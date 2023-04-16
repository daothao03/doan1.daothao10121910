using BLL;
using DAL;
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
    public partial class frmSanPham : Form
    {

        BLLSanPham bllsp = new BLLSanPham();

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void New()
        {
            loadDg(dgSP, dt(bllsp.getAll()));
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            txtMaSanPham.Text = "";
            txtTenSP.Text = "";
            txtXuatXuSP.Text = "";
            txtSoLuongSP.Text = "";
            txtGiaBanSP.Text = "";
            txtTkTenSP.Text = "";
            New();
        }

        private DataGridView loadDg(DataGridView dg, DataTable dt)
        {
            dg.DataSource = dt;
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return dg;
        }

        private DataTable dt(List<sanpham> list)
        {
            //List<sanpham> list = bllsp.getAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sản phẩm");
            dt.Columns.Add("Tên sản phẩm");
            dt.Columns.Add("Đơn vị tính");
            dt.Columns.Add("Xuất xứ");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Gía bán");
            foreach (sanpham sp in list)
            {
                DataRow row = dt.NewRow();
                row["Mã sản phẩm"] = sp.masp;
                row["Tên sản phẩm"] = sp.tensp;
                row["Đơn vị tính"] = sp.donvitinh;
                row["Xuất xứ"] = sp.xuatxu;
                row["Số lượng"] = sp.soluong;
                row["Gía bán"] = sp.giaban;
                dt.Rows.Add(row);
            }
            return dt;
        }

        private void btnLamMoiSP_Click(object sender, EventArgs e)
        {
            
            New();
        }

        private void dgSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaSanPham.Text = dgSP[0, hang].Value.ToString();
            txtTenSP.Text = dgSP[1, hang].Value.ToString();
            txtDonViTinh.Text = dgSP[2, hang].Value.ToString();
            txtXuatXuSP.Text = dgSP[3, hang].Value.ToString();
            txtSoLuongSP.Text = dgSP[4, hang].Value.ToString();
            txtGiaBanSP.Text = dgSP[5, hang].Value.ToString();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            sanpham sp = new sanpham();
            sp.masp = txtMaSanPham.Text;
            sp.tensp=txtTenSP.Text;
            sp.donvitinh = txtDonViTinh.Text;
            sp.xuatxu = txtXuatXuSP.Text;
            sp.soluong = int.Parse(txtSoLuongSP.Text);
            sp.giaban = int.Parse(txtGiaBanSP.Text);

            bllsp.insert(sp);
            MessageBox.Show("Thêm thành công");
            New();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            sanpham sp = new sanpham();
            sp.masp = txtMaSanPham.Text;
            sp.tensp = txtTenSP.Text;
            sp.donvitinh = txtDonViTinh.Text;
            sp.xuatxu = txtXuatXuSP.Text;
            sp.soluong = int.Parse(txtSoLuongSP.Text);
            sp.giaban = int.Parse(txtGiaBanSP.Text);

            bllsp.edit(sp);
            MessageBox.Show("Sửa thành công");
            New();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            sanpham sp = new sanpham();
            bllsp.delete(txtMaSanPham.Text);
            New();
        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            List<SP_SearchSP_Result> lncc = bllsp.Search(txtTkTenSP.Text);
            List<sanpham> listsp = bllsp.getAll();
            List<sanpham> list = new List<sanpham>();
            foreach (var i in lncc)
            {
                foreach (var j in listsp)
                {
                    if (i.masp == j.masp)
                    {
                        list.Add(j);
                    }
                }
            }
            loadDg(dgSP, dt(list));
        }
    }
}
