# Supermarket-billing-system
Supermarket billing system

Below is the SQL code to create the necessary tables for your Billing System project

CREATE TABLE Inventory (
    ItemID INT AUTO_INCREMENT PRIMARY KEY, -- Unique identifier for each item
    ItemName VARCHAR(100) NOT NULL,        -- Name of the item
    PricePerUnit DECIMAL(10, 2) NOT NULL,  -- Price of a single unit
    Quantity INT NOT NULL                  -- Quantity available in stock
);
