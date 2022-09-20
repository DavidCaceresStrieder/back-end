CREATE TABLE Users 
(
	id_usuario int identity(1,1) primary key,
    Name varchar(255) not null,
    LastName varchar(255) not null,
    Email varchar(255) not null,
    BirthDate date not null,
    Telephone bigint,
    Country varchar(255) not null,
    GetInformation bit 
    
);

CREATE TABLE Activity
(
	id_actividad int identity(1,1) primary key,
	CreationDate date not null,
	id_usuario	int FOREIGN KEY REFERENCES Users(id_usuario),
	Activitiy varchar(255)
);