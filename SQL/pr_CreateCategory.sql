ALTER PROCEDURE [dbo].[pr_CreateCategory]
	 @CategoryID int = NULL
	,@CategoryName nvarchar(50)

AS
INSERT [dbo].[tCategories] ([Name]) VALUES (@CategoryName)
SELECT SCOPE_IDENTITY() AS Result
