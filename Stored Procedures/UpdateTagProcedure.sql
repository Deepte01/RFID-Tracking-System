CREATE PROCEDURE [dbo].[UpdateTagProcedure]
	@tagID nchar(80),
	@TagLocation nchar(30)
	


AS
BEGIN
SET NOCOUNT ON
	
	update [dbo].[ship] 
	set [CurrentLocation] =CASE WHEN @TagLocation =1 THEN 'Bridge' WHEN @TagLocation =2 THEN 'Ops Room' WHEN @TagLocation = 3 THEN 'Mess' WHEN @TagLocation =4 THEN 'Engine Room' END
	where RfidTagId = @tagID

END