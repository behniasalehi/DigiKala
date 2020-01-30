use digikala
go
Create PROCEDURE dbo.usp_Select_Product
AS
begin tran 
begin try
	select p.ProductID , p.Category_Ref , p.ProductName , p.UnitPrice , p.Quantiy ,p.Discount , p.ProductImage
	from dbo.Product p 
	print'Successful'
commit tran 
end try
begin catch 
	print 'Error'
rollback tran 
end catch 
go
exec dbo.usp_Select_Product