SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_OrdersDelete
	@order_id		NVARCHAR(25)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE
		Indextation
    SET
		amount_data -= 1
    WHERE
		id_index = 3;

	DELETE FROM
		Orders
	WHERE
		order_id = @order_id;
END
GO