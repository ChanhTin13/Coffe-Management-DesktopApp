USE MASTER
GO
IF EXISTS (SELECT NAME FROM SYS.DATABASES WHERE NAME= N'Do_an_Co_so')
DROP DATABASE Do_an_Co_so

GO 
create database Do_an_Co_so

go
use Do_an_Co_so
 
------------------------------------------------Chức vụ ----------------------------------------------
go
create table Chuc_vu(
	id int identity  primary key,
	Ten_Chuc_vu nvarchar(35) NOT NULL,
	)
	 
go
insert into Chuc_vu values(N'Quản lý')
insert into Chuc_vu values(N'Phục vụ')
insert into Chuc_vu values(N'Bếp')
--select * from Chuc_vu
------------------------------------------------Nhan_vien ---------------------------------------------
go
create table Nhan_vien(
	id int identity primary key,
	Ho_ten nvarchar(35) NOT NULL,
	Chuc_vu int NOT NULL,--2:phuc vu ;3:bep; 1:admin
	  
	hinh nvarchar(max),
	sdt nvarchar(12) not null,

	Gioi_tinh bit,
	ngay_vao_lam datetime,
	FOREIGN KEY (Chuc_vu) REFERENCES Chuc_vu(id)
)

go
insert into Nhan_vien values(N'Admin',1,N'C:\Users\Tin\Downloads\Cai_lai_win\IMG_20210428_194908.jpg',N'45454',1,'2022-05-07');
insert into Nhan_vien values(N'pv1',2,N'C:\Users\Tin\Downloads\Cai_lai_win\meo_mo_phat.jpg',N'45454',0,'2022-06-03'); 
insert into Nhan_vien values(N'bep1',3,N'C:\Users\Tin\Desktop\3a982e38daad1af343bc.jpg',N'45454',1,'2022-06-12'); 
insert into Nhan_vien values(N'bep2',3,N'',N'45454',0,'2022-06-21'); 
 
--select Chuc_vu from Nhan_vien where id like 2  
--select * from Nhan_vien
go
create proc SHOW_NHAN_VIEN
as
begin
	select a.id as N'Mã nhân viên', Ho_ten as N'Họ tên', b.Ten_Chuc_vu as N'Chức vụ',
	a.hinh as N'Hình', a.sdt as N'Số điện thoại' ,a.Gioi_tinh as N'Giới tính', a.ngay_vao_lam as N'Ngày vào làm'
	from Nhan_vien as a, Chuc_vu as b
	where a.Chuc_vu=b.id --and a.Chuc_vu !=1
end

go
create proc SUA_NHAN_VIEN (@id int,@Ho_ten nvarchar(35),@Chuc_vu int ,@sdt nvarchar(12),@Gioi_tinh bit)
as
begin
	update Nhan_vien set Ho_ten=@Ho_ten, Chuc_vu= @Chuc_vu, sdt=@sdt,Gioi_tinh= @Gioi_tinh where id =@id
end

go
create proc THEM_NHAN_VIEN (@Ho_ten nvarchar(35),@Chuc_vu int,@sdt nvarchar(12),@Gioi_tinh bit)
as
begin
	insert into Nhan_vien values(@Ho_ten ,@Chuc_vu, N'' ,@sdt,@Gioi_tinh,Getdate())
end
 

------------------------------------------------Tài khoản ---------------------------------------------
go
create table tai_khoan(
	id int identity primary key,

	sdt NVARCHAR(50) NOT NULL ,
	mat_khau NVARCHAR(max) NOT NULL,

	--TYPE_ACC int NOT NULL , 
	--1: admin, 2:phuc vu, 3: bep/pha che

	MA_NV int NOT NULL,
	FOREIGN KEY (MA_NV) REFERENCES NHAN_VIEN(id)
)

