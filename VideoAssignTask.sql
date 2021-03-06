USE [master]
GO
/****** Object:  Database [VideoAssignTask]    Script Date: 28/06/2021 1:12:44 AM ******/
CREATE DATABASE [VideoAssignTask]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideoAssignTask_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoAssignTask.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VideoAssignTask_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoAssignTask.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VideoAssignTask] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoAssignTask].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoAssignTask] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoAssignTask] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoAssignTask] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoAssignTask] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoAssignTask] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoAssignTask] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VideoAssignTask] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideoAssignTask] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoAssignTask] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoAssignTask] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoAssignTask] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoAssignTask] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoAssignTask] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoAssignTask] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoAssignTask] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VideoAssignTask] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoAssignTask] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoAssignTask] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoAssignTask] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoAssignTask] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoAssignTask] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideoAssignTask] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoAssignTask] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VideoAssignTask] SET  MULTI_USER 
GO
ALTER DATABASE [VideoAssignTask] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoAssignTask] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoAssignTask] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoAssignTask] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VideoAssignTask] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VideoAssignTask] SET QUERY_STORE = OFF
GO
USE [VideoAssignTask]
GO
/****** Object:  Table [dbo].[tblBooking]    Script Date: 28/06/2021 1:12:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBooking](
	[bID] [int] IDENTITY(1,1) NOT NULL,
	[vID] [varchar](50) NULL,
	[cID] [varchar](50) NULL,
	[bookingDt] [varchar](50) NULL,
	[returnDt] [varchar](50) NULL,
 CONSTRAINT [PK_tblBooking] PRIMARY KEY CLUSTERED 
(
	[bID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 28/06/2021 1:12:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomer](
	[cID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
 CONSTRAINT [PK_tblCustomer] PRIMARY KEY CLUSTERED 
(
	[cID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblVideo]    Script Date: 28/06/2021 1:12:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblVideo](
	[vID] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NULL,
	[year] [varchar](50) NULL,
	[ratting] [varchar](50) NULL,
	[copy] [varchar](50) NULL,
	[price] [varchar](50) NULL,
	[genre] [varchar](50) NULL,
	[plot] [varchar](50) NULL,
 CONSTRAINT [PK_tblVideo] PRIMARY KEY CLUSTERED 
(
	[vID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblBooking] ON 

INSERT [dbo].[tblBooking] ([bID], [vID], [cID], [bookingDt], [returnDt]) VALUES (1, N'2', N'1', N'5/22/2021', N'5/22/2021')
INSERT [dbo].[tblBooking] ([bID], [vID], [cID], [bookingDt], [returnDt]) VALUES (2, N'2', N'1', N'5/22/2021', N'5/22/2021')
SET IDENTITY_INSERT [dbo].[tblBooking] OFF
SET IDENTITY_INSERT [dbo].[tblCustomer] ON 

INSERT [dbo].[tblCustomer] ([cID], [Name], [Email], [Phone], [Address]) VALUES (2, N'AmaI', N'Aman@gmail.com', N'Aman@gmail.com', N'NZ')
SET IDENTITY_INSERT [dbo].[tblCustomer] OFF
SET IDENTITY_INSERT [dbo].[tblVideo] ON 

INSERT [dbo].[tblVideo] ([vID], [title], [year], [ratting], [copy], [price], [genre], [plot]) VALUES (1, N'Hollybood', N'3.4', N'2019', N'5', N'5', N'Lapo', N'Surya')
INSERT [dbo].[tblVideo] ([vID], [title], [year], [ratting], [copy], [price], [genre], [plot]) VALUES (2, N'Spider Man', N'4.5', N'2019', N'5', N'5', N'YTV', N'Ganesh')
SET IDENTITY_INSERT [dbo].[tblVideo] OFF
USE [master]
GO
ALTER DATABASE [VideoAssignTask] SET  READ_WRITE 
GO
