-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 07, 2019 at 09:34 PM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.1.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
USE dotnetcoreSamples;
--
-- Database: `dotnetcoresamples`
--

-- --------------------------------------------------------

--
-- Table structure for table `links`
--

CREATE TABLE `links` (
  `Id` int(10) NOT NULL,
  `label` varchar(100) NOT NULL,
  `href` text NOT NULL,
  `pinned` int(1) NOT NULL,
  `categoryId` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `links`
--

INSERT INTO `links` (`Id`, `label`, `href`, `pinned`, `categoryId`) VALUES
(1, 'W3 Schools', 'https://www.w3schools.com/', 0, 1),
(2, 'NSCC', 'https://nscc.ca', 1, 2),
(3, 'Netflix', 'https://netflix.com/browse', 1, 3),
(4, 'RBC Royal Bank', 'https://www.rbcroyalbank.com/personal.html', 0, 4),
(5, 'Google Maps', 'https://maps.google.ca/', 0, 3),
(6, 'Air Miles', 'https://www.airmiles.ca/arrow/Home', 0, 4),
(7, 'ScotiaBank ', 'https://www.scotiabank.com/ca/en/personal.html', 0, 4),
(8, 'Gmail', 'https://gmail.com', 0, 3),
(10, 'Google Home Page', 'https://google.ca', 0, 3),
(36, 'Student Website', 'https://peoplesoft.nscc.ca/psp/SELF_SERVE/EMPLOYEE/HRMS/', 0, 2),
(37, '.NET API', 'https://docs.microsoft.com/en-us/dotnet/api/?view=netcore-2.2', 0, 1),
(51, 'Angular API', 'https://angular.io/api', 0, 1),
(54, 'phpMyAdmin', 'http://www.localhost/phpmyadmin/', 1, 1),
(55, 'XAMPP', 'http://www.localhost/dashboard/', 1, 1),
(56, 'Stack Overflow', 'https://stackoverflow.com/', 0, 1),
(57, 'Prime Video', 'https://www.primevideo.com/', 1, 3),
(58, 'Disney +', 'https://www.disneyplus.com/', 1, 3);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `links`
--
ALTER TABLE `links`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `categoryId` (`categoryId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `links`
--
ALTER TABLE `links`
  MODIFY `Id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `links`
--
ALTER TABLE `links`
  ADD CONSTRAINT `links_ibfk_1` FOREIGN KEY (`categoryId`) REFERENCES `categories` (`Id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
