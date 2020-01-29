use DigiKala
go
alter PROCEDURE dbo.usp_Create_Category_Table
AS
begin tran 
begin try

IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Category') AND type in (N'U'))
		begin
			create table Category
				(	CategoryID int not null identity(1,1) primary key,
					CategoryName nvarchar(50) NOT NULL,
					Descriptions nvarchar(100),
				)
		end
	print'Successful'
commit tran 
end try
begin catch 
	print 'Error'
rollback tran 
end catch 
go
exec dbo.usp_Create_Category_Table