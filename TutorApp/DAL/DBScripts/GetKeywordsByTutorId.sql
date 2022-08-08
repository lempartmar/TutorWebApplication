DROP PROCEDURE [dbo].[GetKeywordsByTutorId]
GO

CREATE PROCEDURE [dbo].[GetKeywordsByTutorId] @TutorId bigint
AS
	SELECT tut.Name, tut.Surname , tut.Id, tut_keyw.KeywordId, keyw.Keyword_Text
	FROM dbo.Tutors tut
	INNER JOIN dbo.TutorKeyword tut_keyw ON tut.Id = tut_keyw.TutorId
	INNER JOIN dbo.Keywords keyw ON keyw.Id = tut_keyw.KeywordId
	WHERE tut.Id = @TutorId;
GO


