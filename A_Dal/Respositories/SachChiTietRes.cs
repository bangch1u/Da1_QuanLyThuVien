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
    public class SachChiTietRes : ISachCTRes
    {
        public bool AddSCT(SachChiTiet sachChiTiet)
        {
            try
            {
                dbConnection._dbDuAn.SachChiTiets.Add(sachChiTiet);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<SachChiTiet?> getAll(string Id)
        {
            return dbConnection._dbDuAn.SachChiTiets.Where(sct => sct.BarCodeSach == Id).ToList();
        }

        public List<SachChiTiet?> getAll2()
        {
            return dbConnection._dbDuAn.SachChiTiets.ToList();
        }

        public List<SachChiTiet?> getAll3(string tenSach)
        {
            List<SachChiTiet?> lst = null; // Initialize the list

            if (tenSach != null)
            {
                lst = (from S in dbConnection._dbDuAn.Saches
                       join Sct in dbConnection._dbDuAn.SachChiTiets on S.BarCodeSach equals Sct.BarCodeSach
                       where S.TenSach.StartsWith(tenSach)
                       select Sct).ToList();
            }

            return lst; // Return the list
        }

        public string GetTenSachBySct(string Id)
        {
            List<String> tenSach = (from Sct in dbConnection._dbDuAn.SachChiTiets
                                    join S in dbConnection._dbDuAn.Saches on Sct.BarCodeSach equals S.BarCodeSach
                                    where Sct.BarCodeMaSach == Id
                                    select S.TenSach).ToList();

            return String.Join(", ", tenSach);
        }

        public bool UpdateSCT(SachChiTiet sachChiTiet)
        {
            try
            {
                dbConnection._dbDuAn.SachChiTiets.Update(sachChiTiet);
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
