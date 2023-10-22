
namespace Car_Rental_Management_System
{
    partial class returncar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.datagrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtRentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFine = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnControl = new Guna.UI2.WinForms.Guna2Button();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDelay = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.btnRent = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnCars = new Guna.UI2.WinForms.Guna2Button();
            this.close = new System.Windows.Forms.Label();
            this.cmbRegno = new System.Windows.Forms.ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnUserAccount = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(224, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 34);
            this.lblTitle.TabIndex = 115;
            this.lblTitle.Text = "Return a car";
            // 
            // datagrid
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.datagrid.ColumnHeadersHeight = 25;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.datagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid.Location = new System.Drawing.Point(230, 293);
            this.datagrid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.datagrid.MultiSelect = false;
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersVisible = false;
            this.datagrid.Size = new System.Drawing.Size(698, 276);
            this.datagrid.TabIndex = 160;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.datagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.datagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagrid.ThemeStyle.HeaderStyle.Height = 25;
            this.datagrid.ThemeStyle.ReadOnly = true;
            this.datagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.datagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagrid.ThemeStyle.RowsStyle.Height = 22;
            this.datagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.LightGray;
            this.datagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 164;
            this.label3.Text = "Reg_no";
            // 
            // txtCustName
            // 
            this.txtCustName.BorderColor = System.Drawing.Color.Black;
            this.txtCustName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustName.DefaultText = "";
            this.txtCustName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustName.ForeColor = System.Drawing.Color.Black;
            this.txtCustName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustName.Location = new System.Drawing.Point(356, 112);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.PasswordChar = '\0';
            this.txtCustName.PlaceholderText = "";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.SelectedText = "";
            this.txtCustName.Size = new System.Drawing.Size(201, 24);
            this.txtCustName.TabIndex = 169;
            this.txtCustName.TextChanged += new System.EventHandler(this.txtDelay_KeyUp);
            this.txtCustName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDelay_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 168;
            this.label4.Text = "Cust name";
            // 
            // dtRentDate
            // 
            this.dtRentDate.Checked = true;
            this.dtRentDate.Enabled = false;
            this.dtRentDate.FillColor = System.Drawing.Color.Maroon;
            this.dtRentDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtRentDate.ForeColor = System.Drawing.Color.White;
            this.dtRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtRentDate.Location = new System.Drawing.Point(727, 73);
            this.dtRentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtRentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtRentDate.Name = "dtRentDate";
            this.dtRentDate.Size = new System.Drawing.Size(201, 24);
            this.dtRentDate.TabIndex = 171;
            this.dtRentDate.Value = new System.DateTime(2022, 10, 13, 22, 36, 57, 868);
            this.dtRentDate.Click += new System.EventHandler(this.dtRentDate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(597, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 170;
            this.label6.Text = "Rent Date";
            // 
            // dtReturnDate
            // 
            this.dtReturnDate.Checked = true;
            this.dtReturnDate.Enabled = false;
            this.dtReturnDate.FillColor = System.Drawing.Color.Maroon;
            this.dtReturnDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtReturnDate.ForeColor = System.Drawing.Color.White;
            this.dtReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtReturnDate.Location = new System.Drawing.Point(728, 112);
            this.dtReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtReturnDate.Name = "dtReturnDate";
            this.dtReturnDate.Size = new System.Drawing.Size(200, 24);
            this.dtReturnDate.TabIndex = 173;
            this.dtReturnDate.Value = new System.DateTime(2022, 10, 13, 22, 36, 57, 868);
            this.dtReturnDate.Click += new System.EventHandler(this.txtDelay_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(598, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 172;
            this.label5.Text = "Return Date";
            // 
            // txtFine
            // 
            this.txtFine.BorderColor = System.Drawing.Color.Black;
            this.txtFine.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFine.DefaultText = "";
            this.txtFine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFine.ForeColor = System.Drawing.Color.Black;
            this.txtFine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFine.Location = new System.Drawing.Point(727, 157);
            this.txtFine.Name = "txtFine";
            this.txtFine.PasswordChar = '\0';
            this.txtFine.PlaceholderText = "";
            this.txtFine.ReadOnly = true;
            this.txtFine.SelectedText = "";
            this.txtFine.Size = new System.Drawing.Size(198, 24);
            this.txtFine.TabIndex = 175;
            this.txtFine.TextChanged += new System.EventHandler(this.txtDelay_KeyUp);
            this.txtFine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDelay_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 174;
            this.label2.Text = "Fine";
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
            this.btnControl.Location = new System.Drawing.Point(355, 200);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(201, 31);
            this.btnControl.TabIndex = 178;
            this.btnControl.Text = "Insert Record";
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BorderColor = System.Drawing.Color.Black;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Location = new System.Drawing.Point(727, 200);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(201, 24);
            this.txtTotal.TabIndex = 180;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(598, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 24);
            this.label8.TabIndex = 179;
            this.label8.Text = "Total";
            // 
            // txtDelay
            // 
            this.txtDelay.BorderColor = System.Drawing.Color.Black;
            this.txtDelay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDelay.DefaultText = "";
            this.txtDelay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDelay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDelay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDelay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDelay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDelay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDelay.ForeColor = System.Drawing.Color.Black;
            this.txtDelay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDelay.Location = new System.Drawing.Point(355, 157);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.PasswordChar = '\0';
            this.txtDelay.PlaceholderText = "";
            this.txtDelay.ReadOnly = true;
            this.txtDelay.SelectedText = "";
            this.txtDelay.Size = new System.Drawing.Size(201, 24);
            this.txtDelay.TabIndex = 182;
            this.txtDelay.TextChanged += new System.EventHandler(this.txtDelay_TextChanged);
            this.txtDelay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDelay_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 181;
            this.label7.Text = "Delay";
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
            this.panel1.TabIndex = 183;
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
            this.btnLogout.Location = new System.Drawing.Point(-15, 493);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedColor = System.Drawing.Color.White;
            this.btnLogout.Size = new System.Drawing.Size(228, 45);
            this.btnLogout.TabIndex = 33;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.BorderColor = System.Drawing.Color.White;
            this.btnReturn.BorderThickness = 1;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturn.FillColor = System.Drawing.Color.White;
            this.btnReturn.FocusedColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
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
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
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
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnCars
            // 
            this.btnCars.BackColor = System.Drawing.Color.Maroon;
            this.btnCars.BorderColor = System.Drawing.Color.White;
            this.btnCars.BorderThickness = 1;
            this.btnCars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCars.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCars.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCars.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCars.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCars.FillColor = System.Drawing.Color.Maroon;
            this.btnCars.FocusedColor = System.Drawing.Color.White;
            this.btnCars.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnCars.ForeColor = System.Drawing.Color.White;
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
            this.close.TabIndex = 184;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // cmbRegno
            // 
            this.cmbRegno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRegno.FormattingEnabled = true;
            this.cmbRegno.Location = new System.Drawing.Point(356, 73);
            this.cmbRegno.Name = "cmbRegno";
            this.cmbRegno.Size = new System.Drawing.Size(200, 24);
            this.cmbRegno.TabIndex = 185;
            this.cmbRegno.SelectedIndexChanged += new System.EventHandler(this.cmbRegno_SelectedIndexChanged);
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
            this.btnSearch.Location = new System.Drawing.Point(833, 265);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 22);
            this.btnSearch.TabIndex = 187;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(654, 265);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Search reg_no";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(173, 22);
            this.txtSearch.TabIndex = 186;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(228, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 22);
            this.label9.TabIndex = 189;
            this.label9.Text = "Filter";
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "All Records"});
            this.cmbFilter.Location = new System.Drawing.Point(286, 265);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(154, 21);
            this.cmbFilter.TabIndex = 188;
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
            this.btnUserAccount.Location = new System.Drawing.Point(-1, 428);
            this.btnUserAccount.Name = "btnUserAccount";
            this.btnUserAccount.PressedColor = System.Drawing.Color.White;
            this.btnUserAccount.Size = new System.Drawing.Size(214, 45);
            this.btnUserAccount.TabIndex = 198;
            this.btnUserAccount.Text = "User Account";
            this.btnUserAccount.Click += new System.EventHandler(this.btnUserAccount_Click);
            // 
            // returncar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 590);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbRegno);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtReturnDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtRentDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "returncar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Space";
            this.Load += new System.EventHandler(this.return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2DataGridView datagrid;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtCustName;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtRentDate;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtReturnDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnControl;
        private Guna.UI2.WinForms.Guna2TextBox txtFine;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtDelay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Dashboard;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private Guna.UI2.WinForms.Guna2Button btnRent;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnCars;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.ComboBox cmbRegno;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFilter;
        private Guna.UI2.WinForms.Guna2Button btnUserAccount;
    }
}