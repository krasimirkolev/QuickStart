ALTER PROCEDURE [dbo].[pr_DeleteCategory]
	 @ID int

AS
DELETE FROM [dbo].[tCategories] WHERE [ID] = @ID
UPDATE [dbo].[tItems] SET [CategoryID] = 0 WHERE [CategoryID] = @ID
