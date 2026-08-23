namespace MunicipalServices.Forms
{
    partial class MainMenuForm
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
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Button reportIssuesButton;
        private System.Windows.Forms.Button localEventsButton;
        private System.Windows.Forms.Button serviceStatusButton;

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.reportIssuesButton = new System.Windows.Forms.Button();
            this.localEventsButton = new System.Windows.Forms.Button();
            this.serviceStatusButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // headerPanel
            //
            this.headerPanel.BackColor = MunicipalServices.UiTheme.Primary;
            this.headerPanel.Controls.Add(this.subtitleLabel);
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(480, 100);
            this.headerPanel.TabIndex = 0;
            //
            // titleLabel
            //
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = MunicipalServices.UiTheme.TitleFont;
            this.titleLabel.ForeColor = MunicipalServices.UiTheme.TextLight;
            this.titleLabel.Location = new System.Drawing.Point(20, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(300, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Municipal Services";
            //
            // subtitleLabel
            //
            this.subtitleLabel.AutoSize = true;
            this.subtitleLabel.Font = MunicipalServices.UiTheme.BodyFont;
            this.subtitleLabel.ForeColor = MunicipalServices.UiTheme.TextLight;
            this.subtitleLabel.Location = new System.Drawing.Point(22, 55);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(220, 19);
            this.subtitleLabel.TabIndex = 1;
            this.subtitleLabel.Text = "How can we help you today?";
            //
            // reportIssuesButton
            //
            this.reportIssuesButton.BackColor = MunicipalServices.UiTheme.Accent;
            this.reportIssuesButton.FlatAppearance.BorderSize = 0;
            this.reportIssuesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportIssuesButton.Font = MunicipalServices.UiTheme.HeadingFont;
            this.reportIssuesButton.ForeColor = MunicipalServices.UiTheme.TextLight;
            this.reportIssuesButton.Location = new System.Drawing.Point(40, 130);
            this.reportIssuesButton.Name = "reportIssuesButton";
            this.reportIssuesButton.Size = new System.Drawing.Size(400, 55);
            this.reportIssuesButton.TabIndex = 1;
            this.reportIssuesButton.Text = "Report Issues";
            this.reportIssuesButton.UseVisualStyleBackColor = false;
            this.reportIssuesButton.Click += new System.EventHandler(this.ReportIssuesButton_Click);
            //
            // localEventsButton
            //
            this.localEventsButton.BackColor = MunicipalServices.UiTheme.Disabled;
            this.localEventsButton.Enabled = false;
            this.localEventsButton.FlatAppearance.BorderSize = 0;
            this.localEventsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.localEventsButton.Font = MunicipalServices.UiTheme.HeadingFont;
            this.localEventsButton.ForeColor = MunicipalServices.UiTheme.TextDark;
            this.localEventsButton.Location = new System.Drawing.Point(40, 200);
            this.localEventsButton.Name = "localEventsButton";
            this.localEventsButton.Size = new System.Drawing.Size(400, 55);
            this.localEventsButton.TabIndex = 2;
            this.localEventsButton.Text = "Local Events && Announcements (coming soon)";
            this.localEventsButton.UseVisualStyleBackColor = false;
            //
            // serviceStatusButton
            //
            this.serviceStatusButton.BackColor = MunicipalServices.UiTheme.Disabled;
            this.serviceStatusButton.Enabled = false;
            this.serviceStatusButton.FlatAppearance.BorderSize = 0;
            this.serviceStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceStatusButton.Font = MunicipalServices.UiTheme.HeadingFont;
            this.serviceStatusButton.ForeColor = MunicipalServices.UiTheme.TextDark;
            this.serviceStatusButton.Location = new System.Drawing.Point(40, 270);
            this.serviceStatusButton.Name = "serviceStatusButton";
            this.serviceStatusButton.Size = new System.Drawing.Size(400, 55);
            this.serviceStatusButton.TabIndex = 3;
            this.serviceStatusButton.Text = "Service Request Status (coming soon)";
            this.serviceStatusButton.UseVisualStyleBackColor = false;
            //
            // MainMenuForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = MunicipalServices.UiTheme.Background;
            this.ClientSize = new System.Drawing.Size(480, 360);
            this.Controls.Add(this.serviceStatusButton);
            this.Controls.Add(this.localEventsButton);
            this.Controls.Add(this.reportIssuesButton);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(496, 399);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municipal Services Application";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
