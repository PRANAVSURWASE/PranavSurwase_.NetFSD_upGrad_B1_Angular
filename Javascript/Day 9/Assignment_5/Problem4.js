class Vehicle {
    constructor(brand, speed) {
        this.brand = brand;
        this.speed = speed;
    }
    start() {
        console.log(
            `${this.brand} Vehicle has Started at Speed of ${this.speed}.`,
        );
    }
}
class Car extends Vehicle {
    constructor(brand, speed, fuelType) {
        super(brand, speed);
        this.fuelType = fuelType;
    }

    showDetails() {
        console.log(`Brand ${this.brand}`);
        console.log(`SPeed ${this.speed}`);
        console.log(`Fuel Type ${this.fuelType}`);
    }
}

let car1 = new Car('Mercedes', 220, 'EV');

car1.start();
car1.showDetails();
