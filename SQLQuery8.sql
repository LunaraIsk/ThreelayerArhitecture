SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE DeleteUser
    @IdUser int
AS
BEGIN
	Delete from [UsersAwards].[dbo].[Users] where IdUser = @IdUser
END
GO

