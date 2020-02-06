use DigiKala
go
create PROCEDURE dbo.usp_Create_Person_Table
AS
begin tran 
begin try

IF  NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'Person') AND type in (N'U'))
		begin
			create table Person
				(	PersonId int not null identity(1,1) primary key,
					FirstName nvarchar(50) NOT NULL,
					Surname nvarchar(50) NOT NULL,
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
exec dbo.usp_Create_Person_Table