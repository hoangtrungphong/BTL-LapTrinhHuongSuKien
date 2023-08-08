	CREATE DATABASE QuanLybanMayTinh
	GO

	USE QuanLybanMayTinh
	GO

	-- Bảng nhà cung cấp
	CREATE TABLE tblNhaCungCap (
		iMaNCC INT NOT NULL,
		sTenNhaCC NVARCHAR(50),
		sTenGiaoDich NVARCHAR(50),
		sDiaChi NVARCHAR(100),
		sSDT VARCHAR(20),
		CONSTRAINT PK_NhaCungCap_MaNCC PRIMARY KEY(iMaNCC)
	)
	GO
	ALTER TABLE dbo.tblNhaCungCap ADD CONSTRAINT unique_sdt_ncc UNIQUE(sSDT)

	-- Bảng Loại Hàng
	CREATE TABLE tblLoaiHang(
		sMaLoaiHang VARCHAR(20) NOT NULL,
		sTenLoaiHang NVARCHAR(50) NOT NULL
	)
	ALTER TABLE dbo.tblLoaiHang ADD CONSTRAINT PK_Maloaihang PRIMARY KEY(sMaloaihang)
	GO

	-- Bảng Mặt Hàng
	CREATE TABLE tblMatHang (
		sMaHang VARCHAR(20) NOT NULL,
		sTenHang NVARCHAR(50) NOT NULL,
		iMaNCC INT NOT NULL,
		sMaLoaiHang VARCHAR(20) NOT NULL,
		iSoLuong INT,
		sDonViTinh NVARCHAR(20),
		fGiaBan INT,
		fTGBaoHanh int ,
		sDVBaoHanh NVARCHAR(20)
	)
	ALTER TABLE dbo.tblMatHang 
	ADD CONSTRAINT PK_Mathang_MaHang PRIMARY KEY(sMahang),
	CONSTRAINT FK_Maloaihang_Loaihang 
		FOREIGN KEY(sMaLoaiHang) REFERENCES dbo.tblLoaiHang(sMaLoaiHang),
	CONSTRAINT FK_mathang_nhacungcap
		FOREIGN KEY(iMaNCC) REFERENCES tblNhaCungCap(iMaNCC);

	ALTER TABLE dbo.tblMatHang 
	ADD CONSTRAINT check_gia_sl CHECK(iSoLuong >= 0 AND fGiaBan > 0 AND fTGBaoHanh > 0),
		CONSTRAINT default_donvibaohanh DEFAULT N'Tháng' FOR sDVBaoHanh	;	
	GO


	 

	-- Bảng Nhân Viên
	CREATE TABLE tblNhanVien (
		sMaNV VARCHAR(20) NOT NULL,
		sTenNV NVARCHAR(50) NOT NULL, 
		sGioiTinh NVARCHAR(10),
		dNgaySinh DATE,
		dNgayVaoLam DATE,
		sDiaChi NVARCHAR(100),
		sSDT VARCHAR(20),
		fLuongCB INT
	);
	ALTER TABLE dbo.tblNhanVien 
	ADD CONSTRAINT PK_NhanVien_MaNV PRIMARY KEY(SMaNV) ;

	ALTER TABLE dbo.tblNhanVien ADD CONSTRAINT check_luongcb CHECK(fLuongCB > 0),
									CONSTRAINT check_gioitinh_nv CHECK(sGioitinh LIKE N'%Nam%' OR sGioitinh LIKE N'%Nữ%'),
									CONSTRAINT unique_sdt_nv UNIQUE(sSDT),
									CONSTRAINT check_ngayvaolam CHECK(dNgayvaolam <= GETDATE());
	GO
	drop table dbo.tblNhanVien
	

	-- Bảng Khách Hàng
	CREATE TABLE tblKhachHang (
		sMaKH VARCHAR(20) NOT NULL,
		sTenKH NVARCHAR(50) NOT NULL,
		sGioiTinh NVARCHAR(20),
		dNgaySinh DATE,
		sDiaChi NVARCHAR(100),
		sSDT VARCHAR(20)
	)
	ALTER TABLE dbo.tblKhachHang ADD CONSTRAINT PK_KhachHang_MaKH PRIMARY KEY(sMaKH),
									 CONSTRAINT unique_sdt_kh UNIQUE(sSDT),
									 CONSTRAINT check_gioitinh_kh CHECK(sGioitinh LIKE N'%Nam%' OR sGioitinh LIKE N'%Nữ%')
	GO

	-- Bảng đơn nhập hàng
	CREATE TABLE tblDonNhapHang (
		iMaHD INT NOT NULL,
		sMaNV VARCHAR(20) NOT NULL,
		sNgayNhapHang DATE,
	)
	ALTER TABLE dbo.tblDonNhapHang 
	ADD CONSTRAINT PK_DonNhapHang_SoHD PRIMARY KEY(iMaHD),
		CONSTRAINT FK_MaNV_NhanVien 
			FOREIGN KEY(sMaNV) REFERENCES dbo.tblNhanVien(sMaNV),
		CONSTRAINT check_ngaynhaphang CHECK(sNgaynhaphang <= GETDATE())
	GO

	-- Bảng chi tiết nhập
	CREATE TABLE tblChiTietNhapHang (
		iMaHD INT NOT NULL,
		sMaHang VARCHAR(20) NOT NULL,
		fGiaNhap INT,
		iSoLuongNhap INT
	)
	ALTER TABLE dbo.tblChiTietNhapHang 
	ADD CONSTRAINT PK_ChiTietNhapHang PRIMARY KEY(iMaHD,sMaHang),
		CONSTRAINT FK_SoHD_DNH 
			FOREIGN KEY(iMaHD) REFERENCES dbo.tblDonnhaphang(iMaHD),
		CONSTRAINT FK_Mahang_MatHang
			FOREIGN KEY(sMaHang) REFERENCES dbo.tblMathang(sMaHang),
		CONSTRAINT check_gianhap_slnhap CHECK(fGianhap > 0 AND iSoluongnhap >= 0 )
	GO 

	-- Bảng đơn đặt hàng
	CREATE TABLE tblDonDatHang (
		iMaHD INT NOT NULL,
		sMaNV VARCHAR(20) NOT NULL,
		sMaKH VARCHAR(20) NOT NULL,
		dNgayDatHang DATE
	)
	ALTER TABLE dbo.tblDonDatHang 
	ADD CONSTRAINT PK_SoHD_DDH PRIMARY KEY(iMaHD),
		CONSTRAINT FK_MaNV_NV
			FOREIGN KEY(sMaNV) REFERENCES dbo.tblNhanVien(sMaNV),
		CONSTRAINT FK_MaKH_KhachHang 
			FOREIGN KEY(sMaKH) REFERENCES dbo.tblKhachHang(sMaKH),
		CONSTRAINT check_ngaydathang CHECK(dNgayDatHang <= GETDATE())
	GO
	alter table tblDonDatHang DROP PK_SoHD_DDH 
	drop table tblDonDatHang
	-- Bảng chi tiết đặt hàng
	CREATE TABLE tblChiTietDatHang (
		iMaHD INT NOT NULL,
		sMaHang VARCHAR(20) NOT NULL,
		fGiaBan INT,
		iSoLuongMua INT,
		fMucGiamGia FLOAT,
		dThGHetBaoHanh DATE
	)
	ALTER TABLE dbo.tblChiTietDatHang 
	ADD CONSTRAINT PK_ChiTietDatHang PRIMARY KEY(iMaHD,sMaHang),
		CONSTRAINT FK_SoHD_DDH 
			FOREIGN KEY(iMaHD) REFERENCES dbo.tblDonDatHang(iMaHD),
		CONSTRAINT FK_Mahang_MH
			FOREIGN KEY(sMaHang) REFERENCES dbo.tblMathang(sMaHang),
		CONSTRAINT check_giaban_slmua_giamgia CHECK(iSoluongmua > 0 AND fGiaban > 0 AND fMucGiamGia >= 0)
	GO

	CREATE TABLE tblTaiKhoan (
	iMaTK INT NOT NULL,
	sTaiKhoan NVARCHAR(50),
	sMatKhau NVARCHAR(255)
)
alter table tblTaiKhoan add constraint PK_TK primary key(iMaTK)
GO	
INSERT INTO dbo.tblTaiKhoan(iMaTK,sTaiKhoan,sMatKhau) 
VALUES
(01, N'Huyền', N'111'),
(02, N'thanh', N'222'),
(03, N'phong', N'333')
GO 
delete  from tblTaiKhoan
	------------------------------------ INSERT ----------------------------------
	-- Bảng Nhà cung cấp
	INSERT INTO dbo.tblNhaCungCap
	(iMaNCC,sTenNhaCC,sTenGiaoDich,sDiachi,sSDT)
	VALUES
	( 1, N'Dell', N'Giao dịch 1',N'America', '098888888'  ),
	( 2, N'Asus',N'Giao dịch 2',N'America', '097777777' ),
	( 3, N'HP' ,N'Giao dịch 3',N'America', '090999221' ),
	( 4, N'Lenovo' ,N'Giao dịch 4',N'America', '098237141' )
	GO

	-- Bảng loại hàng
	INSERT INTO dbo.tblLoaiHang
	(sMaLoaiHang,sTenLoaiHang)
	VALUES
	( 'IP',N'Macbook'),
	( 'SS',N'Dell Vostro'),
	( 'VS',N'Asus Zenbook'),
	( 'OP',N'Asus Vivobook')
	GO


	-- Bảng Mặt hàng
	INSERT INTO dbo.tblMatHang
	(sMahang,sTenHang,iMaNCC,sMaLoaiHang,iSoLuong,sDonViTinh,fGiaBan,fTGBaoHanh,sDVBaoHanh)
	VALUES
	('IP1', N'Macbook Air', 1, 'IP',20,N'Chiếc',24000000,24,N'Tháng'),
	('IP2', N'Macbook Pro', 1, 'IP',18,N'Chiếc',9000000,24,N'Tháng'),
	('SS1', N'Dell Vostro R1', 2, 'SS',30,N'Chiếc',2000000,12,N'Tháng'),
	('SS2', N'Dell Vostro R15', 2, 'SS',32,N'Chiếc',6000000,12,N'Tháng'),
	('VS1', N'Asus Zenbook Z8', 4, 'VS',27,N'Chiếc',3200000,12,N'Tháng'),
	('VS2', N'Asus Zenbook Z5', 4, 'VS',32,N'Chiếc',2400000,12,N'Tháng'),
	('OP1', N'Asus Vivobook V3', 2, 'OP',55,'Chiếc',4500000,24,N'Tháng'),
	('OP2', N'Asus Vivobook V5', 2, 'OP',34,'Chiếc',6300000,24,N'Tháng')
	
	GO
	 DELETE FROM dbo.tblMatHang

	-- Bảng Nhân Viên
	INSERT INTO dbo.tblNhanVien
	(sMaNV,sTenNV,sGioiTinh,dNgaySinh,dNgayVaoLam,sDiaChi,sSDT,fLuongCB)
	VALUES
	('NV1',N'Phạm Xuân Sang', N'Nam','1997-01-21','2015-08-10',N'Nam Định','0932874217',7000000),
	('NV2',N'Nguyễn Thị Minh Thanh' ,N'Nữ','2000-05-13','2019-07-12',N'Nam Định','0912969876',4000000),
	('NV3',N'Hoàng Trung Phong' ,N'Nam','1999-08-14','2016-05-12',N'Thanh Hóa','0987266377',3000000),
	('NV4',N'Nguyễn Hoàng Hiệp' ,N'Nam','1994-02-18','2020-01-22',N'Hải Dương','0963825623',4000000),
	('NV5',N'Lê Thị Giang', N'Nữ','2002-12-16','2017-09-23',N'Thanh Hóa','0912961073',4000000), 
	('NV6',N'Lê Hồng phong', N'Nam','2002-05-31','2016-09-22',N'Thanh Hóa','0886103494',40404040)
	GO
	select * from  dbo.tblNhanVien
	-- Bảng Khách hàng
	INSERT INTO dbo.tblKhachHang
	(sMaKH,sTenKH,sGioiTinh,dNgaySinh,sDiachi,sSDT)
	VALUES
	('KH1', N'Lê Văn Lương',N'Nam','1987-02-02',N'Hà Nội','0937625618'),
	('KH2', N'Nguyễn Quang Hải',N'Nam','1999-04-04',N'Hà Nội','0963725618'),
	('KH3', N'Nguyễn Văn Thanh',N'Nam','1988-09-09',N'Cao Bằng','0983276156'),
	('KH4', N'Chu Ngọc Hoan',N'Nữ','2002-11-17',N'Hải Dương','0982773661'),
	('KH5', N'Hoàng Thị Ngọc Bích',N'Nữ','2001-01-01',N'Sơn La','0988888227'),
	('KH6', N'Vũ Thị Ngọc Bích',N'Nữ','2000-09-01',N'Sơn Tây','0987788227')
	Go
	INSERT INTO dbo.tblKhachHang
	(sMaKH,sTenKH,sGioiTinh,dNgaySinh,sDiachi,sSDT)
	VALUES
	('KH7', N'Nguyễn ngọc ngạn',N'nam','1977-02-03',N'Hà Nam','0937629999')
	GO
	-- Bảng Đơn nhập hàng
	INSERT INTO dbo.tblDonNhapHang
	(iMaHD,sMaNV,sNgaynhaphang)
	VALUES
	(101,  'NV2',  '2019-04-20' ),
	(102,  'NV4',  '2021-06-22' ),
	(103,  'NV5',  '2020-05-31' ),
	(104,  'NV4',  '2021-04-25' ),
	(108,  'NV2',  '2020-05-28' ),
	(109,  'NV4',  '2020-11-21' ),
	(110,  'NV5',  '2019-03-10' )
	GO 

	select * from tblKhachHang where sGioiTinh like 'Nam'
		select * from tblKhachHang where sDiaChi = N'Hà Nội'

	-- Bảng chi tiết nhập hàng
	INSERT INTO dbo.tblChiTietNhapHang
	(iMaHD,sMahang,fGianhap,iSoluongnhap)
	VALUES    
	( 101 , 'OP2', 2000000, 10),
	( 102 , 'IP1', 2100000, 5),
	( 103 , 'VS1', 2800000, 10),

	( 104 , 'IP2', 7500000, 6),
	( 108 , 'OP1', 3800000, 14),
	( 109 , 'VS2', 1900000, 10),

	( 110 , 'OP2', 2000000, 10) 

	GO
	delete from tblChiTietNhapHang


	--Bảng Đơn đặt hàng
	INSERT INTO dbo.tblDonDatHang
		(iMaHD,sMaNV,sMaKH,dNgayDatHang)
		VALUES
		( 201,    'NV3',     'KH1',        '2019-04-20'   ),
		( 202,    'NV2',     'KH4',        '2020-05-12'   ),
		( 203,    'NV2',     'KH2',        '2021-06-23'   ),
		( 209,    'NV5',     'KH1',        '2021-01-20'   ),
		( 210,    'NV3',     'KH2',        '2020-04-10'   ),
		( 211,    'NV2',     'KH6',        '2021-02-25'   )
	GO

	-- Bảng Chi tiết đặt hàng
	INSERT INTO dbo.tblChiTietDatHang
		(iMaHD,sMahang,fGiaban,iSoluongmua,fMucGiamGia,dThGHetBaoHanh)
		VALUES
		( 201 , 'OP2', 6300000, 1,0.05 ,'2021-02-22'),
		( 202 , 'IP1', 24000000, 1,0.2,'2021-04-20'),
		( 203 , 'VS1', 3200000, 1,  0  ,'2020-03-21'), 

		( 209 , 'IP2', 9000000, 1,0.1 ,'2020-06-11'),
		( 210 , 'OP1', 4500000, 1,0.5,'2020-05-12'),
		( 211 , 'VS2', 2400000, 1,0.5,'2021-05-12')
	GO 
	delete from tblChiTietDatHang

	SELECT * FROM dbo.tblKhachHang;
	SELECT * FROM dbo.tblNhaCungCap;
	SELECT * FROM dbo.tblNhanVien;
	SELECT * FROM dbo.tblMatHang;
	SELECT * FROM dbo.tblDonDatHang;
	SELECT * FROM dbo.tblDonNhapHang;
	SELECT * FROM dbo.tblChiTietDatHang;
	SELECT * FROM dbo.tblChiTietNhapHang;
	SELECT * FROM dbo.tblLoaiHang;


	 --Khách Hàng
  CREATE PROC SP_insertKH 
 @sMaKH VARCHAR(20),
 @sTenKH NVARCHAR(50),
 @sGioiTinh NVARCHAR(20),
 @dNgaysinh DATE,
 @sDiachi  NVARCHAR(100),
 @sSDT VARCHAR(20)
 AS
 BEGIN
	INSERT INTO tblKhachHang (sMaKH,sTenKH,sGioiTinh,dNgaySinh,sDiachi ,sSDT)
	 VALUES ( @sMaKH,@sTenKH,@sGioiTinh,@dNgaysinh,@sDiachi ,@sSDT)
 END
 GO
 create procedure spKhachHang_Update
	 @sMaKH VARCHAR(20),
     @sTenKH NVARCHAR(50),
	 @sGioiTinh NVARCHAR(20),
	 @dNgaysinh DATE,
	 @sDiachi NVARCHAR(100),
     @sSDT VARCHAR(20)
