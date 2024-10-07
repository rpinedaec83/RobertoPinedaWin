create database RobertoPineda;

use RobertoPineda;

CREATE TABLE Products (
  ProductId INT IDENTITY(1,1) PRIMARY KEY,
  ProductName VARCHAR(100) NOT NULL,
  UnitPrice DECIMAL NOT NULL,
  StockQuantity INT NOT NULL,
  SupplierName VARCHAR(50),
  Weight DECIMAL,
);

INSERT INTO Products (ProductName, UnitPrice, StockQuantity, SupplierName, Weight)
VALUES
  ('Product1', 29.99, 100, 'SupplierA', 1.5),
  ('Product2', 19.99, 150, 'SupplierB', 2.0),
  ('Product3', 39.99, 80, 'SupplierC', 1.2),
  ('Product4', 49.99, 120, 'SupplierA', 1.8),
  ('Product5', 14.99, 200, 'SupplierB', 1.0);