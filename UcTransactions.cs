using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace user_dashboard
{
    public partial class UcTransactions : UserControl
    {
        public UcTransactions()
        {
            InitializeComponent();
            PremiumFormDesign.Apply(this, "Transactions");
            this.Load += UcTransactions_Load;
        }

        private void UcTransactions_Load(object sender, EventArgs e)
        {
            MakeRound(pnlSearchCounterParty, 25);
            MakeRound(pnlReputationLinkedTransactions, 20);

            cmbTransactType.Items.Clear();
            cmbTransactType.Items.Add("Consultant Agreement");
            cmbTransactType.Items.Add("Non-disclosure Agreement");
            cmbTransactType.Items.Add("Partnership Agreement");
            cmbTransactType.Items.Add("Consulting Agreement");
            cmbTransactType.Items.Add("Loan Agreement");
            cmbTransactType.Items.Add("Employment Agreement");
            cmbTransactType.Items.Add("Service Agreement");
            cmbTransactType.SelectedIndex = -1;
        }

        private void MakeRound(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            control.Region = new Region(path);
        }
        private void cmbTransactType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTransactType.SelectedItem == null) return;
        }

        private void btnSearchParty_Click(object sender, EventArgs e)
        {
            string searchName = txtCounterPartyLookUp.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchName))
            {
                MessageBox.Show("Enter a party / individual to search for");
                return;
            }

            // Search real registered users via the shared UserManager
            // instead of reading users.txt directly - this way it finds
            // people even if they haven't been re-synced to the file yet.
            var results = Program.SharedUserManager.SearchUsers(searchName);
            bool found = results.Count > 0;

            if (found)
            {
                var match = results[0];
                lblName.Text = match.FullName;
                lblJob.Text = match.GetUserTypeLabel();
                lblCounterParty.Text = searchName;
                lblScore.Text = $"{match.TrustScore.CurrentScore}";
                MessageBox.Show($"Customer found : {searchName}");
            }
            else
            {
                MessageBox.Show($"Customer not found");
            }
        }

        private void btnEnterAmount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValueRewards.Text))
            {
                MessageBox.Show("Enter the amount");
                return;
            }

            if (int.TryParse(txtValueRewards.Text, out int userInput))
            {
                MessageBox.Show($"Amount accepted : {userInput}");
            }
            else
            {
                MessageBox.Show("Must contain numbers only");
            }
        }

        private void btnSubmitInfo_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser == null)
            {
                MessageBox.Show("No user logged in");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbTransactType.Text) ||
                string.IsNullOrWhiteSpace(txtCounterPartyLookUp.Text) ||
                string.IsNullOrWhiteSpace(txtValueRewards.Text))
            {
                MessageBox.Show("Fill Type, CounterParty and Amount");
                return;
            }

            if (!decimal.TryParse(txtValueRewards.Text, out decimal user_amount))
            {
                MessageBox.Show("Amount must contain numbers only");
                return;
            }

            string transactionType = cmbTransactType.Text;
            DateTime date_Of_Execution = dtpExecution.Value.Date;
            string userDescription = txtMilestoneDescription.Text;
            string userPartyLookup = txtCounterPartyLookUp.Text;

            string reference = transactionType.Substring(0, 1).ToUpper()
                + "-" + date_Of_Execution.ToString("ddMM")
                + "-" + user_amount.ToString("0.00").Replace(".", "");

            Transactions userTransaction = new Transactions(
                Program.CurrentUser.FullName,
                Program.CurrentUser.Email,
                "",
                userPartyLookup,
                user_amount,
                userDescription,
                date_Of_Execution,
                transactionType,
                reference
            );

            string filePath = Path.Combine(
                Application.StartupPath,
                "transactions.txt"
            );

            if (!File.Exists(filePath))
                File.Create(filePath).Close();

            File.AppendAllText(
                filePath,
                userTransaction.ToFileString() + Environment.NewLine
            );

            // ==========================================
            // ADD 15 TRUST POINTS FOR COMPLETED TRANSACTION
            // ==========================================

            Program.CurrentUser.TrustScore.TransactionCompleted();
            // Save the updated Trust Score
            Program.SharedUserManager.SaveChanges();
            // Update the score displayed on the screen
            lblScore.Text =
                Program.CurrentUser.TrustScore.CurrentScore.ToString() + "%";

            MessageBox.Show(
                "Transaction Created Successfully!\n\n" +
                "+15 Trust Points awarded.\n" +
                "Current Trust Score: " +
                Program.CurrentUser.TrustScore.CurrentScore + "%"
            );

            txtShowInformation.Text =
                "Transaction ID: " + reference + Environment.NewLine +
                "Transaction Type: " + transactionType + Environment.NewLine +
                "Date Of Execution: " + dtpExecution.Value.ToString("yyyy/MM/dd") + Environment.NewLine +
                "Amount: R" + user_amount.ToString("0.00") + Environment.NewLine +
                "Sending To: " + userPartyLookup + Environment.NewLine +
                "Description: " + userDescription + Environment.NewLine +
                "Trust Points Earned: +15" + Environment.NewLine +
                "Current Trust Score: " +
                Program.CurrentUser.TrustScore.CurrentScore + "%";
        }
        private void btnSubmitDescription_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMilestoneDescription.Text))
            {
                MessageBox.Show("Did not enter any description");
                return;
            }
            lblDescription.Text = txtMilestoneDescription.Text;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all information entered?", "CLEAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cmbTransactType.SelectedIndex = -1;
                txtCounterPartyLookUp.Clear();
                txtValueRewards.Clear();
                txtMilestoneDescription.Clear();
                txtShowInformation.Clear();
                lblDescription.Text = "";
                lblName.Text = "";
                lblJob.Text = "";
            }
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "transactions.txt");
            if (!File.Exists(path)) { MessageBox.Show("No transactions yet"); return; }
            if (Program.CurrentUser == null) return;

            txtShowInformation.Clear();
            foreach (var line in File.ReadAllLines(path))
            {
                var p = line.Split('|');
                // Was matched on CellNumber (index 2) - now matched on
                // Email (index 1) since User no longer tracks CellNumber.
                if (p.Length >= 9 && p[1].Equals(Program.CurrentUser.Email, StringComparison.OrdinalIgnoreCase))
                {
                    txtShowInformation.AppendText(line + Environment.NewLine);
                }
            }
        }

        private void lsvScore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvScore.SelectedItems.Count == 0)
                return;

            if (Program.CurrentUser == null)
                return;

            string selected = lsvScore.SelectedItems[0].Text;

            int score = Program.CurrentUser.TrustScore.CurrentScore;

            lblScore.Text = score.ToString() + "%";

            pnlSearchCounterParty.Invalidate();

            txtShowInformation.Text =
                $"Selected: {selected}\r\n" +
                $"Trust Score: {score}%";
        }

        private void dtpExecution_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpExecution.Value;
            lblDtOfExec.Text = selectedDate.ToString("yyyy/MM/dd");
        }
    }
}
