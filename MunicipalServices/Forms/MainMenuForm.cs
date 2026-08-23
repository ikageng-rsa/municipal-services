using System;
using System.Windows.Forms;

namespace MunicipalServices.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void ReportIssuesButton_Click(object sender, EventArgs e)
        {
            using (var reportIssueForm = new ReportIssueForm())
            {
                this.Hide();
                reportIssueForm.ShowDialog();
                this.Show();
            }
        }
    }
}
