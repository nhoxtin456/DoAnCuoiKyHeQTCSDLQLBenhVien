use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('viewBenhNhan') is not null
	drop view viewBenhNhan;
go

create view viewBenhNhan
as
select MaBN, HoBN, TenBN, TinhTrang
from BenhNhan;
go

select * from viewBenhNhan;

use QuanLyBenhVien_DoAnCuoiKix;

if OBJECT_ID('spGetBN') is not null
	drop proc spGetBN;
go

create proc spGetBN
as
begin
	select * from BenhNhan;
end

exec spGetBN;

go

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('spInsertBN') is not null
	drop proc spInsertBN;
go

create proc spInsertBN
(
	@MaBN nvarchar(10),
	@HoBN nvarchar(30),
	@TenBN nvarchar(20),
	@NgaySinh datetime,
	@GioiTinh nvarchar(10),
	@TinhTrang nvarchar(20)
)
as
begin
	insert into BenhNhan
	values (@MaBN,@HoBN,@TenBN,@NgaySinh,@GioiTinh,@TinhTrang)
end
go

exec spInsertBN  @MaBN=N'bn03', @HoBN=N'john', @TenBN=N'henry1', @NgaySinh='1999-05-26', @GioiTinh=N'nam', @TinhTrang=N'normal'
exec spInsertBN  @MaBN=N'bn03', @HoBN=N'john', @TenBN=N'henry1', @NgaySinh='1999-05-26', @GioiTinh=N'nam', @TinhTrang=N'normal'
exec spInsertBN  @MaBN=N'BN03', @HoBN=N'Kansadra J', @TenBN=N'Jack', @NgaySinh='1999-03-15', @GioiTinh=N'Nam', @TinhTrang=N'Normal'

exec spGetBN

if OBJECT_ID('spUpdateBN') is not null
	drop proc spUpdateBN;
go

create proc spUpdateBN
(
	@MaBN nvarchar(10),
	@HoBN nvarchar(30),
	@TenBN nvarchar(20),
	@NgaySinh date,
	@GioiTinh nvarchar(10),
	@TinhTrang nvarchar(20)
)
as
begin
	update BenhNhan set HoBN=@HoBN, TenBN=@TenBN, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, TinhTrang=@TinhTrang
	where MaBN=@MaBN
end

exec spUpdateBN @MaBN=N'bn03', @HoBN=N'john', @TenBN=N'henry1', @NgaySinh='1999-05-26', @GioiTinh=N'nam', @TinhTrang=N'normal'

select * from BenhNhan;
go 

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('spDeleteBN') is not null
	drop proc spDeleteBN;
go

create proc spDeleteBN
(
	@MaBN nvarchar(10)
)
as
begin
	delete from BenhNhan where MaBN=@MaBN;
end

exec spDeleteBN @MaBN=N'BN03';
go

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('trKiemTraUpdateTenBN') is not null
	drop trigger trKiemTraUpdateTenBN;
go

create trigger trKiemTraUpdateTenBN 
	on BacSi
	after insert, update
as
begin
	declare @TenBS nvarchar(20)
	select @TenBS = TenBS from inserted
	if (@TenBS in (select TenKhoa from Khoa))
	begin
		print 'trung ten'
		rollback tran
	end
end
go

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('spGetKhoa') is not null
	drop proc spGetKhoa;
go

create proc spGetKhoa
as
begin
	select *
	from Khoa;
end

exec spGetKhoa;

select * from Khoa;

go

if OBJECT_ID('spInsertKhoa') is not null
	drop proc spInsertKhoa;
go

create proc spInsertKhoa
(
	@MaKhoa nvarchar(10),
	@TenKhoa nvarchar(30)
)
as
begin
	insert into Khoa
	values (@MaKhoa,@TenKhoa)
end
go 

exec spInsertKhoa @MaKhoa=N'K02',@TenKhoa=N'Khoa ngoại tổng quát';

exec spInsertKhoa @MaKhoa=N'K03',@TenKhoa=N'Khoa khám bệnh';

