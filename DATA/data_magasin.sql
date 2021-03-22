DROP DATABASE IF EXISTS `magasin`;
CREATE DATABASE IF NOT EXISTS `magasin` DEFAULT CHARACTER SET utf8mb4 ;
Use `magasin`;
CREATE TABLE `magasin`.`Client` (
`idClient` MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT,
`nom` VARCHAR(45) NOT NULL,
`prenom` VARCHAR(45) NOT NULL,
`age` TINYINT UNSIGNED NULL,
`adresse` VARCHAR(45) NOT NULL,
`ville` VARCHAR(45) NOT NULL,
`mail` VARCHAR(45) NULL,
PRIMARY KEY (`idClient`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;
CREATE TABLE `magasin`.`Commande` (
`idCommande` MEDIUMINT UNSIGNED NOT NULL AUTO_INCREMENT,
`date` DATETIME NULL,
`idClient` MEDIUMINT UNSIGNED NOT NULL,
PRIMARY KEY (`idCommande`),
INDEX `idClient_fk_idx` (`idClient` ASC),
CONSTRAINT `idClient_fk`
FOREIGN KEY (`idClient`)
REFERENCES `magasin`.`Client` (`idClient`)
ON DELETE CASCADE
ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;
CREATE TABLE `magasin`.`Article` (
`idArticle` CHAR(5) NOT NULL,
`designation` VARCHAR(100) NOT NULL,
`prix` DECIMAL(8,2) NOT NULL,
`categorie` ENUM('tous', 'vidéo', 'photo', 'informatique', 'divers') NOT NULL DEFAULT 'tous',
PRIMARY KEY (`idArticle`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;
CREATE TABLE `magasin`.`Ligne` (
`idCommande` MEDIUMINT UNSIGNED NOT NULL,
`idArticle` CHAR(5) NOT NULL,
`quantite` TINYINT UNSIGNED NOT NULL,
PRIMARY KEY (`idCommande`, `idArticle`)
)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;
INSERT INTO `magasin`.`Client` (`idClient`, `nom`, `prenom`, `age`, `adresse`, `ville`, `mail`)
VALUES ('1', 'Marti', 'Jean', '36', '5 av. Einstein', 'Strasbourg', 'mart@marti.com');
INSERT INTO `magasin`.`Client` (`idClient`, `nom`, `prenom`, `age`, `adresse`, `ville`, `mail`)
VALUES ('2', 'Rapp ', 'Paul', '44', '32 av. Foch ', 'Paris', 'rapp@libert.com');
INSERT INTO `magasin`.`Client` (`idClient`, `nom`, `prenom`, `age`, `adresse`, `ville`, `mail`)
VALUES ('3', 'Devos', 'Marie', '18', '75 bd Hochimin', 'Lile', 'grav@waladoo.fr');
INSERT INTO `magasin`.`Client` (`idClient`, `nom`, `prenom`, `age`, `adresse`, `ville`, `mail`)
VALUES ('4', 'Hochon', 'Paul', '22', '33 rue Tsétsé', 'Chartres', 'hoch@fiscali.fr');
INSERT INTO `magasin`.`Client` (`idClient`, `nom`, `prenom`, `age`, `adresse`, `ville`, `mail`)
VALUES ('5', 'Grave', 'Nuyen', '18', '75 bd Hochimin', 'Lille ', 'NULL');
INSERT INTO `magasin`.`Client` (`idClient`, `nom`, `prenom`, `age`, `adresse`, `ville`, `mail`)
VALUES ('6', 'Hachette', 'Jeanne', '45', '60 rue d’Amiens', 'Versailles', 'NULL');
INSERT INTO `magasin`.`Client` (`idClient`, `nom`, `prenom`, `age`, `adresse`, `ville`, `mail`)
VALUES ('7', 'Marti', 'Pierre', '25', '4 av. Henri Paris', 'Paris', 'martin7@fiscali.fr');
INSERT INTO `magasin`.`Client` (`idClient`, `nom`, `prenom`, `age`, `adresse`, `ville`, `mail`)
VALUES ('8', 'Mac Neal', 'John', '52', '89 rue Diana', 'Lyon', 'mac@freez.fr');
INSERT INTO `magasin`.`Client` (`idClient`, `nom`, `prenom`, `age`, `adresse`, `ville`, `mail`)
VALUES ('9', 'Basile', 'Did', '37', '26 rue Gallas', 'Nantes', 'bas@walabi.com');
INSERT INTO `magasin`.`Client` (`idClient`, `nom`, `prenom`, `age`, `adresse`, `ville`, `mail`)
VALUES ('10', 'Darc', 'Jeanne', '19', '9 av. d’Orléans', 'Paris', 'NULL');
INSERT INTO `magasin`.`Client` (`idClient`, `nom`, `prenom`, `age`, `adresse`, `ville`, `mail`)
VALUES ('11', 'Gaté', 'Bill', '45', '9 bd des Bugs', 'Lyon', 'bill@microhard.be');

INSERT INTO `magasin`.`Commande` (`idCommande`, `date`, `idClient`) VALUES ('1', '2012-06-11', '5');
INSERT INTO `magasin`.`Commande` (`idCommande`, `date`, `idClient`) VALUES ('2', '2012-06-25', '9');
INSERT INTO `magasin`.`Commande` (`idCommande`, `date`, `idClient`) VALUES ('3', '2012-07-12', '1');
INSERT INTO `magasin`.`Commande` (`idCommande`, `date`, `idClient`) VALUES ('4', '2012-07-14', '3');
INSERT INTO `magasin`.`Commande` (`idCommande`, `date`, `idClient`) VALUES ('5', '2012-07-31', '9');
INSERT INTO `magasin`.`Commande` (`idCommande`, `date`, `idClient`) VALUES ('6', '2012-08-08', '10');
INSERT INTO `magasin`.`Commande` (`idCommande`, `date`, `idClient`) VALUES ('7', '2012-08-25', '2');
INSERT INTO `magasin`.`Commande` (`idCommande`, `date`, `idClient`) VALUES ('8', '2012-09-04', '7');
INSERT INTO `magasin`.`Commande` (`idCommande`, `date`, `idClient`) VALUES ('9', '2012-10-15', '11');
INSERT INTO `magasin`.`Commande` (`idCommande`, `date`, `idClient`) VALUES ('10', '2012-11-23', '4');
INSERT INTO `magasin`.`Commande` (`idCommande`, `date`, `idClient`) VALUES ('11', '2013-01-21', '8');
INSERT INTO `magasin`.`Commande` (`idCommande`, `date`, `idClient`) VALUES ('12', '2013-02-01', '5');
INSERT INTO `magasin`.`Commande` (`idCommande`, `date`, `idClient`) VALUES ('13', '2013-03-03', '9');

LOAD DATA INFILE 'article.txt'
INTO TABLE article
FIELDS TERMINATED BY ';'
ENCLOSED BY '"'
ESCAPED BY '\\'
LINES TERMINATED BY '\r\n';

LOAD DATA INFILE 'ligne.txt'
INTO TABLE ligne
FIELDS TERMINATED BY ';'
ENCLOSED BY '"'
ESCAPED BY '\\'
LINES TERMINATED BY '\r\n';

ALTER TABLE client ADD COLUMN specialite CHAR(1) NULL AFTER ville;



