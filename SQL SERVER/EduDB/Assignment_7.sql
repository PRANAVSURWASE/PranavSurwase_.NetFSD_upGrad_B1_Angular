--Assignmet_7

select
s.studentId,
s.Firstname,
s.lastName,
d.departmentName
from students s 
Inner join departments d 
on s.DepartmentId= d.departmentId;

--------------------------------------------------

select c.courseName,t.FullName
from courses c 
Inner join teachers t 
on c.teacherId = t.teacherId;

----------------------------------------------------------
select s.firstName,
s.lastName,
c.courseName 
from Students s 
inner join Enrollments e
on s.studentId = e.studentId
inner join courses c 
on e.CourseId = c.CourseId;

-----------------------------------------------------------------
select 
s.firstName,
s.lastName,
m.marksObtained,
e.examType
from students s 
inner join marks m 
on s.studentId = m.studentId
inner join exams e 
on m.examId = e.examId;


----------------------------------------------------------------
select 
c.courseName,
t.fullname
from courses c 
left join teachers t 
on c.teacherId = t.teacherId;

select * from courses;
select * from teachers;

--------------------------------------------------------------------
select 
t.FullName,
c.courseName
from Teachers t 
left join courses c 
on t.teacherId =  c.teacherId
where c.courseId is NULL;

