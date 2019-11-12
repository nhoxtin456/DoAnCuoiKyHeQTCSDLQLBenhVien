﻿USE master;

DROP DATABASE IF EXISTS QuanLyBenhVien_DoAnCuoiKi;

CREATE DATABASE QuanLyBenhVien_DoAnCuoiKi;
GO 

USE QuanLyBenhVien_DoAnCuoiKi;
GO

CREATE TABLE LoaiNhanVien
(
	MaLoaiNV NVARCHAR(10) NOT NULL,
	TenLoaiNV NVARCHAR(30) NOT NULL,
	CONSTRAINT pk_MaLoaiNhanVien PRIMARY KEY(MaLoaiNV),
	CONSTRAINT ck_TenLoaiNhanVien UNIQUE(TenLoaiNV)
);
INSERT INTO LoaiNhanVien VALUES
(N'LNV01',N'Nhân viên tiếp tân'),
(N'LNV02',N'Nhân viên kế toán');

CREATE TABLE NhanVien
(
	MaNV NVARCHAR(10) NOT NULL,
	HoNV NVARCHAR(30) NOT NULL,
	TenNV NVARCHAR(20) NOT NULL,
	NgaySinh DATE NOT NULL,
	GioiTinh NVARCHAR(10) NOT NULL,
	MaLoaiNV NVARCHAR(10) NOT NULL,
	CONSTRAINT pk_MaNV PRIMARY KEY(MaNV)
);
INSERT INTO NhanVien VALUES
(N'NV01',N'Tôn Nữ Như',N'Quỳnh','1999-02-25',N'Nữ',N'LNV01'),
(N'NV02',N'Nguyễn Thái Phương',N'Thảo','1999-10-16',N'Nữ',N'LNV02');

CREATE TABLE Khoa
(
	MaKhoa NVARCHAR(10) NOT NULL,
	TenKhoa NVARCHAR(30) NOT NULL,
	CONSTRAINT pk_MaKhoa PRIMARY KEY(MaKhoa),
	CONSTRAINT ck_TenKhoa UNIQUE(TenKhoa)
);
INSERT INTO Khoa VALUES
(N'K01',N'Khoa ngoại'),
(N'K02',N'Khoa mắt');

CREATE TABLE BacSi
(
	MaBS NVARCHAR(10) NOT NULL,
	HoBS NVARCHAR(30) NOT NULL,
	TenBS NVARCHAR(20) NOT NULL,
	NgaySinh DATE NOT NULL,
	GioiTinh NVARCHAR(10) NOT NULL,
	ChucVu NVARCHAR(20) NOT NULL,
	MaKhoa NVARCHAR(10) NOT NULL,
	CONSTRAINT pk_MaBS PRIMARY KEY(MaBS)
);
INSERT INTO BacSi VALUES
(N'BS01',N'Trương Minh',N'Khoa','1999-10-11',N'Nam',N'Trưởng khoa',N'K01'),
(N'BS02',N'Lư Mạnh',N'Quân','1999-06-25',N'Nam',N'Phó khoa',N'K02');

CREATE TABLE BenhNhan
(
	MaBN NVARCHAR(10) NOT NULL,
	HoBN NVARCHAR(30) NOT NULL,
	TenBN NVARCHAR(20) NOT NULL,
	NgaySinh DATE NOT NULL,
	GioiTinh NVARCHAR(10) NOT NULL,
	TinhTrang NVARCHAR(20) NOT NULL,
	CONSTRAINT pk_MaBN PRIMARY KEY(MaBN)
);
INSERT INTO  BenhNhan VALUES
(N'BN01',N'Đoàn Quốc',N'Hùng','1999-06-15',N'Nam',N'Bình thường'),
(N'BN02',N'Diệp Gia','Hữu','1999-07-23',N'Nam',N'Bình thường');

CREATE TABLE PhieuDangKy
(
	MaPhieuDK NVARCHAR(10) NOT NULL,
	MaNV NVARCHAR(10) NOT NULL,
	MaBN NVARCHAR(10) NOT NULL,
	MaKhoa NVARCHAR(10) NOT NULL,
	--MaBA NVARCHAR(10) NOT NULL,
	CONSTRAINT pk_MaPhieuDK PRIMARY KEY(MaPhieuDK)
);
INSERT INTO PhieuDangKy VALUES
(N'PDK01',N'NV01',N'BN01',N'K01'),
(N'PDK02',N'NV02',N'BN02',N'K02');

