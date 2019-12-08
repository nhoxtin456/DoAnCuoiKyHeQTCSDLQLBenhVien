﻿use QuanLyBenhVienDoAnCuoiKi;
go
----------------------------------------------------------
--Views, store procedures, User defined function, trigger:
----------------------------------------------------------
-- Thêm NhanViens


--  Thêm User và Login
Create or alter Proc HR.spThemTaiKhoanDangNhap
(@TenTaiKhoan nvarchar(max),@matkhau nvarchar(max))
as
begin
	begin transaction
	--thêm login và user
	declare @SQLStringCreateLogin nvarchar(max)
	set @SQLStringCreateLogin= 'CREATE LOGIN ['+@TenTaiKhoan+'] WITH PASSWORD = '''+@matkhau+''''+',DEFAULT_DATABASE=[QuanLyBenhVienDoAnCuoiKi],
			DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION = ON, CHECK_POLICY = ON;'
	--exec (@SQLStringCreateLogin)		
	EXEC sp_executesql
	@stmt = @SQLStringCreateLogin,
	@params = N'@tentk AS nvarchar, @mk as nvarchar',
	@tentk = @TenTaiKhoan,
	@mk = @matkhau;

	declare @SQLStringCreateUser nvarchar (max)
	set @SQLStringCreateUser =  'CREATE USER ['+@TenTaiKhoan+'] FOR LOGIN ['+@TenTaiKhoan+']'

	--exec (@SQLStringCreateUser)

	EXEC sp_executesql
	@stmt = @SQLStringCreateUser,
	@params = N'@tentk AS nvarchar',
	@tentk = @TenTaiKhoan
	
	if(@@ERROR <> 0 )
	begin
		RAISERROR (N'Có lỗi xảy ra khi tạo tài khoản !!!',16, 1)
		rollback transaction
		return
		end
		commit transaction
	end
Go
	

-- Phân quyền cho user
Create or alter Proc HR.spPhanQuyenTaiKhoanDangNhap
(
	@Username nvarchar(10),
	@Quyen nvarchar(10)
)
as
begin
	if (@Quyen = 'NhanVien')
	begin
	exec sp_addrolemember 'NhanVien', @Username
	end

	if (@Quyen = 'Admin')
	begin
	exec sp_addrolemember 'Admin', @Username
	exec sp_addsrvrolemember 'Admin', @Username
	end
end
Go

--  Sửa thông tin tài khoản
Create or alter Proc HR.spSuaTaiKhoanDangNhap
(@TenTaiKhoan nvarchar(max),@matkhau nvarchar(max))
as
begin
	begin transaction
	--update login
	declare @SQLStringUpdateLogin nvarchar(max)
	set @SQLStringUpdateLogin= ' alter LOGIN ['+@TenTaiKhoan+'] WITH PASSWORD = '''+@matkhau+''''+''
	--exec (@SQLStringUpdateLogin)

	EXEC sp_executesql
	@stmt = @SQLStringUpdateLogin,
	@params = N'@tentk AS nvarchar,@mk as nvarchar',
	@tentk = @TenTaiKhoan,
	@mk = @matkhau;


	if(@@ERROR <> 0 )
	begin
		RAISERROR (N'Có lỗi xảy ra !!!',16, 1)
		rollback transaction
		return
		end
		commit transaction;
	end;
Go

-- Xóa tài khoản
Create or alter Proc HR.spXoaTaiKhoanDangNhap
(@TenTaiKhoan nvarchar(max))
as
begin
	begin transaction
	--thêm login và user
	declare @SQLStringDeleteUser nvarchar (max)
	set @SQLStringDeleteUser =  'drop user ['+@TenTaiKhoan+']'
--exec (@SQLStringDeleteUser)
	exec sp_executesql
	@stmt = @SQLStringDeleteUser,
	@params = N'@tentk as nvarchar',
	@tentk = @TenTaiKhoan;


	declare @SQLStringDeleteLogin nvarchar (max)
	set @SQLStringDeleteLogin =  'drop login ['+@TenTaiKhoan+']'
--exec (@SQLStringCreateLogin)
	exec sp_executesql
	@stmt = @SQLStringDeleteLogin,
	@params = N'@tentk as nvarchar',
	@tentk = @TenTaiKhoan;

	if(@@ERROR <> 0 )
	begin
		RAISERROR (N'Có lỗi xảy ra khi xóa tài khoản !!!',16, 1)
		rollback transaction
		return
		end
		commit transaction;
	end;
Go

--  Đổi mật khẩu
CREATE or alter PROCEDURE HR.spDoiMatKhauDangNhap
(
	@Username nvarchar(100),
	@Passwordcu nvarchar(100),
	@Passwordmoi  nvarchar(100))
as
begin tran
	declare @mkcu nvarchar(20)
	select @mkcu=MatKhau from HR.NhanViens where MaNV=@Username
	if (@mkcu=@Passwordcu)
	begin
		declare @mkmoi nvarchar(20)
		set @mkmoi=@Passwordmoi 
		
		update HR.NhanViens set MatKhau = @Passwordmoi where MaNV= @Username
		declare @SQLStringDoiMKDN nvarchar(max)
		set @SQLStringDoiMKDN= 'ALTER LOGIN ['+@Username + '] WITH PASSWORD = ''' + @Passwordmoi + ''' OLD_PASSWORD = ''' + @Passwordcu + ''''
		--exec(@SQLStringDoiMKDN)
		exec sp_executesql
		@stmt = @SQLStringDoiMKDN,
		@params = N'@user as nvarchar, @passnew as nvarchar, @passold as nvarchar',
		@user = @Username,
		@passnew=@mkmoi,
		@passold=@mkcu;
	end

	if (@@ERROR<>0)
	begin
		RAISERROR(N' Có lỗi xảy ra khi đổi mật khẩu', 16, 1)
		rollback tran
		return;
	end		
	commit tran;
Go

Use QuanLyBenhVienDoAnCuoiKi
Go
Create Role Admin
Go
--
	grant select,delete, insert, update on HR.NhanViens to Admin with  grant option



	grant exec on HR.spXoaTaiKhoanDangNhap to Admin with  grant option
	grant exec on HR.spThemTaiKhoanDangNhap to Admin with  grant option
	grant exec on HR.spSuaTaiKhoanDangNhap to Admin with  grant option
	grant exec on HR.spDoiMatKhauDangNhap to Admin with  grant option
	
	grant exec on HR.spGetNV to Admin with grant option

	--grant not exec on Hospital.spGetBN to Admin with grant option

	--Table

	grant select, delete, insert, update on Hospital.BacSis to Admin with grant option

	

	grant select, delete, insert, update on Hospital.Khoas to Admin with grant option

	grant select, delete, insert, update on Hospital.LoaiPhongs to Admin with grant option

	grant select, delete, insert, update on Hospital.LoaiXetNghiems to Admin with grant option

	

	grant select, delete, insert, update on Hospital.Phongs to Admin with grant option

	grant select, delete, insert, update on Hospital.RedoTable to Admin with grant option

	grant select, delete, insert, update on Hospital.Thuocs to Admin with grant option

	grant select, delete, insert, update on Hospital.ToaThuocs to Admin with grant option

	grant select, delete, insert, update on Hospital.ToaXetNghiems to Admin with grant option

	grant select, delete, insert, update on Hospital.UndoTable to Admin with grant option

	grant select, delete, insert, update on Hospital.XetNghiems to Admin with grant option

	grant select, delete, insert, update on Hospital.viewBenhNhan to Admin with grant option


	--Store Procedure
	
	

	--Function
	grant exec on HR.fnMaNhanVienTuDongTang to Admin with  grant option


go


Go
Create Role NhanVien

	grant select, delete, insert, update on Hospital.BenhNhans to Admin with grant option
	grant select, delete, insert, update on Hospital.PhieuDangKys to Admin with grant option

	

	grant select, delete, insert, update on Hospital.HoaDons to Admin with grant option

	grant select, delete, insert, update on Hospital.HoSoBenhAns to Admin with grant option


	grant exec on Hospital.spGetLoaiPhongs to NhanVien with  grant option



Go
--

create login NV01 with password='abc'
create user NV01 for login NV01 
execute sp_addrolemember 'Admin','NV01'
exec sp_addsrvrolemember 'NV01', 'sysadmin'
Go
--
create login NV02 with password='abc'
create user NV02 for login NV02
execute sp_addrolemember 'NhanVien','NV02'
--
go
--
--create login NV02 with password='123'
--create user NV02 for login NV02
--execute sp_addrolemember 'NhanVien','NV02'
--
Go
create login NV03 with password='123'
create user NV03 for login NV03
execute sp_addrolemember 'NhanVien','NV03'
Go
create login NV04 with password='123'
create user NV04 for login NV04
execute sp_addrolemember 'NhanVien','NV04'
Go
create login NV05 with password='123'
create user NV05 for login NV05
execute sp_addrolemember 'NhanVien','NV05'
Go
create login NV06 with password='123'
create user NV06 for login NV06
execute sp_addrolemember 'NhanVien','NV06'
Go
create login NV07 with password='123'
create user NV07 for login NV07
execute sp_addrolemember 'NhanVien','NV07'
Go
create login NV08 with password='123'
create user NV08 for login NV08
execute sp_addrolemember 'NhanVien','NV08'
Go
create login NV09 with password='123'
create user NV09 for login NV09
execute sp_addrolemember 'NhanVien','NV09'
Go
create login NV10 with password='123'
create user NV10 for login NV10
execute sp_addrolemember 'NhanVien','NV10'







if OBJECT_ID ('HR.spGetNV') is not null
	drop proc HR.spGetNV;
go

create proc HR.spGetNV
as
begin
	select * from HR.NhanViens;
end
go






if OBJECT_ID ('HR.spInsertNV') is not null
	drop proc HR.spInsertNV;
go

go
create or alter proc HR.spInsertNV
(
	@MaNV nvarchar(10) = null,
	@MatKhau varchar(20) = null,
	@HoNV nvarchar(50) = null,
	@TenNV nvarchar(20) = null,
	@NgaySinh datetime = null,
	@GioiTinh nvarchar(10) = null,
	@SDT nvarchar(30) = null,
	@Email nvarchar(30) = null,
	@Luong float = null,
	@Quyen nvarchar(30) = null,
	@Hide bit = 0
	--@MaLoaiNV nvarchar(10) = null
)
as
begin
	if exists (select * from HR.NhanViens where MaNV = @MaNV)
	throw 50001, 'Invalid MaNV.', 1;
	if (@MatKhau is null)
		throw 50001, 'Invalid MatKhau.', 1;
	if (@HoNV is null)
		throw 50001, 'Invalid HoNV.', 1;
	if (@TenNV is null)
		throw 50001, 'Invalid TenNV.', 1;
	if (@NgaySinh is null)
		throw 50001, 'Invalid NgaySinh.', 1;
	if (@GioiTinh is null)
		throw 50001, 'Invalid GioiTinh.', 1;
	if (@SDT is null)
		throw 50001, 'Invalid SDT.', 1;
	if (@Email is null)
		throw 50001, 'Invalid Email.', 1;
	if (@Luong is null)
		throw 50001, 'Invalid Luong.', 1;
	if (@Quyen is null)
		throw 50001, 'Invalid Quyen.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
	--if not exists(select MaLoaiNV,TenLoaiNV,Hide from HR.LoaiNhanViens where @MaLoaiNV=MaLoaiNV)
	--	throw 50001, 'Invalid MaLoaiNV.', 1;	
insert into HR.NhanViens
(MaNV,MatKhau,HoNV,TenNV,NgaySinh,GioiTinh,SDT,Email,Luong,Quyen,Hide)
values
(@MaNV,@MatKhau,@HoNV,@TenNV,@NgaySinh,@GioiTinh,@SDT,@Email,@Luong,@Quyen,@Hide)
Exec HR.spThemTaiKhoanDangNhap @MaNV,@MatKhau
Exec HR.spPhanQuyenTaiKhoanDangNhap @MaNV,@Quyen
--truncate table HR.RedoTableNV;
end
go
--exec HR.spGetLoaiNV;

--exec HR.spInsertLoaiNV @MaLoaiNV=N'LNV03',@TenLoaiNV=N'',@Hide='';

--delete from HR.LoaiNhanViens where MaLoaiNV=N'LNV04';
go

-- Cập nhật NhanViens
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('HR.spUpdateNV') is not null
	drop proc HR.spUpdateNV;
go

go
create or alter proc HR.spUpdateNV
(
	@MaNV nvarchar(10) = null,
	@MatKhau varchar(20) = null,
	@HoNV nvarchar(50) = null,
	@TenNV nvarchar(20) = null,
	@NgaySinh datetime = null,
	@GioiTinh nvarchar(10) = null,
	@SDT nvarchar(30) = null,
	@Email nvarchar(30) = null,
	@Luong float = null,
	@Quyen nvarchar(30) = null,
	@Hide bit = 0
	--@MaLoaiNV nvarchar(10) = null
)
as
begin
	if not exists (select * from HR.NhanViens where MaNV = @MaNV)
	throw 50001, 'Invalid MaNV.', 1;
	if (@MatKhau is null)
		throw 50001, 'Invalid MatKhau.', 1;
	if (@HoNV is null)
		throw 50001, 'Invalid HoNV.', 1;
	if (@TenNV is null)
		throw 50001, 'Invalid TenNV.', 1;
	if (@NgaySinh is null)
		throw 50001, 'Invalid NgaySinh.', 1;
	if (@GioiTinh is null)
		throw 50001, 'Invalid GioiTinh.', 1;
	if (@SDT is null)
		throw 50001, 'Invalid SDT.', 1;
	if (@Email is null)
		throw 50001, 'Invalid Email.', 1;
	if (@Luong is null)
		throw 50001, 'Invalid Luong.', 1;
	if (@Quyen is null)
		throw 50001, 'Invalid Quyen.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
	
update HR.NhanViens
set 
	MatKhau=@MatKhau,
	HoNV=@HoNV,
	TenNV=@TenNV,
	NgaySinh=@NgaySinh,
	GioiTinh=@GioiTinh,
	SDT=@SDT,
	Email=@Email,
	Luong=@Luong,
	Quyen=@Quyen,
	Hide=@Hide
	--MaLoaiNV=@MaLoaiNV
where MaNV=@MaNV
Exec HR.spSuaTaiKhoanDangNhap @MaNV,@MatKhau
end
go

-- Xóa NhanViens
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('HR.spDeleteNV') is not null
	drop proc HR.spDeleteNV;
go

create proc HR.spDeleteNV
(@MaNV nvarchar(10) = null)
as
begin
	if not exists (select * from HR.NhanViens where MaNV=@MaNV)
		throw 50001, 'Invalid MaNV.', 1;
delete from HR.NhanViens where MaNV=@MaNV;
Exec HR.spXoaTaiKhoanDangNhap @MaNV
end
go

--Lấy dữ liệu của bảng Hospital.BenhNhans
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spGetBN') is not null
	drop proc Hospital.spGetBN;
go

go
create proc Hospital.spGetBN
as
begin
	select * from Hospital.BenhNhans;
end
go

--Thêm BenhNhans
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spInsertBN') is not null
	drop proc Hospital.spInsertBN;
go

create proc Hospital.spInsertBN
(
	@MaBN nvarchar(10) = null,
	@HoBN nvarchar(30) = null,
	@TenBN nvarchar(20) = null,
	@NgaySinh datetime = null,
	@GioiTinh nvarchar(10) = null,
	@Hide bit = 0
)
as
begin
	if exists (select * from Hospital.BenhNhans where MaBN=@MaBN)
		throw 50001, 'Invalid MaBN.', 1;
	if (@HoBN is null)
		throw 50001, 'Invalid HoBN.', 1;
	if (@TenBN is null)
		throw 50001, 'Invalid TenBN.', 1;
	if (@NgaySinh is null)
		throw 50001, 'Invalid NgaySinh.', 1;
	if (@GioiTinh is null)
		throw 50001, 'Invalid GioiTinh.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
insert into Hospital.BenhNhans
(MaBN,HoBN,TenBN,NgaySinh,GioiTinh,Hide)
values
(@MaBN,@HoBN,@TenBN,@NgaySinh,@GioiTinh,@Hide)
end
go

--Cập nhật BenhNhans
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spUpdateBN') is not null
	drop proc Hospital.spUpdateBN;
go

create proc Hospital.spUpdateBN
(
	@MaBN nvarchar(10) = null,
	@HoBN nvarchar(30) = null,
	@TenBN nvarchar(20) = null,
	@NgaySinh datetime = null,
	@GioiTinh nvarchar(10) = null,
	@Hide bit = 0
)
as
begin
	if not exists (select * from Hospital.BenhNhans where MaBN=@MaBN)
		throw 50001, 'Invalid MaBN.', 1;
	if (@HoBN is null)
		throw 50001, 'Invalid HoBN.', 1;
	if (@TenBN is null)
		throw 50001, 'Invalid TenBN.', 1;
	if (@NgaySinh is null)
		throw 50001, 'Invalid NgaySinh.', 1;
	if (@GioiTinh is null)
		throw 50001, 'Invalid GioiTinh.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
update Hospital.BenhNhans
set
	HoBN=@HoBN,
	TenBN=@TenBN,
	NgaySinh=@NgaySinh,
	GioiTinh=@GioiTinh,
	Hide=@Hide
where MaBN=@MaBN
end
go

--Xóa BenhNhans
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spDeleteBN') is not null
	drop proc Hospital.spDeleteBN;
go

create proc Hospital.spDeleteBN
(@MaBN nvarchar(10) = null)
as
begin
	if not exists (select * from Hospital.BenhNhans where MaBN=@MaBN)
		throw 50001, 'Invalid MaBN.', 1;
delete from Hospital.BenhNhans
	where MaBN=@MaBN;
end
go


--Lấy dữ liệu của bảng Hospital.Khoas
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spGetKhoa') is not null
	drop proc Hospital.spGetKhoa;
go

create proc Hospital.spGetKhoa
as
begin
	select * from Hospital.Khoas;
end
go

--Thêm Khoas
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spInsertKhoa') is not null
	drop proc Hospital.spInsertKhoa;
go

create proc Hospital.spInsertKhoa
(
	@MaKhoa nvarchar(10) = null,
	@TenKhoa nvarchar(70) = null,
	@Hide bit = 0
)
as
begin
	if exists (select * from Hospital.Khoas where MaKhoa=@MaKhoa)
		throw 50001, 'Invalid MaKhoa.', 1;
	if (@TenKhoa is null)
		throw 50001, 'Invalid TenKhoa.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
insert into Hospital.Khoas
(MaKhoa,TenKhoa)
values
(@MaKhoa,@TenKhoa);
end
go

--Cập nhật Khoas
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spUpdateKhoa') is not null
	drop proc Hospital.spUpdateKhoa;
go

create proc Hospital.spUpdateKhoa
(
	@MaKhoa nvarchar(10) = null,
	@TenKhoa nvarchar(70) = null,
	@Hide bit = 0
)
as
begin
	if not exists (select * from Hospital.Khoas where MaKhoa=@MaKhoa)
		throw 50001, 'Invalid MaKhoa.', 1;
	if (@TenKhoa is null)
		throw 50001, 'Invalid TenKhoa.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
update Hospital.Khoas
set
	TenKhoa=@TenKhoa,
	Hide=@Hide
where MaKhoa=@MaKhoa;
end
go

--Xóa Khoas
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spDeleteKhoa') is not null
	drop proc Hospital.spDeleteKhoa;
go

create proc Hospital.spDeleteKhoa
(@MaKhoa nvarchar(10) = null)
as
begin
	if not exists (select * from Hospital.Khoas where MaKhoa=@MaKhoa)
		throw 50001, 'Invalid MaKhoa.', 1;
delete from Hospital.Khoas
	where MaKhoa=@MaKhoa;
end
go


--Lấy dữ liệu của bảng Hospital.PhieuDangKys
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spGetPhieuDangKy') is not null
	drop proc Hospital.spGetPhieuDangKy;
go

create proc Hospital.spGetPhieuDangKy
as
begin
	select * from Hospital.PhieuDangKys;
end
go

--Thêm PhieuDangKys
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spCreatePhieuDangKy') is not null
	drop proc Hospital.spCreatePhieuDangKy;
go

create proc Hospital.spCreatePhieuDangKy
(
	@MaPhieuDK nvarchar(10) = null,
	@Hide bit = 0,
	@MaNV nvarchar(10) = null,
	@MaBN nvarchar(10) = null,
	@MaKhoa nvarchar(10) = null,
	@MaBA nvarchar(10) = null
)
as
begin
	if exists (select * from Hospital.PhieuDangKys where MaPhieuDK=@MaPhieuDK)
		throw 50001, 'Invalid MaPhieuDK.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
	if not exists (select * from HR.NhanViens where MaNV=@MaNV)
		throw 50001, 'Invalid MaNV.', 1;
	if not exists (select * from Hospital.BenhNhans where MaBN=@MaBN)
		throw 50001, 'Invalid MaBN.', 1;
	if not exists (select * from Hospital.Khoas where MaKhoa=@MaKhoa)
		throw 50001, 'Invalid MaKhoa.', 1;
	if not exists (select * from Hospital.HoSoBenhAns where MaBA=@MaBA)
		throw 50001, 'Invalid MaBA.', 1;
insert into Hospital.PhieuDangKys
(MaPhieuDK,Hide,MaNV,MaBN,MaKhoa,MaBA)
values
(@MaPhieuDK,@Hide,@MaNV,@MaBN,@MaKhoa,@MaBA);
end
go

--Cập nhật PhieuDangKys
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spUpdatePhieuDangKy') is not null
	drop proc Hospital.spUpdatePhieuDangKy;
go

create proc Hospital.spUpdatePhieuDangKy
(
	@MaPhieuDK nvarchar(10) = null,
	@Hide bit = 0,
	@MaNV nvarchar(10) = null,
	@MaBN nvarchar(10) = null,
	@MaKhoa nvarchar(10) = null,
	@MaBA nvarchar(10) = null
)
as
begin
	if not exists (select * from Hospital.PhieuDangKys where MaPhieuDK=@MaPhieuDK)
		throw 50001, 'Invalid MaPhieuDK.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
	if not exists (select * from HR.NhanViens where MaNV=@MaNV)
		throw 50001, 'Invalid MaNV.', 1;
	if not exists (select * from Hospital.BenhNhans where MaBN=@MaBN)
		throw 50001, 'Invalid MaBN.', 1;
	if not exists (select * from Hospital.Khoas where MaKhoa=@MaKhoa)
		throw 50001, 'Invalid MaKhoa.', 1;
	if not exists (select * from Hospital.HoSoBenhAns where MaBA=@MaBA)
		throw 50001, 'Invalid MaBA.', 1;
update Hospital.PhieuDangKys
set
	Hide=@Hide,
	MaNV=@MaNV,
	MaBN=@MaBN,
	MaKhoa=@MaKhoa,
	MaBA=@MaBA
where MaPhieuDK=@MaPhieuDK;
end
go

--Xóa PhieuDangKys
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spDeletePhieuDangKy') is not null
	drop proc Hospital.spDeletePhieuDangKy;
go

create proc Hospital.spDeletePhieuDangKy
(@MaPhieuDK nvarchar(10) = null)
as
begin
	if not exists (select * from Hospital.PhieuDangKys where MaPhieuDK=@MaPhieuDK)
		throw 50001, 'Invalid MaPhieuDK.', 1;
delete from Hospital.PhieuDangKys
	where MaPhieuDK=@MaPhieuDK;
end
go


--Lấy dữ liệu của bảng Hospital.BacSis
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spGetBS') is not null
	drop proc Hospital.spGetBS;
go

create proc Hospital.spGetBS
as
begin
	select * from Hospital.BacSis;
end
go

--Thêm BacSis
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spInsertBS') is not null
	drop proc Hospital.spInsertBS;
go

create or alter proc Hospital.spInsertBS
(
	@MaBS nvarchar(10) = null,
	@HoBS nvarchar(30) = null,
	@TenBS nvarchar(20) = null,
	@NgaySinh datetime = null,
	@GioiTinh nvarchar(10) = null,
	@ChucVu nvarchar(20) = null,
	@MaKhoa nvarchar(10) = null,
	@Hide bit = 0
)
as
begin
	if exists (select * from Hospital.BacSis where MaBS=@MaBS)
		throw 50001, 'Invalid MaBS.', 1;
	if (@HoBS is null)
		throw 50001, 'Invalid HoBS.', 1;
	if (@TenBS is null)
		throw 50001, 'Invalid TenBS.', 1;
	if (@NgaySinh is null)
		throw 50001, 'Invalid NgaySinh.', 1;
	if (@GioiTinh is null)
		throw 50001, 'Invalid GioiTinh.', 1;
	if (@ChucVu is null)
		throw 50001, 'Invalid ChucVu.', 1;
	if not exists (select * from Hospital.Khoas where MaKhoa=@MaKhoa)
		throw 50001, 'Invalid MaKhoa.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
insert into Hospital.BacSis
(MaBS,HoBS,TenBS,NgaySinh,GioiTinh,ChucVu,MaKhoa,Hide)
values
(@MaBS,@HoBS,@TenBS,@NgaySinh,@GioiTinh,@ChucVu,@MaKhoa,@Hide);
end
go

--Cập nhật BacSis
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spUpdateBS') is not null
	drop proc Hospital.spUpdateBS;
go

create proc Hospital.spUpdateBS
(
	@MaBS nvarchar(10) = null,
	@HoBS nvarchar(30) = null,
	@TenBS nvarchar(20) = null,
	@NgaySinh datetime = null,
	@GioiTinh nvarchar(10) = null,
	@ChucVu nvarchar(20) = null,
	@MaKhoa nvarchar(10) = null,
	@Hide bit = 0
)
as
begin
	if not exists (select * from Hospital.BacSis where MaBS=@MaBS)
		throw 50001, 'Invalid MaBS.', 1;
	if (@HoBS is null)
		throw 50001, 'Invalid HoBS.', 1;
	if (@TenBS is null)
		throw 50001, 'Invalid TenBS.', 1;
	if (@NgaySinh is null)
		throw 50001, 'Invalid NgaySinh.', 1;
	if (@GioiTinh is null)
		throw 50001, 'Invalid GioiTinh.', 1;
	if (@ChucVu is null)
		throw 50001, 'Invalid ChucVu.', 1;
	if not exists (select * from Hospital.Khoas where MaKhoa=@MaKhoa)
		throw 50001, 'Invalid MaKhoa.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
update Hospital.BacSis
set
	HoBS=@HoBS,
	TenBS=@TenBS,
	NgaySinh=@NgaySinh,
	GioiTinh=@GioiTinh,
	ChucVu=@ChucVu,
	MaKhoa=@MaKhoa,
	Hide=@Hide
where MaBS=@MaBS;
end
go

--Xóa BacSis
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spDeleteBS') is not null
	drop proc Hospital.spDeleteBS;
go

create proc Hospital.spDeleteBS
(@MaBS nvarchar(10) = null)
as
begin
	if not exists (select * from Hospital.BacSis where MaBS=@MaBS)
		throw 50001, 'Invalid MaBS.', 1;
delete from Hospital.BacSis
	where MaBS=@MaBS;
end
go


--Lấy dữ liệu của bảng HoSoBenhAns
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spGetHSBA') is not null
	drop proc Hospital.spGetHSBA;
go

create proc Hospital.spGetHSBA
as
begin
	select * from Hospital.HoSoBenhAns;
end
go

--Thêm HoSoBenhAns
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spCreateHSBA') is not null
	drop proc Hospital.spCreateHSBA;
go

create proc Hospital.spCreateHSBA
(
	@MaBA nvarchar(10) = null,
	@ChuanDoanBenh nvarchar(30) = null,
	@MaBS nvarchar(10) = null,
	@MaPhong nvarchar(10) = null,
	@SoNgayO float = null,
	@Hide bit = 0
)
as
begin
	if exists (select * from Hospital.HoSoBenhAns where MaBA=@MaBA)
		throw 50001, 'Invalid MaBA.', 1;
	if (@ChuanDoanBenh is null)
		throw 50001, 'Invalid ChuaDoanBenh.', 1;
	if not exists (select * from Hospital.BacSis where MaBS=@MaBS)
		throw 50001, 'Invalid MaBS.', 1;
	if not exists (select * from Hospital.Phongs where MaPhong=@MaPhong)
		throw 50001, 'Invalid MaPhong.', 1;
	if (@SoNgayO is null)
		throw 50001, 'Invalid SoNgayO.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
insert into Hospital.HoSoBenhAns
(MaBA,ChuanDoanBenh,MaBS,MaPhong,SoNgayO,Hide)
values
(@MaBA,@ChuanDoanBenh,@MaBS,@MaPhong,@SoNgayO,@Hide);
end
go

--Cập nhật HoSoBenhAns
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spUpdateHSBA') is not null
	drop proc Hospital.spUpdateHSBA;
go

create proc Hospital.spUpdateHSBA
(
	@MaBA nvarchar(10) = null,
	@ChuanDoanBenh nvarchar(30) = null,
	@MaBS nvarchar(10) = null,
	@MaPhong nvarchar(10) = null,
	@SoNgayO float = null,
	@Hide bit = 0
)
as
begin
	if not exists (select * from Hospital.HoSoBenhAns where MaBA=@MaBA)
		throw 50001, 'Invalid MaBA.', 1;
	if (@ChuanDoanBenh is null)
		throw 50001, 'Invalid ChuaDoanBenh.', 1;
	if not exists (select * from Hospital.BacSis where MaBS=@MaBS)
		throw 50001, 'Invalid MaBS.', 1;
	if not exists (select * from Hospital.Phongs where MaPhong=@MaPhong)
		throw 50001, 'Invalid MaPhong.', 1;
	if (@SoNgayO is null)
		throw 50001, 'Invalid SoNgayO.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
update Hospital.HoSoBenhAns
set
	ChuanDoanBenh=@ChuanDoanBenh,
	MaBS=@MaBS,
	MaPhong=@MaPhong,
	SoNgayO=@SoNgayO,
	Hide=@Hide
where MaBA=@MaBA;
end
go

--Xóa HoSoBenhAns
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spDeleteHSBA') is not null
	drop proc Hospital.spDeleteHSBA;
go

create proc Hospital.spDeleteHSBA
(@MaBA nvarchar(10) = null)
as
begin
	if not exists (select * from Hospital.HoSoBenhAns where MaBA=@MaBA)
		throw 50001, 'Invalid MaBA.', 1;
delete from Hospital.HoSoBenhAns
	where MaBA=@MaBA;
end
go


--Lấy dữ liệu của bảng HoaDons
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spGetHD') is not null
	drop proc Hospital.spGetHD;
go

create proc Hospital.spGetHD
as
begin
	select * from Hospital.HoaDons;
end
go

--Thêm HoaDons
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spCreateHD') is not null
	drop proc Hospital.spCreateHD;
go

create proc Hospital.spCreateHD
(
	@MaHD nvarchar(10) = null,
	@TenHD nvarchar(30) = null,
	@GiaHD float = null,
	@Hide bit = 0,
	@MaNV nvarchar(10) = null,
	@MaBA nvarchar(10) = null,
	@NgayLapHD datetime = null,
	@NgayThanhToanHD datetime = null
)
as
begin
	if exists (select * from Hospital.HoaDons where MaHD=@MaHD)
		throw 50001, 'Invalid MaHD.', 1;
	if (@TenHD is null)
		throw 50001, 'Invalid TenHD.', 1;
	if (@GiaHD is null or @GiaHD < 0)
		throw 50001, 'Invalid GiaHD.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
	if not exists (select * from HR.NhanViens where MaNV=@MaNV)
		throw 50001, 'Invalid MaNV.', 1;
	if not exists (select * from Hospital.HoSoBenhAns where MaBA=@MaBA)
		throw 50001, 'Invalid MaBA.', 1;
	if (@NgayLapHD is null or @NgayLapHD >= GETDATE() or DATEDIFF(dd,@NgayLapHD,GETDATE()) > 30)
		throw 50001, 'Invalid NgayLapHD.', 1;
	if (@NgayThanhToanHD is null or @NgayThanhToanHD < @NgayLapHD or @NgayThanhToanHD > GETDATE() or DATEDIFF(dd,@NgayThanhToanHD,GETDATE()) > 30)
		throw 50001, 'Invalid NgayThanhToanHD.', 1;
insert into Hospital.HoaDons
(MaHD,TenHD,GiaHD,Hide,MaNV,MaBA,NgayLapHD,NgayThanhToanHD)
values
(@MaHD,@TenHD,@GiaHD,@Hide,@MaNV,@MaBA,@NgayLapHD,@NgayThanhToanHD);
end
go

--Cập nhật HoaDons
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spUpdateHD') is not null
	drop proc Hospital.spUpdateHD;
go

create proc Hospital.spUpdateHD
(
	@MaHD nvarchar(10) = null,
	@TenHD nvarchar(30) = null,
	@GiaHD float = null,
	@Hide bit = 0,
	@MaNV nvarchar(10) = null,
	@MaBA nvarchar(10) = null,
	@NgayLapHD datetime = null,
	@NgayThanhToanHD datetime = null
)
as
begin
	if not exists (select * from Hospital.HoaDons where MaHD=@MaHD)
		throw 50001, 'Invalid MaHD.', 1;
	if (@TenHD is null)
		throw 50001, 'Invalid TenHD.', 1;
	if (@GiaHD is null or @GiaHD < 0)
		throw 50001, 'Invalid GiaHD.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
	if not exists (select * from HR.NhanViens where MaNV=@MaNV)
		throw 50001, 'Invalid MaNV.', 1;
	if not exists (select * from Hospital.HoSoBenhAns where MaBA=@MaBA)
		throw 50001, 'Invalid MaBA.', 1;
	if (@NgayLapHD is null or @NgayLapHD < 0)
		throw 50001, 'Invalid NgayLapHD.', 1;
	if (@NgayThanhToanHD is null or @NgayThanhToanHD > GETDATE() or DATEDIFF(dd,@NgayThanhToanHD,GETDATE()) > 30)
		throw 50001, 'Invalid NgayThanhToanHD.', 1;
update Hospital.HoaDons
set
	TenHD=@TenHD,
	GiaHD=@GiaHD,
	Hide=@Hide,
	MaNV=@MaNV,
	MaBA=@MaBA,
	NgayLapHD=@NgayLapHD,
	NgayThanhToanHD=@NgayThanhToanHD
where MaHD=@MaHD
end
go

--Xóa HoaDons
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spDeleteHD') is not null
	drop proc Hospital.spDeleteHD;
go

create proc Hospital.spDeleteHD
(@MaHD nvarchar(10) = null)
as
begin
	if not exists (select * from Hospital.HoaDons where MaHD=@MaHD)
		throw 50001, 'Invalid MaHD.', 1;
delete from Hospital.HoaDons
	where MaHD=@MaHD;
end
go


--Lấy dữ liệu của bảng ToaThuocs
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spGetToaThuoc') is not null
	drop proc Hospital.spGetToaThuoc;
go

create proc Hospital.spGetToaThuoc
as
begin
	select * from Hospital.ToaThuocs;
end
go

--Thêm ToaThuocs
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spCreateToaThuoc') is not null
	drop proc Hospital.spCreateToaThuoc;
go

create proc Hospital.spCreateToaThuoc
(
	@MaThuoc nvarchar(10) = null,
	@MaBA nvarchar(10) = null,
	@SoLuong int = null,
	@Hide bit = 0
)
as
begin
	if not exists (select * from Hospital.Thuocs where MaThuoc=@MaThuoc)
		throw 50001, 'Invalid MaThuoc.', 1;
	if not exists (select * from Hospital.HoSoBenhAns where MaBA=@MaBA)
		throw 50001, 'Invalid MaBA.', 1;
	if (@SoLuong is null or @SoLuong < 0)
		throw 50001, 'Invalid SoLuong.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
insert into Hospital.ToaThuocs
(MaThuoc,MaBA,SoLuong,Hide)
values
(@MaThuoc,@MaBA,@SoLuong,@Hide);
end
go

--Cập nhật ToaThuocs
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spUpdateToaThuoc') is not null
	drop proc Hospital.spUpdateToaThuoc;
go

create proc Hospital.spUpdateToaThuoc
(
	@MaThuoc nvarchar(10) = null,
	@MaBA nvarchar(10) = null,
	@SoLuong int = null,
	@Hide bit = 0
)
as
begin
	if not exists (select * from Hospital.Thuocs where MaThuoc=@MaThuoc)
		throw 50001, 'Invalid MaThuoc.', 1;
	if not exists (select * from Hospital.HoSoBenhAns where MaBA=@MaBA)
		throw 50001, 'Invalid MaBA.', 1;
	if (@SoLuong is null or @SoLuong < 0)
		throw 50001, 'Invalid SoLuong.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
update Hospital.ToaThuocs
set
	SoLuong=@SoLuong,
	Hide=@Hide
where MaBA=@MaBA and MaThuoc=@MaThuoc;
end
go

--Xóa ToaThuocs
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spDeleteToaThuoc') is not null
	drop proc Hospital.spDeleteToaThuoc;
go

create proc Hospital.spDeleteToaThuoc
(@MaThuoc nvarchar (10),@MaBA nvarchar(10))
as
begin
	if not exists (select * from Hospital.ToaThuocs where MaThuoc=@MaThuoc)
		throw 50001, 'Invalid MaThuoc.', 1;
	if not exists (select * from Hospital.ToaThuocs where MaBA=@MaBA)
		throw 50001, 'Invalid MaBA.', 1;
delete from Hospital.ToaThuocs
	where MaThuoc=@MaThuoc and MaBA=@MaBA;
end
go


--Lấy dữ liệu của bảng Thuocs
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spGetThuoc') is not null
	drop proc Hospital.spGetThuoc;
go

create proc Hospital.spGetThuoc
as
begin
	select * from Hospital.Thuocs;
end
go

--Thêm Thuocs
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spCreateThuoc') is not null
	drop proc Hospital.spCreateThuoc;
go

create proc Hospital.spCreateThuoc
(
	@MaThuoc nvarchar(10) = null,
	@TenThuoc nvarchar(30) = null,
	@GiaThuoc float = null,
	@Hide bit = 0
)
as
begin
	if exists (select * from Hospital.Thuocs where MaThuoc=@MaThuoc)
		throw 50001, 'Invalid MaThuoc.', 1;
	if (@TenThuoc is null)
		throw 50001, 'Invalid TenThuoc.', 1;
	if (@GiaThuoc is null or @GiaThuoc < 0)
		throw 50001, 'Invalid GiaThuoc.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
insert into Hospital.Thuocs
(MaThuoc,TenThuoc,GiaThuoc,Hide)
values
(@MaThuoc,@TenThuoc,@GiaThuoc,@Hide);
end
go

--Cập nhật Thuocs
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spUpdateThuoc') is not null
	drop proc Hospital.spUpdateThuoc;
go

create proc Hospital.spUpdateThuoc
(
	@MaThuoc nvarchar(10) = null,
	@TenThuoc nvarchar(30) = null,
	@GiaThuoc float = null,
	@Hide bit = 0
)
as
begin
	if not exists (select * from Hospital.Thuocs where MaThuoc=@MaThuoc)
		throw 50001, 'Invalid MaThuoc.', 1;
	if (@TenThuoc is null)
		throw 50001, 'Invalid TenThuoc.', 1;
	if (@GiaThuoc is null or @GiaThuoc < 0)
		throw 50001, 'Invalid GiaThuoc.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
update Hospital.Thuocs
set
	TenThuoc=@TenThuoc,
	GiaThuoc=@GiaThuoc,
	Hide=@Hide
where MaThuoc=@MaThuoc;
end
go

--Xóa Thuocs
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spDeleteThuoc') is not null
	drop proc Hospital.spDeleteThuoc;
go

create proc Hospital.spDeleteThuoc
(@MaThuoc nvarchar(10) = null)
as
begin
	if not exists (select * from Hospital.Thuocs where MaThuoc=@MaThuoc)
		throw 50001, 'Invalid MaThuoc.', 1;
delete from Hospital.Thuocs
	where MaThuoc=@MaThuoc;
end
go


--Lấy dữ liệu của bảng LoaiPhongs
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spGetLoaiPhongs') is not null
	drop proc Hospital.spGetLoaiPhongs;
go

create proc Hospital.spGetLoaiPhongs
as
begin
	select * from Hospital.LoaiPhongs;
end
go

--Thêm LoaiPhongs
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spCreateLoaiPhongs') is not null
	drop proc Hospital.spCreateLoaiPhongs;
go

create proc Hospital.spCreateLoaiPhongs
(
	@MaLoaiPhong nvarchar(10) = null,
	@TenLoaiPhong nvarchar(20) = null,
	@GiaPhong float = null,
	@Hide bit = 0
)
as
begin
	if exists (select * from Hospital.LoaiPhongs where MaLoaiPhong=@MaLoaiPhong)
		throw 50001, 'Invalid MaLoaiPhong.', 1;
	if (@TenLoaiPhong is null)
		throw 50001, 'Invalid TenLoaiPhong.', 1;
	if (@GiaPhong is null or @GiaPhong < 0)
		throw 50001, 'Invalid GiaPhong.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
insert into Hospital.LoaiPhongs
(MaLoaiPhong,TenLoaiPhong,GiaPhong,Hide)
values
(@MaLoaiPhong,@TenLoaiPhong,@GiaPhong,@Hide);
end
go

--Cập nhật LoaiPhongs
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spUpdateLoaiPhongs') is not null
	drop proc Hospital.spUpdateLoaiPhongs;
go

create proc Hospital.spUpdateLoaiPhongs
(
	@MaLoaiPhong nvarchar(10) = null,
	@TenLoaiPhong nvarchar(20) = null,
	@GiaPhong float = null,
	@Hide bit = 0
)
as
begin
	if not exists (select * from Hospital.LoaiPhongs where MaLoaiPhong=@MaLoaiPhong)
		throw 50001, 'Invalid MaLoaiPhong.', 1;
	if (@TenLoaiPhong is null)
		throw 50001, 'Invalid TenLoaiPhong.', 1;
	if (@GiaPhong is null or @GiaPhong < 0)
		throw 50001, 'Invalid GiaPhong.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
update Hospital.LoaiPhongs
set
	TenLoaiPhong=@TenLoaiPhong,
	GiaPhong=@GiaPhong,
	Hide=@Hide
where MaLoaiPhong=@MaLoaiPhong;
end
go

--Xóa LoaiPhongs
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spDeleteLoaiPhongs') is not null
	drop proc Hospital.spDeleteLoaiPhongs;
go

create proc Hospital.spDeleteLoaiPhongs
(@MaLoaiPhong nvarchar(10) = null)
as
begin
	if not exists (select * from Hospital.LoaiPhongs where MaLoaiPhong=@MaLoaiPhong)
		throw 50001, 'Invalid MaLoaiPhong.', 1;
delete from Hospital.LoaiPhongs
	where MaLoaiPhong=@MaLoaiPhong;
end
go

--Lấy dữ liệu của bảng ToaXetNghiems
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spGetToaXNs') is not null
	drop proc Hospital.spGetToaXNs;
go

create proc Hospital.spGetToaXNs
as
begin
	select * from Hospital.ToaXetNghiems;
end
go

--Thêm ToaXNs
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spCreateToaXNs') is not null
	drop proc Hospital.spCreateToaXNs;
go

create proc Hospital.spCreateToaXNs
(
	@MaXN nvarchar(10) = null,
	@MaBA nvarchar(10) = null,
	@NgayXN datetime = null,
	@Hide bit = 0
)
as
begin
	if not exists (select * from Hospital.XetNghiems where MaXN=@MaXN)
		throw 50001, 'Invalid MaXN.', 1;
	if not exists (select * from Hospital.HoSoBenhAns where MaBA=@MaBA)
		throw 50001, 'Invalid MaBA.', 1;
	if (@NgayXN is null or @NgayXN >= GETDATE() or DATEDIFF(dd,@NgayXN,GETDATE()) > 30)
		throw 50001, 'Invalid NgayXN.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
insert into Hospital.ToaXetNghiems
(MaXN,MaBA,NgayXN,Hide)
values
(@MaXN,@MaBA,@NgayXN,@Hide);
end
go

--Cập nhật ToaXNs
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spUpdateToaXNs') is not null
	drop proc Hospital.spUpdateToaXNs;
go

create proc Hospital.spUpdateToaXNs
(
	@MaXN nvarchar(10) = null,
	@MaBA nvarchar(10) = null,
	@NgayXN datetime = null,
	@Hide bit = 0
)
as
begin
	if not exists (select * from Hospital.XetNghiems where MaXN=@MaXN)
		throw 50001, 'Invalid MaXN.', 1;
	if not exists (select * from Hospital.HoSoBenhAns where MaBA=@MaBA)
		throw 50001, 'Invalid MaBA.', 1;
	if (@NgayXN is null or @NgayXN < 0)
		throw 50001, 'Invalid NgayXN.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
update Hospital.ToaXetNghiems
set
	NgayXN=@NgayXN,
	Hide=@Hide
where MaXN=@MaXN and MaBA=@MaBA;
end
go

--Xóa ToaXNs
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spDeleteToaXNs') is not null
	drop proc Hospital.spDeleteToaXNs;
go

create proc Hospital.spDeleteToaXNs
(@MaXN nvarchar(10) = null, @MaBA nvarchar(10) = null)
as
begin
	if not exists (select * from Hospital.XetNghiems where MaXN=@MaXN)
		throw 50001, 'Invalid MaXN.', 1;
	if not exists (select * from Hospital.HoSoBenhAns where MaBA=@MaBA)
		throw 50001, 'Invalid MaBA.', 1;
delete from Hospital.ToaXetNghiems
	where MaXN=@MaXN and MaBA=@MaBA;
end
go


--Lấy dữ liệu của Hospital.Phongs
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spGetPhongs') is not null
	drop proc Hospital.spGetPhongs;
go

create proc Hospital.spGetPhongs
as
begin
	select * from Hospital.Phongs;
end
go


--Lấy dữ liệu của Hospital.LoaiXetNghiems
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spGetLoaiXNs') is not null
	drop proc Hospital.spGetLoaiXNs;
go

create proc Hospital.spGetLoaiXNs
as
begin
	select * from Hospital.LoaiXetNghiems;
end
go

--Thêm LoaiXetNghiems
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spInsertLoaiXNs') is not null
	drop proc Hospital.spInsertLoaiXNs;
go

create proc Hospital.spInsertLoaiXNs
(
	@MaLoaiXN nvarchar(10) = null,
	@TenLoaiXN nvarchar(30) = null,
	@GiaLXN float = null,
	@Hide bit = 0
)
as
begin
	if exists (select * from Hospital.LoaiXetNghiems where MaLoaiXN=@MaLoaiXN)
		throw 50001, 'Invalid MaLoaiXN.', 1;
	if (@TenLoaiXN is null)
		throw 50001, 'Invalid TenLoaiXN.', 1;
	if (@GiaLXN is null or @GiaLXN < 0)
		throw 50001, 'Invalid GiaLXN.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
insert into Hospital.LoaiXetNghiems
(MaLoaiXN,TenLoaiXN,GiaLXN,Hide)
values
(@MaLoaiXN,@TenLoaiXN,@GiaLXN,@Hide);
end
go

--Cập nhật LoaiXetNghiems
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spUpdateLoaiXNs') is not null
	drop proc Hospital.spUpdateLoaiXNs;
go

create proc Hospital.spUpdateLoaiXNs
(
	@MaLoaiXN nvarchar(10) = null,
	@TenLoaiXN nvarchar(30) = null,
	@GiaLXN float = null,
	@Hide bit = 0
)
as
begin
	if not exists (select * from Hospital.LoaiXetNghiems where MaLoaiXN=@MaLoaiXN)
		throw 50001, 'Invalid MaLoaiXN.', 1;
	if (@TenLoaiXN is null)
		throw 50001, 'Invalid TenLoaiXN.', 1;
	if (@GiaLXN is null or @GiaLXN < 0)
		throw 50001, 'Invalid GiaLXN.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
update Hospital.LoaiXetNghiems
set
	TenLoaiXN=@TenLoaiXN,
	GiaLXN=@GiaLXN,
	Hide=@Hide
where MaLoaiXN=@MaLoaiXN;
end
go

--Xóa LoaiXetNghiems
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spDeleteLoaiXNs') is not null
	drop proc Hospital.spDeleteLoaiXNs;
go

create proc Hospital.spDeleteLoaiXNs
(
	@MaLoaiXN nvarchar(10) = null
) 
as
begin
	if not exists (select * from Hospital.LoaiXetNghiems where MaLoaiXN=@MaLoaiXN)
		throw 50001, 'Invalid MaLoaiXN.', 1;
delete from Hospital.LoaiXetNghiems
	where MaLoaiXN=@MaLoaiXN;
end
go


--Lấy dữ liệu của bảng Hospital.XetNghiems
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spGetXNs') is not null
	drop proc Hospital.spGetXNs;
go

create proc Hospital.spGetXNs
as
begin
	select * from Hospital.XetNghiems;
end
go

--Thêm XetNghiems
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spInsertXNs') is not null
	drop proc Hospital.spInsertXNs;
go

create proc Hospital.spInsertXNs
(
	@MaXN nvarchar(10) = null,
	@TenXN nvarchar(100) = null,
	@MaLoaiXN nvarchar(10) = null,
	@Hide bit = 0
)
as
begin
	if exists (select * from Hospital.XetNghiems where MaXN=@MaXN)
		throw 50001, 'Invalid MaXN.', 1;
	if (@TenXN is null)
		throw 50001, 'Invalid TenXN.', 1;
	if not exists (select * from Hospital.LoaiXetNghiems where MaLoaiXN=@MaLoaiXN)
		throw 50001, 'Invalid MaLoaiXN.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
insert into Hospital.XetNghiems
(MaXN,TenXN,MaLoaiXN,Hide)
values
(@MaXN,@TenXN,@MaLoaiXN,@Hide);
end
go

--Cập nhật XetNghiems
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spUpdateXNs') is not null
	drop proc Hospital.spUpdateXNs;
go

create proc Hospital.spUpdateXNs
(
	@MaXN nvarchar(10) = null,
	@TenXN nvarchar(100) = null,
	@MaLoaiXN nvarchar(10) = null,
	@Hide bit = 0
)
as
begin
	if not exists (select * from Hospital.XetNghiems where MaXN=@MaXN)
		throw 50001, 'Invalid MaXN.', 1;
	if (@TenXN is null)
		throw 50001, 'Invalid TenXN.', 1;
	if not exists (select * from Hospital.LoaiXetNghiems where MaLoaiXN=@MaLoaiXN)
		throw 50001, 'Invalid MaLoaiXN.', 1;
	if (@Hide is null)
		throw 50001, 'Invalid Hide.', 1;
update Hospital.XetNghiems
set
	TenXN=@TenXN,
	MaLoaiXN=@MaLoaiXN,
	Hide=@Hide
where MaXN=@MaXN;
end
go

--Xóa XetNghiems
use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spDeleteXNs') is not null
	drop proc Hospital.spDeleteXNs;
go

create proc Hospital.spDeleteXNs
(@MaXN nvarchar(10) = null)
as
begin
	if not exists (select * from Hospital.XetNghiems where MaXN=@MaXN)
		throw 50001, 'Invalid MaXN.', 1;
delete from Hospital.XetNghiems
	where MaXN=@MaXN;
end
go

use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.fnTinhTongHoaDonAll') is not null
	drop function Hospital.fnTinhTongHoaDonAll;
go

create function Hospital.fnTinhTongHoaDonAll
(
	@MaHD nvarchar(10) = null
)
returns float
as
begin
	declare @TongTienHD float = null

	--Phòng
	declare @tonghdphong float = null
	declare @giaphong float = null
	declare @songayophong float = null
	declare @giahdphong float = null

	--Phòng + Thuốc
	declare @tonghdphongthuoc float = null
	declare @SoLuongThuocPhong float = null
	declare @GiaThuocPhong float = null
	declare @SoNgayOThuocPhong float = null
	declare @GiaPhongCuaThuoc float = null
	declare @GiaHDThuocPhong float = null


	--Phòng + XN
	declare @tongpxn float = null
	declare @songaypxn float = null
	declare @giapxn float = null
	declare @giaxn float = null
	declare @GiaHDXN float = null

	--Phòng + Thuốc + XN
	declare @songayoall float = null
	declare @giaphongall float = null
	declare @soluongthuocall float = null
	declare @giathuocall float = null
	declare @giahdtongall float = null
	declare @giaxntongall float = null
	declare @tonghdall float = null
	declare @GiaHDall float = null


	--Phòng
	if not exists (select * from Hospital.HoaDons where MaHD=@MaHD)
		return 0;
	else
	begin
		if  exists (select * from
									(
										select
											MaHD,
											GiaPhong,
											SoNgayO,
											GiaThuoc,
											SoLuong,
											GiaHD,
											GiaLXN
										from 
											Hospital.HoSoBenhAns HS
										inner join 
											Hospital.Phongs P
												on HS.MaPhong=P.MaPhong
										inner join
											Hospital.LoaiPhongs LP
												on P.MaLoaiPhong=LP.MaLoaiPhong
										inner join
											Hospital.ToaThuocs TT
												on HS.MaBA=TT.MaBA
										inner join
											Hospital.Thuocs T
												on TT.MaThuoc=T.MaThuoc
										inner join
											Hospital.ToaXetNghiems TXN
												on HS.MaBA=TXN.MaBA
										inner join
											Hospital.XetNghiems XN
												on TXN.MaXN=XN.MaXN
										inner join
											Hospital.LoaiXetNghiems LXN
												on XN.MaLoaiXN=LXN.MaLoaiXN
										inner join
											Hospital.HoaDons HD
												on HS.MaBA=HD.MaBA
									) as D  
						where @MaHD=D.MaHD)
		
		
			begin
			select 
				@MaHD=MaHD,
				@tonghdall = (GiaPhong * SoNgayO + GiaLXN + GiaHD + SoLuong * GiaThuoc),
				@giaphongall=GiaPhong,
				@songayoall=SoNgayO,
				@giaxntongall=GiaLXN,
				@soluongthuocall=SoLuong,
				@giathuocall=GiaThuoc,
				@GiaHDall=GiaHD
			from 
				Hospital.HoSoBenhAns HS
			inner join Hospital.Phongs P
					on HS.MaPhong=P.MaPhong
			inner join Hospital.LoaiPhongs LP
					on p.MaLoaiPhong=LP.MaLoaiPhong
			inner join Hospital.ToaXetNghiems TXN
					on HS.MaBA=TXN.MaBA
			inner join Hospital.XetNghiems XN
					on TXN.MaXN=XN.MaXN
			inner join Hospital.LoaiXetNghiems LXN
					on XN.MaLoaiXN=LXN.MaLoaiXN
			inner join Hospital.ToaThuocs TT
					on HS.MaBA=TT.MaBA
			inner join Hospital.Thuocs T
					on TT.MaThuoc=T.MaThuoc
			inner join Hospital.HoaDons HD
					on HS.MaBA=HD.MaBA
			where @MaHD=MaHD
			set @TongTienHD = @tonghdall;
			end

		else if  exists (select * from
									(
										select
											MaHD,
											GiaPhong,
											SoNgayO,											
											GiaHD,
											GiaLXN
										from 
											Hospital.HoSoBenhAns HS
										inner join 
											Hospital.Phongs P
												on HS.MaPhong=P.MaPhong
										inner join
											Hospital.LoaiPhongs LP
												on P.MaLoaiPhong=LP.MaLoaiPhong										
										inner join
											Hospital.ToaXetNghiems TXN
												on HS.MaBA=TXN.MaBA
										inner join
											Hospital.XetNghiems XN
												on TXN.MaXN=XN.MaXN
										inner join
											Hospital.LoaiXetNghiems LXN
												on XN.MaLoaiXN=LXN.MaLoaiXN
										inner join
											Hospital.HoaDons HD
												on HS.MaBA=HD.MaBA
									) as DA 
						where @MaHD=DA.MaHD)
		begin
			select 
				@MaHD=MaHD,
				@tongpxn = (GiaPhong * SoNgayO + GiaLXN + GiaHD),
				@giapxn=GiaPhong,
				@songaypxn=SoNgayO,
				@giaxn=GiaLXN,
				@GiaHDXN=GiaHD
			from 
				Hospital.HoSoBenhAns HS
			inner join Hospital.Phongs P
					on HS.MaPhong=P.MaPhong
			inner join Hospital.LoaiPhongs LP
					on p.MaLoaiPhong=LP.MaLoaiPhong
			inner join Hospital.ToaXetNghiems TXN
					on HS.MaBA=TXN.MaBA
			inner join Hospital.XetNghiems XN
					on TXN.MaXN=XN.MaXN
			inner join Hospital.LoaiXetNghiems LXN
					on XN.MaLoaiXN=LXN.MaLoaiXN
			inner join Hospital.HoaDons HD
					on HS.MaBA=HD.MaBA
			where @MaHD=MaHD
			set @TongTienHD = @tongpxn;
		end
			else if exists (select * from (
										select
											MaHD,GiaHD,GiaThuoc,SoLuong,SoNgayO,GiaPhong
										from Hospital.HoSoBenhAns HS inner join Hospital.ToaThuocs TT on HS.MaBA=TT.MaBA inner join Hospital.Thuocs T on TT.MaThuoc=T.MaThuoc inner join Hospital.Phongs P
												on HS.MaPhong=P.MaPhong inner join Hospital.LoaiPhongs LP on P.MaLoaiPhong=Lp.MaLoaiPhong
												inner join Hospital.HoaDons HD on HS.MaBA=HD.MaBA
										) B
										where @MaHD=B.MaHD)
		begin
		select @MaHD=MaHD,
		@tonghdphongthuoc=(GiaThuoc * SoLuong + GiaHD + SoNgayO * GiaPhong),							
			@GiaThuocPhong=GiaThuoc,
				@GiaHDThuocPhong=GiaHD,
				@SoLuongThuocPhong=SoLuong,
				@SoNgayOThuocPhong=SoNgayO,
				@GiaPhongCuaThuoc=GiaPhong
				from Hospital.HoSoBenhAns HS
				inner join
					Hospital.ToaThuocs TT
						on HS.MaBA=TT.MaBA
				inner join
					Hospital.Thuocs T
						on TT.MaThuoc=T.MaThuoc
						inner join Hospital.Phongs P
												on HS.MaPhong=P.MaPhong inner join Hospital.LoaiPhongs LP on P.MaLoaiPhong=Lp.MaLoaiPhong
				inner join 
					Hospital.HoaDons HD
						on TT.MaBA=HD.MaBA
		where MaHD=@MaHD
		set @TongTienHD = @tonghdphongthuoc;
		end
		else							--else if exists (select * from (
								--								select MaHD , GiaHD, GiaPhong, SoNgayO
								--								from Hospital.HoSoBenhAns HS inner join Hospital.Phongs P on HS.MaPhong=P.MaPhong inner join Hospital.LoaiPhongs LP on P.MaLoaiPhong=LP.MaLoaiPhong	
								--										inner join Hospital.HoaDons HD on HS.MaBA=HD.MaBA		
								--								) C where @MaHD=C.MaHD)

		begin
		select @MaHD=MaHD,@tonghdphong=GiaHD+SoNgayO*GiaPhong , @giahdphong=GiaHD, @giaphong=GiaPhong, @songayophong=SoNgayO
										from Hospital.HoSoBenhAns HS inner join Hospital.Phongs P on HS.MaPhong=P.MaPhong inner join Hospital.LoaiPhongs LP on P.MaLoaiPhong=LP.MaLoaiPhong	
												inner join Hospital.HoaDons HD on HS.MaBA=HD.MaBA	
												where @MaHD=MaHD
		set @TongTienHD = @tonghdphong;
		end
	end

	return @TongTienHD
end
go	

use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spTinhTongHoaDonTheoMaHD') is not null
	drop proc Hospital.spTinhTongHoaDonTheoMaHD;
go

create proc Hospital.spTinhTongHoaDonTheoMaHD
(
	@MaHD nvarchar(10) = null
)
as
begin
	select Hospital.fnTinhTongHoaDonAll(@MaHD);
end
go

use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('fnHDPhong') is not null
	drop function Hospital.fnHDPhong;
go

create function Hospital.fnHDPhong()
returns table
as
return
	select
	HS.MaBA,
	HS.ChuanDoanBenh,
	HS.MaBS,
	HS.MaPhong,
	HS.SoNgayO,
	HS.Hide as TinhTrang,
	P.TenPhong,
	P.MaLoaiPhong,
	LP.TenLoaiPhong,
	LP.GiaPhong,
	HD.MaHD,
	HD.TenHD,
	HD.GiaHD,
	HD.Hide as ThanhToan,
	HD.MaNV
from Hospital.HoSoBenhAns HS
inner join
	Hospital.Phongs P
		on HS.MaPhong=P.MaPhong
inner join
	Hospital.LoaiPhongs LP
		on P.MaLoaiPhong=LP.MaLoaiPhong
inner join 
	Hospital.HoaDons HD
		on HS.MaBA=HD.MaBA
go
	
if OBJECT_ID ('fnHDThuoc') is not null
	drop function Hospital.fnHDThuoc;
go

create or alter function Hospital.fnHDThuoc()
returns table
as
return
	select
	HS.MaBA,
	HS.ChuanDoanBenh,
	HS.MaBS,
	HS.MaPhong,
	HS.SoNgayO,
	HS.Hide as TinhTrang,
	T.MaThuoc,
	T.SoLuong,
	TH.TenThuoc,
	TH.GiaThuoc,
	HD.MaHD,
	HD.TenHD,
	HD.GiaHD,
	HD.Hide as ThanhToan,
	HD.MaNV,
	P.TenPhong,
	LP.MaLoaiPhong,
	LP.TenLoaiPhong,
	LP.GiaPhong
from Hospital.HoSoBenhAns HS
inner join
	Hospital.ToaThuocs T
		on HS.MaBA=T.MaBA
inner join
	Hospital.Thuocs TH
		on T.MaThuoc=TH.MaThuoc
inner join
	Hospital.HoaDons HD
		on HS.MaBA=HD.MaBA
inner join
	Hospital.Phongs P
		on HS.MaPhong=P.MaPhong
inner join
	Hospital.LoaiPhongs LP
		on P.MaLoaiPhong=LP.MaLoaiPhong
go


if OBJECT_ID ('fnHDXetNghiem') is not null
	drop function Hospital.fnHDXetNghiem;
go

create or alter function Hospital.fnHDXetNghiem ()
returns table
as
return
	select
	HS.MaBA,
	HS.ChuanDoanBenh,
	HS.MaBS,
	HS.MaPhong,
	HS.SoNgayO,
	HS.Hide as TinhTrang,
	TXN.MaXN,
	TXN.NgayXN,
	XN.TenXN,
	XN.MaLoaiXN,
	LXN.TenLoaiXN,
	LXN.GiaLXN,
	HD.MaHD,
	HD.TenHD,
	HD.GiaHD,
	HD.Hide as ThanhToan,
	HD.MaNV,
	P.TenPhong,
	LP.MaLoaiPhong,
	LP.TenLoaiPhong,
	LP.GiaPhong
	
from Hospital.HoSoBenhAns HS
inner join
	Hospital.HoaDons HD
	on HD.MaBA=HS.MaBA
inner join
	Hospital.ToaXetNghiems TXN
	on HS.MaBA=TXN.MaBA
inner join Hospital.XetNghiems XN
	on TXN.MaXN=XN.MaXN
inner join Hospital.LoaiXetNghiems LXN
	on XN.MaLoaiXN=LXN.MaLoaiXN
inner join Hospital.BacSis BS
	on HS.MaBS=BS.MaBS
inner join
	Hospital.Phongs P
		on HS.MaPhong= P.MaPhong
inner join
	Hospital.LoaiPhongs LP
		on P.MaLoaiPhong=LP.MaLoaiPhong
go


	
if OBJECT_ID ('fnTinhTongHD') is not null
	drop function Hospital.fnTinhTongHD;
go

use QuanLyBenhVienDoAnCuoiKi;
go

create or alter function Hospital.fnTinhTongHDPhong (@MaHD nvarchar(10))
returns float
as
begin
	declare @TongTienPhong float
	--declare @MaHD nvarchar(10)
	declare @MaBA nvarchar(10)
	declare @MaThuoc nvarchar(10)
	declare @SoNgayO float
	declare @GiaHD float
	declare @GiaPhong float
	declare @GiaThuoc float
	declare @SoLuongThuoc int
	declare @GiaXN float
	
	--set @TongTien = @GiaHD + @GiaPhong * @SoNgayO + @GiaXN + @GiaThuoc * @SoLuongThuoc;

	
	select @MaHD=MaHD, @GiaHD=GiaHD, @GiaPhong=GiaPhong, @SoNgayO=SoNgayO
	from Hospital.fnHDPhong()
	where @MaHD=MaHD
	

	set @TongTienPhong = @GiaPhong * @SoNgayO + @GiaHD


	--if @MaBA is not null
	--	select @MaThuoc = MaThuoc, @MaHD=MaHD
	--	from Hospital.fnHDThuoc()
	--	--where @MaHD=MaHD

	--	if @MaThuoc is null
	--	select @SoNgayO = SoNgayO, @GiaPhong=GiaPhong, @GiaHD=GiaHD, @MaHD=MaHD
	--	from Hospital.fnHDPhong()
	--	--where MaHD=@MaHD
	--	set @TongTien = @GiaHD + @GiaPhong * @SoNgayO
		

	return @TongTienPhong
end
go



use QuanLyBenhVienDoAnCuoiKi
if OBJECT_ID ('Hospital.fnTinhTongHDThuoc') is not null
	drop function Hospital.fnTinhTongHDThuoc;
go

create or alter function Hospital.fnTinhTongHDThuoc (@MaHD nvarchar(10))
returns float
as
begin
	declare @TongTienThuoc float
	--declare @MaHD nvarchar(10)
	declare @MaBA nvarchar(10)
	declare @MaThuoc nvarchar(10)
	declare @SoNgayO float
	declare @GiaHD float
	declare @GiaPhong float
	declare @GiaThuoc float
	declare @SoLuongThuoc int
	declare @GiaXN float
	
	--set @TongTien = @GiaHD + @GiaPhong * @SoNgayO + @GiaXN + @GiaThuoc * @SoLuongThuoc;

	
	select @MaHD=MaHD, @GiaThuoc=GiaThuoc, @SoLuongThuoc=SoLuong,@GiaPhong=GiaPhong,@SoNgayO=SoNgayO,@GiaHD=GiaHD
	from Hospital.fnHDThuoc()
	where @MaHD=MaHD
	

	set @TongTienThuoc = @GiaThuoc * @SoLuongThuoc



	


	--if @MaBA is not null
	--	select @MaThuoc = MaThuoc, @MaHD=MaHD
	--	from Hospital.fnHDThuoc()
	--	--where @MaHD=MaHD

	--	if @MaThuoc is null
	--	select @SoNgayO = SoNgayO, @GiaPhong=GiaPhong, @GiaHD=GiaHD, @MaHD=MaHD
	--	from Hospital.fnHDPhong()
	--	--where MaHD=@MaHD
	--	set @TongTien = @GiaHD + @GiaPhong * @SoNgayO
		

	return @TongTienThuoc
end
go



use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.fnTinhTongHDXN') is not null
	drop function Hospital.fnTinhTongHDXN;
go

create or alter function Hospital.fnTinhTongHDXN (@MaHD nvarchar(10))
returns float
as
begin
	declare @TongTienXN float
	--declare @MaHD nvarchar(10)
	declare @MaBA nvarchar(10)
	declare @MaThuoc nvarchar(10)
	declare @SoNgayO float
	declare @GiaHD float
	declare @GiaPhong float
	declare @GiaThuoc float
	declare @SoLuongThuoc int
	declare @GiaXN float
	
	--set @TongTien = @GiaHD + @GiaPhong * @SoNgayO + @GiaXN + @GiaThuoc * @SoLuongThuoc;

	
	select @MaHD=MaHD, @GiaXN=GiaLXN, @GiaHD=GiaHD, @GiaPhong=GiaPhong, @SoNgayO=SoNgayO
	from Hospital.fnHDXetNghiem()
	where @MaHD=MaHD
	

	set @TongTienXN = @GiaXN


	--if @MaBA is not null
	--	select @MaThuoc = MaThuoc, @MaHD=MaHD
	--	from Hospital.fnHDThuoc()
	--	--where @MaHD=MaHD

	--	if @MaThuoc is null
	--	select @SoNgayO = SoNgayO, @GiaPhong=GiaPhong, @GiaHD=GiaHD, @MaHD=MaHD
	--	from Hospital.fnHDPhong()
	--	--where MaHD=@MaHD
	--	set @TongTien = @GiaHD + @GiaPhong * @SoNgayO
		

	return @TongTienXN
end
go



use QuanLyBenhVienDoAnCuoiKi;
go

if OBJECT_ID ('Hospital.spTinhTongHDThuoc') is not null
	drop proc Hospital.spTinhTongHDThuoc;
go


CREATE or alter PROCEDURE Hospital.spTinhTongHDThuoc 
(
    @MaHD nvarchar(10),
    @TongTienHDThuoc float OUTPUT,
	@TongTienHDXN float output,
	@TongTienPhong float output
) 
AS
BEGIN
 
	
	select Hospital.fnTinhTongHDXN(@MaHD)
	select Hospital.fnTinhTongHDPhong(@MaHD)
	select Hospital.fnTinhTongHDThuoc(@MaHD)
	

	
 
    SELECT @TongTienHDThuoc = Hospital.fnTinhTongHDThuoc(@MaHD);
	 SELECT @TongTienHDXN = Hospital.fnTinhTongHDXN(@MaHD);
	  SELECT @TongTienPhong = Hospital.fnTinhTongHDPhong(@MaHD);
END;



if OBJECT_ID ('Hospital.fnTongHDJoin') is not null
	drop function Hospital.fnTongHDJoin;
go

create or alter function Hospital.fnTongHDJoin ()
returns table
as

return
select
HS.MaBA,
	HS.ChuanDoanBenh,
	HS.MaBS,
	HS.MaPhong,
	HS.SoNgayO,
	HS.Hide as TinhTrang,
	BS.HoBS,
	BS.TenBS,
	TXN.MaXN,
	TXN.NgayXN,
	XN.TenXN,
	XN.MaLoaiXN,
	LXN.TenLoaiXN,
	LXN.GiaLXN,
	HD.MaHD,
	HD.TenHD,
	HD.GiaHD,
	HD.Hide as ThanhToan,
	HD.MaNV,
	TT.MaThuoc,
	TT.SoLuong,
	TH.TenThuoc,
	TH.GiaThuoc,
	P.MaLoaiPhong,
	P.TenPhong,
	LP.TenLoaiPhong,
	LP.GiaPhong
	
from Hospital.HoSoBenhAns HS
inner join
	Hospital.HoaDons HD
		on HD.MaBA=HS.MaBA
inner join
	Hospital.ToaXetNghiems TXN
		on HS.MaBA=TXN.MaBA
inner join 
	Hospital.XetNghiems XN
		on TXN.MaXN=XN.MaXN
inner join 
	Hospital.LoaiXetNghiems LXN
		on XN.MaLoaiXN=LXN.MaLoaiXN
inner join 
	Hospital.BacSis BS
		on HS.MaBS=BS.MaBS
inner join
	Hospital.ToaThuocs TT
		on HS.MaBA=TT.MaBA
inner join
	Hospital.Thuocs TH
		on TT.MaThuoc=TH.MaThuoc
inner join
	Hospital.Phongs P
		on HS.MaPhong=P.MaPhong
inner join
	Hospital.LoaiPhongs LP
		on P.MaLoaiPhong=LP.MaLoaiPhong

go

---------------UNDO - REDO-----------------
--Create spCreatePhongs
use QuanLyBenhVienDoAnCuoiKi;
if object_id('Hospital.spCreatePhongs') is not null
	drop proc Hospital.spCreatePhongs;
go
create proc Hospital.spCreatePhongs
	(@MaPhong nVARCHAR(10) = null,
	@MaLoaiPhong nvarchar(10)= null,	
	@TenPhong nvarchar(30)= null,
	@Hide BIT = 0)
as

if exists (select * from Hospital.Phongs where MaPhong = @MaPhong)
	throw 50001, 'Invalid MaPhong.', 1;
if not exists (select * from Hospital.LoaiPhongs where MaLoaiPhong = @MaLoaiPhong)
	throw 50001, 'Invalid MaLoaiPhong.', 1;
if(@TenPhong is null)
	throw 50001, 'Invalid TenPhong.', 1;
if(@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
insert into Hospital.Phongs(MaPhong,MaLoaiPhong,TenPhong,Hide)
values (@MaPhong,@MaLoaiPhong,@TenPhong,@Hide)
delete Hospital.RedoTable


--Update Room
use QuanLyBenhVienDoAnCuoiKi;
if object_id('Hospital.spUpdatePhongs') is not null
	drop proc Hospital.spUpdatePhongs;
go
create proc Hospital.spUpdatePhongs
	(@MaPhong nVARCHAR(10) = null,
	@MaLoaiPhong nvarchar(10)= null,	
	@TenPhong nvarchar(30)= null,
	@Hide BIT = 0)
as
if not exists (select * from Hospital.Phongs where MaPhong = @MaPhong)
	throw 50001, 'Invalid MaPhong.', 1;
if not exists (select * from Hospital.LoaiPhongs where MaLoaiPhong = @MaLoaiPhong)
	throw 50001, 'Invalid MaLoaiPhong.', 1;
if(@TenPhong is null)
	throw 50001, 'Invalid TenPhong.', 1;
if(@Hide is null)
	throw 50001, 'Invalid Hide.', 1;
update Hospital.Phongs
set 
	MaLoaiPhong = @MaLoaiPhong, 
	TenPhong = @TenPhong, 
	Hide = @Hide
	where MaPhong = @MaPhong


--Delete Room
use QuanLyBenhVienDoAnCuoiKi;
if object_id('Hospital.spDeletePhongs') is not null
	drop proc Hospital.spDeletePhongs;
go
create proc Hospital.spDeletePhongs
	(@MaPhong nVARCHAR(10) =null)
as
if not exists (select * from Hospital.Phongs where MaPhong = @MaPhong)
	throw 50001, 'Invalid MaPhong.', 1;
delete Hospital.Phongs
	where MaPhong = @MaPhong
delete Hospital.RedoTable
go





drop trigger if exists Hospital.trg_Undo_Phongs_Insert

drop trigger if exists Hospital.trg_Undo_Phongs_Delete

drop trigger if exists Hospital.trg_Undo_Phongs_Update
go

create trigger Hospital.trg_Undo_Phongs_Insert on Hospital.Phongs
after insert
as
declare
	@MaPhong nvarchar(10),
	@MaLoaiPhong nvarchar(10),
	@TenPhong nvarchar(30),
	@Hide BIT;
select @MaPhong = MaPhong, @MaLoaiPhong = MaLoaiPhong, @TenPhong = TenPhong, @Hide = Hide
from inserted
insert UndoTable
values (@MaPhong, @MaLoaiPhong, @TenPhong, @Hide,'inserted');
go

create trigger Hospital.trg_Undo_Phongs_Update on Hospital.Phongs
instead of update
as
declare
	@MaPhong nvarchar(10),
	@MaLoaiPhong nvarchar(10),
	@TenPhong nvarchar(30),
	@Hide BIT;
select @MaPhong = MaPhong, @MaLoaiPhong = MaLoaiPhong, @TenPhong = TenPhong, @Hide = Hide
from inserted
insert UndoTable
select MaPhong, MaLoaiPhong, TenPhong, Hide, 'updated' from Hospital.Phongs where MaPhong = @MaPhong
update Hospital.Phongs set MaLoaiPhong = @MaLoaiPhong, TenPhong = @TenPhong, Hide = @Hide where MaPhong = @MaPhong
go

create trigger Hospital.trg_Undo_Phongs_Delete on Hospital.Phongs
after delete
as
declare
	@MaPhong nvarchar(10),
	@MaLoaiPhong nvarchar(10),
	@TenPhong nvarchar(30),
	@Hide BIT;
select @MaPhong = MaPhong, @MaLoaiPhong = MaLoaiPhong, @TenPhong = TenPhong, @Hide = Hide
from deleted
insert UndoTable
values (@MaPhong, @MaLoaiPhong, @TenPhong, @Hide,'deleted');
go



drop proc if exists Hospital.spUndoPhongs
go

create proc Hospital.spUndoPhongs
as
exec ('DISABLE TRIGGER Hospital.trg_Undo_Phongs_Insert ON Hospital.Phongs')
exec ('DISABLE TRIGGER Hospital.trg_Undo_Phongs_Delete ON Hospital.Phongs')
declare
	@MaPhong nvarchar(10),
	@MaLoaiPhong nvarchar(10),
	@TenPhong nvarchar(30),
	@Hide BIT,
	@iStatus varchar (10);
select top 1 @MaPhong = MaPhong, @MaLoaiPhong = MaLoaiPhong, @TenPhong = TenPhong, @Hide = Hide, @iStatus = iStatus from Hospital.UndoTable order by iID desc
if((select top 1 iStatus from Hospital.UndoTable order by iID desc) = 'inserted')
begin
	delete Hospital.Phongs
	where MaPhong = @MaPhong;
	insert Hospital.RedoTable
	values (@MaPhong, @MaLoaiPhong, @TenPhong, @Hide, @iStatus);
	with t as (select top 1 * from Hospital.UndoTable order by iID desc )
	delete from t;

end

else if((select top 1 iStatus from Hospital.UndoTable order by iID desc) = 'deleted')
begin
	insert Hospital.Phongs
	values (@MaPhong, @MaLoaiPhong, @TenPhong, @Hide)
	insert Hospital.RedoTable
	values (@MaPhong, @MaLoaiPhong, @TenPhong, @Hide, @iStatus);
	with t as (select top 1 * from Hospital.UndoTable order by iID desc )
	delete from t;

end

else if((select top 1 iStatus from Hospital.UndoTable order by iID desc) = 'updated')
begin
	insert Hospital.RedoTable
	select MaPhong, MaLoaiPhong, TenPhong, Hide, 'updated' from Hospital.Phongs where MaPhong = @MaPhong;
	delete Hospital.Phongs
	where MaPhong = @MaPhong;
	insert Hospital.Phongs
	values(@MaPhong, @MaLoaiPhong, @TenPhong, @Hide);

	with t as (select top 1 * from Hospital.UndoTable order by iID desc )
	delete from t;
end
exec ('ENABLE TRIGGER Hospital.trg_Undo_Phongs_Insert ON Hospital.Phongs')
exec ('ENABLE TRIGGER Hospital.trg_Undo_Phongs_Delete ON Hospital.Phongs')
go



create proc Hospital.spRedoPhongs
as
exec ('DISABLE TRIGGER Hospital.trg_Undo_Phongs_Insert ON Hospital.Phongs')
exec ('DISABLE TRIGGER Hospital.trg_Undo_Phongs_Delete ON Hospital.Phongs')
declare
	@MaPhong nvarchar(10),
	@MaLoaiPhong nvarchar(10),
	@TenPhong nvarchar(30),
	@Hide BIT,
	@iStatus varchar (10);
select top 1 @MaPhong = MaPhong, @MaLoaiPhong = MaLoaiPhong, @TenPhong = TenPhong, @Hide = Hide, @iStatus = iStatus from Hospital.RedoTable order by iID desc
if((select top 1 iStatus from Hospital.RedoTable order by iID desc) = 'inserted')
begin
	insert Hospital.Phongs
	values (@MaPhong, @MaLoaiPhong, @TenPhong, @Hide);
	insert Hospital.UndoTable
	values (@MaPhong, @MaLoaiPhong, @TenPhong, @Hide, @iStatus);
	with t as (select top 1 * from Hospital.RedoTable order by iID desc )
	delete from t;
end
else if((select top 1 iStatus from Hospital.RedoTable order by iID desc) = 'deleted')
begin
	delete Hospital.Phongs
	where MaPhong = @MaPhong
	insert Hospital.UndoTable
	values (@MaPhong, @MaLoaiPhong, @TenPhong, @Hide, @iStatus);
	with t as (select top 1 * from Hospital.RedoTable order by iID desc )
	delete from t;
end
else if((select top 1 iStatus from Hospital.RedoTable order by iID desc) = 'updated')
begin
	insert Hospital.UndoTable
	select MaPhong, MaLoaiPhong, TenPhong, Hide, 'updated' from Hospital.Phongs where MaPhong = @MaPhong;
	delete Hospital.Phongs
	where MaPhong = @MaPhong
	insert Hospital.Phongs
	values (@MaPhong, @MaLoaiPhong, @TenPhong, @Hide);
	
	with t as (select top 1 * from Hospital.RedoTable order by iID desc )
	delete from t;
end
exec ('ENABLE TRIGGER Hospital.trg_Undo_Phongs_Insert ON Hospital.Phongs')
exec ('ENABLE TRIGGER Hospital.trg_Undo_Phongs_Delete ON Hospital.Phongs')
go



	
go
-- Tổng tiền doanh thu
CREATE FUNCTION TongTienDoanhThu
(
	@NgayStart datetime = null,
	@NgayEnd datetime = null
) 
RETURNS float
 AS 
BEGIN 
	 DECLARE @money float = null
	 SELECT @money = SUM(GiaHD)
	 FROM Hospital.HoaDons 
	 WHERE (DATEDIFF(DD,NgayLapHD,NgayThanhToanHD)   )            between @NgayStart and @NgayEnd
	 IF (@money = null) 
	   SET @money = 0; 
	 RETURN @money; 
END
go

--Tìm kiếm nhân viên theo MaNV
Go
create procedure HR.spTimKiemNVTheoMaNV
(
	@MaNV nvarchar (10)
)
as
Begin
	select * from HR.NhanViens where MaNV like  '%'+@MaNV+'%'
End 
Go	
--  Tìm kiếm nhân viên theo Ten nhân viên 
Go
create procedure HR.spTimKiemNVTheoTenNV
(
	@TenNV			nvarchar(100)
)
as
Begin
	select * from HR.NhanViens where TenNV like  N'%'+@TenNV+'%'
End 
Go

use QuanLyBenhVienDoAnCuoiKi;
if OBJECT_ID ('Hospital.spTimKiemBN') is not null
	drop proc Hospital.spTimKiemBN;
go

CREATE or alter PROCEDURE Hospital.spTimKiemBN  
(
	 @MaBN			NVARCHAR(50) = NULL,	
	 @HoBN					NVARCHAR(100) = NULL,	
	 @TenBN        NVARCHAR(100) = NULL,	
	 @NgaySinh				datetime= NULL
	 --@GioiTinh		nvarchar(100) = null,
	 --@Hide bit = 0	
)
AS          
BEGIN      
	SET NOCOUNT ON;  
	DECLARE @SQL							NVARCHAR(MAX)
	DECLARE @ParameterDef					NVARCHAR(500)
    SET @ParameterDef =      '@MaBN			NVARCHAR(50),
							@HoBN					NVARCHAR(100),
							@TenBN			NVARCHAR(100),
							@NgaySinh					datetime'
    SET @SQL = 'SELECT MaBN
						,HoBN
						,TenBN
						,NgaySinh						
					FROM Hospital.BenhNhans WHERE -1=-1 ' 
IF @MaBN IS NOT NULL AND @MaBN <> 0 
SET @SQL = @SQL+ ' AND MaBN = @MaBN' + CAST(@MaBN as int)
IF @HoBN IS NOT NULL AND @HoBN <> ''
SET @SQL = @SQL+ ' AND HoBN like ''%'' + @HoBN + ''%'''
IF @TenBN IS NOT NULL AND @TenBN <>''
SET @SQL = @SQL+ ' AND TenBN like ''%'' + @TenBN + ''%''' 
IF @NgaySinh IS NOT NULL AND @NgaySinh <>''
SET @SQL = @SQL+  ' AND NgaySinh like ''%'' + @NgaySinh + ''%'''
   EXEC sp_Executesql     @SQL,  @ParameterDef, @MaBN=@MaBN,@HoBN=@HoBN,@TenBN=@TenBN,@NgaySinh=@NgaySinh              
