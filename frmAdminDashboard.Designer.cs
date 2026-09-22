namespace user_dashboard
{
    partial class frmAdminDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label lblTrustID;
            pnlMainContent = new Panel();
            cmbRoleFilter = new ComboBox();
            txtSearchUser = new TextBox();
            pnlSuspendedFlagged = new Panel();
            lblActionRequired = new Label();
            lblNumberOfSuspendeFlagged = new Label();
            lblSuspendeFlagged = new Label();
            pnlNewSignups = new Panel();
            lblAwaitingPrimaryReview = new Label();
            lblNumberOfSignups = new Label();
            lblNewSignupsTitle = new Label();
            pnlActiveToday = new Panel();
            lblRateOfConcurrent = new Label();
            lblNumberOfActive = new Label();
            lblActiveToday = new Label();
            pnlReviewsContent = new Panel();
            pnlReviewsSummary = new Panel();
            lbl4Stars = new Label();
            lbl4StarsReceived = new Label();
            lbl3Stars = new Label();
            lbl3StarsReceived = new Label();
            lbl2Stars = new Label();
            lbl2StarsReceived = new Label();
            lbl1Stars = new Label();
            lbl1StarsReceived = new Label();
            lbl5Stars = new Label();
            lbl5StarsReceived = new Label();
            lblNumOfActionsTaken = new Label();
            lblAvgResponseTime = new Label();
            lblRatingDistributionHeading = new Label();
            lblNumOfFlaggedReviews = new Label();
            lblModerationOverviewHeading = new Label();
            pnlReviewsList = new Panel();
            pnlReviewer2 = new Panel();
            btnSuspendReviewer2 = new Button();
            btnRemoveReview2 = new Button();
            lblReasonForFlagUser2 = new Label();
            lblFlaggedUsers = new Label();
            btnDissmissReport2 = new Button();
            textBox2 = new TextBox();
            lblReviewedUser = new Label();
            lblReviewer2 = new Label();
            pnlReviewUser1 = new Panel();
            btnSuspendReviewer = new Button();
            btnRemoveReview = new Button();
            lblReasonForFlagUser1 = new Label();
            lblFlagged = new Label();
            btnDismissReport = new Button();
            txtReviewUser1 = new TextBox();
            lblFlaggedUser = new Label();
            btnTabFlaggedReviews = new Button();
            pnlTotalUsers = new Panel();
            lblTotalUsersChange = new Label();
            lblTotalUsers = new Label();
            lblTotalUsersTitle = new Label();
            dgvUsers = new DataGridView();
            colUserId = new DataGridViewTextBoxColumn();
            colUserProfile = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colIdentityScope = new DataGridViewTextBoxColumn();
            colTrustScore = new DataGridViewTextBoxColumn();
            colAccStatus = new DataGridViewTextBoxColumn();
            colJoinedDate = new DataGridViewTextBoxColumn();
            colActions = new DataGridViewTextBoxColumn();
            cmbStatusFilter = new ComboBox();
            btnCreateUser = new Button();
            pnlSettingsContent = new Panel();
            pnlLogoutOfSession = new Panel();
            lblSubtitleForLogout = new Label();
            lblSessionLogoutHeading = new Label();
            btnLogoutSession = new Button();
            pnlChangePassword = new Panel();
            btnUpdatePassword = new Button();
            lblConfirmNewPassword = new Label();
            txtConfirmNewPassword = new TextBox();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            txtCurrentPassword = new TextBox();
            lblCurrentPassword = new Label();
            lblChangePasswordHeading = new Label();
            pnlEditAccountInformation = new Panel();
            btnSaveChanges = new Button();
            txtEmailAddress = new TextBox();
            lblEmailAddress = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            lblEditAccInforHeading = new Label();
            lblReviewer1 = new Label();
            pnlReportsContent = new Panel();
            pnlHighestRatedIdentities = new Panel();
            lblThirdPersonVerification = new Label();
            lblSecondPersonVerification = new Label();
            lblFirstPersonVerification = new Label();
            lblTrustScoreFirstPlace = new Label();
            lblTrustScoreSecondPlace = new Label();
            lblTrustScoreThirdPlace = new Label();
            lblFirstHighestRatedPerson = new Label();
            lblSecondHighestRatedPerson = new Label();
            lblThirdHighestRatedPerson = new Label();
            lblSecondPlace = new Label();
            lblThirdPlace = new Label();
            lblFirstPlace = new Label();
            lblHighestRatedTitle = new Label();
            pnlTrustScoreDistribution = new Panel();
            pnlUserGrowthChart = new Panel();
            pnlStatTotalTransactions = new Panel();
            lblTotalTransactions = new Label();
            lblAvgSignIns = new Label();
            lblNumberOfTotalTransactions = new Label();
            pnlStatAvgTrustScore = new Panel();
            lblAverageTrustScore = new Label();
            lblExcelledCohort = new Label();
            lblCalcuAvgTrustScore = new Label();
            pnlStatVerificationRate = new Panel();
            lblVerificationRate = new Label();
            lblVeriRate = new Label();
            lblBiometricMatch = new Label();
            pnlStatTotalPlatformUsers = new Panel();
            lblNumberOfTotalUsers = new Label();
            lblWaitingForVerifications = new Label();
            lblTotalPlatformUsers = new Label();
            pnlReportsTabs = new Panel();
            lblTabTransactionAnalytics = new Label();
            lblTabTrustScoreDistribution = new Label();
            lblTabVerificationMetrics = new Label();
            lblTabUserAnalytics = new Label();
            btnPlatformOverviewTab = new Button();
            pnlVerificationContent = new Panel();
            pnlVerificationBody = new Panel();
            btnQualificationVerification = new Button();
            pnlVerificationInspector = new Panel();
            btnRejectClaim = new Button();
            lblRejectionReasonTitle = new Label();
            btnAcceptClaim = new Button();
            chkCryptographicSignature = new CheckBox();
            txtRejectionReason = new TextBox();
            chkDocumentExpiration = new CheckBox();
            chkLivenessVerification = new CheckBox();
            lblComplianceCheck = new Label();
            pnlAttachmentPreview = new Panel();
            pbAttachmentImage = new PictureBox();
            lblAttachmentLabel = new Label();
            lblInspectorTitle = new Label();
            pnlSubmissionsQueue = new Panel();
            dgvSubmissionsQueue = new DataGridView();
            colSubmitter = new DataGridViewTextBoxColumn();
            colDocumentType = new DataGridViewTextBoxColumn();
            colPriority = new DataGridViewTextBoxColumn();
            colAssignedSpecialist = new DataGridViewTextBoxColumn();
            colAction = new DataGridViewTextBoxColumn();
            lblSortNewestFirst = new Label();
            lblActiveSubmissionsTitle = new Label();
            pnlAnomalyWarning = new Panel();
            lnkReviewAnomalyClaims = new LinkLabel();
            lblAnomalyMessage = new Label();
            lblAnomalyIcon = new Label();
            pnlHeader = new Panel();
            lblHeaderTitle = new Label();
            btnNotifications = new Button();
            txtSearchRegistry = new TextBox();
            lblHeaderSubtitle = new Label();
            pnlSidebar = new Panel();
            pnlSidebarBorder = new Panel();
            btnLogout = new Button();
            btnReports = new Button();
            btnSettings = new Button();
            btnReviews = new Button();
            btnVerification = new Button();
            btnManageUsers = new Button();
            btnDashboard = new Button();
            lblLogoAndName = new Label();
            lblTrustID = new Label();
            pnlMainContent.SuspendLayout();
            pnlSuspendedFlagged.SuspendLayout();
            pnlNewSignups.SuspendLayout();
            pnlActiveToday.SuspendLayout();
            pnlReviewsContent.SuspendLayout();
            pnlReviewsSummary.SuspendLayout();
            pnlReviewsList.SuspendLayout();
            pnlReviewer2.SuspendLayout();
            pnlReviewUser1.SuspendLayout();
            pnlTotalUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            pnlSettingsContent.SuspendLayout();
            pnlLogoutOfSession.SuspendLayout();
            pnlChangePassword.SuspendLayout();
            pnlEditAccountInformation.SuspendLayout();
            pnlReportsContent.SuspendLayout();
            pnlHighestRatedIdentities.SuspendLayout();
            pnlStatTotalTransactions.SuspendLayout();
            pnlStatAvgTrustScore.SuspendLayout();
            pnlStatVerificationRate.SuspendLayout();
            pnlStatTotalPlatformUsers.SuspendLayout();
            pnlReportsTabs.SuspendLayout();
            pnlVerificationContent.SuspendLayout();
            pnlVerificationBody.SuspendLayout();
            pnlVerificationInspector.SuspendLayout();
            pnlAttachmentPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAttachmentImage).BeginInit();
            pnlSubmissionsQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubmissionsQueue).BeginInit();
            pnlAnomalyWarning.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlSidebarBorder.SuspendLayout();
            SuspendLayout();
            // 
            // lblTrustID
            // 
            lblTrustID.AutoSize = true;
            lblTrustID.BackColor = Color.Transparent;
            lblTrustID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrustID.ForeColor = SystemColors.Window;
            lblTrustID.Location = new Point(15, 15);
            lblTrustID.Name = "lblTrustID";
            lblTrustID.Size = new Size(77, 25);
            lblTrustID.TabIndex = 0;
            lblTrustID.Text = "TrustID";
            // 
            // pnlMainContent
            // 
            pnlMainContent.BorderStyle = BorderStyle.FixedSingle;
            pnlMainContent.Controls.Add(cmbRoleFilter);
            pnlMainContent.Controls.Add(txtSearchUser);
            pnlMainContent.Controls.Add(pnlSuspendedFlagged);
            pnlMainContent.Controls.Add(pnlNewSignups);
            pnlMainContent.Controls.Add(pnlActiveToday);
            pnlMainContent.Controls.Add(pnlTotalUsers);
            pnlMainContent.Controls.Add(dgvUsers);
            pnlMainContent.Controls.Add(cmbStatusFilter);
            pnlMainContent.Controls.Add(btnCreateUser);
            pnlMainContent.Location = new Point(150, 65);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(995, 708);
            pnlMainContent.TabIndex = 0;
            pnlMainContent.Paint += pnlMainContent_Paint_1;
            // 
            // cmbRoleFilter
            // 
            cmbRoleFilter.BackColor = Color.FromArgb(17, 24, 39);
            cmbRoleFilter.FlatStyle = FlatStyle.Flat;
            cmbRoleFilter.ForeColor = Color.White;
            cmbRoleFilter.FormattingEnabled = true;
            cmbRoleFilter.Items.AddRange(new object[] { "All Roles", "User", "Business", "Administrator" });
            cmbRoleFilter.Location = new Point(313, 171);
            cmbRoleFilter.Name = "cmbRoleFilter";
            cmbRoleFilter.Size = new Size(110, 23);
            cmbRoleFilter.TabIndex = 5;
            // 
            // txtSearchUser
            // 
            txtSearchUser.BackColor = Color.FromArgb(8, 14, 28);
            txtSearchUser.ForeColor = Color.FromArgb(107, 114, 128);
            txtSearchUser.Location = new Point(54, 170);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(210, 23);
            txtSearchUser.TabIndex = 4;
            txtSearchUser.Text = "Search user profile...";
            // 
            // pnlSuspendedFlagged
            // 
            pnlSuspendedFlagged.BackColor = Color.FromArgb(17, 24, 39);
            pnlSuspendedFlagged.Controls.Add(lblActionRequired);
            pnlSuspendedFlagged.Controls.Add(lblNumberOfSuspendeFlagged);
            pnlSuspendedFlagged.Controls.Add(lblSuspendeFlagged);
            pnlSuspendedFlagged.Location = new Point(759, 41);
            pnlSuspendedFlagged.Name = "pnlSuspendedFlagged";
            pnlSuspendedFlagged.Size = new Size(180, 82);
            pnlSuspendedFlagged.TabIndex = 3;
            // 
            // lblActionRequired
            // 
            lblActionRequired.AutoSize = true;
            lblActionRequired.BackColor = Color.Transparent;
            lblActionRequired.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActionRequired.ForeColor = Color.FromArgb(75, 85, 99);
            lblActionRequired.Location = new Point(16, 53);
            lblActionRequired.Name = "lblActionRequired";
            lblActionRequired.Size = new Size(151, 13);
            lblActionRequired.TabIndex = 2;
            lblActionRequired.Text = "Action required immediately";
            // 
            // lblNumberOfSuspendeFlagged
            // 
            lblNumberOfSuspendeFlagged.AutoSize = true;
            lblNumberOfSuspendeFlagged.BackColor = Color.Transparent;
            lblNumberOfSuspendeFlagged.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberOfSuspendeFlagged.ForeColor = Color.White;
            lblNumberOfSuspendeFlagged.Location = new Point(16, 28);
            lblNumberOfSuspendeFlagged.Name = "lblNumberOfSuspendeFlagged";
            lblNumberOfSuspendeFlagged.Size = new Size(34, 25);
            lblNumberOfSuspendeFlagged.TabIndex = 1;
            lblNumberOfSuspendeFlagged.Text = "12";
            // 
            // lblSuspendeFlagged
            // 
            lblSuspendeFlagged.AutoSize = true;
            lblSuspendeFlagged.BackColor = Color.Transparent;
            lblSuspendeFlagged.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSuspendeFlagged.ForeColor = Color.FromArgb(107, 114, 128);
            lblSuspendeFlagged.Location = new Point(16, 5);
            lblSuspendeFlagged.Name = "lblSuspendeFlagged";
            lblSuspendeFlagged.Size = new Size(117, 13);
            lblSuspendeFlagged.TabIndex = 0;
            lblSuspendeFlagged.Text = "Suspended / Flagged";
            // 
            // pnlNewSignups
            // 
            pnlNewSignups.BackColor = Color.FromArgb(17, 24, 39);
            pnlNewSignups.Controls.Add(lblAwaitingPrimaryReview);
            pnlNewSignups.Controls.Add(lblNumberOfSignups);
            pnlNewSignups.Controls.Add(lblNewSignupsTitle);
            pnlNewSignups.Location = new Point(528, 41);
            pnlNewSignups.Name = "pnlNewSignups";
            pnlNewSignups.Size = new Size(180, 82);
            pnlNewSignups.TabIndex = 3;
            // 
            // lblAwaitingPrimaryReview
            // 
            lblAwaitingPrimaryReview.AutoSize = true;
            lblAwaitingPrimaryReview.BackColor = Color.Transparent;
            lblAwaitingPrimaryReview.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAwaitingPrimaryReview.ForeColor = Color.FromArgb(75, 85, 99);
            lblAwaitingPrimaryReview.Location = new Point(16, 53);
            lblAwaitingPrimaryReview.Name = "lblAwaitingPrimaryReview";
            lblAwaitingPrimaryReview.Size = new Size(130, 13);
            lblAwaitingPrimaryReview.TabIndex = 2;
            lblAwaitingPrimaryReview.Text = "Awaiting primary review";
            // 
            // lblNumberOfSignups
            // 
            lblNumberOfSignups.AutoSize = true;
            lblNumberOfSignups.BackColor = Color.Transparent;
            lblNumberOfSignups.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberOfSignups.ForeColor = Color.White;
            lblNumberOfSignups.Location = new Point(16, 28);
            lblNumberOfSignups.Name = "lblNumberOfSignups";
            lblNumberOfSignups.Size = new Size(58, 25);
            lblNumberOfSignups.TabIndex = 1;
            lblNumberOfSignups.Text = "+420";
            // 
            // lblNewSignupsTitle
            // 
            lblNewSignupsTitle.AutoSize = true;
            lblNewSignupsTitle.BackColor = Color.Transparent;
            lblNewSignupsTitle.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewSignupsTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblNewSignupsTitle.Location = new Point(16, 5);
            lblNewSignupsTitle.Name = "lblNewSignupsTitle";
            lblNewSignupsTitle.Size = new Size(75, 13);
            lblNewSignupsTitle.TabIndex = 0;
            lblNewSignupsTitle.Text = "New Signups";
            // 
            // pnlActiveToday
            // 
            pnlActiveToday.BackColor = Color.FromArgb(17, 24, 39);
            pnlActiveToday.Controls.Add(lblRateOfConcurrent);
            pnlActiveToday.Controls.Add(lblNumberOfActive);
            pnlActiveToday.Controls.Add(lblActiveToday);
            pnlActiveToday.Location = new Point(288, 41);
            pnlActiveToday.Name = "pnlActiveToday";
            pnlActiveToday.Size = new Size(180, 82);
            pnlActiveToday.TabIndex = 3;
            // 
            // lblRateOfConcurrent
            // 
            lblRateOfConcurrent.AutoSize = true;
            lblRateOfConcurrent.BackColor = Color.Transparent;
            lblRateOfConcurrent.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRateOfConcurrent.ForeColor = Color.FromArgb(75, 85, 99);
            lblRateOfConcurrent.Location = new Point(16, 53);
            lblRateOfConcurrent.Name = "lblRateOfConcurrent";
            lblRateOfConcurrent.Size = new Size(83, 13);
            lblRateOfConcurrent.TabIndex = 2;
            lblRateOfConcurrent.Text = "21% active rate";
            // 
            // lblNumberOfActive
            // 
            lblNumberOfActive.AutoSize = true;
            lblNumberOfActive.BackColor = Color.Transparent;
            lblNumberOfActive.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberOfActive.ForeColor = Color.White;
            lblNumberOfActive.Location = new Point(16, 28);
            lblNumberOfActive.Name = "lblNumberOfActive";
            lblNumberOfActive.Size = new Size(61, 25);
            lblNumberOfActive.TabIndex = 1;
            lblNumberOfActive.Text = "3,102";
            // 
            // lblActiveToday
            // 
            lblActiveToday.AutoSize = true;
            lblActiveToday.BackColor = Color.Transparent;
            lblActiveToday.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActiveToday.ForeColor = Color.FromArgb(107, 114, 128);
            lblActiveToday.Location = new Point(16, 5);
            lblActiveToday.Name = "lblActiveToday";
            lblActiveToday.Size = new Size(69, 13);
            lblActiveToday.TabIndex = 0;
            lblActiveToday.Text = "Active Today";
            // 
            // pnlReviewsContent
            // 
            pnlReviewsContent.Controls.Add(pnlReviewsSummary);
            pnlReviewsContent.Controls.Add(pnlReviewsList);
            pnlReviewsContent.Controls.Add(btnTabFlaggedReviews);
            pnlReviewsContent.Location = new Point(150, 65);
            pnlReviewsContent.Name = "pnlReviewsContent";
            pnlReviewsContent.Size = new Size(992, 701);
            pnlReviewsContent.TabIndex = 9;
            // 
            // pnlReviewsSummary
            // 
            pnlReviewsSummary.BorderStyle = BorderStyle.FixedSingle;
            pnlReviewsSummary.Controls.Add(lbl4Stars);
            pnlReviewsSummary.Controls.Add(lbl4StarsReceived);
            pnlReviewsSummary.Controls.Add(lbl3Stars);
            pnlReviewsSummary.Controls.Add(lbl3StarsReceived);
            pnlReviewsSummary.Controls.Add(lbl2Stars);
            pnlReviewsSummary.Controls.Add(lbl2StarsReceived);
            pnlReviewsSummary.Controls.Add(lbl1Stars);
            pnlReviewsSummary.Controls.Add(lbl1StarsReceived);
            pnlReviewsSummary.Controls.Add(lbl5Stars);
            pnlReviewsSummary.Controls.Add(lbl5StarsReceived);
            pnlReviewsSummary.Controls.Add(lblNumOfActionsTaken);
            pnlReviewsSummary.Controls.Add(lblAvgResponseTime);
            pnlReviewsSummary.Controls.Add(lblRatingDistributionHeading);
            pnlReviewsSummary.Controls.Add(lblNumOfFlaggedReviews);
            pnlReviewsSummary.Controls.Add(lblModerationOverviewHeading);
            pnlReviewsSummary.Location = new Point(637, 46);
            pnlReviewsSummary.Name = "pnlReviewsSummary";
            pnlReviewsSummary.Size = new Size(336, 434);
            pnlReviewsSummary.TabIndex = 3;
            // 
            // lbl4Stars
            // 
            lbl4Stars.AutoSize = true;
            lbl4Stars.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl4Stars.ForeColor = Color.FromArgb(140, 140, 150);
            lbl4Stars.Location = new Point(13, 202);
            lbl4Stars.Name = "lbl4Stars";
            lbl4Stars.Size = new Size(40, 13);
            lbl4Stars.TabIndex = 22;
            lbl4Stars.Text = "4 stars";
            // 
            // lbl4StarsReceived
            // 
            lbl4StarsReceived.AutoSize = true;
            lbl4StarsReceived.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl4StarsReceived.ForeColor = Color.Cyan;
            lbl4StarsReceived.Location = new Point(67, 202);
            lbl4StarsReceived.Name = "lbl4StarsReceived";
            lbl4StarsReceived.Size = new Size(13, 13);
            lbl4StarsReceived.TabIndex = 21;
            lbl4StarsReceived.Text = "3";
            // 
            // lbl3Stars
            // 
            lbl3Stars.AutoSize = true;
            lbl3Stars.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl3Stars.ForeColor = Color.FromArgb(140, 140, 150);
            lbl3Stars.Location = new Point(13, 230);
            lbl3Stars.Name = "lbl3Stars";
            lbl3Stars.Size = new Size(40, 13);
            lbl3Stars.TabIndex = 20;
            lbl3Stars.Text = "3 stars";
            // 
            // lbl3StarsReceived
            // 
            lbl3StarsReceived.AutoSize = true;
            lbl3StarsReceived.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl3StarsReceived.ForeColor = Color.Cyan;
            lbl3StarsReceived.Location = new Point(67, 230);
            lbl3StarsReceived.Name = "lbl3StarsReceived";
            lbl3StarsReceived.Size = new Size(13, 13);
            lbl3StarsReceived.TabIndex = 19;
            lbl3StarsReceived.Text = "1";
            // 
            // lbl2Stars
            // 
            lbl2Stars.AutoSize = true;
            lbl2Stars.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl2Stars.ForeColor = Color.FromArgb(140, 140, 150);
            lbl2Stars.Location = new Point(13, 258);
            lbl2Stars.Name = "lbl2Stars";
            lbl2Stars.Size = new Size(40, 13);
            lbl2Stars.TabIndex = 18;
            lbl2Stars.Text = "2 stars";
            // 
            // lbl2StarsReceived
            // 
            lbl2StarsReceived.AutoSize = true;
            lbl2StarsReceived.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl2StarsReceived.ForeColor = Color.Cyan;
            lbl2StarsReceived.Location = new Point(67, 264);
            lbl2StarsReceived.Name = "lbl2StarsReceived";
            lbl2StarsReceived.Size = new Size(13, 13);
            lbl2StarsReceived.TabIndex = 17;
            lbl2StarsReceived.Text = "0";
            // 
            // lbl1Stars
            // 
            lbl1Stars.AutoSize = true;
            lbl1Stars.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1Stars.ForeColor = Color.FromArgb(140, 140, 150);
            lbl1Stars.Location = new Point(13, 292);
            lbl1Stars.Name = "lbl1Stars";
            lbl1Stars.Size = new Size(40, 13);
            lbl1Stars.TabIndex = 16;
            lbl1Stars.Text = "1 stars";
            // 
            // lbl1StarsReceived
            // 
            lbl1StarsReceived.AutoSize = true;
            lbl1StarsReceived.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1StarsReceived.ForeColor = Color.Cyan;
            lbl1StarsReceived.Location = new Point(67, 292);
            lbl1StarsReceived.Name = "lbl1StarsReceived";
            lbl1StarsReceived.Size = new Size(13, 13);
            lbl1StarsReceived.TabIndex = 15;
            lbl1StarsReceived.Text = "0";
            // 
            // lbl5Stars
            // 
            lbl5Stars.AutoSize = true;
            lbl5Stars.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl5Stars.ForeColor = Color.FromArgb(140, 140, 150);
            lbl5Stars.Location = new Point(13, 173);
            lbl5Stars.Name = "lbl5Stars";
            lbl5Stars.Size = new Size(40, 13);
            lbl5Stars.TabIndex = 14;
            lbl5Stars.Text = "5 stars";
            // 
            // lbl5StarsReceived
            // 
            lbl5StarsReceived.AutoSize = true;
            lbl5StarsReceived.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl5StarsReceived.ForeColor = Color.Cyan;
            lbl5StarsReceived.Location = new Point(67, 173);
            lbl5StarsReceived.Name = "lbl5StarsReceived";
            lbl5StarsReceived.Size = new Size(19, 13);
            lbl5StarsReceived.TabIndex = 5;
            lbl5StarsReceived.Text = "28";
            // 
            // lblNumOfActionsTaken
            // 
            lblNumOfActionsTaken.AutoSize = true;
            lblNumOfActionsTaken.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumOfActionsTaken.ForeColor = Color.FromArgb(140, 140, 150);
            lblNumOfActionsTaken.Location = new Point(13, 82);
            lblNumOfActionsTaken.Name = "lblNumOfActionsTaken";
            lblNumOfActionsTaken.Size = new Size(85, 13);
            lblNumOfActionsTaken.TabIndex = 4;
            lblNumOfActionsTaken.Text = "4 actions taken";
            // 
            // lblAvgResponseTime
            // 
            lblAvgResponseTime.AutoSize = true;
            lblAvgResponseTime.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvgResponseTime.ForeColor = Color.FromArgb(140, 140, 150);
            lblAvgResponseTime.Location = new Point(13, 110);
            lblAvgResponseTime.Name = "lblAvgResponseTime";
            lblAvgResponseTime.Size = new Size(163, 13);
            lblAvgResponseTime.TabIndex = 3;
            lblAvgResponseTime.Text = "Average response time: 3.2 hrs";
            // 
            // lblRatingDistributionHeading
            // 
            lblRatingDistributionHeading.AutoSize = true;
            lblRatingDistributionHeading.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRatingDistributionHeading.ForeColor = Color.FromArgb(140, 140, 150);
            lblRatingDistributionHeading.Location = new Point(13, 138);
            lblRatingDistributionHeading.Name = "lblRatingDistributionHeading";
            lblRatingDistributionHeading.Size = new Size(119, 13);
            lblRatingDistributionHeading.TabIndex = 2;
            lblRatingDistributionHeading.Text = "RATING DISTRIBUTION";
            // 
            // lblNumOfFlaggedReviews
            // 
            lblNumOfFlaggedReviews.AutoSize = true;
            lblNumOfFlaggedReviews.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumOfFlaggedReviews.ForeColor = Color.FromArgb(140, 140, 150);
            lblNumOfFlaggedReviews.Location = new Point(13, 56);
            lblNumOfFlaggedReviews.Name = "lblNumOfFlaggedReviews";
            lblNumOfFlaggedReviews.Size = new Size(149, 13);
            lblNumOfFlaggedReviews.TabIndex = 1;
            lblNumOfFlaggedReviews.Text = "7 reviews flagged this week";
            // 
            // lblModerationOverviewHeading
            // 
            lblModerationOverviewHeading.AutoSize = true;
            lblModerationOverviewHeading.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModerationOverviewHeading.ForeColor = Color.White;
            lblModerationOverviewHeading.Location = new Point(13, 20);
            lblModerationOverviewHeading.Name = "lblModerationOverviewHeading";
            lblModerationOverviewHeading.Size = new Size(175, 21);
            lblModerationOverviewHeading.TabIndex = 0;
            lblModerationOverviewHeading.Text = "Moderation overview";
            // 
            // pnlReviewsList
            // 
            pnlReviewsList.BorderStyle = BorderStyle.FixedSingle;
            pnlReviewsList.Controls.Add(pnlReviewer2);
            pnlReviewsList.Controls.Add(pnlReviewUser1);
            pnlReviewsList.Location = new Point(19, 46);
            pnlReviewsList.Name = "pnlReviewsList";
            pnlReviewsList.Size = new Size(597, 434);
            pnlReviewsList.TabIndex = 2;
            // 
            // pnlReviewer2
            // 
            pnlReviewer2.BackColor = Color.FromArgb(26, 30, 46);
            pnlReviewer2.BorderStyle = BorderStyle.FixedSingle;
            pnlReviewer2.Controls.Add(btnSuspendReviewer2);
            pnlReviewer2.Controls.Add(btnRemoveReview2);
            pnlReviewer2.Controls.Add(lblReasonForFlagUser2);
            pnlReviewer2.Controls.Add(lblFlaggedUsers);
            pnlReviewer2.Controls.Add(btnDissmissReport2);
            pnlReviewer2.Controls.Add(textBox2);
            pnlReviewer2.Controls.Add(lblReviewedUser);
            pnlReviewer2.Controls.Add(lblReviewer2);
            pnlReviewer2.Location = new Point(18, 225);
            pnlReviewer2.Name = "pnlReviewer2";
            pnlReviewer2.Size = new Size(466, 196);
            pnlReviewer2.TabIndex = 10;
            // 
            // btnSuspendReviewer2
            // 
            btnSuspendReviewer2.BackColor = Color.Red;
            btnSuspendReviewer2.FlatAppearance.BorderSize = 0;
            btnSuspendReviewer2.FlatStyle = FlatStyle.Flat;
            btnSuspendReviewer2.ForeColor = Color.White;
            btnSuspendReviewer2.Location = new Point(228, 153);
            btnSuspendReviewer2.Name = "btnSuspendReviewer2";
            btnSuspendReviewer2.Size = new Size(116, 30);
            btnSuspendReviewer2.TabIndex = 9;
            btnSuspendReviewer2.Text = "Suspend Reviewer";
            btnSuspendReviewer2.UseVisualStyleBackColor = false;
            btnSuspendReviewer2.Click += btnSuspendReviewer2_Click;
            // 
            // btnRemoveReview2
            // 
            btnRemoveReview2.BackColor = Color.Red;
            btnRemoveReview2.FlatAppearance.BorderSize = 0;
            btnRemoveReview2.FlatStyle = FlatStyle.Flat;
            btnRemoveReview2.ForeColor = Color.White;
            btnRemoveReview2.Location = new Point(119, 153);
            btnRemoveReview2.Name = "btnRemoveReview2";
            btnRemoveReview2.Size = new Size(103, 30);
            btnRemoveReview2.TabIndex = 8;
            btnRemoveReview2.Text = "Remove Review";
            btnRemoveReview2.UseVisualStyleBackColor = false;
            btnRemoveReview2.Click += btnRemoveReview2_Click;
            // 
            // lblReasonForFlagUser2
            // 
            lblReasonForFlagUser2.AutoSize = true;
            lblReasonForFlagUser2.Font = new Font("Segoe UI", 8.25F);
            lblReasonForFlagUser2.ForeColor = Color.FromArgb(140, 140, 150);
            lblReasonForFlagUser2.Location = new Point(227, 45);
            lblReasonForFlagUser2.Name = "lblReasonForFlagUser2";
            lblReasonForFlagUser2.Size = new Size(67, 13);
            lblReasonForFlagUser2.TabIndex = 7;
            lblReasonForFlagUser2.Text = "Harassment";
            // 
            // lblFlaggedUsers
            // 
            lblFlaggedUsers.AutoSize = true;
            lblFlaggedUsers.Font = new Font("Segoe UI", 8.25F);
            lblFlaggedUsers.ForeColor = Color.Red;
            lblFlaggedUsers.Location = new Point(227, 25);
            lblFlaggedUsers.Name = "lblFlaggedUsers";
            lblFlaggedUsers.Size = new Size(55, 13);
            lblFlaggedUsers.TabIndex = 6;
            lblFlaggedUsers.Text = "FLAGGED";
            // 
            // btnDissmissReport2
            // 
            btnDissmissReport2.BackColor = Color.Gray;
            btnDissmissReport2.FlatAppearance.BorderSize = 0;
            btnDissmissReport2.FlatStyle = FlatStyle.Flat;
            btnDissmissReport2.ForeColor = Color.White;
            btnDissmissReport2.Location = new Point(9, 153);
            btnDissmissReport2.Name = "btnDissmissReport2";
            btnDissmissReport2.Size = new Size(103, 30);
            btnDissmissReport2.TabIndex = 3;
            btnDissmissReport2.Text = "Dismiss Report";
            btnDissmissReport2.UseVisualStyleBackColor = false;
            btnDissmissReport2.Click += btnDissmissReport2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(26, 30, 46);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(220, 220, 225);
            textBox2.Location = new Point(7, 83);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(316, 60);
            textBox2.TabIndex = 2;
            textBox2.Text = "This guy is a complete scammer, don't trust him,\r\nhe's an idiot who does not know what he is doing.\r\n\r\n";
            // 
            // lblReviewedUser
            // 
            lblReviewedUser.AutoSize = true;
            lblReviewedUser.Font = new Font("Segoe UI", 8.25F);
            lblReviewedUser.ForeColor = Color.FromArgb(140, 140, 150);
            lblReviewedUser.Location = new Point(7, 58);
            lblReviewedUser.Name = "lblReviewedUser";
            lblReviewedUser.Size = new Size(113, 13);
            lblReviewedUser.TabIndex = 1;
            lblReviewedUser.Text = "About: Bob Johnson";
            // 
            // lblReviewer2
            // 
            lblReviewer2.AutoSize = true;
            lblReviewer2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblReviewer2.ForeColor = Color.White;
            lblReviewer2.Location = new Point(10, 25);
            lblReviewer2.Name = "lblReviewer2";
            lblReviewer2.Size = new Size(76, 30);
            lblReviewer2.TabIndex = 0;
            lblReviewer2.Text = "Reviewer:\r\nDiana Prince";
            // 
            // pnlReviewUser1
            // 
            pnlReviewUser1.BackColor = Color.FromArgb(26, 30, 46);
            pnlReviewUser1.BorderStyle = BorderStyle.FixedSingle;
            pnlReviewUser1.Controls.Add(btnSuspendReviewer);
            pnlReviewUser1.Controls.Add(btnRemoveReview);
            pnlReviewUser1.Controls.Add(lblReasonForFlagUser1);
            pnlReviewUser1.Controls.Add(lblFlagged);
            pnlReviewUser1.Controls.Add(btnDismissReport);
            pnlReviewUser1.Controls.Add(txtReviewUser1);
            pnlReviewUser1.Controls.Add(lblFlaggedUser);
            pnlReviewUser1.Location = new Point(18, 19);
            pnlReviewUser1.Name = "pnlReviewUser1";
            pnlReviewUser1.Size = new Size(466, 196);
            pnlReviewUser1.TabIndex = 0;
            // 
            // btnSuspendReviewer
            // 
            btnSuspendReviewer.BackColor = Color.Red;
            btnSuspendReviewer.FlatAppearance.BorderSize = 0;
            btnSuspendReviewer.FlatStyle = FlatStyle.Flat;
            btnSuspendReviewer.ForeColor = Color.White;
            btnSuspendReviewer.Location = new Point(228, 153);
            btnSuspendReviewer.Name = "btnSuspendReviewer";
            btnSuspendReviewer.Size = new Size(116, 30);
            btnSuspendReviewer.TabIndex = 9;
            btnSuspendReviewer.Text = "Suspend Reviewer";
            btnSuspendReviewer.UseVisualStyleBackColor = false;
            // 
            // btnRemoveReview
            // 
            btnRemoveReview.BackColor = Color.Red;
            btnRemoveReview.FlatAppearance.BorderSize = 0;
            btnRemoveReview.FlatStyle = FlatStyle.Flat;
            btnRemoveReview.ForeColor = Color.White;
            btnRemoveReview.Location = new Point(119, 153);
            btnRemoveReview.Name = "btnRemoveReview";
            btnRemoveReview.Size = new Size(103, 30);
            btnRemoveReview.TabIndex = 8;
            btnRemoveReview.Text = "Remove Review";
            btnRemoveReview.UseVisualStyleBackColor = false;
            btnRemoveReview.Click += btnRemoveReview_Click_1;
            // 
            // lblReasonForFlagUser1
            // 
            lblReasonForFlagUser1.AutoSize = true;
            lblReasonForFlagUser1.Font = new Font("Segoe UI", 8.25F);
            lblReasonForFlagUser1.ForeColor = Color.FromArgb(140, 140, 150);
            lblReasonForFlagUser1.Location = new Point(227, 45);
            lblReasonForFlagUser1.Name = "lblReasonForFlagUser1";
            lblReasonForFlagUser1.Size = new Size(59, 26);
            lblReasonForFlagUser1.TabIndex = 7;
            lblReasonForFlagUser1.Text = "Offensive \r\nlanguage\r\n";
            // 
            // lblFlagged
            // 
            lblFlagged.AutoSize = true;
            lblFlagged.Font = new Font("Segoe UI", 8.25F);
            lblFlagged.ForeColor = Color.Red;
            lblFlagged.Location = new Point(227, 25);
            lblFlagged.Name = "lblFlagged";
            lblFlagged.Size = new Size(55, 13);
            lblFlagged.TabIndex = 6;
            lblFlagged.Text = "FLAGGED";
            // 
            // btnDismissReport
            // 
            btnDismissReport.BackColor = Color.Gray;
            btnDismissReport.FlatAppearance.BorderSize = 0;
            btnDismissReport.FlatStyle = FlatStyle.Flat;
            btnDismissReport.ForeColor = Color.White;
            btnDismissReport.Location = new Point(9, 153);
            btnDismissReport.Name = "btnDismissReport";
            btnDismissReport.Size = new Size(103, 30);
            btnDismissReport.TabIndex = 3;
            btnDismissReport.Text = "Dismiss Report";
            btnDismissReport.UseVisualStyleBackColor = false;
            btnDismissReport.Click += btnDismissReport_Click_1;
            // 
            // txtReviewUser1
            // 
            txtReviewUser1.BackColor = Color.FromArgb(26, 30, 46);
            txtReviewUser1.BorderStyle = BorderStyle.None;
            txtReviewUser1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReviewUser1.ForeColor = Color.FromArgb(220, 220, 225);
            txtReviewUser1.Location = new Point(7, 83);
            txtReviewUser1.Multiline = true;
            txtReviewUser1.Name = "txtReviewUser1";
            txtReviewUser1.ReadOnly = true;
            txtReviewUser1.Size = new Size(316, 46);
            txtReviewUser1.TabIndex = 2;
            txtReviewUser1.Text = "This guy is a complete scammer, don't trust him,\r\nhe's an idiot who does not know what he is doing.\r\n\r\n";
            // 
            // lblFlaggedUser
            // 
            lblFlaggedUser.AutoSize = true;
            lblFlaggedUser.Font = new Font("Segoe UI", 8.25F);
            lblFlaggedUser.ForeColor = Color.FromArgb(140, 140, 150);
            lblFlaggedUser.Location = new Point(7, 58);
            lblFlaggedUser.Name = "lblFlaggedUser";
            lblFlaggedUser.Size = new Size(113, 13);
            lblFlaggedUser.TabIndex = 1;
            lblFlaggedUser.Text = "About: Bob Johnson";
            // 
            // btnTabFlaggedReviews
            // 
            btnTabFlaggedReviews.BackColor = Color.DarkGray;
            btnTabFlaggedReviews.FlatAppearance.BorderSize = 0;
            btnTabFlaggedReviews.FlatStyle = FlatStyle.Flat;
            btnTabFlaggedReviews.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTabFlaggedReviews.ForeColor = Color.White;
            btnTabFlaggedReviews.Location = new Point(19, 16);
            btnTabFlaggedReviews.Name = "btnTabFlaggedReviews";
            btnTabFlaggedReviews.Size = new Size(120, 23);
            btnTabFlaggedReviews.TabIndex = 0;
            btnTabFlaggedReviews.Text = "Flagged Reviews";
            btnTabFlaggedReviews.UseVisualStyleBackColor = false;
            // 
            // pnlTotalUsers
            // 
            pnlTotalUsers.BackColor = Color.FromArgb(17, 24, 39);
            pnlTotalUsers.Controls.Add(lblTotalUsersChange);
            pnlTotalUsers.Controls.Add(lblTotalUsers);
            pnlTotalUsers.Controls.Add(lblTotalUsersTitle);
            pnlTotalUsers.Location = new Point(54, 41);
            pnlTotalUsers.Name = "pnlTotalUsers";
            pnlTotalUsers.Size = new Size(180, 82);
            pnlTotalUsers.TabIndex = 2;
            // 
            // lblTotalUsersChange
            // 
            lblTotalUsersChange.AutoSize = true;
            lblTotalUsersChange.BackColor = Color.Transparent;
            lblTotalUsersChange.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalUsersChange.ForeColor = Color.FromArgb(75, 85, 99);
            lblTotalUsersChange.Location = new Point(16, 53);
            lblTotalUsersChange.Name = "lblTotalUsersChange";
            lblTotalUsersChange.Size = new Size(101, 13);
            lblTotalUsersChange.TabIndex = 2;
            lblTotalUsersChange.Text = "+1,240 this month";
            // 
            // lblTotalUsers
            // 
            lblTotalUsers.AutoSize = true;
            lblTotalUsers.BackColor = Color.Transparent;
            lblTotalUsers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUsers.ForeColor = Color.White;
            lblTotalUsers.Location = new Point(16, 28);
            lblTotalUsers.Name = "lblTotalUsers";
            lblTotalUsers.Size = new Size(72, 25);
            lblTotalUsers.TabIndex = 1;
            lblTotalUsers.Text = "14,892";
            // 
            // lblTotalUsersTitle
            // 
            lblTotalUsersTitle.AutoSize = true;
            lblTotalUsersTitle.BackColor = Color.Transparent;
            lblTotalUsersTitle.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalUsersTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblTotalUsersTitle.Location = new Point(16, 5);
            lblTotalUsersTitle.Name = "lblTotalUsersTitle";
            lblTotalUsersTitle.Size = new Size(108, 13);
            lblTotalUsersTitle.TabIndex = 0;
            lblTotalUsersTitle.Text = "Total Platform Users";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.FromArgb(17, 24, 39);
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { colUserId, colUserProfile, colEmail, colIdentityScope, colTrustScore, colAccStatus, colJoinedDate, colActions });
            dgvUsers.Location = new Point(54, 240);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.Size = new Size(791, 288);
            dgvUsers.TabIndex = 8;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // colUserId
            // 
            colUserId.HeaderText = "User ID";
            colUserId.Name = "colUserId";
            colUserId.ReadOnly = true;
            colUserId.Visible = false;
            // 
            // colUserProfile
            // 
            colUserProfile.HeaderText = "User Profile";
            colUserProfile.Name = "colUserProfile";
            colUserProfile.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email Address";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colIdentityScope
            // 
            colIdentityScope.HeaderText = " Identity Scope";
            colIdentityScope.Name = "colIdentityScope";
            colIdentityScope.ReadOnly = true;
            // 
            // colTrustScore
            // 
            colTrustScore.HeaderText = "Trust Score";
            colTrustScore.Name = "colTrustScore";
            colTrustScore.ReadOnly = true;
            // 
            // colAccStatus
            // 
            colAccStatus.HeaderText = "Account Status";
            colAccStatus.Name = "colAccStatus";
            colAccStatus.ReadOnly = true;
            // 
            // colJoinedDate
            // 
            colJoinedDate.HeaderText = "Joined Date";
            colJoinedDate.Name = "colJoinedDate";
            colJoinedDate.ReadOnly = true;
            // 
            // colActions
            // 
            colActions.HeaderText = "Actions";
            colActions.Name = "colActions";
            colActions.ReadOnly = true;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.BackColor = Color.FromArgb(17, 24, 39);
            cmbStatusFilter.FlatStyle = FlatStyle.Flat;
            cmbStatusFilter.ForeColor = Color.White;
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "All Statuses", "Active", "Suspended", "Flagged", "Pending" });
            cmbStatusFilter.Location = new Point(509, 170);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(110, 23);
            cmbStatusFilter.TabIndex = 6;
            // 
            // btnCreateUser
            // 
            btnCreateUser.BackColor = Color.FromArgb(34, 211, 238);
            btnCreateUser.FlatAppearance.BorderSize = 0;
            btnCreateUser.FlatStyle = FlatStyle.Flat;
            btnCreateUser.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateUser.ForeColor = Color.FromArgb(8, 14, 28);
            btnCreateUser.Location = new Point(716, 170);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(126, 23);
            btnCreateUser.TabIndex = 7;
            btnCreateUser.Text = "+ Create New User";
            btnCreateUser.UseVisualStyleBackColor = false;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // pnlSettingsContent
            // 
            pnlSettingsContent.BorderStyle = BorderStyle.FixedSingle;
            pnlSettingsContent.Controls.Add(pnlLogoutOfSession);
            pnlSettingsContent.Controls.Add(pnlChangePassword);
            pnlSettingsContent.Controls.Add(pnlEditAccountInformation);
            pnlSettingsContent.Location = new Point(150, 65);
            pnlSettingsContent.Name = "pnlSettingsContent";
            pnlSettingsContent.Size = new Size(992, 707);
            pnlSettingsContent.TabIndex = 9;
            // 
            // pnlLogoutOfSession
            // 
            pnlLogoutOfSession.BorderStyle = BorderStyle.FixedSingle;
            pnlLogoutOfSession.Controls.Add(lblSubtitleForLogout);
            pnlLogoutOfSession.Controls.Add(lblSessionLogoutHeading);
            pnlLogoutOfSession.Controls.Add(btnLogoutSession);
            pnlLogoutOfSession.Location = new Point(31, 363);
            pnlLogoutOfSession.Name = "pnlLogoutOfSession";
            pnlLogoutOfSession.Size = new Size(449, 90);
            pnlLogoutOfSession.TabIndex = 2;
            // 
            // lblSubtitleForLogout
            // 
            lblSubtitleForLogout.AutoSize = true;
            lblSubtitleForLogout.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitleForLogout.ForeColor = Color.FromArgb(140, 140, 150);
            lblSubtitleForLogout.Location = new Point(18, 28);
            lblSubtitleForLogout.Name = "lblSubtitleForLogout";
            lblSubtitleForLogout.Size = new Size(312, 15);
            lblSubtitleForLogout.TabIndex = 10;
            lblSubtitleForLogout.Text = "Disconnect and signout of your local TrustID node session";
            // 
            // lblSessionLogoutHeading
            // 
            lblSessionLogoutHeading.AutoSize = true;
            lblSessionLogoutHeading.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSessionLogoutHeading.ForeColor = Color.White;
            lblSessionLogoutHeading.Location = new Point(15, 6);
            lblSessionLogoutHeading.Name = "lblSessionLogoutHeading";
            lblSessionLogoutHeading.Size = new Size(54, 17);
            lblSessionLogoutHeading.TabIndex = 9;
            lblSessionLogoutHeading.Text = "Session";
            // 
            // btnLogoutSession
            // 
            btnLogoutSession.BackColor = Color.Red;
            btnLogoutSession.FlatAppearance.BorderSize = 0;
            btnLogoutSession.FlatStyle = FlatStyle.Flat;
            btnLogoutSession.Location = new Point(18, 52);
            btnLogoutSession.Name = "btnLogoutSession";
            btnLogoutSession.Size = new Size(105, 23);
            btnLogoutSession.TabIndex = 8;
            btnLogoutSession.Text = "Logout";
            btnLogoutSession.UseVisualStyleBackColor = false;
            // 
            // pnlChangePassword
            // 
            pnlChangePassword.BackColor = Color.FromArgb(26, 30, 46);
            pnlChangePassword.BorderStyle = BorderStyle.FixedSingle;
            pnlChangePassword.Controls.Add(btnUpdatePassword);
            pnlChangePassword.Controls.Add(lblConfirmNewPassword);
            pnlChangePassword.Controls.Add(txtConfirmNewPassword);
            pnlChangePassword.Controls.Add(txtNewPassword);
            pnlChangePassword.Controls.Add(lblNewPassword);
            pnlChangePassword.Controls.Add(txtCurrentPassword);
            pnlChangePassword.Controls.Add(lblCurrentPassword);
            pnlChangePassword.Controls.Add(lblChangePasswordHeading);
            pnlChangePassword.Location = new Point(509, 21);
            pnlChangePassword.Name = "pnlChangePassword";
            pnlChangePassword.Size = new Size(459, 312);
            pnlChangePassword.TabIndex = 1;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = Color.Cyan;
            btnUpdatePassword.FlatAppearance.BorderSize = 0;
            btnUpdatePassword.FlatStyle = FlatStyle.Flat;
            btnUpdatePassword.Location = new Point(22, 270);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(119, 23);
            btnUpdatePassword.TabIndex = 11;
            btnUpdatePassword.Text = "Update Password";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.AutoSize = true;
            lblConfirmNewPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmNewPassword.ForeColor = Color.FromArgb(140, 140, 150);
            lblConfirmNewPassword.Location = new Point(22, 200);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new Size(131, 15);
            lblConfirmNewPassword.TabIndex = 10;
            lblConfirmNewPassword.Text = "Confirm New Password";
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.BackColor = Color.FromArgb(8, 14, 28);
            txtConfirmNewPassword.BorderStyle = BorderStyle.None;
            txtConfirmNewPassword.Location = new Point(22, 218);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(297, 16);
            txtConfirmNewPassword.TabIndex = 9;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.FromArgb(8, 14, 28);
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.Location = new Point(22, 143);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(297, 16);
            txtNewPassword.TabIndex = 8;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewPassword.ForeColor = Color.FromArgb(140, 140, 150);
            lblNewPassword.Location = new Point(22, 124);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(84, 15);
            lblNewPassword.TabIndex = 5;
            lblNewPassword.Text = "New Password";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.BackColor = Color.FromArgb(8, 14, 28);
            txtCurrentPassword.BorderStyle = BorderStyle.None;
            txtCurrentPassword.Location = new Point(22, 72);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(297, 16);
            txtCurrentPassword.TabIndex = 4;
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentPassword.ForeColor = Color.FromArgb(140, 140, 150);
            lblCurrentPassword.Location = new Point(17, 50);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(100, 15);
            lblCurrentPassword.TabIndex = 3;
            lblCurrentPassword.Text = "Current Password";
            // 
            // lblChangePasswordHeading
            // 
            lblChangePasswordHeading.AutoSize = true;
            lblChangePasswordHeading.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChangePasswordHeading.ForeColor = Color.White;
            lblChangePasswordHeading.Location = new Point(22, 13);
            lblChangePasswordHeading.Name = "lblChangePasswordHeading";
            lblChangePasswordHeading.Size = new Size(132, 20);
            lblChangePasswordHeading.TabIndex = 1;
            lblChangePasswordHeading.Text = "Change Password\r\n";
            // 
            // pnlEditAccountInformation
            // 
            pnlEditAccountInformation.BackColor = Color.FromArgb(26, 30, 46);
            pnlEditAccountInformation.BorderStyle = BorderStyle.FixedSingle;
            pnlEditAccountInformation.Controls.Add(btnSaveChanges);
            pnlEditAccountInformation.Controls.Add(txtEmailAddress);
            pnlEditAccountInformation.Controls.Add(lblEmailAddress);
            pnlEditAccountInformation.Controls.Add(txtUsername);
            pnlEditAccountInformation.Controls.Add(lblUsername);
            pnlEditAccountInformation.Controls.Add(txtFullName);
            pnlEditAccountInformation.Controls.Add(lblFullName);
            pnlEditAccountInformation.Controls.Add(lblEditAccInforHeading);
            pnlEditAccountInformation.Location = new Point(21, 21);
            pnlEditAccountInformation.Name = "pnlEditAccountInformation";
            pnlEditAccountInformation.Size = new Size(459, 312);
            pnlEditAccountInformation.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.Cyan;
            btnSaveChanges.FlatAppearance.BorderSize = 0;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Location = new Point(34, 268);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(105, 23);
            btnSaveChanges.TabIndex = 7;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.BackColor = Color.FromArgb(8, 14, 28);
            txtEmailAddress.BorderStyle = BorderStyle.None;
            txtEmailAddress.Location = new Point(34, 151);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(346, 16);
            txtEmailAddress.TabIndex = 6;
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailAddress.ForeColor = Color.FromArgb(140, 140, 150);
            lblEmailAddress.Location = new Point(29, 125);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(81, 15);
            lblEmailAddress.TabIndex = 5;
            lblEmailAddress.Text = "Email Address";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(8, 14, 28);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Location = new Point(34, 221);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(346, 16);
            txtUsername.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(140, 140, 150);
            lblUsername.Location = new Point(29, 195);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(8, 14, 28);
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Location = new Point(34, 82);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(346, 16);
            txtFullName.TabIndex = 2;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(140, 140, 150);
            lblFullName.Location = new Point(29, 56);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(61, 15);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name";
            // 
            // lblEditAccInforHeading
            // 
            lblEditAccInforHeading.AutoSize = true;
            lblEditAccInforHeading.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditAccInforHeading.ForeColor = Color.White;
            lblEditAccInforHeading.Location = new Point(29, 13);
            lblEditAccInforHeading.Name = "lblEditAccInforHeading";
            lblEditAccInforHeading.Size = new Size(187, 20);
            lblEditAccInforHeading.TabIndex = 0;
            lblEditAccInforHeading.Text = "Edit Account Information";
            // 
            // lblReviewer1
            // 
            lblReviewer1.AutoSize = true;
            lblReviewer1.Location = new Point(0, 0);
            lblReviewer1.Name = "lblReviewer1";
            lblReviewer1.Size = new Size(100, 23);
            lblReviewer1.TabIndex = 0;
            lblReviewer1.Text = "Reviewer:";
            // 
            // pnlReportsContent
            // 
            pnlReportsContent.Controls.Add(pnlHighestRatedIdentities);
            pnlReportsContent.Controls.Add(pnlTrustScoreDistribution);
            pnlReportsContent.Controls.Add(pnlUserGrowthChart);
            pnlReportsContent.Controls.Add(pnlStatTotalTransactions);
            pnlReportsContent.Controls.Add(pnlStatAvgTrustScore);
            pnlReportsContent.Controls.Add(pnlStatVerificationRate);
            pnlReportsContent.Controls.Add(pnlStatTotalPlatformUsers);
            pnlReportsContent.Controls.Add(pnlReportsTabs);
            pnlReportsContent.Location = new Point(150, 65);
            pnlReportsContent.Name = "pnlReportsContent";
            pnlReportsContent.Size = new Size(991, 704);
            pnlReportsContent.TabIndex = 9;
            // 
            // pnlHighestRatedIdentities
            // 
            pnlHighestRatedIdentities.BackColor = Color.FromArgb(26, 30, 46);
            pnlHighestRatedIdentities.Controls.Add(lblThirdPersonVerification);
            pnlHighestRatedIdentities.Controls.Add(lblSecondPersonVerification);
            pnlHighestRatedIdentities.Controls.Add(lblFirstPersonVerification);
            pnlHighestRatedIdentities.Controls.Add(lblTrustScoreFirstPlace);
            pnlHighestRatedIdentities.Controls.Add(lblTrustScoreSecondPlace);
            pnlHighestRatedIdentities.Controls.Add(lblTrustScoreThirdPlace);
            pnlHighestRatedIdentities.Controls.Add(lblFirstHighestRatedPerson);
            pnlHighestRatedIdentities.Controls.Add(lblSecondHighestRatedPerson);
            pnlHighestRatedIdentities.Controls.Add(lblThirdHighestRatedPerson);
            pnlHighestRatedIdentities.Controls.Add(lblSecondPlace);
            pnlHighestRatedIdentities.Controls.Add(lblThirdPlace);
            pnlHighestRatedIdentities.Controls.Add(lblFirstPlace);
            pnlHighestRatedIdentities.Controls.Add(lblHighestRatedTitle);
            pnlHighestRatedIdentities.Location = new Point(15, 497);
            pnlHighestRatedIdentities.Name = "pnlHighestRatedIdentities";
            pnlHighestRatedIdentities.Size = new Size(921, 178);
            pnlHighestRatedIdentities.TabIndex = 5;
            // 
            // lblThirdPersonVerification
            // 
            lblThirdPersonVerification.AutoSize = true;
            lblThirdPersonVerification.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThirdPersonVerification.ForeColor = Color.Green;
            lblThirdPersonVerification.Location = new Point(731, 139);
            lblThirdPersonVerification.Name = "lblThirdPersonVerification";
            lblThirdPersonVerification.Size = new Size(95, 13);
            lblThirdPersonVerification.TabIndex = 12;
            lblThirdPersonVerification.Text = "100% Verification";
            // 
            // lblSecondPersonVerification
            // 
            lblSecondPersonVerification.AutoSize = true;
            lblSecondPersonVerification.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSecondPersonVerification.ForeColor = Color.Green;
            lblSecondPersonVerification.Location = new Point(731, 98);
            lblSecondPersonVerification.Name = "lblSecondPersonVerification";
            lblSecondPersonVerification.Size = new Size(95, 13);
            lblSecondPersonVerification.TabIndex = 11;
            lblSecondPersonVerification.Text = "100% Verification";
            // 
            // lblFirstPersonVerification
            // 
            lblFirstPersonVerification.AutoSize = true;
            lblFirstPersonVerification.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstPersonVerification.ForeColor = Color.Green;
            lblFirstPersonVerification.Location = new Point(731, 52);
            lblFirstPersonVerification.Name = "lblFirstPersonVerification";
            lblFirstPersonVerification.Size = new Size(95, 13);
            lblFirstPersonVerification.TabIndex = 10;
            lblFirstPersonVerification.Text = "100% Verification";
            // 
            // lblTrustScoreFirstPlace
            // 
            lblTrustScoreFirstPlace.AutoSize = true;
            lblTrustScoreFirstPlace.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrustScoreFirstPlace.ForeColor = Color.Cyan;
            lblTrustScoreFirstPlace.Location = new Point(851, 52);
            lblTrustScoreFirstPlace.Name = "lblTrustScoreFirstPlace";
            lblTrustScoreFirstPlace.Size = new Size(25, 13);
            lblTrustScoreFirstPlace.TabIndex = 9;
            lblTrustScoreFirstPlace.Text = "994";
            // 
            // lblTrustScoreSecondPlace
            // 
            lblTrustScoreSecondPlace.AutoSize = true;
            lblTrustScoreSecondPlace.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrustScoreSecondPlace.ForeColor = Color.Cyan;
            lblTrustScoreSecondPlace.Location = new Point(851, 98);
            lblTrustScoreSecondPlace.Name = "lblTrustScoreSecondPlace";
            lblTrustScoreSecondPlace.Size = new Size(25, 13);
            lblTrustScoreSecondPlace.TabIndex = 8;
            lblTrustScoreSecondPlace.Text = "991";
            // 
            // lblTrustScoreThirdPlace
            // 
            lblTrustScoreThirdPlace.AutoSize = true;
            lblTrustScoreThirdPlace.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrustScoreThirdPlace.ForeColor = Color.Cyan;
            lblTrustScoreThirdPlace.Location = new Point(851, 139);
            lblTrustScoreThirdPlace.Name = "lblTrustScoreThirdPlace";
            lblTrustScoreThirdPlace.Size = new Size(25, 13);
            lblTrustScoreThirdPlace.TabIndex = 7;
            lblTrustScoreThirdPlace.Text = "985";
            // 
            // lblFirstHighestRatedPerson
            // 
            lblFirstHighestRatedPerson.AutoSize = true;
            lblFirstHighestRatedPerson.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstHighestRatedPerson.ForeColor = Color.White;
            lblFirstHighestRatedPerson.Location = new Point(84, 52);
            lblFirstHighestRatedPerson.Name = "lblFirstHighestRatedPerson";
            lblFirstHighestRatedPerson.Size = new Size(110, 17);
            lblFirstHighestRatedPerson.TabIndex = 6;
            lblFirstHighestRatedPerson.Text = "Alexander Vance";
            // 
            // lblSecondHighestRatedPerson
            // 
            lblSecondHighestRatedPerson.AutoSize = true;
            lblSecondHighestRatedPerson.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSecondHighestRatedPerson.ForeColor = Color.White;
            lblSecondHighestRatedPerson.Location = new Point(84, 98);
            lblSecondHighestRatedPerson.Name = "lblSecondHighestRatedPerson";
            lblSecondHighestRatedPerson.Size = new Size(79, 17);
            lblSecondHighestRatedPerson.TabIndex = 5;
            lblSecondHighestRatedPerson.Text = "Marie Curie";
            // 
            // lblThirdHighestRatedPerson
            // 
            lblThirdHighestRatedPerson.AutoSize = true;
            lblThirdHighestRatedPerson.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThirdHighestRatedPerson.ForeColor = Color.White;
            lblThirdHighestRatedPerson.Location = new Point(84, 139);
            lblThirdHighestRatedPerson.Name = "lblThirdHighestRatedPerson";
            lblThirdHighestRatedPerson.Size = new Size(80, 17);
            lblThirdHighestRatedPerson.TabIndex = 4;
            lblThirdHighestRatedPerson.Text = "Alan Turing";
            // 
            // lblSecondPlace
            // 
            lblSecondPlace.AutoSize = true;
            lblSecondPlace.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSecondPlace.ForeColor = Color.White;
            lblSecondPlace.Location = new Point(16, 98);
            lblSecondPlace.Name = "lblSecondPlace";
            lblSecondPlace.Size = new Size(23, 17);
            lblSecondPlace.TabIndex = 3;
            lblSecondPlace.Text = "#2";
            // 
            // lblThirdPlace
            // 
            lblThirdPlace.AutoSize = true;
            lblThirdPlace.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThirdPlace.ForeColor = Color.White;
            lblThirdPlace.Location = new Point(16, 139);
            lblThirdPlace.Name = "lblThirdPlace";
            lblThirdPlace.Size = new Size(23, 17);
            lblThirdPlace.TabIndex = 2;
            lblThirdPlace.Text = "#3";
            // 
            // lblFirstPlace
            // 
            lblFirstPlace.AutoSize = true;
            lblFirstPlace.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstPlace.ForeColor = Color.White;
            lblFirstPlace.Location = new Point(16, 52);
            lblFirstPlace.Name = "lblFirstPlace";
            lblFirstPlace.Size = new Size(23, 17);
            lblFirstPlace.TabIndex = 1;
            lblFirstPlace.Text = "#1";
            // 
            // lblHighestRatedTitle
            // 
            lblHighestRatedTitle.AutoSize = true;
            lblHighestRatedTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHighestRatedTitle.ForeColor = Color.White;
            lblHighestRatedTitle.Location = new Point(21, 6);
            lblHighestRatedTitle.Name = "lblHighestRatedTitle";
            lblHighestRatedTitle.Size = new Size(127, 17);
            lblHighestRatedTitle.TabIndex = 0;
            lblHighestRatedTitle.Text = "Highest Rated Title";
            // 
            // pnlTrustScoreDistribution
            // 
            pnlTrustScoreDistribution.BackColor = Color.FromArgb(26, 30, 46);
            pnlTrustScoreDistribution.Location = new Point(486, 213);
            pnlTrustScoreDistribution.Name = "pnlTrustScoreDistribution";
            pnlTrustScoreDistribution.Size = new Size(450, 258);
            pnlTrustScoreDistribution.TabIndex = 4;
            // 
            // pnlUserGrowthChart
            // 
            pnlUserGrowthChart.BackColor = Color.FromArgb(26, 30, 46);
            pnlUserGrowthChart.Location = new Point(15, 213);
            pnlUserGrowthChart.Name = "pnlUserGrowthChart";
            pnlUserGrowthChart.Size = new Size(450, 258);
            pnlUserGrowthChart.TabIndex = 3;
            // 
            // pnlStatTotalTransactions
            // 
            pnlStatTotalTransactions.BorderStyle = BorderStyle.FixedSingle;
            pnlStatTotalTransactions.Controls.Add(lblTotalTransactions);
            pnlStatTotalTransactions.Controls.Add(lblAvgSignIns);
            pnlStatTotalTransactions.Controls.Add(lblNumberOfTotalTransactions);
            pnlStatTotalTransactions.Location = new Point(249, 94);
            pnlStatTotalTransactions.Name = "pnlStatTotalTransactions";
            pnlStatTotalTransactions.Size = new Size(216, 101);
            pnlStatTotalTransactions.TabIndex = 2;
            // 
            // lblTotalTransactions
            // 
            lblTotalTransactions.AutoSize = true;
            lblTotalTransactions.ForeColor = Color.FromArgb(156, 163, 175);
            lblTotalTransactions.Location = new Point(16, 6);
            lblTotalTransactions.Name = "lblTotalTransactions";
            lblTotalTransactions.Size = new Size(102, 15);
            lblTotalTransactions.TabIndex = 8;
            lblTotalTransactions.Text = "Total Transactions";
            // 
            // lblAvgSignIns
            // 
            lblAvgSignIns.AutoSize = true;
            lblAvgSignIns.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvgSignIns.ForeColor = Color.FromArgb(0, 220, 210);
            lblAvgSignIns.Location = new Point(16, 76);
            lblAvgSignIns.Name = "lblAvgSignIns";
            lblAvgSignIns.Size = new Size(141, 13);
            lblAvgSignIns.TabIndex = 7;
            lblAvgSignIns.Text = "Avg. Daily signatures: 1.4k";
            // 
            // lblNumberOfTotalTransactions
            // 
            lblNumberOfTotalTransactions.AutoSize = true;
            lblNumberOfTotalTransactions.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberOfTotalTransactions.ForeColor = Color.White;
            lblNumberOfTotalTransactions.Location = new Point(16, 34);
            lblNumberOfTotalTransactions.Name = "lblNumberOfTotalTransactions";
            lblNumberOfTotalTransactions.Size = new Size(72, 25);
            lblNumberOfTotalTransactions.TabIndex = 6;
            lblNumberOfTotalTransactions.Text = "84,392";
            // 
            // pnlStatAvgTrustScore
            // 
            pnlStatAvgTrustScore.BorderStyle = BorderStyle.FixedSingle;
            pnlStatAvgTrustScore.Controls.Add(lblAverageTrustScore);
            pnlStatAvgTrustScore.Controls.Add(lblExcelledCohort);
            pnlStatAvgTrustScore.Controls.Add(lblCalcuAvgTrustScore);
            pnlStatAvgTrustScore.Location = new Point(491, 94);
            pnlStatAvgTrustScore.Name = "pnlStatAvgTrustScore";
            pnlStatAvgTrustScore.Size = new Size(216, 101);
            pnlStatAvgTrustScore.TabIndex = 2;
            // 
            // lblAverageTrustScore
            // 
            lblAverageTrustScore.AutoSize = true;
            lblAverageTrustScore.ForeColor = Color.FromArgb(156, 163, 175);
            lblAverageTrustScore.Location = new Point(13, 6);
            lblAverageTrustScore.Name = "lblAverageTrustScore";
            lblAverageTrustScore.Size = new Size(111, 15);
            lblAverageTrustScore.TabIndex = 8;
            lblAverageTrustScore.Text = "Average Trust Score";
            // 
            // lblExcelledCohort
            // 
            lblExcelledCohort.AutoSize = true;
            lblExcelledCohort.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExcelledCohort.ForeColor = Color.FromArgb(0, 220, 210);
            lblExcelledCohort.Location = new Point(13, 76);
            lblExcelledCohort.Name = "lblExcelledCohort";
            lblExcelledCohort.Size = new Size(164, 13);
            lblExcelledCohort.TabIndex = 7;
            lblExcelledCohort.Text = "Excelled cohort representation";
            // 
            // lblCalcuAvgTrustScore
            // 
            lblCalcuAvgTrustScore.AutoSize = true;
            lblCalcuAvgTrustScore.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalcuAvgTrustScore.ForeColor = Color.White;
            lblCalcuAvgTrustScore.Location = new Point(13, 34);
            lblCalcuAvgTrustScore.Name = "lblCalcuAvgTrustScore";
            lblCalcuAvgTrustScore.Size = new Size(45, 25);
            lblCalcuAvgTrustScore.TabIndex = 6;
            lblCalcuAvgTrustScore.Text = "847";
            // 
            // pnlStatVerificationRate
            // 
            pnlStatVerificationRate.BorderStyle = BorderStyle.FixedSingle;
            pnlStatVerificationRate.Controls.Add(lblVerificationRate);
            pnlStatVerificationRate.Controls.Add(lblVeriRate);
            pnlStatVerificationRate.Controls.Add(lblBiometricMatch);
            pnlStatVerificationRate.Location = new Point(720, 95);
            pnlStatVerificationRate.Name = "pnlStatVerificationRate";
            pnlStatVerificationRate.Size = new Size(216, 101);
            pnlStatVerificationRate.TabIndex = 2;
            // 
            // lblVerificationRate
            // 
            lblVerificationRate.AutoSize = true;
            lblVerificationRate.ForeColor = Color.FromArgb(156, 163, 175);
            lblVerificationRate.Location = new Point(12, 5);
            lblVerificationRate.Name = "lblVerificationRate";
            lblVerificationRate.Size = new Size(92, 15);
            lblVerificationRate.TabIndex = 8;
            lblVerificationRate.Text = "Verification Rate";
            // 
            // lblVeriRate
            // 
            lblVeriRate.AutoSize = true;
            lblVeriRate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVeriRate.ForeColor = Color.White;
            lblVeriRate.Location = new Point(12, 33);
            lblVeriRate.Name = "lblVeriRate";
            lblVeriRate.Size = new Size(66, 25);
            lblVeriRate.TabIndex = 7;
            lblVeriRate.Text = "94,2%";
            // 
            // lblBiometricMatch
            // 
            lblBiometricMatch.AutoSize = true;
            lblBiometricMatch.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBiometricMatch.ForeColor = Color.FromArgb(0, 220, 210);
            lblBiometricMatch.Location = new Point(12, 72);
            lblBiometricMatch.Name = "lblBiometricMatch";
            lblBiometricMatch.Size = new Size(147, 13);
            lblBiometricMatch.TabIndex = 6;
            lblBiometricMatch.Text = "Biometric match index high";
            // 
            // pnlStatTotalPlatformUsers
            // 
            pnlStatTotalPlatformUsers.BorderStyle = BorderStyle.FixedSingle;
            pnlStatTotalPlatformUsers.Controls.Add(lblNumberOfTotalUsers);
            pnlStatTotalPlatformUsers.Controls.Add(lblWaitingForVerifications);
            pnlStatTotalPlatformUsers.Controls.Add(lblTotalPlatformUsers);
            pnlStatTotalPlatformUsers.Location = new Point(15, 93);
            pnlStatTotalPlatformUsers.Name = "pnlStatTotalPlatformUsers";
            pnlStatTotalPlatformUsers.Size = new Size(216, 101);
            pnlStatTotalPlatformUsers.TabIndex = 1;
            // 
            // lblNumberOfTotalUsers
            // 
            lblNumberOfTotalUsers.AutoSize = true;
            lblNumberOfTotalUsers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberOfTotalUsers.ForeColor = Color.White;
            lblNumberOfTotalUsers.Location = new Point(15, 35);
            lblNumberOfTotalUsers.Name = "lblNumberOfTotalUsers";
            lblNumberOfTotalUsers.Size = new Size(72, 25);
            lblNumberOfTotalUsers.TabIndex = 7;
            lblNumberOfTotalUsers.Text = "14,892";
            // 
            // lblWaitingForVerifications
            // 
            lblWaitingForVerifications.AutoSize = true;
            lblWaitingForVerifications.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWaitingForVerifications.ForeColor = Color.FromArgb(0, 220, 210);
            lblWaitingForVerifications.Location = new Point(15, 77);
            lblWaitingForVerifications.Name = "lblWaitingForVerifications";
            lblWaitingForVerifications.RightToLeft = RightToLeft.No;
            lblWaitingForVerifications.Size = new Size(137, 13);
            lblWaitingForVerifications.TabIndex = 6;
            lblWaitingForVerifications.Text = "Awaiting verification: 148";
            // 
            // lblTotalPlatformUsers
            // 
            lblTotalPlatformUsers.AutoSize = true;
            lblTotalPlatformUsers.ForeColor = Color.FromArgb(156, 163, 175);
            lblTotalPlatformUsers.Location = new Point(15, 7);
            lblTotalPlatformUsers.Name = "lblTotalPlatformUsers";
            lblTotalPlatformUsers.Size = new Size(113, 15);
            lblTotalPlatformUsers.TabIndex = 5;
            lblTotalPlatformUsers.Text = "Total Platform Users";
            // 
            // pnlReportsTabs
            // 
            pnlReportsTabs.BorderStyle = BorderStyle.FixedSingle;
            pnlReportsTabs.Controls.Add(lblTabTransactionAnalytics);
            pnlReportsTabs.Controls.Add(lblTabTrustScoreDistribution);
            pnlReportsTabs.Controls.Add(lblTabVerificationMetrics);
            pnlReportsTabs.Controls.Add(lblTabUserAnalytics);
            pnlReportsTabs.Controls.Add(btnPlatformOverviewTab);
            pnlReportsTabs.Location = new Point(15, 9);
            pnlReportsTabs.Name = "pnlReportsTabs";
            pnlReportsTabs.Size = new Size(921, 40);
            pnlReportsTabs.TabIndex = 0;
            // 
            // lblTabTransactionAnalytics
            // 
            lblTabTransactionAnalytics.AutoSize = true;
            lblTabTransactionAnalytics.ForeColor = Color.FromArgb(156, 163, 175);
            lblTabTransactionAnalytics.Location = new Point(295, 13);
            lblTabTransactionAnalytics.Name = "lblTabTransactionAnalytics";
            lblTabTransactionAnalytics.Size = new Size(119, 15);
            lblTabTransactionAnalytics.TabIndex = 4;
            lblTabTransactionAnalytics.Text = "Transaction Analytics";
            // 
            // lblTabTrustScoreDistribution
            // 
            lblTabTrustScoreDistribution.AutoSize = true;
            lblTabTrustScoreDistribution.ForeColor = Color.FromArgb(156, 163, 175);
            lblTabTrustScoreDistribution.Location = new Point(559, 13);
            lblTabTrustScoreDistribution.Name = "lblTabTrustScoreDistribution";
            lblTabTrustScoreDistribution.Size = new Size(130, 15);
            lblTabTrustScoreDistribution.TabIndex = 3;
            lblTabTrustScoreDistribution.Text = "Trust Score Distribution\r\n";
            // 
            // lblTabVerificationMetrics
            // 
            lblTabVerificationMetrics.AutoSize = true;
            lblTabVerificationMetrics.ForeColor = Color.FromArgb(156, 163, 175);
            lblTabVerificationMetrics.Location = new Point(434, 13);
            lblTabVerificationMetrics.Name = "lblTabVerificationMetrics";
            lblTabVerificationMetrics.Size = new Size(108, 15);
            lblTabVerificationMetrics.TabIndex = 2;
            lblTabVerificationMetrics.Text = "Verification Metrics";
            // 
            // lblTabUserAnalytics
            // 
            lblTabUserAnalytics.AutoSize = true;
            lblTabUserAnalytics.ForeColor = Color.FromArgb(156, 163, 175);
            lblTabUserAnalytics.Location = new Point(199, 13);
            lblTabUserAnalytics.Name = "lblTabUserAnalytics";
            lblTabUserAnalytics.Size = new Size(81, 15);
            lblTabUserAnalytics.TabIndex = 1;
            lblTabUserAnalytics.Text = "User Analytics";
            // 
            // btnPlatformOverviewTab
            // 
            btnPlatformOverviewTab.BackColor = Color.FromArgb(22, 78, 99);
            btnPlatformOverviewTab.FlatAppearance.BorderSize = 0;
            btnPlatformOverviewTab.FlatStyle = FlatStyle.Flat;
            btnPlatformOverviewTab.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlatformOverviewTab.ForeColor = Color.White;
            btnPlatformOverviewTab.Location = new Point(32, 7);
            btnPlatformOverviewTab.Name = "btnPlatformOverviewTab";
            btnPlatformOverviewTab.Size = new Size(130, 23);
            btnPlatformOverviewTab.TabIndex = 0;
            btnPlatformOverviewTab.Text = "Platform Overview";
            btnPlatformOverviewTab.UseVisualStyleBackColor = false;
            // 
            // pnlVerificationContent
            // 
            pnlVerificationContent.Controls.Add(pnlVerificationBody);
            pnlVerificationContent.Controls.Add(pnlAnomalyWarning);
            pnlVerificationContent.Location = new Point(150, 67);
            pnlVerificationContent.Name = "pnlVerificationContent";
            pnlVerificationContent.Size = new Size(991, 702);
            pnlVerificationContent.TabIndex = 9;
            pnlVerificationContent.Visible = false;
            // 
            // pnlVerificationBody
            // 
            pnlVerificationBody.Controls.Add(btnQualificationVerification);
            pnlVerificationBody.Controls.Add(pnlVerificationInspector);
            pnlVerificationBody.Controls.Add(pnlSubmissionsQueue);
            pnlVerificationBody.ForeColor = Color.Cyan;
            pnlVerificationBody.Location = new Point(0, 0);
            pnlVerificationBody.Name = "pnlVerificationBody";
            pnlVerificationBody.Size = new Size(976, 648);
            pnlVerificationBody.TabIndex = 1;
            // 
            // btnQualificationVerification
            // 
            btnQualificationVerification.BackColor = Color.FromArgb(26, 30, 46);
            btnQualificationVerification.BackgroundImageLayout = ImageLayout.None;
            btnQualificationVerification.FlatAppearance.BorderSize = 0;
            btnQualificationVerification.FlatStyle = FlatStyle.Flat;
            btnQualificationVerification.Location = new Point(7, 8);
            btnQualificationVerification.Name = "btnQualificationVerification";
            btnQualificationVerification.Size = new Size(177, 23);
            btnQualificationVerification.TabIndex = 2;
            btnQualificationVerification.Text = "Qualification Submissions (0)";
            btnQualificationVerification.UseVisualStyleBackColor = false;
            btnQualificationVerification.Click += btnQualificationVerification_Click;
            // 
            // pnlVerificationInspector
            // 
            pnlVerificationInspector.BackColor = Color.FromArgb(26, 30, 46);
            pnlVerificationInspector.BorderStyle = BorderStyle.FixedSingle;
            pnlVerificationInspector.Controls.Add(btnRejectClaim);
            pnlVerificationInspector.Controls.Add(lblRejectionReasonTitle);
            pnlVerificationInspector.Controls.Add(btnAcceptClaim);
            pnlVerificationInspector.Controls.Add(chkCryptographicSignature);
            pnlVerificationInspector.Controls.Add(txtRejectionReason);
            pnlVerificationInspector.Controls.Add(chkDocumentExpiration);
            pnlVerificationInspector.Controls.Add(chkLivenessVerification);
            pnlVerificationInspector.Controls.Add(lblComplianceCheck);
            pnlVerificationInspector.Controls.Add(pnlAttachmentPreview);
            pnlVerificationInspector.Controls.Add(lblInspectorTitle);
            pnlVerificationInspector.Location = new Point(550, 40);
            pnlVerificationInspector.Name = "pnlVerificationInspector";
            pnlVerificationInspector.Size = new Size(431, 593);
            pnlVerificationInspector.TabIndex = 1;
            // 
            // btnRejectClaim
            // 
            btnRejectClaim.BackColor = Color.Red;
            btnRejectClaim.FlatAppearance.BorderSize = 0;
            btnRejectClaim.FlatStyle = FlatStyle.Flat;
            btnRejectClaim.ForeColor = Color.White;
            btnRejectClaim.Location = new Point(282, 549);
            btnRejectClaim.Name = "btnRejectClaim";
            btnRejectClaim.Size = new Size(89, 23);
            btnRejectClaim.TabIndex = 12;
            btnRejectClaim.Text = "Reject Claim";
            btnRejectClaim.UseVisualStyleBackColor = false;
            // 
            // lblRejectionReasonTitle
            // 
            lblRejectionReasonTitle.AutoSize = true;
            lblRejectionReasonTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRejectionReasonTitle.ForeColor = Color.White;
            lblRejectionReasonTitle.Location = new Point(9, 394);
            lblRejectionReasonTitle.Name = "lblRejectionReasonTitle";
            lblRejectionReasonTitle.Size = new Size(113, 17);
            lblRejectionReasonTitle.TabIndex = 6;
            lblRejectionReasonTitle.Text = "Rejection Reason";
            // 
            // btnAcceptClaim
            // 
            btnAcceptClaim.BackColor = Color.Green;
            btnAcceptClaim.FlatAppearance.BorderSize = 0;
            btnAcceptClaim.FlatStyle = FlatStyle.Flat;
            btnAcceptClaim.ForeColor = Color.White;
            btnAcceptClaim.Location = new Point(9, 549);
            btnAcceptClaim.Name = "btnAcceptClaim";
            btnAcceptClaim.Size = new Size(106, 23);
            btnAcceptClaim.TabIndex = 11;
            btnAcceptClaim.Text = "Accept Claim";
            btnAcceptClaim.UseVisualStyleBackColor = false;
            // 
            // chkCryptographicSignature
            // 
            chkCryptographicSignature.AutoSize = true;
            chkCryptographicSignature.ForeColor = Color.White;
            chkCryptographicSignature.Location = new Point(39, 372);
            chkCryptographicSignature.Name = "chkCryptographicSignature";
            chkCryptographicSignature.Size = new Size(277, 19);
            chkCryptographicSignature.TabIndex = 5;
            chkCryptographicSignature.Text = "Cryptographic signature matches registry issuer";
            chkCryptographicSignature.UseVisualStyleBackColor = true;
            // 
            // txtRejectionReason
            // 
            txtRejectionReason.BackColor = Color.FromArgb(38, 42, 61);
            txtRejectionReason.BorderStyle = BorderStyle.FixedSingle;
            txtRejectionReason.ForeColor = Color.White;
            txtRejectionReason.Location = new Point(9, 414);
            txtRejectionReason.Multiline = true;
            txtRejectionReason.Name = "txtRejectionReason";
            txtRejectionReason.Size = new Size(362, 116);
            txtRejectionReason.TabIndex = 10;
            // 
            // chkDocumentExpiration
            // 
            chkDocumentExpiration.AutoSize = true;
            chkDocumentExpiration.ForeColor = Color.White;
            chkDocumentExpiration.Location = new Point(40, 347);
            chkDocumentExpiration.Name = "chkDocumentExpiration";
            chkDocumentExpiration.Size = new Size(272, 19);
            chkDocumentExpiration.TabIndex = 4;
            chkDocumentExpiration.Text = "Document expiration is valid beyond 6 months";
            chkDocumentExpiration.UseVisualStyleBackColor = true;
            // 
            // chkLivenessVerification
            // 
            chkLivenessVerification.AutoSize = true;
            chkLivenessVerification.ForeColor = Color.White;
            chkLivenessVerification.Location = new Point(39, 322);
            chkLivenessVerification.Name = "chkLivenessVerification";
            chkLivenessVerification.Size = new Size(273, 19);
            chkLivenessVerification.TabIndex = 3;
            chkLivenessVerification.Text = "Liveness verification matches document photo";
            chkLivenessVerification.UseVisualStyleBackColor = true;
            // 
            // lblComplianceCheck
            // 
            lblComplianceCheck.AutoSize = true;
            lblComplianceCheck.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComplianceCheck.ForeColor = Color.White;
            lblComplianceCheck.Location = new Point(39, 302);
            lblComplianceCheck.Name = "lblComplianceCheck";
            lblComplianceCheck.Size = new Size(120, 17);
            lblComplianceCheck.TabIndex = 2;
            lblComplianceCheck.Text = "Compliance Check";
            // 
            // pnlAttachmentPreview
            // 
            pnlAttachmentPreview.BackColor = Color.FromArgb(38, 42, 61);
            pnlAttachmentPreview.Controls.Add(pbAttachmentImage);
            pnlAttachmentPreview.Controls.Add(lblAttachmentLabel);
            pnlAttachmentPreview.Location = new Point(39, 75);
            pnlAttachmentPreview.Name = "pnlAttachmentPreview";
            pnlAttachmentPreview.Size = new Size(277, 208);
            pnlAttachmentPreview.TabIndex = 1;
            // 
            // pbAttachmentImage
            // 
            pbAttachmentImage.Location = new Point(9, 25);
            pbAttachmentImage.Name = "pbAttachmentImage";
            pbAttachmentImage.Size = new Size(226, 167);
            pbAttachmentImage.SizeMode = PictureBoxSizeMode.CenterImage;
            pbAttachmentImage.TabIndex = 3;
            pbAttachmentImage.TabStop = false;
            // 
            // lblAttachmentLabel
            // 
            lblAttachmentLabel.AutoSize = true;
            lblAttachmentLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAttachmentLabel.ForeColor = Color.FromArgb(140, 140, 150);
            lblAttachmentLabel.Location = new Point(9, 9);
            lblAttachmentLabel.Name = "lblAttachmentLabel";
            lblAttachmentLabel.Size = new Size(134, 13);
            lblAttachmentLabel.TabIndex = 2;
            lblAttachmentLabel.Text = "SUBMITTED ATTACHMENT";
            // 
            // lblInspectorTitle
            // 
            lblInspectorTitle.AutoSize = true;
            lblInspectorTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInspectorTitle.ForeColor = Color.White;
            lblInspectorTitle.Location = new Point(46, 28);
            lblInspectorTitle.Name = "lblInspectorTitle";
            lblInspectorTitle.Size = new Size(140, 17);
            lblInspectorTitle.TabIndex = 0;
            lblInspectorTitle.Text = "Verification Inspector";
            // 
            // pnlSubmissionsQueue
            // 
            pnlSubmissionsQueue.BackColor = Color.FromArgb(26, 30, 46);
            pnlSubmissionsQueue.BorderStyle = BorderStyle.FixedSingle;
            pnlSubmissionsQueue.Controls.Add(dgvSubmissionsQueue);
            pnlSubmissionsQueue.Controls.Add(lblSortNewestFirst);
            pnlSubmissionsQueue.Controls.Add(lblActiveSubmissionsTitle);
            pnlSubmissionsQueue.Location = new Point(15, 37);
            pnlSubmissionsQueue.Name = "pnlSubmissionsQueue";
            pnlSubmissionsQueue.Size = new Size(529, 570);
            pnlSubmissionsQueue.TabIndex = 0;
            // 
            // dgvSubmissionsQueue
            // 
            dgvSubmissionsQueue.AllowUserToAddRows = false;
            dgvSubmissionsQueue.AllowUserToDeleteRows = false;
            dgvSubmissionsQueue.AllowUserToResizeColumns = false;
            dgvSubmissionsQueue.BackgroundColor = Color.FromArgb(8, 14, 28);
            dgvSubmissionsQueue.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSubmissionsQueue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubmissionsQueue.Columns.AddRange(new DataGridViewColumn[] { colSubmitter, colDocumentType, colPriority, colAssignedSpecialist, colAction });
            dgvSubmissionsQueue.GridColor = Color.FromArgb(45, 50, 68);
            dgvSubmissionsQueue.Location = new Point(11, 76);
            dgvSubmissionsQueue.Name = "dgvSubmissionsQueue";
            dgvSubmissionsQueue.RowHeadersVisible = false;
            dgvSubmissionsQueue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubmissionsQueue.Size = new Size(501, 255);
            dgvSubmissionsQueue.TabIndex = 2;
            // 
            // colSubmitter
            // 
            colSubmitter.HeaderText = "Submitter";
            colSubmitter.Name = "colSubmitter";
            // 
            // colDocumentType
            // 
            colDocumentType.HeaderText = "Document Type";
            colDocumentType.Name = "colDocumentType";
            // 
            // colPriority
            // 
            colPriority.HeaderText = "Priority";
            colPriority.Name = "colPriority";
            // 
            // colAssignedSpecialist
            // 
            colAssignedSpecialist.HeaderText = "Assigned Specialist";
            colAssignedSpecialist.Name = "colAssignedSpecialist";
            // 
            // colAction
            // 
            colAction.HeaderText = "Action";
            colAction.Name = "colAction";
            // 
            // lblSortNewestFirst
            // 
            lblSortNewestFirst.AutoSize = true;
            lblSortNewestFirst.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSortNewestFirst.ForeColor = Color.FromArgb(107, 114, 128);
            lblSortNewestFirst.Location = new Point(418, 45);
            lblSortNewestFirst.Name = "lblSortNewestFirst";
            lblSortNewestFirst.Size = new Size(94, 13);
            lblSortNewestFirst.TabIndex = 1;
            lblSortNewestFirst.Text = "Sort:Newest First";
            // 
            // lblActiveSubmissionsTitle
            // 
            lblActiveSubmissionsTitle.AutoSize = true;
            lblActiveSubmissionsTitle.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActiveSubmissionsTitle.ForeColor = Color.White;
            lblActiveSubmissionsTitle.Location = new Point(11, 45);
            lblActiveSubmissionsTitle.Name = "lblActiveSubmissionsTitle";
            lblActiveSubmissionsTitle.Size = new Size(104, 13);
            lblActiveSubmissionsTitle.TabIndex = 0;
            lblActiveSubmissionsTitle.Text = "Active Submissions";
            // 
            // pnlAnomalyWarning
            // 
            pnlAnomalyWarning.BackColor = Color.FromArgb(40, 18, 26);
            pnlAnomalyWarning.Controls.Add(lnkReviewAnomalyClaims);
            pnlAnomalyWarning.Controls.Add(lblAnomalyMessage);
            pnlAnomalyWarning.Controls.Add(lblAnomalyIcon);
            pnlAnomalyWarning.Location = new Point(0, 0);
            pnlAnomalyWarning.Name = "pnlAnomalyWarning";
            pnlAnomalyWarning.Size = new Size(976, 60);
            pnlAnomalyWarning.TabIndex = 0;
            // 
            // lnkReviewAnomalyClaims
            // 
            lnkReviewAnomalyClaims.AutoSize = true;
            lnkReviewAnomalyClaims.Location = new Point(819, 18);
            lnkReviewAnomalyClaims.Name = "lnkReviewAnomalyClaims";
            lnkReviewAnomalyClaims.Size = new Size(134, 15);
            lnkReviewAnomalyClaims.TabIndex = 2;
            lnkReviewAnomalyClaims.TabStop = true;
            lnkReviewAnomalyClaims.Text = "Review Anomaly Claims";
            // 
            // lblAnomalyMessage
            // 
            lblAnomalyMessage.AutoSize = true;
            lblAnomalyMessage.ForeColor = Color.Red;
            lblAnomalyMessage.Location = new Point(51, 18);
            lblAnomalyMessage.Name = "lblAnomalyMessage";
            lblAnomalyMessage.Size = new Size(369, 15);
            lblAnomalyMessage.TabIndex = 1;
            lblAnomalyMessage.Text = "Warning: 3 submissions have triggered conflicting database records..";
            // 
            // lblAnomalyIcon
            // 
            lblAnomalyIcon.AutoSize = true;
            lblAnomalyIcon.ForeColor = Color.Red;
            lblAnomalyIcon.Location = new Point(31, 16);
            lblAnomalyIcon.Name = "lblAnomalyIcon";
            lblAnomalyIcon.Size = new Size(14, 15);
            lblAnomalyIcon.TabIndex = 0;
            lblAnomalyIcon.Text = "●";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(17, 24, 39);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Controls.Add(btnNotifications);
            pnlHeader.Controls.Add(txtSearchRegistry);
            pnlHeader.Controls.Add(lblHeaderSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1157, 65);
            pnlHeader.TabIndex = 1;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.BackColor = Color.Transparent;
            lblHeaderTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(84, 5);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(323, 25);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "User Directory and  Administration";
            // 
            // btnNotifications
            // 
            btnNotifications.BackColor = Color.FromArgb(17, 24, 39);
            btnNotifications.FlatAppearance.BorderSize = 0;
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNotifications.ForeColor = Color.FromArgb(34, 211, 238);
            btnNotifications.Location = new Point(1053, 9);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(92, 23);
            btnNotifications.TabIndex = 2;
            btnNotifications.Text = "Notifications";
            btnNotifications.UseVisualStyleBackColor = false;
            // 
            // txtSearchRegistry
            // 
            txtSearchRegistry.BackColor = Color.FromArgb(8, 14, 28);
            txtSearchRegistry.ForeColor = Color.FromArgb(107, 114, 128);
            txtSearchRegistry.Location = new Point(829, 13);
            txtSearchRegistry.Name = "txtSearchRegistry";
            txtSearchRegistry.Size = new Size(210, 23);
            txtSearchRegistry.TabIndex = 2;
            txtSearchRegistry.Text = "Search reputation registry...";
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.BackColor = Color.Transparent;
            lblHeaderSubtitle.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeaderSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblHeaderSubtitle.Location = new Point(84, 36);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Size = new Size(340, 13);
            lblHeaderSubtitle.TabIndex = 1;
            lblHeaderSubtitle.Text = "Audit platform members, access scopes, and reputation standing";
            lblHeaderSubtitle.Click += lblHeaderSubtitle_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(17, 24, 39);
            pnlSidebar.Controls.Add(pnlSidebarBorder);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnSettings);
            pnlSidebar.Controls.Add(btnReviews);
            pnlSidebar.Controls.Add(btnVerification);
            pnlSidebar.Controls.Add(btnManageUsers);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblLogoAndName);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlSidebar.Location = new Point(0, 65);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(150, 720);
            pnlSidebar.TabIndex = 0;
            // 
            // pnlSidebarBorder
            // 
            pnlSidebarBorder.BackColor = Color.FromArgb(31, 41, 55);
            pnlSidebarBorder.Controls.Add(lblTrustID);
            pnlSidebarBorder.Dock = DockStyle.Left;
            pnlSidebarBorder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlSidebarBorder.Location = new Point(0, 0);
            pnlSidebarBorder.Name = "pnlSidebarBorder";
            pnlSidebarBorder.Size = new Size(1, 720);
            pnlSidebarBorder.TabIndex = 8;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.FromArgb(156, 163, 175);
            btnLogout.Location = new Point(10, 305);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(118, 25);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "⚙  Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.FromArgb(156, 163, 175);
            btnReports.Location = new Point(10, 185);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(118, 25);
            btnReports.TabIndex = 6;
            btnReports.Text = " ▥  Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.ForeColor = Color.FromArgb(156, 163, 175);
            btnSettings.Location = new Point(10, 265);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(118, 25);
            btnSettings.TabIndex = 5;
            btnSettings.Text = "⚙  Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnReviews
            // 
            btnReviews.FlatAppearance.BorderSize = 0;
            btnReviews.FlatStyle = FlatStyle.Flat;
            btnReviews.ForeColor = Color.FromArgb(156, 163, 175);
            btnReviews.Location = new Point(10, 225);
            btnReviews.Name = "btnReviews";
            btnReviews.Size = new Size(118, 25);
            btnReviews.TabIndex = 4;
            btnReviews.Text = "☆  Reviews";
            btnReviews.TextAlign = ContentAlignment.MiddleLeft;
            btnReviews.UseVisualStyleBackColor = true;
            btnReviews.Click += btnReviews_Click;
            // 
            // btnVerification
            // 
            btnVerification.BackColor = Color.FromArgb(17, 24, 39);
            btnVerification.FlatAppearance.BorderSize = 0;
            btnVerification.FlatStyle = FlatStyle.Flat;
            btnVerification.ForeColor = Color.FromArgb(156, 163, 175);
            btnVerification.Location = new Point(10, 145);
            btnVerification.Name = "btnVerification";
            btnVerification.Size = new Size(118, 25);
            btnVerification.TabIndex = 3;
            btnVerification.Text = "✓  Verification Requests";
            btnVerification.TextAlign = ContentAlignment.MiddleLeft;
            btnVerification.UseVisualStyleBackColor = false;
            btnVerification.Click += btnVerification_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.BackColor = Color.FromArgb(17, 24, 39);
            btnManageUsers.FlatAppearance.BorderSize = 0;
            btnManageUsers.FlatStyle = FlatStyle.Flat;
            btnManageUsers.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageUsers.ForeColor = Color.FromArgb(156, 163, 175);
            btnManageUsers.Location = new Point(10, 105);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(118, 25);
            btnManageUsers.TabIndex = 2;
            btnManageUsers.Text = "♙ Manage Users";
            btnManageUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnManageUsers.UseVisualStyleBackColor = false;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.FromArgb(156, 163, 175);
            btnDashboard.Location = new Point(10, 65);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(118, 25);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "▦ Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblLogoAndName
            // 
            lblLogoAndName.AutoSize = true;
            lblLogoAndName.BackColor = Color.Transparent;
            lblLogoAndName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogoAndName.ForeColor = SystemColors.Window;
            lblLogoAndName.Location = new Point(15, 15);
            lblLogoAndName.Name = "lblLogoAndName";
            lblLogoAndName.Size = new Size(77, 25);
            lblLogoAndName.TabIndex = 0;
            lblLogoAndName.Text = "TrustID";
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 28);
            ClientSize = new Size(1157, 785);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlVerificationContent);
            Controls.Add(pnlReportsContent);
            Controls.Add(pnlReviewsContent);
            Controls.Add(pnlSettingsContent);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrustID - Admin Dashboard";
            WindowState = FormWindowState.Maximized;
            pnlMainContent.ResumeLayout(false);
            pnlMainContent.PerformLayout();
            pnlSuspendedFlagged.ResumeLayout(false);
            pnlSuspendedFlagged.PerformLayout();
            pnlNewSignups.ResumeLayout(false);
            pnlNewSignups.PerformLayout();
            pnlActiveToday.ResumeLayout(false);
            pnlActiveToday.PerformLayout();
            pnlReviewsContent.ResumeLayout(false);
            pnlReviewsSummary.ResumeLayout(false);
            pnlReviewsSummary.PerformLayout();
            pnlReviewsList.ResumeLayout(false);
            pnlReviewer2.ResumeLayout(false);
            pnlReviewer2.PerformLayout();
            pnlReviewUser1.ResumeLayout(false);
            pnlReviewUser1.PerformLayout();
            pnlTotalUsers.ResumeLayout(false);
            pnlTotalUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            pnlSettingsContent.ResumeLayout(false);
            pnlLogoutOfSession.ResumeLayout(false);
            pnlLogoutOfSession.PerformLayout();
            pnlChangePassword.ResumeLayout(false);
            pnlChangePassword.PerformLayout();
            pnlEditAccountInformation.ResumeLayout(false);
            pnlEditAccountInformation.PerformLayout();
            pnlReportsContent.ResumeLayout(false);
            pnlHighestRatedIdentities.ResumeLayout(false);
            pnlHighestRatedIdentities.PerformLayout();
            pnlStatTotalTransactions.ResumeLayout(false);
            pnlStatTotalTransactions.PerformLayout();
            pnlStatAvgTrustScore.ResumeLayout(false);
            pnlStatAvgTrustScore.PerformLayout();
            pnlStatVerificationRate.ResumeLayout(false);
            pnlStatVerificationRate.PerformLayout();
            pnlStatTotalPlatformUsers.ResumeLayout(false);
            pnlStatTotalPlatformUsers.PerformLayout();
            pnlReportsTabs.ResumeLayout(false);
            pnlReportsTabs.PerformLayout();
            pnlVerificationContent.ResumeLayout(false);
            pnlVerificationBody.ResumeLayout(false);
            pnlVerificationInspector.ResumeLayout(false);
            pnlVerificationInspector.PerformLayout();
            pnlAttachmentPreview.ResumeLayout(false);
            pnlAttachmentPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAttachmentImage).EndInit();
            pnlSubmissionsQueue.ResumeLayout(false);
            pnlSubmissionsQueue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubmissionsQueue).EndInit();
            pnlAnomalyWarning.ResumeLayout(false);
            pnlAnomalyWarning.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlSidebarBorder.ResumeLayout(false);
            pnlSidebarBorder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMainContent;
        private Panel pnlSidebar;
        private Button btnDashboard;
        private Label lblLogoAndName;
        private Button btnLogout;
        private Button btnReports;
        private Button btnSettings;
        private Button btnReviews;
        private Button btnVerification;
        private Button btnManageUsers;
        private Panel pnlSidebarBorder;
        private Label lblTrustID;
        private Panel pnlHeader;
        private Label lblHeaderSubtitle;
        private Label lblHeaderTitle;
        private TextBox txtSearchRegistry;
        private Button btnNotifications;
        private Panel pnlTotalUsers;
        private Label lblTotalUsers;
        private Label lblTotalUsersTitle;
        private Label lblTotalUsersChange;
        private Panel pnlSuspendedFlagged;
        private Label lblActionRequired;
        private Label lblNumberOfSuspendeFlagged;
        private Label lblSuspendeFlagged;
        private Panel pnlNewSignups;
        private Label lblAwaitingPrimaryReview;
        private Label lblNumberOfSignups;
        private Label lblNewSignupsTitle;
        private Panel pnlActiveToday;
        private Label lblRateOfConcurrent;
        private Label lblNumberOfActive;
        private Label lblActiveToday;
        private ComboBox cmbRoleFilter;
        private TextBox txtSearchUser;
        private Button btnCreateUser;
        private ComboBox cmbStatusFilter;
        private DataGridView dgvUsers;
        private Panel pnlVerificationContent;
        private Panel pnlAnomalyWarning;
        private Label lblAnomalyMessage;
        private Label lblAnomalyIcon;
        private LinkLabel lnkReviewAnomalyClaims;
        private Panel pnlVerificationBody;
        private Panel pnlSubmissionsQueue;
        private Label lblSortNewestFirst;
        private Label lblActiveSubmissionsTitle;
        private DataGridView dgvSubmissionsQueue;
        private DataGridViewTextBoxColumn colSubmitter;
        private DataGridViewTextBoxColumn colDocumentType;
        private DataGridViewTextBoxColumn colPriority;
        private DataGridViewTextBoxColumn colAssignedSpecialist;
        private DataGridViewTextBoxColumn colAction;
        private Panel pnlVerificationInspector;
        private Label lblInspectorTitle;
        private Panel pnlAttachmentPreview;
        private Label lblAttachmentLabel;
        private PictureBox pbAttachmentImage;
        private CheckBox chkCryptographicSignature;
        private CheckBox chkDocumentExpiration;
        private CheckBox chkLivenessVerification;
        private Label lblComplianceCheck;
        private Label lblRejectionReasonTitle;
        private TextBox txtRejectionReason;
        private Button btnAcceptClaim;
        private Button btnRejectClaim;
        private Panel pnlReportsContent;
        private Panel pnlReportsTabs;
        private Button btnPlatformOverviewTab;
        private Label lblTabTransactionAnalytics;
        private Label lblTabTrustScoreDistribution;
        private Label lblTabVerificationMetrics;
        private Label lblTabUserAnalytics;
        private Panel pnlStatTotalTransactions;
        private Label lblTotalTransactions;
        private Label lblAvgSignIns;
        private Label lblNumberOfTotalTransactions;
        private Panel pnlStatAvgTrustScore;
        private Label lblAverageTrustScore;
        private Label lblExcelledCohort;
        private Label lblCalcuAvgTrustScore;
        private Panel pnlStatVerificationRate;
        private Label lblVerificationRate;
        private Label lblVeriRate;
        private Label lblBiometricMatch;
        private Panel pnlStatTotalPlatformUsers;
        private Label lblNumberOfTotalUsers;
        private Label lblWaitingForVerifications;
        private Label lblTotalPlatformUsers;
        private Panel pnlUserGrowthChart;
        private Panel pnlHighestRatedIdentities;
        private Panel pnlTrustScoreDistribution;
        private Label lblSecondPlace;
        private Label lblThirdPlace;
        private Label lblFirstPlace;
        private Label lblHighestRatedTitle;
        private Label lblFirstHighestRatedPerson;
        private Label lblSecondHighestRatedPerson;
        private Label lblThirdHighestRatedPerson;
        private Label lblTrustScoreFirstPlace;
        private Label lblTrustScoreSecondPlace;
        private Label lblTrustScoreThirdPlace;
        private Label lblThirdPersonVerification;
        private Label lblSecondPersonVerification;
        private Label lblFirstPersonVerification;
        private Panel pnlReviewsContent;
        private Panel pnlReviewsList;
        private Panel pnlReviewUser2;
        private Panel pnlReviewUser3;
        private Panel pnlReviewUser1;
        private System.Windows.Forms.Label lblReviewer1;
        private Label lblNameUser1;
        private Label lblRoleUser2;
        private Label lblNameUser2;
        private Label lblRoleUser3;
        private Label lblNameUser3;
        private Label lblFlaggedUser;
        private TextBox txtReviewUsers2;
        private TextBox txtReviewUser3;
        private TextBox txtReviewUser1;
        private Panel pnlReviewsSummary;
        private Label lblModerationOverviewHeading;
        private Button btnTabFlaggedReviews;
        private Label lblReasonForFlagUser1;
        private Label lblFlagged;
        private Button btnDismissReport;
        private Button btnSuspendReviewer;
        private Button btnRemoveReview;
        private Panel pnlReviewer2;
        private Button btnSuspendReviewer2;
        private Button btnRemoveReview2;
        private Label lblReasonForFlagUser2;
        private Label lblFlaggedUsers;
        private Button btnDissmissReport2;
        private TextBox textBox2;
        private Label lblReviewedUser;
        private Label lblReviewer2;
        private Label lblNumOfFlaggedReviews;
        private Label lblNumOfActionsTaken;
        private Label lblAvgResponseTime;
        private Label lblRatingDistributionHeading;
        private Label lbl4Stars;
        private Label lbl4StarsReceived;
        private Label lbl3Stars;
        private Label lbl3StarsReceived;
        private Label lbl2Stars;
        private Label lbl2StarsReceived;
        private Label lbl1Stars;
        private Label lbl1StarsReceived;
        private Label lbl5Stars;
        private Label lbl5StarsReceived;
        private Panel pnlSettingsContent;
        private Panel pnlChangePassword;
        private Label lblChangePasswordHeading;
        private Panel pnlEditAccountInformation;
        private Label lblFullName;
        private Label lblEditAccInforHeading;
        private TextBox txtFullName;
        private Label lblNewPassword;
        private TextBox txtCurrentPassword;
        private Label lblCurrentPassword;
        private Button btnSaveChanges;
        private TextBox txtEmailAddress;
        private Label lblEmailAddress;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblConfirmNewPassword;
        private TextBox txtConfirmNewPassword;
        private TextBox txtNewPassword;
        private Panel pnlLogoutOfSession;
        private Label lblSessionLogoutHeading;
        private Button btnLogoutSession;
        private Button btnUpdatePassword;
        private Label lblSubtitleForLogout;
        private DataGridViewTextBoxColumn colUserId;
        private DataGridViewTextBoxColumn colUserProfile;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colIdentityScope;
        private DataGridViewTextBoxColumn colTrustScore;
        private DataGridViewTextBoxColumn colAccStatus;
        private DataGridViewTextBoxColumn colJoinedDate;
        private DataGridViewTextBoxColumn colActions;
        private Button btnQualificationVerification;
    }
}
