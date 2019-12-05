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

-- Drop constraint
alter table HR.NhanViens
	check constraint FK_NhanViens_LoaiNhanViens;
go

alter table HR.NhanViens
	drop constraint FK_NhanViens_LoaiNhanViens;
go

alter table Hospital.PhieuDangKys
	check constraint FK_PhieuDangKys_BenhNhans;
go

alter table Hospital.PhieuDangKys
	drop constraint FK_PhieuDangKys_BenhNhans;
go

alter table Hospital.PhieuDangKys
	check constraint FK_PhieuDangKys_Khoas;
go

alter table Hospital.PhieuDangKys
	drop constraint FK_PhieuDangKys_Khoas;
go

alter table Hospital.PhieuDangKys
	check constraint FK_PhieuDangKys_HoSoBenhAns;
go

alter table Hospital.PhieuDangKys
	drop constraint FK_PhieuDangKys_HoSoBenhAns;
go

alter table Hospital.PhieuDangKys
	check constraint FK_PKDs_NVs;
go

alter table Hospital.PhieuDangKys
	drop constraint FK_PKDs_NVs;
go

alter table Hospital.BacSis
	check constraint FK_BSs_Khoas;
go

alter table Hospital.BacSis
	drop constraint FK_BSs_Khoas;
go

alter table Hospital.HoSoBenhAns
	check constraint FK_HSBAs_BS;
go

alter table Hospital.HoSoBenhAns
	drop constraint FK_HSBAs_BS;
go

alter table Hospital.HoSoBenhAns
	check constraint FK_HSBAs_Phong;
go

alter table Hospital.HoSoBenhAns
	drop constraint FK_HSBAs_Phong;
go

alter table Hospital.HoaDons
	check constraint FK_HDs_HSBAs;
go

alter table Hospital.HoaDons
	drop constraint FK_HDs_HSBAs;
go

alter table Hospital.HoaDons
	check constraint FK_HDs_NVs;
go

alter table Hospital.ToaThuocs
	check constraint FK_ToaThuocs_HSBAs;
go

alter table Hospital.ToaThuocs
	drop constraint FK_ToaThuocs_HSBAs;
go

alter table Hospital.ToaThuocs
	check constraint FK_ToaThuocs_Thuocs;
go

alter table Hospital.ToaThuocs
	drop constraint FK_ToaThuocs_Thuocs;
go

alter table Hospital.ToaXetNghiems
	check constraint FK_ToaXNs_HSBAs;
go

alter table Hospital.ToaXetNghiems
	drop constraint FK_ToaXNs_HSBAs;
go

alter table Hospital.ToaXetNghiems
	check constraint FK_ToaXNs_XNs;
go

alter table Hospital.ToaXetNghiems
	drop constraint FK_ToaXNs_XNs;
go

alter table Hospital.XetNghiems
	check constraint FK_XNs_LoaiXNs;
go

alter table Hospital.XetNghiems
	drop constraint FK_XNs_LoaiXNs;
go

alter table Hospital.Phongs
	check constraint FK_Phongs_LoaiPhongs;
go

alter table Hospital.Phongs
	drop constraint FK_Phongs_LoaiPhongs;
go

--Drop Tables first then Drop Schemas

drop table if exists HR.LoaiNhanViens;
go

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

truncate table Hospital.UndoTable;
go

truncate table Hospital.RedoTable;
go

drop table if exists Hospital.UndoTable;
go

drop table if exists Hospital.RedoTable;
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

-- Create table HR.LoaiNhanViens

use QuanLyBenhVienDoAnCuoiKi;
go

CREATE TABLE HR.LoaiNhanViens
(
	MaLoaiNV nvarchar(10)       not null,
	TenLoaiNV nvarchar(50)      not null,
	Hide BIT DEFAULT(0)			NULL,
	CONSTRAINT PK_LoaiNhanViens_MaLoaiNV PRIMARY KEY CLUSTERED (MaLoaiNV ASC)
);
go

--Chèn dữ liệu

insert into HR.LoaiNhanViens
(MaLoaiNV, TenLoaiNV, Hide)
values 
(N'LNV01',N'Giám đốc bệnh viện',0),
(N'LNV02',N'Nhân viên kế toán',0),
(N'LNV03',N'Nhân viên tiếp tân',0);
go

