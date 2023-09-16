using BeautyHall.Api.SDK.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BSMS.Winforms.Models
{
    public class DisplayOrder : Order
    {
        public string DisplayOrderServices => string.Join(", ", this.OrderServices.Select(s => s.OrderId));
        public string DisplayOrdersServices => string.Join(", ", this.OrderServices.Select(s => s.ServiceId));
        //public string DisplayOrdersDate => string.Join(", ", this.OrderDate);
        //public string DisplayAppointments => string.Join(", ", this.Appointments.Select(a => a.AppointmentId));
        public string DisplayCustomer => this.Customer?.SubjectLastName ?? "";
        public string DisplayOrderSummaries => string.Join(", ", OrderServices?.Select(s => s.ServicePrice));
        public string DisplayServicesByEmployee
        {
            get
            {
                var servicesByEmployee = this.OrderServices
                    .GroupBy(s => s.Employee?.EmployeeCode)
                    .Select(g => $"{g.Key}: {string.Join(", ", g.Select(s => s.Service?.ServiceDescription))}");

                return string.Join("; ", servicesByEmployee);
            }
        }
    }

}
