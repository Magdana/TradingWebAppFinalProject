USE [TradingWarehouseDataBase]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 28-Sep-23 10:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ContainingCountryCountryId] [int] NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 28-Sep-23 10:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryId] [int] IDENTITY(1,1) NOT NULL,
	[CountryCode] [nvarchar](9) NOT NULL,
	[CountryName] [nvarchar](70) NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerPhoneNumbers]    Script Date: 28-Sep-23 10:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerPhoneNumbers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PhoneTypeId] [int] NOT NULL,
	[PhoneNumberId] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
 CONSTRAINT [PK_CustomerPhoneNumbers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 28-Sep-23 10:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[GenderId] [int] NULL,
	[PersonalNumber] [nvarchar](11) NOT NULL,
	[BirthDate] [datetime2](7) NOT NULL,
	[CityId] [int] NULL,
	[Email] [nvarchar](max) NOT NULL,
	[CountryId] [int] NULL,
	[RelationshipTypeId] [int] NULL,
	[FullAddres] [nvarchar](max) NULL,
	[PhoneNumbersListId] [int] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomersRelationships]    Script Date: 28-Sep-23 10:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomersRelationships](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RelationshipTypeId] [int] NOT NULL,
	[StartCustomerId] [int] NULL,
	[EndCustomerId] [int] NULL,
	[Comment] [nvarchar](100) NULL,
 CONSTRAINT [PK_CustomersRelationships] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genders]    Script Date: 28-Sep-23 10:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Genders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 28-Sep-23 10:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitPrice] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
	[DiscountPrice] [float] NULL,
	[IsDiscounted] [bit] NOT NULL,
 CONSTRAINT [PK_OrderItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 28-Sep-23 10:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[TotalAmount] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhoneNumbersLists]    Script Date: 28-Sep-23 10:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhoneNumbersLists](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsMain] [bit] NOT NULL,
	[PhoneTypeId] [int] NULL,
	[PhoneNumber] [nvarchar](9) NOT NULL,
 CONSTRAINT [PK_PhoneNumbersLists] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhoneTypes]    Script Date: 28-Sep-23 10:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhoneTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PhoneTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategorys]    Script Date: 28-Sep-23 10:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategorys](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](9) NOT NULL,
	[Name] [nvarchar](70) NOT NULL,
 CONSTRAINT [PK_ProductCategorys] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 28-Sep-23 10:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](9) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[CategoryId] [int] NULL,
	[Discount] [bit] NOT NULL,
	[DiscountAmount] [float] NULL,
	[ManufacturingDate] [datetime2](7) NULL,
	[Price] [float] NOT NULL,
	[RealizationPrice] [float] NOT NULL,
	[ShelfLife] [datetime2](7) NULL,
	[UnitId] [int] NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RelationshipTypes]    Script Date: 28-Sep-23 10:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RelationshipTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_RelationshipTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 28-Sep-23 10:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyCode] [nvarchar](9) NOT NULL,
	[CompanyName] [nvarchar](50) NOT NULL,
	[ContactFullName] [nvarchar](70) NOT NULL,
	[CityId] [int] NOT NULL,
	[Phone] [int] NOT NULL,
	[Fax] [int] NOT NULL,
	[WebSite] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Units]    Script Date: 28-Sep-23 10:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Units](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[ShortName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Units] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cities] ON 

