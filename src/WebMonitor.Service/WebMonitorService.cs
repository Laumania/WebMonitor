using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.IO;
using System.Threading;

namespace WebMonitor.Service
{
    public partial class WebMonitorService : ServiceBase
    {
        string filename = @"c:\test\webmonitor.txt";
        private bool running;
        Thread thread;

        public WebMonitorService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //Thread.Sleep(10000);

            if (File.Exists(filename))
                File.Delete(filename);

            using (StreamWriter writer = new StreamWriter(filename, true))
                writer.WriteLine("start " + DateTime.Now.ToString());

            running = true;

            thread  = new Thread(new ThreadStart(go));
            thread.Start();

        }

        private void go()
        {
            while (running)
            {
                using (StreamWriter writer = new StreamWriter(filename, true))
                    writer.WriteLine("go " + DateTime.Now.ToString());

                Thread.Sleep(100);
            }
        }

        protected override void OnCustomCommand(int command)
        {
            using (StreamWriter writer = new StreamWriter(filename, true))
                writer.WriteLine("command " + command);

            //base.OnCustomCommand(command);
        }

        protected override void OnStop()
        {
            running = false;

            using (StreamWriter writer = new StreamWriter(filename, true))
                writer.WriteLine("stop " + DateTime.Now.ToString());
        }
    }
}
