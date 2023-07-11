CREATE TABLE [dbo].[Employee_Service] (
    [ServiceId]  INT NOT NULL,
    [EmployeeId] INT NOT NULL,
    CONSTRAINT [PK_Employee_Service] PRIMARY KEY CLUSTERED ([ServiceId] ASC, [EmployeeId] ASC),
    CONSTRAINT [FK_Employee_Service_Employee] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([EmployeeId]),
    CONSTRAINT [FK_Employee_Service_Service] FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[Service] ([ServiceId])
);

