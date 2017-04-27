

DROP PROCEDURE IF EXISTS SelectUser;
DELIMITER $$
CREATE PROCEDURE SelectUser (IN UserID INT)
LANGUAGE SQL  
NOT DETERMINISTIC  
CONTAINS SQL  
SQL SECURITY DEFINER  
BEGIN 

SELECT id, name, birthdate, address, username,type FROM User WHERE id = UserID;

END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS SelectAllUser;
DELIMITER $$
CREATE PROCEDURE SelectAllUser ()
LANGUAGE SQL  
NOT DETERMINISTIC  
CONTAINS SQL  
SQL SECURITY DEFINER  
BEGIN 
 
SELECT id, name, birthdate, address, username,type FROM User;

END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS UpdateUser;
DELIMITER $$
CREATE PROCEDURE UpdateUser (IN UserID INT, IN EmployeeName VARCHAR(45), IN UserBirthDate datetime, IN UserAddress VARCHAR(45), IN UserName VARCHAR(45), IN Password VARCHAR(45), IN UserType INT)
LANGUAGE SQL  
NOT DETERMINISTIC  
CONTAINS SQL  
SQL SECURITY DEFINER  
BEGIN 
 
UPDATE User SET  id = UserID, name = EmployeeName, birthdate = UserBirthDate, address = UserAddress, username =  UserName, password = Password,type = UserType
 WHERE id = UserID;
 
END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS InsertUser;
DELIMITER $$
CREATE PROCEDURE InsertUser (IN UserID INT, IN EmployeeName VARCHAR(45), IN UserBirthDate datetime, IN UserAddress VARCHAR(45), IN UserName VARCHAR(45), IN Password VARCHAR(45), IN UserType INT)
LANGUAGE SQL  
NOT DETERMINISTIC  
CONTAINS SQL  
SQL SECURITY DEFINER  
BEGIN 
 
INSERT INTO User VALUES (UserID, EmployeeName,UserBirthDate, UserAddress, UserName, Password,type);
 
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS DeleteUser;
DELIMITER $$
CREATE PROCEDURE DeleteUser (IN UserID INT)
LANGUAGE SQL  
NOT DETERMINISTIC  
CONTAINS SQL  
SQL SECURITY DEFINER  
BEGIN 
 
DELETE FROM User WHERE id = UserID;

END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS SelectProduct;
DELIMITER $$
CREATE PROCEDURE SelectProduct (IN ProductID INT, IN EmployeeID INT)
LANGUAGE SQL  
NOT DETERMINISTIC  
CONTAINS SQL  
SQL SECURITY DEFINER  
BEGIN 

INSERT INTO History VALUES (EmployeeID, now(), CONCAT('SELECT Product ', ProductID));

SELECT id, name, description, stock, price FROM Product WHERE id = ProductID;

END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS SelectAllProduct;
DELIMITER $$
CREATE PROCEDURE SelectAllProduct ( IN EmployeeID INT)
LANGUAGE SQL  
NOT DETERMINISTIC  
CONTAINS SQL  
SQL SECURITY DEFINER  
BEGIN 

INSERT INTO History VALUES (EmployeeID, now(), 'SELECT All Products');

SELECT id, name, description, stock, price FROM Product;

END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS UpdateProduct;
DELIMITER $$
CREATE PROCEDURE UpdateProduct (IN ProductID INT, IN ProductName VARCHAR(45), IN Description varchar(80), IN Stock INT, IN Price INT, IN EmployeeID INT)
LANGUAGE SQL  
NOT DETERMINISTIC  
CONTAINS SQL  
SQL SECURITY DEFINER  
BEGIN 

INSERT INTO History VALUES (EmployeeID, now(), CONCAT('UPDATE Product ', ProductID, '||', ProductName, '||',Description, '||', Stock,'||', Price));
 
UPDATE Product SET  id = ProductID, name = ProductName, description = Description, stock = Stock, price =  Price
 WHERE id = ProductID;

 
END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS InsertProduct;
DELIMITER $$
CREATE PROCEDURE InsertProduct (IN ProductID INT, IN ProductName VARCHAR(45), IN Description varchar(80), IN Stock INT, IN Price INT, IN EmployeeID INT)
LANGUAGE SQL  
NOT DETERMINISTIC  
CONTAINS SQL  
SQL SECURITY DEFINER  
BEGIN 
 
INSERT INTO History VALUES (EmployeeID, now(), CONCAT('INSERT Product ', ProductID, '||', ProductName, '||',Description, '||', Stock,'||', Price));
INSERT INTO Product VALUES (ProductID, ProductName, Description, Stock, Price, EmployeeID);
 
