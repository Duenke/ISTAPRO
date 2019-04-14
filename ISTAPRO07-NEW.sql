-- Name: Jacob Duenke
-- File: ISTAPRO07
-- Date: March 18, 2019

use [ISTAPRO07-B];

drop table if exists Users;

create table Users
	(
	UserID int identity primary key
	,UserName varchar(20)
	,Email varchar(30)
	,TicketNumber int
	);

insert into Users
output
	inserted.UserName
	,inserted.Email
	,inserted.TicketNumber
values
	('Dinks','goth-monkey@hotmail.com',1000)
	,('K-Pop','kbil@hotmail.com',1123)
	,('ThaMich','fiestacab@hotmail.com',1246)
	,('ChiTea','gisman9000@hotmail.com',1369)
	,('Chuckles','cartec@hotmail.com',1492);

select * from Users;

drop table if exists Employees;

create table Employees
	(
	EmpID int identity primary key
	,EmpName varchar(20)
	,TicketNumber int
	);

insert into Employees
output
	inserted.EmpName
	,inserted.TicketNumber
values
	('ThatGuy',1001)
	,('Robert',1340)
	,('Michael',1904)
	,('Tom',3123)
	,('Craig',9999);

select * from Employees;

drop table if exists NewTickets;

create table NewTickets
	(
	TicketNumber int identity(1000,123) primary key
	,SubmitDate date
	,UserID int
	,Platform varchar(20)
	,Issue varchar(max)
	);

insert into NewTickets
output
	inserted.SubmitDate
	,inserted.UserID
	,inserted.Platform
	,inserted.Issue
values
	('2019-02-12',1,'Mac OS','I cannot install Windows 10 for some reason.')
	,('2019-02-24',2,'Windows 10','Need help turning computer on.')
	,('2019-03-01',3,'Windows 10','My computer thinks there are only 28 days in February.')
	,('2019-03-05',4,'Mac OS','Can a Mac play games?')
	,('2019-03-17',5,'Windows Phone','My phone will not respond unless I wear green today.')

select * from NewTickets;

drop table if exists OpenTickets;

create table OpenTickets
	(
	TicketNumber int
	,SubmitDate date
	,OpenDate date
	,EmpID int
	,UserID int
	,Platform varchar(20)
	,Issue varchar(max)
	);

insert into OpenTickets
output
	inserted.TicketNumber
	,inserted.SubmitDate
	,inserted.OpenDate
	,inserted.EmpID
	,inserted.UserID
	,inserted.Platform
	,inserted.Issue
values
	(1000,'2019-02-12','2019-02-13',2,1,'Mac OS','I cannot install Windows 10 for some reason.')
	,(1123,'2019-02-24','2019-02-25',3,2,'Windows 10','Need help turning computer on.')
	,(1246,'2019-03-01','2019-03-02',4,3,'Windows 10','My computer thinks there are only 28 days in February.')
	,(1369,'2019-03-05','2019-03-06',5,4,'Mac OS','Can a Mac play games?')
	,(1492,'2019-03-17','2019-03-18',1,5,'Windows Phone','My phone will not respond unless I wear green today.')

select * from OpenTickets;

drop table if exists CompletedTickets;

create table CompletedTickets
	(
	TicketNumber int
	,SubmitDate date
	,OpenDate date
	,CloseDate date
	,EmpID int
	,UserID int
	,Platform varchar(20)
	,Issue varchar(max)
	,Resolution varchar(max)
	);

insert into CompletedTickets
output
	inserted.TicketNumber
	,inserted.SubmitDate
	,inserted.OpenDate
	,inserted.CloseDate
	,inserted.EmpID
	,inserted.UserID
	,inserted.Platform
	,inserted.Issue
	,inserted.Resolution
values
	(1000,'2019-02-12','2019-02-13','2019-02-14',2,1,'Mac OS','I cannot install Windows 10 for some reason.','ID10T ERROR')
	,(1123,'2019-02-24','2019-02-25','2019-02-26',3,2,'Windows 10','Need help turning computer on.','ID10T ERROR')
	,(1246,'2019-03-01','2019-03-02','2019-03-03',4,3,'Windows 10','My computer thinks there are only 28 days in February.','ID10T ERROR')
	,(1369,'2019-03-05','2019-03-06','2019-03-07',5,4,'Mac OS','Can a Mac play games?','ID10T ERROR')
	,(1492,'2019-03-17','2019-03-18','2019-03-19',1,5,'Windows Phone','My phone will not respond unless I wear green today.','ID10T ERROR')

select * from CompletedTickets;
