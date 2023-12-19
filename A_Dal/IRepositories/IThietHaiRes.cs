using A_Dal.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Dal.IRepositories
{
    public interface IThietHaiRes
    {
        public List<ThietHai> GetAllThietHai();
        public bool AddThietHai(ThietHai thietHai);
        public bool UpdateThietHai(ThietHai thietHai);
    }
}
