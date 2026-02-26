let cart = [
  { id: 1, product: "Laptop", price: 60000, qty: 1 },
  { id: 2, product: "Headphones", price: 2000, qty: 2 },
  { id: 3, product: "Mouse", price: 800, qty: 1 }
];

let cartvalue = cart.reduce((total,item)=>{
    return total+(item.price * item.qty);
},0) 
console.log("total Cart Value :" ,cartvalue);

//////////////////////////////////////////////////////////////

let updatedCart = cart.map(item=>item.id===2 ?{...item,qty:item.qty+1}:item);
console.log("After Increasing Quantity ",updatedCart);

//////////////////////////////////////////////////////////////////////////
let removeCart = cart.filter(item=>item.id!==3);
console.log("After Removing Products : ",removeCart)

//////////////////////////////////////////////////////////////////////

let discountedCart = cart.map(item=>item.price>10000 ?{...item, price: +(item.price*0.9)}:item);
console.log("After Discount : ",discountedCart);

/////////////////////////////////////////////////////////////////

let sortedCart = [...cart].sort((a,b)=>(a.price*a.qty)-(b.price*b.qty));
console.log("Sorted by Total Price",sortedCart);

//////////////////////////////////////////////////////////////////////////

let expensiveItem = cart.some(item => item.price > 50000);
console.log("Any Product Above ₹50,000?", expensiveItem);

/////////////////////////////////////////////////////////////////////////

let allInStock = cart.every(item => item.qty > 0);
console.log("All Items In Stock?", allInStock);