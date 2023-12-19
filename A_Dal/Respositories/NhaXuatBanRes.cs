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
    public class NhaXuatBanRes : INhaXuatBanRes
    {
        public bool AddNhaXuatBan(NhaXuatBan nhaXuatBan)
        {
            try
            {
                dbConnection._dbDuAn.NhaXuatBans.Add(nhaXuatBan);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<NhaXuatBan> GetAllNXB()
        {
            return dbConnection._dbDuAn.NhaXuatBans.ToList();
        }

        public string? GetNhaXuatBanByID(string id)
        {
            List<String> nxbList = (from nxb in dbConnection._dbDuAn.NhaXuatBans
                                    where nxb.IdNxb == id
                                    select nxb.TenNxb).ToList();

            return String.Join(", ", nxbList);
        }

        public bool UpdateNhaXuatBan(NhaXuatBan nhaXuatBan)
        {
            try
            {
                dbConnection._dbDuAn.NhaXuatBans.Update(nhaXuatBan);
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
