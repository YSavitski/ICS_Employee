CREATE DATABASE ICSDB
   ON
   ( 
   	NAME = 'ICSDB',
   	FILENAME = 'F:\SQL\Databases\ICS\ICSDB.mdf',
   	SIZE = 10MB,
   	MAXSIZE = 100MB,
   	FILEGROWTH = 10MB
   )
   LOG ON 
   (
   	NAME = 'LogICSDB',
   	FILENAME = 'F:\SQL\Databases\ICS\LogICSDB.ldf',
   	SIZE = 5MB,
   	MAXSIZE = 50MB,
   	FILEGROWTH = 5MB
   )
GO
   
USE ICSDB
GO


CREATE TABLE People 
(	
	People_ID INT NOT NULL IDENTITY(1000001, 1) PRIMARY KEY,
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	Birthday DATE NOT NULL
	
	UNIQUE (FirstName, LastName, Birthday)	
)


CREATE TABLE Employee 
(
	Employee_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	People_ID INT NOT NULL FOREIGN KEY REFERENCES People(People_ID),
	Position_ID INT FOREIGN KEY REFERENCES Position(Position_ID),
	Salary DECIMAL(15,2),
	Sacked BIT NOT NULL DEFAULT 0,
	LastModify DATETIME NOT NULL
	
	UNIQUE(People_ID, Position_ID, Sacked)	
)

CREATE TABLE Position
(
	Position_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	PositionName VARCHAR(30) NOT NULL UNIQUE		
)
   

CREATE VIEW vwEmployeeInfo_v1 AS 
								SELECT p.LastName, p.FirstName, p2.PositionName, p.Birthday, e.Salary
								  FROM People AS p 
								  INNER JOIN Employee AS e ON e.People_ID = p.People_ID 
								  INNER JOIN Position AS p2 ON p2.Position_ID = e.Position_ID
								WHERE e.Sacked = 0 AND e.Salary IS NOT NULL
GO

CREATE VIEW vwReportAVGSalaryByPosition AS
	SELECT p.PositionName, AVG(e.Salary) AS Salary_AVG  FROM Position AS p 
	INNER JOIN Employee AS e ON e.Position_ID = p.Position_ID 
	WHERE e.Sacked = 0
	GROUP BY p.PositionName
GO