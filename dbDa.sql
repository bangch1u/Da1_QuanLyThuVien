

create database QLBD2
go
use QLBD2
go
create table BangDia
(
	MaBD varchar(13) not null primary key,
	TenBang nvarchar(100),
	soLuong int,
);
go
create table  KhachHang
(	MaKH varchar(13) not null primary key,
	HoTen nvarchar(100),
	SoLuongThue int,
	NgayThue datetime,
	SoNgayThue int,
	ThanhTien money,
	MaBD varchar(13) references BangDia(MaBD),
	
);
go
insert into BangDia (MaBD, TenBang, soLuong)
values 
('BD001', N'B? phim Marvel Avengers', 10),
('BD002', N'B? phim Harry Potter', 8),
('BD003', N'B? phim Fast & Furious', 15),
('BD004', N'B? phim The Lord of the Rings', 12),
('BD005', N'B? phim Star Wars', 7);
go
insert into KhachHang (MaKH, HoTen, SoLuongThue, NgayThue, SoNgayThue, ThanhTien, MaBD)
values 
('KH001', N'Nguy?n Vãn A', 2, '2024-05-10', 3, 45000.00, 'BD001'),
('KH002', N'Tr?n Th? B', 1, '2024-05-11', 2, 25000.00, 'BD003'),
('KH003', N'Lê Quang C', 3, '2024-05-12', 5, 75000.00, 'BD002'),
('KH004', N'Ph?m Th? D', 2, '2024-05-13', 4, 50000.00, 'BD005'),
('KH005', N'Hu?nh Vãn E', 1, '2024-05-14', 1, 15000.00, 'BD004');

select * from BangDia