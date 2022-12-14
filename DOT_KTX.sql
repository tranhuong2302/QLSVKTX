CREATE DATABASE dot_ktx
GO
USE dot_ktx
GO
--NHANVIEN
CREATE TABLE NhanVien
(
    MaNhanVien varchar(15) NOT NULL,
    HoTen nvarchar(100) NOT NULL,
    NgaySinh Date NOT NULL,
    SoDienThoai varchar(15) NOT NULL,
	DiaChi nvarchar(100) NOT NULL,
    GioiTinh nvarchar(10) NOT NULL,
    CMND_CCCD varchar(20) NOT NULL,
    ChucVu nvarchar(20) NOT NULL,
	MatKhau nvarchar(20) NOT NULL,
    TrangThai nvarchar(100) NOT NULL,
    CONSTRAINT Pk_NhanVien PRIMARY KEY (MaNhanVien)
)
GO
--SINHVIEN
CREATE TABLE SinhVien
(
    MaSinhVien varchar(15) NOT NULL,
    HoTen nvarchar(100) NOT NULL,
    NgaySinh Date NOT NULL,
    GioiTinh nvarchar(10) NOT NULL,
    NamHoc int NOT NULL,
    SoDienThoai varchar(50) NOT NULL,
    DiaChi nvarchar(100) NOT NULL,
    CMND_CCCD varchar(15) NOT NULL,
	NgayLamHopDong Date NOT NULL,
    NgayKetThucHopDong Date NULL,
    MaPhong varchar(10),
    Khoa nvarchar(100) NOT NULL,
    Constraint PK_SinhVien Primary Key (MaSinhVien)
)
--TOANHA
CREATE TABLE Toa
(
	MaToa varchar(100) NOT NULL,
    TenToa nvarchar(100)  NOT NULL,
    SoPhong int NOT NULL,
    MaNguoiQuanLy varchar(15) 
    CONSTRAINT Pk_Toa PRIMARY KEY (MaToa)
)
--PHONG
CREATE TABLE Phong
(
    MaPhong varchar(10) NOT NULL,
	MaToa varchar(100),
	TenPhong nvarchar(100) not null,
    LoaiPhong nvarchar(25) NOT NULL,
	SoLuongSinhVienHienTai int NOT NULL,
	SoLuongSinhVienToiDa int NOT NULL,
	TinhTrangPhong nvarchar(100) Not NUll, 
	Constraint PK_Phong Primary Key (MaPhong)
)
--DIENNUOC
CREATE TABLE HoaDonDienNuoc
(
    MaHoaDon int IDENTITY(1,1),
	MaPhong varchar(10),
	TenHoaDon nvarchar(100) not null,
    TrangThai nvarchar(20), 
	TienDien float NOT NULL,
	TienNuoc float NOT NULL,
	NgayTao Date ,
	Constraint PK_HoaDonDienNuoc Primary Key (MaHoaDon)
)
--THIETBI
CREATE TABLE ThietBi
(
    MaThietBi int IDENTITY(1,1),
    MaPhong varchar(10),
    TenThietBi nvarchar(100) NOT NULL,
    SoLuongThietBi int NOT NULL,
    SoLuongThietBiHong int NOT NULL,
    SoLuongThietBiToiDa int NOT NULL,
    Constraint PK_ThietBi Primary Key (MaThietBi)
)
--------RANG BUOC FK--------
--TOA NHA FK
ALTER TABLE Toa  ADD CONSTRAINT 
FK_Toa_QuanLy
FOREIGN KEY (MaNguoiQuanLy) REFERENCES NhanVien(MaNhanVien)
ON UPDATE CASCADE
GO
ALTER TABLE Toa CHECK CONSTRAINT FK_Toa_QuanLy
GO
--Phong FK
ALTER TABLE Phong WITH CHECK ADD CONSTRAINT 
FK_Phong_Toa
FOREIGN KEY (MaToa) REFERENCES Toa(MaToa)
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE Phong CHECK CONSTRAINT FK_Phong_Toa
GO
--Sinh vien FK
ALTER TABLE SinhVien WITH CHECK ADD CONSTRAINT 
FK_SinhVien_Phong 
FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE SinhVien CHECK CONSTRAINT FK_SinhVien_Phong
GO
--Dien nuoc FK
ALTER TABLE HoaDonDienNuoc WITH CHECK ADD CONSTRAINT 
FK_HoaDonDienNuoc_Phong 
FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
ON DELETE CASCADE;
GO
ALTER TABLE HoaDonDienNuoc CHECK CONSTRAINT FK_HoaDonDienNuoc_Phong
GO
--ThietBi FK
ALTER TABLE ThietBi WITH CHECK ADD CONSTRAINT 
FK_ThietBi_Phong
FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
ON DELETE CASCADE;
GO
ALTER TABLE ThietBi CHECK CONSTRAINT FK_ThietBi_Phong
GO
--------Rang buoc DK ------
--CCCD_CMDN_SV DK
ALTER TABLE SinhVien WITH CHECK ADD CONSTRAINT 
CHECK_CMND_CCCD_SV CHECK ((len(CMND_CCCD)=(9)) or (len(CMND_CCCD)=(12)))
GO
--SDT_SV DK
ALTER TABLE SinhVien WITH CHECK ADD CONSTRAINT 
CHECK_SDT_SV CHECK ((len(SoDienThoai)=(10)))
GO
--NamHoc_SV DK
ALTER TABLE SinhVien WITH CHECK ADD CONSTRAINT 
CHECK_NamHocSV CHECK ((NamHoc<(5)))
GO
--CMND_CCCD_NV DK
ALTER TABLE NhanVien WITH CHECK ADD CONSTRAINT 
CHECK_CMND_CCCD_NV CHECK ((len(CMND_CCCD)=(9)) or (len(CMND_CCCD)=(12)))
GO
--SDT_NV DK
ALTER TABLE NhanVien WITH CHECK ADD CONSTRAINT 
CHECK_SDT_NV CHECK ((len(SoDienThoai)=(10)))
GO
--SoTien_HoaDonDienNuoc DK
ALTER TABLE HoaDonDienNuoc WITH CHECK ADD CONSTRAINT 
CHECK_SoTien_HoaDonDienNuoc CHECK (TienDien > 0 and TienNuoc > 0)
GO
--MATKHAU DK
--ALTER TABLE NhanVien WITH CHECK ADD CONSTRAINT 
--CHECK_MatKhau_NhanVien CHECK ((len(MatKhau)>=(8)))
--GO
--Phong -> So luong SV DK
ALTER TABLE Phong WITH CHECK ADD CONSTRAINT
CHECK_SoluongSV CHECK ((SoLuongSinhVienHienTai>=(0) AND SoLuongSinhVienToiDa<(9)))
GO
--ToaNha -> So phong DK
ALTER TABLE Toa WITH CHECK ADD CONSTRAINT
CHECK_SoPhong CHECK (SoPhong > 0)
GO