as 
	update tblKhachHang
	set sMaKH = @sMaKH,
		sTenKH = @sTenKH,
		sGioiTinh = @sGioiTinh,
		dNgaySinh = @dNgaysinh,
		sDiachi = @sDiachi,
		sSDT = @sSDT
	where sMaKH = @sMaKH
GO 

 create proc SP_DELETEKH 
@sMaKH VARCHAR(20) output
as
begin
	delete from tblKhachHang where sMaKH = @sMaKH
end


 --NhanVien
  CREATE PROC SP_insertNV 
 @sMaNV VARCHAR(20),
 @sTenNV NVARCHAR(50),
 @sGioiTinh NVARCHAR(10),
 @dNgaySinh DATE,
 @dNgayVaoLam DATE,
 @sDiaChi  NVARCHAR(100),
 @sSDT VARCHAR(20),
 @fLuongCB INT

 AS
 BEGIN
	INSERT INTO tblNhanVien (sMaNV,sTenNV,sGioiTinh,dNgaySinh,dNgayVaoLam ,sDiaChi,sSDT,fLuongCB)
	 VALUES ( @sMaNV,@sTenNV,@sGioiTinh,@dNgaySinh,@dNgayVaoLam ,@sDiaChi,@sSDT,@fLuongCB)
 END
 GO

 create procedure spNhanVien_Update
	 @sMaNV VARCHAR(20),
     @sTenNV NVARCHAR(50),
	 @sGioiTinh NVARCHAR(10),
	 @dNgaySinh DATE,
	 @dNgayVaoLam DATE,
     @sDiaChi NVARCHAR(100),
	 @sSDT VARCHAR(20),
	 @fLuongCB INT

