class Student
{
    rollNo:number;
    studName:string;
    marksEng:number;
    marksMaths:number;
    marksScience:number;

    constructor(rno:number,name:string,eng:number,maths:number,sci:number)
    {
        this.rollNo = rno;
        this.studName=name;
        this.marksEng = eng;
        this.marksMaths =maths;
        this.marksScience = sci   
    }

    Total():number
    {
        return this.marksEng+ this.marksMaths + this.marksScience
    }
    Percentage():number
    {
        return this.Total() /3;
    }
    display():void{
        console.log('Roll No :',this.rollNo);
        console.log("Name :",this.studName);
        console.log("Total Marks :",this.Total());
        console.log("percentage :",this.Percentage());
    }
}
let student = new Student(11,"Alice",89,78,887);
student.display();