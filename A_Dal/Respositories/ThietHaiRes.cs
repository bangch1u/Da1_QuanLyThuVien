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
    public class ThietHaiRes : IThietHaiRes
    {
        public bool AddThietHai(ThietHai thietHai)
        {
            try
            {
                dbConnection._dbDuAn.ThietHais.Add(thietHai);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ThietHai> GetAllThietHai()
        {
            return dbConnection._dbDuAn.ThietHais.ToList();
        }

        public bool UpdateThietHai(ThietHai thietHai)
        {
            try
            {
                dbConnection._dbDuAn.ThietHais.Update(thietHai);
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
