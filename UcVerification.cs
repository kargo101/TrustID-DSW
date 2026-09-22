using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrustID.Models;

namespace user_dashboard
{
    public partial class UcVerification : UserControl
    {
        public UcVerification()
        {
            InitializeComponent();
            PremiumFormDesign.Apply(this, "Verification");
            this.Load += UcVerification_Load;
        }

        private void UcVerification_Load(object sender, EventArgs e)
        {
            cmbIDType.Items.Clear();
            cmbIDType.Items.AddRange(new string[] { "South African ID", "Passport", "Visa", "Work Permit", "Study Permit", "Asylum Seeker" });
            cmbIDType.DropDownStyle = ComboBoxStyle.DropDownList;

            if (dgvRequests.Columns.Count == 0)
            {
                dgvRequests.Columns.Add("RequestID", "Request ID");
                dgvRequests.Columns.Add("DocType", "Document Type");
                dgvRequests.Columns.Add("Status", "Status");
                dgvRequests.Columns.Add("Date", "Date Submitted");
            }

            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequests.AllowUserToAddRows = false;

            dtpExpiryDate.MinDate = DateTime.Now.Date;

            LoadRequests();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser == null)
            {
                MessageBox.Show("Please log in to submit a verification request.");
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

            // Now submits through the SAME VerificationManager the Admin
            // Dashboard reads from - this request will show up in the
            // admin's Active Submissions grid immediately.
            // Note: Document Number and Expiry Date aren't stored on
            // TrustID.Models.VerificationRequest yet - only DocumentType
            // and Priority are tracked. Add fields there later if the
            // admin side needs to see them too.
            try
            {
                using OpenFileDialog dialog = new OpenFileDialog();

                dialog.Title = "Select Identity Document";
                dialog.Filter =
                    "Supported Documents|*.pdf;*.jpg;*.jpeg;*.png;*.bmp|" +
                    "PDF Files|*.pdf|" +
                    "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                dialog.Multiselect = false;

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                string folder = Path.Combine(
                    Application.StartupPath,
                    "verification_documents"
                );

                Directory.CreateDirectory(folder);

                string extension = Path.GetExtension(dialog.FileName);

                string uniqueFileName =
                    $"{Program.CurrentUser!.UserId}_{Guid.NewGuid():N}{extension}";

                string destinationPath = Path.Combine(
                    folder,
                    uniqueFileName
                );

                File.Copy(
                    dialog.FileName,
                    destinationPath,
                    false
                );

                Program.SharedVerificationManager.SubmitRequest(
                    Program.CurrentUser,
                    cmbIDType.Text,
                    destinationPath,
                    RequestPriority.Medium
                );

                Program.SharedUserManager.SaveChanges();

                MessageBox.Show(
                    $"{cmbIDType.Text} submitted for verification!",
                    "Document Submitted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtDocumentNumber.Clear();

                LoadRequests();
            }
            catch (TrustID.Exceptions.ValidationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Verification Submission",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Could Not Save Document",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void LoadRequests()
        {
            dgvRequests.Rows.Clear();
            if (Program.CurrentUser == null) return;

            var myRequests = Program.SharedVerificationManager.Requests
                .Where(r => r.Applicant.UserId == Program.CurrentUser.UserId);

            foreach (var request in myRequests)
            {
                dgvRequests.Rows.Add(
                    request.RequestId,
                    request.DocumentType,
                    request.Status.ToString(),
                    request.SubmittedDate.ToString("yyyy-MM-dd"));
            }
        }
        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
