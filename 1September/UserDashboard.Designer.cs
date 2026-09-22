namespace _1September
{
    partial class UserDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            btnQualifications = new Button();
            btnSettings = new Button();
            btnLogout = new Button();
            btnReports = new Button();
            btnTransactions = new Button();
            btnReputation = new Button();
            btnSearch = new Button();
            btnVerification = new Button();
            btnProfile = new Button();
            btnDashboard = new Button();
            pnlHeader = new Panel();
            lblWelcome = new Label();
            pnlContent = new Panel();
            lblDashboardTitle = new Label();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(btnQualifications);
            pnlSidebar.Controls.Add(btnSettings);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnTransactions);
            pnlSidebar.Controls.Add(btnReputation);
            pnlSidebar.Controls.Add(btnSearch);
            pnlSidebar.Controls.Add(btnVerification);
            pnlSidebar.Controls.Add(btnProfile);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 579);
            pnlSidebar.TabIndex = 0;
            // 
            // btnQualifications
            // 
            btnQualifications.Location = new Point(20, 201);
            btnQualifications.Name = "btnQualifications";
            btnQualifications.Size = new Size(137, 34);
            btnQualifications.TabIndex = 9;
            btnQualifications.Text = "Qualifications";
            btnQualifications.UseVisualStyleBackColor = true;
            btnQualifications.Click += btnQualifications_Click;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(20, 445);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(137, 34);
            btnSettings.TabIndex = 8;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(20, 499);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(137, 34);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(20, 393);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(137, 34);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnTransactions
            // 
            btnTransactions.Location = new Point(20, 341);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(137, 34);
            btnTransactions.TabIndex = 5;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = true;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnReputation
            // 
            btnReputation.Location = new Point(20, 290);
            btnReputation.Name = "btnReputation";
            btnReputation.Size = new Size(137, 34);
            btnReputation.TabIndex = 4;
            btnReputation.Text = "Reputation";
            btnReputation.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(20, 241);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(137, 34);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnVerification
            // 
            btnVerification.Location = new Point(20, 145);
            btnVerification.Name = "btnVerification";
            btnVerification.Size = new Size(137, 34);
            btnVerification.TabIndex = 2;
            btnVerification.Text = "Verification";
            btnVerification.UseVisualStyleBackColor = true;
            btnVerification.Click += btnVerification_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(20, 94);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(137, 34);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(20, 42);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(137, 34);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(200, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(786, 70);
            pnlHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(6, 42);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(129, 25);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, User";
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(lblDashboardTitle);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(200, 70);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(786, 509);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Location = new Point(0, 8);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(167, 25);
            lblDashboardTitle.TabIndex = 1;
            lblDashboardTitle.Text = "USER DASHBOARD";
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 579);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Name = "UserDashboard";
            Text = "UserDashboard";
            pnlSidebar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlHeader;
        private Panel pnlContent;
        private Button btnReports;
        private Button btnTransactions;
        private Button btnReputation;
        private Button btnSearch;
        private Button btnVerification;
        private Button btnProfile;
        private Button btnDashboard;
        private Button btnLogout;
        private Label lblWelcome;
        private Label lblDashboardTitle;
        private Button btnSettings;
        private Button btnQualifications;
    }
}