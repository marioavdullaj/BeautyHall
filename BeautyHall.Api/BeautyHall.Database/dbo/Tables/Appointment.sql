CREATE TABLE [dbo].[Appointment] (
    [AppointmentId]     INT      IDENTITY (1, 1) NOT NULL,
    [CustomerId]        INT      NOT NULL,
    [AppointmentDate]   DATETIME NOT NULL,
    [AppointmentStatus] INT      CONSTRAINT [DF__Appointme__Appoi__34C8D9D1] DEFAULT ((0)) NULL,
    [OrderId]           INT      NULL,
    CONSTRAINT [PK__Appointm__8ECDFCC259B26E9C] PRIMARY KEY CLUSTERED ([AppointmentId] ASC),
    CONSTRAINT [FK_Appointment_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([OrderId]),
    CONSTRAINT [FK_Appointment_Subject] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Subject] ([SubjectId])
);



