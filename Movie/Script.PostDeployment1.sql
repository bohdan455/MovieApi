IF NOT EXISTS (SELECT 1 FROM Genres)
BEGIN
	INSERT INTO Genres(Genre)
	VALUES ('Science fiction'),('Action'),('Drama'),('Horror');
END