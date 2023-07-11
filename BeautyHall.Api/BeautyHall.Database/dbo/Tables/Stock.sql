CREATE TABLE [dbo].[Stock] (
    [ProductId] INT             NOT NULL,
    [Quantity]  DECIMAL (18, 6) DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([ProductId] ASC),
    CONSTRAINT [FK_Stock_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([ProductId])
);

