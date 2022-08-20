USE [encuestadoraDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 07/07/2022 10:07:42 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 07/07/2022 10:07:42 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[encuestas]    Script Date: 07/07/2022 10:07:42 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[encuestasRespondidas]    Script Date: 07/07/2022 10:07:42 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[opciones]    Script Date: 07/07/2022 10:07:42 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[preguntas]    Script Date: 07/07/2022 10:07:42 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 07/07/2022 10:07:42 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220624191856_generarBaseDeDatos', N'3.1.25')
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 
GO
INSERT [dbo].[clientes] ([ClienteId], [nombreCliente], [mailCliente], [passwordCliente], [empresaCliente], [cuitCliente], [domicilioCliente], [precioCliente]) VALUES (1, N'Cliente 1', N'cliente1@dominio.com', N'password1', N'Empresa Cliente 1', N'20-22333444', N'Av. Rivadavia 5500', 0)
GO
INSERT [dbo].[clientes] ([ClienteId], [nombreCliente], [mailCliente], [passwordCliente], [empresaCliente], [cuitCliente], [domicilioCliente], [precioCliente]) VALUES (2, N'Cliente 2', N'cliente2@dominio.com', N'password2', N'Empresa Cliente 2', N'21-33444555', N'Av. Santa Fe 3300', 5000)
GO
INSERT [dbo].[clientes] ([ClienteId], [nombreCliente], [mailCliente], [passwordCliente], [empresaCliente], [cuitCliente], [domicilioCliente], [precioCliente]) VALUES (3, N'Cliente 3', N'cliente3@dominio.com', N'password3', N'Empresa Cliente 3', N'22-44555666', N'Av. Libertador 4400', 10000)
GO
SET IDENTITY_INSERT [dbo].[clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[encuestas] ON 
GO
INSERT [dbo].[encuestas] ([EncuestaId], [tituloEncuesta], [datetimeCreacionEncuesta], [datetimeVencimientoEncuesta], [puntosEncuesta], [ClienteId]) VALUES (22, N'Encuesta Vencida', CAST(N'2022-06-27T15:36:37.0000000' AS DateTime2), CAST(N'2022-07-04T15:36:37.0000000' AS DateTime2), 100, 1)
GO
INSERT [dbo].[encuestas] ([EncuestaId], [tituloEncuesta], [datetimeCreacionEncuesta], [datetimeVencimientoEncuesta], [puntosEncuesta], [ClienteId]) VALUES (23, N'Encuesta 2', CAST(N'2022-07-01T15:38:39.0000000' AS DateTime2), CAST(N'2022-07-16T15:38:39.0000000' AS DateTime2), 250, 2)
GO
INSERT [dbo].[encuestas] ([EncuestaId], [tituloEncuesta], [datetimeCreacionEncuesta], [datetimeVencimientoEncuesta], [puntosEncuesta], [ClienteId]) VALUES (24, N'Encuesta 3', CAST(N'2022-07-05T11:06:45.0000000' AS DateTime2), CAST(N'2022-07-26T11:06:45.0000000' AS DateTime2), 500, 3)
GO
INSERT [dbo].[encuestas] ([EncuestaId], [tituloEncuesta], [datetimeCreacionEncuesta], [datetimeVencimientoEncuesta], [puntosEncuesta], [ClienteId]) VALUES (25, N'Encuesta 1', CAST(N'2022-07-05T11:10:30.0000000' AS DateTime2), CAST(N'2022-07-12T11:10:30.0000000' AS DateTime2), 100, 1)
GO
SET IDENTITY_INSERT [dbo].[encuestas] OFF
GO
SET IDENTITY_INSERT [dbo].[encuestasRespondidas] ON 
GO
INSERT [dbo].[encuestasRespondidas] ([EncuestaRespondidaId], [datetimeRespuestaEncuesta], [EncuestaId], [PreguntaId], [OpcionPreguntaId], [UsuarioId]) VALUES (20, CAST(N'2022-07-05T11:35:28.0000000' AS DateTime2), 22, 28, 33, 1)
GO
INSERT [dbo].[encuestasRespondidas] ([EncuestaRespondidaId], [datetimeRespuestaEncuesta], [EncuestaId], [PreguntaId], [OpcionPreguntaId], [UsuarioId]) VALUES (21, CAST(N'2022-07-05T11:35:36.0000000' AS DateTime2), 22, 29, 34, 1)
GO
INSERT [dbo].[encuestasRespondidas] ([EncuestaRespondidaId], [datetimeRespuestaEncuesta], [EncuestaId], [PreguntaId], [OpcionPreguntaId], [UsuarioId]) VALUES (22, CAST(N'2022-07-05T11:36:12.0000000' AS DateTime2), 22, 28, 32, 2)
GO
INSERT [dbo].[encuestasRespondidas] ([EncuestaRespondidaId], [datetimeRespuestaEncuesta], [EncuestaId], [PreguntaId], [OpcionPreguntaId], [UsuarioId]) VALUES (23, CAST(N'2022-07-05T11:36:16.0000000' AS DateTime2), 22, 29, 35, 2)
GO
SET IDENTITY_INSERT [dbo].[encuestasRespondidas] OFF
GO
SET IDENTITY_INSERT [dbo].[opciones] ON 
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (20, N'Encuesta 2 Pregunta 1 Opcion 1', 0, 22)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (21, N'Encuesta 2 Pregunta 1 Opcion 2', 0, 22)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (22, N'Encuesta 2 Pregunta 2 Opcion 1', 0, 23)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (23, N'Encuesta 2 Pregunta 3 Opcion 1', 0, 24)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (24, N'Encuesta 2 Pregunta 3 Opcion 2', 0, 24)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (25, N'Encuesta 2 Pregunta 2 Opcion 2', 0, 23)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (26, N'Encuesta 3 Pregunta 1 Opcion 1', 0, 25)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (27, N'Encuesta 3 Pregunta 1 Opcion 2', 0, 25)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (28, N'Encuesta 3 Pregunta 2 Opcion 1', 0, 26)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (29, N'Encuesta 3 Pregunta 2 Opcion 2', 0, 26)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (30, N'Encuesta 3 Pregunta 3 Opcion 1', 0, 27)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (31, N'Encuesta 3 Pregunta 3 Opcion 2', 0, 27)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (32, N'Encuesta Vencida Pregunta 1 Opcion 1', 0, 28)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (33, N'Encuesta Vencida Pregunta 1 Opcion 2', 0, 28)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (34, N'Encuesta Vencida Pregunta 2 Opcion 1', 0, 29)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (35, N'Encuesta Vencida Pregunta 2 Opcion 2', 0, 29)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (36, N'Encuesta 1 Pregunta 1 Opcion 1', 0, 30)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (37, N'Encuesta 1 Pregunta 1 Opcion 2', 0, 30)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (38, N'Encuesta 1 Pregunta 2 Opcion 1', 0, 31)
GO
INSERT [dbo].[opciones] ([OpcionPreguntaId], [tituloOpcion], [opcionSeleccionada], [PreguntaId]) VALUES (39, N'Encuesta 1 Pregunta 2 Opcion 2', 0, 31)
GO
SET IDENTITY_INSERT [dbo].[opciones] OFF
GO
SET IDENTITY_INSERT [dbo].[preguntas] ON 
GO
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (22, N'Encuesta 2 Pregunta 1', 0, 23)
GO
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (23, N'Encuesta 2 Pregunta 2', 0, 23)
GO
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (24, N'Encuesta 2 Pregunta 3', 0, 23)
GO
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (25, N'Encuesta 3 Pregunta 1', 0, 24)
GO
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (26, N'Encuesta 3 Pregunta 2', 0, 24)
GO
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (27, N'Encuesta 3 Pregunta 3', 0, 24)
GO
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (28, N'Encuesta Vencida Pregunta 1 ', 0, 22)
GO
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (29, N'Encuesta Vencida Pregunta 2', 0, 22)
GO
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (30, N'Encuesta 1 Pregunta 1 ', 0, 25)
GO
INSERT [dbo].[preguntas] ([PreguntaId], [tituloPregunta], [tipoPregunta], [EncuestaId]) VALUES (31, N'Encuesta 1 Pregunta 2', 0, 25)
GO
SET IDENTITY_INSERT [dbo].[preguntas] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 
GO
INSERT [dbo].[usuarios] ([UsuarioId], [nombreUsuario], [mailUsuario], [passwordUsuario], [dniUsuario], [datetimeFechaNacimiento], [domicilioUsuario], [puntosAcumulados], [preferenciaUsuario]) VALUES (1, N'Usuario 1', N'usuario1@dominio.com', N'password1', N'22333444', CAST(N'2022-06-16T00:00:00.0000000' AS DateTime2), N'Callao 2200', 100, 1)
GO
INSERT [dbo].[usuarios] ([UsuarioId], [nombreUsuario], [mailUsuario], [passwordUsuario], [dniUsuario], [datetimeFechaNacimiento], [domicilioUsuario], [puntosAcumulados], [preferenciaUsuario]) VALUES (2, N'Usuario 2', N'usuario2@dominio.com', N'password2', N'33444555', CAST(N'2022-06-06T00:00:00.0000000' AS DateTime2), N'Tucuman 1100', 100, 2)
GO
INSERT [dbo].[usuarios] ([UsuarioId], [nombreUsuario], [mailUsuario], [passwordUsuario], [dniUsuario], [datetimeFechaNacimiento], [domicilioUsuario], [puntosAcumulados], [preferenciaUsuario]) VALUES (3, N'Usuario 3', N'usuario3@dominio.com', N'password3', N'44555666', CAST(N'2022-06-04T00:00:00.0000000' AS DateTime2), N'Esmeralda 6600', 0, 3)
GO
SET IDENTITY_INSERT [dbo].[usuarios] OFF
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