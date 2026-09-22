using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _1September
{
    public partial class UcQualifications : UserControl
    {
        public UcQualifications()
        {
            InitializeComponent();
            this.Load += UcQualifications_Load;
        }

        private void UcQualifications_Load(object sender, EventArgs e)
        {
            SetUpDataGridView();
            LoadQualifications();

        }

        void SetUpDataGridView()
        {
            dgvQualifications.Columns.Clear();
            dgvQualifications.Columns.Add("QualName", "Qualification");
            dgvQualifications.Columns.Add("InstitutionName", "Institution");
            dgvQualifications.Columns.Add("Year", "Year");
            dgvQualifications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void LoadQualifications()
        {
            try
            {
                dgvQualifications.Rows.Clear();
                string path = Path.Combine(Application.StartupPath, "qualifications.txt");
                if (!File.Exists(path)) File.Create(path).Close();

                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length >= 6)
                    {
                        string cell = parts[2];
                        if (Program.CurrentUser != null && cell == Program.CurrentUser.CellNumber)
                        {
                            dgvQualifications.Rows.Add(parts[3], parts[4], parts[5]);
                        }

                    }
                }

            }


            catch (Exception ex)
            {

                MessageBox.Show("Error loading qualifications: " + ex.Message);
                return;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser == null)
            {
                MessageBox.Show("Please log in to upload qualifications.");
                return;
            }
            if (string.IsNullOrEmpty(txtQualification.Text))
            {
                MessageBox.Show("PLease enter a qualification");
                txtQualification.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtInstituition.Text))
            {
                MessageBox.Show("Please enter an institution name");
                txtInstituition.Focus();
                return;
            }
            Qualifications qualifications = new Qualifications($"{Program.CurrentUser.Name}|{Program.CurrentUser.SecondName}", Program.CurrentUser.Email, Program.CurrentUser.CellNumber, txtQualification.Text, txtInstituition.Text, txtYearObtained.Text);
            dgvQualifications.Rows.Add(qualifications.QualificationName, qualifications.InstitutionName, qualifications.Year);
            SaveToTxTFile(qualifications);
            txtQualification.Clear();
            txtInstituition.Clear();
            txtInstituition.Focus();
            txtQualification.Focus();

            MessageBox.Show("Qualification uploaded successfully."); return;


        }
      private  void SaveToTxTFile(Qualifications qualifications)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "qualifications.txt");
                if (!File.Exists(path)) File.Create(path).Close();

                File.AppendAllText(path,qualifications.ToString()+Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error savingf " + ex.Message);
                return;
            }

        }
    }
}


        