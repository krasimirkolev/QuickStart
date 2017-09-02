ALTER PROCEDURE [dbo].[pr_InsertItem]
	 @ID int = NULL
	,@Name nvarchar(50)
	,@ExePath nvarchar(MAX)
	,@StartupDir nvarchar(MAX) = NULL
	,@IconPath nvarchar(MAX) = NULL
	,@Parameters nvarchar(50) = NULL
	,@CategoryID int = NULL

AS
INSERT [dbo].[tItems] ([Name], [ExePath], [StartupDir], [IconPath], [Parameters], [CategoryID])
			   VALUES (@Name,  @ExePath, @StartupDir,  @IconPath,  @Parameters,  @CategoryID)
SELECT SCOPE_IDENTITY() AS Result
