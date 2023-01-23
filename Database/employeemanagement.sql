-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 23, 2023 at 10:03 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `employeemanagement`
--

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `id` int(11) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `job_title` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `role` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`id`, `first_name`, `last_name`, `job_title`, `email`, `password`, `role`) VALUES
(1, 'Steven', 'King', 'Admin', 'admintest@gmail.com', '123four', 1),
(2, 'Issac', 'Newton', 'Admin', 'test@hotmail.com', '456', 1),
(4, 'Donald', 'OConnell', 'Clerical', 'doconnell@hotmail.com', '123', 0),
(5, 'Pat', 'Fay', 'Clerical', 'pfay@gmail.com', '123', 0),
(6, 'Douglas', 'Grant', 'Clerical', 'dgrant@gmail.com', '123', 0),
(7, 'David', 'Austin', 'Manager', 'daustin@gmail.com', '123', 1),
(8, 'Luis', 'Popp', 'Clerical', 'lpopp@yahoo.com', '123', 0),
(11, 'Matthew', 'Weiss', 'Clerical', 'mweiss@hotmail.com', '123', 0),
(12, 'Lex', 'De Haan', 'Manager', 'ldehaan@gmail.com', '123', 1),
(13, 'John', 'Chen', 'Clerical', 'jchen@jayoo.com', '123', 0),
(14, 'Alexander', 'Khoo', 'Clerical', 'akhoo@hotmail.com', '123', 0),
(15, 'Guy', 'Himuro', 'Clerical', 'ghimuro@gmail.com', '123', 0),
(16, 'Adam', 'Fripp', 'Clerical', 'afripp@gmail.com', '123', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
