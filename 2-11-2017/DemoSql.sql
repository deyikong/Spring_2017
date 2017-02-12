--JOIN
SELECT * FROM dbo.DemoA --3 rows
SELECT * FROM dbo.DemoB -- 5 rows with 3 has references to A (2)

--INNER
SELECT *
FROM dbo.DemoA INNER JOIN dbo.DemoB ON
	dbo.DemoA.Id = dbo.DemoB.DemoAId

--ALIAS demo
SELECT A.Id, B.Id, A.FirstName--dbo.DemoA.FirstName
FROM dbo.DemoA AS A INNER JOIN dbo.DemoB AS B ON
	A.Id = B.DemoAId

--Old syntax INNER
SELECT *
FROM dbo.DemoA, dbo.DemoB
WHERE	dbo.DemoA.Id = dbo.DemoB.DemoAId

--RIGHT
SELECT *
FROM dbo.DemoA RIGHT JOIN dbo.DemoB ON
	dbo.DemoA.Id = dbo.DemoB.DemoAId

--Old syntax RIGHT OUTTER JOIN
--SELECT *
--FROM dbo.DemoA, dbo.DemoB
--WHERE	dbo.DemoA.Id = dbo.DemoB.DemoAId OR dbo.DemoB.DemoAId IS NULL

--LEFT
SELECT *
FROM dbo.DemoA LEFT JOIN dbo.DemoB ON
	dbo.DemoA.Id = dbo.DemoB.DemoAId
--WHERE dbo.DemoA.Id = 1

--CROSS
SELECT *
FROM dbo.DemoA CROSS JOIN dbo.DemoB

--Old syntax
SELECT *
FROM dbo.DemoA, dbo.DemoB

SELECT *
FROM [dbo].[Address]
WHERE [CustomerId] = @CustomerId

--Function
--Get how many orders a customer placed.
SELECT * FROM [dbo].[MyOrder] WHERE CustomerId = 9

SELECT COUNT(*) FROM [dbo].[MyOrder] WHERE CustomerId = 9

--COUNT() built in SQL Server function.

SELECT LastName, UPPER(LastName) FROM dbo.Customer

SELECT *
FROM [dbo].[Customer] JOIN [dbo].[MyOrder] ON -- ON key, similar to WHERE
		[dbo].[Customer].Id = [dbo].[MyOrder].[CustomerId] --JOIN condition
	--JOIN [dbo].[MyShoppingCart] ON
	--	[dbo].[Customer].Id = [dbo].[MyShoppingCart].CustomerId
--WHERE dbo.MyOrder.CustomerId = 9
WHERE dbo.Customer.Id = 9
ORDER BY dbo.MyOrder.CreatedDate DESC

--1:N, INNER/OUT JOIN
SELECT * FROM dbo.Customer
--209 Customer, 3 orders
SELECT *
FROM [dbo].[Customer] INNER JOIN [dbo].[MyOrder] ON --INNER is option to JOIN
		[dbo].[Customer].Id = [dbo].[MyOrder].[CustomerId] 

SELECT *
FROM [dbo].[Customer] JOIN [dbo].[MyOrder] ON --INNER is option to JOIN
		[dbo].[Customer].Id = [dbo].[MyOrder].[CustomerId] 


SELECT *
FROM [dbo].[Customer] LEFT OUTER JOIN [dbo].[MyOrder] ON --OUTER is optional
		[dbo].[Customer].Id = [dbo].[MyOrder].[CustomerId] 

SELECT COUNT(*) FROM dbo.Customer --204
SELECT COUNT(*) FROM dbo.MyOrder --3

--204 * 3
SELECT *
FROM dbo.Customer CROSS JOIN dbo.MyOrder




--Function & SP
--CALL SP
EXEC [dbo].[usp_Customer_Insert] @First, @LastName,

--EXECUTE

--CREATE PROCEDURE
--CREATE PROC
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	Unnecessary demo function
-- =============================================
CREATE FUNCTION dbo.udf_GetCurrentDate
(
)
RETURNS DATETIME
AS
BEGIN
	
	RETURN GETDATE()

END
GO


--CALL FUNCTION, Must have ()
--FUNCTION must be within a SQL, cannot be independently

SELECT [dbo].[udf_GetCurrentDate] ()

--CALL FUNCTION FROM SELECT CALUSE or WHEERE

SELECT * FROM [dbo].[MyOrder]

SELECT SUM([GrandTotal]) AS GrandTotal, MAX([GrandTotal]) , AVG([GrandTotal])
FROM [dbo].[MyOrder]
--WHERE OrderDate > '2017-02-04 00:00:00.000'


SELECT Day(GETDATE()), GETDATE(), PI()


--Aggregate function, GROUP BY, HAVING
SELECT * FROM dbo.Department

SELECT * FROM dbo.Employee

--Give me a salary cost report per dept
SELECT 
		D.Id, 
		D.Name, 
		SUM(ISNULL(E.Salary, 0)) AS GrandTotal, 
		AVG(E.Salary) AS AvgSalary, 
		COUNT(*) AS NumberOfEmployees
FROM [dbo].[Department] AS D LEFT JOIN [dbo].[Employee] AS E ON
	D.Id = E.DeptId
GROUP BY D.Id, D.Name
HAVING SUM(ISNULL(E.Salary, 0)) < 100250.00

--ISNULL(a = b ? a = b : 'replacement' )
--C# IF ELSE, a == b ? "yes" : "no"

-- JOIN,  ON
--SELECT, WHERE
--GROUP BY, HAVING