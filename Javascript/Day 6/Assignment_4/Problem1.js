let books = [
    { id: 1, title: 'JavaScript Basics', price: 450, stock: 10 },
    { id: 2, title: 'React Guide', price: 650, stock: 5 },
    { id: 3, title: 'Node.js Mastery', price: 550, stock: 8 },
    { id: 4, title: 'CSS Complete', price: 300, stock: 12 },
];

let title = books.map(book=>book.title);
console.log("Book Titles :",title);

///////////////////////////////////////////////////////////

let totalValue = books.reduce((total,book)=>{
    return total+ (book.price *book.stock)
},0);
console.log("total Inventory Value :" ,totalValue);

////////////////////////////////////////////////////////////////////

let costlyBooks = books.filter(book=>book.price>500)
{
    console.log("Books above Rs 500 :",costlyBooks);
}

//////////////////////////////////////////////////////////////////////

let increasePrice = books.map(book=>{
    return{
    ...book,price:+(book.price *1.05).toFixed(2)
    }
})
console.log("After 5% Increase:", increasePrice);

////////////////////////////////////////////////////////////

let sortBook = [...books].sort((a,b)=>a.price-b.price);
console.log("Sorted by Price : ",sortBook);

/////////////////////////////////////////////////////////////

let bookId =2;
let bookExists = books.find(book=>book.id===bookId);

if(bookExists)
{
    books =books.filter(book=>book.id!==bookId)
}
console.log("after Removing Book :",books);


let outOfStock = books.some(book=>book.stock===0)

    console.log("Book out of Stock :",outOfStock);

    //////////////////////////////////////////////////////////////////

let groupedBooks = books.reduce((group,book)=>{
    if(book.price<400)
    {

        group.low.push(book)
    }else if(book.price<=600){
        group.medium.push(book);

    }else{
        group.high.push(book);
    }
    return group;
},{low:[],medium:[],high:[]});
console.log("Grouped Books :",groupedBooks)
