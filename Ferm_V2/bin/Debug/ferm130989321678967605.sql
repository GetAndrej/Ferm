-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2016-02-03 02:16:07
-- --------------------------------------
-- Server version 5.7.9-log MySQL Community Server (GPL)


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of cow
-- 

DROP TABLE IF EXISTS `cow`;
CREATE TABLE IF NOT EXISTS `cow` (
  `id_cow` int(11) NOT NULL,
  `klichka` varchar(45) NOT NULL,
  `pol` varchar(45) NOT NULL,
  `data_birthday` date NOT NULL,
  `kod` int(11) NOT NULL,
  `inwert_number` int(11) NOT NULL,
  `id_doyarka` int(11) NOT NULL,
  `id_mesto` int(11) NOT NULL,
  `privivka` varchar(300) NOT NULL,
  PRIMARY KEY (`id_cow`,`pol`,`id_doyarka`,`id_mesto`),
  UNIQUE KEY `id_cow_UNIQUE` (`id_cow`),
  KEY `pol` (`pol`),
  KEY `doy` (`id_doyarka`),
  KEY `id_mesto` (`id_mesto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table cow
-- 

/*!40000 ALTER TABLE `cow` DISABLE KEYS */;
INSERT INTO `cow`(`id_cow`,`klichka`,`pol`,`data_birthday`,`kod`,`inwert_number`,`id_doyarka`,`id_mesto`,`privivka`) VALUES
(1,'Лара','к','2016-01-27 00:00:00',2554,78,1,1,'12.12.2012'),
(2,'Lara','к','2016-01-28 00:00:00',5454,5654,1,1,'215565'),
(3,'ДарЬя','к','2016-01-22 00:00:00',14889,21552,2,1,'2113156');
/*!40000 ALTER TABLE `cow` ENABLE KEYS */;

-- 
-- Definition of korm
-- 

DROP TABLE IF EXISTS `korm`;
CREATE TABLE IF NOT EXISTS `korm` (
  `id_korm` int(11) NOT NULL AUTO_INCREMENT,
  `data` date NOT NULL,
  `makuha` int(11) DEFAULT NULL,
  `otrub` int(11) DEFAULT NULL,
  `kukuruza` int(11) DEFAULT NULL,
  `oves` int(11) DEFAULT NULL,
  `yachmin` int(11) DEFAULT NULL,
  `sino` int(11) DEFAULT NULL,
  `soloma` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_korm`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table korm
-- 

/*!40000 ALTER TABLE `korm` DISABLE KEYS */;
INSERT INTO `korm`(`id_korm`,`data`,`makuha`,`otrub`,`kukuruza`,`oves`,`yachmin`,`sino`,`soloma`) VALUES
(1,'2015-12-01 00:00:00',25,30,40,88,40,400,300),
(2,'2015-12-02 00:00:00',30,70,30,50,50,800,200),
(3,'2015-12-03 00:00:00',40,55,40,50,60,455,900),
(4,'2015-12-04 00:00:00',50,44,56,65,44,506,400),
(5,'2015-12-05 00:00:00',10,50,60,45,56,110,450),
(6,'2015-12-06 00:00:00',40,56,48,42,56,440,568),
(7,'2015-12-07 00:00:00',48,75,65,45,15,660,488),
(8,'2015-12-27 00:00:00',21,212,121,21,212,12121,121);
/*!40000 ALTER TABLE `korm` ENABLE KEYS */;

-- 
-- Definition of login
-- 

DROP TABLE IF EXISTS `login`;
CREATE TABLE IF NOT EXISTS `login` (
  `id_login` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_login`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table login
-- 

/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login`(`id_login`,`login`,`password`) VALUES
(1,'1','1');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;

-- 
-- Definition of mesto_cor
-- 

DROP TABLE IF EXISTS `mesto_cor`;
CREATE TABLE IF NOT EXISTS `mesto_cor` (
  `id_mest` int(11) NOT NULL,
  `name` varchar(75) NOT NULL,
  PRIMARY KEY (`id_mest`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table mesto_cor
-- 

/*!40000 ALTER TABLE `mesto_cor` DISABLE KEYS */;
INSERT INTO `mesto_cor`(`id_mest`,`name`) VALUES
(1,'Коровник№1'),
(2,'Коровник№2'),
(3,'Коровник№3');
/*!40000 ALTER TABLE `mesto_cor` ENABLE KEYS */;

-- 
-- Definition of milk
-- 

DROP TABLE IF EXISTS `milk`;
CREATE TABLE IF NOT EXISTS `milk` (
  `data` date NOT NULL,
  `id_person` int(11) NOT NULL,
  `utro` int(11) DEFAULT NULL,
  `obed` int(11) DEFAULT NULL,
  `vechir` int(11) DEFAULT NULL,
  `pogolov` varchar(45) DEFAULT NULL,
  `vipoy_tel` int(11) DEFAULT NULL,
  `obrat` varchar(45) DEFAULT NULL,
  `zhir` double(45,0) DEFAULT NULL,
  `zavod` int(11) DEFAULT NULL,
  `otpravka` int(11) DEFAULT NULL,
  `vsego_day` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_person`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table milk
-- 

/*!40000 ALTER TABLE `milk` DISABLE KEYS */;
INSERT INTO `milk`(`data`,`id_person`,`utro`,`obed`,`vechir`,`pogolov`,`vipoy_tel`,`obrat`,`zhir`,`zavod`,`otpravka`,`vsego_day`) VALUES
('2016-01-29 00:00:00',1,1,11888,11,'1',11,'1',11,1,11,1);
/*!40000 ALTER TABLE `milk` ENABLE KEYS */;

-- 
-- Definition of personal
-- 

DROP TABLE IF EXISTS `personal`;
CREATE TABLE IF NOT EXISTS `personal` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `position` varchar(100) DEFAULT NULL,
  `birthday` date DEFAULT NULL,
  ` address` varchar(200) DEFAULT NULL,
  `telephone` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table personal
-- 

/*!40000 ALTER TABLE `personal` DISABLE KEYS */;
INSERT INTO `personal`(`id`,`name`,`position`,`birthday`,` address`,`telephone`) VALUES
(1,'1','1','2016-01-30 00:00:00','1','1'),
(2,'2','2','2016-01-02 00:00:00','2','2');
/*!40000 ALTER TABLE `personal` ENABLE KEYS */;

-- 
-- Definition of tabel
-- 

DROP TABLE IF EXISTS `tabel`;
CREATE TABLE IF NOT EXISTS `tabel` (
  `пор_№` int(11) NOT NULL,
  `Наименование и № детали` varchar(300) NOT NULL,
  `Месячный план` varchar(700) DEFAULT NULL,
  `1` varchar(45) DEFAULT NULL,
  `2` varchar(45) DEFAULT NULL,
  `3` varchar(45) DEFAULT NULL,
  `4` varchar(45) DEFAULT NULL,
  `5` varchar(45) DEFAULT NULL,
  `6` varchar(45) DEFAULT NULL,
  `7` varchar(45) DEFAULT NULL,
  `8` varchar(45) DEFAULT NULL,
  `9` varchar(45) DEFAULT NULL,
  `10` varchar(45) DEFAULT NULL,
  `11` varchar(45) DEFAULT NULL,
  `12` varchar(45) DEFAULT NULL,
  `13` varchar(45) DEFAULT NULL,
  `14` varchar(45) DEFAULT NULL,
  `15` varchar(45) DEFAULT NULL,
  `16` varchar(45) DEFAULT NULL,
  `17` varchar(45) DEFAULT NULL,
  `18` varchar(45) DEFAULT NULL,
  `19` varchar(45) DEFAULT NULL,
  `20` varchar(45) DEFAULT NULL,
  `21` varchar(45) DEFAULT NULL,
  `22` varchar(45) DEFAULT NULL,
  `23` varchar(45) DEFAULT NULL,
  `24` varchar(45) DEFAULT NULL,
  `25` varchar(45) DEFAULT NULL,
  `26` varchar(45) DEFAULT NULL,
  `27` varchar(45) DEFAULT NULL,
  `28` varchar(45) DEFAULT NULL,
  `29` varchar(45) DEFAULT NULL,
  `30` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`пор_№`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table tabel
-- 

/*!40000 ALTER TABLE `tabel` DISABLE KEYS */;

/*!40000 ALTER TABLE `tabel` ENABLE KEYS */;

-- 
-- Definition of zarplata
-- 

DROP TABLE IF EXISTS `zarplata`;
CREATE TABLE IF NOT EXISTS `zarplata` (
  `id_zarplata` int(11) NOT NULL,
  `data` date NOT NULL,
  `id_pers` int(11) NOT NULL,
  `zarp_milk` int(11) DEFAULT NULL,
  `zarp_money` int(11) DEFAULT NULL,
  `primechanie` varchar(300) DEFAULT NULL,
  PRIMARY KEY (`id_pers`,`id_zarplata`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- 
-- Dumping data for table zarplata
-- 

/*!40000 ALTER TABLE `zarplata` DISABLE KEYS */;
INSERT INTO `zarplata`(`id_zarplata`,`data`,`id_pers`,`zarp_milk`,`zarp_money`,`primechanie`) VALUES
(1,'2015-11-01 00:00:00',1,54,1200,NULL),
(3,'2015-12-01 00:00:00',1,40,1600,NULL),
(2,'2015-11-01 00:00:00',2,30,1000,NULL);
/*!40000 ALTER TABLE `zarplata` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2016-02-03 02:16:07
-- Total time: 0:0:0:0:74 (d:h:m:s:ms)
