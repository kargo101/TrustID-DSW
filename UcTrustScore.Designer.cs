using System.Drawing;
using System.Windows.Forms;

namespace user_dashboard
{
    partial class UcTrustScore
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblScoreNumber = new Label();
            lblScoreTier = new Label();
            lblBreakdownTitle = new Label();
            lblIdentityLabel = new Label();
            pbIdentity = new ProgressBar();
            lblIdentityValue = new Label();
            lblTransactionLabel = new Label();
            pbTransaction = new ProgressBar();
            lblTransactionValue = new Label();
            lblReviewLabel = new Label();
            pbReview = new ProgressBar();
            lblReviewValue = new Label();
            lblQualificationLabel = new Label();
            pbQualification = new ProgressBar();
            lblQualificationValue = new Label();
            pnlRecommendations = new Panel();
            lblRecommendationsHeader = new Label();
            pnlRecommendations.SuspendLayout();
            SuspendLayout();
            // 
            // lblScoreNumber
            // 
            lblScoreNumber.AutoSize = true;
            lblScoreNumber.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            lblScoreNumber.ForeColor = Color.FromArgb(0, 217, 255);
            lblScoreNumber.Location = new Point(0, 0);
            lblScoreNumber.Name = "lblScoreNumber";
            lblScoreNumber.Size = new Size(0, 72);
            lblScoreNumber.TabIndex = 0;
            // 
            // lblScoreTier
            // 
            lblScoreTier.AutoSize = true;
            lblScoreTier.Font = new Font("Segoe UI", 11F);
            lblScoreTier.ForeColor = Color.FromArgb(245, 247, 250);
            lblScoreTier.Location = new Point(0, 75);
            lblScoreTier.Name = "lblScoreTier";
            lblScoreTier.Size = new Size(0, 20);
            lblScoreTier.TabIndex = 1;
            // 
            // lblBreakdownTitle
            // 
            lblBreakdownTitle.AutoSize = true;
            lblBreakdownTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBreakdownTitle.ForeColor = Color.FromArgb(245, 247, 250);
            lblBreakdownTitle.Location = new Point(205, 14);
            lblBreakdownTitle.Name = "lblBreakdownTitle";
            lblBreakdownTitle.Size = new Size(217, 20);
            lblBreakdownTitle.TabIndex = 2;
            lblBreakdownTitle.Text = "Core Components Breakdown";
            // 
            // lblIdentityLabel
            // 
            lblIdentityLabel.AutoSize = true;
            lblIdentityLabel.ForeColor = Color.Gray;
            lblIdentityLabel.Location = new Point(16, 168);
            lblIdentityLabel.Name = "lblIdentityLabel";
            lblIdentityLabel.Size = new Size(109, 15);
            lblIdentityLabel.TabIndex = 3;
            lblIdentityLabel.Text = "Identity Verification";
            // 
            // pbIdentity
            // 
            pbIdentity.Location = new Point(16, 196);
            pbIdentity.Name = "pbIdentity";
            pbIdentity.Size = new Size(438, 10);
            pbIdentity.TabIndex = 4;
            // 
            // lblIdentityValue
            // 
            lblIdentityValue.AutoSize = true;
            lblIdentityValue.ForeColor = Color.Cyan;
            lblIdentityValue.Location = new Point(472, 196);
            lblIdentityValue.Name = "lblIdentityValue";
            lblIdentityValue.Size = new Size(23, 15);
            lblIdentityValue.TabIndex = 5;
            lblIdentityValue.Text = "0%";
            // 
            // lblTransactionLabel
            // 
            lblTransactionLabel.AutoSize = true;
            lblTransactionLabel.ForeColor = Color.Gray;
            lblTransactionLabel.Location = new Point(16, 218);
            lblTransactionLabel.Name = "lblTransactionLabel";
            lblTransactionLabel.Size = new Size(109, 15);
            lblTransactionLabel.TabIndex = 6;
            lblTransactionLabel.Text = "Transaction History";
            // 
            // pbTransaction
            // 
            pbTransaction.Location = new Point(16, 239);
            pbTransaction.Name = "pbTransaction";
            pbTransaction.Size = new Size(439, 12);
            pbTransaction.TabIndex = 7;
            // 
            // lblTransactionValue
            // 
            lblTransactionValue.AutoSize = true;
            lblTransactionValue.ForeColor = Color.Cyan;
            lblTransactionValue.Location = new Point(472, 239);
            lblTransactionValue.Name = "lblTransactionValue";
            lblTransactionValue.Size = new Size(23, 15);
            lblTransactionValue.TabIndex = 8;
            lblTransactionValue.Text = "0%";
            // 
            // lblReviewLabel
            // 
            lblReviewLabel.AutoSize = true;
            lblReviewLabel.ForeColor = Color.Gray;
            lblReviewLabel.Location = new Point(16, 264);
            lblReviewLabel.Name = "lblReviewLabel";
            lblReviewLabel.Size = new Size(107, 15);
            lblReviewLabel.TabIndex = 9;
            lblReviewLabel.Text = "Peer Review Rating";
            // 
            // pbReview
            // 
            pbReview.Location = new Point(16, 291);
            pbReview.Name = "pbReview";
            pbReview.Size = new Size(438, 10);
            pbReview.TabIndex = 10;
            // 
            // lblReviewValue
            // 
            lblReviewValue.AutoSize = true;
            lblReviewValue.ForeColor = Color.Cyan;
            lblReviewValue.Location = new Point(472, 286);
            lblReviewValue.Name = "lblReviewValue";
            lblReviewValue.Size = new Size(23, 15);
            lblReviewValue.TabIndex = 11;
            lblReviewValue.Text = "0%";
            // 
            // lblQualificationLabel
            // 
            lblQualificationLabel.AutoSize = true;
            lblQualificationLabel.ForeColor = Color.Gray;
            lblQualificationLabel.Location = new Point(16, 313);
            lblQualificationLabel.Name = "lblQualificationLabel";
            lblQualificationLabel.Size = new Size(120, 15);
            lblQualificationLabel.TabIndex = 12;
            lblQualificationLabel.Text = "Qualifications Record";
            // 
            // pbQualification
            // 
            pbQualification.Location = new Point(16, 338);
            pbQualification.Name = "pbQualification";
            pbQualification.Size = new Size(439, 12);
            pbQualification.TabIndex = 13;
            // 
            // lblQualificationValue
            // 
            lblQualificationValue.AutoSize = true;
            lblQualificationValue.ForeColor = Color.Cyan;
            lblQualificationValue.Location = new Point(472, 338);
            lblQualificationValue.Name = "lblQualificationValue";
            lblQualificationValue.Size = new Size(23, 15);
            lblQualificationValue.TabIndex = 14;
            lblQualificationValue.Text = "0%";
            // 
            // pnlRecommendations
            // 
            pnlRecommendations.BorderStyle = BorderStyle.FixedSingle;
            pnlRecommendations.Controls.Add(lblRecommendationsHeader);
            pnlRecommendations.Location = new Point(516, 54);
            pnlRecommendations.Name = "pnlRecommendations";
            pnlRecommendations.Size = new Size(264, 417);
            pnlRecommendations.TabIndex = 15;
            // 
            // lblRecommendationsHeader
            // 
            lblRecommendationsHeader.AutoSize = true;
            lblRecommendationsHeader.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecommendationsHeader.ForeColor = Color.White;
            lblRecommendationsHeader.Location = new Point(12, 10);
            lblRecommendationsHeader.Name = "lblRecommendationsHeader";
            lblRecommendationsHeader.Size = new Size(224, 20);
            lblRecommendationsHeader.TabIndex = 0;
            lblRecommendationsHeader.Text = "Recommendations To Improve";
            // 
            // UcTrustScore
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(10, 15, 29);
            Controls.Add(pnlRecommendations);
            Controls.Add(lblScoreNumber);
            Controls.Add(lblScoreTier);
            Controls.Add(lblBreakdownTitle);
            Controls.Add(lblIdentityLabel);
            Controls.Add(pbIdentity);
            Controls.Add(lblIdentityValue);
            Controls.Add(lblTransactionLabel);
            Controls.Add(pbTransaction);
            Controls.Add(lblTransactionValue);
            Controls.Add(lblReviewLabel);
            Controls.Add(pbReview);
            Controls.Add(lblReviewValue);
            Controls.Add(lblQualificationLabel);
            Controls.Add(pbQualification);
            Controls.Add(lblQualificationValue);
            Name = "UcTrustScore";
            Size = new Size(807, 500);
            pnlRecommendations.ResumeLayout(false);
            pnlRecommendations.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblScoreNumber;
        private Label lblScoreTier;
        private Label lblBreakdownTitle;
        private Label lblIdentityLabel;
        private ProgressBar pbIdentity;
        private Label lblIdentityValue;
        private Label lblTransactionLabel;
        private ProgressBar pbTransaction;
        private Label lblTransactionValue;
        private Label lblReviewLabel;
        private ProgressBar pbReview;
        private Label lblReviewValue;
        private Label lblQualificationLabel;
        private ProgressBar pbQualification;
        private Label lblQualificationValue;
        private Panel pnlRecommendations;
        private Label lblRecommendationsHeader;
    }
}
