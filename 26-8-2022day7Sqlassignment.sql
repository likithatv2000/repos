select * from Student_Exam;
select * from student_info;
select * from Student_Marks;
/*answer1*/
create or alter procedure Stu_less @tot int as
begin
select * ,sum(Maths+Economics+Commerce+English+ComputerScience) as Total_Marks from Student_Marks where @tot>Maths+Economics+Commerce+English+ComputerScience
group by Roll_no,StudentName,Maths,Economics,Commerce,English,ComputerScience 
end
 exec Stu_less   311

create or alter procedure Stu_tot @stdId int as
begin
declare @total int=(select  Maths+Economics+Commerce+English+ComputerScience as total from Student_Marks where Roll_No=@stdId)
exec  stu_less  @total
end

exec Stu_tot 4


/*answer3*/
/*existing table*/
select * from orders;
select * from salesman;

create or alter function answer3(@city varchar(30))
returns @sales table(purch_amt float, city varchar(20))as
begin
insert into @sales
select o.purch_amt, s.city from orders o,salesman s where o.salesman_id=s.Salesman_id and s.city=@city
return;
end
select * from answer3('paris');

drop function answer3


create or alter function answer2()
returns float as
begin
declare @average  int
select @average=avg(purch_amt) from  students.dbo.answer3('London')
return @average;
end
select students.dbo.answer2();

select students.dbo.answer2()


/*new table*/
create table Sales(
AreaName varchar(30),
m1 int,
m2 int,
m3 int,
m4 int,
m5 int,
)

select * from Sales;

insert into Sales values('Banglore',1250,2340,1570,2578,3768)
insert into Sales values('Delhi',5679,2800,1500,2900,9000)
insert into Sales values('Pune',3780,200,1780,2900,9870)
insert into Sales values('Banglore',9600,15600,2900,5700,300)
insert into Sales values('Delhi',1000,2000,2500,2500,3500)
insert into Sales values('Pune',9000,1900,2670,590,330)


create or alter function salesreport(@region varchar(30))
returns int as
begin
declare @total int
select  @total = (m1+m2+m3+m4+m5) from Sales where  AreaName = @region;
return @total
end

select students.dbo.salesreport('Delhi');


create or alter function salesreportaverage(@region varchar(30))
returns int as
begin
declare @Average int
select @Average =(select students.dbo.salesreport(@region))/5;
return @Average;
end

select students.dbo.salesreportaverage('Pune');


/*answer2*/


--question2

select * from AccInfo1;
select * from AccountInformation;

create or alter procedure ROI @ACCTYPE varchar(30) as
DECLARE @SETROI Int
IF(@ACCTYPE = 'SAVINGS') SET @SETROI = 5;
IF(@ACCTYPE = 'CURRENT') SET @SETROI = 6;
select * from CalInterest(@SETROI,@ACCTYPE);


exec ROI 'SAVINGS';

select * Into AccountDetails1 from AccountDetails;
select * from AccountDetails1;
ALTER TABLE AccountDetails1
ADD Interest float;

CREATE or alter FUNCTION CalInterest(@ROI INT,@ACCTYPE VARCHAR(30))  
RETURNS @CalulateInterest TABLE  
(AccountType varchar(50),AccountBalance float,Interest float)  
AS  
BEGIN  
insert into @CalulateInterest 
            
            select AccType,Principal,Interest from AccountInformation
			update @CalulateInterest SET Interest=(AccountBalance*@ROI)/100	WHERE AccountType=@ACCTYPE;
					
RETURN   
END 

select * from CalInterest(8,'SAVINGS') as result;