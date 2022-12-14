﻿GO 
CREATE PROCEDURE [dbo].sp_UpdateEmployee
	@p_empid int,
	@p_fname nvarchar(10),
	@p_lname  nvarchar(20),
	@p_title nvarchar(30),
	@p_birthdate datetime

AS
	update Employees
	set FirstName=@p_fname,
	LastName=@p_lname,
	Title=@p_title,
	BirthDate=@p_birthdate
	where EmployeeID=@p_empid;
RETURN 0
G