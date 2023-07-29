using BeautyHall.Models.Db.Models;
using BeautyHall.Models.Dto.Requests;
using System.Reflection.Metadata;

namespace BeautyHall.Api.DB.Utils
{
    public class Mappers
    {
        #region Input
        public static Subject Map(SubjectDto item)
        {
            return new Subject()
            {
                SubjectId = item.SubjectId,
                SubjectType = item.Type,
                Email = item.EMail,
                PhoneNumber = item.PhoneNumber,
                SubjectLastName = item.SubjectLastName,
                SubjectName = item.SubjectName,
                RegistrationDate = item.RegistrationDate

            };
        }

        public static Employee Map(EmployeeDto item)
        {
            return new Employee()
            {  
                EmployeeId = item.EmployeeId,
                EmployeeName = item.EmployeeName,
                EmployeeLastName = item.EmployeeLastName,
                EmployeeRole = item.EmployeeRole,
                EmployeePhone = item.EmployeePhone,
                IsActive = item.IsActive,
                EmployeeEmail = item.EmployeeEmail,
                EmployeeRegistrationDate = item.EmployeeRegistrationDate,
                EmployeeCode = item.EmployeeCode
            };
        }
        public static Login Map(LoginDto item)
        {
            return new Login()
            {
                Username = item.Username,
                Password = item.Password,
                Name = item.Name,
                Surname = item.Surname,
                Role = item.Role
            };
        }
        public static Service Map(ServiceDto item)
        {
            return new Service()
            {
                ServiceId = item.ServiceId,
                ServiceCode = item.ServiceCode,
                ServiceDescription = item.ServiceDescription,
                ServiceMaximumPrice = item.ServiceMaximumPrice,
                ServiceMinimumPrice = item.ServiceMinimumPrice,
                ServiceNotes = item.ServiceNotes,
                CategoryId = item.CategoryId
            };
        }

        public static Order Map(OrderDto item)
        {
            return new Order()
            {
                OrderId = item.OrderId,
                OrderDate = item.OrderDate,
                CustomerId = item.CustomerId,
                Notes = item.Notes
            };
        }

        public static OrderService Map(OrderServiceDto item)
        {
            return new OrderService()
            {
                OrderId = item.OrderId,
                ServiceId = item.ServiceId,
                EmployeeId = item.EmployeeId,
                ServicePrice = item.ServicePrice
            };
        }
        public static Appointment Map(AppointmentDto item)
        {
            return new Appointment()
            {
                OrderId = item.OrderId,
                AppointmentId = item.AppointmentId,
                CustomerId = item.CustomerId,
                AppointmentDate = item.AppointmentDate,
                AppointmentStatus = item.AppointmentStatus
            };
        }
        public static Discount Map(DiscountDto item)
        {
            return new Discount()
            {
                ServiceId = item.ServiceId,
                CustomerId = item.CustomerId,
                DiscountPercentage = item.DiscountPercentage,
                DiscountTimestamp = item.DiscountTimestamp
            };
        }

        public static Category Map(CategoryDto item)
        {
            return new Category()
            {
                CategoryId = item.CategoryId,
                CategoryName = item.CategoryName,
                CategoryDescription = item.CategoryDescription
            };
        }
        public static Product Map(ProductDto item)
        {
            return new Product()
            {
                ProductId = item.ProductId,
                ProductCode = item.ProductCode,
                ProductDescription = item.ProductDescription,
                SupplierId = item.SupplierId,
                SellingPrice = item.SellingPrice
            };
        }
        public static Stock Map(StockDto item)
        {
            return new Stock()
            {
                ProductId = item.ProductId,
                Quantity = item.Quantity
            };
        }
        public static PaymentSummary Map(PaymentSummaryDto item)
        {
            return new PaymentSummary()
            {
                PaymentId = item.PaymentId,
                OrderId = item.OrderId,
                TotalCash = item.TotalCash,
                DiscountedPrice = item.DiscountedPrice,
                TotalPOS = item.TotalPOS,
                TotalPrice = item.TotalPrice,
                PaymentDate = item.PaymentDate
            };
        }
        #endregion
    }
}
