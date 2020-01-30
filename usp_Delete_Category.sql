use digikala
go
alter  PROCEDURE dbo.usp_Delete_Category
  @DeleteCategory as dbo.udt_Delete_Category readonly
AS
begin tran 
begin try
DELETE FROM dbo.Category WHERE CategoryID in (select Id from @DeleteCategory)
and CategoryID not in (select Category_Ref from dbo.Product);
commit tran 
end try
begin catch 
rollback tran 
end catch 
go
-------------------------------------------------------------------------------
declare @behnia dbo.udt_Delete_Category
insert into @behnia(Id)
values (55) , (61) , (62)
exec dbo.usp_Delete_Category @behnia
select * from dbo.Category
select Category_Ref from dbo.Product