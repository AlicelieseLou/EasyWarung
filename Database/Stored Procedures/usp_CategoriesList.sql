SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_CategoriesList
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		ROW_NUMBER() OVER (ORDER BY Categories.category_id) AS [No.],
		Categories.category_id AS [CategoryID],
		Categories.category_name AS [CategoryName],
		CASE Categories.category_status
			WHEN 0 THEN 'Non-Active'
			WHEN 1 THEN 'Active'
		END AS [CategoryStatusStr],
		Categories.category_status AS [CategoryStatusInt]
	FROM
		Categories
	WHERE
		Categories.category_status = 1
	ORDER BY
		Categories.category_id
END
GO