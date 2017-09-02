ALTER PROCEDURE [dbo].[pr_GetCategories]

AS

SELECT [ID], [Name]
FROM [dbo].[tCategories]
ORDER BY [ID]