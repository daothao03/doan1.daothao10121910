create database da1qlmp
go

use DA1_QLMP

create table ChucVu
( 
maCV int identity primary key,
tenCV nvarchar(50),
mota nvarchar(50)
)

create table NhanVien
(
maNV int identity primary key,
hoten nvarchar(50),
namsinh int,
sdt int not null,
maCV int not null foreign key references ChucVu(maCV)
)

create table khachhang
(
maKH int identity primary key,
hoten nvarchar(50),
sdt int not null
)

create table sanpham
(
masp int identity primary key,
tensp nvarchar(50),
xuatxu nvarchar(50),
giaban int,
soluong int
)

create table ncc 
(
mancc int identity primary key,
diachi nvarchar(50),
sdt int,
tenncc nvarchar(50)
)

create table hoadonban
(
mahdb int identity primary key,
maNV int not null foreign key references NhanVien(maNV),
maKH int not null foreign key references KhachHang(maKH),
ngayBan date,
hinhthucthanhtoan nvarchar(50)
)

create table chitiethdb
(
mahdb int not null foreign key references hoadonban(mahdb),
maSP int not null foreign key references SanPham(maSP),
soluong int
)

create table hdn
(
mahdn int identity primary key,
ngayNhap date,
manv int not null foreign key references NhanVien(maNV),
mancc int not null foreign key references ncc(mancc)
)

create table chitiethdn
(
mahdn int not null foreign key references hdn(mahdn),
maSP int not null foreign key references SanPham(maSP),
gianhap int,
soluong int
)
