using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TrustID.Models;

namespace user_dashboard
{
    public partial class UcTrustScore : UserControl
    {
        public UcTrustScore()
        {
            InitializeComponent();
            PremiumFormDesign.Apply(this, "TrustScore");
            this.Load += UcTrustScore_Load;
        }

        private void UcTrustScore_Load(object sender, EventArgs e)
        {
            LoadTrustScore();
        }

        private void LoadTrustScore()
        {
            User user = Program.CurrentUser;

            if (user == null)
                return;

            int currentScore = user.TrustScore.CurrentScore;

            // ==========================================
            // MAIN SCORE
            // ==========================================

            lblScoreNumber.Text = currentScore.ToString();

            lblScoreTier.Text =
                $"Tier: {user.TrustScore.GetTier()}";

            // ==========================================
            // GET ACTUAL CONTRIBUTIONS
            // ==========================================

            int transactions =
                user.TrustScore.GetContribution(
                    "Completed Transactions");

            int verificationSubmitted =
                user.TrustScore.GetContribution(
                    "Verification Submitted");

            int verificationApproved =
                user.TrustScore.GetContribution(
                    "Verification Approved");

            int verificationRejected =
                user.TrustScore.GetContribution(
                    "Verification Rejected");

            int positiveReviews =
                user.TrustScore.GetContribution(
                    "Positive Reviews");

            int negativeReviews =
                user.TrustScore.GetContribution(
                    "Negative Reviews");

            int qualificationsApproved =
                user.TrustScore.GetContribution(
                    "Qualifications Approved");

            int qualificationsRejected =
                user.TrustScore.GetContribution(
                    "Qualifications Rejected");

            // ==========================================
            // IDENTITY / VERIFICATION
            // ==========================================

            int identityScore =
                verificationSubmitted +
                verificationApproved +
                verificationRejected;

            SetRow(
                pbIdentity,
                lblIdentityValue,
                identityScore
            );

            // ==========================================
            // TRANSACTIONS
            // ==========================================

            SetRow(
                pbTransaction,
                lblTransactionValue,
                transactions
            );

            // ==========================================
            // REVIEWS
            // ==========================================

            int reviewScore =
                positiveReviews +
                negativeReviews;

            SetRow(
                pbReview,
                lblReviewValue,
                reviewScore
            );

            // ==========================================
            // QUALIFICATIONS
            // ==========================================
            int qualificationScore =
                qualificationsApproved + qualificationsRejected;

            SetRow(
                pbQualification,
                lblQualificationValue,
                qualificationScore);

            // ==========================================
            // RIGHT-HAND PANEL
            // ==========================================

            DisplayScoreBreakdown(user);
        }

        private void SetRow(
            ProgressBar bar,
            Label valueLabel,
            int score)
        {
            // Progress bars cannot display negative values.
            // Therefore the absolute contribution is used for
            // the visual bar while the label shows the real value.

            int displayValue =
                Math.Abs(score);

            displayValue =
                Math.Max(
                    0,
                    Math.Min(100, displayValue)
                );

            bar.Value = displayValue;

            if (score > 0)
            {
                valueLabel.Text = $"+{score}";
            }
            else if (score < 0)
            {
                valueLabel.Text = score.ToString();
            }
            else
            {
                valueLabel.Text = "0";
            }
        }

        private void DisplayScoreBreakdown(User user)
        {
            pnlRecommendations.Controls.Clear();

            // ==========================================
            // HEADER
            // ==========================================

            Label header = new Label
            {
                Text = "Trust Score Activity",
                AutoSize = true,
                Font = new Font(
                    "Segoe UI",
                    11.25F,
                    FontStyle.Bold
                ),
                ForeColor = Color.White,
                Location = new Point(12, 10)
            };

            pnlRecommendations.Controls.Add(header);

            // ==========================================
            // CURRENT SCORE
            // ==========================================

            Label currentScore = new Label
            {
                Text =
                    $"Current Score: {user.TrustScore.CurrentScore}/100",
                AutoSize = true,
                Font = new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold
                ),
                ForeColor = Color.FromArgb(0, 217, 255),
                Location = new Point(12, 38)
            };

