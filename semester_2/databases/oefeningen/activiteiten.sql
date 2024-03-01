CREATE TABLE activiteiten;
USE activiteiten;

CREATE TABLE activiteiten(
	id int not null auto_increment,
    omschrijving varchar(100) not null,
    datum date default null,
    location varchar(50) default 'buiten',
    
    primary key (id)
)


