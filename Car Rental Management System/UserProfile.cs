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
    public partial class UserProfile : Form
    {
        controller users = new controller();

        DataSet ds;
        public UserProfile()
        {
            InitializeComponent();
        }

        void fillData()
        {
            ds = users.select("select * from users_tbl where username='" + controller.uname + "'");

            lblUname.Text = ds.Tables[0].Rows[0][1].ToString();
            lblGen.Text = ds.Tables[0].Rows[0][3].ToString();
            lblPhone.Text = ds.Tables[0].Rows[0][4].ToString();
            lblCity.Text = ds.Tables[0].Rows[0][5].ToString();
            lblAddress.Text = ds.Tables[0].Rows[0][6].ToString();
        }
      
        private void Users_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            users.deleteUser();
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Main m1 = new Main();

            m1.Show();

            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProfile ep1 = new EditProfile();

            ep1.Show();

            this.Hide();
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Main m1 = new Main();

            m1.Show();

            this.Hide();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            cars c1 = new cars();

            c1.Show();

            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            customers c1 = new customers();

            c1.Show();

            this.Hide();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            rental r1 = new rental();

            r1.Show();

            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            returncar rt1 = new returncar();

            rt1.Show();

            this.Hide();
        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            controller.logout();
        }
    }
}
