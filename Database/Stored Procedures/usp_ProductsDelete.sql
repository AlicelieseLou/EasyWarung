SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_ProductsDelete
	@product_id		NVARCHAR(25)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE
		Products
    SET
		product_status = 0
    WHERE
		product_id = @product_id;
END
GO