exec spInsertKhoa @MaKhoa=N'K04',@TenKhoa=N'Khoa nội thần kinh tổng quát';

exec spInsertKhoa @MaKhoa=N'K05',@TenKhoa=N'Khoa xét nghiệm';

exec spInsertKhoa @MaKhoa=N'K06',@TenKhoa=N'Khoa nội tiêu hóa';

exec spInsertKhoa @MaKhoa=N'K07',@TenKhoa=N'Khoa cơ xương khớp';

exec spInsertKhoa @MaKhoa=N'K08',@TenKhoa=N'Khoa hô hấp';

exec spInsertKhoa @MaKhoa=N'K09',@TenKhoa=N'Khoa tai mũi họng';

exec spInsertKhoa @MaKhoa=N'K10',@TenKhoa=N'Khoa ngoại chấn thương chỉnh hình';

exec spInsertKhoa @MaKhoa=N'K11',@TenKhoa=N'Khoa khám và điều trị theo yêu cầu';

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('spUpdateKhoa') is not null
	drop proc spUpdateKhoa;
go

create proc spUpdateKhoa
(
	@MaKhoa nvarchar(10),
	@TenKhoa nvarchar(30)
)
as
begin
	update Khoa set TenKhoa=@TenKhoa
	where MaKhoa=@MaKhoa
end

exec spGetKhoa;

exec spUpdateKhoa @MaKhoa=N'K11', @TenKhoa=N'Khoa dinh dưỡng'

go

if OBJECT_ID('spDeleteKhoa') is not null
	drop proc spDeleteKhoa;
go

create proc spDeleteKhoa
(
	@MaKhoa nvarchar(10)
)
as
begin
	delete from Khoa
	where MaKhoa=@MaKhoa
end

exec spDeleteKhoa @MaKhoa=N'K01';

exec spDeleteKhoa @MaKhoa=N'K02';

go

use QuanLyBenhVien_DoAnCuoiKi;
go

if OBJECT_ID('spGetBS') is not null
	drop proc spGetBS;
go

create proc spGetBS
as
begin
	select * from BacSi;
end

exec spGetBS;

if OBJECT_ID('spInsertBS') is not null
	drop proc spInsertBS;
go

create proc spInsertBS
(
	@MaBS nvarchar(10),
	@HoBS nvarchar(30),
	@TenBS nvarchar(20),
	@NgaySinh datetime,
	@GioiTinh nvarchar(10),
	@ChucVu nvarchar(20),
	@MaKhoa nvarchar(10)
)
as
begin
	insert into BacSi
	values (@MaBS,@HoBS,@TenBS,@NgaySinh,@GioiTinh,@ChucVu,@MaKhoa)
end


go

if OBJECT_ID('spUpdateBS') is not null
	drop proc spUpdateBS;
go

create proc spUpdateBS
(
	@MaBS nvarchar(10),
	@HoBS nvarchar(30),
	@TenBS nvarchar(20),
	@NgaySinh datetime,
	@GioiTinh nvarchar(10),
	@ChucVu nvarchar(20),
	@MaKhoa nvarchar(10)
)
as
begin
	update BacSi set HoBS=@HoBS,TenBS=@TenBS,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,ChucVu=@ChucVu,MaKhoa=@MaKhoa
	where MaBS=@MaBS
end

exec spGetBS;

exec spUpdateBS @MaBS=N'abc',@HoBS=N'john1',@TenBS=N'khoa',@NgaySinh='2019-11-06',@GioiTinh=N'nam',@ChucVu=N'pro',@MaKhoa=N'abc'

exec spUpdateBS @MaBS=N'BS01',@HoBS=N'Trương Minh',@TenBS=N'Khoa',@NgaySinh='1999-10-11',@GioiTinh=N'Nam',@ChucVu=N'Trưởng khoa',@MaKhoa=N'K01'

exec spUpdateBS @MaBS=N'BS02',@HoBS=N'Lư Mạnh',@TenBS=N'Quân',@NgaySinh='1999-06-25',@GioiTinh=N'Nam',@ChucVu=N'Phó khoa',@MaKhoa=N'K01'

