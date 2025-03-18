DROP DATABASE IF EXISTS ANGERSCOOT;

CREATE DATABASE IF NOT EXISTS ANGERSCOOT;
USE ANGERSCOOT;
# -----------------------------------------------------------------------------
#       TABLE : DATEINCIDENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DATEINCIDENT
 (
   DATEINCIDENT DATE NOT NULL  
   , PRIMARY KEY (DATEINCIDENT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : LIGNEDEPAIE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS LIGNEDEPAIE
 (
   IDLIGNEDEPAIE CHAR(32) NOT NULL  ,
   IDFICHEDEPAIE INTEGER NOT NULL  ,
   LIBLIGNEDEPAIE CHAR(32) NULL  ,
   NBCHARGELIGNEPAIE INTEGER NULL  ,
   PRIXLIGNEPAIE DECIMAL(10,2) NULL  
   , PRIMARY KEY (IDLIGNEDEPAIE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE LIGNEDEPAIE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_LIGNEDEPAIE_FICHEDEPAIE
     ON LIGNEDEPAIE (IDFICHEDEPAIE ASC);

# -----------------------------------------------------------------------------
#       TABLE : DISPONIBILITE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DISPONIBILITE
 (
   IDDISPO INTEGER NOT NULL  ,
   LIBDISPO CHAR(32) NULL  
   , PRIMARY KEY (IDDISPO) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : PUISSANCE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PUISSANCE
 (
   IDPUISSANCE INTEGER NOT NULL  ,
   LIBELPUISSANCE CHAR(32) NULL  
   , PRIMARY KEY (IDPUISSANCE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : DATERECHARGE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DATERECHARGE
 (
   DATERECHARGE DATE NOT NULL  
   , PRIMARY KEY (DATERECHARGE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : UTILISATEUR
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS UTILISATEUR
 (
   IDUTIL INTEGER NOT NULL  ,
   NOMUTIL CHAR(32) NOT NULL  ,
   PRENOMUTIL CHAR(32) NOT NULL  ,
   MAILUTIL CHAR(32) NOT NULL  ,
   MDPUTIL VARCHAR(255) NOT NULL  ,
   ADRUTIL CHAR(32) NULL  ,
   DOCUTIL CHAR(32) NULL  ,
   RUEUTIL CHAR(32) NULL  ,
   CPUTIL INTEGER NULL  ,
   VILLEUTIL CHAR(32) NULL  ,
   ACTIFUTIL BOOL NULL  ,
   LOGINUTIL CHAR(32) NOT NULL  ,
   ADMINUTIL BOOL NULL  ,
   VALIDUTIL BOOL NULL  
   , PRIMARY KEY (IDUTIL) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : FICHEDEPAIE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS FICHEDEPAIE
 (
   IDFICHEDEPAIE INTEGER NOT NULL  ,
   IDUTIL INTEGER NOT NULL  ,
   DATEFDEPAIE DATE NULL  ,
   DATEPERIODEDFICHE DATE NULL  ,
   DATEPERIODEFFICHE DATE NULL  ,
   NOMPRENOMFICHE CHAR(32) NULL  ,
   ADRESSECHARGEURFICHE CHAR(32) NULL  
   , PRIMARY KEY (IDFICHEDEPAIE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE FICHEDEPAIE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_FICHEDEPAIE_UTILISATEUR
     ON FICHEDEPAIE (IDUTIL ASC);

# -----------------------------------------------------------------------------
#       TABLE : TYPEVEHICULE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TYPEVEHICULE
 (
   IDVEHICULE INTEGER NOT NULL  ,
   IDFORFAIT INTEGER NOT NULL  ,
   LIBTYPEVEHICULE CHAR(32) NULL  
   , PRIMARY KEY (IDVEHICULE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE TYPEVEHICULE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_TYPEVEHICULE_FORFAIT
     ON TYPEVEHICULE (IDFORFAIT ASC);

# -----------------------------------------------------------------------------
#       TABLE : VEHICULE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS VEHICULE
 (
   IMMATVEHICULE CHAR(32) NOT NULL  ,
   IDDISPO INTEGER NOT NULL  ,
   IDVEHICULE INTEGER NOT NULL  ,
   IDPUISSANCE INTEGER NOT NULL  ,
   DATEMISEENSERVICE DATE NOT NULL  ,
   DATEREVISION DATE NULL  
   , PRIMARY KEY (IMMATVEHICULE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE VEHICULE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_VEHICULE_DISPONIBILITE
     ON VEHICULE (IDDISPO ASC);

CREATE  INDEX I_FK_VEHICULE_TYPEVEHICULE
     ON VEHICULE (IDVEHICULE ASC);

CREATE  INDEX I_FK_VEHICULE_PUISSANCE
     ON VEHICULE (IDPUISSANCE ASC);

# -----------------------------------------------------------------------------
#       TABLE : FORFAIT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS FORFAIT
 (
   IDFORFAIT INTEGER NOT NULL  ,
   LIBFORFAIT CHAR(32) NOT NULL  ,
   PRIXFORFAIT DECIMAL(13,2) NOT NULL  
   , PRIMARY KEY (IDFORFAIT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : SIGNALER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS SIGNALER
 (
   IDUTIL INTEGER NOT NULL  ,
   DATEINCIDENT DATE NOT NULL  ,
   IMMATVEHICULE CHAR(32) NOT NULL  ,
   DESCINCIDENT DATE NULL  
   , PRIMARY KEY (IDUTIL,DATEINCIDENT,IMMATVEHICULE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE SIGNALER
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_SIGNALER_UTILISATEUR
     ON SIGNALER (IDUTIL ASC);

CREATE  INDEX I_FK_SIGNALER_DATEINCIDENT
     ON SIGNALER (DATEINCIDENT ASC);

CREATE  INDEX I_FK_SIGNALER_VEHICULE
     ON SIGNALER (IMMATVEHICULE ASC);

# -----------------------------------------------------------------------------
#       TABLE : RECHARGER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS RECHARGER
 (
   IMMATVEHICULE CHAR(32) NOT NULL  ,
   IDUTIL INTEGER NOT NULL  ,
   DATERECHARGE DATE NOT NULL  
   , PRIMARY KEY (IMMATVEHICULE,IDUTIL,DATERECHARGE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE RECHARGER
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_RECHARGER_VEHICULE
     ON RECHARGER (IMMATVEHICULE ASC);

CREATE  INDEX I_FK_RECHARGER_UTILISATEUR
     ON RECHARGER (IDUTIL ASC);

CREATE  INDEX I_FK_RECHARGER_DATERECHARGE
     ON RECHARGER (DATERECHARGE ASC);


# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE LIGNEDEPAIE 
  ADD FOREIGN KEY FK_LIGNEDEPAIE_FICHEDEPAIE (IDFICHEDEPAIE)
      REFERENCES FICHEDEPAIE (IDFICHEDEPAIE) ;


ALTER TABLE FICHEDEPAIE 
  ADD FOREIGN KEY FK_FICHEDEPAIE_UTILISATEUR (IDUTIL)
      REFERENCES UTILISATEUR (IDUTIL) ;


ALTER TABLE TYPEVEHICULE 
  ADD FOREIGN KEY FK_TYPEVEHICULE_FORFAIT (IDFORFAIT)
      REFERENCES FORFAIT (IDFORFAIT) ;


ALTER TABLE VEHICULE 
  ADD FOREIGN KEY FK_VEHICULE_DISPONIBILITE (IDDISPO)
      REFERENCES DISPONIBILITE (IDDISPO) ;


ALTER TABLE VEHICULE 
  ADD FOREIGN KEY FK_VEHICULE_TYPEVEHICULE (IDVEHICULE)
      REFERENCES TYPEVEHICULE (IDVEHICULE) ;


ALTER TABLE VEHICULE 
  ADD FOREIGN KEY FK_VEHICULE_PUISSANCE (IDPUISSANCE)
      REFERENCES PUISSANCE (IDPUISSANCE) ;


ALTER TABLE SIGNALER 
  ADD FOREIGN KEY FK_SIGNALER_UTILISATEUR (IDUTIL)
      REFERENCES UTILISATEUR (IDUTIL) ;


ALTER TABLE SIGNALER 
  ADD FOREIGN KEY FK_SIGNALER_DATEINCIDENT (DATEINCIDENT)
      REFERENCES DATEINCIDENT (DATEINCIDENT) ;


ALTER TABLE SIGNALER 
  ADD FOREIGN KEY FK_SIGNALER_VEHICULE (IMMATVEHICULE)
      REFERENCES VEHICULE (IMMATVEHICULE) ;


ALTER TABLE RECHARGER 
  ADD FOREIGN KEY FK_RECHARGER_VEHICULE (IMMATVEHICULE)
      REFERENCES VEHICULE (IMMATVEHICULE) ;


ALTER TABLE RECHARGER 
  ADD FOREIGN KEY FK_RECHARGER_UTILISATEUR (IDUTIL)
      REFERENCES UTILISATEUR (IDUTIL) ;


ALTER TABLE RECHARGER 
  ADD FOREIGN KEY FK_RECHARGER_DATERECHARGE (DATERECHARGE)
      REFERENCES DATERECHARGE (DATERECHARGE) ;

