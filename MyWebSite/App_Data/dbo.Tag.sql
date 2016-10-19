CREATE TABLE [dbo].[Tag]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NULL
)

SET IDENTITY_INSERT [dbo].[Tag] ON

INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (1, N'.NET', N'The Microsoft .Net Framework')
INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (2, N'PowerShell', N'Windows PowerShell')
INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (3, N'ASP.NET', N'Microsoft ASP.NET')
INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (4, N'Windows', N'Windows Operating System')
INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (5, N'UNIX', N'Unix based Operating System')
INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (6, N'Linux', N'Linux Operating System')
INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (7, N'Python', N'Python scripting language')
INSERT INTO [dbo].[Tag] ([Id], [Name], [Description]) VALUES (8, N'Media', N'Home Media Setup')

SET IDENTITY_INSERT [dbo].[Tag] OFF
