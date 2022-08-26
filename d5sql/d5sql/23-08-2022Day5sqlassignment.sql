/* Write a C# program to get a list of values from the user. (Passport information: passport number, candidate name, passport expiry date, 
years of validity, applied through channel (Normal, Priority),etc) 
for atleast 10 candidates. Create a table and upload this information to the table using a Stored Procedure.*/

create table Pass_Info(
Passport_Number  int,
Name varchar(50),
ExpiryDate  date,
Validity  int,
Channel  varchar(20));


create or alter procedure PassInfo @Passport_Number int, @Name varchar(40), @ExpiryDate date, @validity int, @Channel varchar(20) as
insert into  Pass_Info values(@Passport_Number,@Name, @ExpiryDate, @validity, @Channel)
 
 
 Exec PassInfo 787879,'Likitha','2022-12-23',10,'Online';
 exec PassInfo
select * from Pass_Info;
/*
insert into Pass_Info values(224883,'Likitha','2030-09-23',10,'Normal')
insert into Pass_Info values(789456,'Jyoshna','2040-12-13',5,'Priority')
insert into Pass_Info values(123546,'Nithin','2027-10-15',7,'Normal')
insert into Pass_Info values(453217,'Sanvith','2026-08-25',10,'Priority')
insert into Pass_Info values(231469,'Sharanya','2030-07-22',1,'Normal')
insert into Pass_Info values(673251,'Mamatha','2045-12-29',3,'Priority')
insert into Pass_Info values(901243,'Jyoshna','2046-08-30',4,'Normal')
insert into Pass_Info values(983589,'Shreyas','2023-07-07',7,'Priority')
insert into Pass_Info values(975327,'Shreya B','2036-09-03',8,'Normal')
insert into Pass_Info values(164358,'Tejaswini','2028-05-02',9,'Priority')
insert into Pass_Info values(693278,'Sahana','2028-09-06',1,'Normal')
*/



/*Write a C# program to display students information (Name, Age, Sex, Course, Year of Study, etc). Ask the Year of study from the user and display only those students (If the user enters 1, only show first year students.)
Use Stored Procedure for:
Creating a table with all the information,
Displaying all the information,
Showing the year of study students according to the user input.*/
create or alter procedure studentinformation as
create table student_info(
StuName varchar(50),
Age int,
Sex varchar(20),
Course varchar(50),
Year_Of_study int);
exec studentinformation;
select * from student_info
insert into student_info values('Likitha',22,'Female','ISE',2022)

select * from student_info where Year_Of_study=2022
exec studentinformation 2000







