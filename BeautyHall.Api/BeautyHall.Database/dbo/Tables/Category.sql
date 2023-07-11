CREATE TABLE [dbo].[Category] (
    [CategoryId]          INT            IDENTITY (1, 1) NOT NULL,
    [CategoryName]        NVARCHAR (100) NOT NULL,
    [CategoryDescription] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([CategoryId] ASC)
);

