SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_CategoriesInsert
	@category_name	NVARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;

    INSERT INTO Categories(category_name)
	VALUES
		(@category_name)
END
GO