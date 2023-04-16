using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DALHoaDonNhap
    {
        myphamEntities mp = new myphamEntities();

        public List<hdn> getAll()
        {
            return mp.hdns.ToList();
        }

        public void insert(hdn h)
        {
            mp.hdns.Add(h);
            mp.SaveChanges();
        }

        public void edit(hdn h)
        {
            hdn hdn = mp.hdns.Find(h.mahdn);
            if(hdn != null)
            {
                hdn.manv = h.manv;
                hdn.mancc = h.mancc;
                hdn.ngayNhap = h.ngayNhap;
            }
            mp.SaveChanges();
        }

        public void delete(string mahdn)
        {
            hdn h = mp.hdns.Find(mahdn);
            mp.hdns.Remove(h);
            mp.SaveChanges();
        }
        public List<SearchHDN_Result> Search(DateTime tungay, DateTime denngay, string ten)
        {
            return mp.SearchHDN(tungay, denngay, ten).ToList<SearchHDN_Result>();
        }
    }
}
