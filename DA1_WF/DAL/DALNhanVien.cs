using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DALNhanVien
    {
        myphamEntities mp = new myphamEntities();
        public List<NhanVien> getAll()
        {
            return mp.NhanViens.ToList();
        }

        public void insert(NhanVien nv)
        {
            mp.NhanViens.Add(nv);
            mp.SaveChanges();
        }

        public void edit(NhanVien nv)
        {
            NhanVien n = mp.NhanViens.Find(nv.maNV);
            
            if(n != null)
            {
                n.hoten = nv.hoten;
                n.namsinh = nv.namsinh;
                n.sdt = nv.sdt;
                n.maCV = nv.maCV;
                n.gioitinh = nv.gioitinh;
                n.pw = nv.pw;
            }
            mp.SaveChanges();
        }

        public void delete(string ma)
        {
            NhanVien nv = mp.NhanViens.Find(ma);
            mp.NhanViens.Remove(nv);
            mp.SaveChanges();
        }

        public List<SP_SearchNV_Result> Search(int sdt)
        {
            return mp.SP_SearchNV(sdt).ToList();
        }
    }
}
