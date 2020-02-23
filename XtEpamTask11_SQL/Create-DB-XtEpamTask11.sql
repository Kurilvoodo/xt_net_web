use master;

drop database if exists XtEpamTask11;

create database XtEpamTask11;

use XtEpamTask11;


create table users (
	Id int primary key identity(1,1),
	Name nvarchar(50) not null,
	DateOfBirth date not null,
	UserImage nvarchar(MAX) not null
);

create table awards (
	Id int primary key identity(1,1),
	Title nvarchar(50) not null,
	AwardImage nvarchar(MAX) not null
);

create table users_awards (
	UserId int not null,
	AwardId int not null,
	constraint User_Award_Pair unique (UserId, AwardId),
	constraint FK_UserId foreign key (UserId) references users(Id) on delete cascade,
	constraint FK_AwardId foreign key (AwardId) references awards(Id) on delete cascade
);