go

select * from BacSi;

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('spDeleteBS') is not null
	drop proc spDeleteBS;
go

create proc spDeleteBS
(
	@MaBS nvarchar(10)
)
as
begin
	delete from BacSi where MaBS=@MaBS;
end

exec spDeleteBS @MaBS=N'abc';
exec spGetBS;
go

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('spGetPhieuDK') is not null
	drop proc spGetPhieuDK;
go

--select * from PhieuDangKy;

create proc spGetPhieuDK
as
begin
	select * from PhieuDangKy;
end

exec spGetPhieuDK;
go

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('spInsertPhieuDK') is not null
	drop proc spInsertPhieuDK;
go

create proc spInsertPhieuDK
(
	@MaPhieuDK nvarchar(10),
	@MaNV nvarchar(10),
	@MaBN nvarchar(10),
	@MaKhoa nvarchar(10)
)
as
begin
	insert into PhieuDangKy
	values (@MaPhieuDK,@MaNV,@MaBN,@MaKhoa);
end

if OBJECT_ID('spUpdatePhieuDK') is not null
	drop proc spUpdatePhieuDK;
go

create proc spUpdatePhieuDK
(
	@MaPhieuDK nvarchar(10),
	@MaNV nvarchar(10),
	@MaBN nvarchar(10),
	@MaKhoa nvarchar(10)
)
as
begin
	update PhieuDangKy set MaNV=@MaNV,MaBN=@MaBN,MaKhoa=@MaKhoa
	where MaPhieuDK=@MaPhieuDK
end

exec spGetPhieuDK;

exec spUpdatePhieuDK @MaPhieuDK=N'PDK01',@MaNV=N'NV01',@MaBN=N'BN01',@MaKhoa=N'K01';

exec spUpdatePhieuDK @MaPhieuDK=N'PDK02',@MaNV=N'NV02',@MaBN=N'BN02',@MaKhoa=N'K01';

go

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('spDeletePhieuDK') is not null
	drop proc spDeletePhieuDK;
go

create proc spDeletePhieuDK
(
	@MaPhieuDK nvarchar(10)
)
as
begin
	delete from PhieuDangKy where MaPhieuDK=@MaPhieuDK;
end

go

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('spTableKhoa') is not null
	drop proc spTableKhoa;
go

create type spTableKhoa as
table
(
	MaKhoa varchar(10) not null,
	TenKhoa nvarchar(30) not null
	primary key (MaKhoa)
);
go

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('fnBS') is not null
	drop function fnBS;
go

if OBJECT_ID('fnKhoa') is not null
	drop function fnKhoa;
go

CREATE FUNCTION fnKhoa ()
 RETURNS @OutTable table
(MaKhoa varchar(10), TenKhoa nvarchar(30))
begin
	insert @OutTable
	select * from Khoa
	return;
end

go

use QuanLyBenhVien_DoAnCuoiKix;

select *
from BacSi join dbo.fnKhoa() as BSTable
	on BacSi.MaKhoa = BSTable.MaKhoa

select *
from BacSi, dbo.fnKhoa()
where BacSi.MaKhoa = dbo.fnKhoa.MaKhoa

select *
from dbo.fnKhoa();

select *
from BenhNhan
where MaBN=N'BN01'

--create function fnBS1()
--	returns @OutTable table
--(MaKhoa varchar(10), TenKhoa nvarchar(30))
--begin
--	insert @OutTable
--	select *
--	from BacSi join Khoa
--		on BacSi.MaKhoa=Khoa.MaKhoa
--	return;
--end
--go

use QuanLyBenhVien_DoAnCuoiKix;

if OBJECT_ID('fnBSInfo') is not null
	drop function fnBSInfo;
go

create function fnBSInfo()
returns table
as
return (select * from BacSi);
go

select Khoa.MaKhoa, TenBS
from Khoa join dbo.fnBSInfo() as BSTable
	on Khoa.MaKhoa = BSTable.MaKhoa;

select *
from Khoa join BacSi
	on Khoa.MaKhoa = BacSi.MaKhoa;

