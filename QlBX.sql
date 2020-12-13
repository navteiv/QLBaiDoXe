CREATE DATABASE QuanLyBaiXe
Use QuanlyBaixe
--DROP TABLE NHANVIEN;
CREATE TABLE NHANVIEN(
MaNV VARCHAR(20) NOT NULL PRIMARY KEY,
MatKhau VARCHAR(100) NULL,
HoTen NVARCHAR(50) NULL,
CMND VARCHAR(10),
DiaChi NVARCHAR (500) NULL,
Sdt VARCHAR(20) NULL,
);
CREATE TABLE LoaiXe(
MaLoai VARCHAR(20) NOT NULL PRIMARY KEY,
LoaiXe NVARCHAR(50) NULL,
GiaTien INT NULL
);
--DROP TABLE THE;
CREATE TABLE The(
SoThe VARCHAR(20) NOT NULL PRIMARY KEY,
NgayDk DATETIME NULL,
NgayKt DATETIME NULL,
TinhTrang NVARCHAR(50) NULL
);
--DROP TABLE XERAVAO;
CREATE TABLE XeRaVao(
ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
NgayGioVao DATETIME NOT NULL,
NgayGioRa DATETIME NULL,
MaLoai VARCHAR(20) NULL,
SoThe VARCHAR(20) NULL,
MaNV VARCHAR(20) NULL,
BienSoXe VARCHAR(15) NULL,
AnhPhiaTruoc IMAGE,
TinhTrang BIT NULL,
GiaTien INT NULL
CONSTRAINT fk_nv FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV),
CONSTRAINT fk_the FOREIGN KEY (SoThe) REFERENCES THE(SoThe),
CONSTRAINT fk_loai FOREIGN KEY (MaLoai) REFERENCES LOAIXE(MaLoai)
);

CREATE proc [dbo].[XeVao]
 @NgayGioVao DATETIME =null,
 @MaLoai VARCHAR(20) =null,
 @SoThe VARCHAR(20) =null,
 @MaNV VARCHAR(20) =null, 
 @BienSoXe VARCHAR(15) =null, 
 @AnhPhiaTruoc IMAGE =null,	
 @TinhTrang BIT =null
as
INSERT INTO XERAVAO (NgayGioVao, maloai, sothe, manv, biensoxe, AnhPhiaTruoc, TinhTrang)
VALUES (@NgayGioVao,@maloai,@sothe,@manv,@biensoxe,@AnhPhiaTruoc,@TinhTrang)
GO

CREATE proc [dbo].[XeRa]
@ID int,
 @TinhTrang bit,
 @NgayGioRa datetime,
 @GiaTien int
as
UPDATE    XeRaVao
SET             NgayGioRa=@NgayGioRa, TinhTrang =@TinhTrang, GiaTien=@GiaTien where  ID =@ID
GO
CREATE proc [dbo].[GetCheckXeRa]
@sothe varchar(20)=null
as
SELECT  top 1   XeRaVao.ID, XeRaVao.AnhPhiaTruoc, XeRaVao.biensoxe, XeRaVao.sothe, LOAIXE.loaixe, LoaiXe.giatien, XeRaVao.NgayGioVao, DATEDIFF(DAY, NgayGioVao,GETDATE()) AS 'SoNgay'
FROM         XeRaVao INNER JOIN
                      LOAIXE ON XeRaVao.maloai = LOAIXE.maloai where  XeRaVao.TinhTrang=0 and  XeRaVao.sothe= @sothe
ORDER BY XeRaVao.ID DESC
GO
SELECT DATEDIFF(DAY, NgayGioVao,GETDATE()) FROM XeRaVao;
SELECT MaNV, HoTen, CMND, DiaChi, Sdt FROM NHANVIEN
SELECT count(*) FROM XeRaVao where TinhTrang = 0  and   sothe='0012833129'
Select count(*) from THE where sothe = '0012833129'

SELECT * FROM XeRaVao;
SELECT * FROM NHANVIEN;
SELECT * FROM THE;
SELECT * FROM LoaiXe
SELECT XeRaVao.NgayGioVao, XeRaVao.NgayGioRa, XeRaVao.SoThe, LOAIXE.LoaiXe, LOAIXE.GiaTien,XeRaVao.BienSoXe, XeRaVao.TinhTrang FROM XeRaVao INNER JOIN LOAIXE ON XeRaVao.maloai = LOAIXE.maloai
								WHERE SoThe = '0012833129';
SELECT XeRaVao.NgayGioVao, XeRaVao.NgayGioRa, XeRaVao.sothe, LOAIXE.loaixe, LOAIXE.giatien, XeRaVao.biensoxe, XeRaVao.TinhTrang
FROM XeRaVao INNER JOIN LOAIXE ON XeRaVao.maloai = LOAIXE.maloai 
WHERE( XeRaVao.NgayGioVao >= '2020-12-01 15:16:02'
					AND XeRaVao.NgayGioVao <= '2020-12-04 20:34:44.300')
--INSERT INTO NHANVIEN VALUES('ADMIN','','Administrator','0000000000','Security','01234567890');
--UPDATE NHANVIEN SET MaNV = 'NV000001' WHERE HoTen = 'Administrator'
SELECT COUNT(*) FROM XERAVAO WHERE NgayGioRa is NULL;
-- UPDATE XERAVAO SET NgayGioVao = '2020-12-8 18:13:41.787' WHERE BienSoXe = 'abc';

