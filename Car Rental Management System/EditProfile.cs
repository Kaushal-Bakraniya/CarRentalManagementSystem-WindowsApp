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
    public partial class EditProfile : Form
    {
        controller users = new controller();

        public static string gender;

        DataSet ds;
        public EditProfile()
        {
            InitializeComponent();
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("YOU CAN NOT CHANGE YOUR UNIQUE USERNAME");
        }
        void fillData()
        {
            ds = users.select("select * from users_tbl where username='" + controller.uname + "'");

            txtUsername.Text = ds.Tables[0].Rows[0][1].ToString();
            
            if(ds.Tables[0].Rows[0][3].ToString() == "Male")
            {
                rdbml.Checked = true;
            }
            
            if (ds.Tables[0].Rows[0][3].ToString() == "Female")
            {
                rdbfml.Checked = true;
            }

            txtPhone.Text = ds.Tables[0].Rows[0][4].ToString();
            cmbCity.Text = ds.Tables[0].Rows[0][5].ToString();
            rtbAddress.Text = ds.Tables[0].Rows[0][6].ToString();
            txtPassword.Text = ds.Tables[0].Rows[0][2].ToString();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void close_Click(object sender, EventArgs e)
        {
            UserProfile up1 = new UserProfile();

            up1.Show();

            this.Hide();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            Boolean status = users.editUser(txtPassword.Text, gender, txtPhone.Text, cmbCity.SelectedItem.ToString(), rtbAddress.Text);
            
            if(status)
            {
                UserProfile up1 = new UserProfile();

                up1.Show();

                this.Hide();
            }
        }

        private void rdbml_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void rdbfml_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
    }
}