use QuanLyBenhVienDoAnCuoiKi;
go

DROP INDEX if exists idx_LoaiNVs_TenLoaiNV_MaLoaiNV_Hide 
on HR.LoaiNhanViens;
go

CREATE NONCLUSTERED INDEX idx_LoaiNVs_TenLoaiNV_MaLoaiNV_Hide
ON HR.LoaiNhanViens(TenLoaiNV,MaLoaiNV)
include (Hide);
go

set statistics io, time on
go

--Cold-cache testing
checkpoint;
dbcc dropcleanbuffers;
go

--Disable read-ahead
dbcc traceon(652, -1);
go

--select MaLoaiNV
--from HR.LoaiNhanViens
--where TenLoaiNV=N'Nhân viên tiếp tân';

--select TenLoaiNV
--from HR.LoaiNhanViens
--where MaLoaiNV=N'LNV01';

--select
--	MaLoaiNV
--from HR.LoaiNhanViens
--where Hide=0;

--select * from hr.LoaiNhanViens;

--select
--	Hide
--from
--	HR.LoaiNhanViens
--where TenLoaiNV=N'Nhân viên tiếp tân'

--select
--	MaLoaiNV
--from
--	HR.LoaiNhanViens
--where TenLoaiNV=N'Nhân viên tiếp tân'

--select
--	TenLoaiNV
--from HR.LoaiNhanViens
--where MaLoaiNV=N'LNV01';

--select 
--	MaLoaiNV
--	TenLoaiNV,
--	Hide
--from 
--	HR.LoaiNhanViens
--where MaLoaiNV = N'LNV01';

--select
--	MaLoaiNV,
--	TenLoaiNV,
--	Hide
--from
--	HR.LoaiNhanViens P
--where P.TenLoaiNV = N'Giám đốc bệnh viện';

--select
--	MaLoaiNV,
--	TenLoaiNV,
--	Hide
--from
--	HR.LoaiNhanViens P
--where P.Hide=0 and P.TenLoaiNV=N'Nhân viên tiếp tân';
--go

--select * from HR.LoaiNhanViens;

set statistics io, time off
go

--Enable read-ahead
dbcc traceoff(652,-1);
go

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
	MaLoaiNV nvarchar(10)  not null,
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
ON HR.NhanViens(email_local_part, MaLoaiNV)
include (MaNV);
go

--select
--	MaLoaiNV,
--	MaNV
--from HR.NhanViens
--where email_local_part=N'khoa'

--drop index if exists idx_NhanViens_TenNV_inc
--on hr.NhanViens;
--go

--drop index if exists idx_NhanViens_MaLoaiNV_inc
--on HR.NhanViens;

--select
--	MaLoaiNV
--from HR.NhanViens
--where TenNV=N'Thảo'

CREATE nonclustered INDEX idx_NhanViens_TenNV_inc
ON HR.NhanViens(TenNV,MaNV)
include (MaLoaiNV)
go

CREATE nonclustered INDEX idx_NhanViens_MaLoaiNV_inc
ON HR.NhanViens(MaLoaiNV)
include (MaNV)
go

--Chèn dữ liệu
insert into HR.NhanViens
(MaNV,MatKhau,HoNV,TenNV,NgaySinh,GioiTinh,SDT,Email,Luong,Quyen,Hide,MaLoaiNV)
values 
(N'NV01',N'abc',N'Trương Minh',N'Khoa','1999-10-11',N'Nam',N'0911321110',N'khoa@gmail.com',5000000,N'admin',0,N'LNV01'),

(N'NV02',N'abc',N'Nguyễn Thái Phương',N'Thảo','1999-10-26',N'Nữ',N'0919976141',N'thao@gmail.com',1000000,N'ketoan',0,N'LNV02'),

(N'NV03',N'abc',N'Thạch Hoàng',N'Duy','1999-03-25',N'Nam',N'0976533148',N'duy@gmail.com',2000000,N'tieptan',0,N'LNV03'),

