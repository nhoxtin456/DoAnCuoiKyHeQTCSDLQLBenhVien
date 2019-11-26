use QuanLyBenhVien_DoAnCuoiKix;
go

select * from dbo.fnKhoa();


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

use QuanLyBenhVien_DoAnCuoiKix;
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
	@Hide bit,
	@Quyen varchar(30)
)
as
begin
	insert into NhanVien
	values (@MaNV,@HoNV,@TenNV,@NgaySinh,@GioiTinh,@MaLoaiNV,@Password,@Hide,@Quyen)
end

exec spInsertNV @MaNV=N'NV03',@HoNV=N'Nguyễn Huỳnh Anh',@TenNV=N'Trực',@NgaySinh='1999-03-20',@GioiTinh=N'Nam',@MaLoaiNV=N'LNV03',@Password='abc',@Hide=0,@Quyen='admin'
exec spInsertNV @MaNV=N'NV04', @HoNV=N'Lê Văn', @TenNV=N'Quốc', @NgaySinh='1999-07-23', @GioiTinh=N'Nam', @MaLoaiNV=N'LNV02', @Password='abc', @Hide=0,@Quyen='NVKeToan';

go

use QuanLyBenhVien_DoAnCuoiKix;
alter table NhanVien
add Quyen nvarchar(30);

alter table NhanVienArchive
add Quyen nvarchar(30);

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
	@Hide bit,
	@Quyen varchar(30)	
)
as
begin
	update NhanVien set MaNV=@MaNV,HoNV=@HoNV,TenNV=@TenNV,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,MaLoaiNV=@MaLoaiNV,Password=@Password,Hide=@Hide,Quyen=@Quyen
	where MaNV=@MaNV;
end

exec spUpdateNV @MaNV=N'NV01', @HoNV=N'Tôn Nữ Như', @TenNV=N'Quỳnh', @NgaySinh='1999-02-25', @GioiTinh=N'Nữ', @MaLoaiNV=N'LNV01', @Password='abc', @Hide=0,@Quyen='admin';
exec spUpdateNV @MaNV=N'NV02', @HoNV=N'Nguyễn Thái Phương', @TenNV=N'Thảo', @NgaySinh='1999-10-16', @GioiTinh=N'Nữ', @MaLoaiNV=N'LNV02', @Password='abc', @Hide=0,@Quyen='admin';
exec spUpdateNV @MaNV=N'NV04', @HoNV=N'Lê Văn', @TenNV=N'Quốc', @NgaySinh='1999-07-23', @GioiTinh=N'Nam', @MaLoaiNV=N'LNV02', @Password='abc', @Hide=0,@Quyen='NVKeToan';

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

exec spGetLoaiNV;

exec spGetNV;

exec spGetKhoa;

exec spGetBS;

exec spGetBN;

select * from BenhNhan;

select * from PhieuDangKy;

go

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID('BenhNhan_Trung_Insert_Update') is not null
	drop trigger BenhNhan_Trung_Insert_Update;
go

create trigger BenhNhan_Trung_Insert_Update
		on PhieuDangKy
		after insert, update
as
begin
	declare @MaBN nvarchar(20)
	select @MaBN = MaBN from inserted
	if (@MaBN in (select B.MaBN
				from BenhNhan,
				(select MaBN
				from HoSoBenhAn join PhieuDangKy
					on HoSoBenhAn.MaPhieuDK= PhieuDangKy.MaPhieuDK) B
				where B.MaBN=BenhNhan.MaBN))
	begin
		PRINT N'Tên phieu dang ky cua benh nhan da ton tai trong ho so benh an !!!'
			ROLLBACK TRAN
		END
end
go


use QuanLyBenhVien_DoAnCuoiKix;
begin try
	insert into PhieuDangKy
	values (N'PDK04',N'NV01',N'BN01',N'K01');

	print 'thanh cong: da insert duoc';
end try
begin catch
	print 'that bai: khong insert duoc'
	print 'error ' + convert(varchar, Error_number(), 1)
		+ ':' + error_message();
end catch;

go


select HoBN,B.MaBN
from BenhNhan,
(select MaBN
from HoSoBenhAn join PhieuDangKy
	on HoSoBenhAn.MaPhieuDK= PhieuDangKy.MaPhieuDK) B
where B.MaBN=BenhNhan.MaBN;

select * from dbo.fnKhoa();

select * from Khoa;

exec spGetKhoa;
go


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('spTimKiemBNTheoId') is not null
	drop proc spTimKiemBNTheoId;
go


create proc spTimKiemBNTheoId
(
	@MaBN nvarchar(20)
)
as
begin
	select * from BenhNhan
	where MaBN like '%'+@MaBN+'%'
end
go

exec spTimKiemBNTheoId @MaBN=N'BN01';
go


if OBJECT_ID('spTimKiemBNTheoTen') is not null
	drop proc spTimKiemBNTheoTen;
go

create proc spTimKiemBNTheoTen
(
	@TenBN nvarchar(20)
)
as
begin
	select * from BenhNhan
	where TenBN like '%'+@TenBN+'%'
end

exec spTimKiemBNTheoTen @TenBN=N'Hữu';
go


-- Thêm User và Login
use QuanLyBenhVien_DoAnCuoiKix;

if OBJECT_ID('spThemTKDN') is not null
	drop proc spThemTKDN;
go

Create Proc spThemTKDN
	(@TenTaiKhoan varchar(max),@matkhau varchar(max))
