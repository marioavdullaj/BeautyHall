CREATE TABLE [dbo].[Service] (
    [ServiceId]           INT             IDENTITY (1, 1) NOT NULL,
    [ServiceCode]         NVARCHAR (100)  NOT NULL,
    [ServiceDescription]  NVARCHAR (MAX)  NULL,
    [ServiceNotes]        NVARCHAR (MAX)  NULL,
    [ServiceMinimumPrice] DECIMAL (18, 2) NULL,
    [ServiceMaximumPrice] DECIMAL (18, 2) NULL,
    [CategoryId]          INT             NULL,
    CONSTRAINT [PK__Service__C51BB00A37E209CE] PRIMARY KEY CLUSTERED ([ServiceId] ASC),
    CONSTRAINT [FK_Service_Category] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([CategoryId])
);



