CREATE TABLE [dbo].[Post]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [ShortDescription] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [Content] NVARCHAR(MAX) NOT NULL, 
    [Published] BIT NOT NULL, 
    [PostedOn] DATETIME NOT NULL, 
    [Modified] DATETIME NOT NULL,
    [Category_Id] INT NOT NULL,
    CONSTRAINT [FK_Post_Category] FOREIGN KEY ([Category_Id]) REFERENCES [dbo].[Category] ([Id])
)
