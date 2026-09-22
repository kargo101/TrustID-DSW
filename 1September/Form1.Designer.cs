namespace _1September
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblPassword = new Label();
            txtName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lnkCreateAnAccount = new LinkLabel();
            lblSurname = new Label();
            txtSurname = new TextBox();
            lnkChangePassword = new LinkLabel();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 6);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 130);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(459, 31);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 158);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(459, 31);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(131, 209);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(191, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkCreateAnAccount
            // 
            lnkCreateAnAccount.AutoSize = true;
            lnkCreateAnAccount.Location = new Point(23, 280);
            lnkCreateAnAccount.Name = "lnkCreateAnAccount";
            lnkCreateAnAccount.Size = new Size(156, 25);
            lnkCreateAnAccount.TabIndex = 5;
            lnkCreateAnAccount.TabStop = true;
            lnkCreateAnAccount.Text = "Create an Account";
            lnkCreateAnAccount.LinkClicked += lnkCreateAnAccount_LinkClicked;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(12, 68);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(82, 25);
            lblSurname.TabIndex = 6;
            lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(12, 96);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(459, 31);
            txtSurname.TabIndex = 7;
            // 
            // lnkChangePassword
            // 
            lnkChangePassword.AutoSize = true;
            lnkChangePassword.Location = new Point(251, 280);
            lnkChangePassword.Name = "lnkChangePassword";
            lnkChangePassword.Size = new Size(152, 25);
            lnkChangePassword.TabIndex = 8;
            lnkChangePassword.TabStop = true;
            lnkChangePassword.Text = "Change Password";
            lnkChangePassword.LinkClicked += lnkChangePassword_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 491);
            Controls.Add(lnkChangePassword);
            Controls.Add(txtSurname);
            Controls.Add(lblSurname);
            Controls.Add(lnkCreateAnAccount);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(lblPassword);
            Controls.Add(lblName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblPassword;
        private TextBox txtName;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel lnkCreateAnAccount;
        private Label lblSurname;
        private TextBox txtSurname;
        private LinkLabel lnkChangePassword;
    }
}
