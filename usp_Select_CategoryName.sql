use digikala
go
alter PROCEDURE dbo.usp_Select_CategoryName
AS
begin tran 
begin try
	select  c.CategoryName , c.CategoryId
	from dbo.Category c 
	print'Successful'
commit tran 
end try
begin catch 
	print 'Error'
rollback tran 
end catch 
go
exec dbo.usp_Select_CategoryName