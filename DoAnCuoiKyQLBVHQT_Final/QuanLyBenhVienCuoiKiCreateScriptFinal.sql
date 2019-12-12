-- ĐỒ ÁN CUỐI KỲ MÔN HỆ QUẢN TRỊ CƠ SỞ DỮ LIỆU
-- ĐỀ TÀI: QUẢN LÝ BỆNH VIỆN
-- THÀNH VIÊN:
-- 1) LƯ MẠNH QUÂN				MSSV: 17110209
-- 2) TRƯƠNG MINH KHOA			MSSV: 17110163
-- NHÓM: 11
---------------------------------------------------------------
---------------------------------------------------------------
-- Create QuanLyBenhVienDoAnCuoiKi database
---------------------------------------------------------------
USE master;
go

-- Drop database
if DB_ID(N'QuanLyBenhVienDoAnCuoiKi') is not null
	drop database QuanLyBenhVienDoAnCuoiKi;
go

-- If database could not be created due to open connections, abort
if @@ERROR = 3702
	RAISERROR(N'Database cannot be dropped because there are still open connections.',127,127) WITH NOWAIT,LOG;
go

-- Create database
CREATE DATABASE QuanLyBenhVienDoAnCuoiKi;
go

USE QuanLyBenhVienDoAnCuoiKi;
go



--Drop Tables first then Drop Schemas



drop table if exists HR.NhanViens;
go

drop table if exists Hospital.PhieuDangKys;
go

drop table if exists Hospital.BenhNhans;
go

drop table if exists Hospital.BacSis;
go

drop table if exists Hospital.Khoas;
go

drop table if exists Hospital.HoSoBenhAns;
go

drop table if exists Hospital.HoaDons;
go

drop table if exists Hospital.Phongs;
go

drop table if exists Hospital.LoaiPhongs;
go

drop table if exists Hospital.ToaThuocs;
go

drop table if exists Hospital.Thuocs;
go

drop table if exists Hospital.ToaXetNghiems;
go

drop table if exists Hospital.XetNghiems;
go

drop table if exists Hospital.LoaiXetNghiems;
go



drop schema if exists HR;
go

drop schema if exists Hospital;
go

---------------------------------------------------------------
-- Populate database QuanLyBenhVienDoAnCuoiKi with sample data
---------------------------------------------------------------
---------------------------------------------------------------
-- Create Schemas
---------------------------------------------------------------

use QuanLyBenhVienDoAnCuoiKi;
go

CREATE SCHEMA HR AUTHORIZATION dbo;
GO

CREATE SCHEMA Hospital AUTHORIZATION dbo;
GO

---------------------------------------------------------------
-- Create Tables
---------------------------------------------------------------



-- Create table HR.NhanViens

use QuanLyBenhVienDoAnCuoiKi;
go

CREATE TABLE HR.NhanViens
(
	MaNV nvarchar(10)      not null,
	MatKhau varchar(20)    not null,
	HoNV nvarchar(50)	   not null,
	TenNV nvarchar(20)     not null,
	NgaySinh datetime      not null,
	GioiTinh nvarchar(10)  not null,
	SDT nvarchar(30)	   not null,
	Email nvarchar(30)	   not null,
	Luong float			   not null,
	Quyen nvarchar(30)     not null,
	Hide BIT DEFAULT(0)	   NULL,
	CONSTRAINT PK_NhanViens_MaNV PRIMARY KEY CLUSTERED (MaNV ASC)
);
go

use QuanLyBenhVienDoAnCuoiKi;
go

alter table HR.NhanViens
drop column if exists email_local_part;
go

ALTER TABLE HR.NhanViens
ADD 
    email_local_part AS 
        SUBSTRING(Email, 
            0, 
            CHARINDEX('@', Email, 0)
        );
go

drop index if exists idx_NhanViens_Email_Concat
on HR.NhanViens;
go

CREATE nonclustered INDEX idx_NhanViens_Email_Concat
ON HR.NhanViens(email_local_part)
include (MaNV);
go



CREATE nonclustered INDEX idx_NhanViens_TenNV_inc
ON HR.NhanViens(TenNV,MaNV)
go



