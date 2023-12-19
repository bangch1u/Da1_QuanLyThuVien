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
    public class LichSuNapRes : ILichSuNapRes
    {
        public bool AddLichSuNap(LichSuNap lichSuNap)
        {
            try
            {
                dbConnection._dbDuAn.LichSuNaps.Add(lichSuNap);
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
