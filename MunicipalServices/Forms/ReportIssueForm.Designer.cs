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

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
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
            this.backButton.Location = new System.Drawing.Point(20, 500);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(160, 35);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back to Main Menu";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            //
            // ReportIssueForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = MunicipalServices.UiTheme.Background;
            this.ClientSize = new System.Drawing.Size(560, 560);
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
