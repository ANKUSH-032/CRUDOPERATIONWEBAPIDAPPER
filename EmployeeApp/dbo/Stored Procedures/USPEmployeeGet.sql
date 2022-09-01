CREATE PROC USPEmployeeGet
	(
	 @EmloyeeId UNIQUEIDENTIFIER
	)
	AS 
	BEGIN
	SET NOCOUNT ON;
	SELECT FullName
      ,Adderess
      ,CompanyName
      ,Designation
      ,MobailNumber
      ,Email
      ,Active
      ,CreatedOn
      ,CreatedBy
      ,DeletedOn
      ,DeletedBy
      ,UpdatedOn
      ,UpdatedBy
      FROM
      tblEmployee
      WHERE EmloyeeId= @EmloyeeId
	END