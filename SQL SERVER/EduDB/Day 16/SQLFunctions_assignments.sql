create Function fn_GetGrade
(
 @MarksObtained INT
)
returns varchar(10)
as 
begin
DECLARE @Grade varchar(10)

if @marksObtained >=90
set @grade ='A'

else if @marksObtained >=75
set @Grade = 'B'
-
else if @marksObtained >=60
set @Grade ='c'

else 
set @grade ='Fail'

RETURN @grade

End

select dbo.fn_GetGrade(73)

---------------------------------------------------------------------------

create function fn_GetStudentAge
(
 @DateOfBirth DATE
)
returns INT
as
begin
Declare @age int 

set @age = DateDiff(YEAR,@DateOfBirth,GetDate())

return @age

end

select dbo.fn_GetStudentAge('2002-05-18') as Age

-----------------------------------------------------------------------

create function fn_GetTotalMarks
( 
 @StudentId int
)
returns INT
as
BEGIN
Declare @totalMarks INT

select @totalMarks = sum(marksObtained) from marks
where studentId=@studentId

RETURn @TotalMarks

END

select dbo.fn_GetTotalMarks(15)

------------------------------------------------------------------------------
create function fn_GetStudentCourses
(
 @studentId int 

)
returns Table
as 
return
(
 select 
 c.courseName,
 e.enrollmentDate 
 from courses c 
 inner join Enrollments e
 on c.courseId = e.courseId
 where E.StudentId=@studentID

)

select * from dbo.fn_getStudentCourses(15)

---------------------------------------------------------------------------------------
create function fn_GetDepartmentStudents
(
 @DepartmentId int
)
returns table
as
return 
(
 select 
 studentId,
 firstName +' '+lastName as studentName,
 admissionDate
 from students 
 where DepartmentId = @DepartmentId

)

select * from  dbo.fn_GetDepartmentStudents(1)


