namespace user_dashboard
{
    partial class UcQualifications
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblAddTitle = new Label();
            lblQualification = new Label();
            txtQualification = new TextBox();
            lblInstitution = new Label();
            txtInstituition = new TextBox();
            lblYear = new Label();
            txtYearObtained = new TextBox();
            btnUpload = new Button();
            lblListTitle = new Label();
            dgvQualifications = new DataGridView();
            btnChooseDocument = new Button();
            lblSelectedDocument = new Label();
            btnRemoveRecord = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQualifications).BeginInit();
            SuspendLayout();
            // 
            // lblAddTitle
            // 
            lblAddTitle.AutoSize = true;
            lblAddTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblAddTitle.ForeColor = Color.White;
            lblAddTitle.Location = new Point(18, 0);
            lblAddTitle.Name = "lblAddTitle";
            lblAddTitle.Size = new Size(138, 19);
            lblAddTitle.TabIndex = 0;
            lblAddTitle.Text = "Add a Qualification";
            // 
            // lblQualification
            // 
            lblQualification.AutoSize = true;
            lblQualification.ForeColor = Color.FromArgb(140, 140, 150);
            lblQualification.Location = new Point(18, 34);
            lblQualification.Name = "lblQualification";
            lblQualification.Size = new Size(110, 15);
            lblQualification.TabIndex = 1;
            lblQualification.Text = "Qualification Name";
            // 
            // txtQualification
            // 
            txtQualification.BackColor = Color.FromArgb(38, 42, 61);
            txtQualification.ForeColor = Color.White;
            txtQualification.Location = new Point(18, 52);
            txtQualification.Name = "txtQualification";
            txtQualification.Size = new Size(259, 23);
            txtQualification.TabIndex = 2;
            // 
            // lblInstitution
            // 
            lblInstitution.AutoSize = true;
            lblInstitution.ForeColor = Color.FromArgb(140, 140, 150);
            lblInstitution.Location = new Point(315, 34);
            lblInstitution.Name = "lblInstitution";
            lblInstitution.Size = new Size(61, 15);
            lblInstitution.TabIndex = 3;
            lblInstitution.Text = "Institution";
            // 
            // txtInstituition
            // 
            txtInstituition.BackColor = Color.FromArgb(38, 42, 61);
            txtInstituition.ForeColor = Color.White;
            txtInstituition.Location = new Point(315, 52);
            txtInstituition.Name = "txtInstituition";
            txtInstituition.Size = new Size(220, 23);
            txtInstituition.TabIndex = 4;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.ForeColor = Color.FromArgb(140, 140, 150);
            lblYear.Location = new Point(571, 34);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(81, 15);
            lblYear.TabIndex = 5;
            lblYear.Text = "Year Obtained";
            // 
            // txtYearObtained
            // 
            txtYearObtained.BackColor = Color.FromArgb(38, 42, 61);
            txtYearObtained.ForeColor = Color.White;
            txtYearObtained.Location = new Point(571, 52);
            txtYearObtained.Name = "txtYearObtained";
            txtYearObtained.Size = new Size(100, 23);
            txtYearObtained.TabIndex = 6;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.FromArgb(0, 220, 210);
            btnUpload.FlatAppearance.BorderSize = 0;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.ForeColor = Color.FromArgb(15, 18, 32);
            btnUpload.Location = new Point(157, 92);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(120, 30);
            btnUpload.TabIndex = 7;
            btnUpload.Text = "Add";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblListTitle.ForeColor = Color.White;
            lblListTitle.Location = new Point(21, 139);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(125, 19);
            lblListTitle.TabIndex = 8;
            lblListTitle.Text = "My Qualifications";
            // 
            // dgvQualifications
            // 
            dgvQualifications.BackgroundColor = Color.FromArgb(26, 30, 46);
            dgvQualifications.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(38, 42, 61);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvQualifications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 30, 46);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvQualifications.DefaultCellStyle = dataGridViewCellStyle2;
            dgvQualifications.EnableHeadersVisualStyles = false;
            dgvQualifications.Location = new Point(21, 172);
            dgvQualifications.Name = "dgvQualifications";
            dgvQualifications.ReadOnly = true;
            dgvQualifications.RowHeadersVisible = false;
            dgvQualifications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQualifications.Size = new Size(650, 300);
            dgvQualifications.TabIndex = 9;
            // 
            // btnChooseDocument
            // 
            btnChooseDocument.BackColor = Color.FromArgb(0, 220, 210);
            btnChooseDocument.FlatAppearance.BorderSize = 0;
            btnChooseDocument.FlatStyle = FlatStyle.Flat;
            btnChooseDocument.ForeColor = Color.FromArgb(15, 18, 32);
            btnChooseDocument.Location = new Point(18, 92);
            btnChooseDocument.Name = "btnChooseDocument";
            btnChooseDocument.Size = new Size(120, 30);
            btnChooseDocument.TabIndex = 10;
            btnChooseDocument.Text = "Choose Document";
            btnChooseDocument.UseVisualStyleBackColor = false;
            btnChooseDocument.Click += btnChooseDocument_Click;
            // 
            // lblSelectedDocument
            // 
            lblSelectedDocument.AutoSize = true;
            lblSelectedDocument.ForeColor = Color.FromArgb(140, 140, 150);
            lblSelectedDocument.Location = new Point(544, 107);
            lblSelectedDocument.Name = "lblSelectedDocument";
            lblSelectedDocument.Size = new Size(127, 15);
            lblSelectedDocument.TabIndex = 11;
            lblSelectedDocument.Text = "No document selected";
            // 
            // btnRemoveRecord
            // 
            btnRemoveRecord.BackColor = Color.FromArgb(26, 30, 46);
            btnRemoveRecord.FlatAppearance.BorderSize = 0;
            btnRemoveRecord.FlatStyle = FlatStyle.Flat;
            btnRemoveRecord.ForeColor = Color.Cyan;
            btnRemoveRecord.Location = new Point(315, 92);
            btnRemoveRecord.Name = "btnRemoveRecord";
            btnRemoveRecord.Size = new Size(120, 30);
            btnRemoveRecord.TabIndex = 12;
            btnRemoveRecord.Text = "Remove Record";
            btnRemoveRecord.UseVisualStyleBackColor = false;
            btnRemoveRecord.Click += btnRemoveRecord_Click;
            // 
            // UcQualifications
            // 
            BackColor = Color.FromArgb(15, 18, 32);
            Controls.Add(btnRemoveRecord);
            Controls.Add(lblSelectedDocument);
            Controls.Add(btnChooseDocument);
            Controls.Add(lblAddTitle);
            Controls.Add(lblQualification);
            Controls.Add(txtQualification);
            Controls.Add(lblInstitution);
            Controls.Add(txtInstituition);
            Controls.Add(lblYear);
            Controls.Add(txtYearObtained);
            Controls.Add(btnUpload);
            Controls.Add(lblListTitle);
            Controls.Add(dgvQualifications);
            Name = "UcQualifications";
            Size = new Size(720, 500);
            ((System.ComponentModel.ISupportInitialize)dgvQualifications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblAddTitle;
        private Label lblQualification;
        private TextBox txtQualification;
        private Label lblInstitution;
        private TextBox txtInstituition;
        private Label lblYear;
        private TextBox txtYearObtained;
        private Button btnUpload;
        private Label lblListTitle;
        private DataGridView dgvQualifications;
        private Button btnChooseDocument;
        private Label lblSelectedDocument;
        private Button btnRemoveRecord;
    }
}