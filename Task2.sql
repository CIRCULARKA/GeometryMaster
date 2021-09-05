CREATE DATABASE ProductsDb;

USE ProductsDb;

CREATE TABLE Product
(
	ID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(30) NOT NULL UNIQUE
);

CREATE TABLE Category
(
	ID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(20) NOT NULL UNIQUE
);

INSERT Product
	VALUES ('Pencil'),
	('Birck'),
	('Gun');

INSERT Category
	VALUES ('None'),
	('Build materials'),
	('Chancellary');

CREATE TABLE ProductsCategories
(
	ProductID INT NOT NULL,
	CategoryID INT NOT NULL,
	PRIMARY KEY (ProductID, CategoryID),
	FOREIGN KEY (ProductID) REFERENCES Product (ID),
	FOREIGN KEY (CategoryID) REFERENCES Category (ID)
);

INSERT ProductsCategories
	VALUES (3, 1),
	(2, 2),
	(1, 3);

SELECT Product.Name, Category.Name FROM ProductsCategories
	INNER JOIN Product ON ProductsCategories.ProductID = Product.ID
	INNER JOIN Category ON ProductsCategories.CategoryID = Category.ID;
