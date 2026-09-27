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
            ShowChildForm(new ReportIssueForm());
        }

        private void LocalEventsButton_Click(object sender, EventArgs e)
        {
            ShowChildForm(new LocalEventsForm());
        }

        private void ShowChildForm(Form childForm)
        {
            using (childForm)
            {
                this.Hide();
                childForm.ShowDialog();
                this.Show();
            }
        }
    }
}