END
GO




Go
create procedure Hospital.spGetMaKhoaBS
as
begin
	select MaKhoa from Hospital.Khoas
end
go

Go
Create or alter function Hospital.fnMaBacSiTuDongTang()
returns nvarchar(10)
As
Begin
	Declare @MaBS		nvarchar(10)
	Declare @MaxMaBS	nvarchar(10)
	Declare @Max float
	Select @MaxMaBS = MAX(MaBS) from Hospital.BacSis	
	if exists (select MaBS from Hospital.BacSis)
			set @Max = CONVERT(float, SUBSTRING(@MaxMaBS,4,2)) + 1
	else
			set @Max=1	
	if (@Max < 10)
			set @MaBS='BS' + '0' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
			set @MaBS='BS' + '' + Convert(varchar(2),@Max)
	else
			set @MaBS ='BS' +  Convert(varchar(3),@Max)
	Return @MaBS
End
Go

go
create or alter function Hospital.fnMaKhoaTuDongTang()
returns nvarchar(10)
as
begin
	declare @MaKhoa nvarchar(10)
	declare @MaxMaKhoa nvarchar(10)
	declare @Max float
	select @MaxMaKhoa = MAX(MaKhoa) from Hospital.Khoas
	if exists (select MaKhoa from Hospital.Khoas)
		set @Max = CONVERT(float, substring(@MaxMaKhoa,2,8)) + 1
	else
		set @Max=1
	if (@Max < 10)
		set @MaKhoa='K' + '0' + CONVERT(varchar(1),@Max)
	else
	if (@Max < 100)
			set @MaKhoa='K' + '' + Convert(varchar(2),@Max)
	else
			set @MaKhoa ='K' +  Convert(varchar(3),@Max)
	Return @MaKhoa	
