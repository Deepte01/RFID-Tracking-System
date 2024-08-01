CREATE PROCEDURE [dbo].[CheckTagProcedure]
				@tagID nchar(80)
AS
BEGIN
SET NOCOUNT ON
select      [FirstName]
           ,[LastName]
           ,[Role]
           ,[Title]
           ,[SpecialSeaDuty]
           ,[RescueStation]
		   ,[VerificationMuster]
		   ,[Emergency]
		   ,[Access]
		   ,[RfidTagId]
		   ,[FacialRecognition]
		   from [dbo].[main]
		   where  [RfidTagId] = @tagID

END