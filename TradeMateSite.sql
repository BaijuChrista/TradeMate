USE [master]
GO
/****** Object:  Database [TradeMateSite]    Script Date: 15-09-2023 09:41:24 PM ******/
CREATE DATABASE [TradeMateSite]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TradeMateSite', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TradeMateSite.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TradeMateSite_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TradeMateSite_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TradeMateSite] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TradeMateSite].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TradeMateSite] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TradeMateSite] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TradeMateSite] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TradeMateSite] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TradeMateSite] SET ARITHABORT OFF 
GO
ALTER DATABASE [TradeMateSite] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TradeMateSite] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TradeMateSite] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TradeMateSite] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TradeMateSite] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TradeMateSite] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TradeMateSite] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TradeMateSite] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TradeMateSite] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TradeMateSite] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TradeMateSite] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TradeMateSite] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TradeMateSite] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TradeMateSite] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TradeMateSite] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TradeMateSite] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TradeMateSite] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TradeMateSite] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TradeMateSite] SET  MULTI_USER 
GO
ALTER DATABASE [TradeMateSite] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TradeMateSite] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TradeMateSite] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TradeMateSite] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TradeMateSite] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TradeMateSite] SET QUERY_STORE = OFF
GO
USE [TradeMateSite]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActionPlans]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActionPlans](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[week] [nvarchar](max) NULL,
	[product] [nvarchar](max) NULL,
	[country] [nvarchar](max) NULL,
	[account] [nvarchar](max) NULL,
	[site] [nvarchar](max) NULL,
	[issue] [nvarchar](max) NULL,
	[actionplan] [nvarchar](max) NULL,
	[remarks] [nvarchar](max) NULL,
	[start] [datetime] NOT NULL,
	[end] [datetime] NOT NULL,
	[Status] [int] NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.ActionPlans] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActionPlanStatus]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActionPlanStatus](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ActionPlanId] [bigint] NOT NULL,
	[ActionPlanstatus] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedUserId] [bigint] NOT NULL,
 CONSTRAINT [PK_dbo.ActionPlanStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationUser]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationUser](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[Status] [int] NOT NULL,
	[ImageAttachment] [varbinary](max) NULL,
	[ContentType] [nvarchar](max) NULL,
	[Extension] [nvarchar](max) NULL,
	[UserTypeId] [bigint] NOT NULL,
	[CompanyId] [bigint] NULL,
	[PasswordHash] [varbinary](max) NULL,
	[PasswordSalt] [varbinary](max) NULL,
	[Guid] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[sex] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
 CONSTRAINT [PK_ApplicationUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationUsers]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationUsers](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[Status] [int] NOT NULL,
	[UserDirectory] [nvarchar](max) NULL,
	[PasswordHash] [varbinary](max) NULL,
	[PasswordSalt] [varbinary](max) NULL,
	[UserTypeId] [bigint] NOT NULL,
	[Email] [nvarchar](max) NULL,
	[failedCount] [int] NOT NULL,
	[Token] [nvarchar](max) NULL,
	[UserID] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.ApplicationUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Asset]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asset](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
	[AssetCategoryId] [bigint] NOT NULL,
 CONSTRAINT [PK_Asset] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AssetCategory]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssetCategory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
	[coaId] [bigint] NOT NULL,
 CONSTRAINT [PK_AssetCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bank]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bank](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
	[accno] [nvarchar](max) NULL,
	[bankname] [nvarchar](max) NULL,
	[CurrencyId] [bigint] NOT NULL,
	[swiftcode] [nvarchar](max) NULL,
	[BankcategoryId] [bigint] NOT NULL,
	[cr] [float] NOT NULL,
	[dr] [float] NOT NULL,
	[partnerId] [bigint] NOT NULL,
 CONSTRAINT [PK_Bank] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bankcategory]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bankcategory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[coaId] [bigint] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Bankcategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BankTxn]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankTxn](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[transno] [nvarchar](max) NULL,
	[refno] [nvarchar](max) NULL,
	[trandate] [datetime2](7) NOT NULL,
	[BankId] [bigint] NOT NULL,
	[amount] [float] NOT NULL,
	[narration] [nvarchar](max) NULL,
	[trantype] [int] NOT NULL,
 CONSTRAINT [PK_BankTxn] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Branch]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branch](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
	[BranchGroupId] [bigint] NOT NULL,
 CONSTRAINT [PK_Branch] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BranchGroup]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BranchGroup](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
 CONSTRAINT [PK_BranchGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[StateId] [bigint] NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[coa]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coa](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[COATypeId] [bigint] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
	[odr] [int] NOT NULL,
 CONSTRAINT [PK_coa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Coabase]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coabase](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
	[fs] [int] NOT NULL,
 CONSTRAINT [PK_Coabase] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COAType]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COAType](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[CoabaseId] [bigint] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
	[odr] [int] NOT NULL,
 CONSTRAINT [PK_COAType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[CompanyName] [nvarchar](max) NULL,
	[shortname] [nvarchar](max) NULL,
	[CompanyAddress] [nvarchar](max) NULL,
	[Zipcode] [nvarchar](max) NULL,
	[CityId] [bigint] NOT NULL,
	[SupportMail] [nvarchar](max) NULL,
	[SupportNo] [nvarchar](max) NULL,
	[License] [nvarchar](max) NULL,
	[StartedIn] [datetime2](7) NOT NULL,
	[TaxNo] [nvarchar](max) NULL,
	[Otherreg] [nvarchar](max) NULL,
	[Details] [nvarchar](max) NULL,
	[image] [nvarchar](max) NULL,
	[Lattitude] [nvarchar](max) NULL,
	[Longitude] [nvarchar](max) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyContact]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyContact](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[CompanyId] [bigint] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[Mail] [nvarchar](max) NULL,
	[Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_CompanyContact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[CountryName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreditCard]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditCard](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
	[number] [nvarchar](max) NULL,
	[details] [nvarchar](max) NULL,
	[BankId] [bigint] NOT NULL,
	[categoryId] [bigint] NOT NULL,
	[cr] [float] NOT NULL,
	[dr] [float] NOT NULL,
	[partnerId] [bigint] NOT NULL,
 CONSTRAINT [PK_CreditCard] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreditCardcategory]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditCardcategory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[coaId] [bigint] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
 CONSTRAINT [PK_CreditCardcategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Currency]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Currency](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[name] [nvarchar](max) NULL,
	[smallunit] [nvarchar](max) NULL,
	[roe] [float] NOT NULL,
 CONSTRAINT [PK_Currency] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[CustomerName] [nvarchar](max) NULL,
	[shortname] [nvarchar](max) NULL,
	[CustomerAddress] [nvarchar](max) NULL,
	[Zipcode] [nvarchar](max) NULL,
	[CityId] [bigint] NOT NULL,
	[customercategoryId] [bigint] NOT NULL,
	[customergroupId] [bigint] NOT NULL,
	[SupportMail] [nvarchar](max) NULL,
	[SupportNo] [nvarchar](max) NULL,
	[License] [nvarchar](max) NULL,
	[StartedIn] [datetime2](7) NOT NULL,
	[TaxNo] [nvarchar](max) NULL,
	[Otherreg] [nvarchar](max) NULL,
	[Details] [nvarchar](max) NULL,
	[image] [nvarchar](max) NULL,
	[Lattitude] [nvarchar](max) NULL,
	[Longitude] [nvarchar](max) NULL,
	[code] [nvarchar](max) NULL,
	[creditdays] [int] NOT NULL,
	[creditlimit] [float] NOT NULL,
	[CurrencyId] [bigint] NOT NULL,
	[partnerId] [bigint] NOT NULL,
	[cr] [float] NOT NULL,
	[dr] [float] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customercategory]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customercategory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[name] [nvarchar](max) NULL,
	[code] [nvarchar](max) NULL,
	[coaId] [bigint] NOT NULL,
 CONSTRAINT [PK_customercategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerContact]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerContact](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[CustomerId] [bigint] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[Mail] [nvarchar](max) NULL,
	[Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_CustomerContact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customergroup]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customergroup](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[name] [nvarchar](max) NULL,
	[code] [nvarchar](max) NULL,
 CONSTRAINT [PK_customergroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerUserAssign]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerUserAssign](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[CustomerId] [bigint] NOT NULL,
	[AssignedUserId] [bigint] NOT NULL,
	[assignedDay] [int] NOT NULL,
 CONSTRAINT [PK_CustomerUserAssign] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[defaultaccount]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[defaultaccount](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[name] [nvarchar](max) NULL,
	[ledgerId] [bigint] NOT NULL,
 CONSTRAINT [PK_defaultaccount] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deliverycategory]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deliverycategory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[DeliveryId] [bigint] NULL,
 CONSTRAINT [PK_Deliverycategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeliveryItem]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeliveryItem](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[OrderNo] [nvarchar](max) NULL,
	[details] [nvarchar](max) NULL,
	[FromAddress] [nvarchar](max) NULL,
	[ToAddress] [nvarchar](max) NULL,
	[Amount] [float] NOT NULL,
	[userAssignedId] [bigint] NULL,
	[DropOf_contact] [nvarchar](max) NULL,
	[DropOf_email] [nvarchar](max) NULL,
	[PickUp_contact] [nvarchar](max) NULL,
	[PickUp_email] [nvarchar](max) NULL,
	[subcategoryId] [bigint] NULL,
 CONSTRAINT [PK_DeliveryItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeliveryPayment]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeliveryPayment](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[deliveryItemId] [bigint] NOT NULL,
	[amount] [float] NOT NULL,
	[type] [int] NOT NULL,
 CONSTRAINT [PK_DeliveryPayment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
	[DepartmentGroupId] [bigint] NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DepartmentGroup]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DepartmentGroup](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
 CONSTRAINT [PK_DepartmentGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Designation]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Designation](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
	[DesignationGroupsId] [bigint] NOT NULL,
 CONSTRAINT [PK_Designation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DesignationGroup]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DesignationGroup](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
 CONSTRAINT [PK_DesignationGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
	[salutation] [nvarchar](max) NULL,
	[EmployeeCategoryId] [bigint] NOT NULL,
	[EmployeeGroupId] [bigint] NOT NULL,
	[DepartmentId] [bigint] NOT NULL,
	[DesignationId] [bigint] NOT NULL,
	[firstname] [nvarchar](max) NULL,
	[lastname] [nvarchar](max) NULL,
	[mail] [nvarchar](max) NULL,
	[middlename] [nvarchar](max) NULL,
	[phone] [nvarchar](max) NULL,
	[dob] [datetime2](7) NULL,
	[doj] [datetime2](7) NULL,
	[partnerId] [bigint] NOT NULL,
	[cr] [float] NOT NULL,
	[dr] [float] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeCategory]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeCategory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
	[coaId] [bigint] NOT NULL,
 CONSTRAINT [PK_EmployeeCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeGroup]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeGroup](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
 CONSTRAINT [PK_EmployeeGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FinanceYear]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinanceYear](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[YearName] [nvarchar](max) NULL,
	[FromDate] [datetime2](7) NOT NULL,
	[ToDate] [datetime2](7) NOT NULL,
	[iscurrent] [bit] NOT NULL,
 CONSTRAINT [PK_FinanceYear] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemBrand]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemBrand](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[brnadname] [nvarchar](max) NULL,
	[details] [nvarchar](max) NULL,
 CONSTRAINT [PK_ItemBrand] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemCategory]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemCategory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[CategoryName] [nvarchar](max) NULL,
	[notes] [nvarchar](max) NULL,
	[code] [nvarchar](max) NULL,
	[image] [nvarchar](max) NULL,
 CONSTRAINT [PK_ItemCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemImage]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemImage](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[ItemMasterId] [bigint] NOT NULL,
	[zoom] [nvarchar](max) NULL,
	[thumb] [nvarchar](max) NULL,
	[sortorder] [int] NOT NULL,
 CONSTRAINT [PK_ItemImage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemMaster]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemMaster](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[ItemCode] [nvarchar](max) NULL,
	[ItemName] [nvarchar](max) NULL,
	[CategoryId] [bigint] NOT NULL,
	[TaxMasterId] [bigint] NOT NULL,
	[Price] [float] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[qty] [float] NOT NULL,
	[rol] [float] NOT NULL,
	[ItemBrandId] [bigint] NOT NULL,
	[PurPrice] [float] NOT NULL,
	[SalesPrice] [float] NOT NULL,
	[Maxqty] [float] NOT NULL,
	[BarCode] [nvarchar](max) NULL,
	[ProductCode] [nvarchar](max) NULL,
	[Offerprice] [float] NOT NULL,
	[Showcart] [bit] NOT NULL,
	[Showsite] [bit] NOT NULL,
	[type] [int] NOT NULL,
	[MobilePrice] [float] NOT NULL,
	[BaqalaPrice] [float] NOT NULL,
	[StationaryPrice] [float] NOT NULL,
 CONSTRAINT [PK_ItemMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ledger]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ledger](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[coaId] [bigint] NOT NULL,
	[name] [nvarchar](max) NULL,
	[details] [nvarchar](max) NULL,
	[partnerId] [bigint] NOT NULL,
 CONSTRAINT [PK_ledger] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ledgertxn]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ledgertxn](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[ledgerId] [bigint] NOT NULL,
	[txndate] [datetime2](7) NOT NULL,
	[dr] [float] NOT NULL,
	[cr] [float] NOT NULL,
	[details] [nvarchar](max) NULL,
	[txnno] [nvarchar](max) NULL,
 CONSTRAINT [PK_ledgertxn] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MotherCompany]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MotherCompany](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[CompanyName] [nvarchar](max) NULL,
	[shortname] [nvarchar](max) NULL,
	[CompanyAddress] [nvarchar](max) NULL,
	[Zipcode] [nvarchar](max) NULL,
	[CityId] [bigint] NOT NULL,
	[SupportMail] [nvarchar](max) NULL,
	[SupportNo] [nvarchar](max) NULL,
	[License] [nvarchar](max) NULL,
	[StartedIn] [datetime2](7) NOT NULL,
	[TaxNo] [nvarchar](max) NULL,
	[Otherreg] [nvarchar](max) NULL,
	[Details] [nvarchar](max) NULL,
	[image] [nvarchar](max) NULL,
 CONSTRAINT [PK_MotherCompany] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[partner]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[partner](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
	[details] [nvarchar](max) NULL,
 CONSTRAINT [PK_partner] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[transno] [nvarchar](max) NULL,
	[refno] [nvarchar](max) NULL,
	[trandate] [datetime2](7) NOT NULL,
	[ledgerId] [bigint] NOT NULL,
	[amount] [float] NOT NULL,
	[narration] [nvarchar](max) NULL,
	[trantype] [int] NOT NULL,
	[balance] [float] NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentTransactions]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentTransactions](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[PaymentId] [bigint] NOT NULL,
	[amount] [float] NOT NULL,
 CONSTRAINT [PK_PaymentTransactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[refno] [nvarchar](max) NULL,
	[orderdate] [datetime2](7) NOT NULL,
	[SupplierId] [bigint] NOT NULL,
	[details] [nvarchar](max) NULL,
	[Type] [int] NOT NULL,
	[Discount] [float] NOT NULL,
	[Total] [float] NOT NULL,
	[invoiceno] [nvarchar](max) NULL,
	[balance] [float] NOT NULL,
	[Isvat] [bit] NOT NULL,
 CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseDetail]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseDetail](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[PurchaseOrderId] [bigint] NOT NULL,
	[ItemMasterId] [bigint] NOT NULL,
	[qty] [float] NOT NULL,
	[amount] [float] NOT NULL,
	[comments] [nvarchar](max) NULL,
 CONSTRAINT [PK_PurchaseDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchasepaiddetail]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchasepaiddetail](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[PurchaseOrderId] [bigint] NOT NULL,
	[amount] [float] NOT NULL,
	[details] [nvarchar](max) NULL,
	[paiddate] [datetime2](7) NOT NULL,
	[voucherno] [nvarchar](max) NULL,
 CONSTRAINT [PK_purchasepaiddetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchasereturn]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchasereturn](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[invoiceno] [nvarchar](max) NULL,
	[PurchaseId] [bigint] NOT NULL,
	[details] [nvarchar](max) NULL,
	[Total] [float] NOT NULL,
	[retdate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_purchasereturn] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchasereturnDetail]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchasereturnDetail](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[purchasereturnId] [bigint] NOT NULL,
	[ItemMasterId] [bigint] NOT NULL,
	[qty] [float] NOT NULL,
	[amount] [float] NOT NULL,
 CONSTRAINT [PK_purchasereturnDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receipt]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receipt](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[transno] [nvarchar](max) NULL,
	[refno] [nvarchar](max) NULL,
	[trandate] [datetime2](7) NOT NULL,
	[ledgerId] [bigint] NOT NULL,
	[amount] [float] NOT NULL,
	[narration] [nvarchar](max) NULL,
	[trantype] [int] NOT NULL,
	[balance] [float] NULL,
 CONSTRAINT [PK_Receipt] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReceiptTransactions]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceiptTransactions](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[ReceiptId] [bigint] NOT NULL,
	[amount] [float] NOT NULL,
 CONSTRAINT [PK_ReceiptTransactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salereturn]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salereturn](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[invoiceno] [nvarchar](max) NULL,
	[SalesId] [bigint] NOT NULL,
	[details] [nvarchar](max) NULL,
	[Total] [float] NOT NULL,
	[retdate] [datetime] NULL,
 CONSTRAINT [PK_salereturn] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[salereturnDetail]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salereturnDetail](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[salereturnId] [bigint] NOT NULL,
	[ItemMasterId] [bigint] NOT NULL,
	[qty] [float] NOT NULL,
	[amount] [float] NOT NULL,
 CONSTRAINT [PK_salereturnDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[invoiceno] [nvarchar](max) NULL,
	[Type] [int] NOT NULL,
	[salesdate] [datetime2](7) NOT NULL,
	[CustomerId] [bigint] NOT NULL,
	[SalesOrderId] [bigint] NULL,
	[details] [nvarchar](max) NULL,
	[Total] [float] NOT NULL,
	[Discount] [float] NOT NULL,
	[balance] [float] NOT NULL,
	[Isvat] [bit] NULL,
	[statusChange] [nvarchar](max) NULL,
	[lpono] [nvarchar](max) NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesDetail]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesDetail](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[SalesId] [bigint] NOT NULL,
	[ItemMasterId] [bigint] NOT NULL,
	[qty] [float] NOT NULL,
	[amount] [float] NOT NULL,
	[cost] [float] NOT NULL,
	[comments] [nvarchar](max) NULL,
 CONSTRAINT [PK_SalesDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesOrder]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesOrder](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[refno] [nvarchar](max) NULL,
	[orderdate] [datetime2](7) NOT NULL,
	[CustomerId] [bigint] NOT NULL,
	[details] [nvarchar](max) NULL,
	[Type] [int] NOT NULL,
	[Total] [float] NOT NULL,
	[Discount] [float] NULL,
	[ContactName] [nvarchar](max) NULL,
	[ContactNumber] [nvarchar](max) NULL,
	[statusChange] [nvarchar](max) NULL,
	[Delivery] [nvarchar](max) NULL,
	[lpono] [nvarchar](max) NULL,
 CONSTRAINT [PK_SalesOrder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesOrderDetail]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesOrderDetail](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[SalesOrderId] [bigint] NOT NULL,
	[ItemMasterId] [bigint] NOT NULL,
	[qty] [float] NOT NULL,
	[amount] [float] NOT NULL,
	[comments] [nvarchar](max) NULL,
 CONSTRAINT [PK_SalesOrderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salespaiddetail]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salespaiddetail](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[SalesId] [bigint] NOT NULL,
	[amount] [float] NOT NULL,
	[details] [nvarchar](max) NULL,
	[paiddate] [datetime2](7) NOT NULL,
	[voucherno] [nvarchar](max) NULL,
 CONSTRAINT [PK_Salespaiddetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScrollText]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScrollText](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[text] [nvarchar](max) NULL,
	[type] [bigint] NOT NULL,
 CONSTRAINT [PK_ScrollText] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[service]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[service](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
	[servicetypeId] [bigint] NOT NULL,
 CONSTRAINT [PK_service] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[servicetype]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicetype](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[coaId] [bigint] NOT NULL,
	[code] [nvarchar](max) NULL,
	[name] [nvarchar](max) NULL,
 CONSTRAINT [PK_servicetype] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[State]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[State](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[CountryId] [bigint] NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockMaster]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockMaster](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[ItemMasterId] [bigint] NOT NULL,
	[stock] [float] NOT NULL,
	[PurPrice] [float] NOT NULL,
 CONSTRAINT [PK_StockMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Store]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Store](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[StoreName] [nvarchar](max) NULL,
	[shortname] [nvarchar](max) NULL,
	[StoreAddress] [nvarchar](max) NULL,
	[Zipcode] [nvarchar](max) NULL,
	[CityId] [bigint] NOT NULL,
	[Details] [nvarchar](max) NULL,
	[CompanyId] [bigint] NOT NULL,
	[Lattitude] [nvarchar](max) NULL,
	[Longitude] [nvarchar](max) NULL,
	[code] [nvarchar](max) NULL,
 CONSTRAINT [PK_Store] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[SupplierName] [nvarchar](max) NULL,
	[shortname] [nvarchar](max) NULL,
	[SupplierAddress] [nvarchar](max) NULL,
	[Zipcode] [nvarchar](max) NULL,
	[CityId] [bigint] NOT NULL,
	[categoryId] [bigint] NOT NULL,
	[suppliergroupId] [bigint] NOT NULL,
	[SupportMail] [nvarchar](max) NULL,
	[SupportNo] [nvarchar](max) NULL,
	[License] [nvarchar](max) NULL,
	[StartedIn] [datetime2](7) NULL,
	[TaxNo] [nvarchar](max) NULL,
	[Otherreg] [nvarchar](max) NULL,
	[Details] [nvarchar](max) NULL,
	[image] [nvarchar](max) NULL,
	[code] [nvarchar](max) NULL,
	[CurrencyId] [bigint] NOT NULL,
	[creditlimit] [float] NOT NULL,
	[Lattitude] [nvarchar](max) NULL,
	[Longitude] [nvarchar](max) NULL,
	[partnerId] [bigint] NOT NULL,
	[creditdays] [int] NOT NULL,
	[cr] [float] NOT NULL,
	[dr] [float] NOT NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suppliercategory]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suppliercategory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[name] [nvarchar](max) NULL,
	[code] [nvarchar](max) NULL,
	[coaId] [bigint] NOT NULL,
 CONSTRAINT [PK_suppliercategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierContact]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierContact](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[SupplierId] [bigint] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[Mail] [nvarchar](max) NULL,
	[Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_SupplierContact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suppliergroup]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suppliergroup](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[name] [nvarchar](max) NULL,
	[code] [nvarchar](max) NULL,
 CONSTRAINT [PK_suppliergroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Task]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[name] [nvarchar](max) NULL,
	[details] [nvarchar](max) NULL,
 CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaxMaster]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaxMaster](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[TaxName] [nvarchar](max) NULL,
	[percentage] [float] NOT NULL,
	[notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_TaxMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserCountries]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserCountries](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [bigint] NOT NULL,
	[CountryId] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_dbo.UserCountries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserHierarchies]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserHierarchies](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [bigint] NOT NULL,
	[HierarchyId] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_dbo.UserHierarchies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserPagesAssigned]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserPagesAssigned](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CreatedUserId] [bigint] NOT NULL,
	[ModifiedUserId] [bigint] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[pagename] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
	[UserId] [bigint] NOT NULL,
 CONSTRAINT [PK_UserPagesAssigned] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserProducts]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserProducts](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [bigint] NOT NULL,
	[ProductId] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_dbo.UserProducts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTypes]    Script Date: 15-09-2023 09:41:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTypes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_dbo.UserTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Deliverycategory_CreatedUserId]    Script Date: 15-09-2023 09:41:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_Deliverycategory_CreatedUserId] ON [dbo].[Deliverycategory]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Deliverycategory_DeliveryId]    Script Date: 15-09-2023 09:41:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_Deliverycategory_DeliveryId] ON [dbo].[Deliverycategory]
