USE `master`;
 
/****** Object:  Database [OBE]    Script Date: 6/11/2020 12:54:26 AM ******/
CREATE DATABASE OBE
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OBE', FILENAME = N'C:Program FilesMicrosoft SQL ServerMSSQL15.MSSQLSERVERMSSQLDATAOBE.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OBE_log', FILENAME = N'C:Program FilesMicrosoft SQL ServerMSSQL15.MSSQLSERVERMSSQLDATAOBE_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE `OBE` SET COMPATIBILITY_LEVEL = 150;
 
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
then
CALL `OBE`.`dbo` v_action; = 'enable'
end if;
 
ALTER DATABASE `OBE` SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE `OBE` /* SET ANSI_NULLS OFF */ 
 
ALTER DATABASE `OBE` /* SET ANSI_PADDING OFF */ 
 
ALTER DATABASE `OBE` SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE `OBE` SET ARITHABORT OFF 
GO
ALTER DATABASE `OBE` SET AUTO_CLOSE OFF 
GO
ALTER DATABASE `OBE` SET AUTO_SHRINK OFF 
GO
ALTER DATABASE `OBE` SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE `OBE` SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE `OBE` SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE `OBE` SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE `OBE` SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE `OBE` /* SET QUOTED_IDENTIFIER OFF */ 
 
ALTER DATABASE `OBE` SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE `OBE` SET  DISABLE_BROKER 
GO
ALTER DATABASE `OBE` SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE `OBE` SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE `OBE` SET TRUSTWORTHY OFF 
GO
ALTER DATABASE `OBE` SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE `OBE` SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE `OBE` SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE `OBE` SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE `OBE` SET RECOVERY FULL 
GO
ALTER DATABASE `OBE` SET  MULTI_USER 
GO
ALTER DATABASE `OBE` SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE `OBE` SET DB_CHAINING OFF 
GO
ALTER DATABASE `OBE` SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE `OBE` SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE `OBE` SET DELAYED_DURABILITY = DISABLED; 
 
CALL sys.sp_db_vardecimal_storage_format( N'OBE', N'ON');
 
ALTER DATABASE `OBE` SET QUERY_STORE = OFF;
 
USE `OBE`;
 
