--Assignmet_5
select s.* 
from Students s
join Departments d 
on s.DepartmentId=d.DepartmentId
where d.DepartmentName='Computer Science';

select * from teachers 
where HireDate>'2022-01-01';

select * from teachers;

select * from students
where firstName like'A%';

select * from courses 
where credits>3;

select * from students
where DateOfBirth between'2005-01-01' AND '2008-12-31'

select * from students s 
join departments d 
on s.departmentId = d.departmentId
where d.departmentname<>'Mechanical'

select  * from Teachers
where salary between 40000 AND 70000;

select * from courses 
where  TeacherId<>3;

