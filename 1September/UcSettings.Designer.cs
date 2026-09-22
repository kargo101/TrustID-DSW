namespace _1September
{
    partial class UcSettings
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
            grbSettings = new GroupBox();
            lblSettings = new Label();
            grbEditAccInfo = new GroupBox();
            btnSaveChanges = new Button();
            txtUsername = new TextBox();
            lblUsername = new Label();
            txtEmail = new TextBox();
            lblEmailAddress = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            grbNotificationsPreference = new GroupBox();
            lblTransactionAlerts = new Label();
            lblPushNotifications = new Label();
            chkTransactionAlerts = new CheckBox();
            chkPushNotifications = new CheckBox();
            lblEmailNotification = new Label();
            chkEmailNotifcations = new CheckBox();
            grbChangePassword = new GroupBox();
            btnUpdatePassword = new Button();
            txtConfirmNewPassword = new TextBox();
            txtNewPassword = new TextBox();
            lblConfirmNewPassword = new Label();
            lblNewPassword = new Label();
            txtCurrentPassword = new TextBox();
            lblCurrentPassword = new Label();
            grbVisibility = new GroupBox();
            lblVisibility = new Label();
            chkVisibility = new CheckBox();
            grbSession = new GroupBox();
            btnLogout = new Button();
            label1 = new Label();
            grbSettings.SuspendLayout();
            grbEditAccInfo.SuspendLayout();
            grbNotificationsPreference.SuspendLayout();
            grbChangePassword.SuspendLayout();
            grbVisibility.SuspendLayout();
            grbSession.SuspendLayout();
            SuspendLayout();
            // 
            // grbSettings
            // 
            grbSettings.Controls.Add(lblSettings);
            grbSettings.Location = new Point(3, 3);
            grbSettings.Name = "grbSettings";
            grbSettings.Size = new Size(1346, 88);
            grbSettings.TabIndex = 1;
            grbSettings.TabStop = false;
            grbSettings.Text = "Settings";
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            lblSettings.Location = new Point(17, 39);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(529, 25);
            lblSettings.TabIndex = 0;
            lblSettings.Text = "Manage your profile,security settings and notification preferences";
            // 
            // grbEditAccInfo
            // 
            grbEditAccInfo.Controls.Add(btnSaveChanges);
            grbEditAccInfo.Controls.Add(txtUsername);
            grbEditAccInfo.Controls.Add(lblUsername);
            grbEditAccInfo.Controls.Add(txtEmail);
            grbEditAccInfo.Controls.Add(lblEmailAddress);
            grbEditAccInfo.Controls.Add(txtFullName);
            grbEditAccInfo.Controls.Add(lblFullName);
            grbEditAccInfo.Location = new Point(3, 97);
            grbEditAccInfo.Name = "grbEditAccInfo";
            grbEditAccInfo.Size = new Size(579, 331);
            grbEditAccInfo.TabIndex = 2;
            grbEditAccInfo.TabStop = false;
            grbEditAccInfo.Text = "Edit Account Information";
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(-3, 251);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(192, 34);
            btnSaveChanges.TabIndex = 6;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(0, 200);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(489, 31);
            txtUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(-3, 172);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(0, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(489, 31);
            txtEmail.TabIndex = 3;
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Location = new Point(-3, 98);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(124, 25);
            lblEmailAddress.TabIndex = 2;
            lblEmailAddress.Text = "Email Address";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(0, 55);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(489, 31);
            txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(0, 27);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(91, 25);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            // 
            // grbNotificationsPreference
            // 
            grbNotificationsPreference.Controls.Add(lblTransactionAlerts);
            grbNotificationsPreference.Controls.Add(lblPushNotifications);
            grbNotificationsPreference.Controls.Add(chkTransactionAlerts);
            grbNotificationsPreference.Controls.Add(chkPushNotifications);
            grbNotificationsPreference.Controls.Add(lblEmailNotification);
            grbNotificationsPreference.Controls.Add(chkEmailNotifcations);
            grbNotificationsPreference.Location = new Point(611, 97);
            grbNotificationsPreference.Name = "grbNotificationsPreference";
            grbNotificationsPreference.Size = new Size(426, 331);
            grbNotificationsPreference.TabIndex = 3;
            grbNotificationsPreference.TabStop = false;
            grbNotificationsPreference.Text = "Notifications Preference";
            // 
            // lblTransactionAlerts
            // 
            lblTransactionAlerts.AutoSize = true;
            lblTransactionAlerts.Location = new Point(4, 225);
            lblTransactionAlerts.Name = "lblTransactionAlerts";
            lblTransactionAlerts.Size = new Size(400, 25);
            lblTransactionAlerts.TabIndex = 5;
            lblTransactionAlerts.Text = "Get notified instantly on block-reputation actions\r\n";
            // 
            // lblPushNotifications
            // 
            lblPushNotifications.AutoSize = true;
            lblPushNotifications.Location = new Point(0, 161);
            lblPushNotifications.Name = "lblPushNotifications";
            lblPushNotifications.Size = new Size(415, 25);
            lblPushNotifications.TabIndex = 4;
            lblPushNotifications.Text = "Alert me on browser for verification status changes\r\n";
            // 
            // chkTransactionAlerts
            // 
            chkTransactionAlerts.AutoSize = true;
            chkTransactionAlerts.Location = new Point(9, 200);
            chkTransactionAlerts.Name = "chkTransactionAlerts";
            chkTransactionAlerts.Size = new Size(176, 29);
            chkTransactionAlerts.TabIndex = 3;
            chkTransactionAlerts.Text = "Transaction Alerts";
            chkTransactionAlerts.UseVisualStyleBackColor = true;
            // 
            // chkPushNotifications
            // 
            chkPushNotifications.AutoSize = true;
            chkPushNotifications.Location = new Point(4, 129);
            chkPushNotifications.Name = "chkPushNotifications";
            chkPushNotifications.Size = new Size(181, 29);
            chkPushNotifications.TabIndex = 2;
            chkPushNotifications.Text = "Push Notifications";
            chkPushNotifications.UseVisualStyleBackColor = true;
            // 
            // lblEmailNotification
            // 
            lblEmailNotification.AutoSize = true;
            lblEmailNotification.Location = new Point(0, 86);
            lblEmailNotification.Name = "lblEmailNotification";
            lblEmailNotification.Size = new Size(398, 25);
            lblEmailNotification.TabIndex = 1;
            lblEmailNotification.Text = "Receive security digests and login alerts via email";
            // 
            // chkEmailNotifcations
            // 
            chkEmailNotifcations.AutoSize = true;
            chkEmailNotifcations.Location = new Point(0, 57);
            chkEmailNotifcations.Name = "chkEmailNotifcations";
            chkEmailNotifcations.Size = new Size(185, 29);
            chkEmailNotifcations.TabIndex = 0;
            chkEmailNotifcations.Text = "Email Notifications";
            chkEmailNotifcations.UseVisualStyleBackColor = true;
            // 
            // grbChangePassword
            // 
            grbChangePassword.Controls.Add(btnUpdatePassword);
            grbChangePassword.Controls.Add(txtConfirmNewPassword);
            grbChangePassword.Controls.Add(txtNewPassword);
            grbChangePassword.Controls.Add(lblConfirmNewPassword);
            grbChangePassword.Controls.Add(lblNewPassword);
            grbChangePassword.Controls.Add(txtCurrentPassword);
            grbChangePassword.Controls.Add(lblCurrentPassword);
            grbChangePassword.Location = new Point(3, 451);
            grbChangePassword.Name = "grbChangePassword";
            grbChangePassword.Size = new Size(579, 375);
            grbChangePassword.TabIndex = 3;
            grbChangePassword.TabStop = false;
            grbChangePassword.Text = "Change Password";
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.Location = new Point(6, 301);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(192, 34);
            btnUpdatePassword.TabIndex = 7;
            btnUpdatePassword.Text = "Update Password";
            btnUpdatePassword.UseVisualStyleBackColor = true;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Location = new Point(6, 248);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(489, 31);
            txtConfirmNewPassword.TabIndex = 6;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(6, 151);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(489, 31);
            txtNewPassword.TabIndex = 5;
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.AutoSize = true;
            lblConfirmNewPassword.Location = new Point(6, 201);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new Size(201, 25);
            lblConfirmNewPassword.TabIndex = 4;
            lblConfirmNewPassword.Text = " Confirm New Password";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(6, 123);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(127, 25);
            lblNewPassword.TabIndex = 3;
            lblNewPassword.Text = "New Password";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(6, 74);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(489, 31);
            txtCurrentPassword.TabIndex = 2;
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Location = new Point(6, 46);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(150, 25);
            lblCurrentPassword.TabIndex = 1;
            lblCurrentPassword.Text = "Current Password";
            // 
            // grbVisibility
            // 
            grbVisibility.Controls.Add(lblVisibility);
            grbVisibility.Controls.Add(chkVisibility);
            grbVisibility.Location = new Point(629, 460);
            grbVisibility.Name = "grbVisibility";
            grbVisibility.Size = new Size(571, 127);
            grbVisibility.TabIndex = 4;
            grbVisibility.TabStop = false;
            grbVisibility.Text = "ProfileVisibility";
            // 
            // lblVisibility
            // 
            lblVisibility.AutoSize = true;
            lblVisibility.Location = new Point(6, 83);
            lblVisibility.Name = "lblVisibility";
            lblVisibility.Size = new Size(446, 25);
            lblVisibility.TabIndex = 2;
            lblVisibility.Text = "Allow other verified TrustID users to search your profile";
            // 
            // chkVisibility
            // 
            chkVisibility.AutoSize = true;
            chkVisibility.Location = new Point(6, 51);
            chkVisibility.Name = "chkVisibility";
            chkVisibility.Size = new Size(249, 29);
            chkVisibility.TabIndex = 1;
            chkVisibility.Text = "Profile Reputation Visibility";
            chkVisibility.UseVisualStyleBackColor = true;
            // 
            // grbSession
            // 
            grbSession.Controls.Add(btnLogout);
            grbSession.Controls.Add(label1);
            grbSession.Location = new Point(635, 636);
            grbSession.Name = "grbSession";
            grbSession.Size = new Size(565, 150);
            grbSession.TabIndex = 5;
            grbSession.TabStop = false;
            grbSession.Text = "Session";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(101, 92);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(192, 34);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 48);
            label1.Name = "label1";
            label1.Size = new Size(410, 25);
            label1.TabIndex = 3;
            label1.Text = "Disconnect and log out from your Trust ID session\r\n";
            // 
            // UcSettings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grbSession);
            Controls.Add(grbVisibility);
            Controls.Add(grbChangePassword);
            Controls.Add(grbNotificationsPreference);
            Controls.Add(grbEditAccInfo);
            Controls.Add(grbSettings);
            Name = "UcSettings";
            Size = new Size(1241, 1045);
            Load += UcSettings_Load;
            grbSettings.ResumeLayout(false);
            grbSettings.PerformLayout();
            grbEditAccInfo.ResumeLayout(false);
            grbEditAccInfo.PerformLayout();
            grbNotificationsPreference.ResumeLayout(false);
            grbNotificationsPreference.PerformLayout();
            grbChangePassword.ResumeLayout(false);
            grbChangePassword.PerformLayout();
            grbVisibility.ResumeLayout(false);
            grbVisibility.PerformLayout();
            grbSession.ResumeLayout(false);
            grbSession.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbSettings;
        private Label lblSettings;
        private GroupBox grbEditAccInfo;
        private GroupBox grbNotificationsPreference;
        private GroupBox grbChangePassword;
        private GroupBox grbVisibility;
        private Button btnSaveChanges;
        private TextBox txtUsername;
        private Label lblUsername;
        private TextBox txtEmail;
        private Label lblEmailAddress;
        private TextBox txtFullName;
        private Label lblFullName;
        private CheckBox chkEmailNotifcations;
        private Label lblEmailNotification;
        private Label lblTransactionAlerts;
        private Label lblPushNotifications;
        private CheckBox chkTransactionAlerts;
        private CheckBox chkPushNotifications;
        private Label lblConfirmNewPassword;
        private Label lblNewPassword;
        private TextBox txtCurrentPassword;
        private Label lblCurrentPassword;
        private Button btnUpdatePassword;
        private TextBox txtConfirmNewPassword;
        private TextBox txtNewPassword;
        private GroupBox grbSession;
        private Label lblVisibility;
        private CheckBox chkVisibility;
        private Button btnLogout;
        private Label label1;
    }
}
