﻿namespace DA1_WF
{
    partial class frmHDB
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSdtKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btndskh = new Guna.UI2.WinForms.Guna2Button();
            this.cbbHTTT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtNgayBan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNVKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaHDB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemHDB = new Guna.UI2.WinForms.Guna2Button();
            this.txtTkHDBbSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtDenNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtTuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dgHDB = new System.Windows.Forms.DataGridView();
            this.btnThemHD = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaHDB = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaHDB = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoiHDB = new Guna.UI2.WinForms.Guna2Button();
            this.btnInHDB = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSdtKH);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btndskh);
            this.groupBox1.Controls.Add(this.cbbHTTT);
            this.groupBox1.Controls.Add(this.dtNgayBan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaNVKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaHDB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HDB";
            // 
            // txtSdtKH
            // 
            this.txtSdtKH.AutoRoundedCorners = true;
            this.txtSdtKH.BorderColor = System.Drawing.Color.Green;
            this.txtSdtKH.BorderRadius = 17;
            this.txtSdtKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSdtKH.DefaultText = "";
            this.txtSdtKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSdtKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSdtKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdtKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdtKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdtKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSdtKH.ForeColor = System.Drawing.Color.Black;
            this.txtSdtKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdtKH.Location = new System.Drawing.Point(461, 22);
            this.txtSdtKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSdtKH.Name = "txtSdtKH";
            this.txtSdtKH.PasswordChar = '\0';
            this.txtSdtKH.PlaceholderText = "";
            this.txtSdtKH.SelectedText = "";
            this.txtSdtKH.Size = new System.Drawing.Size(194, 37);
            this.txtSdtKH.TabIndex = 18;
            this.txtSdtKH.TextChanged += new System.EventHandler(this.txtSdtKH_TextChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.AutoRoundedCorners = true;
            this.txtTenKH.BorderColor = System.Drawing.Color.Green;
            this.txtTenKH.BorderRadius = 17;
            this.txtTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKH.DefaultText = "";
            this.txtTenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKH.ForeColor = System.Drawing.Color.Black;
            this.txtTenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.Location = new System.Drawing.Point(461, 87);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.PlaceholderText = "";
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.Size = new System.Drawing.Size(194, 37);
            this.txtTenKH.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tên khách hàng";
            // 
            // btndskh
            // 
            this.btndskh.AutoRoundedCorners = true;
            this.btndskh.BorderRadius = 21;
            this.btndskh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndskh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndskh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndskh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndskh.FillColor = System.Drawing.Color.Green;
            this.btndskh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btndskh.ForeColor = System.Drawing.Color.White;
            this.btndskh.Location = new System.Drawing.Point(141, 200);
            this.btndskh.Name = "btndskh";
            this.btndskh.Size = new System.Drawing.Size(339, 45);
            this.btndskh.TabIndex = 15;
            this.btndskh.Text = "Danh sách khách hàng";
            this.btndskh.Click += new System.EventHandler(this.btndskh_Click);
            // 
            // cbbHTTT
            // 
            this.cbbHTTT.AutoRoundedCorners = true;
            this.cbbHTTT.BackColor = System.Drawing.Color.Transparent;
            this.cbbHTTT.BorderColor = System.Drawing.Color.Green;
            this.cbbHTTT.BorderRadius = 17;
            this.cbbHTTT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbHTTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHTTT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbHTTT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbHTTT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbHTTT.ForeColor = System.Drawing.Color.Black;
            this.cbbHTTT.ItemHeight = 30;
            this.cbbHTTT.Location = new System.Drawing.Point(158, 146);
            this.cbbHTTT.Name = "cbbHTTT";
            this.cbbHTTT.Size = new System.Drawing.Size(161, 36);
            this.cbbHTTT.TabIndex = 14;
            // 
            // dtNgayBan
            // 
            this.dtNgayBan.AutoRoundedCorners = true;
            this.dtNgayBan.BorderColor = System.Drawing.Color.Green;
            this.dtNgayBan.BorderRadius = 17;
            this.dtNgayBan.Checked = true;
            this.dtNgayBan.FillColor = System.Drawing.Color.White;
            this.dtNgayBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtNgayBan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBan.Location = new System.Drawing.Point(449, 146);
            this.dtNgayBan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgayBan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgayBan.Name = "dtNgayBan";
            this.dtNgayBan.Size = new System.Drawing.Size(194, 36);
            this.dtNgayBan.TabIndex = 12;
            this.dtNgayBan.Value = new System.DateTime(2023, 3, 5, 20, 2, 41, 380);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hình thức thanh toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày bán";
            // 
            // txtMaNVKH
            // 
            this.txtMaNVKH.AutoRoundedCorners = true;
            this.txtMaNVKH.BorderColor = System.Drawing.Color.Green;
            this.txtMaNVKH.BorderRadius = 17;
            this.txtMaNVKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNVKH.DefaultText = "";
            this.txtMaNVKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNVKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNVKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNVKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNVKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNVKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNVKH.ForeColor = System.Drawing.Color.Black;
            this.txtMaNVKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNVKH.Location = new System.Drawing.Point(123, 87);
            this.txtMaNVKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNVKH.Name = "txtMaNVKH";
            this.txtMaNVKH.PasswordChar = '\0';
            this.txtMaNVKH.PlaceholderText = "";
            this.txtMaNVKH.SelectedText = "";
            this.txtMaNVKH.Size = new System.Drawing.Size(179, 37);
            this.txtMaNVKH.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "SĐT khách hàng";
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.AutoRoundedCorners = true;
            this.txtMaHDB.BorderColor = System.Drawing.Color.Green;
            this.txtMaHDB.BorderRadius = 17;
            this.txtMaHDB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHDB.DefaultText = "";
            this.txtMaHDB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHDB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHDB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaHDB.ForeColor = System.Drawing.Color.Black;
            this.txtMaHDB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHDB.Location = new System.Drawing.Point(123, 22);
            this.txtMaHDB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.PasswordChar = '\0';
            this.txtMaHDB.PlaceholderText = "";
            this.txtMaHDB.SelectedText = "";
            this.txtMaHDB.Size = new System.Drawing.Size(179, 37);
            this.txtMaHDB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn bán";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiemHDB);
            this.groupBox2.Controls.Add(this.txtTkHDBbSDT);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(691, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm HDB";
            // 
            // btnTimKiemHDB
            // 
            this.btnTimKiemHDB.AutoRoundedCorners = true;
            this.btnTimKiemHDB.BorderRadius = 45;
            this.btnTimKiemHDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemHDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemHDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiemHDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiemHDB.FillColor = System.Drawing.Color.Green;
            this.btnTimKiemHDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiemHDB.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemHDB.Location = new System.Drawing.Point(376, 136);
            this.btnTimKiemHDB.Name = "btnTimKiemHDB";
            this.btnTimKiemHDB.Size = new System.Drawing.Size(129, 93);
            this.btnTimKiemHDB.TabIndex = 8;
            this.btnTimKiemHDB.Text = "Tìm kiếm ";
            this.btnTimKiemHDB.Click += new System.EventHandler(this.btnTimKiemHDB_Click);
            // 
            // txtTkHDBbSDT
            // 
            this.txtTkHDBbSDT.AutoRoundedCorners = true;
            this.txtTkHDBbSDT.BorderColor = System.Drawing.Color.Green;
            this.txtTkHDBbSDT.BorderRadius = 17;
            this.txtTkHDBbSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTkHDBbSDT.DefaultText = "";
            this.txtTkHDBbSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTkHDBbSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTkHDBbSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTkHDBbSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTkHDBbSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTkHDBbSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTkHDBbSDT.ForeColor = System.Drawing.Color.Black;
            this.txtTkHDBbSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTkHDBbSDT.Location = new System.Drawing.Point(37, 179);
            this.txtTkHDBbSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTkHDBbSDT.Name = "txtTkHDBbSDT";
            this.txtTkHDBbSDT.PasswordChar = '\0';
            this.txtTkHDBbSDT.PlaceholderText = "";
            this.txtTkHDBbSDT.SelectedText = "";
            this.txtTkHDBbSDT.Size = new System.Drawing.Size(267, 37);
            this.txtTkHDBbSDT.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtDenNgay);
            this.groupBox4.Location = new System.Drawing.Point(299, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(226, 81);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Đến ngày";
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.AutoRoundedCorners = true;
            this.dtDenNgay.BorderColor = System.Drawing.Color.Green;
            this.dtDenNgay.BorderRadius = 17;
            this.dtDenNgay.Checked = true;
            this.dtDenNgay.FillColor = System.Drawing.Color.Honeydew;
            this.dtDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDenNgay.Location = new System.Drawing.Point(23, 30);
            this.dtDenNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDenNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(183, 36);
            this.dtDenNgay.TabIndex = 19;
            this.dtDenNgay.Value = new System.DateTime(2023, 3, 5, 20, 7, 52, 743);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtTuNgay);
            this.groupBox3.Location = new System.Drawing.Point(37, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 81);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Từ ngày";
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.AutoRoundedCorners = true;
            this.dtTuNgay.BorderColor = System.Drawing.Color.Green;
            this.dtTuNgay.BorderRadius = 17;
            this.dtTuNgay.Checked = true;
            this.dtTuNgay.FillColor = System.Drawing.Color.Honeydew;
            this.dtTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTuNgay.Location = new System.Drawing.Point(23, 30);
            this.dtTuNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTuNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(183, 36);
            this.dtTuNgay.TabIndex = 19;
            this.dtTuNgay.Value = new System.DateTime(2023, 3, 5, 20, 7, 52, 743);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "SĐT khách hàng";
            // 
            // dgHDB
            // 
            this.dgHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHDB.Location = new System.Drawing.Point(13, 286);
            this.dgHDB.Name = "dgHDB";
            this.dgHDB.RowHeadersWidth = 51;
            this.dgHDB.RowTemplate.Height = 24;
            this.dgHDB.Size = new System.Drawing.Size(1219, 366);
            this.dgHDB.TabIndex = 2;
            this.dgHDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHDB_CellClick);
            this.dgHDB.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHDB_CellContentDoubleClick);
            // 
            // btnThemHD
            // 
            this.btnThemHD.AutoRoundedCorners = true;
            this.btnThemHD.BorderRadius = 18;
            this.btnThemHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemHD.FillColor = System.Drawing.Color.Green;
            this.btnThemHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemHD.ForeColor = System.Drawing.Color.White;
            this.btnThemHD.Location = new System.Drawing.Point(69, 685);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(129, 38);
            this.btnThemHD.TabIndex = 3;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // btnSuaHDB
            // 
            this.btnSuaHDB.AutoRoundedCorners = true;
            this.btnSuaHDB.BorderRadius = 18;
            this.btnSuaHDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaHDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaHDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaHDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaHDB.FillColor = System.Drawing.Color.Green;
            this.btnSuaHDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaHDB.ForeColor = System.Drawing.Color.White;
            this.btnSuaHDB.Location = new System.Drawing.Point(312, 685);
            this.btnSuaHDB.Name = "btnSuaHDB";
            this.btnSuaHDB.Size = new System.Drawing.Size(129, 38);
            this.btnSuaHDB.TabIndex = 4;
            this.btnSuaHDB.Text = "Sửa";
            this.btnSuaHDB.Click += new System.EventHandler(this.btnSuaHDB_Click);
            // 
            // btnXoaHDB
            // 
            this.btnXoaHDB.AutoRoundedCorners = true;
            this.btnXoaHDB.BorderRadius = 18;
            this.btnXoaHDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaHDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaHDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaHDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaHDB.FillColor = System.Drawing.Color.Green;
            this.btnXoaHDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaHDB.ForeColor = System.Drawing.Color.White;
            this.btnXoaHDB.Location = new System.Drawing.Point(565, 685);
            this.btnXoaHDB.Name = "btnXoaHDB";
            this.btnXoaHDB.Size = new System.Drawing.Size(129, 38);
            this.btnXoaHDB.TabIndex = 5;
            this.btnXoaHDB.Text = "Xóa";
            this.btnXoaHDB.Click += new System.EventHandler(this.btnXoaHDB_Click);
            // 
            // btnLamMoiHDB
            // 
            this.btnLamMoiHDB.AutoRoundedCorners = true;
            this.btnLamMoiHDB.BorderRadius = 18;
            this.btnLamMoiHDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiHDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiHDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoiHDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoiHDB.FillColor = System.Drawing.Color.Green;
            this.btnLamMoiHDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoiHDB.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiHDB.Location = new System.Drawing.Point(825, 685);
            this.btnLamMoiHDB.Name = "btnLamMoiHDB";
            this.btnLamMoiHDB.Size = new System.Drawing.Size(129, 38);
            this.btnLamMoiHDB.TabIndex = 6;
            this.btnLamMoiHDB.Text = "Làm mới";
            this.btnLamMoiHDB.Click += new System.EventHandler(this.btnLamMoiHDB_Click);
            // 
            // btnInHDB
            // 
            this.btnInHDB.AutoRoundedCorners = true;
            this.btnInHDB.BorderRadius = 18;
            this.btnInHDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInHDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInHDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInHDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInHDB.FillColor = System.Drawing.Color.Green;
            this.btnInHDB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInHDB.ForeColor = System.Drawing.Color.White;
            this.btnInHDB.Location = new System.Drawing.Point(1057, 685);
            this.btnInHDB.Name = "btnInHDB";
            this.btnInHDB.Size = new System.Drawing.Size(129, 38);
            this.btnInHDB.TabIndex = 7;
            this.btnInHDB.Text = "In hóa đơn";
            this.btnInHDB.Click += new System.EventHandler(this.btnInHDB_Click);
            // 
            // frmHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1248, 731);
            this.Controls.Add(this.btnInHDB);
            this.Controls.Add(this.btnLamMoiHDB);
            this.Controls.Add(this.btnXoaHDB);
            this.Controls.Add(this.btnSuaHDB);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.dgHDB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.frmHDB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btndskh;
        private Guna.UI2.WinForms.Guna2ComboBox cbbHTTT;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtNgayBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNVKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgHDB;
        private Guna.UI2.WinForms.Guna2Button btnThemHD;
        private Guna.UI2.WinForms.Guna2Button btnSuaHDB;
        private Guna.UI2.WinForms.Guna2Button btnXoaHDB;
        private Guna.UI2.WinForms.Guna2Button btnLamMoiHDB;
        private Guna.UI2.WinForms.Guna2Button btnInHDB;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDenNgay;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtTuNgay;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemHDB;
        private Guna.UI2.WinForms.Guna2TextBox txtTkHDBbSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtSdtKH;
    }
}