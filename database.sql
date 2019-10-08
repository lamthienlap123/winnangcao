USE [master]
GO
/****** Object:  Database [QLTG]    Script Date: 8/10/2019 11:58:49 PM ******/
CREATE DATABASE [QLTG]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLTG', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLTG.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLTG_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QLTG_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLTG] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTG] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTG] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTG] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTG] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTG] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTG] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLTG] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTG] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTG] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTG] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTG] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTG] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTG] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTG] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTG] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLTG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTG] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTG] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTG] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTG] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTG] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTG] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTG] SET RECOVERY FULL 
GO
ALTER DATABASE [QLTG] SET  MULTI_USER 
GO
ALTER DATABASE [QLTG] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTG] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTG] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTG] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLTG] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLTG', N'ON'
GO
USE [QLTG]
GO
/****** Object:  Table [dbo].[ChiTietPhieu]    Script Date: 8/10/2019 11:58:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieu](
	[MaDV] [varchar](10) NOT NULL,
	[MaP] [varchar](10) NOT NULL,
	[SoLuong] [float] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_ChiTietPhieu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC,
	[MaP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 8/10/2019 11:58:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MaDV] [varchar](10) NOT NULL,
	[TenDV] [nvarchar](50) NOT NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_DICHVU] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DM_MANHINH]    Script Date: 8/10/2019 11:58:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DM_MANHINH](
	[MaManHinh] [varchar](10) NOT NULL,
	[TenManHinh] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DM_MANHINH] PRIMARY KEY CLUSTERED 
(
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 8/10/2019 11:58:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[CongNo] [float] NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEU]    Script Date: 8/10/2019 11:58:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEU](
	[MaP] [varchar](10) NOT NULL,
	[TongTT] [money] NULL,
	[NgayNhan] [datetime] NULL,
	[TrangThai] [bit] NULL,
	[NgayTra] [datetime] NULL,
 CONSTRAINT [PK_PHIEU] PRIMARY KEY CLUSTERED 
(
	[MaP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QL_NGUOIDUNG]    Script Date: 8/10/2019 11:58:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QL_NGUOIDUNG](
	[TenDangNhap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NULL,
	[HoatDong] [bit] NULL,
 CONSTRAINT [PK_QL_NGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QL_NGUOIDUNGNHOMNGUOIDUNG]    Script Date: 8/10/2019 11:58:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QL_NGUOIDUNGNHOMNGUOIDUNG](
	[TenDangNhap] [varchar](50) NOT NULL,
	[MaNhom] [varchar](10) NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_QL_NGUOIDUNGNHOMNGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC,
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QL_NHOMNGUOIDUNG]    Script Date: 8/10/2019 11:58:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QL_NHOMNGUOIDUNG](
	[MaNhom] [varchar](10) NOT NULL,
	[TenNhom] [nvarchar](50) NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_QL_NHOMNGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QL_PHANQUYEN]    Script Date: 8/10/2019 11:58:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QL_PHANQUYEN](
	[MaNhom] [varchar](10) NOT NULL,
	[MaManHinh] [varchar](10) NOT NULL,
	[CoQuyen] [bit] NULL,
 CONSTRAINT [PK_QL_PHANQUYEN] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC,
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [QLTG] SET  READ_WRITE 
GO
