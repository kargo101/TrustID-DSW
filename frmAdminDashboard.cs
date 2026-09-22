using System.Diagnostics;
using TrustID.Models;
using TrustID.Services;

namespace user_dashboard
{
    public partial class frmAdminDashboard : Form
    {
        private readonly UserManager _userManager = Program.SharedUserManager;
        private readonly VerificationManager _verificationManager = Program.SharedVerificationManager;
        private readonly ReviewManager _reviewManager = Program.SharedReviewManager;

        private int _selectedRequestId = -1;
        private bool showingQualifications = false;
        private int _selectedQualificationRowIndex = -1;
        private int _selectedFlaggedReviewId1 = -1;
        private int _selectedFlaggedReviewId2 = -1;
        public frmAdminDashboard()
        {
            InitializeComponent();
            this.Load += frmAdminDashboard_Load;
            this.Activated += frmAdminDashboard_Activated;
            btnTabFlaggedReviews.Click += btnTabFlaggedReviews_Click;

            PremiumFormDesign.Apply(this, "AdminDashboard");


            ConfigureVerificationGrid();

            // Verification events
            dgvSubmissionsQueue.CellClick += dgvSubmissionsQueue_CellClick;
            dgvSubmissionsQueue.CellContentClick += dgvSubmissionsQueue_CellContentClick;

            btnAcceptClaim.Click += btnApproveClaim_Click;
            btnRejectClaim.Click += btnRejectClaim_Click;

            // Dashboard
            btnDashboard.Click += btnDashboard_Click;
        }
        private void btnTabFlaggedReviews_Click(object sender, EventArgs e)
        {
            LoadFlaggedReviews();
        }
        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            LoadUsersFromFile();
            LoadUsersGrid();
            LoadUserStatistics();
            LoadVerificationGrid();
            ShowPanel(pnlMainContent);
            SetActiveSidebarButton(btnManageUsers);
        }

        // ============================================================
        // USER LOADING
        // ============================================================

        private void LoadUsersFromFile()
        {
            string filePath = Path.Combine(
                Application.StartupPath,
                "users.txt"
            );

            _userManager.LoadUsersFromFile(filePath);
        }

        // ============================================================
        // VERIFICATION QUEUE
        // ============================================================

        private void LoadVerificationGrid()
        {
            dgvSubmissionsQueue.Rows.Clear();

            List<VerificationRequest> pending =
                _verificationManager.GetPendingRequests()
                .OrderByDescending(r => r.SubmittedDate)
                .ToList();

            lblActiveSubmissionsTitle.Text =
                $"Active Submissions ({pending.Count})";

            foreach (VerificationRequest request in pending)
            {
                int rowIndex = dgvSubmissionsQueue.Rows.Add(
                    request.Applicant.FullName,
                    request.DocumentType,
                    request.Priority.ToString().ToUpper(),
                    request.AssignedSpecialist,
                    "View File"
                );

                // Store the real request ID without displaying it.
                dgvSubmissionsQueue.Rows[rowIndex].Tag =
                    request.RequestId;
            }
        }

        private void ConfigureVerificationGrid()
        {
            if (dgvSubmissionsQueue.Columns["colAction"] != null)
            {
                int index =
                    dgvSubmissionsQueue.Columns["colAction"].Index;

                dgvSubmissionsQueue.Columns.Remove("colAction");

                DataGridViewButtonColumn buttonColumn =
                    new DataGridViewButtonColumn();

                buttonColumn.Name = "colAction";
                buttonColumn.HeaderText = "Action";
                buttonColumn.Text = "View File";
                buttonColumn.UseColumnTextForButtonValue = true;

                dgvSubmissionsQueue.Columns.Insert(
                    index,
                    buttonColumn
                );
            }
        }

        // ============================================================
        // SELECT VERIFICATION REQUEST
        // ============================================================

        private void dgvSubmissionsQueue_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (showingQualifications)
            {
                _selectedQualificationRowIndex = e.RowIndex;
                return;
            }
            DataGridViewRow row =
                dgvSubmissionsQueue.Rows[e.RowIndex];

            if (row.Tag == null)
                return;

            int requestId =
                Convert.ToInt32(row.Tag);

            VerificationRequest request =
                _verificationManager.Requests
                .FirstOrDefault(r => r.RequestId == requestId);