select * from Khoa;
exec spGetBS;

exec spGetPhieuDK

exec spGetBN

exec spUpdateBN @MaBN=N'BN02',@HoBN=N'Diệp Gia',@TenBN=N'Hữu',@NgaySinh=N'1999-07-23',@GioiTinh=N'Nam',@TinhTrang=N'Bình thường';

select * from Khoa;

if OBJECT_ID('spGetBNId') is not null
	drop proc spGetBNId;
go

create proc spGetBNId
(
	@MaBN nvarchar(10)
)
as
begin
	select * from BenhNhan where MaBN=@MaBN;
end

exec spGetBNId @MaBN= N'BN01';

if OBJECT_ID('spGetLoaiNV') is not null
	drop proc spGetLoaiNV;
go

create proc spGetLoaiNV
as
begin
	select * from LoaiNhanVien;
end

exec spGetLoaiNV;
go

if OBJECT_ID('spInsertLoaiNV') is not null
	drop proc spInsertLoaiNV;
go

create proc spInsertLoaiNV
(
	@MaLoaiNV nvarchar(10),
	@TenLoaiNV nvarchar(30)
)
as
begin
	insert into LoaiNhanVien
	values (@MaLoaiNV,@TenLoaiNV);
end

exec spInsertLoaiNV @MaLoaiNV=N'LNV01', @TenLoaiNV=N'Nhân viên tiếp tân';
exec spInsertLoaiNV @MaLoaiNV=N'LNV02', @TenLoaiNV=N'Nhân viên kế toán';
exec spInsertLoaiNV @MaLoaiNV=N'LNV03', @TenLoaiNV=N'Admin';
go

if OBJECT_ID ('spUpdateLoaiNV') is not null
	drop proc spUpdateLoaiNV;
go

create proc spUpdateLoaiNV
(
	@MaLoaiNV nvarchar(10),
	@TenLoaiNV nvarchar(30)
)
as
begin
	update LoaiNhanVien set TenLoaiNV=TenLoaiNV
	where MaLoaiNV=MaLoaiNV
end

exec spUpdateLoaiNV @MaLoaiNV=N'LNV03',@TenLoaiNV=N'Nhân viên kế toán '

exec spGetLoaiNV;
go

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('spDeleteLoaiNV') is not null
	drop proc spDeleteLoaiNV;
go

select * from NhanVien;

go
create proc spDeleteLoaiNV
(
	@MaLoaiNV nvarchar(10)
)
as
begin
	delete from LoaiNhanVien
	where MaLoaiNV=@MaLoaiNV;
end

exec spDeleteLoaiNV @MaLoaiNV=N'LNV02'
exec spDeleteLoaiNV @MaLoaiNV=N'LNV01'
go

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('spGetNV') is not null
	drop proc spGetNV;
go

create proc spGetNV
as
begin
	select * from NhanVien;
end

exec spGetNV;
go

if OBJECT_ID('spInsertNV') is not null
	drop proc spInsertNV;
go

create proc spInsertNV
(
	@MaNV nvarchar(10),
	@HoNV nvarchar(30),
	@TenNV nvarchar(20),
	@NgaySinh datetime,
	@GioiTinh nvarchar(10),
	@MaLoaiNV nvarchar(10),
	@Password varchar(20),
	@Hide bit
)
as
begin
	insert into NhanVien
	values (@MaNV,@HoNV,@TenNV,@NgaySinh,@GioiTinh,@MaLoaiNV,@Password,@Hide)
end

exec spInsertNV @MaNV=N'NV03',@HoNV=N'Nguyễn Huỳnh Anh',@TenNV=N'Trực',@NgaySinh='1999-03-20',@GioiTinh=N'Nam',@MaLoaiNV=N'LNV03',@Password='abc',@Hide=0;

go

if OBJECT_ID('spUpdateNV') is not null
	drop proc spUpdateNV;
go

