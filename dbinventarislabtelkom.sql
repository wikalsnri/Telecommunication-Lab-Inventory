-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 24, 2025 at 04:50 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbinventarislabtelkom`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbalat`
--

CREATE TABLE `tbalat` (
  `idalat` int(11) NOT NULL,
  `namaalat` varchar(100) NOT NULL,
  `kateid` int(11) NOT NULL,
  `lokasiid` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `kondisi` enum('Baik','Rusak','Hilang') NOT NULL,
  `keterangan` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbalat`
--

INSERT INTO `tbalat` (`idalat`, `namaalat`, `kateid`, `lokasiid`, `jumlah`, `kondisi`, `keterangan`) VALUES
(1, 'keyboard', 2, 2, 20, 'Baik', 'hitam'),
(2, 'komputer', 2, 3, 4, 'Baik', 'merah');

-- --------------------------------------------------------

--
-- Table structure for table `tbkategori`
--

CREATE TABLE `tbkategori` (
  `idkate` int(11) NOT NULL,
  `namakate` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbkategori`
--

INSERT INTO `tbkategori` (`idkate`, `namakate`) VALUES
(1, 'jaringan'),
(2, 'komputer'),
(3, 'mikroprossor');

-- --------------------------------------------------------

--
-- Table structure for table `tbkomponen`
--

CREATE TABLE `tbkomponen` (
  `idkomp` int(11) NOT NULL,
  `namakomp` varchar(100) NOT NULL,
  `kateid` int(11) NOT NULL,
  `lokasiid` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `kondisi` enum('Baik','Rusak','Hilang') NOT NULL,
  `keterangan` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbkomponen`
--

INSERT INTO `tbkomponen` (`idkomp`, `namakomp`, `kateid`, `lokasiid`, `jumlah`, `kondisi`, `keterangan`) VALUES
(1, 'resistor', 1, 2, 3, 'Baik', '100ohm'),
(2, 'kapasitor', 1, 2, 10, '', '100F');

-- --------------------------------------------------------

--
-- Table structure for table `tblokasi`
--

CREATE TABLE `tblokasi` (
  `idlok` int(11) NOT NULL,
  `ruangan` varchar(100) NOT NULL,
  `rak` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblokasi`
--

INSERT INTO `tblokasi` (`idlok`, `ruangan`, `rak`) VALUES
(1, 'LAB MIKRO', '2'),
(2, 'LAB RL', '1'),
(3, 'LAB KOMPUTER', '3');

-- --------------------------------------------------------

--
-- Table structure for table `tbtransaksi`
--

CREATE TABLE `tbtransaksi` (
  `idtransaksi` int(11) NOT NULL,
  `tipeitem` enum('Alat','Komponen') NOT NULL,
  `iditem` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `peminjam` varchar(100) NOT NULL,
  `tglpinjam` date NOT NULL,
  `tglkembali` date DEFAULT NULL,
  `kondisikembali` varchar(20) NOT NULL,
  `status` enum('Dipinjam','Dikembalikan','Hilang') DEFAULT NULL,
  `iduser` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbtransaksi`
--

INSERT INTO `tbtransaksi` (`idtransaksi`, `tipeitem`, `iditem`, `jumlah`, `peminjam`, `tglpinjam`, `tglkembali`, `kondisikembali`, `status`, `iduser`) VALUES
(1, '', 0, 2, 'wika lusianuari', '2025-12-17', '2025-12-24', 'Rusak', 'Dikembalikan', 2),
(2, 'Komponen', 1, 100, 'puan', '2025-12-22', NULL, '', 'Dipinjam', 1),
(3, 'Komponen', 1, 8, 'wika', '2025-12-22', '2025-12-24', 'Rusak', 'Dikembalikan', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbuser`
--

CREATE TABLE `tbuser` (
  `iduser` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `namalengkap` varchar(100) NOT NULL,
  `role` enum('Admin','Petugas','Kepala Lab') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbuser`
--

INSERT INTO `tbuser` (`iduser`, `username`, `password`, `namalengkap`, `role`) VALUES
(1, 'admin1', '111', 'Wika Lusinuari', 'Admin'),
(2, 'petugas1', '111', '-', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbalat`
--
ALTER TABLE `tbalat`
  ADD PRIMARY KEY (`idalat`),
  ADD KEY `kateid` (`kateid`),
  ADD KEY `lokasiid` (`lokasiid`);

--
-- Indexes for table `tbkategori`
--
ALTER TABLE `tbkategori`
  ADD PRIMARY KEY (`idkate`);

--
-- Indexes for table `tbkomponen`
--
ALTER TABLE `tbkomponen`
  ADD PRIMARY KEY (`idkomp`),
  ADD KEY `kateid` (`kateid`),
  ADD KEY `lokasiid` (`lokasiid`);

--
-- Indexes for table `tblokasi`
--
ALTER TABLE `tblokasi`
  ADD PRIMARY KEY (`idlok`);

--
-- Indexes for table `tbtransaksi`
--
ALTER TABLE `tbtransaksi`
  ADD PRIMARY KEY (`idtransaksi`),
  ADD KEY `iduser` (`iduser`);

--
-- Indexes for table `tbuser`
--
ALTER TABLE `tbuser`
  ADD PRIMARY KEY (`iduser`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbalat`
--
ALTER TABLE `tbalat`
  MODIFY `idalat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbkategori`
--
ALTER TABLE `tbkategori`
  MODIFY `idkate` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbkomponen`
--
ALTER TABLE `tbkomponen`
  MODIFY `idkomp` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tblokasi`
--
ALTER TABLE `tblokasi`
  MODIFY `idlok` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbtransaksi`
--
ALTER TABLE `tbtransaksi`
  MODIFY `idtransaksi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbuser`
--
ALTER TABLE `tbuser`
  MODIFY `iduser` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbalat`
--
ALTER TABLE `tbalat`
  ADD CONSTRAINT `tbalat_ibfk_1` FOREIGN KEY (`kateid`) REFERENCES `tbkategori` (`idkate`),
  ADD CONSTRAINT `tbalat_ibfk_2` FOREIGN KEY (`lokasiid`) REFERENCES `tblokasi` (`idlok`);

--
-- Constraints for table `tbkomponen`
--
ALTER TABLE `tbkomponen`
  ADD CONSTRAINT `tbkomponen_ibfk_1` FOREIGN KEY (`kateid`) REFERENCES `tbkategori` (`idkate`),
  ADD CONSTRAINT `tbkomponen_ibfk_2` FOREIGN KEY (`lokasiid`) REFERENCES `tblokasi` (`idlok`);

--
-- Constraints for table `tbtransaksi`
--
ALTER TABLE `tbtransaksi`
  ADD CONSTRAINT `tbtransaksi_ibfk_1` FOREIGN KEY (`iduser`) REFERENCES `tbuser` (`iduser`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
