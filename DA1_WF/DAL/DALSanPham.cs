using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DALSanPham
    {
        myphamEntities mp = new myphamEntities();

        public List<sanpham> getAll()
        {
            return mp.sanphams.ToList();
        }

        public void insert(sanpham sp)
        {
            mp.sanphams.Add(sp);
            mp.SaveChanges();
        }

        public void edit(sanpham sp)
        {
            sanpham s = mp.sanphams.Find(sp.masp);
            if(s != null)
            {
                s.tensp = sp.tensp;
                s.donvitinh = sp.donvitinh;
                s.xuatxu = sp.xuatxu;
                s.giaban = sp.giaban;
                s.soluong = sp.soluong;
            }
            mp.SaveChanges();
        }

        public void delete(string masp)
        {
            sanpham sp = mp.sanphams.Find(masp);
            mp.sanphams.Remove(sp);
            mp.SaveChanges();
        }

        public List<SP_SearchSP_Result> Search(string ten)
        {
            return mp.SP_SearchSP(ten).ToList();
        }
    }
}
