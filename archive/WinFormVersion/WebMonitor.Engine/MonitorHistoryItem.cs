using System;
using System.Collections.Generic;
using System.Text;

namespace WebMonitor.Engine
{
    public class MonitorHistoryItem
    {
        private double responseTime;
        private DateTime updatedDateTime;
        private MonitorStatus status;

       

        public MonitorHistoryItem()
        {
        }

        public MonitorHistoryItem(double responseTime, DateTime updatedDateTime, MonitorStatus status)
        {
            this.responseTime = responseTime;
            this.updatedDateTime = updatedDateTime;
            this.status = status;
        }

        #region Properties
        public DateTime UpdatedDateTime
        {
            get { return updatedDateTime; }
            set { updatedDateTime = value; }
        }

        public double ResponseTime
        {
            get { return responseTime; }
            set { responseTime = value; }
        }
        public MonitorStatus Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion
    }
}
