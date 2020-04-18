CREATE TABLE [dbo].[Category]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL
)

SET IDENTITY_INSERT [dbo].[Category] ON

INSERT INTO [dbo].[Category] ([Id], [Name], [Description]) VALUES (1, N'General', N'General Info')
INSERT INTO [dbo].[Category] ([Id], [Name], [Description]) VALUES (2, N'Automation', N'Automation and Continuous Delivery')
INSERT INTO [dbo].[Category] ([Id], [Name], [Description]) VALUES (5, N'Workstation Setup', N'Blogs on setting up my workstation')
INSERT INTO [dbo].[Category] ([Id], [Name], [Description]) VALUES (6, N'Media Setup', N'Home Media Setup')

SET IDENTITY_INSERT [dbo].[Category] OFF