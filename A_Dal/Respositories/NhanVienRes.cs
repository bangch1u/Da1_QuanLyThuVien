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
    public class NhanVienRes : INhanVienRes
    {
        public bool AddNhanVien(NhanVien nhanVien)
        {
            try
            {
                dbConnection._dbDuAn.NhanViens.Add(nhanVien);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<NhanVien> GetAllNhanVien()
        {
            return dbConnection._dbDuAn.NhanViens.ToList();
        }

        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            try
            {
                dbConnection._dbDuAn.NhanViens.Update(nhanVien);
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
