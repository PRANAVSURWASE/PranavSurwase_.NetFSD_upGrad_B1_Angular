let students = [
  { name: "Akhil", marks: 85 },
  { name: "Priya", marks: 72 },
  { name: "Ravi", marks: 90 },
  { name: "Meena", marks: 45 },
  { name: "Karan", marks: 30 }
];
/////////////////////////////////////////////////////////////////////////
let passStu = students.filter(s=>s.marks>=40);
console.log(passStu);
/////////////////////////////////////////////////////////////////////////
let DistinctionStu = students.filter(s=>s.marks>=85);
console.log(DistinctionStu);
///////////////////////////////////////////////////////////////////////
let totalMarks = students.reduce((sum,s)=>sum+s.marks,0);
let avg = totalMarks /students.length;
console.log("class Average :",avg)
////////////////////////////////////////////////////////////////////////////
let topper = students.reduce((max ,s)=>s.marks>max.marks ? s:max);
console.log("topper ",topper);
//////////////////////////////////////////////////////////////////////////////

let failedStudents = students.filter(s=>s.marks<40).length;
console.log("Failed Students :", failedStudents);

//////////////////////////////////////////////////////////////////
let gradeStu = students.map(s=>{
    let grade;
    if(s.marks>=85)
        grade="A";
    else if(s.marks>=60)
        grade ="B"
    else if(s.marks>=40)
        grade = "c"
    else grade ="Failed"

    return {...s,grade};

})
console.log("Student with Grades ",gradeStu);