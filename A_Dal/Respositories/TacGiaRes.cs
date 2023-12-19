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
    public class TacGiaRes : ITacGiaRes
    {
        public bool AddTacGia(TacGium tacGia)
        {
            try
            {
                dbConnection._dbDuAn.TacGia.Add(tacGia);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<TacGium> GetAllTacGia2()
        {
            return dbConnection._dbDuAn.TacGia.ToList();
        }

        public bool UpdateTacGia(TacGium tacGia)
        {
            try
            {
                dbConnection._dbDuAn.TacGia.Update(tacGia);
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
