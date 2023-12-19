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
    public class TheThuVienRes : ITheThuVienRes
    {
        public bool AddTheThuVien(TheThuVien theThuVien)
        {
            try
            {
                dbConnection._dbDuAn.TheThuViens.Add(theThuVien);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<TheThuVien> GetAllTheThuVien()
        {
            return dbConnection._dbDuAn.TheThuViens.ToList();
        }

        public int GetDiemUyTinById(string id)
        {
            int? diemUyTin = dbConnection._dbDuAn.TheThuViens
             .Where(TTV => TTV.IdTheThuVien == id)
             .Select(TTV => (int?)TTV.DiemUyTin)
             .SingleOrDefault();

            return diemUyTin ?? 0; //nếu null trả về 0
        }

        public string? GetTheThuVienByID(string id)
        {
            List<String> theThuVienList = (from TTV in dbConnection._dbDuAn.TheThuViens
                                           join PM in dbConnection._dbDuAn.PhieuMuons on TTV.IdTheThuVien equals PM.IdTheThuVien
                                           where PM.IdTheThuVien == id
                                           select TTV.HoTen).ToList();

            return String.Join(", ", theThuVienList);
        }

        public string? TenTheThuVien(string id)
        {
            string? ten = null; // Initialize the TaiKhoan object as nullable

            if (id != null)
            {
                var result = (from TTV in dbConnection._dbDuAn.TheThuViens
                              join PM in dbConnection._dbDuAn.PhieuMuons on TTV.IdTheThuVien equals PM.IdTheThuVien
                              join PMCT in dbConnection._dbDuAn.PhieuMuonChiTiets on PM.IdPhieuMuon equals PMCT.IdPhieuMuon
                              where PM.IdPhieuMuon == id
                              select TTV.HoTen).FirstOrDefault(); // Use FirstOrDefault() to get a single value or null

                ten = result; // Assign the result to the nullable variable
            }

            return ten; // Return the TaiKhoan object
        }

        public bool UpdateTheThuVIen(TheThuVien theThuVien)
        {
            try
            {
                dbConnection._dbDuAn.TheThuViens.Update(theThuVien);
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
