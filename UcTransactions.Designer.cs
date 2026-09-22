namespace user_dashboard
{
    partial class UcTransactions
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNewTransactionTitle = new Label();
            lblTransactType = new Label();
            cmbTransactType = new ComboBox();
            lblExecutionDate = new Label();
            dtpExecution = new DateTimePicker();
            lblDtOfExec = new Label();
            lblCounterParty = new Label();
            txtCounterPartyLookUp = new TextBox();
            btnSearchParty = new Button();
            lblName = new Label();
            lblJob = new Label();
            lblAmountTitle = new Label();
            txtValueRewards = new TextBox();
            btnEnterAmount = new Button();
            lblDescriptionTitle = new Label();
            txtMilestoneDescription = new TextBox();
            btnSubmitDescription = new Button();
            btnSubmitInfo = new Button();
            btnClearAll = new Button();
            btnTransactionHistory = new Button();
            txtShowInformation = new TextBox();
            pnlSearchCounterParty = new Panel();
            lblDescription = new Label();
            lsvScore = new ListView();
            lblScore = new Label();
            pnlReputationLinkedTransactions = new Panel();
            pnlSearchCounterParty.SuspendLayout();
            pnlReputationLinkedTransactions.SuspendLayout();
            SuspendLayout();
            // 
            // lblNewTransactionTitle
            // 
            lblNewTransactionTitle.AutoSize = true;
            lblNewTransactionTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblNewTransactionTitle.ForeColor = Color.White;
            lblNewTransactionTitle.Location = new Point(20, 0);
            lblNewTransactionTitle.Name = "lblNewTransactionTitle";
            lblNewTransactionTitle.Size = new Size(183, 19);
            lblNewTransactionTitle.TabIndex = 0;
            lblNewTransactionTitle.Text = "Record a New Transaction";
            // 
            // lblTransactType
            // 
            lblTransactType.AutoSize = true;
            lblTransactType.ForeColor = Color.FromArgb(140, 140, 150);
            lblTransactType.Location = new Point(20, 34);
            lblTransactType.Name = "lblTransactType";
            lblTransactType.Size = new Size(96, 15);
            lblTransactType.TabIndex = 1;
            lblTransactType.Text = "Transaction Type";
            // 
            // cmbTransactType
            // 
            cmbTransactType.BackColor = Color.FromArgb(38, 42, 61);
            cmbTransactType.ForeColor = Color.White;
            cmbTransactType.Location = new Point(20, 55);
            cmbTransactType.Name = "cmbTransactType";
            cmbTransactType.Size = new Size(220, 23);
            cmbTransactType.TabIndex = 2;
            cmbTransactType.SelectedIndexChanged += cmbTransactType_SelectedIndexChanged;
            // 
            // lblExecutionDate
            // 
            lblExecutionDate.AutoSize = true;
            lblExecutionDate.ForeColor = Color.FromArgb(140, 140, 150);
            lblExecutionDate.Location = new Point(270, 34);
            lblExecutionDate.Name = "lblExecutionDate";
            lblExecutionDate.Size = new Size(85, 15);
            lblExecutionDate.TabIndex = 3;
            lblExecutionDate.Text = "Execution Date";
            // 
            // dtpExecution
            // 
            dtpExecution.Format = DateTimePickerFormat.Short;
            dtpExecution.Location = new Point(270, 52);
            dtpExecution.Name = "dtpExecution";
            dtpExecution.Size = new Size(150, 23);
            dtpExecution.TabIndex = 4;
            dtpExecution.ValueChanged += dtpExecution_ValueChanged;
            // 
            // lblDtOfExec
            // 
            lblDtOfExec.AutoSize = true;
            lblDtOfExec.ForeColor = Color.FromArgb(140, 140, 150);
            lblDtOfExec.Location = new Point(240, 78);
            lblDtOfExec.Name = "lblDtOfExec";
            lblDtOfExec.Size = new Size(0, 15);
            lblDtOfExec.TabIndex = 5;
            // 
            // lblCounterParty
            // 
            lblCounterParty.AutoSize = true;
            lblCounterParty.ForeColor = Color.White;
            lblCounterParty.Location = new Point(10, 8);
            lblCounterParty.Name = "lblCounterParty";
            lblCounterParty.Size = new Size(80, 15);
            lblCounterParty.TabIndex = 0;
            lblCounterParty.Text = "Counter Party";
            // 
            // txtCounterPartyLookUp
            // 
            txtCounterPartyLookUp.BackColor = Color.FromArgb(38, 42, 61);
            txtCounterPartyLookUp.ForeColor = Color.White;
            txtCounterPartyLookUp.Location = new Point(10, 30);
            txtCounterPartyLookUp.Name = "txtCounterPartyLookUp";
            txtCounterPartyLookUp.Size = new Size(230, 23);
            txtCounterPartyLookUp.TabIndex = 1;
            // 
            // btnSearchParty
            // 
            btnSearchParty.BackColor = Color.FromArgb(0, 220, 210);
            btnSearchParty.FlatAppearance.BorderSize = 0;
            btnSearchParty.FlatStyle = FlatStyle.Flat;
            btnSearchParty.ForeColor = Color.FromArgb(15, 18, 32);
            btnSearchParty.Location = new Point(250, 30);
            btnSearchParty.Name = "btnSearchParty";
            btnSearchParty.Size = new Size(80, 23);
            btnSearchParty.TabIndex = 2;
            btnSearchParty.Text = "Search";
            btnSearchParty.UseVisualStyleBackColor = false;
            btnSearchParty.Click += btnSearchParty_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(10, 65);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 15);
            lblName.TabIndex = 3;
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.ForeColor = Color.FromArgb(140, 140, 150);
            lblJob.Location = new Point(10, 88);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(0, 15);
            lblJob.TabIndex = 4;
            // 
            // lblAmountTitle
            // 
            lblAmountTitle.AutoSize = true;
            lblAmountTitle.ForeColor = Color.FromArgb(140, 140, 150);
            lblAmountTitle.Location = new Point(440, 250);
            lblAmountTitle.Name = "lblAmountTitle";
            lblAmountTitle.Size = new Size(51, 15);
            lblAmountTitle.TabIndex = 7;
            lblAmountTitle.Text = "Amount";
            // 
            // txtValueRewards
            // 
            txtValueRewards.BackColor = Color.FromArgb(38, 42, 61);
            txtValueRewards.ForeColor = Color.White;
            txtValueRewards.Location = new Point(440, 268);
            txtValueRewards.Name = "txtValueRewards";
            txtValueRewards.Size = new Size(150, 23);
            txtValueRewards.TabIndex = 8;
            // 
            // btnEnterAmount
            // 
            btnEnterAmount.BackColor = Color.Cyan;
            btnEnterAmount.FlatAppearance.BorderSize = 0;
            btnEnterAmount.FlatStyle = FlatStyle.Flat;
            btnEnterAmount.ForeColor = Color.FromArgb(15, 18, 32);
            btnEnterAmount.Location = new Point(440, 297);
            btnEnterAmount.Name = "btnEnterAmount";
            btnEnterAmount.Size = new Size(150, 25);
            btnEnterAmount.TabIndex = 9;
            btnEnterAmount.Text = "Confirm Amount";
            btnEnterAmount.UseVisualStyleBackColor = false;
            btnEnterAmount.Click += btnEnterAmount_Click;
            // 
            // lblDescriptionTitle
            // 
            lblDescriptionTitle.AutoSize = true;
            lblDescriptionTitle.ForeColor = Color.FromArgb(140, 140, 150);
            lblDescriptionTitle.Location = new Point(20, 250);
            lblDescriptionTitle.Name = "lblDescriptionTitle";
            lblDescriptionTitle.Size = new Size(122, 15);
            lblDescriptionTitle.TabIndex = 10;
            lblDescriptionTitle.Text = "Milestone Description";
            // 
            // txtMilestoneDescription
            // 
            txtMilestoneDescription.BackColor = Color.FromArgb(38, 42, 61);
            txtMilestoneDescription.ForeColor = Color.White;
            txtMilestoneDescription.Location = new Point(20, 268);
            txtMilestoneDescription.Multiline = true;
            txtMilestoneDescription.Name = "txtMilestoneDescription";
            txtMilestoneDescription.Size = new Size(380, 60);
            txtMilestoneDescription.TabIndex = 11;
            // 
            // btnSubmitDescription
            // 
            btnSubmitDescription.BackColor = Color.FromArgb(38, 42, 61);
            btnSubmitDescription.FlatAppearance.BorderSize = 0;
            btnSubmitDescription.FlatStyle = FlatStyle.Flat;
            btnSubmitDescription.ForeColor = Color.White;
            btnSubmitDescription.Location = new Point(20, 350);
            btnSubmitDescription.Name = "btnSubmitDescription";
            btnSubmitDescription.Size = new Size(160, 25);
            btnSubmitDescription.TabIndex = 12;
            btnSubmitDescription.Text = "Set Description";
            btnSubmitDescription.UseVisualStyleBackColor = false;
            btnSubmitDescription.Click += btnSubmitDescription_Click;
            // 
            // btnSubmitInfo
            // 
            btnSubmitInfo.BackColor = Color.FromArgb(0, 220, 210);
            btnSubmitInfo.FlatAppearance.BorderSize = 0;
            btnSubmitInfo.FlatStyle = FlatStyle.Flat;
            btnSubmitInfo.ForeColor = Color.FromArgb(15, 18, 32);
            btnSubmitInfo.Location = new Point(20, 381);
            btnSubmitInfo.Name = "btnSubmitInfo";
            btnSubmitInfo.Size = new Size(160, 30);
            btnSubmitInfo.TabIndex = 15;
            btnSubmitInfo.Text = "Submit Transaction";
            btnSubmitInfo.UseVisualStyleBackColor = false;
            btnSubmitInfo.Click += btnSubmitInfo_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = Color.FromArgb(38, 42, 61);
            btnClearAll.FlatAppearance.BorderSize = 0;
            btnClearAll.FlatStyle = FlatStyle.Flat;
            btnClearAll.ForeColor = Color.White;
            btnClearAll.Location = new Point(201, 381);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(100, 30);
            btnClearAll.TabIndex = 16;
            btnClearAll.Text = "Clear All";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnTransactionHistory
            // 
            btnTransactionHistory.BackColor = Color.FromArgb(38, 42, 61);
            btnTransactionHistory.FlatAppearance.BorderSize = 0;
            btnTransactionHistory.FlatStyle = FlatStyle.Flat;
            btnTransactionHistory.ForeColor = Color.White;
            btnTransactionHistory.Location = new Point(330, 381);
            btnTransactionHistory.Name = "btnTransactionHistory";
            btnTransactionHistory.Size = new Size(120, 30);
            btnTransactionHistory.TabIndex = 17;
            btnTransactionHistory.Text = "View History";
            btnTransactionHistory.UseVisualStyleBackColor = false;
            btnTransactionHistory.Click += btnTransactionHistory_Click;
            // 
            // txtShowInformation
            // 
            txtShowInformation.BackColor = Color.FromArgb(38, 42, 61);
            txtShowInformation.ForeColor = Color.White;
            txtShowInformation.Location = new Point(20, 417);
            txtShowInformation.Multiline = true;
            txtShowInformation.Name = "txtShowInformation";
            txtShowInformation.ScrollBars = ScrollBars.Vertical;
            txtShowInformation.Size = new Size(700, 80);
            txtShowInformation.TabIndex = 18;
            // 
            // pnlSearchCounterParty
            // 
            pnlSearchCounterParty.BackColor = Color.FromArgb(26, 30, 46);
            pnlSearchCounterParty.BorderStyle = BorderStyle.Fixed3D;
            pnlSearchCounterParty.Controls.Add(lblCounterParty);
            pnlSearchCounterParty.Controls.Add(txtCounterPartyLookUp);
            pnlSearchCounterParty.Controls.Add(btnSearchParty);
            pnlSearchCounterParty.Controls.Add(lblName);
            pnlSearchCounterParty.Controls.Add(lblJob);
            pnlSearchCounterParty.Location = new Point(20, 100);
            pnlSearchCounterParty.Name = "pnlSearchCounterParty";
            pnlSearchCounterParty.Size = new Size(400, 130);
            pnlSearchCounterParty.TabIndex = 6;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.FromArgb(38, 42, 61);
            lblDescription.ForeColor = Color.FromArgb(140, 140, 150);
            lblDescription.Location = new Point(472, 371);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(248, 40);
            lblDescription.TabIndex = 13;
            // 
            // lsvScore
            // 
            lsvScore.BackColor = Color.FromArgb(38, 42, 61);
            lsvScore.ForeColor = Color.White;
            lsvScore.Location = new Point(10, 65);
            lsvScore.Name = "lsvScore";
            lsvScore.Size = new Size(260, 40);
            lsvScore.TabIndex = 1;
            lsvScore.UseCompatibleStateImageBehavior = false;
            lsvScore.SelectedIndexChanged += lsvScore_SelectedIndexChanged;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblScore.ForeColor = Color.FromArgb(0, 220, 210);
            lblScore.Location = new Point(10, 10);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(0, 25);
            lblScore.TabIndex = 0;
            // 
            // pnlReputationLinkedTransactions
            // 
            pnlReputationLinkedTransactions.BackColor = Color.FromArgb(26, 30, 46);
            pnlReputationLinkedTransactions.BorderStyle = BorderStyle.Fixed3D;
            pnlReputationLinkedTransactions.Controls.Add(lblScore);
            pnlReputationLinkedTransactions.Controls.Add(lsvScore);
            pnlReputationLinkedTransactions.Location = new Point(440, 100);
            pnlReputationLinkedTransactions.Name = "pnlReputationLinkedTransactions";
            pnlReputationLinkedTransactions.Size = new Size(280, 130);
            pnlReputationLinkedTransactions.TabIndex = 14;
            // 
            // UcTransactions
            // 
            BackColor = Color.FromArgb(15, 18, 32);
            Controls.Add(lblNewTransactionTitle);
            Controls.Add(lblTransactType);
            Controls.Add(cmbTransactType);
            Controls.Add(lblExecutionDate);
            Controls.Add(dtpExecution);
            Controls.Add(lblDtOfExec);
            Controls.Add(pnlSearchCounterParty);
            Controls.Add(lblAmountTitle);
            Controls.Add(txtValueRewards);
            Controls.Add(btnEnterAmount);
            Controls.Add(lblDescriptionTitle);
            Controls.Add(txtMilestoneDescription);
            Controls.Add(btnSubmitDescription);
            Controls.Add(lblDescription);
            Controls.Add(pnlReputationLinkedTransactions);
            Controls.Add(btnSubmitInfo);
            Controls.Add(btnClearAll);
            Controls.Add(btnTransactionHistory);
            Controls.Add(txtShowInformation);
            Name = "UcTransactions";
            Size = new Size(918, 522);
            pnlSearchCounterParty.ResumeLayout(false);
            pnlSearchCounterParty.PerformLayout();
            pnlReputationLinkedTransactions.ResumeLayout(false);
            pnlReputationLinkedTransactions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblNewTransactionTitle;
        private Label lblTransactType;
        private ComboBox cmbTransactType;
        private Label lblExecutionDate;
        private DateTimePicker dtpExecution;
        private Label lblDtOfExec;
        private Label lblCounterParty;
        private TextBox txtCounterPartyLookUp;
        private Button btnSearchParty;
        private Label lblName;
        private Label lblJob;
        private Label lblAmountTitle;
        private TextBox txtValueRewards;
        private Button btnEnterAmount;
        private Label lblDescriptionTitle;
        private TextBox txtMilestoneDescription;
        private Button btnSubmitDescription;
        private Button btnSubmitInfo;
        private Button btnClearAll;
        private Button btnTransactionHistory;
        private TextBox txtShowInformation;
        private Panel pnlSearchCounterParty;
        private Label lblDescription;
        private ListView lsvScore;
        private Label lblScore;
        private Panel pnlReputationLinkedTransactions;
    }
}
