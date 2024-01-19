CREATE DATABASE  IF NOT EXISTS `agenciaviagemapics` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `agenciaviagemapics`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: agenciaviagemapics
-- ------------------------------------------------------
-- Server version	8.0.34

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
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20240118160243_inicial','6.0.26'),('20240118162425_segunda','6.0.26'),('20240118165932_terceiro','6.0.26'),('20240118174749_quarto','6.0.26'),('20240118183811_quinto','6.0.26'),('20240119154915_sextou','6.0.26');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `destino`
--

DROP TABLE IF EXISTS `destino`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `destino` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `cidade` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `estado` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `localDestino` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `valor` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `destino`
--

LOCK TABLES `destino` WRITE;
/*!40000 ALTER TABLE `destino` DISABLE KEYS */;
INSERT INTO `destino` VALUES (2,'Planaltina-go','GO','Rodoviária',240.50),(3,'Imperatriz','MA','Aeroporto',115.00),(4,'Cidade Ocidental','GO','Aeroporto ',115.00),(5,'Goiânia','GO','Terminal da Biblia',450.50);
/*!40000 ALTER TABLE `destino` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hospedagem`
--

DROP TABLE IF EXISTS `hospedagem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hospedagem` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `cidade` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `estado` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `endereco` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `tipo` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `telefone` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `valorDiaria` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hospedagem`
--

LOCK TABLES `hospedagem` WRITE;
/*!40000 ALTER TABLE `hospedagem` DISABLE KEYS */;
INSERT INTO `hospedagem` VALUES (1,'Hotel Queiroz','Nova Roma','GO',' q 13 casa 21','Hotel','61992090318',500.40),(2,'Hotel Pousada','Planaltina-go','GO',' q 13 casa 21','Hotel','61992090318',153.00);
/*!40000 ALTER TABLE `hospedagem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `passagem`
--

DROP TABLE IF EXISTS `passagem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `passagem` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `pacotePromo` int NOT NULL,
  `dataViagem` datetime(6) NOT NULL,
  `valorTotal` decimal(10,2) NOT NULL,
  `usuario_id_fk` bigint NOT NULL,
  `destino_id_fk` bigint NOT NULL,
  PRIMARY KEY (`id`),
  KEY `IX_Passagem_destino_id_fk` (`destino_id_fk`),
  KEY `IX_Passagem_usuario_id_fk` (`usuario_id_fk`),
  CONSTRAINT `FK_Passagem_Destino_destino_id_fk` FOREIGN KEY (`destino_id_fk`) REFERENCES `destino` (`id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Passagem_Usuario_usuario_id_fk` FOREIGN KEY (`usuario_id_fk`) REFERENCES `usuario` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `passagem`
--

LOCK TABLES `passagem` WRITE;
/*!40000 ALTER TABLE `passagem` DISABLE KEYS */;
INSERT INTO `passagem` VALUES (1,1,'2023-12-31 00:00:00.000000',1202.50,2,2),(4,1,'2024-12-14 00:00:00.000000',901.00,2,5),(5,1,'2024-12-14 00:00:00.000000',901.00,2,5),(6,1,'2020-12-15 00:00:00.000000',115.00,2,4),(7,2,'2024-12-15 00:00:00.000000',2252.50,7,5),(8,3,'2029-12-15 00:00:00.000000',1351.50,8,5),(9,1,'2030-12-15 00:00:00.000000',115.00,6,4),(10,3,'2050-12-14 00:00:00.000000',460.00,7,3),(11,3,'1990-12-14 00:00:00.000000',1683.50,2,2),(12,2,'2030-12-15 00:00:00.000000',1924.00,6,2),(13,2,'2030-12-15 00:00:00.000000',690.00,7,3),(14,1,'2024-01-13 00:00:00.000000',240.50,7,2),(15,1,'2024-01-13 00:00:00.000000',240.50,7,2),(16,1,'2024-01-13 00:00:00.000000',240.50,7,2),(17,1,'2024-01-13 00:00:00.000000',240.50,7,2),(18,1,'2024-01-13 00:00:00.000000',240.50,7,2),(19,1,'2024-01-13 00:00:00.000000',240.50,7,2),(20,1,'2024-01-13 00:00:00.000000',240.50,7,2),(21,1,'2024-01-13 00:00:00.000000',240.50,7,2),(22,1,'2024-01-13 00:00:00.000000',240.50,7,2),(23,1,'2020-02-16 00:00:00.000000',240.50,7,2),(24,1,'2020-02-16 00:00:00.000000',240.50,7,2),(25,1,'2020-02-16 00:00:00.000000',240.50,7,2),(26,1,'2024-01-24 00:00:00.000000',230.00,7,3),(27,1,'2024-01-24 00:00:00.000000',230.00,7,3),(28,1,'2024-01-10 00:00:00.000000',481.00,6,2),(29,1,'2024-02-02 00:00:00.000000',481.00,7,2),(30,1,'2024-01-12 00:00:00.000000',-240.50,6,2),(31,1,'2200-12-15 00:00:00.000000',481.00,6,2),(32,1,'2204-12-15 00:00:00.000000',240.50,6,2),(33,1,'1990-12-14 00:00:00.000000',481.00,2,2),(34,1,'2024-01-20 00:00:00.000000',962.00,7,2);
/*!40000 ALTER TABLE `passagem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reserva`
--

DROP TABLE IF EXISTS `reserva`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reserva` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `qtdDias` int NOT NULL,
  `dataReserva` datetime(6) NOT NULL,
  `pacotePromo` int NOT NULL,
  `valorTotal` decimal(10,2) NOT NULL,
  `usuario_id_fk` bigint NOT NULL,
  `hospedagem_id_fk` bigint NOT NULL,
  PRIMARY KEY (`id`),
  KEY `IX_Reserva_hospedagem_id_fk` (`hospedagem_id_fk`),
  KEY `IX_Reserva_usuario_id_fk` (`usuario_id_fk`),
  CONSTRAINT `FK_Reserva_Hospedagem_hospedagem_id_fk` FOREIGN KEY (`hospedagem_id_fk`) REFERENCES `hospedagem` (`id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Reserva_Usuario_usuario_id_fk` FOREIGN KEY (`usuario_id_fk`) REFERENCES `usuario` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reserva`
--

LOCK TABLES `reserva` WRITE;
/*!40000 ALTER TABLE `reserva` DISABLE KEYS */;
INSERT INTO `reserva` VALUES (1,3,'1990-12-14 00:00:00.000000',3,459.00,2,2);
/*!40000 ALTER TABLE `reserva` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `cpf` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `data_nascimento` datetime(6) NOT NULL,
  `email` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `telefone` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `endereco` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `estado` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `cidade` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (2,'waschington','04244310177','1990-12-14 00:00:00.000000','chitonbispo@gmail.com','61992090318',' q 13 casa 21','GO','Cidade Ocidental'),(6,'Cauã Dominck Dantas dos Reis','15315348999','2014-05-28 00:00:00.000000','cauareis@gmail.com','61998546413','Quadra 137 casa 19c','GO','Planaltina-go'),(7,'Thaise Miguel','03945441102','1993-04-15 00:00:00.000000','thaisemiguel@recomecar.org','+5561991434692',' q 13 casa 21','GO','Cidade Ocidental'),(8,'Sebastiana Batista dos reis','00000000000','1970-07-10 00:00:00.000000','chitonbispocaua@gmail.com','61992090318','Quadra 137 casa 19c','GO','CIDADE OCIDENTAL'),(9,'Waschington Rodrigo','03945441122','2020-04-16 00:00:00.000000','chitonbispocaua@gmail.com','61992090318',' q 13 casa 21','GO','Cidade Ocidental');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-19 14:38:30