-- Check d???u
CREATE FUNCTION [dbo].[fuConvertToUnsign1] 
( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000)
AS 
BEGIN 

IF @strInput IS NULL RETURN @strInput 
IF @strInput = '' RETURN @strInput 

DECLARE @RT NVARCHAR(4000) 
DECLARE @SIGN_CHARS NCHAR(136) 
DECLARE @UNSIGN_CHARS NCHAR (136) 

SET @SIGN_CHARS = N'???????????????????????????????????????????????????????????????????????????????????? ??????????????????????????????????????????????????????????????????????????????????????????????? ???????????????????????????????????????????????????????????????????????????????????????????????? ???????????????????????????????????????????????????????????????????????????????????' +NCHAR(272)+ NCHAR(208) 
SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 

DECLARE @COUNTER int 
DECLARE @COUNTER1 int 

SET @COUNTER = 1 
WHILE (@COUNTER <=LEN(@strInput)) 
	BEGIN SET @COUNTER1 = 1 
WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
	BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
		BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
			ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK 
			END SET @COUNTER1 = @COUNTER1 +1 
		END SET @COUNTER = @COUNTER +1 
	END SET @strInput = replace(@strInput,' ','-') RETURN @strInput 
END
GO

-- ?????i m???t kh???u
CREATE PROC USP_DoiMatKhau 
@MaNhanVien VARCHAR(100), @MatKhau NVARCHAR(100), @MatKhauMoi NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.NhanVien WHERE MaNhanVien = @MaNhanVien AND MatKhau = @MatKhau
	
	IF (@isRightPass = 1)
	BEGIN
		UPDATE dbo.NhanVien SET MatKhau = @MatKhauMoi WHERE MaNhanVien = @MaNhanVien
	END
