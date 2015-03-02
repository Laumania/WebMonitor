using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WebMonitor
{
    public partial class ChangeLog : Form
    {
        public ChangeLog()
        {
            InitializeComponent();
            changelogRichTextBox.Text = Properties.Resources.ChangeLog.ToString();
        }
    }
}