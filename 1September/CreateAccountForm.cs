using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _1September
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
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





        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string secondName = txtSecondName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string cellNumber = txtCellNumber.Text.Trim();
            string email = txtEmail.Text.Trim();

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

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                txtPassword.Focus();
                return;
            }
            if (!IsStrongPassword(password))
            {
                MessageBox.Show(
                    "Password must contain:\n\n" +
                    "• At least 8 characters\n" +
                    "• At least one uppercase letter\n" +
                    "• At least one lowercase letter\n" +
                    "• At least one number\n" +
                    "• At least one special character"
                );

                txtPassword.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                txtConfirmPassword.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cellNumber))
            {
                MessageBox.Show("Please enter your cell number.");
                txtCellNumber.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email.");
                txtEmail.Focus();
                return;
            }

            string filePath = "users.txt";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            string[] users = File.ReadAllLines(filePath);

            // Check whether the name and second name already exist
            foreach (string line in users)
            {
                string[] parts = line.Split('|');

                if (parts.Length == 5)
                {
                    string savedName = parts[0];
                    string savedSecondName = parts[1];

                    if (savedName.Equals(name, StringComparison.OrdinalIgnoreCase) &&
                        savedSecondName.Equals(secondName, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("An account with this name already exists.");
                        return;
                    }
                }
            }

            // Create a User object
            User newUser = new User(
                name,
                secondName,
                password,
                cellNumber,
                email
            );

            // Put the user's information into one line
            string userData =
                newUser.Name + "|" +
                newUser.SecondName + "|" +
                newUser.Password + "|" +
                newUser.CellNumber + "|" +
                newUser.Email;

            // Add the user to the TXT file
            File.AppendAllText(filePath, userData + Environment.NewLine);

            MessageBox.Show("Account created successfully!");

            this.Close();
        }
    }
}
