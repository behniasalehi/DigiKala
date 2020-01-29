use digikala
go
create PROCEDURE dbo.usp_Update_Category
  @UpdateCategory as dbo.udt_Update_Category readonly
AS
begin tran 
begin try
UPDATE dbo.category
SET CategoryName = (select CategoryName from @UpdateCategory), Descriptions= (select Descriptions from @UpdateCategory)
WHERE CategoryID = (select Id from @UpdateCategory);
commit tran 
end try
begin catch 
rollback tran 
end catch 
go
exec dbo.usp_Update_Category
