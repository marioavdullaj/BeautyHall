CREATE TABLE [dbo].[Subject] (
    [SubjectId]        INT            IDENTITY (1, 1) NOT NULL,
    [SubjectType]      INT            NOT NULL,
    [PhoneNumber]      NVARCHAR (20)  NULL,
    [Email]            NVARCHAR (50)  NULL,
    [SubjectName]      NVARCHAR (255) NULL,
    [SubjectLastName]  NVARCHAR (255) NULL,
    [RegistrationDate] DATETIME       NULL,
    CONSTRAINT [PK__Subject__AC1BA3A885CEB9A3] PRIMARY KEY CLUSTERED ([SubjectId] ASC)
);

