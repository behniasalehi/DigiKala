use digikala
go
create  PROCEDURE dbo.usp_Delete_Product
  @DeleteProduct as dbo.udt_Delete_Product readonly
AS
begin tran 
begin try
DELETE FROM dbo.Product WHERE ProductID in (select Id from @DeleteProduct);
commit tran 
end try
begin catch 
rollback tran 
end catch 
go
-------------------------------------------------------------------------------
declare @behnia dbo.udt_Delete_Product
insert into @behnia(Id)
values (3) , (4)
exec dbo.usp_Delete_Product @behnia
select * from dbo.Product