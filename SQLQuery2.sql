Create table Admin_Account(
AdminID int Primary Key NOT NULL, 
Username VARCHAR (100) NULL,
Name VARCHAR (100) NULL,
Password VARCHAR (100) NULL,
Email VARCHAR (100) NULL,
Role VARCHAR (100) NULL,
Gender VARCHAR (100) NULL,
Status VARCHAR (100) NULL,)

Create table Cashier_Account(
CashierID int Primary key NOT NULL,
Username VARCHAR (100) NULL,
Name VARCHAR (100) NULL,
Password VARCHAR (100) NULL,
Email VARCHAR (100) NULL,
Gender VARCHAR (100) NULL,
Status VARCHAR (100) NULL,

)

Create table Activity_Logs(
LogID int Primary key NOT NULL,
CashierID int NOT NULL,
AdminID int NOT NULL,

FOREIGN KEY (CashierID) REFERENCES Cashier_Account(CashierID),
FOREIGN KEY (AdminID) REFERENCES Admin_Account(AdminID),
)

Create table ProductList(
ProductID int Primary key NOT NULL,
StocksID INT,
DeliveryID INT,
ProductName NVARCHAR (255),
Grams        INT ,
Quantity     INT,    
Price     DECIMAL (18, 2) ,
StockStatus NVARCHAR (50) ,  
MfgDate     DATETIME ,  
ExpDate     DATETIME  ,     
DeliveryDate DATETIME ,      
[Description]  NVARCHAR (MAX),

)



Create table Stocks(
StockID int Primary Key NOT NULL,
ProductID INT,
ProductName  NVARCHAR (100),
Grams  INT,      
Price     DECIMAL (10, 2) ,
StockStatus NVARCHAR (50) ,
Stocks   INT,
DeliveryDate DATE , 
)

Create table DeliveryLogs(
DeliveryID int Primary Key NOT NULL ,
ProductID   INT   IDENTITY (1, 1) NOT NULL,
ProductName VARCHAR (100) NOT NULL, 
Grams        INT NOT NULL,      
Price      DECIMAL (10, 2) NOT NULL ,
Quantity     INT NOT NULL,        
MfgDate      DATE NOT NULL,   
ExpDate      DATE NOT NULL,   
DeliveryDate DATE NULL,

)   

CREATE TABLE OrderHistory(
OrderHistory INT PRIMARY KEY NOT NULL,
Customer_ID INT NOT NULL,
ProductID INT NOT NULL,
TransactionID INT NOT NULL,
ProductName NVARCHAR (100) NOT NULL,
Payment     DECIMAL (10, 2) NOT NULL,
[DateTime]   DATETIME    NOT NULL,
TotalAmount     DECIMAL (10, 2) NOT NULL
) 

CREATE TABLE CustomerOrder(
CustomerID INT PRIMARY KEY NOT NULL,
ProductID INT NOT NULL,
ProductName VARCHAR NOT NULL,
Grams INT NOT NULL,
Quantity INT NOT NULL,
TotalAmount Decimal NOT NULL 
)
  
CREATE TABLE Payment(
TransactionID INT PRIMARY KEY NOT NULL,
Customer_ID INT NOT NULL,
ProductID INT NOT NULL,
PaymentMethod VARCHAR NOT NULL,
ProductName NVARCHAR (100) NOT NULL,
TotalAmount  DECIMAL (10, 2) NOT NULL
)







