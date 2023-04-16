namespace DA1_WF
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitMain = new System.Windows.Forms.Button();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLHDN = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLHDB = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnQLNV = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.btnExitMain);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnQLHDN);
            this.panel1.Controls.Add(this.btnQLHDB);
            this.panel1.Controls.Add(this.btnQLSP);
            this.panel1.Controls.Add(this.btnQLNV);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 508);
            this.panel1.TabIndex = 2;
            // 
            // btnExitMain
            // 
            this.btnExitMain.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExitMain.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitMain.ForeColor = System.Drawing.Color.White;
            this.btnExitMain.Location = new System.Drawing.Point(225, 458);
            this.btnExitMain.Name = "btnExitMain";
            this.btnExitMain.Size = new System.Drawing.Size(103, 35);
            this.btnExitMain.TabIndex = 5;
            this.btnExitMain.Text = "Exit";
            this.btnExitMain.UseVisualStyleBackColor = false;
            this.btnExitMain.Click += new System.EventHandler(this.btnExitMain_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.AutoRoundedCorners = true;
            this.btnThongKe.BorderRadius = 29;
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.FillColor = System.Drawing.Color.DarkGreen;
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = global::DA1_WF.Properties.Resources.kisspng_statistics_computer_icons_statistics_icon_5b4574b685ccc4_9604191915312785185481_removebg_preview;
            this.btnThongKe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongKe.ImageSize = new System.Drawing.Size(35, 35);
            this.btnThongKe.Location = new System.Drawing.Point(16, 372);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(328, 61);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnQLHDN
            // 
            this.btnQLHDN.AutoRoundedCorners = true;
            this.btnQLHDN.BorderRadius = 28;
            this.btnQLHDN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLHDN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLHDN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLHDN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLHDN.FillColor = System.Drawing.Color.DarkGreen;
            this.btnQLHDN.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHDN.ForeColor = System.Drawing.Color.White;
            this.btnQLHDN.Image = global::DA1_WF.Properties.Resources.bill_removebg_preview;
            this.btnQLHDN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLHDN.ImageSize = new System.Drawing.Size(40, 30);
            this.btnQLHDN.Location = new System.Drawing.Point(16, 289);
            this.btnQLHDN.Name = "btnQLHDN";
            this.btnQLHDN.PressedColor = System.Drawing.Color.Transparent;
            this.btnQLHDN.Size = new System.Drawing.Size(328, 59);
            this.btnQLHDN.TabIndex = 3;
            this.btnQLHDN.Text = "Hóa đơn nhập";
            this.btnQLHDN.Click += new System.EventHandler(this.btnQLHDN_Click);
            // 
            // btnQLHDB
            // 
            this.btnQLHDB.AutoRoundedCorners = true;
            this.btnQLHDB.BorderRadius = 28;
            this.btnQLHDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLHDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLHDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLHDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLHDB.FillColor = System.Drawing.Color.DarkGreen;
            this.btnQLHDB.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHDB.ForeColor = System.Drawing.Color.White;
            this.btnQLHDB.Image = global::DA1_WF.Properties.Resources.kisspng_payment_card_credit_card_computer_icons_cheque_payment_icon_credit_payment_icon_5ab07ae60116e8_8012353815215152380045_removebg_preview;
            this.btnQLHDB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLHDB.ImageSize = new System.Drawing.Size(35, 35);
            this.btnQLHDB.Location = new System.Drawing.Point(16, 203);
            this.btnQLHDB.Name = "btnQLHDB";
            this.btnQLHDB.Size = new System.Drawing.Size(328, 58);
            this.btnQLHDB.TabIndex = 2;
            this.btnQLHDB.Text = "Hóa đơn bán";
            this.btnQLHDB.Click += new System.EventHandler(this.btnQLHDB_Click);
            // 
            // btnQLSP
            // 
            this.btnQLSP.AutoRoundedCorners = true;
            this.btnQLSP.BorderRadius = 27;
            this.btnQLSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLSP.FillColor = System.Drawing.Color.DarkGreen;
            this.btnQLSP.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSP.ForeColor = System.Drawing.Color.White;
            this.btnQLSP.Image = global::DA1_WF.Properties.Resources._54681549_a00f_4ad5_9e1e_e56f2a01fc52;
            this.btnQLSP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLSP.ImageSize = new System.Drawing.Size(30, 30);
            this.btnQLSP.Location = new System.Drawing.Point(16, 119);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Size = new System.Drawing.Size(328, 56);
            this.btnQLSP.TabIndex = 1;
            this.btnQLSP.Text = "Quản lý sản phẩm";
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.AutoRoundedCorners = true;
            this.btnQLNV.BorderRadius = 29;
            this.btnQLNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQLNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQLNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQLNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQLNV.FillColor = System.Drawing.Color.DarkGreen;
            this.btnQLNV.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnQLNV.ForeColor = System.Drawing.Color.White;
            this.btnQLNV.Image = global::DA1_WF.Properties.Resources._5087592;
            this.btnQLNV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQLNV.ImageSize = new System.Drawing.Size(40, 40);
            this.btnQLNV.Location = new System.Drawing.Point(16, 32);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(328, 61);
            this.btnQLNV.TabIndex = 0;
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(481, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "TCosmetics by Thảo";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Green;
            this.guna2PictureBox1.Image = global::DA1_WF.Properties.Resources.pngtree_fresh_hand_painted_cosmetics_combination_png_image_1659787;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(346, 58);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(597, 446);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(941, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa hàng TCosmetics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2Button btnQLHDN;
        private Guna.UI2.WinForms.Guna2Button btnQLHDB;
        private Guna.UI2.WinForms.Guna2Button btnQLSP;
        private Guna.UI2.WinForms.Guna2Button btnQLNV;
        private System.Windows.Forms.Button btnExitMain;
    }
}