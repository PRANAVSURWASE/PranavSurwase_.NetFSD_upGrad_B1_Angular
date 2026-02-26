
class Employee {
    constructor(name, salary) {
        this.name = name;
        this.salary = salary;
    }

    getDetails() {
        console.log(`Name: ${this.name}`);
        console.log(`Base Salary: ₹${this.salary}`);
    }
}

class Manager extends Employee {
    constructor(name, salary, bonus) {
        super(name, salary);
        this.bonus = bonus;
    }

    getTotalSalary() {
        return this.salary + this.bonus;
    }
}

class Director extends Manager {
    constructor(name, salary, bonus, stockOptions) {
        super(name, salary, bonus);
        this.stockOptions = stockOptions;
    }

    getFullCompensation() {
        return this.salary + this.bonus + this.stockOptions;
    }
}

let director1 = new Director('Pranav Surwase', 100000, 20000, 50000);

director1.getDetails();
console.log('Total Salary : ' + director1.getTotalSalary());
console.log(
    'Full Compensation : ' + director1.getFullCompensation(),
);
