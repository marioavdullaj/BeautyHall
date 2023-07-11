CREATE TABLE [dbo].[Payment_Summary] (
    [PaymentId]   INT             IDENTITY (1, 1) NOT NULL,
    [OrderId]     INT             NOT NULL,
    [TotalPrice]  DECIMAL (18, 2) NOT NULL,
    [TotalCash]  DECIMAL (18, 2) NULL,
    [TotalPOS]   DECIMAL (18, 2) NULL,
    [PaymentDate] DATETIME        NULL,
    CONSTRAINT [PK__Payment___C3905BCF5B134B98] PRIMARY KEY CLUSTERED ([PaymentId] ASC, [OrderId] ASC),
    CONSTRAINT [FK_Payment_Summary_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([OrderId])
);

