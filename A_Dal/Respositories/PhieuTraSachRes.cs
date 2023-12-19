using A_Dal.Context;
using A_Dal.DomainClass;
using A_Dal.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Dal.Respositories
{
    public class PhieuTraSachRes : IPhieuTraRes
    {
        public bool AddPhieuTra(PhieuTraSach phieuTraSach)
        {
            try
            {
                dbConnection._dbDuAn.PhieuTraSaches.Add(phieuTraSach);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<PhieuTraSach> GetAllPhieuTra()
        {
            return dbConnection._dbDuAn.PhieuTraSaches.ToList();
        }

        public bool UpdatePhieuTra(PhieuTraSach phieuTraSach)
        {
            try
            {
                dbConnection._dbDuAn.PhieuTraSaches.Update(phieuTraSach);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
