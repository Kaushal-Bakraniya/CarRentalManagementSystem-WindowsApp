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
    public partial class Main : Form
    {
        controller main = new controller();

        DataTable dt;

        public Main()
        {
            InitializeComponent();
        }

        void count()
        {
            dt = main.getCount("Select Count(*) from cars_tbl where available='No'");

            carsonrent.Text = dt.Rows[0][0].ToString();

            dt = main.getCount("Select Count(*) from customers_tbl");

            totalcustomers.Text = dt.Rows[0][0].ToString();

            dt = main.getCount("Select Count(*) from cars_tbl where available='Yes'");

            availablecars.Text = dt.Rows[0][0].ToString();

            dt = main.getCount("Select Count(*) from cars_tbl");

            totalcars.Text = dt.Rows[0][0].ToString();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            count();
            lblWelcome.Text += " " + controller.uname;
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            controller.logout();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            cars c1 = new cars();

            c1.Show();

            this.Hide();
        }

        private void btnCustomers_Click_1(object sender, EventArgs e)
        {
            customers ct1 = new customers();

            ct1.Show();

            this.Hide();
        }

        private void btnRent_Click_1(object sender, EventArgs e)
        {
            rental r1 = new rental();

            r1.Show();

            this.Hide();
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            returncar rt1 = new returncar();

            rt1.Show();

            this.Hide();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            controller.logout();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            UserProfile u1 = new UserProfile();

            u1.Show();

            this.Hide();
        }
    }
}
