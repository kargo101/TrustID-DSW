namespace user_dashboard
{
    public partial class UcSettings : UserControl
    {
        public UcSettings()
        {
            InitializeComponent();
            SetupShowPassword();
            PremiumFormDesign.Apply(this, "Settings");
            LoadCurrentUserSettings();
        }

        private void SetupShowPassword()
        {
            CheckBox showPasswords = new CheckBox();
            showPasswords.Name = "chkSettingsShowPasswords";
            showPasswords.Text = "Show passwords";
            showPasswords.AutoSize = false;
            showPasswords.Size = new Size(135, 23);
            showPasswords.Location = new Point(180, 207);

            showPasswords.CheckedChanged += (sender, e) =>
            {
                txtCurrentPassword.UseSystemPasswordChar =
                    !showPasswords.Checked;

                txtNewPassword.UseSystemPasswordChar =
                    !showPasswords.Checked;

                txtConfirmNewPassword.UseSystemPasswordChar =
                    !showPasswords.Checked;
            };

            panel2.Controls.Add(showPasswords);
        }

        private void LoadCurrentUserSettings()
        {
            if (Program.CurrentUser == null)
                return;

            txtFullName.Text =
                Program.CurrentUser.FullName;

            txtEmail.Text =
                Program.CurrentUser.Email;

            txtUsername.Text =
                Program.CurrentUser.Username;
        }

        private void btnSaveChanges_Click(
            object sender,
            EventArgs e)
        {
            if (Program.CurrentUser == null)
                return;

            string fullName =
                txtFullName.Text.Trim();

            string email =
                txtEmail.Text.Trim();

            if (fullName == "" || email == "")
            {
                MessageBox.Show(
                    "Please fill in your name and email."
                );
                return;
            }

            bool emailUsed =
                Program.SharedUserManager.Users.Any(
                    user =>
                        user.UserId !=
                        Program.CurrentUser.UserId &&
                        user.Email.Equals(
                            email,
                            StringComparison.OrdinalIgnoreCase
                        )
                );

            if (emailUsed)
            {
                MessageBox.Show(
                    "That email address is already in use."
                );
                return;
            }

            try
            {
                Program.CurrentUser.FullName =
                    fullName;

                Program.CurrentUser.Email =
                    email;

                Program.SharedUserManager.SaveChanges();

                MessageBox.Show(
                    "Profile updated.",
                    "Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Could Not Save",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnUpdatePassword_Click(
            object sender,
            EventArgs e)
        {
            if (Program.CurrentUser == null)
                return;

            if (!Program.CurrentUser.VerifyPassword(
                txtCurrentPassword.Text))
            {
                MessageBox.Show(
                    "Current password is incorrect.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (txtNewPassword.Text !=
                txtConfirmNewPassword.Text)
            {
                MessageBox.Show(
                    "The new passwords do not match.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            try
            {
                Program.CurrentUser.SetPassword(
                    txtNewPassword.Text
                );

                Program.SharedUserManager.SaveChanges();

                MessageBox.Show(
                    "Password updated.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmNewPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Could Not Update Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