(N'NV04',N'abc',N'Nguyễn Hoàng',N'Bảo','1999-03-26',N'Nam',N'0971516148',N'bao@gmail.com',500000,N'tieptan',0,N'LNV03');

set statistics io, time on
go

--Cold-cache testing
checkpoint;
dbcc dropcleanbuffers;
go

--Disable read-ahead
dbcc traceon(652, -1);
go

--select
--	TenLoaiNV
--from HR.NhanViens C
--inner join HR.LoaiNhanViens P
--	on C.MaLoaiNV=P.MaLoaiNV
--where MaNV=N'NV01';

--select * from HR.NhanViens;

--select
--	MaLoaiNV
--from HR.NhanViens
--where email_local_part=N'khoa';

--select
--	MaLoaiNV
--from HR.NhanViens
--where MaNV=N'NV01';

--select
--	MaNV
--from HR.NhanViens
--where Quyen=N'tieptan'

--select
--	MaNV
--from HR.NhanViens
--where TenNV=N'Thảo'

--select
--	MaNV
--from HR.NhanViens
--where MaLoaiNV=N'LNV01'

--select
--	C.TenNV
--from
--	HR.LoaiNhanViens as P
--inner join
--	HR.NhanViens as C
--	on P.MaLoaiNV=C.MaLoaiNV
--where P.MaLoaiNV=N'LNV01'

--select
--	MaNV
--from HR.NhanViens
--where TenNV=N'Thảo'

--select
--	TenNV
--from HR.NhanViens
--where MaNV=N'NV01'

--select
--	MaNV
--from HR.NhanViens
--where HoNV=N'Nguyễn Thái Phương'

--select
--	C.MaNV,
--	C.TenNV
--from
--	HR.LoaiNhanViens as P
--inner join
--	HR.NhanViens as C
--	on P.MaLoaiNV=C.MaLoaiNV
--where P.MaLoaiNV=N'LNV01'

--select * from HR.NhanViens;
--go

set statistics io, time off
go

--Enable read-ahead
dbcc traceoff(652,-1);
go

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

set statistics io, time on
go

--Cold-cache testing
checkpoint;
dbcc dropcleanbuffers;
go

--Disable read-ahead
dbcc traceon(652, -1);
go

--select * from Hospital.Khoas;

--select
--	MaKhoa
--from Hospital.Khoas
--where TenKhoa=N'Khoa cấp cứu tổng hợp'

--select
--	TenKhoa
--from Hospital.Khoas
--where MaKhoa=N'K06';

--select
--	MaKhoa
--from Hospital.Khoas
--where TenKhoa=N'Khoa hô hấp';

set statistics io, time off
go

--Enable read-ahead
dbcc traceoff(652,-1);
go

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

--select * from Hospital.BacSis;

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

set statistics io, time on
go

--Cold-cache testing
checkpoint;
dbcc dropcleanbuffers;
go

--Disable read-ahead
dbcc traceon(652, -1);
go

--select
--	TenBS
--from Hospital.BacSis 
--where MaKhoa=N'K01';

--select 
--	TenBS
--from Hospital.Khoas  as P
--inner join 
--	Hospital.BacSis  as C
--	on P.MaKhoa=C.MaKhoa
--where P.MaKhoa=N'K02';

--select
--	MaBS
--from Hospital.BacSis 
--where TenBS=N'Quân';

set statistics io, time off
go

--Enable read-ahead
dbcc traceoff(652,-1);
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

--select * from Hospital.BenhNhans;

drop index if exists idx_BenhNhans_MaBN_inc
on Hospital.BenhNhans;
go

create nonclustered index idx_BenhNhans_MaBN_inc
on Hospital.BenhNhans (TenBN,Hide)
include (MaBN);
go

drop index if exists idx_BenhNhans_full_name_inc
on Hospital.BenhNhans;
go

create nonclustered index idx_BenhNhans_full_name_inc
on Hospital.BenhNhans (full_name, Hide)
include (MaBN);
go

set statistics io, time on
go

--Cold-cache testing
checkpoint;
dbcc dropcleanbuffers;
go

--Disable read-ahead
dbcc traceon(652, -1);
go


--select
--	MaBN
--from Hospital.BenhNhans
--where TenBN=N'Hùng';

