using A_Dal.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Dal.IRepositories
{
    public interface IPhieuTraRes
    {
        public bool AddPhieuTra(PhieuTraSach phieuTraSach);
        public List<PhieuTraSach> GetAllPhieuTra();
        public bool UpdatePhieuTra(PhieuTraSach phieuTraSach);
    }
}
