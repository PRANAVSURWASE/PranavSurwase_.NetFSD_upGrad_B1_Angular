class Product {
    constructor({ name, price, category = "General", tags = [] }) {
        this.name = name;
        this.price = price;
        this.category = category;
        this.tags = [...tags];
    }

    getDetails = () => {
        return `Product: ${this.name} | Price: ${this.price} | Category: ${this.category}`;
    }

    addTags = (...newTags) => {
        this.tags = [...this.tags, ...newTags];
    }

    getSummary = () => {
        const { name, price } = this;
        return `${name} costs ${price}`;
    }
}

let product1 = new Product({
    name: "TV",
    price: 78000,
    category: "Electronics",
    tags: ["Tech", "Portable"]
});
console.log(product1.getDetails());
product1.addTags("Office","Work");
console.log("Tags :" ,product1.tags);
console.log(product1.getSummary());