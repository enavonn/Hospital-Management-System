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
    public partial class Diagnosis : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DEANTECH ADMIN\Desktop\nCode + eProjects\Hospital Management System\Hospital Management System\HMSDatabase.mdf;Integrated Security=True");
        public Diagnosis()
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

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
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

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            populate();
        }
        void populateId()
        {
            string sql = "Select * from PatientsTbl";
            SqlCommand cmd = new SqlCommand(sql,Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatientId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                CbPatientId.ValueMember = "PatientId";
                CbPatientId.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        string PatientName;
        void FetchPatientName()
        {
            Con.Open();
            string mysql = "select * from PatientsTbl where PatientId = "+ CbPatientId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql,Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                PatientName = dr["PatientName"].ToString();
                txtPatientName.Text = PatientName;
            }
            Con.Close();
        }
        void populate()
        {
            Con.Open();
            string query = "Select * from DiagnosisTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGVDiagnosis.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void CbPatientId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDiagnosisId_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
