--Sample data for dbo.Customer
INSERT INTO dbo.Customer (FirstName, LastName, Email, UserName, Password, Phone)
VALUES ('Kathy', 'Smith', 'KathyS@gmail.com', 'KathyS', 'DummyPwd1!', '713-965-8520')

DECLARE @Count int = 0;
DECLARE @PostFix VARCHAR(15);

WHILE @Count < 100
BEGIN
	SET @PostFix = CONVERT(VARCHAR(15), @Count);

	INSERT INTO dbo.Customer (FirstName, LastName, Email, UserName, Password, Phone)
	VALUES ('Kathy' + @PostFix, 'Smith' + @PostFix, 'KathyS' + @PostFix + '@gmail.com', 'KathyS' + @PostFix, 'DummyPwd1!', '713-965-8520')

	SET @Count = @Count + 1;
END

UPDATE dbo.Customer
SET FirstName = REPLACE(FirstName, 'Kathy', 'Linda')
WHERE Id % 2 = 1

UPDATE dbo.Customer
SET LastName = REPLACE(LastName, 'Smith', 'Obama')
WHERE Id % 2 = 0


--SELECT * FROM [dbo].[Customer]

INSERT INTO dbo.MyOrder (GrandTotal, OrderDate, CustomerId, Status)
VALUES (0, '02/04/2017', 9, 'Delivered')

INSERT INTO dbo.MyOrder (GrandTotal, OrderDate, CustomerId, Status)
VALUES (10.99, '02/05/2017', 10, 'Confirmed')
