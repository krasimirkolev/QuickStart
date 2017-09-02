ALTER PROCEDURE [dbo].[pr_UpdateItem]
	 @ID int
	,@Name nvarchar(50)
	,@ExePath nvarchar(MAX)
	,@StartupDir nvarchar(MAX) = NULL
	,@IconPath nvarchar(MAX) = NULL
	,@Parameters nvarchar(50) = NULL
	,@CategoryID int = NULL

AS
UPDATE [dbo].[tItems]
SET  [Name] = @Name
	,[ExePath] = @ExePath
	,[StartupDir] = @StartupDir
	,[IconPath] = @IconPath
	,[Parameters] = @Parameters
	,[CategoryID] = @CategoryID
WHERE [ID] = @ID
