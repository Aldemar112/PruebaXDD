Create database Hotel_Rivera
use Hotel_Rivera

--Roles como Admin y Recepcionista
Create table Roles(
	Codigo int primary key,
	Nombre varchar(50)
)
Create table Usuario(
	Cedula varchar(15) primary key,
	Nombre varchar(70),
	Contraseña Varchar(100),
	Correo varchar(70),
	CodRoles int,
	Estado bit,
	Foreign key (CodRoles) references Roles(Codigo)
)
--Estados como Inactivo, Cancelado, En uso, Facturado
Create table Estado(
	Codigo int primary key,
	Nombre varchar(50)
)
--Habitaicones como Quintuple, Twin, Apto, Suite, Doble
Create table TipoHabitacion(
	Codigo int primary key,
	Nombre varchar(50)
)
--Metodo como Efectivo y Tarjeta
Create table MetodoAbono(
	Codigo int primary key,
	Nombre varchar(50)
)
--Tipos como CC,TI y CE
Create table TipoDocumento(
	Codigo int primary key,
	Nombre varchar(50)
)
--Booking, Telefono, Presencial y no hay
Create table MetodoReserva(
	Codigo int primary key,
	Nombre varchar(50)
)
Create table Pais(
	Codigo int primary key,
	Nombre varchar(50)
)
Create table Departamento(
	Codigo int primary key,
	Nombre varchar(50),
	CodPais int,
	Foreign key (CodPais) References Pais(Codigo)
)
Create table Ciudad(
	Codigo int primary key,
	Nombre varchar(50),
	CodDepartamento int,
	Foreign key (CodDepartamento) References Departamento(Codigo)
)

Create table Cliente(
	NumDocumento Varchar(20) primary key,
	TipoDoc int,--
	LugarExpedicion int,--
	Nombres varchar(50),
	Apellidos varchar(50),
	Nacionalidad int,--
	Profesion varchar(25),
	Correo varchar(30),
	Telefono varchar(15),
	FechaNacimiento datetime,
	Foreign key (TipoDoc) references TipoDocumento(Codigo),
	Foreign key (LugarExpedicion) references Ciudad(Codigo),
	Foreign key (Nacionalidad) references Pais(Codigo)
)

Create table Habitacion(
	NumHabitacion varchar(5) primary key,
	Descripcion varchar(60),
	AireAcondicionado bit,
	TipoHabitacion int,
	Estado bit,
	Valor float,
	Foreign key (TipoHabitacion) references TipoHabitacion(Codigo)
)

Create table Reserva(
	Codigo int primary key,
	NumHabitacion varchar(5),
	FechaIngreso datetime,
	FechaSalida datetime,
	MetodoReserva int,
	Estado int,
	Precio float,
	Foreign key (NumHabitacion) references Habitacion(NumHabitacion),
	Foreign key (MetodoReserva) references MetodoReserva(Codigo),
	Foreign key (Estado) references Estado(Codigo)
)

Create table Descripcion(
	Codigo int primary key,
	CodReserva int,
	Cantidad int,
	Descripcion varchar(100),
	Precio float,
	Foreign key (CodReserva) references Reserva(Codigo)
)

Create table Huespedes(
	Codigo int primary key,
	NumDocuTitular varchar(20),
	CodReserva int,
	NumDocuAcompañante varchar(20),
	CiuProcedencia int,
	CiuDestino int,
	Empresa varchar(20),
	Foreign key (NumDocuTitular) references Cliente(NumDocumento),
	Foreign key (CodReserva) references Reserva(Codigo),
	Foreign key (NumDocuAcompañante) references Cliente(NumDocumento),
	Foreign key (CiuProcedencia) references Ciudad(Codigo),
	Foreign key (CiuDestino) references Ciudad(Codigo)
)

Create table Factura(
	NumFactura varchar(5) primary key,
	Total float,
	FechaFactura datetime,
	CodUsuario varchar(15),
	Foreign key (CodUsuario) references Usuario(Cedula)
)

Create table FacturaReservas(
	Codigo int primary key,
	CodReserva int,
	CodFactura varchar(5),
	Total Float,
	Foreign key (CodReserva) references Reserva(Codigo),
	Foreign key (CodFactura) references Factura(NumFactura)
)
CREATE TABLE Abonos(
    Codigo int primary key identity(1,1), 
    CodReserva int, 
    MetodoPago int, 
    fecha date,
    valor int,
	Foreign key (CodReserva) references Reserva(Codigo),
	Foreign key (MetodoPago) references MetodoAbono(Codigo)
)

alter authorization on database:: Hotel_Rivera to sa


select * from Departamento where CodPais = 82