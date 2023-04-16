using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DALLogin
    {
        myphamEntities mp = new myphamEntities();
        public NhanVien getUser(string un, string pw)
        {
            NhanVien user = (from u in mp.NhanViens
                             where u.maNV == un && u.pw == pw
                             select u).FirstOrDefault<NhanVien>();
            return user;
        }
    }
}
