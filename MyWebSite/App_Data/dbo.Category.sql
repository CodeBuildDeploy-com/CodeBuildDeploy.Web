CREATE TABLE [dbo].[Category]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL
)

SET IDENTITY_INSERT [dbo].[Category] ON

INSERT INTO [dbo].[Category] ([Id], [Name], [Description]) VALUES (1, N'Tools', N'My favourite software tools')
INSERT INTO [dbo].[Category] ([Id], [Name], [Description]) VALUES (2, N'Libraries', N'Libraries you may like')
INSERT INTO [dbo].[Category] ([Id], [Name], [Description]) VALUES (3, N'Links', N'Useful links to external articles and resources')
INSERT INTO [dbo].[Category] ([Id], [Name], [Description]) VALUES (5, N'PowerShell', N'Windows command-line shell and scripting language')

SET IDENTITY_INSERT [dbo].[Category] OFF