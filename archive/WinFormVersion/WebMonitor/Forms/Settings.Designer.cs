namespace WebMonitor.Forms
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingTabControl = new System.Windows.Forms.TabControl();
            this.generelTabPage = new System.Windows.Forms.TabPage();
            this.warningsoundCheckBox = new System.Windows.Forms.CheckBox();
            this.generelEnableLoggingCheckBox = new System.Windows.Forms.CheckBox();
            this.autoPingTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.settingsAutoPingTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.graphTabPage = new System.Windows.Forms.TabPage();
            this.synchronizeXAxesCheckBox = new System.Windows.Forms.CheckBox();
            this.antiAliasCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.historiSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.applySettingsButton = new System.Windows.Forms.Button();
            this.logFilePathTextBox = new System.Windows.Forms.TextBox();
            this.logFilePathBrowseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.logFileFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.settingTabControl.SuspendLayout();
            this.generelTabPage.SuspendLayout();
            this.autoPingTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsAutoPingTimeNumericUpDown)).BeginInit();
            this.graphTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historiSizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // settingTabControl
            // 
            this.settingTabControl.Controls.Add(this.generelTabPage);
            this.settingTabControl.Controls.Add(this.autoPingTabPage);
            this.settingTabControl.Controls.Add(this.graphTabPage);
            this.settingTabControl.Location = new System.Drawing.Point(12, 12);
            this.settingTabControl.Name = "settingTabControl";
            this.settingTabControl.SelectedIndex = 0;
            this.settingTabControl.Size = new System.Drawing.Size(383, 497);
            this.settingTabControl.TabIndex = 0;
            // 
            // generelTabPage
            // 
            this.generelTabPage.Controls.Add(this.label3);
            this.generelTabPage.Controls.Add(this.logFilePathBrowseButton);
            this.generelTabPage.Controls.Add(this.logFilePathTextBox);
            this.generelTabPage.Controls.Add(this.warningsoundCheckBox);
            this.generelTabPage.Controls.Add(this.generelEnableLoggingCheckBox);
            this.generelTabPage.Location = new System.Drawing.Point(4, 22);
            this.generelTabPage.Name = "generelTabPage";
            this.generelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generelTabPage.Size = new System.Drawing.Size(375, 471);
            this.generelTabPage.TabIndex = 0;
            this.generelTabPage.Text = "Generel";
            this.generelTabPage.UseVisualStyleBackColor = true;
            // 
            // warningsoundCheckBox
            // 
            this.warningsoundCheckBox.AutoSize = true;
            this.warningsoundCheckBox.Checked = global::WebMonitor.Properties.Settings.Default.PlayWarningSound;
            this.warningsoundCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WebMonitor.Properties.Settings.Default, "PlayWarningSound", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.warningsoundCheckBox.Location = new System.Drawing.Point(17, 73);
            this.warningsoundCheckBox.Name = "warningsoundCheckBox";
            this.warningsoundCheckBox.Size = new System.Drawing.Size(182, 17);
            this.warningsoundCheckBox.TabIndex = 1;
            this.warningsoundCheckBox.Text = "Play warning sound (PC-speaker)";
            this.warningsoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // generelEnableLoggingCheckBox
            // 
            this.generelEnableLoggingCheckBox.AutoSize = true;
            this.generelEnableLoggingCheckBox.Checked = global::WebMonitor.Properties.Settings.Default.EnableLogging;
            this.generelEnableLoggingCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WebMonitor.Properties.Settings.Default, "EnableLogging", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.generelEnableLoggingCheckBox.Location = new System.Drawing.Point(17, 18);
            this.generelEnableLoggingCheckBox.Name = "generelEnableLoggingCheckBox";
            this.generelEnableLoggingCheckBox.Size = new System.Drawing.Size(100, 17);
            this.generelEnableLoggingCheckBox.TabIndex = 0;
            this.generelEnableLoggingCheckBox.Text = "Enable Logging";
            this.generelEnableLoggingCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoPingTabPage
            // 
            this.autoPingTabPage.Controls.Add(this.groupBox1);
            this.autoPingTabPage.Location = new System.Drawing.Point(4, 22);
            this.autoPingTabPage.Name = "autoPingTabPage";
            this.autoPingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.autoPingTabPage.Size = new System.Drawing.Size(375, 471);
            this.autoPingTabPage.TabIndex = 1;
            this.autoPingTabPage.Text = "AutoPing";
            this.autoPingTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.settingsAutoPingTimeNumericUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Ping Interval";
            // 
            // settingsAutoPingTimeNumericUpDown
            // 
            this.settingsAutoPingTimeNumericUpDown.CausesValidation = false;
            this.settingsAutoPingTimeNumericUpDown.Location = new System.Drawing.Point(148, 26);
            this.settingsAutoPingTimeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.settingsAutoPingTimeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.settingsAutoPingTimeNumericUpDown.Name = "settingsAutoPingTimeNumericUpDown";
            this.settingsAutoPingTimeNumericUpDown.ReadOnly = true;
            this.settingsAutoPingTimeNumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.settingsAutoPingTimeNumericUpDown.TabIndex = 2;
            this.settingsAutoPingTimeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Auto Ping Interval(minutes):";
            // 
            // graphTabPage
            // 
            this.graphTabPage.Controls.Add(this.synchronizeXAxesCheckBox);
            this.graphTabPage.Controls.Add(this.antiAliasCheckBox);
            this.graphTabPage.Controls.Add(this.label2);
            this.graphTabPage.Controls.Add(this.historiSizeNumericUpDown);
            this.graphTabPage.Location = new System.Drawing.Point(4, 22);
            this.graphTabPage.Name = "graphTabPage";
            this.graphTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.graphTabPage.Size = new System.Drawing.Size(375, 471);
            this.graphTabPage.TabIndex = 2;
            this.graphTabPage.Text = "Graph";
            this.graphTabPage.UseVisualStyleBackColor = true;
            // 
            // synchronizeXAxesCheckBox
            // 
            this.synchronizeXAxesCheckBox.AutoSize = true;
            this.synchronizeXAxesCheckBox.Checked = global::WebMonitor.Properties.Settings.Default.IsSynchronizeXAxes;
            this.synchronizeXAxesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WebMonitor.Properties.Settings.Default, "IsSynchronizeXAxes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.synchronizeXAxesCheckBox.Location = new System.Drawing.Point(20, 68);
            this.synchronizeXAxesCheckBox.Name = "synchronizeXAxesCheckBox";
            this.synchronizeXAxesCheckBox.Size = new System.Drawing.Size(117, 17);
            this.synchronizeXAxesCheckBox.TabIndex = 7;
            this.synchronizeXAxesCheckBox.Text = "Synchronize XAxes";
            this.synchronizeXAxesCheckBox.UseVisualStyleBackColor = true;
            // 
            // antiAliasCheckBox
            // 
            this.antiAliasCheckBox.AutoSize = true;
            this.antiAliasCheckBox.Checked = global::WebMonitor.Properties.Settings.Default.UseAntiAlias;
            this.antiAliasCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WebMonitor.Properties.Settings.Default, "UseAntiAlias", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.antiAliasCheckBox.Location = new System.Drawing.Point(20, 45);
            this.antiAliasCheckBox.Name = "antiAliasCheckBox";
            this.antiAliasCheckBox.Size = new System.Drawing.Size(159, 17);
            this.antiAliasCheckBox.TabIndex = 6;
            this.antiAliasCheckBox.Text = "Use Anti Alias to draw graph";
            this.antiAliasCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Monitor History Size";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // historiSizeNumericUpDown
            // 
            this.historiSizeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::WebMonitor.Properties.Settings.Default, "MonitorHistorySize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.historiSizeNumericUpDown.Location = new System.Drawing.Point(20, 19);
            this.historiSizeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.historiSizeNumericUpDown.Name = "historiSizeNumericUpDown";
            this.historiSizeNumericUpDown.ReadOnly = true;
            this.historiSizeNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.historiSizeNumericUpDown.TabIndex = 4;
            this.historiSizeNumericUpDown.Value = global::WebMonitor.Properties.Settings.Default.MonitorHistorySize;
            // 
            // applySettingsButton
            // 
            this.applySettingsButton.Location = new System.Drawing.Point(320, 515);
            this.applySettingsButton.Name = "applySettingsButton";
            this.applySettingsButton.Size = new System.Drawing.Size(75, 23);
            this.applySettingsButton.TabIndex = 1;
            this.applySettingsButton.Text = "Apply";
            this.applySettingsButton.UseVisualStyleBackColor = true;
            this.applySettingsButton.Click += new System.EventHandler(this.applySettingsButton_Click);
            // 
            // logFilePathTextBox
            // 
            this.logFilePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WebMonitor.Properties.Settings.Default, "LogFilePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.logFilePathTextBox.Location = new System.Drawing.Point(85, 41);
            this.logFilePathTextBox.Name = "logFilePathTextBox";
            this.logFilePathTextBox.Size = new System.Drawing.Size(250, 20);
            this.logFilePathTextBox.TabIndex = 2;
            this.logFilePathTextBox.Text = global::WebMonitor.Properties.Settings.Default.LogFilePath;
            // 
            // logFilePathBrowseButton
            // 
            this.logFilePathBrowseButton.Location = new System.Drawing.Point(341, 41);
            this.logFilePathBrowseButton.Name = "logFilePathBrowseButton";
            this.logFilePathBrowseButton.Size = new System.Drawing.Size(28, 23);
            this.logFilePathBrowseButton.TabIndex = 3;
            this.logFilePathBrowseButton.Text = "...";
            this.logFilePathBrowseButton.UseVisualStyleBackColor = true;
            this.logFilePathBrowseButton.Click += new System.EventHandler(this.logFilePathBrowseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Logfile path:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 541);
            this.Controls.Add(this.applySettingsButton);
            this.Controls.Add(this.settingTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.settingTabControl.ResumeLayout(false);
            this.generelTabPage.ResumeLayout(false);
            this.generelTabPage.PerformLayout();
            this.autoPingTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsAutoPingTimeNumericUpDown)).EndInit();
            this.graphTabPage.ResumeLayout(false);
            this.graphTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historiSizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl settingTabControl;
        private System.Windows.Forms.TabPage generelTabPage;
        private System.Windows.Forms.TabPage autoPingTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button applySettingsButton;
        private System.Windows.Forms.CheckBox generelEnableLoggingCheckBox;
        private System.Windows.Forms.NumericUpDown settingsAutoPingTimeNumericUpDown;
        private System.Windows.Forms.CheckBox warningsoundCheckBox;
        private System.Windows.Forms.TabPage graphTabPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown historiSizeNumericUpDown;
        private System.Windows.Forms.CheckBox antiAliasCheckBox;
        private System.Windows.Forms.CheckBox synchronizeXAxesCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logFilePathBrowseButton;
        private System.Windows.Forms.TextBox logFilePathTextBox;
        private System.Windows.Forms.FolderBrowserDialog logFileFolderBrowserDialog;

    }
}