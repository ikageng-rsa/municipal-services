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
            UpdateEngagementProgress();
        }

        private void FormField_Changed(object sender, EventArgs e)
        {
            UpdateEngagementProgress();
        }

        private void UpdateEngagementProgress()
        {
            var fieldsFilled = 0;
            if (!string.IsNullOrWhiteSpace(locationTextBox.Text)) fieldsFilled++;
            if (categoryComboBox.SelectedIndex != -1) fieldsFilled++;
            if (!string.IsNullOrWhiteSpace(descriptionRichTextBox.Text)) fieldsFilled++;

            engagementProgressBar.Value = fieldsFilled * 100 / 3;

            switch (fieldsFilled)
            {
                case 0:
                    engagementLabel.Text = "Let's get started! Every report helps your community.";
                    break;
                case 1:
                    engagementLabel.Text = "Great start! Keep going, you're a third of the way there.";
                    break;
                case 2:
                    engagementLabel.Text = "Almost there! Just one more detail to go.";
                    break;
                default:
                    engagementLabel.Text = "All set! Click Submit to send your report.";
                    break;
            }
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

            MessageBox.Show(this,
                $"Thank you! Your issue has been reported successfully.{Environment.NewLine}{Environment.NewLine}" +
                $"{IssueRepository.Issues.Count} issue(s) reported by your community so far. Every report helps!",
                "Report submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
        }

        private void ClearForm()
        {
            locationTextBox.Clear();
            categoryComboBox.SelectedIndex = -1;
            descriptionRichTextBox.Clear();
            attachmentsListBox.Items.Clear();
            _attachmentPaths.Clear();
            UpdateEngagementProgress();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
