using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _1September
{
    public partial class UcSettings : UserControl
    {
        private string originalCellNumber = "";
        public UcSettings()
        {
            InitializeComponent();
            this.Load += UcSettings_Load;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UcSettings_Load(object sender, EventArgs e)
        {
            if (Program.CurrentUser != null)
            {
                txtFullName.Text = $"{Program.CurrentUser.Name} {Program.CurrentUser.SecondName}";
                txtEmail.Text = Program.CurrentUser.Email;
                txtUsername.Text = Program.CurrentUser.Name;

                chkEmailNotifcations.Checked = Program.CurrentUser.EmailNotifications;
                chkPushNotifications.Checked = Program.CurrentUser.PushNotifications;
                chkTransactionAlerts.Checked = Program.CurrentUser.TransactionAlerts;
                chkVisibility.Checked = Program.CurrentUser.Visible;

            }


        }
        private void chkEmailNotifcations_CheckedChanged(object sender, EventArgs e)
        {
            if (Program.CurrentUser == null) return;
            {
                Program.CurrentUser.EmailNotifications = chkEmailNotifcations.Checked;
            }
        }
        private void chkPushNotifications_CheckedChanged(object sender, EventArgs e)
        {
            if (Program.CurrentUser == null) return;
            {
                Program.CurrentUser.PushNotifications = chkPushNotifications.Checked;
            }
        }
        private void chkTransactionAlerts_CheckedChanged(object sender, EventArgs e)
        {
            if (Program.CurrentUser == null) return;
            {
                Program.CurrentUser.TransactionAlerts = chkTransactionAlerts.Checked;
            }
        }
        private void chkVisibility_CheckedChanged(object sender, EventArgs e)
        {
            if (Program.CurrentUser == null) return;
            {
                Program.CurrentUser.Visible = chkVisibility.Checked;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser == null) return;

            //if (Program.CurrentUser == null) return;

            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Fill in all fields");
                return;
            }

            string[] nameParts = txtFullName.Text.Trim().Split(' ');
            Program.CurrentUser.Name = nameParts[0];
            Program.CurrentUser.SecondName = nameParts.Length > 1 ? string.Join(" ", nameParts.Skip(1)) : "";
            Program.CurrentUser.Email = txtEmail.Text.Trim();
            Program.CurrentUser.CellNumber = txtUsername.Text.Trim();

            SaveToTxtFile(); // save to file

            MessageBox.Show("Profile saved and updated in txt!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            originalCellNumber = Program.CurrentUser.CellNumber; // update original
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
         
            if (Program.CurrentUser == null) return;
            if (Program.CurrentUser == null) return;

            if (txtCurrentPassword.Text != Program.CurrentUser.Password)
            {
                MessageBox.Show("Current password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                MessageBox.Show("New password and Confirm don't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNewPassword.Text.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters");
                return;
            }

            Program.CurrentUser.Password = txtNewPassword.Text.Trim();

            SaveToTxtFile(); // save to file

            MessageBox.Show("Password updated and saved to txt!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmNewPassword.Clear();



        }

        private void SaveToTxtFile()
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "users.txt");
                if (!File.Exists(path)) path = "users.txt";
                if (!File.Exists(path)) path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\users.txt");

                if (!File.Exists(path))
                {
                    MessageBox.Show("users.txt not found!");
                    return;
                }

                var lines = File.ReadAllLines(path).ToList();

                for (int i = 0; i < lines.Count; i++)
                {
                    // Your file: name|surname|password|cell|email
                    var cols = lines[i].Split('|');
                    if (cols.Length >= 5 && cols[3].Trim() == originalCellNumber.Trim())
                    {
                        lines[i] = $"{Program.CurrentUser.Name}|{Program.CurrentUser.SecondName}|{Program.CurrentUser.Password}|{Program.CurrentUser.CellNumber}|{Program.CurrentUser.Email}";
                        break;
                    }
                }

                File.WriteAllLines(path, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message);
            }


        }
    }
}
