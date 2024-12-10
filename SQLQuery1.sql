-- 1. Create the `ProductList` table first (it is referenced by multiple tables)
CREATE TABLE ProductList (
  product_id INT NOT NULL,
  product_name VARCHAR(100),
  quantity DECIMAL(10, 2),
  price DECIMAL(10, 2), -- Changed from VARBINARY(MAX) to DECIMAL for price
  description VARCHAR(100),
  PRIMARY KEY (product_id)
);

-- 2. Create the `Stocks` table (it is referenced by `DeliveryLogs`)
CREATE TABLE Stocks (
  stocks_id INT NOT NULL,
  product_id INT,
  stock_status VARCHAR(50),
  stock INT,
  delivery_date DATE,
  PRIMARY KEY (stocks_id),
  FOREIGN KEY (product_id) REFERENCES ProductList(product_id)
);

-- 3. Create the `Account` table (it is referenced by `Audit`)
CREATE TABLE Account (
  user_id INT NOT NULL,
  name VARCHAR(100),
  username VARCHAR(100),
  password VARCHAR(100),
  role VARCHAR(100),
  archived VARCHAR(100),
  PRIMARY KEY (user_id)
);

-- 4. Create the `Payment` table (it is referenced by `Order`)
CREATE TABLE [Payment] (
  payment_id INT NOT NULL,
  order_id INT,
  product_id INT,
  payment_method VARCHAR(100),
  [change] DECIMAL(10, 2),
  total_amount DECIMAL(10, 2),
  [date_time] DATETIME,
  PRIMARY KEY (payment_id),
  FOREIGN KEY (product_id) REFERENCES ProductList(product_id)
);

-- 5. Create the `Order` table (it references `Payment`)
CREATE TABLE [Order] (
  order_id INT NOT NULL,
  payment_id INT,
  product_name VARCHAR(100),
  quantity INT,
  total_price DECIMAL(10, 2),
  PRIMARY KEY (order_id),
  FOREIGN KEY (payment_id) REFERENCES [Payment](payment_id)
);

-- 6. Create the `Audit` table (it references `Account`)
CREATE TABLE Audit (
  audit_id INT NOT NULL,
  user_id INT, -- Changed from VARCHAR(100) to INT to match `Account.user_id`
  actions VARCHAR(100),
  created_at DATETIME,
  PRIMARY KEY (audit_id),
  FOREIGN KEY (user_id) REFERENCES Account(user_id)
);

-- 7. Create the `DeliveryLogs` table (it references `Stocks` and `ProductList`)
CREATE TABLE DeliveryLogs (
  delivery_id INT NOT NULL,
  stocks_id INT,
  product_id INT,
  quantity INT,
  mfg_date DATE,
  exp_date DATE,
  delivery_date DATE,
  PRIMARY KEY (delivery_id),
  FOREIGN KEY (stocks_id) REFERENCES Stocks(stocks_id),
  FOREIGN KEY (product_id) REFERENCES ProductList(product_id)
);
