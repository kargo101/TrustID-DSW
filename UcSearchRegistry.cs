using TrustID.Models;
using user_dashboard;

namespace user_dashboard
{
    public partial class UcSearchRegistry : UserControl
    {
        public UcSearchRegistry()
        {
            InitializeComponent();
            PremiumFormDesign.Apply(this, "Registry");
            this.Load += UcSearchRegistry_Load;
        }

        private void UcSearchRegistry_Load(object sender, EventArgs e)
        {
            if (dgvResults.Columns.Count == 0)
            {
                dgvResults.Columns.Add("colName", "Name");
                dgvResults.Columns.Add("colType", "Account Type");
                dgvResults.Columns.Add("colTrustScore", "Trust Score");
                dgvResults.Columns.Add("colStatus", "Verification");
            }

            LoadResults(Program.SharedUserManager.Users.ToList());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var results = Program.SharedUserManager.SearchUsers(txtSearch.Text);
            LoadResults(results);
        }

        private void LoadResults(List<User> users)
        {
            dgvResults.Rows.Clear();

            foreach (var user in users)
            {
                dgvResults.Rows.Add(
                    user.FullName,
                    user.GetUserTypeLabel(),
                    user.TrustScore.CurrentScore,
                    user.VerificationStatus.ToString());
            }
        }
    }
}
