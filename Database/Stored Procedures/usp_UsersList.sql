SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_UsersList
AS
BEGIN
	SET NOCOUNT ON;

    SELECT
		ROW_NUMBER() OVER (ORDER BY Users.user_id) AS [No.],
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
		Users.user_password AS [Password],
		Users.user_image AS [UserImage],
		CASE Users.user_status
			WHEN 0 THEN 'Non-Active'
			WHEN 1 THEN 'Active'
		END AS [UserStatusStr],
		Users.user_role AS [UserRoleInt],
		Users.user_status AS [UserStatusInt]
	FROM
		Users
	ORDER BY
		Users.user_id
END
GO