as 
BEGIN
	update tblNhanVien set sMaNV = @sMaNV,sTenNV = @sTenNV,sGioiTinh = @sGioiTinh,
	dNgaySinh = @dNgaySinh,dNgayVaoLam = @dNgayVaoLam,sDiaChi = @sDiaChi,sSDT = @sSDT,
	fLuongCB = @fLuongCB
	where sMaNV = @sMaNV
END
go
 

  create proc SP_DELETENV 
@sMaNV VARCHAR(20) output
as
begin
	delete from tblNhanVien where sMaNV = @sMaNV
END


 --- Mat Hang

   CREATE PROC SP_insertMH 
 @sMaHang VARCHAR(20),
 @sTenHang NVARCHAR(50),
 @iMaNCC INT,
 @sMaLoaiHang  VARCHAR(20),
 @iSoLuong INT,
 @sDonViTinh  NVARCHAR(100),
 @fGiaBan VARCHAR(20),
 @fTGBaoHanh INT,
 @sDVBaoHanh NVARCHAR(20)
 AS
 BEGIN
	INSERT INTO tblMatHang (sMaHang,sTenHang,iMaNCC,sMaLoaiHang,iSoLuong ,sDonViTinh,fGiaBan,fTGBaoHanh,sDVBaoHanh)
	 VALUES ( @sMaHang,@sTenHang,@iMaNCC,@sMaLoaiHang,@iSoLuong ,@sDonViTinh,@fGiaBan,@fTGBaoHanh,@sDVBaoHanh)
 END
 GO
 create procedure spMatHang_Update
	 @sMaHang VARCHAR(20),
     @sTenHang NVARCHAR(50),
	 @iMaNCC INT,
	 @sMaLoaiHang VARCHAR(20),
	 @iSoLuong INT,
     @sDonViTinh NVARCHAR(100),
	 @fGiaBan VARCHAR(20),
	 @fTGBaoHanh INT,
	 @sDVBaoHanh NVARCHAR(20)
	  