--SELECT
--    MaBN
--FROM
--    Hospital.BenhNhans
--where 
--	full_name = N'Đoàn Quốc Hùng';

--select
--	MaBN,
--	full_name
--from Hospital.BenhNhans
--where
--	Hide=1;


--select 
--	MaBN
--from Hospital.BenhNhans
--where Hide=1

set statistics io, time off
go

--Enable read-ahead
dbcc traceoff(652,-1);
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

--select * from Hospital.PhieuDangKys;

drop index if exists idx_PDK_MaPDK_inc
on Hospital.PhieuDangKys;
go

create nonclustered index idx_PDK_MaPDK_inc
on Hospital.PhieuDangKys (MaBA, MaBN)
include (MaPhieuDK);
go

drop index if exists idx_PDK_MaPDK_joinMaBN_inc
on Hospital.PhieuDangKys;
go

create nonclustered index idx_PDK_MaPDK_joinMaBN_inc
on Hospital.PhieuDangKys (MaBN, MaNV)
include (MaPhieuDK);

drop index if exists idx_PDK_MaPDK_joinMaKhoa_inc
on Hospital.PhieuDangKys;
go

create nonclustered index idx_PDK_MaPDK_joinMaKhoa_inc
on Hospital.PhieuDangKys (MaKhoa, MaBN)
include (MaPhieuDK);
go

drop index if exists idx_PDK_MaPDK_joinMaNV_inc
on Hospital.PhieuDangKys;
go

create nonclustered index idx_PDK_MaPDK_joinMaNV_inc
on Hospital.PhieuDangKys (MaNV, MaPhieuDK);
go

set statistics io, time on
go

--Cold-cache testing
checkpoint;
dbcc dropcleanbuffers;
go

--Disable read-ahead
dbcc traceon(652, -1);
go

--select
--	P.TenKhoa
--from Hospital.PhieuDangKys C
--inner join Hospital.Khoas P
--	on C.MaKhoa=P.MaKhoa
--where C.MaPhieuDK=N'PDK01'

--select
--	HS.ChuanDoanBenh,
--	B.TenBN
--from Hospital.PhieuDangKys PDK
--inner join Hospital.HoSoBenhAns HS
--	on PDK.MaBA=HS.MaBA
--inner join Hospital.BenhNhans B
--	on PDK.MaBN=B.MaBN
--where MaPhieuDK=N'PDK01';

--select
--	T.TenBS,
--	Y.TenBN
--from Hospital.PhieuDangKys C
--inner join
--	Hospital.Khoas P
--		on P.MaKhoa=C.MaKhoa
--inner join
--	Hospital.BacSis T
--		on C.MaKhoa=T.MaKhoa
--inner join
--	Hospital.BenhNhans Y
--		on C.MaBN=Y.MaBN
--where MaPhieuDK=N'PDK01';
--select
--	MaPhieuDK
--from Hospital.PhieuDangKys C
--inner join HR.NhanViens P
--on C.MaNV=P.MaNV
--where P.MaNV=N'NV03'

set statistics io, time off
go

--Enable read-ahead
dbcc traceoff(652,-1);
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

--select * from Hospital.HoSoBenhAns;

drop index if exists idx_HSBAs_MaBA_inc
on Hospital.HoSoBenhAns;
go

create nonclustered index idx_HSBAs_MaBA_inc
on Hospital.HoSoBenhAns (MaBS, MaPhong)
include (MaBA)
go

drop index if exists idx_HSBAs_ChuanDoanBenh_inc
on Hospital.HoSoBenhAns;
go

create nonclustered index idx_HSBAs_ChuanDoanBenh_inc
on Hospital.HoSoBenhAns (ChuanDoanBenh, MaPhong)
include (MaBA);
go

drop index if exists idx_HSBAs_MaPhong_join
on Hospital.HoSoBenhAns;

create nonclustered index idx_HSBAs_MaPhong_join
on Hospital.HoSoBenhAns (MaPhong, MaBA);

set statistics io, time on
go

--Cold-cache testing
checkpoint;
dbcc dropcleanbuffers;
go

--Disable read-ahead
dbcc traceon(652, -1);
go

