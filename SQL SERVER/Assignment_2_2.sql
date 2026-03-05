
CREATE TABLE stores (
    store_id INT PRIMARY KEY,
    store_name VARCHAR(100),
    city VARCHAR(50)
);

CREATE TABLE order_items (
    item_id INT PRIMARY KEY,
    order_id INT,
    product_id INT,
    quantity INT,
    list_price DECIMAL(10,2),
    discount DECIMAL(4,2),

    FOREIGN KEY (order_id) REFERENCES orders(order_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);

CREATE TABLE stocks (
    store_id INT,
    product_id INT,
    quantity INT,

    PRIMARY KEY (store_id, product_id),

    FOREIGN KEY (store_id) REFERENCES stores(store_id),
    FOREIGN KEY (product_id) REFERENCES products(product_id)
);
ALTER TABLE orders
ADD store_id INT;

ALTER TABLE orders
ADD FOREIGN KEY (store_id) REFERENCES stores(store_id);


INSERT INTO stores VALUES
(1,'Central Store','Mumbai'),
(2,'City Mall Store','Pune'),
(3,'Mega Store','Delhi');

UPDATE orders SET store_id = 1 WHERE order_id = 101;
UPDATE orders SET store_id = 2 WHERE order_id = 102;
UPDATE orders SET store_id = 3 WHERE order_id = 103;
UPDATE orders SET store_id = 1 WHERE order_id = 104;

INSERT INTO order_items VALUES
(1,101,1,2,800,0.10),
(2,102,3,1,600,0.05),
(3,104,5,3,900,0.15),
(4,103,2,2,450,0.00);

INSERT INTO stocks VALUES
(1,1,50),
(1,3,30),
(2,2,40),
(2,5,25),
(3,4,20);
-----------------------------------------------------------------------
SELECT 
    s.store_name,
    SUM(oi.quantity * oi.list_price * (1 - oi.discount)) AS total_sales
FROM stores s
INNER JOIN orders o
    ON s.store_id = o.store_id
INNER JOIN order_items oi
    ON o.order_id = oi.order_id
WHERE o.order_status = 4
GROUP BY s.store_name
ORDER BY total_sales DESC;

--------------------------------------------------------------
SELECT 
    p.product_name,
    s.store_name,
    st.quantity AS stock_quantity,
    SUM(oi.quantity) AS total_quantity_sold
FROM stocks st
INNER JOIN products p
    ON st.product_id = p.product_id
INNER JOIN stores s
    ON st.store_id = s.store_id
LEFT JOIN order_items oi
    ON st.product_id = oi.product_id
GROUP BY 
    p.product_name,
    s.store_name,
    st.quantity
ORDER BY 
    p.product_name;