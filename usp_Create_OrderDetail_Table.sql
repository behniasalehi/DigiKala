use DigiKala
go 
alter PROCEDURE dbo.usp_Create_OrderDetail_Table
as 
  begin tran 
  begin try 
  IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'OrderDetail') AND type in (N'U'))
		begin
			create table OrderDetail
				(	OrderId int not null ,
					Product_Ref int not null ,
					UnitPrice money not null , 
					Quantiy int not null , 
					Discount money ,
					FOREIGN KEY (OrderId) REFERENCES OrderMaster(OrderId),
					FOREIGN KEY (Product_Ref) REFERENCES Product(ProductID),
				)
		end
		print'Successful'
  commit tran 
  end try 
  begin catch  
  print 'Error'
  rollback tran 
  end catch 


  exec dbo.usp_Create_OrderDetail_Table