----Chèn dữ liệu
--insert into HR.NhanViens
--(MaNV,MatKhau,HoNV,TenNV,NgaySinh,GioiTinh,SDT,Email,Luong,Quyen,Hide)
--values 
--(N'NV01',N'abc',N'Trương Minh',N'Khoa','1999-10-11',N'Nam',N'0911321110',N'khoa@gmail.com',5000000,N'Admin',0),

--(N'NV02',N'abc',N'Nguyễn Thái Phương',N'Thảo','1999-10-26',N'Nữ',N'0919976141',N'thao@gmail.com',1000000,N'NhanVien',0),

--(N'NV03',N'abc',N'Thạch Hoàng',N'Duy','1999-03-25',N'Nam',N'0976533148',N'duy@gmail.com',2000000,N'NhanVien',0),

--(N'NV04',N'abc',N'Nguyễn Hoàng',N'Bảo','1999-03-26',N'Nam',N'0971516148',N'bao@gmail.com',500000,N'NhanVien',0);





-- Create Tale Hospital.Khoas
use QuanLyBenhVienDoAnCuoiKi;
go

create table Hospital.Khoas
(
	MaKhoa nvarchar(10)  not null,
	TenKhoa nvarchar(70) not null,
	Hide BIT DEFAULT(0)  NULL,
	CONSTRAINT PK_Khoas_MaKhoa PRIMARY KEY CLUSTERED (MaKhoa ASC)
)
go

use QuanLyBenhVienDoAnCuoiKi;
go

drop index if exists idx_Khoas_inc on Hospital.Khoas;
go

create nonclustered index idx_Khoas_inc
on Hospital.Khoas (TenKhoa)
include (MaKhoa);
go

--Chèn dữ liệu
insert into Hospital.Khoas
values
(N'K01',N'Khoa cấp cứu tổng hợp',0),
(N'K02',N'Khoa cơ xương khớp',0),
(N'K03',N'Khoa dinh dưỡng',0),
(N'K04',N'Khoa hô hấp',0),
(N'K05',N'Khoa khám bệnh',0),
(N'K06',N'Khoa ngoại tổng quát',0),
(N'K07',N'Khoa nội thần kinh tổng quát',0),
(N'K08',N'Khoa nội tiêu hóa',0),
(N'K09',N'Khoa tai mũi họng',0),
(N'K10',N'Khoa tim mạch tổng quát',0),
(N'K11',N'Khoa xét nghiệm',0);




--Create Table Hospital.BacSis
use QuanLyBenhVienDoAnCuoiKi;
go

create table Hospital.BacSis
(
	MaBS nvarchar(10)    not null,
	HoBS nvarchar(30)    not null,
	TenBS nvarchar(20)   not null,
	NgaySinh datetime    not null,
	GioiTinh nvarchar(10)not null,
	ChucVu nvarchar(20)  not null,
	MaKhoa nvarchar(10)  not null,
	Hide BIT DEFAULT(0)  NULL,
	constraint PK_BacSis_MaBS primary key clustered (MaBS asc)
)
go

--Chèn dữ liệu
INSERT INTO Hospital.BacSis 
VALUES
(N'BS01',N'Trương Minh',N'Khoa','1999-10-11',N'Nam',N'Trưởng khoa',N'K01',0),
(N'BS02',N'Lư Mạnh',N'Quân','1999-06-25',N'Nam',N'Phó khoa',N'K02',0),
(N'BS03',N'Lư Mạnh',N'Quân1','1999-06-25',N'Nam',N'Phó khoa',N'K03',0),
(N'BS04',N'Lư Mạnh',N'Quân2','1999-06-25',N'Nam',N'Phó khoa',N'K04',0),
(N'BS05',N'Lư Mạnh',N'Quân3','1999-06-25',N'Nam',N'Phó khoa',N'K05',0);



drop index if exists idx_BS_MaBS_join_inc
on Hospital.BacSis;
go

drop index if exists idx_BS_MaBS_inc
on Hospital.BacSis;
go

CREATE nonclustered INDEX idx_BS_MaBS_join_inc
ON Hospital.BacSis(MaKhoa, MaBS)
go

CREATE nonclustered INDEX idx_BS_MaBS_inc
ON Hospital.BacSis(TenBS, HoBS)
include (MaBS)
go





