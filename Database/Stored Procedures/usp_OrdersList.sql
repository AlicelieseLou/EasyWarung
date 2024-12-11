SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_OrdersList
AS
BEGIN
	SET NOCOUNT ON;

    SELECT
		ROW_NUMBER() OVER (ORDER BY Orders.order_id) AS [No.],
		Orders.order_id AS [OrderID],
		FORMAT(Orders.order_date, 'dd MMMM yyyy HH:mm:ss') AS [OrderDateTime],
		Users.user_id AS [UserID],
		Users.user_name AS [UserName],
		Payments.payment_id AS [PaymentID],
		Payments.payment_name AS [PaymentName],
		CASE Orders.order_status
			WHEN 0 THEN 'Cancelled'
			WHEN 1 THEN 'Pending'
			WHEN 2 THEN 'Preparing'
			WHEN 3 THEN 'Ready'
			WHEN 4 THEN 'Delivered'
			WHEN 5 THEN 'Completed'
		END AS [OrderStatusStr],
		Orders.order_status AS [OrderStatusInt],
		'Rp ' + FORMAT(SUM(OrderDetail.product_price * OrderDetail.order_amount), 'N2', 'id-ID') AS [GrandTotal]
	FROM
		Orders
	JOIN
		Users ON Users.user_id = Orders.user_id
	JOIN
		Payments ON Payments.payment_id = Orders.payment_id
	JOIN
		OrderDetail ON OrderDetail.order_id = Orders.order_id
	GROUP BY
		Orders.order_id, Orders.order_date, Users.user_id, Users.user_name, Payments.payment_id, Payments.payment_name, Orders.order_status
	ORDER BY
		Orders.order_id
END
GO