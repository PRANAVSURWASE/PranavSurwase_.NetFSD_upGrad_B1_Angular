create view vw_StudentDepartment
as 
select
s.studentId,
s.firstname,
s.lastname,
d.departmentname,
s.admissionDate
from dbo.students s 
join dbo.departments d 
on s.departmentId = d.departmentId


select * from vw_StudentDepartment

select * from vw_StudentDepartment where DepartmentName='Computer Science'

DROP VIEW vw_StudentDepartment;



---------------------------------------------------------------------------


create view vw_StudentCourses
as
select
s.studentId,
s.firstName +' '+s.lastName as StudentName,
c.courseName,
e.enrollmentDate
from students s 
inner join enrollments e 
on s.studentId = e.studentId
inner join courses c 
on e.courseId = c.courseId

select * from vw_StudentCourses;

select * from vw_studentCourses where studentId =5;

select
studentName,
count(CourseName) as totalCourses
from 
vw_StudentCourses
group by studentName

select * from vw_StudentCourses where EnrollmentDate >'2024-01-01'




------------------------------------------------------------------------------
create view  vw_ExamResults
as 
select 
s.studentId,
s.firstName+' '+s.lastName as FullName,
c.courseName,
e.examType,
m.marksObtained
from marks m 
inner join students s 
on m.studentId = s.studentId
inner join exams e
on m.examId = e.examId
inner join courses c 
on e.courseId = c.courseId


select * from vw_ExamResults

select * from vw_ExamResults where MarksObtained>80;

SELECT *
FROM vw_ExamResults v1
WHERE MarksObtained =
(
    SELECT MAX(MarksObtained)
    FROM vw_ExamResults v2
    WHERE v1.ExamType = v2.ExamType
);


select
* from vw_ExamResults where MarksObtained <40 

---------------------------------------------------------------------------------

create view 
vw_DepartmentStudentCount
as 
select 
d.departmentName,
count(s.studentId) as totalStudent
from Departments d 
inner join Students s 
on d.DepartmentId = s.DepartmentId
group by d.DepartmentName

select * from vw_DepartmentStudentCount

select * from vw_DepartmentStudentCount where totalStudent>2

select * from vw_DepartmentStudentCount order by totalStudent DESC;