end
go


Go
Create or alter function Hospital.fnMaPhieuDKTuDongTang()
returns nvarchar(10)
As
Begin
	Declare @MaPhieuDK		nvarchar(10)
	Declare @MaxMaPhieuDK	nvarchar(10)
	Declare @Max float
	Select @MaxMaPhieuDK = MAX(MaPhieuDK) from Hospital.PhieuDangKys	
	if exists (select MaBS from Hospital.BacSis)
			set @Max = CONVERT(float, SUBSTRING(@MaxMaPhieuDK,5,2)) + 1
	else
			set @Max=1	
	if (@Max < 10)
			set @MaPhieuDK='PDK' + '0' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
			set @MaPhieuDK='PDK' + '' + Convert(varchar(2),@Max)
	else
			set @MaPhieuDK ='PDK' +  Convert(varchar(3),@Max)
	Return @MaPhieuDK
End
Go


Go
Create or alter function Hospital.fnMaBenhNhanTuDongTang()
returns nvarchar(10)
As
Begin
	Declare @MaBN		nvarchar(10)
	Declare @MaxMaBN	nvarchar(10)
	Declare @Max float
	Select @MaxMaBN = MAX(MaBN) from Hospital.BenhNhans	
	if exists (select MaBN from Hospital.BenhNhans)
			set @Max = CONVERT(float, SUBSTRING(@MaxMaBN,4,3)) + 1
	else
			set @Max=1	
	if (@Max < 10)
			set @MaBN='BN' + '0' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
			set @MaBN='BN' + '' + Convert(varchar(2),@Max)
	else
			set @MaBN ='BN' +  Convert(varchar(3),@Max)
	Return @MaBN
