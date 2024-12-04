CREATE DATABASE ProductDB;

USE ProductDB;

CREATE TABLE Product(
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(100) NOT NULL,
    Grams NVARCHAR(50) NOT NULL,
    Price DECIMAL(10, 2) NOT NULL,
    QtyStock INT NOT NULL,
    StockStatus NVARCHAR(50) NOT NULL,
    MfgDate DATE NOT NULL,
    ExpDate DATE NOT NULL
); 

INSERT INTO Product (ProductName, Grams, Price, QtyStock, StockStatus, MfgDate, ExpDate)
VALUES
-- Powder fry booster
('Powder fry booster', '50g', 50.00, 100, 'In Stock', '2024-01-01', '2025-01-01'),
('Powder fry booster', '100g', 100.00, 100, 'In Stock', '2024-01-01', '2025-01-01'),

-- Granules growout
('Granules growout', '50g', 50.00, 100, 'In Stock', '2024-01-01', '2025-01-01'),
('Granules growout', '100g', 100.00, 100, 'In Stock', '2024-01-01', '2025-01-01'),

-- Granules newbits
('Granules newbits', '50g', 50.00, 100, 'In Stock', '2024-01-01', '2025-01-01'),
('Granules newbits', '100g', 100.00, 100, 'In Stock', '2024-01-01', '2025-01-01'),

-- Anthaxantine granules
('Anthaxantine granules', '50g', 45.00, 100, 'In Stock', '2024-01-01', '2025-01-01'),
('Anthaxantine granules', '100g', 85.00, 100, 'In Stock', '2024-01-01', '2025-01-01'),

-- Spirulina granules
('Spirulina granules', '50g', 45.00, 100, 'In Stock', '2024-01-01', '2025-01-01'),
('Spirulina granules', '100g', 85.00, 100, 'In Stock', '2024-01-01', '2025-01-01'),

-- Spirulina pellet (medium)
('Spirulina pellet (medium)', '50g', 80.00, 100, 'In Stock', '2024-01-01', '2025-01-01'),
('Spirulina pellet (medium)', '100g', 125.00, 100, 'In Stock', '2024-01-01', '2025-01-01'),

-- Kok massive pellet (medium)
('Kok massive pellet (medium)', '50g', 80.00, 100, 'In Stock', '2024-01-01', '2025-01-01'),
('Kok massive pellet (medium)', '100g', 125.00, 100, 'In Stock', '2024-01-01', '2025-01-01');
