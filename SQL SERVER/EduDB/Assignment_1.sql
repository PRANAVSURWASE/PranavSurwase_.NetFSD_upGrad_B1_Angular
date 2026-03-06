use EduDB;
create table Departments(
DepartmentId INT PRIMARY KEY IDENTITY(1,1),
DepartmentName VARCHAR(100) NOT NULL,
Location VARCHAR(100)
);

------Teacher table
create table Teachers
(
 TeacherId INT PRIMARY KEY IDENTITY(1,1),
 TeacherName VARCHAR(100) NOT NULL,
 Email varchar(100) unique,
 DepartmentId INT,
 HireDate Date,

 foreign key (DepartmentId)
 References Departments(DepartmentId)

);

-----Students Table
create table Students
(
 StudentId INT PRIMARY KEY IDENTITY(1,1),
 FirstName varchar(50),
 LastName varchar(50),
 DateOfBirth DATE,
 Gender varchar(10),
 DepartmentId INT,
 AdmissionDate Date,

 FOREIGN KEY(DEPARTMENTID)
 REFERENCES Departments(DepartmentID)
)

--Courses

create table Courses
(
 CourseId INT PRIMARY KEY Identity(1,1),
 CourseName Varchar(100),
 Credits INT,
 DepartmentId INT,
 TeacherID INT,

 Foreign key (DepartmentId)
 references Departments(DepartmentId),

 foreign key(TeacherId)
 references Teachers(TeacherId)
)

--Enrollment Table

create table Enrollments
(
EnrollmentID INT PRIMARY KEY IDENTITY(1,1),
StudentId INT,
CourseId INT,
EnrollmentDate DATE,

Foreign key (StudentId)
references Students(StudentId),

foreign key(CourseId)
references Courses(CourseId)
)

--Exams 
create table Exams
( 
ExamId INT Primary key Identity(1,1),
CourseId INT,
ExamDate DATE,
ExamType Varchar(50),

foreign key(CourseId)
references Courses(CourseId)
)

--Marks 
create table Marks 
(
 MarkId INT PRIMARY KEY IDENTITY(1,1),
 StudentId INT,
 ExamId INT,
 MarksObtained INT,

 FOREIGN kEY(StudentId)
 references Students(StudentId),

 Foreign key(ExamId)
 REferences Exams(ExamID)
)


-----------------------------------
