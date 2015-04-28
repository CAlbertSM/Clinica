use Clinica

-------Actualizacion----------------

--create procedure actualizarTipoEmpleado
--@IdTipoEmpleado INT,@NombreTipoEmpleado VARCHAR(20)
--as begin
--	update TipoEmpleado set NombreTipoEmpleado=@NombreTipoEmpleado where IdTipoEmpleado=@IdTipoEmpleado
--end

--create procedure actualizarEmpleado
--@CodigoEmpleado INT,  @NumeroIdentidadEmpleado VARCHAR(15), @IdTipoEmpleado INT, 
--@Primer_Nombre VARCHAR(15), @Segundo_Nombre VARCHAR(30),@Primer_Apellido VARCHAR(20),
--@Segundo_Apellido VARCHAR(20), @Direccion VARCHAR(150),@Telefono VARCHAR(9),
--@EstadoCivil VARCHAR(10),@FechaNac DATETIME,@Especialidad VARCHAR(45),
--@Genero VARCHAR(1),@NumeroColegiado VARCHAR(20),@Habilitado Bit
--as begin
--	 update Empleado set NumeroIdentidadEmpleado=@NumeroIdentidadEmpleado, IdTipoEmpleado=@IdTipoEmpleado,Primer_Nombre=@Primer_Nombre,
--	 Segundo_Nombre=@Segundo_Nombre,Primer_Apellido=@Primer_Apellido,Segundo_Apellido=@Segundo_Apellido,Direccion=@Direccion,Telefono=@Telefono,
--	 EstadoCivil=@EstadoCivil,FechaNac=@FechaNac,Especialidad=@Especialidad,Genero=@Genero,NumeroColegiado=@NumeroColegiado, Habilitado = @Habilitado
--	 where CodigoEmpleado=@CodigoEmpleado
-- end

-- create procedure actualizaUsuario
-- @CodigoEmpleado INT,@Contrasena VARCHAR(15), @Habilitado Bit
-- as begin
--	update Usuario set Contrasena=@Contrasena, Habilitado = @Habilitado where CodigoEmpleado= @CodigoEmpleado
--end

--create procedure actualizaExpediente
--@NumeroExpediente INT, @NumeroIdentidadPaciente VARCHAR(15),@Primer_Nombre VARCHAR(15),
--@Segundo_Nombre VARCHAR(30),@Primer_Apellido VARCHAR(20),@Segundo_Apellido VARCHAR(20),@Direccion VARCHAR(150),
--@Telefono VARCHAR(10),@EstadoCivil VARCHAR(10),@FechaNac DATETIME,@Genero VARCHAR(1), @Habilitado Bit
--as begin
--	update Expediente set NumeroIdentidadPaciente=@NumeroIdentidadPaciente,Primer_Nombre=@Primer_Nombre,
--	Primer_Apellido=@Primer_Apellido,Segundo_Nombre=@Segundo_Nombre,Segundo_Apellido=@Segundo_Apellido,
--	Telefono=@Telefono,EstadoCivil=@EstadoCivil,FechaNac=@FechaNac,Genero=@Genero,Direccion=@Direccion, Habilitado = @Habilitado
--	where NumeroExpediente=@NumeroExpediente
--end

--create procedure actualizaConsulta
--@NumeroExpediente INT, @Fecha DATETIME,@CodigoEmpleado INT ,
--@Temperatura DECIMAL, @Estatura FLOAT, @PresionArterial VARCHAR(7),
--@Peso FLOAT,@Observacion VARCHAR(20),@Problematica VARCHAR(400),@Diagnostico VARCHAR(400)
--as begin
--	update Consulta set CodigoEmpleado=@CodigoEmpleado,Temperatura=@Temperatura,
--	Estatura=@Estatura,PresionArterial=@PresionArterial,Peso=@Peso,Observacion=@Observacion,Problematica=@Problematica,
--	Diagnostico=@Diagnostico where NumeroExpediente=@NumeroExpediente and Fecha=@Fecha;
--end

