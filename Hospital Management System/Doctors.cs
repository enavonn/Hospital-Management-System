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
    public partial class Doctors : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DEANTECH ADMIN\Desktop\nCode + eProjects\Hospital Management System\Hospital Management System\HMSDatabase.mdf;Integrated Security=True");
        public Doctors()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Admin_Login obj = new Admin_Login();
            obj.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
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

        void populate()
        {
            Con.Open();
            string query = "select * from DoctorsTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGVDoctors.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            txtDoctorId.Text = "";
            txtDoctorName.Text = "";
            txtYearsofExperience.Text = "";
            txtPassword.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDoctorId.Text == "" || txtDoctorName.Text == "" || txtYearsofExperience.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Missing Information! Fill all Details Carefully");
            else
            {
                Con.Open();
                string query = "insert into DoctorsTbl values(" + txtDoctorId.Text + ",'" + txtDoctorName.Text + "'," + txtYearsofExperience.Text + ",'" + txtPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Added Successfully");
                Con.Close();
                populate();
                Reset();
            }
        }

        private void DGVDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDoctorId.Text = DGVDoctors.SelectedRows[0].Cells[0].Value.ToString();
            txtDoctorName.Text = DGVDoctors.SelectedRows[0].Cells[0].Value.ToString();
            txtYearsofExperience.Text = DGVDoctors.SelectedRows[0].Cells[0].Value.ToString();
            txtPassword.Text = DGVDoctors.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DoctorsTbl set DoctorName = '"+txtDoctorName.Text +"',DoctorExp = '"+txtYearsofExperience.Text+"',DoctorPassword = '"+ txtPassword.Text+"' where DoctorId = "+txtDoctorId.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Updated Successfully");
            Con.Close();
            populate();
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                if (txtDoctorId.Text == "")
                    MessageBox.Show("Enter the Doctor Id");
                else
                {
                    Con.Open();
                    string query = "Delete from DoctorTbl where DoctorId=" + txtDoctorId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Deleted Successfully");
                    Con.Close();
                    populate();
                    Reset();
                }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
