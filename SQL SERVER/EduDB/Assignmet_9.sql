--Assignmet_9

create view view_studentDepartment 
as select 
s.studentId,
s.firstName ,
s.lastName ,
d.departmentName
from students s 
join departments d 
on s.DepartmentId=d.DepartmentId;

DROP VIEW view_studentDepartment;


update view_studentDepartment
set FirstName ='Pranav',
lastName='Surwase'
where studentId=15;

select * from view_studentDepartment

-----------------------------------------------------------
create view view_stuCourseEnrollmennt
as
select
s.firstname + ' ' +s.lastname as Fullname,
c.coursename,
e.enrollmentDate
from students s 
inner join Enrollments e 
on s.studentid = e.studentid
join courses c 
on e.courseid= c.courseid;

select * from view_stuCourseEnrollmennt;

---------------------------------------------------------------------------

create view view_ExamResults
as
select
s.firstName,
s.lastName,
c.coursename,
e.examtype,
m.marksObtained
from students s
inner join marks m 
on s.studentid = m.studentid
 inner join exams e 
 on m.examid= e.examid
inner join courses c
on e.courseid =c.courseid


select * from view_ExamResults


DROP VIEW vw_StudentDepartment;

DROP VIEW vw_StudentCourseEnrollment;

DROP VIEW vw_ExamResults;