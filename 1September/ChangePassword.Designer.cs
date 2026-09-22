namespace _1September
{
    partial class ChangePassword
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
            btnChangePassword = new Button();
            lblSecondName = new Label();
            lblNewPassword = new Label();
            lblConfirmPassword = new Label();
            txtSecondName = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(1, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(1, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 31);
            txtName.TabIndex = 1;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(21, 282);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(206, 34);
            btnChangePassword.TabIndex = 2;
            btnChangePassword.Text = "CHANGE PASSWORD ";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // lblSecondName
            // 
            lblSecondName.AutoSize = true;
            lblSecondName.Location = new Point(1, 62);
            lblSecondName.Name = "lblSecondName";
            lblSecondName.Size = new Size(123, 25);
            lblSecondName.TabIndex = 3;
            lblSecondName.Text = "Second Name";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(1, 125);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(127, 25);
            lblNewPassword.TabIndex = 4;
            lblNewPassword.Text = "New Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(1, 181);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(156, 25);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(1, 91);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(262, 31);
            txtSecondName.TabIndex = 6;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(1, 147);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(262, 31);
            txtNewPassword.TabIndex = 7;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(1, 209);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(262, 31);
            txtConfirmPassword.TabIndex = 8;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtSecondName);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(lblSecondName);
            Controls.Add(btnChangePassword);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "ChangePassword";
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Button btnChangePassword;
        private Label lblSecondName;
        private Label lblNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtSecondName;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
    }
}