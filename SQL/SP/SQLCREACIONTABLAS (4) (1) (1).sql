

CREATE DATABASE [PUNTOVENTA]
GO

USE [PUNTOVENTA]
GO

-- SQL CREACION DE TABLAS --

-- TABLAS SIN RELACION--

IF OBJECT_ID('dbo.CATEGORIA', 'U') IS NOT NULL
BEGIN
	DROP TABLE [dbo].[CATEGORIA]
END
GO
CREATE TABLE [dbo].[CATEGORIA](
	[Id_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	CONSTRAINT [PK_CATEGORIA] PRIMARY KEY (Id_Categoria)
);
GO

IF OBJECT_ID('dbo.CLIENTE', 'U') IS NOT NULL
BEGIN
	DROP TABLE [dbo].[CLIENTE]
END
GO
CREATE TABLE [dbo].[CLIENTE](
	[Id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido_Paterno] [varchar](50) NULL,
	[Apellido_Materno] [varchar](50) NOT NULL,
	[Telefono] [varchar](12) NULL,
	[Correo] [varchar](30) NULL,
	[Direccion] [varchar](100) NOT NULL
 CONSTRAINT [PK_CLIENTE] PRIMARY KEY (Id_Cliente)
);
GO


IF OBJECT_ID('dbo.ESTATUS_CREDITO', 'U') IS NOT NULL
BEGIN
	DROP TABLE [dbo].ESTATUS_CREDITO

END
GO
CREATE TABLE [dbo].ESTATUS_CREDITO(
	[Id_Estatus] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [ESTATUS] PRIMARY KEY (Id_Estatus)
);
GO


IF OBJECT_ID('dbo.ESTATUS_PRODUCTO', 'U') IS NOT NULL
BEGIN
	DROP TABLE [dbo].ESTATUS_PRODUCTO
END
GO
CREATE TABLE [dbo].ESTATUS_PRODUCTO(
	[Id_Estatus] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ESTATUS_PRODUCTO] PRIMARY KEY (Id_Estatus)
);
GO
	

IF OBJECT_ID('dbo.MEDIDA', 'U') IS NOT NULL
BEGIN
	DROP TABLE [dbo].[MEDIDA]
END
GO
CREATE TABLE [dbo].[MEDIDA](
	[Id_Medida] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UNIDAD] PRIMARY KEY (Id_Medida)
);
GO


IF OBJECT_ID('dbo.PERFIL', 'U') IS NOT NULL
BEGIN
	DROP TABLE [dbo].[PERFIL]
END
GO
CREATE TABLE [dbo].[PERFIL](
	[Id_Perfil] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PERFIL] PRIMARY KEY (Id_Perfil)
);
GO


IF OBJECT_ID('dbo.PROVEEDOR', 'U') IS NOT NULL
BEGIN
	DROP TABLE [dbo].[PROVEEDOR]
END
GO
CREATE TABLE [dbo].[PROVEEDOR](
	[Id_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Telefono] [varchar](12) NULL,
	[Correo] [varchar](30) NOT NULL,
	[FechaEntrada] [date] NULL,
	[FechaModificacion] [date] NULL,
 CONSTRAINT [PK_PROVEEDOR] PRIMARY KEY (Id_Proveedor)
);
GO



IF OBJECT_ID('dbo.TIPOVENTA', 'U') IS NOT NULL
BEGIN
	DROP TABLE [dbo].[TIPOVENTA]
END
GO
CREATE TABLE [dbo].[TIPOVENTA](
	[Id_TipoVenta] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TIPOVENTA] PRIMARY KEY (Id_TipoVenta)
);
GO



-------------------------------------------------------------------------------------------
-- TABLAS CON RELACIONES---
IF OBJECT_ID('dbo.USUARIO', 'U') IS NOT NULL
BEGIN
	DROP TABLE [dbo].[USUARIO]