create proc spUpdateNV
(
	@MaNV nvarchar(10),
	@HoNV nvarchar(30),
	@TenNV nvarchar(20),
	@NgaySinh datetime,
	@GioiTinh nvarchar(10),
	@MaLoaiNV nvarchar(10),
	@Password varchar(20),
	@Hide bit	
)
as
begin
	update NhanVien set MaNV=@MaNV,HoNV=@HoNV,TenNV=@TenNV,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,MaLoaiNV=@MaLoaiNV,Password=@Password,Hide=@Hide
	where MaNV=@MaNV;
end

exec spUpdateNV @MaNV=N'NV01', @HoNV=N'Tôn Nữ Như', @TenNV=N'Quỳnh', @NgaySinh='1999-02-25', @GioiTinh=N'Nữ', @MaLoaiNV=N'LNV01', @Password='abc', @Hide=0;
exec spUpdateNV @MaNV=N'NV02', @HoNV=N'Nguyễn Thái Phương', @TenNV=N'Thảo', @NgaySinh='1999-10-16', @GioiTinh=N'Nữ', @MaLoaiNV=N'LNV02', @Password='abc', @Hide=0;

exec spGetNV;
go

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('spDeleteNV') is not null
	drop proc spDeleteNV;
go

create proc spDeleteNV
(
	@MaNV nvarchar(10)
)
as
begin
	delete from NhanVien
	where MaNV=@MaNV;
end

go


if OBJECT_ID('fnSoNVKeToan') is not null
	drop function fnSoNVKeToan;
go

create function fnSoNVKeToan () returns int
begin	
	return 	
	(select count (B.TenLoaiNV) as SoLoaiNV
	from(
		select TenLoaiNV
		from NhanVien ,LoaiNhanVien
		where NhanVien.MaLoaiNV = LoaiNhanVien.MaLoaiNV
		and TenLoaiNV = N'Nhân viên kế toán') B)
end	;
go

exec dbo.fnSoNVKeToan;

select dbo.fnSoNVKeToan() as SoLuongNVKeToan;

select  count (B.TenLoaiNV) as NVKeToan
from(
select TenLoaiNV
from NhanVien ,LoaiNhanVien
where NhanVien.MaLoaiNV = LoaiNhanVien.MaLoaiNV
and TenLoaiNV = N'Nhân viên kế toán') B

select * from LoaiNhanVien;

select * from NhanVien;

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('BenhNhan_Delete') is not null
	drop trigger BenhNhan_Delete;
go

create trigger BenhNhan_Delete
		on BenhNhan
		after delete
as

insert into BenhNhanArchive
		(MaBN, HoBN, TenBN, NgaySinh, GioiTinh, TinhTrang)
		select MaBN, HoBN, TenBN, NgaySinh, GioiTinh, TinhTrang
		from deleted;

go

use QuanLyBenhVien_DoAnCuoiKix;
delete BenhNhan
where MaBN=N'bn03'

select * from BenhNhanArchive

exec spGetBN

if OBJECT_ID('BenhNhan_Insert') is not null
	drop trigger BenhNhan_Insert;
go

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('spGetUser') is not null
	drop proc spGetUser;
go

create proc spGetUser
(
	@MaLoaiNV nvarchar(10),
	@Password varchar(20),
	@TenLoaiNV nvarchar(30)
)
as
begin
	select LoaiNhanVien.MaLoaiNV, TenLoaiNV,HoNV, TenNV, Password, Hide
	from LoaiNhanVien join NhanVien
		on LoaiNhanVien.MaLoaiNV=NhanVien.MaLoaiNV
	where LoaiNhanVien.MaLoaiNV=@MaLoaiNV and Password=@Password and TenLoaiNV=@TenLoaiNV
	and Password=@Password and Hide=0;
end

exec spGetUser @MaLoaiNV=N'LNV03', @Password='abc', @TenLoaiNV=N'Admin';

go


select LoaiNhanVien.MaLoaiNV, TenLoaiNV,HoNV, TenNV, Password, Hide
from LoaiNhanVien join NhanVien
	on LoaiNhanVien.MaLoaiNV=NhanVien.MaLoaiNV;

exec spGetNV;

exec spGetPhieuDK;