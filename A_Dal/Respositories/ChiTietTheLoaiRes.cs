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
    public class ChiTietTheLoaiRes : IChiTietTheLoai
    {
        public bool AddTLCT(ChiTietTheLoai chiTietTheLoai)
        {
            try
            {

                dbConnection._dbDuAn.ChiTietTheLoais.Add(chiTietTheLoai);
                dbConnection._dbDuAn.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ChiTietTheLoai> GetAllChiTietTheLoai()
        {
            return dbConnection._dbDuAn.ChiTietTheLoais.ToList();
        }

        public string? GetTheLoaiByID(string id)
        {
            List<String> theLoaiList = (from TLCT in dbConnection._dbDuAn.ChiTietTheLoais
                                        join TL in dbConnection._dbDuAn.TheLoais on TLCT.IdTheLoai equals TL.IdTheLoai
                                        join S in dbConnection._dbDuAn.Saches on TLCT.BarCodeSach equals S.BarCodeSach
                                        where TLCT.BarCodeSach == id
                                        select TL.TenTheLoai).ToList();

            return String.Join(", ", theLoaiList);
        }

        public bool RemoveTLCT(ChiTietTheLoai chiTietTheLoai)
        {
            try
            {

                dbConnection._dbDuAn.ChiTietTheLoais.Remove(chiTietTheLoai);
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
