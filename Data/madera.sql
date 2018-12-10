-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Client :  localhost
-- Généré le :  Lun 10 Décembre 2018 à 12:54
-- Version du serveur :  5.7.11
-- Version de PHP :  5.6.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `madera`
--

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `idClient` int(11) NOT NULL,
  `nomClient` varchar(250) NOT NULL,
  `prenomClient` varchar(250) NOT NULL,
  `adresseClient` varchar(250) NOT NULL,
  `codePostalClient` varchar(250) NOT NULL,
  `villeClient` varchar(250) NOT NULL,
  `emailClient` varchar(250) NOT NULL,
  `faxClient` varchar(10) NOT NULL,
  `mobileClient` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `client`
--

INSERT INTO `client` (`idClient`, `nomClient`, `prenomClient`, `adresseClient`, `codePostalClient`, `villeClient`, `emailClient`, `faxClient`, `mobileClient`) VALUES
(1, 'Blanc', 'Sophie', 'rue Montesquieu', '69007', 'Lyon', 'Sophie.Blanc@outlook.com', '0477639856', '0626438719'),
(2, 'Lambert', 'Andre', 'rue Montplaisir', '26000', 'Valence', 'Andre.Lambert@outlook.com', '0477890406', '0679025074');

-- --------------------------------------------------------

--
-- Structure de la table `commercial`
--

