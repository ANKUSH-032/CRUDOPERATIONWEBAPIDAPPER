CREATE PROC USPEMPLOYEEADD(
	   @FullName  VARCHAR(20)
     ,@Adderess   VARCHAR(50)
      ,@CompanyName   VARCHAR(20)
      ,@Designation   VARCHAR(20)
      ,@MobailNumber   VARCHAR(20)
      ,@Email   VARCHAR(20)
      ,@CreatedBy UNIQUEIDENTIFIER 
)
AS 
BEGIN

 SET NOCOUNT ON;
  IF NOT EXISTS (SELECT 1 FROM tblEmployee WHERE Email= @Email)
 BEGIN
 INSERT INTO tblEmployee 
 (
       FullName
      ,Adderess
      ,CompanyName
      ,Designation
      ,MobailNumber
      ,Email
      ,CreatedBy)VALUES (
      @FullName  
     ,@Adderess   
      ,@CompanyName   
      ,@Designation   
      ,@MobailNumber  
      ,@Email   
      ,@CreatedBy
      )
      SELECT 'Use Inserted Successfully ' as 'Message'
      END
      ELSE
      BEGIN
      SELECT 'User with same email id is already exists'+@Email as 'Message'
END
END