using System;

namespace WebMonitor.Engine
{
    [Serializable]
    public class MonitorManager
    {
        private MonitorCollection monitorCollection;

        public MonitorManager()
        {
            monitorCollection = new MonitorCollection();
        }

        #region Properties

        public MonitorCollection MonitorCollection
        {
            get { return monitorCollection; }
            set { monitorCollection = value; }
        }

        #endregion
    }
}
