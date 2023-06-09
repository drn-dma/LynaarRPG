/****** Object:  Table [dbo].[Boss]    Script Date: 25/05/2023 14:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boss](
	[Id_Entity] [int] NOT NULL,
	[Id_Equipement] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Entity] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Consumables]    Script Date: 25/05/2023 14:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consumables](
	[Id_Consumables] [int] NOT NULL,
	[name] [varchar](50) NULL,
	[maxDrop] [int] NULL,
	[rarity] [int] NULL,
	[priceBuy] [int] NULL,
	[priceSold] [int] NULL,
	[description] [varchar](255) NULL,
	[Id_Effect] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Consumables] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Effect]    Script Date: 25/05/2023 14:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Effect](
	[Id_Effect] [int] NOT NULL,
	[description] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Effect] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enemy]    Script Date: 25/05/2023 14:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enemy](
	[Id_Entity] [int] NOT NULL,
	[name] [varchar](50) NULL,
	[hp] [int] NULL,
	[xp] [int] NULL,
	[dmgMin] [int] NULL,
	[dmgMax] [int] NULL,
	[goldMin] [int] NULL,
	[goldMax] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Entity] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipement]    Script Date: 25/05/2023 14:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipement](
	[Id_Equipement] [int] NOT NULL,
	[description] [varchar](500) NULL,
	[name] [varchar](50) NULL,
	[rarity] [int] NULL,
	[atk] [int] NULL,
	[pv] [int] NULL,
	[price] [int] NULL,
	[isWeapon] [bit] NULL,
	[Id_Effect] [int] NULL,
	[eq_Picture] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Equipement] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory_Equipement]    Script Date: 25/05/2023 14:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory_Equipement](
	[id] [int] NOT NULL,
	[isEquiped] [bit] NULL,
	[Id_Equipement] [int] NOT NULL,
	[Id_Player] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Monsters]    Script Date: 25/05/2023 14:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Monsters](
	[Id_Entity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Entity] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Player]    Script Date: 25/05/2023 14:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Player](
	[Id_Player] [int] NOT NULL,
	[playerName] [varchar](50) NULL,
	[classes] [varchar](50) NULL,
	[level] [int] NULL,
	[xp] [int] NULL,
	[hp] [int] NULL,
	[maxHp] [int] NULL,
	[damage] [int] NULL,
	[additionalDamage] [int] NULL,
	[endurance] [int] NULL,
	[intelligence] [int] NULL,
	[gold] [int] NULL,
	[fightNumber] [int] NULL,
	[dateSave] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Player] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[possessed]    Script Date: 25/05/2023 14:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[possessed](
	[Id_Consumables] [int] NOT NULL,
	[Id_Player] [int] NOT NULL,
	[quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Consumables] ASC,
	[Id_Player] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Story]    Script Date: 25/05/2023 14:09:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Story](
	[Id_Story] [int] NOT NULL,
	[story_line] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Story] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Boss] ([Id_Entity], [Id_Equipement]) VALUES (53, 1)
INSERT [dbo].[Boss] ([Id_Entity], [Id_Equipement]) VALUES (54, 1)
INSERT [dbo].[Boss] ([Id_Entity], [Id_Equipement]) VALUES (55, 1)
INSERT [dbo].[Boss] ([Id_Entity], [Id_Equipement]) VALUES (56, 1)
INSERT [dbo].[Boss] ([Id_Entity], [Id_Equipement]) VALUES (57, 1)
INSERT [dbo].[Boss] ([Id_Entity], [Id_Equipement]) VALUES (58, 1)
INSERT [dbo].[Boss] ([Id_Entity], [Id_Equipement]) VALUES (59, 1)
INSERT [dbo].[Boss] ([Id_Entity], [Id_Equipement]) VALUES (60, 1)
GO
INSERT [dbo].[Consumables] ([Id_Consumables], [name], [maxDrop], [rarity], [priceBuy], [priceSold], [description], [Id_Effect]) VALUES (1, N'Potion de vie légère', 5, 1, 35, 10, N'Un petit remède parfait pour se remettre d''une chute.', 1)
GO
INSERT [dbo].[Effect] ([Id_Effect], [description]) VALUES (1, N'heal')
GO
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (1, N'Mouton', 15, 1, 1, 5, 1, 5)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (2, N'Loup', 17, 3, 1, 9, 1, 5)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (3, N'Méduse', 10, 1, 1, 35, 1, 5)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (4, N'Mage noir', 75, 7, 5, 14, 10, 20)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (5, N'Voleur', 45, 6, 4, 22, 7, 14)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (6, N'Voleuse', 40, 5, 3, 17, 7, 14)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (7, N'Brigand', 55, 9, 4, 15, 7, 14)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (8, N'Barbare', 80, 10, 5, 25, 10, 25)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (9, N'Succube', 40, 3, 20, 50, 5, 10)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (10, N'Gobelin', 20, 5, 2, 12, 3, 6)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (11, N'Kobold', 26, 8, 2, 16, 3, 6)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (12, N'Mage kobold', 27, 12, 2, 30, 3, 6)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (13, N'Guerrier kobold', 35, 10, 3, 22, 7, 14)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (14, N'Forgelier', 50, 6, 3, 13, 7, 14)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (15, N'Drakéide', 38, 9, 3, 17, 8, 16)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (16, N'Gobelin à butin', 99, 1, 1, 1, 1, 150)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (17, N'Slime', 10, 5, 1, 8, 1, 3)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (18, N'Rat-garou', 24, 5, 2, 15, 6, 9)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (19, N'Ours-garou', 80, 11, 5, 18, 15, 25)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (20, N'Loup-garou', 70, 14, 5, 24, 15, 20)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (21, N'Renégat', 40, 12, 3, 17, 5, 30)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (22, N'Centaure', 72, 14, 5, 23, 10, 32)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (23, N'Diablotin', 66, 6, 3, 9, 3, 33)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (24, N'Banshie', 32, 10, 2, 12, 2, 6)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (25, N'Doppelganger', 0, 0, 0, 0, 15, 30)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (26, N'Epée volante', 25, 15, 4, 25, 10, 23)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (27, N'Gargouille', 120, 1, 2, 4, 10, 26)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (28, N'Gnoll', 34, 12, 2, 16, 5, 8)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (29, N'Vampire', 70, 10, 4, 15, 15, 20)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (30, N'Liche', 69, 12, 5, 19, 1, 30)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (31, N'Mimique', 30, 50, 10, 60, 1, 150)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (32, N'Arbuste éveillé', 60, 5, 3, 9, 10, 15)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (33, N'Blême', 36, 16, 3, 18, 8, 10)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (34, N'Chien de chasse infernal', 45, 13, 3, 17, 6, 22)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (35, N'Cockatrice', 27, 6, 2, 12, 5, 7)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (36, N'Criard', 13, 1, 1, 10, 1, 5)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (37, N'Cranefeu', 40, 13, 3, 17, 10, 12)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (38, N'Cube gélatineux', 84, 10, 4, 13, 17, 21)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (39, N'Diable à chaîne', 85, 18, 5, 25, 13, 32)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (40, N'Dragonet', 90, 13, 5, 20, 19, 35)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (41, N'Guenaude', 82, 15, 5, 18, 14, 19)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (42, N'Harpie', 38, 12, 3, 16, 9, 13)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (43, N'Hobgoblin', 11, 2, 1, 8, 2, 7)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (44, N'Homme lézard', 22, 6, 2, 10, 6, 9)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (45, N'Homme poisson', 11, 7, 1, 11, 3, 6)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (46, N'Poisson rouge', 1, 1, 1, 1, 1, 1)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (47, N'Licorne', 67, 31, 7, 38, 29, 41)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (48, N'Manticore', 68, 17, 4, 23, 16, 23)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (49, N'Momie', 58, 16, 4, 23, 17, 20)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (50, N'Ogre', 59, 19, 4, 27, 11, 19)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (51, N'Ours-hibou', 53, 14, 3, 17, 13, 18)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (52, N'Pégase', 79, 18, 5, 37, 17, 39)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (53, N'Dragon', 150, 20, 20, 70, 50, 75)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (54, N'Hydre', 120, 20, 10, 25, 55, 65)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (55, N'Diable ancien', 200, 20, 24, 38, 75, 125)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (56, N'Archange', 170, 20, 30, 35, 100, 135)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (57, N'Liche supérieure', 125, 20, 45, 80, 50, 80)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (58, N'Médusa', 130, 20, 32, 48, 80, 100)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (59, N'Chef gobelin corrompu', 175, 20, 1, 100, 50, 150)
INSERT [dbo].[Enemy] ([Id_Entity], [name], [hp], [xp], [dmgMin], [dmgMax], [goldMin], [goldMax]) VALUES (60, N'Dieu du butin', 999, 40, 1, 1, 1, 500)
GO
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (1, N'La légende raconte que le porteur de cette épée appréciait se tailler les veines de la main. Desormais vous récuperez son âme !', N'Lame_de_rasoir.exe', 0, 0, 450, 999999, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (2, N'Coupe comme du papier, La seule arme à ce jour qui a pu couper le developpeur Akkiristo \n Attention ça coupe !', N'Lame.txt', 0, 0, 0, 999999, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (3, N'Une simple branche elle tue pas de dragons mais ça dépanne', N'Morceau de bois', 1, 1, 0, 1, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (4, N'<Epée> est un bien grand mot pour ce morceau de féraille', N'Epée rouillée', 1, 3, 0, 3, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (5, N'Tranchante mais pas trop non plus', N'Epée en fer', 2, 7, 0, 14, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (6, N'OH! ça brille !', N'Epée en or', 3, 10, 0, 50, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (7, N'Une arme de facture naine, plus résistant tu meurs', N'Epée en mithril', 4, 25, 10, 80, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (8, N'Le prix à payer pour la manier est moindre pour arriver a ses fins', N'Syrus,lame maudite', 5, 60, -50, 120, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (9, N'Le roi dragon Bahamuth lui même à forgé cette lame ', N'Baharuth', 5, 150, 0, 160, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (10, N'Une lame éblouissante créée à partir du coeur d''un ange rien n''est plus pure en ce monde que la matière dont elle est composée', N'Sainte lame de lumière', 5, 75, 50, 150, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (11, N'C''est ce qui arrive quand une licorne a une diahrée', N'Epee Arc-en-ciel', 5, 50, 300, 70, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (12, N'une épée bleue pixélisée qui n''a rien à faire ici', N'Epée en diamant', 5, 99, 0, 99, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (13, N'Il faut arrêter de ramasser tout ce qui taine par terre', N'Dague rouillée', 1, 2, 0, 1, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (14, N'Parfait pour couper le bridoux', N'Dague en fer', 1, 6, 0, 10, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (15, N'24 carats', N'Dague en or', 2, 8, 45, 2, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (16, N'La même que Bilbon Sacquet', N'Dague en mithril', 3, 20, 0, 80, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (17, N'Une dague faite à partir d''un crochet de l''hydre, hautement empoisonée', N'Crochet de l''Hydre', 4, 40, 0, 110, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (18, N'Une lame courte qui coupe à travers le temps', N'Chronos, dague du temps', 5, 50, 0, 130, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (19, N'Une lame renfermant l''âme d''un seigneur vampire', N'Elytis lame vampirique', 5, 42, 0, 150, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (20, N'Un mystère des plus étrange', N'Patte de bisounours', 5, 1, 50, 200, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (21, N'Une branche avec une ficelle', N'Arc en bois', 1, 4, 0, 1, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (22, N'Un arc en chêne robuste', N'Arc de chasse', 2, 10, 0, 5, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (23, N'Un arc solide et puissant', N'Arc en acier', 3, 15, 0, 10, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (24, N'Un arc moderne extrêmement puissant', N'Arc à poulie', 4, 30, 0, 70, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (25, N'Un puissant arc créer à partir du petit doigt de pied d''un dragon ', N'Arc en os de dragon', 5, 50, 0, 120, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (26, N'Un arc inépuisable qui crée des flêches d''anges quand on tire la corde', N'Elyos, Arc sacré', 5, 45, 0, 150, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (27, N'Une branche avec un peu de magie', N'Bâton en bois', 1, 1, 0, 1, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (28, N'Un bâton en fer sertit avec une émeraude', N'Bâton d''émeraude', 2, 25, 0, 20, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (29, N' Un bâton en fer sertit avec un saphir', N'Bâton de saphir', 3, 40, 0, 35, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (30, N'Un bâton en or sertit avec un rubis', N'Bâton en rubis', 4, 55, 0, 75, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (31, N'Un bâton ayant appartenu à l''archimage Zalaqium un bon copain à vous', N'Bâton de Mana de l''archimage', 5, 70, 20, 120, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (32, N'Aie, ça brûle', N'Bâton du soleil', 5, 100, 0, 250, 1, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (33, N'Le String du dev Pless''', N'Pless.toString()', 1, 0, 6, 1, 0, NULL, NULL)
INSERT [dbo].[Equipement] ([Id_Equipement], [description], [name], [rarity], [atk], [pv], [price], [isWeapon], [Id_Effect], [eq_Picture]) VALUES (34, N'Un pagne en toile un peu transparent mais on fait avec', N'Pagne en toile', 1, 0, 3, 1, 0, NULL, NULL)
GO
INSERT [dbo].[Inventory_Equipement] ([id], [isEquiped], [Id_Equipement], [Id_Player]) VALUES (1, 0, 1, 2)
INSERT [dbo].[Inventory_Equipement] ([id], [isEquiped], [Id_Equipement], [Id_Player]) VALUES (2, 0, 2, 2)
GO
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (1)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (2)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (3)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (4)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (5)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (6)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (7)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (8)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (9)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (10)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (11)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (12)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (13)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (14)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (15)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (16)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (17)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (18)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (19)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (20)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (21)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (22)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (23)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (24)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (25)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (26)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (27)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (28)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (29)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (30)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (31)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (32)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (33)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (34)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (35)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (36)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (37)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (38)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (39)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (40)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (41)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (42)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (43)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (44)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (45)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (46)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (47)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (48)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (49)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (50)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (51)
INSERT [dbo].[Monsters] ([Id_Entity]) VALUES (52)
GO
INSERT [dbo].[Player] ([Id_Player], [playerName], [classes], [level], [xp], [hp], [maxHp], [damage], [additionalDamage], [endurance], [intelligence], [gold], [fightNumber], [dateSave]) VALUES (1, N'Pless', N'hunter', 12, 245, 254, 345, 24, 45, 100, NULL, 11, 5, CAST(N'2023-04-05' AS Date))
INSERT [dbo].[Player] ([Id_Player], [playerName], [classes], [level], [xp], [hp], [maxHp], [damage], [additionalDamage], [endurance], [intelligence], [gold], [fightNumber], [dateSave]) VALUES (2, N'Akkiristo', N'rogue', 82, 1458, 1689, 2000, 367, 245, 100, NULL, 518, 45, CAST(N'2023-05-15' AS Date))
GO
INSERT [dbo].[possessed] ([Id_Consumables], [Id_Player], [quantity]) VALUES (1, 2, 12)
GO
ALTER TABLE [dbo].[Player] ADD  DEFAULT (NULL) FOR [dateSave]
GO
ALTER TABLE [dbo].[Boss]  WITH CHECK ADD FOREIGN KEY([Id_Entity])
REFERENCES [dbo].[Enemy] ([Id_Entity])
GO
ALTER TABLE [dbo].[Boss]  WITH CHECK ADD FOREIGN KEY([Id_Equipement])
REFERENCES [dbo].[Equipement] ([Id_Equipement])
GO
ALTER TABLE [dbo].[Consumables]  WITH CHECK ADD FOREIGN KEY([Id_Effect])
REFERENCES [dbo].[Effect] ([Id_Effect])
GO
ALTER TABLE [dbo].[Equipement]  WITH CHECK ADD FOREIGN KEY([Id_Effect])
REFERENCES [dbo].[Effect] ([Id_Effect])
GO
ALTER TABLE [dbo].[Inventory_Equipement]  WITH CHECK ADD FOREIGN KEY([Id_Equipement])
REFERENCES [dbo].[Equipement] ([Id_Equipement])
GO
ALTER TABLE [dbo].[Inventory_Equipement]  WITH CHECK ADD FOREIGN KEY([Id_Player])
REFERENCES [dbo].[Player] ([Id_Player])
GO
ALTER TABLE [dbo].[Monsters]  WITH CHECK ADD FOREIGN KEY([Id_Entity])
REFERENCES [dbo].[Enemy] ([Id_Entity])
GO
ALTER TABLE [dbo].[possessed]  WITH CHECK ADD FOREIGN KEY([Id_Consumables])
REFERENCES [dbo].[Consumables] ([Id_Consumables])
GO
ALTER TABLE [dbo].[possessed]  WITH CHECK ADD FOREIGN KEY([Id_Player])
REFERENCES [dbo].[Player] ([Id_Player])
GO
