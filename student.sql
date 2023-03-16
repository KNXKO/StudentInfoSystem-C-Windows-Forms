-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Hostiteľ: 127.0.0.1:3306
-- Čas generovania: St 21.Dec 2022, 10:14
-- Verzia serveru: 8.0.23
-- Verzia PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáza: `student`
--

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `student_info`
--

CREATE TABLE `student_info` (
  `ID` int NOT NULL,
  `Meno` varchar(50) NOT NULL,
  `Priezvisko` varchar(50) NOT NULL,
  `Datum narodenia` date NOT NULL,
  `Email` varchar(60) NOT NULL,
  `Telefon` varchar(15) NOT NULL,
  `Bydlisko` varchar(60) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `PSC` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Kľúče pre exportované tabuľky
--

--
-- Indexy pre tabuľku `student_info`
--
ALTER TABLE `student_info`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT pre exportované tabuľky
--

--
-- AUTO_INCREMENT pre tabuľku `student_info`
--
ALTER TABLE `student_info`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
