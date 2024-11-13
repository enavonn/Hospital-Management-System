using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtPassword.Text =="")
            {
                MessageBox.Show("Enter Username and Password");
            }
            else if(txtUsername.Text == "Admin" && txtPassword.Text == "Password")
            {
                Doctors obj = new Doctors();
                obj.Show();
                this.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }

        private void lblUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User_Login Page = new User_Login();
            Page.Show();
            this.Hide();
        }
    }
}
