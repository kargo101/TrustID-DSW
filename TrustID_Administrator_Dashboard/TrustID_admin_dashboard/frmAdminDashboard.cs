using TrustID.Services;
using TrustID.Models;
namespace TrustID_admin_dashboard
{
    public partial class frmAdminDashboard : Form
    {
        private readonly UserManager _userManager = new UserManager();
        private readonly VerificationManager _verificationManager = new VerificationManager();
        private readonly ReviewManager _reviewManager = new ReviewManager();
        private int _selectedRequestId = -1;
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            SeedSampleData();
            LoadUsersGrid();
            LoadVerificationGrid();

            ShowPanel(pnlMainContent);
            SetActiveSidebarButton(btnManageUsers);
        }
        private void LoadVerificationGrid()
        {
            dgvSubmissionsQueue.Rows.Clear();

            List<VerificationRequest> pending = _verificationManager.GetPendingRequests();

            lblActiveSubmissionsTitle.Text = $"Active Submissions ({pending.Count})";

            foreach (VerificationRequest request in pending)
            {
                dgvSubmissionsQueue.Rows.Add(
                    request.RequestId,
                    request.Applicant.FullName,
                    request.DocumentType,
                    request.Priority.ToString().ToUpper(),
                    request.AssignedSpecialist,
                    "View File"
                );
            }
        }
        private void dgvSubmissionsQueue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            _selectedRequestId = Convert.ToInt32(dgvSubmissionsQueue.Rows[e.RowIndex].Cells["colRequestId"].Value);
        }

        private void btnApproveClaim_Click(object sender, EventArgs e)
        {
            if (_selectedRequestId == -1)
            {
                MessageBox.Show("Select a submission from the list first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _verificationManager.ApproveRequest(_selectedRequestId);
                MessageBox.Show("Verification approved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadVerificationGrid();
                LoadUsersGrid();
                _selectedRequestId = -1;
            }
            catch (TrustID.Exceptions.ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRejectClaim_Click(object sender, EventArgs e)
        {
            if (_selectedRequestId == -1)
            {
                MessageBox.Show("Select a submission from the list first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _verificationManager.RejectRequest(_selectedRequestId, txtRejectionReason.Text);
                MessageBox.Show("Verification rejected.", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadVerificationGrid();
                LoadUsersGrid();
                txtRejectionReason.Text = "";
                _selectedRequestId = -1;
            }
            catch (TrustID.Exceptions.ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SeedSampleData()
        {
            try
            {
                _userManager.Register(new IndividualUser("John Doe", "j.doe@vancetech.com", "johndoe", "Password1", "Engineer"));
                _userManager.Register(new BusinessUser("Jane Smith", "j.smith@trustid.io", "janesmith", "Password1", "Trust Co", "REG12345"));
                _userManager.Register(new IndividualUser("Bob Johnson", "bob.j@gmail.com", "bobjohnson", "Password1", "Designer"));
                _userManager.Register(new IndividualUser("Alice Williams", "alice.w@yahoo.com", "alicew", "Password1", "Analyst"));
                _userManager.Register(new BusinessUser("Charlie Brown", "c.brown@acme.co", "charlieb", "Password1", "Acme Co", "REG67890"));
            }
            catch (TrustID.Exceptions.ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Seed Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                List<User> users = _userManager.Users.ToList();

                _verificationManager.SubmitRequest(users[0], "Government Passport", RequestPriority.High);
                _verificationManager.SubmitRequest(users[1], "AWS Certificate", RequestPriority.Medium);
                _verificationManager.SubmitRequest(users[2], "Doctoral License", RequestPriority.Low);
                _verificationManager.SubmitRequest(users[3], "Incorporation Deed", RequestPriority.High);
            }
            catch (TrustID.Exceptions.ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Seed Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoadUsersGrid(List<User> usersToShow = null)
        {
            dgvUsers.Rows.Clear();

            List<User> list = usersToShow ?? _userManager.Users.ToList();

            if (list.Count == 0)
            {
                return; // search returning no users - not an error, just empty
            }

            foreach (User user in list)
            {
                dgvUsers.Rows.Add(
                    user.UserId,
                    user.FullName,
                    user.Email,
                    user.GetUserTypeLabel(),
                    user.TrustScore.CurrentScore,
                    user.AccountStatus.ToString(),
                    user.JoinedDate.ToString("MMM dd, yyyy")
                );
            }
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            List<User> results = _userManager.SearchUsers(txtSearchUser.Text);
            LoadUsersGrid(results);
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvUsers.Columns[e.ColumnIndex].Name == "colSuspendAction")
            {
                int userId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["colUserId"].Value);

                try
                {
                    User user = _userManager.GetById(userId);

                    if (user.AccountStatus == AccountStatus.Suspended)
                    {
                        _userManager.ReactivateUser(userId);
                    }
                    else
                    {
                        DialogResult confirm = MessageBox.Show(
                            $"Suspend {user.FullName}'s account?",
                            "Confirm Suspend",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (confirm == DialogResult.Yes)
                        {
                            _userManager.SuspendUser(userId);
                        }
                    }

                    LoadUsersGrid();
                }
                catch (TrustID.Exceptions.ValidationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnVerification_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlVerificationContent);
            SetActiveSidebarButton(btnVerification);

            lblHeaderTitle.Text = "Active Verification Queue";
            lblHeaderSubtitle.Text = "Pending credential claims requiring secondary automated and manual verification";
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlMainContent);
            SetActiveSidebarButton(btnManageUsers);

            lblHeaderTitle.Text = "User Directory and Administration";
            lblHeaderSubtitle.Text = "Audit platform members, access scopes, and reputation standing";
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlReportsContent);
            SetActiveSidebarButton(btnReports);

            lblHeaderTitle.Text = "Platform Reports & Analytics";
            lblHeaderSubtitle.Text = "Analyze transaction records, identity distributions, and verification rates";
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlSettingsContent);
            SetActiveSidebarButton(btnSettings);

            lblHeaderTitle.Text = "Settings";
            lblHeaderSubtitle.Text = "Manage your profile, security settings, and notification preferences";
        }

        private void ShowPanel(Panel panelToShow)
        {
            pnlMainContent.Visible = false;
            pnlVerificationContent.Visible = false;
            pnlReportsContent.Visible = false;
            pnlReviewsContent.Visible = false;
            pnlSettingsContent.Visible = false;

            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }
        private void SetActiveSidebarButton(Button activeButton)
        {
            // Reset all sidebar buttons to inactive style
            Button[] sidebarButtons = { btnDashboard, btnManageUsers, btnVerification, btnReports, btnReviews, btnSettings };

            foreach (Button btn in sidebarButtons)
            {
                btn.BackColor = Color.FromArgb(20, 24, 38);
                btn.ForeColor = Color.FromArgb(140, 140, 150);
            }

            // Apply active style to the clicked one
            activeButton.BackColor = Color.FromArgb(30, 40, 55);
            activeButton.ForeColor = Color.White;
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlReviewsContent);
            SetActiveSidebarButton(btnReviews);

            lblHeaderTitle.Text = "Reported Reviews & Accounts";
            lblHeaderSubtitle.Text = "Review flagged content and take appropriate administrative action";

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AuthenticationManager.Instance.Logout();
                Application.Exit();
            }
        }


        private void lblHeaderSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            using (frmCreateUser createForm = new frmCreateUser())
            {
                if (createForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _userManager.Register(createForm.CreatedUser);
                        LoadUsersGrid();
                        MessageBox.Show("User created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (TrustID.Exceptions.ValidationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
