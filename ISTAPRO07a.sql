-- Name: Jacob Duenke
-- File: ISTAPRO07
-- Date: February 25, 2019

use ISTAPRO07;

drop table if exists Records;

create table Records
	(
	PlayerID int
	,PlayerName varchar(20)
	,Wins int
	,Losses int
	,GamesPlayed int
	);

insert into Records
output
	inserted.PlayerID
	,inserted.PlayerName
	,inserted.Wins
	,inserted.Losses
	,inserted.GamesPlayed
values
	(00,'Dinks',20,02,22)
	,(01,'K-Pop',04,06,10)
	,(02,'ThaMich',12,09,21)
	,(03,'ChiTea',33,00,33)
	,(04,'Chuckles',99,00,99);

select * from Records;

select * from Records where PlayerID = 0;

select PlayerName from Records where Wins > 20;

select PlayerID, PlayerName from Records where GamesPlayed > 20;