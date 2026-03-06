--Assignment_3
ALTER TABLE Students
ADD PhoneNumber VARCHAR(15);

ALTER TABLE Teachers
ADD Salary INT;

ALTER TABLE Teachers
ALTER COLUMN Salary DECIMAL(10,2);

alter table teachers
add constraint CHK_Teachers_Salary
check(salary>20000)

alter table students
drop column phoneNumber

EXEC sp_rename
'Teachers.TeacherName',
'FullName',
'COLUMN';

