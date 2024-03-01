CREATE DATABASE krakkemik;
USE krakkemik;
CREATE TABLE auto (
	id int not null auto_increment,
    merk varchar(50) not null,
    prijs int not null,
    bouwjaar int,
    kleur char(6),
    primary key (id)
);

INSERT INTO auto (merk, prijs, bouwjaar, kleur) VALUE ('Opel Astra', 1500, 1998, 'ff0000');
INSERT INTO auto (merk, prijs, bouwjaar, kleur) VALUE ('Ford Escord', 2000, 2002, '00ff00');
INSERT INTO auto (merk, prijs) VALUE ('Peugeot', 4000);

