USE master;
GO
DROP DATABASE IF EXISTS HospitalManagement;
GO
CREATE DATABASE HospitalManagement;
GO
USE HospitalManagement;
GO 

CREATE TABLE Account
(
	UserID NVARCHAR(50) NOT NULL,
	Password NVARCHAR(50) NOT NULL
	CONSTRAINT pk_account PRIMARY KEY (UserID)	
);
INSERT INTO Account VALUES
(N'Admin',N'123'),
--(N'admin',N'123'),
(N'nguyenpro',N'456'),
(N'manager',N'456'),
(N'employee',N'456'),
(N'khoa',N'123'),
(N'quan',N'123');

--CREATE TABLE Khoa
--(
--	MaKhoa NVARCHAR(50) NOT NULL,
--	TenKhoa NVARCHAR(100) NOT NULL,
--	CONSTRAINT pk_khoa PRIMARY KEY (MaKhoa),
--	CONSTRAINT ck_khoa UNIQUE (TenKhoa) 
--);

--CREATE TABLE BacSi
--(
--	MaBacSi NVARCHAR(50) NOT NULL,
--	TenBacSi NVARCHAR(100) NOT NULL,
--	DiaChiBacSi NVARCHAR(100) NOT NULL,
--	SdtBacSi NVARCHAR(50) NOT NULL,
--	MaKhoa NVARCHAR(50) NOT NULL
--	CONSTRAINT pk_bacsi PRIMARY KEY (MaBacSi),
--	CONSTRAINT ck_bacsi UNIQUE (TenBacSi)
--);

CREATE TABLE Benh
(
	--MaBenh NVARCHAR(50) NOT NULL,
	TenBenh NVARCHAR(50) NOT NULL,
	TrieuChung1 NVARCHAR(50) NOT NULL,
	TrieuChung2 NVARCHAR(50) NOT NULL,
	TrieuChung3 NVARCHAR(50) NOT NULL
	CONSTRAINT pk_benh PRIMARY KEY (TenBenh),
	--CONSTRAINT ck_benh UNIQUE (TenBenh)	
);
INSERT INTO Benh VALUES
(N'Cảm',N'Sốt',N'Chóng mặt',N'Đau đầu'),
(N'Đau dạ dày',N'Đau bụng thường xuyên',N'Chán ăn, ợ hơi, ợ chua',N'Nôn mửa,Dạ dày xuất huyết,Bụng chướng'),
(N'HIV',N'Sốt,Đau đầu,Ho khan',N'Đau cơ và khớp,Buồn nôn, tiêu chảy',N'Sụt cân'),
(N'Sốt xuất huyết',N'Chán ăn,Đau đầu',N'Đau cơ-khớp,Đau đằng sau mắt',N'Đau họng nhẹ,Phát ban,Tiêu chảy'),
(N'Tiểu đường',N'Khát nước,Đi tiểu thường xuyên',N'Vết thương chậm lành,Mệt mỏi',N'Giảm cân nhanh chóng,Cảm giác đói dữ dội'),
(N'Viêm ruột thừa',N'Nôn mửa,Sốt nhẹ',N'Rối loạn tiêu hóa,Chán ăn',N'Vùng bụng dưới sưng');

