CREATE TABLE Items (
 Id INT IDENTITY PRIMARY KEY,
 ItemName VARCHAR(60),
 Quantity INT,
 Price FLOAT,
 PlaceFrom VARCHAR(100),


);

SELECT * FROM Items;

ALTER TABLE Items ADD TotalPrice AS Price * Quantity;

SELECT * FROM Items_Sum

UPDATE Items_Sum SET TotalSum = (SELECT SUM(TotalPrice) FROM Items);

CREATE TABLE Items_Sum(
Id INT IDENTITY PRIMARY KEY,
TotalSum FLOAT DEFAULT 0
);

