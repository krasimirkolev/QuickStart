ALTER PROCEDURE [dbo].[pr_DeleteItem]
	 @ID int

AS
DELETE FROM [dbo].[tItems] WHERE [ID] = @ID
