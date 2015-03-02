using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel;
using WebMonitor.Plugin;
using System.ComponentModel.Composition;

namespace WebMonitor.Engine
{
    [Serializable]
    public class Monitor
    {
        #region private declarations
        //Setup
        private int historySize;
        private MonitorPingResult monitorPingResult;

        private string url;
        private string userAgent;        
        private DateTime lastUpdated;
        private HttpWebRequest request;
        private Guid id;
        private MonitorStatus status;
        private double responseTime;
        private bool running;
        private MonitorRules rules;        
        private string infoText;
        private int pingNo;
        private double totaltPingTime;
        private int colorAsInt;       

        //HttpRequest fields
        private string statusCode;
        private string statusDescription;
        private string responseUri;
        private string responseContentType;
        private string responseHtml;
        private string username;       
        private string password;
        private List<MonitorHistoryItem> history;
        private WebProxy proxy;
        #endregion // private declarations

        #region public declarations
        //Test - Maybe we could use a Dictionary<string, object> to pass information between Monitor and rules. 
        //Just and quick idea.
        public List<IMonitorRule> RuleList { get; set; }
        #endregion // public declarations

        #region Contructors
        public Monitor() : this("", "", null) { }

        /// <summary>
        /// This contructor is created when adding the Monitor the first time
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userAgent"></param>
        public Monitor(string url, string userAgent, List<IMonitorRule> ruleList)
        {
            this.request = (HttpWebRequest)WebRequest.Create(url);
            this.userAgent = userAgent;
            this.lastUpdated = DateTime.Now;
            this.url = url;
            this.id = Guid.NewGuid();
            this.running = false;
            this.rules = new MonitorRules(this);
            this.infoText = "Monitor hasn't been started yet";
            this.pingNo = 0;
            this.totaltPingTime = 0;
            this.history = new List<MonitorHistoryItem>(historySize);
            this.colorAsInt = Color.Blue.ToArgb();
            this.RuleList = ruleList;
            this.monitorPingResult = new MonitorPingResult();

            //HttpRequest fields
            this.statusCode = "";
            this.statusDescription = "";
            this.responseUri = "";
            this.responseContentType = "";
            this.responseHtml = "";
            this.username = "";
            this.password = "";
            this.proxy = new WebProxy();
        } 
        #endregion

        public Monitor Ping()
        {
            //Return a MonitorReponse here with all the data
            //This method needs to be updateted and optimized

            DateTime dtStart = DateTime.Now;
            this.infoText = "Success";
            
            //Todo: This were removed due to extracting engine from main app - put it back in somehow
            //this.HistorySize = Properties.Settings.Default.MonitorHistorySize; 

            try
            {
                //************ SETUP REQUEST ****************//

                running = true;//This is used to prevent another check to start, if one is already running.
                request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = this.userAgent;
                
                // If RunCollectHtml is disabled then perform HEAD request instead of GET request
                if (!this.rules.RunCollectHtml)
                    request.Method = "HEAD";

                // Check if AllowAutoRedirect is enabled or not...
                request.AllowAutoRedirect = this.rules.AllowRedirect;

                // Ignore Certificate validation failures (ex. untrusted certificate/certificate chains)
                ServicePointManager.ServerCertificateValidationCallback = ((sender, certificate, chain, sslPolicyErrors) => true); 

                // Check if UserName is empty - User might want to pass a blank Password so send current value
                if(!string.IsNullOrEmpty(this.username))
                    request.Credentials = new NetworkCredential(this.username, this.password);

                // Check if proxy has been specified
                if (this.proxy.Address != null)
                    request.Proxy = this.proxy;

                //************ HANDLE RESPONSE ****************//

                // Create a new 'HttpWebRequest' Object to the mentioned URL.
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)request.GetResponse();
                
                this.statusCode = myHttpWebResponse.StatusCode.ToString();
                this.statusDescription = myHttpWebResponse.StatusDescription;
                this.responseUri = myHttpWebResponse.ResponseUri.ToString();
                this.responseContentType = myHttpWebResponse.ContentType;

                // Check if StatusCode is OK, else throw exception
                if (myHttpWebResponse.StatusCode != HttpStatusCode.OK)
                    throw new Exception(myHttpWebResponse.StatusDescription);

                //Everything went well, let's save the response time
                TimeSpan ts = DateTime.Now - dtStart;
                this.responseTime = ts.TotalMilliseconds;

                // Check if RunCollectHtml is enabled
                if(this.rules.RunCollectHtml)
                    this.responseHtml = CollectHTML(myHttpWebResponse); 
                
                //Saves the totaltPingTime for use with avg. ping time
                this.totaltPingTime += this.responseTime;
                this.pingNo++;

                this.lastUpdated = DateTime.Now;

                //Every thing was good do far. The server is up.
                this.status = MonitorStatus.Up;

                //Run the rules set in this monitor, and set the Status and infoText
                this.RunRules();

                // Update historical log
                AddToHistory();
            }
            catch (Exception exp)
            {
                this.responseTime = 0;
                this.status = MonitorStatus.Down;
                this.infoText = "Failed: " + exp.Message;

                AddToHistory();
            }
            finally
            {
                running = false;
                if (request != null)
                    request.Abort();
            }

