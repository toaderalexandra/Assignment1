-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';


-- -----------------------------------------------------
-- Schema furniture
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `furniture` DEFAULT CHARACTER SET utf8 ;
USE `furniture` ;

-- -----------------------------------------------------
-- Table `furniture`.`User`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `furniture`.`User` (
  `id` INT NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  `birthdate` datetime,
  `address` VARCHAR(45) NOT NULL,
  `username` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `type` INT NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `furniture`.`Product`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `furniture`.`Product` (
  `id` INT NOT NULL,
  `name` VARCHAR(45) NOT NULL,
  `description` VARCHAR(80) NOT NULL,
  `stock` INT NOT NULL,
  `price` INT NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `furniture`.`Order`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `furniture`.`Order` (
  `id` INT NOT NULL,
  `customername` VARCHAR(45) NOT NULL,
  `shippingaddress` VARCHAR(80) NOT NULL,
  `deliverydate` datetime,
  `status` VARCHAR(45) NOT NULL, 
  `product_id` INT NOT NULL,
  `quantity` INT NOT NULL,
CONSTRAINT `fk_Order_has_Product`
    FOREIGN KEY (`product_id`)
    REFERENCES `furniture`.`Product` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
    ,  PRIMARY KEY (`id`))
ENGINE = InnoDB;
-- -----------------------------------------------------
-- Table `furniture`.`History`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `furniture`.`History` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `employee_id` INT NOT NULL,
  `actiondate` datetime,
  `action` VARCHAR(200) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
