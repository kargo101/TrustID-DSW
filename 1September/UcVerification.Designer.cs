namespace _1September
{
    partial class UcVerification
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLoggedUser = new Label();
            lblDocument = new Label();
            btnUploadDocument = new Button();
            dgvRequests = new DataGridView();
            pnlDocs = new Panel();
            dtpExpiryDate = new DateTimePicker();
            lblExpiryDate = new Label();
            cmbIDType = new ComboBox();
            txtDocumentNumber = new TextBox();
            lblDocumentNumber = new Label();
            pnlHeader = new Panel();
            lblVerifcationRequest = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            pnlDocs.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblLoggedUser
            // 
            lblLoggedUser.AutoSize = true;
            lblLoggedUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoggedUser.Location = new Point(13, 60);
            lblLoggedUser.Name = "lblLoggedUser";
            lblLoggedUser.Size = new Size(0, 38);
            lblLoggedUser.TabIndex = 0;
            // 
            // lblDocument
            // 
            lblDocument.AutoSize = true;
            lblDocument.Location = new Point(3, 0);
            lblDocument.Name = "lblDocument";
            lblDocument.Size = new Size(159, 25);
            lblDocument.TabIndex = 3;
            lblDocument.Text = "Type of Document";
            // 
            // btnUploadDocument
            // 
            btnUploadDocument.Location = new Point(38, 238);
            btnUploadDocument.Name = "btnUploadDocument";
            btnUploadDocument.Size = new Size(241, 34);
            btnUploadDocument.TabIndex = 8;
            btnUploadDocument.Text = "Upload Document";
            btnUploadDocument.UseVisualStyleBackColor = true;
            btnUploadDocument.Click += btnSubmit_Click;
            // 
            // dgvRequests
            // 
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new Point(397, 120);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.RowHeadersWidth = 62;
            dgvRequests.Size = new Size(618, 383);
            dgvRequests.TabIndex = 13;
            dgvRequests.CellContentClick += dgvRequests_CellContentClick;
            // 
            // pnlDocs
            // 
            pnlDocs.Controls.Add(dtpExpiryDate);
            pnlDocs.Controls.Add(lblExpiryDate);
            pnlDocs.Controls.Add(cmbIDType);
            pnlDocs.Controls.Add(txtDocumentNumber);
            pnlDocs.Controls.Add(lblDocumentNumber);
            pnlDocs.Controls.Add(btnUploadDocument);
            pnlDocs.Controls.Add(lblDocument);
            pnlDocs.Location = new Point(3, 111);
            pnlDocs.Name = "pnlDocs";
            pnlDocs.Size = new Size(358, 383);
            pnlDocs.TabIndex = 14;
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.Location = new Point(3, 182);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(300, 31);
            dtpExpiryDate.TabIndex = 13;
            // 
            // lblExpiryDate
            // 
            lblExpiryDate.AutoSize = true;
            lblExpiryDate.Location = new Point(10, 154);
            lblExpiryDate.Name = "lblExpiryDate";
            lblExpiryDate.Size = new Size(101, 25);
            lblExpiryDate.TabIndex = 12;
            lblExpiryDate.Text = "Expiry Date";
            // 
            // cmbIDType
            // 
            cmbIDType.FormattingEnabled = true;
            cmbIDType.Location = new Point(10, 28);
            cmbIDType.Name = "cmbIDType";
            cmbIDType.Size = new Size(275, 33);
            cmbIDType.TabIndex = 11;
            // 
            // txtDocumentNumber
            // 
            txtDocumentNumber.Location = new Point(3, 101);
            txtDocumentNumber.Name = "txtDocumentNumber";
            txtDocumentNumber.Size = new Size(282, 31);
            txtDocumentNumber.TabIndex = 10;
            // 
            // lblDocumentNumber
            // 
            lblDocumentNumber.AutoSize = true;
            lblDocumentNumber.Location = new Point(10, 73);
            lblDocumentNumber.Name = "lblDocumentNumber";
            lblDocumentNumber.Size = new Size(165, 25);
            lblDocumentNumber.TabIndex = 8;
            lblDocumentNumber.Text = "Document Number";
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblVerifcationRequest);
            pnlHeader.Controls.Add(lblLoggedUser);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1086, 105);
            pnlHeader.TabIndex = 16;
            // 
            // lblVerifcationRequest
            // 
            lblVerifcationRequest.AutoSize = true;
            lblVerifcationRequest.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVerifcationRequest.Location = new Point(3, 0);
            lblVerifcationRequest.Name = "lblVerifcationRequest";
            lblVerifcationRequest.Size = new Size(319, 45);
            lblVerifcationRequest.TabIndex = 9;
            lblVerifcationRequest.Text = "Verification Request";
            // 
            // UcVerification
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlHeader);
            Controls.Add(pnlDocs);
            Controls.Add(dgvRequests);
            Name = "UcVerification";
            Size = new Size(1086, 567);
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            pnlDocs.ResumeLayout(false);
            pnlDocs.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblLoggedUser;
        private TextBox txtQualification;
        private Label lblDocument;
        private Label lblInstituition;
        private Button btnUploadDocument;
        private DataGridView dgvRequests;
        private Panel pnlDocs;
        private Label lblDocumentNumber;
        private Panel pnlHeader;
        private Label lblVerifcationRequest;
        private TextBox txtInstituition;
        private TextBox txtDocumentNumber;
        private ComboBox cmbIDType;
        private DateTimePicker dtpExpiryDate;
        private Label lblExpiryDate;
    }
}
