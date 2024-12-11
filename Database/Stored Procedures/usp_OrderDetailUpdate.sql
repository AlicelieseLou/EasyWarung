SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_OrderDetailUpdate
	@detail_id		INT,
	@order_id		NVARCHAR(25),
	@product_id		NVARCHAR(25),
	@product_price	FLOAT,
	@order_amount	INT
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE
		OrderDetail
	SET
		order_id = @order_id, 
		product_id = @product_id, 
		product_price = @product_price, 
		order_amount = @order_amount
	WHERE
		detail_id = @detail_id
END
GO