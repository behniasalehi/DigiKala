use digikala
go
create PROCEDURE dbo.usp_Select_Category

AS
begin tran 
begin try
	select c.CategoryId, c.CategoryName , c.Descriptions
	from dbo.Category c 
	print'Successful'
commit tran 
end try
begin catch 
	print 'Error'
rollback tran 
end catch 
go
exec dbo.usp_Select_Category