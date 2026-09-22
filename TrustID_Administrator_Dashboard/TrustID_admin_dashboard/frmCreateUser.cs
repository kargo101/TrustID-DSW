using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrustID.Models;

namespace TrustID_admin_dashboard
{
    public partial class frmCreateUser : Form
    {
        public User CreatedUser { get; private set; }

        public frmCreateUser()
        {
            InitializeComponent();
            cmbNewUserType.Items.Add("Individual");
            cmbNewUserType.Items.Add("Business");
            cmbNewUserType.SelectedIndex = 0;
        }

        private void btnCreateSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbNewUserType.SelectedItem.ToString() == "Individual")
                {
                    CreatedUser = new IndividualUser(
                        txtNewFullName.Text,
                        txtNewEmail.Text,
                        txtNewUsername.Text,
                        txtNewPassword.Text,
                        "Unspecified");
                }
                else
                {
                    CreatedUser = new BusinessUser(
                        txtNewFullName.Text,
                        txtNewEmail.Text,
                        txtNewUsername.Text,
                        txtNewPassword.Text,
                        txtNewFullName.Text,
                        "PENDING-REG");
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCreateCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
