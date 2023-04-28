use Supermarker
create table Providers
(
 Providers_Id int identity (100000,1) primary key,
 Providers_Name nvarchar (50) not null,
 Providers_Observation nvarchar (50) not null,
)
go
insert into Providers values('Parmalat', 'Quality milk')
insert into Providers values('Motorola', 'Good phone')
