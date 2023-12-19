using A_Dal.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Dal.IRepositories
{
    public interface INhaXuatBanRes
    {
        public string? GetNhaXuatBanByID(string id);
        public List<NhaXuatBan> GetAllNXB();
        public bool AddNhaXuatBan(NhaXuatBan nhaXuatBan);
        public bool UpdateNhaXuatBan(NhaXuatBan nhaXuatBan);

    }
}
