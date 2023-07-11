CREATE TABLE [dbo].[Login] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Username] NVARCHAR (50)  NULL,
    [Password] NVARCHAR (MAX) NULL,
    [Name]     NVARCHAR (50)  NULL,
    [Surname]  NVARCHAR (50)  NULL,
    [Role]     NVARCHAR (50)  NULL,
    CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [UQ_Username] UNIQUE NONCLUSTERED ([Username] ASC)
);





