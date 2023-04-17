CREATE DATABASE  IF NOT EXISTS `inventory_db` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `inventory_db`;
-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: localhost    Database: inventory_db
-- ------------------------------------------------------
-- Server version	8.0.25

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
-- Table structure for table `tbl_actlog`
--

DROP TABLE IF EXISTS `tbl_actlog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_actlog` (
  `username` varchar(80) NOT NULL,
  `usertype` varchar(80) NOT NULL,
  `activity` varchar(80) NOT NULL,
  `datetime` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_actlog`
--

LOCK TABLES `tbl_actlog` WRITE;
/*!40000 ALTER TABLE `tbl_actlog` DISABLE KEYS */;
INSERT INTO `tbl_actlog` VALUES ('Name','Sam','Logged-in','2023-04-16 2:41 PM'),('Name','Sam','Logged-in','2023-04-16 2:43 PM'),('Name','Sam','Logged-in','2023-04-17 5:30 PM'),('Name','Sam','Logged-in','2023-04-17 5:36 PM'),('Name','Sam','Logged-in','2023-04-17 5:50 PM'),('Name','Sam','Logged-in','2023-04-17 5:51 PM'),('Name','Sam','Logged-in','2023-04-17 5:53 PM'),('Name','Sam','Logged-in','2023-04-17 5:54 PM'),('Name','Sam','Logged-in','2023-04-17 5:56 PM'),('Name','Sam','Logged-in','2023-04-17 5:56 PM'),('Name','Sam','Logged-in','2023-04-17 5:58 PM'),('Name','Sam','Logged-in','2023-04-17 5:59 PM'),('Admin','Sam','Added new supplier. Company Name: adada','2023-04-17 6:00 PM'),('Admin','Sam','Added new supplier. Company Name: adada','2023-04-17 6:00 PM'),('Name','Sam','Logged-in','2023-04-17 6:03 PM'),('Name','Sam','Logged-in','2023-04-17 6:07 PM'),('Name','Sam','Logged-in','2023-04-17 6:11 PM'),('Name','Sam','Logged-in','2023-04-17 6:14 PM'),('Name','Sam','Logged-in','2023-04-17 6:16 PM'),('Name','Sam','Logged-in','2023-04-17 6:22 PM'),('Name','Sam','Logged-in','2023-04-17 6:31 PM'),('Name','Sam','Logged-in','2023-04-17 6:32 PM'),('Name','Sam','Logged-in','2023-04-17 6:37 PM'),('Name','Sam','Logged-in','2023-04-17 6:39 PM'),('USERTYPE','Sam','Logged-in','2023-04-17 6:41 PM'),('USERTYPE','Sam','Logged-in','2023-04-17 6:45 PM'),('USERTYPE','Sam','Logged-in','2023-04-17 6:48 PM'),('USERTYPE','Sam','Logged-in','2023-04-17 6:51 PM'),('USERTYPE','Sam','Logged-in','2023-04-17 6:53 PM'),('Admin','Sam','Save purchase order. Order No:213213132132','2023-04-17 6:55 PM'),('Sam','USERTYPE','Logged-in','2023-04-17 7:02 PM'),('Sam','usertype','Logged-in','2023-04-17 7:03 PM'),('Sam','Admin','Logged-in','2023-04-17 7:06 PM'),('Sam','Admin','Logged-in','2023-04-17 7:15 PM'),('Sam','Admin','Logged-in','2023-04-17 7:19 PM'),('Sam','Admin','Logged-in','2023-04-17 7:23 PM'),('Sam','Admin','Logged-in','2023-04-17 7:27 PM'),('Sam','Admin','Logged-in','2023-04-17 7:46 PM'),('Sam','Admin','Logged-in','2023-04-17 7:59 PM'),('Sam','Admin','Logged-in','2023-04-17 8:05 PM'),('Sam','Admin','Logged-in','2023-04-17 8:06 PM'),('Sam','Admin','Logged-in','2023-04-17 8:08 PM'),('Sam','Admin','Logged-in','2023-04-17 8:10 PM'),('Som','Cashier','Logged-in','2023-04-17 8:14 PM'),('Sam','Admin','Logged-in','2023-04-17 8:15 PM'),('Sam','Admin','Logged-in','2023-04-17 8:18 PM'),('Sam','Admin','Save purchase order. Order No:32333','2023-04-17 8:20 PM'),('Sam','Admin','Logged-in','2023-04-17 8:26 PM'),('Sam','Admin','Logged-in','2023-04-17 8:27 PM'),('Sam','Admin','Logged-in','2023-04-17 8:28 PM'),('Som','Cashier','Logged-in','2023-04-17 8:28 PM'),('Sam','Admin','Logged-in','2023-04-17 8:35 PM'),('Sam','Admin','Logged-in','2023-04-17 8:53 PM'),('Sam','Admin','Logged-in','2023-04-17 8:59 PM');
/*!40000 ALTER TABLE `tbl_actlog` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_cart`
--

DROP TABLE IF EXISTS `tbl_cart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cart` (
  `prodid` varchar(45) NOT NULL,
  `prodname` varchar(45) NOT NULL,
  `prodbrand` varchar(45) NOT NULL,
  `prodcat` varchar(45) NOT NULL,
  `catcode` varchar(45) NOT NULL,
  `price` int NOT NULL,
  `unit` varchar(45) NOT NULL,
  `quantity` int NOT NULL,
  `transdate` varchar(45) NOT NULL,
  `returndate` date DEFAULT NULL,
  PRIMARY KEY (`prodid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cart`
--

LOCK TABLES `tbl_cart` WRITE;
/*!40000 ALTER TABLE `tbl_cart` DISABLE KEYS */;
INSERT INTO `tbl_cart` VALUES ('3456','DED','DED','CAPSULE','091020290',20,'200 liter/s',1,'2023-40-17',NULL),('44444','LLL','LLL','CAPSULE','091020290',20,'200 miligram/s',1,'2023-45-17',NULL);
/*!40000 ALTER TABLE `tbl_cart` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_category`
--

DROP TABLE IF EXISTS `tbl_category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_category` (
  `ID` int NOT NULL,
  `catcode` varchar(45) NOT NULL,
  `catname` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_category`
--

LOCK TABLES `tbl_category` WRITE;
/*!40000 ALTER TABLE `tbl_category` DISABLE KEYS */;
INSERT INTO `tbl_category` VALUES (1,'091020290','CAPSULE');
/*!40000 ALTER TABLE `tbl_category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_expiredprod`
--

DROP TABLE IF EXISTS `tbl_expiredprod`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_expiredprod` (
  `stockid` int NOT NULL,
  `prodid` varchar(45) NOT NULL,
  `prodname` varchar(45) NOT NULL,
  `prodman` varchar(45) NOT NULL,
  `prodbrand` varchar(45) NOT NULL,
  `prodcat` varchar(45) NOT NULL,
  `catcode` varchar(45) NOT NULL,
  `price` int NOT NULL,
  `unit` varchar(45) NOT NULL,
  `quantity` int NOT NULL,
  `expirationdate` varchar(45) NOT NULL,
  PRIMARY KEY (`stockid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_expiredprod`
--

LOCK TABLES `tbl_expiredprod` WRITE;
/*!40000 ALTER TABLE `tbl_expiredprod` DISABLE KEYS */;
INSERT INTO `tbl_expiredprod` VALUES (1,'000011\n','ALEVA TABLET','SAM','SAM','Tablet','AVEH0028',20,'250 miligram/s',91,'2/12/2023'),(2,'28973','SAMPROD','SAMMAN','SAMBRAND','SAMPLE1','SAMCODE1',100,'500 miligram/s',55,'3/29/2023'),(3,'1237','SAMCODENAME','SAMMAN','SAMCODEBRAND','SAMPLE1','SAMCODE3',100,'300 gram/s',24,'3/28/2023'),(4,'8762312','aaa','aaa','aaa','SAMPLE1','aaaa',100,'1000 Piece/s',31,'4/3/2023'),(6,'900','LAURENCE','SAMPLE','MIRALLES','SAMPLE1','0',3000,'200 gram/s',16,'4/8/2023');
/*!40000 ALTER TABLE `tbl_expiredprod` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_products`
--

DROP TABLE IF EXISTS `tbl_products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_products` (
  `stockid` int NOT NULL,
  `prodid` varchar(45) NOT NULL,
  `prodname` varchar(45) DEFAULT NULL,
  `prodman` varchar(45) DEFAULT NULL,
  `prodbrand` varchar(45) DEFAULT NULL,
  `prodcat` varchar(45) DEFAULT NULL,
  `catcode` varchar(45) NOT NULL,
  `price` int DEFAULT NULL,
  `unit` varchar(45) DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `expirationdate` date DEFAULT NULL,
  `dateadddedprod` date DEFAULT NULL,
  `dateaddedstocks` date DEFAULT NULL,
  PRIMARY KEY (`prodid`,`catcode`,`stockid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_products`
--

LOCK TABLES `tbl_products` WRITE;
/*!40000 ALTER TABLE `tbl_products` DISABLE KEYS */;
INSERT INTO `tbl_products` VALUES (5,'21','amoxiciline','sample','uniliver','SAMPLE1','3121232',100,'300 miligram/s',87,'2023-04-25','2023-03-13','2023-04-09'),(7,'3456','DED','DED','DED','CAPSULE','091020290',20,'200 liter/s',5,'2023-04-17','2023-04-03','2023-04-03'),(8,'44444','LLL','LLL','LLL','CAPSULE','091020290',20,'200 miligram/s',69,'2023-04-12','2023-04-03','2023-04-09'),(9,'only','only','only','only','CAPSULE','091020290',NULL,NULL,NULL,NULL,'2023-04-06',NULL);
/*!40000 ALTER TABLE `tbl_products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_sales`
--

DROP TABLE IF EXISTS `tbl_sales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_sales` (
  `salesno` int NOT NULL AUTO_INCREMENT,
  `orderno` varchar(45) NOT NULL,
  `transadate` date NOT NULL,
  `discounttype` varchar(45) NOT NULL,
  `totalbill` int NOT NULL,
  `payment` int NOT NULL,
  `totalchange` int NOT NULL,
  PRIMARY KEY (`salesno`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_sales`
--

LOCK TABLES `tbl_sales` WRITE;
/*!40000 ALTER TABLE `tbl_sales` DISABLE KEYS */;
INSERT INTO `tbl_sales` VALUES (16,'2342432','2023-04-13','PWD',300,900,660),(17,'242424','2023-04-13','Senior Citizen',40,100,68),(18,'324343','2023-04-13','Senior Citizen',300,300,60),(19,'13213213213','2023-04-14','Senior Citizen',60,100,52),(20,'213213132132','2023-04-17','N/A',40,100,60),(21,'32333','2023-04-17','N/A',500,1000,500);
/*!40000 ALTER TABLE `tbl_sales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_stocksout`
--

DROP TABLE IF EXISTS `tbl_stocksout`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_stocksout` (
  `stockid` int NOT NULL,
  `prodid` varchar(45) NOT NULL,
  `prodname` varchar(45) NOT NULL,
  `prodman` varchar(45) NOT NULL,
  `prodbrand` varchar(45) NOT NULL,
  `prodcat` varchar(45) NOT NULL,
  `catcode` varchar(45) NOT NULL,
  `price` int NOT NULL,
  `unit` varchar(45) NOT NULL,
  `quantity` varchar(45) NOT NULL,
  `expirationdate` varchar(45) NOT NULL,
  PRIMARY KEY (`stockid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_stocksout`
--

LOCK TABLES `tbl_stocksout` WRITE;
/*!40000 ALTER TABLE `tbl_stocksout` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_stocksout` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_supplier`
--

DROP TABLE IF EXISTS `tbl_supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_supplier` (
  `RefNo` int NOT NULL AUTO_INCREMENT,
  `Companyname` varchar(45) NOT NULL,
  `FirstName` varchar(45) NOT NULL,
  `LastName` varchar(45) NOT NULL,
  `Email` varchar(45) NOT NULL,
  `PhoneNo` varchar(45) NOT NULL,
  `Address` varchar(45) NOT NULL,
  PRIMARY KEY (`RefNo`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_supplier`
--

LOCK TABLES `tbl_supplier` WRITE;
/*!40000 ALTER TABLE `tbl_supplier` DISABLE KEYS */;
INSERT INTO `tbl_supplier` VALUES (1,'sample','samm','sam','sam','234234324','samm'),(3,'sas,akdjijwtf','sadad','dadada','adadada','3534545','adsadasdsd'),(4,'adada','sdasdsad','dadasd','sdasdad','342424','adaw'),(5,'adada','sdasdsad','dadasd','sdasdad','342424','adaww');
/*!40000 ALTER TABLE `tbl_supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_transaction`
--

DROP TABLE IF EXISTS `tbl_transaction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_transaction` (
  `transid` int NOT NULL AUTO_INCREMENT,
  `orderno` varchar(45) DEFAULT NULL,
  `discounttype` varchar(45) DEFAULT NULL,
  `prodid` varchar(45) DEFAULT NULL,
  `prodname` varchar(45) DEFAULT NULL,
  `prodbrand` varchar(45) DEFAULT NULL,
  `catname` varchar(45) DEFAULT NULL,
  `catcode` varchar(45) DEFAULT NULL,
  `unit` varchar(45) DEFAULT NULL,
  `quantity` int DEFAULT NULL,
  `payment` int DEFAULT NULL,
  `totalbill` int DEFAULT NULL,
  `change` int DEFAULT NULL,
  `discountedamount` int DEFAULT NULL,
  `transdate` date DEFAULT NULL,
  `returndate` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`transid`)
) ENGINE=InnoDB AUTO_INCREMENT=111 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_transaction`
--

LOCK TABLES `tbl_transaction` WRITE;
/*!40000 ALTER TABLE `tbl_transaction` DISABLE KEYS */;
INSERT INTO `tbl_transaction` VALUES (79,'3243232132','Senior Citizen','3456','DED','DED','CAPSULE','091020290','200 liter/s',4,100,64,36,64,'2023-04-13',''),(80,'2131313','Senior Citizen','3456','DED','DED','CAPSULE','091020290','200 liter/s',1,100,16,84,16,'2023-04-13',''),(81,'3243242342','Senior Citizen','44444','LLL','LLL','CAPSULE','091020290','200 miligram/s',3,100,48,52,48,'2023-04-13',''),(82,'4234213','PWD','44444','LLL','LLL','CAPSULE','091020290','200 miligram/s',2,100,32,68,32,'2023-04-13',''),(83,'213131','PWD','44444','LLL','LLL','CAPSULE','091020290','200 miligram/s',3,100,48,52,48,'2023-04-13',''),(84,'23123131','PWD','21','amoxiciline','uniliver','SAMPLE1','3121232','300 miligram/s',3,5000,240,4760,240,'2023-04-13',''),(85,'2313123','Senior Citizen','3456','DED','DED','CAPSULE','091020290','200 liter/s',2,100,32,68,32,'2023-04-13',''),(86,'21312312','Senior Citizen','3456','DED','DED','CAPSULE','091020290','200 liter/s',2,1000,32,968,32,'2023-04-13',''),(87,'213131','Senior Citizen','44444','LLL','LLL','CAPSULE','091020290','200 miligram/s',1,100,16,84,16,'2023-04-13',''),(88,'321313','Senior Citizen','3456','DED','DED','CAPSULE','091020290','200 liter/s',1,100,16,84,16,'2023-04-13',''),(89,'131313','Senior Citizen','44444','LLL','LLL','CAPSULE','091020290','200 miligram/s',1,100,16,84,16,'2023-04-13',''),(90,'232131','PWD','21','amoxiciline','uniliver','SAMPLE1','3121232','300 miligram/s',3,300,240,60,240,'2023-04-13',''),(91,'3213131','Senior Citizen','3456','DED','DED','CAPSULE','091020290','200 liter/s',2,100,32,68,32,'2023-04-13',''),(92,'3242334','PWD','3456','DED','DED','CAPSULE','091020290','200 liter/s',2,100,32,68,32,'2023-04-13',''),(93,'3131313','PWD','3456','DED','DED','CAPSULE','091020290','200 liter/s',2,100,32,68,32,'2023-04-13',''),(94,'123131','N/A','44444','LLL','LLL','CAPSULE','091020290','200 miligram/s',2,100,40,60,0,'2023-04-13',''),(95,'3123131','Senior Citizen','3456','DED','DED','CAPSULE','091020290','200 liter/s',3,100,48,52,48,'2023-04-13',''),(96,'23242343','Senior Citizen','3456','DED','DED','CAPSULE','091020290','200 liter/s',3,100,48,52,48,'2023-04-13',''),(97,'12123132','N/A','44444','LLL','LLL','CAPSULE','091020290','200 miligram/s',3,100,60,40,0,'2023-04-13',''),(98,'23123213','Senior Citizen','3456','DED','DED','CAPSULE','091020290','200 liter/s',2,100,32,68,32,'2023-04-13',''),(99,'213213','Senior Citizen','21','amoxiciline','uniliver','SAMPLE1','3121232','300 miligram/s',1,100,80,20,80,'2023-04-13',''),(100,'21313123','N/A','21','amoxiciline','uniliver','SAMPLE1','3121232','300 miligram/s',2,1000,200,800,0,'2023-04-13',''),(101,'4242','N/A','3456','DED','DED','CAPSULE','091020290','200 liter/s',2,100,40,60,0,'2023-04-13',''),(102,'2342432','PWD','21','amoxiciline','uniliver','SAMPLE1','3121232','300 miligram/s',3,900,240,660,240,'2023-04-13',''),(103,'2423423','Senior Citizen','21','amoxiciline','uniliver','SAMPLE1','3121232','300 miligram/s',3,500,240,260,240,'2023-04-13',''),(104,'23424242','Senior Citizen','21','amoxiciline','uniliver','SAMPLE1','3121232','300 miligram/s',3,800,288,512,288,'2023-04-13',''),(105,'232342','Senior Citizen','3456','DED','DED','CAPSULE','091020290','200 liter/s',2,100,32,68,32,'2023-04-13',''),(106,'242424','Senior Citizen','3456','DED','DED','CAPSULE','091020290','200 liter/s',2,100,32,68,32,'2023-04-13',''),(107,'324343','Senior Citizen','21','amoxiciline','uniliver','SAMPLE1','3121232','300 miligram/s',3,300,240,60,240,'2023-04-13',''),(108,'13213213213','Senior Citizen','3456','DED','DED','CAPSULE','091020290','200 liter/s',3,100,48,52,48,'2023-04-13',''),(109,'213213132132','N/A','3456','DED','DED','CAPSULE','091020290','200 liter/s',2,100,40,60,0,'2023-04-17',''),(110,'32333','N/A','21','amoxiciline','uniliver','SAMPLE1','3121232','300 miligram/s',5,1000,500,500,0,'2023-04-17','');
/*!40000 ALTER TABLE `tbl_transaction` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_users`
--

DROP TABLE IF EXISTS `tbl_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_users` (
  `username` varchar(45) NOT NULL,
  `usertype` varchar(45) NOT NULL,
  `userid` varchar(45) NOT NULL,
  `refid` int NOT NULL,
  `status` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `firstname` varchar(45) NOT NULL,
  `middlename` varchar(45) NOT NULL,
  `lastname` varchar(45) NOT NULL,
  `telno` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `address` varchar(45) NOT NULL,
  PRIMARY KEY (`username`,`refid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_users`
--

LOCK TABLES `tbl_users` WRITE;
/*!40000 ALTER TABLE `tbl_users` DISABLE KEYS */;
INSERT INTO `tbl_users` VALUES ('Sam','Admin','0000000',0,'Active','12345','sam','sam','sam','353546','sam','sam'),('Som','Cashier','USERSTF0201',1,'Active','123','wii','wii','dada','132131231','adasdaw','awdwadwa');
/*!40000 ALTER TABLE `tbl_users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-17 21:16:00
