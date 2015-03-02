namespace WebMonitor.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.patchNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.requestsFailedLabel = new System.Windows.Forms.Label();
            this.requestsSucceededLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.autoPingTimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monitorManagerCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.startMonitoringToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pingSelectedMonitorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.addMonitorUrlToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.addMonitorUrlToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.addQuickMonitorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeMonitorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startMonitoringTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.workerToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.monitorStatsOverviewDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusIcon = new System.Windows.Forms.DataGridViewImageColumn();
            this.InfoText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responseTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AveragePingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorDataGridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zedGraphControl = new ZedGraph.ZedGraphControl();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.monitorStatsTabPage = new System.Windows.Forms.TabPage();
            this.graphTabPage = new System.Windows.Forms.TabPage();
            this.logTabPage = new System.Windows.Forms.TabPage();
            this.mainTabImageList = new System.Windows.Forms.ImageList(this.components);
            this.autopingTimer = new System.Windows.Forms.Timer(this.components);
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.mainMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.trayContextMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorStatsOverviewDataGridView)).BeginInit();
            this.monitorDataGridViewContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorCollectionBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.monitorStatsTabPage.SuspendLayout();
            this.graphTabPage.SuspendLayout();
            this.logTabPage.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(910, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator3,
            this.importToolStripMenuItem,
            this.exportLogToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::WebMonitor.Properties.Resources.disk;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(107, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monitorListToolStripMenuItem1});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // monitorListToolStripMenuItem1
            // 
            this.monitorListToolStripMenuItem1.Name = "monitorListToolStripMenuItem1";
            this.monitorListToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.monitorListToolStripMenuItem1.Text = "Monitor List";
            this.monitorListToolStripMenuItem1.Click += new System.EventHandler(this.monitorListToolStripMenuItem1_Click);
            // 
            // exportLogToolStripMenuItem
            // 
            this.exportLogToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.monitorListToolStripMenuItem});
            this.exportLogToolStripMenuItem.Name = "exportLogToolStripMenuItem";
            this.exportLogToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportLogToolStripMenuItem.Text = "&Export";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.logToolStripMenuItem.Text = "&Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.exportLogToolStripMenuItem_Click);
            // 
            // monitorListToolStripMenuItem
            // 
            this.monitorListToolStripMenuItem.Name = "monitorListToolStripMenuItem";
            this.monitorListToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.monitorListToolStripMenuItem.Text = "Monitor List";
            this.monitorListToolStripMenuItem.Click += new System.EventHandler(this.monitorListToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(107, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.clearLogToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.settingsToolStripMenuItem.Text = "&Tools";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.clearLogToolStripMenuItem.Text = "Clear log";
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogButton_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitToolStripMenuItem,
            this.toolStripSeparator1,
            this.patchNoteToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // submitToolStripMenuItem
            // 
            this.submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            this.submitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.submitToolStripMenuItem.Text = "Submit Issue";
            this.submitToolStripMenuItem.Click += new System.EventHandler(this.submitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // patchNoteToolStripMenuItem
            // 
            this.patchNoteToolStripMenuItem.Name = "patchNoteToolStripMenuItem";
            this.patchNoteToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.patchNoteToolStripMenuItem.Text = "Change Log";
            this.patchNoteToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::WebMonitor.Properties.Resources.information;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.AutoWordSelection = true;
            this.logRichTextBox.CausesValidation = false;
            this.logRichTextBox.DetectUrls = false;
            this.logRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logRichTextBox.HideSelection = false;
            this.logRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.ReadOnly = true;
            this.logRichTextBox.Size = new System.Drawing.Size(677, 665);
            this.logRichTextBox.TabIndex = 2;
            this.logRichTextBox.Text = "";
            this.logRichTextBox.ZoomFactor = 0.9F;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.requestsFailedLabel);
            this.groupBox1.Controls.Add(this.requestsSucceededLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.autoPingTimeLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.monitorManagerCountLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 335);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Web monitor informations";
            // 
            // requestsFailedLabel
            // 
            this.requestsFailedLabel.AutoSize = true;
            this.requestsFailedLabel.Location = new System.Drawing.Point(95, 46);
            this.requestsFailedLabel.Name = "requestsFailedLabel";
            this.requestsFailedLabel.Size = new System.Drawing.Size(13, 13);
            this.requestsFailedLabel.TabIndex = 7;
            this.requestsFailedLabel.Text = "0";
            // 
            // requestsSucceededLabel
            // 
            this.requestsSucceededLabel.AutoSize = true;
            this.requestsSucceededLabel.Location = new System.Drawing.Point(121, 31);
            this.requestsSucceededLabel.Name = "requestsSucceededLabel";
            this.requestsSucceededLabel.Size = new System.Drawing.Size(13, 13);
            this.requestsSucceededLabel.TabIndex = 6;
            this.requestsSucceededLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Failed requests:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Succeeded requests:";
            // 
            // autoPingTimeLabel
            // 
            this.autoPingTimeLabel.AutoSize = true;
            this.autoPingTimeLabel.Location = new System.Drawing.Point(148, 61);
            this.autoPingTimeLabel.Name = "autoPingTimeLabel";
            this.autoPingTimeLabel.Size = new System.Drawing.Size(35, 13);
            this.autoPingTimeLabel.TabIndex = 3;
            this.autoPingTimeLabel.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "AutoPing interval (minutes):";
            // 
            // monitorManagerCountLabel
            // 
            this.monitorManagerCountLabel.AutoSize = true;
            this.monitorManagerCountLabel.Location = new System.Drawing.Point(154, 16);
            this.monitorManagerCountLabel.Name = "monitorManagerCountLabel";
            this.monitorManagerCountLabel.Size = new System.Drawing.Size(35, 13);
            this.monitorManagerCountLabel.TabIndex = 1;
            this.monitorManagerCountLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of running  monitors:";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMonitoringToolStripButton,
            this.pingSelectedMonitorToolStripButton,
            this.toolStripSeparator5,
            this.addMonitorUrlToolStripLabel,
            this.addMonitorUrlToolStripTextBox,
            this.addQuickMonitorToolStripButton,
            this.removeMonitorToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(910, 25);
            this.mainToolStrip.TabIndex = 6;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // startMonitoringToolStripButton
            // 
            this.startMonitoringToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("startMonitoringToolStripButton.Image")));
            this.startMonitoringToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startMonitoringToolStripButton.Name = "startMonitoringToolStripButton";
            this.startMonitoringToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.startMonitoringToolStripButton.Text = "&Start";
            this.startMonitoringToolStripButton.ToolTipText = "Starts the monitoring of all the Monitors in the list";
            this.startMonitoringToolStripButton.Click += new System.EventHandler(this.startMonitoringToolStripButton_Click);
            // 
            // pingSelectedMonitorToolStripButton
            // 
            this.pingSelectedMonitorToolStripButton.Image = global::WebMonitor.Properties.Resources.monitor_lightning;
            this.pingSelectedMonitorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pingSelectedMonitorToolStripButton.Name = "pingSelectedMonitorToolStripButton";
            this.pingSelectedMonitorToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.pingSelectedMonitorToolStripButton.Text = "&Check";
            this.pingSelectedMonitorToolStripButton.ToolTipText = "Check currently selected Monitor";
            this.pingSelectedMonitorToolStripButton.Click += new System.EventHandler(this.checkMonitorAsyncButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // addMonitorUrlToolStripLabel
            // 
            this.addMonitorUrlToolStripLabel.Image = global::WebMonitor.Properties.Resources.monitor_add;
            this.addMonitorUrlToolStripLabel.Name = "addMonitorUrlToolStripLabel";
            this.addMonitorUrlToolStripLabel.Size = new System.Drawing.Size(41, 22);
            this.addMonitorUrlToolStripLabel.Text = "Url:";
            this.addMonitorUrlToolStripLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // addMonitorUrlToolStripTextBox
            // 
            this.addMonitorUrlToolStripTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.addMonitorUrlToolStripTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.addMonitorUrlToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addMonitorUrlToolStripTextBox.Name = "addMonitorUrlToolStripTextBox";
            this.addMonitorUrlToolStripTextBox.Size = new System.Drawing.Size(250, 25);
            this.addMonitorUrlToolStripTextBox.ToolTipText = "Type in the URL of the website you would like to monitor. Click the \"+\" button or" +
                " hit Enter to add the Monitor.";
            this.addMonitorUrlToolStripTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.addMonitorUrlToolStripTextBox_KeyUp);
            // 
            // addQuickMonitorToolStripButton
            // 
            this.addQuickMonitorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addQuickMonitorToolStripButton.Image = global::WebMonitor.Properties.Resources.add;
            this.addQuickMonitorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addQuickMonitorToolStripButton.Name = "addQuickMonitorToolStripButton";
            this.addQuickMonitorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.addQuickMonitorToolStripButton.Text = "&Add";
            this.addQuickMonitorToolStripButton.Click += new System.EventHandler(this.addMonitorToolStripMenuItem_Click);
            // 
            // removeMonitorToolStripButton
            // 
            this.removeMonitorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeMonitorToolStripButton.Image = global::WebMonitor.Properties.Resources.delete;
            this.removeMonitorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeMonitorToolStripButton.Name = "removeMonitorToolStripButton";
            this.removeMonitorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.removeMonitorToolStripButton.Text = "Remove Monitor";
            this.removeMonitorToolStripButton.ToolTipText = "Remove currently selected Monitor";
            this.removeMonitorToolStripButton.Click += new System.EventHandler(this.deleteMonitorButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.trayContextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Web Monitor Tray";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // trayContextMenuStrip
            // 
            this.trayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMonitoringTrayToolStripMenuItem,
            this.settingsToolStripMenuItem2,
            this.exitToolStripMenuItem1});
            this.trayContextMenuStrip.Name = "trayContextMenuStrip";
            this.trayContextMenuStrip.Size = new System.Drawing.Size(162, 70);
            // 
            // startMonitoringTrayToolStripMenuItem
            // 
            this.startMonitoringTrayToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("startMonitoringTrayToolStripMenuItem.Image")));
            this.startMonitoringTrayToolStripMenuItem.Name = "startMonitoringTrayToolStripMenuItem";
            this.startMonitoringTrayToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.startMonitoringTrayToolStripMenuItem.Text = "Start Monitoring";
            this.startMonitoringTrayToolStripMenuItem.Click += new System.EventHandler(this.startMonitoringToolStripButton_Click);
            // 
            // settingsToolStripMenuItem2
            // 
            this.settingsToolStripMenuItem2.Name = "settingsToolStripMenuItem2";
            this.settingsToolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
            this.settingsToolStripMenuItem2.Text = "Settings";
            this.settingsToolStripMenuItem2.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripStatusLabel,
            this.workerToolStripProgressBar});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 744);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(910, 22);
            this.mainStatusStrip.TabIndex = 8;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // statusToolStripStatusLabel
            // 
            this.statusToolStripStatusLabel.Name = "statusToolStripStatusLabel";
            this.statusToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // workerToolStripProgressBar
            // 
            this.workerToolStripProgressBar.Name = "workerToolStripProgressBar";
            this.workerToolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.workerToolStripProgressBar.Step = 1;
            this.workerToolStripProgressBar.Visible = false;
            // 
            // monitorStatsOverviewDataGridView
            // 
            this.monitorStatsOverviewDataGridView.AllowUserToAddRows = false;
            this.monitorStatsOverviewDataGridView.AllowUserToResizeRows = false;
            this.monitorStatsOverviewDataGridView.AutoGenerateColumns = false;
            this.monitorStatsOverviewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.monitorStatsOverviewDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.monitorStatsOverviewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monitorStatsOverviewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.StatusIcon,
            this.InfoText,
            this.urlDataGridViewTextBoxColumn,
            this.responseTimeDataGridViewTextBoxColumn,
            this.AveragePingTime});
            this.monitorStatsOverviewDataGridView.ContextMenuStrip = this.monitorDataGridViewContextMenuStrip;
            this.monitorStatsOverviewDataGridView.DataSource = this.monitorCollectionBindingSource;
            this.monitorStatsOverviewDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monitorStatsOverviewDataGridView.Location = new System.Drawing.Point(3, 3);
            this.monitorStatsOverviewDataGridView.MultiSelect = false;
            this.monitorStatsOverviewDataGridView.Name = "monitorStatsOverviewDataGridView";
            this.monitorStatsOverviewDataGridView.ReadOnly = true;
            this.monitorStatsOverviewDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.monitorStatsOverviewDataGridView.ShowEditingIcon = false;
            this.monitorStatsOverviewDataGridView.Size = new System.Drawing.Size(671, 659);
            this.monitorStatsOverviewDataGridView.TabIndex = 0;
            this.monitorStatsOverviewDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.monitorOverviewDataGridView_UserDeletingRow);
            this.monitorStatsOverviewDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.monitorStatsOverviewDataGridView_CellMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // StatusIcon
            // 
            this.StatusIcon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StatusIcon.DataPropertyName = "StatusIcon";
            this.StatusIcon.FillWeight = 75F;
            this.StatusIcon.HeaderText = "Status";
            this.StatusIcon.Name = "StatusIcon";
            this.StatusIcon.ReadOnly = true;
            this.StatusIcon.Width = 75;
            // 
            // InfoText
            // 
            this.InfoText.DataPropertyName = "InfoText";
            this.InfoText.FillWeight = 46.0439F;
            this.InfoText.HeaderText = "Info";
            this.InfoText.Name = "InfoText";
            this.InfoText.ReadOnly = true;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.FillWeight = 46.0439F;
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // responseTimeDataGridViewTextBoxColumn
            // 
            this.responseTimeDataGridViewTextBoxColumn.DataPropertyName = "ResponseTime";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.responseTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.responseTimeDataGridViewTextBoxColumn.FillWeight = 46.0439F;
            this.responseTimeDataGridViewTextBoxColumn.HeaderText = "Response time (ms)";
            this.responseTimeDataGridViewTextBoxColumn.Name = "responseTimeDataGridViewTextBoxColumn";
            this.responseTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AveragePingTime
            // 
            this.AveragePingTime.DataPropertyName = "AveragePingTime";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.AveragePingTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.AveragePingTime.FillWeight = 46.0439F;
            this.AveragePingTime.HeaderText = "Average pingtime";
            this.AveragePingTime.Name = "AveragePingTime";
            this.AveragePingTime.ReadOnly = true;
            // 
            // monitorDataGridViewContextMenuStrip
            // 
            this.monitorDataGridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRulesToolStripMenuItem,
            this.previewMonitorToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.monitorDataGridViewContextMenuStrip.Name = "monitorDataGridViewContextMenuStrip";
            this.monitorDataGridViewContextMenuStrip.Size = new System.Drawing.Size(116, 70);
            // 
            // editRulesToolStripMenuItem
            // 
            this.editRulesToolStripMenuItem.Name = "editRulesToolStripMenuItem";
            this.editRulesToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.editRulesToolStripMenuItem.Text = "Edit";
            this.editRulesToolStripMenuItem.Click += new System.EventHandler(this.editDetailsToolStripMenuItem_Click);
            // 
            // previewMonitorToolStripMenuItem
            // 
            this.previewMonitorToolStripMenuItem.Name = "previewMonitorToolStripMenuItem";
            this.previewMonitorToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.previewMonitorToolStripMenuItem.Text = "Preview";
            this.previewMonitorToolStripMenuItem.Click += new System.EventHandler(this.previewMonitorToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteMonitorButton_Click);
            // 
            // monitorCollectionBindingSource
            // 
            this.monitorCollectionBindingSource.DataSource = typeof(WebMonitor.Engine.MonitorCollection);
            // 
            // zedGraphControl
            // 
            this.zedGraphControl.BackColor = System.Drawing.SystemColors.Control;
            this.zedGraphControl.DataBindings.Add(new System.Windows.Forms.Binding("IsAntiAlias", global::WebMonitor.Properties.Settings.Default, "UseAntiAlias", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.zedGraphControl.DataBindings.Add(new System.Windows.Forms.Binding("IsSynchronizeXAxes", global::WebMonitor.Properties.Settings.Default, "IsSynchronizeXAxes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.zedGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControl.IsAntiAlias = global::WebMonitor.Properties.Settings.Default.UseAntiAlias;
            this.zedGraphControl.IsEnableVPan = false;
            this.zedGraphControl.IsSynchronizeXAxes = global::WebMonitor.Properties.Settings.Default.IsSynchronizeXAxes;
            this.zedGraphControl.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl.Name = "zedGraphControl";
            this.zedGraphControl.ScrollGrace = 0;
            this.zedGraphControl.ScrollMaxX = 0;
            this.zedGraphControl.ScrollMaxY = 0;
            this.zedGraphControl.ScrollMaxY2 = 0;
            this.zedGraphControl.ScrollMinX = 0;
            this.zedGraphControl.ScrollMinY = 0;
            this.zedGraphControl.ScrollMinY2 = 0;
            this.zedGraphControl.Size = new System.Drawing.Size(671, 659);
            this.zedGraphControl.TabIndex = 0;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mainTabControl.Controls.Add(this.monitorStatsTabPage);
            this.mainTabControl.Controls.Add(this.graphTabPage);
            this.mainTabControl.Controls.Add(this.logTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.ImageList = this.mainTabImageList;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(685, 695);
            this.mainTabControl.TabIndex = 17;
            // 
            // monitorStatsTabPage
            // 
            this.monitorStatsTabPage.Controls.Add(this.monitorStatsOverviewDataGridView);
            this.monitorStatsTabPage.ImageIndex = 0;
            this.monitorStatsTabPage.Location = new System.Drawing.Point(4, 26);
            this.monitorStatsTabPage.Name = "monitorStatsTabPage";
            this.monitorStatsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.monitorStatsTabPage.Size = new System.Drawing.Size(677, 665);
            this.monitorStatsTabPage.TabIndex = 0;
            this.monitorStatsTabPage.Text = "Monitors";
            this.monitorStatsTabPage.UseVisualStyleBackColor = true;
            // 
            // graphTabPage
            // 
            this.graphTabPage.Controls.Add(this.zedGraphControl);
            this.graphTabPage.ImageIndex = 1;
            this.graphTabPage.Location = new System.Drawing.Point(4, 26);
            this.graphTabPage.Name = "graphTabPage";
            this.graphTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.graphTabPage.Size = new System.Drawing.Size(677, 665);
            this.graphTabPage.TabIndex = 1;
            this.graphTabPage.Text = "Graph";
            this.graphTabPage.UseVisualStyleBackColor = true;
            // 
            // logTabPage
            // 
            this.logTabPage.Controls.Add(this.logRichTextBox);
            this.logTabPage.ImageIndex = 2;
            this.logTabPage.Location = new System.Drawing.Point(4, 26);
            this.logTabPage.Name = "logTabPage";
            this.logTabPage.Size = new System.Drawing.Size(677, 665);
            this.logTabPage.TabIndex = 2;
            this.logTabPage.Text = "Log";
            this.logTabPage.UseVisualStyleBackColor = true;
            // 
            // mainTabImageList
            // 
            this.mainTabImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mainTabImageList.ImageStream")));
            this.mainTabImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.mainTabImageList.Images.SetKeyName(0, "application_view_list.png");
            this.mainTabImageList.Images.SetKeyName(1, "chart_curve.png");
            this.mainTabImageList.Images.SetKeyName(2, "book.png");
            // 
            // autopingTimer
            // 
            this.autopingTimer.Interval = global::WebMonitor.Properties.Settings.Default.AutoPingTime;
            this.autopingTimer.Tick += new System.EventHandler(this.autoping_Tick);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(217, 342);
            this.propertyGrid1.TabIndex = 18;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mainTabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(910, 695);
            this.splitContainer1.SplitterDistance = 685;
            this.splitContainer1.TabIndex = 19;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer2.Size = new System.Drawing.Size(221, 695);
            this.splitContainer2.SplitterDistance = 345;
            this.splitContainer2.TabIndex = 20;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Status";
            this.dataGridViewImageColumn1.HeaderText = "Status";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 209;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 766);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Web Monitor";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.trayContextMenuStrip.ResumeLayout(false);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorStatsOverviewDataGridView)).EndInit();
            this.monitorDataGridViewContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monitorCollectionBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.monitorStatsTabPage.ResumeLayout(false);
            this.graphTabPage.ResumeLayout(false);
            this.logTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label monitorManagerCountLabel;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusToolStripStatusLabel;
        private System.Windows.Forms.Timer autopingTimer;
        private System.Windows.Forms.Label autoPingTimeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.DataGridView monitorStatsOverviewDataGridView;
        private System.Windows.Forms.BindingSource monitorCollectionBindingSource;
        private System.Windows.Forms.ToolStripMenuItem submitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip trayContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem startMonitoringTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patchNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton removeMonitorToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitorListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitorListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private ZedGraph.ZedGraphControl zedGraphControl;
        private System.Windows.Forms.DataGridViewImageColumn statusIconDataGridViewImageColumn;
        private System.Windows.Forms.Label requestsFailedLabel;
        private System.Windows.Forms.Label requestsSucceededLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage monitorStatsTabPage;
        private System.Windows.Forms.TabPage graphTabPage;
        private System.Windows.Forms.TabPage logTabPage;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ToolStripTextBox addMonitorUrlToolStripTextBox;
        private System.Windows.Forms.ToolStripButton addQuickMonitorToolStripButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ImageList mainTabImageList;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel addMonitorUrlToolStripLabel;
        private System.Windows.Forms.ContextMenuStrip monitorDataGridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem previewMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton startMonitoringToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton pingSelectedMonitorToolStripButton;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn StatusIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoText;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responseTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AveragePingTime;
        private System.Windows.Forms.ToolStripProgressBar workerToolStripProgressBar;
        private System.Windows.Forms.ToolStripMenuItem editRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem2;
        

    }
}

