-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.7.14


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema foodapi
--

CREATE DATABASE IF NOT EXISTS foodapi;
USE foodapi;

--
-- Temporary table structure for view `receta_ingredientes`
--
DROP TABLE IF EXISTS `receta_ingredientes`;
DROP VIEW IF EXISTS `receta_ingredientes`;
CREATE TABLE `receta_ingredientes` (
  `recipeID` int(11),
  `RecetaNombre` varchar(250),
  `tipoplato` varchar(45),
  `descripcion` varchar(250),
  `ingredienteID` int(10)
);

--
-- Definition of table `momentorecipe`
--

DROP TABLE IF EXISTS `momentorecipe`;
CREATE TABLE `momentorecipe` (
  `ID` int(11) NOT NULL,
  `Descripcion` varchar(145) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `momentorecipe`
--

/*!40000 ALTER TABLE `momentorecipe` DISABLE KEYS */;
INSERT INTO `momentorecipe` (`ID`,`Descripcion`) VALUES 
 (1,'Entrada'),
 (2,'Plato Fuerte'),
 (3,'Postre');
/*!40000 ALTER TABLE `momentorecipe` ENABLE KEYS */;


--
-- Definition of table `pais`
--

DROP TABLE IF EXISTS `pais`;
CREATE TABLE `pais` (
  `PaisID` int(11) NOT NULL,
  `Descripcion` varchar(250) DEFAULT NULL,
  `geolocalizacion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`PaisID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pais`
--

/*!40000 ALTER TABLE `pais` DISABLE KEYS */;
INSERT INTO `pais` (`PaisID`,`Descripcion`,`geolocalizacion`) VALUES 
 (1,'Republica Dominicana','18.6691754,-71.2513953,8z'),
 (2,'España','40.1300946,-8.2034785,6z'),
 (3,'Mexico','23.3138441,-111.6482185,5z'),
 (4,'Colombia','4.6098097,-83.3894202,5z'),
 (5,'China','34.4510689,86.0488524,4z'),
 (6,'Venezuela','5.9953744,-73.5800231,5.5z');
/*!40000 ALTER TABLE `pais` ENABLE KEYS */;


--
-- Definition of table `tipoplato`
--

DROP TABLE IF EXISTS `tipoplato`;
CREATE TABLE `tipoplato` (
  `tipoPlatoID` int(11) NOT NULL,
  `Descripcion` varchar(145) DEFAULT NULL,
  PRIMARY KEY (`tipoPlatoID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tipoplato`
--

/*!40000 ALTER TABLE `tipoplato` DISABLE KEYS */;
INSERT INTO `tipoplato` (`tipoPlatoID`,`Descripcion`) VALUES 
 (1,'Desayuno'),
 (2,'Almuerzo'),
 (3,'Merienda'),
 (4,'Cena');
/*!40000 ALTER TABLE `tipoplato` ENABLE KEYS */;


--
-- Definition of view `receta_ingredientes`
--

DROP TABLE IF EXISTS `receta_ingredientes`;
DROP VIEW IF EXISTS `receta_ingredientes`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `receta_ingredientes` AS select `recipe`.`recipeID` AS `recipeID`,`recipe`.`Nombre` AS `RecetaNombre`,`recipe`.`recipeTipoPlatoData` AS `tipoplato`,`ingredientes`.`descripcion` AS `descripcion`,`ingredientes`.`ingredienteID` AS `ingredienteID` from (`recipe` left join `ingredientes` on((`ingredientes`.`recipeID` = `recipe`.`recipeID`)));



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
