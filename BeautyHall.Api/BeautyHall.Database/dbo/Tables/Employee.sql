CREATE TABLE [dbo].[Employee] (
    [EmployeeId]       INT            IDENTITY (1, 1) NOT NULL,
    [EmployeeCode] NVARCHAR(50) NOT NULL, 
    [EmployeeName]     NVARCHAR (MAX) NOT NULL,
    [EmployeeLastName] NVARCHAR (MAX) NULL,
    [EmployeeRole]     NVARCHAR (200) NULL,
    [EmployeePhone]    NVARCHAR(20)            NULL,
    [IsActive]         BIT            CONSTRAINT [DF_Employee_IsActive] DEFAULT ((1)) NULL,
    [EmployeeEmail] NVARCHAR(50) NULL, 
    [EmployeeRegistrationDate] DATETIME NULL, 
    CONSTRAINT [PK__Employee__7AD04F11D36FAF6D] PRIMARY KEY CLUSTERED ([EmployeeId] ASC)
);

