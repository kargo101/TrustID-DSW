namespace user_dashboard
{
    public partial class UcQualifications : UserControl
    {
        private string selectedDocumentPath = "";
        public UcQualifications()
        {
            InitializeComponent();
            PremiumFormDesign.Apply(this, "Qualifications");
            this.Load += UcQualifications_Load;
        }

        private void UcQualifications_Load(object sender, EventArgs e)
        {
            SetUpDataGridView();
            LoadQualifications();
        }

        void SetUpDataGridView()
        {
            dgvQualifications.Columns.Clear();

            dgvQualifications.Columns.Add(
                "QualName",
                "Qualification");

            dgvQualifications.Columns.Add(
                "InstitutionName",
                "Institution");

            dgvQualifications.Columns.Add(
                "Year",
                "Year");

            dgvQualifications.Columns.Add(
                "Document",
                "Document");

            dgvQualifications.Columns.Add(
                "Status",
                "Status");

            dgvQualifications.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
        void LoadQualifications()
        {
            try
            {
                dgvQualifications.Rows.Clear();

                string path = Path.Combine(
                    Application.StartupPath,
                    "qualifications.txt");

                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                    return;
                }

                var lines = File.ReadAllLines(path);

                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var parts = line.Split(',');

                    // Old qualification record
                    if (parts.Length >= 6)
                    {
                        string email = parts[1];

                        if (Program.CurrentUser != null &&
                            email.Equals(
                                Program.CurrentUser.Email,
                                StringComparison.OrdinalIgnoreCase))
                        {
                            string qualification = parts[3];
                            string institution = parts[4];
                            string year = parts[5];

                            // New records contain document + status.
                            string document = "";
                            string status = "Pending";

                            if (parts.Length >= 7)
                                document = parts[6];

                            if (parts.Length >= 8 &&
                                !string.IsNullOrWhiteSpace(parts[7]))
                            {
                                status = parts[7];
                            }

                            string documentName = "Not uploaded";

                            if (!string.IsNullOrWhiteSpace(document))
                            {
                                documentName =
                                    Path.GetFileName(document);
                            }

                            dgvQualifications.Rows.Add(
                                qualification,
                                institution,
                                year,
                                documentName,
                                status);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading qualifications: " +
                    ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedDocumentPath))
            {
                MessageBox.Show("Please choose a qualification document.");
                return;
            }

            string documentsFolder = Path.Combine(
                Application.StartupPath,
                "verification documents");

            if (!Directory.Exists(documentsFolder))
                Directory.CreateDirectory(documentsFolder);

            string extension = Path.GetExtension(selectedDocumentPath);

            string fileName =
                "Qualification_" +
                Program.CurrentUser.UserId +
                "_" +
                DateTime.Now.ToString("yyyyMMddHHmmss") +
                extension;

            string savedDocumentPath = Path.Combine(
                documentsFolder,
                fileName);

            File.Copy(
                selectedDocumentPath,
                savedDocumentPath,
                true);

            Qualifications qualifications = new Qualifications(
                Program.CurrentUser.FullName,
                Program.CurrentUser.Email,
                "",
                txtQualification.Text,
                txtInstituition.Text,
                txtYearObtained.Text,
                savedDocumentPath);

            dgvQualifications.Rows.Add(
             qualifications.QualificationName,
             qualifications.InstitutionName,
             qualifications.Year,
             Path.GetFileName(qualifications.DocumentPath),
             qualifications.Status);
            SaveToTxTFile(qualifications);
            selectedDocumentPath = "";
            lblSelectedDocument.Text = "No document selected";

            MessageBox.Show("Qualification uploaded successfully.");
        }

        private void SaveToTxTFile(Qualifications qualifications)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "qualifications.txt");
                if (!File.Exists(path)) File.Create(path).Close();

                // NOTE: original code called qualifications.ToString() here,
                // which does NOT call ToFileString() - that was a bug in the
                // original that would've saved garbage. Fixed to actually
                // call ToFileString().
                File.AppendAllText(path, qualifications.ToFileString() + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex.Message);
            }
        }

        private void btnChooseDocument_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Select Qualification Document";
                dialog.Filter =
                    "Documents (*.pdf;*.jpg;*.jpeg;*.png)|*.pdf;*.jpg;*.jpeg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedDocumentPath = dialog.FileName;

                    lblSelectedDocument.Text =
                        Path.GetFileName(selectedDocumentPath);
                }
            }
        }

        private void btnRemoveRecord_Click(object sender, EventArgs e)
        {
            if (dgvQualifications.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a qualification record to remove.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DataGridViewRow selectedRow =
                dgvQualifications.SelectedRows[0];

            string qualification =
                selectedRow.Cells["QualName"].Value?.ToString() ?? "";

            string institution =
                selectedRow.Cells["InstitutionName"].Value?.ToString() ?? "";

            string year =
                selectedRow.Cells["Year"].Value?.ToString() ?? "";

            string status =
                selectedRow.Cells["Status"].Value?.ToString() ?? "";

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this qualification record?",
                "Remove Qualification",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                string path = Path.Combine(
                    Application.StartupPath,
                    "qualifications.txt");

                if (!File.Exists(path))
                {
                    MessageBox.Show(
                        "Qualification file could not be found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                string[] lines = File.ReadAllLines(path);

                bool removed = false;

                var updatedLines = new System.Collections.Generic.List<string>();

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] parts = line.Split(',');

                    if (parts.Length >= 6)
                    {
                        string email = parts[1];
                        string fileQualification = parts[3];
                        string fileInstitution = parts[4];
                        string fileYear = parts[5];

                        if (!removed &&
                            Program.CurrentUser != null &&
                            email.Equals(
                                Program.CurrentUser.Email,
                                StringComparison.OrdinalIgnoreCase) &&
                            fileQualification == qualification &&
                            fileInstitution == institution &&
                            fileYear == year)
                        {
                            removed = true;
                            continue;
                        }
                    }

                    updatedLines.Add(line);
                }

                if (!removed)
                {
                    MessageBox.Show(
                        "The selected qualification record could not be found.",
                        "Record Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                File.WriteAllLines(path, updatedLines);

                LoadQualifications();

                MessageBox.Show(
                    "Qualification record removed successfully.",
                    "Record Removed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error removing qualification: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
