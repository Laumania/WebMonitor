using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebMonitor.Plugin
{
    public class MonitorRuleResult
    {
        public List<string> Messages { get; set; }
        public MonitorStatus Status { get; set; }


        public MonitorRuleResult()
        {
            Messages = new List<string>();
            Status = MonitorStatus.Up;
        }

        public void AddMessage(string text)
        {
            Messages.Add(text);
        }
    }
}