as
begin
	begin transaction
	--thêm login và user
	declare @SQLStringCreateLogin varchar(max)
	set @SQLStringCreateLogin= 'CREATE LOGIN ['+@TenTaiKhoan+'] WITH PASSWORD = '''+@matkhau+''''+',DEFAULT_DATABASE=[QuanLyBenhVien_DoAnCuoiKix],
			DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION = ON, CHECK_POLICY = ON;'
	exec (@SQLStringCreateLogin)

	declare @SQLStringCreateUser varchar (max)
	set @SQLStringCreateUser =  'CREATE USER ['+@TenTaiKhoan+'] FOR LOGIN ['+@TenTaiKhoan+']'
	exec (@SQLStringCreateUser)


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
use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('spPhanQuyenTKDN') is not null
	drop proc spPhanQuyenTKDN;
go

Create Proc spPhanQuyenTKDN
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

-- Sửa thông tin tài khoản
use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('spSuaTKDN') is not null
	drop proc spSuaTKDN;
go

Create Proc spSuaTKDN
	(@TenTaiKhoan varchar(max),@matkhau varchar(max))
as
begin
	begin transaction
	--update login
	declare @SQLStringCreateLogin varchar(max)
	set @SQLStringCreateLogin= ' alter LOGIN ['+@TenTaiKhoan+'] WITH  PASSWORD = '''+@matkhau+''''+''
	exec (@SQLStringCreateLogin)

	if(@@ERROR <> 0 )
	begin
		RAISERROR (N'Có lỗi xảy ra !!!',16, 1)
		rollback transaction
		return
		end
		commit transaction
	end
Go


-- Xóa tài khoản
use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('spXoaTKDN') is not null
	drop proc spXoaTKDN;
go

Create Proc spXoaTKDN
	(@TenTaiKhoan varchar(max))
as
begin
	begin transaction
	--thêm login và user
	declare @SQLStringCreateUser varchar (max)
	set @SQLStringCreateUser =  'drop user ['+@TenTaiKhoan+']'
	exec (@SQLStringCreateUser)

	declare @SQLStringCreateLogin varchar (max)
	set @SQLStringCreateLogin =  'drop login ['+@TenTaiKhoan+']'
	exec (@SQLStringCreateLogin)


	if(@@ERROR <> 0 )
	begin
		RAISERROR (N'Có lỗi xảy ra khi xóa tài khoản !!!',16, 1)
		rollback transaction
		return
		end
		commit transaction
	end
Go


-- Đổi mật khẩu
use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('spDoiMKDN') is not null
	drop proc spDoiMKDN;
go

CREATE PROCEDURE spDoiMKDN
(
	@Username varchar(100),
	@Passwordcu nvarchar(100),
	@Passwordmoi  nvarchar(100))
as
begin tran
	declare @mkcu nvarchar(20)
	select @mkcu=NhanVien.Password from NhanVien where MaNV=@Username
	if (@mkcu=@Passwordcu)
	begin
		declare @mkmoi nvarchar(20)
		set @mkmoi=@Passwordmoi 
		
		update NhanVien set NhanVien.Password = @Passwordmoi where MaNV= @Username
		declare @SQLString nvarchar(max)
		set @SQLString= 'ALTER LOGIN ['+@Username + '] WITH PASSWORD = ''' + @Passwordmoi + ''' OLD_PASSWORD = ''' + @Passwordcu + ''''
		exec(@SQLString)
	end
	if (@@ERROR<>0)
	begin
		RAISERROR(N' Có lỗi xảy ra khi đổi mật khẩu', 16, 1)
		rollback tran
		return	
	end		
	commit tran
Go


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('spUndoNV') is not null
	drop proc spUndoNV;
go

create proc spUndoNV
(@MaNV nvarchar(10))
as
begin
	--set IDENTITY_INSERT NhanVien ON

	INSERT INTO NhanVien (MaNV, HoNV, TenNV, NgaySinh, GioiTinh, MaLoaiNV, Password, Hide, Quyen)
	SELECT TOP 1 MaNV, HoNV, TenNV, NgaySinh, GioiTinh, MaLoaiNV, Password, Hide, Quyen
	FROM NhanVienArchive
	ORDER BY MaNV DESC;

	DELETE FROM NhanVienArchive WHERE MaNV = @MaNV;
	--SET IDENTITY_INSERT NhanVien OFF

end
go

exec spUndoNV @MaNV=N'NV03';
select * from NhanVien;
select * from NhanVienArchive;

select * from LoaiNhanVien;


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('NhanVien_DELETE') is not null
	drop trigger NhanVien_DELETE;
go

create trigger NhanVien_DELETE on NhanVien after DELETE
as
begin
	INSERT INTO NhanVienArchive (MaNV, HoNV, TenNV, NgaySinh, GioiTinh, MaLoaiNV, Password, Hide, Quyen)
	SELECT MaNV, HoNV, TenNV, NgaySinh, GioiTinh, MaLoaiNV, Password, Hide, Quyen
	from deleted;
end

select * from NhanVien;
go

use QuanLyBenhVien_DoAnCuoiKix;
drop table if exists NhanVienArchive;
go

select * into NhanVienArchive
from NhanVien;

use QuanLyBenhVien_DoAnCuoiKix;
delete NhanVien where MaNV=N'NV03';

select * from NhanVienArchive;

select * from LoaiNhanVien, NhanVien where LoaiNhanVien.MaLoaiNV = NhanVien.MaLoaiNV;


-- Mã Nhân Viên tự động tăng khi Thêm Nhân Viên
use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('fnIdNVAutoTang') is not null
	drop function fnIdNVAutoTang;
Go

Create function fnIdNVAutoTang()
returns nvarchar(10)	
As
Begin
	Declare @IdNhanVien nvarchar(10)
	Declare @MaxIdNhanVien nvarchar(10)
	Declare @Max float
	Select @MaxIdNhanVien = MAX(MaNV) from NhanVien	
	if exists (select MaNV from NhanVien)
			set @Max = CONVERT(float, SUBSTRING(@MaxIdNhanVien,3,8)) + 1
	else
			set @Max=1	
	if (@Max < 10)
			set @IdNhanVien='NV' + '0' + Convert(varchar(1),@Max)
	else
	if (@Max < 100)
			set @IdNhanVien='NV' + '' + Convert(varchar(2),@Max)
	else
			set @IdNhanVien ='NV' +  Convert(varchar(3),@Max)
	Return @IdNhanVien
	End
Go

--exec dbo.fnIdNVAutoTang;
--exec spInsertNV @MaNV=dbo.fnIdNVAutoTang, @HoNV


-- Thêm Nhân Viên
use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('spThemNhanVien') is not null
	drop proc spThemNhanVien;
go

create procedure spThemNhanVien
( 
		@MaNV				nvarchar(10),
		@HoNV				nvarchar(30),
		@TenNV				nvarchar(20),
		@Ngaysinh			datetime,
		@GioiTinh			nvarchar(10),
		@MaLoaiNV			nvarchar(10),
		@Password			varchar(20),
		@Hide				bit,
		@Quyen				varchar(30)  
)
as
Begin
	insert into NhanVien(MaNV, HoNV, TenNV, Ngaysinh, GioiTinh, MaLoaiNV,Password,Hide,Quyen)
	values(@MaNV, @HoNV, @TenNV, @Ngaysinh, @GioiTinh, @MaLoaiNV,@Password,@Hide,@Quyen)
	Exec spThemTKDN @MaNV,@Password
	Exec spPhanQuyenTKDN @MaNV,@Quyen
End
Go


-- Trả về bảng chứa thông tin hóa đơn
create function ThongTinHoaDon()
returns table
as return
(
	select *
	from HoaDon
)
go


-- Hiển thị thứ trong doanh thu
CREATE FUNCTION HienThiThu(@ngay DATETIME) 
RETURNS NVARCHAR(10)
AS
BEGIN 
	DECLARE @st NVARCHAR(10)          
	SELECT @st=CASE DATEPART(DW,@ngay)                         
	WHEN 1 THEN 'Chu nhat'                         
	WHEN 2 THEN 'Thu hai'                             
	WHEN 3 THEN 'Thu ba'                         
	WHEN 4 THEN 'Thu tu'                         
	WHEN 5 THEN 'Thu nam'                         
	WHEN 6 THEN 'Thu sau'                         
	ELSE 'Thu bay' 
END
RETURN (@st)			/* Trị trả về của hàm */    
END 
go


-- Tổng tiền doanh thu
CREATE FUNCTION TongTienDoanhThu
(
	@NgayStart nvarchar(20),
	@NgayEnd nvarchar(20)
) 
RETURNS nvarchar(20)
 AS 
BEGIN 
	 DECLARE @money nvarchar(20); 
	 SELECT @money =Convert(nvarchar(20),sum(GiaHD))
	 FROM HoaDon 
	 WHERE CONVERT(datetime,ThoiGian,103) between Convert(datetime,@NgayStart,103) and convert(datetime,@NgayEnd,103); 
	 IF (@money = null) 
	   SET @money = 0; 
	 RETURN @money; 
END
go


-- Tìm kiếm hồ sơ bệnh án
create FUNCTION TimKiemHSBA (@ba nvarchar(10))
RETURNS @SearchHSBA TABLE
     (
            IdBA        NVARCHAR(20),
            TenHSBA     NVARCHAR(50),
			MaBS		nvarchar(10),
			MaPhong		nvarchar(10),
			SoNgayO		datetime,
			MaPDK		nvarchar(10),	
			TrangThai nvarchar(50)
      ) 
AS
      BEGIN
            IF @ba='Tất cả'
                  INSERT INTO @SearchHSBA
                  SELECT MaBA,ChuanDoanBenh,MaBS,MaPhong 
				  FROM HoSoBenhAn
            else
                  INSERT INTO @SearchHSBA
                  SELECT  MaBA,ChuanDoanBenh,MaBS,MaPhong
				  FROM HoSoBenhAn
                  WHERE MaBA=@ba
            RETURN				/*Trả kết quả về cho hàm*/
      END
GO


-- Khi xóa hồ sơ bệnh án thì thông tin về phiếu đăng ký trong bệnh nhân và hóa đơn cũng sẽ bị xóa luôn
Go
CREATE TRIGGER Trigger_XoaBan
ON HoSoBenhAn instead of delete
AS
BEGIN
	declare @IdHSBA nvarchar(5)
	select @IdHSBA= MaBA from deleted
	delete from PhieuDangKy where PhieuDangKy.MaPhieuDK= @IdHSBA
	delete from HoaDon where HoaDon.MABA= @IdHSBA
	delete from HoSoBenhAn where HoSoBenhAn.MaBA= @IdHSBA
end
GO


-- Không được phép xóa nhân viên lớn hơn 45 tuổi
Create Trigger Trigger_XoaNhanVien
ON NhanVien
FOR DELETE
AS
BEGIN
	DECLARE @COUNT INT =0
	SELECT @COUNT = COUNT (*) FROM deleted
	WHERE YEAR(GETDATE()) - YEAR(deleted.NgaySinh) > 45
	IF (@COUNT > 0)
	BEGIN
	PRINT N'Không được phép xóa nhân viên lớn hơn 45 tuổi !!!'
		ROLLBACK TRAN
	END
END
GO

if OBJECT_ID('spGetHSBA') is not null
	drop proc spGetHSBA;
go

create proc spGetHSBA

as
begin
	select * from HoSoBenhAn;
end

exec spGetHSBA;
go

if OBJECT_ID('spInsertHSBA') is not null
	drop proc spInsertHSBA;
go

create proc spInsertHSBA
(
	@MaBA nvarchar(10),
	@ChuanDoanBenh nvarchar(30),
	@MaBS nvarchar(10),
	@MaPhong nvarchar(10),
	@MaPhieuDK nvarchar(10),
	@SoNgayO float
)
as
begin
	insert into HoSoBenhAn
	values (@MaBA,@ChuanDoanBenh,@MaBS,@MaPhong,@MaPhieuDK,@SoNgayO);
end

select * from HoSoBenhAn;
select * from BacSi;
go

use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID ('spUpdateHSBA') is not null
	drop proc spUpdateHSBA;
go

create proc spUpdateHSBA
(
	@MaBA nvarchar(10),
	@ChuanDoanBenh nvarchar(30),
	@MaBS nvarchar(10),
	@MaPhong nvarchar(10),
	@MaPhieuDK nvarchar(10),
	@SoNgayO float
)
as
begin
	update HoSoBenhAn set ChuanDoanBenh=@ChuanDoanBenh, MaBS=@MaBS, MaPhong=@MaPhong, MaPhieuDK=@MaPhieuDK, SoNgayO=@SoNgayO
	where MaBA=@MaBA
end
exec spUpdateHSBA @MaBA=N'BA01',@ChuanDoanBenh=N'Viêm dạ dày',@MaBS=N'BS01',@MaPhong=N'P01',@MaPhieuDK=N'PDK01',@SoNgayO=3;

exec spUpdateHSBA @MaBA=N'BA01',@ChuanDoanBenh=N'Viêm dạ dày',@MaBS=N'BS01',@MaPhong=N'P01',@MaPhieuDK=N'PDK01',@SoNgayO=3;

exec spUpdateHSBA @MaBA=N'BA02',@ChuanDoanBenh=N'Viêm dạ dày',@MaBS=N'BN02',@MaPhong=N'P02',@MaPhieuDK=N'PDK02',@SoNgayO=5;

exec spUpdateHSBA @MaBA=N'BA02',@ChuanDoanBenh=N'Viêm ruột thừa',@MaBS=N'BS02',@MaPhong=N'P02',@MaPhieuDK=N'PDK02',@SoNgayO=5;

go

if OBJECT_ID ('spDeleteHSBA') is not null
	drop proc spDeleteHSBA;
go

create proc spDeleteHSBA
(@MaBA nvarchar(10))
as
begin
	delete from HoSoBenhAn where MaBA=@MaBA;
end

go

use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID ('spGetHD') is not null
	drop proc spGetHD;
go

create proc spGetHD
as
begin
	select * from HoaDon;
end

if OBJECT_ID ('spInsertHD') is not null
	drop proc spInsertHD;
go

create proc spInsertHD
(
	@MaHD nvarchar(10),
	@TenHD nvarchar(30),
	@GiaHD float,
	@MaNV nvarchar(10),
	@MaBA nvarchar(10)
)
as
begin
	insert into HoaDon
	values (@MaHD,@TenHD,@GiaHD,@MaNV,@MaBA);
end
go

use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('spUpdateHD') is not null
	drop proc spUpdateHD;
go

create proc spUpdateHD
(
	@MaHD nvarchar(10),
	@TenHD nvarchar(30),
	@GiaHD float,
	@MaNV nvarchar(10),
	@MaBA nvarchar(10)
)
as
begin
	update HoaDon set TenHD=@TenHD,GiaHD=@GiaHD,MaNV=@MaNV,MABA=@MaBA 
	where MaHD=@MaHD;
end

exec spUpdateHD @MaHD=N'HD02', @TenHD=N'Hóa đơn B', @GiaHD=500000, @MaNV=N'NV02', @MaBA=N'BA02';

select * from HoaDon;
go


if OBJECT_ID('spDeleteHD') is not null
	drop proc spDeleteHD;
go

create proc spDeleteHD
(@MaHD nvarchar(10))
as
begin
	delete from HoaDon where MaHD=@MaHD;
end
go


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('spGetLoaiPhong') is not null
	drop proc spGetLoaiPhong;
go

create proc spGetLoaiPhong
as
begin
	select * from LoaiPhongBenh;
end
go


if OBJECT_ID('spInsertLoaiPhong') is not null
	drop proc spInsertLoaiPhong;
go

create proc spInsertLoaiPhong
(@MaLoaiPhong nvarchar(10),@TenLoaiPhong nvarchar(20),@GiaPhong float)
as
begin
	insert into LoaiPhongBenh values(@MaLoaiPhong,@TenLoaiPhong,@GiaPhong);
end
go


if OBJECT_ID('spUpdateLoaiPhong') is not null
	drop proc spUpdateLoaiPhong;
go

create proc spUpdateLoaiPhong
(@MaLoaiPhong nvarchar(10),@TenLoaiPhong nvarchar(20),@GiaPhong float)
as
begin
	update LoaiPhongBenh set TenLoaiPhong=@TenLoaiPhong, GiaPhong=@GiaPhong where MaLoaiPhong=@MaLoaiPhong;
end

exec spUpdateLoaiPhong @MaLoaiPhong=N'LP01',@TenLoaiPhong=N'Phòng vip',@GiaPhong=60000;

exec spUpdateLoaiPhong @MaLoaiPhong=N'LP02',@TenLoaiPhong=N'Phòng thường',@GiaPhong=70000;

select * from LoaiPhongBenh;

go


if OBJECT_ID('spDeleteLoaiPhong') is not null
	drop proc spDeleteLoaiPhong;
go

create proc spDeleteLoaiPhong (@MaLoaiPhong nvarchar(10))
as
begin
	delete from LoaiPhongBenh where MaLoaiPhong=@MaLoaiPhong;
end
go


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('spGetPhong') is not null
	drop proc spGetPhong;
go

create proc spGetPhong as
begin
	select * from PhongBenh;
end
go


if OBJECT_ID('spInsertPhong') is not null
	drop proc spInsertPhong;
go

create proc spInsertPhong
(
	@MaPhong nvarchar(10),
	@TenPhong nvarchar(30),
	@MaLoaiPhong nvarchar(10)
)
as
begin
	insert into PhongBenh values (@MaPhong,@TenPhong,@MaLoaiPhong);
end
go


if OBJECT_ID('spUpdatePhong') is not null
	drop proc spUpdatePhong;
go

create proc spUpdatePhong
(
	@MaPhong nvarchar(10),
	@TenPhong nvarchar(30),
	@MaLoaiPhong nvarchar(10)
)
as
begin
	update PhongBenh set TenPhong=@TenPhong,MaLoaiPhong=@MaLoaiPhong
	where MaPhong=@MaPhong;
end
go


if OBJECT_ID('spDeletePhong') is not null
	drop proc spDeletePhong;
go

create proc spDeletePhong(@MaPhong nvarchar(10)) as begin
	delete from PhongBenh where MaPhong=@MaPhong;
end
go


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('spGetLoaiXN') is not null
	drop proc spGetLoaiXN;
go

create proc spGetLoaiXN as begin select * from LoaiXetNghiem; end 
select * from LoaiXetNghiem;
go


if OBJECT_ID('spInsertLoaiXN') is not null
	drop proc spInsertLoaiXN;
go

create proc spInsertLoaiXN(@MaLoaiXN nvarchar(10),@TenLoaiXN nvarchar(30),@GiaLXN float) as begin
	insert into LoaiXetNghiem values(@MaLoaiXN,@TenLoaiXN,@GiaLXN);
end
go


if OBJECT_ID('spUpdateLoaiXN') is not null
	drop proc spUpdateLoaiXN;
go

create proc spUpdateLoaiXN(@MaLoaiXN nvarchar(10),@TenLoaiXN nvarchar(30),@GiaLXN float) as begin
	update LoaiXetNghiem set TenLoaiXN=@TenLoaiXN, GiaLXN=@GiaLXN where MaLoaiXN=@MaLoaiXN;
end

exec spUpdateLoaiXN @MaLoaiXN=N'LXN01',@TenLoaiXN=N'Xét nghiệm máu',@GiaLXN=500000;

exec spUpdateLoaiXN @MaLoaiXN=N'LXN02',@TenLoaiXN=N'Xét nghiệm y khoa',@GiaLXN=2000000;

select * from LoaiXetNghiem;

go


if OBJECT_ID('spDeleteLoaiXN') is not null
	drop proc spDeleteLoaiXN;
go

create proc spDeleteLoaiXN(@MaLoaiXN nvarchar(10)) as begin
	delete from LoaiXetNghiem where MaLoaiXN=@MaLoaiXN;
end
go


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('spGetXN') is not null
	drop proc spGetXN;
go

create proc spGetXN as begin select * from XetNghiem;
end

select * from XetNghiem;

go

alter table XetNghiem
alter column TenXN nvarchar(50);


if OBJECT_ID('spInsertXN') is not null
	drop proc spInsertXN;
go

create proc spInsertXN
(
	@MaXN nvarchar(10),
	@TenXN nvarchar(20),
	@MaLoaiXN nvarchar(10)
)
as
begin
	insert into XetNghiem
	values (@MaXN,@TenXN,@MaLoaiXN);
end
go

if OBJECT_ID ('spUpdateXN') is not null
	drop proc spUpdateXN;
go

create proc spUpdateXN
(
	@MaXN nvarchar(10),
	@TenXN nvarchar(50),
	@MaLoaiXN nvarchar(10)
)
as
begin
	update XetNghiem set TenXN=@TenXN,MaLoaiXN=@MaLoaiXN
	where MaXN=@MaXN;
end

exec spUpdateXN @MaXN=N'XN01',@TenXN=N'Xét nghiệm sinh hóa máu',@MaLoaiXN=N'LXN01';

select * from XetNghiem;

go

if OBJECT_ID ('spDeleteXN') is not null
	drop proc spDeleteXN;
go

create proc spDeleteXN
(@MaXN nvarchar(10))
as
begin
	delete from XetNghiem where MaXN=@MaXN;
end
go

use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID ('spGetToaXN') is not null
	drop proc spGetToaXN;
go

create proc spGetToaXN
as
begin
	select * from ToaXetNghiem;
end
go


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID ('spGetToaThuoc') is not null
	drop proc spGetToaThuoc;
go

create proc spGetToaThuoc
as
begin
	select * from ToaThuoc;
end
exec spGetToaThuoc;
go

if OBJECT_ID ('spGetThuoc') is not null
	drop proc spGetThuoc;
go

create proc spGetThuoc
as
begin
	select * from Thuoc;
end
go


if OBJECT_ID ('spInsertThuoc') is not null
	drop proc spInsertThuoc;
go

create proc spInsertThuoc
(@MaThuoc nvarchar(10), @TenThuoc nvarchar(30), @GiaThuoc float)
as
begin
	insert into Thuoc
	values (@MaThuoc, @TenThuoc, @GiaThuoc);
end
go


if OBJECT_ID ('spUpdateThuoc') is not null
	drop proc spUpdateThuoc;
go

create proc spUpdateThuoc
(@MaThuoc nvarchar(10), @TenThuoc nvarchar(30), @GiaThuoc float)
as
begin
	update Thuoc set TenThuoc=@TenThuoc, GiaThuoc=@GiaThuoc
	where MaThuoc=@MaThuoc;
end
go


if OBJECT_ID ('spDeleteThuoc') is not null
	drop proc spDeleteThuoc;
go

create proc spDeleteThuoc
(@MaThuoc nvarchar(10))
as
begin
	delete from Thuoc where MaThuoc=@MaThuoc;
end
go

select * from ToaThuoc;


exec spGetKhoa


use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID ('fn')


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




select HoSoBenhAn.MaBA, ChuanDoanBenh, MaBS, MaPhong, SoNgayO, MaPhieuDK, MaXN, NgayXN, TenLoaiXN, TenXN, GiaLXN
from HoSoBenhAn join dbo.fbC() as XN
	on HoSoBenhAn.MaBA = XN.MaBA;


where HoSoBenhAn.MaBA = A.MaBA;	 
		 


alter table HoSoBenhAn
add SoNgayO float;

alter table HoSoBenhAn
drop column SoNgayO;
		 

select * from HoaDon;
		 
if OBJECT_ID ('fnB') is not null
	drop function fbB;
go

create function fnB ()
returns table
as
return  (select B.MaXN, B.TenLoaiXN, B.TenXN, B.GiaXN
		 from (	
			select MaXN , TenLoaiXN, TenXN, GiaXN
			from LoaiXetNghiem join XetNghiem
				on LoaiXetNghiem.MaLoaiXN = XetNghiem.MaLoaiXN
		  ) B)



select MaBA
from (
select  MaBA
from ToaXetNghiem join dbo.fnB() as BN
	on ToaXetNghiem.MaXN = BN.MaXN ) A

go

use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID ('fnC') is not null
	drop function fbC;
go

create function fbC()
returns table
as
return 
	(
		select A.MaBA, A.MaXN, A.NgayXN, A.TenLoaiXN, A.TenXN, A.GiaXN
		from (
		select MaBA, ToaXetNghiem.MaXN, NgayXN, TenLoaiXN, TenXN, GiaXN
		from ToaXetNghiem join dbo.fnB() as BN
			on ToaXetNghiem.MaXN = BN.MaXN ) A
	)
go


		select  MaBA, ToaXetNghiem.MaXN, NgayXN, TenLoaiXN, TenXN, GiaXN
		from ToaXetNghiem join dbo.fnB() as BN
			on ToaXetNghiem.MaXN = BN.MaXN

select HoaDon.MABA, TenHD, GiaHD, ChuanDoanBenh, MaBS, MaPhong, SoNgayO, MaPhieuDK
from HoaDon join HoSoBenhAn
	on HoaDon.MABA = HoSoBenhAn.MaBA;

select * from HoaDon;

select *
from HoaDon join NhanVien
	on HoaDon.MaNV = NhanVien.MaNV;

select * from HoSoBenhAn;


select MaPhong, TenPhong, GiaPhong, TenLoaiPhong
from PhongBenh join LoaiPhongBenh
	on PhongBenh.MaLoaiPhong = LoaiPhongBenh.MaLoaiPhong;


select HoaDon.MABA, MaHD, TenHD, GiaHD, MaNV, ChuanDoanBenh, MaBS, MaPhong, MaPhieuDK, SoNgayO
from HoaDon join HoSoBenhAn
	on HoaDon.MABA = HoSoBenhAn.MaBA;



alter table LoaiXetNghiem
add GiaLXN float;

alter table LoaiPhongBenh
add GiaPhong float;

alter table XetNghiem
drop column GiaXN;

alter table PhongBenh
drop column GiaPhong;


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID ('fnPhongLoaiPhong') is not null
	drop function fnPhongLoaiPhong;
go

create function fnPhongLoaiPhong ()
returns table
as
return	
		select MaPhong, TenPhong, GiaPhong, TenLoaiPhong
		from LoaiPhongBenh join PhongBenh
			on LoaiPhongBenh.MaLoaiPhong = PhongBenh.MaLoaiPhong
go


select * from LoaiPhongBenh;


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID ('fnHSBAPhong') is not null
	drop function fnHSBAPhong;
go

create function fnHSBAPhong ()
returns table
as
return	
	select MaBA, ToaXetNghiem.MaXN, NgayXN, TenLoaiXN, TenXN, GiaXN
	from  join dbo.fnPhongLoaiPhong() as PB
		on .MaPhong = PB.;



use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID ('fnHSBAToaThuoc') is not null
	drop function fnHSBAToaThuoc;
go

create function fnHSBAToaThuoc ()
returns table
as
return
		select tb.MaBA, th.TenThuoc, tb.SoLuong, th.GiaThuoc
		from dbo.ToaThuoc tb
			join dbo.Thuoc th
				on tb.MaThuoc=th.MaThuoc
			join dbo.HoSoBenhAn hs
				on tb.MaBA=hs.MaBA;

go


select tb.MaBA, th.TenThuoc, tb.SoLuong, th.GiaThuoc
from dbo.ToaThuoc tb
		join dbo.Thuoc th
			on tb.MaThuoc=th.MaThuoc
		join dbo.HoSoBenhAn hs
			on tb.MaBA=hs.MaBA;
		
select * from HoSoBenhAn;

select a.MaBA, a.MaThuoc, a.SoLuong, b.TenThuoc, b.GiaThuoc
from dbo.ToaThuoc a, dbo.Thuoc b
where a.MaThuoc = b.MaThuoc



use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID ('fnHSBAPhong') is not null
	drop function fnHSBAPhong;
go

create function fnHSBAPhong()
returns table
as
return
	select hs.MaBA, th.TenLoaiPhong, th.GiaPhong, tb.TenPhong
		from dbo.PhongBenh tb
			join dbo.LoaiPhongBenh th
				on tb.MaLoaiPhong=th.MaLoaiPhong
			join dbo.HoSoBenhAn hs
				on tb.MaPhong=hs.MaPhong;
go

select p.MaLoaiPhong, t.MaPhong, p.TenLoaiPhong, p.GiaPhong, t.TenPhong
from LoaiPhongBenh p join PhongBenh t
	on p.MaLoaiPhong = t.MaLoaiPhong;


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID ('fnHSBATong') is not null
	drop function fnHSBATong;
go

create function fnHSBATong()
returns table
as
return
	select hs.MaBA, ChuanDoanBenh, MaBS, MaPhong, SoNgayO, MaPhieuDK, MaXN, NgayXN, TenLoaiXN, TenXN, GiaLXN, TenThuoc, SoLuong, GiaThuoc, TenLoaiPhong, GiaPhong, TenPhong
		from dbo.HoSoBenhAn hs
			join dbo.fnHSBAPhong() BP
				on hs.MaBA = BP.MaBA
			join dbo.fnHSBAToaThuoc() BT
				on hs.MaBA = BT.MaBA
			join dbo.fbC() C
				on hs.MaBA = C.MaBA;
go


if OBJECT_ID ('fnHSBAHD') is not null
	drop function fnHSBAHD;
go

create function fnHSBAHD()
returns table
as
return
	select hd.MaHD, hd.TenHD, hd.MaNV, hd.GiaHD, t.*
	from dbo.HoaDon hd, dbo.fnHSBATong() t
	where hd.MABA = t.MaBA;
go


select hs.MaBA, ChuanDoanBenh, MaBS, MaPhong, SoNgayO, MaPhieuDK, MaXN, NgayXN, TenLoaiXN, TenXN, GiaLXN, TenThuoc, SoLuong, GiaThuoc, TenLoaiPhong, GiaPhong, TenPhong
		from dbo.HoSoBenhAn hs
			join dbo.fnHSBAPhong() BP
				on hs.MaBA = BP.MaBA
			join dbo.fnHSBAToaThuoc() BT
				on hs.MaBA = BT.MaBA
			join dbo.fbC() C
				on hs.MaBA = C.MaBA;

go

select * from dbo.fnHSBAHD();


use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID ('viewHoaDon') is not null
	drop view viewHoaDon;
go

create view viewHoaDon
--with schemabinding
as
select MaHD, TenHD, GiaHD, MaBA, SoNgayO, TenLoaiXN, GiaLXN, TenThuoc, SoLuong, GiaThuoc, TenLoaiPhong, GiaPhong
from dbo.fnHSBAHD() as BN
where MaHD = (select MaHD from HoaDon where TenHD = N'Hóa đơn A')
--group by BN.TenHD;
go

select * from viewHoaDon
--group by HoaDon.TenHD;


if OBJECT_ID ('viewHD_Insert_Update') is not null
	drop trigger viewHD_Insert_Update;
go

create trigger viewHD_Insert_Update
	on viewHoaDon
	instead of insert,update
as

declare @MaHD nvarchar(10), @TenHD nvarchar(30), @GiaHD float, @MaBA nvarchar(10), @SoNgayO float, @TenLoaiXN nvarchar(30), @GiaLXN float, @TenThuoc nvarchar(30), @SoLuong float,
		@GiaThuoc float, @TenLoaiPhong nvarchar(30), @GiaPhong float, @TestRowCount int, @TongTien float;

select @TestRowCount = COUNT(*) from inserted;
if @TestRowCount = 1
	begin
		select @MaHD = MaHD, @TenHD = TenHD, @GiaHD = GiaHD, @MaBA = MaBA, @SoNgayO = SoNgayO,
			   @TenLoaiXN = TenLoaiXN, @GiaLXN = GiaLXN, @TenThuoc = TenThuoc, @SoLuong = SoLuong,
			   @GiaThuoc = GiaThuoc, @TenLoaiPhong = TenLoaiPhong, @GiaPhong = GiaPhong
		from inserted

		if (@MaHD is not null and @MaBA is not null)
			begin
				select @MaHD = MaHD, @MaBA = MABA
				from HoaDon
				where TenHD = N'Hóa đơn A';

				set @TongTien = @GiaHD + @GiaPhong * @SoNgayO + @GiaLXN + @GiaThuoc * @SoLuong;
				
				update HoaDon set GiaHD=@TongTien
				where TenHD = N'Hóa đơn A'
				PRINT 'Maximum invoice is $' + CONVERT(varchar,@TongTien,1) + '.';

			end

	end
else
	throw 50027, 'loi fail.', 1;
go

use QuanLyBenhVien_DoAnCuoiKix;
update viewHoaDon
set GiaHD=500000
where TenHD = N'Hóa đơn B';


select * from HoaDon;





--CREATE VIEW IBM_Invoices
-- AS
-- SELECT InvoiceNumber, InvoiceDate, InvoiceTotal
-- FROM Invoices
-- WHERE VendorID = (SELECT VendorID FROM Vendors WHERE VendorName = 'IBM');
-- GO

use QuanLyBenhVien_DoAnCuoiKix;
go

if OBJECT_ID ('fnTinhTongHD') is not null
	drop function fnTinhTongHD;
go

create function fnTinhTongHD (@MaHD nvarchar(10))
	returns float
as
begin
	declare @a nvarchar(20),
	 @TenHD nvarchar(30), @GiaHD float, @MaBA nvarchar(10), @SoNgayO float, @TenLoaiXN nvarchar(30), @GiaLXN float, @TenThuoc nvarchar(30), @SoLuong float,
		@GiaThuoc float, @TenLoaiPhong nvarchar(30), @GiaPhong float, @TestRowCount int, @TongTien float;
	set @GiaLXN = GiaLXN, @GiaPhong = GiaPhong, @GiaThuoc = GiaThuoc
	from dbo.fnHSBAHD()
	if @GiaLXN is not null and @GiaPhong is not null and @GiaThuoc is not null



			select @a = MaHD, @TenHD = TenHD, @GiaHD = GiaHD, @MaBA = MaBA, @SoNgayO = SoNgayO,
					   @TenLoaiXN = TenLoaiXN, @GiaLXN = GiaLXN, @TenThuoc = TenThuoc, @SoLuong = SoLuong,
					   @GiaThuoc = GiaThuoc, @TenLoaiPhong = TenLoaiPhong, @GiaPhong = GiaPhong
			from dbo.fnHSBAHD()
			where @MaHD = MaHD;
	
	set @TongTien = @GiaHD + @GiaPhong * @SoNgayO + @GiaLXN + @GiaThuoc * @SoLuong;
				
				
	return @TongTien;
end
go

select * from LoaiXetNghiem;

select * from PhieuDangKy;

select * from BenhNhan;

select * from BenhNhanArchive;

exec spInsertBN @MaBN=N'BN03', @HoBN=N'Lê Văn', @TenBN=N'Quốc', @NgaySinh='1999-05-15', @GioiTinh=N'Nam', @TinhTrang=N'Bình thường';

exec spInsertBN @MaBN=N'BN05', @HoBN=N'Lê Văn', @TenBN=N'Quốc2', @NgaySinh='1999-05-15', @GioiTinh=N'Nam', @TinhTrang=N'Bình thường';

exec spDeleteBN @MaBN=N'BN04';


select dbo.fnTinhTongHD(N'HD02') as TongTien;

select * from dbo.fnHSBAHD();

select * from PhieuDangKy;





	go
	CREATE TRIGGER Trigger_XoaHD
	ON HoaDon instead of delete
	AS
	BEGIN
		declare @IdNV nvarchar(10), @IdBA nvarchar(10)
		select @IdNV= MaNV, @IdBA= MABA 
		from deleted
		delete from HoSoBenhAn where HoSoBenhAn.MaBA= @IdBA
		delete from NhanVien where NhanVien.MaNV= @IdNV 
		
	end


Go
	Create function IdNhanVienTuDongTang()
	returns varchar(10)	
	As
	Begin
		Declare @IdNhanVien varchar(10)
		Declare @MaxIdNhanVien varchar(10)
		Declare @Max float
		Select @MaxIdNhanVien = MAX(IdNhanVien) from NhanVien	
		if exists (select IdNhanVien from NhanVien)
				set @Max = CONVERT(float, SUBSTRING(@MaxIdNhanVien,3,8)) + 1
		else
				set @Max=1	
		if (@Max < 10)
				set @IdNhanVien='NV' + '0' + Convert(varchar(1),@Max)
		else
		if (@Max < 100)
				set @IdNhanVien='NV' + '' + Convert(varchar(2),@Max)
		else
				set @IdNhanVien ='NV' +  Convert(varchar(3),@Max)
		Return @IdNhanVien
		End
	Go





use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID ('BN_Insert') is not null
	drop trigger BN_Insert;
go

create trigger BN_Insert on BenhNhan after insert
as

declare @MaPhieuDK nvarchar(10), @MaNV nvarchar(10), @MaBN nvarchar(10), @MaKhoa nvarchar(10)



select @MaPhieuDK = MaPhieuDK, @MaNV = MaNV, @MaBN = MaBN, @MaKhoa = MaKhoa 
from PhieuDangKy
where MaPhieuDK = @MaPhieuDK

exec spInsertPhieuDK @MaPhieuDK=N'PDK05', @MaNV=N'NV01', @MaBN=N'BN05', @MaKhoa=N'K02';



--use QuanLyBenhVien_DoAnCuoiKix;
--if OBJECT_ID ('BenhNhan')



select * into PhieuDangKyArchive
from PhieuDangKy;

select * into HoaDonArchive
from HoaDon;

select * into HoSoBenhAnArchive
from HoSoBenhAn;









use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('spUndoPDK') is not null
	drop proc spUndoPDK;
go

create proc spUndoPDK
(@MaPDK nvarchar(10))
as
begin
	--set IDENTITY_INSERT NhanVien ON

	INSERT INTO PhieuDangKy (MaPhieuDK, MaNV, MaBN, MaKhoa)
	SELECT TOP 1 MaPhieuDK, MaNV, MaBN, MaKhoa
	FROM PhieuDangKyArchive
	ORDER BY MaPhieuDK DESC;

	DELETE FROM PhieuDangKyArchive WHERE MaPhieuDK = @MaPDK;
	--SET IDENTITY_INSERT NhanVien OFF

end
go

exec spUndoNV @MaPDK=N'PDK01';

select * from PhieuDangKy;

select * from PhieuDangKyArchive;


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('PhieuDK_DELETE') is not null
	drop trigger PhieuDK_DELETE;
go

create trigger PhieuDK_DELETE on PhieuDangKy after DELETE
as
begin
	INSERT INTO PhieuDangKyArchive (MaPhieuDK, MaNV, MaBN, MaKhoa)
	SELECT MaPhieuDK, MaNV, MaBN, MaKhoa
	from deleted;
end

select * from PhieuDangKy;
go

--use QuanLyBenhVien_DoAnCuoiKix;
--drop table if exists PhieuDangKyArchive;
--go



use QuanLyBenhVien_DoAnCuoiKix;
delete PhieuDangKy where MaPhieuDK=N'PDK01';

select * from PhieuDangKyArchive;


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('spUndoPDK') is not null
	drop proc spUndoPDK;
go

create proc spUndoPDK
(@MaPDK nvarchar(10))
as
begin
	--set IDENTITY_INSERT NhanVien ON

	INSERT INTO PhieuDangKy (MaPhieuDK, MaNV, MaBN, MaKhoa)
	SELECT TOP 1 MaPhieuDK, MaNV, MaBN, MaKhoa
	FROM PhieuDangKyArchive
	ORDER BY MaPhieuDK DESC;

	DELETE FROM PhieuDangKyArchive WHERE MaPhieuDK = @MaPDK;
	--SET IDENTITY_INSERT NhanVien OFF

end
go

exec spUndoNV @MaPDK=N'PDK01';

select * from PhieuDangKy;

select * from PhieuDangKyArchive;


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('PhieuDK_DELETE') is not null
	drop trigger PhieuDK_DELETE;
go

create trigger PhieuDK_DELETE on PhieuDangKy after DELETE
as
begin
	INSERT INTO PhieuDangKyArchive (MaPhieuDK, MaNV, MaBN, MaKhoa)
	SELECT MaPhieuDK, MaNV, MaBN, MaKhoa
	from deleted;
end

select * from PhieuDangKy;
go

--use QuanLyBenhVien_DoAnCuoiKix;
--drop table if exists PhieuDangKyArchive;
--go



use QuanLyBenhVien_DoAnCuoiKix;
delete PhieuDangKy where MaPhieuDK=N'PDK01';

select * from PhieuDangKyArchive;


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('spUndoHSBA') is not null
	drop proc spUndoHSBA;
go

create proc spUndoHSBA
(@MaBA nvarchar(10))
as
begin
	--set IDENTITY_INSERT NhanVien ON

	INSERT INTO HosHoSoBenhAn(MaPhieuDK, MaNV, MaBN, MaKhoa)
	SELECT TOP 1 MaPhieuDK, MaNV, MaBN, MaKhoa
	FROM PhieuDangKyArchive
	ORDER BY MaPhieuDK DESC;

	DELETE FROM PhieuDangKyArchive WHERE MaPhieuDK = @MaPDK;
	--SET IDENTITY_INSERT NhanVien OFF

end
go

exec spUndoNV @MaPDK=N'PDK01';

select * from PhieuDangKy;

select * from PhieuDangKyArchive;


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('PhieuDK_DELETE') is not null
	drop trigger PhieuDK_DELETE;
go

create trigger PhieuDK_DELETE on PhieuDangKy after DELETE
as
begin
	INSERT INTO PhieuDangKyArchive (MaPhieuDK, MaNV, MaBN, MaKhoa)
	SELECT MaPhieuDK, MaNV, MaBN, MaKhoa
	from deleted;
end

select * from PhieuDangKy;
go

--use QuanLyBenhVien_DoAnCuoiKix;
--drop table if exists PhieuDangKyArchive;
--go



use QuanLyBenhVien_DoAnCuoiKix;
delete PhieuDangKy where MaPhieuDK=N'PDK01';

select * from PhieuDangKyArchive;


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID ('HSBA_Delete') is not null
	drop trigger HSBA_Delete;
go

create trigger HSBA_Delete on HoSoBenhAn after delete
as
begin
	insert into HoSoBenhAnArchive (MaBA, ChuanDoanBenh, MaBS, MaPhong, MaPhieuDK, SoNgayO)
	select MaBA, ChuanDoanBenh, MaBS, MaPhong, MaPhieuDK, SoNgayO
	from deleted
end
go

use QuanLyBenhVien_DoAnCuoiKix;
delete HoSoBenhAn where MaBA=N'BA01';

select * from HoSoBenhAn;

select * from HoSoBenhAnArchive;


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID ('HD_Delete') is not null
	drop trigger HD_Delete;
go

create trigger HD_Delete on HoaDon after delete
as
insert into HoaDonArchive 
	(MaHD, TenHD, GiaHD, MaNV, MABA)
	select MaHD, TenHD, GiaHD, MaNV, MABA
	from deleted
go

use QuanLyBenhVien_DoAnCuoiKix;
delete from HoaDon where MaHD = N'HD01';

exec spInsertHD @MaHD=N'HD01',@TenHD=N'Hóa đơn A',@GiaHD=500000,@MaNV=N'NV02',@MaBA=N'BA01';

exec spUpdateHD @MaHD=N'HD02',@TenHD=N'Hóa đơn B',@GiaHD=1000000,@MaNV=N'NV02',@MaBA=N'BA02';

select * from NhanVien;

select * from NhanVien, LoaiNhanVien where NhanVien.MaLoaiNV = LoaiNhanVien.MaLoaiNV;

select * from HoaDon;

select * from HoaDonArchive;

delete from HoaDonArchive;


select * from HoSoBenhAn;


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID ('spUndoHD') is not null
	drop proc spUndoHD;
go

create proc spUndoHD
(@MaHD nvarchar(10))
as
begin
	--set IDENTITY_INSERT NhanVien ON
	insert into HoaDon (MaHD, TenHD, GiaHD, MaNV, MABA)
	select top 1 MaHD, TenHD, GiaHD, MaNV, MABA
	from HoaDonArchive
	order by MaHD desc

	delete from HoaDonArchive where MaHD = @MaHD;
	--SET IDENTITY_INSERT NhanVien OFF
end

exec spUndoHD @MaHD=N'HD01';
go


use QuanLyBenhVien_DoAnCuoiKix;
if OBJECT_ID('spUndoHSBA') is not null
	drop proc spUndoHSBA;
go

create proc spUndoHSBA
(@MaBA nvarchar(10))
as
begin
	--set IDENTITY_INSERT NhanVien ON

	INSERT INTO HosHoSoBenhAn(MaPhieuDK, MaNV, MaBN, MaKhoa)
	SELECT TOP 1 MaPhieuDK, MaNV, MaBN, MaKhoa
	FROM PhieuDangKyArchive
	ORDER BY MaPhieuDK DESC;

	DELETE FROM PhieuDangKyArchive WHERE MaPhieuDK = @MaPDK;
	--SET IDENTITY_INSERT NhanVien OFF

end
go

select * from dbo.fnHSBAHD();


