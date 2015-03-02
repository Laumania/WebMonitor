using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using WebMonitor.Engine;


namespace WebMonitor.Plugin.Basic
{
    [Export(typeof(IMonitorRule))]
    public class MaxResponseTime : IMonitorRule
    {
        public MonitorRuleResult Execute(Monitor monitor)
        {
            MonitorRuleResult result = new MonitorRuleResult();
            int maxResponseTime = 500; //Todo: remove hardcoded values

            if (!this.IsMaxResponseValid(monitor.ResponseTime, maxResponseTime))
            {
                result.AddMessage("MaxResponse failed(" + maxResponseTime + ") Actual value: " + monitor.ResponseTime);
                result.Status = MonitorStatus.RuleFailed;
            }

            return result;
        }

        //Check the MaxResponseTime rule
        private bool IsMaxResponseValid(double responseTime, int maxResponseTime)
        {
            if ((Convert.ToInt32(responseTime) > maxResponseTime))
            {
                return false;
            }
            else
                return true;
        }
    }
}
