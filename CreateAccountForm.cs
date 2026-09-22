using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrustID.Exceptions;
using TrustID.Models;
using user_dashboard;

namespace user_dashboard
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
            SetupPasswordToggle();
            PremiumFormDesign.Apply(this, "CreateAccount");
            PremiumFormDesign.AddFormThemeToggle(this, "CreateAccount");
        }


        private void SetupPasswordToggle()
        {
            CheckBox showPasswords = new CheckBox();
            showPasswords.Name = "chkCreateShowPasswords";
            showPasswords.Text = "Show passwords";
            showPasswords.AutoSize = false;
            showPasswords.CheckedChanged += (sender, e) =>
            {
                txtNewPassword1.UseSystemPasswordChar = !showPasswords.Checked;
                txtConfirmPassword1.UseSystemPasswordChar = !showPasswords.Checked;
            };

            pnlCreateAccount.Controls.Add(showPasswords);
        }

        private void btnCreateAccount_Click_1(object sender, EventArgs e)
        {
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string name = txtName1.Text.Trim();
            string surname = txtSurname1.Text.Trim();
            string password = txtNewPassword1.Text.Trim();
            string confirmPassword = txtConfirmPassword1.Text.Trim();
            string cellNumber = txtCellNumber1.Text.Trim();
            string email = txtEmail1.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name.");
                txtName1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(surname))
            {
                MessageBox.Show("Please enter your second name.");
                txtSurname1.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                txtConfirmPassword1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cellNumber))
            {
                MessageBox.Show("Please enter your cell number.");
                txtCellNumber1.Focus();
                return;
            }

            string fullName = $"{name} {surname}";
            try
            {
                IndividualUser newUser = new IndividualUser(
                    fullName,
                    email,
                    email,// Username = Email
                    password,
                    "Unspecified");// Occupation - not collected by this form

                Program.SharedUserManager.Register(newUser);
                string filePath = Path.Combine(Application.StartupPath, "users.txt");
                string userData = $"{name}|{surname}|{password}|{cellNumber}|{email}";
                File.AppendAllText(filePath, userData + Environment.NewLine);

                MessageBox.Show("Account created successfully!");
                this.Close();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Could Not Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
