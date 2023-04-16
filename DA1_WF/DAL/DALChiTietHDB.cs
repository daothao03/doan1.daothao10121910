using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DALChiTietHDB
    {
        myphamEntities mp = new myphamEntities();
        public List<chitiethdb> getAll()
        {
            return mp.chitiethdbs.ToList();
        }

        public void insert(chitiethdb c)
        {
            mp.chitiethdbs.Add(c);
            mp.SaveChanges();
        }

        public void edit(chitiethdb c)
        {
            chitiethdb ct = mp.chitiethdbs.Find(c.mahdb, c.maSP);
            if (ct != null)
            {
                ct.soluong = c.soluong;
            }
            mp.SaveChanges();
        }

        public void delete(string mahdb, string masp)
        {
            chitiethdb c = mp.chitiethdbs.Find(mahdb, masp);
            mp.chitiethdbs.Remove(c);
            mp.SaveChanges();
        }
    }
}
