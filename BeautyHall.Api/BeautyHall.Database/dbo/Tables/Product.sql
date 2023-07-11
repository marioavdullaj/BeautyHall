CREATE TABLE [dbo].[Product] (
    [ProductId]          INT            IDENTITY (1, 1) NOT NULL,
    [ProductCode]        NVARCHAR (MAX) NOT NULL,
    [ProductDescription] NVARCHAR (MAX) NULL,
    [SupplierId]         INT            NULL,
    CONSTRAINT [PK__Product__B40CC6CDADEDCEB1] PRIMARY KEY CLUSTERED ([ProductId] ASC),
    CONSTRAINT [FK_Product_Subject] FOREIGN KEY ([SupplierId]) REFERENCES [dbo].[Subject] ([SubjectId])
);

