using BLL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA1_WF
{
    public partial class frmHDB : Form
    {
        
        BLLHoaDonBan bllhdb = new BLLHoaDonBan();
        BLLKhachHang bllkh = new BLLKhachHang();        
        public static hoadonban hdb = new hoadonban();
        public static string SDT = ""; 

        public frmHDB()
        {
            InitializeComponent();
        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void LamMoi()
        {
            BLLHoaDonBan hdb = new BLLHoaDonBan();
            dtNgayBan.Value = DateTime.Now;
            AutoCompleteStringCollection suggest = new AutoCompleteStringCollection();
            txtSdtKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSdtKH.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach(var i in bllkh.getAll())
            {
                suggest.Add(i.sdt.ToString());
            }

            txtSdtKH.AutoCompleteCustomSource = suggest;
            cbbHTTT.Items.AddRange(new string[] { "Trả tiền mặt", "Banking" });
            //loadcbbSDT();
            load(dgHDB, tb(hdb.getAll()));
        }
        private void btnLamMoiHDB_Click(object sender, EventArgs e)
        {
            txtMaHDB.Text = "";
            txtMaNVKH.Text = "";
            dtNgayBan.Value = DateTime.Now;
            //cbbSdtKH.Items.Clear();
            txtSdtKH.Text = "";
            txtTenKH.Text = "";
            cbbHTTT.Items.Clear();
            txtMaHDB.Focus();
            
            LamMoi();
        }

        private void btndskh_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
        }

        private void dgHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaHDB.Text = dgHDB.CurrentRow.Cells["Mã hóa đơn"].Value.ToString();
            txtMaNVKH.Text = dgHDB.CurrentRow.Cells["Nhân viên bán hàng"].Value.ToString();
            cbbHTTT.SelectedItem = dgHDB.CurrentRow.Cells["Hình thức thanh toán"].Value.ToString();
            txtSdtKH.Text= dgHDB.CurrentRow.Cells["Số điện thoại"].Value.ToString();
            //cbbSdtKH.SelectedItem = dgHDB.CurrentRow.Cells["Số điện thoại"].Value.ToString();
            txtTenKH.Text = dgHDB.CurrentRow.Cells["Tên khách hàng"].Value.ToString();
            dtNgayBan.Value = DateTime.Parse(dgHDB.CurrentRow.Cells["Ngày bán"].Value.ToString());
        }

        private void loadcbbSDT()
        {
            //List<khachhang> list = bllkh.getAll();
            //foreach(var i in list)
            //{
            //    cbbSdtKH.Items.Add(i.sdt);
            //}
        }
        private void frmHDB_Load(object sender, EventArgs e)
        {
            //dtNgayBan.Value = DateTime.Now;
            //AutoCompleteStringCollection suggest = new AutoCompleteStringCollection();
            //cbbSdtKH.AutoCompleteMode = AutoCompleteMode.None;
            //cbbSdtKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //cbbHTTT.Items.AddRange(new string[] { "Trả tiền mặt", "Banking" });
            //loadcbbSDT();
            LamMoi();
            //load(dgHDB, tb());
        }

        private DataGridView load(DataGridView dg, DataTable tb)
        {
            dg.DataSource = tb;
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
           // dg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return dg;
        }

        private DataTable tb(List<hoadonban> hdb)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hóa đơn");
            dt.Columns.Add("Nhân viên bán hàng");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Ngày bán");
            dt.Columns.Add("Hình thức thanh toán");
            foreach (hoadonban h in hdb)
            {
                DataRow row = dt.NewRow();
                row["Mã hóa đơn"] = h.mahdb;
                row["Ngày bán"] = h.ngayBan;
                row["Hình thức thanh toán"] = h.hinhthucthanhtoan;
                row["Nhân viên bán hàng"] = h.NhanVien.hoten;
                row["Số điện thoại"] = h.khachhang.sdt;
                row["Tên khách hàng"] = h.khachhang.hoten;
                dt.Rows.Add(row);
            }
            return dt;
        } 

        private void OpenForm(Form f, object btnSender)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            //this.frmHDB.Controls.Add(childForm);
            //this.pnChild.Tag = childForm;
            f.BringToFront();
            f.Show();
        }

        private void HienThiCTHD(string ma, object sender)
        {
            BLLHoaDonBan bllhdb = new BLLHoaDonBan();
            string mahdb = ma;
            foreach (var i in bllhdb.getAll())
            {
                if (mahdb == i.mahdb)
                {
                    hdb = i;
                    break;
                }
            }
            frmCTHDB frm = new frmCTHDB(this);
            //OpenForm(frm, sender);
            frm.ShowDialog();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            hoadonban hdb = new hoadonban();
            List<khachhang> kh = bllkh.getAll();
            hdb.mahdb = txtMaHDB.Text;
            hdb.maNV = txtMaNVKH.Text;
            foreach (var i in kh)
            {
                //if (i.sdt.ToString() == (cbbSdtKH.SelectedItem + "").Trim())
                if (i.sdt.ToString() == txtSdtKH.Text)
                {
                    hdb.maKH = i.maKH;
                    break;
                }
            }
            hdb.hinhthucthanhtoan = cbbHTTT.SelectedItem + "";
            hdb.ngayBan = dtNgayBan.Value;
            bllhdb.insert(hdb);
            MessageBox.Show("Thêm thành công");
            HienThiCTHD(txtMaHDB.Text,sender);
            LamMoi();
            //load(dgHDB, tb());

        }

        private void btnSuaHDB_Click(object sender, EventArgs e)
        {
            hoadonban hdb = new hoadonban();
            List<khachhang> kh = bllkh.getAll();
            hdb.mahdb = txtMaHDB.Text;
            hdb.maNV = txtMaNVKH.Text;
            foreach (var i in kh)
            {
                //if (i.sdt.ToString() == (cbbSdtKH.SelectedItem + "").Trim())
                if (i.sdt.ToString() == txtSdtKH.Text)
                {
                    hdb.maKH = i.maKH;
                    break;
                }
            }
            hdb.hinhthucthanhtoan = cbbHTTT.SelectedItem + "";
            hdb.ngayBan = dtNgayBan.Value;

            bllhdb.edit(hdb);
            MessageBox.Show("Sửa thành công");
            LamMoi();
        }

        private void btnXoaHDB_Click(object sender, EventArgs e)
        {
            bllhdb.delete(txtMaHDB.Text);
            MessageBox.Show("Xóa thành công");
            LamMoi();
        }

        private void txtSdtKH_TextChanged(object sender, EventArgs e)
        {
            List<khachhang> list = bllkh.getAll();
            txtTenKH.Text = "";
            foreach (var i in list)
            {
                if (txtSdtKH.Text == i.sdt.ToString())
                {
                    txtTenKH.Text = i.hoten;
                    break;
                }
            }
            if (txtTenKH.Text == "" && txtSdtKH.Text.Length == 10)
            {
                btndskh.Text = "Thêm khách hàng";
                SDT = txtSdtKH.Text;
            }
            else
            {
                btndskh.Text = "Quản lý khách hàng";
            }
        }

        private void dgHDB_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahd = txtMaHDB.Text = dgHDB.CurrentRow.Cells["Mã hóa đơn"].Value.ToString();
            if (mahd != "")
            {
                HienThiCTHD(mahd, sender);
            }
        }

        private void btnTimKiemHDB_Click(object sender, EventArgs e)
        {
            List<SearchHDB_Result> listsp = bllhdb.SearchHDB(dtTuNgay.Value, dtDenNgay.Value, int.Parse(txtTkHDBbSDT.Text));
            List<hoadonban> listhdb = bllhdb.getAll();
            List<hoadonban> list = new List<hoadonban>();
            foreach (var i in listsp)
            {
                foreach (var j in listhdb)
                {
                    if (i.mahdb == j.mahdb)
                    {
                        list.Add(j);
                    }
                }
            }
            load(dgHDB, tb(list));
        }

        private void btnInHDB_Click(object sender, EventArgs e)
        {
            frmInHDB frm = new frmInHDB();
            frm.ShowDialog();
        }
    }
}
