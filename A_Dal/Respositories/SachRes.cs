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
    public class SachRes : ISachRes
    {
        public bool AddSach(Sach sach)
        {
            try
            {
                dbConnection._dbDuAn.Saches.Add(sach);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Sach?> getAll()
        {
            return dbConnection._dbDuAn.Saches.ToList();
        }

        public int getCountById(string Id)
        {
            return dbConnection._dbDuAn.SachChiTiets.Where(sct => sct.BarCodeSach.Equals(Id)).Count();
        }

        public string? GetTenSachById(string Id)
        {
            List<String> tenSach = (from S in dbConnection._dbDuAn.Saches
                                    where S.BarCodeSach == Id
                                    select S.TenSach).ToList();

            return String.Join(", ", tenSach);
        }

        public bool UpdateSach(Sach sach)
        {
            try
            {
                dbConnection._dbDuAn.Saches.Update(sach);
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
