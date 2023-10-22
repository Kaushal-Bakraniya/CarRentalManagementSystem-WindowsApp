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
    public partial class customers : Form
    {
        controller cust = new controller();

        DataSet ds;

        public static string gen = null;

        public customers()
        {
            InitializeComponent();
        }

        private void customers_Load(object sender, EventArgs e)
        {
            cmbFilter.SelectedIndex = 0;
            fillgrid("select * from customers_tbl");
            cmbCity.SelectedIndex = 0;

            customers_list.AutoGenerateColumns = false;
            customers_list.Columns.Add(cust.addEdit());
            customers_list.Columns.Add(cust.addDelete());
        }

        void fillgrid(string query)
        {
            ds = cust.select(query);

            customers_list.DataSource = ds.Tables[0];
        }

        void fillData()
        {
            ds = cust.select("select * from customers_tbl where cid='" + Program.id + "'");

            txtCustname.Text = ds.Tables[0].Rows[0][1].ToString();

            if(ds.Tables[0].Rows[0][2].ToString() == "Male")
            {
                rdbMale.Checked = true;
            }

            if (ds.Tables[0].Rows[0][2].ToString() == "Female")
            {
                rdbFemale.Checked = true;
            }

            txtPhone.Text = ds.Tables[0].Rows[0][3].ToString();

            cmbCity.SelectedItem = ds.Tables[0].Rows[0][4].ToString();

            rtbAddress.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        void txtClear()
        {
            txtCustname.Clear();

            rdbMale.Checked = true;

            txtPhone.Clear();

            cmbCity.SelectedIndex = 0;

            rtbAddress.Clear();

            txtSearch.Clear();

            cmbFilter.SelectedIndex = 0;
        }

        private void btnControl_Click_1(object sender, EventArgs e)
        {
            if (txtPhone.Text == "" || txtPhone.Text == "" || cmbCity.SelectedItem.ToString() == "" || rtbAddress.Text == "" || gen == null)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                if (btnControl.Text == "Insert Record")
                {
                    cust.insertCustomer(txtCustname.Text, gen, txtPhone.Text, cmbCity.SelectedItem.ToString(), rtbAddress.Text);

                    fillgrid("select * from customers_tbl");
                    
                    txtClear();
                }

                if (btnControl.Text == "Update Record")
                {
                    cust.updateCustomer(txtCustname.Text, gen, txtPhone.Text, cmbCity.SelectedItem.ToString(), rtbAddress.Text);

                    fillgrid("select * from customers_tbl");
                    
                    txtClear();

                    btnControl.Text = "Insert Record";
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

        private void customers_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                Program.id = Convert.ToInt32(customers_list.Rows[e.RowIndex].Cells["cid"].FormattedValue);

                btnControl.Text = "Update Record";

                fillData();
            }

            if (e.ColumnIndex == 7)
            {
                Program.id = Convert.ToInt32(customers_list.Rows[e.RowIndex].Cells["cid"].FormattedValue);

                cust.deleteCustomer();

                fillgrid("select * from customers_tbl");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Main m1 = new Main();

            m1.Show();

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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            controller.logout();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fillgrid("select * from customers_tbl where cname='"+txtSearch.Text+"'");
        }

        private void cmbFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtSearch.Clear();

            fillgrid("select * from customers_tbl");
        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            UserProfile up1 = new UserProfile();

            up1.Show();

            this.Hide();
        }
    }
}
