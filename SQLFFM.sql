CREATE DATABASE FastFood
GO
USE FastFood
GO
SET DATEFORMAT DMY
GO

CREATE TABLE PRODUCTS
(
  ProductID VARCHAR(50) NOT NULL PRIMARY KEY,
  ProductName NVARCHAR(50) NOT NULL,
  ProductType NVARCHAR(50) NOT NULL,
  ProductPrice INT NOT NULL,
  Stock SMALLINT NOT NULL,
  Descriptions NVARCHAR(MAX),
  ProductImage Image,
)
GO
CREATE TABLE CUSTOMERS
(
 CustomerID VARCHAR(50) PRIMARY KEY NOT NULL,
 Fullname NVARCHAR(100) NOT NULL,
 Phone NVARCHAR(25) NOT NULL,
 Sex CHAR(1) NOT NULL, -- F=FEMALE, M=MALE
 Points INT,
 Level TINYINT,
 )
 GO

 CREATE TABLE STAFF
(
	ID VARCHAR(50) PRIMARY KEY NOT NULL,
	FullName NVARCHAR(100) NOT NULL,
	Sex NVARCHAR(10) NOT NULL,
	DoB VARCHAR(10) NOT NULL,
	Position NVARCHAR(30) NOT NULL,
	Phone VARCHAR(100) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	Addr NVARCHAR(100) NOT NULL,
	Avatar IMAGE,
)
GO

CREATE TABLE ACCOUNT
(
	UserName NVARCHAR(100) PRIMARY KEY NOT NULL,
	Pass NVARCHAR(100) NOT NULL,
	FullName NVARCHAR(100) NOT NULL,
	Sex NVARCHAR(10) NOT NULL,
	DoB VARCHAR(10) NOT NULL,
	Phone VARCHAR(100) NOT NULL,
	Email NVARCHAR(100) NOT NULL,
	Addr NVARCHAR(100) NOT NULL,
	Auth INT NOT NULL, -- 0=Admin, 1=Staff
)
GO

CREATE TABLE ORDERS
(
  OrderID VARCHAR(50) PRIMARY KEY NOT NULL,
  ProductID VARCHAR(50) NOT NULL,
  ProductName NVARCHAR(50) NOT NULL,
  Quantity TINYINT NOT NULL,
  UnitPrice INT NOT NULL,
  Discount FLOAT NOT NULL,
  Total INT,
)
GO
CREATE TABLE BILL
(
	BillNumber INT identity PRIMARY KEY NOT NULL,
	BillDate VARCHAR(10) NOT NULL,
	Total INT NOT NULL,
	OrderID VARCHAR(50) NOT NULL,
	StaffID VARCHAR(50) NOT NULL,
	CustomerID VARCHAR(50) NOT NULL,
	Discount float,
	FOREIGN KEY (OrderID) REFERENCES  ORDERS(OrderID),
)
GO
CREATE TABLE IMPORT
(
  TicketID VARCHAR(50) primary key NOT NULL,
  AdminID NVARCHAR(50) NOT NULL,
  ImportDate VARCHAR(10) NOT NULL,
  Name NVARCHAR(100) NOT NULL,
  UnitPrice INT NOT NULL,
  Quantity INT NOT NULL,
)
GO