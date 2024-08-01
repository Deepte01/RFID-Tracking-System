CREATE PROCEDURE [dbo].[RoomCountProcedure]
AS
BEGIN
SET NOCOUNT ON
SELECT
  name = ISNULL(currentLocation, 'Total')  ,
  count = count(currentLocation)
FROM ship
GROUP BY ROLLUP(currentLocation)

END