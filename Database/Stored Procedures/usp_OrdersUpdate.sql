SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_OrdersUpdate
	@order_id	NVARCHAR(25),
	@user_id	NVARCHAR(25),
	@payment_id	INT,
	@order_date	DATETIME
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE
		Orders
    SET
		user_id = @user_id,
		payment_id = @payment_id,
		order_date = @order_date
    WHERE
		order_id = @order_id;
END
GO