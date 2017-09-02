ALTER PROCEDURE [dbo].[pr_GetItemsByCategoryID]
	 @CategoryID int

AS
SELECT
	   [ID]
      ,[Name]
      ,[ExePath]
      ,[StartupDir]
      ,[IconPath]
      ,[Parameters]
      ,[CategoryID]
FROM [dbo].[tItems]
WHERE
	CASE
		WHEN @CategoryID = 0 THEN 1
		WHEN @CategoryID != 0 AND [CategoryID] = @CategoryID THEN 1
		ELSE 0
		END
	= 1
