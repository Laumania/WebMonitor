using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using WebMonitor.Engine.Plugin;
using System.ComponentModel.Composition;

namespace WebMonitor.Engine
{
    public class Monitor : IPartImportsSatisfiedNotification
    {
        public event EventHandler Pinging;
        public event EventHandler PingCompleted;
        public event EventHandler PingFailed;

        #region Constructors
        /// <summary>
        /// Needed when loading/saving
        /// </summary>
        internal Monitor() : this(string.Empty)
        {
        }

        /// <summary>
        /// Monitors can only be instanciated through the MonitorManager
        /// </summary>
        /// <param name="url"></param>
        internal Monitor(string url)
        {
            Url = url;
            Id = Guid.NewGuid();
            Plugins = new List<IMonitorPlugin>();
        } 
        #endregion

        public MonitorPingResult Ping()
        {
            HttpWebRequest request = null;
            MonitorPingResult result = null;
            try
            {
                //************ SETUP REQUEST ****************//
                result = new MonitorPingResult();
                request = (HttpWebRequest)WebRequest.Create(Url);
                request.Method = "HEAD"; //According to this, we should use HEAD in most cases: http://www.dscoduc.com/2009/04/choose-your-http-requests-wisely/

                //************ HANDLE RESPONSE ****************//
                // Create a new 'HttpWebRequest' Object to the mentioned URL.
                OnPinging();
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)request.GetResponse();
                OnPingCompleted();

                // Check if StatusCode is OK, else throw exception
                if (myHttpWebResponse.StatusCode != HttpStatusCode.OK)
                    throw new Exception(myHttpWebResponse.StatusDescription);

                //Run through all the monitors plugins, so they can act upon the succeeded request
                foreach (IMonitorPlugin plugin in Plugins)
                {
                    plugin.Execute(this, request);
                }

                //Everything went good
                result.Succeeded = true;
            }
            catch (Exception exp)
            {
                result.Error = exp;
                result.Succeeded = false;

                //Todo: Not suere this is the right place to put this
                OnPingFailed();
            }
            finally
            {
                //Clean up
                if (request != null)
                    request.Abort();

                request = null;
            }

            return result;
        }


        public void OnImportsSatisfied()
        {
            foreach (IMonitorPlugin plugin in Plugins)
            {
                //We need to let all the plugins know the monitor that they are attached to
                plugin.Initialize(this);
            }
        }


        private void OnPinging()
        {
            if (Pinging != null)
                Pinging(this, null);
        }

        private void OnPingCompleted()
        {
            if (PingCompleted != null)
                PingCompleted(this, null);
        }

        private void OnPingFailed()
        {
            if (PingFailed != null)
                PingFailed(this, null);
        }

        

        #region Properties
        public Guid Id { get; internal set; }
        public string Url { get; set; }
        public string Name { get; set; }
        [ImportMany(typeof(IMonitorPlugin))]
        public IList<IMonitorPlugin> Plugins { get; internal set; }
        #endregion Properties

       
    }
}
