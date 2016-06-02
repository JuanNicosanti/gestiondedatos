----- Creación de Esquema ------

create schema ROAD_TO_PROYECTO
GO

----- Funciones -----
create function ROAD_TO_PROYECTO.SacarTildes(@Usuario nvarchar(255))
returns nvarchar(255)
as begin
return (replace(replace(replace(replace(replace (@Usuario, 'á', 'a'),'é','e'),'í','i'),'ó','o'),'ú','u'))
end
GO

create function ROAD_TO_PROYECTO.SacarDosPuntos(@DosPuntos nvarchar(255))
returns nvarchar(255)
as begin
return replace(@DosPuntos,':',0)
end
GO

create function ROAD_TO_PROYECTO.OfertaGanadora(@Publicacion int, @Oferta numeric(18,2) )
returns int 
as begin
IF exists (select Publicacion_Cod from gd_esquema.Maestra where publicacion_cod=@Publicacion group by publicacion_cod having count(*)= 1)
  return 1
ELSE IF (select max(Oferta_Monto) from gd_esquema.Maestra where Publicacion_Cod = @Publicacion) = @Oferta
  return 1
  return 0
  end
 GO

------ Creación de Tablas -----
PRINT 'Creando Tablas...'

--Domicilio
create table ROAD_TO_PROYECTO.Domicilio(
DomiId int identity(1,1) PRIMARY KEY,
Calle nvarchar(100),
Numero numeric(18,0),
Piso numeric(18,0),
Depto nvarchar(50),
CodPostal nvarchar(50),
Localidad nvarchar(100),
)
GO

--Usuario
create table ROAD_TO_PROYECTO.Usuario (
Usuario nvarchar(255) PRIMARY KEY,
Contraseña nvarchar(255) NOT NULL,
Mail nvarchar(50),
Habilitado bit default 1,
Nuevo bit default 1,
Reputacion numeric(18,2),
FechaCreacion datetime,
Domicilio int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Domicilio,
LogsFallidos TinyInt
)
GO

--Rubro
create table ROAD_TO_PROYECTO.Rubro(
RubrId int identity(1,1) PRIMARY KEY,
DescripCorta nvarchar(80),
DescripLarga nvarchar(255)
)
GO

--Cliente
create table ROAD_TO_PROYECTO.Cliente (
ClieId int identity(1,1) PRIMARY KEY,
TipoDocumento nvarchar(5),
NroDocumento numeric(18,0),
Apellido nvarchar(255),
Nombres nvarchar(255),
FechaNacimiento datetime,
Telefono numeric(18,0),
CONSTRAINT Cliente_Tipo_Nro_Doc UNIQUE (TipoDocumento, NroDocumento)
)
GO

--Empresa
create table ROAD_TO_PROYECTO.Empresa(
EmprId int identity(1,1) PRIMARY KEY,
RazonSocial nvarchar(255),
CUIT nvarchar(50),
FechaCreacion datetime,
NombreContacto nvarchar(100),
Rubro int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Rubro,
Telefono numeric(18,0),
CONSTRAINT Empresa_Tipo_Nro_Doc UNIQUE (RazonSocial, CUIT)
) 
GO

--Rol
create table ROAD_TO_PROYECTO.Rol(
RolId int identity(1,1) PRIMARY KEY,
Nombre nvarchar(255) NOT NULL,
Habilitado bit default 1
)
GO

--Funciones
create table ROAD_TO_PROYECTO.Funcion(
FuncId int identity(1,1) PRIMARY KEY,
Descripcion nvarchar(255),
Funcion text
)
GO

--Funciones_Por_Rol
create table ROAD_TO_PROYECTO.Funciones_Por_Rol(
RolId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Rol,
FuncId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Funcion,
PRIMARY KEY (RolId, FuncId)
)
GO

--Roles_Por_Usuario
create table ROAD_TO_PROYECTO.Roles_Por_Usuario(
UserId nvarchar(255) FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Usuario,
RolId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Rol,
IdExterno int,
PRIMARY KEY (UserId, RolId)
)
GO

--Visibilidad
create table ROAD_TO_PROYECTO.Visibilidad(
VisiId int PRIMARY KEY,
Descripcion nvarchar(255),
ComiFija numeric (18,2),
ComiVariable numeric (18,2),
ComiEnvio numeric (18,2) default 0
)
GO

--Estado
create table ROAD_TO_PROYECTO.Estado(
EstadoId int identity(1,1) PRIMARY KEY,
Descripcion nvarchar(50)
)
GO

--Tipo_Publicacion
create table ROAD_TO_PROYECTO.Tipo_Publicacion(
TipoPubliId int identity (1,1) PRIMARY KEY,
Descripcion nvarchar(255)
)
GO

--Publicacion
create table ROAD_TO_PROYECTO.Publicacion(
PublId int PRIMARY KEY,
Descipcion nvarchar(255) NOT NULL,
Stock numeric(18,0) NOT NULL,
FechaInicio datetime NOT NULL,
FechaFin datetime NOT NULL,
Precio numeric(18,2) NOT NULL,
Visibilidad int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Visibilidad NOT NULL,
Rubro int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Rubro NOT NULL,
Tipo int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Tipo_Publicacion NOT NULL,
Estado int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Estado NOT NULL,
UserId nvarchar(255) FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Usuario NOT NULL,
EnvioHabilitado bit default 0
)
GO

