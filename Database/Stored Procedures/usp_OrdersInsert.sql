SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_OrdersInsert
	@user_id	NVARCHAR(25),
	@payment_id	INT,
	@order_date	DATETIME
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @order_id		NVARCHAR(25)
	DECLARE @base_format	NVARCHAR(25)
	DECLARE @amount_data	INT

	SELECT 
        @base_format = base_format, 
        @amount_data = amount_data
    FROM 
        Indextation
    WHERE 
        base_format LIKE 'ORD';

	SET @amount_data = @amount_data + 1;

	SET @order_id = CONCAT(@base_format, '-', FORMAT(@order_date, 'yyyyMMdd'), '-', FORMAT(@amount_data, '000'));

	UPDATE Indextation
    SET amount_data = @amount_data
    WHERE base_format = 'ORD';

    INSERT INTO Orders(order_id, user_id, payment_id, order_date)
	VALUES
		(@order_id, @user_id, @payment_id, @order_date)
END
GO