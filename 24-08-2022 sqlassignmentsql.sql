
/*Create a user defined function where you can calculate interest on a savings account with the formula pnr/100. 
If it is a checking account, calculate the interest as 5% on principal amount.*/

select * from AccountInformation;
alter table AccountInformation add  Interest float
update AccInfo set  AccType='Checking' where AccType='loan'
update AccInfo set  principal=8978899 where CustName='jyosh'
update AccInfo set  principal=67281 where CustName='Likitha'
update AccInfo set  CustName='Nischal' where AccNumber=43232187928329
delete from Accinfo where CustId=4 
create Table AccountInformation(
CustId int,
CustName varchar(30),
AccNumber bigint,
AccType  varchar(10),
Principal int
);
insert into AccountInformation values(1,'Likitha',23455627678,'Savings',6789)
insert into AccountInformation values(2,'jyoshna',68788388383,'Savings',7000)
insert into AccountInformation values(2,'jyoshna',68788388383,'Checking',78900)

create or alter function Accinformation(@acctype varchar(20))
returns @acc table(CustName varchar(30), AccType varchar(30), principal float) as
begin
declare @type varchar(30)
declare @p int
declare @n int
declare @r int
set @n=2;
set @r=5;
begin
insert into @acc
 select CustName, AccType, principal from AccountInformation where AccType=@acctype
 alter table @acc add Interest float
 end
 if(@AccType='Savings')
 begin
 update @acc set principal=(principal*@n*@r)/100;
 end
 if(@AccType='Checking')
 begin
 update @acc set principal=(principal*@n*5)/100;
 end
 return;
 end;

 drop table Accinfo
create or alter function Accinformation(@acctype varchar(20))
returns @acc table(CustName varchar(30), AccType varchar(30), principal float,Interest float) as
begin
declare @type varchar(30)
declare @p int
declare @n int
declare @r int
set @n=2;
set @r=5;
begin
insert into @acc
 select CustName, AccType, principal,Interest from AccountInformation where AccType=@acctype
 end
 if(@AccType='Savings')
 begin
 update @acc set Interest=(principal*@n*@r)/100;
 end
 if(@AccType='Checking')
 begin
 update @acc set Interest=(principal*@n*5)/100;
 end
 return;
 end;

select * from Accinformation('Savings')

 select * from Accinformation('Checking')




 /*REA a user defined function where all the employees with the 'manager' designation get a 10% increase in salary
and all employees with the 'developer' designation get a 5% increase in salary. Display all the results on screen*/
SELECT * FROM EmpInfo;

SELECT * FROM empsalary;

exec EmpInfo;

UPDATE EmpInfo SET Designation='manager' where BaseOffice='BNG'
 ALTER table EmpInfo RENAME column Salary to salary
UPDATE EmpInfo SET salary='37000' where BaseOffice='BNG'
update EmpInfo set column='salary' where col='Salary'

CREATE OR ALTER FUNCTION EMPLOYEESAL(@designation varchar(30))
RETURNS @emp table(EmpId int,EmpName varchar(30), Designation varchar(50),salary bigint) as
begin
declare @sal int
declare @desig varchar(30)
declare @salary int
begin 
insert into @emp 
select EmpId,EmpName, Designation,Salary from EmpInfo where Designation=@designation
end
if(@Designation= 'manager')
begin
UPDATE @emp SET Salary = Salary + (Salary * 10/100) 
end
if(@Designation='developer')
begin
UPDATE @emp SET Salary = Salary + (Salary * 5/100) 
end
return;

end
select * from EmpInfo
SELECT * from EMPLOYEESAL('manager')
SELECT * from EMPLOYEESAL('developer')

