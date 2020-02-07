use Users
create table Persons
(
	ID int primary key identity(1, 1) not null,
	Name nvarchar(20) not null,
	Lastname nvarchar(30) not null,
	BirthDate date not null,
	Sex nvarchar(10) not null,
	Image nvarchar(100),
	Sport bit,
	Tourism bit,
	Books bit,
	Movies bit,
	Other nvarchar(100)
)