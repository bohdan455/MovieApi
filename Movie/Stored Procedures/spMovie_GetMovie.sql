CREATE PROCEDURE [dbo].[spMovie_GetMovie]
	@Id int
AS
BEGIN
	SELECT Movies.Id as Id,Title,Released,Genre,[Description]
	FROM Movies
	LEFT JOIN Genres
	ON Movies.Genre_FK = Genres.Id
	WHERE Movies.Id = @Id;
END
