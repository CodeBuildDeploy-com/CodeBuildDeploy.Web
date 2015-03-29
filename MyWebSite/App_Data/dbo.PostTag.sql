CREATE TABLE [dbo].[PostTag]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Post_Id] INT NOT NULL, 
    [Tag_Id] INT NOT NULL, 
    CONSTRAINT [FK_PostTag_Post] FOREIGN KEY ([Post_Id]) REFERENCES [Post]([Id]), 
    CONSTRAINT [FK_PostTag_Tag] FOREIGN KEY ([Tag_Id]) REFERENCES [Tag]([Id])
)
