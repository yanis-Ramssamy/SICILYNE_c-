-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost
-- Généré le : ven. 02 mai 2025 à 02:12
-- Version du serveur : 8.0.30
-- Version de PHP : 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `sicilynes`
--

-- --------------------------------------------------------

--
-- Structure de la table `asso_9`
--

CREATE TABLE `asso_9` (
  `IDTYPE` char(32) NOT NULL,
  `IDCATEGORIE` char(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `bateau`
--

CREATE TABLE `bateau` (
  `IDBATEAU` char(32) NOT NULL,
  `NOMBATEAU` char(32) DEFAULT NULL,
  `LONGUEURBATEAU` double(5,2) DEFAULT NULL,
  `VITESSEBATEU` double(5,2) DEFAULT NULL,
  `LARGEURBATEAU` double(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `bateau`
--

INSERT INTO `bateau` (`IDBATEAU`, `NOMBATEAU`, `LONGUEURBATEAU`, `VITESSEBATEU`, `LARGEURBATEAU`) VALUES
('B001', 'Corsica', 120.50, 35.00, 22.30),
('B002', 'Méditerranée', 100.00, 28.50, 20.00),
('B003', 'Atlantique', 150.00, 40.00, 25.00);

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE `categorie` (
  `IDCATEGORIE` char(32) NOT NULL,
  `LIBELLECATÉGORIE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `IDCLIENT` char(32) NOT NULL,
  `AGECLIENT` double(5,2) DEFAULT NULL,
  `NOMCLIENT` char(32) DEFAULT NULL,
  `ADRESSECLIENT` char(32) DEFAULT NULL,
  `CPCLIENT` char(5) DEFAULT NULL,
  `LOGIN` char(32) DEFAULT NULL,
  `MDP` char(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`IDCLIENT`, `AGECLIENT`, `NOMCLIENT`, `ADRESSECLIENT`, `CPCLIENT`, `LOGIN`, `MDP`) VALUES
('C001', 30.00, 'Martin Dupont', '12 Rue de la Mer', '75001', 'mdupont', 'mdp123'),
('C002', 45.00, 'Sophie Lemoine', '45 Avenue des Îles', '13000', 'slemoine', 'azerty'),
('C003', 22.00, 'Yanis Ramssamy', '99 Quai Sud', '97400', 'yramssamy', 'motdepasse');

-- --------------------------------------------------------

--
-- Structure de la table `contenir`
--

CREATE TABLE `contenir` (
  `IDCATEGORIE` char(32) NOT NULL,
  `IDBATEAU` char(32) NOT NULL,
  `CAPACITÉMAX` double(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `equipement`
--

CREATE TABLE `equipement` (
  `IDEQUIPEMENT` char(32) NOT NULL,
  `LIBELLEEQUIPEMENT` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `liaison`
--

CREATE TABLE `liaison` (
  `IDLIAISON` char(32) NOT NULL,
  `IDPORT_DÉPART` char(32) NOT NULL,
  `IDSECTEUR` char(32) NOT NULL,
  `IDPORT_ARRIVÉE` char(32) NOT NULL,
  `DURÉE` text,
  `PORTARRIVE` char(32) DEFAULT NULL,
  `PORTDEPART` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `periode`
--

CREATE TABLE `periode` (
  `IDPERIODE` char(32) NOT NULL,
  `DATEDÉBUT` date DEFAULT NULL,
  `DATEFIN` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `port`
--

CREATE TABLE `port` (
  `IDPORT` char(32) NOT NULL,
  `NOMPORT` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `propose`
--

CREATE TABLE `propose` (
  `IDBATEAU` char(32) NOT NULL,
  `IDEQUIPEMENT` char(32) NOT NULL,
  `EQUIPEMENTPROPOSE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

CREATE TABLE `reservation` (
  `IDRESERVATION` char(32) NOT NULL,
  `IDTYPE` char(32) DEFAULT NULL,
  `IDTRAVERSEE` char(32) NOT NULL,
  `IDCLIENT` char(32) NOT NULL,
  `DATERÉSERVATION` date DEFAULT NULL,
  `QUANTITÉ` double(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `secteur`
--

CREATE TABLE `secteur` (
  `IDSECTEUR` char(32) NOT NULL,
  `LIBELLE` char(32) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `tarif`
--

CREATE TABLE `tarif` (
  `IDLIAISON` char(32) NOT NULL,
  `IDPERIODE` char(32) NOT NULL,
  `IDTYPE` char(32) NOT NULL,
  `PRIX` double(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `traversee`
--

CREATE TABLE `traversee` (
  `IDTRAVERSEE` char(32) NOT NULL,
  `IDLIAISON` char(32) NOT NULL,
  `DATETRAVERSÉE` date DEFAULT NULL,
  `HEURE` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Structure de la table `type`
--

CREATE TABLE `type` (
  `IDTYPE` char(32) NOT NULL,
  `IDRESERVATION` char(32) DEFAULT NULL,
  `LIBELLETYPE` char(32) DEFAULT NULL,
  `QUANTITÉ` double(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `asso_9`
--
ALTER TABLE `asso_9`
  ADD PRIMARY KEY (`IDTYPE`,`IDCATEGORIE`),
  ADD KEY `I_FK_ASSO_9_TYPE` (`IDTYPE`),
  ADD KEY `I_FK_ASSO_9_CATEGORIE` (`IDCATEGORIE`);

--
-- Index pour la table `bateau`
--
ALTER TABLE `bateau`
  ADD PRIMARY KEY (`IDBATEAU`);

--
-- Index pour la table `categorie`
--
ALTER TABLE `categorie`
  ADD PRIMARY KEY (`IDCATEGORIE`);

--
-- Index pour la table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`IDCLIENT`);

--
-- Index pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD PRIMARY KEY (`IDCATEGORIE`,`IDBATEAU`),
  ADD KEY `I_FK_CONTENIR_CATEGORIE` (`IDCATEGORIE`),
  ADD KEY `I_FK_CONTENIR_BATEAU` (`IDBATEAU`);

--
-- Index pour la table `equipement`
--
ALTER TABLE `equipement`
  ADD PRIMARY KEY (`IDEQUIPEMENT`);

--
-- Index pour la table `liaison`
--
ALTER TABLE `liaison`
  ADD PRIMARY KEY (`IDLIAISON`),
  ADD KEY `I_FK_LIAISON_PORT` (`IDPORT_DÉPART`),
  ADD KEY `I_FK_LIAISON_SECTEUR` (`IDSECTEUR`),
  ADD KEY `I_FK_LIAISON_PORT1` (`IDPORT_ARRIVÉE`);

--
-- Index pour la table `periode`
--
ALTER TABLE `periode`
  ADD PRIMARY KEY (`IDPERIODE`);

--
-- Index pour la table `port`
--
ALTER TABLE `port`
  ADD PRIMARY KEY (`IDPORT`);

--
-- Index pour la table `propose`
--
ALTER TABLE `propose`
  ADD PRIMARY KEY (`IDBATEAU`,`IDEQUIPEMENT`),
  ADD KEY `I_FK_PROPOSE_BATEAU` (`IDBATEAU`),
  ADD KEY `I_FK_PROPOSE_EQUIPEMENT` (`IDEQUIPEMENT`);

--
-- Index pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`IDRESERVATION`),
  ADD UNIQUE KEY `I_FK_RESERVATION_TRAVERSEE` (`IDTRAVERSEE`),
  ADD UNIQUE KEY `I_FK_RESERVATION_CLIENT` (`IDCLIENT`),
  ADD UNIQUE KEY `I_FK_RESERVATION_TYPE` (`IDTYPE`);

--
-- Index pour la table `secteur`
--
ALTER TABLE `secteur`
  ADD PRIMARY KEY (`IDSECTEUR`);

--
-- Index pour la table `tarif`
--
ALTER TABLE `tarif`
  ADD PRIMARY KEY (`IDLIAISON`,`IDPERIODE`,`IDTYPE`),
  ADD KEY `I_FK_TARIF_LIAISON` (`IDLIAISON`),
  ADD KEY `I_FK_TARIF_PERIODE` (`IDPERIODE`),
  ADD KEY `I_FK_TARIF_TYPE` (`IDTYPE`);

--
-- Index pour la table `traversee`
--
ALTER TABLE `traversee`
  ADD PRIMARY KEY (`IDTRAVERSEE`),
  ADD KEY `I_FK_TRAVERSEE_LIAISON` (`IDLIAISON`);

--
-- Index pour la table `type`
--
ALTER TABLE `type`
  ADD PRIMARY KEY (`IDTYPE`),
  ADD UNIQUE KEY `I_FK_TYPE_RESERVATION` (`IDRESERVATION`);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `asso_9`
--
ALTER TABLE `asso_9`
  ADD CONSTRAINT `asso_9_ibfk_1` FOREIGN KEY (`IDTYPE`) REFERENCES `type` (`IDTYPE`),
  ADD CONSTRAINT `asso_9_ibfk_2` FOREIGN KEY (`IDCATEGORIE`) REFERENCES `categorie` (`IDCATEGORIE`);

--
-- Contraintes pour la table `contenir`
--
ALTER TABLE `contenir`
  ADD CONSTRAINT `contenir_ibfk_1` FOREIGN KEY (`IDCATEGORIE`) REFERENCES `categorie` (`IDCATEGORIE`),
  ADD CONSTRAINT `contenir_ibfk_2` FOREIGN KEY (`IDBATEAU`) REFERENCES `bateau` (`IDBATEAU`);

--
-- Contraintes pour la table `liaison`
--
ALTER TABLE `liaison`
  ADD CONSTRAINT `liaison_ibfk_1` FOREIGN KEY (`IDPORT_DÉPART`) REFERENCES `port` (`IDPORT`),
  ADD CONSTRAINT `liaison_ibfk_2` FOREIGN KEY (`IDSECTEUR`) REFERENCES `secteur` (`IDSECTEUR`),
  ADD CONSTRAINT `liaison_ibfk_3` FOREIGN KEY (`IDPORT_ARRIVÉE`) REFERENCES `port` (`IDPORT`);

--
-- Contraintes pour la table `propose`
--
ALTER TABLE `propose`
  ADD CONSTRAINT `propose_ibfk_1` FOREIGN KEY (`IDBATEAU`) REFERENCES `bateau` (`IDBATEAU`),
  ADD CONSTRAINT `propose_ibfk_2` FOREIGN KEY (`IDEQUIPEMENT`) REFERENCES `equipement` (`IDEQUIPEMENT`);

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `reservation_ibfk_1` FOREIGN KEY (`IDTYPE`) REFERENCES `type` (`IDTYPE`),
  ADD CONSTRAINT `reservation_ibfk_2` FOREIGN KEY (`IDTRAVERSEE`) REFERENCES `traversee` (`IDTRAVERSEE`),
  ADD CONSTRAINT `reservation_ibfk_3` FOREIGN KEY (`IDCLIENT`) REFERENCES `client` (`IDCLIENT`);

--
-- Contraintes pour la table `tarif`
--
ALTER TABLE `tarif`
  ADD CONSTRAINT `tarif_ibfk_1` FOREIGN KEY (`IDLIAISON`) REFERENCES `liaison` (`IDLIAISON`),
  ADD CONSTRAINT `tarif_ibfk_2` FOREIGN KEY (`IDPERIODE`) REFERENCES `periode` (`IDPERIODE`),
  ADD CONSTRAINT `tarif_ibfk_3` FOREIGN KEY (`IDTYPE`) REFERENCES `type` (`IDTYPE`);

--
-- Contraintes pour la table `traversee`
--
ALTER TABLE `traversee`
  ADD CONSTRAINT `traversee_ibfk_1` FOREIGN KEY (`IDLIAISON`) REFERENCES `liaison` (`IDLIAISON`);

--
-- Contraintes pour la table `type`
--
ALTER TABLE `type`
  ADD CONSTRAINT `type_ibfk_1` FOREIGN KEY (`IDRESERVATION`) REFERENCES `reservation` (`IDRESERVATION`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
