SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_IndextationIDGetter
	@id_index		INT,
	@id_identity	INT,
	@order_date		DATETIME,
	@id_table		NVARCHAR(25) OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @base_format	NVARCHAR(25)
	DECLARE @amount_data	INT

	SELECT 
        @base_format = base_format,
        @amount_data = amount_data
    FROM 
        Indextation
    WHERE 
        id_index = @id_index;

	IF @id_index = 1 OR @id_index = 2
	BEGIN
		SET @id_table = CONCAT(@base_format, '-', FORMAT(@id_identity, '000'), '-', FORMAT(@amount_data + 1, '000'))
	END
    ELSE
	BEGIN
		SET @id_table = CONCAT(@base_format, '-', FORMAT(@order_date, 'yyyyMMdd'), '-', FORMAT(@amount_data + 1, '000'));
	END
END
GO