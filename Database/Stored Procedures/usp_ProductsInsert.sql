SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_ProductsInsert
	@product_name	NVARCHAR(250),
	@product_price	FLOAT,
	@category_id	INT,
	@product_image	IMAGE
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @product_id		NVARCHAR(25)
	DECLARE @base_format	NVARCHAR(25)
	DECLARE @amount_data	INT

	SELECT 
        @base_format = base_format, 
        @amount_data = amount_data
    FROM 
        Indextation
    WHERE 
        base_format LIKE 'PROD';

	SET @amount_data = @amount_data + 1;

	SET @product_id = CONCAT(@base_format, '-', FORMAT(@category_id, '000'), '-', FORMAT(@amount_data, '000'));

	UPDATE Indextation
    SET amount_data = @amount_data
    WHERE base_format = 'PROD';

	INSERT INTO Products(product_id, product_name, product_price, category_id, product_image)
	VALUES
		(@product_id, @product_name, @product_price, @category_id, @product_image)
END
GO