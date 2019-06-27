USE [master]
GO
/****** Object:  Database [TattoTeans]    Script Date: 27/10/2018 03:10:48 p.m. ******/
CREATE DATABASE [TattoTeans]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TattoTeans', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TattoTeans.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TattoTeans_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TattoTeans_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TattoTeans] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TattoTeans].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TattoTeans] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TattoTeans] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TattoTeans] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TattoTeans] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TattoTeans] SET ARITHABORT OFF 
GO
ALTER DATABASE [TattoTeans] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TattoTeans] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TattoTeans] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TattoTeans] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TattoTeans] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TattoTeans] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TattoTeans] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TattoTeans] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TattoTeans] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TattoTeans] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TattoTeans] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TattoTeans] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TattoTeans] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TattoTeans] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TattoTeans] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TattoTeans] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TattoTeans] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TattoTeans] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TattoTeans] SET RECOVERY FULL 
GO
ALTER DATABASE [TattoTeans] SET  MULTI_USER 
GO
ALTER DATABASE [TattoTeans] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TattoTeans] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TattoTeans] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TattoTeans] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TattoTeans', N'ON'
GO
USE [TattoTeans]
GO
/****** Object:  Table [dbo].[CategoriaProducto]    Script Date: 27/10/2018 03:10:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriaProducto](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_CategoriaProducto] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CategoriaTatuaje]    Script Date: 27/10/2018 03:10:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriaTatuaje](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [nvarchar](20) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CategoriaTatuaje] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CompraDetalle]    Script Date: 27/10/2018 03:10:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompraDetalle](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[ID_FacturaCompra] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_CompraDetalle] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FacturaCompra]    Script Date: 27/10/2018 03:10:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturaCompra](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Usuario] [int] NOT NULL,
	[ID_TipoDePago] [int] NOT NULL,
 CONSTRAINT [PK_FacturaCompra] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Local]    Script Date: 27/10/2018 03:10:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Local](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Distrito] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Local] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LocalPorUsuarioPorCategoria]    Script Date: 27/10/2018 03:10:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LocalPorUsuarioPorCategoria](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Local] [int] NOT NULL,
	[ID_UsuarioPorCategoria] [int] NOT NULL,
 CONSTRAINT [PK_LocalPorartistaPorCategoria] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Opinion]    Script Date: 27/10/2018 03:10:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Opinion](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[ID_TrabajoRealizado] [int] NOT NULL,
 CONSTRAINT [PK_Opinion] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto]    Script Date: 27/10/2018 03:10:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_CategoriaProducto] [int] NOT NULL,
	[Nombre] [nvarchar](20) NOT NULL,
	[Precio] [float] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 27/10/2018 03:10:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_LocalPorUsuarioPorCategoria] [int] NOT NULL,
	[FechaReserva] [date] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[ID_Cliente] [int] NOT NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoDePago]    Script Date: 27/10/2018 03:10:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDePago](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TipoDePago] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoUsuario]    Script Date: 27/10/2018 03:10:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoUsuario](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_TipoUsuario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TrabajoRealizado]    Script Date: 27/10/2018 03:10:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrabajoRealizado](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FechaRealizada] [date] NOT NULL,
	[Puntuacion] [int] NOT NULL,
	[ID_Usuario] [int] NOT NULL,
 CONSTRAINT [PK_TrabajoRealizado] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 27/10/2018 03:10:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_TipoUsuario] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[FechaNac] [date] NOT NULL,
	[Distrito] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Correo] [nvarchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[Celular] [nvarchar](50) NULL,
	[CorreoSecundario] [nvarchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UsuarioPorCategoria]    Script Date: 27/10/2018 03:10:49 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioPorCategoria](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Categoria] [int] NOT NULL,
	[ID_Usuario] [int] NOT NULL,
 CONSTRAINT [PK_ArtistaPorCategoria] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[FacturaCompra] ON 

INSERT [dbo].[FacturaCompra] ([ID], [ID_Usuario], [ID_TipoDePago]) VALUES (1, 9, 1)
SET IDENTITY_INSERT [dbo].[FacturaCompra] OFF
SET IDENTITY_INSERT [dbo].[TipoDePago] ON 

INSERT [dbo].[TipoDePago] ([ID], [Nombre]) VALUES (1, N'efectivo')
SET IDENTITY_INSERT [dbo].[TipoDePago] OFF
SET IDENTITY_INSERT [dbo].[TipoUsuario] ON 

INSERT [dbo].[TipoUsuario] ([ID], [Descripcion]) VALUES (1, N'Cliente')
INSERT [dbo].[TipoUsuario] ([ID], [Descripcion]) VALUES (2, N'Tatuador')
INSERT [dbo].[TipoUsuario] ([ID], [Descripcion]) VALUES (3, N'Administrador')
SET IDENTITY_INSERT [dbo].[TipoUsuario] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([ID], [ID_TipoUsuario], [Nombre], [Apellido], [FechaNac], [Distrito], [Direccion], [Correo], [Contraseña], [Celular], [CorreoSecundario]) VALUES (2, 1, N'Maria', N'Cuadro', CAST(N'2018-10-02' AS Date), N'Miraflores', N'Av. San Marcos', N'maria@gmail.com', N'maria', NULL, NULL)
INSERT [dbo].[Usuario] ([ID], [ID_TipoUsuario], [Nombre], [Apellido], [FechaNac], [Distrito], [Direccion], [Correo], [Contraseña], [Celular], [CorreoSecundario]) VALUES (3, 2, N'tatuador', N'Saenz', CAST(N'2018-10-20' AS Date), N'Surco', N'Av Larcomar', N'tatuador@gmail.com', N'tatuador', N'945788754', N'ta@gmail.com')
INSERT [dbo].[Usuario] ([ID], [ID_TipoUsuario], [Nombre], [Apellido], [FechaNac], [Distrito], [Direccion], [Correo], [Contraseña], [Celular], [CorreoSecundario]) VALUES (7, 2, N'Rodrigo', N'Lara', CAST(N'1999-05-05' AS Date), N'Miraflores', N'Av La Mar 175', N'max.lara5599@gmail.com', N'1234', N'944645789', N'max.lara@hotmail.com')
INSERT [dbo].[Usuario] ([ID], [ID_TipoUsuario], [Nombre], [Apellido], [FechaNac], [Distrito], [Direccion], [Correo], [Contraseña], [Celular], [CorreoSecundario]) VALUES (9, 2, N'Luis', N'Ortiz', CAST(N'1998-04-06' AS Date), N'Talavera', N'CHACCAMARCA SN', N'luisortizcenteno@gmail.com', N'1234', N'999999999', NULL)
INSERT [dbo].[Usuario] ([ID], [ID_TipoUsuario], [Nombre], [Apellido], [FechaNac], [Distrito], [Direccion], [Correo], [Contraseña], [Celular], [CorreoSecundario]) VALUES (10, 3, N'Admin', N'Admin', CAST(N'1990-10-10' AS Date), N'Chorrillos', N'Alameda San Marcos', N'admin@gmail.com', N'admin', N'987654321', N'admin2@gmail.com')
INSERT [dbo].[Usuario] ([ID], [ID_TipoUsuario], [Nombre], [Apellido], [FechaNac], [Distrito], [Direccion], [Correo], [Contraseña], [Celular], [CorreoSecundario]) VALUES (11, 1, N'asasa', N'asasas', CAST(N'2018-10-04' AS Date), N'asasas', N'asasas', N'1234@gmail.com', N'1234', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
ALTER TABLE [dbo].[CompraDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturaCompra_CompraDetalle] FOREIGN KEY([ID_FacturaCompra])
REFERENCES [dbo].[FacturaCompra] ([ID])
GO
ALTER TABLE [dbo].[CompraDetalle] CHECK CONSTRAINT [FK_FacturaCompra_CompraDetalle]
GO
ALTER TABLE [dbo].[CompraDetalle]  WITH CHECK ADD  CONSTRAINT [FK_Producto_CompraDetalle] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Producto] ([ID])
GO
ALTER TABLE [dbo].[CompraDetalle] CHECK CONSTRAINT [FK_Producto_CompraDetalle]
GO
ALTER TABLE [dbo].[FacturaCompra]  WITH CHECK ADD  CONSTRAINT [FK_TipoDePago_FacturaCompra] FOREIGN KEY([ID_TipoDePago])
REFERENCES [dbo].[TipoDePago] ([ID])
GO
ALTER TABLE [dbo].[FacturaCompra] CHECK CONSTRAINT [FK_TipoDePago_FacturaCompra]
GO
ALTER TABLE [dbo].[FacturaCompra]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_FacturaCompra] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuario] ([ID])
GO
ALTER TABLE [dbo].[FacturaCompra] CHECK CONSTRAINT [FK_Usuario_FacturaCompra]
GO
ALTER TABLE [dbo].[LocalPorUsuarioPorCategoria]  WITH CHECK ADD  CONSTRAINT [FK_Local_LocalPorartistaPorCategoria] FOREIGN KEY([ID_Local])
REFERENCES [dbo].[Local] ([ID])
GO
ALTER TABLE [dbo].[LocalPorUsuarioPorCategoria] CHECK CONSTRAINT [FK_Local_LocalPorartistaPorCategoria]
GO
ALTER TABLE [dbo].[LocalPorUsuarioPorCategoria]  WITH CHECK ADD  CONSTRAINT [FK_LocalPorUsuarioPorCategoria_UsuarioPorCategoria] FOREIGN KEY([ID_UsuarioPorCategoria])
REFERENCES [dbo].[UsuarioPorCategoria] ([ID])
GO
ALTER TABLE [dbo].[LocalPorUsuarioPorCategoria] CHECK CONSTRAINT [FK_LocalPorUsuarioPorCategoria_UsuarioPorCategoria]
GO
ALTER TABLE [dbo].[Opinion]  WITH CHECK ADD  CONSTRAINT [FK_TrabajoRealizado_Opinion] FOREIGN KEY([ID_TrabajoRealizado])
REFERENCES [dbo].[TrabajoRealizado] ([ID])
GO
ALTER TABLE [dbo].[Opinion] CHECK CONSTRAINT [FK_TrabajoRealizado_Opinion]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Categoria_Producto] FOREIGN KEY([ID_CategoriaProducto])
REFERENCES [dbo].[CategoriaProducto] ([ID])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Categoria_Producto]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_LocalPorUsuarioPorCategoria] FOREIGN KEY([ID_LocalPorUsuarioPorCategoria])
REFERENCES [dbo].[LocalPorUsuarioPorCategoria] ([ID])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_LocalPorUsuarioPorCategoria]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Usuario] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Usuario] ([ID])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Usuario]
GO
ALTER TABLE [dbo].[TrabajoRealizado]  WITH CHECK ADD  CONSTRAINT [FK_TrabajoRealizado_Usuario] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuario] ([ID])
GO
ALTER TABLE [dbo].[TrabajoRealizado] CHECK CONSTRAINT [FK_TrabajoRealizado_Usuario]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_TipoUsuario] FOREIGN KEY([ID_TipoUsuario])
REFERENCES [dbo].[TipoUsuario] ([ID])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_TipoUsuario]
GO
ALTER TABLE [dbo].[UsuarioPorCategoria]  WITH CHECK ADD  CONSTRAINT [FK_Categoria_ArtistaPorCategoria] FOREIGN KEY([ID_Categoria])
REFERENCES [dbo].[CategoriaTatuaje] ([ID])
GO
ALTER TABLE [dbo].[UsuarioPorCategoria] CHECK CONSTRAINT [FK_Categoria_ArtistaPorCategoria]
GO
ALTER TABLE [dbo].[UsuarioPorCategoria]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPorCategoria_Usuario] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuario] ([ID])
GO
ALTER TABLE [dbo].[UsuarioPorCategoria] CHECK CONSTRAINT [FK_UsuarioPorCategoria_Usuario]
GO
USE [master]
GO
ALTER DATABASE [TattoTeans] SET  READ_WRITE 
GO
