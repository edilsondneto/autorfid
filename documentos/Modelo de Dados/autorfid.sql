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


CREATE DATABASE `autorfid` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `autorfid`;
CREATE TABLE `associado` (
  `idAssociado` varchar(6) NOT NULL,
  `pessoaFisicaJuridica` varchar(2) default NULL,
  `cpf` varchar(11) default NULL,
  `cnpj` varchar(14) default NULL,
  `razaoSocialNome` varchar(90) default NULL,
  `endereco` varchar(60) default NULL,
  `numero` int(11) default NULL,
  `bairro` varchar(40) default NULL,
  `cidade` varchar(40) default NULL,
  `estado` varchar(2) default NULL,
  `cep` varchar(8) default NULL,
  `email` varchar(40) default NULL,
  `fone` varchar(10) default NULL,
  `foneCel` varchar(10) default NULL,
  PRIMARY KEY  (`idAssociado`),
  UNIQUE KEY `XPKAssociado` (`idAssociado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `estabelecimento` (
  `idEstabelecimento` varchar(6) NOT NULL,
  `cnpj` varchar(14) default NULL,
  `razaoSocial` varchar(60) default NULL,
  `endereco` varchar(60) default NULL,
  `numero` int(11) default NULL,
  `bairro` varchar(40) default NULL,
  `cidade` varchar(40) default NULL,
  `estado` varchar(2) default NULL,
  `cep` varchar(8) default NULL,
  `email` varchar(40) default NULL,
  `fone` varchar(10) default NULL,
  `qtdVagas` int(11) default NULL,
  `qtdVagasOcupadas` int(11) default NULL,
  PRIMARY KEY  (`idEstabelecimento`),
  UNIQUE KEY `XPKEstabelecimento` (`idEstabelecimento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `etiquetaassociado` (
  `idEtiqueta` varchar(10) NOT NULL,
  `idAssociado` varchar(6) NOT NULL,
  `SaldoDisponivel` decimal(6,2) default NULL,
  `Situacao` varchar(1) default NULL,
  `Valor` decimal(6,2) default NULL,
  PRIMARY KEY  (`idEtiqueta`,`idAssociado`),
  UNIQUE KEY `XPKEtiquetaAssociado` (`idEtiqueta`,`idAssociado`),
  KEY `R_37` (`idAssociado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `formapagamento` (
  `idFormaPagamento` varchar(6) NOT NULL,
  `especificacao` varchar(20) default NULL,
  PRIMARY KEY  (`idFormaPagamento`),
  UNIQUE KEY `XPKFormaPagamento` (`idFormaPagamento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `funcionario` (
  `idFuncionario` varchar(6) NOT NULL,
  `cpf` varchar(11) default NULL,
  `nome` varchar(60) default NULL,
  `endereco` varchar(60) default NULL,
  `numero` int(11) default NULL,
  `bairro` varchar(40) default NULL,
  `cidade` varchar(40) default NULL,
  `estado` varchar(2) default NULL,
  `cep` varchar(8) default NULL,
  `email` varchar(40) default NULL,
  `idEstabelecimento` varchar(6) default NULL,
  `idTipoFuncionario` varchar(6) default NULL,
  `fone` varchar(10) default NULL,
  PRIMARY KEY  (`idFuncionario`),
  UNIQUE KEY `XPKFuncionario` (`idFuncionario`),
  KEY `R_17` (`idTipoFuncionario`),
  KEY `R_18` (`idEstabelecimento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `movimentacao` (
  `idMovimentacao` varchar(6) NOT NULL,
  `tipoLancamento` varchar(2) default NULL,
  `idEstabelecimento` varchar(6) default NULL,
  `idEtiqueta` varchar(10) default NULL,
  `idAssociado` varchar(6) default NULL,
  `idFuncionario` varchar(6) default NULL,
  `idFormaPagamento` varchar(6) default NULL,
  `dtEntrada_Compra` date default NULL,
  `dtSaida_Credito` date default NULL,
  `Valor` decimal(6,2) default NULL,
  PRIMARY KEY  (`idMovimentacao`),
  UNIQUE KEY `XPKMovEstacionamento` (`idMovimentacao`),
  KEY `R_20` (`idEstabelecimento`),
  KEY `R_34` (`idFuncionario`),
  KEY `R_36` (`idFormaPagamento`),
  KEY `R_39` (`idEtiqueta`,`idAssociado`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

CREATE TABLE `tipofuncionario` (
  `idTipoFuncionario` varchar(6) NOT NULL,
  `funcao` varchar(30) default NULL,
  PRIMARY KEY  (`idTipoFuncionario`),
  UNIQUE KEY `XPKTipoFuncionario` (`idTipoFuncionario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


ALTER TABLE `etiquetaassociado`
  ADD FOREIGN KEY (`idAssociado`) REFERENCES `associado` (`idAssociado`);

ALTER TABLE `funcionario`
  ADD FOREIGN KEY (`idEstabelecimento`) REFERENCES `estabelecimento` (`idEstabelecimento`),
  ADD FOREIGN KEY (`idTipoFuncionario`) REFERENCES `tipofuncionario` (`idTipoFuncionario`);

ALTER TABLE `movimentacao`
  ADD FOREIGN KEY (`idEtiqueta`, `idAssociado`) REFERENCES `etiquetaassociado` (`idEtiqueta`, `idAssociado`),
  ADD FOREIGN KEY (`idEstabelecimento`) REFERENCES `estabelecimento` (`idEstabelecimento`),
  ADD FOREIGN KEY (`idFuncionario`) REFERENCES `funcionario` (`idFuncionario`),
  ADD FOREIGN KEY (`idFormaPagamento`) REFERENCES `formapagamento` (`idFormaPagamento`);


/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
