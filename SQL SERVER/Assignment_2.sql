use assignment_2;

create table customers(
customer_id INT Primary key,
first_Name varchar(50),
last_Name varchar(50),
email varchar(100)
);

create table orders(
order_id int primary key,
customer_id INT,
order_date DATE,
order_status INT,
foreign key(customer_id)references customers(customer_id)
);

create table brands(
brand_id INT primary key,
brand_name varchar(100)
);

create table categories(
category_id int primary key,
category_name varchar(100)
);

create table products(
product_id int primary key,
product_name varchar(100),
brand_id int,
category_id int,
model_year int,
list_price DECIMAL(10,2),

foreign key (brand_id) references brands(brand_id),
foreign key(category_id)references categories(category_id)
);

INSERT INTO customers VALUES
(1,'John','Doe','john@gmail.com'),
(2,'Jane','Smith','jane@gmail.com'),
(3,'Michael','Brown','michael@gmail.com');

INSERT INTO orders VALUES
(101,1,'2024-01-10',1),
(102,2,'2024-02-15',4),
(103,3,'2024-03-05',2),
(104,1,'2024-03-20',4);

INSERT INTO brands VALUES
(1,'Nike'),
(2,'Adidas'),
(3,'Puma');

INSERT INTO categories VALUES
(1,'Shoes'),
(2,'Clothing'),
(3,'Accessories');

INSERT INTO products VALUES
(1,'Running Shoes',1,1,2023,800),
(2,'Sports T-Shirt',2,2,2022,450),
(3,'Sneakers',3,1,2023,600),
(4,'Cap',1,3,2021,300),
(5,'Training Shoes',2,1,2024,900);

select 
c.first_name,
c.last_name,
o.order_id,
o.order_date,
o.order_status
from Customers c 
inner join orders o 
on c.customer_id = o.customer_id
where o.order_status=1
or o.order_status=4
order by o.order_date DESC;

select *  from customers;
select * from orders;

select
p.product_name,
b.brand_name,
c.category_name,
p.model_year,
p.list_price
from products p 
inner join brands b
on p.brand_id = b.brand_id
inner join categories c 
on p.category_id=c.category_id
where p.list_price>500
order by p.list_price ASC;
