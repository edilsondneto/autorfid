/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='SYSTEM' */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE */;
/*!40101 SET SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES */;
/*!40103 SET SQL_NOTES='ON' */;


DROP DATABASE IF EXISTS `autorfid`;
CREATE DATABASE `autorfid` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `autorfid`;
CREATE TABLE `associado` (
  `idASSOCIADO` int(10) unsigned NOT NULL auto_increment,
  `CPF_CNPJ` varchar(14) default NULL,
  `NOME_RAZAOSOCIAL` varchar(90) default NULL,
  `TIPO_PF_PJ` varchar(2) default NULL,
  `ENDERECO` varchar(60) default NULL,
  `NUMERO` int(10) unsigned default NULL,
  `BAIRRO` varchar(40) default NULL,
  `CIDADE` varchar(40) default NULL,
  `ESTADO` varchar(2) default NULL,
  `CEP` varchar(8) default NULL,
  `EMAIL` varchar(60) default NULL,
  `FONE` varchar(10) default NULL,
  `FONECEL` varchar(10) default NULL,
  PRIMARY KEY  (`idASSOCIADO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `estabelecimento` (
  `idESTABELECIMENTO` int(10) unsigned NOT NULL auto_increment,
  `RAZAOSOCIAL` varchar(60) default NULL,
  `ENDERECO` varchar(60) default NULL,
  `NUMERO` int(10) unsigned default NULL,
  `BAIRRO` varchar(40) default NULL,
  `CIDADE` varchar(40) default NULL,
  `ESTADO` varchar(2) default NULL,
  `CEP` varchar(8) default NULL,
  `EMAIL` varchar(40) default NULL,
  `FONE` varchar(10) default NULL,
  `QTDVAGAS` int(10) unsigned default NULL,
  `ATDVAGASDISPONIVEIS` int(10) unsigned default NULL,
  PRIMARY KEY  (`idESTABELECIMENTO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `etiqueta` (
  `idETIQUETA` int(10) unsigned NOT NULL auto_increment,
  `MOVIMENTOESTABELECIMENTO_idMOVIMENTOESTABELECIMENTO` int(10) unsigned NOT NULL,
  `ASSOCIADO_idASSOCIADO` int(10) unsigned NOT NULL,
  `idASSOCIADO` int(10) unsigned default NULL,
  `SALDO` double default NULL,
  `DTINICIO` datetime default NULL,
  `SITUACAO` varchar(20) default NULL,
  `idMOVIMENTACAOCD_ATIVA` int(10) unsigned default NULL,
  PRIMARY KEY  (`idETIQUETA`),
  KEY `ETIQUETA_FKIndex1` (`ASSOCIADO_idASSOCIADO`),
  KEY `ETIQUETA_FKIndex2` (`MOVIMENTOESTABELECIMENTO_idMOVIMENTOESTABELECIMENTO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `formapagamento` (
  `idFORMAPAGAMENTO` int(10) unsigned NOT NULL auto_increment,
  `DESCRICAO` varchar(50) default NULL,
  PRIMARY KEY  (`idFORMAPAGAMENTO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `funcionario` (
  `idFUNCIONARIO` int(10) unsigned NOT NULL auto_increment,
  `ESTABELECIMENTO_idESTABELECIMENTO` int(10) unsigned NOT NULL,
  `CPF` varchar(11) default NULL,
  `NOME` varchar(60) default NULL,
  `NUMERO` int(10) unsigned default NULL,
  `BAIRRO` varchar(40) default NULL,
  `CIDADE` varchar(40) default NULL,
  `ESTADO` varchar(2) default NULL,
  `CEP` varchar(8) default NULL,
  `EMAIL` varchar(40) default NULL,
  `idESTABELECIMENTO` int(10) unsigned default NULL,
  `idTIPOFUNCIONARIO` int(10) unsigned default NULL,
  `FONE` varchar(10) default NULL,
  `FOTO` varchar(60) default NULL,
  PRIMARY KEY  (`idFUNCIONARIO`),
  KEY `FUNCIONARIO_FKIndex1` (`ESTABELECIMENTO_idESTABELECIMENTO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `mov_est_formapagamento` (
  `idMOV_EST_FORMAPAGAMENTO` int(10) unsigned NOT NULL auto_increment,
  `FORMAPAGAMENTO_idFORMAPAGAMENTO` int(10) unsigned NOT NULL,
  `ETIQUETA_idETIQUETA` int(10) unsigned NOT NULL,
  `MOVIMENTOESTABELECIMENTO_idMOVIMENTOESTABELECIMENTO` int(10) unsigned NOT NULL,
  `idMOVIMENTOESTABELECIMENTO` int(10) unsigned default NULL,
  `VALOR` double default NULL,
  `idFORMAPAGAMENTO` int(10) unsigned default NULL,
  `idETIQUETA` int(10) unsigned default NULL,
  PRIMARY KEY  (`idMOV_EST_FORMAPAGAMENTO`),
  KEY `MOV_EST_FORMAPAGAMENTO_FKIndex1` (`MOVIMENTOESTABELECIMENTO_idMOVIMENTOESTABELECIMENTO`),
  KEY `MOV_EST_FORMAPAGAMENTO_FKIndex2` (`ETIQUETA_idETIQUETA`),
  KEY `MOV_EST_FORMAPAGAMENTO_FKIndex3` (`FORMAPAGAMENTO_idFORMAPAGAMENTO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `movimentocd` (
  `idMOVIMENTOCD` int(10) unsigned NOT NULL auto_increment,
  `FUNCIONARIO_idFUNCIONARIO` int(10) unsigned NOT NULL,
  `ESTABELECIMENTO_idESTABELECIMENTO` int(10) unsigned NOT NULL,
  `ETIQUETA_idETIQUETA` int(10) unsigned NOT NULL,
  `VALOR` double default NULL,
  `CR` varchar(1) default NULL,
  `idETIQUETA` int(10) unsigned default NULL,
  `idESTABELECIMENTO` int(10) unsigned default NULL,
  `DATAHORA` datetime default NULL,
  `TIPO` varchar(20) default NULL,
  `idFUNCIONARIO` int(10) unsigned default NULL,
  PRIMARY KEY  (`idMOVIMENTOCD`),
  KEY `MOVIMENTOCD_FKIndex1` (`ETIQUETA_idETIQUETA`),
  KEY `MOVIMENTOCD_FKIndex2` (`ESTABELECIMENTO_idESTABELECIMENTO`),
  KEY `MOVIMENTOCD_FKIndex3` (`FUNCIONARIO_idFUNCIONARIO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `movimentoestabelecimento` (
  `idMOVIMENTOESTABELECIMENTO` int(10) unsigned NOT NULL auto_increment,
  `ESTABELECIMENTO_idESTABELECIMENTO` int(10) unsigned NOT NULL,
  `ASSOCIADO_idASSOCIADO` int(10) unsigned NOT NULL,
  `idESTABELECIMENTO` int(10) unsigned default NULL,
  `idASSOCIADO` int(10) unsigned default NULL,
  `DATAHORAINI` datetime default NULL,
  `DATAHORAFIM` datetime default NULL,
  `VALOR` double default NULL,
  PRIMARY KEY  (`idMOVIMENTOESTABELECIMENTO`),
  KEY `MOVIMENTOESTABELECIMENTO_FKIndex1` (`ASSOCIADO_idASSOCIADO`),
  KEY `MOVIMENTOESTABELECIMENTO_FKIndex2` (`ESTABELECIMENTO_idESTABELECIMENTO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `tipofuncionario` (
  `idTIPOFUNCIONARIO` int(10) unsigned NOT NULL auto_increment,
  `FUNCIONARIO_idFUNCIONARIO` int(10) unsigned NOT NULL,
  `DESCRICAO` varchar(30) default NULL,
  `GERENTE` varchar(1) default NULL,
  PRIMARY KEY  (`idTIPOFUNCIONARIO`),
  KEY `TIPOFUNCIONARIO_FKIndex1` (`FUNCIONARIO_idFUNCIONARIO`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
