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
    public class TacGiaSachRes : ITacGiaSachRes
    {
        public bool AddTacGiaSach(TacGiaSach tacGiaSach)
        {
            try
            {
                dbConnection._dbDuAn.TacGiaSaches.Add(tacGiaSach);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<TacGiaSach> GetAllTacGiaSach()
        {
            return dbConnection._dbDuAn.TacGiaSaches.ToList();
        }

        public string? GetTacGiaByID(string id)
        {
            List<String> tacGiaList = (from TGS in dbConnection._dbDuAn.TacGiaSaches
                                       join TG in dbConnection._dbDuAn.TacGia on TGS.IdTacGia equals TG.IdTacGia
                                       join S in dbConnection._dbDuAn.Saches on TGS.BarCodeSach equals S.BarCodeSach
                                       where TGS.BarCodeSach == id
                                       select TG.HoTen).ToList();

            return String.Join(", ", tacGiaList);
        }

        public bool RemoveTacGiaSach(TacGiaSach tacGiaSach)
        {
            try
            {
                dbConnection._dbDuAn.TacGiaSaches.Remove(tacGiaSach);
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
