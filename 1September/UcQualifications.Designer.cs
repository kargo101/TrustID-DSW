namespace _1September
{
    partial class UcQualifications
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
            grbAddQualifications = new GroupBox();
            txtYearObtained = new TextBox();
            lblYearObtained = new Label();
            txtInstituition = new TextBox();
            lblInstituition = new Label();
            btnUpload = new Button();
            txtQualification = new TextBox();
            lblQualification = new Label();
            dgvQualifications = new DataGridView();
            grbAddQualifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQualifications).BeginInit();
            SuspendLayout();
            // 
            // grbAddQualifications
            // 
            grbAddQualifications.Controls.Add(txtYearObtained);
            grbAddQualifications.Controls.Add(lblYearObtained);
            grbAddQualifications.Controls.Add(txtInstituition);
            grbAddQualifications.Controls.Add(lblInstituition);
            grbAddQualifications.Controls.Add(btnUpload);
            grbAddQualifications.Controls.Add(txtQualification);
            grbAddQualifications.Controls.Add(lblQualification);
            grbAddQualifications.Location = new Point(3, 3);
            grbAddQualifications.Name = "grbAddQualifications";
            grbAddQualifications.Size = new Size(408, 356);
            grbAddQualifications.TabIndex = 0;
            grbAddQualifications.TabStop = false;
            grbAddQualifications.Text = "Add Qualifications";
            // 
            // txtYearObtained
            // 
            txtYearObtained.Location = new Point(6, 233);
            txtYearObtained.Name = "txtYearObtained";
            txtYearObtained.Size = new Size(275, 31);
            txtYearObtained.TabIndex = 6;
            // 
            // lblYearObtained
            // 
            lblYearObtained.AutoSize = true;
            lblYearObtained.Location = new Point(6, 193);
            lblYearObtained.Name = "lblYearObtained";
            lblYearObtained.Size = new Size(123, 25);
            lblYearObtained.TabIndex = 5;
            lblYearObtained.Text = "Year Obtained";
            // 
            // txtInstituition
            // 
            txtInstituition.Location = new Point(6, 148);
            txtInstituition.Name = "txtInstituition";
            txtInstituition.Size = new Size(275, 31);
            txtInstituition.TabIndex = 4;
            // 
            // lblInstituition
            // 
            lblInstituition.AutoSize = true;
            lblInstituition.Location = new Point(6, 101);
            lblInstituition.Name = "lblInstituition";
            lblInstituition.Size = new Size(141, 25);
            lblInstituition.TabIndex = 3;
            lblInstituition.Text = "Enter Instituition";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(91, 292);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(216, 34);
            btnUpload.TabIndex = 2;
            btnUpload.Text = "Upload Qualifications";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // txtQualification
            // 
            txtQualification.Location = new Point(6, 55);
            txtQualification.Name = "txtQualification";
            txtQualification.Size = new Size(275, 31);
            txtQualification.TabIndex = 1;
            // 
            // lblQualification
            // 
            lblQualification.AutoSize = true;
            lblQualification.Location = new Point(6, 27);
            lblQualification.Name = "lblQualification";
            lblQualification.Size = new Size(156, 25);
            lblQualification.TabIndex = 0;
            lblQualification.Text = "Enter Qualification";
            // 
            // dgvQualifications
            // 
            dgvQualifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQualifications.Location = new Point(440, 18);
            dgvQualifications.Name = "dgvQualifications";
            dgvQualifications.RowHeadersWidth = 62;
            dgvQualifications.Size = new Size(557, 341);
            dgvQualifications.TabIndex = 1;
            // 
            // UcQualifications
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvQualifications);
            Controls.Add(grbAddQualifications);
            Name = "UcQualifications";
            Size = new Size(1137, 514);
            grbAddQualifications.ResumeLayout(false);
            grbAddQualifications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQualifications).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbAddQualifications;
        private Button btnUpload;
        private TextBox txtQualification;
        private Label lblQualification;
        private TextBox txtYearObtained;
        private Label lblYearObtained;
        private TextBox txtInstituition;
        private Label lblInstituition;
        private DataGridView dgvQualifications;
    }
}
