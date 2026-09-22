using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _1September
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        private bool IsStrongPassword(string password)
        {
            if (password.Length < 8)
                return false;

            bool hasUppercase = false;
            bool hasLowercase = false;
            bool hasNumber = false;
            bool hasSpecial = false;

            foreach (char character in password)
            {
                if (char.IsUpper(character))
                    hasUppercase = true;

                else if (char.IsLower(character))
                    hasLowercase = true;

                else if (char.IsDigit(character))
                    hasNumber = true;

                else
                    hasSpecial = true;
            }

            return hasUppercase &&
                   hasLowercase &&
                   hasNumber &&
                   hasSpecial;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string secondName = txtSecondName.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.");
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(secondName))
            {
                MessageBox.Show("Please enter your second name.");
                txtSecondName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter a new password.");
                txtNewPassword.Focus();
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                txtConfirmPassword.Focus();
                return;
            }
            if (!IsStrongPassword(newPassword))
            {
                MessageBox.Show(
                    "Password must contain:\n\n" +
                    "• At least 8 characters\n" +
                    "• At least one uppercase letter\n" +
                    "• At least one lowercase letter\n" +
                    "• At least one number\n" +
                    "• At least one special character"
                );

                txtNewPassword.Focus();
                return;
            }

            string filePath = "users.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("User file could not be found.");
                return;
            }

            string[] users = File.ReadAllLines(filePath);

            bool userFound = false;

            for (int i = 0; i < users.Length; i++)
            {
                string[] parts = users[i].Split('|');

                if (parts.Length == 5)
                {
                    string savedName = parts[0];
                    string savedSecondName = parts[1];

                    if (name.Equals(savedName, StringComparison.OrdinalIgnoreCase) &&
                        secondName.Equals(savedSecondName, StringComparison.OrdinalIgnoreCase))
                    {
                        // Keep the existing details
                        string cellNumber = parts[3];
                        string email = parts[4];

                        // Replace the old password
                        users[i] = savedName + "|" +
                                   savedSecondName + "|" +
                                   newPassword + "|" +
                                   cellNumber + "|" +
                                   email;

                        userFound = true;
                        break;
                    }
                }
            }

            if (userFound)
            {
                File.WriteAllLines(filePath, users);

                MessageBox.Show("Password successfully changed!");

                this.Close();
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }
    }
}
