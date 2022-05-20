USE [Chat]
GO
/****** Object:  Table [chat].[chats]    Script Date: 21.05.2022 0:25:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [chat].[chats](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[chat_name] [nvarchar](150) NOT NULL,
	[date] [datetime] NOT NULL,
	[id_admin] [int] NOT NULL,
	[image] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [chat].[friends]    Script Date: 21.05.2022 0:25:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [chat].[friends](
	[id_user_who_add] [int] NOT NULL,
	[id_user_friend_added] [int] NOT NULL,
	[date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_user_who_add] ASC,
	[id_user_friend_added] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [chat].[images]    Script Date: 21.05.2022 0:25:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [chat].[images](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_user] [int] NOT NULL,
	[image] [varbinary](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [chat].[messages]    Script Date: 21.05.2022 0:25:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [chat].[messages](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_user] [int] NOT NULL,
	[id_chat] [int] NOT NULL,
	[message] [nvarchar](1000) NULL,
	[image] [varbinary](max) NULL,
	[date] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [chat].[users]    Script Date: 21.05.2022 0:25:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [chat].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [varchar](150) NOT NULL,
	[password] [varchar](128) NOT NULL,
	[image] [varbinary](max) NULL,
	[status] [bit] NOT NULL,
	[status_deleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [chat].[users_chats]    Script Date: 21.05.2022 0:25:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [chat].[users_chats](
	[id_user] [int] NOT NULL,
	[id_chat] [int] NOT NULL,
	[id_person_who_invited] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_user] ASC,
	[id_chat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [chat].[chats] ADD  DEFAULT (getdate()) FOR [date]
GO
ALTER TABLE [chat].[messages] ADD  DEFAULT (getdate()) FOR [date]
GO
ALTER TABLE [chat].[chats]  WITH CHECK ADD FOREIGN KEY([id_admin])
REFERENCES [chat].[users] ([id])
GO
ALTER TABLE [chat].[friends]  WITH CHECK ADD FOREIGN KEY([id_user_who_add])
REFERENCES [chat].[users] ([id])
GO
ALTER TABLE [chat].[friends]  WITH CHECK ADD FOREIGN KEY([id_user_friend_added])
REFERENCES [chat].[users] ([id])
GO
ALTER TABLE [chat].[images]  WITH CHECK ADD FOREIGN KEY([id_user])
REFERENCES [chat].[users] ([id])
GO
ALTER TABLE [chat].[messages]  WITH CHECK ADD FOREIGN KEY([id_chat])
REFERENCES [chat].[chats] ([id])
GO
ALTER TABLE [chat].[messages]  WITH CHECK ADD FOREIGN KEY([id_user])
REFERENCES [chat].[users] ([id])
GO
ALTER TABLE [chat].[users_chats]  WITH CHECK ADD FOREIGN KEY([id_chat])
REFERENCES [chat].[chats] ([id])
GO
ALTER TABLE [chat].[users_chats]  WITH CHECK ADD FOREIGN KEY([id_person_who_invited])
REFERENCES [chat].[users] ([id])
GO
ALTER TABLE [chat].[users_chats]  WITH CHECK ADD FOREIGN KEY([id_user])
REFERENCES [chat].[users] ([id])
GO
