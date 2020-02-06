use digikala
go
Create Type dbo.udt_Insert_OrderDetail as Table(
					OrderId int,
					Product_Ref int  ,
					UnitPrice money  , 
					Quantiy int , 
					Discount money 
)