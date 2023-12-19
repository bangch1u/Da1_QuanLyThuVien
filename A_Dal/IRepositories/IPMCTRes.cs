using A_Dal.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Dal.IRepositories
{
    public interface IPMCTRes
    {
        public List<PhieuMuonChiTiet> GetAllPMCT(string id);
        public List<PhieuMuonChiTiet> GetAllPMCT2();
        public bool AddPMCT(PhieuMuonChiTiet phieuMuonChiTiet);
        public bool UpdatePMCT(PhieuMuonChiTiet phieuMuonChiTiet);
    }
}
