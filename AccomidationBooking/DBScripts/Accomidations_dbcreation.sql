USE [master]
GO
/****** Object:  Database [Accomidations]    Script Date: 14-01-2022 23:30:02 ******/
CREATE DATABASE [Accomidations]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Accomidations', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Accomidations.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Accomidations_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Accomidations_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Accomidations] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Accomidations].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Accomidations] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Accomidations] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Accomidations] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Accomidations] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Accomidations] SET ARITHABORT OFF 
GO
ALTER DATABASE [Accomidations] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Accomidations] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Accomidations] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Accomidations] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Accomidations] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Accomidations] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Accomidations] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Accomidations] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Accomidations] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Accomidations] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Accomidations] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Accomidations] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Accomidations] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Accomidations] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Accomidations] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Accomidations] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Accomidations] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Accomidations] SET RECOVERY FULL 
GO
ALTER DATABASE [Accomidations] SET  MULTI_USER 
GO
ALTER DATABASE [Accomidations] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Accomidations] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Accomidations] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Accomidations] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Accomidations] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Accomidations] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Accomidations', N'ON'
GO
ALTER DATABASE [Accomidations] SET QUERY_STORE = OFF
GO
USE [Accomidations]
GO
/****** Object:  Table [dbo].[Accomidations]    Script Date: 14-01-2022 23:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accomidations](
	[Id] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Desc] [varchar](150) NOT NULL,
 CONSTRAINT [PK_Accomidations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guest]    Script Date: 14-01-2022 23:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guest](
	[Id] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Guest] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hotels]    Script Date: 14-01-2022 23:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotels](
	[Id] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Desc] [varchar](150) NOT NULL,
	[Accomidations_Id] [int] NOT NULL,
	[HotelType_Id] [int] NOT NULL,
 CONSTRAINT [PK_Hotels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelType]    Script Date: 14-01-2022 23:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelType](
	[Id] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_HotelType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 14-01-2022 23:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[Id] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[CheckinDate] [datetime] NOT NULL,
	[CheckoutDate] [datetime] NOT NULL,
	[NoofPeople] [int] NOT NULL,
	[Guest] [varchar](100) NOT NULL,
	[BookedBy] [varchar](100) NOT NULL,
	[Room_Id] [int] NOT NULL,
	[Hotel_Id] [int] NOT NULL,
	[RoomType] [int] NOT NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 14-01-2022 23:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[Id] [int] NOT NULL,
	[Number] [int] NOT NULL,
	[Maxnoofpeople] [int] NOT NULL,
	[Availablepeople] [int] NOT NULL,
	[isShared] [bit] NOT NULL,
	[Hotel_Id] [int] NOT NULL,
	[RoomType_Id] [int] NOT NULL,
	[RoomStatus_Id] [int] NOT NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomStatus]    Script Date: 14-01-2022 23:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomStatus](
	[Id] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_RoomStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomType]    Script Date: 14-01-2022 23:30:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomType](
	[Id] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_RoomType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Hotels]  WITH CHECK ADD  CONSTRAINT [FK_Hotels_Accomidations_Id] FOREIGN KEY([Accomidations_Id])
REFERENCES [dbo].[Accomidations] ([Id])
GO
ALTER TABLE [dbo].[Hotels] CHECK CONSTRAINT [FK_Hotels_Accomidations_Id]
GO
ALTER TABLE [dbo].[Hotels]  WITH CHECK ADD  CONSTRAINT [FK_Hotels_HotelType_Id] FOREIGN KEY([HotelType_Id])
REFERENCES [dbo].[HotelType] ([Id])
GO
ALTER TABLE [dbo].[Hotels] CHECK CONSTRAINT [FK_Hotels_HotelType_Id]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Hotel_Id] FOREIGN KEY([Hotel_Id])
REFERENCES [dbo].[Hotels] ([Id])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Hotel_Id]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Room_Id] FOREIGN KEY([Room_Id])
REFERENCES [dbo].[Rooms] ([Id])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Room_Id]
GO
ALTER TABLE [dbo].[Rooms]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_Hotel_Id] FOREIGN KEY([Hotel_Id])
REFERENCES [dbo].[Hotels] ([Id])
GO
ALTER TABLE [dbo].[Rooms] CHECK CONSTRAINT [FK_Rooms_Hotel_Id]
GO
ALTER TABLE [dbo].[Rooms]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_RoomStatus_Id] FOREIGN KEY([RoomStatus_Id])
REFERENCES [dbo].[RoomStatus] ([Id])
GO
ALTER TABLE [dbo].[Rooms] CHECK CONSTRAINT [FK_Rooms_RoomStatus_Id]
GO
ALTER TABLE [dbo].[Rooms]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_RoomType_Id] FOREIGN KEY([RoomType_Id])
REFERENCES [dbo].[RoomType] ([Id])
GO
ALTER TABLE [dbo].[Rooms] CHECK CONSTRAINT [FK_Rooms_RoomType_Id]
GO
USE [master]
GO
ALTER DATABASE [Accomidations] SET  READ_WRITE 
GO
