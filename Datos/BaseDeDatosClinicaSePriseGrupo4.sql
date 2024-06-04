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

CREATE TABLE especialidades (
    especialidad_id INT AUTO_INCREMENT,
    nombre_especialidad VARCHAR(100),
    tipo_especialidad ENUM('consultorio_externo', 'estudios_medicos'),
    PRIMARY KEY (especialidad_id)
);
-- Consultorios externos
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Alergología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Andrología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Cardiología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Cirugía');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Dermatología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Endocrinología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Fonoaudiología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Gastroenterología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Ginecología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Infectología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Medicina General');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Nefrología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Neurología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Neumunología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Oftalmología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Otorrinolaringología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Pediatría');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Proctología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Traumatología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Urología');

-- Estudios médicos
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('estudios_medicos', 'Angiografía');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('estudios_medicos', 'Colonoscopía');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('estudios_medicos', 'Densitometría ósea');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('estudios_medicos', 'Ecografía');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('estudios_medicos', 'Electrocardiograma');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('estudios_medicos', 'Electroencefalograma');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('estudios_medicos', 'Endoscopía');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('estudios_medicos', 'Espirometría');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('estudios_medicos', 'Ergometría');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('estudios_medicos', 'Mamografía');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('estudios_medicos', 'Radiografía');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('estudios_medicos', 'Resonancia magnética');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('estudios_medicos', 'Tomografía');
