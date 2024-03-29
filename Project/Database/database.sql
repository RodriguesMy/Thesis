USE [POS]
GO
/****** Object:  Trigger [UpdateModifiedDateOnReceipts_History]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP TRIGGER [dbo].[UpdateModifiedDateOnReceipts_History]
GO
/****** Object:  StoredProcedure [dbo].[validateUserByIdAndPin]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[validateUserByIdAndPin]
GO
/****** Object:  StoredProcedure [dbo].[validateUser]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[validateUser]
GO
/****** Object:  StoredProcedure [dbo].[validateManager]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[validateManager]
GO
/****** Object:  StoredProcedure [dbo].[updateStaffMember]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[updateStaffMember]
GO
/****** Object:  StoredProcedure [dbo].[removeReceiptContents]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[removeReceiptContents]
GO
/****** Object:  StoredProcedure [dbo].[modifyReceipt]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[modifyReceipt]
GO
/****** Object:  StoredProcedure [dbo].[insertItemToReceipt]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[insertItemToReceipt]
GO
/****** Object:  StoredProcedure [dbo].[getWorkingMinutes]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[getWorkingMinutes]
GO
/****** Object:  StoredProcedure [dbo].[getUsers]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[getUsers]
GO
/****** Object:  StoredProcedure [dbo].[getUserName]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[getUserName]
GO
/****** Object:  StoredProcedure [dbo].[getUserId]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[getUserId]
GO
/****** Object:  StoredProcedure [dbo].[GetUserById]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[GetUserById]
GO
/****** Object:  StoredProcedure [dbo].[getRevenue]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[getRevenue]
GO
/****** Object:  StoredProcedure [dbo].[getOrders]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[getOrders]
GO
/****** Object:  StoredProcedure [dbo].[getOrderById]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[getOrderById]
GO
/****** Object:  StoredProcedure [dbo].[getJobTitles]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[getJobTitles]
GO
/****** Object:  StoredProcedure [dbo].[getItemsOfType]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[getItemsOfType]
GO
/****** Object:  StoredProcedure [dbo].[getAllUsersByCheckIn]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[getAllUsersByCheckIn]
GO
/****** Object:  StoredProcedure [dbo].[getAllTodaysOrders]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[getAllTodaysOrders]
GO
/****** Object:  StoredProcedure [dbo].[getAllStaff]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[getAllStaff]
GO
/****** Object:  StoredProcedure [dbo].[getAllItemTypes]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[getAllItemTypes]
GO
/****** Object:  StoredProcedure [dbo].[getAllItems]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[getAllItems]
GO
/****** Object:  StoredProcedure [dbo].[getAllCategories]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[getAllCategories]
GO
/****** Object:  StoredProcedure [dbo].[createStaffMember]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[createStaffMember]
GO
/****** Object:  StoredProcedure [dbo].[createReceipt]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[createReceipt]
GO
/****** Object:  StoredProcedure [dbo].[createPOSAccount]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[createPOSAccount]
GO
/****** Object:  StoredProcedure [dbo].[createManagerAccount]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[createManagerAccount]
GO
/****** Object:  StoredProcedure [dbo].[checkInOutUser]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP PROCEDURE [dbo].[checkInOutUser]
GO
ALTER TABLE [dbo].[RECEIPTS_HISTORY] DROP CONSTRAINT [FK_RECEIPTS_HISTORY_USERS]
GO
ALTER TABLE [dbo].[MANAGER_ACCOUNT] DROP CONSTRAINT [FK_MANAGER_ACCOUNT_USERS]
GO
ALTER TABLE [dbo].[ITEMS_RECEIPT_HISTORY] DROP CONSTRAINT [FK_ITEMS_RECEIPT_HISTORY_RECEIPTS_HISTORY]
GO
ALTER TABLE [dbo].[ITEMS_RECEIPT_HISTORY] DROP CONSTRAINT [FK_ITEMS_RECEIPT_HISTORY_ITEMS]
GO
ALTER TABLE [dbo].[ITEMS] DROP CONSTRAINT [FK_ITEMS_ITEM_TYPE]
GO
ALTER TABLE [dbo].[ACCOUNT] DROP CONSTRAINT [FK_ACCOUNT_USERS]
GO
ALTER TABLE [dbo].[USERS] DROP CONSTRAINT [DF_USERS_salary_per_hour]
GO
ALTER TABLE [dbo].[RECEIPTS_HISTORY] DROP CONSTRAINT [DF__RECEIPTS___datet__282DF8C2]
GO
ALTER TABLE [dbo].[RECEIPTS_HISTORY] DROP CONSTRAINT [DF__RECEIPTS___datet__2739D489]
GO
/****** Object:  Index [UQ__USERS__C16BAC14BFA71A2A]    Script Date: 29/03/2021 12:37:03 PM ******/
ALTER TABLE [dbo].[USERS] DROP CONSTRAINT [UQ__USERS__C16BAC14BFA71A2A]
GO
/****** Object:  Index [UQ__ACCOUNT__3214EC2628FE1B3E]    Script Date: 29/03/2021 12:37:03 PM ******/
ALTER TABLE [dbo].[ACCOUNT] DROP CONSTRAINT [UQ__ACCOUNT__3214EC2628FE1B3E]
GO
/****** Object:  Index [unique_password]    Script Date: 29/03/2021 12:37:03 PM ******/
ALTER TABLE [dbo].[ACCOUNT] DROP CONSTRAINT [unique_password]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 29/03/2021 12:37:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[USERS]') AND type in (N'U'))
DROP TABLE [dbo].[USERS]
GO
/****** Object:  Table [dbo].[STOCK]    Script Date: 29/03/2021 12:37:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[STOCK]') AND type in (N'U'))
DROP TABLE [dbo].[STOCK]
GO
/****** Object:  Table [dbo].[RECEIPTS_HISTORY]    Script Date: 29/03/2021 12:37:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RECEIPTS_HISTORY]') AND type in (N'U'))
DROP TABLE [dbo].[RECEIPTS_HISTORY]
GO
/****** Object:  Table [dbo].[MANAGER_ACCOUNT]    Script Date: 29/03/2021 12:37:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MANAGER_ACCOUNT]') AND type in (N'U'))
DROP TABLE [dbo].[MANAGER_ACCOUNT]
GO
/****** Object:  Table [dbo].[JOB_TITLE]    Script Date: 29/03/2021 12:37:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JOB_TITLE]') AND type in (N'U'))
DROP TABLE [dbo].[JOB_TITLE]
GO
/****** Object:  Table [dbo].[ITEMS_RECEIPT_HISTORY]    Script Date: 29/03/2021 12:37:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMS_RECEIPT_HISTORY]') AND type in (N'U'))
DROP TABLE [dbo].[ITEMS_RECEIPT_HISTORY]
GO
/****** Object:  Table [dbo].[ITEMS]    Script Date: 29/03/2021 12:37:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEMS]') AND type in (N'U'))
DROP TABLE [dbo].[ITEMS]
GO
/****** Object:  Table [dbo].[ITEM_TYPE]    Script Date: 29/03/2021 12:37:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEM_TYPE]') AND type in (N'U'))
DROP TABLE [dbo].[ITEM_TYPE]
GO
/****** Object:  Table [dbo].[ITEM_CATEGORY]    Script Date: 29/03/2021 12:37:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ITEM_CATEGORY]') AND type in (N'U'))
DROP TABLE [dbo].[ITEM_CATEGORY]
GO
/****** Object:  Table [dbo].[CHECK_IN_OUT_HISTORY]    Script Date: 29/03/2021 12:37:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CHECK_IN_OUT_HISTORY]') AND type in (N'U'))
DROP TABLE [dbo].[CHECK_IN_OUT_HISTORY]
GO
/****** Object:  Table [dbo].[ACTIVE_CHECK_IN_OUT_HISTORY]    Script Date: 29/03/2021 12:37:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ACTIVE_CHECK_IN_OUT_HISTORY]') AND type in (N'U'))
DROP TABLE [dbo].[ACTIVE_CHECK_IN_OUT_HISTORY]
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 29/03/2021 12:37:03 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ACCOUNT]') AND type in (N'U'))
DROP TABLE [dbo].[ACCOUNT]
GO
/****** Object:  Schema [NT AUTHORITY\SYSTEM]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP SCHEMA [NT AUTHORITY\SYSTEM]
GO
/****** Object:  User [NT AUTHORITY\SYSTEM]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP USER [NT AUTHORITY\SYSTEM]
GO
/****** Object:  User [rodriguez]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP USER [rodriguez]
GO
USE [master]
GO
/****** Object:  Database [POS]    Script Date: 29/03/2021 12:37:03 PM ******/
DROP DATABASE [POS]
GO
/****** Object:  Database [POS]    Script Date: 29/03/2021 12:37:03 PM ******/
CREATE DATABASE [POS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'POS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER07\MSSQL\DATA\POS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'POS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER07\MSSQL\DATA\POS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [POS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [POS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [POS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [POS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [POS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [POS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [POS] SET ARITHABORT OFF 
GO
ALTER DATABASE [POS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [POS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [POS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [POS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [POS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [POS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [POS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [POS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [POS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [POS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [POS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [POS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [POS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [POS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [POS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [POS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [POS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [POS] SET RECOVERY FULL 
GO
ALTER DATABASE [POS] SET  MULTI_USER 
GO
ALTER DATABASE [POS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [POS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [POS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [POS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [POS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [POS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'POS', N'ON'
GO
ALTER DATABASE [POS] SET QUERY_STORE = OFF
GO
USE [POS]
GO
/****** Object:  User [rodriguez]    Script Date: 29/03/2021 12:37:03 PM ******/
CREATE USER [rodriguez] FOR LOGIN [pos-client] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [NT AUTHORITY\SYSTEM]    Script Date: 29/03/2021 12:37:03 PM ******/
CREATE USER [NT AUTHORITY\SYSTEM] FOR LOGIN [NT AUTHORITY\SYSTEM] WITH DEFAULT_SCHEMA=[NT AUTHORITY\SYSTEM]
GO
/****** Object:  Schema [NT AUTHORITY\SYSTEM]    Script Date: 29/03/2021 12:37:03 PM ******/
CREATE SCHEMA [NT AUTHORITY\SYSTEM]
GO
/****** Object:  Table [dbo].[ACCOUNT]    Script Date: 29/03/2021 12:37:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCOUNT](
	[ID] [int] NOT NULL,
	[password] [int] NOT NULL,
 CONSTRAINT [PK__ACCOUNT__D4F637CAF9CB083D] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[password] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ACTIVE_CHECK_IN_OUT_HISTORY]    Script Date: 29/03/2021 12:37:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACTIVE_CHECK_IN_OUT_HISTORY](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[check_in_time] [datetime] NULL,
	[user_id] [int] NULL,
 CONSTRAINT [PK_ACTIVE_CHECK_IN_OUT_HISTORY] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHECK_IN_OUT_HISTORY]    Script Date: 29/03/2021 12:37:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHECK_IN_OUT_HISTORY](
	[user_id] [int] NOT NULL,
	[check_in_time] [datetime] NULL,
	[check_out_time] [datetime] NULL,
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_CHECK_IN_OUT_HISTORY] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ITEM_CATEGORY]    Script Date: 29/03/2021 12:37:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITEM_CATEGORY](
	[item_category] [smallint] IDENTITY(1,1) NOT NULL,
	[category_name] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ITEM_TYPE]    Script Date: 29/03/2021 12:37:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITEM_TYPE](
	[type_id] [smallint] IDENTITY(1,1) NOT NULL,
	[item_type] [nchar](10) NOT NULL,
	[item_category] [smallint] NULL,
 CONSTRAINT [PK_ITEM_TYPE] PRIMARY KEY CLUSTERED 
(
	[type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ITEMS]    Script Date: 29/03/2021 12:37:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITEMS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](50) NOT NULL,
	[price] [money] NOT NULL,
	[item_type] [smallint] NOT NULL,
	[item_category] [smallint] NULL,
 CONSTRAINT [PK_ITEMS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ITEMS_RECEIPT_HISTORY]    Script Date: 29/03/2021 12:37:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITEMS_RECEIPT_HISTORY](
	[Receipt_ID] [bigint] NULL,
	[item_id] [int] NULL,
	[qty] [smallint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JOB_TITLE]    Script Date: 29/03/2021 12:37:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JOB_TITLE](
	[job_title_id] [smallint] NOT NULL,
	[job_title] [nchar](10) NOT NULL,
 CONSTRAINT [PK_JOB_TITLE] PRIMARY KEY CLUSTERED 
(
	[job_title_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MANAGER_ACCOUNT]    Script Date: 29/03/2021 12:37:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MANAGER_ACCOUNT](
	[ID] [int] NOT NULL,
	[username] [nchar](15) NOT NULL,
	[password] [nchar](150) NOT NULL,
 CONSTRAINT [PK_MANAGER_ACCOUNT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RECEIPTS_HISTORY]    Script Date: 29/03/2021 12:37:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RECEIPTS_HISTORY](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[cashier_id] [int] NOT NULL,
	[datetime_created] [datetime] NULL,
	[datetime_updated] [datetime] NULL,
	[payment_method] [nvarchar](10) NOT NULL,
	[discount_applied] [int] NULL,
 CONSTRAINT [PK_RECEIPTS_HISTORY] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STOCK]    Script Date: 29/03/2021 12:37:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STOCK](
	[item_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_STOCK] PRIMARY KEY CLUSTERED 
(
	[item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USERS]    Script Date: 29/03/2021 12:37:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[job_title_id] [smallint] NOT NULL,
	[FName] [nchar](10) NOT NULL,
	[MName] [nchar](10) NULL,
	[LName] [nchar](10) NOT NULL,
	[personal_id] [nchar](10) NOT NULL,
	[address_no] [nchar](10) NULL,
	[postal_code] [nchar](10) NULL,
	[address_street] [nchar](10) NULL,
	[gender] [char](1) NOT NULL,
	[email] [nchar](100) NULL,
	[DOB] [nchar](20) NULL,
	[salary_per_hour] [money] NULL,
	[phone_no] [int] NULL,
	[is_active] [tinyint] NULL,
	[is_manager] [tinyint] NULL,
 CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ACCOUNT] ([ID], [password]) VALUES (1, 123)
INSERT [dbo].[ACCOUNT] ([ID], [password]) VALUES (2, 12345)
INSERT [dbo].[ACCOUNT] ([ID], [password]) VALUES (3, 1234)
GO
SET IDENTITY_INSERT [dbo].[CHECK_IN_OUT_HISTORY] ON 

INSERT [dbo].[CHECK_IN_OUT_HISTORY] ([user_id], [check_in_time], [check_out_time], [ID]) VALUES (1, CAST(N'2021-03-26T11:08:22.557' AS DateTime), CAST(N'2021-03-26T11:08:28.070' AS DateTime), 16)
INSERT [dbo].[CHECK_IN_OUT_HISTORY] ([user_id], [check_in_time], [check_out_time], [ID]) VALUES (3, CAST(N'2021-03-28T11:49:47.697' AS DateTime), CAST(N'2021-03-28T11:50:00.190' AS DateTime), 17)
INSERT [dbo].[CHECK_IN_OUT_HISTORY] ([user_id], [check_in_time], [check_out_time], [ID]) VALUES (2, CAST(N'2021-03-28T11:49:38.117' AS DateTime), CAST(N'2021-03-28T11:50:04.340' AS DateTime), 18)
INSERT [dbo].[CHECK_IN_OUT_HISTORY] ([user_id], [check_in_time], [check_out_time], [ID]) VALUES (2, CAST(N'2021-03-28T11:53:07.090' AS DateTime), CAST(N'2021-03-28T11:57:21.240' AS DateTime), 19)
INSERT [dbo].[CHECK_IN_OUT_HISTORY] ([user_id], [check_in_time], [check_out_time], [ID]) VALUES (1, CAST(N'2021-03-28T12:20:05.983' AS DateTime), CAST(N'2021-03-28T14:33:14.207' AS DateTime), 20)
SET IDENTITY_INSERT [dbo].[CHECK_IN_OUT_HISTORY] OFF
GO
SET IDENTITY_INSERT [dbo].[ITEM_CATEGORY] ON 

INSERT [dbo].[ITEM_CATEGORY] ([item_category], [category_name]) VALUES (1, N'Drinks    ')
INSERT [dbo].[ITEM_CATEGORY] ([item_category], [category_name]) VALUES (2, N'Food      ')
SET IDENTITY_INSERT [dbo].[ITEM_CATEGORY] OFF
GO
SET IDENTITY_INSERT [dbo].[ITEM_TYPE] ON 

INSERT [dbo].[ITEM_TYPE] ([type_id], [item_type], [item_category]) VALUES (1, N'Hot       ', 1)
INSERT [dbo].[ITEM_TYPE] ([type_id], [item_type], [item_category]) VALUES (2, N'Cold      ', 1)
INSERT [dbo].[ITEM_TYPE] ([type_id], [item_type], [item_category]) VALUES (3, N'Snacks    ', 2)
INSERT [dbo].[ITEM_TYPE] ([type_id], [item_type], [item_category]) VALUES (4, N'Desserts  ', 2)
SET IDENTITY_INSERT [dbo].[ITEM_TYPE] OFF
GO
SET IDENTITY_INSERT [dbo].[ITEMS] ON 

INSERT [dbo].[ITEMS] ([ID], [name], [price], [item_type], [item_category]) VALUES (1, N'Americano                                         ', 3.0000, 1, 1)
INSERT [dbo].[ITEMS] ([ID], [name], [price], [item_type], [item_category]) VALUES (2, N'Cappuccino                                        ', 3.0000, 1, 1)
INSERT [dbo].[ITEMS] ([ID], [name], [price], [item_type], [item_category]) VALUES (3, N'Macchiato                                         ', 3.0000, 1, 1)
INSERT [dbo].[ITEMS] ([ID], [name], [price], [item_type], [item_category]) VALUES (4, N'Espresso                                          ', 2.0000, 1, 1)
INSERT [dbo].[ITEMS] ([ID], [name], [price], [item_type], [item_category]) VALUES (5, N'Mocha                                             ', 4.0000, 1, 1)
INSERT [dbo].[ITEMS] ([ID], [name], [price], [item_type], [item_category]) VALUES (6, N'Iced Mocha                                        ', 4.0000, 2, 1)
INSERT [dbo].[ITEMS] ([ID], [name], [price], [item_type], [item_category]) VALUES (7, N'Freddo Espresso                                   ', 3.0000, 2, 1)
INSERT [dbo].[ITEMS] ([ID], [name], [price], [item_type], [item_category]) VALUES (8, N'Iced Chocolate                                    ', 3.0000, 2, 1)
INSERT [dbo].[ITEMS] ([ID], [name], [price], [item_type], [item_category]) VALUES (9, N'Iced Tea                                          ', 3.0000, 2, 1)
INSERT [dbo].[ITEMS] ([ID], [name], [price], [item_type], [item_category]) VALUES (10, N'Croissant                                         ', 1.2000, 3, 2)
INSERT [dbo].[ITEMS] ([ID], [name], [price], [item_type], [item_category]) VALUES (11, N'Cheese pie                                        ', 2.2000, 3, 2)
INSERT [dbo].[ITEMS] ([ID], [name], [price], [item_type], [item_category]) VALUES (12, N'Chocolate Cake                                    ', 3.2000, 4, 2)
INSERT [dbo].[ITEMS] ([ID], [name], [price], [item_type], [item_category]) VALUES (13, N'Cheese cake                                       ', 4.2000, 4, 2)
INSERT [dbo].[ITEMS] ([ID], [name], [price], [item_type], [item_category]) VALUES (14, N'Carrot cake                                       ', 4.2000, 4, 2)
SET IDENTITY_INSERT [dbo].[ITEMS] OFF
GO
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (18, 2, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (18, 3, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (18, 4, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (19, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (19, 2, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (20, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (20, 2, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (21, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (21, 2, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (43, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (23, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (24, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (24, 2, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (25, 1, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (26, 6, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (27, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (28, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (29, 1, 5)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (29, 2, 6)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (29, 3, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (30, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (30, 2, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (30, 3, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (31, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (31, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (32, 6, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (32, 7, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (33, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (34, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (34, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (35, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (35, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (36, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (36, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (37, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (38, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (38, 2, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (44, 6, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (44, 7, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (45, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (46, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (47, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (48, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (49, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (50, 7, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (51, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (52, 12, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (53, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (54, 13, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (55, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (56, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (57, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (58, 7, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (59, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (60, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (61, 7, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (62, 6, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (63, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (64, 7, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (65, 8, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (66, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (92, 2, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (92, 3, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (93, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (93, 2, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (112, 3, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (112, 2, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (111, 1, 3)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (115, 10, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (115, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (116, 10, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (116, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (117, 10, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (117, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (23, 2, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (40, 2, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (40, 1, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (40, 3, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (40, 4, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (40, 5, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (40, 11, 3)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (70, 7, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (41, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (71, 7, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (72, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (73, 2, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (74, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (75, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (76, 6, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (77, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (78, 6, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (79, 6, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (80, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (81, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (82, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (83, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (85, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (86, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (87, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (88, 10, 1)
GO
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (89, 6, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (90, 6, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (91, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (42, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (42, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (67, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (68, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (69, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (94, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (94, 2, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (94, 4, 3)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (94, 3, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (95, 10, 3)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (95, 11, 4)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (95, 12, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (95, 13, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (95, 1, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (95, 2, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (95, 3, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (95, 4, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (95, 5, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (95, 6, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (95, 7, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (95, 8, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (95, 9, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (96, 1, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (96, 2, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (96, 3, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (97, 10, 3)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (97, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (98, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (98, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (99, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (100, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (101, 10, 3)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (101, 11, 3)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (102, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (103, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (104, 10, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (104, 11, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (105, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (106, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (107, 1, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (107, 2, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (107, 3, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (108, 1, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (108, 2, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (108, 3, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (109, 1, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (109, 2, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (110, 1, 3)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (110, 2, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (113, 1, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (113, 2, 3)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (113, 3, 1)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (113, 4, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (114, 10, 2)
INSERT [dbo].[ITEMS_RECEIPT_HISTORY] ([Receipt_ID], [item_id], [qty]) VALUES (114, 11, 1)
GO
INSERT [dbo].[JOB_TITLE] ([job_title_id], [job_title]) VALUES (1, N'Manager   ')
INSERT [dbo].[JOB_TITLE] ([job_title_id], [job_title]) VALUES (2, N'Employee  ')
GO
INSERT [dbo].[MANAGER_ACCOUNT] ([ID], [username], [password]) VALUES (1, N'mrodrigues     ', N'D404559F602EAB6FD602AC7680DACBFAADD13630335E951F097AF3900E9DE176B6DB28512F2E000B9D04FBA5133E8B1C6E8DF59DB3A8AB9D60BE4B97CC9E81DB                      ')
INSERT [dbo].[MANAGER_ACCOUNT] ([ID], [username], [password]) VALUES (2, N'antreasa       ', N'D404559F602EAB6FD602AC7680DACBFAADD13630335E951F097AF3900E9DE176B6DB28512F2E000B9D04FBA5133E8B1C6E8DF59DB3A8AB9D60BE4B97CC9E81DB                      ')
INSERT [dbo].[MANAGER_ACCOUNT] ([ID], [username], [password]) VALUES (3, N'eleni          ', N'D404559F602EAB6FD602AC7680DACBFAADD13630335E951F097AF3900E9DE176B6DB28512F2E000B9D04FBA5133E8B1C6E8DF59DB3A8AB9D60BE4B97CC9E81DB                      ')
GO
SET IDENTITY_INSERT [dbo].[RECEIPTS_HISTORY] ON 

INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (17, 1, CAST(N'2021-03-23T13:27:51.910' AS DateTime), CAST(N'2021-03-28T15:07:21.243' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (18, 1, CAST(N'2021-03-23T14:17:34.030' AS DateTime), CAST(N'2021-03-28T15:07:21.243' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (19, 1, CAST(N'2021-03-23T14:42:56.030' AS DateTime), CAST(N'2021-03-28T15:07:21.243' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (20, 1, CAST(N'2021-03-23T14:44:44.687' AS DateTime), CAST(N'2021-03-28T15:07:21.243' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (21, 1, CAST(N'2021-03-23T14:45:39.430' AS DateTime), CAST(N'2021-03-28T15:07:21.243' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (22, 1, CAST(N'2021-03-23T14:51:31.110' AS DateTime), CAST(N'2021-03-24T12:39:23.163' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (23, 1, CAST(N'2021-03-23T14:53:49.273' AS DateTime), CAST(N'2021-03-23T14:53:49.273' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (24, 1, CAST(N'2021-03-23T15:11:31.963' AS DateTime), CAST(N'2021-03-23T15:11:31.963' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (25, 1, CAST(N'2021-03-23T15:12:18.810' AS DateTime), CAST(N'2021-03-23T15:12:18.810' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (26, 1, CAST(N'2021-03-23T15:13:00.517' AS DateTime), CAST(N'2021-03-23T15:13:00.517' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (27, 1, CAST(N'2021-03-23T15:14:04.250' AS DateTime), CAST(N'2021-03-23T15:14:04.250' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (28, 1, CAST(N'2021-03-23T15:15:55.057' AS DateTime), CAST(N'2021-03-23T15:15:55.057' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (29, 1, CAST(N'2021-03-23T19:11:04.867' AS DateTime), CAST(N'2021-03-23T19:11:04.867' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (30, 1, CAST(N'2021-03-24T10:46:00.117' AS DateTime), CAST(N'2021-03-24T10:46:00.117' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (31, 1, CAST(N'2021-03-24T10:50:49.757' AS DateTime), CAST(N'2021-03-24T10:50:49.757' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (32, 1, CAST(N'2021-03-24T10:51:25.447' AS DateTime), CAST(N'2021-03-24T10:51:25.447' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (33, 1, CAST(N'2021-03-24T10:51:42.223' AS DateTime), CAST(N'2021-03-24T10:51:42.223' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (34, 1, CAST(N'2021-03-24T10:54:24.050' AS DateTime), CAST(N'2021-03-24T10:54:24.050' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (35, 1, CAST(N'2021-03-24T10:54:40.040' AS DateTime), CAST(N'2021-03-24T10:54:40.040' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (36, 1, CAST(N'2021-03-24T10:56:46.610' AS DateTime), CAST(N'2021-03-24T10:56:46.610' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (37, 1, CAST(N'2021-03-24T10:57:19.040' AS DateTime), CAST(N'2021-03-24T10:57:19.040' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (38, 1, CAST(N'2021-03-24T11:33:35.650' AS DateTime), CAST(N'2021-03-24T11:33:35.650' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (39, 1, CAST(N'2021-03-24T13:08:25.160' AS DateTime), CAST(N'2021-03-24T13:08:25.160' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (40, 1, CAST(N'2021-03-24T13:09:45.973' AS DateTime), CAST(N'2021-03-24T15:09:11.160' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (41, 1, CAST(N'2021-03-24T15:06:04.977' AS DateTime), CAST(N'2021-03-24T15:06:04.977' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (42, 1, CAST(N'2021-03-24T16:04:14.930' AS DateTime), CAST(N'2021-03-24T16:04:49.693' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (43, 1, CAST(N'2021-03-24T16:17:40.830' AS DateTime), CAST(N'2021-03-24T16:17:40.830' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (44, 1, CAST(N'2021-03-24T16:20:13.193' AS DateTime), CAST(N'2021-03-24T16:20:13.193' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (45, 1, CAST(N'2021-03-24T16:21:09.387' AS DateTime), CAST(N'2021-03-24T16:21:09.387' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (46, 1, CAST(N'2021-03-24T16:21:42.770' AS DateTime), CAST(N'2021-03-24T16:21:42.770' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (47, 1, CAST(N'2021-03-24T16:22:05.247' AS DateTime), CAST(N'2021-03-24T16:22:05.247' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (48, 1, CAST(N'2021-03-24T16:25:22.270' AS DateTime), CAST(N'2021-03-24T16:25:22.270' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (49, 1, CAST(N'2021-03-24T16:28:30.650' AS DateTime), CAST(N'2021-03-24T16:28:30.650' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (50, 1, CAST(N'2021-03-24T16:29:24.127' AS DateTime), CAST(N'2021-03-24T16:29:24.127' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (51, 1, CAST(N'2021-03-24T16:30:22.423' AS DateTime), CAST(N'2021-03-24T16:30:22.423' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (52, 1, CAST(N'2021-03-24T16:31:27.070' AS DateTime), CAST(N'2021-03-24T16:31:27.070' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (53, 1, CAST(N'2021-03-24T16:32:17.183' AS DateTime), CAST(N'2021-03-24T16:32:17.183' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (54, 1, CAST(N'2021-03-24T16:33:31.753' AS DateTime), CAST(N'2021-03-24T16:33:31.753' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (55, 1, CAST(N'2021-03-24T16:34:46.700' AS DateTime), CAST(N'2021-03-24T16:34:46.700' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (56, 1, CAST(N'2021-03-24T16:35:14.090' AS DateTime), CAST(N'2021-03-24T16:35:14.090' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (57, 1, CAST(N'2021-03-24T16:36:04.130' AS DateTime), CAST(N'2021-03-24T16:36:04.130' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (58, 1, CAST(N'2021-03-24T16:37:26.820' AS DateTime), CAST(N'2021-03-24T16:37:26.820' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (59, 1, CAST(N'2021-03-24T16:37:58.590' AS DateTime), CAST(N'2021-03-24T16:37:58.590' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (60, 1, CAST(N'2021-03-24T16:38:36.203' AS DateTime), CAST(N'2021-03-24T16:38:36.203' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (61, 1, CAST(N'2021-03-24T16:38:56.347' AS DateTime), CAST(N'2021-03-24T16:38:56.347' AS DateTime), N'AMEX', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (62, 1, CAST(N'2021-03-24T16:40:21.553' AS DateTime), CAST(N'2021-03-24T16:40:21.553' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (63, 1, CAST(N'2021-03-24T16:40:46.717' AS DateTime), CAST(N'2021-03-24T16:40:46.717' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (64, 1, CAST(N'2021-03-24T16:41:39.450' AS DateTime), CAST(N'2021-03-24T16:41:39.450' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (65, 1, CAST(N'2021-03-24T16:42:06.903' AS DateTime), CAST(N'2021-03-24T16:42:06.903' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (66, 1, CAST(N'2021-03-24T16:42:46.390' AS DateTime), CAST(N'2021-03-24T16:42:46.390' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (67, 1, CAST(N'2021-03-24T16:51:09.670' AS DateTime), CAST(N'2021-03-24T16:51:09.670' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (68, 1, CAST(N'2021-03-24T16:51:36.110' AS DateTime), CAST(N'2021-03-24T16:51:36.110' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (69, 1, CAST(N'2021-03-24T16:52:00.410' AS DateTime), CAST(N'2021-03-24T16:52:00.410' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (70, 1, CAST(N'2021-03-24T16:58:53.680' AS DateTime), CAST(N'2021-03-24T16:58:53.680' AS DateTime), N'AMEX', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (71, 1, CAST(N'2021-03-24T17:00:11.450' AS DateTime), CAST(N'2021-03-24T17:00:11.450' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (72, 1, CAST(N'2021-03-24T17:00:53.463' AS DateTime), CAST(N'2021-03-24T17:00:53.463' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (73, 1, CAST(N'2021-03-24T17:01:59.157' AS DateTime), CAST(N'2021-03-24T17:01:59.157' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (74, 1, CAST(N'2021-03-24T17:02:24.187' AS DateTime), CAST(N'2021-03-24T17:02:24.187' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (75, 1, CAST(N'2021-03-24T17:03:36.967' AS DateTime), CAST(N'2021-03-24T17:03:36.967' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (76, 1, CAST(N'2021-03-24T17:03:59.163' AS DateTime), CAST(N'2021-03-24T17:03:59.163' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (77, 1, CAST(N'2021-03-24T17:04:51.537' AS DateTime), CAST(N'2021-03-24T17:04:51.537' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (78, 1, CAST(N'2021-03-24T17:05:15.977' AS DateTime), CAST(N'2021-03-24T17:05:15.977' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (79, 1, CAST(N'2021-03-24T17:07:14.327' AS DateTime), CAST(N'2021-03-24T17:07:14.327' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (80, 1, CAST(N'2021-03-24T17:08:25.973' AS DateTime), CAST(N'2021-03-24T17:08:25.973' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (81, 1, CAST(N'2021-03-24T17:08:46.543' AS DateTime), CAST(N'2021-03-24T17:08:46.543' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (82, 1, CAST(N'2021-03-24T17:09:21.093' AS DateTime), CAST(N'2021-03-24T17:09:21.093' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (83, 1, CAST(N'2021-03-24T17:10:18.560' AS DateTime), CAST(N'2021-03-24T17:10:18.560' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (84, 1, CAST(N'2021-03-24T17:10:43.143' AS DateTime), CAST(N'2021-03-24T17:10:43.143' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (85, 1, CAST(N'2021-03-24T17:11:12.227' AS DateTime), CAST(N'2021-03-24T17:11:12.227' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (86, 1, CAST(N'2021-03-24T17:11:36.390' AS DateTime), CAST(N'2021-03-24T17:11:36.390' AS DateTime), N'MASTER', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (87, 1, CAST(N'2021-03-24T17:12:10.220' AS DateTime), CAST(N'2021-03-24T17:12:10.220' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (88, 1, CAST(N'2021-03-24T17:12:37.713' AS DateTime), CAST(N'2021-03-24T17:12:37.713' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (89, 1, CAST(N'2021-03-24T17:14:11.643' AS DateTime), CAST(N'2021-03-24T17:14:11.643' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (90, 1, CAST(N'2021-03-24T17:14:43.207' AS DateTime), CAST(N'2021-03-24T17:14:43.207' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (91, 1, CAST(N'2021-03-24T17:15:20.907' AS DateTime), CAST(N'2021-03-24T17:15:20.907' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (92, 1, CAST(N'2021-03-26T11:07:53.473' AS DateTime), CAST(N'2021-03-26T11:07:53.473' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (93, 1, CAST(N'2021-03-26T15:14:18.747' AS DateTime), CAST(N'2021-03-26T15:14:18.747' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (94, 1, CAST(N'2021-03-26T16:59:47.383' AS DateTime), CAST(N'2021-03-26T16:59:47.383' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (95, 1, CAST(N'2021-03-26T17:01:07.107' AS DateTime), CAST(N'2021-03-26T17:01:07.107' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (96, 1, CAST(N'2021-03-26T21:04:25.100' AS DateTime), CAST(N'2021-03-26T21:04:25.100' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (97, 1, CAST(N'2021-03-26T21:07:49.043' AS DateTime), CAST(N'2021-03-26T21:07:49.043' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (98, 1, CAST(N'2021-03-26T21:09:04.150' AS DateTime), CAST(N'2021-03-26T21:09:04.150' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (99, 1, CAST(N'2021-03-26T21:13:32.223' AS DateTime), CAST(N'2021-03-26T21:13:32.223' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (100, 1, CAST(N'2021-03-26T21:15:54.187' AS DateTime), CAST(N'2021-03-26T21:15:54.187' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (101, 1, CAST(N'2021-03-26T21:16:49.380' AS DateTime), CAST(N'2021-03-26T21:16:49.380' AS DateTime), N'CASH', 50)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (102, 1, CAST(N'2021-03-26T21:20:04.873' AS DateTime), CAST(N'2021-03-26T21:20:04.873' AS DateTime), N'VISA', 50)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (103, 1, CAST(N'2021-03-26T21:23:00.170' AS DateTime), CAST(N'2021-03-26T21:23:00.170' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (104, 1, CAST(N'2021-03-26T21:23:22.300' AS DateTime), CAST(N'2021-03-26T21:23:22.300' AS DateTime), N'VISA', 50)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (105, 1, CAST(N'2021-03-26T21:24:23.430' AS DateTime), CAST(N'2021-03-26T21:24:23.430' AS DateTime), N'MASTER', 50)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (106, 1, CAST(N'2021-03-26T21:27:18.863' AS DateTime), CAST(N'2021-03-26T21:27:18.863' AS DateTime), N'VISA', 50)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (107, 1, CAST(N'2021-03-26T21:27:42.203' AS DateTime), CAST(N'2021-03-26T21:27:42.203' AS DateTime), N'CASH', 30)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (108, 1, CAST(N'2021-03-26T21:29:34.110' AS DateTime), CAST(N'2021-03-26T21:29:34.110' AS DateTime), N'CASH', 30)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (109, 1, CAST(N'2021-03-26T21:31:07.470' AS DateTime), CAST(N'2021-03-26T21:31:07.470' AS DateTime), N'CASH', 30)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (110, 1, CAST(N'2021-03-26T21:32:56.283' AS DateTime), CAST(N'2021-03-26T21:32:56.283' AS DateTime), N'CASH', 30)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (111, 1, CAST(N'2021-03-26T21:33:58.130' AS DateTime), CAST(N'2021-03-26T21:44:07.283' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (112, 1, CAST(N'2021-03-26T21:35:01.910' AS DateTime), CAST(N'2021-03-26T21:42:08.700' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (113, 1, CAST(N'2021-03-26T21:37:00.077' AS DateTime), CAST(N'2021-03-26T21:37:00.077' AS DateTime), N'CASH', 70)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (114, 1, CAST(N'2021-03-26T21:37:49.700' AS DateTime), CAST(N'2021-03-26T21:37:49.700' AS DateTime), N'VISA', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (115, 1, CAST(N'2021-03-26T21:44:32.720' AS DateTime), CAST(N'2021-03-26T21:44:32.720' AS DateTime), N'CASH', 0)
GO
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (116, 2, CAST(N'2021-03-27T15:57:38.603' AS DateTime), CAST(N'2021-03-27T15:57:38.603' AS DateTime), N'CASH', 0)
INSERT [dbo].[RECEIPTS_HISTORY] ([ID], [cashier_id], [datetime_created], [datetime_updated], [payment_method], [discount_applied]) VALUES (117, 1, CAST(N'2021-03-29T11:42:42.227' AS DateTime), CAST(N'2021-03-29T11:42:42.227' AS DateTime), N'CASH', 0)
SET IDENTITY_INSERT [dbo].[RECEIPTS_HISTORY] OFF
GO
SET IDENTITY_INSERT [dbo].[USERS] ON 

INSERT [dbo].[USERS] ([ID], [job_title_id], [FName], [MName], [LName], [personal_id], [address_no], [postal_code], [address_street], [gender], [email], [DOB], [salary_per_hour], [phone_no], [is_active], [is_manager]) VALUES (1, 1, N'Myriam    ', N'Tereza    ', N'Rodrigues ', N'980916    ', N'2         ', N'5543      ', N'Street    ', N'F', N'mrodrigues@gmail.com                                                                                ', N'02/09/1998 12:00:00 ', 10.0000, 3444323, 1, 1)
INSERT [dbo].[USERS] ([ID], [job_title_id], [FName], [MName], [LName], [personal_id], [address_no], [postal_code], [address_street], [gender], [email], [DOB], [salary_per_hour], [phone_no], [is_active], [is_manager]) VALUES (2, 1, N'Andreas   ', N'          ', N'Ioannou   ', N'432343    ', N'90        ', N'12        ', N'street    ', N'M', N'andreas@gmail.com                                                                                   ', N'02/09/1998 12:00:00 ', 5.0000, 2211563, 1, 1)
INSERT [dbo].[USERS] ([ID], [job_title_id], [FName], [MName], [LName], [personal_id], [address_no], [postal_code], [address_street], [gender], [email], [DOB], [salary_per_hour], [phone_no], [is_active], [is_manager]) VALUES (3, 2, N'Maria     ', N'Eleni     ', N'Christodou', N'12431     ', N'43        ', N'34        ', N'street    ', N'F', N'maria@gmail.com                                                                                     ', N'02/01/2001 12:00:00 ', 5.0000, 22216322, 1, 1)
SET IDENTITY_INSERT [dbo].[USERS] OFF
GO
/****** Object:  Index [unique_password]    Script Date: 29/03/2021 12:37:04 PM ******/
ALTER TABLE [dbo].[ACCOUNT] ADD  CONSTRAINT [unique_password] UNIQUE NONCLUSTERED 
(
	[password] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__ACCOUNT__3214EC2628FE1B3E]    Script Date: 29/03/2021 12:37:04 PM ******/
ALTER TABLE [dbo].[ACCOUNT] ADD UNIQUE NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__USERS__C16BAC14BFA71A2A]    Script Date: 29/03/2021 12:37:04 PM ******/
ALTER TABLE [dbo].[USERS] ADD UNIQUE NONCLUSTERED 
(
	[personal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RECEIPTS_HISTORY] ADD  CONSTRAINT [DF__RECEIPTS___datet__2739D489]  DEFAULT (getdate()) FOR [datetime_created]
GO
ALTER TABLE [dbo].[RECEIPTS_HISTORY] ADD  CONSTRAINT [DF__RECEIPTS___datet__282DF8C2]  DEFAULT (getdate()) FOR [datetime_updated]
GO
ALTER TABLE [dbo].[USERS] ADD  CONSTRAINT [DF_USERS_salary_per_hour]  DEFAULT ((0)) FOR [salary_per_hour]
GO
ALTER TABLE [dbo].[ACCOUNT]  WITH CHECK ADD  CONSTRAINT [FK_ACCOUNT_USERS] FOREIGN KEY([ID])
REFERENCES [dbo].[USERS] ([ID])
GO
ALTER TABLE [dbo].[ACCOUNT] CHECK CONSTRAINT [FK_ACCOUNT_USERS]
GO
ALTER TABLE [dbo].[ITEMS]  WITH CHECK ADD  CONSTRAINT [FK_ITEMS_ITEM_TYPE] FOREIGN KEY([item_type])
REFERENCES [dbo].[ITEM_TYPE] ([type_id])
GO
ALTER TABLE [dbo].[ITEMS] CHECK CONSTRAINT [FK_ITEMS_ITEM_TYPE]
GO
ALTER TABLE [dbo].[ITEMS_RECEIPT_HISTORY]  WITH CHECK ADD  CONSTRAINT [FK_ITEMS_RECEIPT_HISTORY_ITEMS] FOREIGN KEY([item_id])
REFERENCES [dbo].[ITEMS] ([ID])
GO
ALTER TABLE [dbo].[ITEMS_RECEIPT_HISTORY] CHECK CONSTRAINT [FK_ITEMS_RECEIPT_HISTORY_ITEMS]
GO
ALTER TABLE [dbo].[ITEMS_RECEIPT_HISTORY]  WITH CHECK ADD  CONSTRAINT [FK_ITEMS_RECEIPT_HISTORY_RECEIPTS_HISTORY] FOREIGN KEY([Receipt_ID])
REFERENCES [dbo].[RECEIPTS_HISTORY] ([ID])
GO
ALTER TABLE [dbo].[ITEMS_RECEIPT_HISTORY] CHECK CONSTRAINT [FK_ITEMS_RECEIPT_HISTORY_RECEIPTS_HISTORY]
GO
ALTER TABLE [dbo].[MANAGER_ACCOUNT]  WITH CHECK ADD  CONSTRAINT [FK_MANAGER_ACCOUNT_USERS] FOREIGN KEY([ID])
REFERENCES [dbo].[USERS] ([ID])
GO
ALTER TABLE [dbo].[MANAGER_ACCOUNT] CHECK CONSTRAINT [FK_MANAGER_ACCOUNT_USERS]
GO
ALTER TABLE [dbo].[RECEIPTS_HISTORY]  WITH CHECK ADD  CONSTRAINT [FK_RECEIPTS_HISTORY_USERS] FOREIGN KEY([cashier_id])
REFERENCES [dbo].[USERS] ([ID])
GO
ALTER TABLE [dbo].[RECEIPTS_HISTORY] CHECK CONSTRAINT [FK_RECEIPTS_HISTORY_USERS]
GO
/****** Object:  StoredProcedure [dbo].[checkInOutUser]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[checkInOutUser] @checkIn tinyint, @user_id int
AS
if @checkIn = 1
insert into dbo.active_check_in_out_history (user_id,check_in_time)
values(@user_id,CURRENT_TIMESTAMP)

if @checkIn = 0 
begin
insert into dbo.check_in_out_history (user_id,check_in_time,check_out_time)
values (@user_id,(select check_in_time from dbo.active_check_in_out_history where user_id = @user_id),CURRENT_TIMESTAMP);
delete from  dbo.active_check_in_out_history where user_id = @user_id;
end
GO
/****** Object:  StoredProcedure [dbo].[createManagerAccount]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[createManagerAccount] @id nchar(10), @username nchar(15),@password nchar(150)
as
insert into dbo.MANAGER_ACCOUNT(ID,username,password)
values ((select id from dbo.users where id = @id and is_manager = 1),@username,@password)
GO
/****** Object:  StoredProcedure [dbo].[createPOSAccount]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[createPOSAccount] @id nchar(10), @password int
as
insert into dbo.ACCOUNT (ID,password)
values ((select id from dbo.users where id = @id),@password)
GO
/****** Object:  StoredProcedure [dbo].[createReceipt]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[createReceipt] @user_id int, @payment_method nvarchar(10),@discount_applied int
AS
INSERT INTO [dbo].[RECEIPTS_HISTORY] (cashier_id,payment_method,discount_applied)
OUTPUT Inserted.ID
VALUES(@user_id,@payment_method,@discount_applied);
GO
/****** Object:  StoredProcedure [dbo].[createStaffMember]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[createStaffMember] @job_title_id smallint, @FName nchar(10), @MName nchar(10), @LName nchar(10),@personal_id nchar(10),
@address_no nchar(10), @postal_code char(10), @address_street nchar(10), @gender char(1), @email nchar(100),@DOB nchar(20), @salary_per_hour money,
@phone_no int, @is_active tinyint, @is_manager tinyint
as
INSERT INTO [dbo].[USERS]
           ([job_title_id]
           ,[FName]
           ,[MName]
           ,[LName]
           ,[personal_id]
           ,[address_no]
           ,[postal_code]
           ,[address_street]
           ,[gender]
           ,[email]
           ,[DOB]
           ,[salary_per_hour]
           ,[phone_no]
           ,[is_active]
           ,[is_manager])
     VALUES
           (@job_title_id
           ,@FName
           ,@MName
           ,@LName
           ,@personal_id
           ,@address_no
           ,@postal_code
           ,@address_street
           ,@gender
           ,@email
           ,@DOB
           ,@salary_per_hour
           ,@phone_no
           ,@is_active
           ,@is_manager)
GO
/****** Object:  StoredProcedure [dbo].[getAllCategories]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getAllCategories]
AS
SELECT * FROM dbo.ITEM_CATEGORY
GO;
GO
/****** Object:  StoredProcedure [dbo].[getAllItems]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getAllItems]
AS
SELECT * FROM dbo.ITEMS
GO;
GO
/****** Object:  StoredProcedure [dbo].[getAllItemTypes]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getAllItemTypes]
AS
SELECT * FROM dbo.ITEM_TYPE
GO
/****** Object:  StoredProcedure [dbo].[getAllStaff]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getAllStaff]
as
select * from users
GO
/****** Object:  StoredProcedure [dbo].[getAllTodaysOrders]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getAllTodaysOrders]
as
with receipts (ID) as(
select ID
from dbo.RECEIPTS_HISTORY
where CONVERT(VARCHAR(10), datetime_created, 111) = cast(getdate() as Date)
)
SELECT h.Receipt_ID,sum(i.price*h.qty) - (sum(i.price*h.qty)*r.discount_applied/100) as total
FROM receipts ID 
JOIN dbo.ITEMS_RECEIPT_HISTORY h
ON ID = h.Receipt_ID
JOIN dbo.ITEMS i
ON h.item_id = i.ID
JOIN dbo.RECEIPTS_HISTORY r
ON r.ID = h.Receipt_ID
group by h.Receipt_ID,r.discount_applied;
GO
/****** Object:  StoredProcedure [dbo].[getAllUsersByCheckIn]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getAllUsersByCheckIn] @checkIn tinyint
as
if @checkIn = 1
select user_id,FName,MName,LName
from dbo.active_check_in_out_history c
join dbo.USERS
ON dbo.USERS.ID = c.user_id

if @checkIn = 0 
select u.ID,FName,MName,LName from dbo.USERS u
left join dbo.active_check_in_out_history c on c.user_id = u.id
where c.user_id is null
GO
/****** Object:  StoredProcedure [dbo].[getItemsOfType]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getItemsOfType] @type smallint
AS
SELECT * FROM dbo.ITEMS WHERE item_type = @type
GO
/****** Object:  StoredProcedure [dbo].[getJobTitles]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getJobTitles]
as
select * from dbo.JOB_TITLE
GO
/****** Object:  StoredProcedure [dbo].[getOrderById]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getOrderById] @orderId bigint
as
select i.item_id, it.name, it.price , i.qty
from RECEIPTS_HISTORY r 
join dbo.ITEMS_RECEIPT_HISTORY i 
ON r.ID = i.Receipt_ID
JOIN dbo.ITEMS it
on it.ID = i.item_id
where r.id = @orderId
GO
/****** Object:  StoredProcedure [dbo].[getOrders]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getOrders] @from datetime, @to datetime
as
select r.ID,datetime_created,datetime_updated,payment_method,discount_applied,it.name,i.qty,it.price*i.qty as total
from dbo.RECEIPTS_HISTORY r
JOIN dbo.ITEMS_RECEIPT_HISTORY i
ON r.ID = i.Receipt_ID
JOIN dbo.ITEMS it
ON it.ID = i.item_id
where r.datetime_created > @from and r.datetime_created < @to
GO
/****** Object:  StoredProcedure [dbo].[getRevenue]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getRevenue] @from datetime, @to datetime
as
with receipts (ID) as(
select ID
from dbo.RECEIPTS_HISTORY
where datetime_created > @from and datetime_created < @to
), 
allOrders(ID,total) as
(SELECT h.Receipt_ID,sum(i.price*h.qty) - (sum(i.price*h.qty)*r.discount_applied/100)
FROM receipts ID 
JOIN dbo.ITEMS_RECEIPT_HISTORY h
ON ID = h.Receipt_ID
JOIN dbo.ITEMS i
ON h.item_id = i.ID
JOIN dbo.RECEIPTS_HISTORY r
ON r.ID = h.Receipt_ID
group by h.Receipt_ID,r.discount_applied)
select sum(allOrders.total)
from allOrders
GO
/****** Object:  StoredProcedure [dbo].[GetUserById]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetUserById] @personal_id nchar(10)
as
select * from dbo.users where ID = @personal_id
GO
/****** Object:  StoredProcedure [dbo].[getUserId]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getUserId] @pin nvarchar(50)
as
SELECT USERS.ID from dbo.USERS 
JOIN ACCOUNT
ON USERS.ID = ACCOUNT.ID
WHERE ACCOUNT.password = @pin
GO
/****** Object:  StoredProcedure [dbo].[getUserName]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getUserName] @pin nvarchar(50)
AS
SELECT FName,MName,LName from dbo.USERS 
JOIN ACCOUNT
ON USERS.ID = ACCOUNT.ID
WHERE ACCOUNT.password = @pin
GO
/****** Object:  StoredProcedure [dbo].[getUsers]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getUsers]
as
SELECT * FROM  POS.dbo.USERS;
GO
/****** Object:  StoredProcedure [dbo].[getWorkingMinutes]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE procedure [dbo].[getWorkingMinutes] @from datetime, @to datetime
	as
	select FName,MName,LName,personal_id,DATEDIFF(MINUTE, MIN(check_in_time), MAX(check_out_time)) AS working_minutes,u.salary_per_hour as salary
	from dbo.USERS u 
	join dbo.CHECK_IN_OUT_HISTORY c
	on c.user_id = u.ID
	where check_in_time > @from and check_out_time < @to
	Group by u.id,FName,MName,LName,personal_id,salary_per_hour
GO
/****** Object:  StoredProcedure [dbo].[insertItemToReceipt]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertItemToReceipt] @receipt_id bigint, @item_id int, @qty smallint
AS
INSERT INTO [dbo].[ITEMS_RECEIPT_HISTORY]
           ([Receipt_ID]
           ,[item_id]
           ,[qty])
VALUES(@receipt_id,@item_id,@qty);
GO
/****** Object:  StoredProcedure [dbo].[modifyReceipt]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modifyReceipt] @recept_id bigint,@payment_method nvarchar(10), @discount_applied int
as
update dbo.RECEIPTS_HISTORY 
set payment_method = @payment_method, 
discount_applied = @discount_applied
WHERE ID = @recept_id
GO
/****** Object:  StoredProcedure [dbo].[removeReceiptContents]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[removeReceiptContents] @recept_id bigint
as
delete from dbo.ITEMS_RECEIPT_HISTORY where Receipt_ID = @recept_id
GO
/****** Object:  StoredProcedure [dbo].[updateStaffMember]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateStaffMember] @job_title_id smallint, @FName nchar(10), @MName nchar(10), @LName nchar(10),@personal_id nchar(10),
@address_no nchar(10), @postal_code char(10), @address_street nchar(10), @gender char(1), @email nchar(100),@DOB nchar(20), @salary_per_hour money,
@phone_no int, @is_active tinyint, @is_manager tinyint
as
UPDATE [dbo].[USERS]
SET [job_title_id] = @job_title_id,
 [FName] = @FName,
 [MName] = @MName,
 [LName] = @LName,
 [personal_id] = @personal_id,
 [address_no] = @address_no,
 [postal_code] = @postal_code,
 [address_street] = @address_street,
 [gender] = @gender,
 [email] = @email,
 [DOB] = @DOB,
 [salary_per_hour] = @salary_per_hour,
 [phone_no] = @phone_no,
 [is_active] = @is_active,
 [is_manager] = @is_manager
 where personal_id = @personal_id
GO
/****** Object:  StoredProcedure [dbo].[validateManager]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE procedure [dbo].[validateManager] @username nchar(15),@password nchar(150)
	as
	select * from dbo.manager_account m
	join dbo.users u
	on u.ID = m.id
	where username = @username and password = @password and u.is_manager = 1 and u.is_active = 1;
GO
/****** Object:  StoredProcedure [dbo].[validateUser]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[validateUser] @pin int
AS
SELECT * from dbo.USERS u
JOIN dbo.ACCOUNT a
ON u.ID = a.ID
WHERE a.password = @pin and u.is_active = 1;
GO
/****** Object:  StoredProcedure [dbo].[validateUserByIdAndPin]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[validateUserByIdAndPin] @user_id int, @pin int
as
select * from dbo.account a where ID = @user_id and password = @pin
GO
/****** Object:  Trigger [dbo].[UpdateModifiedDateOnReceipts_History]    Script Date: 29/03/2021 12:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[UpdateModifiedDateOnReceipts_History]
ON [dbo].[RECEIPTS_HISTORY]
AFTER UPDATE
AS
UPDATE dbo.RECEIPTS_HISTORY
SET datetime_updated = CURRENT_TIMESTAMP
WHERE ID IN (SELECT DISTINCT ID FROM inserted);
GO
ALTER TABLE [dbo].[RECEIPTS_HISTORY] ENABLE TRIGGER [UpdateModifiedDateOnReceipts_History]
GO
USE [master]
GO
ALTER DATABASE [POS] SET  READ_WRITE 
GO
GRANT EXECUTE ON dbo.checkInOutUser TO PUBLIC
GRANT EXECUTE ON dbo.createManagerAccount TO PUBLIC
GRANT EXECUTE ON dbo.createPOSAccount TO PUBLIC
GRANT EXECUTE ON dbo.createReceipt TO PUBLIC
GRANT EXECUTE ON dbo.createStaffMember TO PUBLIC
GRANT EXECUTE ON dbo.getAllCategories TO PUBLIC
GRANT EXECUTE ON dbo.getAllItems TO PUBLIC
GRANT EXECUTE ON dbo.getAllItemTypes TO PUBLIC
GRANT EXECUTE ON dbo.getAllStaff TO PUBLIC
GRANT EXECUTE ON dbo.getAllTodaysOrders TO PUBLIC
GRANT EXECUTE ON dbo.getAllUsersByCheckIn TO PUBLIC
GRANT EXECUTE ON dbo.getItemsOfType TO PUBLIC
GRANT EXECUTE ON dbo.getJobTitles TO PUBLIC
GRANT EXECUTE ON dbo.getOrderById TO PUBLIC
GRANT EXECUTE ON dbo.getOrders TO PUBLIC
GRANT EXECUTE ON dbo.getRevenue TO PUBLIC
GRANT EXECUTE ON dbo.GetUserById TO PUBLIC
GRANT EXECUTE ON dbo.getUserId TO PUBLIC
GRANT EXECUTE ON dbo.getUserName TO PUBLIC
GRANT EXECUTE ON dbo.getUsers TO PUBLIC
GRANT EXECUTE ON dbo.getWorkingMinutes TO PUBLIC
GRANT EXECUTE ON dbo.insertItemToReceipt TO PUBLIC
GRANT EXECUTE ON dbo.modifyReceipt TO PUBLIC
GRANT EXECUTE ON dbo.removeReceiptContents TO PUBLIC
GRANT EXECUTE ON dbo.updateStaffMember TO PUBLIC
GRANT EXECUTE ON dbo.validateManager TO PUBLIC
GRANT EXECUTE ON dbo.validateUser TO PUBLIC
GRANT EXECUTE ON dbo.validateUserByIdAndPin TO PUBLIC
GO