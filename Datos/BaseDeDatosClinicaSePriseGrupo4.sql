drop database if exists ClinicaSePriseGrupo4;
create database ClinicaSePriseGrupo4;
use ClinicaSePriseGrupo4;

create table roles(
RolUsu int,
NombreRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(001,'Administrador'),
(002,'Empleado');

create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

insert into usuario(CodUsu,NombreUsu,PassUsu,RolUsu) values
(1,'adm','1234',001);
