ALTER PROCEDURE [dbo].[pr_UpdateCategory]
	 @CategoryID int
	,@CategoryName nvarchar(50)

AS
UPDATE [dbo].[tCategories] SET [Name] = @CategoryName WHERE [ID] = @CategoryID