--Create Table Hospital.BenhNhans
use QuanLyBenhVienDoAnCuoiKi;
go
create table Hospital.BenhNhans
(
	MaBN nvarchar(10)	not null,
	HoBN nvarchar(30)	not null,
	TenBN nvarchar(20)	not null,
	NgaySinh datetime	not null,
	GioiTinh nvarchar(10)not null,
	Hide BIT DEFAULT(0)  NULL,
	constraint PK_BenhNhans_MaBN primary key clustered (MaBN asc)
)
go

--Chèn dữ liệu
INSERT INTO  Hospital.BenhNhans 
VALUES
(N'BN01',N'Đoàn Quốc',N'Hùng','1999-06-15',N'Nam',0),
(N'BN02',N'Diệp Gia','Hữu','1999-07-23',N'Nam',0),
(N'BN03',N'Huỳnh Minh',N'Trí','1999-03-15',N'Nam',0),
(N'BN04',N'Nguyễn Khắc Hoàng',N'Phi','1999-02-15',N'Nam',0);

alter table Hospital.BenhNhans
drop column if exists full_name;
go

ALTER TABLE Hospital.BenhNhans
ADD full_name AS (HoBN + ' ' + TenBN) persisted;
go

alter table Hospital.BenhNhans
drop column if exists age_in_years;
go

ALTER TABLE Hospital.BenhNhans
ADD age_in_years 
    AS (CONVERT(INT,CONVERT(CHAR(8),GETDATE(),112))-CONVERT(CHAR(8),NgaySinh,112))/10000;
go



drop index if exists idx_BenhNhans_MaBN_inc
on Hospital.BenhNhans;
go

create nonclustered index idx_BenhNhans_MaBN_inc
on Hospital.BenhNhans (TenBN)
include (MaBN);
go

drop index if exists idx_BenhNhans_full_name_inc
on Hospital.BenhNhans;
go

create nonclustered index idx_BenhNhans_full_name_inc
on Hospital.BenhNhans (full_name)
include (MaBN);
go









--Create Table Hospital.PhieuDangKys
use QuanLyBenhVienDoAnCuoiKi;
go
create table Hospital.PhieuDangKys
(
	MaPhieuDK nvarchar(10) not null,
	Hide BIT DEFAULT(0) NULL,
	MaNV nvarchar(10) not null,
	MaBN nvarchar(10) not null,
	MaKhoa nvarchar(10) not null,
	MaBA nvarchar(10) not null,
	constraint PK_PhieuDangKys_MaPhieuDK primary key clustered (MaPhieuDK asc),
	constraint CK_PhieuDangKys_MaBA unique (MaBA)
)
go

--Chèn dữ liệu
INSERT INTO Hospital.PhieuDangKys 
VALUES
(N'PDK01',0,N'NV03',N'BN01',N'K01',N'BA01'),
(N'PDK02',0,N'NV03',N'BN02',N'K02',N'BA02'),
(N'PDK03',0,N'NV03',N'BN03',N'K03',N'BA03');



drop index if exists idx_PDK_MaPDK_inc
on Hospital.PhieuDangKys;
go

create nonclustered index idx_PDK_MaPDK_inc
on Hospital.PhieuDangKys (MaBA)
include (MaPhieuDK);
go

drop index if exists idx_PDK_MaPDK_joinMaBN_inc
on Hospital.PhieuDangKys;
go

create nonclustered index idx_PDK_MaPDK_joinMaBN_inc
on Hospital.PhieuDangKys (MaBN)
include (MaPhieuDK);

drop index if exists idx_PDK_MaPDK_joinMaKhoa_inc
on Hospital.PhieuDangKys;
go

create nonclustered index idx_PDK_MaPDK_joinMaKhoa_inc
on Hospital.PhieuDangKys (MaKhoa)
include (MaPhieuDK);
go

drop index if exists idx_PDK_MaPDK_joinMaNV_inc
on Hospital.PhieuDangKys;
go

create nonclustered index idx_PDK_MaPDK_joinMaNV_inc
on Hospital.PhieuDangKys (MaNV, MaPhieuDK);
go



--Create Table Hospital.HoSoBenhAns
use QuanLyBenhVienDoAnCuoiKi;
go
create table Hospital.HoSoBenhAns
(
	MaBA nvarchar(10) not null,
	ChuanDoanBenh nvarchar(30) not null,
	MaBS nvarchar(10) not null,
	MaPhong nvarchar(10) not null,
	SoNgayO float not null,
	Hide BIT DEFAULT(0) NULL,
	constraint PK_HSBAs_MaBA primary key clustered (MaBA asc)
)
go

