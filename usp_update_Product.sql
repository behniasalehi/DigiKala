use digikala
go
alter PROCEDURE dbo.usp_Update_Product
  @UpdateProduct as dbo.udt_Update_Product readonly
AS
begin tran 
begin try
--declare @countID int
--set @countID = (select count(td.Id) from @UpdateProduct td);
--declare @index int;
--set @index=0;
--while(@index<=@countID)
--begin 
UPDATE dbo.Product
set Category_Ref = (select Category_Ref from @UpdateProduct),
ProductName = (select ProductName from @UpdateProduct),
UnitPrice = (select UnitPrice from @UpdateProduct),
Quantiy = (select Quantiy from @UpdateProduct),
Discount = (select Discount from @UpdateProduct),
ProductImage = (select ProductImage from @UpdateProduct) 
WHERE ProductID in (select Id from @UpdateProduct);

--order by td.Code offset @index rows fetch next 1 rows only
--set @index=@index+1;
--end

commit tran 
end try
begin catch 
rollback tran 
end catch 
go
declare @behnia dbo.udt_Update_Product
insert into @behnia(       Id  ,
					Category_Ref  ,
					ProductName ,
					UnitPrice   , 
					Quantiy   , 
					Discount  ,
					ProductImage )
values(4,55,'behnia',12,1,4,null) 
--, (3,66,'bb',107,1,4,null)
exec dbo.usp_Update_Product @behnia 