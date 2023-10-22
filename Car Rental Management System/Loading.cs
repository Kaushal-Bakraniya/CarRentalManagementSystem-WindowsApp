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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        int start = 0;

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 4;

            Progress.Value = start;

            if (Progress.Value == 100)
            {
                start = 100;

                timer1.Stop();

                Progress.Value = 0;

                Login l1 = new Login();


                l1.Show();

                this.Hide();
            }

            label2.Text = "Loading.. " + start.ToString() + "%";
        }
    }
}
