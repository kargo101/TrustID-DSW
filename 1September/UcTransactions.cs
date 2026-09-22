using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace _1September
{
    public partial class UcTransactions : UserControl
    {
        public UcTransactions()
        {
            InitializeComponent();
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

        private void dtpExecution_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpExecution.Value;
            lblDtOfExec.Text = selectedDate.ToString("yyyy/MM/dd");
        }

        private void btnSearchParty_Click(object sender, EventArgs e)
        {
            string searchName = txtCounterPartyLookUp.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchName))
            {
                MessageBox.Show("Enter a party / individual to search for");
                return;
            }

            // Search users.txt
            string path = Path.Combine(Application.StartupPath, "users.txt");
            bool found = false;
            if (File.Exists(path))
            {
                foreach (var line in File.ReadAllLines(path))
                {
                    if (line.ToLower().Contains(searchName.ToLower()))
                    {
                        found = true;
                        var p = line.Split('|');
                        lblName.Text = p[0] + " " + p[1];
                        lblJob.Text = p.Length > 4 ? p[4] : "N/A";
                        lblCounterParty.Text = searchName;
                        lblScore.Text = "85%"; // you can calculate later
                        break;
                    }
                }
            }

            if (found)
            {
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

            string transactionType = cmbTransactType.Text;
            DateTime date_Of_Execution = dtpExecution.Value.Date;
            string userDescription = txtMilestoneDescription.Text;
            string userPartyLookup = txtCounterPartyLookUp.Text;
            decimal user_amount = Convert.ToDecimal(txtValueRewards.Text);

            string reference = transactionType.Substring(0, 1).ToUpper()
              + "-" + date_Of_Execution.ToString("ddMM")
              + "-" + user_amount.ToString().Substring(0, 2);

            Transactions userTransaction = new Transactions(
                $"{Program.CurrentUser.Name} {Program.CurrentUser.SecondName}",
                Program.CurrentUser.Email,
                Program.CurrentUser.CellNumber,
                userPartyLookup,
                user_amount,
                userDescription,
                date_Of_Execution,
                transactionType,
                reference
            );

            string filePath = Path.Combine(Application.StartupPath, "transactions.txt");
            if (!File.Exists(filePath)) File.Create(filePath).Close();
            File.AppendAllText(filePath, userTransaction.ToFileString() + Environment.NewLine);

            MessageBox.Show("Transaction Created Successfully");

            txtShowInformation.Text =
               "Transaction ID: " + reference + Environment.NewLine +
               "Transaction Type: " + transactionType + Environment.NewLine +
               "Date Of Execution: " + date_Of_Execution.ToString("yyyy/MM/dd") + Environment.NewLine +
               "Amount: R" + user_amount + Environment.NewLine +
               "Sending To: " + userPartyLookup + Environment.NewLine +
               "Description: " + userDescription + Environment.NewLine;
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

            txtShowInformation.Clear();
            foreach (var line in File.ReadAllLines(path))
            {
                var p = line.Split('|');
                if (p.Length >= 9 && p[2] == Program.CurrentUser.CellNumber)
                {
                    txtShowInformation.AppendText(line + Environment.NewLine);
                }
            }
        }

        private void lsvScore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvScore.SelectedItems.Count == 0) return;

            // Get selected transaction
            string selected = lsvScore.SelectedItems[0].Text; // e.g. "500 - Consultant"

            // Example: Calculate trust score based on number of transactions
            // You can make this smarter later
            int totalTransactions = lsvScore.Items.Count;
            int score = 50 + (totalTransactions * 5); // 50 base + 5 per transaction
            if (score > 100) score = 100;

            lblScore.Text = score.ToString() + "%";

            // Redraw the green circle with score
            pnlSearchCounterParty.Invalidate(); // triggers Paint event to redraw arc

            // Show details in txtShowInformation
            txtShowInformation.Text = $"Selected: {selected}\r\nTrust Score: {score}%";
        }

    }
}

