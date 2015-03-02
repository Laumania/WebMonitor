using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WebMonitor.Engine;

namespace WebMonitor
{
    public partial class MonitorDetails : Form
    {
        private Monitor monitor;

        public MonitorDetails(Monitor monitor)
        {
            InitializeComponent();

            this.monitor = monitor;
            InitializeDetailsForm(monitor);
        }

        private void InitializeDetailsForm(Monitor monitor)
        {
            this.Text = this.monitor.Url;
            //urlTextBox.Text = monitor.Url;
            //userAgentTextBox.Text = monitor.UserAgent;
            infoTextTabel1.Text = monitor.InfoText;
            //colorLabel.BackColor = monitor.Color;

            //HttpRequest fields
            statusCodeLabel.Text = monitor.StatusCode;
            statusDescriptionLabel.Text = monitor.StatusDescription;
            responseUriLabel.Text = monitor.ResponseUri;
            responseContentTypeLabel.Text = monitor.ResponseContentType;

            if (monitor.Rules.RunCollectHtml)
            {
                collectHTMLCheckBox.Checked = monitor.Rules.RunCollectHtml;
                collectedRichTextBox.Enabled = true;
                collectedRichTextBox.Text = monitor.ResponseHtml;
            }
           
            
            //Rules
            allowRedirectCheckBox.Checked = monitor.Rules.AllowRedirect;
            maxResponseTimeCheckBox.Checked = monitor.Rules.RunMaxResponseRule;
            maxResponseTimeTextBox.Text = monitor.Rules.MaxResponseTime.ToString();
            htmlContainsWordsCheckBox.Checked = monitor.Rules.RunHtmlContainsText;

            for (int i = 0; i < monitor.Rules.WordsListCannot.Length; i++)
            {
                if(monitor.Rules.WordsListCannot[i].ToString() != "")
                cannotTextBox.Text += monitor.Rules.WordsListCannot[i].ToString().Trim() +";";
            }

            for (int i = 0; i < monitor.Rules.WordsListMust.Length; i++)
            {
                if (monitor.Rules.WordsListMust[i].ToString() != "")
                mustTextBox.Text += monitor.Rules.WordsListMust[i].ToString().Trim() + ";";
            }

            //Proxy
            proxyPropertyGrid.SelectedObject = monitor.ProxySettings;
        }



        /***************************************************/
        /*****************GUI EVENTS ***********************/
        /***************************************************/
        #region GUI Events

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Save monitor settings
                //monitor.Url = urlTextBox.Text.Trim();
                //onitor.UserAgent = userAgentTextBox.Text.Trim();

                //Save rules
                monitor.Rules.RunMaxResponseRule = maxResponseTimeCheckBox.Checked;
                monitor.Rules.MaxResponseTime = Convert.ToInt32(maxResponseTimeTextBox.Text.Trim());
                monitor.Rules.AllowRedirect = allowRedirectCheckBox.Checked;
                monitor.Rules.RunCollectHtml = collectHTMLCheckBox.Checked;

                monitor.Rules.RunHtmlContainsText = htmlContainsWordsCheckBox.Checked;
                monitor.Rules.WordsListCannot = cannotTextBox.Text.Trim().Split(';');
                monitor.Rules.WordsListMust = mustTextBox.Text.Trim().Split(';');

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            //Dispose the window
            this.Dispose();
        } 


        #endregion

        private void monitorDetailsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.monitorDetailsTabControl.SelectedIndex == 2)
            {
                previewWebBrowser.Url = new Uri(monitor.Url);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}