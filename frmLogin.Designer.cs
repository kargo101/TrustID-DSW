namespace user_dashboard
{
    partial class frmLogin
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            pnlLogin = new Panel();
            lnkCreateAccount = new LinkLabel();
            lblTrustIdMotto = new Label();
            errorProvider1 = new ErrorProvider(components);
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(8, 18, 24);
            txtName.BorderStyle = BorderStyle.None;
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(53, 133);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 16);
            txtName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(8, 18, 24);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(53, 186);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 16);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Cyan;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.FromArgb(8, 14, 28);
            btnLogin.Location = new Point(53, 227);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 26);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUsername
            // 
            lblUsername.ForeColor = Color.FromArgb(140, 140, 150);
            lblUsername.Location = new Point(53, 113);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 17);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.ForeColor = Color.FromArgb(140, 140, 150);
            lblPassword.Location = new Point(53, 164);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 19);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.FromArgb(17, 24, 39);
            pnlLogin.Controls.Add(lnkCreateAccount);
            pnlLogin.Controls.Add(lblTrustIdMotto);
            pnlLogin.Controls.Add(txtName);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(lblUsername);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Location = new Point(264, 118);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(364, 346);
            pnlLogin.TabIndex = 5;
            // 
            // lnkCreateAccount
            // 
            lnkCreateAccount.AutoSize = true;
            lnkCreateAccount.Location = new Point(214, 238);
            lnkCreateAccount.Name = "lnkCreateAccount";
            lnkCreateAccount.Size = new Size(89, 15);
            lnkCreateAccount.TabIndex = 6;
            lnkCreateAccount.TabStop = true;
            lnkCreateAccount.Text = "Create Account";
            lnkCreateAccount.LinkClicked += lnkCreateAccount_LinkClicked_2;
            // 
            // lblTrustIdMotto
            // 
            lblTrustIdMotto.AutoSize = true;
            lblTrustIdMotto.ForeColor = Color.FromArgb(140, 140, 150);
            lblTrustIdMotto.Location = new Point(75, 71);
            lblTrustIdMotto.Name = "lblTrustIdMotto";
            lblTrustIdMotto.Size = new Size(209, 15);
            lblTrustIdMotto.TabIndex = 5;
            lblTrustIdMotto.Text = "Reputation and Identity Registry Login";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmLogin
            // 
            BackColor = Color.FromArgb(8, 14, 28);
            ClientSize = new Size(882, 569);
            Controls.Add(pnlLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "TrustID Login";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        private TextBox txtName;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblUsername;
        private Label lblPassword;
        private Panel pnlLogin;
        private ErrorProvider errorProvider1;
        private Label lblTrustIdMotto;
        private LinkLabel lnkCreateAccount;
    }
}

       
       
