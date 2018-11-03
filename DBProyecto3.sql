
CREATE DATABASE [TEST]
GO
CREATE TABLE [dbo].[TBL_AFILIADOS](
	[DPI] [varchar](50) NOT NULL PRIMARY KEY,
	[NombreCom] [varchar](50) NULL,
	[FechaNac] [date] NULL,
	[Telefono] [int] NULL,
	[InicioCob] [date] NULL,
	[FinCobertura] [date] NULL,
	[MontoCob] [float] NULL,
	[EstadoPoliza] [int] NULL,
	[TipoPoliza] [varchar](50) NULL
)
GO
CREATE TABLE [dbo].[TBL_PROVEEDORES](
	[NIT] [varchar](50) NOT NULL PRIMARY KEY,
	[Nombre] [varchar](50) NULL,
	[Dirreccion] [varchar](50) NULL,
	[Telefono] [int] NULL,
	[Pais] [varchar](50) NULL,
	[Ciudad] [varchar](50) NULL,
	[Correo] [varchar](50) NULL,
	[Encargado] [varchar](50) NULL,
	[Estado] [int] NULL,

)
GO

CREATE TABLE [dbo].[TBL_TRANSACCIONES](
	[ID_Transaccion] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[NIT_Proveedor] [varchar](50) NULL,
	[DPI_Paciente] [varchar](50) NULL,
	[Fecha_Cobertura] [date] NULL,
	[Respuesta] [varchar](50) NULL,
	[Fecha_Consulta] [date] NULL,

)
GO

CREATE TABLE [dbo].[TBL_USERS](
	[ID_USER] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[USERNAME] [varchar](100) NULL,
	[PASSWORD] [varchar](100) NULL,
	[STATUS] [int] NULL,
)
