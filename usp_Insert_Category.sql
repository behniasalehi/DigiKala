use digikala
go
alter PROCEDURE dbo.usp_Insert_Category
  @InsertCategory as dbo.udt_Insert_Category readonly,
  @message nvarchar(50) output
AS
begin tran 
begin try
insert into dbo.Category(CategoryName , Descriptions)
select CategoryName,Descriptions from @InsertCategory
set @message = 'succesfully behnia'
commit tran 
end try
begin catch 
set @message = 'fail'
rollback tran 
end catch 
go
declare @behnia dbo.udt_Insert_Category
DECLARE @count nvarchar(50);
insert into @behnia(CategoryName,Descriptions)
values('ali','kalantari')
exec dbo.usp_Insert_Category @behnia , @count output
select @count
