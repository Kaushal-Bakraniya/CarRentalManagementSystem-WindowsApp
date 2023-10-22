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
    public partial class Login : Form
    {
        controller log = new controller();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Missing Infomration");
            }
            else
            {
                Boolean status = log.logIn(txtUserName.Text,txtPassword.Text);

                if (status)
                {
                    Main m1 = new Main();

                    m1.Show();

                    this.Hide();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            Signup s1 = new Signup();

            s1.Show();

            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
