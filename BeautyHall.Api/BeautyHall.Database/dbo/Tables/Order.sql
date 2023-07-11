CREATE TABLE [dbo].[Order] (
    [OrderId]    INT            IDENTITY (1, 1) NOT NULL,
    [OrderDate]  DATETIME       NOT NULL,
    [CustomerId] INT            NULL,
    [Notes]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK__Order__C3905BCFB6F21A02] PRIMARY KEY CLUSTERED ([OrderId] ASC),
    CONSTRAINT [FK_Order_Subject] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Subject] ([SubjectId])
);





