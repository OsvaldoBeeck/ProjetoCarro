-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 23-Out-2019 às 03:03
-- Versão do servidor: 10.4.8-MariaDB
-- versão do PHP: 7.3.10

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
-- Estrutura da tabela `consignado`
--

CREATE TABLE `consignado` (
  `Placa` varchar(8) NOT NULL,
  `Nome` varchar(50) NOT NULL,
  `Cor` varchar(15) NOT NULL,
  `Preco` double NOT NULL,
  `Ano` varchar(5) NOT NULL,
  `Proprietario` varchar(50) NOT NULL,
  `Taxa` double NOT NULL,
  `Observacoes` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `veiculos`
--

CREATE TABLE `veiculos` (
  `Nome` varchar(20) NOT NULL,
  `Placa` varchar(8) NOT NULL,
  `Cor` varchar(20) NOT NULL,
  `Preco` double NOT NULL,
  `Ano` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `veiculos`
--

INSERT INTO `veiculos` (`Nome`, `Placa`, `Cor`, `Preco`, `Ano`) VALUES
('Golf', 'HGF2658', 'Branco', 35000, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `vendas`
--

CREATE TABLE `vendas` (
  `Placa` varchar(8) NOT NULL,
  `DataVenda` varchar(50) NOT NULL,
  `Cliente` varchar(50) NOT NULL,
  `Telefone` varchar(50) NOT NULL,
  `Endereço` varchar(50) NOT NULL,
  `NomeVeiculo` varchar(50) NOT NULL,
  `PrecoVenda` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `vendas`
--

INSERT INTO `vendas` (`Placa`, `DataVenda`, `Cliente`, `Telefone`, `Endereço`, `NomeVeiculo`, `PrecoVenda`) VALUES
('', '0000-00-00 00:00:00', '', '', '', '', ''),
('abc123', '0000-00-00 00:00:00', 'sdfasdf', '123123', 'sdfasdf', 'teste', 'R$ 123,00'),
('gfd9587', 'terça-feira, 22 de outubro de 2019', 'felipe', '1915615', 'cervezaoooooooo', 'camaro', 'R$ 200.000'),
('peupeu', 'terça-feira, 22 de outubro de 2019', 'felipe', '342342', 'dfasdfasd', 'peupeu', 'R$ 123,00'),
('System.W', '0000-00-00 00:00:00', 'System.Windows.Forms.TextBox, Text: dsafas', 'System.Wind', 'System.Windows.Forms.TextBox, Text: asdfasdf', 'System.Windows.Forms.TextBox, Text: Astra', 'System.Win'),
('teste', '0000-00-00 00:00:00', 'sadfas', '2432', 'sdfgsd', 'teste', 'R$ 1.231,0'),
('testee', '0000-00-00 00:00:00', 'sadfsd', '23423', 'agsddaf', 'testee', 'R$ 123,00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `vendasc`
--

CREATE TABLE `vendasc` (
  `Placa` varchar(8) NOT NULL,
  `DataVenda` varchar(12) NOT NULL,
  `Cliente` varchar(50) NOT NULL,
  `Telefone` varchar(50) NOT NULL,
  `Endereço` varchar(50) NOT NULL,
  `NomeVeiculo` varchar(50) NOT NULL,
  `PrecoVenda` varchar(10) NOT NULL,
  `Observacoes` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `consignado`
--
ALTER TABLE `consignado`
  ADD PRIMARY KEY (`Placa`);

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