CREATE TABLE LoaiXetNghiem
(
	MaLoaiXN NVARCHAR(10) NOT NULL,
	TenLoaiXN NVARCHAR(30) NOT NULL,
	CONSTRAINT pk_MaLoaiXN PRIMARY KEY(MaLoaiXN),
	CONSTRAINT ck_TenLoaiXN UNIQUE(TenLoaiXN)
);
INSERT INTO LoaiXetNghiem VALUES
(N'LXN01',N'Xét nghiệm máu'),
(N'LXN02',N'Xét nghiệm y khoa');

CREATE TABLE XetNghiem
(
	MaXN NVARCHAR(10) NOT NULL,
	TenXN NVARCHAR(20) NOT NULL,
	GiaXN FLOAT NOT NULL,
	MaLoaiXN NVARCHAR(10) NOT NULL,
	CONSTRAINT pk_MaXN PRIMARY KEY(MaXN),
	CONSTRAINT ck_TenXN UNIQUE(TenXN)
);
--SET ANSI_WARNINGS OFF
INSERT INTO XetNghiem VALUES
(N'XN01',N'Xét nghiệm sinh hóa máu',500000,N'LXN01'),
(N'XN02',N'Xét nghiệm miễn dịch',2000000,N'LXN02');

--DROP TABLE IF EXISTS dbo.XetNghiem;



CREATE TABLE ToaXetNghiem
(
	MaXN NVARCHAR(10) NOT NULL,
	MaBA NVARCHAR(10) NOT NULL,
	NgayXN DATE NOT NULL, 
	CONSTRAINT PK_MaXN_MaBA PRIMARY KEY(MaXN,MaBA)
);
INSERT INTO ToaXetNghiem VALUES
(N'XN01',N'BA01','2019-02-23'),
(N'XN02',N'BA02','2019-03-28');

--DROP TABLE IF EXISTS dbo.ToaXetNghiem;
--GO



CREATE TABLE LoaiPhongBenh
(
	MaLoaiPhong NVARCHAR(10) NOT NULL,
	TenLoaiPhong NVARCHAR(20) NOT NULL,
	CONSTRAINT pk_MaLoaiPhong PRIMARY KEY(MaLoaiPhong),
	CONSTRAINT ck_TenLoaiPhong UNIQUE(TenLoaiPhong)
);
INSERT INTO LoaiPhongBenh VALUES
(N'LP01',N'Phòng vip'),
(N'LP02',N'Phòng thường');

CREATE TABLE PhongBenh
(
	MaPhong NVARCHAR(10) NOT NULL,
	TenPhong NVARCHAR(30) NOT NULL,
	GiaPhong FLOAT NOT NULL,
	MaLoaiPhong NVARCHAR(10) NOT NULL,
	CONSTRAINT pk_MaPhong PRIMARY KEY(MaPhong),
	CONSTRAINT ck_TenPhong UNIQUE(TenPhong)
);
INSERT INTO PhongBenh VALUES
(N'P01',N'Phòng khám tổng quát',60000,N'LP01'),
(N'P02',N'Phòng siêu âm',70000,N'LP02');

CREATE TABLE Thuoc
(
	MaThuoc NVARCHAR(10) NOT NULL,
	TenThuoc NVARCHAR(30) NOT NULL,
	GiaThuoc FLOAT NOT NULL,
	CONSTRAINT pk_MaThuoc PRIMARY KEY(MaThuoc),
	CONSTRAINT ck_TenThuoc UNIQUE(TenThuoc)	
);
INSERT INTO Thuoc VALUES
(N'T01',N'Thuốc A',70000),
(N'T02',N'Thuốc B',60000);

CREATE TABLE HoaDon
(
	MaHD NVARCHAR(10) NOT NULL,
	TenHD NVARCHAR(30) NOT NULL,
	GiaHD FLOAT NOT NULL,
	MaNV NVARCHAR(10) NOT NULL,
	MABA NVARCHAR(10) NOT NULL,
	CONSTRAINT pk_MaHD PRIMARY KEY(MaHD),
	CONSTRAINT ck_MaHD UNIQUE(TenHD),
	CONSTRAINT ck_MaBA UNIQUE(MABA)
);
INSERT INTO HoaDon VALUES
(N'HD01',N'Hóa đơn A',500000,N'NV02',N'BA01'),
(N'HD02',N'Hóa đơn B',400000,N'NV02',N'BA02');

