CREATE PROCEDURE [dbo].[EmergencyProcedure]
AS
BEGIN
SET NOCOUNT ON
select      [Id]
           ,[Alert]
           ,[Location]
           ,[start_time]
           ,[end_time]

		   from [dbo].[EmergencyInfo]

END