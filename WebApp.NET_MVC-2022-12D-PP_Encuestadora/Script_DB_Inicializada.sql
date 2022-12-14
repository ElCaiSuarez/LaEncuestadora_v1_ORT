USE [master]
GO
/****** Object:  Database [encuestadoraDB]    Script Date: 05/07/2022 12:26:31 ******/
CREATE DATABASE [encuestadoraDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'encuestadoraDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\encuestadoraDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'encuestadoraDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\encuestadoraDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [encuestadoraDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [encuestadoraDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [encuestadoraDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [encuestadoraDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [encuestadoraDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [encuestadoraDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [encuestadoraDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [encuestadoraDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [encuestadoraDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [encuestadoraDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [encuestadoraDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [encuestadoraDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [encuestadoraDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [encuestadoraDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [encuestadoraDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [encuestadoraDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [encuestadoraDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [encuestadoraDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [encuestadoraDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [encuestadoraDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [encuestadoraDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [encuestadoraDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [encuestadoraDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [encuestadoraDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [encuestadoraDB] SET RECOVERY FULL 
GO
ALTER DATABASE [encuestadoraDB] SET  MULTI_USER 
GO
ALTER DATABASE [encuestadoraDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [encuestadoraDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [encuestadoraDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [encuestadoraDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [encuestadoraDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [encuestadoraDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'encuestadoraDB', N'ON'
GO
ALTER DATABASE [encuestadoraDB] SET QUERY_STORE = OFF
GO
USE [encuestadoraDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 05/07/2022 12:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 05/07/2022 12:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[nombreCliente] [nvarchar](80) NOT NULL,
	[mailCliente] [nvarchar](40) NOT NULL,
	[passwordCliente] [nvarchar](10) NOT NULL,
	[empresaCliente] [nvarchar](40) NULL,
	[cuitCliente] [nvarchar](11) NULL,
	[domicilioCliente] [nvarchar](40) NULL,
	[precioCliente] [int] NOT NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[encuestas]    Script Date: 05/07/2022 12:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[encuestas](
	[EncuestaId] [int] IDENTITY(1,1) NOT NULL,
	[tituloEncuesta] [nvarchar](40) NOT NULL,
	[datetimeCreacionEncuesta] [datetime2](7) NOT NULL,
	[datetimeVencimientoEncuesta] [datetime2](7) NOT NULL,
	[puntosEncuesta] [int] NOT NULL,
	[ClienteId] [int] NOT NULL,
 CONSTRAINT [PK_encuestas] PRIMARY KEY CLUSTERED 
(
	[EncuestaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[encuestasRespondidas]    Script Date: 05/07/2022 12:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[encuestasRespondidas](
	[EncuestaRespondidaId] [int] IDENTITY(1,1) NOT NULL,
	[datetimeRespuestaEncuesta] [datetime2](7) NOT NULL,
	[EncuestaId] [int] NOT NULL,
	[PreguntaId] [int] NULL,
	[OpcionPreguntaId] [int] NULL,
	[UsuarioId] [int] NOT NULL,
 CONSTRAINT [PK_encuestasRespondidas] PRIMARY KEY CLUSTERED 
(
	[EncuestaRespondidaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[opciones]    Script Date: 05/07/2022 12:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[opciones](
	[OpcionPreguntaId] [int] IDENTITY(1,1) NOT NULL,
	[tituloOpcion] [nvarchar](40) NOT NULL,
	[opcionSeleccionada] [bit] NOT NULL,
	[PreguntaId] [int] NOT NULL,
 CONSTRAINT [PK_opciones] PRIMARY KEY CLUSTERED 
(
	[OpcionPreguntaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[preguntas]    Script Date: 05/07/2022 12:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[preguntas](
	[PreguntaId] [int] IDENTITY(1,1) NOT NULL,
	[tituloPregunta] [nvarchar](40) NOT NULL,
	[tipoPregunta] [int] NOT NULL,
	[EncuestaId] [int] NOT NULL,
 CONSTRAINT [PK_preguntas] PRIMARY KEY CLUSTERED 
(
	[PreguntaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 05/07/2022 12:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[nombreUsuario] [nvarchar](80) NOT NULL,
	[mailUsuario] [nvarchar](40) NOT NULL,
	[passwordUsuario] [nvarchar](10) NOT NULL,
	[dniUsuario] [nvarchar](8) NOT NULL,
	[datetimeFechaNacimiento] [datetime2](7) NOT NULL,
	[domicilioUsuario] [nvarchar](40) NULL,
	[puntosAcumulados] [int] NOT NULL,
	[preferenciaUsuario] [int] NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220624191856_generarBaseDeDatos', N'3.1.25')
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 

INSERT [dbo].[clientes] ([ClienteId], [nombreCliente], [mailCliente], [passwordCliente], [empresaCliente], [cuitCliente], [domicilioCliente], [precioCliente]) VALUES (1, N'Cliente 1', N'cliente1@dominio.com', N'password1', N'Empresa Cliente 1', N'20-22333444', N'Av. Rivadavia 5500', 0)
INSERT [dbo].[clientes] ([ClienteId], [nombreCliente], [mailCliente], [passwordCliente], [empresaCliente], [cuitCliente], [domicilioCliente], [precioCliente]) VALUES (2, N'Cliente 2', N'cliente2@dominio.com', N'password2', N'Empresa Cliente 2', N'21-33444555', N'Av. Santa Fe 3300', 5000)
INSERT [dbo].[clientes] ([ClienteId], [nombreCliente], [mailCliente], [passwordCliente], [empresaCliente], [cuitCliente], [domicilioCliente], [precioCliente]) VALUES (3, N'Cliente 3', N'cliente3@dominio.com', N'password3', N'Empresa Cliente 3', N'22-44555666', N'Av. Libertador 4400', 10000)
SET IDENTITY_INSERT [dbo].[clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[encuestas] ON 

INSERT [dbo].[encuestas] ([EncuestaId], [tituloEncuesta], [datetimeCreacionEncuesta], [datetimeVencimientoEncuesta], [puntosEncuesta], [ClienteId]) VALUES (22, N'Encuesta Vencida', CAST(N'2022-06-27T15:36:37.0000000' AS DateTime2), CAST(N'2022-07-04T15:36:37.0000000' AS DateTime2), 100, 1)
INSERT [dbo].[encuestas] ([EncuestaId], [tituloEncuesta], [datetimeCreacionEncuesta], [datetimeVencimientoEncuesta], [puntosEncuesta], [ClienteId]) VALUES (23, N'Encuesta 2', CAST(N'2022-07-01T15:38:39.0000000' AS DateTime2), CAST(N'2022-07-16T15:38:39.0000000' AS DateTime2), 250, 2)
INSERT [dbo].[encuestas] ([EncuestaId], [tituloEncuesta], [datetimeCreacionEncuesta], [datetimeVencimientoEncuesta], [puntosEncuesta], [ClienteId]) VALUES (24, N'Encuesta 3', CAST(N'2022-07-05T11:06:45.0000000' AS DateTime2), CAST(N'2022-07-26T11:06:45.0000000' AS DateTime2), 500, 3)
INSERT [dbo].[encuestas] ([EncuestaId], [tituloEncuesta], [datetimeCreacionEncuesta], [datetimeVencimientoEncuesta], [puntosEncuesta], [ClienteId]) VALUES (25, N'Encuesta 1', CAST(N'2022-07-05T11:10:30.0000000' AS DateTime2), CAST(N'2022-07-12T11:10:30.0000000' AS DateTime2), 100, 1)
SET IDENTITY_INSERT [dbo].[encuestas] OFF
GO
SET IDENTITY_INSERT [dbo].[encuestasRespondidas] ON 

INSERT [dbo].[encuestasRespondidas] ([EncuestaRespondidaId], [datetimeRespuestaEncuesta], [EncuestaId], [PreguntaId], [OpcionPreguntaId], [UsuarioId]) VALUES (20, CAST(N'2022-07-05T11:35:28.0000000' AS DateTime2), 22, 28, 33, 1)
INSERT [dbo].[encuestasRespondidas] ([EncuestaRespondidaId], [datetimeRespuestaEncuesta], [EncuestaId], [PreguntaId], [OpcionPreguntaId], [UsuarioId]) VALUES (21, CAST(N'2022-07-05T11:35:36.0000000' AS DateTime2), 22, 29, 34, 1)
INSERT [dbo].[encuestasRespondidas] ([EncuestaRespondidaId], [datetimeRespuestaEncuesta], [EncuestaId], [PreguntaId], [OpcionPreguntaId], [UsuarioId]) VALUES (22, CAST(N'2022-07-05T11:36:12.0000000' AS DateTime2), 22, 28, 32, 2)
INSERT [dbo].[encuestasRespondidas] ([EncuestaRespondidaId], [datetimeRespuestaEncuesta], [EncuestaId], [PreguntaId], [OpcionPreguntaId], [UsuarioId]) VALUES (23, CAST(N'2022-07-05T11:36:16.0000000' AS DateTime2), 22, 29, 35, 2)
SET IDENTITY_INSERT [dbo].[encuestasRespondidas] OFF
GO
SET IDENTITY_INSERT [dbo].[opciones] ON 

INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (20, N'Encuesta 2 Pregunta 1 Opcion 1', 0, 22)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (21, N'Encuesta 2 Pregunta 1 Opcion 2', 0, 22)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (22, N'Encuesta 2 Pregunta 2 Opcion 1', 0, 23)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (23, N'Encuesta 2 Pregunta 3 Opcion 1', 0, 24)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (24, N'Encuesta 2 Pregunta 3 Opcion 2', 0, 24)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (25, N'Encuesta 2 Pregunta 2 Opcion 2', 0, 23)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (26, N'Encuesta 3 Pregunta 1 Opcion 1', 0, 25)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (27, N'Encuesta 3 Pregunta 1 Opcion 2', 0, 25)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (28, N'Encuesta 3 Pregunta 2 Opcion 1', 0, 26)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (29, N'Encuesta 3 Pregunta 2 Opcion 2', 0, 26)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (30, N'Encuesta 3 Pregunta 3 Opcion 1', 0, 27)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (31, N'Encuesta 3 Pregunta 3 Opcion 2', 0, 27)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (32, N'Encuesta Vencida Pregunta 1 Opcion 1', 0, 28)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (33, N'Encuesta Vencida Pregunta 1 Opcion 2', 0, 28)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (34, N'Encuesta Vencida Pregunta 2 Opcion 1', 0, 29)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (35, N'Encuesta Vencida Pregunta 2 Opcion 2', 0, 29)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (36, N'Encuesta 1 Pregunta 1 Opcion 1', 0, 30)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (37, N'Encuesta 1 Pregunta 1 Opcion 2', 0, 30)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (38, N'Encuesta 1 Pregunta 2 Opcion 1', 0, 31)
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (39, N'Encuesta 1 Pregunta 2 Opcion 2', 0, 31)
SET IDENTITY_INSERT [dbo].[opciones] OFF
GO
SET IDENTITY_INSERT [dbo].[preguntas] ON 

INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (22, N'Encuesta 2 Pregunta 1', 0, 23)
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (23, N'Encuesta 2 Pregunta 2', 0, 23)
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (24, N'Encuesta 2 Pregunta 3', 0, 23)
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (25, N'Encuesta 3 Pregunta 1', 0, 24)
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (26, N'Encuesta 3 Pregunta 2', 0, 24)
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (27, N'Encuesta 3 Pregunta 3', 0, 24)
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (28, N'Encuesta Vencida Pregunta 1 ', 0, 22)
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (29, N'Encuesta Vencida Pregunta 2', 0, 22)
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (30, N'Encuesta 1 Pregunta 1 ', 0, 25)
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (31, N'Encuesta 1 Pregunta 2', 0, 25)
SET IDENTITY_INSERT [dbo].[preguntas] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([UsuarioId], [nombreUsuario], [mailUsuario], [passwordUsuario], [dniUsuario], [datetimeFechaNacimiento], [domicilioUsuario], [puntosAcumulados], [preferenciaUsuario]) VALUES (1, N'Usuario 1', N'usuario1@dominio.com', N'password1', N'22333444', CAST(N'2022-06-16T00:00:00.0000000' AS DateTime2), N'Callao 2200', 100, 1)
INSERT [dbo].[usuarios] ([UsuarioId], [nombreUsuario], [mailUsuario], [passwordUsuario], [dniUsuario], [datetimeFechaNacimiento], [domicilioUsuario], [puntosAcumulados], [preferenciaUsuario]) VALUES (2, N'Usuario 2', N'usuario2@dominio.com', N'password2', N'33444555', CAST(N'2022-06-06T00:00:00.0000000' AS DateTime2), N'Tucuman 1100', 100, 2)
INSERT [dbo].[usuarios] ([UsuarioId], [nombreUsuario], [mailUsuario], [passwordUsuario], [dniUsuario], [datetimeFechaNacimiento], [domicilioUsuario], [puntosAcumulados], [preferenciaUsuario]) VALUES (3, N'Usuario 3', N'usuario3@dominio.com', N'password3', N'44555666', CAST(N'2022-06-04T00:00:00.0000000' AS DateTime2), N'Esmeralda 6600', 0, 3)
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
/****** Object:  Index [IX_encuestas_ClienteId]    Script Date: 05/07/2022 12:26:31 ******/
CREATE NONCLUSTERED INDEX [IX_encuestas_ClienteId] ON [dbo].[encuestas]
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_encuestasRespondidas_EncuestaId]    Script Date: 05/07/2022 12:26:31 ******/
CREATE NONCLUSTERED INDEX [IX_encuestasRespondidas_EncuestaId] ON [dbo].[encuestasRespondidas]
(
	[EncuestaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_encuestasRespondidas_OpcionPreguntaId]    Script Date: 05/07/2022 12:26:31 ******/
CREATE NONCLUSTERED INDEX [IX_encuestasRespondidas_OpcionPreguntaId] ON [dbo].[encuestasRespondidas]
(
	[OpcionPreguntaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_encuestasRespondidas_PreguntaId]    Script Date: 05/07/2022 12:26:31 ******/
CREATE NONCLUSTERED INDEX [IX_encuestasRespondidas_PreguntaId] ON [dbo].[encuestasRespondidas]
(
	[PreguntaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_encuestasRespondidas_UsuarioId]    Script Date: 05/07/2022 12:26:31 ******/
CREATE NONCLUSTERED INDEX [IX_encuestasRespondidas_UsuarioId] ON [dbo].[encuestasRespondidas]
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_opciones_PreguntaId]    Script Date: 05/07/2022 12:26:31 ******/
CREATE NONCLUSTERED INDEX [IX_opciones_PreguntaId] ON [dbo].[opciones]
(
	[PreguntaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_preguntas_EncuestaId]    Script Date: 05/07/2022 12:26:31 ******/
CREATE NONCLUSTERED INDEX [IX_preguntas_EncuestaId] ON [dbo].[preguntas]
(
	[EncuestaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[encuestas]  WITH CHECK ADD  CONSTRAINT [FK_encuestas_clientes_ClienteId] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[clientes] ([ClienteId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[encuestas] CHECK CONSTRAINT [FK_encuestas_clientes_ClienteId]
GO
ALTER TABLE [dbo].[encuestasRespondidas]  WITH CHECK ADD  CONSTRAINT [FK_encuestasRespondidas_encuestas_EncuestaId] FOREIGN KEY([EncuestaId])
REFERENCES [dbo].[encuestas] ([EncuestaId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[encuestasRespondidas] CHECK CONSTRAINT [FK_encuestasRespondidas_encuestas_EncuestaId]
GO
ALTER TABLE [dbo].[encuestasRespondidas]  WITH CHECK ADD  CONSTRAINT [FK_encuestasRespondidas_opciones_OpcionPreguntaId] FOREIGN KEY([OpcionPreguntaId])
REFERENCES [dbo].[opciones] ([OpcionPreguntaId])
GO
ALTER TABLE [dbo].[encuestasRespondidas] CHECK CONSTRAINT [FK_encuestasRespondidas_opciones_OpcionPreguntaId]
GO
ALTER TABLE [dbo].[encuestasRespondidas]  WITH CHECK ADD  CONSTRAINT [FK_encuestasRespondidas_preguntas_PreguntaId] FOREIGN KEY([PreguntaId])
REFERENCES [dbo].[preguntas] ([PreguntaId])
GO
ALTER TABLE [dbo].[encuestasRespondidas] CHECK CONSTRAINT [FK_encuestasRespondidas_preguntas_PreguntaId]
GO
ALTER TABLE [dbo].[encuestasRespondidas]  WITH CHECK ADD  CONSTRAINT [FK_encuestasRespondidas_usuarios_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[usuarios] ([UsuarioId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[encuestasRespondidas] CHECK CONSTRAINT [FK_encuestasRespondidas_usuarios_UsuarioId]
GO
ALTER TABLE [dbo].[opciones]  WITH CHECK ADD  CONSTRAINT [FK_opciones_preguntas_PreguntaId] FOREIGN KEY([PreguntaId])
REFERENCES [dbo].[preguntas] ([PreguntaId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[opciones] CHECK CONSTRAINT [FK_opciones_preguntas_PreguntaId]
GO
ALTER TABLE [dbo].[preguntas]  WITH CHECK ADD  CONSTRAINT [FK_preguntas_encuestas_EncuestaId] FOREIGN KEY([EncuestaId])
REFERENCES [dbo].[encuestas] ([EncuestaId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[preguntas] CHECK CONSTRAINT [FK_preguntas_encuestas_EncuestaId]
GO
USE [master]
GO
ALTER DATABASE [encuestadoraDB] SET  READ_WRITE 
GO