CREATE TABLE BenhNhan
(
	MaBenhNhan NVARCHAR(50) NOT NULL,
	TenBenhNhan NVARCHAR(50) NOT NULL,
	DateOfBirth DATETIME NOT NULL,
	GioiTinh NVARCHAR(50) NOT NULL,
	QueQuan NVARCHAR(50) NOT NULL,
	Benh NVARCHAR(50) NOT NULL,
	TinhTrang NVARCHAR(50) NOT NULL
	CONSTRAINT pk_benhnhan PRIMARY KEY (MaBenhNhan)
	--CONSTRAINT ck_benhnhan UNIQUE (TenBenhNhan)
);
INSERT INTO BenhNhan VALUES
(N'0',N'Lư Mạnh Quân','1999-07-11',N'Nam',N'TP.HCM',N'HIV',N'Còn sống'),
(N'1',N'Trương Minh Khoa','1999-10-11',N'Nam',N'TP.HCM',N'Cảm',N'Còn sống'),
(N'2',N'Trương Minh Khoa1','1999-11-11',N'Nam',N'TP.HCM',N'Cảm',N'Còn sống'),
(N'3',N'Trương Minh Khoa2','1999-12-08',N'Nam',N'TP.HCM',N'Cảm',N'Bình thường'),
(N'4',N'Trương Minh Khoa3','1999-01-11',N'Nam',N'TP.HCM',N'Cảm',N'Đã xuất viện'),
(N'5',N'Trương Minh Khoa4','1999-02-11',N'Nam',N'TP.HCM',N'Cảm',N'Còn sống'),
(N'6',N'Trương Minh Khoa5','1999-03-11',N'Nam',N'TP.HCM',N'Cảm',N'Còn sống'),
(N'7',N'Trương Minh Khoa6','1999-04-11',N'Nam',N'TP.HCM',N'Cảm',N'Còn sống'),
(N'8',N'Trương Minh Khoa7','1999-10-25',N'Nam',N'TP.HCM',N'Cảm',N'Còn sống'),
(N'9',N'Trương Minh Khoa8','1999-10-06',N'Nam',N'TP.HCM',N'Cảm',N'Đã chết'),
(N'10',N'Trương Minh Khoa9','1999-10-25',N'Nam',N'TP.HCM',N'Viêm ruột thừa',N'Còn sống');

CREATE TABLE DoanhThuQuy1
(
	MaSo NVARCHAR(50) NOT NULL,
	HoTen NVARCHAR(50) NOT NULL,
	Benh NVARCHAR(50) NOT NULL,
	NgayXuatVien DATE NOT NULL,
	ChiPhi INT NOT NULL
	CONSTRAINT pk_doanhthuquy1 PRIMARY KEY (MaSo)
);
INSERT INTO DoanhThuQuy1 VALUES
(N'0',N'Lư Mạnh Quân',N'HIV','2019-06-14',15000);

CREATE TABLE DoanhThuQuy2
(
	MaSo NVARCHAR(50) NOT NULL,
	HoTen NVARCHAR(50) NOT NULL,
	Benh NVARCHAR(50) NOT NULL,
	NgayXuatVien DATE NOT NULL,
	ChiPhi INT NOT NULL,
	CONSTRAINT pk_doanhthuquy2 PRIMARY KEY (MaSo)
);
INSERT INTO DoanhThuQuy2 VALUES
(N'1',N'Trương Minh Khoa',N'Cảm','2019-06-18',20000);

CREATE TABLE DoanhThuQuy3
(
	MaSo NVARCHAR(50) NOT NULL,
	HoTen NVARCHAR(50) NOT NULL,
	Benh NVARCHAR(50) NOT NULL,
	NgayXuatVien DATE NOT NULL,
	ChiPhi INT NOT NULL,
	CONSTRAINT pk_doanhthuquy3 PRIMARY KEY (MaSo)
);
INSERT INTO DoanhThuQuy3 VALUES
(N'2',N'Trương Minh Khoa1',N'Cảm','2019-07-21',30000);

CREATE TABLE DSBenhNhanDaXuatVien
(
	MaSo NVARCHAR(50) NOT NULL,
	HoTen NVARCHAR(50) NOT NULL,
	Benh NVARCHAR(50) NOT NULL,
	CONSTRAINT pk_dsbenhnhandaxuatvien PRIMARY KEY (MaSo)
);

--USE QuanLyBenhVien;
--GO
--SELECT TOP 100 * FROM dbo.DSBenhNhanDaXuatVien;

CREATE TABLE HeSoLuong
(
	NgheNghiep NVARCHAR(50) NOT NULL,
	HeSoLuongTheoGio FLOAT NOT NULL,
	--MaNV NVARCHAR(50) NOT NULL,
	CONSTRAINT pk_hesoluong PRIMARY KEY (NgheNghiep)
);
DROP TABLE IF EXISTS dbo.HeSoLuong;

INSERT INTO HeSoLuong VALUES
(N'Bác sĩ',20),
(N'Y tá',4);

CREATE TABLE HoaDon
(
	MaSo NVARCHAR(50) NOT NULL,
	SoLuongThuocA INT NOT NULL,
	SoLuongThuocB INT NOT NULL,
	SoLuongThuocC INT NOT NULL,
	SoLuongThuocD INT NOT NULL,
	SoLuongThuocE INT NOT NULL,
	PhiDieuTri INT NULL,
	CONSTRAINT pk_hoadon PRIMARY KEY (MaSo)		
);
INSERT INTO HoaDon VALUES
(N'2',5,0,0,0,0,NULL),
(N'4',0,0,0,15,0,NULL),
(N'5',0,0,0,0,0,NULL);

