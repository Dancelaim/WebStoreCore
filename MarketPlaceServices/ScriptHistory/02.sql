Begin Try
    SET NOCOUNT ON
    Set XACT_ABORT ON
Begin Tran
exec Check_db_Version 2

Create table OrderProduct
(
	OrderProductId uniqueidentifier
	,OrderId uniqueidentifier
	,ProductId uniqueidentifier
	,ProductOptions nvarchar(MAX)
	,ProductCheckoutPrice decimal (19,1)
	,TotalOptionsCheckoutPrice decimal (19,1),
	PRIMARY KEY (OrderProductId),
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
	FOREIGN KEY (ProductId) REFERENCES Product(ProductId),
)


exec Update_db_Version 2
Commit Tran
End Try
Begin Catch
   RollBack Tran
   Select ERROR_MESSAGE() as Msg, ERROR_NUMBER() as Num
End Catch