--create procedure actualizaPrescripcion
--@NumeroExpediente INT ,@Fecha DATETIME,@CodigoEmpleado INT,
--@NombreMedicamento VARCHAR(70),@Dosis VARCHAR(120)
--as begin
--	update Prescripcion set Fecha=@Fecha,CodigoEmpleado=@CodigoEmpleado,
--	NombreMedicamento=@NombreMedicamento,Dosis=@Dosis 
--	where NumeroExpediente=@NumeroExpediente
--end


-----------Eliminacion-------------

--create procedure eliminarTipoEmpleado
--@IdTipoEmpleado INT
--as begin
--	delete from TipoEmpleado where IdTipoEmpleado=@IdTipoEmpleado
--end

--create procedure eliminarEmpleado
--@CodigoEmpleado INT
--as begin
--	 Update Empleado set Habilitado = 0 where CodigoEmpleado=@CodigoEmpleado
--	 Update Usuario set Habilitado = 0 where CodigoEmpleado=@CodigoEmpleado
-- end

-- create procedure eliminarUsuario
-- @CodigoEmpleado INT,@Contrasena VARCHAR(15)
-- as begin
--	delete from Usuario where CodigoEmpleado= @CodigoEmpleado
--end

--create procedure eliminarExpediente
--@NumeroExpediente INT
--as begin
--	Update Expediente set Habilitado = 0 where NumeroExpediente=@NumeroExpediente
--end

--create procedure eliminarConsulta
--@NumeroExpediente INT,
--@Fecha DATETIME
--as begin
--	delete from Consulta where NumeroExpediente=@NumeroExpediente and Fecha = @Fecha;
--end

--create procedure eliminarPrescripcion
--@NumeroExpediente INT 
--as begin
--	delete from Prescripcion where NumeroExpediente=@NumeroExpediente
--end


--------------Insercion---------------------------

--create procedure insertarTipoEmpleado
--@IdTipoEmpleado INT,@NombreTipoEmpleado VARCHAR(20)
--as begin
--	insert into TipoEmpleado values (@IdTipoEmpleado,@NombreTipoEmpleado);
--end



--create procedure insertarEmpleado
--@CodigoEmpleado INT,  @NumeroIdentidadEmpleado VARCHAR(15), @IdTipoEmpleado INT, 
--@Primer_Nombre VARCHAR(15), @Segundo_Nombre VARCHAR(30),@Primer_Apellido VARCHAR(20),@Segundo_Apellido VARCHAR(20), @Direccion VARCHAR(150),@Telefono VARCHAR(9),@EstadoCivil VARCHAR(10),@FechaNac DATETIME,@Especialidad VARCHAR(45),
--@Genero VARCHAR(1),@NumeroColegiado VARCHAR(20)
--as begin
--	 insert into Empleado values (@CodigoEmpleado,@NumeroIdentidadEmpleado, @IdTipoEmpleado, @Primer_Nombre,
--	 @Segundo_Nombre,@Primer_Apellido,@Segundo_Apellido, @Direccion, @Telefono,@EstadoCivil, @FechaNac,
--	 @Especialidad, @Genero, @NumeroColegiado, 1 )
-- end




-- create procedure insertarUsuario
-- @CodigoEmpleado INT,@Contrasena VARCHAR(15)
-- as begin
--	insert into Usuario values (@CodigoEmpleado,@Contrasena, 1)
--end



--create procedure insertarExpediente
--@NumeroIdentidadPaciente VARCHAR(15),@Primer_Nombre VARCHAR(15),@Segundo_Nombre VARCHAR(30), @Primer_Apellido VARCHAR(20),
--@Segundo_Apellido VARCHAR(20),@Direccion VARCHAR(150), @Telefono VARCHAR(10),
--@EstadoCivil VARCHAR(10),@FechaNac DATETIME,@Genero VARCHAR(1)
--as begin
--	INSERT INTO Expediente
--	VALUES (@NumeroIdentidadPaciente, @Primer_Nombre, @Segundo_Nombre, @Primer_Apellido, @Segundo_Apellido, @Direccion, @Telefono, @EstadoCivil, @FechaNac, @Genero, 1)
--end




