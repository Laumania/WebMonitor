namespace WebMonitor
{
    partial class MonitorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorDetails));
            this.monitorDetailsTabControl = new System.Windows.Forms.TabControl();
            this.rulesTabPage = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cannotTextBox = new System.Windows.Forms.TextBox();
            this.mustTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.htmlContainsWordsCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.maxResponseTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.maxResponseTimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.collectHTMLCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.allowRedirectCheckBox = new System.Windows.Forms.CheckBox();
            this.proxyTabPage = new System.Windows.Forms.TabPage();
            this.proxyPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.monitorDetailsTabPage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.collectedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.infoTextTabel1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.responseContentTypeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.responseUriLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusDescriptionLabel = new System.Windows.Forms.Label();
            this.statusCodeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.previewUrlTabPage = new System.Windows.Forms.TabPage();
            this.previewWebBrowser = new System.Windows.Forms.WebBrowser();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.monitorDetailsTabControl.SuspendLayout();
            this.rulesTabPage.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.proxyTabPage.SuspendLayout();
            this.monitorDetailsTabPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.previewUrlTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // monitorDetailsTabControl
            // 
            this.monitorDetailsTabControl.Controls.Add(this.rulesTabPage);
            this.monitorDetailsTabControl.Controls.Add(this.proxyTabPage);
            this.monitorDetailsTabControl.Controls.Add(this.monitorDetailsTabPage);
            this.monitorDetailsTabControl.Controls.Add(this.previewUrlTabPage);
            this.monitorDetailsTabControl.Location = new System.Drawing.Point(12, 12);
            this.monitorDetailsTabControl.Name = "monitorDetailsTabControl";
            this.monitorDetailsTabControl.SelectedIndex = 0;
            this.monitorDetailsTabControl.Size = new System.Drawing.Size(308, 452);
            this.monitorDetailsTabControl.TabIndex = 0;
            this.monitorDetailsTabControl.SelectedIndexChanged += new System.EventHandler(this.monitorDetailsTabControl_SelectedIndexChanged);
            // 
            // rulesTabPage
            // 
            this.rulesTabPage.Controls.Add(this.groupBox5);
            this.rulesTabPage.Controls.Add(this.groupBox2);
            this.rulesTabPage.Location = new System.Drawing.Point(4, 22);
            this.rulesTabPage.Name = "rulesTabPage";
            this.rulesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rulesTabPage.Size = new System.Drawing.Size(300, 426);
            this.rulesTabPage.TabIndex = 1;
            this.rulesTabPage.Text = "Rules";
            this.rulesTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cannotTextBox);
            this.groupBox5.Controls.Add(this.mustTextBox);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.htmlContainsWordsCheckBox);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(6, 98);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(284, 146);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Html check words";
            // 
            // cannotTextBox
            // 
            this.cannotTextBox.ForeColor = System.Drawing.Color.Red;
            this.cannotTextBox.Location = new System.Drawing.Point(9, 110);
            this.cannotTextBox.Name = "cannotTextBox";
            this.cannotTextBox.Size = new System.Drawing.Size(244, 20);
            this.cannotTextBox.TabIndex = 23;
            // 
            // mustTextBox
            // 
            this.mustTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mustTextBox.Location = new System.Drawing.Point(9, 66);
            this.mustTextBox.Name = "mustTextBox";
            this.mustTextBox.Size = new System.Drawing.Size(244, 20);
            this.mustTextBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cannot:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Must:";
            // 
            // htmlContainsWordsCheckBox
            // 
            this.htmlContainsWordsCheckBox.AutoSize = true;
            this.htmlContainsWordsCheckBox.Location = new System.Drawing.Point(194, 26);
            this.htmlContainsWordsCheckBox.Name = "htmlContainsWordsCheckBox";
            this.htmlContainsWordsCheckBox.Size = new System.Drawing.Size(59, 17);
            this.htmlContainsWordsCheckBox.TabIndex = 16;
            this.htmlContainsWordsCheckBox.Text = "Enable";
            this.htmlContainsWordsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "Words that \'Must\' or \'Cannot\' be in the HTML source. Split words by a \";\"";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rules";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.maxResponseTimeCheckBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.maxResponseTimeTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.collectHTMLCheckBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.allowRedirectCheckBox, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 70);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Collect html:";
            // 
            // maxResponseTimeCheckBox
            // 
            this.maxResponseTimeCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maxResponseTimeCheckBox.AutoSize = true;
            this.maxResponseTimeCheckBox.Location = new System.Drawing.Point(182, 3);
            this.maxResponseTimeCheckBox.Name = "maxResponseTimeCheckBox";
            this.maxResponseTimeCheckBox.Size = new System.Drawing.Size(59, 17);
            this.maxResponseTimeCheckBox.TabIndex = 1;
            this.maxResponseTimeCheckBox.Text = "Enable";
            this.maxResponseTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // maxResponseTimeTextBox
            // 
            this.maxResponseTimeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maxResponseTimeTextBox.Location = new System.Drawing.Point(107, 3);
            this.maxResponseTimeTextBox.Name = "maxResponseTimeTextBox";
            this.maxResponseTimeTextBox.Size = new System.Drawing.Size(69, 20);
            this.maxResponseTimeTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max response time:";
            // 
            // collectHTMLCheckBox
            // 
            this.collectHTMLCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.collectHTMLCheckBox.AutoSize = true;
            this.collectHTMLCheckBox.Location = new System.Drawing.Point(182, 26);
            this.collectHTMLCheckBox.Name = "collectHTMLCheckBox";
            this.collectHTMLCheckBox.Size = new System.Drawing.Size(59, 17);
            this.collectHTMLCheckBox.TabIndex = 4;
            this.collectHTMLCheckBox.Text = "Enable";
            this.collectHTMLCheckBox.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Allow Redirect:";
            // 
            // allowRedirectCheckBox
            // 
            this.allowRedirectCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.allowRedirectCheckBox.AutoSize = true;
            this.allowRedirectCheckBox.Checked = true;
            this.allowRedirectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowRedirectCheckBox.Location = new System.Drawing.Point(182, 49);
            this.allowRedirectCheckBox.Name = "allowRedirectCheckBox";
            this.allowRedirectCheckBox.Size = new System.Drawing.Size(59, 17);
            this.allowRedirectCheckBox.TabIndex = 4;
            this.allowRedirectCheckBox.Text = "Enable";
            this.allowRedirectCheckBox.UseVisualStyleBackColor = true;
            // 
            // proxyTabPage
            // 
            this.proxyTabPage.Controls.Add(this.proxyPropertyGrid);
            this.proxyTabPage.Location = new System.Drawing.Point(4, 22);
            this.proxyTabPage.Name = "proxyTabPage";
            this.proxyTabPage.Size = new System.Drawing.Size(300, 426);
            this.proxyTabPage.TabIndex = 3;
            this.proxyTabPage.Text = "Proxy";
            this.proxyTabPage.UseVisualStyleBackColor = true;
            // 
            // proxyPropertyGrid
            // 
            this.proxyPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proxyPropertyGrid.Location = new System.Drawing.Point(0, 0);
            this.proxyPropertyGrid.Name = "proxyPropertyGrid";
            this.proxyPropertyGrid.Size = new System.Drawing.Size(300, 426);
            this.proxyPropertyGrid.TabIndex = 0;
            // 
            // monitorDetailsTabPage
            // 
            this.monitorDetailsTabPage.Controls.Add(this.groupBox4);
            this.monitorDetailsTabPage.Controls.Add(this.groupBox3);
            this.monitorDetailsTabPage.Location = new System.Drawing.Point(4, 22);
            this.monitorDetailsTabPage.Name = "monitorDetailsTabPage";
            this.monitorDetailsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.monitorDetailsTabPage.Size = new System.Drawing.Size(300, 426);
            this.monitorDetailsTabPage.TabIndex = 0;
            this.monitorDetailsTabPage.Text = "Details";
            this.monitorDetailsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.collectedRichTextBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 174);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Collected HTML";
            // 
            // collectedRichTextBox
            // 
            this.collectedRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectedRichTextBox.Enabled = false;
            this.collectedRichTextBox.Location = new System.Drawing.Point(3, 16);
            this.collectedRichTextBox.Name = "collectedRichTextBox";
            this.collectedRichTextBox.ReadOnly = true;
            this.collectedRichTextBox.Size = new System.Drawing.Size(282, 155);
            this.collectedRichTextBox.TabIndex = 5;
            this.collectedRichTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.infoTextTabel1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.responseContentTypeLabel);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.responseUriLabel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.statusDescriptionLabel);
            this.groupBox3.Controls.Add(this.statusCodeLabel);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 234);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Latest request info";
            // 
            // infoTextTabel1
            // 
            this.infoTextTabel1.AutoSize = true;
            this.infoTextTabel1.Location = new System.Drawing.Point(137, 122);
            this.infoTextTabel1.Name = "infoTextTabel1";
            this.infoTextTabel1.Size = new System.Drawing.Size(35, 13);
            this.infoTextTabel1.TabIndex = 9;
            this.infoTextTabel1.Text = "label1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Info text:";
            // 
            // responseContentTypeLabel
            // 
            this.responseContentTypeLabel.AutoSize = true;
            this.responseContentTypeLabel.Location = new System.Drawing.Point(137, 97);
            this.responseContentTypeLabel.Name = "responseContentTypeLabel";
            this.responseContentTypeLabel.Size = new System.Drawing.Size(35, 13);
            this.responseContentTypeLabel.TabIndex = 7;
            this.responseContentTypeLabel.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Response Content Type:";
            // 
            // responseUriLabel
            // 
            this.responseUriLabel.AutoSize = true;
            this.responseUriLabel.Location = new System.Drawing.Point(137, 74);
            this.responseUriLabel.Name = "responseUriLabel";
            this.responseUriLabel.Size = new System.Drawing.Size(35, 13);
            this.responseUriLabel.TabIndex = 5;
            this.responseUriLabel.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ResponseUri:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "StatusCode:";
            // 
            // statusDescriptionLabel
            // 
            this.statusDescriptionLabel.AutoSize = true;
            this.statusDescriptionLabel.Location = new System.Drawing.Point(137, 49);
            this.statusDescriptionLabel.Name = "statusDescriptionLabel";
            this.statusDescriptionLabel.Size = new System.Drawing.Size(35, 13);
            this.statusDescriptionLabel.TabIndex = 3;
            this.statusDescriptionLabel.Text = "label1";
            // 
            // statusCodeLabel
            // 
            this.statusCodeLabel.AutoSize = true;
            this.statusCodeLabel.Location = new System.Drawing.Point(137, 27);
            this.statusCodeLabel.Name = "statusCodeLabel";
            this.statusCodeLabel.Size = new System.Drawing.Size(35, 13);
            this.statusCodeLabel.TabIndex = 0;
            this.statusCodeLabel.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "StatusDescription:";
            // 
            // previewUrlTabPage
            // 
            this.previewUrlTabPage.Controls.Add(this.previewWebBrowser);
            this.previewUrlTabPage.Location = new System.Drawing.Point(4, 22);
            this.previewUrlTabPage.Name = "previewUrlTabPage";
            this.previewUrlTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.previewUrlTabPage.Size = new System.Drawing.Size(300, 426);
            this.previewUrlTabPage.TabIndex = 2;
            this.previewUrlTabPage.Text = "Preview";
            this.previewUrlTabPage.UseVisualStyleBackColor = true;
            // 
            // previewWebBrowser
            // 
            this.previewWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewWebBrowser.Location = new System.Drawing.Point(3, 3);
            this.previewWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.previewWebBrowser.Name = "previewWebBrowser";
            this.previewWebBrowser.Size = new System.Drawing.Size(294, 420);
            this.previewWebBrowser.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(245, 470);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(162, 470);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // MonitorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 507);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.monitorDetailsTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonitorDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Monitor Rules";
            this.monitorDetailsTabControl.ResumeLayout(false);
            this.rulesTabPage.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.proxyTabPage.ResumeLayout(false);
            this.monitorDetailsTabPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.previewUrlTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl monitorDetailsTabControl;
        private System.Windows.Forms.TabPage monitorDetailsTabPage;
        private System.Windows.Forms.TabPage rulesTabPage;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox maxResponseTimeTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox maxResponseTimeCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusCodeLabel;
        private System.Windows.Forms.Label statusDescriptionLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label responseUriLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label responseContentTypeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox collectedRichTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox collectHTMLCheckBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox htmlContainsWordsCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label infoTextTabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage previewUrlTabPage;
        private System.Windows.Forms.WebBrowser previewWebBrowser;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox cannotTextBox;
        private System.Windows.Forms.TextBox mustTextBox;
        private System.Windows.Forms.TabPage proxyTabPage;
        private System.Windows.Forms.PropertyGrid proxyPropertyGrid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox allowRedirectCheckBox;
    }
}