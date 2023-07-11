using System;
using System.Collections.Generic;

namespace BeautyHall.Api.SDK.Responses;

public class Appointment
{
    public int AppointmentId { get; set; }

    public int CustomerId { get; set; }

    public DateTime AppointmentDate { get; set; }

    public int? AppointmentStatus { get; set; }

    public int? OrderId { get; set; }

    public Subject? Customer { get; set; } = null;
    public Order? Order { get; set; } = null;
}
