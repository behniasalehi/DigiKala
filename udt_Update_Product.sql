﻿use digikala
go
Create Type dbo.udt_Update_Product as Table(
					Id int ,
					Category_Ref int ,
					ProductName nvarchar(50),
					UnitPrice money  , 
					Quantiy int  , 
					Discount money ,
					ProductImage varbinary(max)
						
)
--ProductImage varbinary(max)	