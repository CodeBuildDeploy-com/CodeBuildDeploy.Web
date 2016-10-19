CREATE TABLE [dbo].[Post]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [ShortDescription] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [Content] NVARCHAR(MAX) NOT NULL, 
    [Published] BIT NOT NULL, 
    [PostedOn] DATETIME NOT NULL, 
    [Modified] DATETIME NOT NULL,
    [Category_Id] INT NOT NULL,
    [UrlSlug] NVARCHAR(50) NOT NULL,
    CONSTRAINT [FK_Post_Category] FOREIGN KEY ([Category_Id]) REFERENCES [dbo].[Category] ([Id])
)

SET IDENTITY_INSERT [dbo].[Post] ON

INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug]) VALUES (1, N'Libraries', N'Libraries you may like', N'This section lists libraries I often use. These range from logging frameworks to testing tools used for testing / mocking etc.', N'Libraries', 1, N'2015-03-31 00:00:00', N'2015-03-31 00:00:00', 2, N'Libraries')
INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug]) VALUES (4, N'Links', N'Useful links and resources', N'Links to External Articles / Resources.', N'Links', 1, N'2015-03-31 00:00:00', N'2015-03-31 00:00:00', 3, N'Links')
INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug]) VALUES (5, N'Tools', N'My favourite software tools', N'This section lists the tools I frequently use. Some are development tools others utility tools making general day to day working easier.', N'Tools', 1, N'2015-03-31 00:00:00', N'2015-03-31 00:00:00', 1, N'Tools')
INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug]) VALUES (6, N'PowerShell Grep', N'Grep for Windows PowerShell.', N'Need more...', N'PowerShellGrep', 1, N'2015-05-31 00:00:00', N'2015-05-31 00:00:00', 5, N'PowerShellGrep')
INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug]) VALUES (9, N'PowerShell Remoting', N'Enable and work with powershell remoting.', N'This section talks about how to enable and work with powershell remoting.', N'PowerShellRemoting', 1, N'2015-05-31 00:00:00', N'2015-05-31 00:00:00', 5, N'PowerShellRemoting')
INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id], [UrlSlug])  VALUES (7, N'Install TVHeadend', N'How to install TVHeadend.', N'How to install TVHeadend.', N'TVHeadend', 1, N'2015-10-19 00:00:00', N'2015-10-19 00:00:00', 6, N'TVHeadend')

SET IDENTITY_INSERT [dbo].[Post] OFF