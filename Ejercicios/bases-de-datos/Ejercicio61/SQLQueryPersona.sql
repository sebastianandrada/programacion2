create database Ejercicio61

use Ejercicio61

Create table Persona (
	ID int IDENTITY(1,1) PRIMARY KEY,
	nombre varchar(50),
	apellido varchar(50)
);

insert into Persona (nombre, apellido) values ('milton', 'casco')

select * from Persona