INSERT [dbo].[Cities] ([Id], [Name], [ContainingCountryCountryId]) VALUES (31, N'ახალციხე', 37)
INSERT [dbo].[Cities] ([Id], [Name], [ContainingCountryCountryId]) VALUES (32, N'ბერლინი', 39)
INSERT [dbo].[Cities] ([Id], [Name], [ContainingCountryCountryId]) VALUES (33, N'string', 41)
SET IDENTITY_INSERT [dbo].[Cities] OFF
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([CountryId], [CountryCode], [CountryName]) VALUES (22, N'string', N'string')
INSERT [dbo].[Countries] ([CountryId], [CountryCode], [CountryName]) VALUES (37, N'268', N'საქართველო')
INSERT [dbo].[Countries] ([CountryId], [CountryCode], [CountryName]) VALUES (38, N'268', N'საქართელო')
INSERT [dbo].[Countries] ([CountryId], [CountryCode], [CountryName]) VALUES (39, N'726', N'გერმანია')
INSERT [dbo].[Countries] ([CountryId], [CountryCode], [CountryName]) VALUES (40, N'726', N'გერმანია')
INSERT [dbo].[Countries] ([CountryId], [CountryCode], [CountryName]) VALUES (41, N'string', N'string')
INSERT [dbo].[Countries] ([CountryId], [CountryCode], [CountryName]) VALUES (42, N'string', N'string')
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [GenderId], [PersonalNumber], [BirthDate], [CityId], [Email], [CountryId], [RelationshipTypeId], [FullAddres], [PhoneNumbersListId]) VALUES (15, N'string', N'string', 11, N'string', CAST(N'2023-09-28T06:28:32.4450000' AS DateTime2), 33, N'string', 42, NULL, N'string', 11)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Genders] ON 

INSERT [dbo].[Genders] ([Id], [Name]) VALUES (1, N'string')
INSERT [dbo].[Genders] ([Id], [Name]) VALUES (2, N'string')
INSERT [dbo].[Genders] ([Id], [Name]) VALUES (3, N'string')
INSERT [dbo].[Genders] ([Id], [Name]) VALUES (4, N'string')
INSERT [dbo].[Genders] ([Id], [Name]) VALUES (5, N'string')
INSERT [dbo].[Genders] ([Id], [Name]) VALUES (6, N'string')
INSERT [dbo].[Genders] ([Id], [Name]) VALUES (7, N'string')
INSERT [dbo].[Genders] ([Id], [Name]) VALUES (8, N'string')
INSERT [dbo].[Genders] ([Id], [Name]) VALUES (9, N'მდედრობითი')
INSERT [dbo].[Genders] ([Id], [Name]) VALUES (10, N'მდედრობითი')
INSERT [dbo].[Genders] ([Id], [Name]) VALUES (11, N'string')
SET IDENTITY_INSERT [dbo].[Genders] OFF
GO
SET IDENTITY_INSERT [dbo].[PhoneNumbersLists] ON 

INSERT [dbo].[PhoneNumbersLists] ([Id], [IsMain], [PhoneTypeId], [PhoneNumber]) VALUES (1, 1, 1, N'string')
INSERT [dbo].[PhoneNumbersLists] ([Id], [IsMain], [PhoneTypeId], [PhoneNumber]) VALUES (2, 1, 2, N'string')
INSERT [dbo].[PhoneNumbersLists] ([Id], [IsMain], [PhoneTypeId], [PhoneNumber]) VALUES (3, 1, 3, N'string')
INSERT [dbo].[PhoneNumbersLists] ([Id], [IsMain], [PhoneTypeId], [PhoneNumber]) VALUES (4, 1, 4, N'string')
INSERT [dbo].[PhoneNumbersLists] ([Id], [IsMain], [PhoneTypeId], [PhoneNumber]) VALUES (5, 1, 5, N'string')
INSERT [dbo].[PhoneNumbersLists] ([Id], [IsMain], [PhoneTypeId], [PhoneNumber]) VALUES (6, 1, 6, N'string')
INSERT [dbo].[PhoneNumbersLists] ([Id], [IsMain], [PhoneTypeId], [PhoneNumber]) VALUES (7, 1, 7, N'string')
INSERT [dbo].[PhoneNumbersLists] ([Id], [IsMain], [PhoneTypeId], [PhoneNumber]) VALUES (8, 1, 8, N'string')
INSERT [dbo].[PhoneNumbersLists] ([Id], [IsMain], [PhoneTypeId], [PhoneNumber]) VALUES (9, 1, 9, N'591448857')
INSERT [dbo].[PhoneNumbersLists] ([Id], [IsMain], [PhoneTypeId], [PhoneNumber]) VALUES (10, 1, 10, N'599605784')
INSERT [dbo].[PhoneNumbersLists] ([Id], [IsMain], [PhoneTypeId], [PhoneNumber]) VALUES (11, 1, 11, N'string')
SET IDENTITY_INSERT [dbo].[PhoneNumbersLists] OFF
GO
SET IDENTITY_INSERT [dbo].[PhoneTypes] ON 

