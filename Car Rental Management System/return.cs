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
    public partial class returncar : Form
    {
        controller rtr = new controller();

        DataSet ds;

        int cid = 0;

        public returncar()
        {
            InitializeComponent();
        }

        void fillgrid(string query)
        {
            ds = rtr.select(query);

            datagrid.DataSource = ds.Tables[0];
        }

        void fillCmb()
        {
            DataTable dt1 = new DataTable();
            dt1 = rtr.getData("select DISTINCT reg_no from rent_tbl", "reg_no");

            cmbRegno.ValueMember = "reg_no";
            cmbRegno.DataSource = dt1;
        }

        void getData()
        {
            ds = rtr.select("select * from rent_tbl where reg_no = '" + cmbRegno.Text + "'");

            txtCustName.Text = ds.Tables[0].Rows[0][3].ToString();
            cid = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString()); 
            dtRentDate.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][4].ToString());
            dtReturnDate.Value = DateTime.Now;

            DateTime dt1 = Convert.ToDateTime(ds.Tables[0].Rows[0][5].ToString());

            TimeSpan tm1 = dtReturnDate.Value - dt1;

            if((tm1.TotalDays - 1) <= 0)
            {
                txtDelay.Text = "0";
                txtFine.Text = "0";
                txtTotal.Text = ds.Tables[0].Rows[0][6].ToString();
            }
            else
            {
                txtDelay.Text = Convert.ToInt32(tm1.TotalDays - 1).ToString();
                txtFine.Text = (Convert.ToInt32(tm1.TotalDays - 1) * 300).ToString();
                txtTotal.Text = (Convert.ToInt32(ds.Tables[0].Rows[0][6]) + Convert.ToInt32(txtFine.Text)).ToString();
            }
        }

        private void return_Load(object sender, EventArgs e)
        {
            fillCmb();
            fillgrid("select * from return_tbl order by rtid DESC");

            datagrid.AutoGenerateColumns = false;
            datagrid.Columns.Add(rtr.addDelete());
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if(cmbRegno.Text == "" || txtCustName.Text == "" || txtDelay.Text == "" || txtFine.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if(btnControl.Text == "Insert Record")
                {
                    rtr.returnCar(cmbRegno.Text, txtCustName.Text, cid, Convert.ToDateTime(dtRentDate.Text), Convert.ToDateTime(dtRentDate.Text), txtFine.Text, txtTotal.Text);

                    fillCmb();

                    fillgrid("select * from return_tbl order by rtid DESC");
                }
            }
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                Program.id = Convert.ToInt32(datagrid.Rows[e.RowIndex].Cells["rtid"].FormattedValue);

                rtr.deleteReturnrdCar();

                fillCmb();

                fillgrid("select * from return_tbl order by rtid DESC");
            }
        }

        private void txtDelay_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("YOU CAN'T ENTER VALUES MANUALLY IN THIS FIELD (YOU CAN ONLY EDIT TOTAL CHARGES)");
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

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            controller.logout();
        }

        private void cmbRegno_SelectedIndexChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void txtDelay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDelay_KeyUp(object sender, EventArgs e)
        {

        }

        private void dtRentDate_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fillgrid("select * from return_tbl where reg_no = '" + txtSearch.Text + "'");
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFilter.SelectedIndex == 0)
            {
                txtSearch.Clear();
                fillgrid("select * from return_tbl");
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
