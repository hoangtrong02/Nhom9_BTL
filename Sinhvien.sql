--/// Sinh vien
create table Sinhvien
(
	Malop nvarchar(50),
	Masinhvien int primary key not null,
	Tensinhvien nvarchar(50),
	Ngaysinh datetime,
	Gioitinh nvarchar(50),
	Quequan nvarchar(50),
	Email nvarchar(50),
	Sodienthoai nvarchar(50),
	Picture image,
)
go
create proc sp_AllSinhvien
as
select * from Sinhvien
go
create proc sp_AddSinhvien
@Malop nvarchar(50),
@Masinhvien int,
@Tensinhvien nvarchar(50),
@Ngaysinh datetime,
@Gioitinh nvarchar(20),
@Quequan nvarchar(200),
@Email nvarchar(100),
@Sodienthoai char(11),
@Picture image
as
begin
	insert into Sinhvien values(@Malop,@Masinhvien,@Tensinhvien,@Ngaysinh,@Gioitinh,@Quequan,@Email,@Sodienthoai,@Picture)
end
go
create proc sp_SearchSinhvien
(@Masinhvien nvarchar(50),@Tensinhvien nvarchar(50))
as
begin
	select * from Sinhvien where Masinhvien like '%'+@Masinhvien+'%' or Tensinhvien like '%'+@Tensinhvien+'%'
end
go
create proc sp_SearchSvFromMalop
(@Malop nvarchar(50))
as
begin
	select * from Sinhvien where Malop = @Malop
end
go
create proc sp_ReportSvFromMalop
(@Malop nvarchar(50))
as
begin
	select sv.Malop,lp.Tenlop,lp.Course,sv.Masinhvien,sv.Tensinhvien,sv.Ngaysinh,sv.Gioitinh,sv.Quequan,sv.Email,sv.Sodienthoai from Sinhvien sv join Lop lp on sv.Malop=lp.Malop
	where sv.Malop = @Malop
end
go

--///////// Hoc phan
create table Hocphan
(
	Mahocphan nvarchar(50) ,
	Tenhocphan nvarchar(50) not null primary key,
	Sotinchi int
)
go
create proc sp_AllHocphan
as
select * From Hocphan
go
create proc sp_AddHocphan
(@Mahocphan nvarchar(50),
@Tenhocphan nvarchar(50),
@Sotinchi int)
as
begin
	insert into Hocphan Values(@Mahocphan,@Tenhocphan,@Sotinchi)
end
go
create proc sp_UpdateHocphan
(@Mahocphan nvarchar(50),
@Tenhocphan nvarchar(50),
@Sotinchi int)
as
begin
	Update Hocphan set Tenhocphan=@Tenhocphan,Sotinchi=@Sotinchi
	where Mahocphan=@Mahocphan
end
go
create proc sp_DeleteHocphan
@Mahocphan nvarchar(50)
as
begin
	Delete Hocphan where Mahocphan=@Mahocphan
end

go

--/////// Lop
create table Lop
(
	Malop nvarchar(50) not null primary key,
	Tenlop nvarchar(50),
	Course nvarchar(20)
)
go
create proc sp_AllLop
as
begin
	select * from Lop
end
go
create proc sp_AddLop
(
@Malop nvarchar(50),
@Tenlop nvarchar(50),
@Course nvarchar(50)
)
as
begin
	insert into Lop Values(@Malop,@Tenlop,@Course)
end
go
create proc sp_ComboxMalop
as
select Malop from Lop
exec sp_ComboxMalop
select * from Sinhvien where Masinhvien like '%6%' or Tensinhvien like '%w%'
go
create proc sp_UpdateLop
@Malop nvarchar(50),
@Tenlop nvarchar(50),
@Course nvarchar(50)
as
begin
	Update Lop set Tenlop=@Tenlop,Course=@Course where Malop=@Malop
end
go

create proc sp_SearchLop
@Malop nvarchar(50)
as
begin
	select * from Lop where Malop=@Malop
end
go
--'///// Diem
create table Diem
(
	Masinhvien int not null foreign key references Sinhvien(Masinhvien),
	Tenhocphan nvarchar(50) not null foreign key references Hocphan(Tenhocphan),
	Diemchuyencan decimal(3,1),
	Diemgiuaky decimal(3,1),
	Diemcuoiky decimal(3,1),
	Thangdiem10 decimal(3,1),
	Thangdiem4 decimal(3,1),
	Thangdiemchu nvarchar(10)
)
go
create proc sp_Alldiem
as
select * from Diem
go
create proc sp_AddDiem
(@Masinhvien int,
@Tenhocphan nvarchar(50),
@Diemchuyencan decimal(3,1),
@Diemgiuaky decimal(3,1),
@Diemcuoiky decimal(3,1),
@Thangdiem10 decimal(3,1),
@Thangdiem4 decimal(3,1),
@Thangdiemchu nvarchar(10))
as
begin
	if(not exists(Select * from Diem where Masinhvien=@Masinhvien And Tenhocphan=@Tenhocphan))
		Insert into Diem Values(@Masinhvien,@Tenhocphan,@Diemchuyencan,@Diemgiuaky,@Diemcuoiky,@Thangdiem10,@Thangdiem4,@Thangdiemchu)
	else
		print N'Lỗi thêm'
