using BeautyHall.Models.Db.Models;
using BeautyHall.Models.Dto.Requests;

namespace BeautyHall.Models.Common.Interfaces
{
    public interface IBolDbService
    {
        Login? Login(string? username, string? password);
        bool UpSertLogin(LoginDto data);
        #region Registry
        bool UpSertSubjects(IEnumerable<SubjectDto> data);
        bool DeleteSubject(int subjectId);
        IEnumerable<Subject> GetSubjects();
        bool UpSertEmployees(IEnumerable<EmployeeDto> data);
        bool DeleteEmployee(int employeeId);
        IEnumerable<Employee> GetEmployees();
        #endregion
        // Services
        bool UpSertServices(IEnumerable<ServiceDto> data);
        bool DeleteService(int serviceId);
        IEnumerable<Service> GetServices();
        // Orders
        Order? UpSertOrder(OrderDto data);
        bool DeleteOrder(int orderId);
        IEnumerable<Order> GetOrders();
        IEnumerable<Order> GetOrders(DateTime from, DateTime to);
        IEnumerable<Order> GetOrders(int customerId);
        Order? GetOrder(int orderId);
        bool DeleteOrderServices(IEnumerable<OrderServiceDto> data);
        bool DeleteOrderProducts(IEnumerable<OrderProductDto> data);
        // Appointments
        bool UpSertAppointment(AppointmentDto data);
        bool DeleteAppointment(int appointmentId);
        IEnumerable<Appointment> GetAppointments();
        IEnumerable<Appointment> GetAppointmentsCustomer(int customerId);

        // Discounts
        bool UpSertDiscount(DiscountDto data);
        bool DeleteDiscount(int serviceId, int customerId);

        // Products
        bool UpSertProduct(ProductDto data);
        bool DeleteProduct(int productId);
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetSupplierProducts(int suppliedId);
        bool UpSertStock(StockDto data);

        // Payment Summary
        bool UpSertPaymentSummary(PaymentSummaryDto data);
        bool DeletePaymentSummary(int paymentId);

        // Daily Summary
        DailySummary CalculateDailySummary(DateTime date, decimal dailyCosts);
        IEnumerable<DailySummary> GetDailySummaries();
        IEnumerable<DailySummary> GetDailySummaries(DateTime from, DateTime to);

        IEnumerable<Category> GetCategories();
        bool UpSertCategory(CategoryDto data);
        bool DeleteCategory(int categoryId);
    }
}
