USE [cabrador]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 3/6/2017 1:57:03 PM ******/
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
/****** Object:  Table [dbo].[dogs]    Script Date: 3/6/2017 1:57:03 PM ******/
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
/****** Object:  Table [dbo].[drivers]    Script Date: 3/6/2017 1:57:03 PM ******/
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
/****** Object:  Table [dbo].[trips]    Script Date: 3/6/2017 1:57:03 PM ******/
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
	[date] [datetime] NULL,
	[driver_id] [int] NULL,
	[dog_id] [int] NULL,
	[customer_id] [int] NULL
) ON [PRIMARY]

GO
