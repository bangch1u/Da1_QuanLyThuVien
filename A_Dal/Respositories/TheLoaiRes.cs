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
    public class TheLoaiRes : ITheLoaiRes
    {
        public bool AddTheLoai(TheLoai theLoai)
        {
            try
            {
                dbConnection._dbDuAn.TheLoais.Add(theLoai);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<TheLoai> GetAllTheLoai()
        {
            return dbConnection._dbDuAn.TheLoais.ToList();
        }

        public string? GetTheLoaiByID(string id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTheLoai(TheLoai theLoai)
        {
            try
            {
                dbConnection._dbDuAn.TheLoais.Update(theLoai);
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
