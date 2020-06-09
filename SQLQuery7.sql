SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE GetAllUsers
AS
BEGIN
	SELECT S.IdUser, 
	   S.FirstName,
	   S.LastName,
	   S.DateOfBirth,
	   S.Age 
		FROM dbo.Users S
END
GO