--Transaccion
create table ROAD_TO_PROYECTO.Transaccion(
TranId int identity(1,1) PRIMARY KEY,
TipoTransac nvarchar(50),
Fecha datetime,
Cantidad numeric(18,0),
Monto numeric(18,2),
Ganadora bit default 0,
PubliId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Publicacion,
ClieId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Cliente,
ConEnvio bit default 0
)
GO

--Calificacion
create table ROAD_TO_PROYECTO.Calificacion(
CaliId int PRIMARY KEY,
TranId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Transaccion,
CantEstrellas numeric(18,0),
Descipcion nvarchar(255)
)
GO

--Factura
create table ROAD_TO_PROYECTO.Factura(
FactNro numeric(18,0) PRIMARY KEY,
PubliId int FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Publicacion,
Fecha datetime,
Monto numeric(18,2),
FormaPago nvarchar(255),
)
GO

--Item_Factura
create table ROAD_TO_PROYECTO.Item_Factura(
ItemId int identity(1,1) PRIMARY KEY,
FactNro numeric(18,0) FOREIGN KEY REFERENCES ROAD_TO_PROYECTO.Factura,
Cantidad numeric(18,0),
Detalle nvarchar(255),
Monto numeric(18,2)
)
GO

----- Migración de Datos -----
PRINT 'Comenzando Migración de Datos...'

--Domicilios
PRINT 'Migrando Domicilios...'
insert into ROAD_TO_PROYECTO.Domicilio
select publ_empresa_dom_calle, publ_empresa_nro_calle,publ_empresa_piso,publ_empresa_depto,publ_empresa_cod_postal, NULL
from gd_esquema.Maestra
where publ_empresa_dom_calle is not null
group by publ_empresa_dom_calle, publ_empresa_nro_calle,publ_empresa_piso,publ_empresa_depto,publ_empresa_cod_postal
UNION
select Cli_Dom_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto, Cli_Cod_Postal, NULL
from gd_esquema.Maestra
where Cli_Dom_Calle is not null
group by Cli_Dom_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto, Cli_Cod_Postal
GO

--Usuarios 
PRINT 'Asignando Usuarios...'
insert into ROAD_TO_PROYECTO.Usuario
select ROAD_TO_PROYECTO.SacarTildes(LOWER(Cli_Apeliido+RIGHT(Cli_Nombre,1))), SUBSTRING(master.dbo.fn_varbintohexstr(HashBytes('SHA2_256', 'password')), 3, 255),Cli_Mail,1,0,NULL,getdate() as Fecha, (select DomiId from ROAD_TO_PROYECTO.Domicilio where RTRIM(Calle) like RTRIM(Cli_Dom_Calle) and Numero = Cli_Nro_Calle and Piso = Cli_Piso and Depto = Cli_Depto and CodPostal = Cli_Cod_Postal) as Domicilio, 0 
from gd_esquema.Maestra
where Cli_Apeliido is not null and Cli_Nombre is not null
group by Cli_Apeliido,Cli_Nombre,Cli_Mail,Cli_Dom_Calle,Cli_Nro_Calle,Cli_Piso,cli_depto,Cli_Cod_Postal
UNION
select ROAD_TO_PROYECTO.SacarDosPuntos(LOWER('razonsocial'+RIGHT(publ_empresa_razon_social,2))),'password',publ_empresa_mail,1,0,NULL,getdate(), (select DomiId from ROAD_TO_PROYECTO.Domicilio where RTRIM(Calle) like RTRIM(Publ_Empresa_Dom_Calle) and Numero = Publ_Empresa_Nro_Calle and Piso = Publ_Empresa_Piso and Depto = Publ_Empresa_Depto and CodPostal = Publ_Empresa_Cod_Postal), 0
from gd_esquema.Maestra
where publ_empresa_razon_social is not null
group by publ_empresa_razon_social,publ_empresa_mail, Publ_Empresa_Dom_Calle,Publ_empresa_Nro_Calle,Publ_Empresa_Piso,Publ_Empresa_Depto,Publ_Empresa_Cod_Postal

--Rubros
PRINT 'Migrando Rubros...'
insert into ROAD_TO_PROYECTO.Rubro
select NULL,publicacion_rubro_descripcion
from gd_esquema.Maestra
where publicacion_rubro_descripcion is not null
group by Publicacion_Rubro_Descripcion
GO
  
--Cliente
PRINT 'Migrando Clientes...'
insert into ROAD_TO_PROYECTO.Cliente
select 'DNI', Cli_Dni, Cli_Apeliido, Cli_Nombre, Cli_Fecha_Nac, NULL
from gd_esquema.Maestra
where Cli_Dni is not null
group by Cli_Dni, Cli_Apeliido, Cli_Nombre, Cli_Fecha_Nac
GO

--Empresa
PRINT 'Migrando Empresas...'
insert into ROAD_TO_PROYECTO.Empresa
select Publ_Empresa_Razon_Social, Publ_Empresa_Cuit, Publ_Empresa_Fecha_Creacion, NULL, NULL, NULL
from gd_esquema.Maestra
where Publ_Empresa_Cuit is not null
group by Publ_Empresa_Razon_Social, Publ_Empresa_Cuit, Publ_Empresa_Fecha_Creacion
order by Publ_Empresa_Razon_Social
GO

--Tal vez pueda determinar el rubro de la empresa segun el rubro de las publicaciones, igual es relativo