--update tai_khoan set mat_khau = N'sdfsdf' where MA_NV=2
--select * from tai_khoan where sdt like N'01'
go
insert into tai_khoan values (N'00',N'c4ca4238a0b923820dcc509a6f75849b',1) 
insert into tai_khoan values(N'01',N'c4ca4238a0b923820dcc509a6f75849b',2) 
insert into tai_khoan values(N'02',N'c4ca4238a0b923820dcc509a6f75849b',3) 
 
 

go 
create proc tao_tk_admin( @sdt NVARCHAR(50), @mat_khau NVARCHAR(max) )
as
begin 
	insert into Nhan_vien values(N'admin',1,N'',N'',1,GETDATE());
	insert into tai_khoan values (@sdt,@mat_khau,1)  
end

go
create proc tao_tk_nhan_vien( @MA_NV int , @sdt NVARCHAR(50), @mat_khau NVARCHAR(max) )
AS
BEGIN  
	insert into tai_khoan values ( @sdt, @mat_khau, @MA_NV)   
END


------------------------------------------------Khách hàng ---------------------------------------------
go
create table khach_hang(
	id int identity primary key,
	ten_kh nvarchar(35),
	sdt nvarchar(12),
	cmnd nvarchar(18),

	diem_tich_luy int,
)
insert into khach_hang values(N'Liu yi ming',N'037088',N'149898498',50)
insert into khach_hang values(N'Nguyễn Nam',N'0372544',N'149898498',80)
insert into khach_hang values(N'Trần Lệ',N'09558',N'149898498',150)
go
create proc them_khach_hang(@ten_kh nvarchar(35), @sdt nvarchar(12), @cmnd nvarchar(18))
as
begin
	insert into khach_hang values(@ten_kh,@sdt,@cmnd,0)
end
--update khach_hang set ten_kh= @ten_kh ,sdt= @sdt ,cmnd= @cmnd  where id = @id
go
them_khach_hang N'Nguyễn',N'0146458',N'0548779'
go
them_khach_hang N'Quang',N'023423432',N'045487878'


------------------------------------------------Phiếu đặt bàn ---------------------------------------------
go
create table phieu_dat_ban(
	id int identity primary key,
	ma_nv int,
	ma_kh int,

	ngay_lap_phieu datetime, 
	ngay_hen_nhan datetime,
	da_nhan bit, ----0: chưa nhận, 1:đã nhận
	huy bit,--0:chua,1:huy
	FOREIGN KEY (ma_nv) REFERENCES NHAN_VIEN(id),
	FOREIGN KEY (ma_kh) REFERENCES khach_hang(id) 
) 

go
create proc nhan_ban @id_phieu int
as
begin
	update phieu_dat_ban set da_nhan = 1 where id = @id_phieu

	declare @id_ban int
	set @id_ban = (select id_ban from thong_tin_dat_ban where id_phieu= @id_phieu)
	update ban set trang_thai = 1 where id = @id_ban
	   
	insert into phieu_goi_mon values(GETDATE(),@id_phieu,@id_ban,0)
end
go 
insert into phieu_dat_ban values(2,1,GETDATE(),getdate()+1,0,0);
insert into phieu_dat_ban values(1,2,GETDATE(),getdate()+1,0,0);
insert into phieu_dat_ban values(1,1,GETDATE(),GETDATE(),0,0);
--insert into phieu_dat_ban values(1,null,GETDATE(),'2022/06/15 21:45:00 ',0);
--select * from phieu_dat_ban where ngay_hen_nhan > dateadd(minute,-10,'2022/06/15 21:45:00') and ngay_hen_nhan < dateadd(minute,+10,'2022/06/15 21:45:00')
--------------------------------------- Đặt bàn và Mua tại quán -----------------------------

go
create proc kt_dat_ban (@thoi_gian datetime,@id_ban int )
as
begin
	select count(*) 
	from phieu_dat_ban as a, thong_tin_dat_ban as b
	where a.id =b.id_phieu
	and ngay_hen_nhan >= dateadd(minute,-15,@thoi_gian) and ngay_hen_nhan <= dateadd(minute,+15,@thoi_gian)
	and b.id_ban = @id_ban
	and a.huy = 0
	and a.da_nhan=0
