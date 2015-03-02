using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebMonitor.Engine.Plugin;
using System.ComponentModel.Composition;
using WebMonitor.Engine;
using System.Net;
using System.Windows.Controls;
using WebMonitor.Plugins.UI;

namespace WebMonitor.Plugins
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Export(typeof(IMonitorPlugin))]
    public class TestPlugin : IMonitorPlugin
    {
        public void Initialize(Monitor monitor)
        {
            monitor.Pinging += new EventHandler(monitor_Pinging);
            monitor.PingCompleted += new EventHandler(monitor_PingCompleted);
        }

        public void Execute(Monitor monitor, HttpWebRequest request)
        {

        }

        protected void monitor_PingCompleted(object sender, EventArgs e)
        {
            PingResult = "Im just a test plugin, I don't collect any fucking data!";
        }

        protected void monitor_Pinging(object sender, EventArgs e)
        {

        }

        #region Properties
        public string Id
        {
            get { return "TestPlugin"; }
        }

        public string FriendlyName
        {
            get { return "Test plugin"; }
        }

        public string Description
        {
            get { return "Test plugin to try out new stuff with. It doesn't really do anything specific."; }
        }

        public UserControl View { get { return new TestPluginUI(); } }
        public bool Enabled { get; set; }
        public string PingResult { get; private set; }
        #endregion Properties
    }
}
