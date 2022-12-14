USE [CostingEvalution]
GO
/****** Object:  Table [dbo].[EMP_Employee]    Script Date: 8/15/2022 8:48:30 PM ******/
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
/****** Object:  Table [dbo].[EMP_EmployeeType]    Script Date: 8/15/2022 8:48:30 PM ******/
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
/****** Object:  Table [dbo].[EMP_EmployeeWiseDepartment]    Script Date: 8/15/2022 8:48:30 PM ******/
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
/****** Object:  Table [dbo].[ITM_Item]    Script Date: 8/15/2022 8:48:30 PM ******/
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
/****** Object:  Table [dbo].[ITM_ItemType]    Script Date: 8/15/2022 8:48:30 PM ******/
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
/****** Object:  Table [dbo].[ITM_ItemWiseMainModel]    Script Date: 8/15/2022 8:48:30 PM ******/
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
/****** Object:  Table [dbo].[ITM_ItemWiseOperation]    Script Date: 8/15/2022 8:48:30 PM ******/
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
/****** Object:  Table [dbo].[ITM_ItemWiseRawMaterial]    Script Date: 8/15/2022 8:48:30 PM ******/
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
/****** Object:  Table [dbo].[MST_Department]    Script Date: 8/15/2022 8:48:30 PM ******/
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
/****** Object:  Table [dbo].[MST_RawMaterial]    Script Date: 8/15/2022 8:48:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MST_RawMaterial](
	[RawMaterialID] [int] IDENTITY(1,1) NOT NULL,
	[RawMaterialName] [nvarchar](100) NOT NULL,
	[UnitID] [int] NOT NULL,
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
/****** Object:  Table [dbo].[MST_Unit]    Script Date: 8/15/2022 8:48:30 PM ******/
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
/****** Object:  Table [dbo].[PRD_MainModel]    Script Date: 8/15/2022 8:48:30 PM ******/
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
/****** Object:  Table [dbo].[PRD_MainModelWiseQuestion]    Script Date: 8/15/2022 8:48:30 PM ******/
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
/****** Object:  Table [dbo].[PRD_Question]    Script Date: 8/15/2022 8:48:30 PM ******/
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
/****** Object:  Table [dbo].[SEC_Menu]    Script Date: 8/15/2022 8:48:30 PM ******/
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
/****** Object:  Table [dbo].[SEC_User]    Script Date: 8/15/2022 8:48:30 PM ******/
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
/****** Object:  Table [dbo].[SEC_UserWiseMenu]    Script Date: 8/15/2022 8:48:30 PM ******/
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
SET IDENTITY_INSERT [dbo].[SEC_User] ON 

INSERT [dbo].[SEC_User] ([UserID], [UserName], [UserDisplayName], [UserPassword], [Description], [CreateDateTime], [CreateIP], [CreateBy], [UpdateDateTime], [UpdateIP], [UpdateBy]) VALUES (1, N'Admin', N'Admin', N'admin', N'Admin', CAST(N'2022-08-14T19:22:46.807' AS DateTime), N'0.0.0.0', 1, CAST(N'2022-08-14T19:22:46.807' AS DateTime), N'0.0.0.0', 1)
SET IDENTITY_INSERT [dbo].[SEC_User] OFF
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
