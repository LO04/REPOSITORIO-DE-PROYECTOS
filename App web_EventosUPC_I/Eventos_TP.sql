USE [master]
GO
/****** Object:  Database [Eventos_TP]    Script Date: 15/10/2018 1:13:28 ******/
CREATE DATABASE [Eventos_TP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Eventos_TP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Eventos_TP.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Eventos_TP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Eventos_TP_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Eventos_TP] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Eventos_TP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Eventos_TP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Eventos_TP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Eventos_TP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Eventos_TP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Eventos_TP] SET ARITHABORT OFF 
GO
ALTER DATABASE [Eventos_TP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Eventos_TP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Eventos_TP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Eventos_TP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Eventos_TP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Eventos_TP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Eventos_TP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Eventos_TP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Eventos_TP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Eventos_TP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Eventos_TP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Eventos_TP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Eventos_TP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Eventos_TP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Eventos_TP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Eventos_TP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Eventos_TP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Eventos_TP] SET RECOVERY FULL 
GO
ALTER DATABASE [Eventos_TP] SET  MULTI_USER 
GO
ALTER DATABASE [Eventos_TP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Eventos_TP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Eventos_TP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Eventos_TP] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Eventos_TP] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Eventos_TP]
GO
/****** Object:  Table [dbo].[Actividad]    Script Date: 15/10/2018 1:13:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Actividad](
	[id_actividad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Actividad] PRIMARY KEY CLUSTERED 
(
	[id_actividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 15/10/2018 1:13:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[celular] [int] NULL,
	[DNI] [int] NOT NULL,
	[direccion] [varchar](150) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Equipo]    Script Date: 15/10/2018 1:13:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Equipo](
	[id_equipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[precio_alquiler] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Equipo] PRIMARY KEY CLUSTERED 
(
	[id_equipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Evento]    Script Date: 15/10/2018 1:13:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Evento](
	[id_evento] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_local] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[objetivo] [varchar](50) NULL,
	[nro_asistentes] [int] NOT NULL,
	[fecha_evento] [datetime] NOT NULL,
	[encargado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
(
	[id_evento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Evento_Actividad]    Script Date: 15/10/2018 1:13:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evento_Actividad](
	[id_evento_actividad] [int] IDENTITY(1,1) NOT NULL,
	[id_evento] [int] NOT NULL,
	[id_actividad] [int] NOT NULL,
	[hora_inicio] [datetime] NOT NULL,
	[hora_fin] [datetime] NOT NULL,
 CONSTRAINT [PK_Evento_Actividad] PRIMARY KEY CLUSTERED 
(
	[id_evento_actividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Evento_Equipo]    Script Date: 15/10/2018 1:13:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evento_Equipo](
	[id_evento_equipo] [int] IDENTITY(1,1) NOT NULL,
	[id_evento] [int] NOT NULL,
	[id_equipo] [int] NOT NULL,
 CONSTRAINT [PK_Evento_Equipo] PRIMARY KEY CLUSTERED 
(
	[id_evento_equipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Evento_Material]    Script Date: 15/10/2018 1:13:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evento_Material](
	[id_evento_material] [int] IDENTITY(1,1) NOT NULL,
	[id_evento] [int] NOT NULL,
	[id_material] [int] NOT NULL,
 CONSTRAINT [PK_Evento_Material] PRIMARY KEY CLUSTERED 
(
	[id_evento_material] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Evento_Personal]    Script Date: 15/10/2018 1:13:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evento_Personal](
	[id_evento_personal] [int] IDENTITY(1,1) NOT NULL,
	[id_evento] [int] NOT NULL,
	[id_personal] [int] NOT NULL,
	[horas_trab] [int] NOT NULL,
 CONSTRAINT [PK_Evento_Personal] PRIMARY KEY CLUSTERED 
(
	[id_evento_personal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Evento_Servicio]    Script Date: 15/10/2018 1:13:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evento_Servicio](
	[id_evento_servicio] [int] IDENTITY(1,1) NOT NULL,
	[id_evento] [int] NOT NULL,
	[id_servicio] [int] NOT NULL,
 CONSTRAINT [PK_Evento_Servicio] PRIMARY KEY CLUSTERED 
(
	[id_evento_servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Local]    Script Date: 15/10/2018 1:13:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Local](
	[id_local] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[capacidad] [int] NOT NULL,
 CONSTRAINT [PK_Local] PRIMARY KEY CLUSTERED 
(
	[id_local] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Material]    Script Date: 15/10/2018 1:13:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Material](
	[id_material] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[precio_alquiler] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[id_material] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Personal]    Script Date: 15/10/2018 1:13:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personal](
	[id_personal] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[DNI] [int] NOT NULL,
	[cargo] [varchar](50) NOT NULL,
	[sueldo] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED 
(
	[id_personal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 15/10/2018 1:13:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Servicio](
	[id_servicio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[precio_alquiler] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED 
(
	[id_servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Actividad] ON 

INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (7, N'Actividad1', N'Descripcion1')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (8, N'Actividad2', N'Descripcion2')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (9, N'Actividad3', N'Descripcion3')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (10, N'Actividad4', N'Descripcion4')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (11, N'Actividad5', N'Descripcion5')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (12, N'Actividad6', N'Descripcion6')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (13, N'Actividad7', N'Descripcion7')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (14, N'Actividad8', N'Descripcion8')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (15, N'Actividad9', N'Descripcion9')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (16, N'Actividad10', N'Descripcion10')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (17, N'Actividad11', N'Descripcion11')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (18, N'Actividad12', N'Descripcion12')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (19, N'Actividad13', N'Descripcion13')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (20, N'Actividad14', N'Descripcion14')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (21, N'Actividad15', N'Descripcion15')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (22, N'Actividad16', N'Descripcion16')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (23, N'Actividad17', N'Descripcion17')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (24, N'Actividad18', N'Descripcion18')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (25, N'Actividad19', N'Descripcion19')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (26, N'Actividad20', N'Descripcion20')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (27, N'Actividad21', N'Descripcion21')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (28, N'Actividad22', N'Descripcion22')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (29, N'Actividad23', N'Descripcion23')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (30, N'Actividad24', N'Descripcion24')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (31, N'Actividad25', N'Descripcion25')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (32, N'Actividad26', N'Descripcion26')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (33, N'Actividad27', N'Descripcion27')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (34, N'Actividad28', N'Descripcion28')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (35, N'Actividad29', N'Descripcion29')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (36, N'Actividad30', N'Descripcion30')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (37, N'Actividad31', N'Descripcion31')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (38, N'Actividad32', N'Descripcion32')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (39, N'Actividad33', N'Descripcion33')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (40, N'Actividad34', N'Descripcion34')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (41, N'Actividad35', N'Descripcion35')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (42, N'Actividad36', N'Descripcion36')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (43, N'Actividad37', N'Descripcion37')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (44, N'Actividad38', N'Descripcion38')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (45, N'Actividad39', N'Descripcion39')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (46, N'Actividad40', N'Descripcion40')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (47, N'Actividad41', N'Descripcion41')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (48, N'Actividad42', N'Descripcion42')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (49, N'Actividad43', N'Descripcion43')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (50, N'Actividad44', N'Descripcion44')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (51, N'Actividad45', N'Descripcion45')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (52, N'Actividad46', N'Descripcion46')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (53, N'Actividad47', N'Descripcion47')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (54, N'Actividad48', N'Descripcion48')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (55, N'Actividad49', N'Descripcion49')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (56, N'Actividad50', N'Descripcion50')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (57, N'Actividad51', N'Descripcion51')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (58, N'Actividad52', N'Descripcion52')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (59, N'Actividad53', N'Descripcion53')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (60, N'Actividad54', N'Descripcion54')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (61, N'Actividad55', N'Descripcion55')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (62, N'Actividad56', N'Descripcion56')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (63, N'Actividad57', N'Descripcion57')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (64, N'Actividad58', N'Descripcion58')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (65, N'Actividad59', N'Descripcion59')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (66, N'Actividad60', N'Descripcion60')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (67, N'Actividad61', N'Descripcion61')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (68, N'Actividad62', N'Descripcion62')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (69, N'Actividad63', N'Descripcion63')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (70, N'Actividad64', N'Descripcion64')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (71, N'Actividad65', N'Descripcion65')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (72, N'Actividad66', N'Descripcion66')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (73, N'Actividad67', N'Descripcion67')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (74, N'Actividad68', N'Descripcion68')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (75, N'Actividad69', N'Descripcion69')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (76, N'Actividad70', N'Descripcion70')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (77, N'Actividad71', N'Descripcion71')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (78, N'Actividad72', N'Descripcion72')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (79, N'Actividad73', N'Descripcion73')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (80, N'Actividad74', N'Descripcion74')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (81, N'Actividad75', N'Descripcion75')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (82, N'Actividad76', N'Descripcion76')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (83, N'Actividad77', N'Descripcion77')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (84, N'Actividad78', N'Descripcion78')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (85, N'Actividad79', N'Descripcion79')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (86, N'Actividad80', N'Descripcion80')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (87, N'Actividad81', N'Descripcion81')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (88, N'Actividad82', N'Descripcion82')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (89, N'Actividad83', N'Descripcion83')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (90, N'Actividad84', N'Descripcion84')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (91, N'Actividad85', N'Descripcion85')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (92, N'Actividad86', N'Descripcion86')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (93, N'Actividad87', N'Descripcion87')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (94, N'Actividad88', N'Descripcion88')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (95, N'Actividad89', N'Descripcion89')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (96, N'Actividad90', N'Descripcion90')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (97, N'Actividad91', N'Descripcion91')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (98, N'Actividad92', N'Descripcion92')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (99, N'Actividad93', N'Descripcion93')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (100, N'Actividad94', N'Descripcion94')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (101, N'Actividad95', N'Descripcion95')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (102, N'Actividad96', N'Descripcion96')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (103, N'Actividad97', N'Descripcion97')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (104, N'Actividad98', N'Descripcion98')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (105, N'Actividad99', N'Descripcion99')
GO
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (106, N'Actividad100', N'Descripcion100')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (107, N'Actividad101', N'Descripcion101')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (108, N'Actividad102', N'Descripcion102')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (109, N'Actividad103', N'Descripcion103')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (110, N'Actividad104', N'Descripcion104')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (111, N'Actividad105', N'Descripcion105')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (112, N'Actividad106', N'Descripcion106')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (113, N'Actividad107', N'Descripcion107')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (114, N'Actividad108', N'Descripcion108')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (115, N'Actividad109', N'Descripcion109')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (116, N'Actividad110', N'Descripcion110')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (117, N'Actividad111', N'Descripcion111')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (118, N'Actividad112', N'Descripcion112')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (119, N'Actividad113', N'Descripcion113')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (120, N'Actividad114', N'Descripcion114')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (121, N'Actividad115', N'Descripcion115')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (122, N'Actividad116', N'Descripcion116')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (123, N'Actividad117', N'Descripcion117')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (124, N'Actividad118', N'Descripcion118')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (125, N'Actividad119', N'Descripcion119')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (126, N'Actividad120', N'Descripcion120')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (127, N'Actividad121', N'Descripcion121')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (128, N'Actividad122', N'Descripcion122')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (129, N'Actividad123', N'Descripcion123')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (130, N'Actividad124', N'Descripcion124')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (131, N'Actividad125', N'Descripcion125')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (132, N'Actividad126', N'Descripcion126')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (133, N'Actividad127', N'Descripcion127')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (134, N'Actividad128', N'Descripcion128')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (135, N'Actividad129', N'Descripcion129')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (136, N'Actividad130', N'Descripcion130')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (137, N'Actividad131', N'Descripcion131')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (138, N'Actividad132', N'Descripcion132')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (139, N'Actividad133', N'Descripcion133')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (140, N'Actividad134', N'Descripcion134')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (141, N'Actividad135', N'Descripcion135')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (142, N'Actividad136', N'Descripcion136')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (143, N'Actividad137', N'Descripcion137')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (144, N'Actividad138', N'Descripcion138')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (145, N'Actividad139', N'Descripcion139')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (146, N'Actividad140', N'Descripcion140')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (147, N'Actividad141', N'Descripcion141')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (148, N'Actividad142', N'Descripcion142')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (149, N'Actividad143', N'Descripcion143')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (150, N'Actividad144', N'Descripcion144')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (151, N'Actividad145', N'Descripcion145')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (152, N'Actividad146', N'Descripcion146')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (153, N'Actividad147', N'Descripcion147')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (154, N'Actividad148', N'Descripcion148')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (155, N'Actividad149', N'Descripcion149')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (156, N'Actividad150', N'Descripcion150')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (157, N'Actividad151', N'Descripcion151')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (158, N'Actividad152', N'Descripcion152')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (159, N'Actividad153', N'Descripcion153')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (160, N'Actividad154', N'Descripcion154')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (161, N'Actividad155', N'Descripcion155')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (162, N'Actividad156', N'Descripcion156')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (163, N'Actividad157', N'Descripcion157')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (164, N'Actividad158', N'Descripcion158')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (165, N'Actividad159', N'Descripcion159')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (166, N'Actividad160', N'Descripcion160')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (167, N'Actividad161', N'Descripcion161')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (168, N'Actividad162', N'Descripcion162')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (169, N'Actividad163', N'Descripcion163')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (170, N'Actividad164', N'Descripcion164')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (171, N'Actividad165', N'Descripcion165')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (172, N'Actividad166', N'Descripcion166')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (173, N'Actividad167', N'Descripcion167')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (174, N'Actividad168', N'Descripcion168')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (175, N'Actividad169', N'Descripcion169')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (176, N'Actividad170', N'Descripcion170')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (177, N'Actividad171', N'Descripcion171')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (178, N'Actividad172', N'Descripcion172')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (179, N'Actividad173', N'Descripcion173')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (180, N'Actividad174', N'Descripcion174')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (181, N'Actividad175', N'Descripcion175')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (182, N'Actividad176', N'Descripcion176')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (183, N'Actividad177', N'Descripcion177')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (184, N'Actividad178', N'Descripcion178')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (185, N'Actividad179', N'Descripcion179')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (186, N'Actividad180', N'Descripcion180')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (187, N'Actividad181', N'Descripcion181')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (188, N'Actividad182', N'Descripcion182')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (189, N'Actividad183', N'Descripcion183')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (190, N'Actividad184', N'Descripcion184')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (191, N'Actividad185', N'Descripcion185')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (192, N'Actividad186', N'Descripcion186')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (193, N'Actividad187', N'Descripcion187')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (194, N'Actividad188', N'Descripcion188')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (195, N'Actividad189', N'Descripcion189')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (196, N'Actividad190', N'Descripcion190')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (197, N'Actividad191', N'Descripcion191')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (198, N'Actividad192', N'Descripcion192')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (199, N'Actividad193', N'Descripcion193')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (200, N'Actividad194', N'Descripcion194')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (201, N'Actividad195', N'Descripcion195')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (202, N'Actividad196', N'Descripcion196')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (203, N'Actividad197', N'Descripcion197')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (204, N'Actividad198', N'Descripcion198')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (205, N'Actividad199', N'Descripcion199')
GO
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (206, N'Actividad200', N'Descripcion200')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (207, N'Actividad201', N'Descripcion201')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (208, N'Actividad202', N'Descripcion202')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (209, N'Actividad203', N'Descripcion203')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (210, N'Actividad204', N'Descripcion204')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (211, N'Actividad205', N'Descripcion205')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (212, N'Actividad206', N'Descripcion206')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (213, N'Actividad207', N'Descripcion207')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (214, N'Actividad208', N'Descripcion208')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (215, N'Actividad209', N'Descripcion209')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (216, N'Actividad210', N'Descripcion210')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (217, N'Actividad211', N'Descripcion211')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (218, N'Actividad212', N'Descripcion212')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (219, N'Actividad213', N'Descripcion213')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (220, N'Actividad214', N'Descripcion214')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (221, N'Actividad215', N'Descripcion215')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (222, N'Actividad216', N'Descripcion216')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (223, N'Actividad217', N'Descripcion217')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (224, N'Actividad218', N'Descripcion218')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (225, N'Actividad219', N'Descripcion219')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (226, N'Actividad220', N'Descripcion220')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (227, N'Actividad221', N'Descripcion221')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (228, N'Actividad222', N'Descripcion222')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (229, N'Actividad223', N'Descripcion223')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (230, N'Actividad224', N'Descripcion224')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (231, N'Actividad225', N'Descripcion225')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (232, N'Actividad226', N'Descripcion226')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (233, N'Actividad227', N'Descripcion227')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (234, N'Actividad228', N'Descripcion228')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (235, N'Actividad229', N'Descripcion229')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (236, N'Actividad230', N'Descripcion230')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (237, N'Actividad231', N'Descripcion231')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (238, N'Actividad232', N'Descripcion232')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (239, N'Actividad233', N'Descripcion233')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (240, N'Actividad234', N'Descripcion234')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (241, N'Actividad235', N'Descripcion235')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (242, N'Actividad236', N'Descripcion236')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (243, N'Actividad237', N'Descripcion237')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (244, N'Actividad238', N'Descripcion238')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (245, N'Actividad239', N'Descripcion239')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (246, N'Actividad240', N'Descripcion240')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (247, N'Actividad241', N'Descripcion241')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (248, N'Actividad242', N'Descripcion242')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (249, N'Actividad243', N'Descripcion243')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (250, N'Actividad244', N'Descripcion244')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (251, N'Actividad245', N'Descripcion245')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (252, N'Actividad246', N'Descripcion246')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (253, N'Actividad247', N'Descripcion247')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (254, N'Actividad248', N'Descripcion248')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (255, N'Actividad249', N'Descripcion249')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (256, N'Actividad250', N'Descripcion250')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (257, N'Actividad251', N'Descripcion251')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (258, N'Actividad252', N'Descripcion252')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (259, N'Actividad253', N'Descripcion253')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (260, N'Actividad254', N'Descripcion254')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (261, N'Actividad255', N'Descripcion255')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (262, N'Actividad256', N'Descripcion256')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (263, N'Actividad257', N'Descripcion257')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (264, N'Actividad258', N'Descripcion258')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (265, N'Actividad259', N'Descripcion259')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (266, N'Actividad260', N'Descripcion260')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (267, N'Actividad261', N'Descripcion261')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (268, N'Actividad262', N'Descripcion262')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (269, N'Actividad263', N'Descripcion263')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (270, N'Actividad264', N'Descripcion264')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (271, N'Actividad265', N'Descripcion265')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (272, N'Actividad266', N'Descripcion266')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (273, N'Actividad267', N'Descripcion267')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (274, N'Actividad268', N'Descripcion268')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (275, N'Actividad269', N'Descripcion269')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (276, N'Actividad270', N'Descripcion270')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (277, N'Actividad271', N'Descripcion271')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (278, N'Actividad272', N'Descripcion272')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (279, N'Actividad273', N'Descripcion273')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (280, N'Actividad274', N'Descripcion274')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (281, N'Actividad275', N'Descripcion275')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (282, N'Actividad276', N'Descripcion276')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (283, N'Actividad277', N'Descripcion277')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (284, N'Actividad278', N'Descripcion278')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (285, N'Actividad279', N'Descripcion279')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (286, N'Actividad280', N'Descripcion280')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (287, N'Actividad281', N'Descripcion281')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (288, N'Actividad282', N'Descripcion282')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (289, N'Actividad283', N'Descripcion283')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (290, N'Actividad284', N'Descripcion284')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (291, N'Actividad285', N'Descripcion285')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (292, N'Actividad286', N'Descripcion286')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (293, N'Actividad287', N'Descripcion287')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (294, N'Actividad288', N'Descripcion288')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (295, N'Actividad289', N'Descripcion289')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (296, N'Actividad290', N'Descripcion290')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (297, N'Actividad291', N'Descripcion291')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (298, N'Actividad292', N'Descripcion292')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (299, N'Actividad293', N'Descripcion293')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (300, N'Actividad294', N'Descripcion294')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (301, N'Actividad295', N'Descripcion295')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (302, N'Actividad296', N'Descripcion296')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (303, N'Actividad297', N'Descripcion297')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (304, N'Actividad298', N'Descripcion298')
INSERT [dbo].[Actividad] ([id_actividad], [nombre], [descripcion]) VALUES (305, N'Actividad299', N'Descripcion299')
GO
SET IDENTITY_INSERT [dbo].[Actividad] OFF
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (1, N'Renato', N'Zegarra', 987654321, 7834576, N'Alameda sur 123')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (2, N'Fabiola', N'Altamirano', 987652321, 5345687, N'Av. San Marcos 456')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (4, N'Luis', N'Ortiz', 987654321, 78945612, N'Av las Hormigas 123')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (5, N'Elaine ', N'Long', 987656783, 466786432, N'Av. Los proceres 987')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (6, N'James ', N'Booher', 953467843, 237897654, N'Av. santa anita 76')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (7, N'Saulo ', N'Aranda', 923478245, 44914122, N'Avenida Gismera No. 128')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (8, N'Joaquin ', N'Micaias', 927385722, 42308578, N'Avenida Rifon No. 610')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (9, N'Jorge ', N'Ahmed', 927482618, 8552992, N'Bulevar Valdez No. 751')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (10, N'Salvador', N'López', 972543837, 21170451, N'Calle las praderas 123')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (11, N'Oton', N'Demeter', 912728312, 82648264, N'Calle Santo 1234')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (13, N'Pablo', N'Vivar', 971013012, 95663153, N'Chorrillos Mz X8 Lt 11')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (14, N'Leopoldo', N'Vidro', 908044636, 62022499, N'La Molina Mz Y4 Lt 7')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (15, N'Gaspar', N'Dios', 960119697, 69800757, N'Pachacámac Mz J10 Lt 9')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (16, N'Humberto', N'Gamero', 930056979, 25063039, N'San Martín de Porres Mz J1 Lt 14')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (17, N'Humberto', N'', 996422642, 40624751, N'San Isidro Mz H5 Lt 17')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (18, N'Germán', N'Soriano', 997254377, 82532473, N'Lurin Mz Z10 Lt 9')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (19, N'Roberto', N'Servera', 952101762, 73787888, N'Ancón Mz O9 Lt 23')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (20, N'Maximiliano', N'Cacimiro', 902267473, 60526378, N'Barranco Mz B8 Lt 5')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (21, N'Zoilo', N'Samorano', 925231243, 50101838, N'Miraflores Mz L9 Lt 23')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (22, N'Ivo', N'Teran', 959354503, 90010337, N'La Molina Mz H6 Lt 20')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (23, N'Manuel', N'Ansaldo', 999389821, 27869211, N'Barranco Mz S6 Lt 5')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (24, N'Kilian', N'Roa', 975533962, 81462227, N'Los Olivos Mz D5 Lt 5')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (25, N'Salvador', N'Infante', 978099726, 46668092, N'Chorrillos Mz R7 Lt 13')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (26, N'Juan', N'Fernandez', 974840420, 32411682, N'Surquillo Mz V10 Lt 9')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (27, N'Manuel', N'Sebilla', 928954267, 75302881, N'San Juan de Miraflores Mz I9 Lt 9')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (28, N'Juan', N'Navia', 911954483, 31763969, N'San Bartolo Mz C8 Lt 15')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (29, N'Alfonso', N'Angulo', 906809238, 57242295, N'Santa Anita Mz A4 Lt 14')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (30, N'Tomás', N'Mejicano', 972653056, 23563966, N'Rímac Mz Z5 Lt 14')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (31, N'Conrado', N'Leal', 990906695, 79117503, N'San Isidro Mz G5 Lt 4')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (32, N'José', N'Sanabria', 987575705, 52188387, N'Pachacámac Mz I3 Lt 21')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (33, N'Luis', N'Arreaga', 976231130, 42759368, N'Villa El Salvador Mz S10 Lt 17')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (34, N'Juan', N'Agueda', 934192695, 53040580, N'Breña Mz J8 Lt 18')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (35, N'Samuel', N'Balensuela', 909272990, 94908705, N'Ate Mz K4 Lt 5')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (36, N'Ambrosio', N'Escalante', 918543643, 15411441, N'Carabayllo Mz F6 Lt 2')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (37, N'Adán', N'Ghico', 918812648, 33474570, N'San Bartolo Mz I10 Lt 7')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (38, N'Mauricio', N'Sotela', 909275226, 31544002, N'San Juan de Lurigancho Mz Z8 Lt 9')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (39, N'Zoilo', N'Guajardo', 965114152, 27554242, N'La Victoria Mz C5 Lt 6')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (40, N'Ponce', N'Camargo', 935858698, 81518416, N'San Bartolo Mz S6 Lt 12')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (41, N'Conrado', N'Llanito', 966012203, 32027477, N'Pucusana Mz P6 Lt 2')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (42, N'Carlos', N'Lagunillas', 998437942, 51532678, N'Los Olivos Mz U3 Lt 11')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (43, N'Pedro', N'Quintanar', 921517300, 75541237, N'San Martín de Porres Mz H10 Lt 23')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (44, N'Sergio', N'Canencia', 946699565, 82305683, N'Surquillo Mz G7 Lt 24')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (45, N'Juan', N'Roque', 954163737, 39791054, N'Chorrillos Mz G5 Lt 20')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (46, N'Edmundo', N'Sevallos', 996457031, 48366311, N'San Borja Mz G6 Lt 3')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (47, N'Ramiro', N'Poso', 996134060, 20439784, N'Miraflores Mz L7 Lt 23')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (48, N'Quintín', N'Caacusi', 944007845, 37358953, N'Lurigancho-Chosica Mz O3 Lt 16')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (49, N'Humberto', N'Olivo', 985269825, 72005281, N'Villa El Salvador Mz L5 Lt 24')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (50, N'Nicolás', N'Lomas', 909052785, 41089151, N'San Juan de Miraflores Mz B1 Lt 5')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (51, N'Ismael', N'Vexarano', 962341015, 66374483, N'Comas Mz M1 Lt 22')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (52, N'Walter', N'Candia', 909572974, 87178309, N'Independencia Mz P5 Lt 17')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (53, N'Bruno', N'Grijalva', 920762179, 83429787, N'Punta Negra Mz F6 Lt 15')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (54, N'Salvador', N'Ceron', 949279178, 42783108, N'Santa Anita Mz Y5 Lt 5')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (55, N'Narciso', N'Portales', 986512197, 28078926, N'Ate Mz G7 Lt 10')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (56, N'Dionisio', N'Raya', 976163112, 50695568, N'Lima Mz O5 Lt 2')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (57, N'Hamza', N'Borjas', 909209434, 22861422, N'Villa El Salvador Mz I7 Lt 3')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (58, N'Camilo', N'Barron', 958105426, 38102870, N'San Borja Mz E1 Lt 4')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (59, N'Aarón', N'Crespin', 928423146, 89274436, N'Lince Mz K4 Lt 22')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (60, N'Humberto', N'Velmudes', 973846400, 28149595, N'San Bartolo Mz D9 Lt 7')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (61, N'Rafael', N'Cuautli', 925992188, 24895397, N'San Martín de Porres Mz Z6 Lt 20')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (62, N'Juan', N'Baina', 988701189, 84111964, N'El Agustino Mz E9 Lt 3')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (63, N'Edmundo', N'Garcia', 984596154, 60963457, N'Chorrillos Mz V2 Lt 10')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (64, N'Jose', N'Paneda', 901335751, 81941209, N'San Martín de Porres Mz L2 Lt 21')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (65, N'Virgilio', N'Caasayu', 922931100, 31254435, N'San Luis Mz H6 Lt 13')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (66, N'Maximiliano', N'Garate', 955897131, 12007966, N'Lince Mz L5 Lt 5')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (67, N'Baltasar', N'Tortolero', 907048180, 86157791, N'Lurin Mz H1 Lt 8')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (68, N'Isidoro', N'Montejano', 921795350, 61215523, N'Jesús María Mz K4 Lt 6')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (69, N'Cayetano', N'Huisache', 977855603, 61547539, N'Punta Negra Mz I10 Lt 8')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (70, N'Ángel', N'Nieves', 906505399, 23628104, N'San Martín de Porres Mz D7 Lt 10')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (71, N'Narciso', N'Serrato', 923583851, 53140464, N'Ancón Mz P5 Lt 19')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (72, N'Jordi', N'Malindo', 948181175, 69613844, N'La Molina Mz J6 Lt 20')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (73, N'Ignacio', N'Jaramiyo', 942052619, 51957041, N'Lima Mz X10 Lt 9')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (74, N'Hamza', N'Cabriales', 979305632, 83593776, N'Carabayllo Mz W1 Lt 14')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (75, N'Yerai', N'Ghsichi', 905225115, 57798943, N'Santa Anita Mz R3 Lt 14')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (76, N'Plácido', N'Sabino', 926069163, 42353295, N'Ancón Mz F10 Lt 16')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (77, N'Francisco', N'Siordia', 921109007, 54036534, N'Punta Negra Mz C1 Lt 9')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (78, N'Conrado', N'Balencuela', 945331781, 25897956, N'San Luis Mz R8 Lt 20')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (79, N'Santiago', N'Abonce', 972968267, 31020823, N'Chaclacayo Mz B9 Lt 20')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (80, N'Alano', N'Ballesteros', 997493839, 85336535, N'Punta Hermosa Mz G6 Lt 14')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (81, N'Óscar', N'Lala', 914745376, 41151817, N'Chaclacayo Mz Y1 Lt 7')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (82, N'Gregorio', N'Leonor', 983017675, 12573550, N'Chaclacayo Mz C8 Lt 20')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (83, N'Sergio', N'Rostro', 905396866, 49273980, N'San Borja Mz U9 Lt 9')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (84, N'Benito', N'Lisarde', 904997939, 54245378, N'Magdalena del Mar Mz W1 Lt 19')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (85, N'Oier', N'Mundo', 905467430, 73891370, N'Carabayllo Mz C1 Lt 21')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (86, N'César', N'Ernandes', 977501012, 53594113, N'Cieneguilla Mz E9 Lt 20')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (87, N'Narciso', N'Esparza', 939002997, 34236111, N'Lurigancho-Chosica Mz Y5 Lt 17')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (88, N'Walter', N'Mota', 991381356, 58453559, N'Pachacámac Mz P2 Lt 8')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (89, N'Miguel', N'Vello', 911675146, 45674807, N'Santa María del Mar Mz P9 Lt 2')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (90, N'Salvador', N'Gines', 919025848, 26385080, N'Chorrillos Mz L2 Lt 7')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (91, N'Crispín', N'Tegeda', 910812441, 36126825, N'La Molina Mz Y9 Lt 24')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (92, N'Marcos', N'Martel', 906420864, 86769472, N'Jesús María Mz X1 Lt 12')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (93, N'Yusef', N'Caquihui', 974966536, 71735929, N'Magdalena del Mar Mz L1 Lt 15')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (94, N'Antonio', N'Bona', 915944728, 33489969, N'Rímac Mz R9 Lt 10')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (95, N'Brais', N'Garivay', 953855667, 40314745, N'Rímac Mz Q5 Lt 1')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (96, N'Lucas', N'Madaleno', 999220598, 50645387, N'Santa María del Mar Mz Z5 Lt 10')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (97, N'Amado', N'Arse', 917037728, 19235798, N'La Victoria Mz F8 Lt 5')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (98, N'Cayetano', N'Cosa', 946591284, 78322797, N'Magdalena del Mar Mz A4 Lt 24')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (99, N'Manuel', N'Pezina', 901815841, 68263317, N'Puente Piedra Mz O4 Lt 21')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (100, N'Simón', N'Carabajal', 922365332, 64686849, N'Lima Mz H6 Lt 24')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (101, N'Aníbal', N'Balensuela', 986883107, 19993877, N'Punta Hermosa Mz L5 Lt 20')
GO
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (102, N'Leo', N'Garavito', 975182365, 85091463, N'La Victoria Mz K3 Lt 24')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (103, N'Clemente', N'Esteves', 998006483, 51276270, N'Lurin Mz S6 Lt 8')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (104, N'Eloy', N'Guadiana', 969279297, 10352077, N'Villa El Salvador Mz G10 Lt 15')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (105, N'Octavio', N'Guia', 912743454, 12299858, N'Pucusana Mz I3 Lt 7')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (106, N'Aarón', N'Bugarin', 951216007, 98371986, N'Miraflores Mz W3 Lt 5')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (107, N'Mariano', N'Estebes', 994808825, 38697203, N'Cieneguilla Mz M3 Lt 11')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (108, N'Joel', N'Nollola', 962190684, 35493976, N'Lima Mz E7 Lt 11')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (109, N'Zacarías', N'Gutierrez', 950617374, 98775719, N'Santiago de Surco Mz S7 Lt 7')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (110, N'Jorge', N'Situta', 939438902, 66551845, N'Surquillo Mz Y6 Lt 20')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (111, N'Federico', N'Valenciano', 956013812, 94865791, N'Punta Negra Mz F1 Lt 22')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (112, N'Hugo', N'Uballe', 916850816, 72349782, N'El Agustino Mz V5 Lt 15')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (113, N'Bruno', N'Mandujano', 988008985, 46843909, N'San Luis Mz O1 Lt 5')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (114, N'Aníbal', N'Capasete', 940126199, 14602501, N'La Victoria Mz N4 Lt 12')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (115, N'Julio', N'Cristan', 978531647, 64465495, N'Pueblo Libre Mz N5 Lt 17')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (116, N'Rubén', N'Landeta', 921377870, 69693444, N'San Bartolo Mz B6 Lt 23')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (117, N'Matías', N'Sevallos', 909000972, 87945251, N'Punta Hermosa Mz O3 Lt 6')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (118, N'Camilo', N'Picon', 934669820, 38553298, N'Santa María del Mar Mz M1 Lt 15')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (119, N'Quintín', N'Encarnacion', 911424832, 76213990, N'Independencia Mz W10 Lt 17')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (120, N'Roberto', N'Esquibias', 941144163, 56038100, N'Los Olivos Mz E7 Lt 14')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (121, N'Macario', N'Gamez', 949332122, 77928585, N'Lince Mz P4 Lt 8')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (122, N'Cayetano', N'Gabia', 935759381, 64322127, N'Chaclacayo Mz B9 Lt 15')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (123, N'Zenon', N'Mereles', 933782318, 63821467, N'Lurigancho-Chosica Mz J9 Lt 12')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (124, N'Jorge', N'Sebilla', 960447049, 66834564, N'Comas Mz E8 Lt 1')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (125, N'Raúl', N'Sacarias', 976120065, 65145159, N'Rímac Mz E8 Lt 4')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (126, N'José', N'Villa', 936524798, 52285440, N'Magdalena del Mar Mz N4 Lt 11')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (127, N'Fabián', N'Olmos', 946896723, 54889976, N'Pachacámac Mz V4 Lt 14')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (128, N'Mikel', N'Damian', 970972955, 93546858, N'La Molina Mz J10 Lt 10')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (129, N'Ernesto', N'Canencia', 955317729, 41373589, N'San Borja Mz Q10 Lt 22')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (130, N'Juan', N'Cena', 922348127, 11441248, N'Breña Mz C2 Lt 14')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (131, N'Borja', N'Acero', 943237782, 95350101, N'Pueblo Libre Mz U9 Lt 21')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (132, N'Adiran', N'Eredia', 985789601, 25245434, N'Lince Mz W4 Lt 9')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (133, N'Eneko', N'Camarena', 998506602, 21110003, N'Pueblo Libre Mz D1 Lt 22')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (135, N'Carlos', N'Gertrudis', 990872537, 87917986, N'Santiago de Surco Mz M10 Lt 8')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (136, N'Gustavo', N'Trillo', 950468250, 81716067, N'San Borja Mz C5 Lt 13')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (137, N'Alfredo', N'Sabaleta', 990178543, 60437866, N'Pucusana Mz L1 Lt 18')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (138, N'Sergio', N'Aredondo', 942356811, 56512386, N'Santiago de Surco Mz H1 Lt 17')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (139, N'Edmundo', N'Malo', 965018429, 59746255, N'San Juan de Lurigancho Mz E10 Lt 17')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (140, N'Boris', N'Ferel', 903762480, 52229182, N'Miraflores Mz M9 Lt 18')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (141, N'Hamza', N'Cirilo', 945156022, 70819466, N'Lurigancho-Chosica Mz Z6 Lt 24')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (142, N'Javier', N'Grasia', 945142678, 74221745, N'Surquillo Mz M3 Lt 13')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (143, N'Jose', N'Griego', 970332389, 53608664, N'San Borja Mz Q2 Lt 14')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (144, N'Joel', N'Rendon', 987082102, 82606328, N'Breña Mz V9 Lt 24')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (145, N'Domingo', N'Ibarra', 938309071, 73177285, N'Cieneguilla Mz K1 Lt 14')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (146, N'Yeray', N'Dominguez', 961480075, 51790376, N'Magdalena del Mar Mz X6 Lt 21')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (147, N'Wen', N'Marfil', 984864032, 83575877, N'Miraflores Mz G3 Lt 24')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (148, N'Joan', N'Ursua', 923295255, 12465032, N'San Borja Mz N7 Lt 18')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (149, N'Borja', N'Cobian', 932939504, 11393379, N'Lima Mz M10 Lt 3')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (150, N'Aníbal', N'Acebes', 977484974, 74970579, N'Ate Mz N10 Lt 3')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (151, N'Lorenzo', N'Ghichi', 943055118, 30180286, N'Los Olivos Mz Z4 Lt 7')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (152, N'Juan', N'Ordorica', 942147843, 90230290, N'Los Olivos Mz Z5 Lt 22')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (153, N'Marcelo', N'Noghi', 930082463, 67736120, N'Lurigancho-Chosica Mz I3 Lt 18')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (154, N'Miguel', N'Huisache', 967523562, 47325714, N'La Victoria Mz K6 Lt 12')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (155, N'José', N'Andrade', 950014148, 43546759, N'Breña Mz Z7 Lt 17')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (156, N'Ramiro', N'Constante', 956951422, 25759070, N'Magdalena del Mar Mz L7 Lt 2')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (157, N'Adolfo', N'Toledo', 972050912, 95852829, N'Lince Mz P4 Lt 20')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (158, N'Rogelio', N'Banegas', 945242957, 86402647, N'Santiago de Surco Mz C10 Lt 10')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (159, N'Ernesto', N'Mansano', 924053017, 56173962, N'Santa María del Mar Mz F9 Lt 8')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (160, N'Yeray', N'Losada', 962268565, 15055446, N'Villa El Salvador Mz V9 Lt 24')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (161, N'Emilio', N'Sostenes', 957545969, 53807883, N'Breña Mz D2 Lt 8')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (162, N'Juan', N'Thobar', 999859433, 57759137, N'San Luis Mz V6 Lt 2')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (163, N'Jaime', N'Sicuau', 998229854, 85402531, N'Villa El Salvador Mz B2 Lt 22')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (164, N'Aarón', N'Cabral', 982833197, 36933606, N'Villa El Salvador Mz I6 Lt 23')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (165, N'Amando', N'Banderas', 950062766, 86994989, N'Chorrillos Mz N6 Lt 7')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (166, N'Aimar', N'Ghsighi', 935440518, 55633064, N'Rímac Mz B1 Lt 12')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (167, N'Andrés', N'Cuechi', 971767313, 63999253, N'Jesús María Mz I9 Lt 24')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (168, N'César', N'Casco', 965196229, 63271649, N'Rímac Mz R2 Lt 13')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (169, N'Agustín', N'Aldaco', 915160422, 53291961, N'Rímac Mz D4 Lt 15')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (170, N'Eduardo', N'Coyote', 956756321, 32539520, N'San Luis Mz U2 Lt 21')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (171, N'Abelardo', N'Landa', 928843989, 36561739, N'San Juan de Miraflores Mz D3 Lt 10')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (172, N'Amadeo', N'Antillon', 922350495, 16802766, N'Punta Negra Mz G9 Lt 18')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (173, N'César', N'Sicusi', 939256894, 61667006, N'La Victoria Mz B6 Lt 8')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (174, N'Adam', N'Ghituta', 943415475, 81158979, N'Ancón Mz D7 Lt 4')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (175, N'Alfredo', N'Garcia', 946152524, 73298992, N'Carabayllo Mz U6 Lt 23')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (176, N'Felipe', N'Preciada', 939258518, 96288591, N'San Isidro Mz H6 Lt 13')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (177, N'Abelardo', N'Sion', 989098675, 63300331, N'San Bartolo Mz A8 Lt 4')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (178, N'Wen', N'Santa', 938357288, 18203046, N'Lurin Mz Z7 Lt 21')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (179, N'Yeray', N'Badiola', 913064880, 99548016, N'Chorrillos Mz F1 Lt 4')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (180, N'Hugo', N'Tierrablanca', 959501691, 12512747, N'La Victoria Mz H7 Lt 11')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (181, N'Andrés', N'Calderon', 977534969, 48330854, N'Barranco Mz M6 Lt 19')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (182, N'Sergi', N'Ghyo', 962902909, 83445495, N'El Agustino Mz S1 Lt 18')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (183, N'Joel', N'Gabia', 928746480, 92012792, N'Santa María del Mar Mz F6 Lt 15')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (184, N'Óscar', N'Guerrero', 970754654, 93147418, N'Independencia Mz F9 Lt 13')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (185, N'Constantino', N'Chagollan', 901064963, 78521925, N'Pueblo Libre Mz I1 Lt 12')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (186, N'Jose', N'Sabaleta', 935395491, 73965075, N'Chorrillos Mz S4 Lt 18')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (187, N'Nathan', N'Canencia', 963583674, 11585169, N'Carabayllo Mz Q9 Lt 14')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (188, N'Francisco', N'Posada', 959329747, 65946765, N'Lurigancho-Chosica Mz B7 Lt 11')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (189, N'Boris', N'Rebolloso', 902805265, 32876257, N'San Bartolo Mz M5 Lt 2')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (190, N'Bernardo', N'Asero', 926874152, 49495912, N'Comas Mz L9 Lt 16')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (191, N'Jesús', N'Ghicuiy', 949964346, 88852323, N'San Juan de Miraflores Mz O6 Lt 10')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (192, N'Yusef', N'Inojos', 969996184, 58563831, N'Comas Mz K4 Lt 12')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (193, N'Isidoro', N'Villavicencio', 957303629, 30818236, N'Cieneguilla Mz F2 Lt 8')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (194, N'Edgar', N'Marfil', 987408739, 11889759, N'Chorrillos Mz D6 Lt 2')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (195, N'Abelardo', N'Gongora', 980959281, 86401714, N'Pucusana Mz E9 Lt 6')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (196, N'Bruno', N'Antonio', 908978905, 69917945, N'Ate Mz D9 Lt 2')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (197, N'Amin', N'Texeda', 987366535, 76866565, N'San Isidro Mz X8 Lt 1')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (198, N'Francisco', N'Araiza', 997164260, 35550423, N'Los Olivos Mz U7 Lt 20')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (199, N'Macario', N'Tranquilino', 904250326, 52757242, N'La Victoria Mz C6 Lt 19')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (200, N'Tomás', N'Oviedo', 976421237, 61758472, N'San Miguel Mz Y4 Lt 15')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (201, N'Omar', N'Messa', 932124433, 31506510, N'Jesús María Mz E7 Lt 20')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (202, N'Desiderio', N'Sermeno', 923970935, 42294445, N'Lurigancho-Chosica Mz N1 Lt 6')
GO
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (203, N'Bernardo', N'Salais', 964477180, 66663673, N'Cieneguilla Mz H5 Lt 13')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (204, N'Claudio', N'Razon', 985763208, 65916134, N'Pachacámac Mz Q10 Lt 14')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (205, N'Benjamín', N'Siranda', 983980810, 78178980, N'Punta Negra Mz J5 Lt 16')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (206, N'Alejandro', N'Zabala', 977890625, 62319735, N'Breña Mz H1 Lt 1')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (207, N'Juan', N'Alva', 914374762, 62158864, N'San Luis Mz E1 Lt 13')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (208, N'Agustín', N'Samorano', 914944353, 60282274, N'Punta Hermosa Mz H7 Lt 1')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (209, N'Alejandro', N'Lueza', 951981205, 48794992, N'San Juan de Miraflores Mz B5 Lt 11')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (210, N'Daniel', N'Briseno', 986981309, 47645175, N'Punta Negra Mz H8 Lt 19')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (211, N'Yerai', N'Fernandez', 917188293, 25151300, N'Pueblo Libre Mz F1 Lt 7')
INSERT [dbo].[Cliente] ([id_cliente], [nombre], [apellido], [celular], [DNI], [direccion]) VALUES (212, N'Roberto', N'Ossorio', 903400219, 39003577, N'Carabayllo Mz M5 Lt 4')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
SET IDENTITY_INSERT [dbo].[Equipo] ON 

INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (6, N'Equipo1', CAST(285.01 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (7, N'Equipo2', CAST(201.80 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (8, N'Equipo3', CAST(158.47 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (9, N'Equipo4', CAST(93.76 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (10, N'Equipo5', CAST(398.09 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (11, N'Equipo6', CAST(209.47 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (12, N'Equipo7', CAST(397.44 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (13, N'Equipo8', CAST(421.92 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (14, N'Equipo9', CAST(376.64 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (15, N'Equipo10', CAST(264.35 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (16, N'Equipo11', CAST(311.26 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (17, N'Equipo12', CAST(66.85 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (18, N'Equipo13', CAST(60.04 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (19, N'Equipo14', CAST(141.58 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (20, N'Equipo15', CAST(304.19 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (21, N'Equipo16', CAST(267.46 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (22, N'Equipo17', CAST(184.76 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (23, N'Equipo18', CAST(259.60 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (24, N'Equipo19', CAST(324.93 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (25, N'Equipo20', CAST(193.23 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (26, N'Equipo21', CAST(256.76 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (27, N'Equipo22', CAST(29.33 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (28, N'Equipo23', CAST(403.96 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (29, N'Equipo24', CAST(493.65 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (30, N'Equipo25', CAST(249.98 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (31, N'Equipo26', CAST(438.35 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (32, N'Equipo27', CAST(104.42 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (33, N'Equipo28', CAST(79.89 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (34, N'Equipo29', CAST(298.44 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (35, N'Equipo30', CAST(63.02 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (36, N'Equipo31', CAST(87.29 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (37, N'Equipo32', CAST(264.39 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (38, N'Equipo33', CAST(171.47 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (39, N'Equipo34', CAST(281.97 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (40, N'Equipo35', CAST(171.98 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (41, N'Equipo36', CAST(14.22 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (42, N'Equipo37', CAST(435.96 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (43, N'Equipo38', CAST(298.66 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (44, N'Equipo39', CAST(142.06 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (45, N'Equipo40', CAST(430.44 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (46, N'Equipo41', CAST(172.31 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (47, N'Equipo42', CAST(310.62 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (48, N'Equipo43', CAST(116.40 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (49, N'Equipo44', CAST(214.11 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (50, N'Equipo45', CAST(67.10 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (51, N'Equipo46', CAST(131.17 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (52, N'Equipo47', CAST(50.38 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (53, N'Equipo48', CAST(446.38 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (54, N'Equipo49', CAST(430.22 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (55, N'Equipo50', CAST(364.60 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (56, N'Equipo51', CAST(182.90 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (57, N'Equipo52', CAST(152.46 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (58, N'Equipo53', CAST(443.36 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (59, N'Equipo54', CAST(194.56 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (60, N'Equipo55', CAST(87.55 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (61, N'Equipo56', CAST(118.73 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (62, N'Equipo57', CAST(474.07 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (63, N'Equipo58', CAST(491.11 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (64, N'Equipo59', CAST(442.55 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (65, N'Equipo60', CAST(226.63 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (66, N'Equipo61', CAST(172.68 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (67, N'Equipo62', CAST(393.74 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (68, N'Equipo63', CAST(11.96 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (69, N'Equipo64', CAST(170.17 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (70, N'Equipo65', CAST(209.24 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (71, N'Equipo66', CAST(279.62 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (72, N'Equipo67', CAST(361.99 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (73, N'Equipo68', CAST(246.36 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (74, N'Equipo69', CAST(137.84 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (75, N'Equipo70', CAST(329.71 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (76, N'Equipo71', CAST(384.98 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (77, N'Equipo72', CAST(340.03 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (78, N'Equipo73', CAST(241.59 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (79, N'Equipo74', CAST(438.58 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (80, N'Equipo75', CAST(99.98 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (81, N'Equipo76', CAST(383.97 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (82, N'Equipo77', CAST(403.80 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (83, N'Equipo78', CAST(94.85 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (84, N'Equipo79', CAST(428.16 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (85, N'Equipo80', CAST(292.07 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (86, N'Equipo81', CAST(301.08 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (87, N'Equipo82', CAST(140.16 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (88, N'Equipo83', CAST(358.78 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (89, N'Equipo84', CAST(18.82 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (90, N'Equipo85', CAST(212.47 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (91, N'Equipo86', CAST(192.32 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (92, N'Equipo87', CAST(269.73 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (93, N'Equipo88', CAST(385.77 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (94, N'Equipo89', CAST(441.04 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (95, N'Equipo90', CAST(262.52 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (96, N'Equipo91', CAST(116.18 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (97, N'Equipo92', CAST(303.55 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (98, N'Equipo93', CAST(172.82 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (99, N'Equipo94', CAST(385.39 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (100, N'Equipo95', CAST(203.77 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (101, N'Equipo96', CAST(378.36 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (102, N'Equipo97', CAST(267.50 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (103, N'Equipo98', CAST(126.41 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (104, N'Equipo99', CAST(31.75 AS Decimal(18, 2)))
GO
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (105, N'Equipo100', CAST(273.45 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (106, N'Equipo101', CAST(137.91 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (107, N'Equipo102', CAST(138.47 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (108, N'Equipo103', CAST(247.53 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (109, N'Equipo104', CAST(263.91 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (110, N'Equipo105', CAST(226.46 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (111, N'Equipo106', CAST(394.50 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (112, N'Equipo107', CAST(322.73 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (113, N'Equipo108', CAST(101.16 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (114, N'Equipo109', CAST(337.37 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (115, N'Equipo110', CAST(34.74 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (116, N'Equipo111', CAST(287.47 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (117, N'Equipo112', CAST(305.79 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (118, N'Equipo113', CAST(418.32 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (119, N'Equipo114', CAST(253.73 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (120, N'Equipo115', CAST(289.87 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (121, N'Equipo116', CAST(136.82 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (122, N'Equipo117', CAST(109.33 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (123, N'Equipo118', CAST(127.41 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (124, N'Equipo119', CAST(46.99 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (125, N'Equipo120', CAST(349.92 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (126, N'Equipo121', CAST(263.50 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (127, N'Equipo122', CAST(13.20 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (128, N'Equipo123', CAST(406.15 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (129, N'Equipo124', CAST(381.09 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (130, N'Equipo125', CAST(259.00 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (131, N'Equipo126', CAST(178.31 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (132, N'Equipo127', CAST(438.81 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (133, N'Equipo128', CAST(128.59 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (134, N'Equipo129', CAST(206.87 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (135, N'Equipo130', CAST(232.31 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (136, N'Equipo131', CAST(313.75 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (137, N'Equipo132', CAST(120.09 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (138, N'Equipo133', CAST(203.94 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (139, N'Equipo134', CAST(199.44 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (140, N'Equipo135', CAST(453.15 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (141, N'Equipo136', CAST(29.24 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (142, N'Equipo137', CAST(498.97 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (143, N'Equipo138', CAST(131.57 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (144, N'Equipo139', CAST(248.83 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (145, N'Equipo140', CAST(222.81 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (146, N'Equipo141', CAST(134.20 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (147, N'Equipo142', CAST(39.97 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (148, N'Equipo143', CAST(119.86 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (149, N'Equipo144', CAST(494.24 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (150, N'Equipo145', CAST(395.21 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (151, N'Equipo146', CAST(108.69 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (152, N'Equipo147', CAST(418.65 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (153, N'Equipo148', CAST(187.72 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (154, N'Equipo149', CAST(103.49 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (155, N'Equipo150', CAST(379.61 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (156, N'Equipo151', CAST(281.23 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (157, N'Equipo152', CAST(149.28 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (158, N'Equipo153', CAST(326.68 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (159, N'Equipo154', CAST(234.42 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (160, N'Equipo155', CAST(454.04 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (161, N'Equipo156', CAST(302.79 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (162, N'Equipo157', CAST(245.14 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (163, N'Equipo158', CAST(479.75 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (164, N'Equipo159', CAST(61.11 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (165, N'Equipo160', CAST(13.79 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (166, N'Equipo161', CAST(303.62 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (167, N'Equipo162', CAST(127.22 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (168, N'Equipo163', CAST(114.96 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (169, N'Equipo164', CAST(135.93 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (170, N'Equipo165', CAST(23.74 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (171, N'Equipo166', CAST(469.99 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (172, N'Equipo167', CAST(70.45 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (173, N'Equipo168', CAST(353.56 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (174, N'Equipo169', CAST(79.42 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (175, N'Equipo170', CAST(421.06 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (176, N'Equipo171', CAST(479.07 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (177, N'Equipo172', CAST(200.97 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (178, N'Equipo173', CAST(237.13 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (179, N'Equipo174', CAST(275.31 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (180, N'Equipo175', CAST(408.17 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (181, N'Equipo176', CAST(189.14 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (182, N'Equipo177', CAST(408.07 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (183, N'Equipo178', CAST(239.63 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (184, N'Equipo179', CAST(331.71 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (185, N'Equipo180', CAST(65.68 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (186, N'Equipo181', CAST(431.25 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (187, N'Equipo182', CAST(103.13 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (188, N'Equipo183', CAST(322.34 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (189, N'Equipo184', CAST(462.15 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (190, N'Equipo185', CAST(14.58 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (191, N'Equipo186', CAST(46.07 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (192, N'Equipo187', CAST(11.21 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (193, N'Equipo188', CAST(227.89 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (194, N'Equipo189', CAST(61.34 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (195, N'Equipo190', CAST(453.74 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (196, N'Equipo191', CAST(445.31 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (197, N'Equipo192', CAST(139.97 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (198, N'Equipo193', CAST(207.61 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (199, N'Equipo194', CAST(347.09 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (200, N'Equipo195', CAST(284.61 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (201, N'Equipo196', CAST(31.67 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (202, N'Equipo197', CAST(466.24 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (203, N'Equipo198', CAST(329.76 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (204, N'Equipo199', CAST(188.29 AS Decimal(18, 2)))
GO
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (205, N'Equipo200', CAST(187.57 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (206, N'Equipo201', CAST(271.90 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (207, N'Equipo202', CAST(283.32 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (208, N'Equipo203', CAST(116.05 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (209, N'Equipo204', CAST(245.88 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (210, N'Equipo205', CAST(412.06 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (211, N'Equipo206', CAST(467.46 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (212, N'Equipo207', CAST(146.30 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (213, N'Equipo208', CAST(310.73 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (214, N'Equipo209', CAST(366.17 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (215, N'Equipo210', CAST(189.28 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (216, N'Equipo211', CAST(315.99 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (217, N'Equipo212', CAST(311.98 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (218, N'Equipo213', CAST(32.70 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (219, N'Equipo214', CAST(453.02 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (220, N'Equipo215', CAST(82.41 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (221, N'Equipo216', CAST(178.75 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (222, N'Equipo217', CAST(69.04 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (223, N'Equipo218', CAST(456.75 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (224, N'Equipo219', CAST(32.77 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (225, N'Equipo220', CAST(116.30 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (226, N'Equipo221', CAST(397.62 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (227, N'Equipo222', CAST(252.48 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (228, N'Equipo223', CAST(315.50 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (229, N'Equipo224', CAST(51.78 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (230, N'Equipo225', CAST(21.18 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (231, N'Equipo226', CAST(369.28 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (232, N'Equipo227', CAST(239.58 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (233, N'Equipo228', CAST(94.10 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (234, N'Equipo229', CAST(13.86 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (235, N'Equipo230', CAST(93.94 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (236, N'Equipo231', CAST(465.86 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (237, N'Equipo232', CAST(88.54 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (238, N'Equipo233', CAST(272.97 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (239, N'Equipo234', CAST(306.29 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (240, N'Equipo235', CAST(36.79 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (241, N'Equipo236', CAST(19.99 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (242, N'Equipo237', CAST(289.26 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (243, N'Equipo238', CAST(254.15 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (244, N'Equipo239', CAST(51.58 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (245, N'Equipo240', CAST(370.40 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (246, N'Equipo241', CAST(229.18 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (247, N'Equipo242', CAST(180.11 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (248, N'Equipo243', CAST(364.26 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (249, N'Equipo244', CAST(302.04 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (250, N'Equipo245', CAST(473.21 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (251, N'Equipo246', CAST(274.15 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (252, N'Equipo247', CAST(429.88 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (253, N'Equipo248', CAST(93.01 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (254, N'Equipo249', CAST(472.33 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (255, N'Equipo250', CAST(258.56 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (256, N'Equipo251', CAST(198.86 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (257, N'Equipo252', CAST(261.41 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (258, N'Equipo253', CAST(344.58 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (259, N'Equipo254', CAST(108.32 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (260, N'Equipo255', CAST(284.36 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (261, N'Equipo256', CAST(12.66 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (262, N'Equipo257', CAST(147.31 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (263, N'Equipo258', CAST(400.83 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (264, N'Equipo259', CAST(486.99 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (265, N'Equipo260', CAST(113.02 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (266, N'Equipo261', CAST(375.47 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (267, N'Equipo262', CAST(153.35 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (268, N'Equipo263', CAST(326.73 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (269, N'Equipo264', CAST(319.15 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (270, N'Equipo265', CAST(178.75 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (271, N'Equipo266', CAST(179.75 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (272, N'Equipo267', CAST(49.23 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (273, N'Equipo268', CAST(469.37 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (274, N'Equipo269', CAST(207.67 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (275, N'Equipo270', CAST(130.61 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (276, N'Equipo271', CAST(60.71 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (277, N'Equipo272', CAST(226.77 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (278, N'Equipo273', CAST(402.24 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (279, N'Equipo274', CAST(278.70 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (280, N'Equipo275', CAST(406.05 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (281, N'Equipo276', CAST(410.45 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (282, N'Equipo277', CAST(438.05 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (283, N'Equipo278', CAST(485.66 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (284, N'Equipo279', CAST(498.80 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (285, N'Equipo280', CAST(272.25 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (286, N'Equipo281', CAST(346.94 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (287, N'Equipo282', CAST(466.75 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (288, N'Equipo283', CAST(433.99 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (289, N'Equipo284', CAST(19.97 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (290, N'Equipo285', CAST(373.47 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (291, N'Equipo286', CAST(104.74 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (292, N'Equipo287', CAST(267.21 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (293, N'Equipo288', CAST(207.32 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (294, N'Equipo289', CAST(266.84 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (295, N'Equipo290', CAST(472.16 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (296, N'Equipo291', CAST(114.25 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (297, N'Equipo292', CAST(65.67 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (298, N'Equipo293', CAST(412.36 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (299, N'Equipo294', CAST(413.81 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (300, N'Equipo295', CAST(340.54 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (301, N'Equipo296', CAST(400.82 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (302, N'Equipo297', CAST(474.44 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (303, N'Equipo298', CAST(224.76 AS Decimal(18, 2)))
INSERT [dbo].[Equipo] ([id_equipo], [nombre], [precio_alquiler]) VALUES (304, N'Equipo299', CAST(467.56 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[Equipo] OFF
SET IDENTITY_INSERT [dbo].[Evento] ON 

INSERT [dbo].[Evento] ([id_evento], [id_cliente], [id_local], [nombre], [objetivo], [nro_asistentes], [fecha_evento], [encargado]) VALUES (2, 1, 1, N'reunion', N'realizar algo', 100, CAST(N'2018-10-10 22:12:41.000' AS DateTime), N'Luis Ortiz')
INSERT [dbo].[Evento] ([id_evento], [id_cliente], [id_local], [nombre], [objetivo], [nro_asistentes], [fecha_evento], [encargado]) VALUES (3, 5, 4, N'matrimonio', N'Fiesta inolvidable', 300, CAST(N'2018-10-20 00:57:33.000' AS DateTime), N'Ludovico Nixon')
INSERT [dbo].[Evento] ([id_evento], [id_cliente], [id_local], [nombre], [objetivo], [nro_asistentes], [fecha_evento], [encargado]) VALUES (4, 8, 8, N'Cumple Joaquin', N'cumpleaños', 600, CAST(N'2018-10-19 22:12:41.000' AS DateTime), N'Ruben Bernardes')
INSERT [dbo].[Evento] ([id_evento], [id_cliente], [id_local], [nombre], [objetivo], [nro_asistentes], [fecha_evento], [encargado]) VALUES (5, 11, 6, N'EventoEjecutivo', N'Cena', 100, CAST(N'2018-10-19 22:12:41.000' AS DateTime), N'Bianca Antonia')
INSERT [dbo].[Evento] ([id_evento], [id_cliente], [id_local], [nombre], [objetivo], [nro_asistentes], [fecha_evento], [encargado]) VALUES (6, 9, 1, N'JorgeFiesta', N'Cumpleaños', 250, CAST(N'2018-10-18 22:12:41.000' AS DateTime), N'Kevin Franco')
SET IDENTITY_INSERT [dbo].[Evento] OFF
SET IDENTITY_INSERT [dbo].[Evento_Actividad] ON 

INSERT [dbo].[Evento_Actividad] ([id_evento_actividad], [id_evento], [id_actividad], [hora_inicio], [hora_fin]) VALUES (8, 2, 7, CAST(N'2018-10-15 01:00:01.000' AS DateTime), CAST(N'2018-10-15 02:00:01.000' AS DateTime))
INSERT [dbo].[Evento_Actividad] ([id_evento_actividad], [id_evento], [id_actividad], [hora_inicio], [hora_fin]) VALUES (9, 2, 20, CAST(N'2018-10-15 02:00:01.000' AS DateTime), CAST(N'2018-10-15 03:00:01.000' AS DateTime))
INSERT [dbo].[Evento_Actividad] ([id_evento_actividad], [id_evento], [id_actividad], [hora_inicio], [hora_fin]) VALUES (10, 2, 33, CAST(N'2018-10-15 03:00:01.000' AS DateTime), CAST(N'2018-10-15 04:00:01.000' AS DateTime))
INSERT [dbo].[Evento_Actividad] ([id_evento_actividad], [id_evento], [id_actividad], [hora_inicio], [hora_fin]) VALUES (11, 3, 13, CAST(N'2018-10-15 01:00:01.000' AS DateTime), CAST(N'2018-10-15 02:00:01.000' AS DateTime))
INSERT [dbo].[Evento_Actividad] ([id_evento_actividad], [id_evento], [id_actividad], [hora_inicio], [hora_fin]) VALUES (12, 3, 7, CAST(N'2018-10-15 02:00:01.000' AS DateTime), CAST(N'2018-10-15 03:00:01.000' AS DateTime))
INSERT [dbo].[Evento_Actividad] ([id_evento_actividad], [id_evento], [id_actividad], [hora_inicio], [hora_fin]) VALUES (13, 3, 20, CAST(N'2018-10-15 03:00:01.000' AS DateTime), CAST(N'2018-10-15 04:00:01.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Evento_Actividad] OFF
SET IDENTITY_INSERT [dbo].[Evento_Equipo] ON 

INSERT [dbo].[Evento_Equipo] ([id_evento_equipo], [id_evento], [id_equipo]) VALUES (6, 3, 8)
INSERT [dbo].[Evento_Equipo] ([id_evento_equipo], [id_evento], [id_equipo]) VALUES (7, 3, 22)
INSERT [dbo].[Evento_Equipo] ([id_evento_equipo], [id_evento], [id_equipo]) VALUES (8, 3, 23)
INSERT [dbo].[Evento_Equipo] ([id_evento_equipo], [id_evento], [id_equipo]) VALUES (9, 2, 11)
INSERT [dbo].[Evento_Equipo] ([id_evento_equipo], [id_evento], [id_equipo]) VALUES (10, 2, 21)
SET IDENTITY_INSERT [dbo].[Evento_Equipo] OFF
SET IDENTITY_INSERT [dbo].[Evento_Material] ON 

INSERT [dbo].[Evento_Material] ([id_evento_material], [id_evento], [id_material]) VALUES (4, 2, 7)
INSERT [dbo].[Evento_Material] ([id_evento_material], [id_evento], [id_material]) VALUES (5, 2, 15)
INSERT [dbo].[Evento_Material] ([id_evento_material], [id_evento], [id_material]) VALUES (6, 2, 34)
INSERT [dbo].[Evento_Material] ([id_evento_material], [id_evento], [id_material]) VALUES (7, 6, 9)
INSERT [dbo].[Evento_Material] ([id_evento_material], [id_evento], [id_material]) VALUES (8, 6, 7)
SET IDENTITY_INSERT [dbo].[Evento_Material] OFF
SET IDENTITY_INSERT [dbo].[Evento_Personal] ON 

INSERT [dbo].[Evento_Personal] ([id_evento_personal], [id_evento], [id_personal], [horas_trab]) VALUES (4, 2, 1, 4)
INSERT [dbo].[Evento_Personal] ([id_evento_personal], [id_evento], [id_personal], [horas_trab]) VALUES (5, 2, 15, 2)
INSERT [dbo].[Evento_Personal] ([id_evento_personal], [id_evento], [id_personal], [horas_trab]) VALUES (6, 2, 20, 2)
INSERT [dbo].[Evento_Personal] ([id_evento_personal], [id_evento], [id_personal], [horas_trab]) VALUES (7, 6, 26, 5)
INSERT [dbo].[Evento_Personal] ([id_evento_personal], [id_evento], [id_personal], [horas_trab]) VALUES (9, 3, 8, 6)
SET IDENTITY_INSERT [dbo].[Evento_Personal] OFF
SET IDENTITY_INSERT [dbo].[Evento_Servicio] ON 

INSERT [dbo].[Evento_Servicio] ([id_evento_servicio], [id_evento], [id_servicio]) VALUES (3, 4, 3)
INSERT [dbo].[Evento_Servicio] ([id_evento_servicio], [id_evento], [id_servicio]) VALUES (4, 4, 1)
INSERT [dbo].[Evento_Servicio] ([id_evento_servicio], [id_evento], [id_servicio]) VALUES (5, 4, 6)
INSERT [dbo].[Evento_Servicio] ([id_evento_servicio], [id_evento], [id_servicio]) VALUES (6, 5, 1)
INSERT [dbo].[Evento_Servicio] ([id_evento_servicio], [id_evento], [id_servicio]) VALUES (7, 5, 3)
INSERT [dbo].[Evento_Servicio] ([id_evento_servicio], [id_evento], [id_servicio]) VALUES (8, 5, 9)
INSERT [dbo].[Evento_Servicio] ([id_evento_servicio], [id_evento], [id_servicio]) VALUES (10, 6, 2)
SET IDENTITY_INSERT [dbo].[Evento_Servicio] OFF
SET IDENTITY_INSERT [dbo].[Local] ON 

INSERT [dbo].[Local] ([id_local], [nombre], [direccion], [capacidad]) VALUES (1, N'la Isla de Villa', N'Almeda Don Santiago Lote 03', 2000)
INSERT [dbo].[Local] ([id_local], [nombre], [direccion], [capacidad]) VALUES (3, N'Local ', N'av buenos aires ', 1233)
INSERT [dbo].[Local] ([id_local], [nombre], [direccion], [capacidad]) VALUES (4, N'Escencia', N'Los precursores 123', 3000)
INSERT [dbo].[Local] ([id_local], [nombre], [direccion], [capacidad]) VALUES (5, N'Hacienda lomas ', N'Calle Villa 876', 2000)
INSERT [dbo].[Local] ([id_local], [nombre], [direccion], [capacidad]) VALUES (6, N'La isla', N'calle hormigas 54', 1500)
INSERT [dbo].[Local] ([id_local], [nombre], [direccion], [capacidad]) VALUES (8, N'la cascada', N'Av san marcos 863', 1400)
INSERT [dbo].[Local] ([id_local], [nombre], [direccion], [capacidad]) VALUES (9, N'SA Eventos', N'calle espiritu santo 43', 500)
SET IDENTITY_INSERT [dbo].[Local] OFF
SET IDENTITY_INSERT [dbo].[Material] ON 

INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (7, N'Material1', CAST(36.21 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (8, N'Material2', CAST(29.39 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (9, N'Material3', CAST(49.70 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (10, N'Material4', CAST(24.64 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (11, N'Material5', CAST(47.24 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (12, N'Material6', CAST(11.89 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (13, N'Material7', CAST(39.17 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (14, N'Material8', CAST(47.73 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (15, N'Material9', CAST(24.57 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (16, N'Material10', CAST(17.08 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (17, N'Material11', CAST(40.95 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (18, N'Material12', CAST(15.69 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (19, N'Material13', CAST(37.83 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (20, N'Material14', CAST(29.21 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (21, N'Material15', CAST(14.95 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (22, N'Material16', CAST(17.17 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (23, N'Material17', CAST(33.19 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (24, N'Material18', CAST(47.56 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (25, N'Material19', CAST(24.46 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (26, N'Material20', CAST(21.47 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (27, N'Material21', CAST(46.89 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (28, N'Material22', CAST(39.34 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (29, N'Material23', CAST(14.56 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (30, N'Material24', CAST(15.03 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (31, N'Material25', CAST(47.79 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (32, N'Material26', CAST(18.15 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (33, N'Material27', CAST(47.73 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (34, N'Material28', CAST(36.55 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (35, N'Material29', CAST(26.20 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (36, N'Material30', CAST(33.02 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (37, N'Material31', CAST(14.83 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (38, N'Material32', CAST(11.09 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (39, N'Material33', CAST(31.22 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (40, N'Material34', CAST(24.16 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (41, N'Material35', CAST(20.49 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (42, N'Material36', CAST(15.63 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (43, N'Material37', CAST(42.02 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (44, N'Material38', CAST(43.30 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (45, N'Material39', CAST(25.56 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (46, N'Material40', CAST(12.43 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (47, N'Material41', CAST(24.95 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (48, N'Material42', CAST(47.13 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (49, N'Material43', CAST(29.47 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (50, N'Material44', CAST(39.66 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (51, N'Material45', CAST(11.41 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (52, N'Material46', CAST(12.96 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (53, N'Material47', CAST(40.05 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (54, N'Material48', CAST(40.15 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (55, N'Material49', CAST(30.03 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (56, N'Material50', CAST(37.69 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (57, N'Material51', CAST(47.62 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (58, N'Material52', CAST(47.29 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (59, N'Material53', CAST(47.49 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (60, N'Material54', CAST(10.61 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (61, N'Material55', CAST(40.04 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (62, N'Material56', CAST(49.05 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (63, N'Material57', CAST(48.35 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (64, N'Material58', CAST(23.98 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (65, N'Material59', CAST(49.20 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (66, N'Material60', CAST(47.25 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (67, N'Material61', CAST(10.24 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (68, N'Material62', CAST(18.95 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (69, N'Material63', CAST(12.95 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (70, N'Material64', CAST(30.73 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (71, N'Material65', CAST(31.16 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (72, N'Material66', CAST(42.48 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (73, N'Material67', CAST(10.89 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (74, N'Material68', CAST(42.65 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (75, N'Material69', CAST(39.40 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (76, N'Material70', CAST(26.55 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (77, N'Material71', CAST(11.07 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (78, N'Material72', CAST(44.42 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (79, N'Material73', CAST(26.13 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (80, N'Material74', CAST(12.26 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (81, N'Material75', CAST(14.54 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (82, N'Material76', CAST(16.39 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (83, N'Material77', CAST(29.88 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (84, N'Material78', CAST(27.58 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (85, N'Material79', CAST(45.92 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (86, N'Material80', CAST(43.23 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (87, N'Material81', CAST(36.17 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (88, N'Material82', CAST(18.82 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (89, N'Material83', CAST(25.59 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (90, N'Material84', CAST(42.45 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (91, N'Material85', CAST(40.72 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (92, N'Material86', CAST(43.10 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (93, N'Material87', CAST(43.46 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (94, N'Material88', CAST(26.76 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (95, N'Material89', CAST(14.96 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (96, N'Material90', CAST(26.06 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (97, N'Material91', CAST(25.44 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (98, N'Material92', CAST(14.67 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (99, N'Material93', CAST(41.03 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (100, N'Material94', CAST(20.05 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (101, N'Material95', CAST(21.51 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (102, N'Material96', CAST(43.03 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (103, N'Material97', CAST(42.04 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (104, N'Material98', CAST(47.68 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (105, N'Material99', CAST(28.78 AS Decimal(18, 2)))
GO
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (106, N'Material100', CAST(27.04 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (107, N'Material101', CAST(46.59 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (108, N'Material102', CAST(15.89 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (109, N'Material103', CAST(27.47 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (110, N'Material104', CAST(16.45 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (111, N'Material105', CAST(38.33 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (112, N'Material106', CAST(14.52 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (113, N'Material107', CAST(38.90 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (114, N'Material108', CAST(42.16 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (115, N'Material109', CAST(15.95 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (116, N'Material110', CAST(35.65 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (117, N'Material111', CAST(42.95 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (118, N'Material112', CAST(30.10 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (119, N'Material113', CAST(18.12 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (120, N'Material114', CAST(11.17 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (121, N'Material115', CAST(30.31 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (122, N'Material116', CAST(24.02 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (123, N'Material117', CAST(22.36 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (124, N'Material118', CAST(41.46 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (125, N'Material119', CAST(48.14 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (126, N'Material120', CAST(17.01 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (127, N'Material121', CAST(44.87 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (128, N'Material122', CAST(11.18 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (129, N'Material123', CAST(47.46 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (130, N'Material124', CAST(25.57 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (131, N'Material125', CAST(41.57 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (132, N'Material126', CAST(24.54 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (133, N'Material127', CAST(37.27 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (134, N'Material128', CAST(49.96 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (135, N'Material129', CAST(18.61 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (136, N'Material130', CAST(14.13 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (137, N'Material131', CAST(26.05 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (138, N'Material132', CAST(48.51 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (139, N'Material133', CAST(34.16 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (140, N'Material134', CAST(17.68 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (141, N'Material135', CAST(10.30 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (142, N'Material136', CAST(24.10 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (143, N'Material137', CAST(19.78 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (144, N'Material138', CAST(33.90 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (145, N'Material139', CAST(13.17 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (146, N'Material140', CAST(23.36 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (147, N'Material141', CAST(40.57 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (148, N'Material142', CAST(11.03 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (149, N'Material143', CAST(12.94 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (150, N'Material144', CAST(46.72 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (151, N'Material145', CAST(25.15 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (152, N'Material146', CAST(23.88 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (153, N'Material147', CAST(42.71 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (154, N'Material148', CAST(36.49 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (155, N'Material149', CAST(47.45 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (156, N'Material150', CAST(29.44 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (157, N'Material151', CAST(12.44 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (158, N'Material152', CAST(16.74 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (159, N'Material153', CAST(21.66 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (160, N'Material154', CAST(26.99 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (161, N'Material155', CAST(11.86 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (162, N'Material156', CAST(10.85 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (163, N'Material157', CAST(36.74 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (164, N'Material158', CAST(29.49 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (165, N'Material159', CAST(46.18 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (166, N'Material160', CAST(34.52 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (167, N'Material161', CAST(17.14 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (168, N'Material162', CAST(22.68 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (169, N'Material163', CAST(13.81 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (170, N'Material164', CAST(22.85 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (171, N'Material165', CAST(39.17 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (172, N'Material166', CAST(42.77 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (173, N'Material167', CAST(37.09 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (174, N'Material168', CAST(13.50 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (175, N'Material169', CAST(41.44 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (176, N'Material170', CAST(21.84 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (177, N'Material171', CAST(48.84 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (178, N'Material172', CAST(27.11 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (179, N'Material173', CAST(39.19 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (180, N'Material174', CAST(33.61 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (181, N'Material175', CAST(21.12 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (182, N'Material176', CAST(35.87 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (183, N'Material177', CAST(34.12 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (184, N'Material178', CAST(28.80 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (185, N'Material179', CAST(36.06 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (186, N'Material180', CAST(41.81 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (187, N'Material181', CAST(29.29 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (188, N'Material182', CAST(37.40 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (189, N'Material183', CAST(17.14 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (190, N'Material184', CAST(32.15 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (191, N'Material185', CAST(13.83 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (192, N'Material186', CAST(25.99 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (193, N'Material187', CAST(31.94 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (194, N'Material188', CAST(48.45 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (195, N'Material189', CAST(29.05 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (196, N'Material190', CAST(44.28 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (197, N'Material191', CAST(18.34 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (198, N'Material192', CAST(33.67 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (199, N'Material193', CAST(28.94 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (200, N'Material194', CAST(48.46 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (201, N'Material195', CAST(47.66 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (202, N'Material196', CAST(35.95 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (203, N'Material197', CAST(32.93 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (204, N'Material198', CAST(11.85 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (205, N'Material199', CAST(38.02 AS Decimal(18, 2)))
GO
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (206, N'Material200', CAST(31.18 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (207, N'Material201', CAST(14.49 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (208, N'Material202', CAST(10.55 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (209, N'Material203', CAST(44.49 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (210, N'Material204', CAST(49.67 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (211, N'Material205', CAST(36.29 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (212, N'Material206', CAST(18.94 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (213, N'Material207', CAST(43.99 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (214, N'Material208', CAST(22.52 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (215, N'Material209', CAST(46.74 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (216, N'Material210', CAST(11.78 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (217, N'Material211', CAST(10.97 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (218, N'Material212', CAST(43.44 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (219, N'Material213', CAST(40.20 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (220, N'Material214', CAST(15.24 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (221, N'Material215', CAST(33.81 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (222, N'Material216', CAST(45.42 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (223, N'Material217', CAST(37.50 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (224, N'Material218', CAST(32.68 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (225, N'Material219', CAST(11.84 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (226, N'Material220', CAST(45.03 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (227, N'Material221', CAST(16.12 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (228, N'Material222', CAST(10.67 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (229, N'Material223', CAST(44.81 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (230, N'Material224', CAST(32.47 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (231, N'Material225', CAST(23.03 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (232, N'Material226', CAST(34.91 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (233, N'Material227', CAST(17.21 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (234, N'Material228', CAST(49.02 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (235, N'Material229', CAST(19.50 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (236, N'Material230', CAST(49.78 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (237, N'Material231', CAST(37.44 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (238, N'Material232', CAST(35.55 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (239, N'Material233', CAST(27.11 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (240, N'Material234', CAST(32.11 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (241, N'Material235', CAST(49.94 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (242, N'Material236', CAST(29.74 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (243, N'Material237', CAST(30.00 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (244, N'Material238', CAST(28.40 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (245, N'Material239', CAST(47.24 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (246, N'Material240', CAST(39.86 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (247, N'Material241', CAST(13.13 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (248, N'Material242', CAST(10.33 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (249, N'Material243', CAST(39.96 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (250, N'Material244', CAST(19.30 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (251, N'Material245', CAST(47.17 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (252, N'Material246', CAST(46.60 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (253, N'Material247', CAST(23.26 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (254, N'Material248', CAST(44.54 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (255, N'Material249', CAST(37.85 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (256, N'Material250', CAST(19.47 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (257, N'Material251', CAST(40.05 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (258, N'Material252', CAST(29.53 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (259, N'Material253', CAST(14.75 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (260, N'Material254', CAST(14.20 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (261, N'Material255', CAST(40.05 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (262, N'Material256', CAST(49.10 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (263, N'Material257', CAST(44.30 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (264, N'Material258', CAST(48.19 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (265, N'Material259', CAST(26.73 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (266, N'Material260', CAST(30.97 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (267, N'Material261', CAST(43.52 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (268, N'Material262', CAST(12.51 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (269, N'Material263', CAST(29.32 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (270, N'Material264', CAST(31.29 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (271, N'Material265', CAST(21.40 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (272, N'Material266', CAST(31.65 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (273, N'Material267', CAST(41.16 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (274, N'Material268', CAST(20.18 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (275, N'Material269', CAST(47.01 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (276, N'Material270', CAST(13.73 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (277, N'Material271', CAST(23.31 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (278, N'Material272', CAST(30.35 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (279, N'Material273', CAST(22.00 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (280, N'Material274', CAST(47.37 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (281, N'Material275', CAST(48.83 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (282, N'Material276', CAST(18.57 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (283, N'Material277', CAST(44.07 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (284, N'Material278', CAST(10.79 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (285, N'Material279', CAST(31.30 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (286, N'Material280', CAST(48.36 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (287, N'Material281', CAST(41.77 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (288, N'Material282', CAST(42.60 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (289, N'Material283', CAST(24.55 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (290, N'Material284', CAST(24.39 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (291, N'Material285', CAST(40.05 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (292, N'Material286', CAST(18.70 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (293, N'Material287', CAST(48.91 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (294, N'Material288', CAST(42.88 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (295, N'Material289', CAST(35.49 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (296, N'Material290', CAST(20.13 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (297, N'Material291', CAST(38.92 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (298, N'Material292', CAST(26.42 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (299, N'Material293', CAST(29.35 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (300, N'Material294', CAST(46.33 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (301, N'Material295', CAST(11.51 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (302, N'Material296', CAST(49.52 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (303, N'Material297', CAST(49.35 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (304, N'Material298', CAST(24.46 AS Decimal(18, 2)))
INSERT [dbo].[Material] ([id_material], [nombre], [precio_alquiler]) VALUES (305, N'Material299', CAST(44.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[Material] OFF
SET IDENTITY_INSERT [dbo].[Personal] ON 

INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (1, N'Oscar Rojas ', 8123454, N'Ventas', CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (2, N'Rodrigo Lara', 8569345, N'ventas', CAST(1300.00 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (5, N'Jose Luis', 8123454, N'Despacho', CAST(1300.00 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (6, N'VICTOR MANUEL ', 12345654, N'publicidad', CAST(3000.00 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (7, N'SOFIA NOGUEIRA', 43674356, N'marketing', CAST(2500.00 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (8, N'MARIA JOSE LAINEZ', 87636542, N'tecnologia', CAST(4000.00 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (9, N'FRANCISCA NOVILLO', 87646345, N'Recursos humanos', CAST(2000.00 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (10, N'FELIPE PONCE', 76673537, N'Tecnologia', CAST(3000.00 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (11, N'IVAN CARNERO', 54796432, N'publicidad', CAST(2500.00 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (12, N'TERESA TRIGO', 83727383, N'Marketing', CAST(1500.00 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (14, N'Isidoro', 84820655, N'limpieza', CAST(1103.23 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (15, N'Walter', 80568688, N'seguridad', CAST(954.13 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (16, N'Gabriel', 36954123, N'limpieza', CAST(1155.97 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (17, N'David', 46108018, N'cocina', CAST(1172.65 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (18, N'Constantino', 62535191, N'seguridad', CAST(924.18 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (19, N'Silvestre', 33184176, N'caja', CAST(887.41 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (20, N'Virgilio', 47498124, N'limpieza', CAST(1146.87 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (21, N'Aarón', 67780770, N'seguridad', CAST(1481.24 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (22, N'Jose', 91816905, N'seguridad', CAST(1465.08 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (23, N'Ángel', 42756238, N'seguridad', CAST(904.42 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (24, N'Manuel', 19454062, N'cocina', CAST(1451.02 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (25, N'Cayetano', 84926671, N'mesero', CAST(856.63 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (26, N'Camilo', 19344079, N'caja', CAST(1187.16 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (27, N'Carlos', 90977057, N'limpieza', CAST(1036.24 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (28, N'Jose', 71654421, N'mesero', CAST(1341.92 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (29, N'Manuel', 23599924, N'bartender', CAST(1291.93 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (30, N'Claudio', 15525231, N'cocina', CAST(1026.10 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (31, N'Wen', 42965298, N'bartender', CAST(1298.74 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (32, N'Izan', 26189229, N'cocina', CAST(926.57 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (33, N'Amado', 67973383, N'almacenaje', CAST(1108.63 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (34, N'Máximo', 38544625, N'caja', CAST(1044.65 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (35, N'Manuel', 71988685, N'caja', CAST(1466.32 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (36, N'Macario', 37691541, N'limpieza', CAST(1271.05 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (37, N'Mauricio', 99174472, N'bartender', CAST(875.26 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (38, N'Crispín', 53506448, N'seguridad', CAST(895.82 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (39, N'Abraham', 83845739, N'bartender', CAST(1275.02 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (40, N'Raúl', 52866422, N'limpieza', CAST(1302.79 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (41, N'Jose', 89847984, N'mesero', CAST(1053.98 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (42, N'Juan', 11505379, N'seguridad', CAST(1321.36 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (43, N'Eugenio', 30403433, N'bartender', CAST(1264.64 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (44, N'Félix', 82187328, N'mesero', CAST(957.50 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (45, N'Andrés', 64561989, N'caja', CAST(1027.18 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (46, N'Sebastián', 84333021, N'mesero', CAST(1023.37 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (47, N'Pedro', 18447445, N'limpieza', CAST(1271.97 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (48, N'Brahim', 68981850, N'caja', CAST(1084.88 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (49, N'Carlos', 16884580, N'limpieza', CAST(1048.49 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (50, N'Edmundo', 66081494, N'bartender', CAST(1093.20 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (51, N'Ismael', 89454841, N'caja', CAST(992.36 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (52, N'Jose', 47341797, N'caja', CAST(1153.37 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (53, N'Emilio', 77026971, N'almacenaje', CAST(1444.35 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (54, N'José', 11848822, N'almacenaje', CAST(1361.99 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (55, N'Óscar', 63818555, N'almacenaje', CAST(1242.29 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (56, N'Manuel', 68961479, N'cocina', CAST(1079.75 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (57, N'Antonio', 51861510, N'almacenaje', CAST(1009.53 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (58, N'Guillermo', 64695254, N'limpieza', CAST(1265.30 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (59, N'Germán', 32460130, N'seguridad', CAST(1299.99 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (60, N'Adrià', 22809387, N'limpieza', CAST(1457.78 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (61, N'Lucas', 89549351, N'mesero', CAST(1409.75 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (62, N'Santiago', 69637845, N'caja', CAST(1278.42 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (63, N'Alonso', 73803914, N'cocina', CAST(1080.30 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (64, N'Cayetano', 78347781, N'bartender', CAST(1092.54 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (65, N'Nathan', 76722563, N'seguridad', CAST(892.26 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (66, N'Aimar', 24325797, N'caja', CAST(960.04 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (67, N'Ander', 15389960, N'seguridad', CAST(934.49 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (68, N'Christian', 94248379, N'almacenaje', CAST(1114.59 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (69, N'Ander', 37774439, N'caja', CAST(1144.57 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (70, N'Virgilio', 86815800, N'bartender', CAST(1167.02 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (71, N'Asier', 91791443, N'seguridad', CAST(891.77 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (72, N'Antonio', 80985801, N'limpieza', CAST(856.00 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (73, N'Javier', 99879688, N'caja', CAST(1364.60 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (74, N'Simón', 35610122, N'caja', CAST(1272.49 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (75, N'César', 97281315, N'cocina', CAST(1322.77 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (76, N'Francisco', 59492892, N'limpieza', CAST(1455.26 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (77, N'Mauricio', 29704894, N'limpieza', CAST(851.42 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (78, N'Joaquín', 71329414, N'almacenaje', CAST(1236.84 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (79, N'Zoilo', 87373820, N'cocina', CAST(1100.09 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (80, N'Basilio', 57077434, N'caja', CAST(1044.15 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (81, N'Víctor', 59022277, N'almacenaje', CAST(1330.23 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (82, N'Wen', 53182221, N'bartender', CAST(1124.11 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (83, N'Conrado', 69504769, N'mesero', CAST(1380.82 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (84, N'Nicolás', 39262840, N'cocina', CAST(910.64 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (85, N'Mariano', 89430526, N'bartender', CAST(978.90 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (86, N'Cristian', 88864240, N'almacenaje', CAST(1153.16 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (87, N'Macario', 44391264, N'caja', CAST(1199.11 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (88, N'Rogelio', 73081095, N'mesero', CAST(1240.72 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (89, N'Brais', 11705901, N'limpieza', CAST(1232.28 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (90, N'Leopoldo', 57278493, N'caja', CAST(1390.14 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (91, N'Carlos', 51088987, N'seguridad', CAST(1164.62 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (92, N'Ulises', 37333858, N'almacenaje', CAST(1103.25 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (93, N'Javier', 80880417, N'almacenaje', CAST(1189.51 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (94, N'Zoilo', 24083781, N'almacenaje', CAST(1365.62 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (95, N'Federico', 36907509, N'cocina', CAST(1216.76 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (96, N'Moisés', 18900001, N'seguridad', CAST(1273.42 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (97, N'Mohamed', 87666945, N'caja', CAST(976.26 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (98, N'Jon', 35368884, N'limpieza', CAST(1263.65 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (99, N'Javier', 67954949, N'bartender', CAST(1321.65 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (100, N'Felipe', 84039074, N'cocina', CAST(1099.77 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (101, N'Abraham', 11620946, N'mesero', CAST(1136.16 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (102, N'Mariano', 35513339, N'seguridad', CAST(1027.61 AS Decimal(18, 2)))
GO
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (103, N'Jose', 30063277, N'limpieza', CAST(973.75 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (104, N'Zenon', 69351859, N'cocina', CAST(1065.53 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (105, N'Juan', 87386059, N'mesero', CAST(1237.82 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (106, N'Conrado', 36031771, N'cocina', CAST(1036.17 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (107, N'Jorge', 71900164, N'seguridad', CAST(1115.66 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (108, N'José', 68594716, N'caja', CAST(860.07 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (109, N'Juan', 11266517, N'seguridad', CAST(1200.13 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (110, N'Justo', 96401250, N'seguridad', CAST(1010.95 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (111, N'César', 95629109, N'seguridad', CAST(1110.86 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (112, N'Ramiro', 20034380, N'almacenaje', CAST(885.38 AS Decimal(18, 2)))
INSERT [dbo].[Personal] ([id_personal], [nombre], [DNI], [cargo], [sueldo]) VALUES (113, N'Javier', 37045039, N'bartender', CAST(904.33 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Personal] OFF
SET IDENTITY_INSERT [dbo].[Servicio] ON 

INSERT [dbo].[Servicio] ([id_servicio], [nombre], [precio_alquiler]) VALUES (1, N'Servicio1', CAST(20.00 AS Decimal(18, 2)))
INSERT [dbo].[Servicio] ([id_servicio], [nombre], [precio_alquiler]) VALUES (2, N'Servicio2', CAST(200.00 AS Decimal(18, 2)))
INSERT [dbo].[Servicio] ([id_servicio], [nombre], [precio_alquiler]) VALUES (3, N'Servicio3', CAST(400.00 AS Decimal(18, 2)))
INSERT [dbo].[Servicio] ([id_servicio], [nombre], [precio_alquiler]) VALUES (4, N'Servicio4', CAST(150.00 AS Decimal(18, 2)))
INSERT [dbo].[Servicio] ([id_servicio], [nombre], [precio_alquiler]) VALUES (5, N'servicio5', CAST(300.00 AS Decimal(18, 2)))
INSERT [dbo].[Servicio] ([id_servicio], [nombre], [precio_alquiler]) VALUES (6, N'servicio6', CAST(150.00 AS Decimal(18, 2)))
INSERT [dbo].[Servicio] ([id_servicio], [nombre], [precio_alquiler]) VALUES (7, N'servicio7', CAST(300.00 AS Decimal(18, 2)))
INSERT [dbo].[Servicio] ([id_servicio], [nombre], [precio_alquiler]) VALUES (8, N'servicio8', CAST(150.00 AS Decimal(18, 2)))
INSERT [dbo].[Servicio] ([id_servicio], [nombre], [precio_alquiler]) VALUES (9, N'servicio9', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[Servicio] ([id_servicio], [nombre], [precio_alquiler]) VALUES (10, N'servicio10', CAST(750.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Servicio] OFF
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Cliente]
GO
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Local] FOREIGN KEY([id_local])
REFERENCES [dbo].[Local] ([id_local])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Local]
GO
ALTER TABLE [dbo].[Evento_Actividad]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Actividad_Actividad] FOREIGN KEY([id_actividad])
REFERENCES [dbo].[Actividad] ([id_actividad])
GO
ALTER TABLE [dbo].[Evento_Actividad] CHECK CONSTRAINT [FK_Evento_Actividad_Actividad]
GO
ALTER TABLE [dbo].[Evento_Actividad]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Actividad_Evento] FOREIGN KEY([id_evento])
REFERENCES [dbo].[Evento] ([id_evento])
GO
ALTER TABLE [dbo].[Evento_Actividad] CHECK CONSTRAINT [FK_Evento_Actividad_Evento]
GO
ALTER TABLE [dbo].[Evento_Equipo]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Equipo_Equipo] FOREIGN KEY([id_equipo])
REFERENCES [dbo].[Equipo] ([id_equipo])
GO
ALTER TABLE [dbo].[Evento_Equipo] CHECK CONSTRAINT [FK_Evento_Equipo_Equipo]
GO
ALTER TABLE [dbo].[Evento_Equipo]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Equipo_Evento] FOREIGN KEY([id_evento])
REFERENCES [dbo].[Evento] ([id_evento])
GO
ALTER TABLE [dbo].[Evento_Equipo] CHECK CONSTRAINT [FK_Evento_Equipo_Evento]
GO
ALTER TABLE [dbo].[Evento_Material]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Material_Evento] FOREIGN KEY([id_evento])
REFERENCES [dbo].[Evento] ([id_evento])
GO
ALTER TABLE [dbo].[Evento_Material] CHECK CONSTRAINT [FK_Evento_Material_Evento]
GO
ALTER TABLE [dbo].[Evento_Material]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Material_Material] FOREIGN KEY([id_material])
REFERENCES [dbo].[Material] ([id_material])
GO
ALTER TABLE [dbo].[Evento_Material] CHECK CONSTRAINT [FK_Evento_Material_Material]
GO
ALTER TABLE [dbo].[Evento_Personal]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Personal_Evento] FOREIGN KEY([id_evento])
REFERENCES [dbo].[Evento] ([id_evento])
GO
ALTER TABLE [dbo].[Evento_Personal] CHECK CONSTRAINT [FK_Evento_Personal_Evento]
GO
ALTER TABLE [dbo].[Evento_Personal]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Personal_Personal] FOREIGN KEY([id_personal])
REFERENCES [dbo].[Personal] ([id_personal])
GO
ALTER TABLE [dbo].[Evento_Personal] CHECK CONSTRAINT [FK_Evento_Personal_Personal]
GO
ALTER TABLE [dbo].[Evento_Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Servicio_Evento] FOREIGN KEY([id_evento])
REFERENCES [dbo].[Evento] ([id_evento])
GO
ALTER TABLE [dbo].[Evento_Servicio] CHECK CONSTRAINT [FK_Evento_Servicio_Evento]
GO
ALTER TABLE [dbo].[Evento_Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Servicio_Servicio] FOREIGN KEY([id_servicio])
REFERENCES [dbo].[Servicio] ([id_servicio])
GO
ALTER TABLE [dbo].[Evento_Servicio] CHECK CONSTRAINT [FK_Evento_Servicio_Servicio]
GO
USE [master]
GO
ALTER DATABASE [Eventos_TP] SET  READ_WRITE 
GO
