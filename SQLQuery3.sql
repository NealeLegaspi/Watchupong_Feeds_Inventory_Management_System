CREATE TABLE [dbo].[ProductList] (
    [StockID]     INT           NOT NULL,
    [ProductID]   INT           NULL,
    [ProductName] VARCHAR (100) NULL,
    [Grams]       INT           NULL,
    [QtyStock]    INT           NULL,
    [Price]       DECIMAL (18)  NULL,
    [StockStatus] VARCHAR (100) NULL,
    [MfgDate]     DATE          NULL,
    [ExpDate]     DATE          NULL,
    [DeliveryDate] DATE         NULL,
    [Description] DATE          NULL
    PRIMARY KEY CLUSTERED ([StockID] ASC),
    FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Stocks] ([ProductID])
);
