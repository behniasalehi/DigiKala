use digikala
go
create PROCEDURE dbo.usp_InsertOrder 
    @OrderMaster dbo.udt_Insert_OrderMaster readonly,
    @OrderDetail  dbo.udt_Insert_OrderDetail readonly
AS
   Begin Transaction T
		Begin Try
			--Insert into ordermaster
			insert into dbo.ordermaster(Person_Ref,TotalPrice)
			select Person_Ref,TotalPrice from @OrderMaster	
			--Fetch ordermaster Id
			declare @OrderId int;
			set @OrderId=SCOPE_IDENTITY();
			--Fetch count of OrderDetail
			declare @OrderDetailCount int;
			set @OrderDetailCount=(select count(od.OrderId) from @OrderDetail od)
			declare @index int;
			set @index=0;
			--Insert into OrderDetail
			while(@index<=@OrderDetailCount)
			begin 
				insert into dbo.OrderDetail(OrderId,Product_Ref,UnitPrice,Quantiy,Discount)
				select @OrderId,td.Product_Ref,td.UnitPrice,td.Quantiy,td.Discount
				from @OrderDetail td
				--order by @OrderId offset @index rows fetch next 1 rows only
				set @index=@index+1;
			end
	Commit Transaction T

		End try

	Begin Catch
	
		Rollback Transaction T

	End Catch


Go
declare @behnia dbo.udt_Insert_OrderMaster;
insert into @behnia(Person_Ref,TotalPrice)
values(1,25000)
declare @zahra dbo.udt_Insert_OrderDetail;
insert into @zahra(Product_Ref,UnitPrice,Quantiy,Discount)
values(5,2000,2,250),(6,7412,8,110),(7,25,2,250)
exec dbo.usp_InsertOrder  @behnia , @zahra

