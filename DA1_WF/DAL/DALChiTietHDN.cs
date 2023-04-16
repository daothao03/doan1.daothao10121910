using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    
    public class DALChiTietHDN
    {
        myphamEntities mp = new myphamEntities();
        
        public List<chitiethdn> getAll()
        {
            return mp.chitiethdns.ToList();
        }

        public void insert(chitiethdn c)
        {
            mp.chitiethdns.Add(c);
            mp.SaveChanges();
        }

        public void edit(chitiethdn c)
        {
            chitiethdn ct = mp.chitiethdns.Find(c.mahdn, c.maSP);
            if (ct != null)
            {
                ct.soluong = c.soluong;
                ct.gianhap = c.gianhap;
            }
        }

        public void delete(string mahdn, string masp)
        {
            chitiethdn h = mp.chitiethdns.Find(mahdn, masp);
            mp.chitiethdns.Remove(h);
            mp.SaveChanges();
        }
    }
}
