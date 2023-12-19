using A_Dal.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bus
{
    public interface IServices
    {
        public List<Sach?> GetAllSach(); //Lấy list sách
        public int getCountById(string Id); //Lấy số lượng sách
        public List<SachChiTiet?> GetAllSachCT(string Id); //Lấy list sách chi tiết
        public List<SachChiTiet?> GetAllSachCT2(); //Lấy list sách chi tiết
        public string? GetTacGiaByID(string id); //Lấy Tác giả sách
        public string? GetTheLoaiByID(string id); //Lấy thể loại sách
        public List<TheLoai> GetAllTheLoai(); //Lấy danh sách thể loại

        public string? GetTheThuVienByID(string id); // bằng
        public List<PhieuMuon> GetAllPhieuMuon(string id); // lấy danh sách phiếu mượn (bằng)

        public bool AddTheThuVien(TheThuVien theThuVien);
        public bool AddPhieuMuon(PhieuMuon phieuMuon);
        public bool UpdatePhieuMuon(PhieuMuon phieuMuon);
        public List<PhieuMuonChiTiet> GetAllPMCT(string id);
        public bool AddSach(Sach sach);
        public string? GetNhaXuatBanByID(string id);
        public string? GetTenSach(string id);
        public List<NhanVien> GetAllNhanVien();
        public int GetDiemUyTin(string id);
        public bool AddPMCT(PhieuMuonChiTiet phieuMuonChiTiet);
        public bool UpdateSCT(SachChiTiet sachChiTiet);
        public List<TacGium> GetAllTacGia();
        public bool AddTacGiaSach(TacGiaSach tacGiaSach);
        //public List<TheLoaiSach> GetAllTheLoaiSach();
        public bool AddTheLoaiChiTiet(ChiTietTheLoai chiTietTheLoai);
        public List<NhaXuatBan> GetAllNXB();
        public bool AddSachChiTiet(SachChiTiet sachChiTiet);
        public bool UpdateSach(Sach sach);
        public string GetTenSachBySct(string id);
        public bool UpdatePhieuMuonCT(PhieuMuonChiTiet phieuMuonChiTiet);
        public List<ThietHai> GetAllThietHai();
        public bool AddPhieuTraSach(PhieuTraSach phieuTraSach);
        public List<TheThuVien> GetAllTheThuVien();
        public bool UpdateTheThuVien(TheThuVien theThuVien);
        public List<MucDiemCong> GetMucDiemCongs();
        public bool AddLichSuNap(LichSuNap lichSuNap);
        public bool AddTacGia(TacGium tacGia);
        public bool UpdateTacGia(TacGium tacGia);
        public bool AddNhaXuatBan(NhaXuatBan nhaXuatBan);
        public bool UpdateNhaXuatBan(NhaXuatBan nhaXuatBan);
        public bool AddTheLoai(TheLoai theLoai);
        public bool UpdateTheLoai(TheLoai theLoai);
        public bool AddThietHaiCT(ThietHaiChiTiet thietHaiChiTiet);
        public List<PhieuTraSach> GetAllPhieuTra();
        public bool UpdatePhieuTraSach(PhieuTraSach phieuTraSach);
        public bool AddNhanVien(NhanVien nhanVien);
        public bool UpdateNhanVien(NhanVien nhanVien);
        public int? GetTaiKhoans(string tk, string mk);
        public bool AddTaiKhoan(TaiKhoan taiKhoan);
        public List<TaiKhoan> GetAllTaiKhoan();
        public bool UpdateTaiKhoan(TaiKhoan taiKhoan);
        public bool AddThietHai(ThietHai thietHai);
        public bool UpdateThietHai(ThietHai thietHai);
        public bool RemoveTacGiaSach(TacGiaSach tacGiaSach);
        public List<TacGiaSach> GetAllTacGiaSach();
        public List<ChiTietTheLoai> GetAllChiTietTheLoai();
        public bool RemoveCTTL(ChiTietTheLoai chiTietTheLoai);
        public List<PhieuMuonChiTiet> GetAllPMCT2();
        public List<SachChiTiet> GetSachCTTimKiem(string tenSach);
        public int? GetAllTaiKhoan2(string idNhanVien);
        public string? TenTheThuVien(string id);
       
    }
}