END
GO

--------INSERT--------
insert into NhanVien Values('NV01',N'Phan Hu???nh Ph??c',CAST(N'2001-04-23' AS Date),'0123456789',N'208 An D????ng V????ng, P10, Q5, HCM', N'Nam','221502791',N'Ch??? t???ch','1',N'Qu???n tr??? vi??n')
insert into NhanVien Values('NV02',N'Nguy???n Tr???n H????ng',CAST(N'2001-04-25' AS Date),'0123456789',N'208 An D????ng V????ng, P10, Q5, HCM' , N'Nam','221531242',N'Ph?? ch??? t???ch','1',N'Qu???n tr??? vi??n')
insert into NhanVien Values('NV03',N'Thu???n',CAST(N'2001-04-27' AS Date),'0123456789',N'208 An D????ng V????ng, P10, Q5, HCM', N'Nam','221512463',N'Qu???n l??','1',N'Kh??? d???ng')
insert into NhanVien Values('NV04',N'Nguy???n Th??? Ph??c',CAST(N'2001-04-27' AS Date),'0123456789',N'208 An D????ng V????ng, P10, Q5, HCM', N'N???','221512463',N'Qu???n l??','1',N'Kh??a')
GO
insert into Toa Values('A','T??a A', 3, 'NV01')
insert into Toa Values('B','T??a B' ,3 ,'NV02')
insert into Toa Values('C','T??a C' ,3 ,'NV03')
GO
insert into Phong Values('A101','A','Ph??ng A101',N'NAM', 6 , 8, N'Ho???t ?????ng')
insert into Phong Values('A102','A','Ph??ng A102',N'NAM', 6 , 8, N'Ho???t ?????ng')
insert into Phong Values('A103','A','Ph??ng A103',N'NAM', 6 , 8, N'Ho???t ?????ng')
insert into Phong Values('B101','B','Ph??ng B101',N'N???', 6 , 8, N'Ho???t ?????ng')
insert into Phong Values('B102','B','Ph??ng B102',N'N???', 6 , 8, N'Ho???t ?????ng')
insert into Phong Values('B103','B','Ph??ng B103',N'N???', 6 , 8, N'Ho???t ?????ng')
insert into Phong Values('C101','C','Ph??ng C101',N'NAM', 6 , 8, N'Ho???t ?????ng')
insert into Phong Values('C102','C','Ph??ng C102',N'NAM', 6 , 8, N'Ho???t ?????ng')
insert into Phong Values('C103','C','Ph??ng C103',N'NAM', 6 , 8, N'Ho???t ?????ng')
GO
--A101
insert into SinhVien Values('4801104000',N'Nguy???n V??n A',CAST(N'2004-04-16' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A101',N'Khoa C??ng ngh??? th??ng tin.')
insert into SinhVien Values('4801104001',N'L????ng S?? A',CAST(N'2004-04-17' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A101',N'Khoa C??ng ngh??? th??ng tin.')
insert into SinhVien Values('4801104002',N'Tr???n Th??i A',CAST(N'2004-04-18' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A101',N'Khoa C??ng ngh??? th??ng tin.')
insert into SinhVien Values('4801104003',N'Cao Tu???n A',CAST(N'2004-04-19' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A101',N'Khoa C??ng ngh??? th??ng tin.')
insert into SinhVien Values('4801104004',N'Cao K??? A',CAST(N'2004-04-19' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A101',N'Khoa C??ng ngh??? th??ng tin.')
insert into SinhVien Values('4801104005',N'L???i Tu???n A',CAST(N'2004-04-19' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A101',N'Khoa C??ng ngh??? th??ng tin.')
--A102
insert into SinhVien Values('4801104006',N'Nguy???n V??n Q',CAST(N'2004-04-16' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A102',N'Khoa C??ng ngh??? th??ng tin.')
insert into SinhVien Values('4801104007',N'L????ng S?? Q',CAST(N'2004-04-17' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A102',N'Khoa C??ng ngh??? th??ng tin.')
insert into SinhVien Values('4801104008',N'Tr???n Th??i Q',CAST(N'2004-04-18' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A102',N'Khoa C??ng ngh??? th??ng tin.')
insert into SinhVien Values('4801104009',N'Cao Tu???n Q',CAST(N'2004-04-19' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A102',N'Khoa C??ng ngh??? th??ng tin.')
insert into SinhVien Values('4801104010',N'Cao K??? Q',CAST(N'2004-04-19' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A102',N'Khoa C??ng ngh??? th??ng tin.')
insert into SinhVien Values('4801104011',N'L???i Tu???n Q',CAST(N'2004-04-19' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A102',N'Khoa C??ng ngh??? th??ng tin.')
--A102
insert into SinhVien Values('4801104012',N'Nguy???n V??n W',CAST(N'2004-04-16' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A103',N'Khoa C??ng ngh??? th??ng tin.')
insert into SinhVien Values('4801104013',N'L????ng S?? W',CAST(N'2004-04-17' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A103',N'Khoa C??ng ngh??? th??ng tin.')
insert into SinhVien Values('4801104014',N'Tr???n Th??i W',CAST(N'2004-04-18' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A103',N'Khoa C??ng ngh??? th??ng tin.')
insert into SinhVien Values('4801104015',N'Cao Tu???n W',CAST(N'2004-04-19' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A103',N'Khoa C??ng ngh??? th??ng tin.')
insert into SinhVien Values('4801104016',N'Cao K??? W',CAST(N'2004-04-19' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A103',N'Khoa C??ng ngh??? th??ng tin.')
insert into SinhVien Values('4801104017',N'L???i Tu???n W',CAST(N'2004-04-19' AS Date),N'Nam',1,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'A103',N'Khoa C??ng ngh??? th??ng tin.')
--B101
insert into SinhVien Values('4801705001',N'Nguy???n Th??? B',CAST(N'2003-04-16' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B101',N'Khoa Gi??o d???c ti???u h???c')
insert into SinhVien Values('4801705002',N'L????ng Th??? B',CAST(N'2003-04-17' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B101',N'Khoa Gi??o d???c ti???u h???c')
insert into SinhVien Values('4801705003',N'Tr???n Th??? B',CAST(N'2003-04-18' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B101',N'Khoa Gi??o d???c ti???u h???c')
insert into SinhVien Values('4801705004',N'Cao Th??? B',CAST(N'2003-04-19' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B101',N'Khoa Gi??o d???c ti???u h???c')
insert into SinhVien Values('4801705005',N'Cao Th??? B',CAST(N'2003-04-19' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B101',N'Khoa Gi??o d???c ti???u h???c')
insert into SinhVien Values('4801705006',N'L???i Th??? B',CAST(N'2003-04-19' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B101',N'Khoa Gi??o d???c ti???u h???c')
--B102
insert into SinhVien Values('4801705007',N'Nguy???n Th??? E',CAST(N'2003-04-16' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B102',N'Khoa Gi??o d???c ti???u h???c')
insert into SinhVien Values('4801705008',N'L????ng Th??? E',CAST(N'2003-04-17' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B102',N'Khoa Gi??o d???c ti???u h???c')
insert into SinhVien Values('4801705009',N'Tr???n Th??? E',CAST(N'2003-04-18' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B102',N'Khoa Gi??o d???c ti???u h???c')
insert into SinhVien Values('4801705010',N'Cao Th??? E',CAST(N'2003-04-19' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B102',N'Khoa Gi??o d???c ti???u h???c')
insert into SinhVien Values('4801705011',N'Cao Th??? E',CAST(N'2003-04-19' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B102',N'Khoa Gi??o d???c ti???u h???c')
insert into SinhVien Values('4801705012',N'L???i Th??? E',CAST(N'2003-04-19' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B102',N'Khoa Gi??o d???c ti???u h???c')
--B103
insert into SinhVien Values('4801705013',N'Nguy???n Th??? R',CAST(N'2003-04-16' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B103',N'Khoa Gi??o d???c ti???u h???c')
insert into SinhVien Values('4801705014',N'L????ng Th??? R',CAST(N'2003-04-17' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B103',N'Khoa Gi??o d???c ti???u h???c')
insert into SinhVien Values('4801705015',N'Tr???n Th??? R',CAST(N'2003-04-18' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B103',N'Khoa Gi??o d???c ti???u h???c')
insert into SinhVien Values('4801705016',N'Cao Th??? R',CAST(N'2003-04-19' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B103',N'Khoa Gi??o d???c ti???u h???c')
insert into SinhVien Values('4801705017',N'Cao Th??? R',CAST(N'2003-04-19' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B103',N'Khoa Gi??o d???c ti???u h???c')
insert into SinhVien Values('4801705018',N'L???i Th??? R',CAST(N'2003-04-19' AS Date),N'N???',2,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'B103',N'Khoa Gi??o d???c ti???u h???c')
--C101
insert into SinhVien Values('4804505001',N'Nguy???n V??n C',CAST(N'2002-04-16' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'C101',N'Khoa T??m L?? h???c')
insert into SinhVien Values('4804505002',N'L????ng S?? C',CAST(N'2002-04-17' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'C101',N'Khoa T??m L?? h???c')
insert into SinhVien Values('4804505003',N'Tr???n Th??i C',CAST(N'2002-04-18' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'c101',N'Khoa T??m L?? h???c')
insert into SinhVien Values('4804505004',N'Cao Tu???n C',CAST(N'2002-04-19' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'C101',N'Khoa T??m L?? h???c')
insert into SinhVien Values('4804505005',N'Cao K??? C',CAST(N'2002-04-19' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'C101',N'Khoa T??m L?? h???c')
insert into SinhVien Values('4804505006',N'L???i Tu???n C',CAST(N'2002-04-19' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'C101',N'Khoa T??m L?? h???c')
--C102
insert into SinhVien Values('4804505007',N'Nguy???n V??n T',CAST(N'2002-04-16' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'C102',N'Khoa T??m L?? h???c')
insert into SinhVien Values('4804505008',N'L????ng S?? T',CAST(N'2002-04-17' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'C102',N'Khoa T??m L?? h???c')
insert into SinhVien Values('4804505009',N'Tr???n Th??i T',CAST(N'2002-04-18' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'c102',N'Khoa T??m L?? h???c')
insert into SinhVien Values('4804505010',N'Cao Tu???n T',CAST(N'2002-04-19' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'C102',N'Khoa T??m L?? h???c')
insert into SinhVien Values('4804505011',N'Cao K??? T',CAST(N'2002-04-19' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'C102',N'Khoa T??m L?? h???c')
insert into SinhVien Values('4804505012',N'L???i Tu???n T',CAST(N'2002-04-19' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'C102',N'Khoa T??m L?? h???c')
--C101
insert into SinhVien Values('4804505013',N'Nguy???n V??n Y',CAST(N'2002-04-16' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'C103',N'Khoa T??m L?? h???c')
insert into SinhVien Values('4804505014',N'L????ng S?? Y',CAST(N'2002-04-17' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'C103',N'Khoa T??m L?? h???c')
insert into SinhVien Values('4804505015',N'Tr???n Th??i Y',CAST(N'2002-04-18' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'c103',N'Khoa T??m L?? h???c')
insert into SinhVien Values('4804505016',N'Cao Tu???n Y',CAST(N'2002-04-19' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'C103',N'Khoa T??m L?? h???c')
insert into SinhVien Values('4804505017',N'Cao K??? Y',CAST(N'2002-04-19' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'C103',N'Khoa T??m L?? h???c')
insert into SinhVien Values('4804505018',N'L???i Tu???n Y',CAST(N'2002-04-19' AS Date),N'Nam',3,'0367064834',N'208 An D????ng V????ng, P10, Q5, HCM','221502781',CAST(N'2022-8-16' AS Date),CAST(N'2023-2-16' AS Date),'C103',N'Khoa T??m L?? h???c')
GO
insert into HoaDonDienNuoc Values('A101',N'H??a ????n th??ng 8-A101', N'???? thanh to??n', 500, 200, CAST(N'2022-08-20' AS Date))
insert into HoaDonDienNuoc Values('A101',N'H??a ????n th??ng 9-A101', N'???? thanh to??n', 200, 350, CAST(N'2022-09-20' AS Date))
insert into HoaDonDienNuoc Values('A101',N'H??a ????n th??ng 10-A101', N'???? thanh to??n',200, 300, CAST(N'2022-10-20' AS Date))

insert into HoaDonDienNuoc Values('A102',N'H??a ????n th??ng 8-A102', N'???? thanh to??n', 500, 200,  CAST(N'2022-08-20' AS Date))
insert into HoaDonDienNuoc Values('A102',N'H??a ????n th??ng 9-A102', N'???? thanh to??n', 200, 350,  CAST(N'2022-09-20' AS Date))
insert into HoaDonDienNuoc Values('A102',N'H??a ????n th??ng 10-A102', N'???? thanh to??n',200, 300,  CAST(N'2022-10-20' AS Date))

insert into HoaDonDienNuoc Values('A103',N'H??a ????n th??ng 8-A103', N'???? thanh to??n', 500, 200,  CAST(N'2022-08-20' AS Date))
insert into HoaDonDienNuoc Values('A103',N'H??a ????n th??ng 9-A103', N'???? thanh to??n', 200, 350,  CAST(N'2022-09-20' AS Date))
insert into HoaDonDienNuoc Values('A103',N'H??a ????n th??ng 10-A103', N'???? thanh to??n',200, 300,  CAST(N'2022-10-20' AS Date))

insert into HoaDonDienNuoc Values('B101',N'H??a ????n th??ng 8-B101', N'???? thanh to??n', 500, 200,  CAST(N'2022-08-20' AS Date))
insert into HoaDonDienNuoc Values('B101',N'H??a ????n th??ng 9-B101', N'???? thanh to??n', 200, 350,  CAST(N'2022-09-20' AS Date))
insert into HoaDonDienNuoc Values('B101',N'H??a ????n th??ng 10-B101', N'???? thanh to??n',200, 300,  CAST(N'2022-10-20' AS Date))

insert into HoaDonDienNuoc Values('B102',N'H??a ????n th??ng 8-B102', N'???? thanh to??n', 500, 200,  CAST(N'2022-08-20' AS Date))
insert into HoaDonDienNuoc Values('B102',N'H??a ????n th??ng 9-B102', N'???? thanh to??n', 200, 350,  CAST(N'2022-09-20' AS Date))
insert into HoaDonDienNuoc Values('B102',N'H??a ????n th??ng 10-B102', N'???? thanh to??n',200, 300,  CAST(N'2022-10-20' AS Date))

insert into HoaDonDienNuoc Values('B103',N'H??a ????n th??ng 8-B103', N'???? thanh to??n', 500, 200,  CAST(N'2022-08-20' AS Date))
insert into HoaDonDienNuoc Values('B103',N'H??a ????n th??ng 9-B103', N'???? thanh to??n', 200, 350,  CAST(N'2022-09-20' AS Date))
insert into HoaDonDienNuoc Values('B103',N'H??a ????n th??ng 10-B103', N'???? thanh to??n',200, 300,  CAST(N'2022-10-20' AS Date))

insert into HoaDonDienNuoc Values('C101',N'H??a ????n th??ng 8-C101', N'???? thanh to??n', 500, 200,  CAST(N'2022-08-20' AS Date))
insert into HoaDonDienNuoc Values('C101',N'H??a ????n th??ng 9-C101', N'???? thanh to??n', 200, 350,  CAST(N'2022-09-20' AS Date))
insert into HoaDonDienNuoc Values('C101',N'H??a ????n th??ng 10-C101', N'???? thanh to??n',200, 300,  CAST(N'2022-10-20' AS Date))

insert into HoaDonDienNuoc Values('C102',N'H??a ????n th??ng 8-C102', N'???? thanh to??n', 500, 200,  CAST(N'2022-08-20' AS Date))
insert into HoaDonDienNuoc Values('C102',N'H??a ????n th??ng 9-C102', N'???? thanh to??n', 200, 350,  CAST(N'2022-09-20' AS Date))
insert into HoaDonDienNuoc Values('C102',N'H??a ????n th??ng 10-C102', N'???? thanh to??n',200, 300,  CAST(N'2022-10-20' AS Date))

insert into HoaDonDienNuoc Values('C103',N'H??a ????n th??ng 8-C103', N'???? thanh to??n', 500, 200,  CAST(N'2022-08-20' AS Date))
insert into HoaDonDienNuoc Values('C103',N'H??a ????n th??ng 9-C103', N'???? thanh to??n', 200, 350,  CAST(N'2022-09-20' AS Date))
insert into HoaDonDienNuoc Values('C103',N'H??a ????n th??ng 10-C103', N'???? thanh to??n',200, 300,  CAST(N'2022-10-20' AS Date))

GO
insert into ThietBi Values('A101',N'Qu???t Tr???n',3,0,3)
insert into ThietBi Values('A101',N'????n',3,0,5)
insert into ThietBi Values('A101',N'Router Wifi',1,0,1)

insert into ThietBi Values('A102',N'Qu???t Tr???n',3,0,3)
insert into ThietBi Values('A102',N'????n',3,0,5)
insert into ThietBi Values('A102',N'Router Wifi',1,0,1)

insert into ThietBi Values('A103',N'Qu???t Tr???n',3,0,3)
insert into ThietBi Values('A103',N'????n',3,0,5)
insert into ThietBi Values('A103',N'Router Wifi',1,0,1)

insert into ThietBi Values('B101',N'Qu???t Tr???n',3,0,3)
insert into ThietBi Values('B101',N'????n',3,0,5)
insert into ThietBi Values('B101',N'Router Wifi',1,0,1)

insert into ThietBi Values('B102',N'Qu???t Tr???n',3,0,3)
insert into ThietBi Values('B102',N'????n',3,0,5)
insert into ThietBi Values('B102',N'Router Wifi',1,0,1)

insert into ThietBi Values('B103',N'Qu???t Tr???n',3,0,3)
insert into ThietBi Values('B103',N'????n',3,0,5)
insert into ThietBi Values('B103',N'Router Wifi',1,0,1)

insert into ThietBi Values('C101',N'Qu???t Tr???n',3,0,3)
insert into ThietBi Values('C101',N'????n',3,0,5)
insert into ThietBi Values('C101',N'Router Wifi',1,0,1)

insert into ThietBi Values('C102',N'Qu???t Tr???n',3,0,3)
insert into ThietBi Values('C102',N'????n',3,0,5)
insert into ThietBi Values('C102',N'Router Wifi',1,0,1)

insert into ThietBi Values('C103',N'Qu???t Tr???n',3,0,3)
insert into ThietBi Values('C103',N'????n',3,0,5)
insert into ThietBi Values('C103',N'Router Wifi',1,0,1)


