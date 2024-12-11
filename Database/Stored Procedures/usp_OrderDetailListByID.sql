SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_OrderDetailListByID
	@order_id	NVARCHAR(25)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		ROW_NUMBER() OVER (ORDER BY OrderDetail.detail_id) AS [No.],
		OrderDetail.detail_id AS [DetailID],
		Products.product_name AS [ProductName],
		OrderDetail.product_price AS [ProductPrice],
		OrderDetail.order_amount AS [OrderAmount],
		'Rp ' + FORMAT(OrderDetail.product_price * OrderDetail.order_amount, 'N2', 'id-ID') AS [Subtotal],
		OrderDetail.product_id AS [ProductID]
	FROM
		OrderDetail
	JOIN
		Products ON Products.product_id = OrderDetail.product_id
	WHERE
		OrderDetail.order_id = @order_id
	ORDER BY
		OrderDetail.detail_id
END
GO