CREATE TABLE NhanVien
(
	MaNV NVARCHAR(50) NOT NULL,
	TenNhanVien NVARCHAR(50) NOT NULL,
	GioiTinh NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	DateOfBirth DATE NOT NULL,
	NgheNghiep NVARCHAR(50) NOT NULL,
	SoNgayDiLam INT NOT NULL
	CONSTRAINT pk_nhanvien PRIMARY KEY (MaNV),
	CONSTRAINT ck_nhanvien UNIQUE (TenNhanVien)
);
INSERT INTO NhanVien VALUES
(N'NV1',N'Trương Minh Khoaa',N'Nam',N'abc','1990-06-11',N'Y tá',5);

CREATE TABLE PhiDieuTri
(
	Benh NVARCHAR(50) NOT NULL,
	ChiPhi INT NOT NULL,
	CONSTRAINT pk_phidieutri PRIMARY KEY (Benh)
);
INSERT INTO PhiDieuTri VALUES
(N'Cảm',1000000),
(N'Đau dạ dày',200000),
(N'Gãy tay chân',10000),
(N'Hen xuyễn',300000),
(N'HIV',10000),
(N'Sốt xuất huyết',50000),
(N'Tiểu đường',3000),
(N'Ung thư',50000000),
(N'Viêm ruột thừa',100000);

ALTER TABLE dbo.PhiDieuTri
	DROP CONSTRAINT pk_phidieutri;
GO

ALTER TABLE dbo.PhiDieuTri
WITH NOCHECK ADD CONSTRAINT pk_phidieutri
	PRIMARY KEY (ChiPhi);


DROP TABLE IF EXISTS dbo.PhiDieuTri;
GO



GO 

CREATE TABLE SoLuongBenhNhan
(
	SLBN NVARCHAR(50) NOT NULL,
	CONSTRAINT pk_soluongbenhnhan PRIMARY KEY (SLBN)
);
INSERT INTO SoLuongBenhNhan VALUES
(N'2'),
(N'4'),
(N'5');

CREATE TABLE ThongTinBenhNhan
(
	MaSo NVARCHAR(50) NOT NULL,
	NgayNhapVien DATE NOT NULL,
	SoPhong NVARCHAR(50) NOT NULL,
	MSHoaDon NVARCHAR(50) NOT NULL,
	CONSTRAINT pk_thongtinbenhnhan PRIMARY KEY (MaSo, SoPhong, MSHoaDon)
);
INSERT INTO ThongTinBenhNhan VALUES
(N'2','2019-05-17',N'23',N'HD2'),
(N'4','2019-05-19',N'302',N'HD4'),
(N'5','2019-11-03',N'404',N'HD5');

--CREATE TABLE BenhNhan
--(
--	MaBenhNhan NVARCHAR(50) NOT NULL,
--	TenBenhNhan NVARCHAR(50) NOT NULL,
--	DateOfBirth DATETIME NOT NULL,
--	GioiTinh NVARCHAR(50) NOT NULL,
--	QueQuan NVARCHAR(50) NOT NULL,
--	Benh NVARCHAR(50) NOT NULL,
--	TinhTrang NVARCHAR(50) NOT NULL
--	CONSTRAINT pk_benhnhan PRIMARY KEY (MaBenhNhan)
--	--CONSTRAINT ck_benhnhan UNIQUE (TenBenhNhan)
--);

ALTER TABLE dbo.HoaDon
WITH NOCHECK ADD CONSTRAINT fk_hoadon_benhnhan
FOREIGN KEY (MaSo) REFERENCES dbo.BenhNhan(MaBenhNhan);
GO

ALTER TABLE dbo.HoaDon
	CHECK CONSTRAINT fk_hoadon_benhnhan;
GO

ALTER TABLE dbo.SoLuongBenhNhan
WITH NOCHECK ADD CONSTRAINT fk_soluongbenhnhan_hoadon
	FOREIGN KEY (SLBN) REFERENCES dbo.HoaDon(MaSo);
GO

ALTER TABLE dbo.SoLuongBenhNhan
	CHECK CONSTRAINT fk_soluongbenhnhan_hoadon;
