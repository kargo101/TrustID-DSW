namespace user_dashboard
{
    partial class UcVerification
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
            lblSubmitTitle = new Label();
            lblIDType = new Label();
            cmbIDType = new ComboBox();
            lblDocNumber = new Label();
            txtDocumentNumber = new TextBox();
            lblExpiry = new Label();
            dtpExpiryDate = new DateTimePicker();
            btnSubmit = new Button();
            lblRequestsTitle = new Label();
            dgvRequests = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            SuspendLayout();
            // 
            // lblSubmitTitle
            // 
            lblSubmitTitle.AutoSize = true;
            lblSubmitTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblSubmitTitle.ForeColor = Color.White;
            lblSubmitTitle.Location = new Point(24, 0);
            lblSubmitTitle.Name = "lblSubmitTitle";
            lblSubmitTitle.Size = new Size(227, 19);
            lblSubmitTitle.TabIndex = 0;
            lblSubmitTitle.Text = "Submit New Verification Request";
            // 
            // lblIDType
            // 
            lblIDType.AutoSize = true;
            lblIDType.ForeColor = Color.FromArgb(140, 140, 150);
            lblIDType.Location = new Point(24, 34);
            lblIDType.Name = "lblIDType";
            lblIDType.Size = new Size(91, 15);
            lblIDType.TabIndex = 1;
            lblIDType.Text = "Document Type";
            // 
            // cmbIDType
            // 
            cmbIDType.BackColor = Color.FromArgb(38, 42, 61);
            cmbIDType.ForeColor = Color.White;
            cmbIDType.Location = new Point(24, 52);
            cmbIDType.Name = "cmbIDType";
            cmbIDType.Size = new Size(250, 23);
            cmbIDType.TabIndex = 2;
            // 
            // lblDocNumber
            // 
            lblDocNumber.AutoSize = true;
            lblDocNumber.ForeColor = Color.FromArgb(140, 140, 150);
            lblDocNumber.Location = new Point(311, 34);
            lblDocNumber.Name = "lblDocNumber";
            lblDocNumber.Size = new Size(110, 15);
            lblDocNumber.TabIndex = 3;
            lblDocNumber.Text = "Document Number";
            // 
            // txtDocumentNumber
            // 
            txtDocumentNumber.BackColor = Color.FromArgb(38, 42, 61);
            txtDocumentNumber.ForeColor = Color.White;
            txtDocumentNumber.Location = new Point(311, 52);
            txtDocumentNumber.Name = "txtDocumentNumber";
            txtDocumentNumber.Size = new Size(200, 23);
            txtDocumentNumber.TabIndex = 4;
            // 
            // lblExpiry
            // 
            lblExpiry.AutoSize = true;
            lblExpiry.ForeColor = Color.FromArgb(140, 140, 150);
            lblExpiry.Location = new Point(534, 34);
            lblExpiry.Name = "lblExpiry";
            lblExpiry.Size = new Size(65, 15);
            lblExpiry.TabIndex = 5;
            lblExpiry.Text = "Expiry Date";
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.Format = DateTimePickerFormat.Short;
            dtpExpiryDate.Location = new Point(534, 52);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(150, 23);
            dtpExpiryDate.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 220, 210);
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.ForeColor = Color.FromArgb(15, 18, 32);
            btnSubmit.Location = new Point(34, 99);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(120, 30);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblRequestsTitle
            // 
            lblRequestsTitle.AutoSize = true;
            lblRequestsTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblRequestsTitle.ForeColor = Color.White;
            lblRequestsTitle.Location = new Point(34, 145);
            lblRequestsTitle.Name = "lblRequestsTitle";
            lblRequestsTitle.Size = new Size(173, 19);
            lblRequestsTitle.TabIndex = 8;
            lblRequestsTitle.Text = "My Verification Requests";
            // 
            // dgvRequests
            // 
            dgvRequests.BackgroundColor = Color.FromArgb(26, 30, 46);
            dgvRequests.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(38, 42, 61);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 30, 46);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRequests.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRequests.EnableHeadersVisualStyles = false;
            dgvRequests.Location = new Point(34, 181);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.ReadOnly = true;
            dgvRequests.RowHeadersVisible = false;
            dgvRequests.Size = new Size(650, 300);
            dgvRequests.TabIndex = 9;
            dgvRequests.CellContentClick += dgvRequests_CellContentClick;
            // 
            // UcVerification
            // 
            BackColor = Color.FromArgb(15, 18, 32);
            Controls.Add(lblSubmitTitle);
            Controls.Add(lblIDType);
            Controls.Add(cmbIDType);
            Controls.Add(lblDocNumber);
            Controls.Add(txtDocumentNumber);
            Controls.Add(lblExpiry);
            Controls.Add(dtpExpiryDate);
            Controls.Add(btnSubmit);
            Controls.Add(lblRequestsTitle);
            Controls.Add(dgvRequests);
            Name = "UcVerification";
            Size = new Size(748, 544);
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblSubmitTitle;
        private Label lblIDType;
        private ComboBox cmbIDType;
        private Label lblDocNumber;
        private TextBox txtDocumentNumber;
        private Label lblExpiry;
        private DateTimePicker dtpExpiryDate;
        private Button btnSubmit;
        private Label lblRequestsTitle;
        private DataGridView dgvRequests;
    }
}
