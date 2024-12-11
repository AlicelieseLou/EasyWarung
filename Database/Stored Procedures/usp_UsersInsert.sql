SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_UsersInsert
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

	DECLARE @user_id		NVARCHAR(25)
	DECLARE @base_format	NVARCHAR(25)
	DECLARE @amount_data	INT

	SELECT 
        @base_format = base_format, 
        @amount_data = amount_data
    FROM 
        Indextation
    WHERE 
        base_format LIKE 'USR';

	SET @amount_data = @amount_data + 1;

	SET @user_id = CONCAT(@base_format, '-', FORMAT(@user_role, '000'), '-', FORMAT(@amount_data, '000'));

	UPDATE Indextation
    SET amount_data = @amount_data
    WHERE base_format = 'USR';

	INSERT INTO Users(user_id, user_name, user_address, user_email, user_phone, user_role, user_username, user_password, user_image)
	VALUES
		(@user_id, @user_name, @user_address, @user_email, @user_phone, @user_role, @user_username, @user_password, @user_image)
END
GO