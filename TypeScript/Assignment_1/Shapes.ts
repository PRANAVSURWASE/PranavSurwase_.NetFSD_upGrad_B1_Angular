class Shapes
{
    area(a:number,b?:number):number{
        if(b!==undefined)
        {
            return a*b;
        }
        else{
            return a*a
        }
    }

    areaTriangle(base:number,height:number):number{
        return 0.5*base  *height;
    }

    areaCircle(radius:number):number{
        return Math.PI * radius  * radius;
    }


}

let s = new Shapes();
console.log("Rectagle:" ,s.area(4,6));
console.log("Square:" ,s.area(4));
console.log("Triangle:" ,s.areaTriangle(4,6));
console.log("Circle:" ,s.areaCircle(3));

