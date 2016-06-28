CREATE PROCEDURE spInsertEmployee
	@LastName VARCHAR(50),
	@FirstName VARCHAR(50),
	@Birthday DATE,
	@PositionName VARCHAR(50),
	@Salary DECIMAL(15,2),
	@Sacked BIT,
	@LastModify DATETIME
AS
BEGIN
	BEGIN TRANSACTION T1
		IF EXISTS (
						SELECT * FROM Employee AS e INNER JOIN People AS p ON p.People_ID = e.People_ID
						WHERE p.LastName = @LastName AND p.FirstName = @FirstName AND p.Birthday = @Birthday  AND e.Sacked = 0	
		)
			BEGIN
				ROLLBACK TRANSACTION T1
			END
		ELSE
			BEGIN TRY
				INSERT INTO Employee
				(
					-- Employee_ID -- this column value is auto-generated
					People_ID,
					Position_ID,
					Salary,
					Sacked,
					LastModify
				)
				VALUES
				(
					(SELECT People_ID FROM People AS p WHERE p.LastName = @LastName AND p.FirstName = @FirstName AND p.Birthday = @Birthday),
					(SELECT p.Position_ID FROM Position AS p WHERE p.PositionName = @PositionName),
					CAST(@Salary AS DECIMAL(15,2)),
					CAST(@Sacked AS BIT),
					CAST(@LastModify AS DATETIME)
				)
				
				COMMIT TRANSACTION T1
			END TRY
			BEGIN CATCH
				ROLLBACK TRANSACTION T1
			END CATCH
END




CREATE PROCEDURE [dbo].[spInsertPeople]
	@FirstName VARCHAR(50),
	@LastName  VARCHAR(50),
	@Birthday  DATETIME
	--@Resault   VARCHAR(MAX) OUT
AS
BEGIN
	BEGIN TRANSACTION T1
		IF EXISTS (SELECT *FROM People WHERE People.FirstName = @FirstName AND People.LastName = @LastName)
		BEGIN
			--SET @Resault = 'Incorrect input row. The same row already exists in Schedule'
			--RETURN @Resault;
			ROLLBACK TRANSACTION T1
		END
	ELSE 
		BEGIN
			BEGIN TRY
				INSERT INTO People
				(
					-- People_ID -- this column value is auto-generated
					FirstName,
					LastName,
					Birthday
				)
				VALUES
				(
					@FirstName, @LastName, CAST(@Birthday AS DATE)
				)
				--SET @Resault = 'New row' + CAST((SELECT p.People_ID FROM People AS p 
				--                     WHERE p.FirstName = @FirstName AND p.LastName = @LastName AND p.Birthday = @Birthday) 
				--                     AS VARCHAR) + ' inserted!';
				COMMIT TRANSACTION T1 			
			END TRY
			BEGIN CATCH
				--SET @Resault = CAST((select	error_number() as errornumber) AS VARCHAR) + ': ' + CAST((SELECT error_message() as errormessage) AS VARCHAR)
				ROLLBACK TRANSACTION T1 			
			END CATCH
		END	
END


CREATE PROCEDURE spSackEmployee
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@Birthday DATE,
	@PositionName VARCHAR(50)
AS
BEGIN
	IF EXISTS (SELECT * FROM Employee AS e 
	INNER JOIN People AS p ON p.People_ID = e.People_ID 
	INNER JOIN Position AS p2 ON p2.Position_ID = e.Position_ID 
	           WHERE p.FirstName = @FirstName 
	           AND p.LastName = @LastName 
	           AND p.Birthday = @Birthday 
	           AND p2.PositionName = @PositionName 
	           AND e.Sacked = 0)
	BEGIN TRANSACTION T1
		BEGIN TRY
			UPDATE Employee SET Sacked = 1, LastModify = CAST(GETDATE() AS DATETIME) 
			WHERE People_ID IN (SELECT p.People_ID FROM People AS p WHERE p.FirstName = @FirstName AND p.LastName = @LastName AND p.Birthday = @Birthday) AND 
			Position_ID IN (SELECT p.Position_ID FROM Position AS p WHERE p.PositionName = @PositionName) AND 
			Sacked = 0
			
			COMMIT TRANSACTION T1
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION T1
		END CATCH								
END