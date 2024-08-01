CREATE PROCEDURE [dbo].[GenerateWSBProcedure]
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
		   from [dbo].[ship]

END