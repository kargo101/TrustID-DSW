using System.Xml.Linq;

namespace _1September
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void ClearFields()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string secondName = txtSurname.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.");
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(secondName))
            {
                MessageBox.Show("Please enter your second name.");
                txtSurname.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.");
                txtPassword.Focus();
                return;
            }

            string filePath = "users.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No users have been registered yet.");
                return;
            }

            string[] users = File.ReadAllLines(filePath);

            Program.CurrentUser = null;

            foreach (string line in users)
            {
                string[] parts = line.Split('|');

                if (parts.Length == 5)
                {
                    string savedName = parts[0];
                    string savedSecondName = parts[1];
                    string savedPassword = parts[2];
                    string savedCellNumber = parts[3];
                    string savedEmail = parts[4];

                    if (name.Equals(savedName, StringComparison.OrdinalIgnoreCase) &&
                        secondName.Equals(savedSecondName, StringComparison.OrdinalIgnoreCase) &&
                        password == savedPassword)
                    {
                        Program.CurrentUser = new User(savedName, savedSecondName, savedPassword, savedCellNumber, savedEmail);
                        break;
                    }
                }
            }
            if (Program.CurrentUser != null)
            {
                MessageBox.Show("Login successful!");
                UserDashboard dashboard = new UserDashboard(Program.CurrentUser);
                this.Hide();
                dashboard.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Incorrect name, second name or password.");
            }


        }

        private void lnkCreateAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            this.Hide();
            createAccountForm.ShowDialog();
            this.Show();
        }

        private void lnkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword changePasswordForm = new ChangePassword();
            this.Hide();
            changePasswordForm.ShowDialog();
            this.Show();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
