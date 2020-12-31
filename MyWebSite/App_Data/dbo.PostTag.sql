CREATE TABLE [dbo].[PostTag]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Post_Id] INT NOT NULL, 
    [Tag_Id] INT NOT NULL, 
    CONSTRAINT [FK_PostTag_Post] FOREIGN KEY ([Post_Id]) REFERENCES [Post]([Id]), 
    CONSTRAINT [FK_PostTag_Tag] FOREIGN KEY ([Tag_Id]) REFERENCES [Tag]([Id])
)

SET IDENTITY_INSERT [dbo].[PostTag] ON

INSERT INTO [dbo].[PostTag] ([Id], [Post_Id], [Tag_Id]) VALUES (1, 6, 2)
INSERT INTO [dbo].[PostTag] ([Id], [Post_Id], [Tag_Id]) VALUES (2, 9, 2)
INSERT INTO [dbo].[PostTag] ([Id], [Post_Id], [Tag_Id]) VALUES (3, 6, 4)
INSERT INTO [dbo].[PostTag] ([Id], [Post_Id], [Tag_Id]) VALUES (4, 9, 4)
INSERT INTO [dbo].[PostTag] ([Id], [Post_Id], [Tag_Id]) VALUES (5, 12, 2)
INSERT INTO [dbo].[PostTag] ([Id], [Post_Id], [Tag_Id]) VALUES (6, 12, 4)
INSERT INTO [dbo].[PostTag] ([Id], [Post_Id], [Tag_Id]) VALUES (7, 12, 9)

SET IDENTITY_INSERT [dbo].[PostTag] OFF