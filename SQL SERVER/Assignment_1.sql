use assignment_1;

INSERT INTO Worker
(FIRST_NAME, LAST_NAME, SALARY, JOINING_DATE, DEPARTMENT)
VALUES
('Monika','Arora',100000,'2014-02-20 09:00:00','HR'),
('Niharika','Verma',80000,'2014-06-11 09:00:00','Admin'),
('Vishal','Singhal',300000,'2014-02-20 09:00:00','HR'),
('Amitabh','Singh',500000,'2014-02-20 09:00:00','Admin'),
('Vivek','Bhati',500000,'2014-06-11 09:00:00','Admin'),
('Vipul','Diwan',200000,'2014-06-11 09:00:00','Account'),
('Satish','Kumar',75000,'2014-01-20 09:00:00','Account'),
('Geetika','Chauhan',90000,'2014-04-11 09:00:00','Admin');

select * from Worker;

INSERT INTO Bonus
(WORKER_REF_ID, BONUS_DATE, BONUS_AMOUNT)
VALUES
(1,'2016-02-20 00:00:00',5000),
(2,'2016-06-11 00:00:00',3000),
(3,'2016-02-20 00:00:00',4000),
(1,'2016-02-20 00:00:00',4500),
(2,'2016-06-11 00:00:00',3500);

select * from Bonus;

INSERT INTO Title
(WORKER_REF_ID, WORKER_TITLE, AFFECTED_FROM)
VALUES
(1,'Manager','2016-02-20 00:00:00'),
(2,'Executive','2016-06-11 00:00:00'),
(8,'Executive','2016-06-11 00:00:00'),
(5,'Manager','2016-06-11 00:00:00'),
(4,'Asst. Manager','2016-06-11 00:00:00'),
(7,'Executive','2016-06-11 00:00:00'),
(6,'Lead','2016-06-11 00:00:00'),
(3,'Lead','2016-06-11 00:00:00');

select * from title;

--1
select first_name as Worker_name from Worker ;

--2
select upper(first_name) as FIRST_NAME from Worker;

--3
select distinct department from worker;

--4
select substring(First_name,1,3) as First_three_char from Worker;

--5
select CHARINDEX('a','Amitabh') as position; 

--6
select RTRIM(First_Name) from Worker;

--7
select LTRIM (Department) from worker;

--8
select Distinct Department ,len(Department) as length from Worker;

--9
select Replace(first_name,'a','A') as First_Name from Worker;

--10
select First_Name+' '+Last_Name as Complete_Name from Worker;

--11
select * from Worker order by First_Name ASC;

--12
select * from Worker order by first_name ASC,Department DESC;

--13
select * from Worker where First_name in('vipul','satish');

--14
select * from Worker where First_name not in('vipul','satish');

--15
select * from Worker where Department='Admin'

--16
select * from worker where first_name like'%a%';

--17
select * from worker where first_name like'%a';

--18
select * from worker where first_name like '_____h';

--19
select * from worker where salary between 100000 AND 500000

--20
select * from worker where month(Joining_date) =2 AND year(joining_date)=2014;

--21
select first_name ,salary from worker where salary between 50000 AND 100000;

--22
select department ,count(*) as total_workers from worker Group by department order by total_workers DESC;

--23

--24
select GETDATE() as CURRENT_DATE_TIME;

--25

select TOP 10* from worker;
