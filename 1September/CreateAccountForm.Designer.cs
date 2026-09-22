namespace _1September
{
    partial class CreateAccountForm
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
            lblName = new Label();
            txtName = new TextBox();
            lblSecondName = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            lblCellNumber = new Label();
            lblEmail = new Label();
            txtSecondName = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtCellNumber = new TextBox();
            txtEmail = new TextBox();
            btnCreateAccount = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(2, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(2, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(280, 31);
            txtName.TabIndex = 1;
            // 
            // lblSecondName
            // 
            lblSecondName.AutoSize = true;
            lblSecondName.Location = new Point(2, 71);
            lblSecondName.Name = "lblSecondName";
            lblSecondName.Size = new Size(123, 25);
            lblSecondName.TabIndex = 2;
            lblSecondName.Text = "Second Name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(2, 136);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(2, 208);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(156, 25);
            lblConfirmPassword.TabIndex = 4;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblCellNumber
            // 
            lblCellNumber.AutoSize = true;
            lblCellNumber.Location = new Point(2, 277);
            lblCellNumber.Name = "lblCellNumber";
            lblCellNumber.Size = new Size(110, 25);
            lblCellNumber.TabIndex = 5;
            lblCellNumber.Text = "Cell Number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(2, 340);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(2, 99);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(280, 31);
            txtSecondName.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(2, 174);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(280, 31);
            txtPassword.TabIndex = 8;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(2, 243);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(280, 31);
            txtConfirmPassword.TabIndex = 9;
            // 
            // txtCellNumber
            // 
            txtCellNumber.Location = new Point(2, 306);
            txtCellNumber.Name = "txtCellNumber";
            txtCellNumber.Size = new Size(280, 31);
            txtCellNumber.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(2, 368);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 31);
            txtEmail.TabIndex = 11;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(351, 438);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(197, 34);
            btnCreateAccount.TabIndex = 12;
            btnCreateAccount.Text = "CreateAccount";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 516);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtEmail);
            Controls.Add(txtCellNumber);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtSecondName);
            Controls.Add(lblEmail);
            Controls.Add(lblCellNumber);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblSecondName);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "CreateAccountForm";
            Text = "CreateAccountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblSecondName;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblCellNumber;
        private Label lblEmail;
        private TextBox txtSecondName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtCellNumber;
        private TextBox txtEmail;
        private Button btnCreateAccount;
    }
}