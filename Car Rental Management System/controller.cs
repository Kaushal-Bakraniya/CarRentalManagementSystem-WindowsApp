using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Management_System
{
    class controller
    {
        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|CRMS_DB.mdf;Integrated Security=True";

        public static string uname;

        SqlConnection con;

        SqlCommand cmd;

        SqlDataAdapter da;

        DataSet ds;

        public controller()
        {
            getCon();
        }

        void getCon()
        {
            con = new SqlConnection(s);

            con.Open();
        }

        public static void logout()
        {
            DialogResult d = MessageBox.Show("Are you sure you want to logout ?", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        public DataSet select(string query)
        {
            da = new SqlDataAdapter(query,con);

            ds = new DataSet();

            da.Fill(ds);

            return ds;
        }
        public DataTable getData(string query,string field)
        {
            DataTable dt = new DataTable();

            try
            {
                da = new SqlDataAdapter(query, con);

                dt.Columns.Add(field, typeof(string));

                da.Fill(dt);

                return dt;
            }
            catch(Exception)
            {
                return dt;
            }
        }
        public DataTable getCount(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                da = new SqlDataAdapter(query, con);

                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }

        public DataGridViewButtonColumn addEdit()
        {
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn();

            edit.FlatStyle = FlatStyle.Popup;
            edit.HeaderText = "Edit";
            edit.Name = "Edit";

            edit.UseColumnTextForButtonValue = true;

            edit.Text = "Edit";
            edit.Width = 60;

            return edit;
        }

        public DataGridViewButtonColumn addDelete()
        {
            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();

            delete.FlatStyle = FlatStyle.Popup;
            delete.HeaderText = "Delete";
            delete.Name = "Delete";

            delete.UseColumnTextForButtonValue = true;

            delete.Text = "Delete";
            delete.Width = 60;

            return delete;
        }

        public Boolean addUser(string username,string password,string gender,string phone,string city,string address)
        {
            try
            {
                cmd = new SqlCommand("insert into users_tbl(username,password,gender,phone,city,address) values('" + username + "','" + password + "','" + gender + "','" + phone + "','" + city + "','" + address + "')", con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account Created Successfully");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public Boolean editUser(string password, string gender, string phone, string city, string address)
        {
            try
            {
                cmd = new SqlCommand("update users_tbl set password='" + password + "',gender='" + gender + "',Phone='" + phone + "',city='" + city + "',address='" + address + "' where username='" + controller.uname + "'", con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("User Details Updated Successfully");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }


        public Boolean logIn(string username,string password)
        {
            try
            {
                da = new SqlDataAdapter("select count(*) from users_tbl where username='" + username + "' and password='" + password + "'", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                if(dt.Rows[0][0].ToString() == "1")
                {
                    uname = username;

                    MessageBox.Show("Login Successfull");
                    
                    return true;
                }
                else
                {
                    MessageBox.Show("Login Failed");
                    return false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public void deleteUser()
        {
            try
            {
                DialogResult d = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE YOUR ACCOUNT ?", "Confirmation", MessageBoxButtons.YesNo);

                if (d == DialogResult.Yes)
                {
                    cmd = new SqlCommand("delete from users_tbl where username = '" + controller.uname + "'", con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account Deleted Successfully");

                    MessageBox.Show("Logout Successfull");

                    Application.Exit();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void insertCar(string regNum, string brand, string model, string status, string price)
        {
            try
            {
                cmd = new SqlCommand("insert into cars_tbl(reg_no,brand,model,available,price) values('" + regNum + "','" + brand + "','" + model + "','" + status + "','" + price + "')",con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void updateCar(string regNum, string brand, string model, string status, string price)
        {
            try
            {
                cmd = new SqlCommand("update cars_tbl set reg_no = '" + regNum + "',brand = +'" + brand + "',model ='" + model + "',available = '" + status + "',price = '" + price + "' where reg_no = '" + Program.regNum + "'", con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void deleteCar()
        {
            try
            {
                DialogResult d = MessageBox.Show("Are You Sure You Want To Delete This Record ?","Confirmation",MessageBoxButtons.YesNo);

                if(d == DialogResult.Yes)
                {
                    cmd = new SqlCommand("delete from cars_tbl where reg_no = '" + Program.regNum + "'", con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Deleted Successfully");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);           
            }
        }

        public void insertCustomer(string cname, string gen, string phone, string city, string address)
        {
            try
            {
                cmd = new SqlCommand("insert into customers_tbl(cname,gender,phone,city,address) values('" + cname + "','" + gen + "','" + phone + "','" + city + "','" + address + "')", con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void updateCustomer(string cname, string gen, string phone, string city, string address)
        {
            try
            {
                cmd = new SqlCommand("update customers_tbl set cname = '" + cname + "',gender='" + gen + "',phone='" + phone + "',city='" + city + "',address='" + address + "' where cid='" + Program.id + "'", con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void deleteCustomer()
        {
            try
            {
                DialogResult d = MessageBox.Show("Are You Sure You Want To Delete This Record ?", "Confirmation", MessageBoxButtons.YesNo);

                if (d == DialogResult.Yes)
                {
                    cmd = new SqlCommand("delete from customers_tbl where cid = '" + Program.id + "'", con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Deleted Successfully");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void rentCar(string reg_no, int cid, string custname, DateTime rentDate, DateTime returnDate,string rent)
        {
            try
            {

                cmd = new SqlCommand("insert into rent_tbl(reg_no,cid,cname,rent_date,return_date,rent_fee,status) values('" + reg_no + "','" + cid + "','" + custname + "',convert(date,'" + rentDate + "',105),convert(date,'" + returnDate + "',105),'" + rent + "','On Rent')", con);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("update cars_tbl set available = 'No' where reg_no = '" + reg_no + "'", con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void editMode()
        {
            ds = select("select reg_no from rent_tbl where rid='" + Program.id + "'");
            
            cmd = new SqlCommand("update cars_tbl set available='Yes' where reg_no ='" + ds.Tables[0].Rows[0][0].ToString() + "'",con);
            
            cmd.ExecuteNonQuery();
        }
        public void updateRentedcar(string reg_no, int cid, string custname, DateTime rentDate, DateTime returnDate, string rent)
        {
            try
            {
                ds = select("select reg_no from rent_tbl where rid='" + Program.id + "'");

                cmd = new SqlCommand("update rent_tbl set reg_no = '" + reg_no + "', cid='" + cid + "', cname='" + custname + "', rent_date=convert(date,'" + rentDate + "',105), return_date=convert(date,'" + returnDate + "',105),rent_fee='"+ rent +"' where rid='" + Program.id + "'", con);

                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("update cars_tbl set available = 'No' where reg_no = '" + reg_no + "'", con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void deleteRentedcar()
        {
            try
            {
                DialogResult d = MessageBox.Show("Are You Sure You Want To Delete This Record ?", "Confirmation", MessageBoxButtons.YesNo);

                if (d == DialogResult.Yes)
                {
                    ds = select("select reg_no from rent_tbl where rid='" + Program.id + "'");

                    cmd = new SqlCommand("update cars_tbl set available = 'Yes' where reg_no = '" + ds.Tables[0].Rows[0][0].ToString() + "'", con);

                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("delete from rent_tbl where rid = '" + Program.id + "'", con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Deleted Successfully");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void returnCar(string reg_no,string cname,int cid,DateTime rentDate,DateTime returnDate,string fine,string total)
        {
            try
            {
                DialogResult d = MessageBox.Show("PLEASE CHECK DETAILS CAREFULLY (THIS CHANGE CANNOT BE ROLLBACKED) ARE YOU SURE YOU WANT TO CONTINUE ?", "Confirmation", MessageBoxButtons.YesNo);

                if (d == DialogResult.Yes)
                {
                    cmd = new SqlCommand("insert into return_tbl(reg_no,cname,cid,rent_date,return_date,fine,total_charges) " +
                    "values('" + reg_no + "','" + cname + "','" + cid + "',convert(date,'" + rentDate + "',105),convert(date,'" + returnDate + "',105),'" + fine + "','" + total + "')", con);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("update cars_tbl set available = 'Yes' where reg_no = '" + reg_no + "'", con);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("delete from rent_tbl where reg_no = '" + reg_no + "' and cid='" + cid + "'", con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Inserted Successfully");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void deleteReturnrdCar()
        {
            try
            {
                DialogResult d = MessageBox.Show("Are You Sure You Want To Delete This Record ?", "Confirmation", MessageBoxButtons.YesNo);

                if (d == DialogResult.Yes)
                {
                    cmd = new SqlCommand("update cars_tbl set available = 'Yes' where reg_no = '" + ds.Tables[0].Rows[0][0].ToString() + "'", con);

                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("delete from return_tbl where rtid = '" + Program.id + "'", con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Deleted Successfully");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
