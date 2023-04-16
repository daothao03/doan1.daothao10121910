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
    public partial class frmKhachHang : Form
    {
        BLLKhachHang bllkh = new BLLKhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void New()
        {
            txtTkSDTKH.Text = "";
            load(dgKhachHang, dt(bllkh.getAll()));
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            New();
            //load(dgKhachHang, dt(bllkh.getAll()));
        }

        private DataGridView load(DataGridView dg, DataTable dt)
        {
            dg.DataSource = dt;
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return dg;
        }

        private DataTable dt(List<khachhang> kh)
        {
            //List<khachhang> kh = bllkh.getAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Số điện thoại");
            foreach(khachhang k in kh)
            {
                DataRow row = dt.NewRow();
                row["Mã khách hàng"] = k.maKH;
                row["Tên khách hàng"] = k.hoten;
                row["Số điện thoại"] = k.sdt;
                dt.Rows.Add(row);
            }
            return dt;
        }

        private void dgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaKH.Text = dgKhachHang[0, hang].Value.ToString();
            txtTenKH.Text = dgKhachHang[1, hang].Value.ToString();
            txtSDTKH.Text = dgKhachHang[2, hang].Value.ToString();
        }

        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            khachhang kh = new khachhang();
            kh.maKH = txtMaKH.Text;
            kh.hoten = txtTenKH.Text;
            kh.sdt = int.Parse(txtSDTKH.Text);

            bllkh.insert(kh);
            MessageBox.Show("Thêm thành công");
            load(dgKhachHang, dt(bllkh.getAll()));
        }

        private void btnLamMoiKH_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDTKH.Text = "";
            txtMaKH.Focus();
            New();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            khachhang kh = new khachhang();
            kh.maKH = txtMaKH.Text;
            kh.hoten = txtTenKH.Text;
            kh.sdt = int.Parse(txtSDTKH.Text);

            bllkh.edit(kh);
            MessageBox.Show("Sửa thành công");
            load(dgKhachHang, dt(bllkh.getAll()));
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            khachhang kh = new khachhang();
            bllkh.delete(txtMaKH.Text);
            load(dgKhachHang, dt(bllkh.getAll()));
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            List<SP_SearchKH_Result> search = bllkh.Search(int.Parse(txtTkSDTKH.Text));
            List<khachhang> lkh = bllkh.getAll();
            List<khachhang> listkh = new List<khachhang>();
            foreach (var i in search)
            {
                foreach (var j in lkh)
                {
                    if (i.maKH == j.maKH)
                    {
                        listkh.Add(j);
                    }
                }
            }
            load(dgKhachHang, dt(listkh));
        }
    }
}