--select
--	MaBA
--from Hospital.HoSoBenhAns
--where ChuanDoanBenh=N'Viêm dạ dày'

--select * from Hospital.HoSoBenhAns;

--select
--	BS.TenBS,
--	P.TenPhong
--from Hospital.HoSoBenhAns HS
--inner join
--	Hospital.BacSis BS
--		on HS.MaBS=BS.MaBS
--inner join
--	Hospital.Phongs P
--		on HS.MaPhong=P.MaPhong
--where MaBA=N'BA01';

--select MaBA from Hospital.HoSoBenhAns C inner join Hospital.Phongs P on C.MaPhong=P.MaPhong where P.MaPhong = N'P01';

set statistics io, time off
go

--Enable read-ahead
dbcc traceoff(652,-1);
go

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

--select * from Hospital.HoaDons;

drop index if exists idx_HoaDons_MaHD_inc
on Hospital.HoaDons;
go

create nonclustered index idx_HoaDons_MaHD_inc
on Hospital.HoaDons (MaBA, MaNV)
include (MaHD)
go

drop index if exists idx_HDs_TenHD_inc
on Hospital.HoaDons;
go

create nonclustered index idx_HDs_MaHD_inc
on Hospital.HoaDons (TenHD, MaBA)
include (MaHD);
go

drop index if exists idx_HoaDons_MaNV_join
on Hospital.HoaDons;

create nonclustered index idx_HoaDons_MaNV_join
on Hospital.HoaDons (MaNV, MaHD);

--select
--	TenNV
--from Hospital.HoaDons C
--inner join HR.NhanViens P
--	on C.MaNV=P.MaNV
--where C.MaHD=N'HD01';


--select
--	MaHD
--from Hospital.HoaDons
--where MaBA=N'BA01';

--select
--	HS.ChuanDoanBenh,
--	NV.TenNV
--from 
--	Hospital.HoaDons HD
--inner join
--	Hospital.HoSoBenhAns HS
--		on HD.MaBA=HS.MaBA
--inner join
--	HR.NhanViens NV
--		on HD.MaNV=NV.MaNV
--where HD.MaHD=N'HD01';


--Create T
create table Hospital.LoaiPhongs
(
	MaLoaiPhong nvarchar(10) not null,
	TenLoaiPhong nvarchar(20) not null,
	GiaPhong float,
	Hide BIT DEFAULT(0) NULL,
	constraint PK_LoaiPhongs_MaLoaiPhong primary key clustered (MaLoaiPhong asc)
)
go

INSERT INTO Hospital.LoaiPhongs 
VALUES
(N'LP01',N'Phòng vip',1000000,0),
(N'LP02',N'Phòng thường',500000,0);

--select * from Hospital.LoaiPhongs;

drop index if exists idx_LoaiPhongs_MaLoaiPhong_inc
on Hospital.LoaiPhongs;
go

create index idx_LoaiPhongs_MaLoaiPhong_inc
on Hospital.LoaiPhongs (TenLoaiPhong)
include (MaLoaiPhong)
go

--select
--	LP.TenLoaiPhong
--from
--	Hospital.LoaiPhongs LP
--where LP.MaLoaiPhong=N'LP01';

--
create table Hospital.Phongs
(
	MaPhong nvarchar(10) not null,
	TenPhong nvarchar(30) not null,
	MaLoaiPhong nvarchar(10) not null,
	Hide BIT DEFAULT(0) NULL,
	constraint PK_Phongs_MaPhong primary key clustered (MaPhong asc)
)
go

INSERT INTO Hospital.Phongs 
VALUES
(N'P01',N'Phòng khám tổng quát',N'LP01',0),
(N'P02',N'Phòng siêu âm',N'LP02',0),
(N'P03',N'Phòng xét nghiệm',N'LP01',0);

--select * from Hospital.Phongs;

drop index if exists idx_Phongs_MaPhong_inc
on Hospital.Phongs;
go

create index idx_Phongs_MaPhong_inc
on Hospital.Phongs (TenPhong, MaLoaiPhong)
include (MaPhong);
go

drop index if exists idx_Phongs_MaPhong_join
on Hospital.Phongs;