End
Go


Go
Create or alter function Hospital.fnMaLoaiPhongTuDongTang()
returns nvarchar(10)
As
Begin
	Declare @MaLoaiPhong		nvarchar(10)
	Declare @MaxMaLoaiPhong	nvarchar(10)
	Declare @Max float
	Select @MaxMaLoaiPhong = MAX(MaLoaiPhong) from Hospital.LoaiPhongs	
	if exists (select MaLoaiPhong from Hospital.LoaiPhongs)
			set @Max = CONVERT(float, SUBSTRING(@MaxMaLoaiPhong,4,2)) + 1
	else
			set @Max=1	
	if (@Max < 10)
			set @MaLoaiPhong='LP' + '0' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
			set @MaLoaiPhong='LP' + '' + Convert(varchar(2),@Max)
	else
			set @MaLoaiPhong ='LP' +  Convert(varchar(3),@Max)
	Return @MaLoaiPhong
End
Go

Go
Create or alter function Hospital.fnMaHoSoBenhAnTuDongTang()
returns nvarchar(10)
As
Begin
	Declare @MaBA		nvarchar(10)
	Declare @MaxMaBA	nvarchar(10)
	Declare @Max float
	Select @MaxMaBA = MAX(MaBA) from Hospital.HoSoBenhAns	
	if exists (select MaBA from Hospital.HoSoBenhAns)
			set @Max = CONVERT(float, SUBSTRING(@MaxMaBA,4,3)) + 1
	else
			set @Max=1	
	if (@Max < 10)
			set @MaBA='BA' + '0' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
			set @MaBA='BA' + '' + Convert(varchar(2),@Max)
	else
			set @MaBA ='BA' +  Convert(varchar(3),@Max)
	Return @MaBA
