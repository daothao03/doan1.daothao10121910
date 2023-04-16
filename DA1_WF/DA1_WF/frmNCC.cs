using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Entities;

namespace DA1_WF
{
    public partial class frmNCC : Form
    {
        BLLNCC bllncc = new BLLNCC();
        public frmNCC()
        {
            InitializeComponent();
        }

        private void New()
        {
            load(dgNCC, tb(bllncc.getAll()));
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            New();
        }

        private DataGridView load(DataGridView dg, DataTable tb)
        {
            dg.DataSource = tb;
            dg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return dg;
        }

        private DataTable tb(List<ncc> list)
        {
            //List<ncc> list = bllncc.getAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhà cung cấp");
            dt.Columns.Add("Tên nhà cung cấp");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("Địa chỉ");
            foreach(ncc n in list)
            {
                DataRow row = dt.NewRow();
                row["Mã nhà cung cấp"] = n.mancc;
                row["Tên nhà cung cấp"] = n.tenncc;
                row["Số điện thoại"] = n.sdt;
                row["Địa chỉ"] = n.diachi;
                dt.Rows.Add(row);
            }
            return dt;
        }

        private void btnLamMoiNCC_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDcNCC.Text = "";
            txtSdtNCC.Text = "";
            txtMaNCC.Focus();
            New();
        }

        private void dgNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int hang = e.RowIndex;
            txtMaNCC.Text = dgNCC[0, hang].Value.ToString();
            txtTenNCC.Text = dgNCC[1, hang].Value.ToString();
            txtSdtNCC.Text = dgNCC[2, hang].Value.ToString();
            txtDcNCC.Text = dgNCC[3, hang].Value.ToString();

        }

        private void btnCapNhatNCC_Click(object sender, EventArgs e)
        {
            ncc n = new ncc();
            n.mancc = txtMaNCC.Text;
            n.tenncc = txtTenNCC.Text;
            n.sdt =int.Parse( txtSdtNCC.Text);
            n.diachi = txtDcNCC.Text;

            bllncc.insert(n);
            MessageBox.Show("Thêm thành công");
            New();
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            ncc n = new ncc();
            n.mancc = txtMaNCC.Text;
            n.tenncc = txtTenNCC.Text;
            n.sdt = int.Parse(txtSdtNCC.Text);
            n.diachi = txtDcNCC.Text;

            bllncc.edit(n);
            MessageBox.Show("Sửa thành công");
            New();
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            ncc nc = new ncc();

            bllncc.delete(txtMaNCC.Text);
            MessageBox.Show("Xóa thành công");
            New();
        }

        private void btnTimKiemNCC_Click(object sender, EventArgs e)
        {
            List<SP_SearchNCC_Result> lncc = bllncc.Search(txtTkTenNcc.Text);
            List<ncc> listncc = bllncc.getAll();
            List<ncc> list = new List<ncc>();
            foreach (var i in lncc)
            {
                foreach (var j in listncc)
                {
                    if (i.mancc == j.mancc)
                    {
                        list.Add(j);
                    }
                }
            }
            load(dgNCC, tb(list));
        }
    }
}
