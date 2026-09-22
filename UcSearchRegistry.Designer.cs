namespace user_dashboard
{
    partial class UcSearchRegistry
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            txtSearch = new TextBox();
            dgvResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = Color.FromArgb(140, 140, 150);
            lblTitle.Location = new Point(24, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(252, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Search and view verified professional identities";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(38, 42, 61);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(24, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(320, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.BackgroundColor = Color.FromArgb(26, 30, 46);
            dgvResults.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(38, 42, 61);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 30, 46);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvResults.DefaultCellStyle = dataGridViewCellStyle2;
            dgvResults.EnableHeadersVisualStyles = false;
            dgvResults.Location = new Point(24, 96);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersVisible = false;
            dgvResults.Size = new Size(650, 380);
            dgvResults.TabIndex = 2;
            // 
            // UcSearchRegistry
            // 
            BackColor = Color.FromArgb(15, 18, 32);
            Controls.Add(lblTitle);
            Controls.Add(txtSearch);
            Controls.Add(dgvResults);
            Name = "UcSearchRegistry";
            Size = new Size(720, 500);
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private TextBox txtSearch;
        private DataGridView dgvResults;
    }
}
