SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_UsersUpdate
	@user_id		NVARCHAR(25),
	@user_name		NVARCHAR(250),
	@user_address	NVARCHAR(250),
	@user_email		NVARCHAR(250),
	@user_phone		NVARCHAR(250),
	@user_role		INT,
	@user_username	NVARCHAR(50),
	@user_password	NVARCHAR(MAX),
	@user_image		IMAGE
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE
		Users
    SET
		user_name = @user_name,
		user_address = @user_address,
		user_email = @user_email,
		user_phone = @user_phone,
		user_role = @user_role,
		user_username = @user_username,
		user_password = @user_password,
		user_image = @user_image
    WHERE
		user_id = @user_id
END
GO