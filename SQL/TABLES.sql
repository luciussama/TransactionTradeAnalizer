CREATE TABLE Trades (
    TradeId INT PRIMARY KEY IDENTITY,
    Value DECIMAL(18, 2),
    ClientSector VARCHAR(50)
);

CREATE TABLE TradeCategories (
    TradeCategoryId INT PRIMARY KEY IDENTITY,
    TradeId INT FOREIGN KEY REFERENCES Trades(TradeId),
    Category VARCHAR(50)
);
