-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 14, 2021 at 10:43 AM
-- Server version: 10.4.20-MariaDB
-- PHP Version: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `loginpage`
--

-- --------------------------------------------------------

--
-- Table structure for table `adminlogin`
--

CREATE TABLE `adminlogin` (
  `id` int(110) NOT NULL,
  `adminname` varchar(110) NOT NULL,
  `password` varchar(110) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `adminlogin`
--

INSERT INTO `adminlogin` (`id`, `adminname`, `password`) VALUES
(1, 'admin', '123'),
(2, 'hello', '123');

-- --------------------------------------------------------

--
-- Table structure for table `bookissue`
--

CREATE TABLE `bookissue` (
  `name` varchar(110) NOT NULL,
  `bname` varchar(110) NOT NULL,
  `bid` int(110) DEFAULT NULL,
  `idate` date NOT NULL,
  `rdate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bookissue`
--

INSERT INTO `bookissue` (`name`, `bname`, `bid`, `idate`, `rdate`) VALUES
('', '', NULL, '0000-00-00', '0000-00-00'),
('Rahul', 'Book3/ghi', NULL, '2021-08-03', '2021-08-17'),
('ankit', 'book1/abc', NULL, '2021-08-01', '2021-08-15'),
('shawn', 'Book2/cde', NULL, '2021-08-02', '2021-08-16'),
('', '', 0, '0000-00-00', '0000-00-00'),
('', '', 0, '0000-00-00', '0000-00-00'),
('', '', 0, '0000-00-00', '0000-00-00'),
('', '', 0, '0000-00-00', '0000-00-00'),
('', '', 0, '0000-00-00', '0000-00-00'),
('', '', 0, '0000-00-00', '0000-00-00'),
('', '', 0, '0000-00-00', '0000-00-00'),
('', '', 0, '0000-00-00', '0000-00-00'),
('', '', 0, '0000-00-00', '0000-00-00'),
('', '', 0, '0000-00-00', '0000-00-00'),
('', '', 0, '0000-00-00', '0000-00-00'),
('', '', 0, '0000-00-00', '0000-00-00'),
('', '', 0, '0000-00-00', '0000-00-00'),
('', '', 0, '0000-00-00', '0000-00-00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `adminlogin`
--
ALTER TABLE `adminlogin`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `adminlogin`
--
ALTER TABLE `adminlogin`
  MODIFY `id` int(110) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
