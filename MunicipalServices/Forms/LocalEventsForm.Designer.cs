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
            this.headerPanel.SuspendLayout();
            this.detailsGroupBox.SuspendLayout();
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
            // LocalEventsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = MunicipalServices.UiTheme.Background;
            this.ClientSize = new System.Drawing.Size(900, 620);
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
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
