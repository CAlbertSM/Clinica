--DROP DATABASE Clinica;
--CREATE DATABASE Clinica;
USE Clinica;

CREATE TABLE TipoEmpleado(
IdTipoEmpleado INT NOT NULL,
NombreTipoEmpleado VARCHAR(20),
CONSTRAINT PK_TipoEmpleado PRIMARY KEY (IdTipoEmpleado));

CREATE TABLE Empleado(
CodigoEmpleado INT NOT NULL, 
NumeroIdentidadEmpleado VARCHAR(15) NOT NULL,
IdTipoEmpleado INT NOT NULL,
Primer_Nombre VARCHAR(15),
Segundo_Nombre VARCHAR(30),
Primer_Apellido VARCHAR(20),
Segundo_Apellido VARCHAR(20),
Direccion VARCHAR(150),
Telefono VARCHAR(9),
EstadoCivil VARCHAR(10),
FechaNac DATETIME,
Especialidad VARCHAR(45),
Genero VARCHAR(1),
NumeroColegiado VARCHAR(20),
Habilitado Bit Default 1,
CONSTRAINT PK_Empleado PRIMARY KEY (CodigoEmpleado),
CONSTRAINT FK_EmpleadoTipoEmpleado FOREIGN KEY (IdTipoEmpleado) 
REFERENCES TipoEmpleado(IdTipoEmpleado));

CREATE TABLE Usuario(
CodigoEmpleado INT NOT NULL,
Contrasena VARCHAR(15) DEFAULT 'generica',
Habilitado Bit Default 1,
CONSTRAINT PK_Usuario PRIMARY KEY (CodigoEmpleado),
CONSTRAINT FK_UsuarioEmpleado FOREIGN KEY (CodigoEmpleado) REFERENCES Empleado(CodigoEmpleado));

CREATE TABLE Expediente(
NumeroExpediente INT IDENTITY(1,1) NOT NULL,
NumeroIdentidadPaciente VARCHAR(15) NOT NULL,
Primer_Nombre VARCHAR(15),
Segundo_Nombre VARCHAR(30),
Primer_Apellido VARCHAR(20),
Segundo_Apellido VARCHAR(20),
Direccion VARCHAR(150),
Telefono VARCHAR(9),
EstadoCivil VARCHAR(10),
FechaNac DATETIME,
Genero VARCHAR(1),
Habilitado Bit Default 1,
CONSTRAINT PK_Expediente PRIMARY KEY (NumeroExpediente));

CREATE TABLE Consulta(
NumeroExpediente INT NOT NULL,
Fecha DATETIME,
CodigoEmpleado INT NOT NULL,
Temperatura DECIMAL(4,2),
Estatura FLOAT,
PresionArterial VARCHAR(7),
Peso FLOAT,
Observacion VARCHAR(20),
Problematica VARCHAR(400),
Diagnostico VARCHAR(400),
CONSTRAINT PK_Consulta PRIMARY KEY (NumeroExpediente,Fecha),
CONSTRAINT FK_ConsultaEmpleado FOREIGN KEY (CodigoEmpleado) REFERENCES Empleado(CodigoEmpleado),
CONSTRAINT FK_ConsultaExpediente FOREIGN KEY (NumeroExpediente) REFERENCES Expediente(NumeroExpediente));

CREATE TABLE Prescripcion(
NumeroExpediente INT NOT NULL,
Fecha DATETIME,
CodigoEmpleado INT NOT NULL,
NombreMedicamento VARCHAR(70),
Dosis VARCHAR(120),
CONSTRAINT PK_Prescripcion PRIMARY KEY (NumeroExpediente,Fecha),
CONSTRAINT FK_PrescipcionEmpleado FOREIGN KEY (CodigoEmpleado) REFERENCES Empleado(CodigoEmpleado),
CONSTRAINT FK_PrescripcionExpediente FOREIGN KEY (NumeroExpediente) REFERENCES Expediente(NumeroExpediente));

--Creación del Tipo de Empleado Administrador, es decir, el super usuario del sistema.
INSERT INTO TipoEmpleado VALUES (1, 'Administrador');
INSERT INTO TipoEmpleado VALUES (2, 'Medico');
INSERT INTO TipoEmpleado VALUES (3, 'Enfermera');
INSERT INTO TipoEmpleado VALUES (4, 'Secretaria');
--Creación de un Empleado Genérico para asignarle el Tipo de Empleado Administrador .
INSERT INTO Empleado VALUES (1, '0000-0000-00001', 1, 'Usuario', '', 'Administrador', '', 'Sistema de Administración de Expedientes Médicos Clinica San José', 
	'0000-0000', '', '11-26-2014', '', '', '', 1);
