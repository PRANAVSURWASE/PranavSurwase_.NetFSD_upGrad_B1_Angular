--Assignmet_4

INSERT INTO Departments (DepartmentName, Location) VALUES
('Computer Science','Block A'),
('Mechanical','Block B'),
('Electrical','Block C'),
('Civil','Block D'),
('Information Technology','Block E');

INSERT INTO Teachers (FullName, Email, DepartmentId, HireDate, Salary) VALUES
('Rajesh Sharma','rajesh@school.com',1,'2018-06-10',45000),
('Anita Verma','anita@school.com',1,'2019-07-12',42000),
('Suresh Patil','suresh@school.com',2,'2017-03-15',48000),
('Meena Kulkarni','meena@school.com',3,'2020-01-20',41000),
('Amit Singh','amit@school.com',4,'2016-09-25',50000),
('Priya Nair','priya@school.com',5,'2021-02-11',39000),
('Rohit Deshmukh','rohit@school.com',2,'2018-12-05',43000),
('Sneha Joshi','sneha@school.com',3,'2019-11-15',41000),
('Vikram Rao','vikram@school.com',4,'2015-04-17',52000),
('Neha Kapoor','neha@school.com',5,'2022-08-01',38000);

select * from Teachers;

INSERT INTO Students (FirstName, LastName, DateOfBirth, Gender, DepartmentId, AdmissionDate) VALUES
('Aman','Patil','2002-05-12','M',1,'2023-06-10'),
('Riya','Sharma','2001-08-21','F',1,'2023-06-10'),
('Karan','Singh','2002-02-10','M',2,'2023-06-10'),
('Neha','Joshi','2001-09-14','F',3,'2023-06-10'),
('Rohit','Patel','2002-11-30','M',4,'2023-06-10'),
('Sneha','Kadam','2002-07-18','F',5,'2023-06-10'),
('Arjun','Mehta','2001-03-15','M',1,'2023-06-10'),
('Pooja','Desai','2002-06-25','F',2,'2023-06-10'),
('Rahul','Yadav','2001-12-01','M',3,'2023-06-10'),
('Anjali','Gupta','2002-04-08','F',4,'2023-06-10'),
('Vikas','Shinde','2001-10-10','M',5,'2023-06-10'),
('Kavita','Kulkarni','2002-01-22','F',1,'2023-06-10'),
('Manish','Naik','2001-07-30','M',2,'2023-06-10'),
('Aarti','Patil','2002-09-19','F',3,'2023-06-10'),
('Sagar','More','2002-02-27','M',4,'2023-06-10'),
('Divya','Rao','2001-11-11','F',5,'2023-06-10'),
('Nikhil','Jadhav','2002-03-05','M',1,'2023-06-10'),
('Priyanka','Shetty','2001-06-06','F',2,'2023-06-10'),
('Akash','Chavan','2002-08-08','M',3,'2023-06-10'),
('Rutuja','Patil','2001-04-14','F',4,'2023-06-10');

select * from Students;

INSERT INTO Courses (CourseName, Credits, DepartmentId, TeacherId) VALUES
('Database Systems',4,1,1),
('Operating Systems',4,1,2),
('Thermodynamics',3,2,3),
('Electrical Circuits',3,3,4),
('Structural Engineering',4,4,5),
('Web Development',3,5,6),
('Machine Design',3,2,7),
('Power Systems',4,3,8),
('Construction Management',3,4,9),
('Software Engineering',4,5,10);

select * from Courses;

INSERT INTO Enrollments (StudentId, CourseId) VALUES
(1,1),(2,1),(3,3),(4,4),(5,5),
(6,6),(7,2),(8,3),(9,4),(10,5),
(11,6),(12,1),(13,7),(14,8),(15,9),
(16,10),(17,2),(18,3),(19,4),(20,5),
(1,6),(2,7),(3,8),(4,9),(5,10),
(6,1),(7,3),(8,5),(9,6),(10,7);

select * from Enrollments;

INSERT INTO Exams (CourseId, ExamDate, ExamType) VALUES
(1,'2024-03-10','Midterm'),
(2,'2024-03-12','Midterm'),
(3,'2024-03-14','Midterm'),
(4,'2024-03-16','Final'),
(5,'2024-03-18','Final');


select * from Exams;

INSERT INTO Marks (StudentId, ExamId, MarksObtained) VALUES
(1,1,85),(2,1,78),(3,3,67),(4,4,90),(5,5,88),
(6,1,75),(7,2,82),(8,3,69),(9,4,91),(10,5,73),
(11,1,66),(12,2,77),(13,3,84),(14,4,79),(15,5,92),
(16,1,70),(17,2,88),(18,3,65),(19,4,80),(20,5,76),
(1,2,89),(2,3,72),(3,4,81),(4,5,68),(5,1,74),
(6,2,90),(7,3,87),(8,4,64),(9,5,83),(10,1,79);

select * from Marks;