End
Go



Go
Create or alter function Hospital.fnMaHoaDonTuDongTang()
returns nvarchar(10)
As
Begin
	Declare @MaHD		nvarchar(10)
	Declare @MaxMaHD	nvarchar(10)
	Declare @Max float
	Select @MaxMaHD = MAX(MaHD) from Hospital.HoaDons	
	if exists (select MaHD from Hospital.HoaDons)
			set @Max = CONVERT(float, SUBSTRING(@MaxMaHD,4,3)) + 1
	else
			set @Max=1	
	if (@Max < 10)
			set @MaHD='HD' + '0' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
			set @MaHD='HD' + '' + Convert(varchar(2),@Max)
	else
			set @MaHD ='HD' +  Convert(varchar(3),@Max)
	Return @MaHD;
End
Go




Go
Create or alter function Hospital.fnMaXetNghiemTuDongTang()
returns nvarchar(10)
As
Begin
	Declare @MaXN		nvarchar(10)
	Declare @MaxMaXN	nvarchar(10)
	Declare @Max float
	Select @MaxMaXN = MAX(MaXN) from Hospital.XetNghiems	
	if exists (select MaXN from Hospital.XetNghiems)
			set @Max = CONVERT(float, SUBSTRING(@MaxMaXN,4,3)) + 1
	else
			set @Max=1	
	if (@Max < 10)
			set @MaXN='XN' + '0' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
			set @MaXN='XN' + '' + Convert(varchar(2),@Max)
	else
			set @MaXN ='XN' +  Convert(varchar(3),@Max)
	Return @MaXN
