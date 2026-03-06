--Assignment_2
ALTER TABLE Departments
ADD CONSTRAINT UQ_Departments_Name
UNIQUE (DepartmentName);

ALTER TABLE Students
ADD CONSTRAINT CHK_Students_Gender
CHECK (Gender IN ('M','F'));

ALTER TABLE Courses
ADD CONSTRAINT CHK_Courses_Credits
CHECK (Credits BETWEEN 1 AND 5);

ALTER TABLE Marks
ADD CONSTRAINT CHK_Marks_Range
CHECK (MarksObtained BETWEEN 0 AND 100);

ALTER TABLE Enrollments
ADD CONSTRAINT DF_Enrollment_Date
DEFAULT GETDATE() FOR EnrollmentDate;

