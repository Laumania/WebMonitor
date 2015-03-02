using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using WebMonitor.Engine.Plugin;
using WebMonitor.Engine;
using System.Net;
using System.Windows.Controls;
using WebMonitor.Plugins.UI;

namespace WebMonitor.Plugins
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Export(typeof(IMonitorPlugin))]
    public class ResponseTimePlugin : IMonitorPlugin
    {
        private DateTime startTime;
        private Monitor monitor;

        public void Initialize(Monitor monitor)
        {
            monitor.Pinging += new EventHandler(monitor_Pinging);
            monitor.PingCompleted += new EventHandler(monitor_PingCompleted);
            this.monitor = monitor;
        }

        public void Execute(Monitor monitor, HttpWebRequest request)
        {
            //throw new NotImplementedException();
        }

        protected void monitor_PingCompleted(object sender, EventArgs e)
        {
            double totaltMs = (DateTime.Now - startTime).TotalMilliseconds;
            PingResult = totaltMs.ToString();
        }

        protected void monitor_Pinging(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
        }

        #region Properties
        public string Id
        {
            get { return "ResponseTimePlugin"; }
        }

        public string FriendlyName
        {
            get { return "Response time plugin"; }
        }

        public string Description
        {
            get { return "Measures the response time for the specified Url."; }
        }

        public UserControl View { get { return new ResponseTimeUI(); } }
        public bool Enabled { get; set; }
        public string PingResult { get; private set; }
        #endregion Properties
    }
}