            return this;
        }

        private void AddToHistory()
        {
            //Save data to history for this monitor
            history.Add(new MonitorHistoryItem(this.responseTime, DateTime.Now, this.status));
        }


        private string CollectHTML(HttpWebResponse myHttpWebResponse)
        {
            // Print the HTML contents of the page to the console. 
            Stream streamResponse = myHttpWebResponse.GetResponseStream();
            StreamReader streamRead = new StreamReader(streamResponse);
            StringBuilder html = new StringBuilder();

            Char[] readBuff = new Char[256];
            int count = streamRead.Read(readBuff, 0, 256);
            while (count > 0)
            {
                String outputData = new String(readBuff, 0, count);
                html.Append(outputData);
                count = streamRead.Read(readBuff, 0, 256);
            }
            
            return html.ToString();
        }


        /// <summary>
        /// Runs the rules the user have specified
        /// </summary>
        private void RunRules()
        {
            if (RuleList != null)
            {
                foreach (IMonitorRule rule in RuleList)
                {
                    MonitorRuleResult result = rule.Execute(this);

                    if (result.Messages.Count > 0)
                    {
                        foreach (string item in result.Messages)
                        {
                            this.infoText += item;
                        }
                        this.status = result.Status;
                    }
                }
            }



            //If the rule fails
            //if (!this.rules.IsMaxResponseValid(this.responseTime) && this.rules.RunMaxResponseRule)
            //{
            //    this.infoText = "MaxResponse failed(" + this.Rules.MaxResponseTime + ") Actual value: " + this.responseTime;
            //    this.status = MonitorStatus.RuleFailed;
            //}

            //Check if the HTML contains or dont contain some words
            //if (this.rules.RunHtmlContainsText)
            //{
            //    bool approved = true;
            //    string badWords = "";

            //    //MUST contatin
            //    for (int i = 0; i < this.rules.WordsListMust.Length; i++)
            //    {
            //        if (this.rules.WordsListMust[i].ToString().Trim() != "")
            //        {
            //            approved = this.rules.ContainsWordInHtml(this.rules.WordsListMust[i].ToString(), this.responseHtml);

            //            if (!approved)
            //                badWords += this.rules.WordsListMust[i].ToString() + " ";
            //        }
            //    }

            //    //CANNOT contain
            //    for (int i = 0; i < this.rules.WordsListCannot.Length; i++)
            //    {
            //        if (this.rules.WordsListCannot[i].ToString().Trim() != "")
            //        {
            //            approved = !this.rules.ContainsWordInHtml(this.rules.WordsListCannot[i].ToString(), this.responseHtml);

            //            if (!approved)
            //                badWords += this.rules.WordsListCannot[i].ToString() + " ";
            //        }
            //    }


            //    if (!approved)
            //    {
            //        this.infoText = "HTMLCheckWords failed: " +badWords;
            //        this.status = MonitorStatus.RuleFailed;
            //    }
                              
            //}
        }

