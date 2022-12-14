USE [master]
GO
/****** Object:  Database [CostingEvalution]    Script Date: 30-09-2022 7.21.18 PM ******/
CREATE DATABASE [CostingEvalution]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CostingEvalution', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS02\MSSQL\DATA\CostingEvalution.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CostingEvalution_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS02\MSSQL\DATA\CostingEvalution_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CostingEvalution] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CostingEvalution].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CostingEvalution] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CostingEvalution] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CostingEvalution] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CostingEvalution] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CostingEvalution] SET ARITHABORT OFF 
GO
ALTER DATABASE [CostingEvalution] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CostingEvalution] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CostingEvalution] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CostingEvalution] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CostingEvalution] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CostingEvalution] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CostingEvalution] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CostingEvalution] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CostingEvalution] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CostingEvalution] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CostingEvalution] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CostingEvalution] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CostingEvalution] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CostingEvalution] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CostingEvalution] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CostingEvalution] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CostingEvalution] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CostingEvalution] SET RECOVERY FULL 
GO
ALTER DATABASE [CostingEvalution] SET  MULTI_USER 
GO
ALTER DATABASE [CostingEvalution] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CostingEvalution] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CostingEvalution] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CostingEvalution] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CostingEvalution] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CostingEvalution] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [CostingEvalution] SET QUERY_STORE = OFF
GO
USE [CostingEvalution]
GO
/****** Object:  Table [dbo].[EMP_Employee]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMP_Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](100) NOT NULL,
	[EmployeeTypeID] [int] NOT NULL,
	[PricePerHour] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[CreateBy] [int] NOT NULL,
	[CreateIP] [nvarchar](50) NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
	[UpdateBy] [int] NOT NULL,
	[UpdateIP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MST_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMP_EmployeeType]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMP_EmployeeType](
	[EmployeeTypeID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeTypeName] [nvarchar](100) NOT NULL,
	[IsEmployeeTypeForNos] [bit] NOT NULL,
	[IsEmployeeTypeForHour] [bit] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[CreateBy] [int] NOT NULL,
	[CreateIP] [nvarchar](50) NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
	[UpdateBy] [int] NOT NULL,
	[UpdateIP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MST_EmployeeType] PRIMARY KEY CLUSTERED 
(
	[EmployeeTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMP_EmployeeWiseDepartment]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMP_EmployeeWiseDepartment](
	[EmployeeWiseDepartmentID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[DepartmentID] [int] NOT NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[CreateBy] [int] NOT NULL,
	[CreateIP] [nvarchar](50) NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
	[UpdateBy] [int] NOT NULL,
	[UpdateIP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MST_EmployeeWiseDepartment] PRIMARY KEY CLUSTERED 
(
	[EmployeeWiseDepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ITM_Item]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITM_Item](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](100) NOT NULL,
	[ItemTypeID] [int] NOT NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[CreateBy] [int] NOT NULL,
	[CreateIP] [nvarchar](50) NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
	[UpdateBy] [int] NOT NULL,
	[UpdateIP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MST_Item] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ITM_ItemType]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITM_ItemType](
	[ItemTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ItemTypeName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[CreateBy] [int] NOT NULL,
	[CreateIP] [nvarchar](50) NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
	[UpdateBy] [int] NOT NULL,
	[UpdateIP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MST_ItemType] PRIMARY KEY CLUSTERED 
(
	[ItemTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ITM_ItemWiseMainModel]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITM_ItemWiseMainModel](
	[ItemWiseMainModelID] [int] IDENTITY(1,1) NOT NULL,
	[ItemID] [int] NOT NULL,
	[MainModelID] [int] NOT NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[CreateBy] [int] NOT NULL,
	[CreateIP] [nvarchar](50) NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
	[UpdateBy] [int] NOT NULL,
	[UpdateIP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MST_ItemWiseMainModel] PRIMARY KEY CLUSTERED 
(
	[ItemWiseMainModelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ITM_ItemWiseOperation]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITM_ItemWiseOperation](
	[ItemWiseOperationID] [int] IDENTITY(1,1) NOT NULL,
	[ItemID] [int] NOT NULL,
	[EmployeeTypeID] [int] NOT NULL,
	[DepartmentID] [int] NULL,
	[EmployeeID] [int] NULL,
	[OperationTimeInMiniute] [int] NULL,
	[NumberOfNos] [int] NULL,
	[NumberOfEmployee] [int] NULL,
	[OperationExpense] [int] NULL,
	[Description] [nvarchar](max) NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[CreateBy] [int] NOT NULL,
	[CreateIP] [nvarchar](50) NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
	[UpdateBy] [int] NOT NULL,
	[UpdateIP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MST_ItemWiseOperation] PRIMARY KEY CLUSTERED 
(
	[ItemWiseOperationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ITM_ItemWiseRawMaterial]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITM_ItemWiseRawMaterial](
	[ItemWiseRawMaterialID] [int] IDENTITY(1,1) NOT NULL,
	[ItemID] [int] NOT NULL,
	[RawMaterialID] [int] NOT NULL,
	[RawMaterialQuantity] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[CreateBy] [int] NOT NULL,
	[CreateIP] [nvarchar](50) NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
	[UpdateBy] [int] NOT NULL,
	[UpdateIP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MST_ItemWiseRawMaterial] PRIMARY KEY CLUSTERED 
(
	[ItemWiseRawMaterialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MST_Department]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MST_Department](
	[DepartmentID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[CreateBy] [int] NOT NULL,
	[CreateIP] [nvarchar](50) NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
	[UpdateBy] [int] NOT NULL,
	[UpdateIP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MST_Department] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MST_RawMaterial]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MST_RawMaterial](
	[RawMaterialID] [int] IDENTITY(1,1) NOT NULL,
	[RawMaterialName] [nvarchar](100) NOT NULL,
	[UnitID] [int] NOT NULL,
	[RawMaterialPrice] [decimal](5, 5) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[CreateBy] [int] NOT NULL,
	[CreateIP] [nvarchar](50) NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
	[UpdateBy] [int] NOT NULL,
	[UpdateIP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MST_RawMaterial] PRIMARY KEY CLUSTERED 
(
	[RawMaterialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MST_Unit]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MST_Unit](
	[UnitID] [int] IDENTITY(1,1) NOT NULL,
	[UnitName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[CreateBy] [int] NOT NULL,
	[CreateIP] [nvarchar](50) NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
	[UpdateBy] [int] NOT NULL,
	[UpdateIP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MST_Unit] PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRD_MainModel]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRD_MainModel](
	[MainModelID] [int] IDENTITY(1,1) NOT NULL,
	[MainModelName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[CreateBy] [int] NOT NULL,
	[CreateIP] [nvarchar](50) NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
	[UpdateBy] [int] NOT NULL,
	[UpdateIP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MST_MainModel] PRIMARY KEY CLUSTERED 
(
	[MainModelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRD_MainModelWiseQuestion]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRD_MainModelWiseQuestion](
	[MainModelWiseQuestionID] [int] IDENTITY(1,1) NOT NULL,
	[MainModelID] [int] NOT NULL,
	[QuestionID] [int] NOT NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[CreateBy] [int] NOT NULL,
	[CreateIP] [nvarchar](50) NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
	[UpdateBy] [int] NOT NULL,
	[UpdateIP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MST_MainModelWiseQuestion] PRIMARY KEY CLUSTERED 
(
	[MainModelWiseQuestionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRD_Question]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRD_Question](
	[QuestionID] [int] IDENTITY(1,1) NOT NULL,
	[QuestionName] [nvarchar](500) NOT NULL,
	[ItemTypeID] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[CreateBy] [int] NOT NULL,
	[CreateIP] [nvarchar](50) NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
	[UpdateBy] [int] NOT NULL,
	[UpdateIP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MST_Question] PRIMARY KEY CLUSTERED 
(
	[QuestionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SEC_Menu]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEC_Menu](
	[MenuID] [int] IDENTITY(1,1) NOT NULL,
	[MenuName] [nvarchar](100) NOT NULL,
	[MenuImagePath] [nvarchar](250) NULL,
	[MenuURL] [nvarchar](max) NOT NULL,
	[MenuSequence] [decimal](5, 3) NOT NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[CreateBy] [int] NOT NULL,
	[CreateIP] [nvarchar](50) NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
	[UpdateBy] [int] NOT NULL,
	[UpdateIP] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MST_Menu] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SEC_User]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEC_User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[UserDisplayName] [nvarchar](100) NOT NULL,
	[UserPassword] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[CreateDateTime] [datetime] NOT NULL,
	[CreateIP] [nvarchar](100) NOT NULL,
	[CreateBy] [int] NOT NULL,
	[UpdateDateTime] [datetime] NOT NULL,
	[UpdateIP] [nvarchar](100) NOT NULL,
	[UpdateBy] [int] NOT NULL,
 CONSTRAINT [PK_MST_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SEC_UserWiseMenu]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEC_UserWiseMenu](
	[UserWiseMenuID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[MenuID] [int] NOT NULL,
 CONSTRAINT [PK_MST_UserWiseMenu] PRIMARY KEY CLUSTERED 
(
	[UserWiseMenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ITM_Item] ON 

INSERT [dbo].[ITM_Item] ([ItemID], [ItemName], [ItemTypeID], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (1, N'75" Hopper', 1, CAST(N'2022-09-30T09:57:22.777' AS DateTime), 1, N'192.168.56.1', CAST(N'2022-09-30T09:57:22.777' AS DateTime), 1, N'192.168.56.1')
SET IDENTITY_INSERT [dbo].[ITM_Item] OFF
GO
SET IDENTITY_INSERT [dbo].[ITM_ItemType] ON 

INSERT [dbo].[ITM_ItemType] ([ItemTypeID], [ItemTypeName], [Description], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (1, N'Hopper', NULL, CAST(N'2022-09-04T19:06:32.627' AS DateTime), 1, N'10.55.51.140', CAST(N'2022-09-04T19:08:58.237' AS DateTime), 1, N'10.55.51.140')
INSERT [dbo].[ITM_ItemType] ([ItemTypeID], [ItemTypeName], [Description], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (2, N'Side Frame', NULL, CAST(N'2022-09-04T19:28:47.383' AS DateTime), 1, N'10.55.51.140', CAST(N'2022-09-04T19:28:47.383' AS DateTime), 1, N'10.55.51.140')
SET IDENTITY_INSERT [dbo].[ITM_ItemType] OFF
GO
SET IDENTITY_INSERT [dbo].[ITM_ItemWiseMainModel] ON 

INSERT [dbo].[ITM_ItemWiseMainModel] ([ItemWiseMainModelID], [ItemID], [MainModelID], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (1, 1, 1, CAST(N'2022-09-30T09:57:22.777' AS DateTime), 1, N'192.168.56.1', CAST(N'2022-09-30T09:57:22.777' AS DateTime), 1, N'192.168.56.1')
INSERT [dbo].[ITM_ItemWiseMainModel] ([ItemWiseMainModelID], [ItemID], [MainModelID], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (2, 1, 2, CAST(N'2022-09-30T09:57:22.777' AS DateTime), 1, N'192.168.56.1', CAST(N'2022-09-30T09:57:22.777' AS DateTime), 1, N'192.168.56.1')
SET IDENTITY_INSERT [dbo].[ITM_ItemWiseMainModel] OFF
GO
SET IDENTITY_INSERT [dbo].[MST_Department] ON 

INSERT [dbo].[MST_Department] ([DepartmentID], [DepartmentName], [Description], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (1, N'Pain Department', N'Testing', CAST(N'2022-08-17T09:52:41.993' AS DateTime), 1, N'192.168.1.5', CAST(N'2022-08-17T09:53:12.003' AS DateTime), 1, N'192.168.1.5')
SET IDENTITY_INSERT [dbo].[MST_Department] OFF
GO
SET IDENTITY_INSERT [dbo].[MST_Unit] ON 

INSERT [dbo].[MST_Unit] ([UnitID], [UnitName], [Description], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (1, N'KG', NULL, CAST(N'2022-08-16T16:46:25.643' AS DateTime), 1, N'::1', CAST(N'2022-08-16T19:29:09.017' AS DateTime), 1, N'192.168.1.5')
INSERT [dbo].[MST_Unit] ([UnitID], [UnitName], [Description], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (2, N'NOS', NULL, CAST(N'2022-08-16T19:12:17.870' AS DateTime), 1, N'192.168.56.1', CAST(N'2022-08-16T19:29:54.103' AS DateTime), 1, N'192.168.1.5')
INSERT [dbo].[MST_Unit] ([UnitID], [UnitName], [Description], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (3, N'LTR', NULL, CAST(N'2022-08-16T19:20:58.943' AS DateTime), 1, N'192.168.1.5', CAST(N'2022-08-29T10:33:35.560' AS DateTime), 1, N'192.168.56.1')
SET IDENTITY_INSERT [dbo].[MST_Unit] OFF
GO
SET IDENTITY_INSERT [dbo].[PRD_MainModel] ON 

INSERT [dbo].[PRD_MainModel] ([MainModelID], [MainModelName], [Description], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (1, N'Test1', NULL, CAST(N'2022-09-23T15:35:13.607' AS DateTime), 1, N'192.168.11.215', CAST(N'2022-09-23T15:35:13.607' AS DateTime), 1, N'192.168.11.215')
INSERT [dbo].[PRD_MainModel] ([MainModelID], [MainModelName], [Description], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (2, N'Test2', NULL, CAST(N'2022-09-23T15:35:23.300' AS DateTime), 1, N'192.168.11.215', CAST(N'2022-09-23T15:35:23.300' AS DateTime), 1, N'192.168.11.215')
INSERT [dbo].[PRD_MainModel] ([MainModelID], [MainModelName], [Description], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (3, N'Test3', NULL, CAST(N'2022-09-22T23:08:00.363' AS DateTime), 1, N'192.168.56.1', CAST(N'2022-09-22T23:08:00.363' AS DateTime), 1, N'192.168.56.1')
INSERT [dbo].[PRD_MainModel] ([MainModelID], [MainModelName], [Description], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (4, N'Test4', NULL, CAST(N'2022-09-22T23:08:39.880' AS DateTime), 1, N'192.168.56.1', CAST(N'2022-09-22T23:08:39.880' AS DateTime), 1, N'192.168.56.1')
INSERT [dbo].[PRD_MainModel] ([MainModelID], [MainModelName], [Description], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (5, N'Test5', NULL, CAST(N'2022-09-22T23:08:56.263' AS DateTime), 1, N'192.168.56.1', CAST(N'2022-09-22T23:08:56.263' AS DateTime), 1, N'192.168.56.1')
INSERT [dbo].[PRD_MainModel] ([MainModelID], [MainModelName], [Description], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (6, N'w', NULL, CAST(N'2022-09-22T23:26:23.517' AS DateTime), 1, N'10.55.51.55', CAST(N'2022-09-22T23:26:23.517' AS DateTime), 1, N'10.55.51.55')
INSERT [dbo].[PRD_MainModel] ([MainModelID], [MainModelName], [Description], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (7, N's', NULL, CAST(N'2022-09-23T15:35:37.660' AS DateTime), 1, N'192.168.11.215', CAST(N'2022-09-23T15:35:37.660' AS DateTime), 1, N'192.168.11.215')
INSERT [dbo].[PRD_MainModel] ([MainModelID], [MainModelName], [Description], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (8, N'abc', NULL, CAST(N'2022-09-23T15:35:59.963' AS DateTime), 1, N'192.168.11.215', CAST(N'2022-09-23T15:35:59.963' AS DateTime), 1, N'192.168.11.215')
SET IDENTITY_INSERT [dbo].[PRD_MainModel] OFF
GO
SET IDENTITY_INSERT [dbo].[PRD_MainModelWiseQuestion] ON 

INSERT [dbo].[PRD_MainModelWiseQuestion] ([MainModelWiseQuestionID], [MainModelID], [QuestionID], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (1, 8, 1, CAST(N'2022-09-23T15:35:59.963' AS DateTime), 1, N'192.168.11.215', CAST(N'2022-09-23T15:35:59.963' AS DateTime), 1, N'192.168.11.215')
INSERT [dbo].[PRD_MainModelWiseQuestion] ([MainModelWiseQuestionID], [MainModelID], [QuestionID], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (2, 8, 2, CAST(N'2022-09-23T15:35:59.963' AS DateTime), 1, N'192.168.11.215', CAST(N'2022-09-23T15:35:59.963' AS DateTime), 1, N'192.168.11.215')
SET IDENTITY_INSERT [dbo].[PRD_MainModelWiseQuestion] OFF
GO
SET IDENTITY_INSERT [dbo].[PRD_Question] ON 

INSERT [dbo].[PRD_Question] ([QuestionID], [QuestionName], [ItemTypeID], [Description], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (1, N'Hopper', 1, NULL, CAST(N'2022-09-04T19:27:56.873' AS DateTime), 1, N'10.55.51.140', CAST(N'2022-09-17T18:58:41.040' AS DateTime), 1, N'192.168.1.7')
INSERT [dbo].[PRD_Question] ([QuestionID], [QuestionName], [ItemTypeID], [Description], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (2, N'Side Frame', 2, NULL, CAST(N'2022-09-09T23:42:28.870' AS DateTime), 1, N'10.55.50.84', CAST(N'2022-09-09T23:42:28.870' AS DateTime), 1, N'10.55.50.84')
SET IDENTITY_INSERT [dbo].[PRD_Question] OFF
GO
SET IDENTITY_INSERT [dbo].[SEC_Menu] ON 

INSERT [dbo].[SEC_Menu] ([MenuID], [MenuName], [MenuImagePath], [MenuURL], [MenuSequence], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (1, N'Unit', N'fa fa-key', N'../Master/MST_Unit.aspx', CAST(1.000 AS Decimal(5, 3)), CAST(N'2022-09-03T14:44:09.327' AS DateTime), 1, N'10.55.51.140', CAST(N'2022-09-09T20:59:00.127' AS DateTime), 1, N'10.55.50.84')
INSERT [dbo].[SEC_Menu] ([MenuID], [MenuName], [MenuImagePath], [MenuURL], [MenuSequence], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (2, N'Raw Material', NULL, N'../Master/MST_RawMaterial.aspx', CAST(2.000 AS Decimal(5, 3)), CAST(N'2022-09-03T20:29:47.227' AS DateTime), 1, N'10.55.51.140', CAST(N'2022-09-03T20:29:47.230' AS DateTime), 1, N'10.55.51.140')
INSERT [dbo].[SEC_Menu] ([MenuID], [MenuName], [MenuImagePath], [MenuURL], [MenuSequence], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (3, N'Department', N'fa fa-key', N'../Master/MST_Department.aspx', CAST(3.000 AS Decimal(5, 3)), CAST(N'2022-09-03T20:30:10.430' AS DateTime), 1, N'10.55.51.140', CAST(N'2022-09-03T20:30:10.430' AS DateTime), 1, N'10.55.51.140')
INSERT [dbo].[SEC_Menu] ([MenuID], [MenuName], [MenuImagePath], [MenuURL], [MenuSequence], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (4, N'Menu', NULL, N'../Security/SEC_Menu.aspx', CAST(4.000 AS Decimal(5, 3)), CAST(N'2022-09-03T20:30:39.390' AS DateTime), 1, N'10.55.51.140', CAST(N'2022-09-03T20:30:39.390' AS DateTime), 1, N'10.55.51.140')
INSERT [dbo].[SEC_Menu] ([MenuID], [MenuName], [MenuImagePath], [MenuURL], [MenuSequence], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (5, N'Menu Permission', NULL, N'../Security/SEC_MenuPermission.aspx', CAST(5.000 AS Decimal(5, 3)), CAST(N'2022-09-03T20:30:58.557' AS DateTime), 1, N'10.55.51.140', CAST(N'2022-09-03T20:30:58.557' AS DateTime), 1, N'10.55.51.140')
INSERT [dbo].[SEC_Menu] ([MenuID], [MenuName], [MenuImagePath], [MenuURL], [MenuSequence], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (6, N'Question', NULL, N'../Product/PRD_Question.aspx', CAST(6.000 AS Decimal(5, 3)), CAST(N'2022-09-04T18:30:42.040' AS DateTime), 1, N'10.55.51.140', CAST(N'2022-09-04T18:30:42.043' AS DateTime), 1, N'10.55.51.140')
INSERT [dbo].[SEC_Menu] ([MenuID], [MenuName], [MenuImagePath], [MenuURL], [MenuSequence], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (7, N'Item Type', NULL, N'../Item/ITM_ItemType.aspx', CAST(7.000 AS Decimal(5, 3)), CAST(N'2022-09-04T19:01:59.023' AS DateTime), 1, N'10.55.51.140', CAST(N'2022-09-04T19:01:59.023' AS DateTime), 1, N'10.55.51.140')
INSERT [dbo].[SEC_Menu] ([MenuID], [MenuName], [MenuImagePath], [MenuURL], [MenuSequence], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (8, N'Main Model', NULL, N'../Product/PRD_MainModel.aspx', CAST(8.000 AS Decimal(5, 3)), CAST(N'2022-09-09T22:03:20.173' AS DateTime), 1, N'10.55.50.84', CAST(N'2022-09-09T22:03:20.173' AS DateTime), 1, N'10.55.50.84')
INSERT [dbo].[SEC_Menu] ([MenuID], [MenuName], [MenuImagePath], [MenuURL], [MenuSequence], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (10, N'Item Master', NULL, N'../Item/ITM_Item.aspx', CAST(9.000 AS Decimal(5, 3)), CAST(N'2022-09-13T11:52:06.600' AS DateTime), 2, N'192.168.19.116', CAST(N'2022-09-13T11:52:06.600' AS DateTime), 2, N'192.168.19.116')
INSERT [dbo].[SEC_Menu] ([MenuID], [MenuName], [MenuImagePath], [MenuURL], [MenuSequence], [CreateDateTime], [CreateBy], [CreateIP], [UpdateDateTime], [UpdateBy], [UpdateIP]) VALUES (11, N'User Panel', NULL, N'../Security/SEC_User.aspx', CAST(10.000 AS Decimal(5, 3)), CAST(N'2022-09-24T10:14:46.180' AS DateTime), 1, N'10.55.49.196', CAST(N'2022-09-24T10:14:46.180' AS DateTime), 1, N'10.55.49.196')
SET IDENTITY_INSERT [dbo].[SEC_Menu] OFF
GO
SET IDENTITY_INSERT [dbo].[SEC_User] ON 

INSERT [dbo].[SEC_User] ([UserID], [UserName], [UserDisplayName], [UserPassword], [Description], [CreateDateTime], [CreateIP], [CreateBy], [UpdateDateTime], [UpdateIP], [UpdateBy]) VALUES (1, N'admin', N'Admin', N'adminn', N'Admin', CAST(N'2022-08-14T19:22:46.807' AS DateTime), N'0.0.0.0', 1, CAST(N'2022-08-14T19:22:46.807' AS DateTime), N'0.0.0.0', 1)
INSERT [dbo].[SEC_User] ([UserID], [UserName], [UserDisplayName], [UserPassword], [Description], [CreateDateTime], [CreateIP], [CreateBy], [UpdateDateTime], [UpdateIP], [UpdateBy]) VALUES (2, N'md', N'Anonymous', N'adminn', NULL, CAST(N'2022-09-24T13:42:08.130' AS DateTime), N'10.55.49.196', 1, CAST(N'2022-09-24T13:42:08.130' AS DateTime), N'10.55.49.196', 1)
INSERT [dbo].[SEC_User] ([UserID], [UserName], [UserDisplayName], [UserPassword], [Description], [CreateDateTime], [CreateIP], [CreateBy], [UpdateDateTime], [UpdateIP], [UpdateBy]) VALUES (3, N'test', N'Test', N'test12', NULL, CAST(N'2022-09-24T11:08:01.480' AS DateTime), N'10.55.49.196', 1, CAST(N'2022-09-24T11:08:01.480' AS DateTime), N'10.55.49.196', 1)
SET IDENTITY_INSERT [dbo].[SEC_User] OFF
GO
SET IDENTITY_INSERT [dbo].[SEC_UserWiseMenu] ON 

INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (34, 1, 1)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (35, 1, 2)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (36, 1, 3)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (37, 1, 4)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (38, 1, 5)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (39, 1, 6)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (40, 1, 7)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (41, 1, 8)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (51, 1, 10)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (52, 2, 1)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (53, 2, 2)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (54, 2, 3)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (55, 2, 4)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (56, 2, 5)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (57, 2, 6)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (58, 2, 7)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (59, 2, 8)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (60, 2, 10)
INSERT [dbo].[SEC_UserWiseMenu] ([UserWiseMenuID], [UserID], [MenuID]) VALUES (61, 1, 11)
SET IDENTITY_INSERT [dbo].[SEC_UserWiseMenu] OFF
GO
ALTER TABLE [dbo].[EMP_Employee]  WITH CHECK ADD  CONSTRAINT [FK_MST_Employee_MST_EmployeeType] FOREIGN KEY([EmployeeTypeID])
REFERENCES [dbo].[EMP_EmployeeType] ([EmployeeTypeID])
GO
ALTER TABLE [dbo].[EMP_Employee] CHECK CONSTRAINT [FK_MST_Employee_MST_EmployeeType]
GO
ALTER TABLE [dbo].[EMP_Employee]  WITH CHECK ADD  CONSTRAINT [FK_MST_Employee_MST_User] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[EMP_Employee] CHECK CONSTRAINT [FK_MST_Employee_MST_User]
GO
ALTER TABLE [dbo].[EMP_Employee]  WITH CHECK ADD  CONSTRAINT [FK_MST_Employee_MST_User1] FOREIGN KEY([UpdateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[EMP_Employee] CHECK CONSTRAINT [FK_MST_Employee_MST_User1]
GO
ALTER TABLE [dbo].[EMP_EmployeeType]  WITH CHECK ADD  CONSTRAINT [FK_MST_EmployeeType_MST_User] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[EMP_EmployeeType] CHECK CONSTRAINT [FK_MST_EmployeeType_MST_User]
GO
ALTER TABLE [dbo].[EMP_EmployeeType]  WITH CHECK ADD  CONSTRAINT [FK_MST_EmployeeType_MST_User1] FOREIGN KEY([UpdateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[EMP_EmployeeType] CHECK CONSTRAINT [FK_MST_EmployeeType_MST_User1]
GO
ALTER TABLE [dbo].[EMP_EmployeeWiseDepartment]  WITH CHECK ADD  CONSTRAINT [FK_MST_EmployeeWiseDepartment_MST_Department] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[MST_Department] ([DepartmentID])
GO
ALTER TABLE [dbo].[EMP_EmployeeWiseDepartment] CHECK CONSTRAINT [FK_MST_EmployeeWiseDepartment_MST_Department]
GO
ALTER TABLE [dbo].[EMP_EmployeeWiseDepartment]  WITH CHECK ADD  CONSTRAINT [FK_MST_EmployeeWiseDepartment_MST_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[EMP_Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[EMP_EmployeeWiseDepartment] CHECK CONSTRAINT [FK_MST_EmployeeWiseDepartment_MST_Employee]
GO
ALTER TABLE [dbo].[EMP_EmployeeWiseDepartment]  WITH CHECK ADD  CONSTRAINT [FK_MST_EmployeeWiseDepartment_MST_User] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[EMP_EmployeeWiseDepartment] CHECK CONSTRAINT [FK_MST_EmployeeWiseDepartment_MST_User]
GO
ALTER TABLE [dbo].[EMP_EmployeeWiseDepartment]  WITH CHECK ADD  CONSTRAINT [FK_MST_EmployeeWiseDepartment_MST_User1] FOREIGN KEY([UpdateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[EMP_EmployeeWiseDepartment] CHECK CONSTRAINT [FK_MST_EmployeeWiseDepartment_MST_User1]
GO
ALTER TABLE [dbo].[ITM_Item]  WITH CHECK ADD  CONSTRAINT [FK_MST_Item_MST_ItemType] FOREIGN KEY([ItemTypeID])
REFERENCES [dbo].[ITM_ItemType] ([ItemTypeID])
GO
ALTER TABLE [dbo].[ITM_Item] CHECK CONSTRAINT [FK_MST_Item_MST_ItemType]
GO
ALTER TABLE [dbo].[ITM_Item]  WITH CHECK ADD  CONSTRAINT [FK_MST_Item_MST_User] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[ITM_Item] CHECK CONSTRAINT [FK_MST_Item_MST_User]
GO
ALTER TABLE [dbo].[ITM_Item]  WITH CHECK ADD  CONSTRAINT [FK_MST_Item_MST_User1] FOREIGN KEY([UpdateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[ITM_Item] CHECK CONSTRAINT [FK_MST_Item_MST_User1]
GO
ALTER TABLE [dbo].[ITM_ItemType]  WITH CHECK ADD  CONSTRAINT [FK_MST_ItemType_MST_User] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[ITM_ItemType] CHECK CONSTRAINT [FK_MST_ItemType_MST_User]
GO
ALTER TABLE [dbo].[ITM_ItemType]  WITH CHECK ADD  CONSTRAINT [FK_MST_ItemType_MST_User1] FOREIGN KEY([UpdateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[ITM_ItemType] CHECK CONSTRAINT [FK_MST_ItemType_MST_User1]
GO
ALTER TABLE [dbo].[ITM_ItemWiseMainModel]  WITH CHECK ADD  CONSTRAINT [FK_MST_ItemWiseMainModel_MST_Item] FOREIGN KEY([ItemID])
REFERENCES [dbo].[ITM_Item] ([ItemID])
GO
ALTER TABLE [dbo].[ITM_ItemWiseMainModel] CHECK CONSTRAINT [FK_MST_ItemWiseMainModel_MST_Item]
GO
ALTER TABLE [dbo].[ITM_ItemWiseMainModel]  WITH CHECK ADD  CONSTRAINT [FK_MST_ItemWiseMainModel_MST_MainModel] FOREIGN KEY([MainModelID])
REFERENCES [dbo].[PRD_MainModel] ([MainModelID])
GO
ALTER TABLE [dbo].[ITM_ItemWiseMainModel] CHECK CONSTRAINT [FK_MST_ItemWiseMainModel_MST_MainModel]
GO
ALTER TABLE [dbo].[ITM_ItemWiseMainModel]  WITH CHECK ADD  CONSTRAINT [FK_MST_ItemWiseMainModel_MST_User] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[ITM_ItemWiseMainModel] CHECK CONSTRAINT [FK_MST_ItemWiseMainModel_MST_User]
GO
ALTER TABLE [dbo].[ITM_ItemWiseMainModel]  WITH CHECK ADD  CONSTRAINT [FK_MST_ItemWiseMainModel_MST_User1] FOREIGN KEY([UpdateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[ITM_ItemWiseMainModel] CHECK CONSTRAINT [FK_MST_ItemWiseMainModel_MST_User1]
GO
ALTER TABLE [dbo].[ITM_ItemWiseOperation]  WITH CHECK ADD  CONSTRAINT [FK_MST_ItemWiseOperation_MST_Department] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[MST_Department] ([DepartmentID])
GO
ALTER TABLE [dbo].[ITM_ItemWiseOperation] CHECK CONSTRAINT [FK_MST_ItemWiseOperation_MST_Department]
GO
ALTER TABLE [dbo].[ITM_ItemWiseOperation]  WITH CHECK ADD  CONSTRAINT [FK_MST_ItemWiseOperation_MST_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[EMP_Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[ITM_ItemWiseOperation] CHECK CONSTRAINT [FK_MST_ItemWiseOperation_MST_Employee]
GO
ALTER TABLE [dbo].[ITM_ItemWiseOperation]  WITH CHECK ADD  CONSTRAINT [FK_MST_ItemWiseOperation_MST_EmployeeType] FOREIGN KEY([EmployeeTypeID])
REFERENCES [dbo].[EMP_EmployeeType] ([EmployeeTypeID])
GO
ALTER TABLE [dbo].[ITM_ItemWiseOperation] CHECK CONSTRAINT [FK_MST_ItemWiseOperation_MST_EmployeeType]
GO
ALTER TABLE [dbo].[ITM_ItemWiseOperation]  WITH CHECK ADD  CONSTRAINT [FK_MST_ItemWiseOperation_MST_Item] FOREIGN KEY([ItemID])
REFERENCES [dbo].[ITM_Item] ([ItemID])
GO
ALTER TABLE [dbo].[ITM_ItemWiseOperation] CHECK CONSTRAINT [FK_MST_ItemWiseOperation_MST_Item]
GO
ALTER TABLE [dbo].[ITM_ItemWiseOperation]  WITH CHECK ADD  CONSTRAINT [FK_MST_ItemWiseOperation_MST_User] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[ITM_ItemWiseOperation] CHECK CONSTRAINT [FK_MST_ItemWiseOperation_MST_User]
GO
ALTER TABLE [dbo].[ITM_ItemWiseOperation]  WITH CHECK ADD  CONSTRAINT [FK_MST_ItemWiseOperation_MST_User1] FOREIGN KEY([UpdateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[ITM_ItemWiseOperation] CHECK CONSTRAINT [FK_MST_ItemWiseOperation_MST_User1]
GO
ALTER TABLE [dbo].[ITM_ItemWiseRawMaterial]  WITH CHECK ADD  CONSTRAINT [FK_MST_ItemWiseRawMaterial_MST_Item] FOREIGN KEY([ItemID])
REFERENCES [dbo].[ITM_Item] ([ItemID])
GO
ALTER TABLE [dbo].[ITM_ItemWiseRawMaterial] CHECK CONSTRAINT [FK_MST_ItemWiseRawMaterial_MST_Item]
GO
ALTER TABLE [dbo].[ITM_ItemWiseRawMaterial]  WITH CHECK ADD  CONSTRAINT [FK_MST_ItemWiseRawMaterial_MST_RawMaterial] FOREIGN KEY([RawMaterialID])
REFERENCES [dbo].[MST_RawMaterial] ([RawMaterialID])
GO
ALTER TABLE [dbo].[ITM_ItemWiseRawMaterial] CHECK CONSTRAINT [FK_MST_ItemWiseRawMaterial_MST_RawMaterial]
GO
ALTER TABLE [dbo].[ITM_ItemWiseRawMaterial]  WITH CHECK ADD  CONSTRAINT [FK_MST_ItemWiseRawMaterial_MST_User] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[ITM_ItemWiseRawMaterial] CHECK CONSTRAINT [FK_MST_ItemWiseRawMaterial_MST_User]
GO
ALTER TABLE [dbo].[ITM_ItemWiseRawMaterial]  WITH CHECK ADD  CONSTRAINT [FK_MST_ItemWiseRawMaterial_MST_User1] FOREIGN KEY([UpdateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[ITM_ItemWiseRawMaterial] CHECK CONSTRAINT [FK_MST_ItemWiseRawMaterial_MST_User1]
GO
ALTER TABLE [dbo].[MST_Department]  WITH CHECK ADD  CONSTRAINT [FK_MST_Department_MST_User] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[MST_Department] CHECK CONSTRAINT [FK_MST_Department_MST_User]
GO
ALTER TABLE [dbo].[MST_Department]  WITH CHECK ADD  CONSTRAINT [FK_MST_Department_MST_User1] FOREIGN KEY([UpdateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[MST_Department] CHECK CONSTRAINT [FK_MST_Department_MST_User1]
GO
ALTER TABLE [dbo].[MST_RawMaterial]  WITH CHECK ADD  CONSTRAINT [FK_MST_RawMaterial_MST_Unit] FOREIGN KEY([UnitID])
REFERENCES [dbo].[MST_Unit] ([UnitID])
GO
ALTER TABLE [dbo].[MST_RawMaterial] CHECK CONSTRAINT [FK_MST_RawMaterial_MST_Unit]
GO
ALTER TABLE [dbo].[MST_RawMaterial]  WITH CHECK ADD  CONSTRAINT [FK_MST_RawMaterial_MST_User] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[MST_RawMaterial] CHECK CONSTRAINT [FK_MST_RawMaterial_MST_User]
GO
ALTER TABLE [dbo].[MST_RawMaterial]  WITH CHECK ADD  CONSTRAINT [FK_MST_RawMaterial_MST_User1] FOREIGN KEY([UpdateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[MST_RawMaterial] CHECK CONSTRAINT [FK_MST_RawMaterial_MST_User1]
GO
ALTER TABLE [dbo].[MST_Unit]  WITH CHECK ADD  CONSTRAINT [FK_MST_Unit_MST_User] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[MST_Unit] CHECK CONSTRAINT [FK_MST_Unit_MST_User]
GO
ALTER TABLE [dbo].[MST_Unit]  WITH CHECK ADD  CONSTRAINT [FK_MST_Unit_MST_User1] FOREIGN KEY([UpdateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[MST_Unit] CHECK CONSTRAINT [FK_MST_Unit_MST_User1]
GO
ALTER TABLE [dbo].[PRD_MainModel]  WITH CHECK ADD  CONSTRAINT [FK_MST_MainModel_MST_User] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[PRD_MainModel] CHECK CONSTRAINT [FK_MST_MainModel_MST_User]
GO
ALTER TABLE [dbo].[PRD_MainModel]  WITH CHECK ADD  CONSTRAINT [FK_MST_MainModel_MST_User1] FOREIGN KEY([UpdateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[PRD_MainModel] CHECK CONSTRAINT [FK_MST_MainModel_MST_User1]
GO
ALTER TABLE [dbo].[PRD_MainModelWiseQuestion]  WITH CHECK ADD  CONSTRAINT [FK_MST_MainModelWiseQuestion_MST_MainModel] FOREIGN KEY([MainModelID])
REFERENCES [dbo].[PRD_MainModel] ([MainModelID])
GO
ALTER TABLE [dbo].[PRD_MainModelWiseQuestion] CHECK CONSTRAINT [FK_MST_MainModelWiseQuestion_MST_MainModel]
GO
ALTER TABLE [dbo].[PRD_MainModelWiseQuestion]  WITH CHECK ADD  CONSTRAINT [FK_MST_MainModelWiseQuestion_MST_Question] FOREIGN KEY([QuestionID])
REFERENCES [dbo].[PRD_Question] ([QuestionID])
GO
ALTER TABLE [dbo].[PRD_MainModelWiseQuestion] CHECK CONSTRAINT [FK_MST_MainModelWiseQuestion_MST_Question]
GO
ALTER TABLE [dbo].[PRD_MainModelWiseQuestion]  WITH CHECK ADD  CONSTRAINT [FK_MST_MainModelWiseQuestion_MST_User] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[PRD_MainModelWiseQuestion] CHECK CONSTRAINT [FK_MST_MainModelWiseQuestion_MST_User]
GO
ALTER TABLE [dbo].[PRD_MainModelWiseQuestion]  WITH CHECK ADD  CONSTRAINT [FK_MST_MainModelWiseQuestion_MST_User1] FOREIGN KEY([UpdateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[PRD_MainModelWiseQuestion] CHECK CONSTRAINT [FK_MST_MainModelWiseQuestion_MST_User1]
GO
ALTER TABLE [dbo].[PRD_Question]  WITH CHECK ADD  CONSTRAINT [FK_MST_Question_MST_ItemType] FOREIGN KEY([ItemTypeID])
REFERENCES [dbo].[ITM_ItemType] ([ItemTypeID])
GO
ALTER TABLE [dbo].[PRD_Question] CHECK CONSTRAINT [FK_MST_Question_MST_ItemType]
GO
ALTER TABLE [dbo].[PRD_Question]  WITH CHECK ADD  CONSTRAINT [FK_MST_Question_MST_User] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[PRD_Question] CHECK CONSTRAINT [FK_MST_Question_MST_User]
GO
ALTER TABLE [dbo].[PRD_Question]  WITH CHECK ADD  CONSTRAINT [FK_MST_Question_MST_User1] FOREIGN KEY([UpdateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[PRD_Question] CHECK CONSTRAINT [FK_MST_Question_MST_User1]
GO
ALTER TABLE [dbo].[SEC_Menu]  WITH CHECK ADD  CONSTRAINT [FK_MST_Menu_MST_User] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[SEC_Menu] CHECK CONSTRAINT [FK_MST_Menu_MST_User]
GO
ALTER TABLE [dbo].[SEC_Menu]  WITH CHECK ADD  CONSTRAINT [FK_MST_Menu_MST_User1] FOREIGN KEY([UpdateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[SEC_Menu] CHECK CONSTRAINT [FK_MST_Menu_MST_User1]
GO
ALTER TABLE [dbo].[SEC_User]  WITH CHECK ADD  CONSTRAINT [FK_MST_User_MST_User] FOREIGN KEY([CreateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[SEC_User] CHECK CONSTRAINT [FK_MST_User_MST_User]
GO
ALTER TABLE [dbo].[SEC_User]  WITH CHECK ADD  CONSTRAINT [FK_MST_User_MST_User1] FOREIGN KEY([UpdateBy])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[SEC_User] CHECK CONSTRAINT [FK_MST_User_MST_User1]
GO
ALTER TABLE [dbo].[SEC_UserWiseMenu]  WITH CHECK ADD  CONSTRAINT [FK_MST_UserWiseMenu_MST_Menu] FOREIGN KEY([MenuID])
REFERENCES [dbo].[SEC_Menu] ([MenuID])
GO
ALTER TABLE [dbo].[SEC_UserWiseMenu] CHECK CONSTRAINT [FK_MST_UserWiseMenu_MST_Menu]
GO
ALTER TABLE [dbo].[SEC_UserWiseMenu]  WITH CHECK ADD  CONSTRAINT [FK_MST_UserWiseMenu_MST_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[SEC_User] ([UserID])
GO
ALTER TABLE [dbo].[SEC_UserWiseMenu] CHECK CONSTRAINT [FK_MST_UserWiseMenu_MST_User]
GO
/****** Object:  StoredProcedure [dbo].[SEC_Login_Select]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SEC_Login_Select]
@UserName nvarchar(100),
@UserPassword nvarchar(100)
AS
SELECT 
        [dbo].[SEC_User].[UserID],
        [dbo].[SEC_User].[UserName],
		[dbo].[SEC_User].[UserDisplayName],
		[dbo].[SEC_User].[UserPassword]
FROM    [dbo].[SEC_User]
WHERE [dbo].[SEC_User].[UserName] = @UserName and [dbo].[SEC_User].[UserPassword] = @UserPassword
GO
/****** Object:  StoredProcedure [dbo].[SP_EMP_Employee_Delete]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_EMP_Employee_Delete]

    @EmployeeID int

AS
BEGIN TRY
BEGIN TRAN

DELETE FROM [dbo].[EMP_Employee]
WHERE [dbo].[EMP_Employee].[EmployeeID] = @EmployeeID

COMMIT TRAN
END TRY

BEGIN CATCH

IF @@TRANCOUNT > 0
		
	BEGIN
        ROLLBACK TRAN
    END

    ; THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_EMP_Employee_Insert]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EMP_Employee_Insert]

    @EmployeeID int OUTPUT,
    @EmployeeName nvarchar(100),
    @EmployeeTypeID int,
    @PricePerHour int,
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS

BEGIN TRY
BEGIN TRAN

INSERT INTO [dbo].[EMP_Employee]
(
    [dbo].[EMP_Employee].[EmployeeName],
    [dbo].[EMP_Employee].[EmployeeTypeID],
    [dbo].[EMP_Employee].[PricePerHour],
    [dbo].[EMP_Employee].[Description],
    [dbo].[EMP_Employee].[CreateDateTime],
    [dbo].[EMP_Employee].[CreateBy],
    [dbo].[EMP_Employee].[CreateIP],
    [dbo].[EMP_Employee].[UpdateDateTime],
    [dbo].[EMP_Employee].[UpdateBy],
    [dbo].[EMP_Employee].[UpdateIP]
)
VALUES
(
    @EmployeeName,
    @EmployeeTypeID,
    @PricePerHour,
    @Description,
    @CreateDateTime,
    @CreateBy,
    @CreateIP,
    @UpdateDateTime,
    @UpdateBy,
    @UpdateIP
)

SET @EmployeeID = SCOPE_IDENTITY()

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_EMP_Employee_Select]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EMP_Employee_Select]

        @EmployeeName nvarchar(100),
        @EmployeeTypeID int

AS
BEGIN TRY
BEGIN TRAN

SELECT 
        [dbo].[EMP_Employee].[EmployeeName],
        [dbo].[EMP_Employee].[EmployeeTypeID],
        [dbo].[EMP_EmployeeType].[EmployeeTypeName],
        [dbo].[EMP_Employee].[PricePerHour],
        [dbo].[EMP_Employee].[Description],
        [dbo].[EMP_Employee].[UpdateBy],
        [UpdateBy].[UserDisplayName] AS [UpdateBy]
FROM    [dbo].[EMP_Employee]

INNER JOIN [dbo].[SEC_User] AS [UpdateBy]
ON      [UpdateBy].[UserID] = [dbo].[EMP_Employee].[UpdateBy]

INNER JOIN [dbo].[EMP_EmployeeType]
ON      [dbo].[EMP_EmployeeType].[EmployeeTypeID] = [dbo].[EMP_Employee].[EmployeeTypeID]

WHERE   (@EmployeeName IS NULL OR [dbo].[EMP_Employee].[EmployeeName] LIKE '%' + @EmployeeName + '%')
AND     (@EmployeeTypeID IS NULL OR [dbo].[EMP_Employee].[EmployeeTypeID] = @EmployeeTypeID)


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_EMP_Employee_SelectForDropDown]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EMP_Employee_SelectForDropDown]

AS

BEGIN TRY
BEGIN TRAN

SELECT 
        [dbo].[EMP_Employee].[EmployeeID],
        [dbo].[EMP_Employee].[EmployeeName]
FROM    [dbo].[EMP_Employee]

COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_EMP_Employee_SelectPK]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EMP_Employee_SelectPK]

        @EmployeeID int

AS

BEGIN TRY
BEGIN TRAN

SELECT
        [dbo].[EMP_Employee].[EmployeeID],
        [dbo].[EMP_Employee].[EmployeeName],
        [dbo].[EMP_Employee].[EmployeeTypeID],
        [dbo].[EMP_Employee].[PricePerHour],
        [dbo].[EMP_Employee].[Description],
        [dbo].[EMP_Employee].[CreateDateTime],
        [dbo].[EMP_Employee].[CreateBy],
        [dbo].[EMP_Employee].[CreateIP],
        [dbo].[EMP_Employee].[UpdateDateTime],
        [dbo].[EMP_Employee].[UpdateBy],
        [dbo].[EMP_Employee].[UpdateIP]
FROM    [dbo].[EMP_Employee]

WHERE   [dbo].[EMP_Employee].[EmployeeID] = @EmployeeID

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_EMP_Employee_Update]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_EMP_Employee_Update]

    @EmployeeID int,
    @EmployeeName nvarchar(100),
    @EmployeeTypeID int,
    @PricePerHour int,
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS
BEGIN TRY
BEGIN TRAN

UPDATE [dbo].[EMP_Employee]
SET
		
    [dbo].[EMP_Employee].[EmployeeName] = @EmployeeName,
    [dbo].[EMP_Employee].[EmployeeTypeID] = @EmployeeTypeID,
    [dbo].[EMP_Employee].[PricePerHour] = @PricePerHour,
    [dbo].[EMP_Employee].[Description] = @Description,
    [dbo].[EMP_Employee].[CreateDateTime] = @CreateDateTime,
    [dbo].[EMP_Employee].[CreateBy] = @CreateBy,
    [dbo].[EMP_Employee].[CreateIP] = @CreateIP,
    [dbo].[EMP_Employee].[UpdateDateTime] = @UpdateDateTime,
    [dbo].[EMP_Employee].[UpdateBy] = @UpdateBy,
    [dbo].[EMP_Employee].[UpdateIP] = @UpdateIP

WHERE
	[dbo].[EMP_Employee].[EmployeeID] = @EmployeeID


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_EMP_EmployeeType_Delete]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_EMP_EmployeeType_Delete]

    @EmployeeTypeID int

AS
BEGIN TRY
BEGIN TRAN

DELETE FROM [dbo].[EMP_EmployeeType]
WHERE [dbo].[EMP_EmployeeType].[EmployeeTypeID] = @EmployeeTypeID

COMMIT TRAN
END TRY

BEGIN CATCH

IF @@TRANCOUNT > 0
		
	BEGIN
        ROLLBACK TRAN
    END

    ; THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_EMP_EmployeeType_Insert]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EMP_EmployeeType_Insert]

    @EmployeeTypeID int OUTPUT,
    @EmployeeTypeName nvarchar(100),
    @IsEmployeeTypeForNos bit,
    @IsEmployeeTypeForHour bit,
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS

BEGIN TRY
BEGIN TRAN

INSERT INTO [dbo].[EMP_EmployeeType]
(
    [dbo].[EMP_EmployeeType].[EmployeeTypeName],
    [dbo].[EMP_EmployeeType].[IsEmployeeTypeForNos],
    [dbo].[EMP_EmployeeType].[IsEmployeeTypeForHour],
    [dbo].[EMP_EmployeeType].[Description],
    [dbo].[EMP_EmployeeType].[CreateDateTime],
    [dbo].[EMP_EmployeeType].[CreateBy],
    [dbo].[EMP_EmployeeType].[CreateIP],
    [dbo].[EMP_EmployeeType].[UpdateDateTime],
    [dbo].[EMP_EmployeeType].[UpdateBy],
    [dbo].[EMP_EmployeeType].[UpdateIP]
)
VALUES
(
    @EmployeeTypeName,
    @IsEmployeeTypeForNos,
    @IsEmployeeTypeForHour,
    @Description,
    @CreateDateTime,
    @CreateBy,
    @CreateIP,
    @UpdateDateTime,
    @UpdateBy,
    @UpdateIP
)

SET @EmployeeTypeID = SCOPE_IDENTITY()

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_EMP_EmployeeType_Select]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EMP_EmployeeType_Select]

        @EmployeeTypeName nvarchar(100)

AS
BEGIN TRY
BEGIN TRAN

SELECT 
        [dbo].[EMP_EmployeeType].[EmployeeTypeName],
        [dbo].[EMP_EmployeeType].[IsEmployeeTypeForNos],
        [dbo].[EMP_EmployeeType].[IsEmployeeTypeForHour],
        [dbo].[EMP_EmployeeType].[Description],
        [dbo].[EMP_EmployeeType].[UpdateBy],
        [UpdateBy].[UserDisplayName] AS [UpdateBy]
FROM    [dbo].[EMP_EmployeeType]

INNER JOIN [dbo].[SEC_User] AS [UpdateBy]
ON      [UpdateBy].[UserID] = [dbo].[EMP_EmployeeType].[UpdateBy]

WHERE   (@EmployeeTypeName IS NULL OR [dbo].[EMP_EmployeeType].[EmployeeTypeName] LIKE '%' + @EmployeeTypeName + '%')


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_EMP_EmployeeType_SelectForDropDown]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EMP_EmployeeType_SelectForDropDown]

AS

BEGIN TRY
BEGIN TRAN

SELECT 
        [dbo].[EMP_EmployeeType].[EmployeeTypeID],
        [dbo].[EMP_EmployeeType].[EmployeeTypeName]
FROM    [dbo].[EMP_EmployeeType]

COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_EMP_EmployeeType_SelectPK]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EMP_EmployeeType_SelectPK]

        @EmployeeTypeID int

AS

BEGIN TRY
BEGIN TRAN

SELECT
        [dbo].[EMP_EmployeeType].[EmployeeTypeID],
        [dbo].[EMP_EmployeeType].[EmployeeTypeName],
        [dbo].[EMP_EmployeeType].[IsEmployeeTypeForNos],
        [dbo].[EMP_EmployeeType].[IsEmployeeTypeForHour],
        [dbo].[EMP_EmployeeType].[Description],
        [dbo].[EMP_EmployeeType].[CreateDateTime],
        [dbo].[EMP_EmployeeType].[CreateBy],
        [dbo].[EMP_EmployeeType].[CreateIP],
        [dbo].[EMP_EmployeeType].[UpdateDateTime],
        [dbo].[EMP_EmployeeType].[UpdateBy],
        [dbo].[EMP_EmployeeType].[UpdateIP]
FROM    [dbo].[EMP_EmployeeType]

WHERE   [dbo].[EMP_EmployeeType].[EmployeeTypeID] = @EmployeeTypeID

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_EMP_EmployeeType_Update]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_EMP_EmployeeType_Update]

    @EmployeeTypeID int,
    @EmployeeTypeName nvarchar(100),
    @IsEmployeeTypeForNos bit,
    @IsEmployeeTypeForHour bit,
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS
BEGIN TRY
BEGIN TRAN

UPDATE [dbo].[EMP_EmployeeType]
SET
		
    [dbo].[EMP_EmployeeType].[EmployeeTypeName] = @EmployeeTypeName,
    [dbo].[EMP_EmployeeType].[IsEmployeeTypeForNos] = @IsEmployeeTypeForNos,
    [dbo].[EMP_EmployeeType].[IsEmployeeTypeForHour] = @IsEmployeeTypeForHour,
    [dbo].[EMP_EmployeeType].[Description] = @Description,
    [dbo].[EMP_EmployeeType].[CreateDateTime] = @CreateDateTime,
    [dbo].[EMP_EmployeeType].[CreateBy] = @CreateBy,
    [dbo].[EMP_EmployeeType].[CreateIP] = @CreateIP,
    [dbo].[EMP_EmployeeType].[UpdateDateTime] = @UpdateDateTime,
    [dbo].[EMP_EmployeeType].[UpdateBy] = @UpdateBy,
    [dbo].[EMP_EmployeeType].[UpdateIP] = @UpdateIP

WHERE
	[dbo].[EMP_EmployeeType].[EmployeeTypeID] = @EmployeeTypeID


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_Item_Delete]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_ITM_Item_Delete]

    @ItemID int

AS
BEGIN TRY
BEGIN TRAN

DELETE FROM [dbo].[ITM_Item]
WHERE [dbo].[ITM_Item].[ItemID] = @ItemID

COMMIT TRAN
END TRY

BEGIN CATCH

IF @@TRANCOUNT > 0
		
	BEGIN
        ROLLBACK TRAN
    END

    ; THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_Item_Insert]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ITM_Item_Insert]

    @ItemID int OUTPUT,
    @ItemName nvarchar(100),
    @ItemTypeID int,
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS

BEGIN TRY
BEGIN TRAN

INSERT INTO [dbo].[ITM_Item]
(
    [dbo].[ITM_Item].[ItemName],
    [dbo].[ITM_Item].[ItemTypeID],
    [dbo].[ITM_Item].[CreateDateTime],
    [dbo].[ITM_Item].[CreateBy],
    [dbo].[ITM_Item].[CreateIP],
    [dbo].[ITM_Item].[UpdateDateTime],
    [dbo].[ITM_Item].[UpdateBy],
    [dbo].[ITM_Item].[UpdateIP]
)
VALUES
(
    @ItemName,
    @ItemTypeID,
    @CreateDateTime,
    @CreateBy,
    @CreateIP,
    @UpdateDateTime,
    @UpdateBy,
    @UpdateIP
)

SET @ItemID = SCOPE_IDENTITY()

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_Item_Select]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ITM_Item_Select]

        @ItemName nvarchar(100),
        @ItemTypeID int

AS
BEGIN TRY
BEGIN TRAN

SELECT 
        [dbo].[ITM_Item].[ItemName],
        [dbo].[ITM_Item].[ItemTypeID],
        [dbo].[ITM_ItemType].[ItemTypeName],
        [dbo].[ITM_Item].[UpdateBy],
        [UpdateBy].[UserDisplayName] AS [UpdateBy]
FROM    [dbo].[ITM_Item]

INNER JOIN [dbo].[SEC_User] AS [UpdateBy]
ON      [UpdateBy].[UserID] = [dbo].[ITM_Item].[UpdateBy]

INNER JOIN [dbo].[ITM_ItemType]
ON      [dbo].[ITM_ItemType].[ItemTypeID] = [dbo].[ITM_Item].[ItemTypeID]

WHERE   (@ItemName IS NULL OR [dbo].[ITM_Item].[ItemName] LIKE '%' + @ItemName + '%')
AND     (@ItemTypeID IS NULL OR [dbo].[ITM_Item].[ItemTypeID] = @ItemTypeID)


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_Item_SelectForDropDown]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ITM_Item_SelectForDropDown]

AS

BEGIN TRY
BEGIN TRAN

SELECT 
        [dbo].[ITM_Item].[ItemID],
        [dbo].[ITM_Item].[ItemName]
FROM    [dbo].[ITM_Item]

COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_Item_SelectPK]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ITM_Item_SelectPK]

        @ItemID int

AS

BEGIN TRY
BEGIN TRAN

SELECT
        [dbo].[ITM_Item].[ItemID],
        [dbo].[ITM_Item].[ItemName],
        [dbo].[ITM_Item].[ItemTypeID],
        [dbo].[ITM_Item].[CreateDateTime],
        [dbo].[ITM_Item].[CreateBy],
        [dbo].[ITM_Item].[CreateIP],
        [dbo].[ITM_Item].[UpdateDateTime],
        [dbo].[ITM_Item].[UpdateBy],
        [dbo].[ITM_Item].[UpdateIP]
FROM    [dbo].[ITM_Item]

WHERE   [dbo].[ITM_Item].[ItemID] = @ItemID

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_Item_Update]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_ITM_Item_Update]

    @ItemID int,
    @ItemName nvarchar(100),
    @ItemTypeID int,
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS
BEGIN TRY
BEGIN TRAN

UPDATE [dbo].[ITM_Item]
SET
		
    [dbo].[ITM_Item].[ItemName] = @ItemName,
    [dbo].[ITM_Item].[ItemTypeID] = @ItemTypeID,
    [dbo].[ITM_Item].[CreateDateTime] = @CreateDateTime,
    [dbo].[ITM_Item].[CreateBy] = @CreateBy,
    [dbo].[ITM_Item].[CreateIP] = @CreateIP,
    [dbo].[ITM_Item].[UpdateDateTime] = @UpdateDateTime,
    [dbo].[ITM_Item].[UpdateBy] = @UpdateBy,
    [dbo].[ITM_Item].[UpdateIP] = @UpdateIP

WHERE
	[dbo].[ITM_Item].[ItemID] = @ItemID


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemType_Delete]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_ITM_ItemType_Delete]

    @ItemTypeID int

AS
BEGIN TRY
BEGIN TRAN

DELETE FROM [dbo].[ITM_ItemType]
WHERE [dbo].[ITM_ItemType].[ItemTypeID] = @ItemTypeID

COMMIT TRAN
END TRY

BEGIN CATCH

IF @@TRANCOUNT > 0
		
	BEGIN
        ROLLBACK TRAN
    END

    ; THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemType_Insert]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ITM_ItemType_Insert]

    @ItemTypeName nvarchar(100),
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS

BEGIN TRY
BEGIN TRAN

INSERT INTO [dbo].[ITM_ItemType]
(
    [dbo].[ITM_ItemType].[ItemTypeName],
    [dbo].[ITM_ItemType].[Description],
    [dbo].[ITM_ItemType].[CreateDateTime],
    [dbo].[ITM_ItemType].[CreateBy],
    [dbo].[ITM_ItemType].[CreateIP],
    [dbo].[ITM_ItemType].[UpdateDateTime],
    [dbo].[ITM_ItemType].[UpdateBy],
    [dbo].[ITM_ItemType].[UpdateIP]
)
VALUES
(
    @ItemTypeName,
    @Description,
    @CreateDateTime,
    @CreateBy,
    @CreateIP,
    @UpdateDateTime,
    @UpdateBy,
    @UpdateIP
)


COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemType_Select]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ITM_ItemType_Select]


AS
BEGIN TRY
BEGIN TRAN

SELECT 
		[dbo].[ITM_ItemType].[ItemTypeID],
        [dbo].[ITM_ItemType].[ItemTypeName],
        [dbo].[ITM_ItemType].[Description],
        [dbo].[ITM_ItemType].[UpdateBy],
        [UpdateBy].[UserDisplayName] AS [UpdateBy]
FROM    [dbo].[ITM_ItemType]

INNER JOIN [dbo].[SEC_User] AS [UpdateBy]
ON      [UpdateBy].[UserID] = [dbo].[ITM_ItemType].[UpdateBy]


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemType_SelectForDropDown]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ITM_ItemType_SelectForDropDown]

AS

BEGIN TRY
BEGIN TRAN

SELECT 
        [dbo].[ITM_ItemType].[ItemTypeID],
        [dbo].[ITM_ItemType].[ItemTypeName]
FROM    [dbo].[ITM_ItemType]

COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemType_SelectPK]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ITM_ItemType_SelectPK]

        @ItemTypeID int

AS

BEGIN TRY
BEGIN TRAN

SELECT
        [dbo].[ITM_ItemType].[ItemTypeID],
        [dbo].[ITM_ItemType].[ItemTypeName],
        [dbo].[ITM_ItemType].[Description],
        [dbo].[ITM_ItemType].[CreateDateTime],
        [dbo].[ITM_ItemType].[CreateBy],
        [dbo].[ITM_ItemType].[CreateIP],
        [dbo].[ITM_ItemType].[UpdateDateTime],
        [dbo].[ITM_ItemType].[UpdateBy],
        [dbo].[ITM_ItemType].[UpdateIP]
FROM    [dbo].[ITM_ItemType]

WHERE   [dbo].[ITM_ItemType].[ItemTypeID] = @ItemTypeID

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemType_Update]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_ITM_ItemType_Update]

    @ItemTypeID int,
    @ItemTypeName nvarchar(100),
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS
BEGIN TRY
BEGIN TRAN

UPDATE [dbo].[ITM_ItemType]
SET
		
    [dbo].[ITM_ItemType].[ItemTypeName] = @ItemTypeName,
    [dbo].[ITM_ItemType].[Description] = @Description,
    [dbo].[ITM_ItemType].[UpdateDateTime] = @UpdateDateTime,
    [dbo].[ITM_ItemType].[UpdateBy] = @UpdateBy,
    [dbo].[ITM_ItemType].[UpdateIP] = @UpdateIP

WHERE
	[dbo].[ITM_ItemType].[ItemTypeID] = @ItemTypeID


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemWiseMainModel_Delete]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_ITM_ItemWiseMainModel_Delete]

    @ItemWiseMainModelID int

AS
BEGIN TRY
BEGIN TRAN

DELETE FROM [dbo].[ITM_ItemWiseMainModel]
WHERE [dbo].[ITM_ItemWiseMainModel].[ItemWiseMainModelID] = @ItemWiseMainModelID

COMMIT TRAN
END TRY

BEGIN CATCH

IF @@TRANCOUNT > 0
		
	BEGIN
        ROLLBACK TRAN
    END

    ; THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemWiseMainModel_Insert]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ITM_ItemWiseMainModel_Insert]

    @ItemWiseMainModelID int OUTPUT,
    @ItemID int,
    @MainModelID int,
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS

BEGIN TRY
BEGIN TRAN

INSERT INTO [dbo].[ITM_ItemWiseMainModel]
(
    [dbo].[ITM_ItemWiseMainModel].[ItemID],
    [dbo].[ITM_ItemWiseMainModel].[MainModelID],
    [dbo].[ITM_ItemWiseMainModel].[CreateDateTime],
    [dbo].[ITM_ItemWiseMainModel].[CreateBy],
    [dbo].[ITM_ItemWiseMainModel].[CreateIP],
    [dbo].[ITM_ItemWiseMainModel].[UpdateDateTime],
    [dbo].[ITM_ItemWiseMainModel].[UpdateBy],
    [dbo].[ITM_ItemWiseMainModel].[UpdateIP]
)
VALUES
(
    @ItemID,
    @MainModelID,
    @CreateDateTime,
    @CreateBy,
    @CreateIP,
    @UpdateDateTime,
    @UpdateBy,
    @UpdateIP
)

SET @ItemWiseMainModelID = SCOPE_IDENTITY()

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemWiseMainModel_Select]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ITM_ItemWiseMainModel_Select]



AS
BEGIN TRY
BEGIN TRAN

SELECT *

FROM    [dbo].[ITM_ItemWiseMainModel]





COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemWiseMainModel_SelectForDropDown]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ITM_ItemWiseMainModel_SelectForDropDown]

AS

BEGIN TRY
BEGIN TRAN

SELECT *

FROM    [dbo].[ITM_ItemWiseMainModel]

COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemWiseMainModel_SelectPK]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ITM_ItemWiseMainModel_SelectPK]

        @ItemWiseMainModelID int

AS

BEGIN TRY
BEGIN TRAN

SELECT
        [dbo].[ITM_ItemWiseMainModel].[ItemWiseMainModelID],
        [dbo].[ITM_ItemWiseMainModel].[ItemID],
        [dbo].[ITM_ItemWiseMainModel].[MainModelID],
        [dbo].[ITM_ItemWiseMainModel].[CreateDateTime],
        [dbo].[ITM_ItemWiseMainModel].[CreateBy],
        [dbo].[ITM_ItemWiseMainModel].[CreateIP],
        [dbo].[ITM_ItemWiseMainModel].[UpdateDateTime],
        [dbo].[ITM_ItemWiseMainModel].[UpdateBy],
        [dbo].[ITM_ItemWiseMainModel].[UpdateIP]
FROM    [dbo].[ITM_ItemWiseMainModel]

WHERE   [dbo].[ITM_ItemWiseMainModel].[ItemWiseMainModelID] = @ItemWiseMainModelID

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemWiseMainModel_Update]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_ITM_ItemWiseMainModel_Update]

    @ItemWiseMainModelID int,
    @ItemID int,
    @MainModelID int,
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS
BEGIN TRY
BEGIN TRAN

UPDATE [dbo].[ITM_ItemWiseMainModel]
SET
		
    [dbo].[ITM_ItemWiseMainModel].[ItemID] = @ItemID,
    [dbo].[ITM_ItemWiseMainModel].[MainModelID] = @MainModelID,
    [dbo].[ITM_ItemWiseMainModel].[CreateDateTime] = @CreateDateTime,
    [dbo].[ITM_ItemWiseMainModel].[CreateBy] = @CreateBy,
    [dbo].[ITM_ItemWiseMainModel].[CreateIP] = @CreateIP,
    [dbo].[ITM_ItemWiseMainModel].[UpdateDateTime] = @UpdateDateTime,
    [dbo].[ITM_ItemWiseMainModel].[UpdateBy] = @UpdateBy,
    [dbo].[ITM_ItemWiseMainModel].[UpdateIP] = @UpdateIP

WHERE
	[dbo].[ITM_ItemWiseMainModel].[ItemWiseMainModelID] = @ItemWiseMainModelID


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemWiseOperation_Delete]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_ITM_ItemWiseOperation_Delete]

    @ItemWiseOperationID int

AS
BEGIN TRY
BEGIN TRAN

DELETE FROM [dbo].[ITM_ItemWiseOperation]
WHERE [dbo].[ITM_ItemWiseOperation].[ItemWiseOperationID] = @ItemWiseOperationID

COMMIT TRAN
END TRY

BEGIN CATCH

IF @@TRANCOUNT > 0
		
	BEGIN
        ROLLBACK TRAN
    END

    ; THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemWiseOperation_Insert]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ITM_ItemWiseOperation_Insert]

    @ItemWiseOperationID int OUTPUT,
    @ItemID int,
    @EmployeeTypeID int,
    @DepartmentID int,
    @EmployeeID int,
    @OperationTimeInMiniute int,
    @NumberOfNos int,
    @NumberOfEmployee int,
    @OperationExpense int,
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS

BEGIN TRY
BEGIN TRAN

INSERT INTO [dbo].[ITM_ItemWiseOperation]
(
    [dbo].[ITM_ItemWiseOperation].[ItemID],
    [dbo].[ITM_ItemWiseOperation].[EmployeeTypeID],
    [dbo].[ITM_ItemWiseOperation].[DepartmentID],
    [dbo].[ITM_ItemWiseOperation].[EmployeeID],
    [dbo].[ITM_ItemWiseOperation].[OperationTimeInMiniute],
    [dbo].[ITM_ItemWiseOperation].[NumberOfNos],
    [dbo].[ITM_ItemWiseOperation].[NumberOfEmployee],
    [dbo].[ITM_ItemWiseOperation].[OperationExpense],
    [dbo].[ITM_ItemWiseOperation].[Description],
    [dbo].[ITM_ItemWiseOperation].[CreateDateTime],
    [dbo].[ITM_ItemWiseOperation].[CreateBy],
    [dbo].[ITM_ItemWiseOperation].[CreateIP],
    [dbo].[ITM_ItemWiseOperation].[UpdateDateTime],
    [dbo].[ITM_ItemWiseOperation].[UpdateBy],
    [dbo].[ITM_ItemWiseOperation].[UpdateIP]
)
VALUES
(
    @ItemID,
    @EmployeeTypeID,
    @DepartmentID,
    @EmployeeID,
    @OperationTimeInMiniute,
    @NumberOfNos,
    @NumberOfEmployee,
    @OperationExpense,
    @Description,
    @CreateDateTime,
    @CreateBy,
    @CreateIP,
    @UpdateDateTime,
    @UpdateBy,
    @UpdateIP
)

SET @ItemWiseOperationID = SCOPE_IDENTITY()

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemWiseOperation_Select]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ITM_ItemWiseOperation_Select]

        @ItemID int,
        @EmployeeTypeID int,
        @DepartmentID int,
        @EmployeeID int

AS
BEGIN TRY
BEGIN TRAN

SELECT 
        [dbo].[ITM_ItemWiseOperation].[ItemID],
        [dbo].[ITM_Item].[ItemName],
        [dbo].[ITM_ItemWiseOperation].[EmployeeTypeID],
        [dbo].[EMP_EmployeeType].[EmployeeTypeName],
        [dbo].[ITM_ItemWiseOperation].[DepartmentID],
        [dbo].[MST_Department].[DepartmentName],
        [dbo].[ITM_ItemWiseOperation].[EmployeeID],
        [dbo].[EMP_Employee].[EmployeeName],
        [dbo].[ITM_ItemWiseOperation].[OperationTimeInMiniute],
        [dbo].[ITM_ItemWiseOperation].[NumberOfNos],
        [dbo].[ITM_ItemWiseOperation].[NumberOfEmployee],
        [dbo].[ITM_ItemWiseOperation].[OperationExpense],
        [dbo].[ITM_ItemWiseOperation].[Description],
        [dbo].[ITM_ItemWiseOperation].[UpdateBy],
        [UpdateBy].[UserDisplayName] AS [UpdateBy]
FROM    [dbo].[ITM_ItemWiseOperation]

INNER JOIN [dbo].[SEC_User] AS [UpdateBy]
ON      [UpdateBy].[UserID] = [dbo].[ITM_ItemWiseOperation].[UpdateBy]

INNER JOIN [dbo].[EMP_EmployeeType]
ON      [dbo].[EMP_EmployeeType].[EmployeeTypeID] = [dbo].[ITM_ItemWiseOperation].[EmployeeTypeID]

INNER JOIN [dbo].[ITM_Item]
ON      [dbo].[ITM_Item].[ItemID] = [dbo].[ITM_ItemWiseOperation].[ItemID]

LEFT OUTER JOIN [dbo].[MST_Department]
ON      [dbo].[MST_Department].[DepartmentID] = [dbo].[ITM_ItemWiseOperation].[DepartmentID]

LEFT OUTER JOIN [dbo].[EMP_Employee]
ON      [dbo].[EMP_Employee].[EmployeeID] = [dbo].[ITM_ItemWiseOperation].[EmployeeID]

WHERE   (@ItemID IS NULL OR [dbo].[ITM_ItemWiseOperation].[ItemID] = @ItemID
AND     (@EmployeeTypeID IS NULL OR [dbo].[ITM_ItemWiseOperation].[EmployeeTypeID] = @EmployeeTypeID)
AND     (@DepartmentID IS NULL OR [dbo].[ITM_ItemWiseOperation].[DepartmentID] = @DepartmentID)
AND     (@EmployeeID IS NULL OR [dbo].[ITM_ItemWiseOperation].[EmployeeID] = @EmployeeID))


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemWiseOperation_SelectForDropDown]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ITM_ItemWiseOperation_SelectForDropDown]

AS

BEGIN TRY
BEGIN TRAN

SELECT 
        [dbo].[ITM_ItemWiseOperation].[ItemWiseOperationID],
        [dbo].[ITM_ItemWiseOperation].[ItemID]
FROM    [dbo].[ITM_ItemWiseOperation]

COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemWiseOperation_SelectPK]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ITM_ItemWiseOperation_SelectPK]

        @ItemWiseOperationID int

AS

BEGIN TRY
BEGIN TRAN

SELECT
        [dbo].[ITM_ItemWiseOperation].[ItemWiseOperationID],
        [dbo].[ITM_ItemWiseOperation].[ItemID],
        [dbo].[ITM_ItemWiseOperation].[EmployeeTypeID],
        [dbo].[ITM_ItemWiseOperation].[DepartmentID],
        [dbo].[ITM_ItemWiseOperation].[EmployeeID],
        [dbo].[ITM_ItemWiseOperation].[OperationTimeInMiniute],
        [dbo].[ITM_ItemWiseOperation].[NumberOfNos],
        [dbo].[ITM_ItemWiseOperation].[NumberOfEmployee],
        [dbo].[ITM_ItemWiseOperation].[OperationExpense],
        [dbo].[ITM_ItemWiseOperation].[Description],
        [dbo].[ITM_ItemWiseOperation].[CreateDateTime],
        [dbo].[ITM_ItemWiseOperation].[CreateBy],
        [dbo].[ITM_ItemWiseOperation].[CreateIP],
        [dbo].[ITM_ItemWiseOperation].[UpdateDateTime],
        [dbo].[ITM_ItemWiseOperation].[UpdateBy],
        [dbo].[ITM_ItemWiseOperation].[UpdateIP]
FROM    [dbo].[ITM_ItemWiseOperation]

WHERE   [dbo].[ITM_ItemWiseOperation].[ItemWiseOperationID] = @ItemWiseOperationID

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_ITM_ItemWiseOperation_Update]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_ITM_ItemWiseOperation_Update]

    @ItemWiseOperationID int,
    @ItemID int,
    @EmployeeTypeID int,
    @DepartmentID int,
    @EmployeeID int,
    @OperationTimeInMiniute int,
    @NumberOfNos int,
    @NumberOfEmployee int,
    @OperationExpense int,
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS
BEGIN TRY
BEGIN TRAN

UPDATE [dbo].[ITM_ItemWiseOperation]
SET
		
    [dbo].[ITM_ItemWiseOperation].[ItemID] = @ItemID,
    [dbo].[ITM_ItemWiseOperation].[EmployeeTypeID] = @EmployeeTypeID,
    [dbo].[ITM_ItemWiseOperation].[DepartmentID] = @DepartmentID,
    [dbo].[ITM_ItemWiseOperation].[EmployeeID] = @EmployeeID,
    [dbo].[ITM_ItemWiseOperation].[OperationTimeInMiniute] = @OperationTimeInMiniute,
    [dbo].[ITM_ItemWiseOperation].[NumberOfNos] = @NumberOfNos,
    [dbo].[ITM_ItemWiseOperation].[NumberOfEmployee] = @NumberOfEmployee,
    [dbo].[ITM_ItemWiseOperation].[OperationExpense] = @OperationExpense,
    [dbo].[ITM_ItemWiseOperation].[Description] = @Description,
    [dbo].[ITM_ItemWiseOperation].[CreateDateTime] = @CreateDateTime,
    [dbo].[ITM_ItemWiseOperation].[CreateBy] = @CreateBy,
    [dbo].[ITM_ItemWiseOperation].[CreateIP] = @CreateIP,
    [dbo].[ITM_ItemWiseOperation].[UpdateDateTime] = @UpdateDateTime,
    [dbo].[ITM_ItemWiseOperation].[UpdateBy] = @UpdateBy,
    [dbo].[ITM_ItemWiseOperation].[UpdateIP] = @UpdateIP

WHERE
	[dbo].[ITM_ItemWiseOperation].[ItemWiseOperationID] = @ItemWiseOperationID


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_Menu_Fill]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Menu_Fill]

@UserID nvarchar(100)

as

Select
		[dbo].[SEC_Menu].[MenuID],
        [dbo].[SEC_Menu].[MenuName],
        [dbo].[SEC_Menu].[MenuImagePath],
        [dbo].[SEC_Menu].[MenuURL],
        [dbo].[SEC_Menu].[MenuSequence]
From [dbo].[SEC_Menu]
inner join [dbo].[SEC_UserWiseMenu] 
on [dbo].[SEC_UserWiseMenu].[MenuID] = [dbo].[SEC_Menu].[MenuID] 
AND [dbo].[SEC_UserWiseMenu].[UserID] = @UserID
order by [dbo].[SEC_Menu].[MenuSequence] ASC
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_Department_Delete]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_MST_Department_Delete]

    @DepartmentID int

AS
BEGIN TRY
BEGIN TRAN

DELETE FROM [dbo].[MST_Department]
WHERE [dbo].[MST_Department].[DepartmentID] = @DepartmentID

COMMIT TRAN
END TRY

BEGIN CATCH

IF @@TRANCOUNT > 0
		
	BEGIN
        ROLLBACK TRAN
    END

    ; THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_Department_Insert]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MST_Department_Insert]

    @DepartmentName nvarchar(100),
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS

BEGIN TRY
BEGIN TRAN

INSERT INTO [dbo].[MST_Department]
(
    [dbo].[MST_Department].[DepartmentName],
    [dbo].[MST_Department].[Description],
    [dbo].[MST_Department].[CreateDateTime],
    [dbo].[MST_Department].[CreateBy],
    [dbo].[MST_Department].[CreateIP],
    [dbo].[MST_Department].[UpdateDateTime],
    [dbo].[MST_Department].[UpdateBy],
    [dbo].[MST_Department].[UpdateIP]
)
VALUES
(
    @DepartmentName,
    @Description,
    @CreateDateTime,
    @CreateBy,
    @CreateIP,
    @UpdateDateTime,
    @UpdateBy,
    @UpdateIP
)


COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_Department_Select]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MST_Department_Select]


AS
BEGIN TRY
BEGIN TRAN

SELECT 
		[dbo].[MST_Department].[DepartmentID],
        [dbo].[MST_Department].[DepartmentName],
        [dbo].[MST_Department].[Description],
        [UpdateBy].[UserDisplayName] AS [UpdateBy]
FROM    [dbo].[MST_Department]

INNER JOIN [dbo].[SEC_User] AS [UpdateBy]
ON      [UpdateBy].[UserID] = [dbo].[MST_Department].[UpdateBy]



COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_Department_SelectForDropDown]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MST_Department_SelectForDropDown]

AS

BEGIN TRY
BEGIN TRAN

SELECT 
        [dbo].[MST_Department].[DepartmentID],
        [dbo].[MST_Department].[DepartmentName]
FROM    [dbo].[MST_Department]

COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_Department_SelectPK]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MST_Department_SelectPK]

        @DepartmentID int

AS

BEGIN TRY
BEGIN TRAN

SELECT
        [dbo].[MST_Department].[DepartmentID],
        [dbo].[MST_Department].[DepartmentName],
        [dbo].[MST_Department].[Description],
        [dbo].[MST_Department].[CreateDateTime],
        [dbo].[MST_Department].[CreateBy],
        [dbo].[MST_Department].[CreateIP],
        [dbo].[MST_Department].[UpdateDateTime],
        [dbo].[MST_Department].[UpdateBy],
        [dbo].[MST_Department].[UpdateIP]
FROM    [dbo].[MST_Department]

WHERE   [dbo].[MST_Department].[DepartmentID] = @DepartmentID

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_Department_Update]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_MST_Department_Update]

    @DepartmentID int,
    @DepartmentName nvarchar(100),
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS
BEGIN TRY
BEGIN TRAN

UPDATE [dbo].[MST_Department]
SET
		
    [dbo].[MST_Department].[DepartmentName] = @DepartmentName,
    [dbo].[MST_Department].[Description] = @Description,
    [dbo].[MST_Department].[UpdateDateTime] = @UpdateDateTime,
    [dbo].[MST_Department].[UpdateBy] = @UpdateBy,
    [dbo].[MST_Department].[UpdateIP] = @UpdateIP

WHERE
	[dbo].[MST_Department].[DepartmentID] = @DepartmentID


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_RawMaterial_Delete]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_MST_RawMaterial_Delete]

    @RawMaterialID int

AS
BEGIN TRY
BEGIN TRAN

DELETE FROM [dbo].[MST_RawMaterial]
WHERE [dbo].[MST_RawMaterial].[RawMaterialID] = @RawMaterialID

COMMIT TRAN
END TRY

BEGIN CATCH

IF @@TRANCOUNT > 0
		
	BEGIN
        ROLLBACK TRAN
    END

    ; THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_RawMaterial_Insert]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MST_RawMaterial_Insert]

    @RawMaterialName nvarchar(100),
    @UnitID int,
	@RawMaterialPrice decimal,
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS

BEGIN TRY
BEGIN TRAN

INSERT INTO [dbo].[MST_RawMaterial]
(
    [dbo].[MST_RawMaterial].[RawMaterialName],
    [dbo].[MST_RawMaterial].[UnitID],
	[dbo].[MST_RawMaterial].[RawMaterialPrice],
    [dbo].[MST_RawMaterial].[Description],
    [dbo].[MST_RawMaterial].[CreateDateTime],
    [dbo].[MST_RawMaterial].[CreateBy],
    [dbo].[MST_RawMaterial].[CreateIP],
    [dbo].[MST_RawMaterial].[UpdateDateTime],
    [dbo].[MST_RawMaterial].[UpdateBy],
    [dbo].[MST_RawMaterial].[UpdateIP]
)
VALUES
(
    @RawMaterialName,
    @UnitID,
	@RawMaterialPrice,
    @Description,
    @CreateDateTime,
    @CreateBy,
    @CreateIP,
    @UpdateDateTime,
    @UpdateBy,
    @UpdateIP
)


COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_RawMaterial_Select]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MST_RawMaterial_Select]


AS
BEGIN TRY
BEGIN TRAN

SELECT 
		[dbo].[MST_RawMaterial].[RawMaterialID],
        [dbo].[MST_RawMaterial].[RawMaterialName],
        [dbo].[MST_Unit].[UnitName],
		[dbo].[MST_RawMaterial].[RawMaterialPrice],
        [dbo].[MST_RawMaterial].[Description],
        [UpdateBy].[UserDisplayName] AS [UpdateBy]
FROM    [dbo].[MST_RawMaterial]

INNER JOIN [dbo].[SEC_User] AS [UpdateBy]
ON      [UpdateBy].[UserID] = [dbo].[MST_RawMaterial].[UpdateBy]

INNER JOIN [dbo].[MST_Unit]
ON      [dbo].[MST_Unit].[UnitID] = [dbo].[MST_RawMaterial].[UnitID]


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_RawMaterial_SelectForDropDown]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MST_RawMaterial_SelectForDropDown]

AS

BEGIN TRY
BEGIN TRAN

SELECT 
        [dbo].[MST_RawMaterial].[RawMaterialID],
        [dbo].[MST_RawMaterial].[RawMaterialName]
FROM    [dbo].[MST_RawMaterial]

COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_RawMaterial_SelectPK]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MST_RawMaterial_SelectPK]

        @RawMaterialID int

AS

BEGIN TRY
BEGIN TRAN

SELECT
        [dbo].[MST_RawMaterial].[RawMaterialID],
        [dbo].[MST_RawMaterial].[RawMaterialName],
        [dbo].[MST_RawMaterial].[UnitID],
		[dbo].[MST_RawMaterial].[RawMaterialPrice],
        [dbo].[MST_RawMaterial].[Description],
        [dbo].[MST_RawMaterial].[CreateDateTime],
        [dbo].[MST_RawMaterial].[CreateBy],
        [dbo].[MST_RawMaterial].[CreateIP],
        [dbo].[MST_RawMaterial].[UpdateDateTime],
        [dbo].[MST_RawMaterial].[UpdateBy],
        [dbo].[MST_RawMaterial].[UpdateIP]
FROM    [dbo].[MST_RawMaterial]

WHERE   [dbo].[MST_RawMaterial].[RawMaterialID] = @RawMaterialID

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_RawMaterial_Update]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_MST_RawMaterial_Update]

    @RawMaterialID int,
    @RawMaterialName nvarchar(100),
    @UnitID int,
	@RawMaterialPrice decimal(5,5),
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS
BEGIN TRY
BEGIN TRAN

UPDATE [dbo].[MST_RawMaterial]
SET
		
    [dbo].[MST_RawMaterial].[RawMaterialName] = @RawMaterialName,
    [dbo].[MST_RawMaterial].[UnitID] = @UnitID,
	[dbo].[MST_RawMaterial].[RawMaterialPrice] = @RawMaterialPrice,
    [dbo].[MST_RawMaterial].[Description] = @Description,
    [dbo].[MST_RawMaterial].[UpdateDateTime] = @UpdateDateTime,
    [dbo].[MST_RawMaterial].[UpdateBy] = @UpdateBy,
    [dbo].[MST_RawMaterial].[UpdateIP] = @UpdateIP

WHERE
	[dbo].[MST_RawMaterial].[RawMaterialID] = @RawMaterialID


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_Unit_Delete]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_MST_Unit_Delete]

    @UnitID int

AS
BEGIN TRY
BEGIN TRAN

DELETE FROM [dbo].[MST_Unit]
WHERE [dbo].[MST_Unit].[UnitID] = @UnitID

COMMIT TRAN
END TRY

BEGIN CATCH

IF @@TRANCOUNT > 0
		
	BEGIN
        ROLLBACK TRAN
    END

    ; THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_Unit_Insert]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MST_Unit_Insert]

    @UnitName nvarchar(50),
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS

BEGIN TRY
BEGIN TRAN

INSERT INTO [dbo].[MST_Unit]
(
    [dbo].[MST_Unit].[UnitName],
    [dbo].[MST_Unit].[Description],
    [dbo].[MST_Unit].[CreateDateTime],
    [dbo].[MST_Unit].[CreateBy],
    [dbo].[MST_Unit].[CreateIP],
    [dbo].[MST_Unit].[UpdateDateTime],
    [dbo].[MST_Unit].[UpdateBy],
    [dbo].[MST_Unit].[UpdateIP]
)
VALUES
(
    @UnitName,
    @Description,
    @CreateDateTime,
    @CreateBy,
    @CreateIP,
    @UpdateDateTime,
    @UpdateBy,
    @UpdateIP
)



COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_Unit_Select]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MST_Unit_Select]

     

AS
BEGIN TRY
BEGIN TRAN

SELECT 
		[dbo].[MST_Unit].[UnitID],
        [dbo].[MST_Unit].[UnitName],
        [dbo].[MST_Unit].[Description],
        [UpdateBy].[UserDisplayName] AS [UpdateBy]
FROM    [dbo].[MST_Unit]

INNER JOIN [dbo].[SEC_User] AS [UpdateBy]
ON      [UpdateBy].[UserID] = [dbo].[MST_Unit].[UpdateBy]



COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_Unit_SelectForDropDown]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MST_Unit_SelectForDropDown]

AS

BEGIN TRY
BEGIN TRAN

SELECT 
        [dbo].[MST_Unit].[UnitID],
        [dbo].[MST_Unit].[UnitName]
FROM    [dbo].[MST_Unit]

COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_Unit_SelectPK]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_MST_Unit_SelectPK]

        @UnitID int

AS

BEGIN TRY
BEGIN TRAN

SELECT
        [dbo].[MST_Unit].[UnitID],
        [dbo].[MST_Unit].[UnitName],
        [dbo].[MST_Unit].[Description],
        [dbo].[MST_Unit].[CreateDateTime],
        [dbo].[MST_Unit].[CreateBy],
        [dbo].[MST_Unit].[CreateIP],
        [dbo].[MST_Unit].[UpdateDateTime],
        [dbo].[MST_Unit].[UpdateBy],
        [dbo].[MST_Unit].[UpdateIP]
FROM    [dbo].[MST_Unit]

WHERE   [dbo].[MST_Unit].[UnitID] = @UnitID

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_MST_Unit_Update]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_MST_Unit_Update]

    @UnitID int,
    @UnitName nvarchar(50),
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS
BEGIN TRY
BEGIN TRAN

UPDATE [dbo].[MST_Unit]
SET
		
    [dbo].[MST_Unit].[UnitName] = @UnitName,
    [dbo].[MST_Unit].[Description] = @Description,
    [dbo].[MST_Unit].[UpdateDateTime] = @UpdateDateTime,
    [dbo].[MST_Unit].[UpdateBy] = @UpdateBy,
    [dbo].[MST_Unit].[UpdateIP] = @UpdateIP

WHERE
	[dbo].[MST_Unit].[UnitID] = @UnitID


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_MainModel_Delete]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_PRD_MainModel_Delete]

    @MainModelID int

AS
BEGIN TRY
BEGIN TRAN

DELETE FROM [dbo].[PRD_MainModel]
WHERE [dbo].[PRD_MainModel].[MainModelID] = @MainModelID

COMMIT TRAN
END TRY

BEGIN CATCH

IF @@TRANCOUNT > 0
		
	BEGIN
        ROLLBACK TRAN
    END

    ; THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_MainModel_Insert]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PRD_MainModel_Insert]

    @MainModelID int OUTPUT,
    @MainModelName nvarchar(100),
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS

BEGIN TRY
BEGIN TRAN

INSERT INTO [dbo].[PRD_MainModel]
(
    [dbo].[PRD_MainModel].[MainModelName],
    [dbo].[PRD_MainModel].[Description],
    [dbo].[PRD_MainModel].[CreateDateTime],
    [dbo].[PRD_MainModel].[CreateBy],
    [dbo].[PRD_MainModel].[CreateIP],
    [dbo].[PRD_MainModel].[UpdateDateTime],
    [dbo].[PRD_MainModel].[UpdateBy],
    [dbo].[PRD_MainModel].[UpdateIP]
)
VALUES
(
    @MainModelName,
    @Description,
    @CreateDateTime,
    @CreateBy,
    @CreateIP,
    @UpdateDateTime,
    @UpdateBy,
    @UpdateIP
)

SET @MainModelID = SCOPE_IDENTITY()

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_MainModel_Select]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PRD_MainModel_Select]


AS
BEGIN TRY
BEGIN TRAN


SELECT 
	distinct [dbo].[PRD_MainModel].[MainModelID],
	[dbo].[PRD_MainModel].[MainModelName],
	STRING_AGG([dbo].[PRD_Question].[QuestionName],', ') AS QuestionName     
FROM 
	[dbo].[PRD_MainModelWiseQuestion]

INNER JOIN 
	[dbo].[PRD_MainModel]
ON      
	[dbo].[PRD_MainModelWiseQuestion].[MainModelID] = [dbo].[PRD_MainModel].[MainModelID]

INNER JOIN 
	[dbo].[PRD_Question]
ON
	[dbo].[PRD_MainModelWiseQuestion].[QuestionID] = [dbo].[PRD_Question].[QuestionID]

GROUP BY 
	[dbo].[PRD_MainModel].[MainModelName],[dbo].[PRD_MainModel].[MainModelID]





COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_MainModel_SelectForDropDown]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PRD_MainModel_SelectForDropDown]

AS

BEGIN TRY
BEGIN TRAN

SELECT 
        [dbo].[PRD_MainModel].[MainModelID],
        [dbo].[PRD_MainModel].[MainModelName]
FROM    [dbo].[PRD_MainModel]

COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_MainModel_SelectPK]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PRD_MainModel_SelectPK]

        @MainModelID int

AS

BEGIN TRY
BEGIN TRAN

SELECT
        [dbo].[PRD_MainModel].[MainModelID],
        [dbo].[PRD_MainModel].[MainModelName],
        [dbo].[PRD_MainModel].[Description],
        [dbo].[PRD_MainModel].[CreateDateTime],
        [dbo].[PRD_MainModel].[CreateBy],
        [dbo].[PRD_MainModel].[CreateIP],
        [dbo].[PRD_MainModel].[UpdateDateTime],
        [dbo].[PRD_MainModel].[UpdateBy],
        [dbo].[PRD_MainModel].[UpdateIP]
FROM    [dbo].[PRD_MainModel]

WHERE   [dbo].[PRD_MainModel].[MainModelID] = @MainModelID

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_MainModel_Update]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_PRD_MainModel_Update]

    @MainModelID int,
    @MainModelName nvarchar(100),
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS
BEGIN TRY
BEGIN TRAN

UPDATE [dbo].[PRD_MainModel]
SET
		
    [dbo].[PRD_MainModel].[MainModelName] = @MainModelName,
    [dbo].[PRD_MainModel].[Description] = @Description,
    [dbo].[PRD_MainModel].[CreateDateTime] = @CreateDateTime,
    [dbo].[PRD_MainModel].[CreateBy] = @CreateBy,
    [dbo].[PRD_MainModel].[CreateIP] = @CreateIP,
    [dbo].[PRD_MainModel].[UpdateDateTime] = @UpdateDateTime,
    [dbo].[PRD_MainModel].[UpdateBy] = @UpdateBy,
    [dbo].[PRD_MainModel].[UpdateIP] = @UpdateIP

WHERE
	[dbo].[PRD_MainModel].[MainModelID] = @MainModelID


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_MainModelWiseQuestion_Delete]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_PRD_MainModelWiseQuestion_Delete]

    @MainModelWiseQuestionID int

AS
BEGIN TRY
BEGIN TRAN

DELETE FROM [dbo].[PRD_MainModelWiseQuestion]
WHERE [dbo].[PRD_MainModelWiseQuestion].[MainModelWiseQuestionID] = @MainModelWiseQuestionID

COMMIT TRAN
END TRY

BEGIN CATCH

IF @@TRANCOUNT > 0
		
	BEGIN
        ROLLBACK TRAN
    END

    ; THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_MainModelWiseQuestion_Insert]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PRD_MainModelWiseQuestion_Insert]

    @MainModelWiseQuestionID int OUTPUT,
    @MainModelID int,
    @QuestionID int,
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS

BEGIN TRY
BEGIN TRAN

INSERT INTO [dbo].[PRD_MainModelWiseQuestion]
(
    [dbo].[PRD_MainModelWiseQuestion].[MainModelID],
    [dbo].[PRD_MainModelWiseQuestion].[QuestionID],
    [dbo].[PRD_MainModelWiseQuestion].[CreateDateTime],
    [dbo].[PRD_MainModelWiseQuestion].[CreateBy],
    [dbo].[PRD_MainModelWiseQuestion].[CreateIP],
    [dbo].[PRD_MainModelWiseQuestion].[UpdateDateTime],
    [dbo].[PRD_MainModelWiseQuestion].[UpdateBy],
    [dbo].[PRD_MainModelWiseQuestion].[UpdateIP]
)
VALUES
(
    @MainModelID,
    @QuestionID,
    @CreateDateTime,
    @CreateBy,
    @CreateIP,
    @UpdateDateTime,
    @UpdateBy,
    @UpdateIP
)

SET @MainModelWiseQuestionID = SCOPE_IDENTITY()

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_MainModelWiseQuestion_Select]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PRD_MainModelWiseQuestion_Select]



AS
BEGIN TRY
BEGIN TRAN

SELECT 
*
FROM    [dbo].[PRD_MainModelWiseQuestion]





COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_MainModelWiseQuestion_SelectForDropDown]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PRD_MainModelWiseQuestion_SelectForDropDown]

AS

BEGIN TRY
BEGIN TRAN

SELECT 
*
FROM    [dbo].[PRD_MainModelWiseQuestion]

COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_MainModelWiseQuestion_SelectPK]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PRD_MainModelWiseQuestion_SelectPK]

        @MainModelWiseQuestionID int

AS

BEGIN TRY
BEGIN TRAN

SELECT
        [dbo].[PRD_MainModelWiseQuestion].[MainModelWiseQuestionID],
        [dbo].[PRD_MainModelWiseQuestion].[MainModelID],
        [dbo].[PRD_MainModelWiseQuestion].[QuestionID],
        [dbo].[PRD_MainModelWiseQuestion].[CreateDateTime],
        [dbo].[PRD_MainModelWiseQuestion].[CreateBy],
        [dbo].[PRD_MainModelWiseQuestion].[CreateIP],
        [dbo].[PRD_MainModelWiseQuestion].[UpdateDateTime],
        [dbo].[PRD_MainModelWiseQuestion].[UpdateBy],
        [dbo].[PRD_MainModelWiseQuestion].[UpdateIP]
FROM    [dbo].[PRD_MainModelWiseQuestion]

WHERE   [dbo].[PRD_MainModelWiseQuestion].[MainModelWiseQuestionID] = @MainModelWiseQuestionID

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_MainModelWiseQuestion_Update]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_PRD_MainModelWiseQuestion_Update]

    @MainModelWiseQuestionID int,
    @MainModelID int,
    @QuestionID int,
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS
BEGIN TRY
BEGIN TRAN

UPDATE [dbo].[PRD_MainModelWiseQuestion]
SET
		
    [dbo].[PRD_MainModelWiseQuestion].[MainModelID] = @MainModelID,
    [dbo].[PRD_MainModelWiseQuestion].[QuestionID] = @QuestionID,
    [dbo].[PRD_MainModelWiseQuestion].[CreateDateTime] = @CreateDateTime,
    [dbo].[PRD_MainModelWiseQuestion].[CreateBy] = @CreateBy,
    [dbo].[PRD_MainModelWiseQuestion].[CreateIP] = @CreateIP,
    [dbo].[PRD_MainModelWiseQuestion].[UpdateDateTime] = @UpdateDateTime,
    [dbo].[PRD_MainModelWiseQuestion].[UpdateBy] = @UpdateBy,
    [dbo].[PRD_MainModelWiseQuestion].[UpdateIP] = @UpdateIP

WHERE
	[dbo].[PRD_MainModelWiseQuestion].[MainModelWiseQuestionID] = @MainModelWiseQuestionID


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_Question_Delete]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_PRD_Question_Delete]

    @QuestionID int

AS
BEGIN TRY
BEGIN TRAN

DELETE FROM [dbo].[PRD_Question]
WHERE [dbo].[PRD_Question].[QuestionID] = @QuestionID

COMMIT TRAN
END TRY

BEGIN CATCH

IF @@TRANCOUNT > 0
		
	BEGIN
        ROLLBACK TRAN
    END

    ; THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_Question_Insert]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PRD_Question_Insert]

    @QuestionName nvarchar(500),
    @ItemTypeID int,
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS

BEGIN TRY
BEGIN TRAN

INSERT INTO [dbo].[PRD_Question]
(
    [dbo].[PRD_Question].[QuestionName],
    [dbo].[PRD_Question].[ItemTypeID],
    [dbo].[PRD_Question].[Description],
    [dbo].[PRD_Question].[CreateDateTime],
    [dbo].[PRD_Question].[CreateBy],
    [dbo].[PRD_Question].[CreateIP],
    [dbo].[PRD_Question].[UpdateDateTime],
    [dbo].[PRD_Question].[UpdateBy],
    [dbo].[PRD_Question].[UpdateIP]
)
VALUES
(
    @QuestionName,
    @ItemTypeID,
    @Description,
    @CreateDateTime,
    @CreateBy,
    @CreateIP,
    @UpdateDateTime,
    @UpdateBy,
    @UpdateIP
)


COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_Question_Select]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PRD_Question_Select]


AS
BEGIN TRY
BEGIN TRAN

SELECT 
		[dbo].[PRD_Question].[QuestionID],
        [dbo].[PRD_Question].[QuestionName],
        [dbo].[PRD_Question].[ItemTypeID],
        [dbo].[ITM_ItemType].[ItemTypeName],
        [dbo].[PRD_Question].[Description],
        [dbo].[PRD_Question].[UpdateBy],
        [UpdateBy].[UserDisplayName] AS [UpdateBy]
FROM    [dbo].[PRD_Question]

INNER JOIN [dbo].[SEC_User] AS [UpdateBy]
ON      [UpdateBy].[UserID] = [dbo].[PRD_Question].[UpdateBy]

INNER JOIN [dbo].[ITM_ItemType]
ON      [dbo].[ITM_ItemType].[ItemTypeID] = [dbo].[PRD_Question].[ItemTypeID]



COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_Question_SelectForDropDown]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PRD_Question_SelectForDropDown]

AS

BEGIN TRY
BEGIN TRAN

SELECT 
        [dbo].[PRD_Question].[QuestionID],
        [dbo].[PRD_Question].[QuestionName]
FROM    [dbo].[PRD_Question]

COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_Question_SelectPK]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PRD_Question_SelectPK]

        @QuestionID int

AS

BEGIN TRY
BEGIN TRAN

SELECT
        [dbo].[PRD_Question].[QuestionID],
        [dbo].[PRD_Question].[QuestionName],
        [dbo].[PRD_Question].[ItemTypeID],
        [dbo].[PRD_Question].[Description],
        [dbo].[PRD_Question].[CreateDateTime],
        [dbo].[PRD_Question].[CreateBy],
        [dbo].[PRD_Question].[CreateIP],
        [dbo].[PRD_Question].[UpdateDateTime],
        [dbo].[PRD_Question].[UpdateBy],
        [dbo].[PRD_Question].[UpdateIP]
FROM    [dbo].[PRD_Question]

WHERE   [dbo].[PRD_Question].[QuestionID] = @QuestionID

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_PRD_Question_Update]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_PRD_Question_Update]

    @QuestionID int,
    @QuestionName nvarchar(500),
    @ItemTypeID int,
    @Description nvarchar(MAX),
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS
BEGIN TRY
BEGIN TRAN

UPDATE [dbo].[PRD_Question]
SET
		
    [dbo].[PRD_Question].[QuestionName] = @QuestionName,
    [dbo].[PRD_Question].[ItemTypeID] = @ItemTypeID,
    [dbo].[PRD_Question].[Description] = @Description,
    [dbo].[PRD_Question].[UpdateDateTime] = @UpdateDateTime,
    [dbo].[PRD_Question].[UpdateBy] = @UpdateBy,
    [dbo].[PRD_Question].[UpdateIP] = @UpdateIP

WHERE
	[dbo].[PRD_Question].[QuestionID] = @QuestionID


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_Menu_Delete]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_SEC_Menu_Delete]

    @MenuID int

AS
BEGIN TRY
BEGIN TRAN

DELETE FROM [dbo].[SEC_Menu]
WHERE [dbo].[SEC_Menu].[MenuID] = @MenuID

DELETE FROM [dbo].[SEC_UserWiseMenu]
WHERE [dbo].[SEC_UserWiseMenu].[MenuID] = @MenuID AND [dbo].[SEC_UserWiseMenu].UserID = 1

COMMIT TRAN
END TRY

BEGIN CATCH

IF @@TRANCOUNT > 0
		
	BEGIN
        ROLLBACK TRAN
    END

    ; THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_Menu_Insert]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SEC_Menu_Insert]

	@MenuID int output,
    @MenuName nvarchar(100),
    @MenuImagePath nvarchar(250),
    @MenuURL nvarchar(MAX),
    @MenuSequence decimal,
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS

BEGIN TRY
BEGIN TRAN

INSERT INTO [dbo].[SEC_Menu]
(
    [dbo].[SEC_Menu].[MenuName],
    [dbo].[SEC_Menu].[MenuImagePath],
    [dbo].[SEC_Menu].[MenuURL],
    [dbo].[SEC_Menu].[MenuSequence],
    [dbo].[SEC_Menu].[CreateDateTime],
    [dbo].[SEC_Menu].[CreateBy],
    [dbo].[SEC_Menu].[CreateIP],
    [dbo].[SEC_Menu].[UpdateDateTime],
    [dbo].[SEC_Menu].[UpdateBy],
    [dbo].[SEC_Menu].[UpdateIP]
)
VALUES
(
    @MenuName,
    @MenuImagePath,
    @MenuURL,
    @MenuSequence,
    @CreateDateTime,
    @CreateBy,
    @CreateIP,
    @UpdateDateTime,
    @UpdateBy,
    @UpdateIP
)

SET @MenuID = SCOPE_IDENTITY()

INSERT INTO [dbo].[SEC_UserWiseMenu]
(
    [dbo].[SEC_UserWiseMenu].[UserID],
    [dbo].[SEC_UserWiseMenu].[MenuID]
)
VALUES
(
    1,
    @MenuID
)



COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_Menu_Select]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SEC_Menu_Select]


AS
BEGIN TRY
BEGIN TRAN

SELECT
		[dbo].[SEC_Menu].[MenuID],
        [dbo].[SEC_Menu].[MenuName],
        [dbo].[SEC_Menu].[MenuURL],
        [dbo].[SEC_Menu].[MenuSequence],
        [dbo].[SEC_Menu].[UpdateBy],
        [UpdateBy].[UserDisplayName] AS [UpdateBy]
FROM    [dbo].[SEC_Menu]

INNER JOIN [dbo].[SEC_User] AS [UpdateBy]
ON      [UpdateBy].[UserID] = [dbo].[SEC_Menu].[UpdateBy]



COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_Menu_SelectForDropDown]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SEC_Menu_SelectForDropDown]

AS

BEGIN TRY
BEGIN TRAN

SELECT 
        [dbo].[SEC_Menu].[MenuID],
        [dbo].[SEC_Menu].[MenuName]
FROM    [dbo].[SEC_Menu]

COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_Menu_SelectPK]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SEC_Menu_SelectPK]

        @MenuID int

AS

BEGIN TRY
BEGIN TRAN

SELECT
        [dbo].[SEC_Menu].[MenuID],
        [dbo].[SEC_Menu].[MenuName],
        [dbo].[SEC_Menu].[MenuImagePath],
        [dbo].[SEC_Menu].[MenuURL],
        [dbo].[SEC_Menu].[MenuSequence],
        [dbo].[SEC_Menu].[CreateDateTime],
        [dbo].[SEC_Menu].[CreateBy],
        [dbo].[SEC_Menu].[CreateIP],
        [dbo].[SEC_Menu].[UpdateDateTime],
        [dbo].[SEC_Menu].[UpdateBy],
        [dbo].[SEC_Menu].[UpdateIP]
FROM    [dbo].[SEC_Menu]

WHERE   [dbo].[SEC_Menu].[MenuID] = @MenuID

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_Menu_Update]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_SEC_Menu_Update]

    @MenuID int,
    @MenuName nvarchar(100),
    @MenuImagePath nvarchar(250),
    @MenuURL nvarchar(MAX),
    @MenuSequence decimal,
    @CreateDateTime datetime,
    @CreateBy int,
    @CreateIP nvarchar(50),
    @UpdateDateTime datetime,
    @UpdateBy int,
    @UpdateIP nvarchar(50)

AS
BEGIN TRY
BEGIN TRAN

UPDATE [dbo].[SEC_Menu]
SET
		
    [dbo].[SEC_Menu].[MenuName] = @MenuName,
    [dbo].[SEC_Menu].[MenuImagePath] = @MenuImagePath,
    [dbo].[SEC_Menu].[MenuURL] = @MenuURL,
    [dbo].[SEC_Menu].[MenuSequence] = @MenuSequence,
    [dbo].[SEC_Menu].[UpdateDateTime] = @UpdateDateTime,
    [dbo].[SEC_Menu].[UpdateBy] = @UpdateBy,
    [dbo].[SEC_Menu].[UpdateIP] = @UpdateIP

WHERE
	[dbo].[SEC_Menu].[MenuID] = @MenuID


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_User_Delete]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_SEC_User_Delete]

    @UserID int

AS
BEGIN TRY
BEGIN TRAN

DELETE FROM [dbo].[SEC_User]
WHERE [dbo].[SEC_User].[UserID] = @UserID

COMMIT TRAN
END TRY

BEGIN CATCH

IF @@TRANCOUNT > 0
		
	BEGIN
        ROLLBACK TRAN
    END

    ; THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_User_Insert]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SEC_User_Insert]

    @UserID int OUTPUT,
    @UserName nvarchar(100),
    @UserDisplayName nvarchar(100),
    @UserPassword nvarchar(100),
    @Description nvarchar(500),
    @CreateDateTime datetime,
    @CreateIP nvarchar(100),
    @CreateBy int,
    @UpdateDateTime datetime,
    @UpdateIP nvarchar(100),
    @UpdateBy int

AS

BEGIN TRY
BEGIN TRAN

INSERT INTO [dbo].[SEC_User]
(
    [dbo].[SEC_User].[UserName],
    [dbo].[SEC_User].[UserDisplayName],
    [dbo].[SEC_User].[UserPassword],
    [dbo].[SEC_User].[Description],
    [dbo].[SEC_User].[CreateDateTime],
    [dbo].[SEC_User].[CreateIP],
    [dbo].[SEC_User].[CreateBy],
    [dbo].[SEC_User].[UpdateDateTime],
    [dbo].[SEC_User].[UpdateIP],
    [dbo].[SEC_User].[UpdateBy]
)
VALUES
(
    @UserName,
    @UserDisplayName,
    @UserPassword,
    @Description,
    @CreateDateTime,
    @CreateIP,
    @CreateBy,
    @UpdateDateTime,
    @UpdateIP,
    @UpdateBy
)

SET @UserID = SCOPE_IDENTITY()

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_User_Select]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SEC_User_Select]


AS
BEGIN TRY
BEGIN TRAN

SELECT	
		[dbo].[SEC_User].[UserID],
        [dbo].[SEC_User].[UserName],
        [dbo].[SEC_User].[UserDisplayName],
        [dbo].[SEC_User].[Description]
FROM    [dbo].[SEC_User]
WHERE	[dbo].[SEC_User].[UserID]!=1



COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_User_SelectForDropDown]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SEC_User_SelectForDropDown]

AS

BEGIN TRY
BEGIN TRAN

SELECT 
        [dbo].[SEC_User].[UserID],
        [dbo].[SEC_User].[UserDisplayName]
FROM    [dbo].[SEC_User]
WHERE	[dbo].[SEC_User].[UserID]!=1

COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_User_SelectPK]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SEC_User_SelectPK]

        @UserID int

AS

BEGIN TRY
BEGIN TRAN

SELECT
        [dbo].[SEC_User].[UserID],
        [dbo].[SEC_User].[UserName],
        [dbo].[SEC_User].[UserDisplayName],
        [dbo].[SEC_User].[UserPassword],
        [dbo].[SEC_User].[Description],
        [dbo].[SEC_User].[CreateDateTime],
        [dbo].[SEC_User].[CreateIP],
        [dbo].[SEC_User].[CreateBy],
        [dbo].[SEC_User].[UpdateDateTime],
        [dbo].[SEC_User].[UpdateIP],
        [dbo].[SEC_User].[UpdateBy]
FROM    [dbo].[SEC_User]

WHERE   [dbo].[SEC_User].[UserID] = @UserID

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_User_Update]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_SEC_User_Update]

    @UserID int,
    @UserName nvarchar(100),
    @UserDisplayName nvarchar(100),
    @UserPassword nvarchar(100),
    @Description nvarchar(500),
    @CreateDateTime datetime,
    @CreateIP nvarchar(100),
    @CreateBy int,
    @UpdateDateTime datetime,
    @UpdateIP nvarchar(100),
    @UpdateBy int

AS
BEGIN TRY
BEGIN TRAN

UPDATE [dbo].[SEC_User]
SET
		
    [dbo].[SEC_User].[UserName] = @UserName,
    [dbo].[SEC_User].[UserDisplayName] = @UserDisplayName,
    [dbo].[SEC_User].[UserPassword] = @UserPassword,
    [dbo].[SEC_User].[Description] = @Description,
    [dbo].[SEC_User].[CreateDateTime] = @CreateDateTime,
    [dbo].[SEC_User].[CreateIP] = @CreateIP,
    [dbo].[SEC_User].[CreateBy] = @CreateBy,
    [dbo].[SEC_User].[UpdateDateTime] = @UpdateDateTime,
    [dbo].[SEC_User].[UpdateIP] = @UpdateIP,
    [dbo].[SEC_User].[UpdateBy] = @UpdateBy

WHERE
	[dbo].[SEC_User].[UserID] = @UserID


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_UserWiseMenu_Delete]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_SEC_UserWiseMenu_Delete]

    @UserID int

AS
BEGIN TRY
BEGIN TRAN

DELETE FROM [dbo].[SEC_UserWiseMenu]
where [dbo].[SEC_UserWiseMenu].[UserID] = @UserID


COMMIT TRAN
END TRY

BEGIN CATCH

IF @@TRANCOUNT > 0
		
	BEGIN
        ROLLBACK TRAN
    END

    ; THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_UserWiseMenu_Insert]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SEC_UserWiseMenu_Insert]

    @UserID int,
    @MenuID int

AS

BEGIN TRY
BEGIN TRAN

INSERT INTO [dbo].[SEC_UserWiseMenu]
(
    [dbo].[SEC_UserWiseMenu].[UserID],
    [dbo].[SEC_UserWiseMenu].[MenuID]
)
VALUES
(
    @UserID,
    @MenuID
)


COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_UserWiseMenu_Select]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SEC_UserWiseMenu_Select]

        @UserID int

AS
BEGIN TRY
BEGIN TRAN

select * from [dbo].[SEC_Menu]
left outer join [dbo].[SEC_UserWiseMenu]
ON [dbo].[SEC_UserWiseMenu].[MenuID] = [dbo].[SEC_Menu].[MenuID]
AND [dbo].[SEC_UserWiseMenu].[UserID] = @UserID


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_UserWiseMenu_SelectForDropDown]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SEC_UserWiseMenu_SelectForDropDown]

AS

BEGIN TRY
BEGIN TRAN

SELECT 
*
FROM    [dbo].[SEC_UserWiseMenu]

COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_UserWiseMenu_SelectPK]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SEC_UserWiseMenu_SelectPK]

        @UserWiseMenuID int

AS

BEGIN TRY
BEGIN TRAN

SELECT
        [dbo].[SEC_UserWiseMenu].[UserWiseMenuID],
        [dbo].[SEC_UserWiseMenu].[UserID],
        [dbo].[SEC_UserWiseMenu].[MenuID]
FROM    [dbo].[SEC_UserWiseMenu]

WHERE   [dbo].[SEC_UserWiseMenu].[UserWiseMenuID] = @UserWiseMenuID

COMMIT TRAN
END TRY

BEGIN CATCH

    IF @@TRANCOUNT > 0

    BEGIN
        ROLLBACK TRAN
    END
    
    ;THROW

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[SP_SEC_UserWiseMenu_Update]    Script Date: 30-09-2022 7.21.18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE[dbo].[SP_SEC_UserWiseMenu_Update]

    @UserWiseMenuID int,
    @UserID int,
    @MenuID int

AS
BEGIN TRY
BEGIN TRAN

UPDATE [dbo].[SEC_UserWiseMenu]
SET
		
    [dbo].[SEC_UserWiseMenu].[UserID] = @UserID,
    [dbo].[SEC_UserWiseMenu].[MenuID] = @MenuID

WHERE
	[dbo].[SEC_UserWiseMenu].[UserWiseMenuID] = @UserWiseMenuID


COMMIT TRAN
END TRY

BEGIN CATCH
IF @@TRANCOUNT > 0
	BEGIN
		ROLLBACK TRAN
	END
;THROW
END CATCH
GO
USE [master]
GO
ALTER DATABASE [CostingEvalution] SET  READ_WRITE 
GO
