using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using System.Windows.Controls;

namespace WebMonitor.Engine.Plugin
{
    public interface IMonitorPlugin
    {
        //Methods
        void Initialize(Monitor monitor);
        void Execute(Monitor monitor, HttpWebRequest request);
        
        //Properties
        string Id { get; }
        string FriendlyName { get; }
        string Description { get; }
        bool Enabled { get; set; }
        UserControl View { get; }
        string PingResult { get; }
    }
}