END
GO
CREATE TABLE [dbo].[USUARIO](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contrasenia] [varchar](50) NOT NULL,
	[Id_Perfil] [int] NOT NULL,
	CONSTRAINT [PK_USUARIO] PRIMARY KEY (Id_Usuario),
	CONSTRAINT [FK_PERFIL_USUARIO] FOREIGN KEY([Id_Perfil]) REFERENCES [dbo].[PERFIL] ([Id_Perfil])
);
GO


IF OBJECT_ID('dbo.PRODUCTO', 'U') IS NOT NULL
BEGIN
	DROP TABLE [dbo].[PRODUCTO]
END
GO
CREATE TABLE [dbo].[PRODUCTO](
	[Id_Producto] [varchar] (40)  NOT NULL,
	[Id_Categoria] [int] NOT NULL,
	[Id_Medida] [int] NOT NULL,
	[Id_Proveedor] [int] NOT NULL,
	[Id_Estatus] [int] NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[PrecioCompra] [float] (3) NOT NULL,
	[PrecioVenta] [float] (3) NOT NULL,
	[Stock] [int] NOT NULL,
	CONSTRAINT [PK_PRODUCTO] PRIMARY KEY (Id_Producto),
	CONSTRAINT [FK_CATEGORIA_PRODUCTO] FOREIGN KEY([Id_Categoria]) REFERENCES [dbo].[CATEGORIA] ([Id_Categoria]),
	CONSTRAINT [FK_MEDIDA_PRODUCTO] FOREIGN KEY([Id_Medida]) REFERENCES [dbo].[MEDIDA] ([Id_Medida]),
	CONSTRAINT [FK_PROVEEDOR_PRODUCTO] FOREIGN KEY([Id_Proveedor]) REFERENCES [dbo].[PROVEEDOR] ([Id_Proveedor]),
	CONSTRAINT [FK_ESTATUS_PRODUCTO] FOREIGN KEY([Id_Estatus]) REFERENCES [dbo].[ESTATUS_PRODUCTO] ([Id_Estatus])
);
GO


IF OBJECT_ID('dbo.ENTRADA', 'U') IS NOT NULL
BEGIN
	DROP TABLE [dbo].[ENTRADA]
END
GO
CREATE TABLE [dbo].[ENTRADA](
	[Id_Entrada] [int] IDENTITY(1,1) NOT NULL,
	[Id_Producto] [varchar] (40)  NOT NULL,
	[Id_Usuario] [int] NOT NULL,
	[Stock] [int] NOT NULL,
	[FechaEntrada] [date] NOT NULL,
	CONSTRAINT [PK_ENTRADA] PRIMARY KEY (Id_Entrada),
	CONSTRAINT [FK_PRODUCTO_ENTRADA] FOREIGN KEY([Id_Producto]) REFERENCES [dbo].[PRODUCTO] ([Id_Producto]),
	CONSTRAINT [FK_USUARIO_ENTRADA] FOREIGN KEY([Id_Usuario]) REFERENCES [dbo].[USUARIO] ([Id_Usuario])
	
);
GO


IF OBJECT_ID('dbo.VENTA', 'U') IS NOT NULL
BEGIN
	DROP TABLE [dbo].[VENTA]
END
GO
CREATE TABLE [dbo].[VENTA](
	[Id_Venta] [int]  NOT NULL,
	[Id_Usuario] [int]  NULL,
	[Id_TipoVenta] [int]  NULL,
	[Id_Cliente] [int] NULL,
	[NombreTransferencia] [varchar](30)  NULL,
	[Total] [float] (3)  NULL,
	[Cambio] [float] (3)  NULL,
	[FechaVenta] [date]  NULL,
	CONSTRAINT [PK_VENTA] PRIMARY KEY (Id_Venta),
	CONSTRAINT [FK_TIPOVENTA_VENTA] FOREIGN KEY([Id_TipoVenta]) REFERENCES [dbo].[TIPOVENTA] ([Id_TipoVenta]),
	CONSTRAINT [FK_USUARIO_VENTA] FOREIGN KEY([Id_Usuario]) REFERENCES [dbo].[USUARIO] ([Id_Usuario]),
	CONSTRAINT [FK_CLIENTE_VENTA] FOREIGN KEY([Id_Cliente]) REFERENCES [dbo].[CLIENTE] ([Id_Cliente])
	
);
GO


