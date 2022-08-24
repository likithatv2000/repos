/*Create a Stored Procedure to show only the Employees working on C# in the base location of Bangalore. Display the result set with Employee ID, Name, Working Language and Base Location. */
use students;

create or alter procedure baselocation @location varchar(50) as
select EmpId, EmpName, Designation, BaseOffice from EmpInfo where Designation=@location;
exec baselocation C#
 drop procedure baselocation
update EmpInfo set Designation='C#' where BaseOffice='Maharastra'

/*output
5	Marry	C#	Maharastra
33	Mamatha 	C#	Maharastra
44	Rohith	C#	Maharastra
56	Supriya 	C#	Maharastra
66	Rajath	C#	Maharastra
67	Likith 	C#	Maharastra
78	Nischal 	C#	Maharastra */

/*Create a Stored Procedure to calculate total marks and display ranks of students accordingly. Have atleast 10 students in the result set. Total marks should include marks from 
Maths, Economics, Commerce, English and Computer Science. */

create procedure StudentMarks as
create table Student_Marks(
Roll_No int,
StudentName varchar(50),
Maths int,
Economics int,
Commerce int,
English int,
ComputerScience int);
exec StudentMarks;
select * from Student_Marks
Insert into Student_Marks values(1,'Likitha',97,89,90,99,79);
Insert into Student_Marks values(2,'Nikhil',77,65,78,56,35);
Insert into Student_Marks values(3,'Jyoshna',93,81,78,76,75);
Insert into Student_Marks values(4,'Mounika',47,29,70,59,69);
Insert into Student_Marks values(5,'Naveen',78,80,40,49,29);
Insert into Student_Marks values(6,'Sujay',67,56,39,69,59);
Insert into Student_Marks values(7,'Sowjanya',38,29,58,45,27);
Insert into Student_Marks values(8,'Nazma',47,59,80,89,69);
Insert into Student_Marks values(9,'Manasa',67,39,40,09,29);
Insert into Student_Marks values(10,'Niranjan',37,23,44,69,29);
Insert into Student_Marks values(11,'Harini',57,59,20,79,89);
Insert into Student_Marks values(12,'Varun',67,86,67,89,69);

select *,sum(Maths+Economics+Commerce+English+ComputerScience) as Total_Marks,rank() over( order by  Maths+Economics+Commerce+English+ComputerScience DESC)as Rank from Student_Marks 
group by Roll_no,StudentName,Maths,Economics,Commerce,English,ComputerScience


/*
1	Likitha	97	89	90	99	79	454	1
3	Jyoshna	93	81	78	76	75	403	2
12	Varun	67	86	67	89	69	378	3
8	Nazma	47	59	80	89	69	344	4
2	Nikhil	77	65	78	56	35	311	5
11	Harini	57	59	20	79	89	304	6
6	Sujay	67	56	39	69	59	290	7
5	Naveen	78	80	40	49	29	276	8
4	Mounika	47	29	70	59	69	274	9
10	Niranjan	37	23	44	69	29	202	10
7	Sowjanya	38	29	58	45	27	197	11
9	Manasa	67	39	40	9	29	184	12
*/




