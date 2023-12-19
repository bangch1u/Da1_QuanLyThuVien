using A_Dal.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Dal.IRepositories
{
    public interface IMucDiemNapRes
    {
        public List<MucDiemCong> GetAllMucDiemCong();
    }
}
