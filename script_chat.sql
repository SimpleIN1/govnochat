USE [TOWORKWITHCS]
GO
/****** Object:  Schema [chat]    Script Date: 08.03.2022 13:43:49 ******/
CREATE SCHEMA [chat]
GO
/****** Object:  Table [chat].[chats]    Script Date: 08.03.2022 13:43:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [chat].[chats](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name_chat]  AS ('FID'+right('0000000000'+CONVERT([varchar](10),[id]),(10))) PERSISTED,
	[date] [date] NOT NULL,
	[name_chat_for_users] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [chat].[users]    Script Date: 08.03.2022 13:43:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [chat].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [varchar](120) NOT NULL,
	[password] [varchar](128) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [chat].[users_chats]    Script Date: 08.03.2022 13:43:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [chat].[users_chats](
	[id_user] [int] NOT NULL,
	[id_chat] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_user] ASC,
	[id_chat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [chat].[chats] ADD  DEFAULT (getdate()) FOR [date]
GO
ALTER TABLE [chat].[users_chats]  WITH CHECK ADD FOREIGN KEY([id_chat])
REFERENCES [chat].[chats] ([id])
GO
ALTER TABLE [chat].[users_chats]  WITH CHECK ADD FOREIGN KEY([id_user])
REFERENCES [chat].[users] ([id])
GO
