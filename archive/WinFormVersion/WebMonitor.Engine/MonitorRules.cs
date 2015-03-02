using System;
using System.Collections.Generic;
using System.Text;

namespace WebMonitor.Engine
{
    public class MonitorRules
    {
        private int maxResponseTime;
        private string[] wordsListCannot;
        private string[] wordsListMust;        
       
        private Monitor monitor;


        //RunRule bools
        private bool runMaxResponseRule;
        private bool allowRedirects;
        private bool runHtmlContainsText;        
        private bool runCollectHtml;
               

        /// <summary>
        /// Empty constructor
        /// </summary>
        public MonitorRules()
        {
        }

        public MonitorRules(Monitor monitor)
        {
            this.monitor = monitor;

            this.maxResponseTime = 500;
            this.runMaxResponseRule = true;
            this.runCollectHtml = false;
            this.allowRedirects = true;
            this.runHtmlContainsText = false;
            this.wordsListCannot = new string[0];
            this.wordsListMust = new string[0];
        }


        /**************************************************/
        /*****************Rule Methods*********************/
        /**************************************************/

        #region Rule Methods

        //Check the MaxResponseTime rule
        public bool IsMaxResponseValid(double responseTime)
        {
            if ((Convert.ToInt32(responseTime) > this.maxResponseTime))
            {
                return false;
            }
            else
                return true; 
        }

        public bool ContainsWordInHtml(string word,string html)
        {              
            if (html.Contains(word))
                return true;
            else
                return false;
                     
        }

        #endregion

        #region Properties
              

        public bool RunMaxResponseRule
        {
            get { return runMaxResponseRule; }
            set { runMaxResponseRule = value; }
        }

        public bool RunHtmlContainsText
        {
            get { return runHtmlContainsText; }
            set { runHtmlContainsText = value; }
        }

        public bool RunCollectHtml
        {
            get { return runCollectHtml; }
            set { runCollectHtml = value; }
        }

        public bool AllowRedirect
        {
        get { return allowRedirects; }
        set { allowRedirects = value; }
        }

        public int MaxResponseTime
        {
            get { return maxResponseTime; }
            set { maxResponseTime = value; }
        }

        public string[] WordsListCannot
        {
            get { return wordsListCannot; }
            set { wordsListCannot = value; }
        }

        public string[] WordsListMust
        {
            get { return wordsListMust; }
            set { wordsListMust = value; }
        }

        #endregion
    }
}
