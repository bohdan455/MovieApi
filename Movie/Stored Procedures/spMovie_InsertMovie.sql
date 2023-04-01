CREATE PROCEDURE [dbo].[spMovie_InsertMovie]
	@Title nvarchar(200),
	@Released date,
	@Genre nvarchar(50),
	@Description nvarchar(2000)
AS
BEGIN
	IF NOT EXISTS(SELECT 1 FROM Genres WHERE Genre = @Genre)
		INSERT INTO Genres(Genre) VALUES (@Genre);

	INSERT INTO Movies(Title,Released,[Description],Genre_FK)
	VALUES (@Title, @Released, @Description,
		(SELECT Id FROM Genres WHERE Genre = @Genre)
	);

END
