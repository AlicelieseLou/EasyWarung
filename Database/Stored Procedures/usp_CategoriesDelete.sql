SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_CategoriesDelete
	@category_id	INT
AS
BEGIN
	SET NOCOUNT ON;

    UPDATE
		Categories
	SET
		category_status = 0
	WHERE
		category_id = @category_id
END
GO