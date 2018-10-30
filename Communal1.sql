create database CommunalPayment

use CommunalPayment
create table [User] (
	UserId bigint Primary Key IDENTITY(1,1),
	Email nvarchar(40) NOT NULL,
	[Password] nvarchar(40) NOT NULL)

create table UserData (
	Id bigint Primary Key,
	FirstName nvarchar(20) NOT NULL,
	LastName nvarchar(40) NOT NULL,
	PhoneNumber nvarchar(40) NOT NULL,
	AddressId int,
	Constraint FK_User Foreign key (Id) References [User](UserId)
    ON DELETE CASCADE    
    ON UPDATE CASCADE)

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
insert into [UserData]
values ((Select UserId from [User] where [User].Email = 'terry@gmail.com'), 
'Terry', 'John', '+7950 78981230', '1')
insert into [UserData]
values ((Select UserId from [User] where [User].Email = 'james@gmail.com'), 
'Rodrigez', 'James', '+4381 56679118', '2')
insert into [UserData]
values ((Select UserId from [User] where [User].Email = 'gepard69@gmail.com'), 
'Kernose', 'Zigmund', '+380 671182121', '3')
insert into [UserData]
values ((Select UserId from [User] where [User].Email = 'dopa@gmail.com'), 
'King', 'Steven', '+780 671199999', '4')
insert into [UserData]
values ((Select UserId from [User] where [User].Email = 'vitya@gmail.com'), 
'Yaya', 'Ture', '+5180 671144421', '5')

-- adding Services
insert into Service
values ('���������� ����', '��������', '������ �������������')
insert into Service
values ('����������������', '��������', '������ ��������������')
insert into Service
values ('���������', '��������', '������ �� ������������� � �����������')
insert into Service
values ('���������', '��������', '������ �� ������ ���������')
insert into Service
values ('�������������', '��������', '������ �� �������')

--adding Address
insert into Address
values ('����� �����������', '244', 154)
insert into Address
values ('����� 23-�� �������', '26', 10)
insert into Address
values ('����� ��������', '7', null)
insert into Address
values ('������� ������� ������������', 32, null)
insert into Address
values ('�������� ����������', '202/2', 59)