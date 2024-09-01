IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Product')
BEGIN
    CREATE DATABASE Product;
END
GO

USE Product;
GO

CREATE TABLE Item (
    ItemID INT IDENTITY(1,1) PRIMARY KEY,
    ItemName NVARCHAR(100) NOT NULL,
    Description TEXT,
    Price DECIMAL(18, 2) NOT NULL,
    StockQuantity INT NOT NULL,
    ImageURL NVARCHAR(255),
    Color NVARCHAR(50),
    Weight DECIMAL(18, 2),
    Material NVARCHAR(100),
    Status NVARCHAR(MAX),
    Rating NVARCHAR(MAX),
    Location NVARCHAR(100),
    Featured BIT NOT NULL,
    Discount NVARCHAR(MAX),
    Brand NVARCHAR(50),
    TaxGroupID INT,
    UnitOfMeasureID INT,
    FOREIGN KEY (TaxGroupID) REFERENCES TaxGroup(TaxGroupID),
    FOREIGN KEY (UnitOfMeasureID) REFERENCES UnitOfMeasure(UnitOfMeasureID)
);
GO


CREATE TABLE prItemBarcode (
    BarcodeID INT IDENTITY(1,1) PRIMARY KEY,
    BarcodeType NVARCHAR(50) NOT NULL,
    ItemID INT NOT NULL,
    Barcode NVARCHAR(13) NOT NULL,
    FOREIGN KEY (ItemID) REFERENCES Item(ItemID)
);
GO

CREATE TABLE TaxGroup (
    TaxGroupID INT IDENTITY(1,1) NOT NULL,
    TaxGroupName VARCHAR(50) NOT NULL,
    TaxRate DECIMAL(5, 2) NOT NULL,
    PRIMARY KEY (TaxGroupID)
);
GO

CREATE TABLE UnitOfMeasure (
    UnitOfMeasureID INT IDENTITY(1,1) NOT NULL,
    UnitOfMeasureName NVARCHAR(MAX) NOT NULL,
    UnitOfMeasureCode NVARCHAR(MAX) NULL,
    UnitOfMeasureDescription NVARCHAR(MAX) NULL,
    ConversionFactor DECIMAL(10, 4) NULL,
    PRIMARY KEY (UnitOfMeasureID)
);
GO