(
	[DeliveryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DeliveryItem_subcategoryId]    Script Date: 15-09-2023 09:41:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_DeliveryItem_subcategoryId] ON [dbo].[DeliveryItem]
(
	[subcategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DeliveryPayment_CreatedUserId]    Script Date: 15-09-2023 09:41:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_DeliveryPayment_CreatedUserId] ON [dbo].[DeliveryPayment]
(
	[CreatedUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DeliveryPayment_deliveryItemId]    Script Date: 15-09-2023 09:41:24 PM ******/
CREATE NONCLUSTERED INDEX [IX_DeliveryPayment_deliveryItemId] ON [dbo].[DeliveryPayment]
(
	[deliveryItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ApplicationUsers] ADD  DEFAULT ((0)) FOR [failedCount]
GO
ALTER TABLE [dbo].[AssetCategory] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [coaId]
GO
ALTER TABLE [dbo].[Bank] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [CurrencyId]
GO
ALTER TABLE [dbo].[Bank] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [BankcategoryId]
GO
ALTER TABLE [dbo].[Bank] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [cr]
GO
ALTER TABLE [dbo].[Bank] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [dr]
GO
ALTER TABLE [dbo].[Bank] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [partnerId]
GO
ALTER TABLE [dbo].[coa] ADD  DEFAULT ((0)) FOR [odr]
GO
ALTER TABLE [dbo].[Coabase] ADD  DEFAULT ((0)) FOR [fs]
GO
ALTER TABLE [dbo].[COAType] ADD  DEFAULT ((0)) FOR [odr]
GO
ALTER TABLE [dbo].[CreditCard] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [categoryId]
GO
ALTER TABLE [dbo].[CreditCard] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [cr]
GO
ALTER TABLE [dbo].[CreditCard] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [dr]
GO
ALTER TABLE [dbo].[CreditCard] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [partnerId]
GO
ALTER TABLE [dbo].[Currency] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [roe]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT ((0)) FOR [creditdays]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [creditlimit]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT ((2)) FOR [CurrencyId]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [partnerId]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [cr]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [dr]
GO
ALTER TABLE [dbo].[customercategory] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [coaId]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [DepartmentId]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [DesignationId]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [partnerId]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [cr]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [dr]
GO
ALTER TABLE [dbo].[EmployeeCategory] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [coaId]
GO
ALTER TABLE [dbo].[ItemMaster] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [ItemBrandId]
GO
ALTER TABLE [dbo].[ItemMaster] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [PurPrice]
GO
ALTER TABLE [dbo].[ItemMaster] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [SalesPrice]
GO
ALTER TABLE [dbo].[ItemMaster] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [Maxqty]
GO
ALTER TABLE [dbo].[ItemMaster] ADD  CONSTRAINT [DF_ItemMaster_Offerprice]  DEFAULT ((0)) FOR [Offerprice]
GO
ALTER TABLE [dbo].[ItemMaster] ADD  CONSTRAINT [DF_ItemMaster_Showcart]  DEFAULT ((0)) FOR [Showcart]
GO
ALTER TABLE [dbo].[ItemMaster] ADD  CONSTRAINT [DF_ItemMaster_Showsite]  DEFAULT ((0)) FOR [Showsite]
GO
ALTER TABLE [dbo].[ItemMaster] ADD  CONSTRAINT [DF_ItemMaster_type]  DEFAULT ((0)) FOR [type]
GO
ALTER TABLE [dbo].[ItemMaster] ADD  CONSTRAINT [DF_ItemMaster_MobilePrice]  DEFAULT ((0)) FOR [MobilePrice]
GO
ALTER TABLE [dbo].[ItemMaster] ADD  CONSTRAINT [DF_ItemMaster_BaqalaPrice]  DEFAULT ((0)) FOR [BaqalaPrice]
GO
ALTER TABLE [dbo].[ItemMaster] ADD  CONSTRAINT [DF_ItemMaster_StationaryPrice]  DEFAULT ((0)) FOR [StationaryPrice]
GO
ALTER TABLE [dbo].[ledger] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [partnerId]
GO
ALTER TABLE [dbo].[Purchase] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Purchase] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [Discount]
GO
ALTER TABLE [dbo].[Purchase] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [Total]
GO
ALTER TABLE [dbo].[Purchase] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [balance]
GO
ALTER TABLE [dbo].[purchasereturn] ADD  DEFAULT (getdate()) FOR [retdate]
GO
ALTER TABLE [dbo].[SalesOrder] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[SalesOrder] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [Total]
GO
ALTER TABLE [dbo].[StockMaster] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [PurPrice]
GO
ALTER TABLE [dbo].[Supplier] ADD  DEFAULT ((2)) FOR [CurrencyId]
GO
ALTER TABLE [dbo].[Supplier] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [creditlimit]
GO
ALTER TABLE [dbo].[Supplier] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [partnerId]
GO
ALTER TABLE [dbo].[Supplier] ADD  DEFAULT ((0)) FOR [creditdays]
GO
ALTER TABLE [dbo].[Supplier] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [cr]
GO
ALTER TABLE [dbo].[Supplier] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [dr]
GO
ALTER TABLE [dbo].[suppliercategory] ADD  DEFAULT (CONVERT([bigint],(0))) FOR [coaId]
GO
ALTER TABLE [dbo].[UserProducts] ADD  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[ActionPlans]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ActionPlans_dbo.ApplicationUsers_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUsers] ([Id])
GO
ALTER TABLE [dbo].[ActionPlans] CHECK CONSTRAINT [FK_dbo.ActionPlans_dbo.ApplicationUsers_CreatedUserId]
GO
ALTER TABLE [dbo].[ActionPlans]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ActionPlans_dbo.ApplicationUsers_ModifiedUserId] FOREIGN KEY([ModifiedUserId])
REFERENCES [dbo].[ApplicationUsers] ([Id])
GO
ALTER TABLE [dbo].[ActionPlans] CHECK CONSTRAINT [FK_dbo.ActionPlans_dbo.ApplicationUsers_ModifiedUserId]
GO
ALTER TABLE [dbo].[ActionPlanStatus]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ActionPlanStatus_dbo.ActionPlans_ActionPlanId] FOREIGN KEY([ActionPlanId])
REFERENCES [dbo].[ActionPlans] ([Id])
GO
ALTER TABLE [dbo].[ActionPlanStatus] CHECK CONSTRAINT [FK_dbo.ActionPlanStatus_dbo.ActionPlans_ActionPlanId]
GO
ALTER TABLE [dbo].[ActionPlanStatus]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ActionPlanStatus_dbo.ApplicationUsers_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUsers] ([Id])
GO
ALTER TABLE [dbo].[ActionPlanStatus] CHECK CONSTRAINT [FK_dbo.ActionPlanStatus_dbo.ApplicationUsers_CreatedUserId]
GO
ALTER TABLE [dbo].[ApplicationUser]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationUser_Company_CompanyId] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([Id])
GO
ALTER TABLE [dbo].[ApplicationUser] CHECK CONSTRAINT [FK_ApplicationUser_Company_CompanyId]
GO
ALTER TABLE [dbo].[ApplicationUser]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationUser_UserType_UserTypeId] FOREIGN KEY([UserTypeId])
REFERENCES [dbo].[UserType] ([Id])
GO
ALTER TABLE [dbo].[ApplicationUser] CHECK CONSTRAINT [FK_ApplicationUser_UserType_UserTypeId]
GO
ALTER TABLE [dbo].[ApplicationUsers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ApplicationUsers_dbo.UserTypes_UserTypeId] FOREIGN KEY([UserTypeId])
REFERENCES [dbo].[UserTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ApplicationUsers] CHECK CONSTRAINT [FK_dbo.ApplicationUsers_dbo.UserTypes_UserTypeId]
GO
ALTER TABLE [dbo].[Asset]  WITH CHECK ADD  CONSTRAINT [FK_Asset_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Asset] CHECK CONSTRAINT [FK_Asset_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Asset]  WITH CHECK ADD  CONSTRAINT [FK_Asset_AssetCategory_AssetCategoryId] FOREIGN KEY([AssetCategoryId])
REFERENCES [dbo].[AssetCategory] ([Id])
GO
ALTER TABLE [dbo].[Asset] CHECK CONSTRAINT [FK_Asset_AssetCategory_AssetCategoryId]
GO
ALTER TABLE [dbo].[AssetCategory]  WITH CHECK ADD  CONSTRAINT [FK_AssetCategory_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[AssetCategory] CHECK CONSTRAINT [FK_AssetCategory_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[AssetCategory]  WITH CHECK ADD  CONSTRAINT [FK_AssetCategory_coa_coaId] FOREIGN KEY([coaId])
REFERENCES [dbo].[coa] ([Id])
GO
ALTER TABLE [dbo].[AssetCategory] CHECK CONSTRAINT [FK_AssetCategory_coa_coaId]
GO
ALTER TABLE [dbo].[Bank]  WITH CHECK ADD  CONSTRAINT [FK_Bank_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Bank] CHECK CONSTRAINT [FK_Bank_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Bank]  WITH CHECK ADD  CONSTRAINT [FK_Bank_Bankcategory_BankcategoryId] FOREIGN KEY([BankcategoryId])
REFERENCES [dbo].[Bankcategory] ([Id])
GO
ALTER TABLE [dbo].[Bank] CHECK CONSTRAINT [FK_Bank_Bankcategory_BankcategoryId]
GO
ALTER TABLE [dbo].[Bank]  WITH CHECK ADD  CONSTRAINT [FK_Bank_Currency_CurrencyId] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
GO
ALTER TABLE [dbo].[Bank] CHECK CONSTRAINT [FK_Bank_Currency_CurrencyId]
GO
ALTER TABLE [dbo].[Bank]  WITH CHECK ADD  CONSTRAINT [FK_Bank_partner_partnerId] FOREIGN KEY([partnerId])
REFERENCES [dbo].[partner] ([Id])
GO
ALTER TABLE [dbo].[Bank] CHECK CONSTRAINT [FK_Bank_partner_partnerId]
GO
ALTER TABLE [dbo].[Bankcategory]  WITH CHECK ADD  CONSTRAINT [FK_Bankcategory_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Bankcategory] CHECK CONSTRAINT [FK_Bankcategory_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Bankcategory]  WITH CHECK ADD  CONSTRAINT [FK_Bankcategory_coa_coaId] FOREIGN KEY([coaId])
REFERENCES [dbo].[coa] ([Id])
GO
ALTER TABLE [dbo].[Bankcategory] CHECK CONSTRAINT [FK_Bankcategory_coa_coaId]
GO
ALTER TABLE [dbo].[BankTxn]  WITH CHECK ADD  CONSTRAINT [FK_BankTxn_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[BankTxn] CHECK CONSTRAINT [FK_BankTxn_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[BankTxn]  WITH CHECK ADD  CONSTRAINT [FK_BankTxn_Bank_BankId] FOREIGN KEY([BankId])
REFERENCES [dbo].[Bank] ([Id])
GO
ALTER TABLE [dbo].[BankTxn] CHECK CONSTRAINT [FK_BankTxn_Bank_BankId]
GO
ALTER TABLE [dbo].[Branch]  WITH CHECK ADD  CONSTRAINT [FK_Branch_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Branch] CHECK CONSTRAINT [FK_Branch_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Branch]  WITH CHECK ADD  CONSTRAINT [FK_Branch_BranchGroup_BranchGroupId] FOREIGN KEY([BranchGroupId])
REFERENCES [dbo].[BranchGroup] ([Id])
GO
ALTER TABLE [dbo].[Branch] CHECK CONSTRAINT [FK_Branch_BranchGroup_BranchGroupId]
GO
ALTER TABLE [dbo].[BranchGroup]  WITH CHECK ADD  CONSTRAINT [FK_BranchGroup_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[BranchGroup] CHECK CONSTRAINT [FK_BranchGroup_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_State_StateId] FOREIGN KEY([StateId])
REFERENCES [dbo].[State] ([Id])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_State_StateId]
GO
ALTER TABLE [dbo].[coa]  WITH CHECK ADD  CONSTRAINT [FK_coa_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[coa] CHECK CONSTRAINT [FK_coa_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[coa]  WITH CHECK ADD  CONSTRAINT [FK_coa_COAType_COATypeId] FOREIGN KEY([COATypeId])
REFERENCES [dbo].[COAType] ([Id])
GO
ALTER TABLE [dbo].[coa] CHECK CONSTRAINT [FK_coa_COAType_COATypeId]
GO
ALTER TABLE [dbo].[Coabase]  WITH CHECK ADD  CONSTRAINT [FK_Coabase_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Coabase] CHECK CONSTRAINT [FK_Coabase_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[COAType]  WITH CHECK ADD  CONSTRAINT [FK_COAType_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[COAType] CHECK CONSTRAINT [FK_COAType_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[COAType]  WITH CHECK ADD  CONSTRAINT [FK_COAType_Coabase_CoabaseId] FOREIGN KEY([CoabaseId])
REFERENCES [dbo].[Coabase] ([Id])
GO
ALTER TABLE [dbo].[COAType] CHECK CONSTRAINT [FK_COAType_Coabase_CoabaseId]
GO
ALTER TABLE [dbo].[Company]  WITH CHECK ADD  CONSTRAINT [FK_Company_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Company] CHECK CONSTRAINT [FK_Company_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Company]  WITH CHECK ADD  CONSTRAINT [FK_Company_City_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[City] ([Id])
GO
ALTER TABLE [dbo].[Company] CHECK CONSTRAINT [FK_Company_City_CityId]
GO
ALTER TABLE [dbo].[CompanyContact]  WITH CHECK ADD  CONSTRAINT [FK_CompanyContact_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[CompanyContact] CHECK CONSTRAINT [FK_CompanyContact_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[CompanyContact]  WITH CHECK ADD  CONSTRAINT [FK_CompanyContact_Company_CompanyId] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([Id])
GO
ALTER TABLE [dbo].[CompanyContact] CHECK CONSTRAINT [FK_CompanyContact_Company_CompanyId]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[CreditCard]  WITH CHECK ADD  CONSTRAINT [FK_CreditCard_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[CreditCard] CHECK CONSTRAINT [FK_CreditCard_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[CreditCard]  WITH CHECK ADD  CONSTRAINT [FK_CreditCard_Bank_BankId] FOREIGN KEY([BankId])
REFERENCES [dbo].[Bank] ([Id])
GO
ALTER TABLE [dbo].[CreditCard] CHECK CONSTRAINT [FK_CreditCard_Bank_BankId]
GO
ALTER TABLE [dbo].[CreditCard]  WITH CHECK ADD  CONSTRAINT [FK_CreditCard_CreditCardcategory_categoryId] FOREIGN KEY([categoryId])
REFERENCES [dbo].[CreditCardcategory] ([Id])
GO
ALTER TABLE [dbo].[CreditCard] CHECK CONSTRAINT [FK_CreditCard_CreditCardcategory_categoryId]
GO
ALTER TABLE [dbo].[CreditCard]  WITH CHECK ADD  CONSTRAINT [FK_CreditCard_partner_partnerId] FOREIGN KEY([partnerId])
REFERENCES [dbo].[partner] ([Id])
GO
ALTER TABLE [dbo].[CreditCard] CHECK CONSTRAINT [FK_CreditCard_partner_partnerId]
GO
ALTER TABLE [dbo].[CreditCardcategory]  WITH CHECK ADD  CONSTRAINT [FK_CreditCardcategory_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[CreditCardcategory] CHECK CONSTRAINT [FK_CreditCardcategory_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[CreditCardcategory]  WITH CHECK ADD  CONSTRAINT [FK_CreditCardcategory_coa_coaId] FOREIGN KEY([coaId])
REFERENCES [dbo].[coa] ([Id])
GO
ALTER TABLE [dbo].[CreditCardcategory] CHECK CONSTRAINT [FK_CreditCardcategory_coa_coaId]
GO
ALTER TABLE [dbo].[Currency]  WITH CHECK ADD  CONSTRAINT [FK_Currency_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Currency] CHECK CONSTRAINT [FK_Currency_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_City_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[City] ([Id])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_City_CityId]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Currency_CurrencyId] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_Currency_CurrencyId]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_customercategory_customercategoryId] FOREIGN KEY([customercategoryId])
REFERENCES [dbo].[customercategory] ([Id])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_customercategory_customercategoryId]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_customergroup_customergroupId] FOREIGN KEY([customergroupId])
REFERENCES [dbo].[customergroup] ([Id])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_customergroup_customergroupId]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_partner_partnerId] FOREIGN KEY([partnerId])
REFERENCES [dbo].[partner] ([Id])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_partner_partnerId]
GO
ALTER TABLE [dbo].[customercategory]  WITH CHECK ADD  CONSTRAINT [FK_customercategory_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[customercategory] CHECK CONSTRAINT [FK_customercategory_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[customercategory]  WITH CHECK ADD  CONSTRAINT [FK_customercategory_coa_coaId] FOREIGN KEY([coaId])
REFERENCES [dbo].[coa] ([Id])
GO
ALTER TABLE [dbo].[customercategory] CHECK CONSTRAINT [FK_customercategory_coa_coaId]
GO
ALTER TABLE [dbo].[CustomerContact]  WITH CHECK ADD  CONSTRAINT [FK_CustomerContact_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[CustomerContact] CHECK CONSTRAINT [FK_CustomerContact_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[CustomerContact]  WITH CHECK ADD  CONSTRAINT [FK_CustomerContact_Customer_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[CustomerContact] CHECK CONSTRAINT [FK_CustomerContact_Customer_CustomerId]
GO
ALTER TABLE [dbo].[customergroup]  WITH CHECK ADD  CONSTRAINT [FK_customergroup_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[customergroup] CHECK CONSTRAINT [FK_customergroup_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[CustomerUserAssign]  WITH CHECK ADD  CONSTRAINT [FK_CustomerUserAssign_ApplicationUser_AssignedUserId] FOREIGN KEY([AssignedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerUserAssign] CHECK CONSTRAINT [FK_CustomerUserAssign_ApplicationUser_AssignedUserId]
GO
ALTER TABLE [dbo].[CustomerUserAssign]  WITH CHECK ADD  CONSTRAINT [FK_CustomerUserAssign_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[CustomerUserAssign] CHECK CONSTRAINT [FK_CustomerUserAssign_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[CustomerUserAssign]  WITH CHECK ADD  CONSTRAINT [FK_CustomerUserAssign_Customer_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[CustomerUserAssign] CHECK CONSTRAINT [FK_CustomerUserAssign_Customer_CustomerId]
GO
ALTER TABLE [dbo].[defaultaccount]  WITH CHECK ADD  CONSTRAINT [FK_defaultaccount_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[defaultaccount] CHECK CONSTRAINT [FK_defaultaccount_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[defaultaccount]  WITH CHECK ADD  CONSTRAINT [FK_defaultaccount_ledger_ledgerId] FOREIGN KEY([ledgerId])
REFERENCES [dbo].[ledger] ([Id])
GO
ALTER TABLE [dbo].[defaultaccount] CHECK CONSTRAINT [FK_defaultaccount_ledger_ledgerId]
GO
ALTER TABLE [dbo].[Deliverycategory]  WITH CHECK ADD  CONSTRAINT [FK_Deliverycategory_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Deliverycategory] CHECK CONSTRAINT [FK_Deliverycategory_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Deliverycategory]  WITH CHECK ADD  CONSTRAINT [FK_Deliverycategory_Deliverycategory_DeliveryId] FOREIGN KEY([DeliveryId])
REFERENCES [dbo].[Deliverycategory] ([Id])
GO
ALTER TABLE [dbo].[Deliverycategory] CHECK CONSTRAINT [FK_Deliverycategory_Deliverycategory_DeliveryId]
GO
ALTER TABLE [dbo].[DeliveryItem]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryItem_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DeliveryItem] CHECK CONSTRAINT [FK_DeliveryItem_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[DeliveryItem]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryItem_ApplicationUser_userAssignedId] FOREIGN KEY([userAssignedId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[DeliveryItem] CHECK CONSTRAINT [FK_DeliveryItem_ApplicationUser_userAssignedId]
GO
ALTER TABLE [dbo].[DeliveryItem]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryItem_Deliverycategory_subcategoryId] FOREIGN KEY([subcategoryId])
REFERENCES [dbo].[Deliverycategory] ([Id])
GO
ALTER TABLE [dbo].[DeliveryItem] CHECK CONSTRAINT [FK_DeliveryItem_Deliverycategory_subcategoryId]
GO
ALTER TABLE [dbo].[DeliveryPayment]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryPayment_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[DeliveryPayment] CHECK CONSTRAINT [FK_DeliveryPayment_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[DeliveryPayment]  WITH CHECK ADD  CONSTRAINT [FK_DeliveryPayment_DeliveryItem_deliveryItemId] FOREIGN KEY([deliveryItemId])
REFERENCES [dbo].[DeliveryItem] ([Id])
GO
ALTER TABLE [dbo].[DeliveryPayment] CHECK CONSTRAINT [FK_DeliveryPayment_DeliveryItem_deliveryItemId]
GO
ALTER TABLE [dbo].[Department]  WITH CHECK ADD  CONSTRAINT [FK_Department_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Department] CHECK CONSTRAINT [FK_Department_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Department]  WITH CHECK ADD  CONSTRAINT [FK_Department_DepartmentGroup_DepartmentGroupId] FOREIGN KEY([DepartmentGroupId])
REFERENCES [dbo].[DepartmentGroup] ([Id])
GO
ALTER TABLE [dbo].[Department] CHECK CONSTRAINT [FK_Department_DepartmentGroup_DepartmentGroupId]
GO
ALTER TABLE [dbo].[DepartmentGroup]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentGroup_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[DepartmentGroup] CHECK CONSTRAINT [FK_DepartmentGroup_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Designation]  WITH CHECK ADD  CONSTRAINT [FK_Designation_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Designation] CHECK CONSTRAINT [FK_Designation_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Designation]  WITH CHECK ADD  CONSTRAINT [FK_Designation_DesignationGroup_DesignationGroupsId] FOREIGN KEY([DesignationGroupsId])
REFERENCES [dbo].[DesignationGroup] ([Id])
GO
ALTER TABLE [dbo].[Designation] CHECK CONSTRAINT [FK_Designation_DesignationGroup_DesignationGroupsId]
GO
ALTER TABLE [dbo].[DesignationGroup]  WITH CHECK ADD  CONSTRAINT [FK_DesignationGroup_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[DesignationGroup] CHECK CONSTRAINT [FK_DesignationGroup_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department_DepartmentId] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department_DepartmentId]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Designation_DesignationId] FOREIGN KEY([DesignationId])
REFERENCES [dbo].[Designation] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Designation_DesignationId]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_EmployeeCategory_EmployeeCategoryId] FOREIGN KEY([EmployeeCategoryId])
REFERENCES [dbo].[EmployeeCategory] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_EmployeeCategory_EmployeeCategoryId]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_EmployeeGroup_EmployeeGroupId] FOREIGN KEY([EmployeeGroupId])
REFERENCES [dbo].[EmployeeGroup] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_EmployeeGroup_EmployeeGroupId]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_partner_partnerId] FOREIGN KEY([partnerId])
REFERENCES [dbo].[partner] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_partner_partnerId]
GO
ALTER TABLE [dbo].[EmployeeCategory]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeCategory_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[EmployeeCategory] CHECK CONSTRAINT [FK_EmployeeCategory_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[EmployeeCategory]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeCategory_coa_coaId] FOREIGN KEY([coaId])
REFERENCES [dbo].[coa] ([Id])
GO
ALTER TABLE [dbo].[EmployeeCategory] CHECK CONSTRAINT [FK_EmployeeCategory_coa_coaId]
GO
ALTER TABLE [dbo].[EmployeeGroup]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeGroup_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[EmployeeGroup] CHECK CONSTRAINT [FK_EmployeeGroup_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[FinanceYear]  WITH CHECK ADD  CONSTRAINT [FK_FinanceYear_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[FinanceYear] CHECK CONSTRAINT [FK_FinanceYear_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[ItemBrand]  WITH CHECK ADD  CONSTRAINT [FK_ItemBrand_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[ItemBrand] CHECK CONSTRAINT [FK_ItemBrand_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[ItemImage]  WITH CHECK ADD  CONSTRAINT [FK_ItemImage_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[ItemImage] CHECK CONSTRAINT [FK_ItemImage_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[ItemImage]  WITH CHECK ADD  CONSTRAINT [FK_ItemImage_ItemMaster_ItemMasterId] FOREIGN KEY([ItemMasterId])
REFERENCES [dbo].[ItemMaster] ([Id])
GO
ALTER TABLE [dbo].[ItemImage] CHECK CONSTRAINT [FK_ItemImage_ItemMaster_ItemMasterId]
GO
ALTER TABLE [dbo].[ItemMaster]  WITH CHECK ADD  CONSTRAINT [FK_ItemMaster_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[ItemMaster] CHECK CONSTRAINT [FK_ItemMaster_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[ItemMaster]  WITH CHECK ADD  CONSTRAINT [FK_ItemMaster_ItemBrand_ItemBrandId] FOREIGN KEY([ItemBrandId])
REFERENCES [dbo].[ItemBrand] ([Id])
GO
ALTER TABLE [dbo].[ItemMaster] CHECK CONSTRAINT [FK_ItemMaster_ItemBrand_ItemBrandId]
GO
ALTER TABLE [dbo].[ItemMaster]  WITH CHECK ADD  CONSTRAINT [FK_ItemMaster_ItemCategory_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[ItemCategory] ([Id])
GO
ALTER TABLE [dbo].[ItemMaster] CHECK CONSTRAINT [FK_ItemMaster_ItemCategory_CategoryId]
GO
ALTER TABLE [dbo].[ItemMaster]  WITH CHECK ADD  CONSTRAINT [FK_ItemMaster_TaxMaster_TaxMasterId] FOREIGN KEY([TaxMasterId])
REFERENCES [dbo].[TaxMaster] ([Id])
GO
ALTER TABLE [dbo].[ItemMaster] CHECK CONSTRAINT [FK_ItemMaster_TaxMaster_TaxMasterId]
GO
ALTER TABLE [dbo].[ledger]  WITH CHECK ADD  CONSTRAINT [FK_ledger_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[ledger] CHECK CONSTRAINT [FK_ledger_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[ledger]  WITH CHECK ADD  CONSTRAINT [FK_ledger_coa_coaId] FOREIGN KEY([coaId])
REFERENCES [dbo].[coa] ([Id])
GO
ALTER TABLE [dbo].[ledger] CHECK CONSTRAINT [FK_ledger_coa_coaId]
GO
ALTER TABLE [dbo].[ledger]  WITH CHECK ADD  CONSTRAINT [FK_ledger_partner_partnerId] FOREIGN KEY([partnerId])
REFERENCES [dbo].[partner] ([Id])
GO
ALTER TABLE [dbo].[ledger] CHECK CONSTRAINT [FK_ledger_partner_partnerId]
GO
ALTER TABLE [dbo].[ledgertxn]  WITH CHECK ADD  CONSTRAINT [FK_ledgertxn_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[ledgertxn] CHECK CONSTRAINT [FK_ledgertxn_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[ledgertxn]  WITH CHECK ADD  CONSTRAINT [FK_ledgertxn_ledger_ledgerId] FOREIGN KEY([ledgerId])
REFERENCES [dbo].[ledger] ([Id])
GO
ALTER TABLE [dbo].[ledgertxn] CHECK CONSTRAINT [FK_ledgertxn_ledger_ledgerId]
GO
ALTER TABLE [dbo].[MotherCompany]  WITH CHECK ADD  CONSTRAINT [FK_MotherCompany_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[MotherCompany] CHECK CONSTRAINT [FK_MotherCompany_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[MotherCompany]  WITH CHECK ADD  CONSTRAINT [FK_MotherCompany_City_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[City] ([Id])
GO
ALTER TABLE [dbo].[MotherCompany] CHECK CONSTRAINT [FK_MotherCompany_City_CityId]
GO
ALTER TABLE [dbo].[partner]  WITH CHECK ADD  CONSTRAINT [FK_partner_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[partner] CHECK CONSTRAINT [FK_partner_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_ledger_ledgerId] FOREIGN KEY([ledgerId])
REFERENCES [dbo].[ledger] ([Id])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_ledger_ledgerId]
GO
ALTER TABLE [dbo].[PaymentTransactions]  WITH CHECK ADD  CONSTRAINT [FK_PaymentTransactions_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PaymentTransactions] CHECK CONSTRAINT [FK_PaymentTransactions_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[PaymentTransactions]  WITH CHECK ADD  CONSTRAINT [FK_PaymentTransactions_Payment_PaymentId] FOREIGN KEY([PaymentId])
REFERENCES [dbo].[Payment] ([Id])
GO
ALTER TABLE [dbo].[PaymentTransactions] CHECK CONSTRAINT [FK_PaymentTransactions_Payment_PaymentId]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_Purchase_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Supplier_SupplierId] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Supplier] ([Id])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_Purchase_Supplier_SupplierId]
GO
ALTER TABLE [dbo].[PurchaseDetail]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseDetail_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[PurchaseDetail] CHECK CONSTRAINT [FK_PurchaseDetail_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[PurchaseDetail]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseDetail_ItemMaster_ItemMasterId] FOREIGN KEY([ItemMasterId])
REFERENCES [dbo].[ItemMaster] ([Id])
GO
ALTER TABLE [dbo].[PurchaseDetail] CHECK CONSTRAINT [FK_PurchaseDetail_ItemMaster_ItemMasterId]
GO
ALTER TABLE [dbo].[PurchaseDetail]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseDetail_Purchase_PurchaseOrderId] FOREIGN KEY([PurchaseOrderId])
REFERENCES [dbo].[Purchase] ([Id])
GO
ALTER TABLE [dbo].[PurchaseDetail] CHECK CONSTRAINT [FK_PurchaseDetail_Purchase_PurchaseOrderId]
GO
ALTER TABLE [dbo].[purchasepaiddetail]  WITH CHECK ADD  CONSTRAINT [FK_purchasepaiddetail_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[purchasepaiddetail] CHECK CONSTRAINT [FK_purchasepaiddetail_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[purchasepaiddetail]  WITH CHECK ADD  CONSTRAINT [FK_purchasepaiddetail_Purchase_PurchaseOrderId] FOREIGN KEY([PurchaseOrderId])
REFERENCES [dbo].[Purchase] ([Id])
GO
ALTER TABLE [dbo].[purchasepaiddetail] CHECK CONSTRAINT [FK_purchasepaiddetail_Purchase_PurchaseOrderId]
GO
ALTER TABLE [dbo].[purchasereturn]  WITH CHECK ADD  CONSTRAINT [FK_purchasereturn_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[purchasereturn] CHECK CONSTRAINT [FK_purchasereturn_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[purchasereturn]  WITH CHECK ADD  CONSTRAINT [FK_purchasereturn_Purchase_PurchaseId] FOREIGN KEY([PurchaseId])
REFERENCES [dbo].[Purchase] ([Id])
GO
ALTER TABLE [dbo].[purchasereturn] CHECK CONSTRAINT [FK_purchasereturn_Purchase_PurchaseId]
GO
ALTER TABLE [dbo].[purchasereturnDetail]  WITH CHECK ADD  CONSTRAINT [FK_purchasereturnDetail_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[purchasereturnDetail] CHECK CONSTRAINT [FK_purchasereturnDetail_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[purchasereturnDetail]  WITH CHECK ADD  CONSTRAINT [FK_purchasereturnDetail_ItemMaster_ItemMasterId] FOREIGN KEY([ItemMasterId])
REFERENCES [dbo].[ItemMaster] ([Id])
GO
ALTER TABLE [dbo].[purchasereturnDetail] CHECK CONSTRAINT [FK_purchasereturnDetail_ItemMaster_ItemMasterId]
GO
ALTER TABLE [dbo].[purchasereturnDetail]  WITH CHECK ADD  CONSTRAINT [FK_purchasereturnDetail_purchasereturn_purchasereturnId] FOREIGN KEY([purchasereturnId])
REFERENCES [dbo].[purchasereturn] ([Id])
GO
ALTER TABLE [dbo].[purchasereturnDetail] CHECK CONSTRAINT [FK_purchasereturnDetail_purchasereturn_purchasereturnId]
GO
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [FK_Receipt_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [FK_Receipt_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [FK_Receipt_ledger_ledgerId] FOREIGN KEY([ledgerId])
REFERENCES [dbo].[ledger] ([Id])
GO
ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [FK_Receipt_ledger_ledgerId]
GO
ALTER TABLE [dbo].[ReceiptTransactions]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptTransactions_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ReceiptTransactions] CHECK CONSTRAINT [FK_ReceiptTransactions_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[ReceiptTransactions]  WITH CHECK ADD  CONSTRAINT [FK_ReceiptTransactions_Receipt_ReceiptId] FOREIGN KEY([ReceiptId])
REFERENCES [dbo].[Receipt] ([Id])
GO
ALTER TABLE [dbo].[ReceiptTransactions] CHECK CONSTRAINT [FK_ReceiptTransactions_Receipt_ReceiptId]
GO
ALTER TABLE [dbo].[salereturn]  WITH CHECK ADD  CONSTRAINT [FK_salereturn_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[salereturn] CHECK CONSTRAINT [FK_salereturn_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[salereturn]  WITH CHECK ADD  CONSTRAINT [FK_salereturn_Sales_SalesId] FOREIGN KEY([SalesId])
REFERENCES [dbo].[Sales] ([Id])
GO
ALTER TABLE [dbo].[salereturn] CHECK CONSTRAINT [FK_salereturn_Sales_SalesId]
GO
ALTER TABLE [dbo].[salereturnDetail]  WITH CHECK ADD  CONSTRAINT [FK_salereturnDetail_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[salereturnDetail] CHECK CONSTRAINT [FK_salereturnDetail_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[salereturnDetail]  WITH CHECK ADD  CONSTRAINT [FK_salereturnDetail_ItemMaster_ItemMasterId] FOREIGN KEY([ItemMasterId])
REFERENCES [dbo].[ItemMaster] ([Id])
GO
ALTER TABLE [dbo].[salereturnDetail] CHECK CONSTRAINT [FK_salereturnDetail_ItemMaster_ItemMasterId]
GO
ALTER TABLE [dbo].[salereturnDetail]  WITH CHECK ADD  CONSTRAINT [FK_salereturnDetail_salereturn_salereturnId] FOREIGN KEY([salereturnId])
REFERENCES [dbo].[salereturn] ([Id])
GO
ALTER TABLE [dbo].[salereturnDetail] CHECK CONSTRAINT [FK_salereturnDetail_salereturn_salereturnId]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Customer_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Customer_CustomerId]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_SalesOrder_SalesOrderId] FOREIGN KEY([SalesOrderId])
REFERENCES [dbo].[SalesOrder] ([Id])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_SalesOrder_SalesOrderId]
GO
ALTER TABLE [dbo].[SalesDetail]  WITH CHECK ADD  CONSTRAINT [FK_SalesDetail_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[SalesDetail] CHECK CONSTRAINT [FK_SalesDetail_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[SalesDetail]  WITH CHECK ADD  CONSTRAINT [FK_SalesDetail_ItemMaster_ItemMasterId] FOREIGN KEY([ItemMasterId])
REFERENCES [dbo].[ItemMaster] ([Id])
GO
ALTER TABLE [dbo].[SalesDetail] CHECK CONSTRAINT [FK_SalesDetail_ItemMaster_ItemMasterId]
GO
ALTER TABLE [dbo].[SalesDetail]  WITH CHECK ADD  CONSTRAINT [FK_SalesDetail_Sales_SalesId] FOREIGN KEY([SalesId])
REFERENCES [dbo].[Sales] ([Id])
GO
ALTER TABLE [dbo].[SalesDetail] CHECK CONSTRAINT [FK_SalesDetail_Sales_SalesId]
GO
ALTER TABLE [dbo].[SalesOrder]  WITH CHECK ADD  CONSTRAINT [FK_SalesOrder_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[SalesOrder] CHECK CONSTRAINT [FK_SalesOrder_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[SalesOrder]  WITH CHECK ADD  CONSTRAINT [FK_SalesOrder_Customer_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[SalesOrder] CHECK CONSTRAINT [FK_SalesOrder_Customer_CustomerId]
GO
ALTER TABLE [dbo].[SalesOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_SalesOrderDetail_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[SalesOrderDetail] CHECK CONSTRAINT [FK_SalesOrderDetail_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[SalesOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_SalesOrderDetail_ItemMaster_ItemMasterId] FOREIGN KEY([ItemMasterId])
REFERENCES [dbo].[ItemMaster] ([Id])
GO
ALTER TABLE [dbo].[SalesOrderDetail] CHECK CONSTRAINT [FK_SalesOrderDetail_ItemMaster_ItemMasterId]
GO
ALTER TABLE [dbo].[SalesOrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_SalesOrderDetail_SalesOrder_SalesOrderId] FOREIGN KEY([SalesOrderId])
REFERENCES [dbo].[SalesOrder] ([Id])
GO
ALTER TABLE [dbo].[SalesOrderDetail] CHECK CONSTRAINT [FK_SalesOrderDetail_SalesOrder_SalesOrderId]
GO
ALTER TABLE [dbo].[Salespaiddetail]  WITH CHECK ADD  CONSTRAINT [FK_Salespaiddetail_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Salespaiddetail] CHECK CONSTRAINT [FK_Salespaiddetail_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Salespaiddetail]  WITH CHECK ADD  CONSTRAINT [FK_Salespaiddetail_Sales_SalesId] FOREIGN KEY([SalesId])
REFERENCES [dbo].[Sales] ([Id])
GO
ALTER TABLE [dbo].[Salespaiddetail] CHECK CONSTRAINT [FK_Salespaiddetail_Sales_SalesId]
GO
ALTER TABLE [dbo].[ScrollText]  WITH CHECK ADD  CONSTRAINT [FK_ScrollText_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ScrollText] CHECK CONSTRAINT [FK_ScrollText_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[service]  WITH CHECK ADD  CONSTRAINT [FK_service_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[service] CHECK CONSTRAINT [FK_service_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[service]  WITH CHECK ADD  CONSTRAINT [FK_service_servicetype_servicetypeId] FOREIGN KEY([servicetypeId])
REFERENCES [dbo].[servicetype] ([Id])
GO
ALTER TABLE [dbo].[service] CHECK CONSTRAINT [FK_service_servicetype_servicetypeId]
GO
ALTER TABLE [dbo].[servicetype]  WITH CHECK ADD  CONSTRAINT [FK_servicetype_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[servicetype] CHECK CONSTRAINT [FK_servicetype_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[servicetype]  WITH CHECK ADD  CONSTRAINT [FK_servicetype_coa_coaId] FOREIGN KEY([coaId])
REFERENCES [dbo].[coa] ([Id])
GO
ALTER TABLE [dbo].[servicetype] CHECK CONSTRAINT [FK_servicetype_coa_coaId]
GO
ALTER TABLE [dbo].[State]  WITH CHECK ADD  CONSTRAINT [FK_State_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[State] CHECK CONSTRAINT [FK_State_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[State]  WITH CHECK ADD  CONSTRAINT [FK_State_Country_CountryId] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Country] ([Id])
GO
ALTER TABLE [dbo].[State] CHECK CONSTRAINT [FK_State_Country_CountryId]
GO
ALTER TABLE [dbo].[StockMaster]  WITH CHECK ADD  CONSTRAINT [FK_StockMaster_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[StockMaster] CHECK CONSTRAINT [FK_StockMaster_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[StockMaster]  WITH CHECK ADD  CONSTRAINT [FK_StockMaster_ItemMaster_ItemMasterId] FOREIGN KEY([ItemMasterId])
REFERENCES [dbo].[ItemMaster] ([Id])
GO
ALTER TABLE [dbo].[StockMaster] CHECK CONSTRAINT [FK_StockMaster_ItemMaster_ItemMasterId]
GO
ALTER TABLE [dbo].[Store]  WITH CHECK ADD  CONSTRAINT [FK_Store_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Store] CHECK CONSTRAINT [FK_Store_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Store]  WITH CHECK ADD  CONSTRAINT [FK_Store_City_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[City] ([Id])
GO
ALTER TABLE [dbo].[Store] CHECK CONSTRAINT [FK_Store_City_CityId]
GO
ALTER TABLE [dbo].[Store]  WITH CHECK ADD  CONSTRAINT [FK_Store_Company_CompanyId] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([Id])
GO
ALTER TABLE [dbo].[Store] CHECK CONSTRAINT [FK_Store_Company_CompanyId]
GO
ALTER TABLE [dbo].[Supplier]  WITH CHECK ADD  CONSTRAINT [FK_Supplier_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Supplier] CHECK CONSTRAINT [FK_Supplier_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Supplier]  WITH CHECK ADD  CONSTRAINT [FK_Supplier_City_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[City] ([Id])
GO
ALTER TABLE [dbo].[Supplier] CHECK CONSTRAINT [FK_Supplier_City_CityId]
GO
ALTER TABLE [dbo].[Supplier]  WITH CHECK ADD  CONSTRAINT [FK_Supplier_Currency_CurrencyId] FOREIGN KEY([CurrencyId])
REFERENCES [dbo].[Currency] ([Id])
GO
ALTER TABLE [dbo].[Supplier] CHECK CONSTRAINT [FK_Supplier_Currency_CurrencyId]
GO
ALTER TABLE [dbo].[Supplier]  WITH CHECK ADD  CONSTRAINT [FK_Supplier_partner_partnerId] FOREIGN KEY([partnerId])
REFERENCES [dbo].[partner] ([Id])
GO
ALTER TABLE [dbo].[Supplier] CHECK CONSTRAINT [FK_Supplier_partner_partnerId]
GO
ALTER TABLE [dbo].[Supplier]  WITH CHECK ADD  CONSTRAINT [FK_Supplier_suppliercategory_categoryId] FOREIGN KEY([categoryId])
REFERENCES [dbo].[suppliercategory] ([Id])
GO
ALTER TABLE [dbo].[Supplier] CHECK CONSTRAINT [FK_Supplier_suppliercategory_categoryId]
GO
ALTER TABLE [dbo].[Supplier]  WITH CHECK ADD  CONSTRAINT [FK_Supplier_suppliergroup_suppliergroupId] FOREIGN KEY([suppliergroupId])
REFERENCES [dbo].[suppliergroup] ([Id])
GO
ALTER TABLE [dbo].[Supplier] CHECK CONSTRAINT [FK_Supplier_suppliergroup_suppliergroupId]
GO
ALTER TABLE [dbo].[suppliercategory]  WITH CHECK ADD  CONSTRAINT [FK_suppliercategory_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[suppliercategory] CHECK CONSTRAINT [FK_suppliercategory_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[suppliercategory]  WITH CHECK ADD  CONSTRAINT [FK_suppliercategory_coa_coaId] FOREIGN KEY([coaId])
REFERENCES [dbo].[coa] ([Id])
GO
ALTER TABLE [dbo].[suppliercategory] CHECK CONSTRAINT [FK_suppliercategory_coa_coaId]
GO
ALTER TABLE [dbo].[SupplierContact]  WITH CHECK ADD  CONSTRAINT [FK_SupplierContact_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[SupplierContact] CHECK CONSTRAINT [FK_SupplierContact_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[SupplierContact]  WITH CHECK ADD  CONSTRAINT [FK_SupplierContact_Supplier_SupplierId] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Supplier] ([Id])
GO
ALTER TABLE [dbo].[SupplierContact] CHECK CONSTRAINT [FK_SupplierContact_Supplier_SupplierId]
GO
ALTER TABLE [dbo].[suppliergroup]  WITH CHECK ADD  CONSTRAINT [FK_suppliergroup_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[suppliergroup] CHECK CONSTRAINT [FK_suppliergroup_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_Task_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[TaxMaster]  WITH CHECK ADD  CONSTRAINT [FK_TaxMaster_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[TaxMaster] CHECK CONSTRAINT [FK_TaxMaster_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[UserCountries]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UserCountries_dbo.ApplicationUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[ApplicationUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserCountries] CHECK CONSTRAINT [FK_dbo.UserCountries_dbo.ApplicationUsers_UserId]
GO
ALTER TABLE [dbo].[UserHierarchies]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UserHierarchies_dbo.ApplicationUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[ApplicationUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserHierarchies] CHECK CONSTRAINT [FK_dbo.UserHierarchies_dbo.ApplicationUsers_UserId]
GO
ALTER TABLE [dbo].[UserPagesAssigned]  WITH CHECK ADD  CONSTRAINT [FK_UserPagesAssigned_ApplicationUser_CreatedUserId] FOREIGN KEY([CreatedUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserPagesAssigned] CHECK CONSTRAINT [FK_UserPagesAssigned_ApplicationUser_CreatedUserId]
GO
ALTER TABLE [dbo].[UserPagesAssigned]  WITH CHECK ADD  CONSTRAINT [FK_UserPagesAssigned_ApplicationUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[UserPagesAssigned] CHECK CONSTRAINT [FK_UserPagesAssigned_ApplicationUser_UserId]
GO
ALTER TABLE [dbo].[UserProducts]  WITH CHECK ADD  CONSTRAINT [FK_dbo.UserProducts_dbo.ApplicationUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[ApplicationUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserProducts] CHECK CONSTRAINT [FK_dbo.UserProducts_dbo.ApplicationUsers_UserId]
GO
/****** Object:  StoredProcedure [dbo].[GetCustomerInfo_Trademate]    Script Date: 15-09-2023 09:41:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Baiju>
-- Create date: <Create Date,,2020-Sep-02>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetCustomerInfo_Trademate] --[dbo].[GetCustomerInfo_Trademate] 0
	-- Add the parameters for the stored procedure here
	@CustomeId bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT cu.Id,max(cu.code) code ,max(cu.CustomerName) Name,max(cu.CustomerAddress) address,max(cu.creditlimit) creditlimit ,max(cu.creditdays) creditdays
,case coalesce(max(cua.assignedDay),8) When 0 Then 'Sunday'      
  When 1 Then 'Monday'       
  When 2 Then 'Tuesday'       
  When 3 Then 'Wednesday'      
  When 4 Then 'Thursday'       
  When 5 Then 'Friday'   
  When 6 Then 'Saturday' 
  when 8 Then 'Not Assigned'
    end assignedDay
,coalesce(max(au.Username),'Not Assigned') assignedTo,coalesce(sum(sa.balance),0) Balance,
case when dateadd(day,max(cu.creditdays),coalesce(MIN(sa.CreatedDate),getdate()))<GETDATE() then 'Credit Days Over' 
when max(cu.creditlimit)<coalesce(sum(sa.balance),0) then 'Credit limit over' else 'Active' end status,max(cc.Number) number
  FROM [TradeMate].[dbo].[Customer] cu
  left join [TradeMate].[dbo].[CustomerUserAssign] cua on cu.Id=cua.CustomerId  and cua.Status>0
  left join [TradeMate].[dbo].[ApplicationUser] au on au.Id=cua.AssignedUserId  
  left join [TradeMate].[dbo].[Sales] sa on cu.Id=sa.CustomerId and sa.balance<>0
  left join [TradeMate].[dbo].CustomerContact cc on cu.Id=cc.CustomerId 
  --left join [TradeMate].[dbo].[Sales] sab on cu.Id=sab.CustomerId and sab.balance<>0
  where cu.Id=@CustomeId or @CustomeId=0 
  group by cu.Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetItemInfo_Trademate]    Script Date: 15-09-2023 09:41:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Baiju>
-- Create date: <Create Date,,2020-Sep-02>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetItemInfo_Trademate] -- [dbo].[GetItemInfo_Trademate] 1789
	-- Add the parameters for the stored procedure here
	@itemId bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	IF OBJECT_ID(N'tempdb..#Temp') IS NOT NULL
BEGIN
DROP TABLE #Temp
END
    -- Insert statements for procedure here
SELECT * INTO #Temp FROM (
SELECT de.Id, ma.ItemName ItemName, ma.ItemCode code,sa.invoiceno Invoiceno,'Sales' type,case when de.amount<0 then de.qty else de.qty*-1 end count, amount, cu.CustomerName customer,sa.CreatedDate date,au.Username created
from SalesDetail de 
join Sales sa on sa.Id=de.SalesId 
join ItemMaster ma on ma.Id=de.ItemMasterId
join Customer cu on cu.Id=sa.CustomerId
join ApplicationUser au on au.Id=sa.CreatedUserId
where ItemMasterId=@itemId and de.Status>0 
union 
SELECT de.Id, ma.ItemName ItemName, ma.ItemCode code,sa.invoiceno Invoiceno,'Purchase' type,case when de.amount>0 then de.qty else de.qty*-1 end count, amount, cu.SupplierName customer,sa.CreatedDate date,au.Username created
from PurchaseDetail de 
join Purchase sa on sa.Id=de.PurchaseOrderId and sa.Status>1
join ItemMaster ma on ma.Id=de.ItemMasterId 
join Supplier cu on cu.Id=sa.SupplierId 
join ApplicationUser au on au.Id=sa.CreatedUserId
where ItemMasterId=@itemId and de.Status>0
) as temp

SELECT 0 Id,'' ItemName, '' code,'' Invoiceno,'Total' type,sum(count) [count],sum(amount) amount, '' customer,GETDATE() [date],'' created from #Temp
union
select * from #Temp
END
GO
/****** Object:  StoredProcedure [dbo].[GetProduct_Trademate]    Script Date: 15-09-2023 09:41:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Baiju>
-- Create date: <Create Date,,2020-Sep-02>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetProduct_Trademate] -- [dbo].[GetProduct_Trademate] 0,0,1
	-- Add the parameters for the stored procedure here
	@cart bit,
	@site bit,
	@type int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT  [Id]
      ,[CreatedUserId]
      ,[ModifiedUserId]
      ,[CreatedDate]
      ,[ModifiedDate]
      ,[IpAddress]
      ,[Status]
      ,[ItemCode]
      ,[ItemName]
      ,[CategoryId]
      ,[TaxMasterId]
      ,[Price]
      ,[Description]
      ,[qty]
      ,[rol]
      ,[ItemBrandId]
      ,[PurPrice]
      ,[SalesPrice]
      ,[Maxqty]
      ,[BarCode]
      ,[ProductCode]
      ,
	  case when @type=1 then BaqalaPrice 
	   when @type=2 then MobilePrice 
	   when @type=3 then StationaryPrice 
	  
	  else [Offerprice] end as Offerprice
      ,[Showcart]
      ,[Showsite]
      ,[type]
      ,[MobilePrice]
      ,[BaqalaPrice]
      ,[StationaryPrice], im.thumb
FROM    ItemMaster ma
CROSS APPLY
        (
        SELECT  TOP 1 img.thumb
        FROM    ItemImage img
        WHERE   img.ItemMasterId = ma.Id and img.Status=1
        ) im
		where ma.Showcart=@cart and ma.Showsite=@site and (ma.type=@type or ma.type=0)
END
GO
/****** Object:  StoredProcedure [dbo].[GetVatInfo_Trademate]    Script Date: 15-09-2023 09:41:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Baiju>
-- Create date: <Create Date,,2020-Sep-02>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetVatInfo_Trademate] -- [dbo].[GetVatInfo_Trademate] 0,0
	-- Add the parameters for the stored procedure here
	@customerId bigint,
	@SupplierId bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT * INTO #Temp FROM (
SELECT sa.Id, sa.invoiceno ItemName, cu.TaxNo code,sa.invoiceno Invoiceno,'Sales' type,sa.Total count,sa.Total*0.05 amount, cu.CustomerName customer,sa.CreatedDate date,au.Username created
from Sales sa
join Customer cu on cu.Id=sa.CustomerId
join ApplicationUser au on au.Id=sa.CreatedUserId
where (sa.CustomerId=@customerId or @customerId=0) and sa.Status>0 and sa.Isvat=1
union 
SELECT sa.Id, sa.invoiceno ItemName, cu.TaxNo code,sa.invoiceno Invoiceno,'Purchase' type,sa.Total count,sa.Total*-0.05 amount, cu.SupplierName customer,sa.CreatedDate date,au.Username created
from Purchase sa
join Supplier cu on cu.Id=sa.SupplierId 
join ApplicationUser au on au.Id=sa.CreatedUserId
where (sa.SupplierId=@SupplierId or @SupplierId=0) and sa.Status>0 and sa.Isvat=1
) as temp

SELECT 0 Id,'' ItemName, '' code,'' Invoiceno,'Total' type,sum(count) [count],sum(amount) amount, '' customer,GETDATE() [date],'' created from #Temp
union
select * from #Temp
END
GO
USE [master]
GO
ALTER DATABASE [TradeMateSite] SET  READ_WRITE 
GO
