"use strict";
class Student {
    rollNo;
    studName;
    marksEng;
    marksMaths;
    marksScience;
    constructor(rno, name, eng, maths, sci) {
        this.rollNo = rno;
        this.studName = name;
        this.marksEng = eng;
        this.marksMaths = maths;
        this.marksScience = sci;
    }
    Total() {
        return this.marksEng + this.marksMaths + this.marksScience;
    }
    Percentage() {
        return this.Total() / 3;
    }
    display() {
        console.log('Roll No :', this.rollNo);
        console.log("Name :", this.studName);
        console.log("Total Marks :", this.Total());
        console.log("percentage :", this.Percentage());
    }
}
let student = new Student(11, "Alice", 89, 78, 887);
student.display();
