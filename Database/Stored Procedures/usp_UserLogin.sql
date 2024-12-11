SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_UserLogin
	@user_username	NVARCHAR(50),
	@user_password	NVARCHAR(MAX)
AS
BEGIN
	SET NOCOUNT ON;

    SELECT
		Users.user_id AS [UserID],
		Users.user_name AS [UserName],
		Users.user_address AS [UserAddress],
		Users.user_email AS [UserEmail],
		Users.user_phone AS [UserPhone],
		CASE Users.user_role
			WHEN 0 THEN 'Super Admin'
			WHEN 1 THEN 'Admin'
			WHEN 2 THEN 'Operator'
		END AS [UserRoleStr],
		Users.user_username AS [Username],
		Users.user_image AS [UserImage],
		CASE Users.user_status
			WHEN 0 THEN 'Non-Active'
			WHEN 1 THEN 'Active'
		END AS [UserStatusStr],
		Users.user_role AS [UserRoleInt],
		Users.user_status AS [UserStatusInt]
	FROM
		Users
	WHERE
		user_username COLLATE SQL_Latin1_General_CP1_CS_AS = @user_username AND user_password = @user_password AND user_status = 1
END
GO