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
    public partial class User_Login : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DEANTECH ADMIN\Desktop\nCode + eProjects\Hospital Management System\Hospital Management System\HMSDatabase.mdf;Integrated Security=True");
        public User_Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Login Page = new Admin_Login();
            Page.Show();
            this.Hide();
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Enter the correct Username or Passowrd");
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from DoctorsTbl where DoctorName'" + txtUsername.Text + "' and DoctorPassword='" + txtPassword.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Doctors Page = new Doctors();
                    Page.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username and Password");
                }
                Con.Close();
            }
        }
    }
}
