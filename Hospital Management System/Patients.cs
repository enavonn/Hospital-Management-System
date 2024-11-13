using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class Patients : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DEANTECH ADMIN\Desktop\nCode + eProjects\Hospital Management System\Hospital Management System\HMSDatabase.mdf;Integrated Security=True");
        public Patients()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            Doctors obj = new Doctors();
            obj.Show();
            this.Hide();
        }

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            Diagnosis obj = new Diagnosis();
            obj.Show();
            this.Hide();
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            Medicines obj = new Medicines();
            obj.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Admin_Login obj = new Admin_Login();
            obj.Show();
            this.Hide();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from PatientsTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGVPatients.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            txtPatientId.Text = "";
            txtPatientName.Text = "";
            txtPatientAddress.Text = "";
            txtPatientAge.Text = "";
            txtPatientPhone.Text = "";
            txtMajorDisease.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPatientId.Text == "" || txtPatientName.Text == "" || txtPatientAddress.Text == "" || txtPatientPhone.Text == "" || txtPatientAge.Text == "" || txtMajorDisease.Text == "")
                MessageBox.Show("Missing information! See Carefully");
            else
            {
                Con.Open();
                string query = "insert into PatientsTbl values(" + txtPatientId.Text + ",'" + txtPatientName.Text + ",'" + txtPatientAddress.Text+",'" + txtPatientPhone + ",'" + txtPatientAge.Text + ",'" + CbGender.SelectedItem.ToString() + "','" + CbBloodGroup.SelectedItem.ToString() + "','" + txtMajorDisease.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient added Successfully");
                Con.Close();
                populate();
                Reset();
            }
        }

        private void DGVPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPatientId.Text = DGVPatients.SelectedRows[0].Cells[0].Value.ToString();
            txtPatientName.Text = DGVPatients.SelectedRows[0].Cells[0].Value.ToString();
            txtPatientAddress.Text = DGVPatients.SelectedRows[0].Cells[0].Value.ToString();
            txtPatientPhone.Text = DGVPatients.SelectedRows[0].Cells[0].Value.ToString();
            txtPatientAge.Text = DGVPatients.SelectedRows[0].Cells[0].Value.ToString();
            txtMajorDisease.Text = DGVPatients.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update patientsTbl set PatientName = '" + txtPatientName.Text + "',PatientAddress = '" + txtPatientAddress.Text + "',PatientPhone = '" + txtPatientPhone.Text + "',PatientAge = '" + txtPatientAge.Text + "',PatientGender = '" + CbGender.SelectedItem.ToString() + "',PatientBG = '" + CbBloodGroup.SelectedItem.ToString() + "'where PatientId = '" + txtPatientId + "";
            SqlCommand cmd = new SqlCommand(query,Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Updated Successfully");
            Con.Close();
            populate();
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPatientId.Text == "")
                MessageBox.Show("Enter the Patient Id");
            else
            {
                Con.Open();
                string query = "delete from PatientTbl where PatientId= " + txtPatientId.Text + "";
                SqlCommand cmd = new SqlCommand(query,Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Deleted Successfully");
                Con.Close();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
