namespace _1September
{
    partial class UcTransactions
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblMakeTransactions = new Label();
            pnlReputationLinkedTransactions = new Panel();
            lblDescription = new Label();
            btnSubmitInfo = new Button();
            btnClearAll = new Button();
            btnSubmitDescription = new Button();
            lblMileStone = new Label();
            txtMilestoneDescription = new TextBox();
            btnEnterAmount = new Button();
            btnSearchParty = new Button();
            txtValueRewards = new TextBox();
            lblValueCredits = new Label();
            txtCounterPartyLookUp = new TextBox();
            lblCounterParty = new Label();
            dtpExecution = new DateTimePicker();
            lblDtOfExec = new Label();
            cmbTransactType = new ComboBox();
            lblTransactionType = new Label();
            lblReputationLinkedTransaction = new Label();
            pnlSearchCounterParty = new Panel();
            lsvScore = new ListView();
            lblScore = new Label();
            lblJob = new Label();
            lblName = new Label();
            lblSelectedCounterParty = new Label();
            pictureBox1 = new PictureBox();
            btnTransactionHistory = new Button();
            txtShowInformation = new TextBox();
            pnlHeader.SuspendLayout();
            pnlReputationLinkedTransactions.SuspendLayout();
            pnlSearchCounterParty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblMakeTransactions);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1472, 89);
            pnlHeader.TabIndex = 0;
            // 
            // lblMakeTransactions
            // 
            lblMakeTransactions.AutoSize = true;
            lblMakeTransactions.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMakeTransactions.Location = new Point(58, 18);
            lblMakeTransactions.Name = "lblMakeTransactions";
            lblMakeTransactions.Size = new Size(260, 38);
            lblMakeTransactions.TabIndex = 0;
            lblMakeTransactions.Text = "Make Transactions";
            // 
            // pnlReputationLinkedTransactions
            // 
            pnlReputationLinkedTransactions.Controls.Add(lblDescription);
            pnlReputationLinkedTransactions.Controls.Add(btnSubmitInfo);
            pnlReputationLinkedTransactions.Controls.Add(btnClearAll);
            pnlReputationLinkedTransactions.Controls.Add(btnSubmitDescription);
            pnlReputationLinkedTransactions.Controls.Add(lblMileStone);
            pnlReputationLinkedTransactions.Controls.Add(txtMilestoneDescription);
            pnlReputationLinkedTransactions.Controls.Add(btnEnterAmount);
            pnlReputationLinkedTransactions.Controls.Add(btnSearchParty);
            pnlReputationLinkedTransactions.Controls.Add(txtValueRewards);
            pnlReputationLinkedTransactions.Controls.Add(lblValueCredits);
            pnlReputationLinkedTransactions.Controls.Add(txtCounterPartyLookUp);
            pnlReputationLinkedTransactions.Controls.Add(lblCounterParty);
            pnlReputationLinkedTransactions.Controls.Add(dtpExecution);
            pnlReputationLinkedTransactions.Controls.Add(lblDtOfExec);
            pnlReputationLinkedTransactions.Controls.Add(cmbTransactType);
            pnlReputationLinkedTransactions.Controls.Add(lblTransactionType);
            pnlReputationLinkedTransactions.Controls.Add(lblReputationLinkedTransaction);
            pnlReputationLinkedTransactions.Dock = DockStyle.Left;
            pnlReputationLinkedTransactions.Location = new Point(0, 89);
            pnlReputationLinkedTransactions.Name = "pnlReputationLinkedTransactions";
            pnlReputationLinkedTransactions.Size = new Size(595, 648);
            pnlReputationLinkedTransactions.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(3, 616);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(106, 25);
            lblDescription.TabIndex = 16;
            lblDescription.Text = "Description:\r\n";
            // 
            // btnSubmitInfo
            // 
            btnSubmitInfo.Location = new Point(3, 557);
            btnSubmitInfo.Name = "btnSubmitInfo";
            btnSubmitInfo.Size = new Size(199, 60);
            btnSubmitInfo.TabIndex = 15;
            btnSubmitInfo.Text = "Submit Information";
            btnSubmitInfo.UseVisualStyleBackColor = true;
            btnSubmitInfo.Click += btnSubmitInfo_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(208, 557);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(138, 60);
            btnClearAll.TabIndex = 14;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnSubmitDescription
            // 
            btnSubmitDescription.Location = new Point(367, 557);
            btnSubmitDescription.Name = "btnSubmitDescription";
            btnSubmitDescription.Size = new Size(191, 60);
            btnSubmitDescription.TabIndex = 13;
            btnSubmitDescription.Text = "Submit Description";
            btnSubmitDescription.UseVisualStyleBackColor = true;
            btnSubmitDescription.Click += btnSubmitDescription_Click;
            // 
            // lblMileStone
            // 
            lblMileStone.AutoSize = true;
            lblMileStone.Location = new Point(3, 397);
            lblMileStone.Name = "lblMileStone";
            lblMileStone.Size = new Size(278, 25);
            lblMileStone.TabIndex = 12;
            lblMileStone.Text = "Milestone\\Deliverable Description\r\n";
            // 
            // txtMilestoneDescription
            // 
            txtMilestoneDescription.Location = new Point(12, 425);
            txtMilestoneDescription.Multiline = true;
            txtMilestoneDescription.Name = "txtMilestoneDescription";
            txtMilestoneDescription.Size = new Size(559, 126);
            txtMilestoneDescription.TabIndex = 11;
            // 
            // btnEnterAmount
            // 
            btnEnterAmount.Location = new Point(446, 301);
            btnEnterAmount.Name = "btnEnterAmount";
            btnEnterAmount.Size = new Size(112, 60);
            btnEnterAmount.TabIndex = 10;
            btnEnterAmount.Text = "Enter Amount";
            btnEnterAmount.UseVisualStyleBackColor = true;
            btnEnterAmount.Click += btnEnterAmount_Click;
            // 
            // btnSearchParty
            // 
            btnSearchParty.Location = new Point(122, 311);
            btnSearchParty.Name = "btnSearchParty";
            btnSearchParty.Size = new Size(112, 60);
            btnSearchParty.TabIndex = 9;
            btnSearchParty.Text = "Search Party";
            btnSearchParty.UseVisualStyleBackColor = true;
            btnSearchParty.Click += btnSearchParty_Click;
            // 
            // txtValueRewards
            // 
            txtValueRewards.Location = new Point(305, 255);
            txtValueRewards.Name = "txtValueRewards";
            txtValueRewards.Size = new Size(253, 31);
            txtValueRewards.TabIndex = 8;
            // 
            // lblValueCredits
            // 
            lblValueCredits.AutoSize = true;
            lblValueCredits.Location = new Point(345, 212);
            lblValueCredits.Name = "lblValueCredits";
            lblValueCredits.Size = new Size(187, 25);
            lblValueCredits.TabIndex = 7;
            lblValueCredits.Text = "Value\\Rewards Credits";
            // 
            // txtCounterPartyLookUp
            // 
            txtCounterPartyLookUp.Location = new Point(3, 252);
            txtCounterPartyLookUp.Name = "txtCounterPartyLookUp";
            txtCounterPartyLookUp.Size = new Size(236, 31);
            txtCounterPartyLookUp.TabIndex = 6;
            // 
            // lblCounterParty
            // 
            lblCounterParty.AutoSize = true;
            lblCounterParty.Location = new Point(12, 212);
            lblCounterParty.Name = "lblCounterParty";
            lblCounterParty.Size = new Size(184, 25);
            lblCounterParty.TabIndex = 5;
            lblCounterParty.Text = "Counter Party Lookup";
            // 
            // dtpExecution
            // 
            dtpExecution.Location = new Point(276, 136);
            dtpExecution.Name = "dtpExecution";
            dtpExecution.Size = new Size(295, 31);
            dtpExecution.TabIndex = 4;
            // 
            // lblDtOfExec
            // 
            lblDtOfExec.AutoSize = true;
            lblDtOfExec.Location = new Point(320, 95);
            lblDtOfExec.Name = "lblDtOfExec";
            lblDtOfExec.Size = new Size(151, 25);
            lblDtOfExec.TabIndex = 3;
            lblDtOfExec.Text = "Date of Execution\r\n";
            // 
            // cmbTransactType
            // 
            cmbTransactType.FormattingEnabled = true;
            cmbTransactType.Location = new Point(3, 138);
            cmbTransactType.Name = "cmbTransactType";
            cmbTransactType.Size = new Size(231, 33);
            cmbTransactType.TabIndex = 2;
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.Location = new Point(12, 95);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(142, 25);
            lblTransactionType.TabIndex = 1;
            lblTransactionType.Text = "Transaction Type";
            // 
            // lblReputationLinkedTransaction
            // 
            lblReputationLinkedTransaction.AutoSize = true;
            lblReputationLinkedTransaction.Location = new Point(88, 29);
            lblReputationLinkedTransaction.Name = "lblReputationLinkedTransaction";
            lblReputationLinkedTransaction.Size = new Size(247, 25);
            lblReputationLinkedTransaction.TabIndex = 0;
            lblReputationLinkedTransaction.Text = "Reputation Linked Transaction";
            // 
            // pnlSearchCounterParty
            // 
            pnlSearchCounterParty.Controls.Add(lsvScore);
            pnlSearchCounterParty.Controls.Add(lblScore);
            pnlSearchCounterParty.Controls.Add(lblJob);
            pnlSearchCounterParty.Controls.Add(lblName);
            pnlSearchCounterParty.Controls.Add(lblSelectedCounterParty);
            pnlSearchCounterParty.Controls.Add(pictureBox1);
            pnlSearchCounterParty.Location = new Point(648, 95);
            pnlSearchCounterParty.Name = "pnlSearchCounterParty";
            pnlSearchCounterParty.Size = new Size(422, 567);
            pnlSearchCounterParty.TabIndex = 2;
            // 
            // lsvScore
            // 
            lsvScore.Location = new Point(117, 246);
            lsvScore.Name = "lsvScore";
            lsvScore.Size = new Size(182, 146);
            lsvScore.TabIndex = 11;
            lsvScore.UseCompatibleStateImageBehavior = false;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(25, 236);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(56, 25);
            lblScore.TabIndex = 9;
            lblScore.Text = "Score";
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Location = new Point(191, 130);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(77, 25);
            lblJob.TabIndex = 8;
            lblJob.Text = "Job Title";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(191, 58);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 7;
            lblName.Text = "Name";
            // 
            // lblSelectedCounterParty
            // 
            lblSelectedCounterParty.AutoSize = true;
            lblSelectedCounterParty.Location = new Point(25, 14);
            lblSelectedCounterParty.Name = "lblSelectedCounterParty";
            lblSelectedCounterParty.Size = new Size(190, 25);
            lblSelectedCounterParty.TabIndex = 6;
            lblSelectedCounterParty.Text = "Selected Counter Party\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(25, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 106);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnTransactionHistory
            // 
            btnTransactionHistory.Location = new Point(648, 668);
            btnTransactionHistory.Name = "btnTransactionHistory";
            btnTransactionHistory.Size = new Size(431, 58);
            btnTransactionHistory.TabIndex = 3;
            btnTransactionHistory.Text = "Transaction History";
            btnTransactionHistory.UseVisualStyleBackColor = true;
            btnTransactionHistory.Click += btnTransactionHistory_Click;
            // 
            // txtShowInformation
            // 
            txtShowInformation.Location = new Point(1076, 95);
            txtShowInformation.Multiline = true;
            txtShowInformation.Name = "txtShowInformation";
            txtShowInformation.Size = new Size(249, 639);
            txtShowInformation.TabIndex = 4;
            // 
            // UcTransactions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtShowInformation);
            Controls.Add(btnTransactionHistory);
            Controls.Add(pnlSearchCounterParty);
            Controls.Add(pnlReputationLinkedTransactions);
            Controls.Add(pnlHeader);
            Name = "UcTransactions";
            Size = new Size(1472, 737);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlReputationLinkedTransactions.ResumeLayout(false);
            pnlReputationLinkedTransactions.PerformLayout();
            pnlSearchCounterParty.ResumeLayout(false);
            pnlSearchCounterParty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblMakeTransactions;
        private Panel pnlReputationLinkedTransactions;
        private Panel pnlSearchCounterParty;
        private Label lblDtOfExec;
        private ComboBox cmbTransactType;
        private Label lblTransactionType;
        private Label lblReputationLinkedTransaction;
        private DateTimePicker dtpExecution;
        private TextBox txtValueRewards;
        private Label lblValueCredits;
        private TextBox txtCounterPartyLookUp;
        private Label lblCounterParty;
        private Button btnEnterAmount;
        private Button btnSearchParty;
        private Label lblMileStone;
        private TextBox txtMilestoneDescription;
        private Label lblDescription;
        private Button btnSubmitInfo;
        private Button btnClearAll;
        private Button btnSubmitDescription;
        private Label lblSelectedCounterParty;
        private PictureBox pictureBox1;
        private Label lblJob;
        private Label lblName;
        private Label lblScore;
        private ListView lsvScore;
        private Button btnTransactionHistory;
        private TextBox txtShowInformation;
    }
}
