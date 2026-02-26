let employees = [
 { id:1, name:"Ravi", dept:"IT", salary:70000 },
 { id:2, name:"Anita", dept:"HR", salary:50000 },
 { id:3, name:"Karan", dept:"IT", salary:80000 },
 { id:4, name:"Meena", dept:"Finance", salary:60000 }
];

let totalSalary = employees.reduce((total, emp) =>
  total + emp.salary, 0
);
console.log("Total Salary Expense:", totalSalary);

let highestPaid = employees.reduce((max, emp) =>
  emp.salary > max.salary ? emp : max
);

let lowestPaid = employees.reduce((min, emp) =>
  emp.salary < min.salary ? emp : min
);
console.log("Highest Paid:", highestPaid);
console.log("Lowest Paid:", lowestPaid);

let updatedEmployees = employees.map(emp =>
  emp.dept === "IT"
    ? { ...emp, salary: Math.round(emp.salary * 1.15) }
    : emp
);

console.log("After 15% IT Hike:", updatedEmployees);
////////////////////////////////////////////////////////

let groupedByDept = employees.reduce((groups, emp) => {

  if (!groups[emp.dept]) {
    groups[emp.dept] = [];
  }

  groups[emp.dept].push(emp);

  return groups;

}, {});

console.log("Grouped by Department:", groupedByDept);

let deptAverage = employees.reduce((acc, emp) => {

  if (!acc[emp.dept]) {
    acc[emp.dept] = { total: 0, count: 0 };
  }

  acc[emp.dept].total += emp.salary;
  acc[emp.dept].count++;

  return acc;

}, {});

for (let dept in deptAverage) {
  deptAverage[dept].average =
    (deptAverage[dept].total / deptAverage[dept].count);
}

console.log("Department-wise Average:", deptAverage);



let sortedEmployees = [...employees].sort((a, b) =>
  b.salary - a.salary
);

console.log("Sorted by Salary (High to Low):", sortedEmployees);