/****** Object:  Table [dbo].[Students]    Script Date: 6/11/2020 12:54:27 AM ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE TABLE Students(
	`id` int AUTO_INCREMENT NOT NULL,
	`student_id` varchar(13) NOT NULL,
	`program_id` int NOT NULL,
	`guardianName` varchar(60) NOT NULL,
	`guardianContact` varchar(13) NOT NULL,
 CONSTRAINT `PK_Students` PRIMARY KEY 
(
	`id` ASC
)  OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT `UQ__Students__2A33069BED79EE82` UNIQUE NONCLUSTERED 
(
	`student_id` ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonalInformation]    Script Date: 6/11/2020 12:54:27 AM ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE TABLE PersonalInformation(
	`username` varchar(13) NOT NULL,
	`fullName` varchar(60) NOT NULL,
	`fathersName` varchar(60) NOT NULL,
	`mothersName` varchar(60) NOT NULL,
	`image` varchar(200) NULL,
	`dateOfBirth` date NOT NULL,
	`contact` varchar(13) NOT NULL,
	`email` varchar(200) NULL,
	`presentAddress` varchar(300) NOT NULL,
	`permanentAddress` varchar(300) NOT NULL,
 CONSTRAINT `PK_PersonalInformation` PRIMARY KEY 
(
	`username` ASC
)  OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 6/11/2020 12:54:27 AM ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE TABLE Login(
	`username` varchar(13) NOT NULL,
	`password` varchar(200) NOT NULL,
	`role` varchar(50) NOT NULL,
	`isActive` int NOT NULL,
	`lastLoginDate` datetime(3) NULL
);
/****** Object:  View [dbo].[vw_allStudents]    Script Date: 6/11/2020 12:54:27 AM ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE VIEW `dbo`.`vw_allStudents`
AS
SELECT        dbo.Students.id, dbo.Students.student_id, dbo.PersonalInformation.fullName, dbo.Students.program_id, dbo.PersonalInformation.fathersName, dbo.PersonalInformation.mothersName, dbo.PersonalInformation.image, 
                         dbo.PersonalInformation.dateOfBirth, dbo.PersonalInformation.contact, dbo.PersonalInformation.guardianContact, dbo.PersonalInformation.email, dbo.PersonalInformation.presentAddress, 
                         dbo.PersonalInformation.permanentAddress, dbo.Login.password, dbo.Login.role, dbo.Login.isActive, dbo.Login.lastLoginDate
FROM            Login INNER JOIN
                         dbo.PersonalInformation ON dbo.Login.username = dbo.PersonalInformation.username INNER JOIN
                         dbo.Students ON dbo.PersonalInformation.username = dbo.Students.student_id
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 6/11/2020 12:54:27 AM ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE TABLE Courses(
	`id` int AUTO_INCREMENT NOT NULL,
	`name` varchar(100) NOT NULL,
	`code` varchar(10) NOT NULL,
	`descriptions` varchar(200) NOT NULL,
 CONSTRAINT `PK_Courses` PRIMARY KEY 
(
	`id` ASC
)  OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 6/11/2020 12:54:27 AM ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE TABLE Departments(
	`id` int AUTO_INCREMENT NOT NULL,
	`name` varchar(60) NOT NULL,
	`descriptions` varchar(200) NOT NULL,
 CONSTRAINT `PK_Departments` PRIMARY KEY 
(
	`id` ASC
)  OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Missions]    Script Date: 6/11/2020 12:54:27 AM ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE TABLE Missions(
	`id` int AUTO_INCREMENT NOT NULL,
	`name` varchar(100) NOT NULL,
	`descriptions` varchar(200) NOT NULL,
 CONSTRAINT `PK_Table_1` PRIMARY KEY 
(
	`id` ASC
)  OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MissionToPEOMapping]    Script Date: 6/11/2020 12:54:27 AM ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE TABLE MissionToPEOMapping(
	`mission_id` int NOT NULL,
	`peo_id` int NOT NULL,
	`points` Double NOT NULL
);
/****** Object:  Table [dbo].[PEO]    Script Date: 6/11/2020 12:54:27 AM ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE TABLE PEO(
	`id` int AUTO_INCREMENT NOT NULL,
	`program_id` int NOT NULL,
	`name` varchar(100) NOT NULL,
	`descriptions` varchar(200) NULL,
 CONSTRAINT `PK_PEO` PRIMARY KEY 
(
	`id` ASC
)  OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrerequisiteCoursesInformations]    Script Date: 6/11/2020 12:54:27 AM ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE TABLE PrerequisiteCoursesInformations(
	`course_id` int NOT NULL,
	`prerequisiteCourseId` int NOT NULL
);
/****** Object:  Table [dbo].[Programs]    Script Date: 6/11/2020 12:54:27 AM ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE TABLE Programs(
	`id` int AUTO_INCREMENT NOT NULL,
	`name` varchar(60) NOT NULL,
	`creditHour` Double NOT NULL,
	`duration` varchar(10) NOT NULL,
	`department_id` int NOT NULL,
 CONSTRAINT `PK_Programs` PRIMARY KEY 
(
	`id` ASC
)  OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 6/11/2020 12:54:27 AM ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE TABLE Staffs(
	`id` int AUTO_INCREMENT NOT NULL,
	`staff_id` varchar(13) NOT NULL,
	`department_id` int NOT NULL,
 CONSTRAINT `PK_Staffs` PRIMARY KEY 
(
	`id` ASC
)  OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	`staff_id` ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE `dbo`.`Login`  WITH CHECK ADD  CONSTRAINT `FK_Login_PersonalInformation` FOREIGN KEY(`username`)
REFERENCES [dbo].[PersonalInformation] (`username`)
GO
ALTER TABLE `dbo`.`Login` CHECK CONSTRAINT `FK_Login_PersonalInformation`
GO
ALTER TABLE `dbo`.`MissionToPEOMapping`  WITH CHECK ADD  CONSTRAINT `FK_MissionToPEOMapping_Missions` FOREIGN KEY(`mission_id`)
REFERENCES [dbo].[Missions] (`id`)
GO
ALTER TABLE `dbo`.`MissionToPEOMapping` CHECK CONSTRAINT `FK_MissionToPEOMapping_Missions`
GO
ALTER TABLE `dbo`.`MissionToPEOMapping`  WITH CHECK ADD  CONSTRAINT `FK_MissionToPEOMapping_PEO` FOREIGN KEY(`peo_id`)
REFERENCES [dbo].[PEO] (`id`)
GO
ALTER TABLE `dbo`.`MissionToPEOMapping` CHECK CONSTRAINT `FK_MissionToPEOMapping_PEO`
GO
ALTER TABLE `dbo`.`PEO`  WITH CHECK ADD  CONSTRAINT `FK_PEO_Programs` FOREIGN KEY(`program_id`)
REFERENCES [dbo].[Programs] (`id`)
GO
ALTER TABLE `dbo`.`PEO` CHECK CONSTRAINT `FK_PEO_Programs`
GO
ALTER TABLE `dbo`.`PrerequisiteCoursesInformations`  WITH CHECK ADD  CONSTRAINT `FK_PrerequisiteCoursesInformations_Courses` FOREIGN KEY(`course_id`)
REFERENCES [dbo].[Courses] (`id`)
GO
ALTER TABLE `dbo`.`PrerequisiteCoursesInformations` CHECK CONSTRAINT `FK_PrerequisiteCoursesInformations_Courses`
GO
ALTER TABLE `dbo`.`PrerequisiteCoursesInformations`  WITH CHECK ADD  CONSTRAINT `FK_PrerequisiteCoursesInformations_Courses1` FOREIGN KEY(`prerequisiteCourseId`)
REFERENCES [dbo].[Courses] (`id`)
GO
ALTER TABLE `dbo`.`PrerequisiteCoursesInformations` CHECK CONSTRAINT `FK_PrerequisiteCoursesInformations_Courses1`
GO
ALTER TABLE `dbo`.`Programs`  WITH CHECK ADD  CONSTRAINT `FK_Programs_Departments` FOREIGN KEY(`department_id`)
REFERENCES [dbo].[Departments] (`id`)
GO
ALTER TABLE `dbo`.`Programs` CHECK CONSTRAINT `FK_Programs_Departments`
GO
ALTER TABLE `dbo`.`Staffs`  WITH CHECK ADD  CONSTRAINT `FK_Staffs_Departments` FOREIGN KEY(`department_id`)
REFERENCES [dbo].[Departments] (`id`)
GO
ALTER TABLE `dbo`.`Staffs` CHECK CONSTRAINT `FK_Staffs_Departments`
GO
ALTER TABLE `dbo`.`Students`  WITH CHECK ADD  CONSTRAINT `FK_Students_Programs` FOREIGN KEY(`program_id`)
REFERENCES [dbo].[Programs] (`id`)
GO
ALTER TABLE `dbo`.`Students` CHECK CONSTRAINT `FK_Students_Programs`
GO
CALL sys.sp_addextendedproperty v_name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Login"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "PersonalInformation"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 435
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "Students"
            Begin Extent = 
               Top = 6
               Left = 473
               Bottom = 119
               Right = 643
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_allStudents'
GO
CALL sys.sp_addextendedproperty v_name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_allStudents'
GO
USE `master`;
 
ALTER DATABASE `OBE` SET  READ_WRITE 
GO
