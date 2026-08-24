namespace MunicipalServices.Forms
{
    partial class ReportIssueForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button attachButton;
        private System.Windows.Forms.ListBox attachmentsListBox;
        private System.Windows.Forms.OpenFileDialog attachmentDialog;
        private System.Windows.Forms.Button submitButton;

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.attachButton = new System.Windows.Forms.Button();
            this.attachmentsListBox = new System.Windows.Forms.ListBox();
            this.attachmentDialog = new System.Windows.Forms.OpenFileDialog();
            this.submitButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // headerPanel
            //
            this.headerPanel.BackColor = MunicipalServices.UiTheme.Primary;
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(560, 60);
            this.headerPanel.TabIndex = 0;
            //
            // titleLabel
            //
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = MunicipalServices.UiTheme.HeadingFont;
            this.titleLabel.ForeColor = MunicipalServices.UiTheme.TextLight;
            this.titleLabel.Location = new System.Drawing.Point(20, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(120, 21);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Report an Issue";
            //
            // backButton
            //
            this.backButton.BackColor = MunicipalServices.UiTheme.Disabled;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = MunicipalServices.UiTheme.BodyFont;
            this.backButton.Location = new System.Drawing.Point(380, 500);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 35);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back to Main Menu";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            //
            // locationLabel
            //
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = MunicipalServices.UiTheme.BodyFont;
            this.locationLabel.ForeColor = MunicipalServices.UiTheme.TextDark;
            this.locationLabel.Location = new System.Drawing.Point(30, 72);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(58, 17);
            this.locationLabel.TabIndex = 2;
            this.locationLabel.Text = "Location";
            //
            // locationTextBox
            //
            this.locationTextBox.Font = MunicipalServices.UiTheme.BodyFont;
            this.locationTextBox.Location = new System.Drawing.Point(30, 92);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(500, 25);
            this.locationTextBox.TabIndex = 3;
            //
            // categoryLabel
            //
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = MunicipalServices.UiTheme.BodyFont;
            this.categoryLabel.ForeColor = MunicipalServices.UiTheme.TextDark;
            this.categoryLabel.Location = new System.Drawing.Point(30, 132);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(60, 17);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "Category";
            //
            // categoryComboBox
            //
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Font = MunicipalServices.UiTheme.BodyFont;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities (Water & Electricity)",
            "Public Safety",
            "Parks & Recreation",
            "Other"});
            this.categoryComboBox.Location = new System.Drawing.Point(30, 152);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(250, 25);
            this.categoryComboBox.TabIndex = 5;
            //
            // descriptionLabel
            //
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = MunicipalServices.UiTheme.BodyFont;
            this.descriptionLabel.ForeColor = MunicipalServices.UiTheme.TextDark;
            this.descriptionLabel.Location = new System.Drawing.Point(30, 192);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(74, 17);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Description";
            //
            // descriptionRichTextBox
            //
            this.descriptionRichTextBox.Font = MunicipalServices.UiTheme.BodyFont;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(30, 212);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(500, 110);
            this.descriptionRichTextBox.TabIndex = 7;
            this.descriptionRichTextBox.Text = "";
            //
            // attachButton
            //
            this.attachButton.BackColor = MunicipalServices.UiTheme.Primary;
            this.attachButton.FlatAppearance.BorderSize = 0;
            this.attachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attachButton.Font = MunicipalServices.UiTheme.BodyFont;
            this.attachButton.ForeColor = MunicipalServices.UiTheme.TextLight;
            this.attachButton.Location = new System.Drawing.Point(30, 332);
            this.attachButton.Name = "attachButton";
            this.attachButton.Size = new System.Drawing.Size(180, 30);
            this.attachButton.TabIndex = 8;
            this.attachButton.Text = "Attach Media...";
            this.attachButton.UseVisualStyleBackColor = false;
            this.attachButton.Click += new System.EventHandler(this.AttachButton_Click);
            //
            // attachmentsListBox
            //
            this.attachmentsListBox.Font = MunicipalServices.UiTheme.BodyFont;
            this.attachmentsListBox.FormattingEnabled = true;
            this.attachmentsListBox.Location = new System.Drawing.Point(30, 368);
            this.attachmentsListBox.Name = "attachmentsListBox";
            this.attachmentsListBox.Size = new System.Drawing.Size(500, 69);
            this.attachmentsListBox.TabIndex = 9;
            //
            // attachmentDialog
            //
            this.attachmentDialog.Filter = "Images and documents|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.pdf;*.doc;*.docx;*.txt|All files|*.*";
            this.attachmentDialog.Multiselect = true;
            this.attachmentDialog.Title = "Attach media or documents for this issue";
            //
            // submitButton
            //
            this.submitButton.BackColor = MunicipalServices.UiTheme.Accent;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = MunicipalServices.UiTheme.HeadingFont;
            this.submitButton.ForeColor = MunicipalServices.UiTheme.TextLight;
            this.submitButton.Location = new System.Drawing.Point(30, 500);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(150, 35);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            //
            // ReportIssueForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = MunicipalServices.UiTheme.Background;
            this.ClientSize = new System.Drawing.Size(560, 560);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.attachmentsListBox);
            this.Controls.Add(this.attachButton);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(576, 599);
            this.Name = "ReportIssueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report an Issue";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
