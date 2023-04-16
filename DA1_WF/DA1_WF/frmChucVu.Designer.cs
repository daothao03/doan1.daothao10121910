namespace DA1_WF
{
    partial class frmChucVu
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
            this.dgChucVu = new System.Windows.Forms.DataGridView();
            this.txtMoTaChucVu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenChucVu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaChucVu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoatChucvu = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoiChucvu = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaChucVu = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaChucvu = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemChucvu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgChucVu
            // 
            this.dgChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChucVu.Location = new System.Drawing.Point(17, 257);
            this.dgChucVu.Name = "dgChucVu";
            this.dgChucVu.RowHeadersWidth = 51;
            this.dgChucVu.RowTemplate.Height = 24;
            this.dgChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChucVu.Size = new System.Drawing.Size(912, 304);
            this.dgChucVu.TabIndex = 38;
            this.dgChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChucVu_CellClick);
            // 
            // txtMoTaChucVu
            // 
            this.txtMoTaChucVu.AutoRoundedCorners = true;
            this.txtMoTaChucVu.BorderColor = System.Drawing.Color.Green;
            this.txtMoTaChucVu.BorderRadius = 47;
            this.txtMoTaChucVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTaChucVu.DefaultText = "";
            this.txtMoTaChucVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTaChucVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTaChucVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTaChucVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTaChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTaChucVu.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtMoTaChucVu.ForeColor = System.Drawing.Color.Black;
            this.txtMoTaChucVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTaChucVu.Location = new System.Drawing.Point(140, 139);
            this.txtMoTaChucVu.Name = "txtMoTaChucVu";
            this.txtMoTaChucVu.PasswordChar = '\0';
            this.txtMoTaChucVu.PlaceholderText = "";
            this.txtMoTaChucVu.SelectedText = "";
            this.txtMoTaChucVu.Size = new System.Drawing.Size(765, 97);
            this.txtMoTaChucVu.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Mô tả";
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.AutoRoundedCorners = true;
            this.txtTenChucVu.BorderColor = System.Drawing.Color.Green;
            this.txtTenChucVu.BorderRadius = 15;
            this.txtTenChucVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenChucVu.DefaultText = "";
            this.txtTenChucVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenChucVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenChucVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenChucVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenChucVu.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtTenChucVu.ForeColor = System.Drawing.Color.Black;
            this.txtTenChucVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenChucVu.Location = new System.Drawing.Point(140, 76);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.PasswordChar = '\0';
            this.txtTenChucVu.PlaceholderText = "";
            this.txtTenChucVu.SelectedText = "";
            this.txtTenChucVu.Size = new System.Drawing.Size(221, 32);
            this.txtTenChucVu.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên chức vụ";
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.AutoRoundedCorners = true;
            this.txtMaChucVu.BorderColor = System.Drawing.Color.Green;
            this.txtMaChucVu.BorderRadius = 15;
            this.txtMaChucVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaChucVu.DefaultText = "";
            this.txtMaChucVu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaChucVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaChucVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaChucVu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaChucVu.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.txtMaChucVu.ForeColor = System.Drawing.Color.Black;
            this.txtMaChucVu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaChucVu.Location = new System.Drawing.Point(140, 12);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.PasswordChar = '\0';
            this.txtMaChucVu.PlaceholderText = "";
            this.txtMaChucVu.SelectedText = "";
            this.txtMaChucVu.Size = new System.Drawing.Size(221, 32);
            this.txtMaChucVu.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã chức vụ";
            // 
            // btnThoatChucvu
            // 
            this.btnThoatChucvu.AutoRoundedCorners = true;
            this.btnThoatChucvu.BorderRadius = 17;
            this.btnThoatChucvu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoatChucvu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoatChucvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoatChucvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoatChucvu.FillColor = System.Drawing.Color.Green;
            this.btnThoatChucvu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoatChucvu.ForeColor = System.Drawing.Color.White;
            this.btnThoatChucvu.Location = new System.Drawing.Point(755, 587);
            this.btnThoatChucvu.Name = "btnThoatChucvu";
            this.btnThoatChucvu.Size = new System.Drawing.Size(118, 37);
            this.btnThoatChucvu.TabIndex = 43;
            this.btnThoatChucvu.Text = "Thoát";
            this.btnThoatChucvu.Click += new System.EventHandler(this.btnThoatChucvu_Click);
            // 
            // btnLamMoiChucvu
            // 
            this.btnLamMoiChucvu.AutoRoundedCorners = true;
            this.btnLamMoiChucvu.BorderRadius = 17;
            this.btnLamMoiChucvu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiChucvu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoiChucvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoiChucvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoiChucvu.FillColor = System.Drawing.Color.Green;
            this.btnLamMoiChucvu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoiChucvu.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiChucvu.Location = new System.Drawing.Point(544, 587);
            this.btnLamMoiChucvu.Name = "btnLamMoiChucvu";
            this.btnLamMoiChucvu.Size = new System.Drawing.Size(117, 37);
            this.btnLamMoiChucvu.TabIndex = 42;
            this.btnLamMoiChucvu.Text = "Làm mới";
            this.btnLamMoiChucvu.Click += new System.EventHandler(this.btnLamMoiHDB_Click);
            // 
            // btnXoaChucVu
            // 
            this.btnXoaChucVu.AutoRoundedCorners = true;
            this.btnXoaChucVu.BorderRadius = 17;
            this.btnXoaChucVu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaChucVu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaChucVu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaChucVu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaChucVu.FillColor = System.Drawing.Color.Green;
            this.btnXoaChucVu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaChucVu.ForeColor = System.Drawing.Color.White;
            this.btnXoaChucVu.Location = new System.Drawing.Point(377, 587);
            this.btnXoaChucVu.Name = "btnXoaChucVu";
            this.btnXoaChucVu.Size = new System.Drawing.Size(109, 37);
            this.btnXoaChucVu.TabIndex = 41;
            this.btnXoaChucVu.Text = "Xóa";
            this.btnXoaChucVu.Click += new System.EventHandler(this.btnXoaChucVu_Click);
            // 
            // btnSuaChucvu
            // 
            this.btnSuaChucvu.AutoRoundedCorners = true;
            this.btnSuaChucvu.BorderRadius = 17;
            this.btnSuaChucvu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaChucvu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaChucvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaChucvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaChucvu.FillColor = System.Drawing.Color.Green;
            this.btnSuaChucvu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaChucvu.ForeColor = System.Drawing.Color.White;
            this.btnSuaChucvu.Location = new System.Drawing.Point(211, 587);
            this.btnSuaChucvu.Name = "btnSuaChucvu";
            this.btnSuaChucvu.Size = new System.Drawing.Size(100, 37);
            this.btnSuaChucvu.TabIndex = 40;
            this.btnSuaChucvu.Text = "Sửa";
            this.btnSuaChucvu.Click += new System.EventHandler(this.btnSuaChucvu_Click);
            // 
            // btnThemChucvu
            // 
            this.btnThemChucvu.AutoRoundedCorners = true;
            this.btnThemChucvu.BorderRadius = 17;
            this.btnThemChucvu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemChucvu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemChucvu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemChucvu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemChucvu.FillColor = System.Drawing.Color.Green;
            this.btnThemChucvu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemChucvu.ForeColor = System.Drawing.Color.White;
            this.btnThemChucvu.Location = new System.Drawing.Point(52, 587);
            this.btnThemChucvu.Name = "btnThemChucvu";
            this.btnThemChucvu.Size = new System.Drawing.Size(95, 37);
            this.btnThemChucvu.TabIndex = 39;
            this.btnThemChucvu.Text = "Thêm";
            this.btnThemChucvu.Click += new System.EventHandler(this.btnThemChucvu_Click);
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(944, 638);
            this.Controls.Add(this.btnThoatChucvu);
            this.Controls.Add(this.btnLamMoiChucvu);
            this.Controls.Add(this.btnXoaChucVu);
            this.Controls.Add(this.btnSuaChucvu);
            this.Controls.Add(this.btnThemChucvu);
            this.Controls.Add(this.dgChucVu);
            this.Controls.Add(this.txtMoTaChucVu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenChucVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaChucVu);
            this.Controls.Add(this.label1);
            this.Name = "frmChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChucVu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChucVu_FormClosed);
            this.Load += new System.EventHandler(this.frmChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgChucVu;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTaChucVu;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtTenChucVu;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMaChucVu;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnThoatChucvu;
        private Guna.UI2.WinForms.Guna2Button btnLamMoiChucvu;
        private Guna.UI2.WinForms.Guna2Button btnXoaChucVu;
        private Guna.UI2.WinForms.Guna2Button btnSuaChucvu;
        private Guna.UI2.WinForms.Guna2Button btnThemChucvu;
    }
}