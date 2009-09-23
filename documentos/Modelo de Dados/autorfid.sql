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
  `idAssociado` int(11) NOT NULL auto_increment,
  `cpf_cnpj` varchar(14) default NULL,
  `nome_razaosocial` varchar(90) default NULL,
  `tipo_fisica_juridica` varchar(2) default NULL,
  `endereco` varchar(60) default NULL,
  `numero` int(11) default NULL,
  `bairro` varchar(40) default NULL,
  `cidade` varchar(40) default NULL,
  `estado` varchar(2) default NULL,
  `cep` varchar(8) default NULL,
  `email` varchar(60) default NULL,
  `fone` varchar(10) default NULL,
  `fonecelular` varchar(10) default NULL,
  PRIMARY KEY  (`idAssociado`),
  UNIQUE KEY `XPKAssociado` (`idAssociado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `estabelecimento` (
  `idEstabelecimento` int(11) NOT NULL auto_increment,
  `cnpj` varchar(14) default NULL,
  `razaosocial` varchar(90) default NULL,
  `endereco` varchar(60) default NULL,
  `numero` int(11) default NULL,
  `bairro` varchar(40) default NULL,
  `cidade` varchar(40) default NULL,
  `estado` varchar(2) default NULL,
  `cep` varchar(8) default NULL,
  `email` varchar(60) default NULL,
  `fone` varchar(10) default NULL,
  `fonecelular` varchar(10) default NULL,
  `qtdVagas` int(11) default NULL,
  `qtdVagasOcupadas` int(11) default NULL,
  PRIMARY KEY  (`idEstabelecimento`),
  UNIQUE KEY `XPKEstabelecimento` (`idEstabelecimento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `etiquetaassociado` (
  `codigo_etiqueta` varchar(10) NOT NULL,
  `idAssociado` int(11) NOT NULL,
  `saldo` decimal(6,2) default NULL,
  `situacao` varchar(1) default NULL,
  `Valor` decimal(9,2) default NULL,
  PRIMARY KEY  (`codigo_etiqueta`,`idAssociado`),
  UNIQUE KEY `XPKEtiquetaAssociado` (`codigo_etiqueta`,`idAssociado`),
  KEY `XIF1EtiquetaAssociado` (`idAssociado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `funcionario` (
  `idFuncionario` int(11) NOT NULL auto_increment,
  `cpf` varchar(11) default NULL,
  `nome` varchar(60) default NULL,
  `endereco` varchar(60) default NULL,
  `numero` int(11) default NULL,
  `bairro` varchar(40) default NULL,
  `cidade` varchar(40) default NULL,
  `estado` varchar(2) default NULL,
  `cep` varchar(8) default NULL,
  `email` varchar(60) default NULL,
  `fone` varchar(10) default NULL,
  `fonecelular` varchar(10) default NULL,
  `idEstabelecimento` int(11) default NULL,
  `idTipoFuncionario` int(11) default NULL,
  `funcao` varchar(1) default NULL,
  PRIMARY KEY  (`idFuncionario`),
  UNIQUE KEY `XPKFuncionario` (`idFuncionario`),
  KEY `XIF3Funcionario` (`idTipoFuncionario`),
  KEY `XIF4Funcionario` (`idEstabelecimento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `movcreditos` (
  `idmovcreditos` int(11) NOT NULL auto_increment,
  `idFuncionario` int(11) default NULL,
  `idEstabelecimento` int(11) default NULL,
  `idAssociado` int(11) default NULL,
  `codigo_etiqueta` varchar(10) default NULL,
  `idFormaPagamento` int(11) default NULL,
  `dtCompra` date default NULL,
  `dtCredito` date default NULL,
  `valorcreditado` decimal(9,2) default NULL,
  `tipoPagamento` varchar(1) default NULL,
  PRIMARY KEY  (`idmovcreditos`),
  UNIQUE KEY `XPKMovEstacionamento` (`idmovcreditos`),
  KEY `XIF2MovEstacionamento` (`idEstabelecimento`),
  KEY `XIF4MovEstacionamento` (`idFuncionario`),
  KEY `XIF6MovEstacionamento` (`idFormaPagamento`),
  KEY `XIF7MovEstacionamento` (`codigo_etiqueta`,`idAssociado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `movdebitos` (
  `idmovdebitos` int(11) NOT NULL auto_increment,
  `codigo_etiqueta` varchar(10) default NULL,
  `idAssociado` int(11) default NULL,
  `idEstabelecimento` date default NULL,
  `dtentradahora` date default NULL,
  `dtsaidahora` int(11) default NULL,
  `valordebitado` decimal(9,2) default NULL,
  PRIMARY KEY  (`idmovdebitos`),
  UNIQUE KEY `XPKMovDebitos` (`idmovdebitos`),
  KEY `XIF1MovDebitos` (`codigo_etiqueta`,`idAssociado`),
  KEY `XIF2MovDebitos` (`idEstabelecimento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


ALTER TABLE `etiquetaassociado`
  ADD FOREIGN KEY (`idAssociado`) REFERENCES `associado` (`idAssociado`);

ALTER TABLE `funcionario`
  ADD FOREIGN KEY (`idEstabelecimento`) REFERENCES `estabelecimento` (`idEstabelecimento`);

ALTER TABLE `movcreditos`
  ADD FOREIGN KEY (`idEstabelecimento`) REFERENCES `estabelecimento` (`idEstabelecimento`),
  ADD FOREIGN KEY (`idFuncionario`) REFERENCES `funcionario` (`idFuncionario`),
  ADD FOREIGN KEY (`codigo_etiqueta`, `idAssociado`) REFERENCES `etiquetaassociado` (`codigo_etiqueta`, `idAssociado`);

ALTER TABLE `movdebitos`
  ADD FOREIGN KEY (`codigo_etiqueta`, `idAssociado`) REFERENCES `etiquetaassociado` (`codigo_etiqueta`, `idAssociado`);


/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
