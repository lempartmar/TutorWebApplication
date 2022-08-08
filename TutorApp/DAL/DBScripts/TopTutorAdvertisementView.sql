
CREATE VIEW [dbo].[TopTutorAdvertisementAbove100] AS

SELECT tut.Name, SUM(adv.Value) AS SUMA
	FROM dbo.Advertisement adv
	JOIN dbo.Tutors tut ON tut.Id = adv.TutorId
GROUP BY tut.Name
HAVING SUM(adv.Value) > 100