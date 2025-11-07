CREATE DATABASE QuanLyCuaHang
GO
USE QuanLyCuaHang
GO
CREATE TABLE PhanQuyen
(
	MaQuyen varchar(10) constraint PK_Quyen primary key,
	TenQuyen nvarchar(100) not null
)
GO

CREATE TABLE NhanVien
(
	MaNhanVien varchar(10) constraint PK_NhanVien primary key,
	HoTen nvarchar(100) not null,
	SoDienThoai varchar(15) not null constraint UQ_NhanVien_SoDienThoai unique,
	DiaChi nvarchar(255),
	TenDangNhap varchar(50) not null constraint UQ_NhanVien_TenDangNhap unique,
	MatKhau varchar(255) not null,
	MaQuyen varchar(10) constraint FK_NhanVien_Quyen foreign key references PhanQuyen(MaQuyen)
)
GO
CREATE TABLE LoaiSanPham
(
	MaLoaiSP varchar(10) constraint PK_MaLoaiSP primary key,
	TenLoaiSP nvarchar(100) not null,
)
GO
CREATE TABLE  SanPham
(
	MaSanPham varchar(10) constraint PK_SanPham primary key,
	TenSanPham nvarchar(200) not null,
	DonGia int not null,
	SoLuongTon int constraint DF_SanPham_SoLuongTon default 0,
	HanSuDung date,
	MaLoaiSP varchar(10) constraint FR_SanPham_LoaiSanPham foreign key references LoaiSanPham(MaLoaiSP)
)
GO
CREATE TABLE KhachHang
(
	MaKhachHang varchar(10) constraint PK_KhachHang primary key,
	HoTen nvarchar(100) not null,
	SoDienThoai varchar(15) not null constraint UQ_KhachHang_SoDienThoai unique,
	DiaChi nvarchar(255),
)
GO
CREATE TABLE HoaDon
(
    MaHoaDon varchar(10) constraint PK_HoaDon primary key ,
    NgayLap datetime constraint DF_HoaDon_NgayLap default getdate(),
    TongThanhToan int not null,
    ThanhToan nvarchar(20) constraint DF_HoaDon_ThanhToan default N'Chưa thanh toán',
    MaKhachHang varchar(10) constraint FK_HoaDon_KhachHang foreign key references KhachHang(MaKhachHang),
)

GO
CREATE TABLE ChiTietHoaDon
(
    MaHoaDon varchar(10) not null constraint FK_ChiTietHoaDon_HoaDon foreign key references HoaDon(MaHoaDon),
    MaSanPham varchar(10) not null constraint FK_ChiTietHoaDon_SanPham foreign key references SanPham(MaSanPham),
    SoLuong int not null,
    DonGiaBan int not null,
    ThanhTien int not null,
    constraint PK_ChiTietHoaDon primary key (MaHoaDon, MaSanPham)
)

GO
CREATE TABLE NhaCungCap
(
	MaNhaCungCap varchar(10) not null constraint FK_MaNhaCungCap primary key,
	TenNhaCungCap nvarchar(255) not null,
	SoDienThoai varchar(20),
	DiaChi nvarchar(500),
	Email varchar(100),
)
GO
CREATE TABLE PhieuNhapHang
(
    MaPhieuNhap varchar(10) constraint PK_PhieuNhapHang primary key,
    NgayNhap datetime ,
    TongTienNhap int not null,
    MaNhanVien varchar(10) not null constraint FK_PhieuNhapHang_NhanVien foreign key references NhanVien(MaNhanVien),
    MaNhaCungCap varchar(10) not null constraint FK_PhieuNhapHang_NhaCungCap foreign key references NhaCungCap(MaNhaCungCap)
)
GO
CREATE TABLE ChiTietThuNhap
(
	MaPhieuNhap varchar(10)not null constraint FK_ChiTietPhieuNhap_PhieuNhapHang foreign key references PhieuNhapHang(MaPhieuNhap),
    MaSanPham varchar(10) not null constraint FK_ChiTietPhieuNhap_SanPham foreign key references SanPham(MaSanPham),
    SoLuongNhap int not null,
    DonGiaNhap int not null,
    ThanhTien int not null,
    constraint PK_ChiTietPhieuNhap primary key (MaPhieuNhap, MaSanPham)
)
GO
CREATE TABLE KhuyenMai
(
    MaKM varchar(10) constraint PK_KhuyenMai primary key,
    TenKM nvarchar(255) not null,
    TyLeGiam int not null,
    NgayBD date,
    NgayKT date ,
	constraint CK_KhuyenMai_NgayHopLe CHECK (NgayKT > NgayBD)
)
-- them vao du lieu
-- PhanQuyen
INSERT INTO PhanQuyen(MaQuyen,TenQuyen) Values 
('Admin',N'Chủ sở hữu'),
('NV', N'Nhân viên bán hàng')
--them data nhan vien
INSERT INTO NhanVien(MaNhanVien, HoTen,SoDienThoai, DiaChi,TenDangNhap, MatKhau, MaQuyen) Values
('AD00', N'Lữ Chiến Tấn Sang', '0964584850', 'Q5, TPHCM', 'admin','SangDepTrai','Admin'),
('NV01', N'Văn Thị Huyền Trân','0912345678', 'Q5, TPHCM', 'Tran@gmail.com','1234','NV')
--them loai san pham
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP) Values
('TP',N'Thực phẩm'),
('NU',N'Nước Uống')
--Them san pham
INSERT INTO SanPham (MaSanPham, TenSanPham, DonGia, SoLuongTon, HanSuDung, MaLoaiSP) VALUES
('SP001', N'Bánh mì Sandwich', 50000, 100, '2025-12-30', 'TP'),
('SP002', N'Sữa tươi Vinamilk 1L', 35000, 200, '2025-11-20', 'TP'),
('SP003', N'Coca Cola Lon', 10000, 500, '2025-12-25', 'NU'),
('SP004', N'Nước suối Aquafina', 5000, 1000, '2026-04-26', 'NU')
--Them khach hang
INSERT INTO KhachHang(MaKhachHang, HoTen, SoDienThoai, DiaChi) Values
('KH001', N'Nguyễn Văn A', '0909123456', N'123 Lê Lợi, Q1, TPHCM'),
('KH002', N'Trần Thị B', '0908765432', N'456 Nguyễn Trãi, Q5, TPHCM')
--Them nha cung cap
INSERT INTO NhaCungCap (MaNhaCungCap, TenNhaCungCap, SoDienThoai, DiaChi, Email)VALUES
('NCC001', N'Công ty TNHH Acecook Việt Nam', '02838154064', N'Lô II-3, KCN Tân Bình, Q. Tân Phú, TP.HCM', 'Acecook@gmail.com'),
('NCC002', N'Công ty Nước giải khát Suntory PepsiCo', '02838219437', N'Tầng 5, Sheraton, 88 Đồng Khởi, Q.1, TP.HCM', 'pepsi@gmail.com');
--Them khuyen mai
INSERT INTO KhuyenMai (MaKM, TenKM, TyLeGiam, NgayBD, NgayKT) VALUES
('KM001', N'Mua sắm vui vẻ', 10, '2025-09-01', '2025-09-10'),
('KM002', N'Black Friday', 50, '2025-11-28', '2025-11-30')

SELECT * FROM KhuyenMai