End
Go




Go
Create or alter function Hospital.fnMaLoaiXetNghiemTuDongTang()
returns nvarchar(10)
As
Begin
	Declare @MaLoaiXN		nvarchar(10)
	Declare @MaxMaLoaiXN	nvarchar(10)
	Declare @Max float
	Select @MaxMaLoaiXN = MAX(MaLoaiXN) from Hospital.LoaiXetNghiems	
	if exists (select MaLoaiXN from Hospital.LoaiXetNghiems)
			set @Max = CONVERT(float, SUBSTRING(@MaxMaLoaiXN,4,3)) + 1
	else
			set @Max=1	
	if (@Max < 10)
			set @MaLoaiXN='LXN' + '0' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
			set @MaLoaiXN='LXN' + '' + Convert(varchar(2),@Max)
	else
			set @MaLoaiXN ='LXN' +  Convert(varchar(3),@Max)
	Return @MaLoaiXN
End
Go



Go
Create or alter function Hospital.fnMaPhongTuDongTang()
returns nvarchar(10)
As
Begin
	Declare @MaPhong		nvarchar(10)
	Declare @MaxMaPhong	nvarchar(10)
	Declare @Max float
	Select @MaxMaPhong = MAX(MaPhong) from Hospital.Phongs	
	if exists (select MaPhong from Hospital.Phongs)
			set @Max = CONVERT(float, SUBSTRING(@MaxMaPhong,3,3)) + 1
	else
			set @Max=1	
	if (@Max < 10)
			set @MaPhong='P' + '0' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
			set @MaPhong='P' + '' + Convert(varchar(2),@Max)
	else
			set @MaPhong ='P' +  Convert(varchar(3),@Max)
	Return @MaPhong
