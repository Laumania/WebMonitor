namespace WebMonitor
{
    partial class ChangeLog
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
            this.changelogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // changelogRichTextBox
            // 
            this.changelogRichTextBox.CausesValidation = false;
            this.changelogRichTextBox.DetectUrls = false;
            this.changelogRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changelogRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.changelogRichTextBox.Name = "changelogRichTextBox";
            this.changelogRichTextBox.ReadOnly = true;
            this.changelogRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.changelogRichTextBox.ShortcutsEnabled = false;
            this.changelogRichTextBox.Size = new System.Drawing.Size(632, 383);
            this.changelogRichTextBox.TabIndex = 0;
            this.changelogRichTextBox.Text = "";
            // 
            // ChangeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(632, 383);
            this.Controls.Add(this.changelogRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ChangeLog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangeLog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox changelogRichTextBox;
    }
}