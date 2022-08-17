select * from Salesman;
Insert into Salesman Values(5001,'James Hoog','New York',0.15)
Insert into Salesman Values(5002,'Nail Kinte','paris',0.13)
Insert into Salesman Values(5005,'Pit Alex','London',0.11)
Insert into Salesman Values(5006,'Mc Lyon','Paris',0.14)
Insert into Salesman Values(5007,'Paul Adem','Rome',0.13)
Insert into Salesman Values(5003,'Lausen hen','San Jose',0.12)
select * from salesman where comission  between 0.12 and 0.14;



select * from orders;
Insert into orders values(70001,150.5,'2012-10-05', 3005 ,5002)
Insert into orders values(70009, 270.65,'2012-09-10 ',3001, 5005)
Insert into orders values(70002, 65.26, '2012-10-05',3002, 5001)
Insert into orders values(70004, 110.5, '2012-08-17', 3009, 5003)
Insert into orders values(70007, 948.5, '2012-09-10', 3005, 5002)
Insert into orders values(70005, 2400.6, '2012-07-27',3007, 5001)
Insert into orders values(70008, 5760,  '2012-09-10', 3002, 5001)
Insert into orders values(70010, 1983.43, '2012-10-10',3004,5006)
Insert into orders values(70003, 2480.4,  '2012-10-10', 3009, 5003)
Insert into orders values(70012, 250.45,  '2012-06-27', 3008, 5002)
Insert into orders values(70011, 75.29,   '2012-08-17',3003, 5007)
Insert into orders values(70013, 3045.6,  '2012-04-25',3002, 5001)

select * from orders where purch_amt between 500 and 4000 
AND purch_amt not IN(948.50, 1983.43);


select* from TotalValue;
Insert into TotalValue values('A001/DJ-402\44_/100/2015');
insert into totalValue values('A001_\DJ-402\44_/100/2015');
insert into totalValue values('A001_DJ-402-2014-2015');
insert into totalValue values('A002_DJ-401-2014-2015');
insert into totalValue values('A001/DJ_401');
insert into totalValue values('A001/DJ_402\44');
insert into totalValue values('A001/DJ_402\44\2015');
insert into totalValue values('A001/DJ-402%45\2015/200');
insert into totalValue values('A001/DJ_402\45\2015%100');
insert into totalValue values('A001/DJ_402%45\2015/300');
insert into totalValue values('A001/DJ-402\44');

select * from TotalValue where TotalValue not like '%/_%';