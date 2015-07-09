USE [master]
GO
/****** Object:  Database [UniversityManagementDB]    Script Date: 07/07/2015 18:43:36 ******/
CREATE DATABASE [UniversityManagementDB] ON  PRIMARY 
( NAME = N'UniversityManagementDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\UniversityManagementDB.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'UniversityManagementDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\UniversityManagementDB_log.LDF' , SIZE = 504KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [UniversityManagementDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UniversityManagementDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UniversityManagementDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [UniversityManagementDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [UniversityManagementDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [UniversityManagementDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [UniversityManagementDB] SET ARITHABORT OFF
GO
ALTER DATABASE [UniversityManagementDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [UniversityManagementDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [UniversityManagementDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [UniversityManagementDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [UniversityManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [UniversityManagementDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [UniversityManagementDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [UniversityManagementDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [UniversityManagementDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [UniversityManagementDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [UniversityManagementDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [UniversityManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [UniversityManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [UniversityManagementDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [UniversityManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [UniversityManagementDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [UniversityManagementDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [UniversityManagementDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [UniversityManagementDB] SET  READ_WRITE
GO
ALTER DATABASE [UniversityManagementDB] SET RECOVERY FULL
GO
ALTER DATABASE [UniversityManagementDB] SET  MULTI_USER
GO
ALTER DATABASE [UniversityManagementDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [UniversityManagementDB] SET DB_CHAINING OFF
GO
USE [UniversityManagementDB]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 07/07/2015 18:43:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Students]    Script Date: 07/07/2015 18:43:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[RegNo] [varchar](50) NOT NULL,
	[Address] [varchar](300) NULL,
	[DepartmentId] [int] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[StudentDepartment]    Script Date: 07/07/2015 18:43:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[StudentDepartment]
AS
SELECT s.ID, s.Name,s.RegNo,s.Address,s.DepartmentId,d.Name as DepartmentName FROM Students as s  LEFT OUTER JOIN Departments as d

ON s.DepartmentId = d.Id
GO
/****** Object:  StoredProcedure [dbo].[GetStudentDepartmentByStudentId]    Script Date: 07/07/2015 18:43:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetStudentDepartmentByStudentId](@StudentId as int )

AS

SELECT * FROM StudentDepartment s
WHERE s.ID = @StudentId
GO
/****** Object:  ForeignKey [FK_Students_Departments]    Script Date: 07/07/2015 18:43:38 ******/
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Departments]
GO
