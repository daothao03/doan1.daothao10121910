using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DALHoaDonBan
    {
        myphamEntities mp = new myphamEntities();
        public List<hoadonban> getAll()
        {
            return mp.hoadonbans.ToList();
        }

        public void insert(hoadonban hdb)
        {
            mp.hoadonbans.Add(hdb);
            mp.SaveChanges();
        }

        public void edit(hoadonban h)
        {
            hoadonban hdb = mp.hoadonbans.Find(h.mahdb);
            if(hdb != null)
            {
                hdb.maNV = h.maNV;
                hdb.maKH = h.maKH;
                hdb.ngayBan = h.ngayBan;
                hdb.hinhthucthanhtoan = h.hinhthucthanhtoan;
            }
            mp.SaveChanges();
        }

        public void delete(string ma)
        {
            hoadonban h = mp.hoadonbans.Find(ma);
            mp.hoadonbans.Remove(h);
            mp.SaveChanges();
        }

        public List<SearchHDB_Result> Search(DateTime tungay, DateTime denngay, int sdt)
        {
            return mp.SearchHDB(tungay, denngay, sdt).ToList<SearchHDB_Result>();
        }
    }
}
