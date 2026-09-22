namespace user_dashboard
{
    partial class frmWriteReview
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUser = new Label();
            cmbTargetUser = new ComboBox();
            lblRating = new Label();
            cmbRating = new ComboBox();
            lblComment = new Label();
            txtComment = new TextBox();
            btnSubmitReview = new Button();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.ForeColor = Color.FromArgb(245, 247, 250);
            lblUser.Location = new Point(20, 20);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(133, 15);
            lblUser.TabIndex = 0;
            lblUser.Text = "Who are you reviewing?";
            // 
            // cmbTargetUser
            // 
            cmbTargetUser.BackColor = Color.FromArgb(20, 27, 45);
            cmbTargetUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTargetUser.ForeColor = Color.FromArgb(245, 247, 250);
            cmbTargetUser.Location = new Point(20, 40);
            cmbTargetUser.Name = "cmbTargetUser";
            cmbTargetUser.Size = new Size(300, 23);
            cmbTargetUser.TabIndex = 1;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.ForeColor = Color.FromArgb(245, 247, 250);
            lblRating.Location = new Point(20, 80);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(69, 15);
            lblRating.TabIndex = 2;
            lblRating.Text = "Rating (1-5)";
            // 
            // cmbRating
            // 
            cmbRating.BackColor = Color.FromArgb(20, 27, 45);
            cmbRating.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRating.ForeColor = Color.FromArgb(245, 247, 250);
            cmbRating.Location = new Point(20, 100);
            cmbRating.Name = "cmbRating";
            cmbRating.Size = new Size(100, 23);
            cmbRating.TabIndex = 3;
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.ForeColor = Color.FromArgb(245, 247, 250);
            lblComment.Location = new Point(20, 140);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(101, 15);
            lblComment.TabIndex = 4;
            lblComment.Text = "Review Comment";
            // 
            // txtComment
            // 
            txtComment.BackColor = Color.FromArgb(20, 27, 45);
            txtComment.ForeColor = Color.FromArgb(245, 247, 250);
            txtComment.Location = new Point(20, 160);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(300, 100);
            txtComment.TabIndex = 5;
            // 
            // btnSubmitReview
            // 
            btnSubmitReview.BackColor = Color.FromArgb(0, 217, 255);
            btnSubmitReview.FlatAppearance.BorderSize = 0;
            btnSubmitReview.FlatStyle = FlatStyle.Flat;
            btnSubmitReview.ForeColor = Color.FromArgb(15, 18, 32);
            btnSubmitReview.Location = new Point(20, 275);
            btnSubmitReview.Name = "btnSubmitReview";
            btnSubmitReview.Size = new Size(150, 32);
            btnSubmitReview.TabIndex = 6;
            btnSubmitReview.Text = "Submit Review";
            btnSubmitReview.UseVisualStyleBackColor = false;
            btnSubmitReview.Click += btnSubmitReview_Click;
            // 
            // frmWriteReview
            // 
            BackColor = Color.FromArgb(10, 15, 29);
            ClientSize = new Size(848, 548);
            Controls.Add(lblUser);
            Controls.Add(cmbTargetUser);
            Controls.Add(lblRating);
            Controls.Add(cmbRating);
            Controls.Add(lblComment);
            Controls.Add(txtComment);
            Controls.Add(btnSubmitReview);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmWriteReview";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Write a Peer Review";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblUser;
        private ComboBox cmbTargetUser;
        private Label lblRating;
        private ComboBox cmbRating;
        private Label lblComment;
        private TextBox txtComment;
        private Button btnSubmitReview;
    }
}
