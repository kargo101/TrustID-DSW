using TrustID.Models;
using user_dashboard;

namespace user_dashboard
{
    public partial class frmWriteReview : Form
    {
        public frmWriteReview()
        {
            InitializeComponent();
            PremiumFormDesign.Apply(this, "WriteReview");
            this.Load += frmWriteReview_Load;
        }

        private void frmWriteReview_Load(object sender, EventArgs e)
        {
            if (Program.CurrentUser == null)
            {
                Close();
                return;
            }

            var otherUsers = Program.SharedUserManager.Users
                .Where(u => u.UserId != Program.CurrentUser.UserId)
                .ToList();

            cmbTargetUser.DisplayMember = "FullName";
            cmbTargetUser.DataSource = otherUsers;

            cmbRating.Items.Clear();
            cmbRating.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
            cmbRating.SelectedIndex = 4; // default to 5 stars
        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            if (cmbTargetUser.SelectedItem == null)
            {
                MessageBox.Show("Please select who you're reviewing.");
                return;
            }

            User targetUser = (User)cmbTargetUser.SelectedItem;
            int rating = (int)cmbRating.SelectedItem;
            string comment = txtComment.Text.Trim();

            try
            {
                Program.SharedReviewManager.SubmitReview(Program.CurrentUser, targetUser, rating, comment);
                MessageBox.Show("Review submitted successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could Not Submit Review", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
