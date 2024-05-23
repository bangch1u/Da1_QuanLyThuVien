create database DBDA_TV
go
use DBDA_TV
go
create table Sach
(
	barCodeSach varchar(13) not null primary key,
	tenSach nvarchar(100),
	soLuong int,
	giaTien money,
	namXuatBan date
);
go
create table TacGia
(
	idTacGia varchar(13) not null primary key,
	hoTen nvarchar(100),
	ngaySinh date
);
go
create table TacGiaSach
(
	barCodeSach varchar(13) references Sach(barCodeSach),
	idTacGia varchar(13) references TacGia(idTacGia),
	moTa varchar(10),
	PRIMARY KEY (barCodeSach, idTacGia)
);
go
create table TheLoai
(
	idTheLoai varchar(13) primary key,
	tenTheLoai nvarchar(50),
	viTriKeSach varchar(10)
);
go
create table ChiTietTheLoai
(
	idTheLoai varchar(13) references TheLoai(idTheLoai),
	barCodeSach varchar(13) references Sach(barCodeSach),
	moTa varchar(10),
	primary key (idTheLoai, barCodeSach)
);
go
create table NhanVien
(
	idNhanVien varchar(10) primary key,
	hoTen nvarchar(50),
	gioiTinh bit,
	soDienThoai varchar(10),
	diaChi nvarchar(150),
	ngaySinh Date,
	email varchar(100),
	trangThai int ---1: ho?t đ?ng, 0: ngh? vi?c
);
go
create table TaiKhoan
(
	idTaiKhoan varchar(10) primary key,
	userName varchar(50),
	[passWord] varchar(50),
	idNhanVien varchar(10) unique references NhanVien(idNhanVien),
	[role] int ----1: nhân viên, ---2: qu?n l?
);
create table TheThuVien 
(
	idTheThuVien varchar(10) primary key,
	hoTen nvarchar(50),
	soDienThoai varchar(10), 
	diemUyTin int,
	trangThai int, ---1: ho?t đ?ng|| 0: khóa th? || 2: ngưng ho?t đ?ng||
);
go
create table LichSuNap
(
	idLichSu int identity(1,1) primary key,
	soTienNap money,
	diemCongUyTin int,
	ngayNap date,
	idTheThuVien varchar(10) references TheThuVien(idTheThuVien)
);
go
create table MucDiemCong
(
	id int identity(1,1) primary key,
	mucTien money,
	soDiemCong int
);
create table PhieuMuon
(	
	idPhieuMuon varchar(10) primary key,
	idTheThuVien varchar(10) unique references TheThuVien(idTheThuVien),
	tongSachMuon int, 
	ngayTaoPhieu date,
	trangThai bit --0: full sách không th? mư?n|| 1: c?n có th? mư?n sách
);
go
create table NhaXuatBan
(
	idNXB varchar(10) primary key,
	tenNXB nvarchar(100),
	diaChi nvarchar(150),
	soDienThoai nvarchar(10)
);
go
create table SachChiTiet
(
	barCodeMaSach varchar(13) primary key,
	barCodeSach varchar(13) references Sach(barCodeSach),
	tinhTrangSach nvarchar(50),
	lanTaiBan int,
	kichCo varchar(20),
	namTaiBan int,
	diemUyTinMin int,
	trangThai int,
	idNXB varchar(10) references NhaXuatBan(idNXB)
);
go
create table PhieuMuonChiTiet
(
	idPhieuMuonChiTiet int identity(1,1) primary key,
	idPhieuMuon varchar(10) references PhieuMuon(idPhieuMuon),
	idNhanVien varchar(10) references NhanVien(idNhanVien),
	barCodeMaSach varchar(13) references SachChiTiet(barCodeMaSach),
	soLuongSach int,
	ngayMuonSach date,
	ngayTraSach date,
	soLanGiaHan int,
	trangThai int ---0: mư?n thành công, -1: mư?n th?t b?i, 2: gia h?n thành công, 3: quá s? l?n gia h?n
);
go
create table PhieuTraSach
(
	idPhieuTra varchar(10) primary key,
	soLuongTra int,
	thoiGianTraSach date,
	tinhTrangSach nvarchar(50),
	barCodeMaSach varchar(13) references SachChiTiet(barCodeMaSach),
	idPhieuMuon varchar(10) references PhieuMuon(idPhieuMuon),
	trangThai bit
);
go
create table ThietHai
(
	idThietHai varchar(10) primary key,
	tenThietHai nvarchar(50),
	diemTruUyTin int
);
go
create table ThietHaiChiTiet
(
	idThietHai varchar(10) references ThietHai(idThietHai),
	idPhieuTra varchar(10) references PhieuTraSach(idPhieuTra),
	moTa nvarchar(100),
	primary key ( idThietHai, idPhieuTra)
);
go
INSERT INTO MucDiemCong (mucTien, soDiemCong) VALUES (100000, 10);
INSERT INTO MucDiemCong (mucTien, soDiemCong) VALUES (200000, 50);
INSERT INTO MucDiemCong (mucTien, soDiemCong) VALUES (300000, 100);
INSERT INTO MucDiemCong (mucTien, soDiemCong) VALUES (400000, 150);
INSERT INTO MucDiemCong (mucTien, soDiemCong) VALUES (500000, 200);
