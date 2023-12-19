using A_Dal.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Dal.IRepositories
{
    public interface ITaiKhoanRes
    {
        public int? GetTaiKhoans(string tk, string mk);
        public bool AddTaiKhoan(TaiKhoan taiKhoan);
        public List<TaiKhoan> GetAllTaiKhoan();
        public int? GetAllTaiKhoan2(string idNhanVien);
        public bool UpdateTaiKhoan(TaiKhoan taiKhoan);
        
    }
}