--Chèn dữ liệu
INSERT INTO Hospital.HoSoBenhAns 
VALUES
(N'BA01',N'Viêm dạ dày',N'BS01',N'P01',5,0),
(N'BA02',N'Viêm ruột thừa',N'BS02',N'P02',3,0);



drop index if exists idx_HSBAs_MaBA_inc
on Hospital.HoSoBenhAns;
go

create nonclustered index idx_HSBAs_MaBA_inc
on Hospital.HoSoBenhAns (MaBS)
include (MaBA)
go

drop index if exists idx_HSBAs_ChuanDoanBenh_inc
on Hospital.HoSoBenhAns;
go

create nonclustered index idx_HSBAs_ChuanDoanBenh_inc
on Hospital.HoSoBenhAns (ChuanDoanBenh)
include (MaBA);
go

drop index if exists idx_HSBAs_MaPhong_join
on Hospital.HoSoBenhAns;

create nonclustered index idx_HSBAs_MaPhong_join
on Hospital.HoSoBenhAns (MaPhong, MaBA);





--Create Table Hospital.HoaDons
use QuanLyBenhVienDoAnCuoiKi;
go
create table Hospital.HoaDons
(
	MaHD nvarchar(10) not null,
	TenHD nvarchar(30) not null,
	GiaHD float not null,
	Hide BIT DEFAULT(0) NULL,
	MaNV nvarchar(10) not null,
	MaBA nvarchar(10) not null,
	NgayLapHD datetime not null,
	NgayThanhToanHD datetime not null,
	constraint PK_HoaDons_MaHD primary key clustered (MaHD asc),
	constraint CK_HoaDons_MaBA unique (MaBA)
)
go

--Chèn dữ liệu
INSERT INTO Hospital.HoaDons 
VALUES
(N'HD01',N'Hóa đơn A',500000,0,N'NV02',N'BA01','2019-11-05','2019-12-01'),
(N'HD02',N'Hóa đơn B',400000,0,N'NV02',N'BA02','2019-11-06','2019-12-05');



drop index if exists idx_HoaDons_MaHD_inc
on Hospital.HoaDons;
go

create nonclustered index idx_HoaDons_MaHD_inc
on Hospital.HoaDons (MaBA)
include (MaHD)
go

drop index if exists idx_HDs_TenHD_inc
on Hospital.HoaDons;
go

create nonclustered index idx_HDs_MaHD_inc
on Hospital.HoaDons (TenHD)
include (MaHD);
go

drop index if exists idx_HoaDons_MaNV_join
on Hospital.HoaDons;

create nonclustered index idx_HoaDons_MaNV_join
on Hospital.HoaDons (MaNV, MaHD);

create table Hospital.LoaiPhongs
(
	MaLoaiPhong nvarchar(10) not null,
	TenLoaiPhong nvarchar(20) not null,
	GiaPhong float not null,
	Hide BIT DEFAULT(0) not NULL,
	constraint PK_LoaiPhongs_MaLoaiPhong primary key clustered (MaLoaiPhong asc)
)
go

INSERT INTO Hospital.LoaiPhongs 
VALUES
(N'LP01',N'Phòng thường',10000,0),
(N'LP02',N'Phòng vip',50000,0);



drop index if exists idx_LoaiPhongs_MaLoaiPhong_inc
on Hospital.LoaiPhongs;
go

create index idx_LoaiPhongs_MaLoaiPhong_inc
on Hospital.LoaiPhongs (TenLoaiPhong)
include (MaLoaiPhong)
go

create table Hospital.Phongs
(
	MaPhong nvarchar(10) not null,
	MaLoaiPhong nvarchar(10) not null,
	TenPhong nvarchar(30) not null,
	Hide BIT DEFAULT(0) not NULL,
	constraint PK_Phongs_MaPhong primary key clustered (MaPhong asc)
)
go

INSERT INTO Hospital.Phongs 
VALUES
(N'P01',N'Phòng khám tổng quát',N'LP01',0),
(N'P02',N'Phòng siêu âm',N'LP02',0),
(N'P03',N'Phòng xét nghiệm',N'LP01',0);



drop index if exists idx_Phongs_MaPhong_inc
on Hospital.Phongs;
go

