using TrustID.Models;

namespace user_dashboard
{
    public partial class UcDashboard : UserControl
    {
        public UcDashboard()
        {
            InitializeComponent();
            PremiumFormDesign.Apply(this, "Dashboard");
            this.Load += UcDashboard_Load;
        }

        private void UcDashboard_Load(object sender, EventArgs e)
        {
            User user = Program.CurrentUser;
            if (user == null) return;

            lblWelcome.Text = $"Welcome back, {user.FullName}";
            lblTrustScore.Text = user.TrustScore.CurrentScore.ToString();

            int documentsVerified = Program.SharedVerificationManager.Requests
                .Count(r => r.Applicant.UserId == user.UserId && r.Status == RequestStatus.Approved);
            lblDocuments.Text = documentsVerified.ToString();

            int transactionCount = CountTransactions(user.Email);
            lblTransactions.Text = transactionCount.ToString();

            var reviews = Program.SharedReviewManager.GetReviewsForUser(user.UserId);
            lblRating.Text = reviews.Count == 0
                ? "No ratings yet"
                : $"{reviews.Average(r => r.Rating):0.00} / 5";

            LoadRecentActivity(user);
        }

        private int CountTransactions(string email)
        {
            string path = Path.Combine(Application.StartupPath, "transactions.txt");
            if (!File.Exists(path)) return 0;

            return File.ReadAllLines(path)
                .Count(line => line.Split('|').Length >= 2 &&
                               line.Split('|')[1].Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        private void LoadRecentActivity(User user)
        {
            var pendingCount = Program.SharedVerificationManager.Requests
                .Count(r => r.Applicant.UserId == user.UserId && r.Status == RequestStatus.Pending);
            var approvedCount = Program.SharedVerificationManager.Requests
                .Count(r => r.Applicant.UserId == user.UserId && r.Status == RequestStatus.Approved);

            lblCredentialsVerified.Text = $"Credentials Verified: {approvedCount}";
            lblDocumentUploaded.Text = $"Pending Verification: {pendingCount}";

            int transactionCount = CountTransactions(user.Email);
            lbltransactionCompleted.Text = $"Transactions Recorded: {transactionCount}";
        }
    }
}
