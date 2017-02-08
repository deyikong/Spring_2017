--UPDATE

SELECT Id, FirstName, LastName, Email
FROM dbo.Customer
WHERE Id = 6

UPDATE dbo.Customer
--Set name value pair separated by ,
SET LastName = 'Trump', FirstName = 'Tom2' --Changed from 'Obama'
WHERE Id = 6 --OR 1 = 1 -- C# if(true) 1=1 1==1

--C#, 
--String lastName;
--lastName = "trump";


--String lastName = "trump"
--SQL,
DECLARE @LastName VARCHAR(25)
SET @LastName = 'Trump';

--in Ad-hoc query, variables are local variable similar to C# local variable.


--DECLARE @LastName VARCHAR(25) = 'Trump';

DECLARE @FirstName VARCHAR(25) = 'Hilary';

--DECLARE @FirstName2 VARCHAR(25) = 'Hilary', @LastName2 VARCHAR(25) = 'Cliton'
 
--Value is flexible, you can assign variable to a column
UPDATE dbo.Customer
SET LastName = @LastName
WHERE Id = 6

--Reverse works too. A little bit hard for you. Just FYI.
UPDATE dbo.Customer
SET @LastName = LastName
WHERE Id = 6

--[LAPTOP-E4GLUAC2\HELLOWARE].[ShoppingCart].[dbo].[Customer]


--DELETE
DELETE [dbo].[Customer]
WHERE Id = 11


UPDATE dbo.Customer
SET FirstName = @firstName, LastName = @lastName
WHERE Id = @id

SELECT Id, FirstName, LastName, Email
FROM dbo.Customer
WHERE Id = 9