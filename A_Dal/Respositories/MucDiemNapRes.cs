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
    public class MucDiemNapRes : IMucDiemNapRes
    {
        public List<MucDiemCong> GetAllMucDiemCong()
        {
            return dbConnection._dbDuAn.MucDiemCongs.ToList();
        }
    }
}
