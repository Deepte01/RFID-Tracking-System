CREATE PROCEDURE [dbo].[TrackProcedure]
AS
BEGIN
SET NOCOUNT ON
select      [Id],
            [FirstName]
           ,[LastName]
           ,[Role]
           ,[Title]
		   ,[CurrentLocation]
           ,[SpecialSeaDuty]
           ,[RescueStation]
		   ,[VerificationMuster]
		   ,[Emergency]
		   ,[Access]
		   ,[RfidTagId]
		   ,[LastSeenTime]
		   
		   from [dbo].[ship]

END