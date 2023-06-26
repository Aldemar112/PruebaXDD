Use Hotel_Rivera

----
create procedure SP_LoginUsuario
@Cedula varchar(15),
@Contraseña varchar(100)
as
	SELECT * FROM Usuario WHERE Contraseña = @Contraseña AND Cedula = @Cedula AND Estado = 1
go

Create procedure SP_BuscarUsuario
as
	SELECT Cedula, Nombre, Correo, Estado FROM Usuario where CodRoles = 2
go


create procedure SP_InsertarUsuario
@Cedula varchar(15),
@Nombre varchar(70),
@Contraseña Varchar(100),
@Correo varchar(70),
@CodRoles int,
@Estado bit
as
	INSERT INTO Usuario (Cedula, Nombre, Contraseña, Correo, CodRoles, Estado) 
	VALUES (@Cedula, @Nombre, @Contraseña, @Correo, @CodRoles, @Estado)
go

create procedure SP_ModificarUsuario
@Cedula varchar(15),
@Nombre varchar(70),
@Correo varchar(70),
@Estado bit
as
	UPDATE Usuario SET Nombre = @Nombre, Correo = @Correo, Estado = @Estado 
	WHERE Cedula = @Cedula
go

