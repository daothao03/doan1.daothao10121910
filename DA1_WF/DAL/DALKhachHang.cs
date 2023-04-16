using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DALKhachHang
    {
        myphamEntities mp = new myphamEntities();

        public List<khachhang> getAll()
        {
            return mp.khachhangs.ToList();
        }

        public void insert(khachhang kh)
        {
            mp.khachhangs.Add(kh);
            mp.SaveChanges();
        }

        public void edit(khachhang kh)
        {
            khachhang k = mp.khachhangs.Find(kh.maKH);
            if(k!= null)
            {
                k.hoten = kh.hoten;
                k.sdt = kh.sdt;
            }
            mp.SaveChanges();           
        }

        public void delete(string ma)
        {
            khachhang kh = mp.khachhangs.Find(ma);
            mp.khachhangs.Remove(kh);
            mp.SaveChanges();
        }

        public List<SP_SearchKH_Result> Search(int sdt)
        {
            return mp.SP_SearchKH(sdt).ToList();
        }
    }
}
