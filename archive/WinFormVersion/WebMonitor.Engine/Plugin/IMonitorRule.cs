using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebMonitor.Engine;

namespace WebMonitor.Plugin
{
    public interface IMonitorRule
    {
        MonitorRuleResult Execute(Monitor monitor);
    }
}
