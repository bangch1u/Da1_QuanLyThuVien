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
    public class PhieuMuonChiTietRes : IPMCTRes
    {
        public bool AddPMCT(PhieuMuonChiTiet phieuMuonChiTiet)
        {
            try
            {
                dbConnection._dbDuAn.PhieuMuonChiTiets.Add(phieuMuonChiTiet);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<PhieuMuonChiTiet> GetAllPMCT(string id)
        {
            if (id == null)
            {
                return dbConnection._dbDuAn.PhieuMuonChiTiets.ToList();
            }
            return dbConnection._dbDuAn.PhieuMuonChiTiets.Where(g => g.IdPhieuMuon.ToUpper().StartsWith(id.ToUpper())).ToList();
        }

        public List<PhieuMuonChiTiet> GetAllPMCT2()
        {
            return dbConnection._dbDuAn.PhieuMuonChiTiets.ToList();
        }

        public bool UpdatePMCT(PhieuMuonChiTiet phieuMuonChiTiet)
        {
            try
            {
                dbConnection._dbDuAn.PhieuMuonChiTiets.Update(phieuMuonChiTiet);
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
