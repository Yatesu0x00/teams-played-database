create schema if not exists gor;

use gor;

drop table if exists Mannschaft;
create table Mannschaft(
MKurz char(3),
MName varchar(64),
MGJahr int,
primary key(MKurz)
);

drop table if exists Spiel;
create table Spiel(
HMKurz char(3),
GMKurz char(3),
Spieltag int,
Datum date,
primary key(HMKurz, GMKurz),

UNIQUE KEY(HMKurz, Spieltag),
UNIQUE KEY(GMKurz, Spieltag),

foreign key(HMKurz) references Mannschaft(MKurz),
foreign key(GMKurz) references Mannschaft(MKurz)
);