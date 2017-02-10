
INSERT [dbo].[Customer] ([Id], [FirstName], [LastName], [Email], [UserName], [Password], [Phone], [IsActive], [CreatedDate]) 
VALUES (5, N'Shawn', N'Shi', N'shawnshi@yahoo.com', N'ShawnShi', N'abc123', N'713-789-9632', 1, CAST(N'2017-02-04T15:53:12.367' AS DateTime))


--C# String
--String firstName = @"Shawn"; //"Shawn"
--SQL
DECLARE @FirstName VARCHAR(25) = N'Shawn' -- 'Shawn'



--INSERT INTO Prod

SELECT * FROM [dbo].[Product]

--Msg 544, Level 16, State 1, Line 17
--Cannot insert explicit value for identity column in table 'Product' when IDENTITY_INSERT is set to OFF.
INSERT [dbo].[Product] (Id, Name, Description, UnitPrice, UnitOfMeasure, IsActive, Picture, CreatedDate, CreatedBy)
VALUES (5, N'Spicy Chicken', N'', 2.99, 'Dish', 1, NULL, GETDATE(), NULL)


INSERT [dbo].[Product] (Name, Description, UnitPrice, UnitOfMeasure, IsActive, Picture, CreatedDate, CreatedBy)
VALUES (N'Spicy Chicken', N'', 2.99, 'Dish', 1, NULL, GETDATE(), NULL)

INSERT [dbo].[Product] (Name)
VALUES (N'Spicy Chicken2')

--SELECT GETDATE()

UPDATE [dbo].[Product]
SET Description = 'delicious'
WHERE Id = 6 OR Id = 7
--WHERE Id IN (6, 7)

INSERT [dbo].[Product] (Name, IsActive)
VALUES (N'Spicy Chicken3', 0)

SELECT @@IDENTITY

--EXECUTE OR EXEC a SP
EXEC [dbo].[usp_Customer_Insert] 'Bob', 'Cliton', 'BobC@yahoo.com', 'BobC', 'MyPassword1', '713-987-9512', 0


SELECT * FROM [dbo].[Customer] ORDER BY Id DESC

SELECT TOP 10 * FROM [dbo].[Customer] ORDER BY Id DESC