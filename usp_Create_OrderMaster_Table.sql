use DigiKala
go
create PROCEDURE dbo.usp_Create_OrderMaster_Table
AS
begin tran 
begin try

IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'OrderMaster') AND type in (N'U'))
		begin
			create table OrderMaster
				(	OrderId int not null identity(1,1) primary key,
					Person_Ref int NOT NULL,
					TotalPrice money,
					FOREIGN KEY (Person_Ref) REFERENCES Person(PersonId)
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
exec dbo.usp_Create_OrderMaster_Table