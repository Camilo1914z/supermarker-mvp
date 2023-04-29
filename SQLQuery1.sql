use Customers
create table PayMode
(
 Customers_Id int identity (100000,1) primary key,
 Customers_Name nvarchar (50) not null,
 Customers_Observation nvarchar (50) not null,
)
go
insert into Customers values('Karen', 'Cumplida')
insert into Customers values('Benedito', 'Incumpliddo')
