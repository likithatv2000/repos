
/* 1.From the following table, create a view to count the number of salespeople in each city. Return city, number of salespersons.*/

select * from Salesman;
Insert into Salesman Values(5001,'James Hoog','New York',0.15)
Insert into Salesman Values(5002,'Nail Kinte','paris',0.13)
Insert into Salesman Values(5005,'Pit Alex','London',0.11)
Insert into Salesman Values(5006,'Mc Lyon','Paris',0.14)
Insert into Salesman Values(5007,'Paul Adem','Rome',0.13)
Insert into Salesman Values(5003,'Lausen hen','San Jose',0.12)
use students;
go

create view salespeople AS 
SELECT city,COUNT(distinct salesman_id)as count_salespeople
FROM salesman
group by city;
go
 select * from salespeople


 /*2. From the following table, write a SQL query to select all the salespeople. Return salesman_id, name, city, commission with the percent sign (%). */

select Salesman_id,name,city,format(comission,'p')as comission_percent from salesman;

 /* 3.From the following tables, write a SQL query to find the number of goals scored by each team in each match during normal play. Return match number, country name and goal score.*/
select * from match_details

Insert into match_details values(1,'G',1207 ,'W','N',2,'',80016 ,160140)
Insert into match_details values(1,'G',1216 ,'L','N',1,'',80020 ,160348)
Insert into match_details values(2,'G',1201 ,'L','N',0,'',80003 ,160001)
Insert into match_details values(2,'G',1207 ,'W','N',1,'',80023 ,160463)
Insert into match_details values(3,'G',1214 ,'W','N',2,'',80031 ,160532)
Insert into match_details values(3,'G',1213 ,'L','N',1,'',80025 ,160392)
Insert into match_details values(4,'G',1206 ,'D','N',1,'',80008 ,160117)
Insert into match_details values(4,'G',1210 ,'D','N',1,'',80019 ,160369)
Insert into match_details values(5,'G',1211 ,'L','N',0,'',80011 ,160486)
Insert into match_details values(5,'G',1204 ,'W','N',1,'',80022 ,160071)
Insert into match_details values(6,'G',1213 ,'W','N',1,'',80036 ,160279)
Insert into match_details values(6,'G',1212 ,'L','N',0,'',80029 ,160256)
Insert into match_details values(7,'G',1208 ,'W','N',2,'',80014 ,160163)
Insert into match_details values(7,'G',1201 ,'L','N',0,'',80006 ,160508)
Insert into match_details values(8,'G',1205 ,'L','N',0,'',80012 ,160093)
Insert into match_details values(8,'G',1204 ,'L','N',0,'',80012 ,160093)
Insert into match_details values(9,'G',1214 ,'D','N',1,'',80017 ,160324)
Insert into match_details values(9,'G',1201 ,'D','N',1,'',80010 ,160439)
Insert into match_details values(10,'G',1203 ,'L','N',0,'',80004 ,160047)
Insert into match_details values(10,'G',1211 ,'W','N',2,'',80007 ,160231)
Insert into match_details values(11,'G',1202 ,'L','N',0,'',80026 ,160024)
Insert into match_details values(11,'G',1209 ,'W','N',2,'',80028 ,160187)
Insert into match_details values(12,'G',1214 ,'D','N',1,'',80009 ,160302)
Insert into match_details values(12,'G',1210 ,'D','N',1,'',80015 ,160208)

select * from soccer_country
Insert into soccer_country values(1201,'ALB','Albania')
Insert into soccer_country values(1202,'AUT','Austria')
Insert into soccer_country values(1203,'BEL','Belgium')
Insert into soccer_country values(1204,'CRO','Croatia')
Insert into soccer_country values(1205,'CZE','Czeh Rebublic')
Insert into soccer_country values(1206,'ENG','England')
Insert into soccer_country values(1207,'FRA','France')
Insert into soccer_country values(1208,'GER','Germany')
Insert into soccer_country values(1209,'HUN','Hungary')
Insert into soccer_country values(1210,'ISL','IceLand')
Insert into soccer_country values(1221,'IT','Italy')
Insert into soccer_country values(1212,'NIR','Northern Ireland')
Insert into soccer_country values(1213,'POL','Poland')
Insert into soccer_country values(1214,'POR','Portugal')


SELECT match_no,country_name,goal_score
FROM match_details a
JOIN soccer_country b
ON a.team_id=b.country_id
WHERE decided_by='N'
ORDER BY match_no;

/*4. Create a student database which has information about Students, their marks, courses, etc.
Display on screen the maximum marks, each student has obtained in each course, order it by course.*/

SELECT*  from Student_Exam

insert into Student_Exam values('Likitha',88,'C SHARP');
insert into Student_Exam values('Jyoshna',77,'AI');
insert into Student_Exam values('Mamatha',99,'ML');
insert into Student_Exam values('Jyoshna',88,'JAVA');
insert into Student_Exam values('Nischal',95,'PYTHON');
insert into Student_Exam values('Pooja',96,'C++');
insert into Student_Exam values('Davik',89,'RUBY');
insert into Student_Exam values('parikshith',86,'ABAP');
insert into Student_Exam values('Hemanth',98,'SAP ABAP');
insert into Student_Exam values('Prathibha',76,'SAP ABAP');
insert into Student_Exam values('Preetham',99,'ABAP OO');
  
delete from Student_Exam where Name='P';
delete from Student_Exam where Name='DAVID';
delete from Student_Exam where Name='CHRISMA';
delete from Student_Exam where Name='ZAK';
delete from Student_Exam where Name='JACK';
delete from Student_Exam where Name='ANTON';




select Name,Marks as Maximum_Mark,Subject from Student_Exam 
where Marks in (select max(Marks)  from Student_Exam 
group by Subject)
order by Subject;