END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS DeleteProduct;
DELIMITER $$
CREATE PROCEDURE DeleteProduct (IN ProductID INT)
LANGUAGE SQL  
NOT DETERMINISTIC  
CONTAINS SQL  
SQL SECURITY DEFINER  
BEGIN 

INSERT INTO History VALUES (EmployeeID, now(), CONCAT('DELETE Product ', ProductID));
DELETE FROM Product WHERE id = ProductID;

END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS SelectOrder;
DELIMITER $$
CREATE PROCEDURE SelectOrder (IN OrderID INT, IN EmployeeID INT)
LANGUAGE SQL  
NOT DETERMINISTIC  
CONTAINS SQL  
SQL SECURITY DEFINER  
BEGIN 

INSERT INTO History VALUES (EmployeeID, now(), CONCAT('SELECT Order ', OrderID));

SELECT id, customername, shippingaddress, deliverydate, status, product_id, quantity FROM furniture.order WHERE id = OrderID;

END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS SelectAllOrder;
DELIMITER $$
CREATE PROCEDURE SelectAllOrder( IN EmployeeID INT)
LANGUAGE SQL  
NOT DETERMINISTIC  
CONTAINS SQL  
SQL SECURITY DEFINER  
BEGIN 

INSERT INTO History VALUES (EmployeeID, now(), 'SELECT All Orders');

SELECT id, customername, shippingaddress, deliverydate, status, product_id, quantity FROM furniture.Order;

END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS UpdateOrder;
DELIMITER $$
CREATE PROCEDURE UpdateOrder 
(IN OrderID INT, IN CustomerName VARCHAR(45), IN Shippingaddress varchar(80), IN Deliverydate DATETIME, IN Status VARCHAR(45), IN Productid INT, IN Quantity INT, IN EmployeeID INT)
LANGUAGE SQL  
NOT DETERMINISTIC  
CONTAINS SQL  
SQL SECURITY DEFINER  
BEGIN 

INSERT INTO History VALUES (EmployeeID, now(), CONCAT('UPDATE Order ', CustomerName, '||', Shippingaddress, '||',Deliverydate, '||', Status,'||', Productid,'||', Quantity));
 
UPDATE furniture.Order 
SET  id = OrderID, customername = CustomerName, shippingaddress = Shippingaddress, deliverydate = Deliverydate, status =  Status, product_id =Productid, quantity = Quantity
WHERE id = OrderID;

 
END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS InsertOrder;
DELIMITER $$
CREATE PROCEDURE InsertOrder 
(IN OrderID INT, IN CustomerName VARCHAR(45), IN Shippingaddress varchar(80), IN Deliverydate DATETIME, IN Status VARCHAR(45), IN Productid INT, IN Quantity INT, IN EmployeeID INT)
LANGUAGE SQL  
NOT DETERMINISTIC  
CONTAINS SQL  
SQL SECURITY DEFINER  
BEGIN 
 
INSERT INTO History VALUES (EmployeeID, now(), CONCAT('INSERT Order ', CustomerName, '||', Shippingaddress, '||',Deliverydate, '||', Status,'||', Productid,'||', Quantity));
INSERT INTO furniture.order VALUES (OrderID, CustomerName, Shippingaddress, Deliverydate, Status, Productid, Quantity);
 
END$$
DELIMITER ;

DROP PROCEDURE IF EXISTS DeleteOrder;
DELIMITER $$
CREATE PROCEDURE DeleteOrder (IN OrderID INT)
LANGUAGE SQL  
NOT DETERMINISTIC  
CONTAINS SQL  
SQL SECURITY DEFINER  
BEGIN 

INSERT INTO History VALUES (EmployeeID, now(), CONCAT('DELETE Order ', OrderID));
DELETE FROM furniture.order WHERE id = OrderID;

END$$
DELIMITER ;


DROP PROCEDURE IF EXISTS SelectHistory;
DELIMITER $$
CREATE PROCEDURE SelectHistory (IN EmployeeID INT, IN Startdate DATETIME, IN Enddate DATETIME)
LANGUAGE SQL  
NOT DETERMINISTIC  
CONTAINS SQL  
SQL SECURITY DEFINER  
BEGIN 

SELECT  employee_id, actiondate, action FROM History WHERE employee_id = EmployeeID AND actiondate BETWEEN Startdate AND Enddate;

END$$
DELIMITER ;