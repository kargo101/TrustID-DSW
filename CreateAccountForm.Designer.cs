namespace user_dashboard
{
    public partial class CreateAccountForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnCreateAccount = new Button();
            lblName = new Label();
            txtName1 = new TextBox();
            pnlCreateAccount = new Panel();
            txtEmail1 = new TextBox();
            lblEmailAddress = new Label();
            txtSurname1 = new TextBox();
            txtCellNumber1 = new TextBox();
            txtConfirmPassword1 = new TextBox();
            txtNewPassword1 = new TextBox();
            lblNewPassword = new Label();
            lblConfirmPassword = new Label();
            lblCellNumber = new Label();
            lblSurname = new Label();
            pnlCreateAccount.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.Cyan;
            btnCreateAccount.FlatAppearance.BorderSize = 0;
            btnCreateAccount.FlatStyle = FlatStyle.Popup;
            btnCreateAccount.ForeColor = Color.FromArgb(8, 14, 28);
            btnCreateAccount.Location = new Point(102, 272);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(275, 26);
            btnCreateAccount.TabIndex = 0;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.FromArgb(140, 140, 150);
            lblName.Location = new Point(18, 26);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // txtName1
            // 
            txtName1.BackColor = Color.FromArgb(8, 14, 28);
            txtName1.BorderStyle = BorderStyle.None;
            txtName1.ForeColor = Color.White;
            txtName1.Location = new Point(128, 26);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(249, 16);
            txtName1.TabIndex = 2;
            // 
            // pnlCreateAccount
            // 
            pnlCreateAccount.BackColor = Color.FromArgb(17, 24, 39);
            pnlCreateAccount.Controls.Add(txtEmail1);
            pnlCreateAccount.Controls.Add(lblEmailAddress);
            pnlCreateAccount.Controls.Add(txtSurname1);
            pnlCreateAccount.Controls.Add(txtCellNumber1);
            pnlCreateAccount.Controls.Add(txtConfirmPassword1);
            pnlCreateAccount.Controls.Add(txtNewPassword1);
            pnlCreateAccount.Controls.Add(lblNewPassword);
            pnlCreateAccount.Controls.Add(btnCreateAccount);
            pnlCreateAccount.Controls.Add(lblConfirmPassword);
            pnlCreateAccount.Controls.Add(lblCellNumber);
            pnlCreateAccount.Controls.Add(lblSurname);
            pnlCreateAccount.Controls.Add(txtName1);
            pnlCreateAccount.Controls.Add(lblName);
            pnlCreateAccount.Location = new Point(205, 117);
            pnlCreateAccount.Name = "pnlCreateAccount";
            pnlCreateAccount.Size = new Size(436, 336);
            pnlCreateAccount.TabIndex = 3;
            // 
            // txtEmail1
            // 
            txtEmail1.BackColor = Color.FromArgb(8, 14, 28);
            txtEmail1.BorderStyle = BorderStyle.None;
            txtEmail1.ForeColor = Color.White;
            txtEmail1.Location = new Point(128, 142);
            txtEmail1.Name = "txtEmail1";
            txtEmail1.Size = new Size(249, 16);
            txtEmail1.TabIndex = 12;
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.ForeColor = Color.FromArgb(140, 140, 150);
            lblEmailAddress.Location = new Point(18, 142);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(81, 15);
            lblEmailAddress.TabIndex = 11;
            lblEmailAddress.Text = "Email Address";
            // 
            // txtSurname1
            // 
            txtSurname1.BackColor = Color.FromArgb(8, 14, 28);
            txtSurname1.BorderStyle = BorderStyle.None;
            txtSurname1.ForeColor = Color.White;
            txtSurname1.Location = new Point(128, 67);
            txtSurname1.Name = "txtSurname1";
            txtSurname1.Size = new Size(249, 16);
            txtSurname1.TabIndex = 10;
            // 
            // txtCellNumber1
            // 
            txtCellNumber1.BackColor = Color.FromArgb(8, 14, 28);
            txtCellNumber1.BorderStyle = BorderStyle.None;
            txtCellNumber1.ForeColor = Color.White;
            txtCellNumber1.Location = new Point(128, 109);
            txtCellNumber1.Name = "txtCellNumber1";
            txtCellNumber1.Size = new Size(249, 16);
            txtCellNumber1.TabIndex = 9;
            // 
            // txtConfirmPassword1
            // 
            txtConfirmPassword1.BackColor = Color.FromArgb(8, 14, 28);
            txtConfirmPassword1.BorderStyle = BorderStyle.None;
            txtConfirmPassword1.ForeColor = Color.White;
            txtConfirmPassword1.Location = new Point(128, 220);
            txtConfirmPassword1.Name = "txtConfirmPassword1";
            txtConfirmPassword1.Size = new Size(249, 16);
            txtConfirmPassword1.TabIndex = 8;
            txtConfirmPassword1.UseSystemPasswordChar = true;
            // 
            // txtNewPassword1
            // 
            txtNewPassword1.BackColor = Color.FromArgb(8, 14, 28);
            txtNewPassword1.BorderStyle = BorderStyle.None;
            txtNewPassword1.ForeColor = Color.White;
            txtNewPassword1.Location = new Point(128, 184);
            txtNewPassword1.Name = "txtNewPassword1";
            txtNewPassword1.Size = new Size(249, 16);
            txtNewPassword1.TabIndex = 7;
            txtNewPassword1.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.ForeColor = Color.FromArgb(140, 140, 150);
            lblNewPassword.Location = new Point(18, 185);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(84, 15);
            lblNewPassword.TabIndex = 6;
            lblNewPassword.Text = "New Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.ForeColor = Color.FromArgb(140, 140, 150);
            lblConfirmPassword.Location = new Point(18, 221);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(104, 15);
            lblConfirmPassword.TabIndex = 5;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblCellNumber
            // 
            lblCellNumber.AutoSize = true;
            lblCellNumber.ForeColor = Color.FromArgb(140, 140, 150);
            lblCellNumber.Location = new Point(18, 110);
            lblCellNumber.Name = "lblCellNumber";
            lblCellNumber.Size = new Size(74, 15);
            lblCellNumber.TabIndex = 4;
            lblCellNumber.Text = "Cell Number";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.ForeColor = Color.FromArgb(140, 140, 150);
            lblSurname.Location = new Point(18, 67);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(54, 15);
            lblSurname.TabIndex = 3;
            lblSurname.Text = "Surname";
            // 
            // CreateAccountForm
            // 
            BackColor = Color.FromArgb(8, 14, 28);
            ClientSize = new Size(882, 569);
            Controls.Add(pnlCreateAccount);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateAccountForm";
            Text = "Create Account";
            pnlCreateAccount.ResumeLayout(false);
            pnlCreateAccount.PerformLayout();
            ResumeLayout(false);
        }
        private void AddLabelAndBox(string labelText, TextBox box, ref int yPos)
        {
            

                int gap = 45;

                var lbl = new Label { Text = labelText, Location = new Point(30, yPos), AutoSize = true };
                this.Controls.Add(lbl);
                box.Location = new Point(30, yPos + 18);
                box.Size = new Size(280, 23);
                this.Controls.Add(box);
                yPos += gap;
          }   

        private TextBox txtName1;
        private TextBox txtSecondName;
private TextBox txtConfirmPassword1;
        private TextBox txtCellNumber1;
        private TextBox txtEmail;
        private Button btnCreateAccount;
        private Label lblName;
        private TextBox txtName;
        private Panel pnlCreateAccount;
        private TextBox txtSurname1;
        private TextBox txtCellNumber;
private TextBox txtNewPassword1;
        private Label lblNewPassword;
        private Label lblConfirmPassword;
        private Label lblCellNumber;
        private Label lblSurname;
        private TextBox txtEmail1;
        private Label lblEmailAddress;
    }
}
