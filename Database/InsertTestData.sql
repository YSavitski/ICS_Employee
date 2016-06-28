USE ICSDB
GO

--INSERT INTO Position
--(
--	-- Position_ID -- this column value is auto-generated
--	PositionName
--)
--VALUES
--('Manager'), ('Bookkeeper'), ('Broker'), ('Cashier'), ('Clerk'), ('Consultant'), ('Dealer'), ('Economist')
--GO


--INSERT INTO People
--(
--	-- People_ID -- this column value is auto-generated
--	FirstName,
--	LastName,
--	Birthday
--)
--VALUES
--('Yauheni', 'Savitski', '1994-05-25'), ('Andrew', 'Parcheuski', '1994-04-17'), ('Aleksand', 'Kishkel', '1994-07-26'), ('Golovina', 'Ekaterina', '1994-08-26')
--GO

		
--INSERT INTO Employee
--(
--	 Employee_ID -- this column value is auto-generated
--	People_ID,
--	Position_ID,
--	Salary,
--	Sacked,
--	LastModify
--)
--VALUES
--(
--	(SELECT p.People_ID FROM People AS p WHERE p.FirstName='Golovina' AND p.LastName = 'Ekaterina'),
--	(SELECT p.Position_ID FROM Position AS p WHERE p.PositionName = 'Clerk'),
--	200,
--	0,
--	CAST(GETDATE() AS DATETIME)	
--),
--(
--	(SELECT p.People_ID FROM People AS p WHERE p.FirstName='Yauheni' AND p.LastName = 'Savitski'),
--	(SELECT p.Position_ID FROM Position AS p WHERE p.PositionName = 'Manager'),
--	452.77,
--	0,
--	CAST(GETDATE() AS DATETIME)	
--),
--(
--	(SELECT p.People_ID FROM People AS p WHERE p.FirstName='Aleksand' AND p.LastName = 'Kishkel'),
--	(SELECT p.Position_ID FROM Position AS p WHERE p.PositionName = 'Economist'),
--	CAST((5870000/20193) AS DECIMAL(15,2)),
--	0,
--	CAST(GETDATE() AS DATETIME)		
--)


--INSERT INTO Employee
--(
--	-- Employee_ID -- this column value is auto-generated
--	People_ID,
--	Position_ID,
--	Salary,
--	LastModify
--)
--VALUES
--(
--	(SELECT p.People_ID FROM People AS p WHERE p.FirstName='Andrew' AND p.LastName = 'Parcheuski'),
--	(SELECT p.Position_ID FROM Position AS p WHERE p.PositionName = 'Manager'),
--	550,
--	CAST(GETDATE() AS DATETIME)
--)