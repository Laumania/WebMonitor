using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WebMonitor.Engine;
using System.ServiceProcess;

namespace WebMonitor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MonitorManager monitorManager;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        protected void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            monitorManager = new MonitorManager();
            monitorManager.Initialize();

            PluginsComboBox.DataContext = monitorManager.Plugins;
            PluginsComboBox.DisplayMemberPath = "FriendlyName";
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            monitorManager.LoadMonitors();
            MonitorsListBox.ItemsSource = monitorManager.Monitors;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            monitorManager.Add(monitorManager.CreateMonitor(DateTime.Now.ToString(), "http://laumania.net"));
            monitorManager.SaveMonitors();
            MonitorsListBox.ItemsSource = monitorManager.Monitors;
        }

        static int command = 128;

        //[ServiceControllerPermission(System.Security.Permissions.SecurityAction.Assert,PermissionAccess = ServiceControllerPermissionAccess.Control, ServiceName="",Unrestricted=true)]
        private void switchServiceButton_Click(object sender, RoutedEventArgs e)
        {
            ServiceController sc = new ServiceController("webmonitor");

            if (sc.Status == ServiceControllerStatus.Running)
            {
                sc.Stop();
                sc.WaitForStatus(ServiceControllerStatus.Stopped);
                serviceStatus.Text = sc.Status.ToString();
            }
            else
            {
                sc.Start();
                sc.WaitForStatus(ServiceControllerStatus.Running);
                sc.ExecuteCommand(command++);
                serviceStatus.Text = sc.Status.ToString();
            }
        }

        private void MonitorsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Monitor m = e.AddedItems[0] as Monitor;

            if (m != null)
                monitorPluginListBox.ItemsSource = m.Plugins;
        }

        private void PingButton_Click(object sender, RoutedEventArgs e)
        {
            monitorManager.PingMonitors();
        }
    }
}