go

--ALTER TABLE dbo.NhanVien
--WITH NOCHECK ADD CONSTRAINT fk_nhanvien_hesoluong
--	FOREIGN KEY (NgheNghiep) REFERENCES dbo.HeSoLuong(NgheNghiep);
--GO

--ALTER TABLE dbo.NhanVien
--	CHECK CONSTRAINT fk_nhanvien_hesoluong;
--GO

--ALTER TABLE dbo.HeSoLuong
--WITH NOCHECK ADD CONSTRAINT fk_hesoluong_nhanvien
--	FOREIGN KEY (MaNV) REFERENCES dbo.NhanVien(MaNV);
--GO

--ALTER TABLE dbo.HeSoLuong
--	CHECK CONSTRAINT fk_hesoluong_nhanvien;
--GO

ALTER TABLE dbo.NhanVien
WITH NOCHECK ADD CONSTRAINT fk_nhanvien_hesoluong
	FOREIGN KEY (NgheNghiep) REFERENCES dbo.HeSoLuong(NgheNghiep);
GO

ALTER TABLE dbo.NhanVien
	CHECK CONSTRAINT fk_nhanvien_hesoluong;
GO 

ALTER TABLE dbo.ThongTinBenhNhan
WITH NOCHECK ADD CONSTRAINT fk_thongtinbenhnhan_benhnhan
	FOREIGN KEY (MaSo) REFERENCES dbo.BenhNhan(MaBenhNhan);
GO

ALTER TABLE dbo.ThongTinBenhNhan
	CHECK CONSTRAINT fk_thongtinbenhnhan_benhnhan;
GO

ALTER TABLE dbo.ThongTinBenhNhan
WITH NOCHECK ADD CONSTRAINT fk_thongtinbenhnhan_hoadon
	FOREIGN KEY (MSHoaDon) REFERENCES dbo.HoaDon(MaSo);
GO

ALTER TABLE dbo.ThongTinBenhNhan
	CHECK CONSTRAINT fk_thongtinbenhnhan_hoadon;
GO

ALTER TABLE dbo.PhiDieuTri
WITH NOCHECK ADD CONSTRAINT fk_phidieutri_benh
	FOREIGN KEY (Benh) REFERENCES dbo.Benh(TenBenh);
GO

ALTER TABLE dbo.PhiDieuTri
	CHECK CONSTRAINT fk_phidieutri_benh;
GO

--ALTER TABLE dbo.ThongTinBenhNhan
--WITH NOCHECK ADD CONSTRAINT fk_thongtinbenhnhan_hoadon
--	FOREIGN KEY (MSHoaDon) REFERENCES dbo.HoaDon(MaSo);
--GO

--ALTER TABLE dbo.ThongTinBenhNhan
--	CHECK CONSTRAINT fk_thongtinbenhnhan_hoadon;
--go

--ALTER TABLE dbo.ThongTinBenhNhan
--	CHECK CONSTRAINT fk_thongtinbenhnhan_benhnhan;
--GO

ALTER TABLE dbo.DSBenhNhanDaXuatVien
WITH NOCHECK ADD CONSTRAINT fk_dsbenhnhandaxuatvien_benhnhan
	FOREIGN KEY (MaSo) REFERENCES dbo.BenhNhan(MaBenhNhan);
GO

ALTER TABLE dbo.DSBenhNhanDaXuatVien
	CHECK CONSTRAINT fk_dsbenhnhandaxuatvien_benhnhan;
GO

--ALTER TABLE dbo.BenhNhan
--WITH NOCHECK ADD CONSTRAINT fk_benhnhan_dsbenhnhandaxuatvien
--	FOREIGN KEY (MaBenhNhan) REFERENCES dbo.DSBenhNhanDaXuatVien (MaSo);
--GO

--ALTER TABLE dbo.BenhNhan
--	CHECK CONSTRAINT fk_benhnhan_dsbenhnhandaxuatvien;
--GO

ALTER TABLE dbo.DoanhThuQuy1
WITH NOCHECK ADD CONSTRAINT fk_doanhthuquy1_benhnhan
	FOREIGN KEY (MaSo) REFERENCES dbo.BenhNhan(MaBenhNhan);
GO

ALTER TABLE dbo.DoanhThuQuy1
	CHECK CONSTRAINT fk_doanhthuquy1_benhnhan;
