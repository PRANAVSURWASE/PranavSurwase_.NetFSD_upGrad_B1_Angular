let num = 3
let res = (num>=0)?"Positive":"Negative";
console.log("Number is ",res);

if(num%2===0)
{
    console.log("Number is even")
}
else{
    console.log("Number is Odd");
}

console.log("Numbers from 1 to ",num)
for(let i=0;i<=num;i++)
{
    console.log(i);
}