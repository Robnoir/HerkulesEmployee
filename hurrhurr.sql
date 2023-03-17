CREATE DATABASE  IF NOT EXISTS `herkules` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `herkules`;
-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: herkules
-- ------------------------------------------------------
-- Server version	8.0.31

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
-- Table structure for table `herkules`
--

DROP TABLE IF EXISTS `herkules`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `herkules` (
  `herkules_id` int NOT NULL AUTO_INCREMENT,
  `herkules_user` varchar(45) DEFAULT NULL,
  `herkules_password` int DEFAULT NULL,
  `herkules_hour` int DEFAULT NULL,
  `herkules_pay` int DEFAULT NULL,
  `herkules_create` datetime DEFAULT CURRENT_TIMESTAMP,
  `herkules_update` datetime DEFAULT NULL ON UPDATE CURRENT_TIMESTAMP,
  `herkules_title` varchar(45) DEFAULT NULL,
  `herkules_status` varchar(45) DEFAULT NULL,
  `herkules_vacation` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`herkules_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `herkules`
--

LOCK TABLES `herkules` WRITE;
/*!40000 ALTER TABLE `herkules` DISABLE KEYS */;
INSERT INTO `herkules` VALUES (2,'Abdulle@protonmail.com',123,5,1000,'2023-03-15 16:57:43','2023-03-16 21:34:48','GigaDeveloper','Active','1'),(3,'Kamphol@gmail.com',123,4,800,'2023-03-15 17:14:09','2023-03-16 21:12:19','Software Engineer','Active','0.8'),(4,'Babu420@facebook.com',123,2,400,'2023-03-15 19:44:04','2023-03-16 21:34:12','Babushka','Inactive','0.4');
/*!40000 ALTER TABLE `herkules` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-16 22:10:33
