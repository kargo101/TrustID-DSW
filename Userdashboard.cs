using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TrustID.Models;

namespace user_dashboard
{
    public partial class UserDashboard : Form
    {
        private User currentUser;

        public UserDashboard(User user)
        {
            InitializeComponent();
            PremiumFormDesign.ApplyDashboardShell(this);

            currentUser = user;

            LoadDashboardControl();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
        }

        private void SetHeader(string title, string subtitle)
        {
            lblPageTitle.Text = title;
            lblPageSubtitle.Text = subtitle;
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {
        }

        // ==========================================
        // DASHBOARD
        // ==========================================

        private void LoadDashboardControl()
        {
            pnlContent.Controls.Clear();

            SetHeader(
                "Dashboard",
                "Overview of your TrustID profile and recent activity"
            );

            UcDashboard ucDashboard = new UcDashboard();

            ucDashboard.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(ucDashboard);
        }


        // ==========================================
        // PROFILE
        // ==========================================

        private void LoadProfileControl()
        {
            pnlContent.Controls.Clear();

            SetHeader(
                "Profile",
                "Manage your public reputation and connected networks"
            );

            UcProfile ucProfile = new UcProfile();

            ucProfile.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(ucProfile);
        }


        // ==========================================
        // TRUST SCORE
        // ==========================================

        private void LoadTrustScoreControl()
        {
            pnlContent.Controls.Clear();

            SetHeader(
                "Trust Score",
                "See your current score and what affects it"
            );

            UcTrustScore ucTrustScore = new UcTrustScore();

            ucTrustScore.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(ucTrustScore);
        }


        // ==========================================
        // REVIEWS
        // ==========================================

        private void LoadReviewsControl()
        {
            pnlContent.Controls.Clear();

            SetHeader(
                "Reviews",
                "View ratings and feedback from other users"
            );

            UcReviews ucReviews = new UcReviews();

            ucReviews.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(ucReviews);
        }


        // ==========================================
        // SEARCH USERS
        // ==========================================

        private void LoadSearchUsersControl()
        {
            pnlContent.Controls.Clear();

            SetHeader(
                "Search Users",
                "Search and view verified professional identities"
            );

            UcSearchRegistry ucSearchRegistry = new UcSearchRegistry();

            ucSearchRegistry.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(ucSearchRegistry);
        }


        // ==========================================
        // VERIFICATION
        // ==========================================

        private void LoadVerifyControl()
        {
            pnlContent.Controls.Clear();

            SetHeader(
                "Verification Center",
                "Submit documents and follow your verification requests"
            );

            UcVerification ucVerification = new UcVerification();

            ucVerification.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(ucVerification);
        }


        // ==========================================
        // SETTINGS
        // ==========================================

        private void LoadSettingsControl()
        {
            pnlContent.Controls.Clear();

            SetHeader(
                "Settings",
                "Manage your profile, security settings, and notification preferences"
            );

            UcSettings ucSettings = new UcSettings();

            ucSettings.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(ucSettings);
        }


        // ==========================================
        // QUALIFICATIONS
        // ==========================================

        private void LoadQualificationsControl()
        {
            pnlContent.Controls.Clear();

            SetHeader(
                "Qualifications & Credentials",
                "Add and view your qualifications"
            );

            UcQualifications ucQualifications = new UcQualifications();

            ucQualifications.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(ucQualifications);
        }


        // ==========================================
        // TRANSACTIONS
        // ==========================================

        private void LoadTransactionsControl()
        {
            pnlContent.Controls.Clear();

            SetHeader(
                "Transaction History",
                "Record transactions and view your saved history"
            );

            UcTransactions ucTransactions = new UcTransactions();

            ucTransactions.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(ucTransactions);
        }


        // ==========================================
        // SIDEBAR BUTTONS
        // ==========================================

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PremiumFormDesign.SetActiveNav(this, btnDashboard);
            LoadDashboardControl();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            PremiumFormDesign.SetActiveNav(this, btnProfile);
            LoadProfileControl();
        }

        private void btnVerification_Click(object sender, EventArgs e)
        {
            PremiumFormDesign.SetActiveNav(this, btnVerification);
            LoadVerifyControl();
        }

        private void btnQualifications_Click(object sender, EventArgs e)
        {
            PremiumFormDesign.SetActiveNav(this, btnQualifications);
            LoadQualificationsControl();
        }

        private void btnSearchUsers_Click(object sender, EventArgs e)
        {
            PremiumFormDesign.SetActiveNav(this, btnSearchUsers);
            LoadSearchUsersControl();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            PremiumFormDesign.SetActiveNav(this, btnTransactions);
            LoadTransactionsControl();
        }

        private void btnTrustScore_Click(object sender, EventArgs e)
        {
            PremiumFormDesign.SetActiveNav(this, btnTrustScore);
            LoadTrustScoreControl();
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            PremiumFormDesign.SetActiveNav(this, btnReviews);
            LoadReviewsControl();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            PremiumFormDesign.SetActiveNav(this, btnSettings);
            LoadSettingsControl();
        }


        // ==========================================
        // LOGOUT
        // ==========================================

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.CurrentUser = null;

            this.Close();
        }
    }
}