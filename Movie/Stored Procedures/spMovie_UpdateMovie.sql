CREATE PROCEDURE [dbo].[spMovie_UpdateMovie]
	@Id int,
	@Title nvarchar(200),
	@Released date,
	@Genre nvarchar(50),
	@Description nvarchar(2000)
AS
BEGIN
	IF NOT EXISTS(SELECT 1 FROM Genres WHERE Genre = @Genre)
		INSERT INTO Genres(Genre) VALUES (@Genre);

	UPDATE Movies
	SET Title = @Title, 
	Released = @Released,
	Genre_FK = (SELECT Id FROM Genres WHERE Genre = @Genre),
	[Description] = @Description
	WHERE Id = @Id

END;

