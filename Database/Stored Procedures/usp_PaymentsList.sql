SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE usp_PaymentsList
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		ROW_NUMBER() OVER (ORDER BY Payments.payment_id) AS [No.],
		Payments.payment_id AS [PaymentID],
		Payments.payment_name AS [PaymentName],
		CASE Payments.payment_status
			WHEN 0 THEN 'Non-Active'
			WHEN 1 THEN 'Active'
		END AS [PaymentStatusStr],
		Payments.payment_status AS [PaymentStatusInt]
	FROM
		Payments
	WHERE
		Payments.payment_status = 1
	ORDER BY
		Payments.payment_id
END
GO