end
 
go
create proc load_phieu_dat_ban @ngay_nhan datetime
as
begin
 select b.id_phieu,b.id_ban,d.ten_khu_vuc,e.sdt,c.ten_ban,a.ngay_hen_nhan from phieu_dat_ban as a,thong_tin_dat_ban as b,ban as c,khu_vuc as d,khach_hang as e
 where a.id=b.id_phieu 
 and b.id_ban=c.id
 and c.khu_vuc=d.id 
 and a.ma_kh=e.id 
 and ngay_hen_nhan > @ngay_nhan
 and ngay_hen_nhan < @ngay_nhan+1
 and a.huy = 0 and a.da_nhan = 0
 order by a.ngay_hen_nhan asc
 end

go
create proc Dat_ban( @ma_nv int,@ma_kh int,@ngay_hen_nhan datetime,@id_ban int)
as
begin
	insert into phieu_dat_ban values(@ma_nv,@ma_kh,GETDATE(),@ngay_hen_nhan,0,0);

	declare @id_phieu int
	set @id_phieu = (select top(1)id from phieu_dat_ban where  ngay_hen_nhan=@ngay_hen_nhan and ma_kh = @ma_kh and da_nhan = 0 )
	insert into thong_tin_dat_ban values(@id_phieu,@id_ban)
end
--kt_dat_ban '2022/06/15 4:45:00',1
--Dat_ban 2,2,'2022/06/16 4:5:00',1
 --select *from ban where trang_thai =1
--select * from phieu_dat_ban
--select * from thong_tin_dat_ban 
--select * from ban


---------------------------------------- KHU VỰC -------------------------------------------------
go
create table khu_vuc(
	id int identity primary key,
	ten_khu_vuc nvarchar(50),
) 
go 
insert into khu_vuc values(N'Lầu 1')
insert into khu_vuc values(N'Lầu 2')
insert into khu_vuc values(N'Ngoài trời') 
--select * from khu_vuc,ban where ban.khu_vuc=khu_vuc.id and ban.khu_vuc = 1
--select id, ten_khu_vuc as N'Tên khu vực' from khu_vuc 
---------------------------------------- BÀN ----------------------------------------------
go
create table ban( 
	id int identity primary key,

	ten_ban nvarchar(10),
	so_ghe int,
	trang_thai bit,--0:trống ,1:có ng

	khu_vuc int,
	FOREIGN KEY (khu_vuc) REFERENCES khu_vuc(id)  
) 
--select ban.id as 'Mã bàn', ten_ban as N'Tên bàn', so_ghe as N'Số ghế', trang_thai as N'Trạng thái', khu_vuc as N'Khu vực'  from ban,khu_vuc where ban.khu_vuc=khu_vuc.id and khu_vuc.id= 1
go
create proc Them_ban(@ten_ban nvarchar(10),@so_ghe int,@khu_vuc int)
as
begin 
	insert into ban values(@ten_ban,@so_ghe,0,1)
end

go
--lau 1
insert into ban values(N'Bàn 1',2,1,1)
insert into ban values(N'Bàn 2',4,1,1)
insert into ban values(N'Bàn 3',4,0,1)
insert into ban values(N'Bàn 4',4,0,1)
insert into ban values(N'Bàn 5',2,0,1)
insert into ban values(N'Bàn 6',2,0,1)
--lau 2 
insert into ban values(N'Bàn 1',2,0,2)
insert into ban values(N'Bàn 2',4,0,2)
insert into ban values(N'Bàn 3',4,0,2)
insert into ban values(N'Bàn 4',4,0,2)
insert into ban values(N'Bàn 5',2,0,2)
insert into ban values(N'Bàn 6',2,0,2)
--Ngoài trời 
insert into ban values(N'Bàn 1',4,0,3)
insert into ban values(N'Bàn 2',4,0,3)
insert into ban values(N'Bàn 3',4,0,3)
insert into ban values(N'Bàn 4',4,0,3) 

