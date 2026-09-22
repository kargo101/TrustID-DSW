using TrustID.Models;
using TrustID.Exceptions;

namespace user_dashboard
{
    public partial class UcProfile : UserControl
    {
        private System.Windows.Forms.Button? btnChangePhoto;
        private System.Windows.Forms.Button? btnUploadDocument;
        private System.Windows.Forms.ComboBox? cmbDocumentType;

        public UcProfile()
        {
            InitializeComponent();

            SetupProfilePhoto();
            SetupDocumentUpload();

            PremiumFormDesign.Apply(this, "Profile");

            Load += UcProfile_Load;
        }

        private void UcProfile_Load(object sender, EventArgs e)
        {
            User? user = Program.CurrentUser;

            if (user == null)
                return;

            lblUserName.Text = user.Username;
            lblName.Text = user.FullName;

            lblOcupation.Text =
                (user as IndividualUser)?.Occupation ??
                user.GetUserTypeLabel();

            lblDateJoined.Text =
                $"Member since {user.JoinedDate:MMM yyyy}";

            lblBiography.Text =
                $"Verification status: {user.VerificationStatus}\n" +
                $"Account status: {user.AccountStatus}";

            lblTrustScoreNumber.Text =
                user.TrustScore.CurrentScore.ToString();

            progressBar6.Value =
                user.TrustScore.CurrentScore;

            LoadQualificationsList(user.Email);
            LoadProfilePhoto();
        }

        // =========================================================
        // QUALIFICATIONS
        // =========================================================

        private void LoadQualificationsList(string email)
        {
            lstQualifications.Items.Clear();

            string path =
                Path.Combine(
                    Application.StartupPath,
                    "qualifications.txt"
                );

            if (!File.Exists(path))
            {
                lstQualifications.Items.Add(
                    "No qualifications added yet."
                );

                return;
            }

            foreach (string line in File.ReadAllLines(path))
            {
                string[] parts = line.Split(',');

                if (parts.Length >= 6 &&
                    parts[1].Equals(
                        email,
                        StringComparison.OrdinalIgnoreCase
                    ))
                {
                    lstQualifications.Items.Add(
                        $"{parts[3]} - {parts[4]} ({parts[5]})"
                    );
                }
            }

            if (lstQualifications.Items.Count == 0)
            {
                lstQualifications.Items.Add(
                    "No qualifications added yet."
                );
            }
        }

        // =========================================================
        // PROFILE PHOTO
        // =========================================================

        private void SetupProfilePhoto()
        {
            pictureBox1.SizeMode =
                PictureBoxSizeMode.Zoom;

            btnChangePhoto =
                new System.Windows.Forms.Button();

            btnChangePhoto.Name =
                "btnChangePhoto";

            btnChangePhoto.Text =
                "Change Photo";

            btnChangePhoto.Size =
                new Size(112, 27);

            btnChangePhoto.Location =
                new Point(91, 126);

            btnChangePhoto.FlatStyle =
                FlatStyle.Flat;

            btnChangePhoto.BackColor =
                Color.FromArgb(21, 119, 235);

            btnChangePhoto.ForeColor =
                Color.White;

            btnChangePhoto.FlatAppearance.BorderSize = 0;

            btnChangePhoto.Click +=
                BtnChangePhoto_Click;

            pnlGeneral.Controls.Add(
                btnChangePhoto
            );

            lblName.Location =
                new Point(20, 165);

            lblOcupation.Location =
                new Point(20, 190);

            lblDateJoined.Location =
                new Point(20, 212);

            label4.Location =
                new Point(20, 240);

            lblBiography.Location =
                new Point(20, 263);

            lblBiography.Size =
                new Size(260, 65);
        }

        private string GetProfilePhotoPath()
        {
            if (Program.CurrentUser == null)
                return "";

            string fileName =
                Program.CurrentUser.Username
                    .Replace("@", "_")
                    .Replace(".", "_") +
                ".png";

            string folder =
                Path.Combine(
                    Application.StartupPath,
                    "profile_pictures"
                );

            Directory.CreateDirectory(folder);

            return Path.Combine(
                folder,
                fileName
            );
        }

        private void LoadProfilePhoto()
        {
            string path =
                GetProfilePhotoPath();

            if (path == "" ||
                !File.Exists(path))
                return;

            try
            {
                using Image source =
                    Image.FromFile(path);

                pictureBox1.Image?.Dispose();

                pictureBox1.Image =
                    new Bitmap(source);
            }
            catch
            {
            }
        }