as 
	update tblMatHang 
	set sMaHang = @sMaHang,sTenHang = @sTenHang,iMaNCC = @iMaNCC,sMaLoaiHang = @sMaLoaiHang,iSoLuong = @iSoLuong,sDonViTinh = @sDonViTinh,fGiaBan = @fGiaBan,fTGBaoHanh = @fTGBaoHanh, sDVBaoHanh = @sDVBaoHanh 
	where sMaHang = @sMaHang
GO 

 create proc SP_DELETEMH 
@sMaHang VARCHAR(20) output
as
begin
	delete from tblMatHang where sMaHang = @sMaHang
end


--Chi tiết Nhập hàng
 CREATE PROC SP_CtNhapHang 
 @iMaHD INT output,
 @sMaHang VARCHAR(20),
 @fGiaNhap INT,
 @iSoLuongNhap INT 
 AS
 BEGIN
	INSERT INTO tblChiTietNhapHang (iMaHD,sMaHang,fGiaNhap,iSoLuongNhap)
	 VALUES ( @iMaHD,@sMaHang,@fGiaNhap,@iSoLuongNhap )
 END
 GO
 CREATE procedure spCTNhapHang_Update
 @iMaHD INT,
 @sMaHang VARCHAR(20),
 @fGiaNhap INT,
 @iSoLuongNhap INT  
