using TrustID.Exceptions;
using TrustID.Models;

namespace user_dashboard
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            SetupLoginExperience();
            PremiumFormDesign.Apply(this, "Login");
            PremiumFormDesign.AddFormThemeToggle(this, "Login");
        }

        private void SetupLoginExperience()
        {
            lblTrustIdMotto.Text = "Welcome Back";
            lblTrustIdMotto.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblUsername.Text = "Email Address / Username";
            lblPassword.Text = "Password";
            txtName.PlaceholderText = "Enter your email address or username";
            txtPassword.PlaceholderText = "Enter your password";
            btnLogin.Text = "Sign In";

            Label subtitle = new Label();
            subtitle.Name = "lblLoginSubtitle";
            subtitle.Text = "Sign in to continue your verification journey.";
            subtitle.AutoSize = false;
            pnlLogin.Controls.Add(subtitle);

            CheckBox showPassword = new CheckBox();
            showPassword.Name = "chkShowPassword";
            showPassword.Text = "Show password";
            showPassword.AutoSize = false;
            showPassword.CheckedChanged += (sender, e) =>
            {
                txtPassword.UseSystemPasswordChar = !showPassword.Checked;
            };
            pnlLogin.Controls.Add(showPassword);

            LinkLabel forgot = new LinkLabel();
            forgot.Name = "lnkForgotPassword";
            forgot.Text = "Forgot password?";
            forgot.AutoSize = false;
            forgot.TextAlign = ContentAlignment.MiddleRight;
            forgot.LinkClicked += LnkForgotPassword_LinkClicked;
            pnlLogin.Controls.Add(forgot);

            Label noAccount = new Label();
            noAccount.Name = "lblNoAccount";
            noAccount.Text = "Don't have an account?";
            noAccount.AutoSize = false;
            noAccount.TextAlign = ContentAlignment.MiddleRight;
            pnlLogin.Controls.Add(noAccount);

            lnkCreateAccount.AutoSize = false;
            lnkCreateAccount.TextAlign = ContentAlignment.MiddleLeft;

            subtitle.BringToFront();
            showPassword.BringToFront();
            forgot.BringToFront();
            noAccount.BringToFront();
            lnkCreateAccount.BringToFront();
        }

        private void LnkForgotPassword_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            using Form resetForm = new Form();

            resetForm.Text = "Reset Password";
            resetForm.StartPosition = FormStartPosition.CenterParent;
            resetForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            resetForm.MaximizeBox = false;
            resetForm.MinimizeBox = false;
            resetForm.ClientSize = new Size(410, 345);

            bool dark = PremiumFormDesign.DarkMode;

            resetForm.BackColor = dark
                ? Color.FromArgb(7, 27, 48)
                : Color.FromArgb(247, 251, 255);

            Color textColor = dark
                ? Color.White
                : Color.FromArgb(12, 29, 52);

            Color mutedColor = dark
                ? Color.FromArgb(168, 192, 220)
                : Color.FromArgb(82, 106, 133);

            Color inputColor = dark
                ? Color.FromArgb(12, 35, 60)
                : Color.White;

            Label title = new Label();
            title.Text = "Reset Password";
            title.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            title.ForeColor = textColor;
            title.AutoSize = true;
            title.Location = new Point(28, 22);

            Label info = new Label();
            info.Text = "Enter your email or username and choose a new password.";
            info.ForeColor = mutedColor;
            info.AutoSize = true;
            info.Location = new Point(30, 62);

            TextBox account = new TextBox();
            account.PlaceholderText = "Email address or username";
            account.Location = new Point(30, 98);
            account.Size = new Size(350, 29);
            account.BackColor = inputColor;
            account.ForeColor = textColor;
            account.BorderStyle = BorderStyle.FixedSingle;

            TextBox password = new TextBox();
            password.PlaceholderText = "New password";
            password.UseSystemPasswordChar = true;
            password.Location = new Point(30, 145);
            password.Size = new Size(350, 29);
            password.BackColor = inputColor;
            password.ForeColor = textColor;
            password.BorderStyle = BorderStyle.FixedSingle;

            TextBox confirm = new TextBox();
            confirm.PlaceholderText = "Confirm new password";
            confirm.UseSystemPasswordChar = true;
            confirm.Location = new Point(30, 192);
            confirm.Size = new Size(350, 29);
            confirm.BackColor = inputColor;
            confirm.ForeColor = textColor;
            confirm.BorderStyle = BorderStyle.FixedSingle;

            CheckBox showPasswords = new CheckBox();
            showPasswords.Text = "Show passwords";
            showPasswords.AutoSize = true;
            showPasswords.Location = new Point(30, 233);
            showPasswords.ForeColor = textColor;
            showPasswords.BackColor = Color.Transparent;

            showPasswords.CheckedChanged += (sender2, e2) =>
            {
                password.UseSystemPasswordChar = !showPasswords.Checked;
                confirm.UseSystemPasswordChar = !showPasswords.Checked;
            };

            Button reset = new Button();
            reset.Text = "Reset Password";
            reset.Location = new Point(30, 278);
            reset.Size = new Size(350, 38);
            reset.FlatStyle = FlatStyle.Flat;
            reset.BackColor = Color.FromArgb(21, 119, 235);
            reset.ForeColor = Color.White;
            reset.FlatAppearance.BorderSize = 0;

            reset.Click += (sender2, e2) =>
            {
                if (password.Text != confirm.Text)
                {
                    MessageBox.Show(
                        "The passwords do not match.",
                        "Reset Password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                try
                {
                    Program.SharedUserManager.ResetPassword(
                        account.Text.Trim(),
                        password.Text
                    );

                    MessageBox.Show(
                        "Password reset successfully. You can now sign in.",
                        "Reset Password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    resetForm.Close();
                }
                catch (ValidationException ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Could Not Reset Password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            };

            resetForm.Controls.Add(title);
            resetForm.Controls.Add(info);
            resetForm.Controls.Add(account);
            resetForm.Controls.Add(password);
            resetForm.Controls.Add(confirm);
            resetForm.Controls.Add(showPasswords);
            resetForm.Controls.Add(reset);

            resetForm.ShowDialog(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtName.Text.Trim();
            string password = txtPassword.Text.Trim();

            errorProvider1.SetError(btnLogin, "");

            try
            {
                User loggedInUser = Program.SharedUserManager.Login(username, password);
                Program.CurrentUser = loggedInUser;

                if (loggedInUser.CanAccessAdminFunctions())
                {
                    frmAdminDashboard adminDashboard = new frmAdminDashboard();
                    Hide();
                    adminDashboard.ShowDialog();
                    Show();
                }
                else
                {
                    UserDashboard dashboard = new UserDashboard(loggedInUser);
                    Hide();
                    dashboard.ShowDialog();
                    Show();
                }
            }
            catch (ValidationException)
            {
                errorProvider1.SetError(
                    btnLogin,
                    "Invalid email, username or password."
                );
            }
        }

        private void lnkCreateAccount_LinkClicked_2(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            Hide();
            createAccountForm.ShowDialog();
            Show();
        }
    }
}
