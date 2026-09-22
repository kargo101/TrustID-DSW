using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _1September
{
    public partial class UserDashboard : Form
    {
        private User currentUser;
        public UserDashboard(User user)
        {
            InitializeComponent();
            currentUser = user ?? Program.CurrentUser;
            lblWelcome.Text = $"Welcome, {currentUser.Name} {currentUser.SecondName} ";
        }

        private void LoadVerifyControl()
        {
            pnlContent.Controls.Clear();
            UcVerification ucVerification = new UcVerification();
            ucVerification.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(ucVerification);
        }

        private void LoadSettingsControl()
        {
            pnlContent.Controls.Clear();
            UcSettings ucSettings = new UcSettings();
            ucSettings.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(ucSettings);
        }

        private void LoadQualificationsControl()
        {
            pnlContent.Controls.Clear();
            UcQualifications ucQualifications = new UcQualifications();
            ucQualifications.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(ucQualifications);
        }

        private void btnVerification_Click(object sender, EventArgs e)
        {
            LoadVerifyControl();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadSettingsControl();
        }

        private void btnQualifications_Click(object sender, EventArgs e)
        {
            LoadQualificationsControl();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            this.Close();
            loginForm.Show();
            this.Focus();

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            LoadTransactionsControl();
        }

        private void LoadTransactionsControl()
        {
            pnlContent.Controls.Clear();
            UcTransactions ucTransactions = new UcTransactions();
            ucTransactions.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(ucTransactions);
        }
    }
}

            