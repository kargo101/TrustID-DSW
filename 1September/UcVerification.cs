using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _1September
{
    public partial class UcVerification : UserControl
    {

        public UcVerification()
        {
            InitializeComponent();
            this.Load += UcVerification_Load;
        }
        private void UcVerification_Load(object sender, EventArgs e)
        {
            // Load the verification status for the current user
            if (Program.CurrentUser != null)
            {


            }
            cmbIDType.Items.Clear();
            cmbIDType.Items.AddRange(new string[] { "South African ID", "Passport", "Visa", "Work Permit", "Study Permit", "Asylum Seeker" });
            cmbIDType.DropDownStyle = ComboBoxStyle.DropDownList;

            if (dgvRequests.Columns.Count == 0)
            {
                dgvRequests.Columns.Add("RequestID", "Request ID");
                dgvRequests.Columns.Add("DocType", "Document Type");
                dgvRequests.Columns.Add("DocNumber", "Document Number");
                dgvRequests.Columns.Add("Expiry", "Expiry Date");
                dgvRequests.Columns.Add("Status", "Status");
                dgvRequests.Columns.Add("Date", "Date Submitted");
            }

            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequests.AllowUserToAddRows = false;

            dtpExpiryDate.MinDate = DateTime.Now.Date;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            {
                if (cmbIDType.SelectedIndex == -1 && string.IsNullOrEmpty(txtDocumentNumber.Text))
                {
                    MessageBox.Show("Please select Document Type and Number");
                    return;
                }
                if (cmbIDType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Document Type");
                    return;
                }
                if (string.IsNullOrEmpty(txtDocumentNumber.Text))
                {
                    MessageBox.Show("Please enter Document Number");
                    return;
                }

                if (dtpExpiryDate.Value.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Expiry date cannot be in the past");
                    return;
                }

                string filePath = Path.Combine(Application.StartupPath, "personal_docs.txt");
                int counter = File.Exists(filePath) ? File.ReadAllLines(filePath).Length + 1 : 1;

                string requestID = $"REQ-{counter:D3}";

                // REQ-01|Email|DocumentType|DocumentNumber|ExpiryDate|Pending|DateSubmitted
                string line = $"REQ-{counter:D3}|{Program.CurrentUser.Email}|{cmbIDType.Text}|{txtDocumentNumber.Text.Trim()}|{dtpExpiryDate.Value:yyyy-MM-dd}|Pending|{DateTime.Now:yyyy-MM-dd}";

                File.AppendAllText(filePath, line + Environment.NewLine);
                MessageBox.Show($"{cmbIDType.Text} submitted!");
                LoadRequests();
            }

            void LoadRequests()
            {
                dgvRequests.Rows.Clear();
                string filePath = Path.Combine(Application.StartupPath, "personal_docs.txt");
                if (!File.Exists(filePath)) return;

                foreach (string line in File.ReadAllLines(filePath))
                {
                    var p = line.Split('|');
                    if (p.Length < 7) continue;
                    if (p[1].Trim().ToLower() != Program.CurrentUser.Email.Trim().ToLower()) continue;

                    // RequestID, DocType, DocNumber, Expiry, Status, Date
                    dgvRequests.Rows.Add(p[0], p[2], p[3], p[4], p[5], p[6]);
                }
            }
        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
