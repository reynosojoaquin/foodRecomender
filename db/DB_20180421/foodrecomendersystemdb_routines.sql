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
-- Temporary view structure for view `recipedatatoowl`
--

DROP TABLE IF EXISTS `recipedatatoowl`;
/*!50001 DROP VIEW IF EXISTS `recipedatatoowl`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `recipedatatoowl` AS SELECT 
 1 AS `recipeID`,
 1 AS `sal`,
 1 AS `calorias`,
 1 AS `fibra`,
 1 AS `azucar`,
 1 AS `grasas`,
 1 AS `grasasSaturadas`,
 1 AS `carbohidratos`,
 1 AS `proteinas`,
 1 AS `colesterol`,
 1 AS `recipeTipoPlatoData`,
 1 AS `recipeCulturaData`,
 1 AS `recipeNacionalidadData`,
 1 AS `recipeMomentoData`,
 1 AS `recipeTemporadaData`,
 1 AS `esSopa`,
 1 AS `esPasta`,
 1 AS `esMarisco`,
 1 AS `esBebida`,
 1 AS `esBajoColesterol`,
 1 AS `esBajoEncalorias`,
 1 AS `esLibreGluten`,
 1 AS `pais`,
 1 AS `recipeName`,
 1 AS `Ingredientedescripcion`,
 1 AS `ingredienteID`,
 1 AS `classOf`,
 1 AS `mainIngredient`,
 1 AS `geolocalizacion`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `receta_ingredientes`
--

DROP TABLE IF EXISTS `receta_ingredientes`;
/*!50001 DROP VIEW IF EXISTS `receta_ingredientes`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `receta_ingredientes` AS SELECT 
 1 AS `recipeID`,
 1 AS `RecetaNombre`,
 1 AS `tipoplato`,
 1 AS `descripcion`,
 1 AS `ingredienteID`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `recipedatatoowl`
--

/*!50001 DROP VIEW IF EXISTS `recipedatatoowl`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `recipedatatoowl` AS select `recipe`.`recipeID` AS `recipeID`,`recipe`.`sal` AS `sal`,`recipe`.`calorias` AS `calorias`,`recipe`.`fibra` AS `fibra`,`recipe`.`azucar` AS `azucar`,`recipe`.`grasas` AS `grasas`,`recipe`.`grasasSaturadas` AS `grasasSaturadas`,`recipe`.`carbohidratos` AS `carbohidratos`,`recipe`.`proteinas` AS `proteinas`,`recipe`.`colesterol` AS `colesterol`,`recipe`.`recipeTipoPlatoData` AS `recipeTipoPlatoData`,`recipe`.`recipeCulturaData` AS `recipeCulturaData`,`recipe`.`recipeNacionalidadData` AS `recipeNacionalidadData`,`recipe`.`recipeMomentoData` AS `recipeMomentoData`,`recipe`.`recipeTemporadaData` AS `recipeTemporadaData`,`recipe`.`esSopa` AS `esSopa`,`recipe`.`esPasta` AS `esPasta`,`recipe`.`esMarisco` AS `esMarisco`,`recipe`.`esBebida` AS `esBebida`,`recipe`.`esBajoColesterol` AS `esBajoColesterol`,`recipe`.`esBajoEnCalorias` AS `esBajoEncalorias`,`recipe`.`esLibreGluten` AS `esLibreGluten`,`recipe`.`PaisID` AS `pais`,`translate`.`recipeName` AS `recipeName`,`translate`.`IngredienteDescripcion` AS `Ingredientedescripcion`,`translate`.`ingredienteID` AS `ingredienteID`,`translate`.`classOf` AS `classOf`,`translate`.`mainIngredient` AS `mainIngredient`,`pais`.`geolocalizacion` AS `geolocalizacion` from ((`recipe` left join `translate` on((`translate`.`recipeID` = `recipe`.`recipeID`))) left join `pais` on((`recipe`.`PaisID` = `pais`.`PaisID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `receta_ingredientes`
--

/*!50001 DROP VIEW IF EXISTS `receta_ingredientes`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `receta_ingredientes` AS select `recipe`.`recipeID` AS `recipeID`,`recipe`.`Nombre` AS `RecetaNombre`,`recipe`.`recipeTipoPlatoData` AS `tipoplato`,`ingredientes`.`descripcion` AS `descripcion`,`ingredientes`.`ingredienteID` AS `ingredienteID` from (`recipe` left join `ingredientes` on((`ingredientes`.`recipeID` = `recipe`.`recipeID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Dumping routines for database 'foodrecomendersystemdb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-04-21  9:51:34