--create procedure insertarConsulta
--@NumeroExpediente INT, @Fecha DATETIME,@CodigoEmpleado INT ,
--@Temperatura DECIMAL, @Estatura FLOAT, @PresionArterial VARCHAR(7),
--@Peso FLOAT,@Observacion VARCHAR(20),@Problematica VARCHAR(400),@Diagnostico VARCHAR(400)
--as begin
--	insert into Consulta values (@NumeroExpediente, @Fecha,@CodigoEmpleado, @Temperatura, 
--	@Estatura, @PresionArterial, @Peso,@Observacion, @Problematica,@Diagnostico)
--end



--create procedure insertarPrescripcion
-- @NumeroExpediente INT ,@Fecha DATETIME,@CodigoEmpleado INT,
--@NombreMedicamento VARCHAR(70),@Dosis VARCHAR(120)
--as begin
--	insert into Prescripcion values (@NumeroExpediente,@Fecha,@CodigoEmpleado,
--	@NombreMedicamento, @Dosis )
--end


---------------------------Consulta----------------------------

--create procedure consultarTablaEmpleado
--@IdTipoEmpleado INT
--as begin
--	select * from TipoEmpleado where IdTipoEmpleado=@IdTipoEmpleado
--end

--create procedure consultarEmpleado
--@CodigoEmpleado INT
--as begin
--	 select * from Empleado where CodigoEmpleado=@CodigoEmpleado
-- end

-- create procedure consultarUsuario
-- @CodigoEmpleado INT as begin
--	select * from Usuario where CodigoEmpleado= @CodigoEmpleado
--end

--create procedure consultarExpediente
--@NumeroExpediente INT
--as begin
--	select * from Expediente 
--	where NumeroExpediente=@NumeroExpediente
--end

--create procedure consultarConsulta
--@NumeroExpediente INT
--as begin
--	select * from Consulta where NumeroExpediente=@NumeroExpediente
--end

--create procedure consultarPrescripcion
--@NumeroExpediente INT 
--as begin
--	select * from Prescripcion where NumeroExpediente=@NumeroExpediente
--end


--Trigger
USE Clinica
--CREATE TRIGGER insercionUsuarioCrearEmpleado ON Empleado
--AFTER INSERT
--AS BEGIN
--SET NOCOUNT ON;
--	INSERT INTO Usuario (CodigoEmpleado)
--	SELECT CodigoEmpleado FROM INSERTED
--END

USE Clinica;
--CREATE PROCEDURE seleccionarUsuarios
--AS BEGIN
--	SELECT * FROM Usuario;
--END;

--CREATE PROCEDURE seleccionarEmpleados
--AS BEGIN
--	SELECT * FROM Empleado;
--END;

--CREATE PROCEDURE seleccionarTiposEmpleado
--AS BEGIN
--	SELECT * FROM TipoEmpleado;
--END;

--CREATE PROCEDURE seleccionarConsulta
--AS BEGIN
--	SELECT * FROM Consulta;
--END;

--CREATE PROCEDURE seleccionarExpediente
--AS BEGIN
--	SELECT * FROM Expediente;
--END;

----CREATE PROCEDURE seleccionarPrescripcion
----AS BEGIN
----	SELECT * FROM Prescripcion;
----END;

--create procedure consultarExpedienteI
--@NumeroIdentidad Varchar(15)
--as begin
--	select * from Expediente 
--	where NumeroIdentidadPaciente=@NumeroIdentidad
--end

--create procedure consultaIdentidad
--@NumeroIdentidad Varchar(15)
--as begin
--		select * from Consulta where NumeroExpediente in
--		(select NumeroExpediente from Expediente where 
--		NumeroIdentidadPaciente=@NumeroIdentidad);
--end