            if (request == null)
                return;

            _selectedRequestId = requestId;

            LoadVerificationInspector(request);
        }

        // ============================================================
        // VIEW FILE BUTTON
        // ============================================================

        private void dgvSubmissionsQueue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvSubmissionsQueue.Columns[e.ColumnIndex].Name != "colAction")
                return;

            DataGridViewRow row = dgvSubmissionsQueue.Rows[e.RowIndex];

            if (showingQualifications)
            {
                // QUALIFICATION MODE

                if (row.Tag == null)
                    return;

                int lineIndex = Convert.ToInt32(row.Tag);

                string path = Path.Combine(
                    Application.StartupPath,
                    "qualifications.txt");

                if (!File.Exists(path))
                    return;

                string[] lines = File.ReadAllLines(path);

                if (lineIndex < 0 || lineIndex >= lines.Length)
                    return;

                string[] parts = lines[lineIndex].Split(',');

                if (parts.Length < 7)
                {
                    MessageBox.Show(
                        "This qualification does not have a document.",
                        "No Document",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string documentPath = parts[6];

                if (string.IsNullOrWhiteSpace(documentPath) ||
                    !File.Exists(documentPath))
                {
                    MessageBox.Show(
                        "The uploaded qualification document could not be found.",
                        "File Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = documentPath,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "The document could not be opened.\n\n" + ex.Message,
                        "Unable to Open File",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                return;
            }

            // IDENTITY VERIFICATION MODE
            if (row.Tag == null)
                return;

            int requestId = Convert.ToInt32(row.Tag);

            VerificationRequest request =
                _verificationManager.Requests
                .FirstOrDefault(r => r.RequestId == requestId);

            if (request == null)
                return;

            _selectedRequestId = requestId;
            LoadVerificationInspector(request);

            if (!File.Exists(request.DocumentPath))
            {
                MessageBox.Show(
                    "The uploaded document could not be found.",
                    "File Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = request.DocumentPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The document could not be opened.\n\n" + ex.Message,
                    "Unable to Open File",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // VERIFICATION INSPECTOR
        // ============================================================

        private void LoadVerificationInspector(
            VerificationRequest request)
        {
            User applicant = request.Applicant;

            lblInspectorTitle.Text =
                $"Verification Inspector - {applicant.FullName}";

            lblAttachmentLabel.Text =
                request.DocumentType.ToUpper();

            txtRejectionReason.Clear();

            chkLivenessVerification.Checked = false;
            chkDocumentExpiration.Checked = false;
            chkCryptographicSignature.Checked = false;

            LoadDocumentPreview(request.DocumentPath);
        }

        private void LoadDocumentPreview(string documentPath)
        {
            // Dispose the previous image first.
            if (pbAttachmentImage.Image != null)
            {
                Image oldImage = pbAttachmentImage.Image;
                pbAttachmentImage.Image = null;
                oldImage.Dispose();
            }

            if (string.IsNullOrWhiteSpace(documentPath))
            {
                lblAttachmentLabel.Text =
                    "NO ATTACHMENT";

                return;
            }

            if (!File.Exists(documentPath))
            {
                lblAttachmentLabel.Text =
                    "FILE NOT FOUND";

                return;
            }

            string extension =
                Path.GetExtension(documentPath).ToLower();

            if (extension == ".jpg" ||
                extension == ".jpeg" ||
                extension == ".png" ||
                extension == ".bmp")
            {
                using (Image original =
                    Image.FromFile(documentPath))
                {
                    pbAttachmentImage.Image =
                        new Bitmap(original);
                }

                pbAttachmentImage.SizeMode =
                    PictureBoxSizeMode.Zoom;

                lblAttachmentLabel.Text =
                    $"SUBMITTED ATTACHMENT: " +
                    $"{Path.GetFileName(documentPath)}";
            }
            else
            {
                lblAttachmentLabel.Text =
                    $"DOCUMENT: " +
                    $"{Path.GetFileName(documentPath)}";

                pbAttachmentImage.Image = null;
            }
        }

        private void ClearVerificationInspector()
        {
            _selectedRequestId = -1;

            lblInspectorTitle.Text =
                "Verification Inspector";

            lblAttachmentLabel.Text =
                "SUBMITTED ATTACHMENT";

            if (pbAttachmentImage.Image != null)
            {
                Image oldImage =
                    pbAttachmentImage.Image;

                pbAttachmentImage.Image = null;

                oldImage.Dispose();
            }

            chkLivenessVerification.Checked = false;
            chkDocumentExpiration.Checked = false;
            chkCryptographicSignature.Checked = false;

            txtRejectionReason.Clear();
        }

        // ============================================================
        // COMPLIANCE CHECKS
        // ============================================================

        private bool ComplianceChecksPassed()
        {
            return chkLivenessVerification.Checked &&
                   chkDocumentExpiration.Checked &&
                   chkCryptographicSignature.Checked;
        }

        // ============================================================
        // APPROVE VERIFICATION
        // ============================================================
        private void ApproveSelectedQualification()
        {
            if (_selectedQualificationRowIndex == -1)
            {
                MessageBox.Show(
                    "Select a qualification submission first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DataGridViewRow selectedRow =
                dgvSubmissionsQueue.Rows[_selectedQualificationRowIndex];

            if (selectedRow.Tag == null)
                return;

            int lineIndex = Convert.ToInt32(selectedRow.Tag);

            string path = Path.Combine(
                Application.StartupPath,
                "qualifications.txt");

            if (!File.Exists(path))
                return;

            string[] lines = File.ReadAllLines(path);

            if (lineIndex < 0 || lineIndex >= lines.Length)
                return;

            string[] parts = lines[lineIndex].Split(',');

            if (parts.Length < 8)
                return;

            parts[7] = "Approved";

            User applicant = _userManager.Users.FirstOrDefault(
            u => u.Email.Equals(
            parts[1],
            StringComparison.OrdinalIgnoreCase));

            if (applicant != null)
            {
                applicant.TrustScore.QualificationApproved();
                _userManager.SaveChanges();
            }

            lines[lineIndex] = string.Join(",", parts);

            File.WriteAllLines(path, lines);

            MessageBox.Show(
                "Qualification approved successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            _selectedQualificationRowIndex = -1;

            LoadQualificationGrid();
        }
        private void btnApproveClaim_Click(
            object sender,
            EventArgs e)
        {
            if (showingQualifications)
            {
                ApproveSelectedQualification();
                return;
            }
            if (_selectedRequestId == -1)
            {
                MessageBox.Show(
                    "Select a verification submission first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            if (!ComplianceChecksPassed())
            {
                MessageBox.Show(
                    "Please complete all compliance checks before approving the verification.",
                    "Compliance Check",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                _verificationManager.ApproveRequest(
                    _selectedRequestId
                );

                _userManager.SaveChanges();

                MessageBox.Show(
                    "Verification approved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ClearVerificationInspector();

                LoadVerificationGrid();
                LoadUsersGrid();
            }
            catch (TrustID.Exceptions.ValidationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // REJECT VERIFICATION
        // ============================================================
        private void RejectSelectedQualification()
        {
            if (_selectedQualificationRowIndex == -1)
            {
                MessageBox.Show(
                    "Select a qualification submission first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtRejectionReason.Text))
            {
                MessageBox.Show(
                    "Please provide a rejection reason.",
                    "Rejection Reason Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtRejectionReason.Focus();
                return;
            }

            DataGridViewRow selectedRow =
                dgvSubmissionsQueue.Rows[_selectedQualificationRowIndex];

            if (selectedRow.Tag == null)
                return;

            int lineIndex = Convert.ToInt32(selectedRow.Tag);

            string path = Path.Combine(
                Application.StartupPath,
                "qualifications.txt");

            if (!File.Exists(path))
                return;

            string[] lines = File.ReadAllLines(path);

            if (lineIndex < 0 || lineIndex >= lines.Length)
                return;

            string[] parts = lines[lineIndex].Split(',');

            if (parts.Length < 8)
                return;

            parts[7] = "Rejected";
            User applicant = _userManager.Users.FirstOrDefault(
            u => u.Email.Equals(
            parts[1],
            StringComparison.OrdinalIgnoreCase));

            if (applicant != null)
            {
                applicant.TrustScore.QualificationRejected();
                _userManager.SaveChanges();
            }
            if (parts.Length >= 9)
                parts[8] = txtRejectionReason.Text.Trim();
            else
                Array.Resize(ref parts, 9);

            lines[lineIndex] = string.Join(",", parts);

            File.WriteAllLines(path, lines);

            MessageBox.Show(
                "Qualification rejected successfully.",
                "Rejected",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            _selectedQualificationRowIndex = -1;

            txtRejectionReason.Clear();

            LoadQualificationGrid();
        }
        private void btnRejectClaim_Click(
            object sender,
            EventArgs e)
        {
            if (showingQualifications)
            {
                RejectSelectedQualification();
                return;
            }
            if (_selectedRequestId == -1)
            {
                MessageBox.Show(
                    "Select a submission from the list first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            if (string.IsNullOrWhiteSpace(
                txtRejectionReason.Text))
            {
                MessageBox.Show(
                    "Please provide a rejection reason.",
                    "Rejection Reason Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtRejectionReason.Focus();

                return;
            }

            try
            {
                _verificationManager.RejectRequest(
                    _selectedRequestId,
                    txtRejectionReason.Text
                );

                _userManager.SaveChanges();

                MessageBox.Show(
                    "Verification rejected.",
                    "Rejected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ClearVerificationInspector();

                LoadVerificationGrid();
                LoadUsersGrid();
            }
            catch (TrustID.Exceptions.ValidationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ============================================================
        // REPORTS
        // ============================================================

        private void LoadReports()
        {
            List<User> users =
                _userManager.Users.ToList();

            int totalUsers =
                users.Count;

            string transactionsFile =
                Path.Combine(
                    Application.StartupPath,
                    "transactions.txt"
                );

            int totalTransactions = 0;

            if (File.Exists(transactionsFile))
            {
                totalTransactions =
                    File.ReadAllLines(transactionsFile)
                    .Count(
                        line => !string.IsNullOrWhiteSpace(line)
                    );
            }

            int pendingVerifications =
                _verificationManager
                .GetPendingRequests()
                .Count;

            double averageTrustScore =
                users.Count == 0
                    ? 0
                    : users.Average(
                        u => u.TrustScore.CurrentScore
                    );

            int verificationRequests =
                _verificationManager.Requests.Count;

            int approvedRequests =
                _verificationManager.Requests.Count(
                    r => r.Status ==
                         RequestStatus.Approved
                );

            double verificationRate =
                verificationRequests == 0
                    ? 0
                    : (double)approvedRequests /
                      verificationRequests *
                      100;

            lblNumberOfTotalUsers.Text =
                totalUsers.ToString();

            lblNumberOfTotalTransactions.Text =
                totalTransactions.ToString();

            lblWaitingForVerifications.Text =
                $"Awaiting verification: " +
                $"{pendingVerifications}";

            lblCalcuAvgTrustScore.Text =
                Math.Round(
                    averageTrustScore,
                    1
                ).ToString();

            lblVeriRate.Text =
                $"{Math.Round(
                    verificationRate,
                    1
                )}%";
        }

        private void LoadHighestRatedUsers()
        {
            List<User> rankedUsers =
                _userManager.Users
                .OrderByDescending(
                    u => u.TrustScore.CurrentScore
                )
                .Take(3)
                .ToList();

            SetRankingUser(
                rankedUsers,
                0,
                lblFirstHighestRatedPerson,
                lblTrustScoreFirstPlace,
                lblFirstPersonVerification
            );

            SetRankingUser(
                rankedUsers,
                1,
                lblSecondHighestRatedPerson,
                lblTrustScoreSecondPlace,
                lblSecondPersonVerification
            );

            SetRankingUser(
                rankedUsers,
                2,
                lblThirdHighestRatedPerson,
                lblTrustScoreThirdPlace,
                lblThirdPersonVerification
            );
        }

        private void SetRankingUser(
            List<User> users,
            int index,
            Label nameLabel,
            Label scoreLabel,
            Label verificationLabel)
        {
            if (index >= users.Count)
            {
                nameLabel.Text =
                    "No user";

                scoreLabel.Text =
                    "0";

                verificationLabel.Text =
                    "Not verified";

                return;
            }

            User user =
                users[index];

            nameLabel.Text =
                user.FullName;

            scoreLabel.Text =
                user.TrustScore.CurrentScore
                .ToString();

            verificationLabel.Text =
                user.VerificationStatus ==
                VerificationStatus.Verified
                    ? "Verified"
                    : "Not verified";
        }

        // ============================================================
        // USER GRID
        // ============================================================

        private void LoadUsersGrid(
            List<User>? usersToShow = null)
        {
            dgvUsers.Rows.Clear();

            List<User> list =
                usersToShow ??
                _userManager.Users.ToList();

            foreach (User user in list)
            {
                dgvUsers.Rows.Add(
                    user.UserId,
                    user.FullName,
                    user.Email,
                    user.GetUserTypeLabel(),
                    user.TrustScore.CurrentScore,
                    user.AccountStatus.ToString(),
                    user.JoinedDate.ToString(
                        "MMM dd, yyyy"
                    ),
                    user.AccountStatus ==
                    AccountStatus.Suspended
                        ? "Reactivate"
                        : "Suspend"
                );
            }
        }

        // ============================================================
        // SEARCH USERS
        // ============================================================

        private void txtSearchUser_TextChanged(
            object sender,
            EventArgs e)
        {
            string searchText =
                txtSearchUser.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText) ||
                searchText == "Search user profile...")
            {
                LoadUsersGrid();
                return;
            }

            List<User> results =
                _userManager.SearchUsers(
                    searchText
                );

            LoadUsersGrid(results);
        }

        // ============================================================
        // SIDEBAR
        // ============================================================

        private void btnDashboard_Click(
            object sender,
            EventArgs e)
        {
            ShowPanel(pnlMainContent);

            SetActiveSidebarButton(btnDashboard);

            lblHeaderTitle.Text =
                "Admin Dashboard";

            lblHeaderSubtitle.Text =
                "Monitor TrustID users, verification activity, and platform operations";

            LoadUsersGrid();
            LoadVerificationGrid();
            LoadUserStatistics();
        }

        private void btnManageUsers_Click(
            object sender,
            EventArgs e)
        {
            ShowPanel(pnlMainContent);

            SetActiveSidebarButton(
                btnManageUsers
            );

            lblHeaderTitle.Text =
                "User Directory and Administration";

            lblHeaderSubtitle.Text =
                "Audit platform members, access scopes, and reputation standing";

            LoadUsersGrid();
            LoadUserStatistics();
        }

        private void btnVerification_Click(
            object sender,
            EventArgs e)
        {
            ShowPanel(
                pnlVerificationContent
            );

            SetActiveSidebarButton(
                btnVerification
            );

            lblHeaderTitle.Text =
                "Active Verification Queue";

            lblHeaderSubtitle.Text =
                "Pending credential claims requiring secondary automated and manual verification";

            LoadVerificationGrid();
        }

        private void btnReports_Click(
            object sender,
            EventArgs e)
        {
            ShowPanel(
                pnlReportsContent
            );

            SetActiveSidebarButton(
                btnReports
            );

            lblHeaderTitle.Text =
                "Platform Reports & Analytics";

            lblHeaderSubtitle.Text =
                "Analyze transaction records, identity distributions, and verification rates";

            LoadReports();
            LoadHighestRatedUsers();
        }

        private void btnReviews_Click(
            object sender,
            EventArgs e)
        {
            ShowPanel(
                pnlReviewsContent
            );

            SetActiveSidebarButton(
                btnReviews
            );

            lblHeaderTitle.Text =
                "Reported Reviews & Accounts";

            lblHeaderSubtitle.Text =
                "Review flagged content and take appropriate administrative action";
        }

        private void btnSettings_Click(
            object sender,
            EventArgs e)
        {
            ShowPanel(
                pnlSettingsContent
            );

            SetActiveSidebarButton(
                btnSettings
            );

            lblHeaderTitle.Text =
                "Settings";

            lblHeaderSubtitle.Text =
                "Manage your profile, security settings, and notification preferences";
        }

        private void ShowPanel(
            Panel panelToShow)
        {
            pnlMainContent.Visible = false;
            pnlVerificationContent.Visible = false;
            pnlReportsContent.Visible = false;
            pnlReviewsContent.Visible = false;
            pnlSettingsContent.Visible = false;

            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }

        private void SetActiveSidebarButton(
            Button activeButton)
        {
            Button[] sidebarButtons =
            {
                btnDashboard,
                btnManageUsers,
                btnVerification,
                btnReports,
                btnReviews,
                btnSettings
            };

            foreach (Button btn in sidebarButtons)
            {
                btn.BackColor =
                    Color.FromArgb(
                        20,
                        24,
                        38
                    );

                btn.ForeColor =
                    Color.FromArgb(
                        140,
                        140,
                        150
                    );
            }

            activeButton.BackColor =
                Color.FromArgb(
                    30,
                    40,
                    55
                );

            activeButton.ForeColor =
                Color.White;
        }

        // ============================================================
        // LOGOUT
        // ============================================================

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to log out?",
                    "Confirm Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                AuthenticationManager.Instance.Logout();

                Program.CurrentUser = null;

                this.Close();
            }
        }

        // ============================================================
        // HEADER
        // ============================================================

        private void lblHeaderSubtitle_Click(
            object sender,
            EventArgs e)
        {
        }

        // ============================================================
        // CREATE USER
        // ============================================================

        private void btnCreateUser_Click(
            object sender,
            EventArgs e)
        {
            using (frmCreateUser createForm =
                   new frmCreateUser())
            {
                if (createForm.ShowDialog() ==
           DialogResult.OK)
                {
                    try
                    {
                        _userManager.Register(
                            createForm.CreatedUser
                        );

                        LoadUsersGrid();
                        LoadUserStatistics();

                        MessageBox.Show(
                            "User created successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (
                        TrustID.Exceptions.ValidationException ex)
                    {
                        MessageBox.Show(
                            ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }

        }

        // ============================================================
        // SUSPEND / REACTIVATE USER
        // ============================================================

        private void dgvUsers_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvUsers.Columns[e.ColumnIndex].Name !=
                "colActions")
            {
                return;
            }

            int userId =
                Convert.ToInt32(
                    dgvUsers.Rows[e.RowIndex]
                    .Cells["colUserId"]
                    .Value
                );

            try
            {
                User user =
                    _userManager.GetById(userId);

                if (user.AccountStatus ==
                    AccountStatus.Suspended)
                {
                    _userManager.ReactivateUser(
                        userId
                    );
                }
                else
                {
                    DialogResult confirm =
                        MessageBox.Show(
                            $"Suspend {user.FullName}'s account?",
                            "Confirm Suspend",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                    if (confirm ==
                        DialogResult.Yes)
                    {
                        _userManager.SuspendUser(
                            userId
                        );
                    }
                }

                LoadUsersGrid();
                LoadUserStatistics();
            }
            catch (
                TrustID.Exceptions.ValidationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void LoadUserStatistics()
        {
            List<User> users = _userManager.Users.ToList();

            int totalUsers = users.Count;

            int suspendedUsers = users.Count(
                u => u.AccountStatus == AccountStatus.Suspended
            );

            int activeUsers = users.Count(
                u => u.AccountStatus == AccountStatus.Active
            );

            DateTime startOfMonth = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month,
                1
            );

            int newUsersThisMonth = users.Count(
                u => u.JoinedDate >= startOfMonth
            );

            double activeRate = totalUsers == 0
                ? 0
                : (double)activeUsers / totalUsers * 100;

            lblNumberOfSuspendeFlagged.Text =
                suspendedUsers.ToString();

            lblNumberOfSignups.Text =
                $"+{newUsersThisMonth}";

            lblNumberOfActive.Text =
                activeUsers.ToString();

            lblTotalUsers.Text =
                totalUsers.ToString();

            lblTotalUsersChange.Text =
                $"+{newUsersThisMonth} this month";

            lblRateOfConcurrent.Text =
                $"{Math.Round(activeRate, 1)}% active rate";
        }

        private void btnQualificationVerification_Click(object sender, EventArgs e)
        {
            showingQualifications = !showingQualifications;

            if (showingQualifications)
            {
                // QUALIFICATION MODE
                btnQualificationVerification.Text = "Identity Verification";

                ConfigureQualificationGrid();
                LoadQualificationGrid();
            }
            else
            {
                // IDENTITY VERIFICATION MODE
                btnQualificationVerification.Text = "Qualification Submissions";

                ConfigureVerificationGrid();

                dgvSubmissionsQueue.Columns["colSubmitter"].HeaderText = "Submitter";
                dgvSubmissionsQueue.Columns["colDocumentType"].HeaderText = "Document Type";
                dgvSubmissionsQueue.Columns["colPriority"].HeaderText = "Priority";
                dgvSubmissionsQueue.Columns["colAssignedSpecialist"].HeaderText = "Assigned Specialist";
                dgvSubmissionsQueue.Columns["colAction"].HeaderText = "Action";

                LoadVerificationGrid();
            }
        }
        private void frmAdminDashboard_Activated(object sender, EventArgs e)
        {
            if (showingQualifications)
            {
                LoadQualificationGrid();
            }
            else
            {
                LoadVerificationGrid();
            }
            LoadFlaggedReviews();
        }
        private void ConfigureQualificationGrid()
        {
            dgvSubmissionsQueue.Columns["colSubmitter"].HeaderText = "Applicant";
            dgvSubmissionsQueue.Columns["colDocumentType"].HeaderText = "Qualification";
            dgvSubmissionsQueue.Columns["colPriority"].HeaderText = "Institution";
            dgvSubmissionsQueue.Columns["colAssignedSpecialist"].HeaderText = "Year";
            dgvSubmissionsQueue.Columns["colAction"].HeaderText = "Document";
        }
        private void LoadQualificationGrid()
        {
            dgvSubmissionsQueue.Rows.Clear();

            string path = Path.Combine(
                Application.StartupPath,
                "qualifications.txt");

            if (!File.Exists(path))
            {
                lblActiveSubmissionsTitle.Text =
                    "Qualification Submissions (0)";
                return;
            }

            int pendingCount = 0;

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split(',');

                if (parts.Length < 8)
                    continue;

                string status = parts[7];

                if (!status.Equals(
                        "Pending",
                        StringComparison.OrdinalIgnoreCase))
                    continue;

                string name = parts[0];
                string qualification = parts[3];
                string institution = parts[4];
                string year = parts[5];

                int rowIndex = dgvSubmissionsQueue.Rows.Add(
                    name,
                    qualification,
                    institution,
                    year,
                    "View Document");

                // Store the line number so we know exactly which
                // qualification the administrator selected.
                dgvSubmissionsQueue.Rows[rowIndex].Tag =
                    Array.IndexOf(lines, line);

                pendingCount++;
            }

            lblActiveSubmissionsTitle.Text =
                $"Qualification Submissions ({pendingCount})";
        }

        private void LoadFlaggedReviews()
        {
            _selectedFlaggedReviewId1 = -1;
            _selectedFlaggedReviewId2 = -1;
            List<Review> flaggedReviews =
                _reviewManager.GetFlaggedReviews();

            // Hide the existing cards first.
            pnlReviewUser1.Visible = false;
            pnlReviewer2.Visible = false;

            // Nothing to display.
            if (flaggedReviews.Count == 0)
                return;

            // -------------------------
            // FIRST FLAGGED REVIEW
            // -------------------------

            Review review1 = flaggedReviews[0];
            if (review1.Reviewer == null ||
                review1.ReviewedUser == null)
            {
                MessageBox.Show(
                    "This review has missing user information.",
                    "Invalid Review",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            _selectedFlaggedReviewId1 = review1.ReviewId;
            pnlReviewUser1.Visible = true;

            lblReviewer1.Text =
                "Reviewer:\r\n" +
                review1.Reviewer.FullName;

            lblFlaggedUser.Text =
                "About: " +
                review1.ReviewedUser.FullName;

            txtReviewUser1.Text =
                review1.Comment;

            lblReasonForFlagUser1.Text =
                review1.FlagReason;


            // -------------------------
            // SECOND FLAGGED REVIEW
            // -------------------------

            if (flaggedReviews.Count > 1)
            {
                Review review2 = flaggedReviews[1];
                _selectedFlaggedReviewId2 = review2.ReviewId;

                pnlReviewer2.Visible = true;

                lblReviewer2.Text =
                    "Reviewer:\r\n" +
                    review2.Reviewer.FullName;

                lblReviewedUser.Text =
                    "About: " +
                    review2.ReviewedUser.FullName;

                textBox2.Text =
                    review2.Comment;

                lblReasonForFlagUser2.Text =
                    review2.FlagReason;
            }
        }

        private void pnlMainContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDismissReport_Click(object sender, EventArgs e)
        {
            if (_selectedFlaggedReviewId1 == -1)
            {
                MessageBox.Show(
                    "There is no flagged review to dismiss.",
                    "No Review",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            try
            {
                _reviewManager.DismissReport(
                    _selectedFlaggedReviewId1);

                Program.SharedUserManager.SaveChanges();

                MessageBox.Show(
                    "Report dismissed successfully.",
                    "Report Dismissed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadFlaggedReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Dismiss Report",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveReview_Click(object sender, EventArgs e)
        {
            if (_selectedFlaggedReviewId1 == -1)
            {
                MessageBox.Show(
                    "There is no flagged review to remove.",
                    "No Review",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this review?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _reviewManager.RemoveReview(
                    _selectedFlaggedReviewId1);

                MessageBox.Show(
                    "Review removed successfully.",
                    "Review Removed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadFlaggedReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Remove Review",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnSuspendReviewer_Click(object sender, EventArgs e)
        {
            if (_selectedFlaggedReviewId1 == -1)
            {
                MessageBox.Show("There is no first flagged review to suspend the reviewer for.",
                "No Review",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to suspend this reviewer?",
                                                   "Confirm Suspension",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;
            try
            {
                _reviewManager.SuspendReviewer(_selectedFlaggedReviewId1);
                Program.SharedUserManager.SaveChanges();
                MessageBox.Show("Reviewer suspended successfully.",
                "Reviewer Suspended",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                LoadFlaggedReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Suspend Reviewer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void pnlMainContent_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnRemoveReview_Click_1(object sender, EventArgs e)
        {
            if (_selectedFlaggedReviewId1 == -1)
            {
                MessageBox.Show("There is no first flagged review to remove.",
                "No Review",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to remove this review?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;
            try { _reviewManager.RemoveReview(_selectedFlaggedReviewId1); 
                MessageBox.Show("Review removed successfully.", 
                    "Review Removed", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information); 
                LoadFlaggedReviews();
            }
            catch (Exception ex) 
            { MessageBox.Show(ex.Message,
                "Unable to Remove Review", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void btnDismissReport_Click_1(object sender, EventArgs e)
        {
            if (_selectedFlaggedReviewId1 == -1) 
            { 
                MessageBox.Show("There is no first flagged review to dismiss.", 
                    "No Review", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information); 
                return;
            }
            try { 
                _reviewManager.DismissReport(_selectedFlaggedReviewId1); 
                Program.SharedUserManager.SaveChanges(); 
                MessageBox.Show("Report dismissed successfully.", 
                    "Report Dismissed", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                LoadFlaggedReviews(); 
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message, 
                    "Unable to Dismiss Report", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning); 
            }
        }

        private void btnRemoveReview2_Click(object sender, EventArgs e)
        {
            if (_selectedFlaggedReviewId2 == -1)
            {
                MessageBox.Show(
                    "There is no second flagged review to remove.",
                    "No Review",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this review?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _reviewManager.RemoveReview(
                    _selectedFlaggedReviewId2);

                MessageBox.Show(
                    "Review removed successfully.",
                    "Review Removed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadFlaggedReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Remove Review",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnDissmissReport2_Click(object sender, EventArgs e)
        {
            if (_selectedFlaggedReviewId2 == -1)
            {
                MessageBox.Show(
                    "There is no second flagged review to dismiss.",
                    "No Review",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            try
            {
                _reviewManager.DismissReport(
                    _selectedFlaggedReviewId2);

                Program.SharedUserManager.SaveChanges();

                MessageBox.Show(
                    "Report dismissed successfully.",
                    "Report Dismissed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadFlaggedReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Dismiss Report",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void btnSuspendReviewer2_Click(object sender, EventArgs e)
        {
            if (_selectedFlaggedReviewId2 == -1)
            {
                MessageBox.Show("There is no second flagged review to suspend the reviewer for.",
                    "No Review",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to suspend this reviewer?",
                "Confirm Suspension",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;
            try
            {
                _reviewManager.SuspendReviewer(_selectedFlaggedReviewId2);
                Program.SharedUserManager.SaveChanges();
                MessageBox.Show("Reviewer suspended successfully.",
                "Reviewer Suspended",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                LoadFlaggedReviews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "" +
                "Unable to Suspend Reviewer",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
    }
}