namespace MunicipalServices.Forms
{
    partial class LocalEventsForm
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
        private System.Windows.Forms.ListView eventsListView;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.ColumnHeader titleColumn;
        private System.Windows.Forms.ColumnHeader categoryColumn;
        private System.Windows.Forms.ColumnHeader locationColumn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.GroupBox detailsGroupBox;
        private System.Windows.Forms.RichTextBox detailsTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox announcementsGroupBox;
        private System.Windows.Forms.ListView announcementsListView;
        private System.Windows.Forms.ColumnHeader urgencyColumn;
        private System.Windows.Forms.ColumnHeader noticeColumn;
        private System.Windows.Forms.RichTextBox announcementTextBox;

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.eventsListView = new System.Windows.Forms.ListView();
            this.dateColumn = new System.Windows.Forms.ColumnHeader();
            this.titleColumn = new System.Windows.Forms.ColumnHeader();
            this.categoryColumn = new System.Windows.Forms.ColumnHeader();
            this.locationColumn = new System.Windows.Forms.ColumnHeader();
            this.statusLabel = new System.Windows.Forms.Label();
            this.detailsGroupBox = new System.Windows.Forms.GroupBox();
            this.detailsTextBox = new System.Windows.Forms.RichTextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.announcementsGroupBox = new System.Windows.Forms.GroupBox();
            this.announcementsListView = new System.Windows.Forms.ListView();
            this.urgencyColumn = new System.Windows.Forms.ColumnHeader();
            this.noticeColumn = new System.Windows.Forms.ColumnHeader();
            this.announcementTextBox = new System.Windows.Forms.RichTextBox();
            this.headerPanel.SuspendLayout();
            this.detailsGroupBox.SuspendLayout();
            this.announcementsGroupBox.SuspendLayout();
            this.SuspendLayout();
            //
            // headerPanel
            //
            this.headerPanel.BackColor = MunicipalServices.UiTheme.Primary;
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(900, 60);
            this.headerPanel.TabIndex = 0;
            //
            // titleLabel
            //
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = MunicipalServices.UiTheme.HeadingFont;
            this.titleLabel.ForeColor = MunicipalServices.UiTheme.TextLight;
            this.titleLabel.Location = new System.Drawing.Point(20, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(240, 21);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Local Events && Announcements";
            //
            // backButton
            //
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.BackColor = MunicipalServices.UiTheme.Disabled;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = MunicipalServices.UiTheme.BodyFont;
            this.backButton.Location = new System.Drawing.Point(720, 570);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 35);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back to Main Menu";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            //
            // categoryLabel
            //
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = MunicipalServices.UiTheme.BodyFont;
            this.categoryLabel.ForeColor = MunicipalServices.UiTheme.TextDark;
            this.categoryLabel.Location = new System.Drawing.Point(20, 77);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(60, 17);
            this.categoryLabel.TabIndex = 5;
            this.categoryLabel.Text = "Category";
            //
            // categoryComboBox
            //
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Font = MunicipalServices.UiTheme.BodyFont;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(90, 74);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(180, 25);
            this.categoryComboBox.TabIndex = 6;
            //
            // dateCheckBox
            //
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Font = MunicipalServices.UiTheme.BodyFont;
            this.dateCheckBox.ForeColor = MunicipalServices.UiTheme.TextDark;
            this.dateCheckBox.Location = new System.Drawing.Point(290, 76);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(100, 21);
            this.dateCheckBox.TabIndex = 7;
            this.dateCheckBox.Text = "On this date";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.DateCheckBox_CheckedChanged);
            //
            // datePicker
            //
            this.datePicker.CustomFormat = "ddd, dd MMM yyyy";
            this.datePicker.Enabled = false;
            this.datePicker.Font = MunicipalServices.UiTheme.BodyFont;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(400, 74);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(160, 25);
            this.datePicker.TabIndex = 8;
            //
            // searchButton
            //
            this.searchButton.BackColor = MunicipalServices.UiTheme.Accent;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = MunicipalServices.UiTheme.BodyFont;
            this.searchButton.ForeColor = MunicipalServices.UiTheme.TextLight;
            this.searchButton.Location = new System.Drawing.Point(580, 72);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(90, 30);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            //
            // clearButton
            //
            this.clearButton.BackColor = MunicipalServices.UiTheme.Disabled;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = MunicipalServices.UiTheme.BodyFont;
            this.clearButton.Location = new System.Drawing.Point(680, 72);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 30);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            //
            // eventsListView
            //
            this.eventsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateColumn,
            this.titleColumn,
            this.categoryColumn,
            this.locationColumn});
            this.eventsListView.Font = MunicipalServices.UiTheme.BodyFont;
            this.eventsListView.FullRowSelect = true;
            this.eventsListView.HideSelection = false;
            this.eventsListView.Location = new System.Drawing.Point(20, 115);
            this.eventsListView.MultiSelect = false;
            this.eventsListView.Name = "eventsListView";
            this.eventsListView.Size = new System.Drawing.Size(560, 370);
            this.eventsListView.TabIndex = 2;
            this.eventsListView.UseCompatibleStateImageBehavior = false;
            this.eventsListView.View = System.Windows.Forms.View.Details;
            this.eventsListView.SelectedIndexChanged += new System.EventHandler(this.EventsListView_SelectedIndexChanged);
            //
            // dateColumn
            //
            this.dateColumn.Text = "Date";
            this.dateColumn.Width = 120;
            //
            // titleColumn
            //
            this.titleColumn.Text = "Event";
            this.titleColumn.Width = 210;
            //
            // categoryColumn
            //
            this.categoryColumn.Text = "Category";
            this.categoryColumn.Width = 120;
            //
            // locationColumn
            //
            this.locationColumn.Text = "Location";
            this.locationColumn.Width = 100;
            //
            // statusLabel
            //
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = MunicipalServices.UiTheme.BodyFont;
            this.statusLabel.ForeColor = MunicipalServices.UiTheme.PrimaryDark;
            this.statusLabel.Location = new System.Drawing.Point(20, 492);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(120, 17);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Showing 0 events";
            //
            // detailsGroupBox
            //
            this.detailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right))));
            this.detailsGroupBox.Controls.Add(this.detailsTextBox);
            this.detailsGroupBox.Font = MunicipalServices.UiTheme.BodyFont;
            this.detailsGroupBox.ForeColor = MunicipalServices.UiTheme.TextDark;
            this.detailsGroupBox.Location = new System.Drawing.Point(600, 115);
            this.detailsGroupBox.Name = "detailsGroupBox";
            this.detailsGroupBox.Size = new System.Drawing.Size(280, 185);
            this.detailsGroupBox.TabIndex = 4;
            this.detailsGroupBox.TabStop = false;
            this.detailsGroupBox.Text = "Event details";
            //
            // detailsTextBox
            //
            this.detailsTextBox.BackColor = MunicipalServices.UiTheme.Background;
            this.detailsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsTextBox.Location = new System.Drawing.Point(3, 20);
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.ReadOnly = true;
            this.detailsTextBox.Size = new System.Drawing.Size(274, 162);
            this.detailsTextBox.TabIndex = 0;
            this.detailsTextBox.Text = "";
            //
            // announcementsGroupBox
            //
            this.announcementsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right))));
            this.announcementsGroupBox.Controls.Add(this.announcementTextBox);
            this.announcementsGroupBox.Controls.Add(this.announcementsListView);
            this.announcementsGroupBox.Font = MunicipalServices.UiTheme.BodyFont;
            this.announcementsGroupBox.ForeColor = MunicipalServices.UiTheme.TextDark;
            this.announcementsGroupBox.Location = new System.Drawing.Point(600, 310);
            this.announcementsGroupBox.Name = "announcementsGroupBox";
            this.announcementsGroupBox.Size = new System.Drawing.Size(280, 245);
            this.announcementsGroupBox.TabIndex = 11;
            this.announcementsGroupBox.TabStop = false;
            this.announcementsGroupBox.Text = "Announcements (most urgent first)";
            //
            // announcementsListView
            //
            this.announcementsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.announcementsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urgencyColumn,
            this.noticeColumn});
            this.announcementsListView.FullRowSelect = true;
            this.announcementsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.announcementsListView.HideSelection = false;
            this.announcementsListView.Location = new System.Drawing.Point(8, 22);
            this.announcementsListView.MultiSelect = false;
            this.announcementsListView.Name = "announcementsListView";
            this.announcementsListView.Size = new System.Drawing.Size(264, 125);
            this.announcementsListView.TabIndex = 0;
            this.announcementsListView.UseCompatibleStateImageBehavior = false;
            this.announcementsListView.View = System.Windows.Forms.View.Details;
            this.announcementsListView.SelectedIndexChanged += new System.EventHandler(this.AnnouncementsListView_SelectedIndexChanged);
            //
            // urgencyColumn
            //
            this.urgencyColumn.Text = "Urgency";
            this.urgencyColumn.Width = 75;
            //
            // noticeColumn
            //
            this.noticeColumn.Text = "Notice";
            this.noticeColumn.Width = 185;
            //
            // announcementTextBox
            //
            this.announcementTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.announcementTextBox.BackColor = MunicipalServices.UiTheme.Background;
            this.announcementTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.announcementTextBox.Location = new System.Drawing.Point(8, 153);
            this.announcementTextBox.Name = "announcementTextBox";
            this.announcementTextBox.ReadOnly = true;
            this.announcementTextBox.Size = new System.Drawing.Size(264, 86);
            this.announcementTextBox.TabIndex = 1;
            this.announcementTextBox.Text = "";
            //
            // LocalEventsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = MunicipalServices.UiTheme.Background;
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.announcementsGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dateCheckBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.detailsGroupBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.eventsListView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(816, 599);
            this.Name = "LocalEventsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Events & Announcements";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.detailsGroupBox.ResumeLayout(false);
            this.announcementsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
