SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_CategoriesUpdate
	@category_id	INT,
	@category_name	NVARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;

    UPDATE
		Categories
	SET
		category_name = @category_name
	WHERE
		category_id = @category_id
END
GO