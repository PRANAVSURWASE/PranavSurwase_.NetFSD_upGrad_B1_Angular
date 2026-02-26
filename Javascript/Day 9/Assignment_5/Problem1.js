class Person {
    constructor(name, age) {
        this.name = name;
        this.age = age;
    }

    greet() {
        console.log(`Hello My Name is ${this.name} and I am ${this.age}`);
    }
}

let person1 = new Person('Pranav', 23);
person1.greet();
