using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WebMonitor.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            int saveAutoTimerinterval = (Properties.Settings.Default.AutoPingTime / 1000) / 60;
            
            if(saveAutoTimerinterval <= 0)
                settingsAutoPingTimeNumericUpDown.Value = 1;
            else
                settingsAutoPingTimeNumericUpDown.Value = saveAutoTimerinterval;
                                 
        }

        private void applySettingsButton_Click(object sender, EventArgs e)
        {
            //Save the settings here
            int newAutoPingTimeinMinutes = (Convert.ToInt32(settingsAutoPingTimeNumericUpDown.Value) * 60) * 1000;

            if (newAutoPingTimeinMinutes >= 1)
                Properties.Settings.Default.AutoPingTime = newAutoPingTimeinMinutes;
            else
                Properties.Settings.Default.AutoPingTime = 1;


            //Save alle properties
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();

            this.Dispose();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void logFilePathBrowseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = logFileFolderBrowserDialog.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                logFilePathTextBox.Text = logFileFolderBrowserDialog.SelectedPath;
            }
        }
           
    }
}