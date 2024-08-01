CREATE PROCEDURE [dbo].[InsertProcedureMain]
	@FirstName nchar(10),
	@LastName nchar(10),
	@Role nchar(10),
	@Title nchar(10),
	@SpecialSeaDuty nchar(10),
	@RescueStation nchar(10),
	@VerificationMuster nchar(10),
	@Emergency nchar(10),
	@Access nchar(10),
	@RfidTagId nchar(80),
	@FacialRecognition binary(50)
	


AS
BEGIN
SET NOCOUNT ON
	
	INSERT INTO [dbo].[main]
           ([FirstName]
           ,[LastName]
           ,[Role]
           ,[Title]
           ,[SpecialSeaDuty]
           ,[RescueStation]
		   ,[VerificationMuster]
		   ,[Emergency]
		   ,[Access]
		   ,[RfidTagId]
		   ,[FacialRecognition])
		  
     VALUES
           (@FirstName
           ,@LastName
           ,@Role,
		   @Title,
		   @SpecialSeaDuty,
		   @RescueStation,
		   @VerificationMuster,
		   @Emergency,
		   @Access,
		   @RfidTagId,
		   @FacialRecognition
		 
			)

END