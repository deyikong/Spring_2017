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


