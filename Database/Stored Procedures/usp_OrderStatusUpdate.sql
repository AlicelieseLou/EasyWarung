SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_OrderStatusUpdate
	@order_id		NVARCHAR(25),
	@order_status	INT
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE
		Orders
    SET
		order_status = @order_status
    WHERE
		order_id = @order_id;
END
GO