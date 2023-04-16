using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class DALNCC
    {
        myphamEntities mp = new myphamEntities();
        public List<ncc> getAll()
        {
            return mp.nccs.ToList();
        }

        public void insert(ncc n)
        {
            mp.nccs.Add(n);
            mp.SaveChanges();
        }

        public void edit(ncc n)
        {
            ncc ncc = mp.nccs.Find(n.mancc);
            if (ncc != null)
            {
                ncc.tenncc = n.tenncc;
                ncc.sdt = n.sdt;
                ncc.diachi = n.diachi;
            }
            mp.SaveChanges();
        }

        public void delete(string ma)
        {
            ncc n = mp.nccs.Find(ma);
            mp.nccs.Remove(n);
            mp.SaveChanges();
        }

        public List<SP_SearchNCC_Result> Search(string ten)
        {
            return mp.SP_SearchNCC(ten).ToList();
        }
    }
}
