using TrustID.Models;

namespace user_dashboard
{
    public partial class UcReviews : UserControl
    {
        public UcReviews()
        {
            InitializeComponent();
            PremiumFormDesign.Apply(this, "Reviews");
            this.Load += UcReviews_Load;
        }

        private void UcReviews_Load(object sender, EventArgs e)
        {
            User? user = Program.CurrentUser;
            if (user == null) return;

            var reviews = Program.SharedReviewManager.GetReviewsForUser(user.UserId);

            lblAverageNumber.Text = reviews.Count == 0 ? "N/A" : $"{reviews.Average(r => r.Rating):0.00}";
            lblAverageSubtext.Text = $"Average of {reviews.Count} Peer Review(s)";

            int count5 = reviews.Count(r => r.Rating == 5);
            int count4 = reviews.Count(r => r.Rating == 4);
            int count3 = reviews.Count(r => r.Rating == 3);
            int count2 = reviews.Count(r => r.Rating == 2);
            int count1 = reviews.Count(r => r.Rating == 1);
            int total = Math.Max(reviews.Count, 1);

            pb5.Value = (count5 * 100) / total; lblCount5.Text = count5.ToString();
            pb4.Value = (count4 * 100) / total; lblCount4.Text = count4.ToString();
            pb3.Value = (count3 * 100) / total; lblCount3.Text = count3.ToString();
            pb2.Value = (count2 * 100) / total; lblCount2.Text = count2.ToString();
            pb1.Value = (count1 * 100) / total; lblCount1.Text = count1.ToString();

            pnlReviewsList.Controls.Clear();
            int y = 0;

            if (reviews.Count == 0)
            {
                pnlReviewsList.Controls.Add(new Label
                {
                    Text = "No reviews yet.",
                    ForeColor = Color.Gray,
                    Location = new Point(0, 0),
                    AutoSize = true
                });
                return;
            }

            foreach (var review in reviews)
            {
                bool dark = PremiumFormDesign.DarkMode;

                var card = new Panel
                {
                    BackColor = dark
                        ? Color.FromArgb(6, 25, 46)
                        : Color.FromArgb(250, 253, 255),
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(0, y),
                    Size = new Size(430, 100)
                };

                card.Controls.Add(new Label
                {
                    Text = review.Reviewer.FullName,
                    ForeColor = PremiumFormDesign.DarkMode
                        ? Color.White
                        : Color.FromArgb(12, 29, 52),
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    Location = new Point(10, 8),
                    AutoSize = true
                });

                card.Controls.Add(new Label
                {
                    Text = new string('★', review.Rating) + new string('☆', 5 - review.Rating),
                    ForeColor = Color.FromArgb(255, 200, 40),
                    Location = new Point(10, 30),
                    AutoSize = true
                });

                card.Controls.Add(new Label
                {
                    Text = review.Comment,
                    ForeColor = PremiumFormDesign.DarkMode
                        ? Color.FromArgb(200, 210, 225)
                        : Color.FromArgb(82, 106, 133),
                    Location = new Point(10, 52),
                    Size = new Size(410, 40)
                });

                pnlReviewsList.Controls.Add(card);
                y += 110;
            }
        }

        private void btnWriteReview_Click(object sender, EventArgs e)
        {
            using (frmWriteReview writeReviewForm = new frmWriteReview())
            {
                writeReviewForm.ShowDialog();
            }
            UcReviews_Load(this, EventArgs.Empty);
        }
    }
}