go
create proc Load_Ban_Theo_Khu_Vuc( @id_khu_vuc int)
as
begin
	select id, ten_ban as N'Tên bàn', so_ghe as N'Số ghế', trang_thai as N'Trạng thái', khu_vuc as N'Khu vực'  from ban where khu_vuc = @id_khu_vuc
end
 

 
---------------------------------------- THÔNG TIN ĐẶT BÀN ----------------------------------------------
go
create table thong_tin_dat_ban(
	id_phieu int,
	id_ban int,

	FOREIGN KEY (id_phieu) REFERENCES phieu_dat_ban(id),
	FOREIGN KEY (id_ban) REFERENCES ban(id) 
)

go
insert into thong_tin_dat_ban values(1,2) 
insert into thong_tin_dat_ban values(2,4)
insert into thong_tin_dat_ban values(3,6)


------------------------------------------------Loại ---------------------------------------------
go
create table loai(
	id int identity primary key,
	ten_loai nvarchar(35)
)

go
insert into loai values(N'Đồ ăn')
insert into loai values(N'Thức uống')

--select id as N'Mã loại', ten_loai as N'Tên loại' from loai

 
------------------------------------------------Menu ---------------------------------------------
go
create table menu(
	id int identity primary key,
	ten_mon nvarchar(100),

	ma_loai int,
	so_luong_ton int,
	gia int not null, 

	hinh nvarchar(200),

	FOREIGN KEY (ma_loai) REFERENCES loai(id) 
)