        private void BtnChangePhoto_Click(
            object? sender,
            EventArgs e)
        {
            using OpenFileDialog dialog =
                new OpenFileDialog();

            dialog.Title =
                "Choose Profile Picture";

            dialog.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() !=
                DialogResult.OK)
                return;

            try
            {
                using Image source =
                    Image.FromFile(dialog.FileName);

                using Bitmap copy =
                    new Bitmap(source);

                string path =
                    GetProfilePhotoPath();

                copy.Save(
                    path,
                    System.Drawing.Imaging.ImageFormat.Png
                );

                pictureBox1.Image?.Dispose();

                pictureBox1.Image =
                    new Bitmap(copy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Could Not Save Photo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // =========================================================
        // DOCUMENT UPLOAD
        // =========================================================

        private void SetupDocumentUpload()
        {
            // Document type selector
            cmbDocumentType =
                new System.Windows.Forms.ComboBox();

            cmbDocumentType.Name =
                "cmbDocumentType";

            cmbDocumentType.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbDocumentType.Items.AddRange(
                new object[]
                {
                    "Identity Document",
                    "Qualification",
                    "Certificate",
                    "Proof of Work Experience"
                }
            );

            cmbDocumentType.SelectedIndex = 0;

            cmbDocumentType.Location =
                new Point(15, 295);

            cmbDocumentType.Size =
                new Size(180, 23);

            pnlContactVerfication.Controls.Add(
                cmbDocumentType
            );

            // Upload button
            btnUploadDocument =
                new System.Windows.Forms.Button();

            btnUploadDocument.Name =
                "btnUploadDocument";

            btnUploadDocument.Text =
                "Upload Document";

            btnUploadDocument.Size =
                new Size(130, 27);

            btnUploadDocument.Location =
                new Point(205, 293);

            btnUploadDocument.FlatStyle =
                FlatStyle.Flat;

            btnUploadDocument.BackColor =
                Color.FromArgb(21, 119, 235);

            btnUploadDocument.ForeColor =
                Color.White;

            btnUploadDocument.FlatAppearance.BorderSize =
                0;

            btnUploadDocument.Click +=
                BtnUploadDocument_Click;

            pnlContactVerfication.Controls.Add(
                btnUploadDocument
            );
        }

        private void BtnUploadDocument_Click(
            object? sender,
            EventArgs e)
        {
            User? user =
                Program.CurrentUser;

            if (user == null)
            {
                MessageBox.Show(
                    "You must be logged in to upload a document.",
                    "Upload Document",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (cmbDocumentType == null ||
                cmbDocumentType.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a document type.",
                    "Upload Document",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            using OpenFileDialog dialog =
                new OpenFileDialog();

            dialog.Title =
                "Select Document for Verification";

            dialog.Filter =
                "Supported Documents|" +
                "*.pdf;*.jpg;*.jpeg;*.png;*.bmp|" +
                "PDF Files|*.pdf|" +
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            dialog.Multiselect = false;

            if (dialog.ShowDialog() !=
                DialogResult.OK)
                return;

            try
            {
                string documentType =
                    cmbDocumentType.SelectedItem.ToString()!;

                string folder =
                    Path.Combine(
                        Application.StartupPath,
                        "verification_documents"
                    );

                Directory.CreateDirectory(folder);

                string extension =
                    Path.GetExtension(
                        dialog.FileName
                    );

                string uniqueFileName =
                    $"{user.UserId}_{Guid.NewGuid():N}{extension}";

                string destinationPath =
                    Path.Combine(
                        folder,
                        uniqueFileName
                    );

                File.Copy(
                    dialog.FileName,
                    destinationPath,
                    false
                );

                Program.SharedVerificationManager.SubmitRequest(
                    user,
                    documentType,
                    destinationPath,
                    RequestPriority.Medium
                );

                Program.SharedUserManager.SaveChanges();

                MessageBox.Show(
                    "Your document has been uploaded successfully and is now pending verification.",
                    "Upload Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                lblBiography.Text =
                    $"Verification status: {user.VerificationStatus}\n" +
                    $"Account status: {user.AccountStatus}";

                lblTrustScoreNumber.Text =
                    user.TrustScore.CurrentScore.ToString();

                progressBar6.Value =
                    user.TrustScore.CurrentScore;
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Upload Document",
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
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Upload Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}