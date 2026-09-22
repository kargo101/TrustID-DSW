namespace user_dashboard
{
    partial class UcProfile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcProfile));
            pnlGeneral = new Panel();
            pictureBox1 = new PictureBox();
            lblName = new Label();
            lblOcupation = new Label();
            lblDateJoined = new Label();
            label4 = new Label();
            lblBiography = new Label();
            pnlHeader = new Panel();
            picLogo = new PictureBox();
            lblTrustID = new Label();
            lblUserName = new Label();
            pnlContactVerfication = new Panel();
            lblQualification = new Label();
            lstQualifications = new ListBox();
            pnlTrustScore = new Panel();
            lblTrustScore = new Label();
            lblTrustScoreNumber = new Label();
            lblOutOff100 = new Label();
            progressBar6 = new ProgressBar();
            pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlContactVerfication.SuspendLayout();
            pnlTrustScore.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGeneral
            // 
            pnlGeneral.BackColor = Color.FromArgb(11, 18, 32);
            pnlGeneral.BorderStyle = BorderStyle.FixedSingle;
            pnlGeneral.Controls.Add(pictureBox1);
            pnlGeneral.Controls.Add(lblName);
            pnlGeneral.Controls.Add(lblOcupation);
            pnlGeneral.Controls.Add(lblDateJoined);
            pnlGeneral.Controls.Add(label4);
            pnlGeneral.Controls.Add(lblBiography);
            pnlGeneral.Location = new Point(23, 138);
            pnlGeneral.Name = "pnlGeneral";
            pnlGeneral.Size = new Size(314, 350);
            pnlGeneral.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(20, 135);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 20);
            lblName.TabIndex = 1;
            // 
            // lblOcupation
            // 
            lblOcupation.AutoSize = true;
            lblOcupation.ForeColor = Color.FromArgb(140, 140, 150);
            lblOcupation.Location = new Point(20, 160);
            lblOcupation.Name = "lblOcupation";
            lblOcupation.Size = new Size(0, 15);
            lblOcupation.TabIndex = 2;
            // 
            // lblDateJoined
            // 
            lblDateJoined.AutoSize = true;
            lblDateJoined.ForeColor = Color.FromArgb(140, 140, 150);
            lblDateJoined.Location = new Point(20, 182);
            lblDateJoined.Name = "lblDateJoined";
            lblDateJoined.Size = new Size(0, 15);
            lblDateJoined.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 215);
            label4.Name = "label4";
            label4.Size = new Size(127, 17);
            label4.TabIndex = 4;
            label4.Text = "Profile Information";
            // 
            // lblBiography
            // 
            lblBiography.ForeColor = Color.FromArgb(180, 180, 190);
            lblBiography.Location = new Point(20, 240);
            lblBiography.Name = "lblBiography";
            lblBiography.Size = new Size(260, 80);
            lblBiography.TabIndex = 5;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(11, 18, 32);
            pnlHeader.BorderStyle = BorderStyle.FixedSingle;
            pnlHeader.Controls.Add(picLogo);
            pnlHeader.Controls.Add(lblTrustID);
            pnlHeader.Controls.Add(lblUserName);
            pnlHeader.Location = new Point(3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(865, 130);
            pnlHeader.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.FromArgb(11, 18, 32);
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = Properties.Resources.Icon;
            picLogo.Location = new Point(20, 20);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(80, 80);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblTrustID
            // 
            lblTrustID.AutoSize = true;
            lblTrustID.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTrustID.ForeColor = Color.White;
            lblTrustID.Location = new Point(120, 30);
            lblTrustID.Name = "lblTrustID";
            lblTrustID.Size = new Size(129, 41);
            lblTrustID.TabIndex = 1;
            lblTrustID.Text = "Trust ID";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10F);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(650, 50);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(0, 19);
            lblUserName.TabIndex = 2;
            // 
            // pnlContactVerfication
            // 
            pnlContactVerfication.BackColor = Color.FromArgb(11, 18, 32);
            pnlContactVerfication.BorderStyle = BorderStyle.FixedSingle;
            pnlContactVerfication.Controls.Add(lblQualification);
            pnlContactVerfication.Controls.Add(lstQualifications);
            pnlContactVerfication.Location = new Point(346, 138);
            pnlContactVerfication.Name = "pnlContactVerfication";
            pnlContactVerfication.Size = new Size(370, 350);
            pnlContactVerfication.TabIndex = 2;
            // 
            // lblQualification
            // 
            lblQualification.AutoSize = true;
            lblQualification.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblQualification.ForeColor = Color.White;
            lblQualification.Location = new Point(15, 15);
            lblQualification.Name = "lblQualification";
            lblQualification.Size = new Size(100, 19);
            lblQualification.TabIndex = 0;
            lblQualification.Text = "Qualifications";
            // 
            // lstQualifications
            // 
            lstQualifications.BackColor = Color.FromArgb(35, 41, 54);
            lstQualifications.ForeColor = Color.White;
            lstQualifications.Location = new Point(15, 50);
            lstQualifications.Name = "lstQualifications";
            lstQualifications.Size = new Size(300, 274);
            lstQualifications.TabIndex = 1;
            // 
            // pnlTrustScore
            // 
            pnlTrustScore.BackColor = Color.FromArgb(11, 18, 32);
            pnlTrustScore.BorderStyle = BorderStyle.FixedSingle;
            pnlTrustScore.Controls.Add(lblTrustScore);
            pnlTrustScore.Controls.Add(lblTrustScoreNumber);
            pnlTrustScore.Controls.Add(lblOutOff100);
            pnlTrustScore.Controls.Add(progressBar6);
            pnlTrustScore.Location = new Point(23, 494);
            pnlTrustScore.Name = "pnlTrustScore";
            pnlTrustScore.Size = new Size(845, 136);
            pnlTrustScore.TabIndex = 3;
            // 
            // lblTrustScore
            // 
            lblTrustScore.AutoSize = true;
            lblTrustScore.ForeColor = Color.White;
            lblTrustScore.Location = new Point(20, 10);
            lblTrustScore.Name = "lblTrustScore";
            lblTrustScore.Size = new Size(65, 15);
            lblTrustScore.TabIndex = 0;
            lblTrustScore.Text = "Trust Score";
            // 
            // lblTrustScoreNumber
            // 
            lblTrustScoreNumber.AutoSize = true;
            lblTrustScoreNumber.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTrustScoreNumber.ForeColor = Color.FromArgb(34, 211, 238);
            lblTrustScoreNumber.Location = new Point(20, 35);
            lblTrustScoreNumber.Name = "lblTrustScoreNumber";
            lblTrustScoreNumber.Size = new Size(0, 47);
            lblTrustScoreNumber.TabIndex = 1;
            // 
            // lblOutOff100
            // 
            lblOutOff100.AutoSize = true;
            lblOutOff100.Font = new Font("Segoe UI", 16F);
            lblOutOff100.ForeColor = Color.White;
            lblOutOff100.Location = new Point(90, 55);
            lblOutOff100.Name = "lblOutOff100";
            lblOutOff100.Size = new Size(58, 30);
            lblOutOff100.TabIndex = 2;
            lblOutOff100.Text = "/100";
            // 
            // progressBar6
            // 
            progressBar6.Location = new Point(20, 100);
            progressBar6.Name = "progressBar6";
            progressBar6.Size = new Size(600, 12);
            progressBar6.TabIndex = 3;
            // 
            // UcProfile
            // 
            BackColor = Color.FromArgb(35, 41, 54);
            Controls.Add(pnlHeader);
            Controls.Add(pnlGeneral);
            Controls.Add(pnlContactVerfication);
            Controls.Add(pnlTrustScore);
            Name = "UcProfile";
            Size = new Size(884, 650);
            pnlGeneral.ResumeLayout(false);
            pnlGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlContactVerfication.ResumeLayout(false);
            pnlContactVerfication.PerformLayout();
            pnlTrustScore.ResumeLayout(false);
            pnlTrustScore.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlGeneral;
        private Label label4;
        private Label lblBiography;
        private Label lblDateJoined;
        private Label lblOcupation;
        private Label lblName;
        private PictureBox pictureBox1;
        private Panel pnlHeader;
        private Label lblUserName;
        private Label lblTrustID;
        private PictureBox picLogo;
        private Panel pnlContactVerfication;
        private Label lblQualification;
        private ListBox lstQualifications;
        private Panel pnlTrustScore;
        private Label lblOutOff100;
        private Label lblTrustScoreNumber;
        private Label lblTrustScore;
        private ProgressBar progressBar6;
    }
}
