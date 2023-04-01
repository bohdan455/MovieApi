CREATE PROCEDURE [dbo].[spMovie_GetAllMovies]
AS
BEGIN
	SELECT Movies.Id as Id,Title,Released,Genre,[Description]
	FROM Movies
	LEFT JOIN Genres
	ON Genre_FK = Genres.Id
END
 