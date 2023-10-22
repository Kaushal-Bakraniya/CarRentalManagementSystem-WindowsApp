
namespace Car_Rental_Management_System
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtRentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCid = new System.Windows.Forms.ComboBox();
            this.rentedcars_list = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnControl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRegNo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.rentedcars_list)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkRed;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(180, 507);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 25);
            this.btnBack.TabIndex = 113;
            this.btnBack.Text = "Back to home";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Available Cars",
            "Customers List",
            "Cars on rent"});
            this.cmbFilter.Location = new System.Drawing.Point(762, 124);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(217, 28);
            this.cmbFilter.TabIndex = 112;
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCustName.Location = new System.Drawing.Point(180, 255);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(217, 23);
            this.txtCustName.TabIndex = 111;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14F);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(42, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 110;
            this.label8.Text = "Cust. Name";
            // 
            // dtReturnDate
            // 
            this.dtReturnDate.Checked = true;
            this.dtReturnDate.FillColor = System.Drawing.Color.DarkRed;
            this.dtReturnDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtReturnDate.ForeColor = System.Drawing.Color.White;
            this.dtReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtReturnDate.Location = new System.Drawing.Point(180, 346);
            this.dtReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtReturnDate.Name = "dtReturnDate";
            this.dtReturnDate.Size = new System.Drawing.Size(217, 23);
            this.dtReturnDate.TabIndex = 109;
            this.dtReturnDate.Value = new System.DateTime(2022, 10, 8, 18, 28, 29, 11);
            // 
            // dtRentDate
            // 
            this.dtRentDate.Checked = true;
            this.dtRentDate.FillColor = System.Drawing.Color.DarkRed;
            this.dtRentDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtRentDate.ForeColor = System.Drawing.Color.White;
            this.dtRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtRentDate.Location = new System.Drawing.Point(180, 300);
            this.dtRentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtRentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtRentDate.Name = "dtRentDate";
            this.dtRentDate.Size = new System.Drawing.Size(217, 23);
            this.dtRentDate.TabIndex = 108;
            this.dtRentDate.Value = new System.DateTime(2022, 10, 8, 18, 28, 29, 11);
            // 
            // txtFees
            // 
            this.txtFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFees.Location = new System.Drawing.Point(180, 396);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(217, 23);
            this.txtFees.TabIndex = 107;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14F);
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(41, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 23);
            this.label7.TabIndex = 106;
            this.label7.Text = "Return Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14F);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(41, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 105;
            this.label4.Text = "Customer Id";
            // 
            // cmbCid
            // 
            this.cmbCid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbCid.FormattingEnabled = true;
            this.cmbCid.Location = new System.Drawing.Point(180, 209);
            this.cmbCid.Name = "cmbCid";
            this.cmbCid.Size = new System.Drawing.Size(217, 23);
            this.cmbCid.TabIndex = 104;
            // 
            // rentedcars_list
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.rentedcars_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.rentedcars_list.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rentedcars_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rentedcars_list.ColumnHeadersHeight = 22;
            this.rentedcars_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rentedcars_list.DefaultCellStyle = dataGridViewCellStyle3;
            this.rentedcars_list.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.rentedcars_list.Location = new System.Drawing.Point(442, 167);
            this.rentedcars_list.Name = "rentedcars_list";
            this.rentedcars_list.ReadOnly = true;
            this.rentedcars_list.RowHeadersVisible = false;
            this.rentedcars_list.Size = new System.Drawing.Size(537, 388);
            this.rentedcars_list.TabIndex = 103;
            this.rentedcars_list.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.rentedcars_list.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.rentedcars_list.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.rentedcars_list.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.rentedcars_list.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.rentedcars_list.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.rentedcars_list.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.rentedcars_list.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkRed;
            this.rentedcars_list.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.rentedcars_list.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentedcars_list.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.rentedcars_list.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.rentedcars_list.ThemeStyle.HeaderStyle.Height = 22;
            this.rentedcars_list.ThemeStyle.ReadOnly = true;
            this.rentedcars_list.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.rentedcars_list.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.rentedcars_list.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentedcars_list.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.rentedcars_list.ThemeStyle.RowsStyle.Height = 22;
            this.rentedcars_list.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.rentedcars_list.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14F);
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(42, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 23);
            this.label10.TabIndex = 101;
            this.label10.Text = "Fees";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Location = new System.Drawing.Point(12, 602);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 32);
            this.panel2.TabIndex = 97;
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.Color.DarkRed;
            this.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControl.Font = new System.Drawing.Font("Verdana", 12F);
            this.btnControl.ForeColor = System.Drawing.Color.White;
            this.btnControl.Location = new System.Drawing.Point(180, 455);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(217, 31);
            this.btnControl.TabIndex = 99;
            this.btnControl.Text = "Rent a car";
            this.btnControl.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(437, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 96;
            this.label3.Text = "Rent a car";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14F);
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(41, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 100;
            this.label6.Text = "Rental Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(413, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Manage Rental Cars";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(958, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 20);
            this.close.TabIndex = 20;
            this.close.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Rental Management System";
            // 
            // cmbRegNo
            // 
            this.cmbRegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Location = new System.Drawing.Point(180, 167);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new System.Drawing.Size(217, 23);
            this.cmbRegNo.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14F);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(42, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 98;
            this.label5.Text = "Reg. No.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 97);
            this.panel1.TabIndex = 95;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 641);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtReturnDate);
            this.Controls.Add(this.dtRentDate);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCid);
            this.Controls.Add(this.rentedcars_list);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbRegNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rentedcars_list)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtReturnDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtRentDate;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCid;
        private Guna.UI2.WinForms.Guna2DataGridView rentedcars_list;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRegNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}