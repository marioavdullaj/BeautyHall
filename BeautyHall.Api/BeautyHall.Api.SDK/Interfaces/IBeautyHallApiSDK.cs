using BeautyHall.Api.SDK.Configuration;
using BeautyHall.Api.SDK.Requests;using BeautyHall.Api.SDK.Responses;namespace BeautyHall.Api.SDK.Interfaces{    public interface IBeautyHallApiSDK    {
        /// <summary>
        /// Login into the system. The function accepts a LoginDto object as input. If the login is successful, it returns a Login object 
        /// containing the user information. If the login fails, it returns null.
        /// </summary>
        /// <param name="login">The LoginDto object containing login credentials</param>
        /// <returns>A Task representing the asynchronous operation. It returns a Login object if successful, otherwise null.</returns>
        Task<Login?> GetLogin(LoginDto login);

        /// <summary>
        /// Add a new user to the system. The function accepts a LoginDto object as input and adds the user to the system. It returns a boolean
        /// indicating whether the user has been successfully added.
        /// </summary>
        /// <param name="login">The LoginDto object containing user information</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the user is added successfully, otherwise false.</returns>
        Task<bool> AddLogin(LoginDto login);

        /// <summary>
        /// Get all subjects in the system. The function retrieves a list of Subject objects representing both clients and suppliers.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation. It returns a list of Subject objects if successful, otherwise null.</returns>
        Task<IEnumerable<Subject>?> GetSubjects();

        /// <summary>
        /// Insert new subjects or update existing ones. The function accepts a list of SubjectDto objects containing client/supplier data.
        /// It inserts new subjects into the system or updates existing subjects. It returns a boolean indicating if the insertion/update
        /// was successful.
        /// </summary>
        /// <param name="subjects">The list of SubjectDto objects containing client/supplier data</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the insertion/update was successful, otherwise false.</returns>
        Task<bool> UpsertSubjects(IEnumerable<SubjectDto> subjects);

        /// <summary>
        /// Delete a subject from the system. The function accepts a subjectId as input and deletes the subject with the corresponding ID
        /// from the system. It returns a boolean indicating if the deletion was successful.
        /// </summary>
        /// <param name="subjectId">The ID of the subject to be deleted</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the deletion was successful, otherwise false.</returns>
        Task<bool> DeleteSubject(int subjectId);

        /// <summary>
        /// Get all employees in the system. The function retrieves a list of Employee objects representing the employees.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation. It returns a list of Employee objects if successful, otherwise null.</returns>
        Task<IEnumerable<Employee>?> GetEmployees();

        /// <summary>
        /// Insert new employees or update existing ones. The function accepts a list of EmployeeDto objects containing employee data.
        /// It inserts new employees into the system or updates existing employees. It returns a boolean indicating if the insertion/update
        /// was successful.
        /// </summary>
        /// <param name="employees">The list of EmployeeDto objects containing employee data</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the insertion/update was successful, otherwise false.</returns>
        Task<bool> UpsertEmployees(IEnumerable<EmployeeDto> employees);

        /// <summary>
        /// Delete an employee from the system. The function accepts an employeeId as input and deletes the employee with the corresponding ID
        /// from the system. It returns a boolean indicating if the deletion was successful.
        /// </summary>
        /// <param name="employeeId">The ID of the employee to be deleted</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the deletion was successful, otherwise false.</returns>
        Task<bool> DeleteEmployee(int employeeId);

        /// <summary>
        /// Get all services in the system. The function retrieves a list of Service objects representing the services.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation. It returns a list of Service objects if successful, otherwise null.</returns>
        Task<IEnumerable<Service>?> GetServices();

        /// <summary>
        /// Insert new services or update existing ones. The function accepts a list of ServiceDto objects containing service data.
        /// It inserts new services into the system or updates existing services. It returns a boolean indicating if the insertion/update
        /// was successful.
        /// </summary>
        /// <param name="services">The list of ServiceDto objects containing service data</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the insertion/update was successful, otherwise false.</returns>
        Task<bool> UpsertServices(IEnumerable<ServiceDto> services);

        /// <summary>
        /// Delete a service from the system. The function accepts a serviceId as input and deletes the service with the corresponding ID
        /// from the system. It returns a boolean indicating if the deletion was successful.
        /// </summary>
        /// <param name="serviceId">The ID of the service to be deleted</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the deletion was successful, otherwise false.</returns>
        Task<bool> DeleteService(int serviceId);

        /// <summary>
        /// Delete a order from the system. The function accepts a orderId as input and deletes the order with the corresponding ID
        /// from the system. It returns a boolean indicating if the deletion was successful.
        /// </summary>
        /// <param name="orderId">The ID of the order to be deleted</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the deletion was successful, otherwise false.</returns>
        Task<bool> DeleteOrder(int orderId);

        /// <summary>
        /// Insert a new order into the system or update an existing one. The function accepts an OrderDto object containing order data.
        /// It inserts a new order into the system or updates an existing order. It returns an Order object if the insertion/update was
        /// successful, otherwise null.
        /// </summary>
        /// <param name="order">The OrderDto object containing order data</param>
        /// <returns>A Task representing the asynchronous operation. It returns an Order object if the insertion/update was successful, otherwise null.</returns>
        Task<Order?> UpsertOrder(OrderDto order);

        /// <summary>
        /// Get all orders for a specific customer. The function accepts a customerId as input and retrieves a list of Order objects
        /// representing the orders associated with the customer.
        /// </summary>
        /// <param name="customerId">The ID of the customer</param>
        /// <returns>A Task representing the asynchronous operation. It returns a list of Order objects if successful, otherwise null.</returns>
        Task<IEnumerable<Order>?> GetCustomerOrders(int customerId);

        /// <summary>
        /// Get a specific order. The function accepts a orderId as input and retrieves an Order object.
        /// </summary>
        /// <param name="orderId">The ID of the order</param>
        /// <returns>A Task representing the asynchronous operation. It returns an Order objects if successful, otherwise null.</returns>
        Task<Order?> GetOrder(int orderId);

        /// <summary>
        /// Get all orders. The function retrieves a list of Order objects from the database.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation. It returns a list of Order objects if successful, otherwise null.</returns>
        Task<IEnumerable<Order>?> GetOrders();
        /// <summary>
        /// Get all orders. The function retrieves a list of Order objects from the database.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation. It returns a list of Order objects if successful, otherwise null.</returns>
        Task<IEnumerable<Order>?> GetOrders(DateTime from, DateTime to);

        /// <summary>
        /// Delete services from an order. The function accepts a list of OrderServiceDto objects containing the services to be deleted
        /// from an order. It removes the specified services from the order and returns a boolean indicating if the deletion was successful.
        /// </summary>
        /// <param name="orderServices">The list of OrderServiceDto objects containing the services to be deleted</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the deletion was successful, otherwise false.</returns>
        Task<bool> DeleteOrderServices(IEnumerable<OrderServiceDto> orderServices);

        /// <summary>
        /// Get all appointments in the system. The function retrieves a list of Appointment objects representing the appointments.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation. It returns a list of Appointment objects if successful, otherwise null.</returns>
        Task<IEnumerable<Appointment>?> GetAppointments();

        /// <summary>
        /// Get all appointments for a specific customer. The function accepts a customerId as input and retrieves a list of Appointment objects
        /// representing the appointments associated with the customer.
        /// </summary>
        /// <param name="customerId">The ID of the customer</param>
        /// <returns>A Task representing the asynchronous operation. It returns a list of Appointment objects if successful, otherwise null.</returns>
        Task<IEnumerable<Appointment>?> GetCustomerAppointments(int customerId);

        /// <summary>
        /// Insert a new appointment into the system or update an existing one. The function accepts an AppointmentDto object containing appointment data.
        /// It inserts a new appointment into the system or updates an existing appointment. It returns a boolean indicating if the insertion/update
        /// was successful.
        /// </summary>
        /// <param name="appointment">The AppointmentDto object containing appointment data</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the insertion/update was successful, otherwise false.</returns>
        Task<bool> UpsertAppointment(AppointmentDto appointment);

        /// <summary>
        /// Delete an appointment from the system. The function accepts an appointmentId as input and deletes the appointment with the corresponding ID
        /// from the system. It returns a boolean indicating if the deletion was successful.
        /// </summary>
        /// <param name="appointmentId">The ID of the appointment to be deleted</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the deletion was successful, otherwise false.</returns>
        Task<bool> DeleteAppointment(int appointmentId);

        /// <summary>
        /// Upsert a discount into the system. The function accepts a DiscountDto object containing discount data.
        /// It inserts a new discount into the system or updates an existing discount. It returns a boolean indicating if the insertion/update
        /// was successful.
        /// </summary>
        /// <param name="discount">The DiscountDto object containing discount data</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the insertion/update was successful, otherwise false.</returns>
        Task<bool> UpsertDiscount(DiscountDto discount);

        /// <summary>
        /// Delete a discount from the system. The function accepts a serviceId and customerId as input and deletes the discount with the corresponding
        /// service ID and customer ID from the system. It returns a boolean indicating if the deletion was successful.
        /// </summary>
        /// <param name="serviceId">The ID of the service for which the discount applies</param>
        /// <param name="customerId">The ID of the customer for whom the discount applies</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the deletion was successful, otherwise false.</returns>
        Task<bool> DeleteDiscount(int serviceId, int customerId);

        /// <summary>
        /// Get all products in the system. The function retrieves a list of Product objects representing the products.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation. It returns a list of Product objects if successful, otherwise null.</returns>
        Task<IEnumerable<Product>?> GetAllProducts();

        /// <summary>
        /// Get all products for a specific supplier. The function accepts a supplierId as input and retrieves a list of Product objects
        /// representing the products associated with the supplier.
        /// </summary>
        /// <param name="supplierId">The ID of the supplier</param>
        /// <returns>A Task representing the asynchronous operation. It returns a list of Product objects if successful, otherwise null.</returns>
        Task<IEnumerable<Product>?> GetSupplierProducts(int supplierId);

        /// <summary>
        /// Upsert a product into the system. The function accepts a ProductDto object containing product data.
        /// It inserts a new product into the system or updates an existing product. It returns a boolean indicating if the insertion/update
        /// was successful.
        /// </summary>
        /// <param name="product">The ProductDto object containing product data</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the insertion/update was successful, otherwise false.</returns>
        Task<bool> UpsertProduct(ProductDto product);

        /// <summary>
        /// Delete a product from the system. The function accepts a productId as input and deletes the product with the corresponding ID
        /// from the system. It returns a boolean indicating if the deletion was successful.
        /// </summary>
        /// <param name="productId">The ID of the product to be deleted</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the deletion was successful, otherwise false.</returns>
        Task<bool> DeleteProduct(int productId);

        /// <summary>
        /// Upsert stock into the system. The function accepts a StockDto object containing stock data.
        /// It inserts new stock into the system or updates existing stock. It returns a boolean indicating if the insertion/update
        /// was successful.
        /// </summary>
        /// <param name="stock">The StockDto object containing stock data</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the insertion/update was successful, otherwise false.</returns>
        Task<bool> UpsertStock(StockDto stock);

        /// <summary>
        /// Upsert a payment summary into the system. The function accepts a PaymentSummaryDto object containing payment summary data.
        /// It inserts a new payment summary into the system or updates an existing payment summary. It returns a boolean indicating if the insertion/update
        /// was successful.
        /// </summary>
        /// <param name="paymentSummary">The PaymentSummaryDto object containing payment summary data</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the insertion/update was successful, otherwise false.</returns>
        Task<bool> UpsertPayment(PaymentSummaryDto paymentSummary);

        /// <summary>
        /// Delete a payment from the system. The function accepts a paymentId as input and deletes the payment with the corresponding ID
        /// from the system. It returns a boolean indicating if the deletion was successful.
        /// </summary>
        /// <param name="paymentId">The ID of the payment to be deleted</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the deletion was successful, otherwise false.</returns>
        Task<bool> DeletePayment(int paymentId);

        /// <summary>
        /// Get all daily summaries in the system. The function retrieves a list of DailySummary objects representing the daily summaries.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation. It returns a list of DailySummary objects if successful, otherwise null.</returns>
        Task<IEnumerable<DailySummary>?> GetDailySummaries();

        /// <summary>
        /// Get daily summaries within a specific date range. The function accepts from and to dates as input and retrieves a list of DailySummary objects
        /// representing the daily summaries within the specified date range.
        /// </summary>
        /// <param name="from">The starting date of the range</param>
        /// <param name="to">The ending date of the range</param>
        /// <returns>A Task representing the asynchronous operation. It returns a list of DailySummary objects if successful, otherwise null.</returns>
        Task<IEnumerable<DailySummary>?> GetDailySummaries(DateTime from, DateTime to);

        /// <summary>
        /// Calculate a daily summary for a specific date. The function accepts a date and daily costs as input and calculates a DailySummary object
        /// representing the summary for the specified date.
        /// </summary>
        /// <param name="date">The date for which the summary is calculated</param>
        /// <param name="dailyCosts">The total daily costs</param>
        /// <returns>A Task representing the asynchronous operation. It returns a DailySummary object if successful, otherwise null.</returns>
        Task<DailySummary?> CalculateDailySummary(DateTime date, decimal dailyCosts);

        /// <summary>
        /// Get all categories in the system. The function retrieves a list of Category objects representing the categories.
        /// </summary>
        /// <returns>A Task representing the asynchronous operation. It returns a list of Category objects if successful, otherwise null.</returns>
        Task<IEnumerable<Category>?> GetCategories();

        /// <summary>
        /// Upsert a category into the system. The function accepts a CategoryDto object containing category data.
        /// It inserts a new category into the system or updates an existing category. It returns a boolean indicating if the insertion/update
        /// was successful.
        /// </summary>
        /// <param name="category">The CategoryDto object containing ccategory data</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the insertion/update was successful, otherwise false.</returns>
        Task<bool> UpsertCategory(CategoryDto category);
        /// <summary>
        /// Delete a category from the system. The function accepts a categoryId as input and deletes the category with the corresponding ID
        /// from the system. It returns a boolean indicating if the deletion was successful.
        /// </summary>
        /// <param name="categoryId">The ID of the category to be deleted</param>
        /// <returns>A Task representing the asynchronous operation. It returns true if the deletion was successful, otherwise false.</returns>
        Task<bool> DeleteCategory(int categoryId);    }}