INSERT [dbo].[PhoneTypes] ([Id], [Name]) VALUES (1, N'string')
INSERT [dbo].[PhoneTypes] ([Id], [Name]) VALUES (2, N'string')
INSERT [dbo].[PhoneTypes] ([Id], [Name]) VALUES (3, N'string')
INSERT [dbo].[PhoneTypes] ([Id], [Name]) VALUES (4, N'string')
INSERT [dbo].[PhoneTypes] ([Id], [Name]) VALUES (5, N'string')
INSERT [dbo].[PhoneTypes] ([Id], [Name]) VALUES (6, N'string')
INSERT [dbo].[PhoneTypes] ([Id], [Name]) VALUES (7, N'string')
INSERT [dbo].[PhoneTypes] ([Id], [Name]) VALUES (8, N'string')
INSERT [dbo].[PhoneTypes] ([Id], [Name]) VALUES (9, N'მობილური')
INSERT [dbo].[PhoneTypes] ([Id], [Name]) VALUES (10, N'მობილური')
INSERT [dbo].[PhoneTypes] ([Id], [Name]) VALUES (11, N'string')
SET IDENTITY_INSERT [dbo].[PhoneTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductCategorys] ON 

INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (3, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (4, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (7, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (8, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (9, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (10, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (11, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (12, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (13, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (14, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (15, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (16, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (17, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (18, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (19, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (20, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (21, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (22, N'string', N'string')
INSERT [dbo].[ProductCategorys] ([Id], [Code], [Name]) VALUES (23, N'string', N'string')
SET IDENTITY_INSERT [dbo].[ProductCategorys] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Code], [Name], [CategoryId], [Discount], [DiscountAmount], [ManufacturingDate], [Price], [RealizationPrice], [ShelfLife], [UnitId], [Quantity]) VALUES (5, N'string', N'string', 9, 1, 0, CAST(N'2023-09-27T21:59:30.2790000' AS DateTime2), 0, 0, CAST(N'2023-09-27T21:59:30.2790000' AS DateTime2), 9, 0)
INSERT [dbo].[Products] ([Id], [Code], [Name], [CategoryId], [Discount], [DiscountAmount], [ManufacturingDate], [Price], [RealizationPrice], [ShelfLife], [UnitId], [Quantity]) VALUES (6, N'string', N'string', 10, 1, 0, CAST(N'2023-09-27T21:59:30.2790000' AS DateTime2), 0, 0, CAST(N'2023-09-27T21:59:30.2790000' AS DateTime2), 10, 0)
INSERT [dbo].[Products] ([Id], [Code], [Name], [CategoryId], [Discount], [DiscountAmount], [ManufacturingDate], [Price], [RealizationPrice], [ShelfLife], [UnitId], [Quantity]) VALUES (7, N'string', N'string', 11, 1, 0, CAST(N'2023-09-27T21:59:30.2790000' AS DateTime2), 0, 0, CAST(N'2023-09-27T21:59:30.2790000' AS DateTime2), 11, 0)
INSERT [dbo].[Products] ([Id], [Code], [Name], [CategoryId], [Discount], [DiscountAmount], [ManufacturingDate], [Price], [RealizationPrice], [ShelfLife], [UnitId], [Quantity]) VALUES (8, N'string', N'string', 17, 1, 0, CAST(N'2023-09-28T06:12:31.7390000' AS DateTime2), 0, 0, CAST(N'2023-09-28T06:12:31.7390000' AS DateTime2), 17, 0)
INSERT [dbo].[Products] ([Id], [Code], [Name], [CategoryId], [Discount], [DiscountAmount], [ManufacturingDate], [Price], [RealizationPrice], [ShelfLife], [UnitId], [Quantity]) VALUES (9, N'string', N'string', 18, 1, 0, CAST(N'2023-09-28T06:12:31.7390000' AS DateTime2), 0, 0, CAST(N'2023-09-28T06:12:31.7390000' AS DateTime2), 18, 0)
INSERT [dbo].[Products] ([Id], [Code], [Name], [CategoryId], [Discount], [DiscountAmount], [ManufacturingDate], [Price], [RealizationPrice], [ShelfLife], [UnitId], [Quantity]) VALUES (10, N'ma', N'string', 19, 1, 0, CAST(N'2023-09-28T06:12:31.7390000' AS DateTime2), 0, 0, CAST(N'2023-09-28T06:12:31.7390000' AS DateTime2), 19, 0)
INSERT [dbo].[Products] ([Id], [Code], [Name], [CategoryId], [Discount], [DiscountAmount], [ManufacturingDate], [Price], [RealizationPrice], [ShelfLife], [UnitId], [Quantity]) VALUES (11, N'ma', N'string', 20, 1, 0, CAST(N'2023-09-28T06:15:55.9640000' AS DateTime2), 0, 0, CAST(N'2023-09-28T06:15:55.9640000' AS DateTime2), 20, 0)
INSERT [dbo].[Products] ([Id], [Code], [Name], [CategoryId], [Discount], [DiscountAmount], [ManufacturingDate], [Price], [RealizationPrice], [ShelfLife], [UnitId], [Quantity]) VALUES (12, N'ma', N'string', 21, 1, 0, CAST(N'2023-09-28T06:16:47.4740000' AS DateTime2), 0, 0, CAST(N'2023-09-28T06:16:47.4740000' AS DateTime2), 21, 0)
INSERT [dbo].[Products] ([Id], [Code], [Name], [CategoryId], [Discount], [DiscountAmount], [ManufacturingDate], [Price], [RealizationPrice], [ShelfLife], [UnitId], [Quantity]) VALUES (13, N'vashli', N'string', 22, 1, 0, CAST(N'2023-09-28T06:18:06.6440000' AS DateTime2), 0, 0, CAST(N'2023-09-28T06:18:06.6440000' AS DateTime2), 22, 0)
INSERT [dbo].[Products] ([Id], [Code], [Name], [CategoryId], [Discount], [DiscountAmount], [ManufacturingDate], [Price], [RealizationPrice], [ShelfLife], [UnitId], [Quantity]) VALUES (14, N'vashlli', N'string', 23, 1, 0, CAST(N'2023-09-28T06:20:22.5720000' AS DateTime2), 0, 0, CAST(N'2023-09-28T06:20:22.5720000' AS DateTime2), 23, 0)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Units] ON 

INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (3, N'string', N'strin')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (4, N'string', N'strin')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (7, N'string', N'string')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (8, N'string', N'string')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (9, N'string', N'string')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (10, N'string', N'string')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (11, N'string', N'string')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (12, N'string', N'string')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (13, N'string', N'string')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (14, N'string', N'string')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (15, N'string', N'string')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (16, N'string', N'string')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (17, N'string', N'string')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (18, N'string', N'string')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (19, N'string', N'string')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (20, N'string', N'string')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (21, N'string', N'string')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (22, N'string', N'string')
INSERT [dbo].[Units] ([Id], [Name], [ShortName]) VALUES (23, N'string', N'string')
SET IDENTITY_INSERT [dbo].[Units] OFF
GO
ALTER TABLE [dbo].[OrderItems] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDiscounted]
GO
ALTER TABLE [dbo].[PhoneNumbersLists] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsMain]
GO
ALTER TABLE [dbo].[PhoneNumbersLists] ADD  DEFAULT (N'') FOR [PhoneNumber]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT (CONVERT([bit],(0))) FOR [Discount]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [Price]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [RealizationPrice]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Cities]  WITH CHECK ADD  CONSTRAINT [FK_Cities_Countries_ContainingCountryCountryId] FOREIGN KEY([ContainingCountryCountryId])
REFERENCES [dbo].[Countries] ([CountryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cities] CHECK CONSTRAINT [FK_Cities_Countries_ContainingCountryCountryId]
GO
ALTER TABLE [dbo].[CustomerPhoneNumbers]  WITH CHECK ADD  CONSTRAINT [FK_CustomerPhoneNumbers_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerPhoneNumbers] CHECK CONSTRAINT [FK_CustomerPhoneNumbers_Customers_CustomerId]
GO
ALTER TABLE [dbo].[CustomerPhoneNumbers]  WITH CHECK ADD  CONSTRAINT [FK_CustomerPhoneNumbers_PhoneNumbersLists_PhoneNumberId] FOREIGN KEY([PhoneNumberId])
REFERENCES [dbo].[PhoneNumbersLists] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerPhoneNumbers] CHECK CONSTRAINT [FK_CustomerPhoneNumbers_PhoneNumbersLists_PhoneNumberId]
GO
ALTER TABLE [dbo].[CustomerPhoneNumbers]  WITH CHECK ADD  CONSTRAINT [FK_CustomerPhoneNumbers_PhoneTypes_PhoneTypeId] FOREIGN KEY([PhoneTypeId])
REFERENCES [dbo].[PhoneTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerPhoneNumbers] CHECK CONSTRAINT [FK_CustomerPhoneNumbers_PhoneTypes_PhoneTypeId]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Cities_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Cities_CityId]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Countries_CountryId] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([CountryId])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Countries_CountryId]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Genders_GenderId] FOREIGN KEY([GenderId])
REFERENCES [dbo].[Genders] ([Id])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Genders_GenderId]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_PhoneNumbersLists_PhoneNumbersListId] FOREIGN KEY([PhoneNumbersListId])
REFERENCES [dbo].[PhoneNumbersLists] ([Id])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_PhoneNumbersLists_PhoneNumbersListId]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_RelationshipTypes_RelationshipTypeId] FOREIGN KEY([RelationshipTypeId])
REFERENCES [dbo].[RelationshipTypes] ([Id])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_RelationshipTypes_RelationshipTypeId]
GO
ALTER TABLE [dbo].[CustomersRelationships]  WITH CHECK ADD  CONSTRAINT [FK_CustomersRelationships_Customers_EndCustomerId] FOREIGN KEY([EndCustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[CustomersRelationships] CHECK CONSTRAINT [FK_CustomersRelationships_Customers_EndCustomerId]
GO
ALTER TABLE [dbo].[CustomersRelationships]  WITH CHECK ADD  CONSTRAINT [FK_CustomersRelationships_Customers_StartCustomerId] FOREIGN KEY([StartCustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[CustomersRelationships] CHECK CONSTRAINT [FK_CustomersRelationships_Customers_StartCustomerId]
GO
ALTER TABLE [dbo].[CustomersRelationships]  WITH CHECK ADD  CONSTRAINT [FK_CustomersRelationships_RelationshipTypes_RelationshipTypeId] FOREIGN KEY([RelationshipTypeId])
REFERENCES [dbo].[RelationshipTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomersRelationships] CHECK CONSTRAINT [FK_CustomersRelationships_RelationshipTypes_RelationshipTypeId]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Orders_OrderId]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Products_ProductId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers_CustomerId]
GO
ALTER TABLE [dbo].[PhoneNumbersLists]  WITH CHECK ADD  CONSTRAINT [FK_PhoneNumbersLists_PhoneTypes_PhoneTypeId] FOREIGN KEY([PhoneTypeId])
REFERENCES [dbo].[PhoneTypes] ([Id])
GO
ALTER TABLE [dbo].[PhoneNumbersLists] CHECK CONSTRAINT [FK_PhoneNumbersLists_PhoneTypes_PhoneTypeId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ProductCategorys_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[ProductCategorys] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ProductCategorys_CategoryId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Units_UnitId] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Units] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Units_UnitId]
GO
ALTER TABLE [dbo].[Suppliers]  WITH CHECK ADD  CONSTRAINT [FK_Suppliers_Cities_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Suppliers] CHECK CONSTRAINT [FK_Suppliers_Cities_CityId]
GO
