SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_ProductsUpdate
	@product_id		NVARCHAR(25),
	@product_name	NVARCHAR(250),
	@product_price	FLOAT,
	@category_id	INT,
	@product_image	IMAGE
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE
		Products
    SET
		product_name = @product_name,
		product_price = @product_price,
		category_id = @category_id,
		product_image = @product_image
    WHERE
		product_id = @product_id;
END
GO