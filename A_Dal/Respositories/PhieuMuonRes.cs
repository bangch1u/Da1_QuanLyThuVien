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
    public class PhieuMuonRes : IPhieuMuonRes
    {
        public bool AddPhieuMuon(PhieuMuon phieuMuon)
        {
            try
            {
                dbConnection._dbDuAn.PhieuMuons.Add(phieuMuon);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<PhieuMuon?> GetAllPhieuMuon(string id)
        {
            if (id == null)
            {
                return dbConnection._dbDuAn.PhieuMuons.ToList();
            }
            return dbConnection._dbDuAn.PhieuMuons.Where(g => g.IdPhieuMuon.ToUpper().StartsWith(id.ToUpper())).ToList();
        }

        public string? GetPhieuMuonById(string id)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePhieuMuon(PhieuMuon phieuMuon)
        {
            try
            {
                dbConnection._dbDuAn.PhieuMuons.Update(phieuMuon);
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
