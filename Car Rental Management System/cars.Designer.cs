
namespace Car_Rental_Management_System
{
    partial class cars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cars_list = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtRegno = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrand = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbYes = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdbNo = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnControl = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.btnRent = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnCars = new Guna.UI2.WinForms.Guna2Button();
            this.close = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnUserAccount = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.cars_list)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(222, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 34);
            this.lblTitle.TabIndex = 113;
            this.lblTitle.Text = "Cars Details";
            // 
            // cars_list
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.cars_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.cars_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cars_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.cars_list.ColumnHeadersHeight = 25;
            this.cars_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cars_list.DefaultCellStyle = dataGridViewCellStyle6;
            this.cars_list.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.cars_list.Location = new System.Drawing.Point(228, 286);
            this.cars_list.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cars_list.MultiSelect = false;
            this.cars_list.Name = "cars_list";
            this.cars_list.ReadOnly = true;
            this.cars_list.RowHeadersVisible = false;
            this.cars_list.Size = new System.Drawing.Size(702, 281);
            this.cars_list.TabIndex = 138;
            this.cars_list.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.cars_list.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.cars_list.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.cars_list.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.cars_list.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.cars_list.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.cars_list.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.cars_list.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.cars_list.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cars_list.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.cars_list.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.cars_list.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.cars_list.ThemeStyle.HeaderStyle.Height = 25;
            this.cars_list.ThemeStyle.ReadOnly = true;
            this.cars_list.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.cars_list.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cars_list.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cars_list.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.cars_list.ThemeStyle.RowsStyle.Height = 22;
            this.cars_list.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.cars_list.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.cars_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cars_list_CellContentClick);
            // 
            // txtRegno
            // 
            this.txtRegno.BorderColor = System.Drawing.Color.Black;
            this.txtRegno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegno.DefaultText = "";
            this.txtRegno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRegno.ForeColor = System.Drawing.Color.Black;
            this.txtRegno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegno.Location = new System.Drawing.Point(337, 84);
            this.txtRegno.Name = "txtRegno";
            this.txtRegno.PasswordChar = '\0';
            this.txtRegno.PlaceholderText = "";
            this.txtRegno.SelectedText = "";
            this.txtRegno.Size = new System.Drawing.Size(200, 24);
            this.txtRegno.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 139;
            this.label3.Text = "Reg_no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 141;
            this.label2.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.BorderColor = System.Drawing.Color.Black;
            this.txtModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModel.DefaultText = "";
            this.txtModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtModel.ForeColor = System.Drawing.Color.Black;
            this.txtModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModel.Location = new System.Drawing.Point(337, 124);
            this.txtModel.Name = "txtModel";
            this.txtModel.PasswordChar = '\0';
            this.txtModel.PlaceholderText = "";
            this.txtModel.SelectedText = "";
            this.txtModel.Size = new System.Drawing.Size(200, 24);
            this.txtModel.TabIndex = 142;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(583, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 143;
            this.label4.Text = "Brand";
            // 
            // txtBrand
            // 
            this.txtBrand.BorderColor = System.Drawing.Color.Black;
            this.txtBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrand.DefaultText = "";
            this.txtBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBrand.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBrand.ForeColor = System.Drawing.Color.Black;
            this.txtBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBrand.Location = new System.Drawing.Point(670, 84);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.PasswordChar = '\0';
            this.txtBrand.PlaceholderText = "";
            this.txtBrand.SelectedText = "";
            this.txtBrand.Size = new System.Drawing.Size(200, 24);
            this.txtBrand.TabIndex = 144;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(583, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 145;
            this.label5.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColor = System.Drawing.Color.Black;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(670, 122);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(200, 24);
            this.txtPrice.TabIndex = 146;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(229, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 147;
            this.label6.Text = "Available";
            // 
            // rdbYes
            // 
            this.rdbYes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbYes.CheckedState.BorderThickness = 0;
            this.rdbYes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbYes.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbYes.Location = new System.Drawing.Point(337, 168);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.Size = new System.Drawing.Size(20, 20);
            this.rdbYes.TabIndex = 148;
            this.rdbYes.Text = "guna2CustomRadioButton1";
            this.rdbYes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbYes.UncheckedState.BorderThickness = 2;
            this.rdbYes.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbYes.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbYes.CheckedChanged += new System.EventHandler(this.rdbYes_CheckedChanged);
            // 
            // rdbNo
            // 
            this.rdbNo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbNo.CheckedState.BorderThickness = 0;
            this.rdbNo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbNo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbNo.Location = new System.Drawing.Point(437, 168);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(20, 20);
            this.rdbNo.TabIndex = 149;
            this.rdbNo.Text = "guna2CustomRadioButton2";
            this.rdbNo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbNo.UncheckedState.BorderThickness = 2;
            this.rdbNo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbNo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbNo.CheckedChanged += new System.EventHandler(this.rdbNo_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(363, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 24);
            this.label7.TabIndex = 150;
            this.label7.Text = "Yes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(463, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 24);
            this.label8.TabIndex = 151;
            this.label8.Text = "No";
            // 
            // btnControl
            // 
            this.btnControl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnControl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnControl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnControl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnControl.FillColor = System.Drawing.Color.Maroon;
            this.btnControl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.ForeColor = System.Drawing.Color.White;
            this.btnControl.Location = new System.Drawing.Point(337, 212);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(200, 29);
            this.btnControl.TabIndex = 152;
            this.btnControl.Text = "Insert Record";
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnUserAccount);
            this.panel1.Controls.Add(this.Dashboard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.btnRent);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnCars);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 591);
            this.panel1.TabIndex = 155;
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.Maroon;
            this.Dashboard.BorderColor = System.Drawing.Color.White;
            this.Dashboard.BorderThickness = 1;
            this.Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Dashboard.FillColor = System.Drawing.Color.Maroon;
            this.Dashboard.FocusedColor = System.Drawing.Color.White;
            this.Dashboard.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Dashboard.ForeColor = System.Drawing.Color.White;
            this.Dashboard.HoverState.BorderColor = System.Drawing.Color.White;
            this.Dashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Dashboard.HoverState.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Dashboard.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Dashboard.Location = new System.Drawing.Point(-12, 122);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.PressedColor = System.Drawing.Color.White;
            this.Dashboard.Size = new System.Drawing.Size(225, 45);
            this.Dashboard.TabIndex = 35;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(1);
            this.label1.Size = new System.Drawing.Size(176, 39);
            this.label1.TabIndex = 34;
            this.label1.Text = "Car Space";
            // 
            // btnLogout
            // 
            this.btnLogout.BorderColor = System.Drawing.Color.White;
            this.btnLogout.BorderThickness = 1;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Maroon;
            this.btnLogout.FocusedColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogout.HoverState.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(-12, 489);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedColor = System.Drawing.Color.White;
            this.btnLogout.Size = new System.Drawing.Size(228, 45);
            this.btnLogout.TabIndex = 33;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnReturn
            // 
            this.btnReturn.BorderColor = System.Drawing.Color.White;
            this.btnReturn.BorderThickness = 1;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturn.FillColor = System.Drawing.Color.Maroon;
            this.btnReturn.FocusedColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnReturn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReturn.HoverState.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnReturn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(-12, 366);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.PressedColor = System.Drawing.Color.White;
            this.btnReturn.Size = new System.Drawing.Size(225, 45);
            this.btnReturn.TabIndex = 31;
            this.btnReturn.Text = "Return a car";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // btnRent
            // 
            this.btnRent.BorderColor = System.Drawing.Color.White;
            this.btnRent.BorderThickness = 1;
            this.btnRent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRent.FillColor = System.Drawing.Color.Maroon;
            this.btnRent.FocusedColor = System.Drawing.Color.White;
            this.btnRent.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnRent.ForeColor = System.Drawing.Color.White;
            this.btnRent.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnRent.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRent.HoverState.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnRent.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnRent.Location = new System.Drawing.Point(-12, 306);
            this.btnRent.Name = "btnRent";
            this.btnRent.PressedColor = System.Drawing.Color.White;
            this.btnRent.Size = new System.Drawing.Size(225, 45);
            this.btnRent.TabIndex = 30;
            this.btnRent.Text = "Rent a car";
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click_1);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BorderColor = System.Drawing.Color.White;
            this.btnCustomers.BorderThickness = 1;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomers.FillColor = System.Drawing.Color.Maroon;
            this.btnCustomers.FocusedColor = System.Drawing.Color.White;
            this.btnCustomers.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnCustomers.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCustomers.HoverState.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnCustomers.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCustomers.Location = new System.Drawing.Point(-12, 245);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.PressedColor = System.Drawing.Color.White;
            this.btnCustomers.Size = new System.Drawing.Size(225, 45);
            this.btnCustomers.TabIndex = 28;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click_1);
            // 
            // btnCars
            // 
            this.btnCars.BackColor = System.Drawing.Color.White;
            this.btnCars.BorderColor = System.Drawing.Color.White;
            this.btnCars.BorderThickness = 1;
            this.btnCars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCars.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCars.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCars.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCars.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCars.FillColor = System.Drawing.Color.White;
            this.btnCars.FocusedColor = System.Drawing.Color.White;
            this.btnCars.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnCars.ForeColor = System.Drawing.Color.Black;
            this.btnCars.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnCars.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCars.HoverState.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnCars.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCars.Location = new System.Drawing.Point(-12, 186);
            this.btnCars.Name = "btnCars";
            this.btnCars.PressedColor = System.Drawing.Color.White;
            this.btnCars.Size = new System.Drawing.Size(225, 45);
            this.btnCars.TabIndex = 24;
            this.btnCars.Text = "Cars";
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Maroon;
            this.close.Location = new System.Drawing.Point(911, 12);
            this.close.Margin = new System.Windows.Forms.Padding(3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(33, 32);
            this.close.TabIndex = 156;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(660, 258);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Search reg_no";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(173, 22);
            this.txtSearch.TabIndex = 158;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.Maroon;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 12.25F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(839, 258);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 22);
            this.btnSearch.TabIndex = 159;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(224, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 22);
            this.label9.TabIndex = 161;
            this.label9.Text = "Filter";
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "All Cars",
            "Available Cars",
            "Not Available"});
            this.cmbFilter.Location = new System.Drawing.Point(282, 259);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(154, 21);
            this.cmbFilter.TabIndex = 160;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // btnUserAccount
            // 
            this.btnUserAccount.BorderColor = System.Drawing.Color.White;
            this.btnUserAccount.BorderThickness = 1;
            this.btnUserAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserAccount.FillColor = System.Drawing.Color.Maroon;
            this.btnUserAccount.FocusedColor = System.Drawing.Color.White;
            this.btnUserAccount.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnUserAccount.ForeColor = System.Drawing.Color.White;
            this.btnUserAccount.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnUserAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUserAccount.HoverState.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnUserAccount.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnUserAccount.Location = new System.Drawing.Point(-15, 428);
            this.btnUserAccount.Name = "btnUserAccount";
            this.btnUserAccount.PressedColor = System.Drawing.Color.White;
            this.btnUserAccount.Size = new System.Drawing.Size(228, 45);
            this.btnUserAccount.TabIndex = 162;
            this.btnUserAccount.Text = "User Account";
            this.btnUserAccount.Click += new System.EventHandler(this.btnUserAccount_Click);
            // 
            // cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 590);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdbNo);
            this.Controls.Add(this.rdbYes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cars_list);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Space";
            this.Load += new System.EventHandler(this.cars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cars_list)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2DataGridView cars_list;
        private Guna.UI2.WinForms.Guna2TextBox txtRegno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtBrand;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdbYes;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdbNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnControl;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Dashboard;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private Guna.UI2.WinForms.Guna2Button btnRent;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnCars;
        private System.Windows.Forms.Label close;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFilter;
        private Guna.UI2.WinForms.Guna2Button btnUserAccount;
    }
}