CREATE TABLE [dbo].[Order_Product] (
    [OrderId]         INT             NOT NULL,
    [ProductId]       INT             NOT NULL,
    [ProductQuantity] DECIMAL (18, 2) NOT NULL,
    [TotalPrice]     DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Order_Product] PRIMARY KEY CLUSTERED ([OrderId] ASC, [ProductId] ASC),
    CONSTRAINT [FK_Order_Product_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([OrderId]),
    CONSTRAINT [FK_Order_Product_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([ProductId])
);

