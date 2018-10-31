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
	Apartment int,
	UserId bigint,
	Constraint FK_UserId Foreign key (UserId) References UserData(Id))

create table [Address&Service] (
	Id bigint Primary key Identity(1,1),
	AddressId bigint NOT NULL,
	ServiceId bigint NOT NULL)

create table [Transaction] (
	TransactId bigint Primary Key Identity(1,1),
	UserId int NOT NULL,
	ServiceId int NOT NULL,
	Amount decimal NOT NULL,
	PaymentDate DATETIME NOT NULL)

--adding Users
insert into [User]
values ('jerry@gmail.com', 'p@ss')
insert into [User]
values ('sunshine@gmail.com', 'word')
insert into [User]
values ('gepard69@gmail.com', 'par0l')
insert into [User]
values ('alex.bond@gmail.com', '012345q')
insert into [User]
values ('vitya@gmail.com', '/*-+0]')

--adding UserData
insert into [UserData]
--(Select UserId from [User] where [User].Email = 'terry@gmail.com')
values (1, 'Jerry', 'John', '+7950 78981230')
insert into [UserData]
values (2, 'James', 'Rodrigez', '+4381 56679118')
insert into [UserData]
values (3, 'Sigizmund', 'Kernoziskiy', '+380 671182121')
insert into [UserData]
values (4, 'Steven', 'King', '+780 671199999')
insert into [UserData]
values (5, 'Victor', 'Glukhoverov', '+5180 671144421')

-- adding Services
insert into Service
values ('KharkivGas Sbyt', 'Oschadbank', 'Payment for gas')
insert into Service
values ('KharkivOblEnergo', 'Oschadbank', 'Payment for electricity')
insert into Service
values ('Vodokanal', 'Oschadbank', 'Payment for water')
insert into Service
values ('Internet', 'Oschadbank', 'Payment for Internet service')
insert into Service
values ('DomophoneService', 'Oschadbank', 'Payment for domophone')

--adding Address
insert into Address
values ('Klochkovskaya str.', '244', 154)
insert into Address
values ('23rd of august str.', '26', 10)
insert into Address
values ('Morozova str.', '7', null)
insert into Address
values ('Bohdan Khmelnytsky boul.', 32, null)
insert into Address
values ('Moscow Ave.', '202/2', 59)

--adding Address and Service
insert into [Address&Service]
values (1, 4)
insert into [Address&Service]
values (2, 4)
insert into [Address&Service]
values (3, 4)
insert into [Address&Service]
values (4, 1)
insert into [Address&Service]
values (4, 2)
insert into [Address&Service]
values (4, 3)
insert into [Address&Service]
values (4, 4)
insert into [Address&Service]
values (5, 4)

--adding Tras
insert into [Transaction]
values (1, 4, 100, '2018-09-15 11:37:10')
insert into [Transaction]
values (2, 4, 250, '2018-05-11 15:07:50')
insert into [Transaction]
values (3, 4, 150, '2018-10-20 7:12:15')
insert into [Transaction]
values (4, 1, 740, '2018-02-03 20:14:10')
insert into [Transaction]
values (4, 2, 1040, '2018-02-03 20:16:10')
insert into [Transaction]
values (4, 4, 440, '2018-02-03 20:18:10')
insert into [Transaction]
values (5, 4, 75, '2018-03-09 23:20:40')