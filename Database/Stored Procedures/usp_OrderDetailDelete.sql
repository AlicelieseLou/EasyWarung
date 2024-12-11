SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_OrderDetailDelete
	@detail_id		INT
AS
BEGIN
	SET NOCOUNT ON;

	DELETE FROM
		OrderDetail
	WHERE
		detail_id = @detail_id
END
GO