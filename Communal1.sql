create database CommunalPayment

use CommunalPayment
create table [User] (
	UserId bigint Primary Key IDENTITY(1,1),
	Email nvarchar(40) NOT NULL,
	[Password] nvarchar(40) NOT NULL)

create table UserData (
	Id bigint Primary Key IDENTITY(1,1),
	--UserId bigint,
	FirstName nvarchar(20) NOT NULL,
	LastName nvarchar(40) NOT NULL,
	PhoneNumber nvarchar(40) NOT NULL)
	--Constraint FK_User Foreign key (UserId) References [User](UserId))

create table Service (
	Id bigint Primary Key IDENTITY(1,1),
	ServiceName nvarchar(40) NOT NULL,
	BankAccount nvarchar(40) NOT NULL,
	ServiceDescription nvarchar(40))

create table Address (
	Id bigint Primary Key IDENTITY(1,1),
	StreetName nvarchar(50) NOT NULL,
	HouseNumber nvarchar(10) NOT NULL,
	Apartment int)

create table [Transaction] (
	TransId bigint Primary Key Identity(1,1),
	UserId int NOT NULL,
	ServiceId int NOT NULL,
	Amount decimal NOT NULL,
	PaymentDate date NOT NULL)

--adding Users
insert into [User]
values ('terry@gmail.com', 'p@ss')
insert into [User]
values ('james@gmail.com', 'word')
insert into [User]
values ('gepard69@gmail.com', 'par0l')
insert into [User]
values ('dopa@gmail.com', '012345q')
insert into [User]
values ('vitya@gmail.com', '/*-+0]')

--adding UserData
insert into [UserData] (FirstName, LastName, PhoneNumber)
values ('Terry', 'John', '+7950 78981230')
insert into [UserData] (FirstName, LastName, PhoneNumber)
values ('Rodrigez', 'James', '+4381 56679118')
insert into [UserData] (FirstName, LastName, PhoneNumber)
values ('Kernose', 'Zigmund', '+380 671182121')
insert into [UserData] (FirstName, LastName, PhoneNumber)
values ('King', 'Steven', '+780 671199999')
insert into [UserData] (FirstName, LastName, PhoneNumber)
values ('Yaya', 'Ture', '+5180 671144421')

-- adding Services
insert into Service
values ('ХарьковГаз Сбыт', 'Ощадбанк', 'Оплата газоснабжения')
insert into Service
values ('Харьковоблэнерго', 'Ощадбанк', 'Оплата электроэнергии')
insert into Service
values ('Водоканал', 'Ощадбанк', 'Оплата за водоснабжение и канализацию')
insert into Service
values ('Интеренет', 'Ощадбанк', 'Оплата за услуги интеренет')
insert into Service
values ('ДомофонСервис', 'Ощадбанк', 'Оплата за домофон')