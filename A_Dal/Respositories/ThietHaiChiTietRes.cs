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
    public class ThietHaiChiTietRes : IThietHaiChiTietRes
    {
        public bool AddThietHaiCT(ThietHaiChiTiet thietHaiChiTiet)
        {
            try
            {
                dbConnection._dbDuAn.ThietHaiChiTiets.Add(thietHaiChiTiet);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ThietHaiChiTiet> GetAllThietHaiCT()
        {
            return dbConnection._dbDuAn.ThietHaiChiTiets.ToList();
        }
    }
}
