drop database QuanLyBanDoAn
use master
go

create database QuanLyBanDoAn
go

use QuanLyBanDoAn
go

create table DangNhap(
	TenDangNhap nvarchar(30),
	MatKhau nvarchar(30),
	constraint pk_DN primary key (TenDangNhap)
);
go
insert into DangNhap values
	(N'admin',N'admin1')
go
select * from DangNhap

create table NhanVien (
	MaNhanVien nvarchar(10) Not Null constraint pk_NV_MNV primary key,
	TenNhanVien nvarchar(100),
	GioiTinh nvarchar(5) check (GioiTinh in(N'Nam',N'Nữ',N'Khác')),
	DiaChi nvarchar(100),
	DienThoai nvarchar(15),
	NgaySinh datetime

);
go

create table Khach(
	MaKhach nvarchar(10) constraint pk_K_MK primary key,
	TenKhach nvarchar(100),
	DiaChiKH nvarchar(100),
	DienThoaiKH nvarchar(15)

);
go
create table NguyenLieu(
	MaNguyenLieu nvarchar(10) constraint pk_CL_MCL primary key,
	TenNguyenLieu nvarchar(100)
);
go

create table MonAn(
	MaMonAn nvarchar(10) constraint pk_MA_MMA primary key,
	TenMonAn nvarchar(100),
	MaNguyenLieu nvarchar(10) constraint fk_MA_MNL foreign key references NguyenLieu(MaNguyenLieu),
	SoLuong float,
	DonGiaNhap float,
	DonGiaBan float,
	Anh nvarchar(200),
	GhiChu nvarchar(200),
);
go



create table ChiTietHoaDonBan(
	MaHDBan nvarchar(100)constraint pk_CT primary key ,
	MaMonAn nvarchar(10) constraint fk_CT_MMA foreign key references MonAn(MaMonAn),
	SoLuong float,
	DonGia float,
	GiamGia float,
	ThanhTien float,
	
);
go
create table HoaDonBan(
	MaHDBan nvarchar(100)constraint fk_HDB_MHD foreign key references ChiTietHoaDonBan(MaHDBan), 
	MaNhanVien nvarchar(10) constraint fk_HDB_MaNV foreign key references NhanVien(MaNhanVien),
	NgayBan datetime,
	MaKhach nvarchar(10) constraint fk_HDB_MK foreign key references Khach(MaKhach),
	TongTien float,
	constraint pk_HDB primary key(MaHDBan)
);
go


select * from DangNhap