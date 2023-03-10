USE [master]
GO
/****** Object:  Database [Footwear]    Script Date: 08.12.2022 10:17:10 ******/
CREATE DATABASE [Footwear]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Footwear', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Footwear.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Footwear_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Footwear_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Footwear] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Footwear].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Footwear] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Footwear] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Footwear] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Footwear] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Footwear] SET ARITHABORT OFF 
GO
ALTER DATABASE [Footwear] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Footwear] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Footwear] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Footwear] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Footwear] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Footwear] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Footwear] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Footwear] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Footwear] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Footwear] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Footwear] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Footwear] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Footwear] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Footwear] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Footwear] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Footwear] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Footwear] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Footwear] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Footwear] SET  MULTI_USER 
GO
ALTER DATABASE [Footwear] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Footwear] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Footwear] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Footwear] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Footwear] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Footwear] SET QUERY_STORE = OFF
GO
USE [Footwear]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 08.12.2022 10:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Classification]    Script Date: 08.12.2022 10:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classification](
	[ClassificationId] [int] NOT NULL,
	[ClassificationName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Classification] PRIMARY KEY CLUSTERED 
(
	[ClassificationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 08.12.2022 10:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Code] [varchar](6) NOT NULL,
	[LastName] [varchar](100) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[Patronymic] [varbinary](50) NOT NULL,
	[Gender] [char](1) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 08.12.2022 10:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[Code] [varchar](3) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Flag] [binary](100) NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manufacturer]    Script Date: 08.12.2022 10:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturer](
	[ManufacturerId] [int] NOT NULL,
	[ManufacturerName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Manufacturer] PRIMARY KEY CLUSTERED 
(
	[ManufacturerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 08.12.2022 10:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] NOT NULL,
	[OrderCode] [nvarchar](3) NOT NULL,
	[OrderDate] [date] NOT NULL,
	[OrderDateDelivery] [date] NOT NULL,
	[OrderStatusId] [int] NOT NULL,
	[OrderClientId] [int] NULL,
	[OrderPointIssueId] [int] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderContent]    Script Date: 08.12.2022 10:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderContent](
	[OrderContnentId] [int] NOT NULL,
	[OrderContentProduct] [nvarchar](100) NOT NULL,
	[OrderContentCount] [int] NOT NULL,
 CONSTRAINT [PK_OrderContent] PRIMARY KEY CLUSTERED 
(
	[OrderContnentId] ASC,
	[OrderContentProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PointIssue]    Script Date: 08.12.2022 10:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PointIssue](
	[PointIssueId] [int] NOT NULL,
	[PointIssueName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_PointIssue] PRIMARY KEY CLUSTERED 
(
	[PointIssueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 08.12.2022 10:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductArticleNumber] [nvarchar](100) NOT NULL,
	[ProductClassificationId] [int] NOT NULL,
	[ProductDescription] [nvarchar](100) NOT NULL,
	[ProductCategoryId] [int] NOT NULL,
	[ProductPhoto] [nvarchar](100) NULL,
	[ProductManufacuturerId] [int] NOT NULL,
	[ProductCost] [decimal](19, 4) NOT NULL,
	[ProductDiscountMax] [tinyint] NOT NULL,
	[ProductDiscountNow] [tinyint] NOT NULL,
	[ProductQuantityInStock] [int] NOT NULL,
	[ProductUnitId] [int] NOT NULL,
	[ProductProviderId] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductArticleNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 08.12.2022 10:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provider](
	[ProviderId] [int] NOT NULL,
	[ProviderName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Provider] PRIMARY KEY CLUSTERED 
(
	[ProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 08.12.2022 10:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 08.12.2022 10:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusId] [int] NOT NULL,
	[StatusName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 08.12.2022 10:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[UnitId] [int] NOT NULL,
	[UnitName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[UnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 08.12.2022 10:17:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserSecondName] [nvarchar](100) NOT NULL,
	[UserFirstName] [nvarchar](100) NOT NULL,
	[UserPatronymic] [nvarchar](100) NOT NULL,
	[UserLogin] [nvarchar](max) NOT NULL,
	[UserPassword] [nvarchar](max) NOT NULL,
	[UserRole] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (1, N'Женская обувь')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (2, N'Мужская обувь')
GO
INSERT [dbo].[Classification] ([ClassificationId], [ClassificationName]) VALUES (1, N'Ботинки')
INSERT [dbo].[Classification] ([ClassificationId], [ClassificationName]) VALUES (2, N'Кеды')
INSERT [dbo].[Classification] ([ClassificationId], [ClassificationName]) VALUES (3, N'Кроссовки')
INSERT [dbo].[Classification] ([ClassificationId], [ClassificationName]) VALUES (4, N'Полуботинки')
INSERT [dbo].[Classification] ([ClassificationId], [ClassificationName]) VALUES (5, N'Сапоги')
INSERT [dbo].[Classification] ([ClassificationId], [ClassificationName]) VALUES (6, N'Тапочки')
INSERT [dbo].[Classification] ([ClassificationId], [ClassificationName]) VALUES (7, N'Туфли')
GO
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (1, N'Alessio Nesca')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (2, N'CROSBY')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (3, N'Kari')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (4, N'Marco Tozzi')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (5, N'Rieker')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (6, N'Рос')
GO
INSERT [dbo].[Order] ([OrderId], [OrderCode], [OrderDate], [OrderDateDelivery], [OrderStatusId], [OrderClientId], [OrderPointIssueId]) VALUES (1, N'911', CAST(N'2022-05-16' AS Date), CAST(N'2022-05-22' AS Date), 1, 4, 10)
INSERT [dbo].[Order] ([OrderId], [OrderCode], [OrderDate], [OrderDateDelivery], [OrderStatusId], [OrderClientId], [OrderPointIssueId]) VALUES (2, N'912', CAST(N'2022-05-17' AS Date), CAST(N'2022-05-23' AS Date), 2, NULL, 5)
INSERT [dbo].[Order] ([OrderId], [OrderCode], [OrderDate], [OrderDateDelivery], [OrderStatusId], [OrderClientId], [OrderPointIssueId]) VALUES (3, N'913', CAST(N'2022-05-18' AS Date), CAST(N'2022-05-24' AS Date), 2, 5, 11)
INSERT [dbo].[Order] ([OrderId], [OrderCode], [OrderDate], [OrderDateDelivery], [OrderStatusId], [OrderClientId], [OrderPointIssueId]) VALUES (4, N'914', CAST(N'2022-05-19' AS Date), CAST(N'2022-05-25' AS Date), 2, NULL, 10)
INSERT [dbo].[Order] ([OrderId], [OrderCode], [OrderDate], [OrderDateDelivery], [OrderStatusId], [OrderClientId], [OrderPointIssueId]) VALUES (5, N'915', CAST(N'2022-05-20' AS Date), CAST(N'2022-05-26' AS Date), 1, 6, 1)
INSERT [dbo].[Order] ([OrderId], [OrderCode], [OrderDate], [OrderDateDelivery], [OrderStatusId], [OrderClientId], [OrderPointIssueId]) VALUES (6, N'916', CAST(N'2022-05-21' AS Date), CAST(N'2022-05-27' AS Date), 1, NULL, 32)
INSERT [dbo].[Order] ([OrderId], [OrderCode], [OrderDate], [OrderDateDelivery], [OrderStatusId], [OrderClientId], [OrderPointIssueId]) VALUES (7, N'917', CAST(N'2022-05-22' AS Date), CAST(N'2022-05-28' AS Date), 1, NULL, 20)
INSERT [dbo].[Order] ([OrderId], [OrderCode], [OrderDate], [OrderDateDelivery], [OrderStatusId], [OrderClientId], [OrderPointIssueId]) VALUES (8, N'918', CAST(N'2022-05-23' AS Date), CAST(N'2022-05-29' AS Date), 2, NULL, 34)
INSERT [dbo].[Order] ([OrderId], [OrderCode], [OrderDate], [OrderDateDelivery], [OrderStatusId], [OrderClientId], [OrderPointIssueId]) VALUES (9, N'919', CAST(N'2022-05-24' AS Date), CAST(N'2022-05-30' AS Date), 1, NULL, 25)
INSERT [dbo].[Order] ([OrderId], [OrderCode], [OrderDate], [OrderDateDelivery], [OrderStatusId], [OrderClientId], [OrderPointIssueId]) VALUES (10, N'920', CAST(N'2022-05-25' AS Date), CAST(N'2022-05-31' AS Date), 2, NULL, 36)
GO
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (1, N'H782T5', 1)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (1, N'А112Т4', 2)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (2, N'F635R4', 5)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (2, N'G783F5', 6)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (3, N'D572U8', 3)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (3, N'J384T6', 2)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (4, N'B320R5', 3)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (4, N'D329H3', 5)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (5, N'G432E4', 1)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (5, N'S213E3', 2)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (6, N'K345R4', 3)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (6, N'S634B5', 1)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (7, N'G531F4', 2)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (7, N'J542F5', 4)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (8, N'C436G5', 2)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (8, N'P764G4', 1)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (9, N'D364R4', 4)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (9, N'S326R5', 1)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (10, N'D268G5', 5)
INSERT [dbo].[OrderContent] ([OrderContnentId], [OrderContentProduct], [OrderContentCount]) VALUES (10, N'M542T5', 3)
GO
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (1, N'344288, г. Москва, ул. Чехова, 1')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (2, N'614164, г.Москва,  ул. Степная, 30')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (3, N'394242, г. Москва, ул. Коммунистическая, 43')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (4, N'660540, г. Москва, ул. Солнечная, 25')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (5, N'125837, г. Москва, ул. Шоссейная, 40')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (6, N'125703, г. Москва, ул. Партизанская, 49')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (7, N'625283, г. Москва, ул. Победы, 46')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (8, N'614611, г. Москва, ул. Молодежная, 50')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (9, N'454311, г.Москва, ул. Новая, 19')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (10, N'660007, г.Москва, ул. Октябрьская, 19')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (11, N'603036, г. Москва, ул. Садовая, 4')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (12, N'450983, г.Москва, ул. Комсомольская, 26')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (13, N'394782, г. Москва, ул. Чехова, 3')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (14, N'603002, г. Москва, ул. Дзержинского, 28')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (15, N'450558, г. Москва, ул. Набережная, 30')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (16, N'394060, г.Москва, ул. Фрунзе, 43')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (17, N'410661, г. Москва, ул. Школьная, 50')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (18, N'625590, г. Москва, ул. Коммунистическая, 20')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (19, N'625683, г. Москва, ул. 8 Марта')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (20, N'400562, г. Москва, ул. Зеленая, 32')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (21, N'614510, г. Москва, ул. Маяковского, 47')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (22, N'410542, г. Москва, ул. Светлая, 46')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (23, N'620839, г. Москва, ул. Цветочная, 8')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (24, N'443890, г. Москва, ул. Коммунистическая, 1')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (25, N'603379, г. Москва, ул. Спортивная, 46')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (26, N'603721, г. Москва, ул. Гоголя, 41')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (27, N'410172, г. Москва, ул. Северная, 13')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (28, N'420151, г. Москва, ул. Вишневая, 32')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (29, N'125061, г. Москва, ул. Подгорная, 8')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (30, N'630370, г. Москва, ул. Шоссейная, 24')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (31, N'614753, г. Москва, ул. Полевая, 35')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (32, N'426030, г. Москва, ул. Маяковского, 44')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (33, N'450375, г. Москва ул. Клубная, 44')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (34, N'625560, г. Москва, ул. Некрасова, 12')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (35, N'630201, г. Москва, ул. Комсомольская, 17')
INSERT [dbo].[PointIssue] ([PointIssueId], [PointIssueName]) VALUES (36, N'190949, г. Москва, ул. Мичурина, 26')
GO
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'B320R5', 7, N'Туфли Rieker женские демисезонные, размер 41, цвет коричневый', 1, N'B320R5.jpg', 5, CAST(4300.0000 AS Decimal(19, 4)), 15, 2, 6, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'B431R5', 1, N'Мужские кожаные ботинки/мужские ботинки', 2, N'', 5, CAST(2700.0000 AS Decimal(19, 4)), 10, 2, 5, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'C436G5', 1, N'Ботинки женские, ARGO, размер 40', 1, N'', 1, CAST(10200.0000 AS Decimal(19, 4)), 15, 2, 9, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'D268G5', 7, N'Туфли Rieker женские демисезонные, размер 36, цвет коричневый', 1, N'', 5, CAST(4399.0000 AS Decimal(19, 4)), 10, 3, 12, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'D329H3', 4, N'Полуботинки Alessio Nesca женские 3-30797-47, размер 37, цвет: бордовый', 1, N'D329H3.jpg', 1, CAST(1890.0000 AS Decimal(19, 4)), 10, 4, 4, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'D364R4', 7, N'Туфли Luiza Belly женские Kate-lazo черные из натуральной замши', 1, N'', 3, CAST(12400.0000 AS Decimal(19, 4)), 10, 2, 5, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'D572U8', 3, N'129615-4 Кроссовки мужские', 2, N'D572U8.jpg', 6, CAST(4100.0000 AS Decimal(19, 4)), 5, 3, 6, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'E482R4', 4, N'Полуботинки kari женские MYZ20S-149, размер 41, цвет: черный', 1, N'', 3, CAST(1800.0000 AS Decimal(19, 4)), 15, 2, 14, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'F427R5', 1, N'Ботинки на молнии с декоративной пряжкой FRAU', 1, N'', 5, CAST(11800.0000 AS Decimal(19, 4)), 10, 4, 11, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'F572H7', 7, N'Туфли Marco Tozzi женские летние, размер 39, цвет черный', 1, N'F572H7.jpg', 4, CAST(2700.0000 AS Decimal(19, 4)), 15, 2, 14, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'F635R4', 1, N'Ботинки Marco Tozzi женские демисезонные, размер 39, цвет бежевый', 1, N'F635R4.jpg', 4, CAST(3244.0000 AS Decimal(19, 4)), 20, 2, 13, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'G432E4', 7, N'Туфли kari женские TR-YR-413017, размер 37, цвет: черный', 1, N'G432E4.jpg', 3, CAST(2800.0000 AS Decimal(19, 4)), 10, 3, 15, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'G531F4', 1, N'Ботинки женские зимние ROMER арт. 893167-01 Черный', 1, N'', 3, CAST(6600.0000 AS Decimal(19, 4)), 5, 2, 9, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'G783F5', 1, N'Мужские ботинки Рос-Обувь кожаные с натуральным мехом', 2, N'G783F5.jpg', 6, CAST(5900.0000 AS Decimal(19, 4)), 25, 2, 8, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'H535R5', 1, N'Женские Ботинки демисезонные', 1, N'', 5, CAST(2300.0000 AS Decimal(19, 4)), 25, 2, 7, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'H782T5', 7, N'Туфли kari мужские классика MYZ21AW-450A, размер 43, цвет: черный', 2, N'H782T5.jpg', 3, CAST(4499.0000 AS Decimal(19, 4)), 30, 4, 5, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'J384T6', 1, N'B3430/14 Полуботинки мужские Rieker', 2, N'J384T6.jpg', 5, CAST(3800.0000 AS Decimal(19, 4)), 10, 2, 16, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'J542F5', 6, N'Тапочки мужские Арт.70701-55-67син р.41', 2, N'', 3, CAST(500.0000 AS Decimal(19, 4)), 5, 3, 12, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'K345R4', 4, N'407700/01-02 Полуботинки мужские CROSBY', 2, N'', 2, CAST(2100.0000 AS Decimal(19, 4)), 15, 2, 3, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'K358H6', 6, N'Тапочки мужские син р.41', 2, N'', 5, CAST(599.0000 AS Decimal(19, 4)), 5, 3, 2, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'L754R4', 4, N'Полуботинки kari женские WB2020SS-26, размер 38, цвет: черный', 1, N'', 3, CAST(1700.0000 AS Decimal(19, 4)), 10, 2, 7, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'M542T5', 3, N'Кроссовки мужские TOFA', 2, N'', 5, CAST(2800.0000 AS Decimal(19, 4)), 5, 5, 3, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'N457T5', 4, N'Полуботинки Ботинки черные зимние, мех', 1, N'', 2, CAST(4600.0000 AS Decimal(19, 4)), 5, 3, 13, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'O754F4', 7, N'Туфли женские демисезонные Rieker артикул 55073-68/37', 1, N'', 5, CAST(5400.0000 AS Decimal(19, 4)), 10, 4, 18, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'P764G4', 7, N'Туфли женские, ARGO, размер 38', 1, N'', 2, CAST(6800.0000 AS Decimal(19, 4)), 30, 3, 15, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'S213E3', 4, N'407700/01-01 Полуботинки мужские CROSBY', 2, N'', 2, CAST(2156.0000 AS Decimal(19, 4)), 5, 3, 6, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'S326R5', 6, N'Мужские кожаные тапочки "Профиль С.Дали" ', 2, N'', 2, CAST(9900.0000 AS Decimal(19, 4)), 15, 3, 15, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'S634B5', 2, N'Кеды Caprice мужские демисезонные, размер 42, цвет черный', 2, N'', 2, CAST(5500.0000 AS Decimal(19, 4)), 20, 3, 6, 1, 2)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'T324F5', 5, N'Сапоги замша Цвет: синий', 1, N'', 2, CAST(4699.0000 AS Decimal(19, 4)), 15, 2, 5, 1, 1)
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductClassificationId], [ProductDescription], [ProductCategoryId], [ProductPhoto], [ProductManufacuturerId], [ProductCost], [ProductDiscountMax], [ProductDiscountNow], [ProductQuantityInStock], [ProductUnitId], [ProductProviderId]) VALUES (N'А112Т4', 1, N'Женские Ботинки демисезонные kari', 1, N'А112Т4.jpg', 3, CAST(4990.0000 AS Decimal(19, 4)), 30, 3, 6, 1, 1)
GO
INSERT [dbo].[Provider] ([ProviderId], [ProviderName]) VALUES (1, N'Kari')
INSERT [dbo].[Provider] ([ProviderId], [ProviderName]) VALUES (2, N'Обувь для вас')
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (1, N'Администратор
')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (2, N'Менеджер')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (3, N'Клиент')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (4, N'Гость')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
INSERT [dbo].[Status] ([StatusId], [StatusName]) VALUES (1, N'Новый')
INSERT [dbo].[Status] ([StatusId], [StatusName]) VALUES (2, N'Завершен
')
GO
INSERT [dbo].[Unit] ([UnitId], [UnitName]) VALUES (1, N'шт.')
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [UserSecondName], [UserFirstName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (1, N'Федоров', N'Глеб', N'Михайлович', N'o@outlook.com', N'2L6KZG', 1)
INSERT [dbo].[User] ([UserId], [UserSecondName], [UserFirstName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (2, N'Семенова', N'Софья', N'Дмитриевна', N'hr6zdl@yandex.ru', N'uzWC67', 1)
INSERT [dbo].[User] ([UserId], [UserSecondName], [UserFirstName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (3, N'Васильев', N'Егор', N'Германович', N'kaft93x@outlook.com', N'8ntwUp', 1)
INSERT [dbo].[User] ([UserId], [UserSecondName], [UserFirstName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (4, N'Смирнова', N'Ирина', N'Александровна', N'dcu@yandex.ru', N'YOyhfR', 2)
INSERT [dbo].[User] ([UserId], [UserSecondName], [UserFirstName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (5, N'Петров', N'Андрей', N'Владимирович', N'19dn@outlook.com', N'RSbvHv', 2)
INSERT [dbo].[User] ([UserId], [UserSecondName], [UserFirstName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (6, N'Егоров', N'Максим', N'Андреевич', N'pa5h@mail.ru', N'rwVDh9', 2)
INSERT [dbo].[User] ([UserId], [UserSecondName], [UserFirstName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (7, N'Никитин', N'Артур', N'Алексеевич', N'281av0@gmail.com', N'LdNyos', 3)
INSERT [dbo].[User] ([UserId], [UserSecondName], [UserFirstName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (8, N'Киселев', N'Максим', N'Сергеевич', N'8edmfh@outlook.com', N'gynQMT', 3)
INSERT [dbo].[User] ([UserId], [UserSecondName], [UserFirstName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (9, N'Борисов', N'Тимур', N'Егорович', N'sfn13i@mail.ru', N'AtnDjr', 3)
INSERT [dbo].[User] ([UserId], [UserSecondName], [UserFirstName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (10, N'Климов', N'Арсений', N'Тимурович', N'g0orc3x1@outlook.com', N'JlFRCZ', 3)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_PointIssue] FOREIGN KEY([OrderPointIssueId])
REFERENCES [dbo].[PointIssue] ([PointIssueId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_PointIssue]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Status] FOREIGN KEY([OrderStatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Status]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User] FOREIGN KEY([OrderClientId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_User]
GO
ALTER TABLE [dbo].[OrderContent]  WITH CHECK ADD  CONSTRAINT [FK_OrderContent_Order] FOREIGN KEY([OrderContnentId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderContent] CHECK CONSTRAINT [FK_OrderContent_Order]
GO
ALTER TABLE [dbo].[OrderContent]  WITH CHECK ADD  CONSTRAINT [FK_OrderContent_Product] FOREIGN KEY([OrderContentProduct])
REFERENCES [dbo].[Product] ([ProductArticleNumber])
GO
ALTER TABLE [dbo].[OrderContent] CHECK CONSTRAINT [FK_OrderContent_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([ProductCategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Classification] FOREIGN KEY([ProductClassificationId])
REFERENCES [dbo].[Classification] ([ClassificationId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Classification]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Manufacturer] FOREIGN KEY([ProductManufacuturerId])
REFERENCES [dbo].[Manufacturer] ([ManufacturerId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Manufacturer]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Provider] FOREIGN KEY([ProductProviderId])
REFERENCES [dbo].[Provider] ([ProviderId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Provider]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Unit] FOREIGN KEY([ProductUnitId])
REFERENCES [dbo].[Unit] ([UnitId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Unit]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([UserRole])
REFERENCES [dbo].[Role] ([RoleId])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
ALTER DATABASE [Footwear] SET  READ_WRITE 
GO