CREATE TABLE `commercial` (
  `idCommercial` int(11) NOT NULL,
  `nomCommercial` varchar(250) NOT NULL,
  `prenomCommercial` varchar(250) NOT NULL,
  `loginCommercial` varchar(250) NOT NULL,
  `motDePasseCommercial` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `commercial`
--

INSERT INTO `commercial` (`idCommercial`, `nomCommercial`, `prenomCommercial`, `loginCommercial`, `motDePasseCommercial`) VALUES
(1, 'Morel', 'Martin', 'Martin.Morel', 'Morel.Martin'),
(2, 'Petit', 'Vincent', 'Vincent.Petit', 'Petit.Vincent');

-- --------------------------------------------------------

--
-- Structure de la table `composant`
--

CREATE TABLE `composant` (
  `idComposant` int(11) NOT NULL,
  `nomComposant` varchar(250) NOT NULL,
  `idFamille` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `couverture`
--

CREATE TABLE `couverture` (
  `idCouverture` int(11) NOT NULL,
  `typeCouverture` varchar(250) NOT NULL,
  `prixHTCouverture` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `devis`
--

CREATE TABLE `devis` (
  `idDevis` int(11) NOT NULL,
  `nomDevis` varchar(250) NOT NULL,
  `dateDevis` date NOT NULL,
  `quantiteDevis` int(11) NOT NULL,
  `uniteDevis` int(11) NOT NULL,
  `prixHTDevis` float NOT NULL,
  `prixTTDevis` float NOT NULL,
  `margeCommercialDevis` int(11) NOT NULL,
  `margeEntrepriseDevis` int(11) NOT NULL,
  `idEtat` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `etat`
--

CREATE TABLE `etat` (
  `idEtat` int(11) NOT NULL,
  `libelleEtat` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `etat`
--

INSERT INTO `etat` (`idEtat`, `libelleEtat`) VALUES
(1, 'Brouillon'),
(2, 'Accepté'),
(3, 'En attente'),
(4, 'Refusé'),
(5, 'En commande');

-- --------------------------------------------------------

--
-- Structure de la table `famille`
--

CREATE TABLE `famille` (
  `idFamille` int(11) NOT NULL,
  `nomFamille` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `forme`
--

CREATE TABLE `forme` (
  `idForme` int(11) NOT NULL,
  `labelForme` varchar(250) NOT NULL,
  `longueurForme` float NOT NULL,
  `largeurForme` float NOT NULL,
  `prixHTForme` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `gamme`
--

CREATE TABLE `gamme` (
  `idGamme` int(11) NOT NULL,
  `offrePromoGamme` varchar(250) NOT NULL,
  `qualiteHuisserieGamme` varchar(250) NOT NULL,
  `typeIsolantGamme` varchar(250) NOT NULL,
  `typeFinitionGamme` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `module`
--

CREATE TABLE `module` (
  `idModule` int(11) NOT NULL,
  `nomModule` varchar(250) NOT NULL,
  `prixHTModule` float NOT NULL,
  `nbSectionModule` int(11) NOT NULL,
  `coordonneeDebutXModule` int(11) NOT NULL,
  `coordonneeDebutYModule` int(11) NOT NULL,
  `coordonneeFinXModule` int(11) NOT NULL,
  `coordonneeFinYModule` int(11) NOT NULL,
  `idSectionModule` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `objectifmodule`
--

CREATE TABLE `objectifmodule` (
  `idObjectifModule` int(11) NOT NULL,
  `labelObjectifModule` varchar(250) NOT NULL,
  `prixObjectifModule` float NOT NULL,
  `idForme` int(11) NOT NULL,
  `idComposant` int(11) NOT NULL,
  `idModule` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `plan`
--

CREATE TABLE `plan` (
  `idPlan` int(11) NOT NULL,
  `nomPlan` varchar(250) NOT NULL,
  `datePlan` date NOT NULL,
  `idProjet` int(11) NOT NULL,
  `idModule` int(11) NOT NULL,
  `idSol` int(11) NOT NULL,
  `idCouverture` int(11) NOT NULL,
  `idForme` int(11) NOT NULL,
  `idGamme` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `projet`
--

CREATE TABLE `projet` (
  `idProjet` int(11) NOT NULL,
  `nomProjet` varchar(250) NOT NULL,
  `dateProjet` date NOT NULL,
  `idClient` int(11) NOT NULL,
  `idCommercial` int(11) NOT NULL,
  `idDevis` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `section`
--

CREATE TABLE `section` (
  `idSection` int(11) NOT NULL,
  `labelSection` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `sol`
--

CREATE TABLE `sol` (
  `idSol` int(11) NOT NULL,
  `typeSol` varchar(250) NOT NULL,
  `prixHTSol` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Index pour les tables exportées
--

--
-- Index pour la table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`idClient`);

--
-- Index pour la table `commercial`
--
ALTER TABLE `commercial`
  ADD PRIMARY KEY (`idCommercial`);

--
-- Index pour la table `composant`
--
ALTER TABLE `composant`
  ADD PRIMARY KEY (`idComposant`),
  ADD KEY `fk_composant_famille` (`idFamille`);

--
-- Index pour la table `couverture`
--
ALTER TABLE `couverture`
  ADD PRIMARY KEY (`idCouverture`);

--
-- Index pour la table `devis`
--
ALTER TABLE `devis`
  ADD PRIMARY KEY (`idDevis`),
  ADD KEY `fk_devis_etat` (`idEtat`);

--
-- Index pour la table `etat`
--
ALTER TABLE `etat`
  ADD PRIMARY KEY (`idEtat`);

--
-- Index pour la table `famille`
--
ALTER TABLE `famille`
  ADD PRIMARY KEY (`idFamille`);

--
-- Index pour la table `forme`
--
ALTER TABLE `forme`
  ADD PRIMARY KEY (`idForme`);

--
-- Index pour la table `gamme`
--
ALTER TABLE `gamme`
  ADD PRIMARY KEY (`idGamme`);

--
-- Index pour la table `module`
--
ALTER TABLE `module`
  ADD PRIMARY KEY (`idModule`),
  ADD KEY `fk_module_section_module` (`idSectionModule`);

--
-- Index pour la table `objectifmodule`
--
ALTER TABLE `objectifmodule`
  ADD PRIMARY KEY (`idObjectifModule`),
  ADD KEY `fk_objectidmodule_forme` (`idForme`),
  ADD KEY `fk_objectidmodule_composant` (`idComposant`),
  ADD KEY `fk_objectidmodule_module` (`idModule`);

--
-- Index pour la table `plan`
--
ALTER TABLE `plan`
  ADD PRIMARY KEY (`idPlan`),
  ADD KEY `fk_plan_projet` (`idProjet`),
  ADD KEY `fk_plan_module` (`idModule`),
  ADD KEY `fk_plan_sol` (`idSol`),
  ADD KEY `fk_plan_couverture` (`idCouverture`),
  ADD KEY `fk_plan_forme` (`idForme`),
  ADD KEY `fk_plan_gamme` (`idGamme`);

--
-- Index pour la table `projet`
--
ALTER TABLE `projet`
  ADD PRIMARY KEY (`idProjet`),
  ADD KEY `fk_projet_client` (`idClient`),
  ADD KEY `fk_projet_commercial` (`idCommercial`),
  ADD KEY `fk_projet_devis` (`idDevis`);

--
-- Index pour la table `section`
--
ALTER TABLE `section`
  ADD PRIMARY KEY (`idSection`);

--
-- Index pour la table `sol`
--
ALTER TABLE `sol`
  ADD PRIMARY KEY (`idSol`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `client`
--
ALTER TABLE `client`
  MODIFY `idClient` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT pour la table `commercial`
--
ALTER TABLE `commercial`
  MODIFY `idCommercial` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT pour la table `composant`
--
ALTER TABLE `composant`
  MODIFY `idComposant` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT pour la table `couverture`
--
ALTER TABLE `couverture`
  MODIFY `idCouverture` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `devis`
--
ALTER TABLE `devis`
  MODIFY `idDevis` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `etat`
--
ALTER TABLE `etat`
  MODIFY `idEtat` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT pour la table `famille`
--
ALTER TABLE `famille`
  MODIFY `idFamille` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT pour la table `forme`
--
ALTER TABLE `forme`
  MODIFY `idForme` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `gamme`
--
ALTER TABLE `gamme`
  MODIFY `idGamme` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `module`
--
ALTER TABLE `module`
  MODIFY `idModule` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `objectifmodule`
--
ALTER TABLE `objectifmodule`
  MODIFY `idObjectifModule` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `plan`
--
ALTER TABLE `plan`
  MODIFY `idPlan` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `projet`
--
ALTER TABLE `projet`
  MODIFY `idProjet` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `section`
--
ALTER TABLE `section`
  MODIFY `idSection` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `sol`
--
ALTER TABLE `sol`
  MODIFY `idSol` int(11) NOT NULL AUTO_INCREMENT;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `composant`
--
ALTER TABLE `composant`
  ADD CONSTRAINT `fk_composant_famille` FOREIGN KEY (`idFamille`) REFERENCES `famille` (`idFamille`);

--
-- Contraintes pour la table `devis`
--
ALTER TABLE `devis`
  ADD CONSTRAINT `fk_devis_etat` FOREIGN KEY (`idEtat`) REFERENCES `etat` (`idEtat`);

--
-- Contraintes pour la table `module`
--
ALTER TABLE `module`
  ADD CONSTRAINT `fk_module_section_module` FOREIGN KEY (`idSectionModule`) REFERENCES `section` (`idSection`);

--
-- Contraintes pour la table `objectifmodule`
--
ALTER TABLE `objectifmodule`
  ADD CONSTRAINT `fk_objectidmodule_composant` FOREIGN KEY (`idComposant`) REFERENCES `composant` (`idComposant`),
  ADD CONSTRAINT `fk_objectidmodule_forme` FOREIGN KEY (`idForme`) REFERENCES `forme` (`idForme`),
  ADD CONSTRAINT `fk_objectidmodule_module` FOREIGN KEY (`idModule`) REFERENCES `module` (`idModule`);

--
-- Contraintes pour la table `plan`
--
ALTER TABLE `plan`
  ADD CONSTRAINT `fk_plan_couverture` FOREIGN KEY (`idCouverture`) REFERENCES `couverture` (`idCouverture`),
  ADD CONSTRAINT `fk_plan_forme` FOREIGN KEY (`idForme`) REFERENCES `forme` (`idForme`),
  ADD CONSTRAINT `fk_plan_gamme` FOREIGN KEY (`idGamme`) REFERENCES `gamme` (`idGamme`),
  ADD CONSTRAINT `fk_plan_module` FOREIGN KEY (`idModule`) REFERENCES `module` (`idModule`),
  ADD CONSTRAINT `fk_plan_projet` FOREIGN KEY (`idProjet`) REFERENCES `projet` (`idProjet`),
  ADD CONSTRAINT `fk_plan_sol` FOREIGN KEY (`idSol`) REFERENCES `sol` (`idSol`);

--
-- Contraintes pour la table `projet`
--
ALTER TABLE `projet`
  ADD CONSTRAINT `fk_projet_client` FOREIGN KEY (`idClient`) REFERENCES `client` (`idClient`),
  ADD CONSTRAINT `fk_projet_commercial` FOREIGN KEY (`idCommercial`) REFERENCES `commercial` (`idCommercial`),
  ADD CONSTRAINT `fk_projet_devis` FOREIGN KEY (`idDevis`) REFERENCES `devis` (`idDevis`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
