using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MunicipalServices.Models;

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

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(locationTextBox.Text))
            {
                MessageBox.Show(this, "Please enter the location of the issue.", "Missing information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                locationTextBox.Focus();
                return;
            }

            if (categoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Please select a category for the issue.", "Missing information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                categoryComboBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(descriptionRichTextBox.Text))
            {
                MessageBox.Show(this, "Please describe the issue.", "Missing information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                descriptionRichTextBox.Focus();
                return;
            }

            var issue = new Issue
            {
                Location = locationTextBox.Text.Trim(),
                Category = categoryComboBox.SelectedItem.ToString(),
                Description = descriptionRichTextBox.Text.Trim(),
                AttachmentPaths = new List<string>(_attachmentPaths)
            };
            IssueRepository.Add(issue);

            MessageBox.Show(this, "Thank you! Your issue has been reported successfully.", "Report submitted",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
        }

        private void ClearForm()
        {
            locationTextBox.Clear();
            categoryComboBox.SelectedIndex = -1;
            descriptionRichTextBox.Clear();
            attachmentsListBox.Items.Clear();
            _attachmentPaths.Clear();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
