IF OBJECT_ID('dbo.TutorKeywordTable1') IS NOT NULL

BEGIN
	DROP PROCEDURE dbo.TutorKeywordTable1;
END

GO

CREATE PROCEDURE [dbo].[TutorKeywordTable1]

AS
SELECT * FROM dbo.Tutor;
GO