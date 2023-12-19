using A_Dal.DomainClass;
using A_Dal.IRepositories;
using A_Dal.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Bus
{
    public class Services : IServices
    {
      
        public static ISachRes SachRes = new SachRes(); //Khởi tạo biến Sách repos
        public static ISachCTRes SachCTRes = new SachChiTietRes(); //Khởi tạo biến Sách Chi tiết repos
        public static ITacGiaSachRes TacGiaSachRes = new TacGiaSachRes(); //Khởi tạo biến tác giả repos
        public static ITheLoaiRes TheLoaiRes = new TheLoaiRes(); //Khởi tạo biến thể loại repos
        public static IPhieuMuonRes PhieuMuonRes = new PhieuMuonRes(); // 
        public static ITheThuVienRes TheThuVienRes = new TheThuVienRes();
        public static IPMCTRes PMCTRes = new PhieuMuonChiTietRes();//khởi tạo biến phiếu mượn chi tiết repos
        public static INhaXuatBanRes NXBRes = new NhaXuatBanRes();
        public static INhanVienRes NhanVienRes = new NhanVienRes();
        public static ITacGiaRes tacGiaRes = new TacGiaRes();
        public static IChiTietTheLoai cTTLRes = new ChiTietTheLoaiRes();
        public static IThietHaiRes thietHaiRes = new ThietHaiRes();
        public static IPhieuTraRes phieuTraRes = new PhieuTraSachRes();
        public static IMucDiemNapRes mucDiemNapRes = new MucDiemNapRes();
        public static ILichSuNapRes LichSuNapRes = new LichSuNapRes();
        public static IThietHaiChiTietRes ThietHaiChiTietRes = new ThietHaiChiTietRes();
        public static ITaiKhoanRes TaiKhoanRes = new TaiKhoanRes();



        //public bool? Login(string username, string password) => UserRes.Login(username, password); // Đăng nh
        public List<Sach?> GetAllSach() => SachRes.getAll(); //Lấy danh sách sách
        public int getCountById(string Id) => SachRes.getCountById(Id); //Lấy số lượng sách theo barcode
        public List<SachChiTiet?> GetAllSachCT(string Id) => SachCTRes.getAll(Id); //Lấy danh sách sách
        public List<SachChiTiet?> GetAllSachCT2() => SachCTRes.getAll2(); //Lấy danh sách sách

        public string? GetTacGiaByID(string id) => TacGiaSachRes.GetTacGiaByID(id); //Lấy chuỗi tên tác giả của sách theo mã sách
        public string? GetTheLoaiByID(string id) => cTTLRes.GetTheLoaiByID(id); //Lấy chuỗi thể loại của sách theo mã sách
        public List<TheLoai> GetAllTheLoai() => TheLoaiRes.GetAllTheLoai(); //Lấy danh sách thể loại

        public List<PhieuMuon> GetAllPhieuMuon(string id) => PhieuMuonRes.GetAllPhieuMuon(id);//lấy danh sách phiếu mượn

        public string? GetTheThuVienByID(string id) => TheThuVienRes.GetTheThuVienByID(id);

        public bool AddTheThuVien(TheThuVien theThuVien)
        {
            return TheThuVienRes.AddTheThuVien(theThuVien);
        }

        public bool AddPhieuMuon(PhieuMuon phieuMuon) => PhieuMuonRes.AddPhieuMuon(phieuMuon);

        public bool UpdatePhieuMuon(PhieuMuon phieuMuon) => PhieuMuonRes.UpdatePhieuMuon(phieuMuon);



        public List<PhieuMuonChiTiet> GetAllPMCT(string id) => PMCTRes.GetAllPMCT(id);

        public bool AddSach(Sach sach) => SachRes.AddSach(sach);

        public string? GetNhaXuatBanByID(string id) => NXBRes.GetNhaXuatBanByID(id);

        public string GetTenSach(string id) => SachRes.GetTenSachById(id);

        public List<NhanVien> GetAllNhanVien() => NhanVienRes.GetAllNhanVien();
        public int GetDiemUyTin(string id) => TheThuVienRes.GetDiemUyTinById(id);

        public bool AddPMCT(PhieuMuonChiTiet phieuMuonChiTiet) => PMCTRes.AddPMCT(phieuMuonChiTiet);

        public bool UpdateSCT(SachChiTiet sachChiTiet) => SachCTRes.UpdateSCT(sachChiTiet);

        public List<TacGium> GetAllTacGia() => tacGiaRes.GetAllTacGia2();
        public bool AddTacGiaSach(TacGiaSach tacGiaSach) => TacGiaSachRes.AddTacGiaSach(tacGiaSach);

        // public List<TheLoai> GetAllTheLoaiSach() => TheLoaiRes.GetAllTheLoai();

        public bool AddTheLoaiChiTiet(ChiTietTheLoai chiTietTheLoai) => cTTLRes.AddTLCT(chiTietTheLoai);
        public List<NhaXuatBan> GetAllNXB() => NXBRes.GetAllNXB();

        public bool AddSachChiTiet(SachChiTiet sachChiTiet) => SachCTRes.AddSCT(sachChiTiet);
        public bool UpdateSach(Sach sach) => SachRes.UpdateSach(sach);
        public string GetTenSachBySct(string id) => SachCTRes.GetTenSachBySct(id);

        public bool UpdatePhieuMuonCT(PhieuMuonChiTiet phieuMuonChiTiet) => PMCTRes.UpdatePMCT(phieuMuonChiTiet);

        public List<ThietHai> GetAllThietHai() => thietHaiRes.GetAllThietHai();

        public bool AddPhieuTraSach(PhieuTraSach phieuTraSach) => phieuTraRes.AddPhieuTra(phieuTraSach);

        public List<TheThuVien> GetAllTheThuVien() => TheThuVienRes.GetAllTheThuVien();

        public bool UpdateTheThuVien(TheThuVien theThuVien) => TheThuVienRes.UpdateTheThuVIen(theThuVien);

        public List<MucDiemCong> GetMucDiemCongs() => mucDiemNapRes.GetAllMucDiemCong();

        public bool AddLichSuNap(LichSuNap lichSuNap) => LichSuNapRes.AddLichSuNap(lichSuNap);

        public bool AddTacGia(TacGium tacGia) => tacGiaRes.AddTacGia(tacGia);

        public bool UpdateTacGia(TacGium tacGia) => tacGiaRes.UpdateTacGia(tacGia);

        public bool AddNhaXuatBan(NhaXuatBan nhaXuatBan) => NXBRes.AddNhaXuatBan(nhaXuatBan);

        public bool UpdateNhaXuatBan(NhaXuatBan nhaXuatBan) => NXBRes.UpdateNhaXuatBan(nhaXuatBan);

        public bool AddTheLoai(TheLoai theLoai) => TheLoaiRes.AddTheLoai(theLoai);

        public bool UpdateTheLoai(TheLoai theLoai) => TheLoaiRes.UpdateTheLoai(theLoai);

        public bool AddThietHaiCT(ThietHaiChiTiet thietHaiChiTiet) => ThietHaiChiTietRes.AddThietHaiCT(thietHaiChiTiet);

        public List<PhieuTraSach> GetAllPhieuTra() => phieuTraRes.GetAllPhieuTra();

        public bool UpdatePhieuTraSach(PhieuTraSach phieuTraSach) => phieuTraRes.UpdatePhieuTra(phieuTraSach);

        public bool AddNhanVien(NhanVien nhanVien) => NhanVienRes.AddNhanVien(nhanVien);

        public bool UpdateNhanVien(NhanVien nhanVien) => NhanVienRes.UpdateNhanVien(nhanVien);

        public int? GetTaiKhoans(string tk, string mk) => TaiKhoanRes.GetTaiKhoans(tk, mk);

        public bool AddTaiKhoan(TaiKhoan taiKhoan) => TaiKhoanRes.AddTaiKhoan(taiKhoan);

        public List<TaiKhoan> GetAllTaiKhoan() => TaiKhoanRes.GetAllTaiKhoan();

        public bool UpdateTaiKhoan(TaiKhoan taiKhoan) => TaiKhoanRes.UpdateTaiKhoan(taiKhoan);

        public bool AddThietHai(ThietHai thietHai) => thietHaiRes.AddThietHai(thietHai);


        public bool UpdateThietHai(ThietHai thietHai) => thietHaiRes.UpdateThietHai(thietHai);

        public bool RemoveTacGiaSach(TacGiaSach tacGiaSach) => TacGiaSachRes.RemoveTacGiaSach(tacGiaSach);

        public List<TacGiaSach> GetAllTacGiaSach() => TacGiaSachRes.GetAllTacGiaSach();

        public List<ChiTietTheLoai> GetAllChiTietTheLoai() => cTTLRes.GetAllChiTietTheLoai();

        public bool RemoveCTTL(ChiTietTheLoai chiTietTheLoai) => cTTLRes.RemoveTLCT(chiTietTheLoai);

        public List<PhieuMuonChiTiet> GetAllPMCT2() => PMCTRes.GetAllPMCT2();

        public List<SachChiTiet> GetSachCTTimKiem(string tenSach) => SachCTRes.getAll3(tenSach);

        public int? GetAllTaiKhoan2(string idNhanVien) => TaiKhoanRes.GetAllTaiKhoan2(idNhanVien);

        public string? TenTheThuVien(string id) => TheThuVienRes.TenTheThuVien(id);
        
    }
}
