SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_OrderDetailInsert
	@order_id		NVARCHAR(25),
	@product_id		NVARCHAR(25),
	@product_price	FLOAT,
	@order_amount	INT
AS
BEGIN
	SET NOCOUNT ON;

	IF EXISTS (
		SELECT
			1
		FROM
			OrderDetail
		WHERE
			order_id = @order_id
			AND product_id = @product_id
			AND product_price = @product_price
	)
	BEGIN
		UPDATE
			OrderDetail
		SET
			order_amount += @order_amount
		WHERE
			order_id = @order_id
			AND product_id = @product_id
			AND product_price = @product_price
	END
	ELSE
	BEGIN
		INSERT INTO OrderDetail(order_id, product_id, product_price, order_amount)
			VALUES
				(@order_id, @product_id, @product_price, @order_amount)
	END
END
GO