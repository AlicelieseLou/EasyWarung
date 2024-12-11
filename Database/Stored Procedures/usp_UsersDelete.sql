SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_UsersDelete
	@user_id		NVARCHAR(25)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE
		Users
    SET
		user_status = 0
    WHERE
		user_id = @user_id
END
GO