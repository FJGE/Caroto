USE [SOCIAL2]
GO
/****** Object:  Table [dbo].[Friend]    Script Date: 28/04/2022 10:32:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Friend](
	[ID1] [int] NOT NULL,
	[ID2] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID1] ASC,
	[ID2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Highschooler]    Script Date: 28/04/2022 10:32:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Highschooler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Grade] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Likes]    Script Date: 28/04/2022 10:32:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Likes](
	[ID1] [int] NOT NULL,
	[ID2] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID1] ASC,
	[ID2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Friend] ([ID1], [ID2]) VALUES (1, 2)
INSERT [dbo].[Friend] ([ID1], [ID2]) VALUES (1, 3)
INSERT [dbo].[Friend] ([ID1], [ID2]) VALUES (1, 5)
INSERT [dbo].[Friend] ([ID1], [ID2]) VALUES (2, 1)
INSERT [dbo].[Friend] ([ID1], [ID2]) VALUES (2, 8)
INSERT [dbo].[Friend] ([ID1], [ID2]) VALUES (2, 9)
INSERT [dbo].[Friend] ([ID1], [ID2]) VALUES (3, 1)
INSERT [dbo].[Friend] ([ID1], [ID2]) VALUES (3, 6)
INSERT [dbo].[Friend] ([ID1], [ID2]) VALUES (5, 1)
INSERT [dbo].[Friend] ([ID1], [ID2]) VALUES (6, 3)
INSERT [dbo].[Friend] ([ID1], [ID2]) VALUES (8, 2)
INSERT [dbo].[Friend] ([ID1], [ID2]) VALUES (9, 2)
GO
SET IDENTITY_INSERT [dbo].[Highschooler] ON 

INSERT [dbo].[Highschooler] ([ID], [Name], [Grade]) VALUES (1, N'Beatrix', 10)
INSERT [dbo].[Highschooler] ([ID], [Name], [Grade]) VALUES (2, N'Coco', 5)
INSERT [dbo].[Highschooler] ([ID], [Name], [Grade]) VALUES (3, N'Flora', 9)
INSERT [dbo].[Highschooler] ([ID], [Name], [Grade]) VALUES (4, N'Olympia', 11)
INSERT [dbo].[Highschooler] ([ID], [Name], [Grade]) VALUES (5, N'Bluebell', 8)
INSERT [dbo].[Highschooler] ([ID], [Name], [Grade]) VALUES (6, N'Fraser', 8)
INSERT [dbo].[Highschooler] ([ID], [Name], [Grade]) VALUES (7, N'Horatio', 9)
INSERT [dbo].[Highschooler] ([ID], [Name], [Grade]) VALUES (8, N'Bertie', 10)
INSERT [dbo].[Highschooler] ([ID], [Name], [Grade]) VALUES (9, N'Rex', 4)
INSERT [dbo].[Highschooler] ([ID], [Name], [Grade]) VALUES (10, N'Otis', 5)
SET IDENTITY_INSERT [dbo].[Highschooler] OFF
GO
INSERT [dbo].[Likes] ([ID1], [ID2]) VALUES (2, 9)
INSERT [dbo].[Likes] ([ID1], [ID2]) VALUES (4, 7)

GO
ALTER TABLE [dbo].[Friend]  WITH CHECK ADD FOREIGN KEY([ID1])
REFERENCES [dbo].[Highschooler] ([ID])
GO
ALTER TABLE [dbo].[Friend]  WITH CHECK ADD FOREIGN KEY([ID2])
REFERENCES [dbo].[Highschooler] ([ID])
GO
ALTER TABLE [dbo].[Likes]  WITH CHECK ADD FOREIGN KEY([ID1])
REFERENCES [dbo].[Highschooler] ([ID])
GO
ALTER TABLE [dbo].[Likes]  WITH CHECK ADD FOREIGN KEY([ID2])
REFERENCES [dbo].[Highschooler] ([ID])
GO
