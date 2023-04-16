using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.DAL
{
    public class DALChucVu
    {
        myphamEntities mp = new myphamEntities();

        public List<ChucVu> getAll()
        {
            return mp.ChucVus.ToList();
        }

        public void insert(ChucVu c)
        {
            mp.ChucVus.Add(c);
            mp.SaveChanges();
        }

        public void edit(ChucVu c)
        {
            ChucVu cv = mp.ChucVus.Find(c.maCV);
            if (cv != null)
            {
                cv.tenCV = c.tenCV;
                cv.mota = c.mota;
            }
            mp.SaveChanges();
        }

        public void delete(string ma)
        {
            ChucVu c = mp.ChucVus.Find(ma);
            mp.ChucVus.Remove(c);
            mp.SaveChanges();
        }
    }
}
