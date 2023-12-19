using A_Dal.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Dal.IRepositories
{
    public interface ITacGiaSachRes
    {
        public string? GetTacGiaByID(string id);
        public List<TacGiaSach> GetAllTacGiaSach();
        public bool AddTacGiaSach(TacGiaSach tacGiaSach);
        public bool RemoveTacGiaSach(TacGiaSach tacGiaSach);
     
    }
}
