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
    CONSTRAINT [FK_Post_Category] FOREIGN KEY ([Category_Id]) REFERENCES [dbo].[Category] ([Id])
)

SET IDENTITY_INSERT [dbo].[Post] ON

INSERT INTO [dbo].[Post] ([Id], [Title], [ShortDescription], [Description], [Content], [Published], [PostedOn], [Modified], [Category_Id]) VALUES (1, N'Libraries', N'Libraries you may like', N'This section lists libraries I often use. These range from logging frameworks to testing tools used for testing / mocking etc.', N'<ul>
	<li>Nlog</li>
        <li>Common.Logging Facade</li>
        <li>NUnit</li>
        <li>Rx</li>
</ul>', 1, N'2015-03-31 00:00:00', N'2015-03-31 00:00:00', 2)

SET IDENTITY_INSERT [dbo].[Post] OFF