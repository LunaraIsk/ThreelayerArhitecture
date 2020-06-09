SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE AddUser
    @FirstName nvarchar(15),
	@LastName nvarchar(15),
	@DateOfBirth Date,
	@Age int
AS
BEGIN
		INSERT INTO Users(FirstName, LastName, DateOfBirth, Age)
		VALUES(@FirstName, @LastName, @DateOfBirth, @Age)

		SELECT @@IDENTITY;
END
GO

