CREATE TABLE [dbo].[Order_Service] (
    [OrderId]      INT             NOT NULL,
    [ServiceId]    INT             NOT NULL,
    [ServicePrice] DECIMAL (18, 2) NOT NULL,
    [EmployeeId]   INT             NULL,
    CONSTRAINT [PK_Order_Service] PRIMARY KEY CLUSTERED ([OrderId] ASC, [ServiceId] ASC),
    CONSTRAINT [FK_Order_Service_Employee] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([EmployeeId]),
    CONSTRAINT [FK_Order_Service_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([OrderId]),
    CONSTRAINT [FK_Order_Service_Service] FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[Service] ([ServiceId])
);