            pnlRecommendations.Controls.Add(currentScore);

            // ==========================================
            // CONTRIBUTIONS
            // ==========================================

            var contributions =
                user.TrustScore
                    .GetContributions()
                    .Where(c => c.Value != 0)
                    .OrderByDescending(c => Math.Abs(c.Value))
                    .ToList();

            int y = 72;

            if (contributions.Count == 0)
            {
                Label emptyLabel = new Label
                {
                    Text =
                        "No Trust Score activity recorded yet.",
                    ForeColor = Color.Gray,
                    Location = new Point(12, y),
                    Size = new Size(235, 40)
                };

                pnlRecommendations.Controls.Add(emptyLabel);
                return;
            }

            foreach (var contribution in contributions)
            {
                bool positive =
                    contribution.Value > 0;

                string points =
                    positive
                        ? $"+{contribution.Value}"
                        : contribution.Value.ToString();

                Label factorLabel = new Label
                {
                    Text = contribution.Key,
                    AutoSize = false,
                    Size = new Size(175, 24),
                    Location = new Point(12, y),
                    ForeColor = Color.FromArgb(
                        210,
                        215,
                        225
                    ),
                    Font = new Font(
                        "Segoe UI",
                        8.5F
                    )
                };

                Label pointsLabel = new Label
                {
                    Text = points,
                    AutoSize = false,
                    Size = new Size(45, 24),
                    Location = new Point(205, y),
                    TextAlign = ContentAlignment.MiddleRight,
                    ForeColor = positive
                        ? Color.FromArgb(0, 217, 255)
                        : Color.IndianRed,
                    Font = new Font(
                        "Segoe UI",
                        8.5F,
                        FontStyle.Bold
                    )
                };

                pnlRecommendations.Controls.Add(
                    factorLabel
                );

                pnlRecommendations.Controls.Add(
                    pointsLabel
                );

                y += 28;

                // Prevent controls from running outside
                // the visible panel.
                if (y > pnlRecommendations.Height - 35)
                    break;
            }

            // ==========================================
            // RECOMMENDATIONS
            // ==========================================

            y += 8;

            Label recommendationTitle = new Label
            {
                Text = "Improve Your Score",
                AutoSize = true,
                Font = new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold
                ),
                ForeColor = Color.White,
                Location = new Point(12, y)
            };

            pnlRecommendations.Controls.Add(
                recommendationTitle
            );

            y += 28;

            AddRecommendation(
                "• Complete transactions",
                user.TrustScore.GetContribution(
                    "Completed Transactions"
                ) == 0,
                ref y
            );

            AddRecommendation(
                "• Submit verification documents",
                user.VerificationStatus ==
                    VerificationStatus.Unverified,
                ref y
            );

            AddRecommendation(
                "• Add verified qualifications",
                user.TrustScore.GetContribution(
                    "Qualifications Approved"
                ) == 0,
                ref y
            );

            AddRecommendation(
                "• Build positive reviews",
                user.TrustScore.GetContribution(
                    "Positive Reviews"
                ) == 0,
                ref y
            );
        }

        private void AddRecommendation(
            string text,
            bool show,
            ref int y)
        {
            if (!show)
                return;

            if (y > pnlRecommendations.Height - 25)
                return;

            Label recommendation = new Label
            {
                Text = text,
                AutoSize = false,
                Size = new Size(235, 22),
                Location = new Point(12, y),
                ForeColor = Color.FromArgb(
                    160,
                    170,
                    185
                ),
                Font = new Font(
                    "Segoe UI",
                    8.5F
                )
            };

            pnlRecommendations.Controls.Add(
                recommendation
            );

            y += 22;
        }
    }
}