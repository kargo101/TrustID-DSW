namespace user_dashboard
{
    partial class UcDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlDashboardHeader = new Panel();
            lblWelcome = new Label();
            lblDashboardDescription = new Label();
            pnlStats = new Panel();
            pnlTrustScore = new Panel();
            lblTrustScoreTitle = new Label();
            lblTrustScore = new Label();
            pnlDocuments = new Panel();
            lblDocumentsTitle = new Label();
            lblDocuments = new Label();
            pnlTransactions = new Panel();
            lblTransactionsTitle = new Label();
            lblTransactions = new Label();
            pnlRating = new Panel();
            lblRatingTitle = new Label();
            lblRating = new Label();
            pnlQuickActions = new Panel();
            lblQuickActions = new Label();
            pnlVerifyDocument = new Panel();
            lblVerifyDocument = new Label();
            lblUploadanewdocumentforverification = new Label();
            pnlRecordTransaction = new Panel();
            lblRecordTransaction = new Label();
            lblLogareputationboundtransaction = new Label();
            pnlRecentActivity = new Panel();
            lblRecentActivity = new Label();
            lblCredentialsVerified = new Label();
            lblDocumentUploaded = new Label();
            lbltransactionCompleted = new Label();
            pnlDashboardHeader.SuspendLayout();
            pnlStats.SuspendLayout();
            pnlTrustScore.SuspendLayout();
            pnlDocuments.SuspendLayout();
            pnlTransactions.SuspendLayout();
            pnlRating.SuspendLayout();
            pnlQuickActions.SuspendLayout();
            pnlVerifyDocument.SuspendLayout();
            pnlRecordTransaction.SuspendLayout();
            pnlRecentActivity.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDashboardHeader
            // 
            pnlDashboardHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlDashboardHeader.Controls.Add(lblWelcome);
            pnlDashboardHeader.Controls.Add(lblDashboardDescription);
            pnlDashboardHeader.Location = new Point(25, 4);
            pnlDashboardHeader.Name = "pnlDashboardHeader";
            pnlDashboardHeader.Size = new Size(877, 65);
            pnlDashboardHeader.TabIndex = 3;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(245, 247, 250);
            lblWelcome.Location = new Point(0, 10);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 25);
            lblWelcome.TabIndex = 0;
            // 
            // lblDashboardDescription
            // 
            lblDashboardDescription.AutoSize = true;
            lblDashboardDescription.ForeColor = Color.FromArgb(138, 148, 168);
            lblDashboardDescription.Location = new Point(25, 38);
            lblDashboardDescription.Name = "lblDashboardDescription";
            lblDashboardDescription.Size = new Size(224, 15);
            lblDashboardDescription.TabIndex = 1;
            lblDashboardDescription.Text = "Here's an overview of your TrustID profile";
            // 
            // pnlStats
            // 
            pnlStats.BorderStyle = BorderStyle.FixedSingle;
            pnlStats.Controls.Add(pnlTrustScore);
            pnlStats.Controls.Add(pnlDocuments);
            pnlStats.Controls.Add(pnlTransactions);
            pnlStats.Controls.Add(pnlRating);
            pnlStats.Location = new Point(25, 75);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(877, 120);
            pnlStats.TabIndex = 2;
            // 
            // pnlTrustScore
            // 
            pnlTrustScore.BackColor = Color.FromArgb(20, 27, 45);
            pnlTrustScore.BorderStyle = BorderStyle.FixedSingle;
            pnlTrustScore.Controls.Add(lblTrustScoreTitle);
            pnlTrustScore.Controls.Add(lblTrustScore);
            pnlTrustScore.Location = new Point(6, 3);
            pnlTrustScore.Name = "pnlTrustScore";
            pnlTrustScore.Size = new Size(196, 90);
            pnlTrustScore.TabIndex = 0;
            // 
            // lblTrustScoreTitle
            // 
            lblTrustScoreTitle.AutoSize = true;
            lblTrustScoreTitle.ForeColor = Color.FromArgb(138, 148, 168);
            lblTrustScoreTitle.Location = new Point(10, 15);
            lblTrustScoreTitle.Name = "lblTrustScoreTitle";
            lblTrustScoreTitle.Size = new Size(65, 15);
            lblTrustScoreTitle.TabIndex = 0;
            lblTrustScoreTitle.Text = "Trust Score";
            // 
            // lblTrustScore
            // 
            lblTrustScore.AutoSize = true;
            lblTrustScore.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrustScore.ForeColor = Color.FromArgb(245, 247, 250);
            lblTrustScore.Location = new Point(10, 40);
            lblTrustScore.Name = "lblTrustScore";
            lblTrustScore.Size = new Size(0, 25);
            lblTrustScore.TabIndex = 1;
            // 
            // pnlDocuments
            // 
            pnlDocuments.BackColor = Color.FromArgb(20, 27, 45);
            pnlDocuments.BorderStyle = BorderStyle.FixedSingle;
            pnlDocuments.Controls.Add(lblDocumentsTitle);
            pnlDocuments.Controls.Add(lblDocuments);
            pnlDocuments.Location = new Point(228, 3);
            pnlDocuments.Name = "pnlDocuments";
            pnlDocuments.Size = new Size(188, 90);
            pnlDocuments.TabIndex = 1;
            // 
            // lblDocumentsTitle
            // 
            lblDocumentsTitle.AutoSize = true;
            lblDocumentsTitle.ForeColor = Color.FromArgb(138, 148, 168);
            lblDocumentsTitle.Location = new Point(10, 15);
            lblDocumentsTitle.Name = "lblDocumentsTitle";
            lblDocumentsTitle.Size = new Size(110, 15);
            lblDocumentsTitle.TabIndex = 0;
            lblDocumentsTitle.Text = "Verified Documents";
            // 
            // lblDocuments
            // 
            lblDocuments.AutoSize = true;
            lblDocuments.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocuments.ForeColor = Color.FromArgb(245, 247, 250);
            lblDocuments.Location = new Point(10, 40);
            lblDocuments.Name = "lblDocuments";
            lblDocuments.Size = new Size(0, 25);
            lblDocuments.TabIndex = 1;
            // 
            // pnlTransactions
            // 
            pnlTransactions.BackColor = Color.FromArgb(20, 27, 45);
            pnlTransactions.BorderStyle = BorderStyle.FixedSingle;
            pnlTransactions.Controls.Add(lblTransactionsTitle);
            pnlTransactions.Controls.Add(lblTransactions);
            pnlTransactions.Location = new Point(435, 3);
            pnlTransactions.Name = "pnlTransactions";
            pnlTransactions.Size = new Size(190, 90);
            pnlTransactions.TabIndex = 2;
            // 
            // lblTransactionsTitle
            // 
            lblTransactionsTitle.AutoSize = true;
            lblTransactionsTitle.ForeColor = Color.FromArgb(138, 148, 168);
            lblTransactionsTitle.Location = new Point(10, 15);
            lblTransactionsTitle.Name = "lblTransactionsTitle";
            lblTransactionsTitle.Size = new Size(73, 15);
            lblTransactionsTitle.TabIndex = 0;
            lblTransactionsTitle.Text = "Transactions";
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactions.ForeColor = Color.FromArgb(245, 247, 250);
            lblTransactions.Location = new Point(10, 40);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(0, 25);
            lblTransactions.TabIndex = 1;
            // 
            // pnlRating
            // 
            pnlRating.BackColor = Color.FromArgb(20, 27, 45);
            pnlRating.BorderStyle = BorderStyle.FixedSingle;
            pnlRating.Controls.Add(lblRatingTitle);
            pnlRating.Controls.Add(lblRating);
            pnlRating.Location = new Point(645, 3);
            pnlRating.Name = "pnlRating";
            pnlRating.Size = new Size(191, 90);
            pnlRating.TabIndex = 3;
            // 
            // lblRatingTitle
            // 
            lblRatingTitle.AutoSize = true;
            lblRatingTitle.ForeColor = Color.FromArgb(138, 148, 168);
            lblRatingTitle.Location = new Point(10, 15);
            lblRatingTitle.Name = "lblRatingTitle";
            lblRatingTitle.Size = new Size(87, 15);
            lblRatingTitle.TabIndex = 0;
            lblRatingTitle.Text = "Average Rating";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRating.ForeColor = Color.FromArgb(245, 247, 250);
            lblRating.Location = new Point(10, 40);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(0, 25);
            lblRating.TabIndex = 1;
            // 
            // pnlQuickActions
            // 
            pnlQuickActions.BorderStyle = BorderStyle.FixedSingle;
            pnlQuickActions.Controls.Add(lblQuickActions);
            pnlQuickActions.Controls.Add(pnlVerifyDocument);
            pnlQuickActions.Controls.Add(pnlRecordTransaction);
            pnlQuickActions.Location = new Point(25, 195);
            pnlQuickActions.Name = "pnlQuickActions";
            pnlQuickActions.Size = new Size(877, 160);
            pnlQuickActions.TabIndex = 1;
            // 
            // lblQuickActions
            // 
            lblQuickActions.AutoSize = true;
            lblQuickActions.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblQuickActions.ForeColor = Color.FromArgb(245, 247, 250);
            lblQuickActions.Location = new Point(25, 3);
            lblQuickActions.Name = "lblQuickActions";
            lblQuickActions.Size = new Size(105, 20);
            lblQuickActions.TabIndex = 0;
            lblQuickActions.Text = "Quick Actions";
            // 
            // pnlVerifyDocument
            // 
            pnlVerifyDocument.BackColor = Color.FromArgb(20, 27, 45);
            pnlVerifyDocument.BorderStyle = BorderStyle.FixedSingle;
            pnlVerifyDocument.Controls.Add(lblVerifyDocument);
            pnlVerifyDocument.Controls.Add(lblUploadanewdocumentforverification);
            pnlVerifyDocument.Location = new Point(25, 45);
            pnlVerifyDocument.Name = "pnlVerifyDocument";
            pnlVerifyDocument.Size = new Size(290, 100);
            pnlVerifyDocument.TabIndex = 1;
            // 
            // lblVerifyDocument
            // 
            lblVerifyDocument.AutoSize = true;
            lblVerifyDocument.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVerifyDocument.ForeColor = Color.FromArgb(245, 247, 250);
            lblVerifyDocument.Location = new Point(12, 15);
            lblVerifyDocument.Name = "lblVerifyDocument";
            lblVerifyDocument.Size = new Size(120, 19);
            lblVerifyDocument.TabIndex = 0;
            lblVerifyDocument.Text = "Verify Document";
            // 
            // lblUploadanewdocumentforverification
            // 
            lblUploadanewdocumentforverification.AutoSize = true;
            lblUploadanewdocumentforverification.ForeColor = Color.FromArgb(138, 148, 168);
            lblUploadanewdocumentforverification.Location = new Point(12, 45);
            lblUploadanewdocumentforverification.Name = "lblUploadanewdocumentforverification";
            lblUploadanewdocumentforverification.Size = new Size(183, 15);
            lblUploadanewdocumentforverification.TabIndex = 1;
            lblUploadanewdocumentforverification.Text = "Upload document for verification";
            // 
            // pnlRecordTransaction
            // 
            pnlRecordTransaction.BackColor = Color.FromArgb(20, 27, 45);
            pnlRecordTransaction.BorderStyle = BorderStyle.FixedSingle;
            pnlRecordTransaction.Controls.Add(lblRecordTransaction);
            pnlRecordTransaction.Controls.Add(lblLogareputationboundtransaction);
            pnlRecordTransaction.Location = new Point(345, 45);
            pnlRecordTransaction.Name = "pnlRecordTransaction";
            pnlRecordTransaction.Size = new Size(300, 100);
            pnlRecordTransaction.TabIndex = 2;
            // 
            // lblRecordTransaction
            // 
            lblRecordTransaction.AutoSize = true;
            lblRecordTransaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRecordTransaction.ForeColor = Color.FromArgb(245, 247, 250);
            lblRecordTransaction.Location = new Point(12, 15);
            lblRecordTransaction.Name = "lblRecordTransaction";
            lblRecordTransaction.Size = new Size(137, 19);
            lblRecordTransaction.TabIndex = 0;
            lblRecordTransaction.Text = "Record Transaction";
            // 
            // lblLogareputationboundtransaction
            // 
            lblLogareputationboundtransaction.AutoSize = true;
            lblLogareputationboundtransaction.ForeColor = Color.FromArgb(138, 148, 168);
            lblLogareputationboundtransaction.Location = new Point(12, 45);
            lblLogareputationboundtransaction.Name = "lblLogareputationboundtransaction";
            lblLogareputationboundtransaction.Size = new Size(196, 15);
            lblLogareputationboundtransaction.TabIndex = 1;
            lblLogareputationboundtransaction.Text = "Log a reputation-bound transaction";
            // 
            // pnlRecentActivity
            // 
            pnlRecentActivity.BackColor = Color.FromArgb(20, 27, 45);
            pnlRecentActivity.BorderStyle = BorderStyle.FixedSingle;
            pnlRecentActivity.Controls.Add(lblRecentActivity);
            pnlRecentActivity.Controls.Add(lblCredentialsVerified);
            pnlRecentActivity.Controls.Add(lblDocumentUploaded);
            pnlRecentActivity.Controls.Add(lbltransactionCompleted);
            pnlRecentActivity.Location = new Point(25, 355);
            pnlRecentActivity.Name = "pnlRecentActivity";
            pnlRecentActivity.Size = new Size(877, 176);
            pnlRecentActivity.TabIndex = 0;
            // 
            // lblRecentActivity
            // 
            lblRecentActivity.AutoSize = true;
            lblRecentActivity.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRecentActivity.ForeColor = Color.FromArgb(245, 247, 250);
            lblRecentActivity.Location = new Point(6, 3);
            lblRecentActivity.Name = "lblRecentActivity";
            lblRecentActivity.Size = new Size(115, 20);
            lblRecentActivity.TabIndex = 0;
            lblRecentActivity.Text = "Recent Activity";
            // 
            // lblCredentialsVerified
            // 
            lblCredentialsVerified.AutoSize = true;
            lblCredentialsVerified.ForeColor = Color.FromArgb(245, 247, 250);
            lblCredentialsVerified.Location = new Point(6, 45);
            lblCredentialsVerified.Name = "lblCredentialsVerified";
            lblCredentialsVerified.Size = new Size(0, 15);
            lblCredentialsVerified.TabIndex = 1;
            // 
            // lblDocumentUploaded
            // 
            lblDocumentUploaded.AutoSize = true;
            lblDocumentUploaded.ForeColor = Color.FromArgb(245, 247, 250);
            lblDocumentUploaded.Location = new Point(6, 84);
            lblDocumentUploaded.Name = "lblDocumentUploaded";
            lblDocumentUploaded.Size = new Size(0, 15);
            lblDocumentUploaded.TabIndex = 2;
            // 
            // lbltransactionCompleted
            // 
            lbltransactionCompleted.AutoSize = true;
            lbltransactionCompleted.ForeColor = Color.FromArgb(245, 247, 250);
            lbltransactionCompleted.Location = new Point(6, 123);
            lbltransactionCompleted.Name = "lbltransactionCompleted";
            lbltransactionCompleted.Size = new Size(0, 15);
            lbltransactionCompleted.TabIndex = 3;
            // 
            // UcDashboard
            // 
            AutoSize = true;
            BackColor = Color.FromArgb(10, 15, 29);
            Controls.Add(pnlRecentActivity);
            Controls.Add(pnlQuickActions);
            Controls.Add(pnlStats);
            Controls.Add(pnlDashboardHeader);
            Name = "UcDashboard";
            Size = new Size(947, 660);
            pnlDashboardHeader.ResumeLayout(false);
            pnlDashboardHeader.PerformLayout();
            pnlStats.ResumeLayout(false);
            pnlTrustScore.ResumeLayout(false);
            pnlTrustScore.PerformLayout();
            pnlDocuments.ResumeLayout(false);
            pnlDocuments.PerformLayout();
            pnlTransactions.ResumeLayout(false);
            pnlTransactions.PerformLayout();
            pnlRating.ResumeLayout(false);
            pnlRating.PerformLayout();
            pnlQuickActions.ResumeLayout(false);
            pnlQuickActions.PerformLayout();
            pnlVerifyDocument.ResumeLayout(false);
            pnlVerifyDocument.PerformLayout();
            pnlRecordTransaction.ResumeLayout(false);
            pnlRecordTransaction.PerformLayout();
            pnlRecentActivity.ResumeLayout(false);
            pnlRecentActivity.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlDashboardHeader;
        private Label lblWelcome;
        private Label lblDashboardDescription;
        private Panel pnlStats;
        private Panel pnlTrustScore;
        private Label lblTrustScoreTitle;
        private Label lblTrustScore;
        private Panel pnlDocuments;
        private Label lblDocumentsTitle;
        private Label lblDocuments;
        private Panel pnlTransactions;
        private Label lblTransactionsTitle;
        private Label lblTransactions;
        private Panel pnlRating;
        private Label lblRatingTitle;
        private Label lblRating;
        private Panel pnlQuickActions;
        private Label lblQuickActions;
        private Panel pnlVerifyDocument;
        private Label lblVerifyDocument;
        private Label lblUploadanewdocumentforverification;
        private Panel pnlRecordTransaction;
        private Label lblRecordTransaction;
        private Label lblLogareputationboundtransaction;
        private Panel pnlRecentActivity;
        private Label lblRecentActivity;
        private Label lblCredentialsVerified;
        private Label lblDocumentUploaded;
        private Label lbltransactionCompleted;
    }
}
