class Student {
    constructor(name) {
        this.name = name;
        this.marks = [];
    }
    addMarks(mark) {
        this.marks.push(mark);
        console.log(`Mark ${mark} added. `);
    }
    getAvg() {
        let sum = 0;
        for (let mark of this.marks) {
            sum += mark;
        }
        return sum / this.marks.length;
    }
    getGrade() {
        let avg = this.getAvg();
        if (avg >= 90) {
            return 'A';
        } else if (avg >= 75) {
            return 'B';
        } else if (avg >= 50) {
            return 'C';
        } else {
            return 'Fail';
        }
    }
}

let s1 = new Student('Pranav Surwwase');
s1.addMarks(89);
s1.addMarks(78);
s1.addMarks(81);
s1.addMarks(77);
s1.addMarks(95);
console.log('Average ->', s1.getAvg());
console.log('Grade -> ', s1.getGrade());
