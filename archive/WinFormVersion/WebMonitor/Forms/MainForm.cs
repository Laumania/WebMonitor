using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Deployment.Application;
using System.IO;
using System.Xml.Serialization;
using System.Threading;
using ZedGraph;
using System.Diagnostics;
using WebMonitor.Engine;
using Monitor = WebMonitor.Engine.Monitor;
using System.ComponentModel.Composition;
using System.Reflection;
using WebMonitor.Plugin;

namespace WebMonitor.Forms
{
    public partial class MainForm : Form
    {
        private CompositionContainer container;
        private MonitorManager monitorManager;
        private int requestsSucceeded;
        private int requestsFailed;
        private delegate void WriteToLog(string text);

        //Test:
        [Import]
        public List<IMonitorRule> RuleList { get; set; }

        public MainForm()
        {
            InitializeComponent();
            InitializeMonitorManager();
            InitializeCompositionContainer();
            InitializeZedGraph();

            requestsSucceeded = 0;
            requestsFailed = 0;
        }
        

        /**************************************************************/
        /*********************** Private Methods  *********************/
        /**************************************************************/
        #region Private Methods
      
        private void InitializeMonitorManager()
        {
            try
            {
                if (Properties.Settings.Default.MonitorManager != null)
                {
                    monitorManager = Properties.Settings.Default.MonitorManager;
                }
                else
                    monitorManager = new MonitorManager();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to load up your old settings.");
                monitorManager = new MonitorManager();
            }
        }

        private void InitializeCompositionContainer()
        {
            if (!Directory.Exists("Plugins"))
                Directory.CreateDirectory("Plugins");

            var catalog = new AggregatingComposablePartCatalog();
            catalog.Catalogs.Add(new DirectoryPartCatalog("Plugins", true));
            catalog.Catalogs.Add(new AttributedAssemblyPartCatalog(typeof(MonitorManager).Assembly));
            catalog.Catalogs.Add(new AttributedAssemblyPartCatalog(Assembly.GetExecutingAssembly()));

            container = new CompositionContainer(catalog.CreateResolver());

            container.AddPart(this);
            //container.AddExportedObject<ICompositionService>(container);
            //container.AddExportedObject<AggregatingComposablePartCatalog>(catalog);

            try
            {
                container.Compose();
            }
            catch (CompositionException compositionException)
            {
                MessageBox.Show(compositionException.ToString());
            }
        }

        private BackgroundWorker CreateMonitorPingWorker()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(updateBackgroundWorker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(updateBackgroundWorker_RunWorkerCompleted);
            worker.ProgressChanged += new ProgressChangedEventHandler(updateBackgroundWorker_ProgressChanged);
            return worker;
        }

        /// <summary>
        /// Saves the MonitorManager and all the Monitors it holds
        /// </summary>
        private void SaveSettings()
        {
            //Saves MonitorManager
            Properties.Settings.Default.MonitorManager = monitorManager;

            //Save settings
            Properties.Settings.Default.Save();

            AppendToLog("Monitor/Settings has been saved.");
        }
                

        private void UpdateInterface()
        {
            //How many monitors are we running at the time
            monitorManagerCountLabel.Text = monitorManager.MonitorCollection.Count.ToString();

            autoPingTimeLabel.Text = "" + (Properties.Settings.Default.AutoPingTime / 1000) / 60;

            MonitorGridDatabind();
        }

        private void AppendToLog(string text)
        {
            if (Properties.Settings.Default.EnableLogging)
            {
                if (InvokeRequired)
                    Invoke(new WriteToLog(OnWriteToLog), "\n" +DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +"\t" + text + "\t");
                else
                    OnWriteToLog("\n" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t" + text + "\t");
            }
        }

        private void OnWriteToLog(string text)
        {
            logRichTextBox.AppendText(text);
            Application.DoEvents();
        }

        private void SetStatusBarText(string text)
        {
            statusToolStripStatusLabel.Text = text;
        }

        private void PingAllMonitors()
        {
            //Setup progressbar
            workerToolStripProgressBar.Visible = true;
            workerToolStripProgressBar.Maximum = monitorManager.MonitorCollection.Count;
            workerToolStripProgressBar.Value = 0;

            //Set status text
            SetStatusBarText("Working...");

            foreach (Monitor monitor in monitorManager.MonitorCollection)
            {
                if (!monitor.Running)
                {
                    BackgroundWorker worker = CreateMonitorPingWorker();
                    //Make the it "work"
                    worker.RunWorkerAsync(monitor);

                    //SetStatusBarText("Updating monitor: " + monitor.Url);
                }
                else
                {
                    SetStatusBarText("Monitor already running: " + monitor.Url);
                }
            }

            //Save LogFile
            if (!String.IsNullOrEmpty(Properties.Settings.Default.LogFilePath) && Properties.Settings.Default.EnableLogging)
                SaveLogFile(Properties.Settings.Default.LogFilePath + @"\WebMonitor_Logfile.txt");

        }

        private void ExportMonitorList(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(MonitorManager));
            xs.Serialize(fs, monitorManager);
            fs.Close();
        }

