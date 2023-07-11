using System;
using System.Collections.Generic;

namespace BeautyHall.Models.Db.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public int SubjectType { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? SubjectName { get; set; }

    public string? SubjectLastName { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
