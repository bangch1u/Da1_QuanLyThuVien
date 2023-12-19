using A_Dal.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Dal.IRepositories
{
    public interface ISachCTRes
    {
        List<SachChiTiet?> getAll(string Id);
        List<SachChiTiet?> getAll2();
        List<SachChiTiet?> getAll3(string tenSach);
        public bool UpdateSCT(SachChiTiet sachChiTiet);
        public bool AddSCT(SachChiTiet sachChiTiet);
        public string GetTenSachBySct(string Id);
    }
}
