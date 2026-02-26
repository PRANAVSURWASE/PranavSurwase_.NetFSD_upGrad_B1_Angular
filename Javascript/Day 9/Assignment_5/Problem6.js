class Shape{
    calculateArea()
    {
        console.log("Area not defined");
    }
}
class Circle extends Shape{
    constructor(radius)
    {
        super();
        this.radius = radius;
    }

    calculateArea(){
        let area =3.14 *this.radius *this.radius;
        
        console.log(`Circle Area :${area}`);
    }
}
class rectangle extends Shape{
    constructor(len,wid)
    {
        super();
        this.len = len;
        this.wid = wid;
    }
    calculateArea()
    {
        let area = this.len * this.wid;
        console.log(`Rectangle Area :${area}` );
    }
}
class Triangle extends Shape{
    constructor(base,height)
    {
        super();
        this.base = base;
        this.height = height;

    }
    calculateArea(){
        let area = 0.5 *this.base * this.height;
        console.log(`Triangle Area :${area}`)
    }
}
let shapes = [
    new Circle(4),
    new rectangle(4,7),
    new Triangle(3,6)
];

for(let shape of shapes)
{
    shape.calculateArea();
}