create nonclustered index idx_Phongs_MaPhong_join
on Hospital.Phongs (MaLoaiPhong,MaPhong);

--select
--	P.TenLoaiPhong
--from Hospital.Phongs C
--inner join Hospital.LoaiPhongs P
--	on C.MaLoaiPhong=P.MaLoaiPhong
--where C.MaPhong=N'P01';

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

--select * from Hospital.Thuocs;

drop index if exists idx_Thuocs_MaThuoc_inc
on Hospital.Thuocs;
go

create nonclustered index idx_Thuocs_MaThuoc_inc
on Hospital.Thuocs(TenThuoc)
include (MaThuoc);
go

--select
--	T.MaThuoc
--from Hospital.Thuocs T
--where T.TenThuoc=N'Thuốc A';

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

drop index if exists idx_ToaThuocs_MaThuoc_inc
on Hospital.ToaThuocs;
go

create nonclustered index idx_ToaThuocs_MaThuoc_inc
on Hospital.ToaThuocs (MaBA)
include (MaThuoc);
go


--select * from Hospital.ToaThuocs;

--select
--	T.GiaThuoc
--from Hospital.ToaThuocs TT
--inner join Hospital.HoSoBenhAns HS
--	on TT.MaBA=HS.MaBA
--inner join Hospital.Thuocs T
--	on TT.MaThuoc=T.MaThuoc
--where TT.MaBA=N'BA01';

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

--select * from Hospital.LoaiXetNghiems;

drop index if exists idx_LoaiXNs_MaLoaiXN_inc
on Hospital.LoaiXetNghiems;
go

create nonclustered index idx_LoaiXNs_MaLoaiXN_inc
on Hospital.LoaiXetNghiems (TenLoaiXN)
include (MaLoaiXN);
go

select
	L.MaLoaiXN
from Hospital.LoaiXetNghiems L
where L.TenLoaiXN=N'Xét nghiệm máu';

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

--select * from Hospital.XetNghiems;

drop index if exists idx_XNs_MaXN_inc
on Hospital.XetNghiems;
go

create nonclustered index idx_XNs_MaXN_inc
on Hospital.XetNghiems (TenXN, MaLoaiXN)
include (MaXN);
go

drop index if exists idx_XNs_MaXN_join
on Hospital.XetNghiems;
go

create nonclustered index idx_XNs_MaXN_join
on Hospital.XetNghiems (MaLoaiXN,MaXN);

--select
--	C.MaXN,
--	P.GiaLXN
--from Hospital.XetNghiems C
--inner join
--	Hospital.LoaiXetNghiems P
--		on C.MaLoaiXN=P.MaLoaiXN
--where C.MaLoaiXN=N'LXN01';


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

--select * from Hospital.ToaXetNghiems;

drop index if exists idx_ToaXNs_MaXN_inc
on Hospital.ToaXetNghiems;
go

create nonclustered index idx_ToaXNs_MaXN_inc
on Hospital.ToaXetNghiems(MaBA)
include (MaXN);
go

--select
--	H.ChuanDoanBenh
--from Hospital.ToaXetNghiems T
--inner join
--	Hospital.HoSoBenhAns H
--		on T.MaBA=H.MaBA
--inner join
--	Hospital.XetNghiems X
--		on T.MaXN=X.MaXN
--where T.MaBA=N'BA01';



--select
--	T.GiaThuoc
--from Hospital.ToaThuocs TT
--inner join Hospital.HoSoBenhAns HS
--	on TT.MaBA=HS.MaBA
--inner join Hospital.Thuocs T
--	on TT.MaThuoc=T.MaThuoc
--where TT.MaBA=N'BA01';


--Foreign key
use QuanLyBenhVienDoAnCuoiKi;
go

alter table hr.NhanViens
	check constraint FK_NhanViens_LoaiNhanViens;
go

alter table HR.NhanViens
	drop constraint FK_NhanViens_LoaiNhanViens;
go

alter table hr.NhanViens
with nocheck add constraint FK_NhanViens_LoaiNhanViens
	foreign key (MaLoaiNV) references hr.LoaiNhanViens (MaLoaiNV);
go

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
