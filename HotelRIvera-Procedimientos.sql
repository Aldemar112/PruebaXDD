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

----Ubicaciones
Create procedure SP_BuscarPais
as
Select * from Pais
go

Create procedure SP_BuscarDepartamento
@CodPais int
as
select * from Departamento where CodPais = @CodPais
go

Create procedure SP_BuscarCiudad
@CodDepartamento int
as
select * from Ciudad where CodDepartamento = @CodDepartamento
go

--Tipo de Documento
Create procedure SP_TipoDocumento
as
Select * from TipoDocumento
go

--tipo de habitacion
Create procedure SP_TipoHabitacion
as
select * from TipoHabitacion
go
-- Habitaciones
Create procedure SP_BuscarHabitaciones
@TipoHabitacion int
as
select * from Habitacion where TipoHabitacion = @TipoHabitacion
go
--Metodo de abonos
Create procedure SP_MetodoAbonos
as
select * from MetodoAbono
go
--Metodo de Reserva
Create procedure SP_MetodoReserva
as
select * from MetodoReserva
go
---Cliente
Create procedure SP_BuscarCliente
@NumDocumento varchar(20)
as
select * from Cliente where NumDocumento = @NumDocumento
go

create procedure SP_InsertarCliente
@NumDocumento Varchar(20),
@TipoDoc int,
@LugarExpedicion int,
@Nombres varchar(50),
@Apellidos varchar(50),
@Nacionalidad int,
@Profesion varchar(25),
@Correo varchar(30),
@Telefono varchar(15),
@FechaNacimiento datetime
as
Insert into Cliente 
Values 
(@NumDocumento,@TipoDoc,@LugarExpedicion,@Nombres,@Apellidos,@Nacionalidad,@Profesion,@Correo,@Telefono,@FechaNacimiento)
go


create procedure SP_EditarCliente
@NumDocumento Varchar(20),
@TipoDoc int,
@LugarExpedicion int,
@Nombres varchar(50),
@Apellidos varchar(50),
@Nacionalidad int,
@Profesion varchar(25),
@Correo varchar(30),
@Telefono varchar(15),
@FechaNacimiento datetime
as
Update Cliente set TipoDoc=@TipoDoc,LugarExpedicion=@LugarExpedicion,
Nombres=@Nombres,Apellidos=@Apellidos,Nacionalidad=@Nacionalidad,Profesion= @Profesion,
Correo=@Correo,Telefono= @Telefono,FechaNacimiento= @FechaNacimiento 
where NumDocumento = @NumDocumento
go

--Reservas
create procedure SP_InsertarReserva
@NumHabitacion varchar(5),
@FechaIngreso datetime,
@FechaSalida datetime,
@MetodoReserva int,
@Estado int,
@Precio float
as
Insert into Reserva (NumHabitacion,FechaIngreso,FechaSalida,MetodoReserva,Estado,Precio)
Values (@NumHabitacion,@FechaIngreso,@FechaSalida,@MetodoReserva,@Estado,@Precio)
go

Create procedure SP_buscarReservaMayor
as
select max(Codigo) as Codigo from Reserva
go

--Huespedes
Create procedure SP_InsertarHuespedes
@NumDocuTitular varchar(20),
@CodReserva int,
@NumDocuAcompañante varchar(20),
@CiuProcedencia int,
@CiuDestino int,
@Empresa varchar(20)
as
Insert into Huespedes 
Values
(@NumDocuTitular, @CodReserva, @NumDocuAcompañante, @CiuProcedencia, @CiuDestino, @Empresa)
go

--Insertar Abono
Create procedure SP_InsertarAbono
@CodReserva int, 
@MetodoPago int, 
@fecha date,
@valor int
as
Insert into Abonos Values (@CodReserva,@MetodoPago,@fecha,@valor)
go



exec SP_InsertarCliente 5734373839, 2, 849, Eulogio, 'Eiravella Mujica', 63, 'Estudiante prostituto', 'Eulogiomujica@gmail.com', 3116521515, '2001-07-29'
select * from Cliente
select * from Reserva
select * from Huespedes
select * from Pais order by Nombre asc















--Depronto toque usarlo
select C.NumDocumento, Td.Nombre as 'tipo de documento', Ci.Nombre as 'Expedido', C.Nombres, C.Apellidos, P.Nombre as Nacionalidad, C.Profesion, C.Correo, C.Telefono, C.FechaNacimiento
from Cliente as C
join Pais as P
on C.Nacionalidad = P.Codigo
join  Ciudad as Ci
on C.LugarExpedicion = Ci.Codigo
join TipoDocumento as Td
on C.TipoDoc = Td.Codigo