create index idx_Phongs_MaPhong_inc
on Hospital.Phongs (TenPhong)
include (MaPhong);
go

drop index if exists idx_Phongs_MaPhong_join
on Hospital.Phongs;

create nonclustered index idx_Phongs_MaPhong_join
on Hospital.Phongs (MaLoaiPhong,MaPhong);



--Create Table Hospital.Thuocs
create table Hospital.Thuocs
(
	MaThuoc nvarchar(10) not null, 
	TenThuoc nvarchar(30) not null, 
	GiaThuoc float not null,
	Hide BIT DEFAULT(0) NULL,
	constraint PK_Thuocs_MaThuoc primary key clustered (MaThuoc asc)
)
go

INSERT INTO Hospital.Thuocs 
VALUES
(N'T01',N'Thuốc A',70000,0),
(N'T02',N'Thuốc B',60000,0);



drop index if exists idx_Thuocs_MaThuoc_inc
on Hospital.Thuocs;
go

create nonclustered index idx_Thuocs_MaThuoc_inc
on Hospital.Thuocs(TenThuoc)
include (MaThuoc);
go



--Create Table Hospital.ToaThuocs
create table Hospital.ToaThuocs
(
	MaThuoc NVARCHAR(10) NOT NULL,
	MaBA NVARCHAR(10) NOT NULL,
	SoLuong INT NOT NULL,
	Hide BIT DEFAULT(0) NULL,
	CONSTRAINT pk_MaThuoc_MaBA PRIMARY KEY clustered(MaThuoc,MaBA)
)
go

INSERT INTO Hospital.ToaThuocs 
VALUES
(N'T01',N'BA01',50,0),
(N'T02',N'BA02',30,0);





--Create table Hospital.LoaiXetNghiems
create table Hospital.LoaiXetNghiems
(
	MaLoaiXN nvarchar(10) not null,
	TenLoaiXN nvarchar(30) not null,
	GiaLXN float,
	Hide BIT DEFAULT(0) NULL,
	constraint PK_LoaiXNs_MaLoaiXN primary key clustered (MaLoaiXN)
)
go

INSERT INTO Hospital.LoaiXetNghiems 
VALUES
(N'LXN01',N'Xét nghiệm máu',200000,0),
(N'LXN02',N'Xét nghiệm y khoa',100000,0);



drop index if exists idx_LoaiXNs_MaLoaiXN_inc
on Hospital.LoaiXetNghiems;
go

create nonclustered index idx_LoaiXNs_MaLoaiXN_inc
on Hospital.LoaiXetNghiems (TenLoaiXN)
include (MaLoaiXN);
go



--Create table Hospital.XetNghiems
create table Hospital.XetNghiems
(
	MaXN nvarchar(10) not null,
	TenXN nvarchar(100) not null,
	MaLoaiXN nvarchar(10) not null,
	Hide BIT DEFAULT(0) NULL,
	constraint PK_XNs_MaXN primary key clustered (MaXN)
)
go

INSERT INTO Hospital.XetNghiems 
VALUES
(N'XN01',N'Xét nghiệm sinh hóa máu',N'LXN01',0),
(N'XN02',N'Xét nghiệm miễn dịch',N'LXN02',0);



drop index if exists idx_XNs_MaXN_inc
on Hospital.XetNghiems;
go

create nonclustered index idx_XNs_MaXN_inc
on Hospital.XetNghiems (TenXN)
include (MaXN);
go

drop index if exists idx_XNs_MaXN_join
on Hospital.XetNghiems;
go

create nonclustered index idx_XNs_MaXN_join
on Hospital.XetNghiems (MaLoaiXN,MaXN);


--Create table Hospital.ToaXetNghiems
create table Hospital.ToaXetNghiems
(
	MaXN NVARCHAR(10) NOT NULL,
	MaBA NVARCHAR(10) NOT NULL,
	NgayXN DATETIME NOT NULL, 
	Hide BIT DEFAULT(0) NULL,
	CONSTRAINT PK_MaXN_MaBA PRIMARY KEY clustered (MaXN,MaBA)
)
go

INSERT INTO Hospital.ToaXetNghiems 
VALUES
(N'XN01',N'BA01','2019-02-23',0),
(N'XN02',N'BA02','2019-03-28',0);

