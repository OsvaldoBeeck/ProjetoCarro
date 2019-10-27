-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 27-Out-2019 às 08:09
-- Versão do servidor: 10.4.8-MariaDB
-- versão do PHP: 7.1.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `dados_veiculos`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `lucro`
--

CREATE TABLE `lucro` (
  `Loja` double NOT NULL,
  `Consignado` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `lucro`
--

INSERT INTO `lucro` (`Loja`, `Consignado`) VALUES
(0, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `veiculos`
--

CREATE TABLE `veiculos` (
  `Nome` varchar(20) NOT NULL,
  `Placa` varchar(8) NOT NULL,
  `Cor` varchar(20) NOT NULL,
  `Preco` double NOT NULL,
  `Ano` int(11) NOT NULL,
  `Status` varchar(12) NOT NULL,
  `Tipo` varchar(12) NOT NULL,
  `Cpf_Propietario` varchar(12) NOT NULL,
  `Propietario` varchar(50) NOT NULL,
  `Taxa` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `vendas`
--

CREATE TABLE `vendas` (
  `Cliente` varchar(60) NOT NULL,
  `Placa` varchar(8) NOT NULL,
  `NomeVeiculo` varchar(50) NOT NULL,
  `DataVenda` varchar(50) NOT NULL,
  `Telefone` varchar(50) NOT NULL,
  `Endereço` varchar(50) NOT NULL,
  `PrecoVenda` double NOT NULL,
  `Tipo` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `veiculos`
--
ALTER TABLE `veiculos`
  ADD PRIMARY KEY (`Placa`);

--
-- Índices para tabela `vendas`
--
ALTER TABLE `vendas`
  ADD PRIMARY KEY (`Placa`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
