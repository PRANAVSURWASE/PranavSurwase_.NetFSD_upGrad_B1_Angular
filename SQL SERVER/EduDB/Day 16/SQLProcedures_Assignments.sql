create procedure sp_InsertStudents
@firstName varchar(20),
@LastName varchar(20),
@Gender check(Gender IN ('M','F')),
@DepartmentId INT,
@AdmissionDate DATE 
as 
BEGIN
Insert into students
(
 FirstName,
 LastName,
 Gender,
 DepartmentId,
 AdmissionDate
 
)
values
(
 @firstName,
 @lastName,
 @Gender,
 @DepartmentId,
 @AdmissionDate
)
end
go

select * from Departments

EXEC sp_InsertStudents 'Vaibhav','Jadhav','M',1,'2026-01-03'

select * from students
delete from students where studentId=23


-------------------------------------------------------------------------

create Procedure sp_GetStudentsByDepartment
@DepartmentId INT
as
 BEGIN
 select
 studentId,
 firstName+' '+lastName as StudentName,
 admissionDate 
 from students 
 where DepartmentId = @DepartmentId
 END
 GO

 exec sp_GetStudentsByDepartment 2
  exec sp_GetStudentsByDepartment 3

--------------------------------------------------------------------------------------

create procedure sp_EnrollStudent
@studentId INT,
@CourseId INT
as 
begin

insert into Enrollments
(
 studentId,
 CourseId,
 EnrollmentDate
)
values
( 
 @studentId,
 @CourseId,
 GETDATE()
)
end 
go

exec sp_EnrollStudent 17,10
select * from COurses

select * from Enrollments

SELECT * 
FROM dbo.Enrollments
ORDER BY EnrollmentId DESC;

---------------------------------------------------------------------------------------

create procedure sp_GetStudentMarks
@studentId INT
as 
Begin 
select 
s.firstName +' '+s.lastName as StudentName,
c.courseName,
e.examType,
m.marksObtained
from students s 
inner join marks m 
on s.studentId = m.studentId
inner join exams e 
on m.examId = e.examId
inner join courses c 
on e.courseId = c.courseId
where s.studentId = @studentId
end 
go
exec sp_GetStudentMarks 15
select * from students


-------------------------------------------------------------------------------------------------------------------------------------

create procedure sp_UpdateMarks
@markId INT,
@NewMarks INT
as 
Begin

update marks 
set MarksObtained=@NewMarks
where MarkId =@markId

select * from Marks 
where markId = @markId

end 
go

select * from marks
exec sp_UpdateMarks  15,85

------------------------------------------------------------------------------

create procedure sp_DeleteEnrollment
@EnrollmentId INT
as 
BEGIN

delete from Enrollments
where EnrollmentID = @EnrollmentId;

select * from 
Enrollments where EnrollmentId = @EnrollmentId

END 
GO

select * from Enrollments 
exec sp_DeleteEnrollment 1