End
Go



Go
Create or alter function Hospital.fnMaThuocTuDongTang()
returns nvarchar(10)
As
Begin
	Declare @MaThuoc		nvarchar(10)
	Declare @MaxMaThuoc	nvarchar(10)
	Declare @Max float
	Select @MaxMaThuoc = MAX(MaThuoc) from Hospital.Thuocs	
	if exists (select MaThuoc from Hospital.Thuocs)
			set @Max = CONVERT(float, SUBSTRING(@MaxMaThuoc,3,3)) + 1
	else
			set @Max=1	
	if (@Max < 10)
			set @MaThuoc='T' + '0' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
			set @MaThuoc='T' + '' + Convert(varchar(2),@Max)
	else
			set @MaThuoc ='T' +  Convert(varchar(3),@Max)
	Return @MaThuoc;
End
Go





create proc HR.spGetMaNhanVienParas
as
begin
	select MaNV from HR.NhanViens;
end
go

create proc Hospital.spGetMaBNParas
as
begin
	select MaBN from Hospital.BenhNhans;
end
go

create proc Hospital.spGetMaBSParas
as
begin
	select MaBS from Hospital.BacSis;
end
go

create proc Hospital.spGetMaKhoaParas
as
begin
	select MaKhoa from Hospital.Khoas;
end
go

create proc Hospital.spGetMaPhieuDKParas
as
begin
	select MaPhieuDK from Hospital.PhieuDangKys;
end
go

create proc Hospital.spGetMaBAParas
as
begin
	select MaBA from Hospital.HoSoBenhAns;
end
go

create proc Hospital.spGetMaHDParas
as
begin
	select MaHD from Hospital.HoaDons;
end
go

create proc Hospital.spGetMaPhongParas
as
begin
	select MaPhong from Hospital.Phongs;
end
go

create proc Hospital.spGetMaLoaiPhongParas
as
begin
	select MaLoaiPhong from Hospital.LoaiPhongs;
end
go

create proc Hospital.spGetMaXetNghiemParas
as
begin
	select MaXN from Hospital.XetNghiems;
end
go

create proc Hospital.spGetMaLoaiXetNghiemParas
as
begin
	select MaLoaiXN from Hospital.LoaiXetNghiems;
end
go