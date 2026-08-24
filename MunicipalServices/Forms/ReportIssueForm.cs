using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalServices.Forms
{
    public partial class ReportIssueForm : Form
    {
        private readonly List<string> _attachmentPaths = new List<string>();

        public ReportIssueForm()
        {
            InitializeComponent();
        }

        private void AttachButton_Click(object sender, EventArgs e)
        {
            if (attachmentDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var fileName in attachmentDialog.FileNames)
                {
                    _attachmentPaths.Add(fileName);
                    attachmentsListBox.Items.Add(System.IO.Path.GetFileName(fileName));
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
