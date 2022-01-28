-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 28, 2022 at 07:13 PM
-- Server version: 8.0.28
-- PHP Version: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `abc_traders`
--

-- --------------------------------------------------------

--
-- Table structure for table `car`
--

CREATE TABLE `car` (
  `CarId` int NOT NULL,
  `Brand` varchar(255) NOT NULL,
  `Edition` varchar(255) NOT NULL,
  `Model` varchar(255) NOT NULL,
  `Transmission` varchar(255) NOT NULL,
  `FuelType` varchar(255) NOT NULL,
  `BodyType` varchar(255) NOT NULL,
  `EngineCapacity` varchar(255) NOT NULL,
  `Colour` varchar(255) NOT NULL,
  `ManufacturedYear` varchar(50) NOT NULL,
  `Description` varchar(300) DEFAULT NULL,
  `Price` double NOT NULL,
  `Quantity` int NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `car`
--

INSERT INTO `car` (`CarId`, `Brand`, `Edition`, `Model`, `Transmission`, `FuelType`, `BodyType`, `EngineCapacity`, `Colour`, `ManufacturedYear`, `Description`, `Price`, `Quantity`, `created_at`) VALUES
(1, 'BMW', 'i8', 'H Model', 'Automatic', 'Petrol', 'MMM', '1000', 'Silver', '2018', 'Description for BMW I8', 200000, 194, '2022-01-22 19:00:02'),
(2, 'Tesla', 'v8', 't12', 'Manual', 'Diesel', 'qjwqkqjw', 'kqjwkqjk', 'Silver', 'kqjwkqk', '1', 10000000, 12, '2022-01-28 07:15:25'),
(4, 'Toyota', 'Vios', 't2', 'Manual', 'Petrol', 'MMM', 'MMM', 'Black', '1121', 'Hello', 10000, 0, '2022-01-28 07:15:35'),
(5, 'Toyota', 'ToyoTa', '123', 'Automatic', 'Diesel', 'NNN', '10000', 'Silver', '2016', 'Hello', 1000000, 8, '2022-01-28 07:15:39'),
(6, 'Audi', 'a8', 'a4', 'a', 'Petrol', 'a', 'a', 'sdss', 'a', 'dfdsf', 12000, 1, '2022-01-28 07:15:44'),
(7, 'Tesla', 'v2', '2', 'dfs', 'Diesel', 'sdf', 'sdf', 'dsf', 'sdf', 'sdf', 33, 2, '2022-01-28 07:16:15'),
(8, 'sad', 'asd', 'asd', 'asd', 'Diesel', 'asd', '34', 'dsf', '342', 'dsfsdf', 1222000, 23, '2022-01-28 17:37:06');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `CustomerId` int NOT NULL,
  `CustomerName` varchar(255) NOT NULL,
  `CustomerMobile` varchar(255) NOT NULL,
  `CustomerEmail` varchar(255) NOT NULL,
  `CustomerAddress` varchar(255) NOT NULL,
  `CustomerUserName` varchar(255) NOT NULL,
  `CustomerPassword` varchar(255) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`CustomerId`, `CustomerName`, `CustomerMobile`, `CustomerEmail`, `CustomerAddress`, `CustomerUserName`, `CustomerPassword`, `created_at`) VALUES
(1, 'Janitha Sandun', '0775527374', 'sandunjanitha8@gmail.com', 'Galle', 'sandun98', '*A4B6157319038724E3560894F7F932C8886EBFCF', '2022-01-28 16:19:02');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `OrderId` int NOT NULL,
  `OrderToken` varchar(100) DEFAULT NULL,
  `CustomerId` int NOT NULL,
  `Status` varchar(50) NOT NULL,
  `OrderDate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `TotalAmount` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Table structure for table `order_detail`
--

CREATE TABLE `order_detail` (
  `OrderDetailId` int NOT NULL,
  `OrderId` int NOT NULL DEFAULT '0',
  `UnitPrice` double NOT NULL,
  `Qty` int NOT NULL,
  `SubTotal` double NOT NULL,
  `CarId` int NOT NULL DEFAULT '0',
  `CarPartId` int NOT NULL DEFAULT '0',
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Table structure for table `spare_part`
--

CREATE TABLE `spare_part` (
  `SparePartId` int NOT NULL,
  `Brand` varchar(255) NOT NULL,
  `SparePartName` varchar(255) NOT NULL,
  `Model` varchar(255) NOT NULL,
  `Price` double NOT NULL,
  `Quantity` int NOT NULL,
  `Description` varchar(500) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `spare_part`
--

INSERT INTO `spare_part` (`SparePartId`, `Brand`, `SparePartName`, `Model`, `Price`, `Quantity`, `Description`, `created_at`) VALUES
(1, 'Brand One', 'Spare Part One', 'Model One', 2500, 31, 'spare part description', '2022-01-22 19:00:02'),
(2, 'LLL', 'MMM', 'MMM', 20000, 7, 'Hello', '2022-01-20 17:52:37'),
(3, 'a', 'fdgdf', 's', 23, 1, 'dfgdfg', '2022-01-24 04:37:36');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` int NOT NULL,
  `email` varchar(255) NOT NULL,
  `user_name` varchar(50) NOT NULL,
  `user_role` varchar(255) NOT NULL,
  `password` varchar(50) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `email`, `user_name`, `user_role`, `password`, `created_at`) VALUES
(1, 'superadmin@98.com', 'Admin', 'Super Admin', '*A4B6157319038724E3560894F7F932C8886EBFCF', '2022-01-24 07:03:48'),
(2, 'AdminP2', 'Admin P2', 'Admin', '*A4B6157319038724E3560894F7F932C8886EBFCF', '2022-01-25 05:59:56');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `car`
--
ALTER TABLE `car`
  ADD PRIMARY KEY (`CarId`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerId`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`OrderId`),
  ADD KEY `FK_order_customer` (`CustomerId`);

--
-- Indexes for table `order_detail`
--
ALTER TABLE `order_detail`
  ADD PRIMARY KEY (`OrderDetailId`),
  ADD KEY `FK_order_detail_order` (`OrderId`);

--
-- Indexes for table `spare_part`
--
ALTER TABLE `spare_part`
  ADD PRIMARY KEY (`SparePartId`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `car`
--
ALTER TABLE `car`
  MODIFY `CarId` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `CustomerId` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `OrderId` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `order_detail`
--
ALTER TABLE `order_detail`
  MODIFY `OrderDetailId` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT for table `spare_part`
--
ALTER TABLE `spare_part`
  MODIFY `SparePartId` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `FK_order_customer` FOREIGN KEY (`CustomerId`) REFERENCES `customer` (`CustomerId`);

--
-- Constraints for table `order_detail`
--
ALTER TABLE `order_detail`
  ADD CONSTRAINT `FK_order_detail_order` FOREIGN KEY (`OrderId`) REFERENCES `orders` (`OrderId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
