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
    public partial class Medicines : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DEANTECH ADMIN\Desktop\nCode + eProjects\Hospital Management System\Hospital Management System\HMSDatabase.mdf;Integrated Security=True");
        public Medicines()
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

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            Diagnosis obj = new Diagnosis();
            obj.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Admin_Login obj = new Admin_Login();
            obj.Show();
            this.Hide();
        }

        private void DGVMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMedicineId.Text = DGVMedicine.SelectedRows[0].Cells[0].Value.ToString();
            txtMedicineName.Text = DGVMedicine.SelectedRows[0].Cells[0].Value.ToString();
            txtMedicineType.Text = DGVMedicine.SelectedRows[0].Cells[0].Value.ToString();
            txtByDoctor.Text = DGVMedicine.SelectedRows[0].Cells[0].Value.ToString();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from MedicineTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGVMedicine.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            txtMedicineId.Text = "";
            txtMedicineName.Text = "";
            txtMedicineType.Text = "";
            txtByDoctor.Text = "";

        }
        

        private void Medicines_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMedicineId.Text == "" || txtMedicineName.Text == "" || txtMedicineType.Text == "" || txtByDoctor.Text == "")
                MessageBox.Show("Missing Information! Fill all Details Carefully");
            else
            {
                Con.Open();
                string query = "insert into MedicineTbl values(" + txtMedicineId.Text + ",'" + txtMedicineName.Text + "','" + txtMedicineType.Text + "','" + txtByDoctor.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Added Successfully");
                Con.Close();
                populate();
                Reset();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update MedicineTbl set MedicineName = '" + txtMedicineName.Text + "',MedicineType = '" + txtMedicineType.Text + "',ByDoctor = '" + txtByDoctor.Text + "' where MedicineId = " + txtMedicineId.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Updated Successfully");
            Con.Close();
            populate();
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMedicineId.Text == "")
                MessageBox.Show("Enter the Doctor Id");
            else
            {
                Con.Open();
                string query = "Delete from MedicineTbl where MedicineId=" + txtMedicineId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Deleted Successfully");
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
