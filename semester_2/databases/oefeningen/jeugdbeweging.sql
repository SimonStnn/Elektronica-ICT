CREATE DATABASE jeugdbeweging;

USE jeugdbeweging;

CREATE TABLE leden (
	lidnr int not null auto_increment,
	naam varchar(50) not null,
	ismeisje boolean default null,
	inschrijvingsdatum timestamp default current_timestamp,
	primary key (lidnr)
);

INSERT INTO leden (naam, ismeisje)
VALUES('Niels', 0);

DROP TABLE leden;