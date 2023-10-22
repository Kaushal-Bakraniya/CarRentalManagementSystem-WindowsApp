using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Management_System
{
    public partial class Signup : Form
    {
        controller signup = new controller();

        string gen = null;
        
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            cmbCity.SelectedIndex = 0;
            rdbMale.Checked = true;
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtPassword.Text == "" || rtbAddress.Text == "")
            {
                MessageBox.Show("Missing Infomration");
            }
            else
            {
                Boolean status = signup.addUser(txtUsername.Text, txtPassword.Text, gen, txtPhone.Text, cmbCity.Text, rtbAddress.Text);

                if(status)
                {
                    Login l1 = new Login();

                    l1.Show();

                    this.Hide();
                }
            }
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            gen = "Male";
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            gen = "Female";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rtbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();

            l1.Show();

            this.Hide();
        }
    }
}
