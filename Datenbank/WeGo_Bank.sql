-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: mydb
-- ------------------------------------------------------
-- Server version	8.0.37

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
-- Table structure for table `essen`
--

DROP TABLE IF EXISTS `essen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `essen` (
  `idEssen` int NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Calories` varchar(45) DEFAULT NULL,
  `Kunde_idKunde` int NOT NULL,
  PRIMARY KEY (`idEssen`),
  KEY `fk_Essen_Kunde_idx` (`Kunde_idKunde`),
  CONSTRAINT `fk_Essen_Kunde` FOREIGN KEY (`Kunde_idKunde`) REFERENCES `kunde` (`idKunde`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `essen`
--

LOCK TABLES `essen` WRITE;
/*!40000 ALTER TABLE `essen` DISABLE KEYS */;
/*!40000 ALTER TABLE `essen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `events`
--

DROP TABLE IF EXISTS `events`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `events` (
  `idEvents` int NOT NULL,
  `Event_Name` varchar(45) DEFAULT NULL,
  `Datum` varchar(45) DEFAULT NULL,
  `Uhrzeit` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idEvents`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `events`
--

LOCK TABLES `events` WRITE;
/*!40000 ALTER TABLE `events` DISABLE KEYS */;
INSERT INTO `events` VALUES (1942231588,'Boxing Tournament','18.7.2024','12:45'),(1970518228,'Yoga ','3.8.2024','13:40');
/*!40000 ALTER TABLE `events` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kunde`
--

DROP TABLE IF EXISTS `kunde`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kunde` (
  `idKunde` int NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `TeleNummer` varchar(45) DEFAULT NULL,
  `Password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idKunde`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kunde`
--

LOCK TABLES `kunde` WRITE;
/*!40000 ALTER TABLE `kunde` DISABLE KEYS */;
INSERT INTO `kunde` VALUES (0,'Rashad Mardini','rashadmardini@gmail.com','015732203834','123456789wego'),(158087513,'Olaf Scholtz','Olaf.de@gmail.de','015732486248','123456789döner'),(247197328,'Zia Ul-Mustafa','ziaulmustafa2013@gmail.com','015213649574','123456789hund');
/*!40000 ALTER TABLE `kunde` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kunde angemeldet`
--

DROP TABLE IF EXISTS `kunde angemeldet`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kunde angemeldet` (
  `Kunde_idKunde` int NOT NULL,
  `Kurse_idKurse` int NOT NULL,
  PRIMARY KEY (`Kunde_idKunde`,`Kurse_idKurse`),
  KEY `fk_Kunde_has_Kurse_Kurse1_idx` (`Kurse_idKurse`),
  KEY `fk_Kunde_has_Kurse_Kunde1_idx` (`Kunde_idKunde`),
  CONSTRAINT `fk_Kunde_has_Kurse_Kunde1` FOREIGN KEY (`Kunde_idKunde`) REFERENCES `kunde` (`idKunde`),
  CONSTRAINT `fk_Kunde_has_Kurse_Kurse1` FOREIGN KEY (`Kurse_idKurse`) REFERENCES `kurse` (`idKurse`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kunde angemeldet`
--

LOCK TABLES `kunde angemeldet` WRITE;
/*!40000 ALTER TABLE `kunde angemeldet` DISABLE KEYS */;
/*!40000 ALTER TABLE `kunde angemeldet` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kunde nimmt teil`
--

DROP TABLE IF EXISTS `kunde nimmt teil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kunde nimmt teil` (
  `Kunde_idKunde` int NOT NULL,
  `Events_idEvents` int NOT NULL,
  PRIMARY KEY (`Kunde_idKunde`,`Events_idEvents`),
  KEY `fk_Kunde_has_Events_Events1_idx` (`Events_idEvents`),
  KEY `fk_Kunde_has_Events_Kunde1_idx` (`Kunde_idKunde`),
  CONSTRAINT `fk_Kunde_has_Events_Events1` FOREIGN KEY (`Events_idEvents`) REFERENCES `events` (`idEvents`),
  CONSTRAINT `fk_Kunde_has_Events_Kunde1` FOREIGN KEY (`Kunde_idKunde`) REFERENCES `kunde` (`idKunde`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kunde nimmt teil`
--

LOCK TABLES `kunde nimmt teil` WRITE;
/*!40000 ALTER TABLE `kunde nimmt teil` DISABLE KEYS */;
/*!40000 ALTER TABLE `kunde nimmt teil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kurse`
--

DROP TABLE IF EXISTS `kurse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kurse` (
  `idKurse` int NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idKurse`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kurse`
--

LOCK TABLES `kurse` WRITE;
/*!40000 ALTER TABLE `kurse` DISABLE KEYS */;
/*!40000 ALTER TABLE `kurse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `messages`
--

DROP TABLE IF EXISTS `messages`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `messages` (
  `idMessages` int NOT NULL,
  `Inhalt` varchar(45) DEFAULT NULL,
  `Kunde_idKunde` int NOT NULL,
  PRIMARY KEY (`idMessages`,`Kunde_idKunde`),
  KEY `fk_Messages_Kunde1_idx` (`Kunde_idKunde`),
  CONSTRAINT `fk_Messages_Kunde1` FOREIGN KEY (`Kunde_idKunde`) REFERENCES `kunde` (`idKunde`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `messages`
--

LOCK TABLES `messages` WRITE;
/*!40000 ALTER TABLE `messages` DISABLE KEYS */;
/*!40000 ALTER TABLE `messages` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workout`
--

DROP TABLE IF EXISTS `workout`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `workout` (
  `idWorkout` int NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Kunde_idKunde` int NOT NULL,
  PRIMARY KEY (`idWorkout`),
  KEY `fk_Workout_Kunde1_idx` (`Kunde_idKunde`),
  CONSTRAINT `fk_Workout_Kunde1` FOREIGN KEY (`Kunde_idKunde`) REFERENCES `kunde` (`idKunde`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workout`
--

LOCK TABLES `workout` WRITE;
/*!40000 ALTER TABLE `workout` DISABLE KEYS */;
/*!40000 ALTER TABLE `workout` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-07-18  7:07:14