IF OBJECT_ID('dbo.VENTA_DETALLE', 'U') IS NOT NULL
BEGIN
	DROP TABLE [dbo].[VENTA_DETALLE]
END
GO
CREATE TABLE [dbo].[VENTA_DETALLE](
	[Id_Venta_Detalle] [int] IDENTITY(1,1) NOT NULL,
	[Id_Venta] [int] NOT NULL,
	[Id_Producto] [varchar] (40)  NOT NULL,
	[Precio] [float] (3) NOT NULL,
	[Cantidad] [int] NOT NULL,
	CONSTRAINT [PK_VENTA_DETALLE] PRIMARY KEY (Id_Venta_Detalle),
	CONSTRAINT [FK_VENTA_VENTA_DETALLE] FOREIGN KEY([Id_Venta]) REFERENCES [dbo].[VENTA] ([Id_Venta]),
	CONSTRAINT [FK_PRODUCTO_VENTA_DETALLE] FOREIGN KEY([Id_Producto]) REFERENCES [dbo].[PRODUCTO] ([Id_Producto])	
);
GO


IF OBJECT_ID('dbo.CREDITO', 'U') IS NOT NULL
BEGIN
	DROP TABLE [dbo].[CREDITO]
END
GO
CREATE TABLE [dbo].[CREDITO](
	[Id_Credito] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Id_Venta] [int] NOT NULL,
	[Id_Estatus] [int] NOT NULL,
	[CantidadPagada] [float]  NULL,
	[FechaRegistro] [date] NOT NULL,
	[FechaUltimoPago] [date]  NULL,
	[FechaPago] [date]  NULL,
	CONSTRAINT [PK_CREDITO] PRIMARY KEY (Id_Credito),
	CONSTRAINT [FK_CLIENTE_CREDITO] FOREIGN KEY([Id_Cliente]) REFERENCES [dbo].[CLIENTE] ([Id_Cliente]),
	CONSTRAINT [FK_VENTA_CREDITO] FOREIGN KEY([Id_Venta]) REFERENCES [dbo].[VENTA] ([Id_Venta]),
	CONSTRAINT [FK_ESTATUS_CREDITO] FOREIGN KEY([Id_Estatus]) REFERENCES [dbo].[ESTATUS_CREDITO] ([Id_Estatus])
	
);
GO

IF OBJECT_ID('dbo.TICKET', 'U') IS NOT NULL
BEGIN
	DROP TABLE [dbo].TICKET
END
GO
CREATE TABLE [dbo].TICKET(
	[NombreEmpresa] [varchar](30) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Mensaje] [varchar] (30) NOT NULL
	
);   M
GO

IF OBJECT_ID('dbo.CLIENTECREDITOSELECCIONADO', 'U') IS NOT NULL
BEGIN
	DROP TABLE [dbo].CLIENTECREDITOSELECCIONADO
END
GO
CREATE TABLE [dbo].CLIENTECREDITOSELECCIONADO(
	[Id_Cliente] [int]  NOT NULL
	CONSTRAINT [PK_CIENTE_SELECCIONADO] PRIMARY KEY ([Id_Cliente])
);
GO

-----------------------------------------------------

--INSERTS---

insert into PERFIL values ('Administrador');
insert into PERFIL values ('Vendedor');

insert into ESTATUS_CREDITO values('Pagado');
insert into ESTATUS_CREDITO values('No Pagado');

insert into ESTATUS_PRODUCTO values('Activo');
insert into ESTATUS_PRODUCTO values('Desactivo');

insert into TIPOVENTA values('Efectivo');
insert into TIPOVENTA values('Transferencia');
insert into TIPOVENTA values('Credito');





insert into USUARIO(usuario,Contrasenia,Id_Perfil) values('sa','sa',1);

INSERT INTO TICKET (NombreEmpresa,Direccion,Telefono,Mensaje ) VALUES ('FERRETERIA TONY','CENTRO MTY','819029323','Gracias por su Compra');


