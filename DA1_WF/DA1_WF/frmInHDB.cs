using BLL;
using DAL.Entities;
using Microsoft.Reporting.WinForms;
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
    public partial class frmInHDB : Form
    {
        public frmInHDB()
        {
            InitializeComponent();
        }
        private DataTable dthdb(string ma)
        {
            BLLHoaDonBan hdbbus = new BLLHoaDonBan();
            List<hoadonban> hdb = hdbbus.getAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("MaHDB");
            dt.Columns.Add("NhanVienBH");
            dt.Columns.Add("TenKH");
            dt.Columns.Add("SDT");
            dt.Columns.Add("NgayBan");
            //dt.Columns.Add("HTTT");

            foreach (var x in hdb)
            {
                if (x.mahdb == ma)
                {
                    DataRow row = dt.NewRow();
                    row["MaHDB"] = x.mahdb;
                    row["NhanVienBH"] = x.NhanVien.hoten;
                    row["TenKH"] = x.khachhang.hoten;
                    row["SDT"] = x.khachhang.sdt;
                    row["NgayBan"] = x.ngayBan;
                    //row["HTTT"] = x.hinhthucthanhtoan;
                    dt.Rows.Add(row);
                    break;
                }
            }
            return dt;

        }
        private DataTable dtcthdb(string ma)
        {
            BLLChiTietHDB cthdbbus = new BLLChiTietHDB();
            List<chitiethdb> cthdb = cthdbbus.getAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("TenSanPham");
            dt.Columns.Add("GiaBan", typeof(Double));
            dt.Columns.Add("SoLuong", typeof(Double));
            dt.Columns.Add("ThanhTien", typeof(Double));
            foreach (var x in cthdb)
            {
                if (x.mahdb == ma)
                {
                    double tt = (Double)(x.soluong * x.sanpham.giaban).Value;
                    DataRow row = dt.NewRow();
                    row["TenSanPham"] = x.sanpham.tensp;
                    row["GiaBan"] = (Double)x.sanpham.giaban;
                    row["SoLuong"] = (Double)x.soluong;
                    row["ThanhTien"] = tt;
                    dt.Rows.Add(row);
                }
            }
            return dt;


        }
        private void frmInHDB_Load(object sender, EventArgs e)
        {
            //using (myphamEntities mp = new myphamEntities())
            //{
            //    this.reportViewer1.LocalReport.ReportEmbeddedResource = "Report1.rdlc";

            //    ReportDataSource r = new ReportDataSource();
            //    r.Name = "DataSet1";
            //    r.Value = frmHDB.hdb.mahdb;
            //    this.reportViewer1.LocalReport.DataSources.Add(r);
            //    this.reportViewer1.RefreshReport();

            //    this.reportViewer1.LocalReport.ReportEmbeddedResource = "Report1.rdlc";

            //    ReportDataSource rds1 = new ReportDataSource();
            //    rds1.Name = "DataSet1";
            //    rds1.Value = dtcthdb(frmHDB.hdb.mahdb);
            //    ReportDataSource rds2 = new ReportDataSource();
            //    rds2.Name = "DataSet2";
            //    rds2.Value = dthdb(frmHDB.hdb.mahdb);
            //    this.reportViewer1.LocalReport.DataSources.Add(rds1);
            //    this.reportViewer1.LocalReport.DataSources.Add(rds2);
            //    this.reportViewer1.RefreshReport();
            //}
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
