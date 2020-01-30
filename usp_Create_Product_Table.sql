use DigiKala
go 
CREATE PROCEDURE dbo.usp_Create_Product_Table
as 
  begin tran 
  begin try 
  IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Product') AND type in (N'U'))
		begin
			create table Product
				(	ProductID int not null identity(1,1) primary key,
					Category_Ref int not null ,
					ProductName nvarchar(50) NOT NULL,
					UnitPrice money not null , 
					Quantiy int not null , 
					Discount money ,
					ProductImage varbinary(max),
					FOREIGN KEY (Category_Ref) REFERENCES Category(CategoryID)
				)
		end
		print'Successful'
  commit tran 
  end try 
  begin catch  
  print 'Error'
  rollback tran 
  end catch 


  exec dbo.usp_Create_Product_Table