use QuanLyBenhVienDoAnCuoiKi;
create table Hospital.UndoTable
(
	iID int identity,
	MaPhong nVARCHAR(10) null,
	MaLoaiPhong nvarchar(10) null,
	TenPhong nvarchar(30) null,
	Hide BIT DEFAULT(0) NULL,
	iStatus varchar(10)
)
go

create table Hospital.RedoTable
(
	iID int identity,
	MaPhong nVARCHAR(10) null,
	MaLoaiPhong nvarchar(10) null,
	TenPhong nvarchar(30) null,
	Hide BIT DEFAULT(0) NULL,
	iStatus varchar(10)
)
go

create table Hospital.UndoTableHoaDons
(
	iID int identity,
	MaHD nVARCHAR(10) null,
	TenHD nvarchar(30) null,
	GiaHD float null,
	Hide BIT DEFAULT(0) null,
	MaNV nvarchar(10) null,
	MaBA nvarchar(10) null,
	NgayLapHD datetime null,
	NgayThanhToanHD datetime null,
	ThoiGian datetime null,
	iStatus varchar(10)
)
go

create table Hospital.RedoTableHoaDons
(
	iID int identity,
	MaHD nVARCHAR(10) null,
	TenHD nvarchar(30) null,
	GiaHD float null,
	Hide BIT DEFAULT(0) null,
	MaNV nvarchar(10) null,
	MaBA nvarchar(10) null,
	NgayLapHD datetime null,
	NgayThanhToanHD datetime null,
	ThoiGian datetime null,
	iStatus varchar(10)
)
go

--Foreign key
alter table Hospital.PhieuDangKys
with nocheck add constraint FK_PDKs_NVs
	foreign key (MaNV) references HR.NhanViens(MaNV);
go

alter table Hospital.PhieuDangKys
with nocheck add constraint FK_PhieuDangKys_BenhNhans
	foreign key (MaBN) references Hospital.BenhNhans(MaBN);
go

alter table Hospital.PhieuDangKys
with nocheck add constraint FK_PhieuDangKys_Khoas
	foreign key (MaKhoa) references Hospital.Khoas(MaKhoa);
go

alter table Hospital.PhieuDangKys
with nocheck add constraint FK_PhieuDangKys_HoSoBenhAns
	foreign key (MaBA) references Hospital.HoSoBenhAns(MaBA);
go

alter table Hospital.HoSoBenhAns
with nocheck add constraint FK_HSBAs_BS
	foreign key (MaBS) references Hospital.BacSis (MaBS);
go

alter table Hospital.HoSoBenhAns
with nocheck add constraint FK_HSBAs_Phong
	foreign key (MaPhong) references Hospital.Phongs (MaPhong);
go

alter table Hospital.HoaDons
with nocheck add constraint FK_HDs_HSBAs
	foreign key (MaBA) references Hospital.HoSoBenhAns(MaBA);
go

alter table Hospital.HoaDons
with nocheck add constraint FK_HDs_NVs
	foreign key (MaNV) references HR.NhanViens (MaNV);
go

alter table Hospital.Phongs
with nocheck add constraint FK_Phongs_LoaiPhongs
	foreign key (MaLoaiPhong) references Hospital.LoaiPhongs(MaLoaiPhong);
go

alter table Hospital.XetNghiems
with nocheck add constraint FK_XNs_LoaiXNs
	foreign key (MaLoaiXN) references Hospital.LoaiXetNghiems(MaLoaiXN);
go

alter table Hospital.ToaXetNghiems
with nocheck add constraint FK_ToaXNs_XNs
	foreign key (MaXN) references Hospital.XetNghiems(MaXN);
go

alter table Hospital.ToaXetNghiems
with nocheck add constraint FK_ToaXNs_HSBAs
	foreign key (MaBA) references Hospital.HoSoBenhAns(MaBA);
go

alter table Hospital.ToaThuocs
with nocheck add constraint FK_ToaThuocs_HSBAs
 foreign key (MaBA) references Hospital.HoSoBenhAns(MaBA);
go

alter table Hospital.ToaThuocs
with nocheck add constraint FK_ToaThuocs_Thuocs
 foreign key (MaThuoc) references Hospital.Thuocs(MaThuoc);
go

alter table Hospital.Bacsis
with nocheck add constraint FK_BSs_Khoas
	foreign key (MaKhoa) references Hospital.Khoas(MaKhoa);
go
