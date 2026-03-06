--assignment_8

select 
s.firstname,
s.lastName,
m.marksObtained
from marks m
inner join students s
on m.studentId = s.studentId
where MarksObtained>
(
 select AVG(marksObtained) from marks
);

----------------------------------------------------------
select
* from courses
where credits=
(
 select max(credits) from Courses
);
select * from courses;

---------------------------------------------------------------

select 
s.firstname,
s.lastname
from students s
where studentId IN
(
select studentId
from Enrollments
group by studentId
having count(courseId)>2
);

-----------------------------------------------------------------
select * 
from teachers
where departmentId =
(
select departmentId 
from teachers 
where fullname='jhon'

)

------------------------------------------------------------------
select s.firstname,
s.lastname,
m.marksObtained
from students s 
inner join marks m 
on s.studentId =m.studentId
where m.marksObtained=
(
 select max(marksObtained) from marks
)
--select * from marks
--select * from students;

--------------------------------------------------------------------

SELECT DepartmentId
FROM Students
GROUP BY DepartmentId
HAVING COUNT(StudentId) =
(
    SELECT MAX(StudentCount)
    FROM
    (
        SELECT COUNT(StudentId) AS StudentCount
        FROM Students
        GROUP BY DepartmentId
    ) AS DeptCount
);

