/*
This is demo
We will demo SQL syntax
*/

SELECT Email FROM [dbo].[Customer] WHERE FirstName LIKE '%sh%'

seLECT * FROM [Customer]

SELECT Id, FirstName, LastName, Email, UserName, Password, Phone, IsActive, CreatedDate
FROM [dbo].[Customer]


DELETE [dbo].[Customer] WHERE FirstName = 'Shawn'

--SCHEMA + . + TABLE name

--COMMENTS:--C#, // /* */
--SQL: --, inline comment, /* */ mutiple line comments