end
go
create proc sp_UpdateDiem
(@Masinhvien int,
@Tenhocphan nvarchar(50),
@Diemchuyencan decimal(3,1),
@Diemgiuaky decimal(3,1),
@Diemcuoiky decimal(3,1),
@Thangdiem10 decimal(3,1),
@Thangdiem4 decimal(3,1),
@Thangdiemchu nvarchar(10))
as
begin
	Update Diem set Diemchuyencan=@Diemchuyencan,Diemgiuaky=@Diemgiuaky,Diemcuoiky=@Diemcuoiky,Thangdiem10=@Thangdiem10,Thangdiem4=@Thangdiem4,Thangdiemchu=@Thangdiemchu
	Where Masinhvien = @Masinhvien and Tenhocphan=@Tenhocphan
end
go
create proc sp_DeleteDiem
(@Masinhvien int,
@Tenhocphan nvarchar(50))
as
begin
	Delete Diem Where Masinhvien = @Masinhvien and Tenhocphan=@Tenhocphan
end
go
create proc sp_SearchDiem
(@Masinhvien nvarchar(50))
as
begin
	select * from Diem where Masinhvien like '%'+@Masinhvien+'%'
end
go
create proc sp_ReportDiemFromSV
(@Masinhvien nvarchar(50))
as
begin
	select sv.Masinhvien,sv.Tensinhvien,hp.Mahocphan,hp.Tenhocphan,hp.Sotinchi,d.Thangdiem10,d.Thangdiem4,d.Thangdiemchu 
	from Sinhvien sv join Diem d on sv.Masinhvien=d.Masinhvien join Hocphan hp on hp.Tenhocphan=d.Tenhocphan 
	where d.Masinhvien = @Masinhvien
end
go
exec sp_ReportDiemFromSV 20200159

---//////////Giảng viên
create proc sp_AddGiangvien
@Tenhocphan nvarchar(50),
@Magiangvien int,
@Tengiangvien nvarchar(50),
@Ngaysinh datetime,
@Gioitinh nvarchar(20),
@Quequan nvarchar(200),
@Email nvarchar(100),
@Sodienthoai char(11),
@Picture image
as
begin
	insert into Giangvien values(@Tenhocphan,@Magiangvien,@Tengiangvien,@Ngaysinh,@Gioitinh,@Quequan,@Email,@Sodienthoai,@Picture)
end
go
create proc sp_SearchGiangvien
(@Magiangvien nvarchar(50),@Tengiangvien nvarchar(50))
as
begin
	select * from Giangvien where Magiangvien like '%'+@Magiangvien+'%' or Tengiangvien like '%'+@Tengiangvien+'%'
end
go
create table Giangvien
(
	Tenhocphan nvarchar(50) not null foreign key references Hocphan(Tenhocphan),
	Magiangvien int primary key not null,
	Tengiangvien nvarchar(50),
	Ngaysinh datetime,
	Gioitinh nvarchar(50),
	Quequan nvarchar(50),
	Email nvarchar(50),
	Sodienthoai nvarchar(50),
	Picture image,
)
go
create proc sp_AllGiangvien
as
select * from Giangvien
go
create proc sp_UpdateGiangvien
@Tenhocphan nvarchar(50),
@Magiangvien int,
@Tengiangvien nvarchar(50),
@Ngaysinh datetime,
@Gioitinh nvarchar(20),
@Quequan nvarchar(200),
@Email nvarchar(100),
@Sodienthoai char(11),
@Picture image
as
begin
	Update  Giangvien set Tenhocphan=@Tenhocphan,Tengiangvien=@Tengiangvien,Ngaysinh=@Ngaysinh,Gioitinh=@Gioitinh,Quequan=@Quequan,Email=@Email,Sodienthoai=@Sodienthoai,Picture=@Picture
	where Magiangvien=@Magiangvien
end
go
create proc sp_DeleteGiangvien
@Magiangvien int
as
begin
	Delete  Giangvien where Magiangvien=@Magiangvien
end
go
