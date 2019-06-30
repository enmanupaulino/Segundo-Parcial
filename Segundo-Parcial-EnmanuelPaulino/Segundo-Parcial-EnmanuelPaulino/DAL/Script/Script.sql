create database InscripcionDb

use InscripcionDb

create table Asignaturas
(
AsignaturasId int primary key identity,
Descripcion varchar (max),
Creditos int
FecheIngreso

)

Create table Estudiantes (
EstudianteId int primary key identity,
FecheIngreso datetime,
Nombres varchar (max),
Balance int 

)

create table Inscripcion(
InscripcionId int primary key identity,
Fecha datetime,
Monto int
)