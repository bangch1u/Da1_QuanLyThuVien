using A_Dal.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Dal.IRepositories
{
    public interface INhanVienRes
    {
        public List<NhanVien> GetAllNhanVien();
        public bool AddNhanVien(NhanVien nhanVien);
        public bool UpdateNhanVien(NhanVien nhanVien);
    }
}
