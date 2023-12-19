using A_Dal.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Dal.IRepositories
{
    public interface IChiTietTheLoai
    {
        public string? GetTheLoaiByID(string id);
        public bool AddTLCT(ChiTietTheLoai chiTietTheLoai);
        public List<ChiTietTheLoai> GetAllChiTietTheLoai();
        public bool RemoveTLCT(ChiTietTheLoai chiTietTheLoai);
    }
}