go
insert into menu values(N'Bánh Quy',1,10,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Đồ ăn\Bánh Quy.jpg')
insert into menu values(N'Bông Lan Cuộn Mứt Dâu',1,10,20000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Đồ ăn\Bông Lan Cuộn Mứt Dâu.jpg')
insert into menu values(N'Bông Lan Cuộn Socola',1,10,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Đồ ăn\Bông Lan Cuộn Socola.jpg')
insert into menu values(N'Bông Lan Cuộn Vani',1,13,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Đồ ăn\Bông Lan Cuộn Vani.jpg')
insert into menu values(N'Bông Lan Trứng Muối',1,13,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Đồ ăn\Bông Lan Trứng Muối.jpg')
insert into menu values(N'Flan Socola',1,13,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Đồ ăn\Flan Socola.jpg')
insert into menu values(N'Pancake Kem Dâu',1,13,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Đồ ăn\Pancake Kem Dâu.jpg')
insert into menu values(N'Pancake Mật ong',1,13,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Đồ ăn\Pancake Mật ong.jpg')

insert into menu values(N'Đen Đá',2,13,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Thức uống\Đen Đá.jpg')
insert into menu values(N'CaCao Nóng',2,13,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Thức uống\CaCao Nóng.jpg')
insert into menu values(N'Đen Nóng',2,13,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Thức uống\Đen Nóng.jpg')
insert into menu values(N'Hồng Trà Sủi Bọt',2,13,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Thức uống\Hồng Trà Sủi Bọt.jpg')
insert into menu values(N'Matcha đậu đỏ',2,13,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Thức uống\Matcha đậu đỏ.jpg')
insert into menu values(N'Matcha Trân Châu Đường Đen',2,13,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Thức uống\Matcha Trân Châu Đường Đen.jpg')
insert into menu values(N'Matcha',2,13,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Thức uống\Matcha.jpg')
insert into menu values(N'Pin Sữa Đá',2,13,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Thức uống\Pin Sữa Đá.jpg')
insert into menu values(N'Trà Đào',2,13,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Thức uống\Trà Đào.jpg')
insert into menu values(N'Trà Vải',2,13,30000,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\HinhAnh\Thức uống\Trà Vải.jpg')
--insert into menu values(N'',2,3,30000,N'.jpg')
go
create proc load_menu
as
begin
	select a.id, ten_mon as N'Tên món',b.ten_loai as N'Loại', gia as N'Giá',so_luong_ton as N'Số lượng tồn', hinh as N'Hình' 
	from menu as a, loai as b
	where a.ma_loai=b.id 
end

--select id , ten_kh as N'Tên khách hàng', sdt as N'Số điện thoại', cmnd as N'CMND', diem_tich_luy as N'Điểm tích lũy' from khach_hang
------------------------------------------------Phiếu gọi món ---------------------------------------------
go
create table phieu_goi_mon(
	id int identity primary key,
	ngay_lap_phieu datetime,
	
	id_phieu_dat_ban int,
	id_ban int,
	thanh_toan bit,--0:chua,1:roi

	FOREIGN KEY (id_ban) REFERENCES ban(id),
	FOREIGN KEY (id_phieu_dat_ban) REFERENCES phieu_dat_ban(id)
)
 --select * from phieu_goi_mon as a,ban as b where a.id_ban=b.id and id_ban=1 and b.trang_thai = 1
  --select * from phieu_goi_mon
  --select id from phieu_goi_mon where thanh_toan = 0 and id_ban =1
go
insert into phieu_goi_mon values(GETDATE(),1,1,0)
insert into phieu_goi_mon values(getdate(),2,2,0) 
 
------------------------------------------------CTPG món ---------------------------------------------
go
create table chi_tiet_phieu_goi_mon(
	id_phieu int,

	id_mon int,
	so_luong int,

	noi_dung nvarchar(200),
	con_hang bit,-- 0: hết,  1:còn
	da_xong bit,-- 0:chưa xong,  1: xong
	ngay_goi datetime,
	FOREIGN KEY (id_phieu) REFERENCES phieu_goi_mon(id),
	FOREIGN KEY (id_mon) REFERENCES menu(id) 
)
--select a.id, ten_mon as N'Tên món',a.ma_loai, gia as N'Giá',so_luong_ton as N'Số lượng tồn', hinh as N'Hình'
--from menu as a, loai as b where a.ma_loai=b.id
 
--select * from chi_tiet_phieu_goi_mon
go
insert into chi_tiet_phieu_goi_mon values(1,5,1,N'',1,0,getdate())
insert into chi_tiet_phieu_goi_mon values(1,3,2,N'',1,0,getdate()-1)
insert into chi_tiet_phieu_goi_mon values(2,10,2,N'',1,0,getdate()+1)



------------------------------------------------Khuyến mãi ---------------------------------------------
go
create table khuyen_mai(
	id int identity primary key,

	noi_dung nvarchar(50), 
)


------------------------------------------------Hóa đơn ---------------------------------------------
create table hoa_don(
	id int identity primary key,

	ma_phieu int,
	--ma_mon int,

	ngay_thanh_toan datetime,
	tong_tien int,
	 
	--FOREIGN KEY (ma_mon) REFERENCES menu(id),
	FOREIGN KEY (ma_phieu) REFERENCES phieu_goi_mon(id)
) 
 
go
create proc co_the_xoa_menu (@id_mon int)
as
begin
	select count(*)
	from chi_tiet_phieu_goi_mon as a, phieu_goi_mon as b
	where a.id_phieu=b.id and b.thanh_toan=0 and a.id_mon = @id_mon
end

go
create proc sua_mon ( @id int , @ten_mon nvarchar(100), @ma_loai int, @so_luong_ton int, @gia int )
as
begin
	update menu
	set ten_mon=@ten_mon, ma_loai= @ma_loai, so_luong_ton=@so_luong_ton,gia=@gia
	where id=@id
end

go
create proc them_mon ( @ten_mon nvarchar(100), @ma_loai int, @so_luong_ton int, @gia int )
as
begin
	insert into menu values (@ten_mon,@ma_loai,@so_luong_ton,@gia,N'D:\z_Do an co so QL Cafe\Do_an_QLCafe\Do_an_Co_so\Do_an_Co_so\HinhAnh\null.png') 
end
 
go
create proc co_the_xoa_loai (@ten_loai nvarchar(35) )
as
begin
	select count(*) from loai as a, menu as b 
	where a.id = b.ma_loai
		and a.ten_loai like @ten_loai
end
 
go
create proc them_ban_tu_dong (@sl int, @id_kv int)
as
begin
	DECLARE @id_ten_ban INT
	DECLARE @ten_ban nvarchar(20)
	DECLARE @i INT = 0;

	WHILE @i < @sl
		BEGIN 
		SET @i = @i + 1;

		SELECT @id_ten_ban =  COUNT( * )+1 FROM ban where ban.khu_vuc= @id_kv
		SET @ten_ban = N'Bàn' + RIGHT(' '+ CAST( @id_ten_ban as nvarchar(2) ) ,20)
	 
		INSERT INTO ban VALUES (@ten_ban , 2 , 0, @id_kv)
	END;
end

--them_ban_tu_dong 3 , 1
--select * from ban where khu_vuc=1

go
create proc Mua_tai_quan(@ma_nv int,@ma_kh int)
as
begin
	insert into phieu_dat_ban values(@ma_nv,@ma_kh,GETDATE(),GETDATE(),1,0); 
end

--select * from phieu_goi_mon
--select * from thong_tin_dat_ban where id_phieu = 2
--select * from chi_tiet_phieu_goi_mon
-------------------------------------------------------CHUYỂN BÀN---------------------------------------------
go
create proc chuyen_ban (@id_ban_moi int, @id_phieu_dat_ban int , @id_phieu_goi_mon int, @id_ban_cu int )
as
begin
	update phieu_goi_mon set id_ban = @id_ban_moi  where id = @id_phieu_goi_mon
	 
	update thong_tin_dat_ban set id_ban = @id_ban_moi where id_phieu = @id_phieu_dat_ban
	update ban set trang_thai = 1 where id=@id_ban_moi
	update ban set trang_thai = 0 where id=@id_ban_cu
end

  go
create proc gop_ban (@id_phieu_goi_mon_moi int, @id_phieu_goi_mon_cu int , @id_ban_cu int ,@id_phieu_dat_ban_cu int)
as
begin
	 update chi_tiet_phieu_goi_mon set id_phieu = @id_phieu_goi_mon_moi where id_phieu=@id_phieu_goi_mon_cu
	 
	 update ban set trang_thai =0 where id=@id_ban_cu
	 delete phieu_goi_mon where id= @id_phieu_goi_mon_cu 
	 delete thong_tin_dat_ban where id_phieu=@id_phieu_dat_ban_cu
	 delete phieu_dat_ban where id = @id_phieu_dat_ban_cu
 end

  go
  create proc load_bill_theo_id_phieu_goi @id_phieu_goi_mon int
  as
  begin
	select a.id_phieu, a.id_mon,b.ten_mon, a.so_luong,b.gia,a.noi_dung,b.so_luong_ton,b.hinh,a.da_xong,a.con_hang
	from chi_tiet_phieu_goi_mon as a, menu as b
	where a.id_mon=b.id and a.id_phieu=  @id_phieu_goi_mon
  end

  --gop_ban 1,4,5,5
 go
 create proc Load_don_hang
 as
 begin
	select d.ten_khu_vuc,c.ten_ban,e.tt,a.id as N'id_phieu_goi_mon',c.id as N'id_ban',b.id as N'id_phieu_dat_ban'
	from phieu_goi_mon as a, phieu_dat_ban as b, ban as c, khu_vuc as d, 
			( select SUM(cc.so_luong*dd.gia) as tt, cc.id_phieu 
			from chi_tiet_phieu_goi_mon as cc,menu as dd
			where cc.id_mon=dd.id 
			group by cc.id_phieu) as e
	where a.id_phieu_dat_ban=b.id and a.id_ban=c.id and c.khu_vuc=d.id and a.thanh_toan=0
		and e.id_phieu=a.id

 end

go
create proc load_all_ctpgm 
as 
begin
	select a.id_phieu ,a.id_mon,b.ten_mon, a.so_luong,a.noi_dung
	from chi_tiet_phieu_goi_mon as a, menu as b
	where a.id_mon=b.id and a.con_hang = 1 and a.da_xong = 0
	order by ngay_goi asc
end

 --select id,ten_mon,so_luong_ton from menu
 --load_bill_theo_id_phieu_goi 1
 --luu_phieu_goi_mon 1,5,2,''
 --go
 --luu_phieu_goi_mon 1,3,2,''
   go
create proc luu_phieu_goi_mon ( @id_phieu int, @id_mon int,@so_luong int,@noi_dung nvarchar(200) ,@sl_thay_doi int )
as
begin
	DECLARE @check INT
	select @check =  COUNT( * ) from chi_tiet_phieu_goi_mon where id_phieu =@id_phieu and id_mon=@id_mon
	if @check > 0
		begin
			if @so_luong = 0
				begin
					delete chi_tiet_phieu_goi_mon where id_mon=@id_mon and id_phieu=@id_phieu
					update menu set so_luong_ton= 0 where id=@id_mon
					--print'1'
				end
			else
				begin
					if @sl_thay_doi=0
						begin
							update chi_tiet_phieu_goi_mon set so_luong=@so_luong,noi_dung=@noi_dung where id_phieu =@id_phieu and id_mon=@id_mon
						end
					else
						begin
							update chi_tiet_phieu_goi_mon set so_luong=@so_luong,noi_dung=@noi_dung where id_phieu =@id_phieu and id_mon=@id_mon
							update menu set so_luong_ton= (so_luong_ton- @sl_thay_doi) where id=@id_mon
							--print'2'
						end
				end
		end
	else
		begin
			insert into chi_tiet_phieu_goi_mon values(@id_phieu , @id_mon ,@so_luong ,@noi_dung,1,0,getdate())
			update menu set so_luong_ton= (so_luong_ton-@so_luong) where id=@id_mon
			--print'3'
		end  
end
 
--go
--load_bill_theo_id_phieu_goi 1
--go
--luu_phieu_goi_mon 1,3,1,'' 
go
create proc lap_phieu_goi_mon  ( @id_nv int,@id_ban int)
as
begin
	insert into phieu_dat_ban values( @id_nv,null,getdate(),getdate(),1,0)
	declare @id_phieu_dat_ban int

	set @id_phieu_dat_ban = (select max(id) from phieu_dat_ban) 
	insert into thong_tin_dat_ban values(@id_phieu_dat_ban,@id_ban)  
	 
	insert into phieu_goi_mon values(GETDATE(),@id_phieu_dat_ban,@id_ban,0)
	update ban set trang_thai=1 where id = @id_ban 
end 

go
create proc thanh_toan (@id_phieu_goi_mon int,@id_ban int)
as
begin
	update ban set trang_thai=0 where id = @id_ban 
	update phieu_goi_mon set thanh_toan = 1 where id =@id_phieu_goi_mon
	update chi_tiet_phieu_goi_mon set da_xong=1 where id_phieu=@id_phieu_goi_mon
	declare @tong_tien int
	set @tong_tien= ( select sum(a.so_luong*b.gia) from chi_tiet_phieu_goi_mon as a, menu as b where a.id_mon=b.id and a.id_phieu= @id_phieu_goi_mon )
	insert into hoa_don values(@id_phieu_goi_mon,getdate(),@tong_tien)

	update khach_hang set diem_tich_luy =(@tong_tien/10000) where id=1
end 
 
 go
 create proc v_thanh_toan @id_phieu int
 as
 begin
	select b.ten_mon, a.so_luong, (a.so_luong*b.gia) as N'Thành tiền' from chi_tiet_phieu_goi_mon as a, menu as b
	where a.id_mon=b.id
	and a.id_phieu = @id_phieu
	and a.so_luong!=0
 end
  
go
create proc top_10_mon_ban_chay
as
begin
   select top(10) b.ten_mon, sum(a.so_luong) as N'SL' 
   from chi_tiet_phieu_goi_mon as a,menu as b
   where a.id_mon=b.id  group by b.ten_mon order by sum(a.so_luong) desc
end
 