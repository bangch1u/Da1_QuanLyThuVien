using A_Dal.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Dal.IRepositories
{
    public interface ITacGiaRes
    {
        public List<TacGium> GetAllTacGia2();
        public bool AddTacGia(TacGium tacGia);
        public bool UpdateTacGia(TacGium tacGia);
    }
}
