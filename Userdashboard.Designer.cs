using TrustID.Models;
namespace user_dashboard
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
            pnlContent = new Panel();
            lblPageTitle = new Label();
            lblPageSubtitle = new Label();
            pnlHeader = new Panel();
            btnDashboard = new Button();
            btnProfile = new Button();
            btnVerification = new Button();
            btnQualifications = new Button();
            btnSearchUsers = new Button();
            btnTransactions = new Button();
            btnTrustScore = new Button();
            btnReviews = new Button();
            btnSettings = new Button();
            btnLogout = new Button();
            pnlSidebar = new Panel();
            picLogo = new PictureBox();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(17, 24, 39);
            pnlContent.Location = new Point(179, 86);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1133, 690);
            pnlContent.TabIndex = 2;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(24, 8);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(63, 25);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "label1";
            // 
            // lblPageSubtitle
            // 
            lblPageSubtitle.AutoSize = true;
            lblPageSubtitle.Location = new Point(24, 49);
            lblPageSubtitle.Name = "lblPageSubtitle";
            lblPageSubtitle.Size = new Size(38, 15);
            lblPageSubtitle.TabIndex = 1;
            lblPageSubtitle.Text = "label1";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(17, 24, 39);
            pnlHeader.Controls.Add(lblPageSubtitle);
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Location = new Point(179, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1133, 81);
            pnlHeader.TabIndex = 1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(17, 24, 39);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.FromArgb(140, 140, 150);
            btnDashboard.Location = new Point(10, 124);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(130, 23);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.TopLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(17, 24, 39);
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.ForeColor = Color.FromArgb(140, 140, 150);
            btnProfile.Location = new Point(10, 170);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(130, 23);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.TextAlign = ContentAlignment.TopLeft;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnVerification
            // 
            btnVerification.BackColor = Color.FromArgb(17, 24, 39);
            btnVerification.FlatAppearance.BorderSize = 0;
            btnVerification.FlatStyle = FlatStyle.Flat;
            btnVerification.ForeColor = Color.FromArgb(140, 140, 150);
            btnVerification.Location = new Point(10, 218);
            btnVerification.Name = "btnVerification";
            btnVerification.Size = new Size(130, 23);
            btnVerification.TabIndex = 2;
            btnVerification.Text = "Verfication";
            btnVerification.TextAlign = ContentAlignment.TopLeft;
            btnVerification.UseVisualStyleBackColor = false;
            btnVerification.Click += btnVerification_Click;
            // 
            // btnQualifications
            // 
            btnQualifications.BackColor = Color.FromArgb(17, 24, 39);
            btnQualifications.FlatAppearance.BorderSize = 0;
            btnQualifications.FlatStyle = FlatStyle.Flat;
            btnQualifications.ForeColor = Color.FromArgb(140, 140, 150);
            btnQualifications.Location = new Point(10, 271);
            btnQualifications.Name = "btnQualifications";
            btnQualifications.Size = new Size(130, 23);
            btnQualifications.TabIndex = 3;
            btnQualifications.Text = "Qualifications";
            btnQualifications.TextAlign = ContentAlignment.TopLeft;
            btnQualifications.UseVisualStyleBackColor = false;
            btnQualifications.Click += btnQualifications_Click;
            // 
            // btnSearchUsers
            // 
            btnSearchUsers.BackColor = Color.FromArgb(17, 24, 39);
            btnSearchUsers.FlatAppearance.BorderSize = 0;
            btnSearchUsers.FlatStyle = FlatStyle.Flat;
            btnSearchUsers.ForeColor = Color.FromArgb(140, 140, 150);
            btnSearchUsers.Location = new Point(10, 323);
            btnSearchUsers.Name = "btnSearchUsers";
            btnSearchUsers.Size = new Size(130, 23);
            btnSearchUsers.TabIndex = 4;
            btnSearchUsers.Text = "Search Users";
            btnSearchUsers.TextAlign = ContentAlignment.TopLeft;
            btnSearchUsers.UseVisualStyleBackColor = false;
            btnSearchUsers.Click += btnSearchUsers_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.FromArgb(17, 24, 39);
            btnTransactions.FlatAppearance.BorderSize = 0;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.ForeColor = Color.FromArgb(140, 140, 150);
            btnTransactions.Location = new Point(10, 376);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(130, 23);
            btnTransactions.TabIndex = 5;
            btnTransactions.Text = "Transactions";
            btnTransactions.TextAlign = ContentAlignment.TopLeft;
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnTrustScore
            // 
            btnTrustScore.BackColor = Color.FromArgb(17, 24, 39);
            btnTrustScore.FlatAppearance.BorderSize = 0;
            btnTrustScore.FlatStyle = FlatStyle.Flat;
            btnTrustScore.ForeColor = Color.FromArgb(140, 140, 150);
            btnTrustScore.Location = new Point(10, 429);
            btnTrustScore.Name = "btnTrustScore";
            btnTrustScore.Size = new Size(130, 23);
            btnTrustScore.TabIndex = 6;
            btnTrustScore.Text = "Trust Score";
            btnTrustScore.TextAlign = ContentAlignment.TopLeft;
            btnTrustScore.UseVisualStyleBackColor = false;
            btnTrustScore.Click += btnTrustScore_Click;
            // 
            // btnReviews
            // 
            btnReviews.BackColor = Color.FromArgb(17, 24, 39);
            btnReviews.FlatAppearance.BorderSize = 0;
            btnReviews.FlatStyle = FlatStyle.Flat;
            btnReviews.ForeColor = Color.FromArgb(140, 140, 150);
            btnReviews.Location = new Point(10, 479);
            btnReviews.Name = "btnReviews";
            btnReviews.Size = new Size(130, 23);
            btnReviews.TabIndex = 7;
            btnReviews.Text = "Reviews";
            btnReviews.TextAlign = ContentAlignment.TopLeft;
            btnReviews.UseVisualStyleBackColor = false;
            btnReviews.Click += btnReviews_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(17, 24, 39);
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.ForeColor = Color.FromArgb(140, 140, 150);
            btnSettings.Location = new Point(10, 528);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(130, 23);
            btnSettings.TabIndex = 8;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.TopLeft;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(17, 24, 39);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.FromArgb(140, 140, 150);
            btnLogout.Location = new Point(10, 578);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(130, 23);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.TopLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(17, 24, 39);
            pnlSidebar.Controls.Add(picLogo);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnSettings);
            pnlSidebar.Controls.Add(btnReviews);
            pnlSidebar.Controls.Add(btnTrustScore);
            pnlSidebar.Controls.Add(btnTransactions);
            pnlSidebar.Controls.Add(btnSearchUsers);
            pnlSidebar.Controls.Add(btnQualifications);
            pnlSidebar.Controls.Add(btnVerification);
            pnlSidebar.Controls.Add(btnProfile);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Location = new Point(2, 1);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(176, 775);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.FromArgb(11, 18, 32);
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = Properties.Resources.Icon;
            picLogo.Location = new Point(23, 22);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(80, 80);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 24, 39);
            ClientSize = new Size(1324, 788);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            ForeColor = Color.FromArgb(140, 140, 150);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUserdashboard";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContent;
        private Panel pnlHeader;
        private Label lblPageSubtitle;
        private Label lblPageTitle;
        private Panel pnlSidebar;
        private Button btnLogout;
        private Button btnSettings;
        private Button btnReviews;
        private Button btnTrustScore;
        private Button btnTransactions;
        private Button btnSearchUsers;
        private Button btnQualifications;
        private Button btnVerification;
        private Button btnProfile;
        private Button btnDashboard;
        private PictureBox picLogo;
    }
}