CREATE DATABASE [cabrador]
GO
USE [cabrador]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 3/9/2017 4:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[photo] [varchar](255) NULL,
	[email] [varchar](255) NULL,
	[password] [varchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dogs]    Script Date: 3/9/2017 4:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dogs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[breed] [varchar](255) NULL,
	[photo] [varchar](255) NULL,
	[shelter] [varchar](255) NULL,
	[adopted] [tinyint] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[drivers]    Script Date: 3/9/2017 4:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[drivers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[car] [varchar](255) NULL,
	[photo] [varchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[trips]    Script Date: 3/9/2017 4:02:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trips](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[start_point] [varchar](255) NULL,
	[destination] [varchar](255) NULL,
	[price] [int] NULL,
	[miles] [int] NULL,
	[date] [varchar](255) NULL,
	[driver_id] [int] NULL,
	[dog_id] [int] NULL,
	[customer_id] [int] NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[customers] ON 

INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (1, N'afdf', N'sdvfdd', N'asfdf@khg.com', N'zsflhsdgf')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (2, N'asdfasdf', N'asdfasdf', N'asdfasdf@yahoo.com', N'asdfasdf')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (3, N'Cassie', N'https://pbs.twimg.com/profile_images/700136447093805056/iwRqAEEy.jpg', N'asdfasdf@yahoo.com', N'asdfasdf')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (4, N'asdfasdf', N'asdfasdf', N'asdfasdf@yahoo.com', N'asdfasdf')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (5, N'Cassie', N'jfasdflkj', N'cassie@gmail.com', N'asdlkfj')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (6, N'Cassie', N'jfasdflkj', N'cassie@gmail.com', N'asdlkfj')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (7, N'Cassie', N'asdfsadf', N'cassie@gmail.com', N'fdalkjdf')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (8, N'cass', N'asdf', N'cas@gmail.com', N'alsdf')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (9, N'cass', N'asdfs', N'cass@gmail.com', N'adsf')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (10, N'asdfsdf', N'asdfasdf', N'asdfasfd@aasdf.com', N'asdfasdf')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (11, N'asdfasdf', N'asdfsadf', N'Df@gma.com', N'asdf')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (12, N'Cassie', N'asdflkj', N'cass@gmail.com', N'sdflkj')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (13, N'asdfasdf', N'asdfasdf', N'asdfadf@yahoo.com', N'asdfasdf')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (14, N'keely', N'url', N'keely@gmail.com', N'dskfsdf')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (15, N'sadfasd', N'sdfasdf', N'sdafsda@gmail.com', N'fdgsadfasd')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (16, N'keely', N'sdfjas', N'sdlkjsad@gmail.com', N'fdlkgjasdf')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (17, N'dafsd', N'asdfsd', N'asdf@gmail.com', N'asdflk')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (18, N'cass', N'dafsd', N'cass@gmail.com', N'asdfsadf')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (19, N'cass', N'asdfsd', N'cass@gmail.com', N'asdfsd')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (20, N'cass', N'dafsd', N'cass@gmail.com', N'dasdf')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (21, N'keelu', N'dsfsadf', N'jsdf@gmail.com', N'dsfasdf')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (22, N'Britt', N'https://images.pexels.com/photos/38554/girl-people-landscape-sun-38554.jpeg?w=940&h=650&auto=compress&cs=tinysrgb', N'brittany@gmail.com', N'hello')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (23, N'Britt', N'https://images.pexels.com/photos/38554/girl-people-landscape-sun-38554.jpeg?w=940&h=650&auto=compress&cs=tinysrgb', N'brittany@gmail.com', N'britt')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (24, N'Cassie', N'https://images.pexels.com/photos/38554/girl-people-landscape-sun-38554.jpeg?w=940&h=650&auto=compress&cs=tinysrgb', N'cass@gmail.com', N'sadfasdf')
INSERT [dbo].[customers] ([id], [name], [photo], [email], [password]) VALUES (25, N'Cassie', N'https://upload.wikimedia.org/wikipedia/commons/0/0e/Cassie_Ventura.jpg', N'cassie@gmail.com', N'cassie')
SET IDENTITY_INSERT [dbo].[customers] OFF
SET IDENTITY_INSERT [dbo].[dogs] ON 

INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (1, N'Oakley', N'Boxer', N'/Content/img/Oakley.jpg', N'Seattle Humane Society', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (2, N'Alex', N'Shepherd Mix', N'/Content/img/Alex.jpg', N'SPCA of Seattle', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (3, N'Allie', N'Border Collie', N'/Content/img/Allie.jpg', N'SPCA of Seattle', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (4, N'Bebe', N'Chihuahua', N'/Content/img/Bebe.jpg', N'Seattle Humane Society', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (5, N'Bella', N'English Bulldog', N'/Content/img/Bella.jpg', N'NW Bulldog Haven', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (6, N'Bowie', N'Terrier/Dachsund', N'/Content/img/Bowie.jpg', N'SPCA', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (7, N'Tilly', N'Spaniel/Chihuahua', N'/Content/img/TIlly.jpg', N'Santa Cruz Humane Society', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (8, N'Rapunzel', N'Retriever', N'/Content/img/Rapunzel.jpg', N'Santa Cruz Humane Society', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (9, N'Cara', N'Retriever Mix', N'/Content/img/Cara.jpg', N'Santa Cruz Humane Society', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (10, N'Loki', N'Chihuahua', N'/Content/img/Loki.jpg', N'Seattle Humane', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (11, N'Sarge', N'Dutch Shepherd', N'/Content/img/Sarge.jpg', N'Seattle Humane', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (12, N'Bert', N'Fox Terrier', N'/Content/img/Bert.jpg', N'Seattle Humane', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (13, N'Chico', N'Pit Mix', N'/Content/img/Chico.jpg', N'Seattle Humane', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (14, N'Sage', N'Pit Mix', N'/Content/img/Sage.jpg', N'Seattle Humane', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (15, N'Beverely', N'Border Collie', N'/Content/img/Beverely.jpg', N'Seattle Humane', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (16, N'Paddington Bear', N'Beagle Mix', N'/Content/img/PaddingtonBear.jpg', N'Seattle Humane ', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (17, N'Mowgli', N'Terrier Bull Mix', N'/Content/img/Mowgli.jpg', N'Seattle Humane', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (18, N'Frankie', N'English Bulldog', N'/Content/img/Frankie.jpg', N'NW Bulldog Haven', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (19, N'Opal', N'Lab', N'/Content/img/Opal.jpg', N'Seattle Animal Shelter', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (20, N'Snowflake', N'Terrier/American Pit Bull', N'/Content/img/Snowflake.jpg', N'Seattle Animal Shelter', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (21, N'Pops', N'Terrier/American Pit Bull', N'/Content/img/Pops.jpg', N'Seattle Animal Shelter', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (22, N'Honey', N'Chihuahua', N'/Content/img/Honey.jpg', N'Seattle Animal Shelter', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (23, N'Lorisa', N'English Bulldog', N'/Content/img/Lorisa.jpg', N'NW Bulldog Haven', 0)
INSERT [dbo].[dogs] ([id], [name], [breed], [photo], [shelter], [adopted]) VALUES (24, N'Sammy Orion', N'Retriever Mix', N'/img/Sammy_Orion.jpg', N'Seattle Humane', 0)
SET IDENTITY_INSERT [dbo].[dogs] OFF
SET IDENTITY_INSERT [dbo].[drivers] ON 

INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (1, N'Aniekan', N'Toyota Prius', N'/drivers/Aniekan.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (2, N'Ariel', N'Honda Element', N'/drivers.Ariel.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (3, N'Ayana', N'Mercedes E-Class', N'/drivers/Ayana.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (4, N'Ben', N'Ford Fusion', N'/drivers/Ben.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (5, N'Carl', N'Honda Civic', N'/drivers/Carl.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (6, N'Chris', N'Subaru Outback', N'/drivers/Chris.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (7, N'Dmitri', N'Toyota Camry', N'/driver/Dmitri.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (8, N'Elizabeth', N'Audi A4', N'/drivers/Elizabeth.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (9, N'Emilie', N'Volkswagen Jetta', N'/drivers/Emilie.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (10, N'Hamed', N'Mercedes C-Class', N'/drivers/Hamed.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (11, N'Heather', N'Toyota Prius', N'/drivers/Heather.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (12, N'Jack', N'Chevy Malibu', N'/drivers/Jack.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (13, N'Jamie', N'Subaru Impreza', N'/drivers/Jamie.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (14, N'Jenny', N'Subaru Forester', N'/drivers/Jenny.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (15, N'Junelle', N'Honda Civic', N'/drivers/Junelle.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (16, N'Kameran', N'Audi S6', N'/drivers/Kameran.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (17, N'Kevin', N'Honda Element', N'/drivers/Kevin.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (18, N'Leo', N'Volkswagen Rabbit', N'/drivers/leo.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (19, N'Madison', N'Hyundai Sonata', N'/drivers/Madison.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (20, N'Meg', N'Subaru Outback', N'/drivers/Meg.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (21, N'Michelle', N'Lexus RX', N'/drivers/Michelle.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (22, N'Miquel', N'Subaru Tribeca', N'/drivers/Miquel.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (23, N'Quin', N'Honda Accord', N'/drivers/quin.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (24, N'Ryan', N'BMW 745', N'/drivers/Ryan.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (25, N'Sabrina', N'Nissan Xterra', N'/drivers/Sabrina.jpg')
INSERT [dbo].[drivers] ([id], [name], [car], [photo]) VALUES (26, N'Trevor', N'Volkswagen Golf', N'/drivers/Trevor.jpg')
SET IDENTITY_INSERT [dbo].[drivers] OFF
SET IDENTITY_INSERT [dbo].[trips] ON 

INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (1, N'222', N'222', 20, 5, N'2017-03-09', 3, 3, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (2, N'222', N'222', 20, 5, N'2017-03-09', 3, 3, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (3, N'asdfas', N'asdfasdf', 20, 5, N'2017-03-03', 3, 1, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (4, N'etxdtgxf', N'cgcgv', 22, 6, N'2017-03-08', 3, 5, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (5, N'zfgfg', N'xgxf', 16, 3, N'may 2nd', 3, 2, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (6, N'dsrgfrg', N'zasfzdf', 20, 5, N'2017-03-07', 3, 1, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (7, N'vvvf', N'dgxfg', 18, 4, N'2017-03-09', 3, 5, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (8, N'vvvf', N'dgxfg', 18, 4, N'2017-03-09', 3, 5, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (9, N'vvvf', N'dgxfg', 18, 4, N'2017-03-09', 3, 5, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (10, N'vvvf', N'dgxfg', 18, 4, N'2017-03-09', 3, 5, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (11, N'vvvf', N'dgxfg', 18, 4, N'2017-03-09', 3, 5, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (12, N'vvvf', N'dgxfg', 18, 4, N'2017-03-09', 3, 5, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (13, N'vvvf', N'dgxfg', 18, 4, N'2017-03-09', 3, 5, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (14, N'vvvf', N'dgxfg', 18, 4, N'2017-03-09', 3, 5, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (15, N'vvvf', N'dgxfg', 18, 4, N'2017-03-09', 3, 5, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (16, N'vvvf', N'dgxfg', 18, 4, N'2017-03-09', 3, 5, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (17, N'cgsDSD', N'SFzdf', 18, 4, N'2017-03-11', 3, 4, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (18, N'dfdf', N'sezsrw', 22, 6, N'2017-03-07', 3, 4, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (19, N'asdfasdf', N'asdfsdf', 16, 3, N'2017-03-09', 3, 8, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (20, N'asdfasdf', N'adsfasdf', 16, 3, N'2017-03-01', 3, 3, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (21, N'asdfasdf', N'adsfasdf', 16, 3, N'2017-03-01', 3, 3, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (22, N'asdfasdf', N'adsfasdf', 16, 3, N'2017-03-01', 3, 3, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (23, N'dasfadsf', N'asdfasdf', 18, 4, N'2017-03-11', 3, 4, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (24, N'dasfadsf', N'asdfasdf', 18, 4, N'2017-03-11', 3, 4, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (25, N'adfdffd', N'fgsrtwe', 18, 4, N'2017-03-08', 3, 9, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (26, N'adfdffd', N'fgsrtwe', 18, 4, N'2017-03-08', 3, 9, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (27, N'adfdffd', N'fgsrtwe', 18, 4, N'2017-03-08', 3, 9, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (28, N'ADwreff', N'zdfaer', 16, 3, N'2017-03-10', 3, 4, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (29, N'ADwreff', N'zdfaer', 16, 3, N'2017-03-10', 3, 4, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (30, N'ADwreff', N'zdfaer', 16, 3, N'2017-03-10', 3, 4, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (31, N'ewrqwer', N'qwerqwer', 16, 3, N'2017-03-16', 3, 2, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (32, N'zfzdf', N'z', 24, 7, N'2017-03-16', 3, 11, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (33, N'zfzdf', N'z', 24, 7, N'2017-03-16', 3, 11, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (34, N'zfzdf', N'z', 24, 7, N'2017-03-16', 3, 11, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (35, N'xvzdgxfgb', N'xdtaet', 18, 4, N'2017-03-17', 23, 6, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (36, N'dstsetr', N'sdtrst', 20, 5, N'2017-03-10', 12, 6, 25)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (37, N'123 East St.', N'123 West St.', 14, 2, N'2017-01-01', 26, 12, 1)
INSERT [dbo].[trips] ([id], [start_point], [destination], [price], [miles], [date], [driver_id], [dog_id], [customer_id]) VALUES (38, N'asdfasdf', N'asdfasdf', 18, 4, N'2017-04-21', 14, 19, 25)
SET IDENTITY_INSERT [dbo].[trips] OFF