GO

ALTER TABLE dbo.DoanhThuQuy2
WITH NOCHECK ADD CONSTRAINT fk_doanhthuquy2_benhnhan
	FOREIGN KEY (MaSo) REFERENCES dbo.BenhNhan(MaBenhNhan);
GO

ALTER TABLE dbo.DoanhThuQuy2
	CHECK CONSTRAINT fk_doanhthuquy2_benhnhan;
GO

ALTER TABLE dbo.DoanhThuQuy3
WITH NOCHECK ADD CONSTRAINT fk_doanhthuquy3_benhnhan
	FOREIGN KEY (MaSo) REFERENCES dbo.BenhNhan(MaBenhNhan);
GO

ALTER TABLE dbo.DoanhThuQuy3
	CHECK CONSTRAINT fk_doanhthuquy3_benhnhan;
GO


ALTER TABLE dbo.NhanVien
	DROP CONSTRAINT fk_nhanvien_hesoluong;
GO

DROP TABLE dbo.NhanVien;
GO

SELECT * FROM dbo.ThongTinBenhNhan;

USE HospitalManagement;
IF OBJECT_ID('spDangNhap') IS NOT NULL
	DROP PROC spDangNhap;
GO

CREATE PROC spDangNhap
	@UserID NVARCHAR(50),
	@Password NVARCHAR(50)
AS
BEGIN
    SELECT UserID, Password
	FROM dbo.Account
	WHERE UserID=@UserID
	AND Password=@Password;
END
GO

---- 3.4. Thêm User và Login
--Create Proc ThemTaiKhoanDangNhap
--(@TenTaiKhoan varchar(max),@matkhau varchar(max))
--as
--begin
--	begin transaction
--	--thêm login và user
--	declare @SQLStringCreateLogin varchar(max)
--	set @SQLStringCreateLogin= 'CREATE LOGIN ['+@TenTaiKhoan+'] WITH  PASSWORD = '''+@matkhau+''''+',DEFAULT_DATABASE=[QuanLyQuanAn_DoAnCuoiKi],
--			DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION = ON, CHECK_POLICY = ON;'
--	exec (@SQLStringCreateLogin)

--	declare @SQLStringCreateUser varchar (max)
--	set @SQLStringCreateUser =  'CREATE USER ['+@TenTaiKhoan+'] FOR LOGIN ['+@TenTaiKhoan+']'
--	exec (@SQLStringCreateUser)


--	if(@@ERROR <> 0 )
--	begin
--		RAISERROR (N'Có lỗi xảy ra khi tạo tài khoản !!!',16, 1)
--		rollback transaction
--		return
--		end
--		commit transaction
--	end
--Go

---- Thêm User và Login
--USE HospitalManagement;
--IF OBJECT_ID('spInsertAccount') IS NOT NULL
--	DROP PROC spInsertAccount;
--GO

--CREATE PROC spInsertAccount
--(@UserName NVARCHAR(50),@Password NVARCHAR(50))
--AS 
--BEGIN
--    BEGIN TRANSACTION
--    DECLARE @SQLStringCreateLogin NVARCHAR(MAX)
--	SET @SQLStringCreateLogin = 'CREATE LOGIN ['+@UserName+'] WITH PASSWORD = '''+@Password+''''+',DEFAULT_DATABASE=[HospitalManagement],
--		DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION = ON, CHECK_POLICY = ON;'
--	EXEC (@SQLStringCreateLogin)

--	DECLARE @SQLStringCreateUser NVARCHAR(MAX)
--	SELECT @SQLStringCreateUser = 'CREATE USER ['+@UserName+'] FOR LOGIN ['+@UserName+']'
--	EXEC (@SQLStringCreateUser)

--	IF (@@ERROR <> 0)
--	BEGIN
--		RAISERROR (N'Có lỗi xảy ra khi tạo tài khoản !!!',16,1)
--		ROLLBACK TRANSACTION
--		RETURN
--		END
--        COMMIT TRANSACTION
--    END
--GO

--create procedure HienThiThongTinNhanVien
--as
--Begin
--	select *from dbo.Account
--END
--GO 

USE HospitalManagement;
GO
SELECT * 
FROM dbo.NhanVien;
GO

SELECT * FROM dbo.BenhNhan;
