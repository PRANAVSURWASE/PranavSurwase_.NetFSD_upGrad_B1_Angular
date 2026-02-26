let numbers = [10, 20, 30, 10, 40, 20, 50, 60, 60];

let uniqueNumber  =[...new Set(numbers)];
console.log("Unique :",uniqueNumber);

//////////////////////////////////////////////////

let secondLargest = [...new Set(numbers)].sort((a,b)=>b-a)[1];
console.log(secondLargest);

//////////////////////////////////////////////

let frequency = numbers.reduce((acc, num) => {
  acc[num] = (acc[num] || 0) + 1;
  return acc;
}, {});

console.log("Frequency:", frequency);

//////////////////////////////////////////////
let firstNonRepeating = numbers.find(num => frequency[num] === 1);
console.log("First Non-Repeating:", firstNonRepeating);

/////////////////////////////////////////////

let arr = [1,2,3,5,6];
let missing;

for (let i = 0; i < arr.length; i++) {
  if (arr[i] !== i + 1) {
    missing = i + 1;
    break;
  }
}
///////////////////////////////////////////////////////////////////
console.log("Missing Number:", missing);

let rotateBy2 = [
  ...numbers.slice(-2),
  ...numbers.slice(0, numbers.length - 2)
];

console.log("Rotated:", rotateBy2);