use digikala
go
alter  PROCEDURE dbo.usp_Delete_Category
  @DeleteCategory as dbo.udt_Delete_Category readonly
AS
begin tran 
begin try
DELETE FROM dbo.Category WHERE CategoryID in (select Id from @DeleteCategory);
commit tran 
end try
begin catch 
rollback tran 
end catch 
go
declare @behnia dbo.udt_Delete_Category
insert into @behnia(Id)
values (1),(10)
exec dbo.usp_Delete_Category @behnia