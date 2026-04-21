"use strict";
class Shapes {
    area(a, b) {
        if (b !== undefined) {
            return a * b;
        }
        else {
            return a * a;
        }
    }
    areaTriangle(base, height) {
        return 0.5 * base * height;
    }
    areaCircle(radius) {
        return Math.PI * radius * radius;
    }
}
let s = new Shapes();
console.log("Rectagle:", s.area(4, 6));
console.log("Square:", s.area(4));
console.log("Triangle:", s.areaTriangle(4, 6));
console.log("Circle:", s.areaCircle(3));