--Rol
PRINT 'Creando Roles...'
insert into ROAD_TO_PROYECTO.Rol values('Administrador',1)
insert into ROAD_TO_PROYECTO.Rol values('Cliente',1)
insert into ROAD_TO_PROYECTO.Rol values('Empresa',1)
GO

--Funciones
PRINT 'Creando Funciones...'
insert into ROAD_TO_PROYECTO.Funcion values('ABM Rol','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('ABM Usuario','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('ABM Visibilidad','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('ABM Rubro','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('Generar Publicación','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('Comprar/Ofertar','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('Historial de Cliente','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('Calificar al Vendedor','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('Consulta de facturas realizadas al vendedor','Codigo en C# que habilite esta funcion')
insert into ROAD_TO_PROYECTO.Funcion values('Listado Estadístico','Codigo en C# que habilite esta funcion')

--Funciones por rol
PRINT 'Creando Funciones Por Rol...'
insert into ROAD_TO_PROYECTO.Funciones_Por_Rol select RolId,FuncId from ROAD_TO_PROYECTO.Rol,ROAD_TO_PROYECTO.Funcion where Nombre = 'Administrador' and Descripcion in ('ABM Rubro','ABM Rol','ABM Visibilidad','ABM Usuario')
insert into ROAD_TO_PROYECTO.Funciones_Por_Rol select RolId,FuncId from ROAD_TO_PROYECTO.Rol,ROAD_TO_PROYECTO.Funcion where nombre = 'Cliente' and Descripcion in ('Generar Publicación','Comprar/Ofertar','Historial de Cliente','Calificar al Vendedor','Consulta de facturas realizadas al vendedor','Listado Estadístico')
insert into ROAD_TO_PROYECTO.Funciones_Por_Rol select RolId,FuncId from ROAD_TO_PROYECTO.Rol,ROAD_TO_PROYECTO.Funcion where nombre = 'Empresa' and Descripcion in ('Generar Publicación','Consulta de facturas realizadas al vendedor','Listado Estadístico')
--Roles por usuario
PRINT 'Creando Roles por Usuario...'
insert into ROAD_TO_PROYECTO.Roles_Por_Usuario
select ROAD_TO_PROYECTO.SacarTildes(LOWER(Apellido+RIGHT(Nombres,1))), (select RolId from ROAD_TO_PROYECTO.Rol where Nombre = 'Cliente'), ClieId
from ROAD_TO_PROYECTO.Cliente
UNION
select ROAD_TO_PROYECTO.SacarDosPuntos(LOWER('razonsocial'+RIGHT(RazonSocial,2))), (select RolId from ROAD_TO_PROYECTO.Rol where Nombre = 'Empresa'), EmprId
from ROAD_TO_PROYECTO.Empresa
GO

--Visibilidad
PRINT 'Migrando Visibilidades...'
insert into ROAD_TO_PROYECTO.Visibilidad (VisiId, Descripcion, ComiFija, ComiVariable)
select Publicacion_Visibilidad_Cod, Publicacion_Visibilidad_Desc, Publicacion_Visibilidad_Precio, Publicacion_Visibilidad_Porcentaje
from gd_esquema.Maestra
where Publicacion_Visibilidad_Cod is not null
group by publicacion_visibilidad_cod, Publicacion_Visibilidad_Desc, Publicacion_Visibilidad_Precio, Publicacion_Visibilidad_Porcentaje
GO

update ROAD_TO_PROYECTO.Visibilidad
set ComiEnvio = 0.05
where VisiId = 10002 or VisiId = 10003
GO

update ROAD_TO_PROYECTO.Visibilidad
set ComiEnvio = 0.01
where VisiId = 10004 or VisiId = 10005
GO

--Estado
PRINT 'Migrando Estados de publicaciones...'
insert into ROAD_TO_PROYECTO.Estado values('Borrador')
insert into ROAD_TO_PROYECTO.Estado values('Activa')
insert into ROAD_TO_PROYECTO.Estado values('Pausada')
insert into ROAD_TO_PROYECTO.Estado values('Finalizada')
GO

--Tipo_Publicacion
PRINT 'Migrando Tipos de publicaciones...'
insert into ROAD_TO_PROYECTO.Tipo_Publicacion 
select Publicacion_Tipo
from gd_esquema.Maestra
where Publicacion_Tipo is not null
group by Publicacion_Tipo
GO

--Publicacion
PRINT 'Migrando publicaciones...'
insert into ROAD_TO_PROYECTO.Publicacion
select Publicacion_Cod, Publicacion_Descripcion, Publicacion_Stock, Publicacion_Fecha, Publicacion_Fecha_Venc, Publicacion_Precio, Publicacion_Visibilidad_Cod, (select RubrId from ROAD_TO_PROYECTO.Rubro where publicacion_rubro_descripcion = DescripLarga) as Rubro, (select TipoPubliId from ROAD_TO_PROYECTO.Tipo_Publicacion where Publicacion_Tipo = Descripcion) as TipoPublicacion, 3 as Estado, (select Usuario from ROAD_TO_PROYECTO.Usuario where Mail = Publ_Cli_Mail or Mail = Publ_Empresa_Mail) as Usuario, 0
from gd_esquema.Maestra
where Publicacion_Cod is not null
group by Publicacion_Cod, Publicacion_Descripcion, Publicacion_Stock, Publicacion_Fecha, Publicacion_Fecha_Venc, Publicacion_Precio, Publicacion_Visibilidad_Cod, Publicacion_Rubro_Descripcion,Publ_Cli_Mail, Publicacion_Tipo, Publ_Empresa_Mail
GO

--Transaccion
PRINT 'Migrando transacciones...'
insert into ROAD_TO_PROYECTO.Transaccion
select 'Compra', Compra_Fecha, Compra_Cantidad, null, null, Publicacion_Cod, (select ClieId from ROAD_TO_PROYECTO.Cliente where Cli_Dni = NroDocumento), 0
from gd_esquema.Maestra
where Publicacion_Tipo = 'Compra Inmediata' and Compra_Fecha is not null 
group by publicacion_cod, Compra_Fecha, Compra_Cantidad, Cli_Dni
union
select 'Oferta', Oferta_Fecha, 1, Oferta_Monto, 0, Publicacion_Cod, (select ClieId from ROAD_TO_PROYECTO.Cliente where Cli_Dni = NroDocumento), 0
from gd_esquema.Maestra
where Publicacion_Tipo = 'Subasta' and Oferta_Fecha is not null
group by Publicacion_Cod, Oferta_Fecha, Oferta_Monto, Cli_Dni
GO

update t1 set Ganadora = 1
from ROAD_TO_PROYECTO.Transaccion t1
where TipoTransac = 'Oferta' and TranId in (select top 1 t2.TranId 
											from ROAD_TO_PROYECTO.Transaccion t2
											where t2.TipoTransac = 'Oferta' and t1.PubliId = t2.PubliId
											order by t2.PubliId, t2.Monto desc)

--Calificacion
insert into ROAD_TO_PROYECTO.Calificacion
select Calificacion_Codigo, t.TranId,Calificacion_Cant_Estrellas,Calificacion_Descripcion
from gd_esquema.Maestra gd,ROAD_TO_PROYECTO.TRANSACCION t,ROAD_TO_PROYECTO.Cliente c
where t.PubliId = gd.Publicacion_Cod and t.clieid = c.ClieId and c.NroDocumento = gd.Cli_Dni and t.fecha = Compra_Fecha and t.cantidad = Compra_Cantidad and gd.Calificacion_Cant_Estrellas is not null and (t.ganadora = 1 or t.tipotransac = 'Compra') 
GO

--Factura
insert into ROAD_TO_PROYECTO.Factura
select gd.Factura_Nro,Publicacion_Cod, gd.factura_fecha,gd.factura_total, gd.forma_pago_desc
from gd_esquema.Maestra gd
where  Factura_nro is not null 
group by factura_nro,Factura_Fecha,Factura_Total,Forma_Pago_Desc,Publicacion_Cod
GO

--FUNCIONES PARA MIGRAR ITEMS

create function ROAD_TO_PROYECTO.EspecificarDetalle(@Cantidad numeric(18,0), @Monto numeric(18,2), @PrecioVisibilidad numeric(18,2), @PorcentajeComision numeric(18,2), @PrecioPublicacion numeric(18,2))
returns nvarchar(255)
as begin
if @Monto = @PrecioVisibilidad
return 'Precio por tipo publicación'
else if ROUND(@Monto,0) = ROUND(@PrecioPublicacion * @PorcentajeComision * @Cantidad,0)
 or ROUND(@Monto,0) = ROUND(@PrecioPublicacion * @PorcentajeComision * @Cantidad,0,1)
 or ROUND(@Monto,0,1) = ROUND(@PrecioPublicacion * @PorcentajeComision * @Cantidad,0)
 or ROUND(@Monto,0,1) = ROUND(@PrecioPublicacion * @PorcentajeComision * @Cantidad,0,1)
return 'Comisión por productos vendidos'
return NULL
end 
GO

--Item Factura
insert into ROAD_TO_PROYECTO.Item_Factura
select f.FactNro, gd.Item_Factura_Cantidad,ROAD_TO_PROYECTO.EspecificarDetalle(gd.Item_Factura_Cantidad,gd.Item_Factura_Monto,gd.Publicacion_Visibilidad_Precio,gd.Publicacion_Visibilidad_Porcentaje,gd.Publicacion_Precio), gd.Item_Factura_Monto
from gd_esquema.Maestra gd,ROAD_TO_PROYECTO.Factura f
where gd.Factura_Nro is not null and f.FactNro = gd.Factura_Nro and ROAD_TO_PROYECTO.EspecificarDetalle(gd.Item_Factura_Cantidad,gd.Item_Factura_Monto,gd.Publicacion_Visibilidad_Precio,gd.Publicacion_Visibilidad_Porcentaje,gd.Publicacion_Precio) is not null
GO

----- Otras Funciones -----

----- Stored Procedures -----
--Listado Roles
CREATE PROCEDURE ROAD_TO_PROYECTO.ListaRoles
	as begin
		select RolId, Nombre 
		from ROAD_TO_PROYECTO.Rol
	end
GO

--Alta Rol
CREATE PROCEDURE ROAD_TO_PROYECTO.AltaRol
@Nombre nvarchar(255)
as begin
if not exists (select Nombre from ROAD_TO_PROYECTO.Rol where Nombre = @Nombre)
insert into ROAD_TO_PROYECTO.Rol values(@Nombre,1)
end
GO

--Asignar una funcion a un rol
CREATE PROCEDURE ROAD_TO_PROYECTO.AsignarFuncionARol
@Rol nvarchar(255),
@Funcion nvarchar(255)
as begin
declare @RolId int = (select rolid from ROAD_TO_PROYECTO.Rol where Nombre = @Rol)
declare @FuncId int = (select funcid from ROAD_TO_PROYECTO.Funcion where Descripcion = @Funcion)

if not exists(select FuncId from ROAD_TO_PROYECTO.Funciones_Por_Rol where RolId = @RolId and FuncId = @FuncId)
insert into ROAD_TO_PROYECTO.Funciones_Por_Rol values (@RolId,@FuncId)
end
GO

--Desasignar una funcion a un rol
CREATE PROCEDURE ROAD_TO_PROYECTO.DesasignarFuncionARol
@Rol nvarchar(255),
@Funcion nvarchar(255)
as begin
declare @RolId int = (select rolid from ROAD_TO_PROYECTO.Rol where Nombre = @Rol)
declare @FuncId int = (select funcid from ROAD_TO_PROYECTO.Funcion where Descripcion = @Funcion)

if exists(select FuncId from ROAD_TO_PROYECTO.Funciones_Por_Rol where RolId = @RolId and FuncId = @FuncId)
delete ROAD_TO_PROYECTO.Funciones_Por_Rol where FuncId = @FuncId and RolId = @RolId
end
GO 

--Dar de baja un rol
CREATE PROCEDURE ROAD_TO_PROYECTO.BajaRol
@Rol int
as begin
update ROAD_TO_PROYECTO.Rol set Habilitado = 0 where RolId = @Rol
delete ROAD_TO_PROYECTO.Roles_Por_Usuario where RolId = @Rol
end
GO

--Listado Rubros
CREATE PROCEDURE ROAD_TO_PROYECTO.ListaRubros
	as begin
		select DescripLarga
		from ROAD_TO_PROYECTO.Rubro
		order by DescripLarga
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Usuario_Logs_Fallidos
	@Usuario nvarchar(255),
	@Contraseña nvarchar(255)
	as
	begin
	if(select habilitado from ROAD_TO_PROYECTO.Usuario where @Usuario = Usuario)=1
	begin
		update ROAD_TO_PROYECTO.Usuario set LogsFallidos = LogsFallidos + 1
		where Usuario = @Usuario and Contraseña != @Contraseña
		update ROAD_TO_PROYECTO.Usuario set LogsFallidos = 0
		where Usuario = @Usuario and Contraseña = @Contraseña
	end
		update ROAD_TO_PROYECTO.Usuario set Habilitado = 0
		where LogsFallidos = 3
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Usuario_Login
	@username nvarchar(255),
	@password nvarchar(255)
	as
	begin 
		execute ROAD_TO_PROYECTO.Usuario_Logs_Fallidos @Usuario = @username, @Contraseña = @password
		select u.Usuario as username, u.Contraseña as password, u.Habilitado as habilitado, rpu.RolId as rol 
		from ROAD_TO_PROYECTO.Usuario u, ROAD_TO_PROYECTO.Roles_Por_Usuario rpu
		where Usuario = @username and Contraseña = @password
		and u.Usuario = rpu.UserId
		
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Alta_Domicilio
	@Calle nvarchar(100),
	@Numero numeric(18,0),
	@Piso numeric(18,0),
	@Depto nvarchar(50),
	@CodPostal nvarchar(50),
	@Localidad nvarchar(100)
	as
	begin
		if not exists(select * from ROAD_TO_PROYECTO.Domicilio where @Calle = Calle and @Numero = Numero and @Piso = Piso and @Depto = Depto and @CodPostal = CodPostal and @Localidad = Localidad)
		insert into ROAD_TO_PROYECTO.Domicilio (Calle, Numero, Piso, Depto, CodPostal, Localidad)
		values (@Calle, @Numero, @Piso, @Depto, @CodPostal, @Localidad)
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Alta_Rol_Usuario
	@Usuario nvarchar(255),
	@RolAsignado nvarchar(255),
	@IdExterno int

	as
	begin
		if not exists(select rpu.UserId,rpu.RolId from ROAD_TO_PROYECTO.Roles_Por_Usuario rpu where rpu.UserId = @Usuario and rpu.RolId = (select RolId from ROAD_TO_PROYECTO.Rol r where r.Nombre = @RolAsignado))
		begin
			insert into ROAD_TO_PROYECTO.Roles_Por_Usuario (UserId, RolId, IdExterno)
			values (@Usuario, (select RolId from ROAD_TO_PROYECTO.Rol r where r.Nombre = @RolAsignado), @IdExterno)
		end					
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Alta_Cliente
	@Usuario nvarchar(255),
	@Contraseña nvarchar(255),
	@Mail nvarchar(50),
	@RolAsignado nvarchar(255),
	@TipoDocumento nvarchar(5),
	@NroDocumento numeric(18,0),
	@Apellido nvarchar(255),
	@Nombres nvarchar(255),
	@FechaNacimiento datetime,
	@Telefono numeric(18,0),


	@Calle nvarchar(100),
	@Numero numeric(18,0),
	@Piso numeric(18,0),
	@Depto nvarchar(50),
	@CodPostal nvarchar(50),
	@Localidad nvarchar(100)

	as
	begin
		declare	@IdExterno int
		if(@RolAsignado = 'Cliente')
		begin
			if not exists(select c.NroDocumento from ROAD_TO_PROYECTO.Cliente c where c.TipoDocumento = @TipoDocumento and c.NroDocumento = @NroDocumento)
			begin
				execute ROAD_TO_PROYECTO.Alta_Usuario @Usuario = @Usuario, @Contraseña = @Contraseña, @Mail = @Mail, @RolAsignado = @RolAsignado
									
				insert into ROAD_TO_PROYECTO.Cliente (TipoDocumento, NroDocumento, Apellido, Nombres, FechaNacimiento, Telefono)
				values (@TipoDocumento, @NroDocumento, @Apellido, @Nombres, @FechaNacimiento, @Telefono)
			
				select @IdExterno = SCOPE_IDENTITY()
				execute ROAD_TO_PROYECTO.Alta_Rol_Usuario @Usuario = @Usuario, @RolAsignado = @RolAsignado, @IdExterno = @IdExterno
				execute ROAD_TO_PROYECTO.Domicilio_Usuario @Usuario = @Usuario, @Calle = @Calle, @Numero = @Numero, @Piso = @Piso, @Depto = @Depto, @CodPostal = @CodPostal, @Localidad = @Localidad
			end
		end
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Alta_Empresa
	@Usuario nvarchar(255),
	@Contraseña nvarchar(255),
	@Mail nvarchar(50),
	@RolAsignado nvarchar(255),
	@RazonSocial nvarchar(255),
	@CUIT nvarchar(50),
	@FechaCreacion datetime,
	@NombreContacto nvarchar(100),
	@Rubro nvarchar(255),
	@Telefono numeric(18,0),

	@Calle nvarchar(100),
	@Numero numeric(18,0),
	@Piso numeric(18,0),
	@Depto nvarchar(50),
	@CodPostal nvarchar(50),
	@Localidad nvarchar(100)

	as
	begin
		declare	@IdExterno int

		if(@RolAsignado = 'Empresa')
		begin
			if not exists(select e.EmprId from ROAD_TO_PROYECTO.Empresa e where e.CUIT = @CUIT and e.RazonSocial = @RazonSocial)
			begin
				execute ROAD_TO_PROYECTO.Alta_Usuario @Usuario = @Usuario, @Contraseña = @Contraseña, @Mail = @Mail, @RolAsignado = @RolAsignado
				
				insert into ROAD_TO_PROYECTO.Empresa (RazonSocial, CUIT, FechaCreacion, NombreContacto, Rubro, Telefono)
				values (@RazonSocial, @CUIT, @FechaCreacion, @NombreContacto, (select RubrId from ROAD_TO_PROYECTO.Rubro r where r.DescripLarga = @Rubro), @Telefono)
			
				select @IdExterno = SCOPE_IDENTITY()
				execute ROAD_TO_PROYECTO.Alta_Rol_Usuario @Usuario = @Usuario, @RolAsignado = @RolAsignado, @IdExterno = @IdExterno
				execute ROAD_TO_PROYECTO.Domicilio_Usuario @Usuario = @Usuario, @Calle = @Calle, @Numero = @Numero, @Piso = @Piso, @Depto = @Depto, @CodPostal = @CodPostal, @Localidad = @Localidad
			end
		end
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Alta_Usuario
	@Usuario nvarchar(255),
	@Contraseña nvarchar(255),
	@Mail nvarchar(50),
	@RolAsignado nvarchar(255)
	as
	begin
		if(not exists(select u.Usuario from ROAD_TO_PROYECTO.Usuario u where u.Usuario = @Usuario))
		begin
			insert into ROAD_TO_PROYECTO.Usuario (Usuario, Contraseña, Mail, Habilitado, Nuevo, Reputacion, FechaCreacion,/*Domicilio,*/ LogsFallidos)
			values (@Usuario, @Contraseña, @Mail, 1, 1, null, GETDATE(), 0)
		end
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Domicilio_Usuario
	@Usuario nvarchar(255),
	@Calle nvarchar(100),
	@Numero numeric(18,0),
	@Piso numeric(18,0),
	@Depto nvarchar(50),
	@CodPostal nvarchar(50),
	@Localidad nvarchar(100)
	as
	begin
		execute ROAD_TO_PROYECTO.Alta_Domicilio @Calle = @Calle, @Numero = @Numero, @Piso = @Piso, @Depto = @Depto, @CodPostal = @CodPostal, @Localidad = @Localidad
		update ROAD_TO_PROYECTO.Usuario 
		set Domicilio = (select top 1 DomiId from ROAD_TO_PROYECTO.Domicilio
						where Calle = @Calle and Numero = @Numero and Piso = @Piso and Depto = @Depto and CodPostal = @CodPostal and Localidad = @Localidad)
		where Usuario = @Usuario
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Cambiar_Contraseña
	@Usuario nvarchar(255),
	@Contraseña nvarchar(255),
	@ContraseñaNueva nvarchar(255)
	as
	begin
		if exists(select Usuario,Contraseña from ROAD_TO_PROYECTO.Usuario where @Usuario = Usuario and @Contraseña = Contraseña)
		begin
			update ROAD_TO_PROYECTO.Usuario set Contraseña = @ContraseñaNueva
			where @Usuario = Usuario and @Contraseña = Contraseña
		end
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Buscar_Cliente
	@Mail nvarchar(50),
	@TipoDocumento nvarchar(5),
	@NroDocumento numeric(18,0),
	@Apellido nvarchar(255),
	@Nombres nvarchar(255)
	as
	begin
		--update u set Habilitado = 0
		select u.Usuario, u.Mail, c.TipoDocumento, c.NroDocumento, c.Apellido, c.Nombres
		from ROAD_TO_PROYECTO.Usuario u, ROAD_TO_PROYECTO.Cliente c, ROAD_TO_PROYECTO.Roles_Por_Usuario rpu
		where rpu.UserId = u.Usuario and rpu.RolId = (select RolId from ROAD_TO_PROYECTO.Rol r where r.Nombre = 'Cliente') and rpu.IdExterno = c.ClieId
		and c.Nombres like '%'+ @Nombres +'%'
		and c.Apellido like '%'+ @Apellido +'%'
		and c.TipoDocumento = @TipoDocumento
		and c.NroDocumento = @NroDocumento
		and u.Mail like '%'+ @Mail +'%'
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Buscar_Empresa
	@RazonSocial nvarchar(255),
	@CUIT nvarchar(50),
	@Mail nvarchar(50)
	as
	begin
		--update u set Habilitado = 0
		select u.Usuario, u.Mail, e.RazonSocial, e.CUIT
		from ROAD_TO_PROYECTO.Usuario u, ROAD_TO_PROYECTO.Empresa e, ROAD_TO_PROYECTO.Roles_Por_Usuario rpu
		where rpu.UserId = u.Usuario and rpu.RolId = (select RolId from ROAD_TO_PROYECTO.Rol r where r.Nombre = 'Empresa') and rpu.IdExterno = e.EmprId
		and e.RazonSocial like '%'+ @RazonSocial +'%'
		and e.CUIT = @CUIT
		and u.Mail like '%'+ @Mail +'%'
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Baja_Usuario
	@Usuario nvarchar(255)
	as
	begin
		update u set Habilitado = 0
		from ROAD_TO_PROYECTO.Usuario u
		where u.Usuario = @Usuario
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Comisiones_Visibilidad
	as
	begin
		select Descripcion from ROAD_TO_PROYECTO.Visibilidad order by Descripcion
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Comisiones_Valores
	@Visibilidad nvarchar(255)
	as
	begin
		select ComiFija, ComiVariable, ComiEnvio from ROAD_TO_PROYECTO.Visibilidad where Descripcion = @Visibilidad
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Alta_Publicacion
	@Descipcion nvarchar(255),
	@Stock numeric(18,0),
	@FechaInicio datetime,
	@Precio numeric(18,2),
	@VisiDesc nvarchar(255),
	@RubroDesc nvarchar(255),
	@TipoDesc nvarchar(255),
--	@EstadoDesc nvarchar(50),
	@VendedorId nvarchar(255),
	@EnvioHabilitado bit	

	as begin
		declare @VisiId int, @RubroId int, @TipoPubliId int, @EstadoId int, @PubliIdAnterior int, @PubliId int
		select @VisiId = VisiId from ROAD_TO_PROYECTO.Visibilidad where Descripcion = @VisiDesc
		select @RubroId = RubrId from ROAD_TO_PROYECTO.Rubro where DescripLarga = @RubroDesc
		select @TipoPubliId = TipoPubliId from ROAD_TO_PROYECTO.Tipo_Publicacion where Descripcion = @TipoDesc
		select @EstadoId = EstadoId from ROAD_TO_PROYECTO.Estado where Descripcion = 'Borrador'--@EstadoDesc
		select top 1 @PubliIdAnterior = PublId from ROAD_TO_PROYECTO.Publicacion order by PublId desc
		set @PubliId = @PubliIdAnterior +1

		insert into ROAD_TO_PROYECTO.Publicacion (PublId, Descipcion, Stock, FechaInicio, FechaFin, Precio, Visibilidad, Rubro, Tipo, Estado, UserId, EnvioHabilitado)
		values(@PubliId, @Descipcion, @Stock, @FechaInicio, dateadd(mm, 2, @FechaInicio), @Precio, @VisiId, @RubroId, @TipoPubliId, @EstadoId, @VendedorId, @EnvioHabilitado)
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Activar_Publicacion
	@PubliId int
	as begin
	declare @EstadoId int
	select @EstadoId = EstadoId from ROAD_TO_PROYECTO.Estado where Descripcion = 'Activa'
		update ROAD_TO_PROYECTO.Publicacion
		set Estado = @EstadoId
		where PublId = @PubliId
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Pausar_Publicacion
	@PubliId int
	as begin
	declare @EstadoId int
	select @EstadoId = EstadoId from ROAD_TO_PROYECTO.Estado where Descripcion = 'Pausada'
		update ROAD_TO_PROYECTO.Publicacion
		set Estado = @EstadoId
		where PublId = @PubliId
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Finalizar_Publicacion
	@PubliId int
	as begin
	declare @EstadoId int
	select @EstadoId = EstadoId from ROAD_TO_PROYECTO.Estado where Descripcion = 'Finalizada'
		update ROAD_TO_PROYECTO.Publicacion
		set Estado = @EstadoId
		where PublId = @PubliId
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Comprar_Publicacion
	@PubliId int,
	@Cantidad numeric(18,0),
	@CompradorId int, --Es cliente, no usuario, por eso es int y no nvarchar(255)
	@ConEnvio bit
	as begin
		if((select Stock from ROAD_TO_PROYECTO.Publicacion where PublId = @PubliId) > @Cantidad)
		begin
			insert into ROAD_TO_PROYECTO.Transaccion(TipoTransac, Fecha, Cantidad, PubliId, ClieId, ConEnvio)
			values('Compra', getdate(), @Cantidad, @PubliId, @CompradorId, @ConEnvio)
		end
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Ofertar_Publicacion
	@PubliId int,
	@MontoOferta numeric(18,2),
	@OfertanteId int, --Es cliente, no usuario, por eso es int y no nvarchar(255)
	@ConEnvio bit
	as begin
		if((select top 1 Monto from ROAD_TO_PROYECTO.Transaccion where PubliId = @PubliId and TipoTransac = 'Oferta' order by Monto desc) < @MontoOferta)
		begin
			insert into ROAD_TO_PROYECTO.Transaccion (TipoTransac, Fecha, Monto, PubliId, ClieId, ConEnvio)
			values('Oferta', getdate(), @MontoOferta, @PubliId, @OfertanteId, @ConEnvio)
		end
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Agregar_Visibilidad
	@Descripcion nvarchar(255),
	@ComiFija numeric(18,2),
	@ComiVariable numeric(18,2),
	@ComiEnvio numeric(18,2)
	as begin
		declare @VisiIdAnterior int, @VisiId int
		select top 1 @VisiIdAnterior = VisiId from ROAD_TO_PROYECTO.Visibilidad order by VisiId desc
		set @VisiId = @VisiIdAnterior +1

		insert into ROAD_TO_PROYECTO.Visibilidad (VisiId, Descripcion, ComiFija, ComiVariable, ComiEnvio)
		values (@VisiId, @Descripcion, @ComiFija, @ComiVariable, @ComiEnvio)
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Eliminar_Visibilidad
	@Descripcion nvarchar(255)
	as begin
		delete from Visibilidad where Descripcion = @Descripcion
	end
GO

CREATE PROCEDURE ROAD_TO_PROYECTO.Update_Visibilidad
	@Descripcion nvarchar(255),
	@ComiFija numeric(18,2),
	@ComiVariable numeric(18,2),
	@ComiEnvio numeric(18,2)
	as begin
		update ROAD_TO_PROYECTO.Visibilidad
		set ComiFija = @ComiFija, ComiVariable = @ComiVariable, ComiEnvio = @ComiEnvio
		where Descripcion = @Descripcion
	end
GO

----- Triggers -----
CREATE TRIGGER ROAD_TO_PROYECTO.Actualizar_Stock_y_Facturar on ROAD_TO_PROYECTO.Transaccion after insert
	as begin
		--Variables
		declare @Fecha datetime, @Cantidad numeric(18,0), @PubliId int, @UltimaFactura int, @FacturaActual int, @ComiVariable numeric(18,2), @ComiEnvio numeric(18,2)

		--Cursor con compras realizadas
		declare c1 cursor for select Fecha, Cantidad, PubliId from inserted where TipoTransac = 'Compra'
		open c1
		fetch next from c1 into @Fecha, @Cantidad, @PubliId

		while @@FETCH_STATUS = 0
			begin
			begin transaction
				--Actualizo stock de publicaciones involucradas
				update ROAD_TO_PROYECTO.Publicacion
				set Stock = (Stock - @Cantidad)
				where PublId = @PubliId
				
				--Busco el último número de factura y determino el siguiente
				select top 1 @UltimaFactura = FactNro from ROAD_TO_PROYECTO.Factura order by FactNro desc
				set @FacturaActual = @UltimaFactura + 1

				--Creo nueva factura
				insert into ROAD_TO_PROYECTO.Factura (FactNro, PubliId, Fecha)--, Monto, FormaPago)
				values(@FacturaActual, @PubliId, @Fecha)

				--Busco la comisión por ventas de la publicación
				select @ComiVariable = ComiVariable 
				from ROAD_TO_PROYECTO.Visibilidad v, ROAD_TO_PROYECTO.Publicacion p
				where p.PublId = @PubliId and p.Visibilidad = v.VisiId

				--Creo los items de la factura
				insert into ROAD_TO_PROYECTO.Item_Factura (FactNro, Cantidad, Detalle, Monto)
				values(@FacturaActual, @Cantidad, 'Comisión por productos vendidos', @Cantidad * @ComiVariable)
				
				--Verifico si corresponde comisiones por envío
				if((select p.EnvioHabilitado from ROAD_TO_PROYECTO.Publicacion p where p.PublId = @PubliId) = 1)
					begin
						--Busco la comisión por envío de la publicación
						select @ComiEnvio = ComiEnvio 
						from ROAD_TO_PROYECTO.Visibilidad v, ROAD_TO_PROYECTO.Publicacion p
						where p.PublId = @PubliId and p.Tipo = v.VisiId

						--Creo los items de la factura
						insert into ROAD_TO_PROYECTO.Item_Factura (FactNro, Cantidad, Detalle, Monto)
						values(@FacturaActual, @Cantidad, 'Comisión por envío de producto', @Cantidad * @ComiEnvio)
					end

				fetch next from c1 into @Fecha, @Cantidad, @PubliId
				commit
			end
		close c1
		deallocate c1
	end
GO