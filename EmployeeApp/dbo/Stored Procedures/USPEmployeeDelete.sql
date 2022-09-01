CREATE PROC USPEmployeeDelete(
@EmloyeeId UNIQUEIDENTIFIER
)
AS
BEGIN
SET NOCOUNT ON;
IF EXISTS (SELECT 1 FROM tblEmployee WHERE EmloyeeId = @EmloyeeId)
BEGIN
DELETE tblEmployee
WHERE EmloyeeId = @EmloyeeId
SELECT 'DELETED' AS 'Message'
END
ELSE
BEGIN
SELECT 'User not Fount ' AS 'Message'
END
END