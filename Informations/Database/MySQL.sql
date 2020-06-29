-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: obe
-- ------------------------------------------------------
-- Server version	8.0.20

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `academicevaluation`
--

DROP TABLE IF EXISTS `academicevaluation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `academicevaluation` (
  `id` int NOT NULL AUTO_INCREMENT,
  `course_id` int NOT NULL,
  `semester_id` int NOT NULL,
  `assessment_id` int NOT NULL,
  `marks` float NOT NULL,
  `EntryBy_Id` int NOT NULL,
  `EntryDate` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=61 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `academicevaluation`
--

LOCK TABLES `academicevaluation` WRITE;
/*!40000 ALTER TABLE `academicevaluation` DISABLE KEYS */;
INSERT INTO `academicevaluation` VALUES (21,1,1,1,8,1,'2020-06-27 12:35:32'),(22,1,1,2,7,1,'2020-06-27 12:35:32'),(23,1,1,3,0,1,'2020-06-27 12:35:32'),(24,1,1,4,5,1,'2020-06-27 12:35:32'),(25,1,1,5,5,1,'2020-06-27 12:35:32'),(26,1,1,6,0,1,'2020-06-27 12:35:32'),(27,1,1,8,0,1,'2020-06-27 12:35:32'),(28,1,1,9,5,1,'2020-06-27 12:35:32'),(29,6,1,1,10,1,'2020-06-27 12:37:32'),(30,6,1,2,10,1,'2020-06-27 12:37:32'),(31,6,1,3,0,1,'2020-06-27 12:37:32'),(32,6,1,4,5,1,'2020-06-27 12:37:32'),(33,6,1,5,0,1,'2020-06-27 12:37:32'),(34,6,1,6,0,1,'2020-06-27 12:37:32'),(35,6,1,8,0,1,'2020-06-27 12:37:32'),(36,6,1,9,5,1,'2020-06-27 12:37:32'),(37,2,1,1,10,1,'2020-06-27 12:48:06'),(38,2,1,2,10,1,'2020-06-27 12:48:06'),(39,2,1,3,0,1,'2020-06-27 12:48:06'),(40,2,1,4,0,1,'2020-06-27 12:48:06'),(41,2,1,5,0,1,'2020-06-27 12:48:06'),(42,2,1,6,0,1,'2020-06-27 12:48:06'),(43,2,1,8,0,1,'2020-06-27 12:48:06'),(44,2,1,9,10,1,'2020-06-27 12:48:07'),(45,3,2,1,10,1,'2020-06-28 15:38:03'),(46,3,2,2,10,1,'2020-06-28 15:38:03'),(47,3,2,3,0,1,'2020-06-28 15:38:03'),(48,3,2,4,0,1,'2020-06-28 15:38:03'),(49,3,2,5,0,1,'2020-06-28 15:38:03'),(50,3,2,6,0,1,'2020-06-28 15:38:03'),(51,3,2,8,5,1,'2020-06-28 15:38:03'),(52,3,2,9,5,1,'2020-06-28 15:38:03'),(53,1,2,1,7,1,'2020-06-28 15:46:49'),(54,1,2,2,8,1,'2020-06-28 15:46:49'),(55,1,2,3,0,1,'2020-06-28 15:46:49'),(56,1,2,4,5,1,'2020-06-28 15:46:49'),(57,1,2,5,5,1,'2020-06-28 15:46:49'),(58,1,2,6,0,1,'2020-06-28 15:46:49'),(59,1,2,8,0,1,'2020-06-28 15:46:49'),(60,1,2,9,5,1,'2020-06-28 15:46:50');
/*!40000 ALTER TABLE `academicevaluation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `academicevaluationttoclomapping`
--

