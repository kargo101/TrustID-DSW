namespace user_dashboard
{
    partial class UcSettings
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblAccountInfoTitle = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            btnSaveChanges = new Button();
            panel2 = new Panel();
            lblChangePasswordTitle = new Label();
            lblCurrentPassword = new Label();
            txtCurrentPassword = new TextBox();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblConfirmNewPassword = new Label();
            txtConfirmNewPassword = new TextBox();
            btnUpdatePassword = new Button();
            panel3 = new Panel();
            lblNotificationsTitle = new Label();
            chkEmailNotifcations = new CheckBox();
            chkPushNotifications = new CheckBox();
            chkTransactionAlerts = new CheckBox();
            chkVisibility = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 30, 46);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblAccountInfoTitle);
            panel1.Controls.Add(lblFullName);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnSaveChanges);
            panel1.Location = new Point(19, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 246);
            panel1.TabIndex = 0;
            // 
            // lblAccountInfoTitle
            // 
            lblAccountInfoTitle.AutoSize = true;
            lblAccountInfoTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAccountInfoTitle.ForeColor = Color.White;
            lblAccountInfoTitle.Location = new Point(16, 12);
            lblAccountInfoTitle.Name = "lblAccountInfoTitle";
            lblAccountInfoTitle.Size = new Size(175, 19);
            lblAccountInfoTitle.TabIndex = 0;
            lblAccountInfoTitle.Text = "Edit Account Information";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.ForeColor = Color.FromArgb(140, 140, 150);
            lblFullName.Location = new Point(16, 46);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(61, 15);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.FromArgb(38, 42, 61);
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.ForeColor = Color.White;
            txtFullName.Location = new Point(16, 64);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(300, 23);
            txtFullName.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.FromArgb(140, 140, 150);
            lblEmail.Location = new Point(16, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(81, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email Address";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(38, 42, 61);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(16, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.FromArgb(140, 140, 150);
            lblUsername.Location = new Point(16, 154);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(38, 42, 61);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(16, 172);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(300, 23);
            txtUsername.TabIndex = 6;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(0, 220, 210);
            btnSaveChanges.FlatAppearance.BorderSize = 0;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.ForeColor = Color.FromArgb(15, 18, 32);
            btnSaveChanges.Location = new Point(16, 205);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(140, 30);
            btnSaveChanges.TabIndex = 7;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 30, 46);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblChangePasswordTitle);
            panel2.Controls.Add(lblCurrentPassword);
            panel2.Controls.Add(txtCurrentPassword);
            panel2.Controls.Add(lblNewPassword);
            panel2.Controls.Add(txtNewPassword);
            panel2.Controls.Add(lblConfirmNewPassword);
            panel2.Controls.Add(txtConfirmNewPassword);
            panel2.Controls.Add(btnUpdatePassword);
            panel2.Location = new Point(19, 293);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 240);
            panel2.TabIndex = 1;
            // 
            // lblChangePasswordTitle
            // 
            lblChangePasswordTitle.AutoSize = true;
            lblChangePasswordTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblChangePasswordTitle.ForeColor = Color.White;
            lblChangePasswordTitle.Location = new Point(16, 12);
            lblChangePasswordTitle.Name = "lblChangePasswordTitle";
            lblChangePasswordTitle.Size = new Size(127, 19);
            lblChangePasswordTitle.TabIndex = 0;
            lblChangePasswordTitle.Text = "Change Password";
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.ForeColor = Color.FromArgb(140, 140, 150);
            lblCurrentPassword.Location = new Point(16, 46);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(100, 15);
            lblCurrentPassword.TabIndex = 1;
            lblCurrentPassword.Text = "Current Password";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.BackColor = Color.FromArgb(38, 42, 61);
            txtCurrentPassword.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentPassword.ForeColor = Color.White;
            txtCurrentPassword.Location = new Point(16, 64);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(300, 23);
            txtCurrentPassword.TabIndex = 2;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.ForeColor = Color.FromArgb(140, 140, 150);
            lblNewPassword.Location = new Point(16, 100);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(84, 15);
            lblNewPassword.TabIndex = 3;
            lblNewPassword.Text = "New Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.FromArgb(38, 42, 61);
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.ForeColor = Color.White;
            txtNewPassword.Location = new Point(16, 118);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(300, 23);
            txtNewPassword.TabIndex = 4;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.AutoSize = true;
            lblConfirmNewPassword.ForeColor = Color.FromArgb(140, 140, 150);
            lblConfirmNewPassword.Location = new Point(16, 154);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new Size(131, 15);
            lblConfirmNewPassword.TabIndex = 5;
            lblConfirmNewPassword.Text = "Confirm New Password";
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.BackColor = Color.FromArgb(38, 42, 61);
            txtConfirmNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmNewPassword.ForeColor = Color.White;
            txtConfirmNewPassword.Location = new Point(16, 172);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(300, 23);
            txtConfirmNewPassword.TabIndex = 6;
            txtConfirmNewPassword.UseSystemPasswordChar = true;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = Color.FromArgb(0, 220, 210);
            btnUpdatePassword.FlatAppearance.BorderSize = 0;
            btnUpdatePassword.FlatStyle = FlatStyle.Flat;
            btnUpdatePassword.ForeColor = Color.FromArgb(15, 18, 32);
            btnUpdatePassword.Location = new Point(16, 205);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(150, 30);
            btnUpdatePassword.TabIndex = 7;
            btnUpdatePassword.Text = "Update Password";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 30, 46);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblNotificationsTitle);
            panel3.Controls.Add(chkEmailNotifcations);
            panel3.Controls.Add(chkPushNotifications);
            panel3.Controls.Add(chkTransactionAlerts);
            panel3.Controls.Add(chkVisibility);
            panel3.Location = new Point(380, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(332, 243);
            panel3.TabIndex = 2;
            // 
            // lblNotificationsTitle
            // 
            lblNotificationsTitle.AutoSize = true;
            lblNotificationsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNotificationsTitle.ForeColor = Color.White;
            lblNotificationsTitle.Location = new Point(16, 12);
            lblNotificationsTitle.Name = "lblNotificationsTitle";
            lblNotificationsTitle.Size = new Size(171, 19);
            lblNotificationsTitle.TabIndex = 0;
            lblNotificationsTitle.Text = "Notification Preferences";
            // 
            // chkEmailNotifcations
            // 
            chkEmailNotifcations.AutoSize = true;
            chkEmailNotifcations.ForeColor = Color.White;
            chkEmailNotifcations.Location = new Point(16, 50);
            chkEmailNotifcations.Name = "chkEmailNotifcations";
            chkEmailNotifcations.Size = new Size(126, 19);
            chkEmailNotifcations.TabIndex = 1;
            chkEmailNotifcations.Text = "Email Notifications";
            // 
            // chkPushNotifications
            // 
            chkPushNotifications.AutoSize = true;
            chkPushNotifications.ForeColor = Color.White;
            chkPushNotifications.Location = new Point(16, 85);
            chkPushNotifications.Name = "chkPushNotifications";
            chkPushNotifications.Size = new Size(123, 19);
            chkPushNotifications.TabIndex = 2;
            chkPushNotifications.Text = "Push Notifications";
            // 
            // chkTransactionAlerts
            // 
            chkTransactionAlerts.AutoSize = true;
            chkTransactionAlerts.ForeColor = Color.White;
            chkTransactionAlerts.Location = new Point(16, 120);
            chkTransactionAlerts.Name = "chkTransactionAlerts";
            chkTransactionAlerts.Size = new Size(120, 19);
            chkTransactionAlerts.TabIndex = 3;
            chkTransactionAlerts.Text = "Transaction Alerts";
            // 
            // chkVisibility
            // 
            chkVisibility.AutoSize = true;
            chkVisibility.ForeColor = Color.White;
            chkVisibility.Location = new Point(16, 155);
            chkVisibility.Name = "chkVisibility";
            chkVisibility.Size = new Size(143, 19);
            chkVisibility.TabIndex = 4;
            chkVisibility.Text = "Public Profile Visibility";
            // 
            // UcSettings
            // 
            BackColor = Color.FromArgb(15, 18, 32);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "UcSettings";
            Size = new Size(798, 563);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Label lblAccountInfoTitle;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblUsername;
        private TextBox txtUsername;
        private Button btnSaveChanges;

        private Panel panel2;
        private Label lblChangePasswordTitle;
        private Label lblCurrentPassword;
        private TextBox txtCurrentPassword;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmNewPassword;
        private TextBox txtConfirmNewPassword;
        private Button btnUpdatePassword;

        private Panel panel3;
        private Label lblNotificationsTitle;
        private CheckBox chkEmailNotifcations;
        private CheckBox chkPushNotifications;
        private CheckBox chkTransactionAlerts;
        private CheckBox chkVisibility;
    }
}
