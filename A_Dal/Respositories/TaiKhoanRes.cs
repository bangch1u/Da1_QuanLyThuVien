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
    public class TaiKhoanRes : ITaiKhoanRes
    {
        public bool AddTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                dbConnection._dbDuAn.TaiKhoans.Add(taiKhoan);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<TaiKhoan> GetAllTaiKhoan()
        {
            return dbConnection._dbDuAn.TaiKhoans.ToList();
        }

        public int? GetAllTaiKhoan2(string idNhanVien)
        {
            int? taiKhoan = null; // Initialize the TaiKhoan object as nullable

            if (idNhanVien != null)
            {
                var result = (from Tk in dbConnection._dbDuAn.TaiKhoans
                              join Nv in dbConnection._dbDuAn.NhanViens on Tk.IdNhanVien equals Nv.IdNhanVien
                              where Tk.IdNhanVien == idNhanVien
                              select Tk.Role).FirstOrDefault(); // Use FirstOrDefault() to get a single value or null

                taiKhoan = result; // Assign the result to the nullable variable
            }

            return taiKhoan; // Return the TaiKhoan object
        }

        public int? GetTaiKhoans(string tk, string mk)
        {
            var acount = dbConnection._dbDuAn.TaiKhoans.FirstOrDefault(acc => acc.UserName == tk && acc.PassWord == mk);
            if (acount != null)
            {
                return acount.Role;   
            }
            return null;
        }

        public bool UpdateTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                dbConnection._dbDuAn.TaiKhoans.Update(taiKhoan);
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
