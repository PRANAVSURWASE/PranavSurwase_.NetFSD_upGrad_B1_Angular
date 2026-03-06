--Assignmet_6
select d.departmentName ,count(s.studentId) as totalStudents
from Students s 
join departments d 
on s.departmentId=d.departmentId
group by d.departmentName;

----------------------------------------------------------------
select ExamID,avg(marksObtained) as AvgMarks
from marks
group by examId;

---------------------------------------------------------------

select c.courseName ,count(e.studentId) as totalStudents
from courses c 
join Enrollments e 
on c.courseId = e.courseId
group by c.courseName;

---------------------------------------------------------------
select examId ,Max(marksObtained) as MaxMarks
from marks 
group by examId;

----------------------------------------------------------------
select c.courseName ,Min(marksObtained) as MinMarks 
from marks m 
join Exams e 
on m.ExamId = e.examId
join courses c 
on e.courseId = c.courseId
group by c.courseName;

------------------------------------------------------------------
select d.departmentName , count(s.studentId) as totalStudents
from students s 
join departments d
on s.departmentId = d.departmentId
group by d.DepartmentName
having count(s.studentId)>5;