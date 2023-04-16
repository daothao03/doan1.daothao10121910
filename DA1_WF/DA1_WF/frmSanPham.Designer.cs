namespace DA1_WF
{
    partial class frmSanPham
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
            this.dgSP = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemSP = new Guna.UI2.WinForms.Guna2Button();
            this.txtTkTenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiaBanSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoLuongSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaSanPham = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXuatXuSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoiSP = new Guna.UI2.WinForms.Guna2Button();
            this.txtDonViTinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgSP
            // 
            this.dgSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSP.Location = new System.Drawing.Point(12, 247);
            this.dgSP.Name = "dgSP";
            this.dgSP.RowHeadersWidth = 51;
            this.dgSP.RowTemplate.Height = 24;
            this.dgSP.Size = new System.Drawing.Size(1110, 396);
            this.dgSP.TabIndex = 21;
            this.dgSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSP_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiemSP);
            this.groupBox2.Controls.Add(this.txtTkTenSP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(734, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 224);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm Sản phẩm";
            // 
            // btnTimKiemSP
            // 
            this.btnTimKiemSP.AutoRoundedCorners = true;
            this.btnTimKiemSP.BorderRadius = 21;
            this.btnTimKiemSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiemSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiemSP.FillColor = System.Drawing.Color.Green;
            this.btnTimKiemSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiemSP.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemSP.Location = new System.Drawing.Point(214, 150);
            this.btnTimKiemSP.Name = "btnTimKiemSP";
            this.btnTimKiemSP.Size = new System.Drawing.Size(135, 45);
            this.btnTimKiemSP.TabIndex = 14;
            this.btnTimKiemSP.Text = "Tìm kiếm";
            this.btnTimKiemSP.Click += new System.EventHandler(this.btnTimKiemSP_Click);
            // 
            // txtTkTenSP
            // 
            this.txtTkTenSP.AutoRoundedCorners = true;
            this.txtTkTenSP.BorderColor = System.Drawing.Color.Green;
            this.txtTkTenSP.BorderRadius = 16;
            this.txtTkTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTkTenSP.DefaultText = "";
            this.txtTkTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTkTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTkTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTkTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTkTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTkTenSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTkTenSP.ForeColor = System.Drawing.Color.Black;
            this.txtTkTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTkTenSP.Location = new System.Drawing.Point(28, 88);
            this.txtTkTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTkTenSP.Name = "txtTkTenSP";
            this.txtTkTenSP.PasswordChar = '\0';
            this.txtTkTenSP.PlaceholderText = "";
            this.txtTkTenSP.SelectedText = "";
            this.txtTkTenSP.Size = new System.Drawing.Size(321, 35);
            this.txtTkTenSP.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên sản phẩm:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDonViTinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGiaBanSP);
            this.groupBox1.Controls.Add(this.txtSoLuongSP);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSanPham);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtXuatXuSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 224);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txtGiaBanSP
            // 
            this.txtGiaBanSP.AutoRoundedCorners = true;
            this.txtGiaBanSP.BorderColor = System.Drawing.Color.Green;
            this.txtGiaBanSP.BorderRadius = 18;
            this.txtGiaBanSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBanSP.DefaultText = "";
            this.txtGiaBanSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaBanSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaBanSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBanSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBanSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBanSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaBanSP.ForeColor = System.Drawing.Color.Black;
            this.txtGiaBanSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBanSP.Location = new System.Drawing.Point(456, 84);
            this.txtGiaBanSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaBanSP.Name = "txtGiaBanSP";
            this.txtGiaBanSP.PasswordChar = '\0';
            this.txtGiaBanSP.PlaceholderText = "";
            this.txtGiaBanSP.SelectedText = "";
            this.txtGiaBanSP.Size = new System.Drawing.Size(202, 39);
            this.txtGiaBanSP.TabIndex = 12;
            // 
            // txtSoLuongSP
            // 
            this.txtSoLuongSP.AutoRoundedCorners = true;
            this.txtSoLuongSP.BorderColor = System.Drawing.Color.Green;
            this.txtSoLuongSP.BorderRadius = 18;
            this.txtSoLuongSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuongSP.DefaultText = "";
            this.txtSoLuongSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuongSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuongSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuongSP.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuongSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongSP.Location = new System.Drawing.Point(128, 156);
            this.txtSoLuongSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongSP.Name = "txtSoLuongSP";
            this.txtSoLuongSP.PasswordChar = '\0';
            this.txtSoLuongSP.PlaceholderText = "";
            this.txtSoLuongSP.SelectedText = "";
            this.txtSoLuongSP.Size = new System.Drawing.Size(202, 39);
            this.txtSoLuongSP.TabIndex = 11;
            // 
            // txtTenSP
            // 
            this.txtTenSP.AutoRoundedCorners = true;
            this.txtTenSP.BorderColor = System.Drawing.Color.Green;
            this.txtTenSP.BorderRadius = 18;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.DefaultText = "";
            this.txtTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenSP.ForeColor = System.Drawing.Color.Black;
            this.txtTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Location = new System.Drawing.Point(128, 84);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PasswordChar = '\0';
            this.txtTenSP.PlaceholderText = "";
            this.txtTenSP.SelectedText = "";
            this.txtTenSP.Size = new System.Drawing.Size(202, 39);
            this.txtTenSP.TabIndex = 10;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.AutoRoundedCorners = true;
            this.txtMaSanPham.BorderColor = System.Drawing.Color.Green;
            this.txtMaSanPham.BorderRadius = 18;
            this.txtMaSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSanPham.DefaultText = "";
            this.txtMaSanPham.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaSanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaSanPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSanPham.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSanPham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSanPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaSanPham.ForeColor = System.Drawing.Color.Black;
            this.txtMaSanPham.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaSanPham.Location = new System.Drawing.Point(128, 22);
            this.txtMaSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.PasswordChar = '\0';
            this.txtMaSanPham.PlaceholderText = "";
            this.txtMaSanPham.SelectedText = "";
            this.txtMaSanPham.Size = new System.Drawing.Size(202, 39);
            this.txtMaSanPham.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gía bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên sản phẩm";
            // 
            // txtXuatXuSP
            // 
            this.txtXuatXuSP.AutoRoundedCorners = true;
            this.txtXuatXuSP.BorderColor = System.Drawing.Color.Green;
            this.txtXuatXuSP.BorderRadius = 18;
            this.txtXuatXuSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXuatXuSP.DefaultText = "";
            this.txtXuatXuSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtXuatXuSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtXuatXuSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXuatXuSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXuatXuSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXuatXuSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtXuatXuSP.ForeColor = System.Drawing.Color.Black;
            this.txtXuatXuSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXuatXuSP.Location = new System.Drawing.Point(456, 22);
            this.txtXuatXuSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXuatXuSP.Name = "txtXuatXuSP";
            this.txtXuatXuSP.PasswordChar = '\0';
            this.txtXuatXuSP.PlaceholderText = "";
            this.txtXuatXuSP.SelectedText = "";
            this.txtXuatXuSP.Size = new System.Drawing.Size(202, 39);
            this.txtXuatXuSP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Xuất xứ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // btnThemSP
            // 
            this.btnThemSP.AutoRoundedCorners = true;
            this.btnThemSP.BorderRadius = 21;
            this.btnThemSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemSP.FillColor = System.Drawing.Color.Green;
            this.btnThemSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemSP.ForeColor = System.Drawing.Color.White;
            this.btnThemSP.Location = new System.Drawing.Point(129, 649);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(135, 45);
            this.btnThemSP.TabIndex = 15;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.AutoRoundedCorners = true;
            this.btnSuaSP.BorderRadius = 21;
            this.btnSuaSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaSP.FillColor = System.Drawing.Color.Green;
            this.btnSuaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaSP.ForeColor = System.Drawing.Color.White;
            this.btnSuaSP.Location = new System.Drawing.Point(367, 649);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(135, 45);
            this.btnSuaSP.TabIndex = 22;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.AutoRoundedCorners = true;
            this.btnXoaSP.BorderRadius = 21;
            this.btnXoaSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaSP.FillColor = System.Drawing.Color.Green;
            this.btnXoaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.Location = new System.Drawing.Point(616, 649);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(135, 45);
            this.btnXoaSP.TabIndex = 23;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // btnLamMoiSP
            // 
            this.btnLamMoiSP.AutoRoundedCorners = true;
            this.btnLamMoiSP.BorderRadius = 21;
            this.btnLamMoiSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoiSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoiSP.FillColor = System.Drawing.Color.Green;
            this.btnLamMoiSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoiSP.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiSP.Location = new System.Drawing.Point(859, 649);
            this.btnLamMoiSP.Name = "btnLamMoiSP";
            this.btnLamMoiSP.Size = new System.Drawing.Size(135, 45);
            this.btnLamMoiSP.TabIndex = 24;
            this.btnLamMoiSP.Text = "Làm mới";
            this.btnLamMoiSP.Click += new System.EventHandler(this.btnLamMoiSP_Click);
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.AutoRoundedCorners = true;
            this.txtDonViTinh.BorderColor = System.Drawing.Color.Green;
            this.txtDonViTinh.BorderRadius = 18;
            this.txtDonViTinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonViTinh.DefaultText = "";
            this.txtDonViTinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonViTinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonViTinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonViTinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonViTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonViTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDonViTinh.ForeColor = System.Drawing.Color.Black;
            this.txtDonViTinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonViTinh.Location = new System.Drawing.Point(456, 156);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.PasswordChar = '\0';
            this.txtDonViTinh.PlaceholderText = "";
            this.txtDonViTinh.SelectedText = "";
            this.txtDonViTinh.Size = new System.Drawing.Size(202, 39);
            this.txtDonViTinh.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Đơn vị tính";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1133, 706);
            this.Controls.Add(this.btnLamMoiSP);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnSuaSP);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.dgSP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemSP;
        private Guna.UI2.WinForms.Guna2TextBox txtTkTenSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtXuatXuSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaBanSP;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuongSP;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSP;
        private Guna.UI2.WinForms.Guna2TextBox txtMaSanPham;
        private Guna.UI2.WinForms.Guna2Button btnThemSP;
        private Guna.UI2.WinForms.Guna2Button btnSuaSP;
        private Guna.UI2.WinForms.Guna2Button btnXoaSP;
        private Guna.UI2.WinForms.Guna2Button btnLamMoiSP;
        private Guna.UI2.WinForms.Guna2TextBox txtDonViTinh;
        private System.Windows.Forms.Label label7;
    }
}