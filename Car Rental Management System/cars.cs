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
    public partial class cars : Form
    {
        controller car = new controller();

        DataSet ds;

        public static string status = null;

        public cars()
        {
            InitializeComponent();
        }

        void txtClear()
        {
            txtRegno.Clear();
            txtPrice.Clear();
            txtModel.Clear();
            txtBrand.Clear();
            rdbYes.Checked = true;
            cmbFilter.SelectedIndex = 0;
            txtSearch.Clear();
        }

        void fillgrid(string query)
        {
            ds = car.select(query);

            cars_list.DataSource = ds.Tables[0];
        }

        void fillData()
        {
            ds = car.select("select * from cars_tbl where reg_no = '" + Program.regNum + "'");

            txtRegno.Text = ds.Tables[0].Rows[0][0].ToString();

            txtBrand.Text = ds.Tables[0].Rows[0][1].ToString();

            txtModel.Text = ds.Tables[0].Rows[0][2].ToString();

            if (ds.Tables[0].Rows[0][3].ToString() == "Yes")
            {
                rdbYes.Checked = true;
            }

            if (ds.Tables[0].Rows[0][3].ToString() == "No")
            {
                rdbNo.Checked = true;
            }

            txtPrice.Text = ds.Tables[0].Rows[0][4].ToString();
        }

        private void rdbYes_CheckedChanged(object sender, EventArgs e)
        {
            status = "Yes";
        }

        private void rdbNo_CheckedChanged(object sender, EventArgs e)
        {
            status = "No";
        }

        private void cars_Load(object sender, EventArgs e)
        {
            cmbFilter.SelectedIndex = 0;
            fillgrid("select * from cars_tbl");

            cars_list.AutoGenerateColumns = false;
            cars_list.Columns.Add(car.addEdit());
            cars_list.Columns.Add(car.addDelete());
        }

        private void cars_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Program.regNum = cars_list.Rows[e.RowIndex].Cells["reg_no"].FormattedValue.ToString();

                btnControl.Text = "Update Record";

                fillData();
            }

            if (e.ColumnIndex == 6)
            {
                Program.regNum = cars_list.Rows[e.RowIndex].Cells["reg_no"].FormattedValue.ToString();

                car.deleteCar();

                fillgrid("select * from cars_tbl");
            }
        }


        private void btnControl_Click(object sender, EventArgs e)
        {
            if (txtRegno.Text == "" || txtBrand.Text == "" || txtModel.Text == "" || txtPrice.Text == "" || status == null)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (btnControl.Text == "Insert Record")
                {
                    car.insertCar(txtRegno.Text, txtBrand.Text, txtModel.Text, status, txtPrice.Text);

                    fillgrid("select * from cars_tbl");

                    txtClear();
                }

                if (btnControl.Text == "Update Record")
                {
                    car.updateCar(txtRegno.Text, txtBrand.Text, txtModel.Text, status, txtPrice.Text);

                    fillgrid("select * from cars_tbl");

                    txtClear();

                    btnControl.Text = "Insert Record";
                }
            }
        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            Main m1 = new Main();

            m1.Show();

            this.Hide();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click_1(object sender, EventArgs e)
        {
            customers c1 = new customers();

            c1.Show();

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
            returncar r1 = new returncar();

            r1.Show();

            this.Hide();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            controller.logout();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Main m1 = new Main();

            m1.Show();

            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fillgrid("select * from cars_tbl where reg_no='" + txtSearch.Text + "'");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            if (cmbFilter.SelectedIndex == 0)
            {
                fillgrid("select * from cars_tbl");
            }

            if (cmbFilter.SelectedIndex == 1)
            {
                fillgrid("select * from cars_tbl where available='Yes'");
            }

            if (cmbFilter.SelectedIndex == 2)
            {
                fillgrid("select * from cars_tbl where available='No'");
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
