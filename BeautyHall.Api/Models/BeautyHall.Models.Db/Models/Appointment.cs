using System;
using System.Collections.Generic;

namespace BeautyHall.Models.Db.Models;

public partial class Appointment
{
    public int AppointmentId { get; set; }

    public int CustomerId { get; set; }

    public DateTime AppointmentDate { get; set; }

    public int? AppointmentStatus { get; set; }

    public int? OrderId { get; set; }

    public virtual Subject Customer { get; set; } = null!;
    public virtual Order Order { get; set; } = null!;
}
