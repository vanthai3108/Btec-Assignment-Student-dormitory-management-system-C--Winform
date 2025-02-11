USE [master]
GO
/****** Object:  Database [DormitoryManagement]    Script Date: 11/2/2020 12:30:16 PM ******/
CREATE DATABASE [DormitoryManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DormitoryManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DormitoryManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DormitoryManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DormitoryManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DormitoryManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DormitoryManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DormitoryManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DormitoryManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DormitoryManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DormitoryManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DormitoryManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [DormitoryManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DormitoryManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DormitoryManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DormitoryManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DormitoryManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DormitoryManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DormitoryManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DormitoryManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DormitoryManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DormitoryManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DormitoryManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DormitoryManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DormitoryManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DormitoryManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DormitoryManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DormitoryManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DormitoryManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DormitoryManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DormitoryManagement] SET  MULTI_USER 
GO
ALTER DATABASE [DormitoryManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DormitoryManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DormitoryManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DormitoryManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DormitoryManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DormitoryManagement] SET QUERY_STORE = OFF
GO
USE [DormitoryManagement]
GO
/****** Object:  User [thai2001]    Script Date: 11/2/2020 12:30:16 PM ******/
CREATE USER [thai2001] FOR LOGIN [thai2001] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/2/2020 12:30:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [varchar](50) NOT NULL,
	[PassWord] [varchar](1000) NULL,
	[LastName] [varchar](20) NULL,
	[FirstName] [varchar](20) NULL,
	[DateOfBirth] [date] NULL,
	[Gender] [varchar](10) NULL,
	[PhoneNumber] [int] NULL,
	[EmailAddress] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 11/2/2020 12:30:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassID] [int] NOT NULL,
	[ClassName] [varchar](200) NULL,
 CONSTRAINT [PK__Class__CB1927A010FB7987] PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contract_Manager]    Script Date: 11/2/2020 12:30:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract_Manager](
	[ContractID] [int] NOT NULL,
	[ManagerID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ManagerID] ASC,
	[ContractID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DormitoryManager]    Script Date: 11/2/2020 12:30:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DormitoryManager](
	[ManagerID] [int] NOT NULL,
	[ManagerName] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ManagerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalContract]    Script Date: 11/2/2020 12:30:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalContract](
	[ContractID] [int] NOT NULL,
	[CheckInDay] [date] NULL,
	[CheckOutDay] [date] NULL,
	[StudentID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ContractID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 11/2/2020 12:30:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomID] [int] NOT NULL,
	[RoomName] [varchar](200) NULL,
	[NumberOfBeds] [int] NULL,
	[RoomRates] [float] NULL,
	[RoomArea] [float] NULL,
 CONSTRAINT [PK__Room__32863919E620012C] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room_Manager]    Script Date: 11/2/2020 12:30:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room_Manager](
	[ManagerID] [int] NOT NULL,
	[RoomID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ManagerID] ASC,
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 11/2/2020 12:30:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [int] NOT NULL,
	[StudentName] [varchar](200) NULL,
	[Age] [int] NULL,
	[Gender] [varchar](6) NULL,
	[PhoneNumber] [int] NULL,
	[Address] [varchar](200) NULL,
	[ClassID] [int] NULL,
	[RoomID] [int] NULL,
 CONSTRAINT [PK__Student__32C52A79CFB2E458] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Contract_Manager]  WITH CHECK ADD  CONSTRAINT [FK__Contract___Contr__06CD04F7] FOREIGN KEY([ContractID])
REFERENCES [dbo].[RentalContract] ([ContractID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contract_Manager] CHECK CONSTRAINT [FK__Contract___Contr__06CD04F7]
GO
ALTER TABLE [dbo].[Contract_Manager]  WITH CHECK ADD  CONSTRAINT [FK__Contract___Manag__07C12930] FOREIGN KEY([ManagerID])
REFERENCES [dbo].[DormitoryManager] ([ManagerID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contract_Manager] CHECK CONSTRAINT [FK__Contract___Manag__07C12930]
GO
ALTER TABLE [dbo].[RentalContract]  WITH CHECK ADD  CONSTRAINT [FK__RentalCon__Stude__2C3393D0] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RentalContract] CHECK CONSTRAINT [FK__RentalCon__Stude__2C3393D0]
GO
ALTER TABLE [dbo].[Room_Manager]  WITH CHECK ADD  CONSTRAINT [FK__Room_Mana__Manag__30F848ED] FOREIGN KEY([ManagerID])
REFERENCES [dbo].[DormitoryManager] ([ManagerID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Room_Manager] CHECK CONSTRAINT [FK__Room_Mana__Manag__30F848ED]
GO
ALTER TABLE [dbo].[Room_Manager]  WITH CHECK ADD  CONSTRAINT [FK__Room_Mana__RoomI__31EC6D26] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([RoomID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Room_Manager] CHECK CONSTRAINT [FK__Room_Mana__RoomI__31EC6D26]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK__Student__ClassID__3C69FB99] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Class] ([ClassID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK__Student__ClassID__3C69FB99]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK__Student__RoomID__3D5E1FD2] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([RoomID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK__Student__RoomID__3D5E1FD2]
GO
/****** Object:  StoredProcedure [dbo].[SelectAllRoom]    Script Date: 11/2/2020 12:30:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectAllRoom]
as
Begin
SELECT*FROM Room
End

EXECUTE SelectAllRoom
EXECUTE SelectAllManager
GO
USE [master]
GO
ALTER DATABASE [DormitoryManagement] SET  READ_WRITE 
GO
