SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_ProductsList
AS
BEGIN
	SET NOCOUNT ON;

    SELECT
		ROW_NUMBER() OVER (ORDER BY Products.product_id) AS [No.],
		Products.product_id AS [ProductID],
		Products.product_name AS [ProductName],
		Products.product_price AS [ProductPrice],
		'Rp ' + FORMAT(Products.product_price, 'N2', 'id-ID') AS [ProductPriceStr],
		Categories.category_id AS [CategoryID],
		Categories.category_name AS [CategoryName],
		Products.product_image AS [ProductImage],
		CASE Products.product_status
			WHEN 0 THEN 'Non-Active'
			WHEN 1 THEN 'Active'
		END AS [ProductStatusStr],
		Products.product_status AS [ProductStatusInt]
	FROM
		Products
	JOIN
		Categories ON Categories.category_id = Products.category_id
	WHERE
		Products.product_status = 1
	ORDER BY
		Products.product_id
END
GO