USE [master]
GO
/****** Object:  Database [DB_BOX]    Script Date: 17/5/2024 16:35:17 ******/
CREATE DATABASE [DB_BOX]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_BOX', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DB_BOX.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_BOX_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DB_BOX_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DB_BOX] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_BOX].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_BOX] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_BOX] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_BOX] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_BOX] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_BOX] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_BOX] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_BOX] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_BOX] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_BOX] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_BOX] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_BOX] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_BOX] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_BOX] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_BOX] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_BOX] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_BOX] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_BOX] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_BOX] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_BOX] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_BOX] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_BOX] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_BOX] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_BOX] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_BOX] SET  MULTI_USER 
GO
ALTER DATABASE [DB_BOX] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_BOX] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_BOX] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_BOX] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_BOX] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_BOX] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DB_BOX] SET QUERY_STORE = ON
GO
ALTER DATABASE [DB_BOX] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DB_BOX]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 17/5/2024 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Apellido] [varchar](50) NOT NULL,
	[CUIL] [int] NULL,
	[Rubro] [varchar](50) NULL,
	[Razon_Social] [varchar](50) NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Mail] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalles_de_Compras]    Script Date: 17/5/2024 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles_de_Compras](
	[Id_Detalle_Compra] [int] IDENTITY(1,1) NOT NULL,
	[Id_Orden_Compra] [int] NOT NULL,
	[Id_Oferta] [int] NOT NULL,
	[Cantidad_Compra] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalles_de_Ventas]    Script Date: 17/5/2024 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles_de_Ventas](
	[Id_Detalle_Venta] [int] IDENTITY(1,1) NOT NULL,
	[Id_Presupuesto] [int] NOT NULL,
	[Id_Oferta] [int] NOT NULL,
	[Cantidad_Venta] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Documentos]    Script Date: 17/5/2024 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documentos](
	[Id_Documento] [int] IDENTITY(1,1) NOT NULL,
	[Id_Orden_Venta] [int] NOT NULL,
	[Id_Orden_Compra] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 17/5/2024 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[Id_Estado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Informacion_Proveedores]    Script Date: 17/5/2024 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Informacion_Proveedores](
	[Id_Proveedor] [int] NOT NULL,
	[Id_Oferta] [int] IDENTITY(1,1) NOT NULL,
	[Id_Estado] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lista_de_Precios]    Script Date: 17/5/2024 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lista_de_Precios](
	[Id_Lista_Precio] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Porcentaje] [float] NOT NULL,
	[Id_Estado] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 17/5/2024 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[Id_Marca] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas_Proveedores]    Script Date: 17/5/2024 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas_Proveedores](
	[Id_Marca] [int] NOT NULL,
	[Id_Proveedor] [int] NOT NULL,
	[Id_Estado] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ofertas]    Script Date: 17/5/2024 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ofertas](
	[Id_Oferta] [int] IDENTITY(1,1) NOT NULL,
	[Id_Tipo_Oferta] [int] NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Id_Proveedor] [int] NOT NULL,
	[Id_Vehiculo] [int] NOT NULL,
	[Precio_Costo] [money] NOT NULL,
	[Id_Ganancia] [int] NOT NULL,
	[Cantidad] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordenes_de_Compras]    Script Date: 17/5/2024 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordenes_de_Compras](
	[Id_Orden_Compra] [int] IDENTITY(1,1) NOT NULL,
	[Id_Proveedor] [int] NOT NULL,
	[Id_Detalle_Compra] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Total] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordenes_de_Ventas]    Script Date: 17/5/2024 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordenes_de_Ventas](
	[Id_Orden_Venta] [int] IDENTITY(1,1) NOT NULL,
	[Id_Presupuesto] [int] NOT NULL,
	[Id_Estado] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Presupuestos]    Script Date: 17/5/2024 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presupuestos](
	[Id_Presupuesto] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Id_Detalle_Venta] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Subtotal] [float] NOT NULL,
	[Id_Lista_Precio] [int] NOT NULL,
	[Precio_Final] [float] NOT NULL,
	[Notas] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 17/5/2024 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[Id_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Pais] [varchar](50) NULL,
	[Mail] [varchar](50) NOT NULL,
	[Rubro] [varchar](50) NULL,
	[CUIT] [varchar](50) NULL,
	[Notas] [varchar](100) NULL,
	[Id_Marca] [int] NULL,
	[Id_Estado] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos_de_Ofertas]    Script Date: 17/5/2024 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos_de_Ofertas](
	[Id_Tipos_Ofertas] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 17/5/2024 16:35:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[Id_Vehiculo] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [DB_BOX] SET  READ_WRITE 
GO
