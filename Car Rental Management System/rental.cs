using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Management_System
{
    public partial class rental : Form
    {
        controller rent = new controller();

        DataSet ds;
        
        public rental()
        {
            InitializeComponent();
        }

        void fillgrid(string query)
        {
            ds = rent.select(query);

            datagrid.DataSource = ds.Tables[0];
        }

        void txtClear()
        {
            txtCustName.Clear();
            txtRent.Clear();
            fillCmb();
            dtRentDate.Value = DateTime.Now;
            dtReturnDate.Value = DateTime.Now;
        }

        private void rental_Load(object sender, EventArgs e)
        {
            cmbFilter.SelectedIndex = 0;            fillgrid("select * from rent_tbl");

            dtRentDate.Value = DateTime.Now;
            dtReturnDate.Value = DateTime.Now;

            fillCmb();

            datagrid.AutoGenerateColumns = false;
            datagrid.Columns.Add(rent.addEdit());
            datagrid.Columns.Add(rent.addDelete());
        }

        void fillData()
        {
            rent.editMode();
            ds = rent.select("select * from rent_tbl where rid = '" + Program.id + "'");
            fillCmb();
            cmbRegno.Text = ds.Tables[0].Rows[0][1].ToString();
            cmbCid.Text = ds.Tables[0].Rows[0][2].ToString();
            txtCustName.Text = ds.Tables[0].Rows[0][3].ToString();
            dtRentDate.Text = ds.Tables[0].Rows[0][4].ToString();
            dtReturnDate.Text = ds.Tables[0].Rows[0][5].ToString();
            txtRent.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        void fillCmb()
        {
            DataTable dt1 = new DataTable();
            dt1 = rent.getData("select reg_no from cars_tbl where available='Yes'","reg_no");

            cmbRegno.ValueMember = "reg_no";
            cmbRegno.DataSource = dt1;

            DataTable dt2 = new DataTable();
            dt2 = rent.getData("select cid from customers_tbl", "cid");

            cmbCid.ValueMember = "cid";
            cmbCid.DataSource = dt2;
        }

        void fillName()
        {
            DataTable dt3 = new DataTable();
            dt3 = rent.getData("select cname from customers_tbl where cid='" + cmbCid.Text + "'", "cname");

            foreach (DataRow dr in dt3.Rows)
            {
                txtCustName.Text = dr["cname"].ToString();
            }
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if(txtCustName.Text == "" || txtRent.Text == "" || cmbRegno.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if(btnControl.Text == "Insert Record")
                {
                    rent.rentCar(cmbRegno.Text, Convert.ToInt32(cmbCid.Text), txtCustName.Text, Convert.ToDateTime(dtRentDate.Text), Convert.ToDateTime(dtReturnDate.Text),txtRent.Text);

                    txtClear();
                    cmbFilter.SelectedIndex = 0;                    fillgrid("select * from rent_tbl");                }

                if (btnControl.Text == "Update Record")
                {
                    rent.updateRentedcar(cmbRegno.Text, Convert.ToInt32(cmbCid.Text), txtCustName.Text, Convert.ToDateTime(dtRentDate.Text), Convert.ToDateTime(dtReturnDate.Text), txtRent.Text);

                    txtClear();

                    cmbFilter.SelectedIndex = 0;
                    fillgrid("select * from rent_tbl");

                    btnControl.Text = "Insert Record";
                }
            }
        }

        private void cmbCid_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillName();
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
            customers ct1 = new customers();

            ct1.Show();

            this.Hide();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {

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

        private void close_Click(object sender, EventArgs e)
        {
            Main m1 = new Main();

            m1.Show();

            this.Hide();
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 8)
            {
                Program.id = Convert.ToInt32(datagrid.Rows[e.RowIndex].Cells["rid"].FormattedValue);
                
                fillData();

                btnControl.Text = "Update Record";
            }

            if (e.ColumnIndex == 9)
            {
                Program.id = Convert.ToInt32(datagrid.Rows[e.RowIndex].Cells["rid"].FormattedValue);

                rent.deleteRentedcar();

                fillCmb();

                cmbFilter.SelectedIndex = 0;
                fillgrid("select * from rent_tbl");
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(cmbFilter.SelectedIndex == 0)
            {
                txtSearch.Clear();
                fillgrid("select * from rent_tbl");
            }
        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            UserProfile up1 = new UserProfile();

            up1.Show();

            this.Hide();
        }
    }
}