        #region Properties

        #region HttpRequest fields

        [XmlIgnore]
        [Category("Request")]
        [ReadOnly(true)]
        public string InfoText
        {
            get { return infoText; }
            set { infoText = value; }
        }

        [Category("Request")]
        [ReadOnly(true)]
        public DateTime LastUpdated
        {
            get { return lastUpdated; }
            set { lastUpdated = value; }
        }

        [Category("Request")] 
        [ReadOnly(true)]
        public double ResponseTime
        {
            get { return responseTime; }
            set { responseTime = value; }
        }

        [Category("Request")] 
        public string StatusCode
        {
            get { return statusCode; }
        }
        [Category("Request")] 
        public string StatusDescription
        {
            get { return statusDescription; }
        }
        [Category("Request")] 
        public string ResponseUri
        {
            get { return responseUri; }
        }
        [Category("Request")] 
        public string ResponseContentType
        {
            get { return responseContentType; }
        }
        [Category("Request")] 
        public string ResponseHtml
        {
            get { return responseHtml; }
        }

        [Category("Request")]
        public double AveragePingTime
        {
            get { return this.totaltPingTime / this.pingNo; }
        }

        [XmlIgnore]
        [Browsable(false)]
        public WebProxy ProxySettings
        {
            get { return this.proxy; }
            set { this.proxy = value; }
        }
        
        #endregion

        #region General

        [XmlIgnore]
        [Category("General")]
        [ReadOnly(true)]
        public MonitorStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        [Category("General")]
        [ReadOnly(true)]
        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }

        [Category("General")] 
        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        
        [Category("General")]
        [ReadOnly(true)]
        public Icon StatusIcon
        {
            get
            {
                switch (status)
                {
                    case MonitorStatus.Up:
                        return Properties.Resources.up_server;
                    case MonitorStatus.Down:
                        return Properties.Resources.down_server;
                    default:
                        return Properties.Resources.warning;
                }

            }

        }

        [Category("General")] 
        public string UserAgent
        {
            get { return userAgent; }
            set { userAgent = value; }
        }
       


        [XmlIgnore]
        [Browsable(false)]
        [Category("General")]
        public bool Running
        {
            get { return running; }
        }

        [Browsable(false)]
        [Category("General")]
        public MonitorRules Rules
        {
            get { return rules; }
            set { rules = value; }
        }

        #endregion

        #region Cridentials
        [Category("Cridentials")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        [Category("Cridentials")]
        public string Username
        {
            get { return username; }
            set { username = value; }
        } 
        #endregion

        #region Graph 

        [Browsable(false)]
        [Category("Graph")]
        public int ColorAsInt
        {
            get { return colorAsInt; }
            set { colorAsInt = value; }
        }

        [XmlIgnore]
        [Category("Graph")]
        public Color Color
        {
            get
            {
                return Color.FromArgb(colorAsInt);
            }
            set { colorAsInt = value.ToArgb(); }
        }

        [XmlIgnore]
        [Browsable(false)]
        [Category("Graph")]
        public List<MonitorHistoryItem> History
        {
            get
            {
                if (history.Count > historySize)
                    history.RemoveRange(0, history.Count - historySize);

                return history;
            }
            set { history = value; }
        }

        [Category("Graph")]
        public int HistorySize
        {
            get { return historySize; }
            set 
            { 
                historySize = value;

                if (historySize < history.Capacity)
                    history.Clear();
             
                history.Capacity = historySize;
            }
        }

        #endregion
 
        #endregion
    }
}
