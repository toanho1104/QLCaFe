USE [master]
GO
/****** Object:  Database [QuanLyQuanCafe]    Script Date: 8/13/2020 10:26:09 AM ******/
CREATE DATABASE [QuanLyQuanCafe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyQuanCafe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyQuanCafe.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyQuanCafe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyQuanCafe_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyQuanCafe] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyQuanCafe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyQuanCafe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyQuanCafe] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyQuanCafe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyQuanCafe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyQuanCafe] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLyQuanCafe]
GO
/****** Object:  StoredProcedure [dbo].[AddBan]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--
CREATE PROC [dbo].[AddBan]
(
	@Name NVARCHAR(100)
)
AS
	INSERT INTO Ban(Name) VALUES(@Name)

GO
/****** Object:  StoredProcedure [dbo].[AddMon]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--
CREATE PROC [dbo].[AddMon]
(
	@TenMon NVARCHAR(100),
	@GiaBan FLOAT,
	@IdThucDon INT
)
AS
	INSERT INTO Mon(TenMon,GiaBan,IdThucDon) VALUES(@TenMon,@GiaBan,@IdThucDon)

GO
/****** Object:  StoredProcedure [dbo].[AddTaiKhoan]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--
CREATE PROC [dbo].[AddTaiKhoan]
(
	@UserName VARCHAR(100),
	@FullName NVARCHAR(100),
	@MatKhau VARCHAR(1000),
	@HoatDong INT,
	@PhanQuyen INT 
)
AS
	INSERT INTO TaiKhoan(UserName,FullName,MatKhau,HoatDong,PhanQuyen) VALUES(@UserName,@FullName,@MatKhau,@HoatDong,@PhanQuyen)

GO
/****** Object:  StoredProcedure [dbo].[AddThucDon]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--
CREATE PROC [dbo].[AddThucDon]
(
	@Name NVARCHAR(100)
)
AS
	INSERT INTO ThucDon(Name) VALUES(@Name)

GO
/****** Object:  StoredProcedure [dbo].[CapNhatHoaDon]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--
CREATE PROC [dbo].[CapNhatHoaDon]
(
	@Id int,
	@Time datetime,
	@TrangThai int,
	@NguoiLap varchar(100),
	@TongTien float,
	@GiamGia float
)
AS
	UPDATE HoaDon set TimeCheckOut=@Time,TrangThai=@TrangThai,NguoiLap=@NguoiLap, TongTien=@TongTien, GiamGia=@GiamGia where Id=@Id

GO
/****** Object:  StoredProcedure [dbo].[CapNhatTrangThaiBan]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--
CREATE PROC [dbo].[CapNhatTrangThaiBan]
(
	@Id INT,
	@TrangThai Nvarchar(100)
)
AS
	UPDATE BAN SET TrangThai = @TrangThai WHERE Id = @Id

GO
/****** Object:  StoredProcedure [dbo].[DeleteBan]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[DeleteBan]
(
	@Id INT
)
AS
	DELETE FROM Ban WHERE Id = @Id

GO
/****** Object:  StoredProcedure [dbo].[DeleteMon]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[DeleteMon]
(
	@Id INT
)
AS
	DELETE FROM MON WHERE Id = @Id

GO
/****** Object:  StoredProcedure [dbo].[DeleteThucDon]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[DeleteThucDon]
(
	@Id INT
)
AS
	DELETE FROM ThucDon WHERE Id = @Id

GO
/****** Object:  StoredProcedure [dbo].[GetAccountByUserName]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GetAccountByUserName]
(
	@Username NVARCHAR(100)
)
AS
	SELECT * FROM TaiKhoan WHERE UserName = @Username

GO
/****** Object:  StoredProcedure [dbo].[GetMonTheoTen]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GetMonTheoTen]
(
	@Tenmon NVARCHAR(100)
)
AS
	SELECT * FROM Mon WHERE TenMon = @Tenmon

GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
							

CREATE PROC [dbo].[Login]
(
	@Username VARCHAR(50),
	@Password VARCHAR(MAX)
)
AS
BEGIN
	IF EXISTS(SELECT * FROM TaiKhoan WHERE UserName = @Username)
	BEGIN
		SELECT * FROM TaiKhoan WHERE UserName = @Username AND MatKhau = @Password;
		RETURN 1;
	END
		RETURN 0;
END

GO
/****** Object:  StoredProcedure [dbo].[ResetPassWord]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ResetPassWord]
(
	@UserName VARCHAR(100)
)
AS
	UPDATE TaiKhoan SET MatKhau = @UserName WHERE UserName = @UserName

GO
/****** Object:  StoredProcedure [dbo].[ThongKeDoanhThu]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--
CREATE PROC [dbo].[ThongKeDoanhThu]
(
	@FromDate DATE,
	@ToDate DATE
)
AS
BEGIN
	SELECT B.Name AS [Tên bàn], HD.TongTien AS [Tổng tiền], TimeCheckIn AS[Giờ vào], TimeCheckOut AS[Giờ ra],NguoiLap AS [Người Lập], GiamGia AS[Giảm Giá]
	FROM HoaDon AS HD, Ban AS B
	WHERE TimeCheckOut >= @FromDate AND TimeCheckOut <= @ToDate AND HD.TrangThai = 1 AND B.Id = HD.IdBan
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateBan]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UpdateBan]
(
	@Id INT,
	@Name NVARCHAR(100)
)
AS
	UPDATE Ban SET Name = @Name WHERE Id = @Id

GO
/****** Object:  StoredProcedure [dbo].[UpdateMon]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UpdateMon]
(
	@Id INT,
	@TenMon NVARCHAR(100),
	@GiaBan FLOAT,
	@IdThucDon INT
)
AS
	UPDATE Mon SET TenMon = @TenMon, GiaBan = @GiaBan, IdThucDon = @IdThucDon WHERE Id = @Id

GO
/****** Object:  StoredProcedure [dbo].[UpdateTaiKhoan]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UpdateTaiKhoan]
(
	@UserName VARCHAR(100),
	@FullName NVARCHAR(100),
	@HoatDong INT,
	@PhanQuyen INT 
)
AS
	UPDATE TaiKhoan SET FullName =  @FullName, HoatDong = @HoatDong, PhanQuyen = @PhanQuyen WHERE UserName = @UserName

GO
/****** Object:  StoredProcedure [dbo].[UpdateThongTinCaNhan]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UpdateThongTinCaNhan]
(	
	@Username NVARCHAR(100), 
	@Fullname NVARCHAR(100), 
	@password NVARCHAR(100),
	@newpassword NVARCHAR(100)
)
AS
BEGIN
	DECLARE @isValid INT = 0
	SELECT @isValid = COUNT(*) FROM TaiKhoan WHERE UserName = @Username AND MatKhau = @password
	IF(@isValid = 1)
	BEGIN 
		IF(@newpassword = NULL OR @newpassword = '')
		BEGIN
			UPDATE TaiKhoan SET FullName = @Fullname WHERE UserName = @Username
		END
		ELSE
			UPDATE TaiKhoan SET FullName = @Fullname,MatKhau = @newpassword WHERE UserName = @Username
	END
END	

GO
/****** Object:  StoredProcedure [dbo].[UpdateThucDon]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UpdateThucDon]
(
	@Id INT,
	@Name NVARCHAR(100)
)
AS
	UPDATE ThucDon SET Name = @Name WHERE Id = @Id

GO
/****** Object:  StoredProcedure [dbo].[XoaHoaDonKhiXoaAllMon]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaHoaDonKhiXoaAllMon]
(
	@Id INT
)
AS
	DELETE FROM HoaDon WHERE Id = @Id

GO
/****** Object:  StoredProcedure [dbo].[XoaMonKhiOrder]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaMonKhiOrder]
(
	@IdHoaDon INT,
	@IdMon INT
)
AS
	DELETE FROM ChiTietHoaDon WHERE IdHoaDon = @IdHoaDon and IdMon = @IdMon

GO
/****** Object:  Table [dbo].[Ban]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[TrangThai] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[IdHoaDon] [int] NOT NULL,
	[IdMon] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[IdHoaDon] ASC,
	[IdMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TimeCheckIn] [datetime] NOT NULL,
	[TimeCheckOut] [datetime] NULL,
	[TrangThai] [int] NULL,
	[IdBan] [int] NULL,
	[NguoiLap] [varchar](100) NULL,
	[TongTien] [float] NULL,
	[GiamGia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mon]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenMon] [nvarchar](100) NULL,
	[GiaBan] [float] NULL,
	[IdThucDon] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[UserName] [varchar](100) NOT NULL,
	[FullName] [nvarchar](100) NULL,
	[MatKhau] [varchar](1000) NOT NULL,
	[HoatDong] [int] NULL,
	[PhanQuyen] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThucDon]    Script Date: 8/13/2020 10:26:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThucDon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Ban] ON 

INSERT [dbo].[Ban] ([Id], [Name], [TrangThai]) VALUES (1, N'Bàn 1', N'Có người')
INSERT [dbo].[Ban] ([Id], [Name], [TrangThai]) VALUES (2, N'Bàn 2', N'Trống')
INSERT [dbo].[Ban] ([Id], [Name], [TrangThai]) VALUES (3, N'Bàn 3', N'Trống')
INSERT [dbo].[Ban] ([Id], [Name], [TrangThai]) VALUES (4, N'Bàn 4', N'Trống')
INSERT [dbo].[Ban] ([Id], [Name], [TrangThai]) VALUES (5, N'Bàn 5', N'Trống')
INSERT [dbo].[Ban] ([Id], [Name], [TrangThai]) VALUES (6, N'Bàn 6', N'Trống')
INSERT [dbo].[Ban] ([Id], [Name], [TrangThai]) VALUES (7, N'Bàn 7', N'Trống')
INSERT [dbo].[Ban] ([Id], [Name], [TrangThai]) VALUES (8, N'Bàn 8', N'Trống')
INSERT [dbo].[Ban] ([Id], [Name], [TrangThai]) VALUES (14, N'Bàn 9', N'Trống')
INSERT [dbo].[Ban] ([Id], [Name], [TrangThai]) VALUES (15, N'Bàn 10', N'Trống')
INSERT [dbo].[Ban] ([Id], [Name], [TrangThai]) VALUES (17, N'Bàn 12', N'Trống')
SET IDENTITY_INSERT [dbo].[Ban] OFF
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (1, 4, 6, 58000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (2, 4, 15, 58000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (3, 4, 40, 58000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (4, 1, 3, 116000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (5, 1, 3, 116000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (5, 4, 4, 58000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (5, 7, 4, 1760000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (6, 1, 1, 116000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (6, 4, 2, 58000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (7, 1, 1, 116000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (8, 1, 1, 116000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (9, 1, 3, 116000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (10, 1, 1, 116000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (10, 6, 2, 88000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (10, 8, 1, 54000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (10, 9, 1, 490000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (10, 11, 1, 490000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (10, 12, 1, 49000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (10, 19, 3, 57000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (11, 1, 4, 116000)
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdMon], [SoLuong], [ThanhTien]) VALUES (11, 4, 2, 58000)
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([Id], [TimeCheckIn], [TimeCheckOut], [TrangThai], [IdBan], [NguoiLap], [TongTien], [GiamGia]) VALUES (1, CAST(0x0000AC1300E1F231 AS DateTime), CAST(0x0000AC1301063C2E AS DateTime), 1, 2, N'admin', 1740000, 0)
INSERT [dbo].[HoaDon] ([Id], [TimeCheckIn], [TimeCheckOut], [TrangThai], [IdBan], [NguoiLap], [TongTien], [GiamGia]) VALUES (2, CAST(0x0000AC1300E20962 AS DateTime), CAST(0x0000AC1301285346 AS DateTime), 1, 3, N'admin', 4350000, 0)
INSERT [dbo].[HoaDon] ([Id], [TimeCheckIn], [TimeCheckOut], [TrangThai], [IdBan], [NguoiLap], [TongTien], [GiamGia]) VALUES (3, CAST(0x0000AC1300E27B05 AS DateTime), CAST(0x0000AC13012854C1 AS DateTime), 1, 6, N'admin', 11600000, 0)
INSERT [dbo].[HoaDon] ([Id], [TimeCheckIn], [TimeCheckOut], [TrangThai], [IdBan], [NguoiLap], [TongTien], [GiamGia]) VALUES (4, CAST(0x0000AC1300E32A6E AS DateTime), CAST(0x0000AC1301285662 AS DateTime), 1, 8, N'admin', 870000, 0)
INSERT [dbo].[HoaDon] ([Id], [TimeCheckIn], [TimeCheckOut], [TrangThai], [IdBan], [NguoiLap], [TongTien], [GiamGia]) VALUES (5, CAST(0x0000AC13012459F6 AS DateTime), CAST(0x0000AC1301284F99 AS DateTime), 1, 2, N'admin', 3790000, 0)
INSERT [dbo].[HoaDon] ([Id], [TimeCheckIn], [TimeCheckOut], [TrangThai], [IdBan], [NguoiLap], [TongTien], [GiamGia]) VALUES (6, CAST(0x0000AC13012B2E29 AS DateTime), CAST(0x0000AC16008B0322 AS DateTime), 1, 1, N'admin', 870000, 0)
INSERT [dbo].[HoaDon] ([Id], [TimeCheckIn], [TimeCheckOut], [TrangThai], [IdBan], [NguoiLap], [TongTien], [GiamGia]) VALUES (7, CAST(0x0000AC13012B64DC AS DateTime), CAST(0x0000AC16008AE040 AS DateTime), 1, 2, N'admin', 290000, 0)
INSERT [dbo].[HoaDon] ([Id], [TimeCheckIn], [TimeCheckOut], [TrangThai], [IdBan], [NguoiLap], [TongTien], [GiamGia]) VALUES (8, CAST(0x0000AC1600816C17 AS DateTime), CAST(0x0000AC16008B293F AS DateTime), 1, 3, N'admin', 290000, 0)
INSERT [dbo].[HoaDon] ([Id], [TimeCheckIn], [TimeCheckOut], [TrangThai], [IdBan], [NguoiLap], [TongTien], [GiamGia]) VALUES (9, CAST(0x0000AC1600954B3F AS DateTime), NULL, 0, 1, NULL, NULL, NULL)
INSERT [dbo].[HoaDon] ([Id], [TimeCheckIn], [TimeCheckOut], [TrangThai], [IdBan], [NguoiLap], [TongTien], [GiamGia]) VALUES (10, CAST(0x0000AC16009F4047 AS DateTime), CAST(0x0000AC1600A11A38 AS DateTime), 1, 2, N'admin', 375000, 0)
INSERT [dbo].[HoaDon] ([Id], [TimeCheckIn], [TimeCheckOut], [TrangThai], [IdBan], [NguoiLap], [TongTien], [GiamGia]) VALUES (11, CAST(0x0000AC16009FE6B1 AS DateTime), CAST(0x0000AC1600A0EDCA AS DateTime), 1, 7, N'admin', 174000, 0)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
SET IDENTITY_INSERT [dbo].[Mon] ON 

INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (1, N'Phin Sữa Đá', 29000, 1)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (2, N'Phin Đen Đá', 29000, 1)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (3, N'Phin Đen Nóng', 29000, 1)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (4, N'Phin Sữa Nóng', 29000, 1)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (5, N'Mocha Macchiato', 59000, 1)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (6, N'Espresso', 44000, 1)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (7, N'Americano', 44000, 1)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (8, N'Latte', 54000, 1)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (9, N'Caramel Phin Freeze', 49000, 2)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (10, N'Classic Phin Freeze', 49000, 2)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (11, N'Freeze Trà Xanh', 49000, 2)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (12, N'Cookies & Cream', 49000, 2)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (13, N'Freeze Sô-cô-la', 49000, 2)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (14, N'Trà Sen Vàng', 390000, 3)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (15, N'Trà Thạch Vải', 39000, 3)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (16, N'Trà Thạch Đào', 39000, 3)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (17, N'Trà Thanh Đào', 39000, 3)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (18, N'Thịt nướng', 19000, 4)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (19, N'Xíu mại', 19000, 4)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (20, N'Gà Xé Nước Tương', 19000, 4)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (21, N'Chả lụa xá xíu', 19000, 4)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (22, N'Bánh Mousse Cacao', 29000, 5)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (23, N'Bánh Sô-cô-la Highlands', 29000, 5)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (24, N'Bánh Caramel Phô Mai', 29000, 5)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (25, N'Bánh Mousse Đào', 29000, 5)
INSERT [dbo].[Mon] ([Id], [TenMon], [GiaBan], [IdThucDon]) VALUES (26, N'111', 100, 1)
SET IDENTITY_INSERT [dbo].[Mon] OFF
INSERT [dbo].[TaiKhoan] ([UserName], [FullName], [MatKhau], [HoatDong], [PhanQuyen]) VALUES (N'admin', N'Toan Ho', N'123', 1, 1)
INSERT [dbo].[TaiKhoan] ([UserName], [FullName], [MatKhau], [HoatDong], [PhanQuyen]) VALUES (N'nv1', N'nv1', N'123', 1, 0)
INSERT [dbo].[TaiKhoan] ([UserName], [FullName], [MatKhau], [HoatDong], [PhanQuyen]) VALUES (N'tien', N'tien', N'123', 0, 0)
SET IDENTITY_INSERT [dbo].[ThucDon] ON 

INSERT [dbo].[ThucDon] ([Id], [Name]) VALUES (1, N'Freeze')
INSERT [dbo].[ThucDon] ([Id], [Name]) VALUES (2, N'Cà phê')
INSERT [dbo].[ThucDon] ([Id], [Name]) VALUES (3, N'Trà')
INSERT [dbo].[ThucDon] ([Id], [Name]) VALUES (4, N'Bánh mì')
INSERT [dbo].[ThucDon] ([Id], [Name]) VALUES (5, N'Món mới')
SET IDENTITY_INSERT [dbo].[ThucDon] OFF
ALTER TABLE [dbo].[Ban] ADD  DEFAULT (N'Trống') FOR [TrangThai]
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  DEFAULT (NULL) FOR [ThanhTien]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT (getdate()) FOR [TimeCheckIn]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT ((1)) FOR [HoatDong]
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  DEFAULT ((0)) FOR [PhanQuyen]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_IdHOADON] FOREIGN KEY([IdHoaDon])
REFERENCES [dbo].[HoaDon] ([Id])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_CTHD_IdHOADON]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_IdMON] FOREIGN KEY([IdMon])
REFERENCES [dbo].[Mon] ([Id])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_CTHD_IdMON]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_BAN] FOREIGN KEY([IdBan])
REFERENCES [dbo].[Ban] ([Id])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HOADON_BAN]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NguoiLap] FOREIGN KEY([NguoiLap])
REFERENCES [dbo].[TaiKhoan] ([UserName])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HOADON_NguoiLap]
GO
ALTER TABLE [dbo].[Mon]  WITH CHECK ADD  CONSTRAINT [FK_MON_THUCDON] FOREIGN KEY([IdThucDon])
REFERENCES [dbo].[ThucDon] ([Id])
GO
ALTER TABLE [dbo].[Mon] CHECK CONSTRAINT [FK_MON_THUCDON]
GO
USE [master]
GO
ALTER DATABASE [QuanLyQuanCafe] SET  READ_WRITE 
GO
