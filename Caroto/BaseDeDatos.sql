CREATE DATABASE CAROTO
GO
USE [CAROTO]
GO
/****** Object:  Table [dbo].[Coche]    Script Date: 12/05/2022 15:46:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coche](
	[Matricula] [char](8) NOT NULL,
	[Puertas] [char](1) NOT NULL,
	[Imagen] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalles_Pedido]    Script Date: 12/05/2022 15:46:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles_Pedido](
	[Id_Pedido] [int] NOT NULL,
	[Matricula] [char](8) NOT NULL,
	[fecha_compra] [date] NULL,
	[precio] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Pedido] ASC,
	[Matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gamma]    Script Date: 12/05/2022 15:46:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gamma](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Clase] [varchar](10) NOT NULL,
	[Precio] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Moto]    Script Date: 12/05/2022 15:46:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Moto](
	[Matricula] [char](8) NOT NULL,
	[Espejos] [char](1) NOT NULL,
	[Imagen] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 12/05/2022 15:46:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Correo_Usu] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Piezas]    Script Date: 12/05/2022 15:46:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Piezas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](15) NOT NULL,
	[precio] [money] NOT NULL,
	[Imagen] [varchar](100) NULL,
	[Nombre] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Piezas_Vehiculo]    Script Date: 12/05/2022 15:46:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Piezas_Vehiculo](
	[Id_Pieza] [int] NOT NULL,
	[Matricula_Vehiculo] [char](8) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Pieza] ASC,
	[Matricula_Vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/05/2022 15:46:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Correo] [varchar](50) NOT NULL,
	[Contraseña] [varchar](16) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 12/05/2022 15:46:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[Matricula] [char](8) NOT NULL,
	[Id_Gamma] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Coche] ([Matricula], [Puertas], [Imagen]) VALUES (N'1242 JIL', N'5', N'\img\cocheMedia1.jpg')
INSERT [dbo].[Coche] ([Matricula], [Puertas], [Imagen]) VALUES (N'2018 JKR', N'5', N'\img\cocheBaja1.jpg')
INSERT [dbo].[Coche] ([Matricula], [Puertas], [Imagen]) VALUES (N'2222 AAA', N'5', N'\img\cocheAlta1.png')
INSERT [dbo].[Coche] ([Matricula], [Puertas], [Imagen]) VALUES (N'5634 ABC', N'3', N'\img\cocheBaja2.jpg')
INSERT [dbo].[Coche] ([Matricula], [Puertas], [Imagen]) VALUES (N'7632 OPG', N'3', N'\img\cocheBaja3.jpg')
INSERT [dbo].[Coche] ([Matricula], [Puertas], [Imagen]) VALUES (N'8888 FDF', N'5', N'\img\cocheAlta2.png')
INSERT [dbo].[Coche] ([Matricula], [Puertas], [Imagen]) VALUES (N'9823 ASD', N'5', N'\img\cocheMedia2.png')
GO
INSERT [dbo].[Detalles_Pedido] ([Id_Pedido], [Matricula], [fecha_compra], [precio]) VALUES (1, N'5634 ABC', NULL, NULL)
INSERT [dbo].[Detalles_Pedido] ([Id_Pedido], [Matricula], [fecha_compra], [precio]) VALUES (2, N'9090 MVC', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Gamma] ON 

INSERT [dbo].[Gamma] ([Id], [Clase], [Precio]) VALUES (1, N'Baja', 10000.0000)
INSERT [dbo].[Gamma] ([Id], [Clase], [Precio]) VALUES (2, N'Media', 20000.0000)
INSERT [dbo].[Gamma] ([Id], [Clase], [Precio]) VALUES (3, N'Alta', 30000.0000)
SET IDENTITY_INSERT [dbo].[Gamma] OFF
GO
INSERT [dbo].[Moto] ([Matricula], [Espejos], [Imagen]) VALUES (N'1261 TVX', N'2', N'\img\motoAlta1.jpg')
INSERT [dbo].[Moto] ([Matricula], [Espejos], [Imagen]) VALUES (N'4545 JKL', N'2', N'\img\motoMedia1.jpg')
INSERT [dbo].[Moto] ([Matricula], [Espejos], [Imagen]) VALUES (N'5665 VGE', N'2', N'\img\motoMedia2.jpg')
INSERT [dbo].[Moto] ([Matricula], [Espejos], [Imagen]) VALUES (N'5678 MCF', N'2', N'\img\motoMedia3.jpg')
INSERT [dbo].[Moto] ([Matricula], [Espejos], [Imagen]) VALUES (N'7890 CXS', N'2', N'\img\motoAlta2.jpg')
INSERT [dbo].[Moto] ([Matricula], [Espejos], [Imagen]) VALUES (N'9090 MVC', N'1', N'\img\motoBaja1.jpg')
GO
SET IDENTITY_INSERT [dbo].[Pedido] ON 

INSERT [dbo].[Pedido] ([Id], [Correo_Usu]) VALUES (1, N'pepeluis@gmail.com')
INSERT [dbo].[Pedido] ([Id], [Correo_Usu]) VALUES (2, N'laurasanchez@gmail.com')
SET IDENTITY_INSERT [dbo].[Pedido] OFF
GO
SET IDENTITY_INSERT [dbo].[Piezas] ON 

INSERT [dbo].[Piezas] ([Id], [tipo], [precio], [Imagen], [Nombre]) VALUES (17, N'coche', 50.0000, N'\img\amortiguadores-coche.png', N'Amortiguador')
INSERT [dbo].[Piezas] ([Id], [tipo], [precio], [Imagen], [Nombre]) VALUES (18, N'moto', 120.0000, N'\img\discofreno-moto.png', N'Disco de Freno')
INSERT [dbo].[Piezas] ([Id], [tipo], [precio], [Imagen], [Nombre]) VALUES (19, N'coche', 10.0000, N'\img\escobillas-coche.png', N'Escobillas')
INSERT [dbo].[Piezas] ([Id], [tipo], [precio], [Imagen], [Nombre]) VALUES (20, N'coche', 28.0000, N'\img\filtroAceite-coche.png', N'Filtro de Aceite')
INSERT [dbo].[Piezas] ([Id], [tipo], [precio], [Imagen], [Nombre]) VALUES (21, N'coche', 260.0000, N'\img\frenos-coche.png', N'Frenos')
INSERT [dbo].[Piezas] ([Id], [tipo], [precio], [Imagen], [Nombre]) VALUES (22, N'moto', 60.0000, N'\img\kitCadenas-moto.png', N'Kit de Cadenas')
INSERT [dbo].[Piezas] ([Id], [tipo], [precio], [Imagen], [Nombre]) VALUES (23, N'moto', 80.0000, N'\img\lamparaFaro-moto.png', N'Faros')
INSERT [dbo].[Piezas] ([Id], [tipo], [precio], [Imagen], [Nombre]) VALUES (24, N'moto', 100.0000, N'\img\piñonCadena-moto.png', N'Piñon de Cadena')
SET IDENTITY_INSERT [dbo].[Piezas] OFF
GO
INSERT [dbo].[Usuario] ([Correo], [Contraseña]) VALUES (N'fran@gmail.com', N'contraseña')
INSERT [dbo].[Usuario] ([Correo], [Contraseña]) VALUES (N'laurasanchez@gmail.com', N'lAuRi45')
INSERT [dbo].[Usuario] ([Correo], [Contraseña]) VALUES (N'pepe@gmail.com', N'contraseña')
INSERT [dbo].[Usuario] ([Correo], [Contraseña]) VALUES (N'pepeluis@gmail.com', N'pePiTo48')
INSERT [dbo].[Usuario] ([Correo], [Contraseña]) VALUES (N'prueba1@gmail.com', N'prueba1234')
INSERT [dbo].[Usuario] ([Correo], [Contraseña]) VALUES (N'prueba2@gmail.com', N'prueba2134')
GO
INSERT [dbo].[Vehiculo] ([Matricula], [Id_Gamma]) VALUES (N'1242 JIL', 2)
INSERT [dbo].[Vehiculo] ([Matricula], [Id_Gamma]) VALUES (N'1261 TVX', 1)
INSERT [dbo].[Vehiculo] ([Matricula], [Id_Gamma]) VALUES (N'2018 JKR', 1)
INSERT [dbo].[Vehiculo] ([Matricula], [Id_Gamma]) VALUES (N'2222 AAA', 3)
INSERT [dbo].[Vehiculo] ([Matricula], [Id_Gamma]) VALUES (N'4545 JKL', 2)
INSERT [dbo].[Vehiculo] ([Matricula], [Id_Gamma]) VALUES (N'5634 ABC', 1)
INSERT [dbo].[Vehiculo] ([Matricula], [Id_Gamma]) VALUES (N'5665 VGE', 2)
INSERT [dbo].[Vehiculo] ([Matricula], [Id_Gamma]) VALUES (N'5678 MCF', 2)
INSERT [dbo].[Vehiculo] ([Matricula], [Id_Gamma]) VALUES (N'7632 OPG', 1)
INSERT [dbo].[Vehiculo] ([Matricula], [Id_Gamma]) VALUES (N'7890 CXS', 1)
INSERT [dbo].[Vehiculo] ([Matricula], [Id_Gamma]) VALUES (N'8888 FDF', 3)
INSERT [dbo].[Vehiculo] ([Matricula], [Id_Gamma]) VALUES (N'9090 MVC', 3)
INSERT [dbo].[Vehiculo] ([Matricula], [Id_Gamma]) VALUES (N'9823 ASD', 2)
GO
ALTER TABLE [dbo].[Coche]  WITH CHECK ADD FOREIGN KEY([Matricula])
REFERENCES [dbo].[Vehiculo] ([Matricula])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Detalles_Pedido]  WITH CHECK ADD FOREIGN KEY([Id_Pedido])
REFERENCES [dbo].[Pedido] ([Id])
GO
ALTER TABLE [dbo].[Detalles_Pedido]  WITH CHECK ADD FOREIGN KEY([Matricula])
REFERENCES [dbo].[Vehiculo] ([Matricula])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Moto]  WITH CHECK ADD FOREIGN KEY([Matricula])
REFERENCES [dbo].[Vehiculo] ([Matricula])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD FOREIGN KEY([Correo_Usu])
REFERENCES [dbo].[Usuario] ([Correo])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Piezas_Vehiculo]  WITH CHECK ADD FOREIGN KEY([Id_Pieza])
REFERENCES [dbo].[Piezas] ([Id])
GO
ALTER TABLE [dbo].[Piezas_Vehiculo]  WITH CHECK ADD FOREIGN KEY([Matricula_Vehiculo])
REFERENCES [dbo].[Vehiculo] ([Matricula])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD FOREIGN KEY([Id_Gamma])
REFERENCES [dbo].[Gamma] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Moto]  WITH CHECK ADD CHECK  (([Espejos]='2' OR [Espejos]='1'))
GO
ALTER TABLE [dbo].[Moto]  WITH CHECK ADD CHECK  (([Espejos]='2' OR [Espejos]='1'))
GO
/****** Object:  StoredProcedure [dbo].[EditarUsuario]    Script Date: 12/05/2022 15:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[EditarUsuario] (@correo varchar(max), @contrasena varchar(max))
as
update Usuario set Correo=@correo, Contraseña=@contrasena where Correo=@correo
GO
/****** Object:  StoredProcedure [dbo].[InsertarUsuarios]    Script Date: 12/05/2022 15:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertarUsuarios] (@correo varchar(max), @contraseña varchar(max))
as
insert into Usuario (Correo, Contraseña) values (@correo, @contraseña)
GO
/****** Object:  StoredProcedure [dbo].[MostrarCoches]    Script Date: 12/05/2022 15:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     PROCEDURE [dbo].[MostrarCoches] @Gamma varchar(max)
AS
BEGIN
	select Coche.Matricula, Coche.Imagen
	FROM Coche, Vehiculo, Gamma
	WHERE Coche.Matricula = Vehiculo.Matricula AND
	Vehiculo.Id_Gamma = Gamma.Id AND
	Gamma.Id = @Gamma
END
GO
/****** Object:  StoredProcedure [dbo].[MostrarMotos]    Script Date: 12/05/2022 15:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[MostrarMotos] @Gamma varchar(max)
AS
BEGIN
	select Moto.Matricula, Moto.Imagen
	FROM Moto, Vehiculo, Gamma
	WHERE Moto.Matricula = Vehiculo.Matricula AND
	Vehiculo.Id_Gamma = Gamma.Id AND
	Gamma.Id = @Gamma
END
GO
/****** Object:  StoredProcedure [dbo].[MostrarPiezasCoche]    Script Date: 12/05/2022 15:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[MostrarPiezasCoche]
AS
BEGIN
	select Id, Nombre, Imagen, precio
	FROM Piezas
	WHERE Piezas.tipo = 'Coche'
END
GO
/****** Object:  StoredProcedure [dbo].[MostrarPiezasMoto]    Script Date: 12/05/2022 15:46:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[MostrarPiezasMoto]
AS
BEGIN
	select Id, Nombre, Imagen, precio
	FROM Piezas
	WHERE Piezas.tipo = 'Moto'
END
GO
