create database qlmpDA1
go

use qlmpDA1

create table ChucVu
( 
maCV varchar(5) primary key,
tenCV nvarchar(50),
mota nvarchar(50)
)

create table NhanVien
(
maNV varchar(5) primary key,
hoten nvarchar(50),
namsinh int,
sdt int not null,
maCV varchar(5) not null foreign key references ChucVu(maCV)
)

create table khachhang
(
maKH varchar(5) primary key,
hoten nvarchar(50),
sdt int not null
)

create table sanpham
(
masp varchar(5) primary key,
tensp nvarchar(50),
xuatxu nvarchar(50),
giaban int,
soluong int
)

create table ncc 
(
mancc varchar(5) primary key,
diachi nvarchar(50),
sdt int,
tenncc nvarchar(50)
)

create table hoadonban
(
mahdb varchar(5) primary key,
maNV varchar(5) not null foreign key references NhanVien(maNV),
maKH varchar(5) not null foreign key references KhachHang(maKH),
ngayBan date,
hinhthucthanhtoan nvarchar(50)
)

create table chitiethdb
(
mahdb varchar(5) not null foreign key references hoadonban(mahdb),
maSP varchar(5) not null foreign key references SanPham(maSP),
soluong int
)

create table hdn
(
mahdn varchar(5) primary key,
ngayNhap date,
manv varchar(5) not null foreign key references NhanVien(maNV),
mancc varchar(5) not null foreign key references ncc(mancc)
)

create table chitiethdn
(
mahdn varchar(5) not null foreign key references hdn(mahdn),
maSP varchar(5) not null foreign key references SanPham(maSP),
gianhap int,
soluong int
)

alter table NhanVien add gioitinh nvarchar(5)

alter table NhanVien add pw varchar(4)

alter table sanpham add donvitinh nvarchar(50)

alter table NhanVien
alter column namsinh date

alter table khachhang 
alter column hoten nvarchar(50) not null

select * from sanpham

ALTER TABLE chitiethdb
ADD CONSTRAINT pk_cthdb PRIMARY KEY(mahdb)



ALTER TABLE chitiethdn
ADD CONSTRAINT pk_cthdn1 PRIMARY KEY(mahdn)

ALTER TABLE chitiethdn
ADD CONSTRAINT pk_cthdn PRIMARY KEY(maSP)


ALTER TABLE chitiethdn
DROP CONSTRAINT pk_cthdn 


ALTER TABLE chitiethdn
DROP CONSTRAINT pk_cthdn1






select * from khachhang

select * from ncc

create proc SP_SearchKH
	(@sdt int)
as 
begin
	select maKH, hoten, sdt from khachhang 
	where sdt = @sdt 
end



exec SP_SearchKH '974585959'


create proc SP_SearchNCC
	(@tenncc Nvarchar(50))
as
begin 
	select * from ncc 
	where tenncc like '%' + @tenncc + '%'
end


exec SP_SearchNCC N'nhập khẩu'



create proc SP_SearchSP
	(@tensp nvarchar(50))
as
begin
	select * from sanpham 
	where tensp like '%' + @tensp + '%'
end


exec SP_SearchSP N'merzy'



create proc SP_SearchNV
	(@sdt int)
as
begin 
	select * from NhanVien
	where sdt = @sdt
end


exec SP_SearchNV '95858686'



select * from hoadonban

select * from khachhang

drop procedure SP_SearchHDB 

create procedure SearchHDB 
	(@tungay DateTime, @denngay DateTime, @sdt int)
as
begin
	select hoadonban.mahdb, hoadonban.maNV,hoadonban.maKH,hoadonban.ngayBan,hoadonban.hinhthucthanhtoan 
	from hoadonban,khachhang, NhanVien
	where 
		khachhang.maKH = hoadonban.maKH
		and NhanVien.maNV = hoadonban.maNV
		and ngayBan between @tungay and @denngay 
		and khachhang.sdt=@sdt 
	group by hoadonban.mahdb, hoadonban.maNV,hoadonban.maKH,hoadonban.ngayBan,hoadonban.hinhthucthanhtoan
end 

exec SearchHDB '04/04/2023','04/11/2023','846477559'

select * from hdn

select * from ncc

create procedure SearchHDN
	(@tungay DateTime, @denngay DateTime, @tenncc nvarchar(50))
as
begin
	select hdn.mahdn, hdn.ngayNhap, hdn.manv, hdn.mancc
	from hdn,ncc, NhanVien
	where 
		ncc.mancc=hdn.mancc
		and NhanVien.maNV=hdn.manv
		and ngayNhap between @tungay and @denngay 
		and ncc.tenncc = @tenncc 
	group by hdn.mahdn, hdn.ngayNhap, hdn.manv, hdn.mancc
end 


exec SearchHDN '04/04/2023','04/13/2023',N'Công ty TNHH MTV Newface'



SELECT chitiethdb.mahdb, chitiethdb.soluong, hoadonban.ngayBan, sanpham.tensp, sanpham.giaban, NhanVien.hoten, khachhang.hoten AS [Tên khách hàng], khachhang.sdt, sanpham.giaban * chitiethdb.soluong AS thanhtien

FROM     chitiethdb INNER JOIN
                  hoadonban ON chitiethdb.mahdb = hoadonban.mahdb INNER JOIN
                  khachhang ON hoadonban.maKH = khachhang.maKH INNER JOIN
                  NhanVien ON hoadonban.maNV = NhanVien.maNV INNER JOIN
                  sanpham ON chitiethdb.maSP = sanpham.masp


select sum(sanpham.giaban * chitiethdb.soluong)
FROM     chitiethdb INNER JOIN
                  hoadonban ON chitiethdb.mahdb = hoadonban.mahdb INNER JOIN
                  khachhang ON hoadonban.maKH = khachhang.maKH INNER JOIN
                  NhanVien ON hoadonban.maNV = NhanVien.maNV INNER JOIN
                  sanpham ON chitiethdb.maSP = sanpham.masp

