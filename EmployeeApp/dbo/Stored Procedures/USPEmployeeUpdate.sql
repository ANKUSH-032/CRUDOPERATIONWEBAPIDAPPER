CREATE PROC USPEmployeeUpdate(
@EmloyeeId  UNIQUEIDENTIFIER 
	,@FullName VARCHAR(20)
      ,@Adderess VARCHAR(20)
      ,@CompanyName VARCHAR(20)
      ,@Designation VARCHAR(20)
      ,@MobailNumber VARCHAR(20)
      ,@Email VARCHAR(20)
      ,@Active BIT
      ,@UpdatedBy UNIQUEIDENTIFIER
)
AS
BEGIN
SET NOCOUNT ON;

IF  EXISTS (SELECT 1 FROM tblEmployee WHERE EmloyeeId= @EmloyeeId)

BEGIN
	UPDATE tblEmployee
	SET 
	FullName=@FullName
      ,Adderess=@Adderess 
      ,CompanyName=@CompanyName 
      ,Designation=@Designation 
      ,MobailNumber=@MobailNumber 
      ,Email =@Email 
      ,Active=@Active 
      ,UpdatedBy=@UpdatedBy
      
      WHERE EmloyeeId= @EmloyeeId
      SELECT 'UPDATED' AS 'Message'
	
END
ELSE
BEGIN
SELECT 'User not Fount' AS 'Message'
END
END