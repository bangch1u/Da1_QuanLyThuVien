using A_Dal.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Dal.IRepositories
{
    public interface ITheLoaiRes
    {
        public string? GetTheLoaiByID(string id);
        public List<TheLoai> GetAllTheLoai();
        public bool AddTheLoai(TheLoai theLoai);
        public bool UpdateTheLoai(TheLoai theLoai);
        
    }
}
