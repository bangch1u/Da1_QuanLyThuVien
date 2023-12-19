using A_Dal.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Dal.IRepositories
{
    public interface IThietHaiChiTietRes
    {
        public bool AddThietHaiCT(ThietHaiChiTiet thietHaiChiTiet);
        public List<ThietHaiChiTiet> GetAllThietHaiCT();
    }
}