        private void ImportMonitorList(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(MonitorManager));
            this.monitorManager = (MonitorManager)xs.Deserialize(fs);
            fs.Close();
        }

        /// <summary>
        /// Promt the user with a SaveFileDialog and saves the log as a .txt file
        /// </summary>
        private void SaveLogFile()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save log file";
            dialog.AddExtension = true;
            dialog.DefaultExt = "txt";
            dialog.Filter = "Text File (*.txt)|";
            dialog.ShowDialog();
            SaveLogFile(dialog.FileName);
        }

        private void SaveLogFile(string filePath)
        {
            if (!String.IsNullOrEmpty(filePath))
            {
                try
                {
                    logRichTextBox.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to save file \nError: " + exp.Message, "Unable to save file");
                }
            }
        }

        #endregion


        /**************************************************************/
        /*********************** Worker Events    *********************/
        /**************************************************************/
        #region Worker Events

        private void checkMonitorAsyncButton_Click(System.Object sender, System.EventArgs e)
        {
            if (monitorStatsOverviewDataGridView.SelectedRows[0].Index >= 0)
            {
                // Start the asynchronous operation.
                CreateMonitorPingWorker().RunWorkerAsync(monitorStatsOverviewDataGridView.SelectedRows[0].Index);
                SetStatusBarText("Updating monitor..."); 
            }
            else
                SetStatusBarText("Unable to run that monitor");
        }




        // This event handler is where the actual,
        // potentially time-consuming work is done.
        private void updateBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Assign the result of the computation
            // to the Result property of the DoWorkEventArgs
            // object. This is will be available to the 
            // RunWorkerCompleted eventhandler.
            if (e.Argument is Monitor)
            {
                if (!((Monitor)e.Argument).Running)
                    e.Result = ((Monitor)e.Argument).Ping();
                else
                {
                    SetStatusBarText("Monitor already running: " + ((Monitor)e.Argument).Url);
                    AppendToLog("[" + ((Monitor)e.Argument).Url + "] Already running");
                }
            }
            else if (e.Argument is int)
            {
                if(!monitorManager.MonitorCollection[((int)e.Argument)].Running)
                    e.Result = monitorManager.MonitorCollection[((int)e.Argument)].Ping();
                else
                {
                    
                    SetStatusBarText("Monitor already running: " + monitorManager.MonitorCollection[((int)e.Argument)].Url);
                    AppendToLog("[" + monitorManager.MonitorCollection[((int)e.Argument)].Url + "] Already running");
                }
            }
        }

        private void updateBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled 
                // the operation.
                // Note that due to a race condition in 
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.
                //resultLabel.Text = "Canceled";
                SetStatusBarText("Monitor update cancelled");
            }
            else
            {
                // Finally, handle the case where the operation 
                // succeeded.
                //Don't know if we need a lock here                

                MonitorGridDatabind();
               

                //If the monitor failed
                if (((Monitor)e.Result).Status == MonitorStatus.Down)
                {
                    ShowBalloonTip(0, "Monitor error", (Monitor)e.Result);
                    requestsFailedLabel.Text = "" + requestsFailed++;
                    
                }
                //If ruled failed
                else if (((Monitor)e.Result).Status == MonitorStatus.RuleFailed)
                {
                    ShowBalloonTip(0, "Monitor error", (Monitor)e.Result);
                    requestsFailedLabel.Text = "" + requestsFailed++;
                    
                }
                //Else everything is good
                else if (((Monitor)e.Result).Status == MonitorStatus.Up)
                {
                    requestsSucceededLabel.Text = "" + requestsSucceeded++;
                }


                //Writes to the log
                AppendToLog("Status: " + ((Monitor)e.Result).Status.ToString() + "\tMonitor URL: " + ((Monitor)e.Result).Url +"\tResponse time: " + ((Monitor)e.Result).ResponseTime);
                
                //Update ZedGraph
                CreateGraph(zedGraphControl);

                
            }

            //Update the ProgressBar
            if (workerToolStripProgressBar.Value >= workerToolStripProgressBar.Maximum - 1)
            {
                workerToolStripProgressBar.Visible = false;
                SetStatusBarText("Done");
            }
            else
                workerToolStripProgressBar.PerformStep();

        }

        private void ShowBalloonTip(int showTime, string title, WebMonitor.Engine.Monitor monitor)
        {
            switch (monitor.Status)
            {
                case MonitorStatus.Up:
                    break;
                case MonitorStatus.Down:
                    notifyIcon.ShowBalloonTip(showTime, title, "The monitor: " + monitor.Url + " is not responding.", ToolTipIcon.Error);
                    break;
                case MonitorStatus.RuleFailed:
                    notifyIcon.ShowBalloonTip(showTime, monitor.Url, monitor.InfoText, ToolTipIcon.Warning);
                    break;
                default:
                    break;
            }

            if(Properties.Settings.Default.PlayWarningSound)
                PlayWarningSound();
            
        }

        private void PlayWarningSound()
        {
            Console.Beep(1000, 200);
            Console.Beep(1200, 200);       
        }

        // This event handler updates the progress bar.
        private void updateBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Do something
            SetStatusBarText("Changed...");
        }
        #endregion


        /**************************************************************/
        /*********************** NotiftIcon Events*********************/
        /**************************************************************/
        #region NotiftIcon Events

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        #endregion


        /**************************************************************/
        /*********************** Form Events **************************/
        /**************************************************************/
        #region Form Events

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to want to exit?", "Exit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Do some saving of data here
                SaveSettings();
            }
            else
                e.Cancel = true;
            
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            UpdateInterface();           
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
            }
        }

        #endregion


        /**************************************************************/
        /***********************  Gui/Menu Events **************************/
        /**************************************************************/
        #region Gui/Menu Events
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog(this);
        }

        private void addMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //new AddMonitor(monitorManager.MonitorCollection).ShowDialog(this);
                if (!String.IsNullOrEmpty(addMonitorUrlToolStripTextBox.Text))
                {
                    string url = addMonitorUrlToolStripTextBox.Text.ToLower();

                    // Check if new entry contains protocol, if not then add the default of http
                    if(!url.StartsWith("https:", StringComparison.OrdinalIgnoreCase) && !url.StartsWith("http:", StringComparison.OrdinalIgnoreCase))
                        url = "http://" + url;

                    monitorManager.MonitorCollection.Add(new Monitor(url, "WebMonitor UserAgent; v" + System.Reflection.Assembly.GetExecutingAssembly().GetName(false).Version, RuleList));
                    //Clear the TextBox
                    addMonitorUrlToolStripTextBox.Text = "";
                    MonitorGridDatabind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void MonitorGridDatabind()
        {
            //Todo: Better way to make the Grid refresh
            monitorCollectionBindingSource.DataSource = null;
            monitorCollectionBindingSource.DataSource = monitorManager.MonitorCollection;
        }

        private void addMonitorUrlToolStripTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                addMonitorToolStripMenuItem_Click(sender, e);
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog(this);
        }

        private void submitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.codeplex.com/WebMonitor/WorkItem/List.aspx");
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangeLog().ShowDialog(this);
        }

        private void deleteMonitorButton_Click(object sender, EventArgs e)
        {
            if (monitorStatsOverviewDataGridView.SelectedRows.Count > 0)
                monitorManager.MonitorCollection.RemoveAt(monitorStatsOverviewDataGridView.SelectedRows[0].Index);

            UpdateInterface();
        }        

        private void clearLogButton_Click(object sender, EventArgs e)
        {
            logRichTextBox.Clear();
        }

        private void startMonitoringToolStripButton_Click(object sender, EventArgs e)
        {
            //If the timer doesn't run, we start it
            if (!autopingTimer.Enabled)
            {
                //Start out by pinging all monitors, and then we wait for next Tick from the timer
                PingAllMonitors();
                autopingTimer.Interval = Properties.Settings.Default.AutoPingTime;
                autopingTimer.Start();

                //Set the text on the different buttons
                startMonitoringToolStripButton.Text = "&Stop";
                startMonitoringToolStripButton.Image = Properties.Resources.icon_red.ToBitmap();

                startMonitoringTrayToolStripMenuItem.Text = "&Stop";
                startMonitoringTrayToolStripMenuItem.Image = Properties.Resources.icon_red.ToBitmap();

                notifyIcon.Icon = Properties.Resources.icon_green;
                notifyIcon.Text = "Web Monitor (Running)";
            }
            //If the timer is running we stop it
            else if (autopingTimer.Enabled)
            {
                autopingTimer.Interval = Properties.Settings.Default.AutoPingTime;
                autopingTimer.Stop();
                
                //Set the text on the different buttons
                startMonitoringToolStripButton.Text = "&Start";
                startMonitoringToolStripButton.Image = Properties.Resources.icon_green.ToBitmap();

                startMonitoringTrayToolStripMenuItem.Text = "&Start";
                startMonitoringTrayToolStripMenuItem.Image = Properties.Resources.icon_green.ToBitmap();

                notifyIcon.Icon = Properties.Resources.icon_red;
                notifyIcon.Text = "Web Monitor (Stopped)";
            }
        }

        private void monitorOverviewDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Row.Dispose();
        }

        private void saveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void exportLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveLogFile();
        }

        private void monitorStatsOverviewDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Monitor detailedMonitor = monitorManager.MonitorCollection.GetMonitor(monitorStatsOverviewDataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value.ToString());

            if (detailedMonitor != null)
            {
                AppendToLog("Viewing details for [" + detailedMonitor.Url + "]");
                new MonitorDetails(detailedMonitor).ShowDialog(this);
            }
            else
                AppendToLog("[Monitor Id = " + monitorStatsOverviewDataGridView.SelectedRows[0].Cells[0].Value.ToString() + "] Not found");
        }

        private void monitorStatsOverviewDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Todo: Implement this propertyGrid correctly
            Monitor detailedMonitor = monitorManager.MonitorCollection.GetMonitor(monitorStatsOverviewDataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value.ToString());
            propertyGrid1.SelectedObject = detailedMonitor;
        }

        private void monitorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save monitor list file";
            dialog.AddExtension = true;
            dialog.DefaultExt = "xml";
            dialog.Filter = "Xml File (*.xml)|";
            dialog.ShowDialog();
            if (dialog.FileName != "" && dialog.FileName != null)
            {

                try
                {
                    ExportMonitorList(dialog.FileName);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to save file \nError: " + exp.Message, "Unable to save file");
                }
            }

        }

        private void monitorListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Import monitor list file";
            dialog.AddExtension = true;
            dialog.DefaultExt = "xml";
            dialog.Filter = "Xml File (*.xml)|";
            dialog.ShowDialog();
            if (dialog.CheckFileExists)
            {

                try
                {
                    ImportMonitorList(dialog.FileName);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to save file \nError: " + exp.Message, "Unable to save file");
                }
            }
        }

        private void previewMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(monitorManager.MonitorCollection.GetMonitor(monitorStatsOverviewDataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value.ToString()).Url);
        }

        private void editDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MonitorDetails(monitorManager.MonitorCollection.GetMonitor(monitorStatsOverviewDataGridView.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value.ToString())).ShowDialog(this);
        }


        #endregion


        /**************************************************************/
        /*********************** Timer Ticks **************************/
        /**************************************************************/
        #region Timer Ticks

        private void autoping_Tick(object sender, EventArgs e)
        {
            //Pings all the monitors
            PingAllMonitors();
            //Test
            GC.Collect();

           
        }        

        #endregion


        /**************************************************************/
        /**********************  ZedGraph    **************************/
        /**************************************************************/

        #region ZedGraph Methods


        private void InitializeZedGraph()
        {
            CreateGraph(zedGraphControl);
        }

       
        // Build the Chart
        private void CreateGraph(ZedGraphControl zgc)
        {
            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;
            myPane.XAxis.Type = AxisType.DateAsOrdinal;
            
            //Clear the Graph
            myPane.CurveList.Clear();

            // Set the Titles
            myPane.Title.Text = "WebMonitor Graph";
            myPane.XAxis.Title.Text = "Time";
            myPane.YAxis.Title.Text = "Response time in ms";

            foreach (Monitor monitor in monitorManager.MonitorCollection)
            {
                PointPairList list1 = new PointPairList();

                foreach (MonitorHistoryItem historyItem in monitor.History)
                {
                    if (historyItem.Status == MonitorStatus.Down)
                    {
                        list1.Add(historyItem.UpdatedDateTime.ToOADate(), 0);
                    }
                    else
                    {
                        list1.Add(historyItem.UpdatedDateTime.ToOADate(), historyItem.ResponseTime);
                    }
                }

                if (monitor.Status == MonitorStatus.Down)
                {
                    LineItem myCurve = myPane.AddCurve(monitor.Url, list1, Color.Red, SymbolType.Circle);
                    myCurve.Line.Width = 3;
                    myCurve.Symbol = new Symbol(SymbolType.Star, Color.Red);
                }
                else
                {
                    myPane.AddCurve(monitor.Url, list1, monitor.Color, SymbolType.None);
                }
                
            }

            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zgc.AxisChange();
            //Redraw the graph
            zgc.Invalidate();
        } 

        #endregion

        /**************************************************************/
        /***********************Debug Events **************************/
        /**************************************************************/
        #region Debug Events

        private void fakeCrashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This will make the application crash
            monitorStatsOverviewDataGridView.SelectedRows[-5].ReadOnly = true;
        }

        #endregion

       

        

       

      

      

    }
}