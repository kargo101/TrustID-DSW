namespace TrustID_admin_dashboard
{
    partial class frmCreateUser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNewFullName = new Label();
            lblNewEmail = new Label();
            btnCreateSubmit = new Button();
            btnCreateCancel = new Button();
            txtNewFullName = new TextBox();
            txtNewUsername = new TextBox();
            txtNewEmail = new TextBox();
            cmbNewUserType = new ComboBox();
            lblNewUsername = new Label();
            lblNewUserType = new Label();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            SuspendLayout();
            // 
            // lblNewFullName
            // 
            lblNewFullName.AutoSize = true;
            lblNewFullName.ForeColor = Color.White;
            lblNewFullName.Location = new Point(26, 56);
            lblNewFullName.Name = "lblNewFullName";
            lblNewFullName.Size = new Size(67, 15);
            lblNewFullName.TabIndex = 0;
            lblNewFullName.Text = "Full Name: ";
            // 
            // lblNewEmail
            // 
            lblNewEmail.AutoSize = true;
            lblNewEmail.ForeColor = Color.White;
            lblNewEmail.Location = new Point(27, 99);
            lblNewEmail.Name = "lblNewEmail";
            lblNewEmail.Size = new Size(66, 15);
            lblNewEmail.TabIndex = 4;
            lblNewEmail.Text = "New Email:";
            // 
            // btnCreateSubmit
            // 
            btnCreateSubmit.BackColor = Color.FromArgb(0, 192, 0);
            btnCreateSubmit.FlatStyle = FlatStyle.Flat;
            btnCreateSubmit.Location = new Point(125, 302);
            btnCreateSubmit.Name = "btnCreateSubmit";
            btnCreateSubmit.Size = new Size(109, 23);
            btnCreateSubmit.TabIndex = 5;
            btnCreateSubmit.Text = "Create Submit";
            btnCreateSubmit.UseVisualStyleBackColor = false;
            btnCreateSubmit.Click += btnCreateSubmit_Click;
            // 
            // btnCreateCancel
            // 
            btnCreateCancel.BackColor = Color.CornflowerBlue;
            btnCreateCancel.FlatStyle = FlatStyle.Flat;
            btnCreateCancel.Location = new Point(365, 302);
            btnCreateCancel.Name = "btnCreateCancel";
            btnCreateCancel.Size = new Size(109, 23);
            btnCreateCancel.TabIndex = 6;
            btnCreateCancel.Text = "Create Cancel";
            btnCreateCancel.UseVisualStyleBackColor = false;
            // 
            // txtNewFullName
            // 
            txtNewFullName.BackColor = Color.FromArgb(17, 24, 39);
            txtNewFullName.BorderStyle = BorderStyle.None;
            txtNewFullName.ForeColor = Color.White;
            txtNewFullName.Location = new Point(124, 55);
            txtNewFullName.Name = "txtNewFullName";
            txtNewFullName.Size = new Size(349, 16);
            txtNewFullName.TabIndex = 7;
            // 
            // txtNewUsername
            // 
            txtNewUsername.BackColor = Color.FromArgb(17, 24, 39);
            txtNewUsername.BorderStyle = BorderStyle.None;
            txtNewUsername.ForeColor = Color.White;
            txtNewUsername.Location = new Point(125, 152);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(349, 16);
            txtNewUsername.TabIndex = 9;
            // 
            // txtNewEmail
            // 
            txtNewEmail.BackColor = Color.FromArgb(17, 24, 39);
            txtNewEmail.BorderStyle = BorderStyle.None;
            txtNewEmail.ForeColor = Color.White;
            txtNewEmail.Location = new Point(125, 98);
            txtNewEmail.Name = "txtNewEmail";
            txtNewEmail.Size = new Size(349, 16);
            txtNewEmail.TabIndex = 10;
            // 
            // cmbNewUserType
            // 
            cmbNewUserType.BackColor = Color.FromArgb(17, 24, 39);
            cmbNewUserType.ForeColor = Color.White;
            cmbNewUserType.FormattingEnabled = true;
            cmbNewUserType.Items.AddRange(new object[] { "Individual", "Business" });
            cmbNewUserType.Location = new Point(124, 243);
            cmbNewUserType.Name = "cmbNewUserType";
            cmbNewUserType.Size = new Size(349, 23);
            cmbNewUserType.TabIndex = 11;
            // 
            // lblNewUsername
            // 
            lblNewUsername.AutoSize = true;
            lblNewUsername.ForeColor = Color.White;
            lblNewUsername.Location = new Point(26, 152);
            lblNewUsername.Name = "lblNewUsername";
            lblNewUsername.Size = new Size(90, 15);
            lblNewUsername.TabIndex = 12;
            lblNewUsername.Text = "New Username:";
            // 
            // lblNewUserType
            // 
            lblNewUserType.AutoSize = true;
            lblNewUserType.ForeColor = Color.White;
            lblNewUserType.Location = new Point(26, 243);
            lblNewUserType.Name = "lblNewUserType";
            lblNewUserType.Size = new Size(88, 15);
            lblNewUserType.TabIndex = 13;
            lblNewUserType.Text = "New User Type:";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.ForeColor = Color.White;
            lblNewPassword.Location = new Point(27, 200);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(87, 15);
            lblNewPassword.TabIndex = 14;
            lblNewPassword.Text = "New Password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.FromArgb(17, 24, 39);
            txtNewPassword.BorderStyle = BorderStyle.None;
            txtNewPassword.ForeColor = Color.White;
            txtNewPassword.Location = new Point(125, 200);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(349, 16);
            txtNewPassword.TabIndex = 15;
            // 
            // frmCreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 28);
            ClientSize = new Size(995, 708);
            Controls.Add(txtNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(lblNewUserType);
            Controls.Add(lblNewUsername);
            Controls.Add(cmbNewUserType);
            Controls.Add(txtNewEmail);
            Controls.Add(txtNewUsername);
            Controls.Add(txtNewFullName);
            Controls.Add(btnCreateCancel);
            Controls.Add(btnCreateSubmit);
            Controls.Add(lblNewEmail);
            Controls.Add(lblNewFullName);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(170, 80);
            Name = "frmCreateUser";
            Text = "frmCreateUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNewFullName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblNewEmail;
        private Button btnCreateSubmit;
        private Button btnCreateCancel;
        private TextBox txtNewFullName;
        private TextBox textBox2;
        private TextBox txtNewUsername;
        private TextBox txtNewEmail;
        private ComboBox cmbNewUserType;
        private Label lblNewUsername;
        private Label lblNewUserType;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
    }
}