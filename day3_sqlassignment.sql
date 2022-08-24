/* From an orders table, fetch the maximum purchase amount a salesman has made in the last 6 months. Also, index the table based on order id.
*/
use students
select * from orders;

/*SELECT customer_id,MAX(purch_amt) 
FROM orders 
GROUP BY customer_id;

create index Orderndex on orders(ord_no);
select * from orders;
*/

insert into orders values(70014,5788.56,'2012-07-13',3009,5001);
insert into orders values(70015,789.67,'2012-08-13',3008,5004);
insert into orders values(70016, 37.56,'2022-07-12',3009,5001);
insert into orders values(70017,68.90,'2022-08-13',3005,5002);

SELECT MAX(purch_amt) AS Maxium_PurchasedAmount FROM orders
where datediff(month, ord_date, getdate()) between 0 and 6;

CREATE INDEX order_information ON orders (ord_no);   

/*Use CTE to fetch the employee salary, employee name, etc and display the salaries higher than 45000. (edited) 
 */
 select * from EmpInfo;
  select * from empsalary;

 WITH Emp_salary(EmpSalary,EmpName,Designation) as( 
(select s.EmpSalary,e.EmpName, e.Designation from empsalary s,EmpInfo e where s.EmpId=e.EmpId and EmpSalary>45000))
select EmpSalary,EmpName,Designation from Emp_salary where EmpSalary>45000;







