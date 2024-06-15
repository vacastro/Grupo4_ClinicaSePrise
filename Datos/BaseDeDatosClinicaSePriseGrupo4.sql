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

CREATE TABLE insumos (
    insumo_id INT AUTO_INCREMENT,
    nombre VARCHAR(100),
    cantidad int,
    PRIMARY KEY (insumo_id)
);

-- Consultorios externos
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Alergología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Andrología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Cardiología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Cirugía');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Dermatología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Endocrinología');
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Fisio-Kinesiologia');
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
INSERT INTO Especialidades (tipo_especialidad, nombre_especialidad) VALUES ('consultorio_externo', 'Salud Mental');
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

-- Estudios médicos
INSERT INTO Insumos (nombre, cantidad) VALUES ('Jeringas Descartables 5mm', 1500);
INSERT INTO Insumos (nombre, cantidad) VALUES ('Reactivos Urocultivo', 350);
INSERT INTO Insumos (nombre, cantidad) VALUES ('Reactivos Glucosa', 10);
INSERT INTO Insumos (nombre, cantidad) VALUES ('Heparina', 100);
INSERT INTO Insumos (nombre, cantidad) VALUES ('ELISA', 450);
INSERT INTO Insumos (nombre, cantidad) VALUES ('Reactivos COVID', 2000);
INSERT INTO Insumos (nombre, cantidad) VALUES ('Reactivos VIH', 750);
INSERT INTO Insumos (nombre, cantidad) VALUES ('Reactivos Hepatitis', 300);

CREATE TABLE paciente (
    pacienteId INT AUTO_INCREMENT,
    nombre VARCHAR(40),
    apellido VARCHAR(40),
    fecNacimiento DATE,
    domicilio VARCHAR(40),
    email VARCHAR(40),
    telefono VARCHAR(20),
    dni BIGINT,
    PRIMARY KEY (pacienteId)
);

insert into paciente(pacienteId,nombre,apellido,fecNacimiento,domicilio,email,telefono,dni) values 
(default,'Leo','Messi',19880101,'Siempreviva 123','leo10@gmail.com','10101010',33495009),
(default,'Angel','DiMaria',19880201,'Siempreviva 124','angelito07@gmail.com','070707',33495007),
(default,'Dibu','Martinez',19880301,'Siempreviva 125','el_Dibu@gmail.com','232323',33495008);


CREATE TABLE turno (
    turnoId INT AUTO_INCREMENT,
    fecha DATE,
    hora TIME,
    especialidad VARCHAR(255),
    pacienteId INT, 
    sobreturno BOOLEAN DEFAULT false,
    PRIMARY KEY (turnoId),
    FOREIGN KEY (pacienteId) REFERENCES paciente (pacienteId)
);