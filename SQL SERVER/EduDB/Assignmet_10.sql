--Assignmet_10

create index IX_Student_lastName on students(lastName)

create index IX_Teacher_Email on teachers(email);

CREATE INDEX IX_Enrollments_Student_Course
ON Enrollments(StudentId, CourseId);

create unique index idx_departmentName
on departments(departmentName)

drop index IX_Student_LastName on  students