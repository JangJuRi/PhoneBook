show databases;

create database phone;
use phone;

create table add_user
(
    name varchar(20) primary key not null,
    phone_num varchar(20) not null,
    job varchar(20) not null,
    email varchar(40) null,
    memo text null,
    saveDate date,
    callNum int
);