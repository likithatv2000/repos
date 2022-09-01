/*.Write a C# program to display Account details and Customer information of users (Account number, Customer name, Aadhar number, 
Account opened date, date of last transaction, etc)
whose account balance is greater than 200000. Pull information from 2 tables, Use UDF and display information on screen.*/
select * from AccountInformation;
select * from AccInfo1;
create table AccInfo1(
AccNum bigint,
CusName varchar(20),
Aadhar bigint,
Opendate date,
Lasttrans date,
Balance int);
drop table AccInfo1

Insert into AccInfo1 values(5623843287328,'Likitha',467646788956,'2022-08-25','2021-08-25',73883)
Insert into AccInfo1 values(6734858590020,'niranjan',789045672345,'2022-06-29','2029-09-22',1000)

create or alter function AccDetails(@balance int) 
returns @accounts table(AccNum bigint,CusName varchar(20),Aadhar bigint,Opendate date,Lasttrans date,Balance int)as
begin
insert into @accounts 
select AccNum,CusName,Aadhar,Opendate,Lasttrans,Balance from AccInfo1 where Balance>@balance;
return
end
select * from AccDetails('10000')