as 
	update tblChiTietNhapHang 
	set fGiaNhap = @fGiaNhap,iSoLuongNhap = @iSoLuongNhap  
	where iMaHD = @iMaHD
go
  

create proc SP_DELETECTNH 
@iMaHD VARCHAR(20) output
as
begin
	delete from tblChiTietNhapHang where iMaHD = @iMaHD
end
 

 --Chi Tiết Đặt Hàng
CREATE PROC SP_CTDatHang 
 @iMaHD INT output,
 @sMaHang VARCHAR(20),
 @fGiaBan INT,
 @iSoLuongMua INT ,
 @fMucGiamGia INT ,
 @dThGHetBaoHanh DATE  

 AS
 BEGIN
	INSERT INTO tblChiTietDatHang (iMaHD,sMaHang,fGiaBan,iSoLuongMua,fMucGiamGia,dThGHetBaoHanh)
	 VALUES ( @iMaHD,@sMaHang,@fGiaBan,@iSoLuongMua,@fMucGiamGia,@dThGHetBaoHanh )
 END
 GO
 CREATE procedure SP_CTDatHang_Update
 @iMaHD INT,
 @sMaHang VARCHAR(20),
 @fGiaBan INT,
 @iSoLuongMua INT ,
 @fMucGiamGia INT ,
 @dThGHetBaoHanh DATE 
as 
	update tblChiTietDatHang 
	set fGiaBan = @fGiaBan,iSoLuongMua = @iSoLuongMua, fMucGiamGia = @fMucGiamGia,dThGHetBaoHanh= @dThGHetBaoHanh
	where iMaHD = @iMaHD
go
 create proc SP_DELETEDatHang 
@iMaHD VARCHAR(20) output
as
begin
	delete from tblChiTietDatHang where iMaHD = @iMaHD
end
	  

	  select * from tblChiTietDatHang where dThGHetBaoHanh like '2021-04-20'