CREATE TABLE HoSoBenhAn
(
	MaBA NVARCHAR(10) NOT NULL,
	ChuanDoanBenh NVARCHAR(30) NOT NULL,
	MaBS NVARCHAR(10) NOT NULL,
	MaPhong NVARCHAR(10) NOT NULL,
	SoNgayO DATE NOT NULL,
	MaPhieuDK NVARCHAR(10) NOT NULL,
	CONSTRAINT pk_MaBA PRIMARY KEY(MaBA),
	CONSTRAINT ck_MaPhieuDK UNIQUE(MaPhieuDK)
);
INSERT INTO HoSoBenhAn VALUES
(N'BA01',N'Viêm dạ dày',N'BN01',N'P01','2019-08-07',N'PDK01'),
(N'BA02',N'Viêm ruột thừa',N'BN02',N'P02','2019-06-12',N'PDK02');

CREATE TABLE ToaThuoc
(
	MaThuoc NVARCHAR(10) NOT NULL,
	MaBA NVARCHAR(10) NOT NULL,
	SoLuong INT NOT NULL,
	CONSTRAINT pk_MaThuoc_MaBA PRIMARY KEY(MaThuoc,MaBA)	
);

INSERT INTO ToaThuoc VALUES
(N'T01',N'BA01',50),
(N'T02',N'BA02',30);

ALTER TABLE dbo.NhanVien
WITH NOCHECK ADD CONSTRAINT fk_NhanVien_LoaiNhanVien
	FOREIGN KEY(MaLoaiNV) REFERENCES dbo.LoaiNhanVien(MaLoaiNV);
GO

ALTER TABLE dbo.NhanVien
	CHECK CONSTRAINT fk_NhanVien_LoaiNhanVien;
GO

ALTER TABLE dbo.HoaDon
WITH NOCHECK ADD CONSTRAINT fk_HoaDon_NhanVien
	FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV);
GO

ALTER TABLE dbo.HoaDon
	DROP CONSTRAINT fk_HoaDon_NhanVien;
GO

ALTER TABLE dbo.HoaDon
	CHECK CONSTRAINT fk_HoaDon_NhanVien;
GO 

ALTER TABLE dbo.BacSi
WITH NOCHECK ADD CONSTRAINT fk_BacSi_Khoa
	FOREIGN KEY(MaKhoa) REFERENCES dbo.Khoa(MaKhoa);
GO

ALTER TABLE dbo.XetNghiem
WITH NOCHECK ADD CONSTRAINT fk_XetNghiem_LoaiXetNghiem
	FOREIGN KEY(MaLoaiXN) REFERENCES dbo.LoaiXetNghiem(MaLoaiXN);
GO

ALTER TABLE dbo.PhongBenh
WITH NOCHECK ADD CONSTRAINT fk_PhongBenh_LoaiPhongBenh
	FOREIGN KEY(MaLoaiPhong) REFERENCES dbo.LoaiPhongBenh(MaLoaiPhong);
GO

ALTER TABLE dbo.PhieuDangKy
WITH NOCHECK ADD CONSTRAINT fk_PhieuDangKy_NhanVien
	FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV);
GO

ALTER TABLE dbo.PhieuDangKy
WITH NOCHECK ADD CONSTRAINT fk_PhieuDangKy_BenhNhan
	FOREIGN KEY(MaBN) REFERENCES dbo.BenhNhan(MaBN);
GO

ALTER TABLE dbo.PhieuDangKy
WITH NOCHECK ADD CONSTRAINT fk_PhieuDangKy_Khoa
	FOREIGN KEY(MaKhoa) REFERENCES dbo.Khoa(MaKhoa);
GO 

ALTER TABLE dbo.HoSoBenhAn
WITH NOCHECK ADD CONSTRAINT fk_HSBA_PhieuDK
	FOREIGN KEY(MaPhieuDK) REFERENCES dbo.PhieuDangKy(MaPhieuDK);
GO 

ALTER TABLE dbo.HoSoBenhAn
WITH NOCHECK ADD CONSTRAINT FK_HSBA_MaBS
	FOREIGN KEY(MaBS) REFERENCES dbo.BacSi(MaBS);
GO

ALTER TABLE dbo.HoSoBenhAn
WITH NOCHECK ADD CONSTRAINT FK_HSBA_MaPhong
	FOREIGN KEY(MaPhong) REFERENCES dbo.PhongBenh(MaPhong);
GO





ALTER TABLE dbo.HoaDon
WITH NOCHECK ADD CONSTRAINT fk_HD_HSBA
	FOREIGN KEY(MABA) REFERENCES dbo.HoSoBenhAn(MaBA);
GO

