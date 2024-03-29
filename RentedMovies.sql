USE [master]
GO
/****** Object:  Database [RentedMovies]    Script Date: 16-09-2019 14:06:16 ******/
CREATE DATABASE [RentedMovies]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RentedMovies', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RentedMovies.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RentedMovies_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RentedMovies_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RentedMovies] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentedMovies].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentedMovies] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentedMovies] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentedMovies] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentedMovies] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentedMovies] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentedMovies] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RentedMovies] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentedMovies] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentedMovies] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentedMovies] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentedMovies] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentedMovies] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentedMovies] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentedMovies] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentedMovies] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RentedMovies] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentedMovies] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentedMovies] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentedMovies] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentedMovies] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentedMovies] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentedMovies] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RentedMovies] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RentedMovies] SET  MULTI_USER 
GO
ALTER DATABASE [RentedMovies] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentedMovies] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RentedMovies] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RentedMovies] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RentedMovies] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RentedMovies] SET QUERY_STORE = OFF
GO
USE [RentedMovies]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 16-09-2019 14:06:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](255) NULL,
	[LastName] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Phone] [nvarchar](255) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 16-09-2019 14:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[Rating] [nvarchar](50) NULL,
	[Title] [nvarchar](255) NULL,
	[Year] [nvarchar](255) NULL,
	[Rental_Cost] [money] NULL,
	[Copies] [nvarchar](50) NULL,
	[Plot] [ntext] NULL,
	[Genre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentedMovie]    Script Date: 16-09-2019 14:06:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovie](
	[RMID] [int] IDENTITY(1,1) NOT NULL,
	[MovieIDFK] [int] NULL,
	[CustIDFK] [int] NULL,
	[DateRented] [datetime] NULL,
	[DateReturned] [datetime] NULL,
 CONSTRAINT [PK_RentedMovie] PRIMARY KEY CLUSTERED 
(
	[RMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (2, N'ishwar ', N'singh', N'2/513 manukau road epsom, auckland', N'0276142029')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (3, N'gurpyar ', N'singh', N'24 oakland avenue,papatoetoe, auckland', N'0226016427')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (4, N'sandeep ', N'singh', N'10 ross aveneu, papatoetoe, auckland', N'0272727030')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (5, N'nitin ', N'singh thakur', N'14 routhery road manurewa, auckland', N'0225308501')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (6, N'sukhman', N'singh', N'18 dreadon avenue papatoetoe, auckland', N'0275244857')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (7, N'jaskirat', N'singh', N'27 wentworth avenue papatoetoe auckland', N'0225005769')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (8, N'rohit ', N'khattri', N'10a wintere avenue papatoetoe auckland', N'788862089')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (9, N'mandeep ', N'singh', N'10a barrie avenue papatoetoe auckland', N'0266587020     ')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (10, N'amrit', N'singh', N'4/56 hillside road papatoetoe auckland', N'0226506440')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (11, N'akashdeep', N'singh', N'24 cornail avenue flatbush, auckland', N'0276430835')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (1, N'9.2', N'the godfather', N'1972', 2.0000, N'1', N'The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.', N'crime,drama')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (2, N'8.2', N'Schindler''s List', N'1993', 2.0000, N'1', N'In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.', N'boigraphy,drama,history')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (3, N'8.9', N'12 Angry men', N'1957', 2.0000, N'1', N'A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.', N'drama')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (4, N'8.6', N'. Life Is Beautiful ', N'1997', 2.0000, N'1', N'When an open-minded Jewish librarian and his son become victims of the Holocaust, he uses a perfect mixture of will, humor, and imagination to protect his son from the dangers around their camp.', N'comedy,drama,romance')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (5, N'8.8', N' The Good, the Bad and the Ugly ', N'1996', 2.0000, N'1', N'A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.', N'western')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (6, N'9.3', N'The Shawshank Redemption', N'1994', 2.0000, N'1', N'Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.', N'drama')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (7, N'9.3', N'7. The Pursuit of Happyness', N'2006', 2.0000, N'1', N'A struggling salesman takes custody of his son as he''s poised to begin a life-changing professional career.', N'biography,drama')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (8, N'8.6', N'Seven Samurai ', N'1954', 2.0000, N'1', N'A poor village under attack by bandits recruits seven unemployed samurai to help them defend themselves.', N'adventure,drama')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (9, N'8.5', N' The Intouchables', N'2011', 2.0000, N'1', N'After he becomes a quadriplegic from a paragliding accident, an aristocrat hires a young man from the projects to be his caregiver.', N'biography,comedy,drama')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (10, N'7.9', N'Central Station ', N'1998', 2.0000, N'1', N'An emotive journey of a former school teacher, who writes letters for illiterate people, and a young boy, whose mother has just died, as they search for the father he never knew.', N'drama')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (11, N'8.3', N'Requiem for a Dream ', N'2000', 2.0000, N'1', N'The drug-induced utopias of four Coney Island people are shattered when their addictions run deep.', N'drama')
SET IDENTITY_INSERT [dbo].[Movies] OFF
SET IDENTITY_INSERT [dbo].[RentedMovie] ON 

INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1, 6, 8, CAST(N'2019-09-13T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (2, 3, 4, CAST(N'2019-09-04T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (3, 10, 9, CAST(N'2019-09-06T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (4, 1, 2, CAST(N'2019-09-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[RentedMovie] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (5, 7, 2, CAST(N'2019-09-11T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[RentedMovie] OFF
USE [master]
GO
ALTER DATABASE [RentedMovies] SET  READ_WRITE 
GO
