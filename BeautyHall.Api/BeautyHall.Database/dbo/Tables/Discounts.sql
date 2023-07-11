CREATE TABLE [dbo].[Discounts] (
    [ServiceId]          INT             NOT NULL,
    [CustomerId]         INT             NOT NULL,
    [DiscountPercentage] DECIMAL (18, 2) DEFAULT ((0)) NOT NULL,
    [DiscountTimestamp]  DATETIME        NULL,
    CONSTRAINT [PK_Discounts] PRIMARY KEY CLUSTERED ([ServiceId] ASC, [CustomerId] ASC),
    CONSTRAINT [FK_Discounts_Service] FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[Service] ([ServiceId]),
    CONSTRAINT [FK_Discounts_Subject] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Subject] ([SubjectId])
);



