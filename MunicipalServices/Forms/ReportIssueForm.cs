using System;
using System.Windows.Forms;

namespace MunicipalServices.Forms
{
    public partial class ReportIssueForm : Form
    {
        public ReportIssueForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
