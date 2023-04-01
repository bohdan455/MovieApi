CREATE TABLE [dbo].[Movies]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(200) NOT NULL, 
    [Released] DATE NULL, 
    [Genre_FK] INT NULL, 
    [Description] NVARCHAR(2000) NULL, 
    CONSTRAINT [FK_Movies_ToTable] FOREIGN KEY ([Genre_FK]) REFERENCES [Genres]([Id]) 
)