DROP TABLE IF EXISTS `academicevaluationttoclomapping`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `academicevaluationttoclomapping` (
  `id` int NOT NULL AUTO_INCREMENT,
  `academicevaluation_id` int NOT NULL,
  `clo_id` int NOT NULL,
  `points` float NOT NULL,
  `EntryBy_id` int NOT NULL,
  `EntryDate` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `academicevaluationttoclomapping`
--

LOCK TABLES `academicevaluationttoclomapping` WRITE;
/*!40000 ALTER TABLE `academicevaluationttoclomapping` DISABLE KEYS */;
INSERT INTO `academicevaluationttoclomapping` VALUES (1,21,1,1,1,'2020-06-28 17:20:04'),(3,22,1,2,1,'2020-06-28 18:19:09'),(6,24,4,3,1,'2020-06-29 15:14:10');
/*!40000 ALTER TABLE `academicevaluationttoclomapping` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `academicgrading`
--

DROP TABLE IF EXISTS `academicgrading`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `academicgrading` (
  `id` int NOT NULL AUTO_INCREMENT,
  `gradingSystem_id` int NOT NULL,
  `gradeName` varchar(10) NOT NULL DEFAULT '',
  `percentageFrom` float NOT NULL,
  `percentageTo` float NOT NULL,
  `gpa` float NOT NULL,
  `EntryBy_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `FK_AcademicGradingtoGradingSystem_idx` (`gradingSystem_id`),
  CONSTRAINT `FK_AcademicGradingtoGradingSystem` FOREIGN KEY (`gradingSystem_id`) REFERENCES `gradingsystem` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `academicgrading`
--

LOCK TABLES `academicgrading` WRITE;
/*!40000 ALTER TABLE `academicgrading` DISABLE KEYS */;
INSERT INTO `academicgrading` VALUES (1,3,'A+',80,100,4,2),(2,3,'A',75,79,3.75,2),(3,3,'A-',70,74,3.5,2),(4,3,'B',60,69,3,2),(5,3,'B-',50,59,2.5,2),(6,3,'F',0,49,0,2);
/*!40000 ALTER TABLE `academicgrading` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `assessments`
--

DROP TABLE IF EXISTS `assessments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `assessments` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) NOT NULL,
  `type` varchar(100) NOT NULL,
  `EntryBy_id` int NOT NULL,
  `EntryDate` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assessments`
--

LOCK TABLES `assessments` WRITE;
/*!40000 ALTER TABLE `assessments` DISABLE KEYS */;
INSERT INTO `assessments` VALUES (1,'Class Test 1','Analyze',3,'2020-06-20 17:31:40'),(2,'Class Test 2','Apply',3,'2020-06-20 17:52:58'),(3,'Class Test 3','Evaluate',3,'2020-06-20 17:52:59'),(4,'Assignment 1','Understand',3,'2020-06-20 17:53:11'),(5,'Assignment 2','Create',3,'2020-06-20 17:54:49'),(6,'Co-Curricular Activities','Apply',3,'2020-06-20 17:56:13'),(8,'Quizze','Remember',3,'2020-06-20 17:56:33'),(9,'Attendance','Understand',1,'2020-06-24 14:57:39');
/*!40000 ALTER TABLE `assessments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clo`
--

DROP TABLE IF EXISTS `clo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clo` (
  `id` int NOT NULL AUTO_INCREMENT,
  `course_id` int NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Descriptions` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clo`
--

LOCK TABLES `clo` WRITE;
/*!40000 ALTER TABLE `clo` DISABLE KEYS */;
INSERT INTO `clo` VALUES (1,1,'CLO 1','Understand management, functions, process of planning and the concept of C'),(2,1,'CLO 2','Analyze the structure'),(4,1,'CLO 3','Remember dynamics of C, the concept of accuracy and perception, values and attitude'),(5,1,'CLO 4','Apply case studies on functions and processes.'),(6,1,'CLO 5','Analyze Individual behavior and dynamics of groups and effective workflow and structure of C'),(7,2,'CLO 1','Understand management, functions, process of planning and the concept of Java');
/*!40000 ALTER TABLE `clo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clotoplomapping`
--

DROP TABLE IF EXISTS `clotoplomapping`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clotoplomapping` (
  `id` int NOT NULL AUTO_INCREMENT,
  `clo_id` int NOT NULL,
  `plo_id` int NOT NULL,
  `points` float NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clotoplomapping`
--

LOCK TABLES `clotoplomapping` WRITE;
/*!40000 ALTER TABLE `clotoplomapping` DISABLE KEYS */;
INSERT INTO `clotoplomapping` VALUES (1,1,1,1),(2,1,3,2),(3,1,4,3),(4,1,5,3),(5,1,6,0),(6,4,1,0),(7,4,3,3),(8,4,4,2),(9,4,5,0),(10,4,6,2),(11,2,1,2),(12,2,3,2),(13,2,4,3),(14,2,5,0),(15,2,6,0),(16,5,1,0),(17,5,3,1),(18,5,4,0),(19,5,5,2),(20,5,6,3),(21,6,1,1),(22,6,3,0),(23,6,4,2),(24,6,5,0),(25,6,6,2),(26,7,1,0),(27,7,3,2),(28,7,4,1),(29,7,5,0),(30,7,6,3);
/*!40000 ALTER TABLE `clotoplomapping` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clotoplomappling`
--

DROP TABLE IF EXISTS `clotoplomappling`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clotoplomappling` (
  `id` int NOT NULL AUTO_INCREMENT,
  `clo_id` int NOT NULL,
  `plo_id` int NOT NULL,
  `points` float NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clotoplomappling`
--

LOCK TABLES `clotoplomappling` WRITE;
/*!40000 ALTER TABLE `clotoplomappling` DISABLE KEYS */;
/*!40000 ALTER TABLE `clotoplomappling` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `coursecontent`
--

DROP TABLE IF EXISTS `coursecontent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `coursecontent` (
  `id` int NOT NULL AUTO_INCREMENT,
  `course_id` int NOT NULL,
  `clo_id` int NOT NULL,
  `contentDescriptions` varchar(500) NOT NULL,
  `hours` float NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `coursecontent`
--

LOCK TABLES `coursecontent` WRITE;
/*!40000 ALTER TABLE `coursecontent` DISABLE KEYS */;
/*!40000 ALTER TABLE `coursecontent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `courseregistration`
--

DROP TABLE IF EXISTS `courseregistration`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `courseregistration` (
  `id` int NOT NULL AUTO_INCREMENT,
  `registrationinformation_id` int NOT NULL,
  `student_id` int NOT NULL,
  `registertime` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courseregistration`
--

LOCK TABLES `courseregistration` WRITE;
/*!40000 ALTER TABLE `courseregistration` DISABLE KEYS */;
INSERT INTO `courseregistration` VALUES (1,1,1,'2020-06-30 10:05:20'),(2,1,4,'2020-06-30 10:05:20'),(3,1,6,'2020-06-30 10:05:20'),(4,2,7,'2020-06-30 10:05:20'),(5,2,1,'2020-06-30 10:05:20'),(6,3,4,'2020-06-30 10:05:20'),(7,4,6,'2020-06-30 10:05:20'),(8,4,7,'2020-06-30 10:05:20'),(9,6,1,'2020-06-30 10:05:20'),(10,6,4,'2020-06-30 10:05:20'),(11,7,6,'2020-06-30 10:05:20'),(12,7,7,'2020-06-30 10:05:20'),(13,10,1,'2020-06-30 10:05:20'),(14,10,4,'2020-06-30 10:05:20'),(15,10,6,'2020-06-30 10:05:20'),(16,10,7,'2020-06-30 10:05:20');
/*!40000 ALTER TABLE `courseregistration` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `courses`
--

DROP TABLE IF EXISTS `courses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `courses` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `code` varchar(10) NOT NULL,
  `credit` float NOT NULL,
  `descriptions` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courses`
--

LOCK TABLES `courses` WRITE;
/*!40000 ALTER TABLE `courses` DISABLE KEYS */;
INSERT INTO `courses` VALUES (1,'Programming Language C','CSE1011',3,'Engineering Course of CSE'),(2,'Programming Language Java','CSE2015',3,'Engineering Course of CSE'),(3,'Database Design','CSE3011',3,'Engineering Course of CSE'),(4,'Advanced Java	','CSE4047	',3,'Engineering Course of CSE'),(5,'Web and Internet Programming','CSE4033',3,'Engineering Course of CSE'),(6,'Operating systems	','CSE3031',3,'Engineering Course of CSE'),(7,'Algorithm','CSE2021',3,'Engineering Course of CSE'),(8,'Data Structure	','CSE1033	',3,'Engineering Course of CSE'),(9,'Mathematical Analysis for Computer Science	','CSE3021',3,'Engineering Course of CSE'),(10,'Computer Architecture	','CSE3015',3,'Engineering Course of CSE');
/*!40000 ALTER TABLE `courses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departments`
--

DROP TABLE IF EXISTS `departments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departments` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(60) NOT NULL,
  `descriptions` varchar(200) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departments`
--

LOCK TABLES `departments` WRITE;
/*!40000 ALTER TABLE `departments` DISABLE KEYS */;
INSERT INTO `departments` VALUES (1,'Engineering','All Engineering Subject');
/*!40000 ALTER TABLE `departments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gradingsystem`
--

DROP TABLE IF EXISTS `gradingsystem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gradingsystem` (
  `id` int NOT NULL AUTO_INCREMENT,
  `systemName` varchar(45) NOT NULL,
  `EntryBy_id` int NOT NULL,
  `EntryDate` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gradingsystem`
--

LOCK TABLES `gradingsystem` WRITE;
/*!40000 ALTER TABLE `gradingsystem` DISABLE KEYS */;
INSERT INTO `gradingsystem` VALUES (1,'Gpa Based Grading',2,'2020-05-20 00:00:00'),(3,'Gpa-4 Based Grading',2,'2020-05-20 00:00:00');
/*!40000 ALTER TABLE `gradingsystem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `login` (
  `username` varchar(13) NOT NULL,
  `password` varchar(200) NOT NULL,
  `role` varchar(50) NOT NULL,
  `isActive` int NOT NULL,
  `lastLoginDate` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES ('2016000000007','123456','Student',1,'0001-01-01 00:00:00.000000'),('2016000000008','123456','Student',1,'0001-01-01 00:00:00.000000'),('2016000000009','123456','Student',1,'2020-06-13 03:05:10.000000'),('2016000000010','123456','Student',1,'0001-01-01 00:00:00.000000'),('2016000000015','123456','Student',1,'2020-05-20 10:00:00.000000'),('kmh','123456','Admin',1,'2020-05-20 10:05:00.000000'),('raj','123456','Faculty',1,'0001-01-01 00:00:00.000000'),('rakib','123456','Superadmin',1,'2020-05-20 00:00:00.000000'),('sm','sm123456','Admin',1,'2020-05-20 10:10:02.000000');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `missions`
--

DROP TABLE IF EXISTS `missions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `missions` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `descriptions` varchar(1000) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `missions`
--

LOCK TABLES `missions` WRITE;
/*!40000 ALTER TABLE `missions` DISABLE KEYS */;
INSERT INTO `missions` VALUES (13,'Perfection of Intelligence',' Life long learners who will be able to create, share and apply their knowledge in multidisciplinary areas to earn benefit for the humanity.'),(14,'Leadership Skill','Groom our students with the quality of leadership skill'),(18,'Complex Problem Solve','The mission of the department is to  groom our students with the quality complex problem solvers');
/*!40000 ALTER TABLE `missions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `missiontopeomapping`
--

DROP TABLE IF EXISTS `missiontopeomapping`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `missiontopeomapping` (
  `id` int NOT NULL AUTO_INCREMENT,
  `mission_id` int NOT NULL,
  `peo_id` int NOT NULL,
  `points` float NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `missiontopeomapping`
--

LOCK TABLES `missiontopeomapping` WRITE;
/*!40000 ALTER TABLE `missiontopeomapping` DISABLE KEYS */;
INSERT INTO `missiontopeomapping` VALUES (36,13,3,2),(37,13,5,3),(38,14,3,1),(39,14,5,3),(40,18,3,3),(41,18,5,0);
/*!40000 ALTER TABLE `missiontopeomapping` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `peo`
--

DROP TABLE IF EXISTS `peo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `peo` (
  `id` int NOT NULL AUTO_INCREMENT,
  `program_id` int NOT NULL,
  `name` varchar(100) NOT NULL,
  `descriptions` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `peo`
--

LOCK TABLES `peo` WRITE;
/*!40000 ALTER TABLE `peo` DISABLE KEYS */;
INSERT INTO `peo` VALUES (3,1,'PEO 2','PEO 2 Descriptions'),(5,1,'PEO 3','PEO 3 Descriptions');
/*!40000 ALTER TABLE `peo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personalinformation`
--

DROP TABLE IF EXISTS `personalinformation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personalinformation` (
  `id` int NOT NULL AUTO_INCREMENT,
  `fullName` varchar(60) NOT NULL,
  `fathersName` varchar(60) NOT NULL,
  `mothersName` varchar(60) NOT NULL,
  `dateOfBirth` date NOT NULL,
  `gender` varchar(6) NOT NULL,
  `contact` varchar(13) NOT NULL,
  `email` varchar(200) DEFAULT NULL,
  `presentAddress` varchar(300) NOT NULL,
  `permanentAddress` varchar(300) NOT NULL,
  `image` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personalinformation`
--

LOCK TABLES `personalinformation` WRITE;
/*!40000 ALTER TABLE `personalinformation` DISABLE KEYS */;
INSERT INTO `personalinformation` VALUES (1,'Md Rakibul Hasan','Md Anwer Hossain','Mst Ronjona Khatun','1998-05-22','male','01642090363','mrhasan.334@gmail.com','Dhaka, Bangladesh','Jamalpur, Bangladesh','Rakib.png'),(2,'Jafry Monfol Deep','Md JFR Father','Mst JFR Mother','1997-03-05','male','01122090363','jafry.334@gmail.com','Dhaka, Bangladesh','Gazipur, Bangladesh','jafry.jpg'),(3,'Monirul Hasan Tomal','Md KMH\'s Father','Mst KMH\'s Mother','1990-12-23','male','01236698432','kmh.334@gmail.com','Dhaka, Bangladesh','Dhaka, Bangladesh','kmh.jpg'),(4,'Shahriar Manzoor','Md SM\'s Father','Mst SM\'s Mother','1988-02-02','male','1236953214','sm.334@gmail.com','Dhaka, Bangladesh','Dhaka, Bangladesh','smsir.jpg'),(10,'Md Sohel Hossen','Md Hasan Khan','Mst Hasina Khan','2020-06-20','Male','01722589652','sohel@gmail.com','s','s','01393030-9365-4a89-9fa7-6604ae5041b8_userlogo.jpg'),(11,'Md Farhan Hasasn','Md Hasan Khan','Mst Hasina Khan','2020-06-20','Male','01722589652','sohel@gmail.com','sad','asdas','01393030-9365-4a89-9fa7-6604ae5041b8_userlogo.jpg'),(12,'Sojib Hasan','Md Habib Khan','Msy Habiba ','2020-06-20','Male','013827374793','Sojib@gmail.com','Tongi','Tongi','01393030-9365-4a89-9fa7-6604ae5041b8_userlogo.jpg'),(16,'Roksana Akter Joly ','Mam\'s Father','Mam\'s Mother','1991-06-20','Female','01722589652','joly@gmail.com','Dhaka','Dhaka,Dhaka','01393030-9365-4a89-9fa7-6604ae5041b8_userlogo.jpg');
/*!40000 ALTER TABLE `personalinformation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `plo`
--

DROP TABLE IF EXISTS `plo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `plo` (
  `id` int NOT NULL AUTO_INCREMENT,
  `program_id` int NOT NULL,
  `name` varchar(100) NOT NULL,
  `Descriptions` varchar(1000) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `plo`
--

LOCK TABLES `plo` WRITE;
/*!40000 ALTER TABLE `plo` DISABLE KEYS */;
INSERT INTO `plo` VALUES (1,1,'Engineering knowledge','Apply knowledge of mathematics, natural science, engineering fundamentals and Computer Science and Engineering to the solution of complex engineering problems.'),(3,1,'Problem analysis','Identify, formulate, research literature and analyse complex engineering problems reaching substantiated conclusions using first principles of mathematics, natural sciences and engineering sciences'),(4,1,'Design/development of solutions','Design solutions for complex engineering problems and design systems, components or processes that meet specified needs with appropriate consideration for public health and safety, cultural, societal, and environmental considerations.'),(5,1,'Investigation','Conduct investigations of complex problems using research-based knowledge and research methods including design of experiments, analysis and interpretation of data, and synthesis of information to provide valid conclusions.'),(6,1,'Modern tool usage','Create, select and apply appropriate techniques, resources, and modern engineering and IT tools, including prediction and modelling, to complex engineering problems, with an understanding of the limitations.');
/*!40000 ALTER TABLE `plo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `plotopeomapping`
--

DROP TABLE IF EXISTS `plotopeomapping`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `plotopeomapping` (
  `id` int NOT NULL AUTO_INCREMENT,
  `plo_id` int NOT NULL,
  `peo_id` int NOT NULL,
  `points` float NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `plotopeomapping`
--

LOCK TABLES `plotopeomapping` WRITE;
/*!40000 ALTER TABLE `plotopeomapping` DISABLE KEYS */;
INSERT INTO `plotopeomapping` VALUES (3,5,3,3),(4,5,5,3),(6,1,3,2),(7,1,5,1);
/*!40000 ALTER TABLE `plotopeomapping` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prerequisitecoursesinformations`
--

DROP TABLE IF EXISTS `prerequisitecoursesinformations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prerequisitecoursesinformations` (
  `course_id` int NOT NULL,
  `prerequisiteCourseId` int NOT NULL,
  KEY `FK_PrerequisiteCoursesInformations_Courses` (`course_id`),
  KEY `FK_PrerequisiteCoursesInformations_Courses1` (`prerequisiteCourseId`),
  CONSTRAINT `FK_PrerequisiteCoursesInformations_Courses` FOREIGN KEY (`course_id`) REFERENCES `courses` (`id`),
  CONSTRAINT `FK_PrerequisiteCoursesInformations_Courses1` FOREIGN KEY (`prerequisiteCourseId`) REFERENCES `courses` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prerequisitecoursesinformations`
--

LOCK TABLES `prerequisitecoursesinformations` WRITE;
/*!40000 ALTER TABLE `prerequisitecoursesinformations` DISABLE KEYS */;
/*!40000 ALTER TABLE `prerequisitecoursesinformations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `programs`
--

DROP TABLE IF EXISTS `programs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `programs` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(60) NOT NULL,
  `creditHour` float NOT NULL,
  `duration` varchar(10) NOT NULL,
  `department_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `programs`
--

LOCK TABLES `programs` WRITE;
/*!40000 ALTER TABLE `programs` DISABLE KEYS */;
INSERT INTO `programs` VALUES (1,'BSC in CSE',144,'4 Yeaers',1),(2,'BSC in EEE',144,'4 Years',1);
/*!40000 ALTER TABLE `programs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registrationinformation`
--

DROP TABLE IF EXISTS `registrationinformation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `registrationinformation` (
  `id` int NOT NULL AUTO_INCREMENT,
  `semester_id` int NOT NULL,
  `course_id` int NOT NULL,
  `faculty_id` int NOT NULL,
  `Classday` varchar(50) NOT NULL,
  `classTimeStart` time NOT NULL,
  `classTimeEnd` time NOT NULL,
  `roomnumber` varchar(50) NOT NULL,
  `seatLimit` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registrationinformation`
--

LOCK TABLES `registrationinformation` WRITE;
/*!40000 ALTER TABLE `registrationinformation` DISABLE KEYS */;
INSERT INTO `registrationinformation` VALUES (1,1,1,1,'Sunday, Tuesday','10:00:00','11:30:00','AR1002',40),(2,1,1,2,'Sunday, Tuesday','10:00:00','11:30:00','AR1001',40),(3,1,2,7,'Monday, Wednesday','11:30:00','01:00:00','AR705',40),(4,1,2,7,'Monday, Wednesday','02:30:00','04:00:00','AR705',40),(5,1,2,1,'Monday, Wednesday','02:30:00','04:00:00','AR1205',40),(6,1,3,1,'Sunday, Tuesday','01:00:00','02:30:00','AR1202',40),(7,1,3,2,'Monday, Wednesday','11:30:00','01:00:00','AR1205',40),(8,1,4,2,'Monday, Wednesday','01:00:00','02:30:00','AR805',40),(9,1,4,1,'Saturday,Saturday','10:00:00','01:00:00','AR702',40),(10,1,5,7,'Sunday, Tuesday','08:30:00','10:00:00','AR901',40);
/*!40000 ALTER TABLE `registrationinformation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `result`
--

DROP TABLE IF EXISTS `result`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `result` (
  `id` int NOT NULL AUTO_INCREMENT,
  `gradingSystem_id` int NOT NULL,
  `academicevaluation_id` int NOT NULL,
  `student_id` int NOT NULL,
  `Marks` float NOT NULL,
  `EntryBy_id` int NOT NULL,
  `EntryDate` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `result`
--

LOCK TABLES `result` WRITE;
/*!40000 ALTER TABLE `result` DISABLE KEYS */;
/*!40000 ALTER TABLE `result` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `semesters`
--

DROP TABLE IF EXISTS `semesters`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `semesters` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `NAME` int NOT NULL,
  `EntryBy_id` int NOT NULL,
  `EntryDate` datetime NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `semesters`
--

LOCK TABLES `semesters` WRITE;
/*!40000 ALTER TABLE `semesters` DISABLE KEYS */;
/*!40000 ALTER TABLE `semesters` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `semesterschema`
--

DROP TABLE IF EXISTS `semesterschema`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `semesterschema` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(200) NOT NULL,
  `program_id` int NOT NULL,
  `course_id` int NOT NULL,
  `CIE` float NOT NULL,
  `SEE` float NOT NULL,
  `Total` float NOT NULL,
  `EntryBy_id` int NOT NULL,
  `EntryDate` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `semesterschema`
--

LOCK TABLES `semesterschema` WRITE;
/*!40000 ALTER TABLE `semesterschema` DISABLE KEYS */;
/*!40000 ALTER TABLE `semesterschema` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staffs`
--

DROP TABLE IF EXISTS `staffs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staffs` (
  `id` int NOT NULL AUTO_INCREMENT,
  `staff_id` varchar(13) NOT NULL,
  `department_id` int NOT NULL,
  `personalInformation_id` int NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UQ__Staffs__1963DD9DC2BF8AD1` (`staff_id`),
  KEY `FK_Staffs_PersonalInformation_idx` (`personalInformation_id`),
  CONSTRAINT `FK_Staffs_Login` FOREIGN KEY (`staff_id`) REFERENCES `login` (`username`),
  CONSTRAINT `FK_Staffs_PersonalInformation` FOREIGN KEY (`personalInformation_id`) REFERENCES `personalinformation` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staffs`
--

LOCK TABLES `staffs` WRITE;
/*!40000 ALTER TABLE `staffs` DISABLE KEYS */;
INSERT INTO `staffs` VALUES (1,'sm',1,4),(2,'kmh',1,3),(3,'rakib',1,1),(7,'raj',1,16);
/*!40000 ALTER TABLE `staffs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `students` (
  `id` int NOT NULL AUTO_INCREMENT,
  `student_id` varchar(13) NOT NULL,
  `program_id` int NOT NULL,
  `personalinformation_id` int NOT NULL,
  `guardianName` varchar(60) NOT NULL,
  `guardianContact` varchar(13) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UQ__Students__2A33069BED79EE82` (`student_id`),
  KEY `FK_Students_PersonalInformation_idx` (`personalinformation_id`),
  CONSTRAINT `FK_Students_Login` FOREIGN KEY (`student_id`) REFERENCES `login` (`username`),
  CONSTRAINT `FK_Students_PersonalInformation` FOREIGN KEY (`personalinformation_id`) REFERENCES `personalinformation` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES (1,'2016000000009',1,1,'Md Anwer Hossain ','01721383577'),(4,'2016000000015',1,2,'Md Kibria ','01723121212'),(6,'2016000000008',1,10,'Md Hasan Khan','01722589653'),(7,'2016000000007',1,11,'Md Hasan Khan','01722589653'),(8,'2016000000010',1,12,'Habib','026364747399');
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sysdiagrams`
--

DROP TABLE IF EXISTS `sysdiagrams`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sysdiagrams` (
  `name` varchar(160) NOT NULL,
  `principal_id` int NOT NULL,
  `diagram_id` int NOT NULL,
  `version` int DEFAULT NULL,
  `definition` longblob,
  PRIMARY KEY (`diagram_id`),
  UNIQUE KEY `UK_principal_name` (`principal_id`,`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sysdiagrams`
--

LOCK TABLES `sysdiagrams` WRITE;
/*!40000 ALTER TABLE `sysdiagrams` DISABLE KEYS */;
/*!40000 ALTER TABLE `sysdiagrams` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `vw_allacademicevaluation`
--

DROP TABLE IF EXISTS `vw_allacademicevaluation`;
/*!50001 DROP VIEW IF EXISTS `vw_allacademicevaluation`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allacademicevaluation` AS SELECT 
 1 AS `id`,
 1 AS `course_id`,
 1 AS `semester_id`,
 1 AS `assessment_id`,
 1 AS `marks`,
 1 AS `EntryBy_Id`,
 1 AS `EntryDate`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_allacademicevaluationttoclomapping`
--

DROP TABLE IF EXISTS `vw_allacademicevaluationttoclomapping`;
/*!50001 DROP VIEW IF EXISTS `vw_allacademicevaluationttoclomapping`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allacademicevaluationttoclomapping` AS SELECT 
 1 AS `id`,
 1 AS `academicevaluation_id`,
 1 AS `clo_id`,
 1 AS `points`,
 1 AS `EntryBy_id`,
 1 AS `EntryDate`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_allassessment`
--

DROP TABLE IF EXISTS `vw_allassessment`;
/*!50001 DROP VIEW IF EXISTS `vw_allassessment`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allassessment` AS SELECT 
 1 AS `Id`,
 1 AS `Name`,
 1 AS `type`,
 1 AS `EntryBy_id`,
 1 AS `EntryDate`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_allassessments`
--

DROP TABLE IF EXISTS `vw_allassessments`;
/*!50001 DROP VIEW IF EXISTS `vw_allassessments`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allassessments` AS SELECT 
 1 AS `Id`,
 1 AS `Name`,
 1 AS `type`,
 1 AS `EntryBy_id`,
 1 AS `EntryDate`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_allclos`
--

DROP TABLE IF EXISTS `vw_allclos`;
/*!50001 DROP VIEW IF EXISTS `vw_allclos`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allclos` AS SELECT 
 1 AS `id`,
 1 AS `course_id`,
 1 AS `Name`,
 1 AS `Descriptions`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_allclotoplomapping`
--

DROP TABLE IF EXISTS `vw_allclotoplomapping`;
/*!50001 DROP VIEW IF EXISTS `vw_allclotoplomapping`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allclotoplomapping` AS SELECT 
 1 AS `id`,
 1 AS `clo_id`,
 1 AS `plo_id`,
 1 AS `points`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_allcourses`
--

DROP TABLE IF EXISTS `vw_allcourses`;
/*!50001 DROP VIEW IF EXISTS `vw_allcourses`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allcourses` AS SELECT 
 1 AS `id`,
 1 AS `name`,
 1 AS `code`,
 1 AS `credit`,
 1 AS `descriptions`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_alldepartments`
--

DROP TABLE IF EXISTS `vw_alldepartments`;
/*!50001 DROP VIEW IF EXISTS `vw_alldepartments`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_alldepartments` AS SELECT 
 1 AS `id`,
 1 AS `name`,
 1 AS `descriptions`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_allgradingsystem`
--

DROP TABLE IF EXISTS `vw_allgradingsystem`;
/*!50001 DROP VIEW IF EXISTS `vw_allgradingsystem`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allgradingsystem` AS SELECT 
 1 AS `id`,
 1 AS `systemName`,
 1 AS `EntryBy_id`,
 1 AS `EntryDate`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_alllogin`
--

DROP TABLE IF EXISTS `vw_alllogin`;
/*!50001 DROP VIEW IF EXISTS `vw_alllogin`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_alllogin` AS SELECT 
 1 AS `username`,
 1 AS `password`,
 1 AS `role`,
 1 AS `isActive`,
 1 AS `lastLoginDate`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_allmission`
--

DROP TABLE IF EXISTS `vw_allmission`;
/*!50001 DROP VIEW IF EXISTS `vw_allmission`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allmission` AS SELECT 
 1 AS `id`,
 1 AS `name`,
 1 AS `descriptions`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_allmissiontopeomapping`
--

DROP TABLE IF EXISTS `vw_allmissiontopeomapping`;
/*!50001 DROP VIEW IF EXISTS `vw_allmissiontopeomapping`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allmissiontopeomapping` AS SELECT 
 1 AS `id`,
 1 AS `mission_id`,
 1 AS `peo_id`,
 1 AS `points`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_allpeo`
--

DROP TABLE IF EXISTS `vw_allpeo`;
/*!50001 DROP VIEW IF EXISTS `vw_allpeo`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allpeo` AS SELECT 
 1 AS `id`,
 1 AS `program_id`,
 1 AS `name`,
 1 AS `descriptions`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_allplo`
--

DROP TABLE IF EXISTS `vw_allplo`;
/*!50001 DROP VIEW IF EXISTS `vw_allplo`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allplo` AS SELECT 
 1 AS `id`,
 1 AS `program_id`,
 1 AS `name`,
 1 AS `Descriptions`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_allplotopeomapping`
--

DROP TABLE IF EXISTS `vw_allplotopeomapping`;
/*!50001 DROP VIEW IF EXISTS `vw_allplotopeomapping`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allplotopeomapping` AS SELECT 
 1 AS `id`,
 1 AS `plo_id`,
 1 AS `peo_id`,
 1 AS `points`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_allprograms`
--

DROP TABLE IF EXISTS `vw_allprograms`;
/*!50001 DROP VIEW IF EXISTS `vw_allprograms`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allprograms` AS SELECT 
 1 AS `id`,
 1 AS `name`,
 1 AS `creditHour`,
 1 AS `duration`,
 1 AS `department_id`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_allregistrationinformation`
--

DROP TABLE IF EXISTS `vw_allregistrationinformation`;
/*!50001 DROP VIEW IF EXISTS `vw_allregistrationinformation`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allregistrationinformation` AS SELECT 
 1 AS `id`,
 1 AS `registrationinformation_id`,
 1 AS `student_id`,
 1 AS `registertime`,
 1 AS `registrationinformationId`,
 1 AS `semester_id`,
 1 AS `course_id`,
 1 AS `faculty_id`,
 1 AS `ClassDay`,
 1 AS `classTimeStart`,
 1 AS `classTimeEnd`,
 1 AS `roomnumber`,
 1 AS `seatLimit`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_allstaffs`
--

DROP TABLE IF EXISTS `vw_allstaffs`;
/*!50001 DROP VIEW IF EXISTS `vw_allstaffs`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allstaffs` AS SELECT 
 1 AS `id`,
 1 AS `staff_id`,
 1 AS `department_id`,
 1 AS `fullName`,
 1 AS `fathersName`,
 1 AS `mothersName`,
 1 AS `dateOfBirth`,
 1 AS `gender`,
 1 AS `contact`,
 1 AS `email`,
 1 AS `presentAddress`,
 1 AS `permanentAddress`,
 1 AS `image`,
 1 AS `username`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vw_allstudents`
--

DROP TABLE IF EXISTS `vw_allstudents`;
/*!50001 DROP VIEW IF EXISTS `vw_allstudents`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vw_allstudents` AS SELECT 
 1 AS `id`,
 1 AS `student_id`,
 1 AS `program_id`,
 1 AS `guardianName`,
 1 AS `guardianContact`,
 1 AS `fullName`,
 1 AS `fathersName`,
 1 AS `mothersName`,
 1 AS `dateOfBirth`,
 1 AS `gender`,
 1 AS `contact`,
 1 AS `email`,
 1 AS `presentAddress`,
 1 AS `permanentAddress`,
 1 AS `image`,
 1 AS `username`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping routines for database 'obe'
--
/*!50003 DROP PROCEDURE IF EXISTS `sp_deleteAcademicEvaluation` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deleteAcademicEvaluation`(	
	IN Id INT
)
BEGIN
	DELETE FROM academicevaluation
    WHERE academicevaluation.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_deleteacademicevaluationttoclomapping` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deleteacademicevaluationttoclomapping`(
	IN Id INT
)
BEGIN
	DELETE FROM academicevaluationttoclomapping
    WHERE academicevaluationttoclomapping.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_deleteAcademicGrading` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deleteAcademicGrading`(
	IN id INT
)
BEGIN
	DELETE FROM academicgrading
    WHERE academicgrading.id = id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_deleteAssessment` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deleteAssessment`(
	IN Id INT
)
BEGIN
	DELETE FROM assessments
    WHERE assessments.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_deleteCLO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deleteCLO`(
	IN Id INT 
)
BEGIN
	DELETE FROM clo
    WHERE clo.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_deleteCLOToPLOMapping` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deleteCLOToPLOMapping`(
	IN Id INT
)
BEGIN
	DELETE FROM clotoplomapping
    WHERE clotoplomapping.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_deleteDepartments` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deleteDepartments`(
	IN Id INT
)
BEGIN
	DELETE FROM departments
    WHERE departments.Id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_deleteGradingSystem` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deleteGradingSystem`(
	IN Id INT
)
BEGIN
	DELETE FROM academicgrading
    WHERE academicgrading.gradingSystem_id = Id;
    
    DELETE FROM gradingsystem
    WHERE gradingsystem.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_deleteMission` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deleteMission`(
	IN Id INT
)
BEGIN
	DELETE FROM missions
    WHERE missions.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_deleteMissionToPEOMapping` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deleteMissionToPEOMapping`(	
	IN Id INT
)
BEGIN
	DELETE FROM MissionTOPEOMapping
    WHERE MissionTOPEOMapping.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_deletePEO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deletePEO`(
	IN Id INT
)
BEGIN
	DELETE FROM peo
    WHERE peo.Id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_deletePLO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deletePLO`(
	IN Id INT 
)
BEGIN
	DELETE FROM plo
    WHERE plo.Id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_deletePLOToPEOMapping` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deletePLOToPEOMapping`(
	IN Id INT
)
BEGIN
	DELETE FROM plotopeomapping 
    WHERE plotopeomapping.id = Id; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_deletePrograms` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_deletePrograms`(
	IN Id INT
)
BEGIN
	DELETE FROM programs 
    WHERE programs.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_saveAcademicEvaluation` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_saveAcademicEvaluation`(
    IN CourseId 	INT,
    IN AssessmentId INT,
    IN SemesterId 	INT,
    IN Marks 		FLOAT,
    IN EntryById 	INT,
    IN EntryDate 	DATETIME
)
BEGIN
	INSERT INTO academicevaluation
    (
        academicevaluation.course_id,
        academicevaluation.assessment_id,
        academicevaluation.semester_id,
        academicevaluation.marks,
        academicevaluation.EntryBy_id,
        academicevaluation.EntryDate
    )VALUES
    (	
         CourseId 	,
         AssessmentId, 
         SemesterId ,	
         Marks 		,
         EntryById 	,
         EntryDate 	
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_saveacademicevaluationttoclomapping` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_saveacademicevaluationttoclomapping`(
	IN AcademicEvaluationId INT,
    IN CLOId 				INT,
    IN Points 				FLOAT,
    IN EntryById 			INT,
    IN EntryDate 			DATETIME
)
BEGIN
	INSERT INTO academicevaluationttoclomapping
    (
		academicevaluationttoclomapping.academicevaluation_id,
        academicevaluationttoclomapping.clo_id,
        academicevaluationttoclomapping.points,
        academicevaluationttoclomapping.EntryBy_id,
        academicevaluationttoclomapping.EntryDate
    )
    VALUES
    (
		AcademicEvaluationId,
        CLOId 				,
        Points 				,
        EntryById 			,
        EntryDate 			
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_saveAcademicGrading` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_saveAcademicGrading`(
    IN GradingSystemId 		INT,
    IN GradeName 			VARCHAR(10),
    IN PercentageFrom		FLOAT,
    IN PercentageTo			FLOAT,
    IN Gpa					FLOAT,
    IN EntryBy_id		INT 
)
BEGIN
	INSERT INTO academicgrading
    (
		academicgrading.gradingSystem_id	,
        academicgrading.gradeName 			,
        academicgrading.percentageFrom		,
        academicgrading.percentageto		,
        academicgrading.gpa					,
        academicgrading.EntryBy_id
    )
    VALUES
    (
		GradingSystemId	,
        GradeName 			,
        PercentageFrom		,
        PercentageTo		,
        Gpa					,
        EntryBy_id
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_saveAssessment` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_saveAssessment`(
    IN Name VARCHAR(100),
    IN Type VARCHAR(100),
    IN EntryById INT,
    IN EntryDate DATETIME
)
BEGIN
    INSERT INTO assessments
    (
        assessments.name,
        assessments.type,
        assessments.EntryBy_id,
        assessments.EntryDate
    )
    VALUES
    (
        Name,
        Type,
        EntryById,
        EntryDate
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_saveCLO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_saveCLO`(
	IN Name VARCHAR(100),
    IN CourseId INT,
    IN Descriptions VARCHAR(1000)
)
BEGIN
	INSERT INTO clo
    (
		clo.course_id,
		clo.name,
        clo.descriptions
	)
    VALUES 
    (	
		CourseId,
        Name,
        Descriptions
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_saveCLOToPLOMapping` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_saveCLOToPLOMapping`(
	IN CLOId INT,
    IN PLOId INT,
    IN Points FLOAT
)
BEGIN
	INSERT INTO CLOToPLOMapping
    (
		clotoplomapping.clo_id,
		clotoplomapping.plo_id,
		clotoplomapping.points
    )
    VALUES
    (
		CLOId ,
		PLOId ,	
		Points 	
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_saveDepartments` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_saveDepartments`(
	IN Name VARCHAR(60),
    IN Descriptions VARCHAR(200)
)
BEGIN
	INSERT INTO departments
    (
		departments.Name,
        departments.descriptions
    )VALUES
    (	
		Name,
        Descriptions
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_saveExamInformation` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_saveExamInformation`(
	IN ExamName 		VARCHAR(60),
	IN InstitutionId 	INT,
	IN EntryBy_id 		INT
)
BEGIN
	INSERT INTO examinformation
    (
        examinformation.ExamName, 	
        examinformation.Institution_Id,
		examinformation.EntryBy_id 	
    )
    VALUES
    (
		ExamName, 	
        InstitutionId,
		EntryBy_id
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_saveGradingSystem` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_saveGradingSystem`(
	IN SystemName 	VARCHAR(45),
    IN EntryById 	INT,
    IN EntryDate 	DATETIME
)
BEGIN
	INSERT INTO gradingSystem
    (
		gradingSystem.SystemName,
		gradingSystem.EntryBy_id,
        gradingSystem.EntryDate 
    )VALUES
    (
		SystemName,
        EntryById,
        EntryDate
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_saveMission` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_saveMission`(
    IN Name VARCHAR(100),
    IN Description VARCHAR(1000)
)
BEGIN
	INSERT INTO missions 
    (
        missions.name,
		missions.descriptions
    )
    VALUES
    (
        Name,
        Description
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_saveMissionToPEOMapping` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_saveMissionToPEOMapping`(	
	IN MissionId INT,
    IN PEOId INT,
    IN Points FLOAT
)
BEGIN
	INSERT INTO MissionToPEOMapping
    (	
		MissionToPEOMapping.mission_id,
        MissionToPEOMapping.peo_id,
        MissionToPEOMapping.points
    )VALUES
    (	
		MissionId,
        PEOId,
        Points
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_savePEO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_savePEO`(
	IN ProgramId INT,
    IN Name VARCHAR(100),
    IN Description VARCHAR(1000)
	
)
BEGIN
	INSERT INTO peo
    (
		peo.program_id 	,
        peo.name 		,
        peo.descriptions 
    )
    VALUES
    (	
		ProgramId,
        Name ,
        Description
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_savePLO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_savePLO`(
	IN ProgramId INT,
    IN Name VARCHAR(100),
    IN Description VARCHAR(1000)
)
BEGIN
	INSERT INTO plo
    (
		plo.program_id 	,
        plo.name 		,
        plo.descriptions 
    )
    VALUES
    (	
		ProgramId,
        Name ,
        Description
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_savePLOToPEOMapping` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_savePLOToPEOMapping`(
	IN PLOId INT,
    IN PEOId INT,
    IN Points FLOAT
)
BEGIN
	INSERT INTO PLOToPEOMapping
    (	
		PLOToPEOMapping.plo_id,
        PLOToPEOMapping.peo_id,
        PLOToPEOMapping.points
    )VALUES
    (	
		PLOId,
        PEOId,
        Points
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_savePrograms` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_savePrograms`(
	IN Name 		VARCHAR(60),
    IN CreditHour 	FLOAT,
    IN Durations 	VARCHAR(10),
    IN DepartmentId INT
)
BEGIN
	INSERT INTO programs
    (
		programs.name,
        programs.creditHour,
        programs.durations,
        programs.department_id
    )
    VALUES
    (
		 Name, 		
         CreditHour, 	
         Durations 	,
         DepartmentId 
    );
    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_saveStaff` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_saveStaff`(
	IN StaffId 			VARCHAR(13),
    IN DepartmentId 	INT,
    IN FullName 		VARCHAR(60),
    IN FathersName 		VARCHAR(60),
    IN MothersName 		VARCHAR(60),
    IN DateOfBirth 		DATE,
    IN Gender 			VARCHAR(6),
    IN Contact 			VARCHAR(14),
    IN Email 			VARCHAR(200),
    IN PresentAddress 	VARCHAR(300),
    IN PermanentAddress VARCHAR(300),
    IN Image 			VARCHAR(200),
    IN Password 		VARCHAR(200),
    IN Role 			VARCHAR(50),
    IN LastLoginDate 	DATETIME,
    IN IsActive 		INT
)
BEGIN
START TRANSACTION;
	INSERT INTO personalinformation
    (
		personalinformation.fullName 		,
		personalinformation.fathersName 	,	
		personalinformation.mothersName 	,	
		personalinformation.dateOfBirth 	,	
		personalinformation.gender 			,
		personalinformation.contact 		,	
		personalinformation.email 			,
		personalinformation.presentAddress 	,
		personalinformation.permanentAddress, 
		personalinformation.image 			
    )
    VALUES
    (
		FullName 		,
		FathersName 	,	
		MothersName 	,	
		DateOfBirth 	,	
		Gender 			,
		Contact 		,	
		Email 			,
		PresentAddress 	,
		PermanentAddress, 
		Image 			
    );
    INSERT INTO login
    (
		login.username,
        login.password,
        login.role,
        login.lastLoginDate,
        login.isActive
    )VALUES
    (
		StaffId			,
        Password 		,
        Role 			,
        LastLoginDate 	,
		IsActive 	
    );
    
    INSERT INTO staffs
    (
		staffs.staff_id 		,	
		staffs.department_id 	,
        staffs.personalInformation_id
    )
    VALUES 
    (
		StaffId 		,
        DepartmentId 	,
        LAST_INSERT_ID()
    );
COMMIT;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_saveStudent` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_saveStudent`(
    IN StudentId		VARCHAR(13),
    IN ProgramId 		INT,
    IN GuardianName     VARCHAR(60),
    IN GuardianContact  VARCHAR(14),
    IN FullName 		VARCHAR(60),
    IN FathersName 		VARCHAR(60),
    IN MothersName 		VARCHAR(60),
    IN DateOfBirth 		DATE,
    IN Gender 			VARCHAR(6),
    IN Contact 			VARCHAR(14),
    IN Email 			VARCHAR(200),
    IN PresentAddress 	VARCHAR(300),
    IN PermanentAddress VARCHAR(300),
    IN Image 			VARCHAR(200),
    IN Password 		VARCHAR(200),
    IN Role 			VARCHAR(50),
    IN LastLoginDate 	DATETIME,
    IN IsActive 		INT
)
BEGIN
START TRANSACTION;
	INSERT INTO personalinformation
    (
		personalinformation.fullName 		,
		personalinformation.fathersName 	,	
		personalinformation.mothersName 	,	
		personalinformation.dateOfBirth 	,	
		personalinformation.gender 			,
		personalinformation.contact 		,	
		personalinformation.email 			,
		personalinformation.presentAddress 	,
		personalinformation.permanentAddress, 
		personalinformation.image 			
    )
    VALUES
    (
		FullName 		,
		FathersName 	,	
		MothersName 	,	
		DateOfBirth 	,	
		Gender 			,
		Contact 		,	
		Email 			,
		PresentAddress 	,
		PermanentAddress, 
		Image 			
    );
    
    INSERT INTO login
    (
		login.username,
        login.password,
        login.role,
        login.lastLoginDate,
        login.isActive
    )VALUES
    (
		StudentId		,
        Password 		,
        Role 			,
        LastLoginDate 	,
		IsActive 	
    );
    
    INSERT INTO students
    (
		students.student_id ,	
		students.program_id ,
        students.personalInformation_id,
        students.guardianName,
        students.guardianContact
    )
    VALUES 
    (
		StudentId 		,
        ProgramId 	,
        LAST_INSERT_ID(),
        GuardianName,
        GuardianContact
    );
COMMIT;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updateAcademicEvaluation` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updateAcademicEvaluation`(
	IN Id 	INT,
	IN CourseId 	INT,
    IN AssessmentId INT,
    IN SemesterId 	INT,
    IN Marks 		FLOAT,
    IN EntryById 	INT,
    IN EntryDate 	DATETIME
)
BEGIN
	UPDATE academicevaluation
    SET
        academicevaluation.course_id     = CourseId,
        academicevaluation.assessment_id = AssessmentId,
        academicevaluation.semester_id	 = SemesterId,
        academicevaluation.marks		 = Marks,
        academicevaluation.EntryBy_id	 = EntryById,
        academicevaluation.EntryDate	 = EntryDate	 
	WHERE 
    academicevaluation.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updateacademicevaluationttoclomapping` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updateacademicevaluationttoclomapping`(
	IN Id 					INT,
	IN AcademicEvaluationId INT,
    IN CLOId 				INT,
    IN Points 				FLOAT,
    IN EntryById 			INT,
    IN EntryDate 			DATETIME
)
BEGIN

	UPDATE academicevaluationttoclomapping
    SET
		academicevaluationttoclomapping.academicevaluation_id 	= AcademicEvaluationId,
        academicevaluationttoclomapping.clo_id 					= CLOId,
        academicevaluationttoclomapping.points 					= Points,
        academicevaluationttoclomapping.EntryBy_id 				= EntryById,
        academicevaluationttoclomapping.EntryDate 				= EntryDate
	WHERE 
    academicevaluationttoclomapping.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updateAcademicGrading` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updateAcademicGrading`(
	IN id 					INT,
    IN GradingSystemId 	VARCHAR(45),
    IN GradeName 			VARCHAR(10),
    IN PercentageFrom		FLOAT,
    IN PercentageTo			FLOAT,
    IN Gpa					FLOAT,
    IN EntryBy_id			INT 
)
BEGIN
	UPDATE academicgrading 
    SET 
    academicgrading.gradingSystem_id	= GradingSystemId,
    academicgrading.gradeName 			= GradeName,
    academicgrading.percentageFrom		= PercentageFrom,
    academicgrading.percentageTo		= PercentageTo,
    academicgrading.gpa					= Gpa,
    academicgrading.EntryBy_id			= EntryBy_id
    WHERE academicgrading.id = id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updateAssessment` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updateAssessment`(
	IN Id INT,
    IN Name VARCHAR(100),
    IN Type VARCHAR(100),
    IN EntryById INT,
    IN EntryDate DATETIME
)
BEGIN
    UPDATE  assessments
    SET	
        assessments.name = Name,
        assessments.type = Type ,
        assessments.EntryBy_id = EntryById,
        assessments.EntryDate = EntryDate
    WHERE 
    assessments.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updateCLO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updateCLO`(
	IN Id INT,
	IN Name VARCHAR(100),
    IN CourseId INT,
    IN Descriptions VARCHAR(1000)
)
BEGIN
	UPDATE clo
    SET
		clo.course_id = CourseId,
        clo.name = Name,
        clo.descriptions = Descriptions
    WHERE 
    clo.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updateCLOToPLOMapping` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updateCLOToPLOMapping`(
	IN Id INT,
	IN CLOId INT,
    IN PLOId INT,
    IN Points FLOAT
)
BEGIN
	UPDATE clotoplomapping
    SET
    clotoplomapping.clo_id = CLOId,
    clotoplomapping.plo_id = PLOId,
    clotoplomapping.points = Points
    WHERE 
    clotoplomapping.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updateDepartments` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updateDepartments`(
	IN Id 			INT,
	IN Name 		VARCHAR(60),
    IN Descriptions VARCHAR(200)
)
BEGIN
	UPDATE departments
    SET
    departments.Name		 = Name, 		
    departments.Descriptions = Descriptions
    WHERE 
    departments.Id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updateGradingSystem` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updateGradingSystem`(
	IN Id 				INT,
	IN SystemName 		VARCHAR(45),
    IN EntryDate 		DATETIME,
    IN EntryById 		INT
)
BEGIN
	UPDATE gradingsystem
    SET
    gradingsystem.systemName 		= SystemName,
    gradingsystem.EntryBy_id 		= EntryById,
    gradingsystem.EntryDate	= EntryDate
    
    WHERE gradingsystem.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updateLogin` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updateLogin`(	
	IN Username VARCHAR(13),
    IN Password VARCHAR(200),
    IN Role VARCHAR(50),
    IN IsActive INT,
    IN LastLoginDate DATETIME
)
BEGIN
	UPDATE login 
    SET 
    login.username 		= Username,
    Login.password 		= Password,
    login.role 			= Role,
    login.isActive 		= IsActive,
    login.lastLoginDate = LastLoginDate
    WHERE 
    login.Username = Username;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updateMission` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updateMission`(
	IN Id INT,
    IN Name VARCHAR(100),
    IN Description VARCHAR(1000)
)
BEGIN
	UPDATE missions 
    SET
    missions.name = Name,
    missions.descriptions = Description
    WHERE 
    missions.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updateMissionToPEOMapping` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updateMissionToPEOMapping`(
	IN Id INT,
	IN MissionId INT,
    IN PEOId INT,
    IN Points FLOAT
)
BEGIN
	UPDATE MissionToPEOMapping 
    SET 
		MissionToPEOMapping.mission_id = MissionId,
        MissionToPEOMapping.peo_id = PEOId,
        MissionToPEOMapping.points = Points
	WHERE 
    MissionToPEOMapping.Id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updatePEO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updatePEO`(
	IN Id INT,
	IN ProgramId INT,
    IN Name VARCHAR(100),
    IN Description VARCHAR(1000)
)
BEGIN
	UPDATE peo
    SET
		peo.program_id 		= ProgramId,
        peo.name 			= Name ,
        peo.descriptions 	= Description
    WHERE 
    peo.id = Id ;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updatePLO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updatePLO`(
	IN Id INT,
	IN ProgramId INT,
    IN Name VARCHAR(100),
    IN Description VARCHAR(1000)
)
BEGIN
	UPDATE plo
    SET
		plo.program_id 		= ProgramId,
        plo.name 			= Name ,
        plo.descriptions 	= Description
    WHERE 
    plo.id = Id ;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updatePLOToPEOMapping` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updatePLOToPEOMapping`(
	IN Id INT,
    IN PLOId INT,
    IN PEOId INT,
    IN Points FLOAT
)
BEGIN
	UPDATE plotopeomapping
    SET
		PLOToPEOMapping.plo_id = PLOId,
        PLOToPEOMapping.peo_id = PEOId,
        PLOToPEOMapping.points = Points
	WHERE 
    PLOToPEOMapping.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_updatePrograms` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_updatePrograms`(
	IN Id 			INT,
	IN Name 		VARCHAR(60),
    IN CreditHour 	FLOAT,
    IN Durations 	VARCHAR(10),
    IN DepartmentId INT
)
BEGIN
	UPDATE programs
    SET 
		programs.name = Name,
        programs.creditHour = CreditHour,
        programs.durations = Durations,
        programs.department_id = DepartmentId
	WHERE programs.id = Id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `vw_allacademicevaluation`
--

/*!50001 DROP VIEW IF EXISTS `vw_allacademicevaluation`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allacademicevaluation` AS select `academicevaluation`.`id` AS `id`,`academicevaluation`.`course_id` AS `course_id`,`academicevaluation`.`semester_id` AS `semester_id`,`academicevaluation`.`assessment_id` AS `assessment_id`,`academicevaluation`.`marks` AS `marks`,`academicevaluation`.`EntryBy_Id` AS `EntryBy_Id`,`academicevaluation`.`EntryDate` AS `EntryDate` from `academicevaluation` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_allacademicevaluationttoclomapping`
--

/*!50001 DROP VIEW IF EXISTS `vw_allacademicevaluationttoclomapping`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allacademicevaluationttoclomapping` AS select `academicevaluationttoclomapping`.`id` AS `id`,`academicevaluationttoclomapping`.`academicevaluation_id` AS `academicevaluation_id`,`academicevaluationttoclomapping`.`clo_id` AS `clo_id`,`academicevaluationttoclomapping`.`points` AS `points`,`academicevaluationttoclomapping`.`EntryBy_id` AS `EntryBy_id`,`academicevaluationttoclomapping`.`EntryDate` AS `EntryDate` from `academicevaluationttoclomapping` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_allassessment`
--

/*!50001 DROP VIEW IF EXISTS `vw_allassessment`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allassessment` AS select `assessments`.`Id` AS `Id`,`assessments`.`Name` AS `Name`,`assessments`.`type` AS `type`,`assessments`.`EntryBy_id` AS `EntryBy_id`,`assessments`.`EntryDate` AS `EntryDate` from `assessments` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_allassessments`
--

/*!50001 DROP VIEW IF EXISTS `vw_allassessments`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allassessments` AS select `assessments`.`Id` AS `Id`,`assessments`.`Name` AS `Name`,`assessments`.`type` AS `type`,`assessments`.`EntryBy_id` AS `EntryBy_id`,`assessments`.`EntryDate` AS `EntryDate` from `assessments` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_allclos`
--

/*!50001 DROP VIEW IF EXISTS `vw_allclos`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allclos` AS select `clo`.`id` AS `id`,`clo`.`course_id` AS `course_id`,`clo`.`Name` AS `Name`,`clo`.`Descriptions` AS `Descriptions` from `clo` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_allclotoplomapping`
--

/*!50001 DROP VIEW IF EXISTS `vw_allclotoplomapping`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allclotoplomapping` AS select `clotoplomapping`.`id` AS `id`,`clotoplomapping`.`clo_id` AS `clo_id`,`clotoplomapping`.`plo_id` AS `plo_id`,`clotoplomapping`.`points` AS `points` from `clotoplomapping` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_allcourses`
--

/*!50001 DROP VIEW IF EXISTS `vw_allcourses`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allcourses` AS select `courses`.`id` AS `id`,`courses`.`name` AS `name`,`courses`.`code` AS `code`,`courses`.`credit` AS `credit`,`courses`.`descriptions` AS `descriptions` from `courses` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_alldepartments`
--

/*!50001 DROP VIEW IF EXISTS `vw_alldepartments`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_alldepartments` AS select `departments`.`id` AS `id`,`departments`.`name` AS `name`,`departments`.`descriptions` AS `descriptions` from `departments` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_allgradingsystem`
--

/*!50001 DROP VIEW IF EXISTS `vw_allgradingsystem`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allgradingsystem` AS select `gradingsystem`.`id` AS `id`,`gradingsystem`.`systemName` AS `systemName`,`gradingsystem`.`EntryBy_id` AS `EntryBy_id`,`gradingsystem`.`EntryDate` AS `EntryDate` from `gradingsystem` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_alllogin`
--

/*!50001 DROP VIEW IF EXISTS `vw_alllogin`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_alllogin` AS select `login`.`username` AS `username`,`login`.`password` AS `password`,`login`.`role` AS `role`,`login`.`isActive` AS `isActive`,`login`.`lastLoginDate` AS `lastLoginDate` from `login` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_allmission`
--

/*!50001 DROP VIEW IF EXISTS `vw_allmission`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allmission` AS select `missions`.`id` AS `id`,`missions`.`name` AS `name`,`missions`.`descriptions` AS `descriptions` from `missions` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_allmissiontopeomapping`
--

/*!50001 DROP VIEW IF EXISTS `vw_allmissiontopeomapping`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allmissiontopeomapping` AS select `missiontopeomapping`.`id` AS `id`,`missiontopeomapping`.`mission_id` AS `mission_id`,`missiontopeomapping`.`peo_id` AS `peo_id`,`missiontopeomapping`.`points` AS `points` from `missiontopeomapping` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_allpeo`
--

/*!50001 DROP VIEW IF EXISTS `vw_allpeo`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allpeo` AS select `peo`.`id` AS `id`,`peo`.`program_id` AS `program_id`,`peo`.`name` AS `name`,`peo`.`descriptions` AS `descriptions` from `peo` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_allplo`
--

/*!50001 DROP VIEW IF EXISTS `vw_allplo`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allplo` AS select `plo`.`id` AS `id`,`plo`.`program_id` AS `program_id`,`plo`.`name` AS `name`,`plo`.`Descriptions` AS `Descriptions` from `plo` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_allplotopeomapping`
--

/*!50001 DROP VIEW IF EXISTS `vw_allplotopeomapping`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allplotopeomapping` AS select `plotopeomapping`.`id` AS `id`,`plotopeomapping`.`plo_id` AS `plo_id`,`plotopeomapping`.`peo_id` AS `peo_id`,`plotopeomapping`.`points` AS `points` from `plotopeomapping` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_allprograms`
--

/*!50001 DROP VIEW IF EXISTS `vw_allprograms`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allprograms` AS select `programs`.`id` AS `id`,`programs`.`name` AS `name`,`programs`.`creditHour` AS `creditHour`,`programs`.`duration` AS `duration`,`programs`.`department_id` AS `department_id` from `programs` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_allregistrationinformation`
--

/*!50001 DROP VIEW IF EXISTS `vw_allregistrationinformation`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allregistrationinformation` AS select `courseregistration`.`id` AS `id`,`courseregistration`.`registrationinformation_id` AS `registrationinformation_id`,`courseregistration`.`student_id` AS `student_id`,`courseregistration`.`registertime` AS `registertime`,`registrationinformation`.`id` AS `registrationinformationId`,`registrationinformation`.`semester_id` AS `semester_id`,`registrationinformation`.`course_id` AS `course_id`,`registrationinformation`.`faculty_id` AS `faculty_id`,`registrationinformation`.`Classday` AS `ClassDay`,`registrationinformation`.`classTimeStart` AS `classTimeStart`,`registrationinformation`.`classTimeEnd` AS `classTimeEnd`,`registrationinformation`.`roomnumber` AS `roomnumber`,`registrationinformation`.`seatLimit` AS `seatLimit` from (`courseregistration` join `registrationinformation`) where (`courseregistration`.`registrationinformation_id` = `registrationinformation`.`id`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_allstaffs`
--

/*!50001 DROP VIEW IF EXISTS `vw_allstaffs`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allstaffs` AS select `staffs`.`id` AS `id`,`staffs`.`staff_id` AS `staff_id`,`staffs`.`department_id` AS `department_id`,`personalinformation`.`fullName` AS `fullName`,`personalinformation`.`fathersName` AS `fathersName`,`personalinformation`.`mothersName` AS `mothersName`,`personalinformation`.`dateOfBirth` AS `dateOfBirth`,`personalinformation`.`gender` AS `gender`,`personalinformation`.`contact` AS `contact`,`personalinformation`.`email` AS `email`,`personalinformation`.`presentAddress` AS `presentAddress`,`personalinformation`.`permanentAddress` AS `permanentAddress`,`personalinformation`.`image` AS `image`,`login`.`username` AS `username` from ((`staffs` join `personalinformation`) join `login`) where ((`staffs`.`personalInformation_id` = `personalinformation`.`id`) and (`staffs`.`staff_id` = `login`.`username`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vw_allstudents`
--

/*!50001 DROP VIEW IF EXISTS `vw_allstudents`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_allstudents` AS select `students`.`id` AS `id`,`students`.`student_id` AS `student_id`,`students`.`program_id` AS `program_id`,`students`.`guardianName` AS `guardianName`,`students`.`guardianContact` AS `guardianContact`,`personalinformation`.`fullName` AS `fullName`,`personalinformation`.`fathersName` AS `fathersName`,`personalinformation`.`mothersName` AS `mothersName`,`personalinformation`.`dateOfBirth` AS `dateOfBirth`,`personalinformation`.`gender` AS `gender`,`personalinformation`.`contact` AS `contact`,`personalinformation`.`email` AS `email`,`personalinformation`.`presentAddress` AS `presentAddress`,`personalinformation`.`permanentAddress` AS `permanentAddress`,`personalinformation`.`image` AS `image`,`login`.`username` AS `username` from ((`students` join `personalinformation`) join `login`) where ((`students`.`personalinformation_id` = `personalinformation`.`id`) and (`students`.`student_id` = `login`.`username`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-06-29 18:27:12
