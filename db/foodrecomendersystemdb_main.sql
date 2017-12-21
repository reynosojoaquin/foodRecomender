CREATE DATABASE  IF NOT EXISTS `foodrecomendersystemdb` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `foodrecomendersystemdb`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: foodrecomendersystemdb
-- ------------------------------------------------------
-- Server version	5.7.14

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `main`
--

DROP TABLE IF EXISTS `main`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `main` (
  `ingredientes` varchar(250) DEFAULT NULL,
  `id` int(11) NOT NULL,
  `vocabulary` text,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `main`
--

LOCK TABLES `main` WRITE;
/*!40000 ALTER TABLE `main` DISABLE KEYS */;
INSERT INTO `main` VALUES (NULL,1,'about,added,and,as,drained,teaspoon,tablespoon,fluid ounce,gill,cup ,pint ,quart,gallon,ml,pound,ounce,mg,Length,mm,cm,or,oz,red,your,black,of,no,oscar,part,pinch,plain,powder,preferably,raw,reduced,refrigerated,rinsed,salad,see,serving,scrubbed,sea,brand,bread,brown,can,choice,canned,coarse,container,cooked,cooking,cored,crumbled,crushed,cups,cut,Dash,dog,deli,diced,divided,dried,extra,for,firm,fat,free,fresh,Freshly,short,sharp,soy,spice,spray,stalk,smoked,slivered,sliced,teaspoons,Tip,Tips,to,toasted,virgin,wheat,white,whole,chopped,Chopped,cubed,halved,ground,grilled,into,leaves,large,light,mashed,mixed,Oscar,shredded,stemmed,tablespoons,com,cubes,de,hot,Hot,Mayer,optional,packed,paste,style,skim,such,sweet,cup,minced,ounces,inch,very,');
/*!40000 ALTER TABLE `main` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-12-20 21:53:04
