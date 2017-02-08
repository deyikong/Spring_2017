--SELECT CALUSE/SELECT LIST, SCHEMA . TABLE Name . Column Name
SELECT 
	--[dbo].[Product].Id, 
	Prod.Id,
	[Name] AS [ProductName]--, --Give a column alias ProductName as necessary
	--'This is hard coded column' AS DemoHardCoded,
	--[Description], --[] Convert reservered keyword to regular
	--UnitPrice, 
	--UnitOfMeasure, 
	--Prod.IsActive, 
	--Picture, 
	--Prod.CreatedDate, 
	--CreatedBy,
	--C.FirstName
FROM [dbo].[Product] AS Prod--, [dbo].[Customer] AS C
WHERE Id = 3


--C# logic operator, &&, ||, ==, >, >=, <, <=, !=
--SQL logic operator, AND, OR, =, >, >=, <, <=, <>, IS NULL, IS NOT NULL, LIKE, BETWEEN, IN, NOT
SELECT Id, FirstName, LastName, Email, UserName, Password, Phone, IsActive, CreatedDate
FROM [dbo].[Customer]
WHERE FirstName LIKE 'Kathy%' AND Id >= 100

--LIKE, Can only be used for String, VARCHAR, CHAR, etc.
--%VALUE%, %Value, VALUE%
SELECT Id, FirstName, LastName, Email, UserName, Password, Phone, IsActive, CreatedDate
FROM [dbo].[Customer]
WHERE FirstName LIKE 'kathy%'


SELECT Id, FirstName, LastName, Email, UserName, Password, Phone, IsActive, CreatedDate
FROM [dbo].[Customer]
WHERE FirstName LIKE 'Kathy%' OR Id > 100

--IN
SELECT Id, FirstName, LastName, Email, UserName, Password, Phone, IsActive, CreatedDate
FROM [dbo].[Customer]
WHERE Id IN (100, 120, 130)

--IN equals to OR
SELECT Id, FirstName, LastName, Email, UserName, Password, Phone, IsActive, CreatedDate
FROM [dbo].[Customer]
WHERE Id = 100 OR Id = 120 OR Id = 130

--BETWEEN
SELECT Id, FirstName, LastName, Email, UserName, Password, Phone, IsActive, CreatedDate
FROM [dbo].[Customer]
WHERE Id BETWEEN 100 AND 105

--BETWEEN equals to >= and <=
SELECT Id, FirstName, LastName, Email, UserName, Password, Phone, IsActive, CreatedDate
FROM [dbo].[Customer]
WHERE Id >= 100 AND Id <= 105

--ORDER BY caluse, ASC--DEFAULT, DESC
SELECT Id, FirstName, LastName, Email, UserName, Password, Phone, IsActive, CreatedDate
FROM [dbo].[Customer]
WHERE FirstName LIKE 'kathy%'
ORDER BY Id DESC


SELECT Id, FirstName, LastName, Email, UserName, Password, Phone, IsActive, CreatedDate
FROM [dbo].[Customer]
WHERE FirstName LIKE 'kathy%'
ORDER BY FirstName, LastName DESC

--DISTINCT
SELECT DISTINCT Password
FROM [dbo].[Customer]

--TOP
SELECT TOP 10 Id
FROM [dbo].[Customer]




SELECT Id, FirstName, LastName, Email, UserName, Password, Phone, IsActive, CreatedDate
FROM [dbo].[Customer]
WHERE FirstName LIKE 'Kathy%'















SELECT FirstName, LastName, [LastName] + ', ' + [FirstName] AS FullName
FROM [dbo].[Customer]



--SELECT * FROM [dbo].[MyOrder]