ALTER TABLE dbo.HoaDon
WITH NOCHECK ADD CONSTRAINT fk_HD_NV
	FOREIGN KEY(MaNV) REFERENCES dbo.NhanVien(MaNV);
GO 

ALTER TABLE dbo.ToaXetNghiem
WITH NOCHECK ADD CONSTRAINT fk_ToaXN_HSBA_XN
	FOREIGN KEY(MaXN) REFERENCES dbo.XetNghiem(MaXN);
GO

ALTER TABLE dbo.ToaXetNghiem
WITH NOCHECK ADD CONSTRAINT fk_ToaXN_XN_HSBA
	FOREIGN KEY(MaBA) REFERENCES dbo.HoSoBenhAn(MaBA);
GO

ALTER TABLE dbo.ToaThuoc
WITH NOCHECK ADD CONSTRAINT fk_ToaThuoc_HSBA
	FOREIGN KEY(MaBA) REFERENCES dbo.HoSoBenhAn(MaBA);
GO

ALTER TABLE dbo.ToaThuoc
WITH NOCHECK ADD CONSTRAINT fk_ToaThuoc_Thuoc
	FOREIGN KEY(MaThuoc) REFERENCES dbo.Thuoc(MaThuoc);
GO







ALTER TABLE dbo.PhieuDangKy
	DROP CONSTRAINT fk_PhieuDK_HSBA;
GO

ALTER TABLE dbo.PhieuDangKy
WITH NOCHECK ADD CONSTRAINT fk_PhieuDK_HSBA
	FOREIGN KEY(MaBA) REFERENCES dbo.HoSoBenhAn(MaBA);
GO

ALTER TABLE dbo.PhieuDangKy
	DROP CONSTRAINT fk_PhieuDK_HSBA;
GO





--DROP TABLE IF EXISTS dbo.HoSoBenhAn;

--DROP TABLE IF EXISTS dbo.PhieuDangKy;

--DROP TABLE IF EXISTS PhieuDK;

--USE QuanLyBenhVien_DoAnCuoiKi;
--GO


--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO

--CREATE TABLE HoSoBenhAn
--(
--	MaBA NVARCHAR(10) NOT NULL,
--	Name NVARCHAR(10) NOT NULL,
--	MaPDK NVARCHAR(10) NOT NULL,
--	--CONSTRAINT pk_MaBA PRIMARY KEY(MaBA)
--	CONSTRAINT PK_HSBA PRIMARY KEY (MaBA)
--);

--CREATE TABLE PhieuDK
--(
--	MaPDK NVARCHAR(10) NOT NULL,
--	Name NVARCHAR(10) NOT NULL,
--	MaBA NVARCHAR(10) NOT NULL,
--	CONSTRAINT PK_PDK PRIMARY KEY (MaPDK),
--	CONSTRAINT ck_PDK_MaBA UNIQUE(MaBA)
--);

--ALTER TABLE dbo.PhieuDK
--	DROP CONSTRAINT FK_abc;
--GO

--ALTER TABLE dbo.PhieuDK
--WITH NOCHECK ADD CONSTRAINT FK_PhieuDK_HSBA
--	FOREIGN KEY(MaBA) REFERENCES dbo.HoSoBenhAn(MaBA);
--GO



--ALTER TABLE dbo.PhieuDangKy
--WITH NOCHECK ADD CONSTRAINT fk_PDK_HSBA
--	FOREIGN KEY(MaPDK) REFERENCES dbo.PhieuDangKy(MaPDK);
--GO

--ALTER TABLE dbo.PhieuDK WITH NOCHECK ADD CONSTRAINT FK_abc FOREIGN KEY(MaPDK) REFERENCES dbo.HoSoBenhAn(MaBA);

--	ALTER TABLE [dbo].[AuthorBiography]  WITH CHECK ADD  CONSTRAINT [FK_AuthorBiography_Authors_AuthorId] FOREIGN KEY([AuthorId])
--REFERENCES [dbo].[Authors] ([AuthorId])
--ON DELETE CASCADE
--GO
--ALTER TABLE [dbo].[AuthorBiography] CHECK CONSTRAINT [FK_AuthorBiography_Authors_AuthorId]
--GO



--ALTER TABLE dbo.ToaThuoc
--WITH NOCHECK ADD CONSTRAINT fk_a
--	FOREIGN KEY(MaBA) REFERENCES dbo.HoSoBenhAn(MaBA)

--ALTER TABLE dbo.ToaThuoc
--WITH NOCHECK ADD CONSTRAINT fk_b
--	FOREIGN KEY(MaThuoc) REFERENCES dbo.Thuoc(MaThuoc)