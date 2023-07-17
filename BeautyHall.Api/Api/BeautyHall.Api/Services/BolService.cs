using BeautyHall.Api.DB.Utils;
using BeautyHall.Models.Common.Interfaces;
using BeautyHall.Models.Db;
using BeautyHall.Models.Db.Models;
using BeautyHall.Models.Dto.Requests;
using System.Reflection.Metadata;
using System.Transactions;

namespace BeautyHall.Api.DB.Services
{
    public class BolService : IBolDbService
    {
        private readonly IDBService DbService;
        public BolService(IDBService dbService)
        {
            DbService = dbService;
        }

        #region Login
        public Login? Login(string? username, string? password)
        {
            var filters = new List<FilterSetting>
            {
                new FilterSetting { Comparisation = ECompareType.Equal, Value = username, Key = "Username" },
                new FilterSetting { Comparisation = ECompareType.Equal, Value = password, Key = "Password" }
            };
            var results = DbService.Search<Login>(filters);
            if (results != null && results.Count() == 1)
            {
                var login = (results as IEnumerable<Login>).First();
                login.Password = null;
                return login;
            }
            return null;
        }

        public bool UpSertLogin(LoginDto data)
        {
            return DbService.UpSert(Mappers.Map(data));
        }
        #endregion

        #region Subjects
        /// <summary>
        /// Inserisce o aggiorna un soggetto
        /// </summary>
        /// <param name="datas"></param>
        /// <returns></returns>
        public bool UpSertSubjects(IEnumerable<SubjectDto> datas)
        {
            foreach (var data in datas)
            {
                if (!DbService.UpSert(Mappers.Map(data)))
                    return false;
            }
            return true;
        }

        public bool DeleteSubject(int subjectId)
        {
            return DbService.Delete(new Subject { SubjectId = subjectId });
        }
        public IEnumerable<Subject> GetSubjects()
        {
            var res = DbService.Search<Subject>(filters: null);
            return (res as IEnumerable<Subject>);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            var res = DbService.Search<Employee>(filters: null);
            return (res as IEnumerable<Employee>);
        }

        public bool UpSertEmployees(IEnumerable<EmployeeDto> datas)
        {
            foreach (var data in datas)
            {
                if (!DbService.UpSert(Mappers.Map(data)))
                    return false;
            }
            return true;
        }

        public bool DeleteEmployee(int employeeId)
        {
            return DbService.Delete(new Employee { EmployeeId = employeeId });
        }
        #endregion

        public IEnumerable<Service> GetServices()
        {
            var res = DbService.Search<Service>(filters: null);
            return (res as IEnumerable<Service>);
        }

        public bool UpSertServices(IEnumerable<ServiceDto> datas)
        {
            foreach (var data in datas)
            {
                if (!DbService.UpSert(Mappers.Map(data)))
                    return false;
            }
            return true;
        }

        public bool DeleteService(int serviceId)
        {
            return DbService.Delete(new Service { ServiceId = serviceId });
        }

        public IEnumerable<Order> GetOrders()
        {
            var res = DbService.Search<Order>(filters: null);
            return (res as IEnumerable<Order>);
        }
        public IEnumerable<Order> GetOrders(int customerId)
        {
            var res = DbService.Search<Order>(new List<FilterSetting>
            {
                new FilterSetting { Comparisation = ECompareType.Equal, Key = "CustomerId", Value = customerId }
            });
            return (res as IEnumerable<Order>);
        }
        public IEnumerable<Order> GetOrders(DateTime from, DateTime to)
        {
            var res = DbService.Search<Order>(new List<FilterSetting>
            {
                new FilterSetting { Comparisation = ECompareType.GreaterThanOrEqual, Key = "OrderDate", Value = from },
                new FilterSetting { Comparisation = ECompareType.LessThanOrEqual, Key = "OrderDate", Value = to }
            });
            return (res as IEnumerable<Order>);
        }
        public Order? GetOrder(int orderId)
        {
            var res = DbService.Search<Order>(new List<FilterSetting>
            {
                new FilterSetting { Comparisation = ECompareType.Equal, Key = "OrderId", Value = orderId }
            });
            return (res as IEnumerable<Order>).FirstOrDefault();
        }

        public Order? UpSertOrder(OrderDto data)
        {
            Order order = Mappers.Map(data);

            using (var scope = new TransactionScope())
            {
                try
                {
                    if (DbService.UpSert(order))
                    {
                        if (data.Services != null)
                        {
                            var orderServices = data.Services.Select(x => new OrderService
                            {
                                ServiceId = x.ServiceId,
                                EmployeeId = x.EmployeeId,
                                OrderId = order.OrderId,
                                ServicePrice = x.ServicePrice
                            });

                            // get current order's services
                            var searchOrders = DbService.Search<Order>(new List<FilterSetting>
                            {
                                new FilterSetting{ Comparisation = ECompareType.Equal, Key = "OrderId", Value = data.OrderId }
                            });
                            if(searchOrders != null && searchOrders.Count() == 1)
                            {
                                order = (searchOrders as IEnumerable<Order>).First();
                                var currentOrderServices = order.OrderServices.ToList();
                                var servicesToRemove = currentOrderServices.Where(x => !orderServices.Any(y => y.ServiceId == x.ServiceId));
                                if (servicesToRemove != null)
                                    foreach (var service in servicesToRemove)
                                        DbService.Delete<OrderService>(service);
                            }

                            foreach (var os in orderServices)
                            {
                                DbService.UpSert(os);
                            }
                        }

                        scope.Complete();
                    }
                }
                catch (Exception)
                {
                    scope.Dispose();
                    return null;
                }
            }

            return order;
        }

        public bool DeleteOrder(int orderId)
        {
            return DbService.Delete(new Order { OrderId = orderId });
        }

        public bool DeleteOrderServices(IEnumerable<OrderServiceDto> data)
        {
            foreach (var orderservice in data)
            {
                if (!DbService.Delete(Mappers.Map(orderservice)))
                    return false;
            }
            return true;
        }

        public IEnumerable<Appointment> GetAppointments()
        {
            var res = DbService.Search<Appointment>(filters: null);
            return (res as IEnumerable<Appointment>);
        }
        public IEnumerable<Appointment> GetAppointmentsCustomer(int customerId)
        {
            var res = DbService.Search<Appointment>(new List<FilterSetting>
            {
                new FilterSetting{ Comparisation = ECompareType.Equal, Key = "CustomerId", Value = customerId } 
            });
            return (res as IEnumerable<Appointment>);
        }

        public bool UpSertAppointment(AppointmentDto data)
        {
            return DbService.UpSert(Mappers.Map(data));
        }

        public bool DeleteAppointment(int appointmentId)
        {
            return DbService.Delete(new Appointment { AppointmentId = appointmentId });
        }


        public bool UpSertDiscount(DiscountDto data)
        {
            return DbService.UpSert(Mappers.Map(data));
        }

        public bool DeleteDiscount(int serviceId, int customerId)
        {
            return DbService.Delete(new Discount { ServiceId = serviceId, CustomerId = customerId });
        }

        // Products

        public IEnumerable<Product> GetAllProducts()
        {
            var res = DbService.Search<Product>(filters: null);
            return (res as IEnumerable<Product>);
        }
        public IEnumerable<Product> GetSupplierProducts(int supplierId)
        {
            var res = DbService.Search<Product>(new List<FilterSetting>
            {
                new FilterSetting{ Comparisation = ECompareType.Equal, Key = "SuppliedId", Value = supplierId }
            });
            return (res as IEnumerable<Product>);
        }

        public bool UpSertProduct(ProductDto data)
        {
            return DbService.UpSert(Mappers.Map(data));
        }

        public bool DeleteProduct(int productId)
        {
            return DbService.Delete(new Product { ProductId = productId });
        }
        public bool UpSertStock(StockDto data)
        {
            return DbService.UpSert(Mappers.Map(data));
        }

        // PaymentSummary
        public bool UpSertPaymentSummary(PaymentSummaryDto data)
        {
            return DbService.UpSert(Mappers.Map(data));
        }

        public bool DeletePaymentSummary(int paymentId)
        {
            return DbService.Delete(new PaymentSummary { PaymentId = paymentId });
        }

        public DailySummary CalculateDailySummary(DateTime date, decimal dailyCosts)
        {
            DailySummary dailySummary = new()
            {
                SummaryDate = date,
                TotalCash = 0,
                TotalCashNet = 0,
                TotalGross = 0,
                TotalNet = 0,
                TotalPos = 0,
                DailyCosts = dailyCosts
            };
            var p = DbService.Search<PaymentSummary>(new List<FilterSetting>
            {
                new FilterSetting{Comparisation = ECompareType.SameDay, Key = "PaymentDate", Value=date }
            });
            if (p != null)
            {
                var payments = (p as IEnumerable<PaymentSummary>).ToList();

                var totalCash = payments.Sum(x => x.TotalCash);
                var totalCashNet = totalCash - dailyCosts;
                var totalGross = payments.Sum(x => x.DiscountedPrice > 0 ? x.DiscountedPrice??0 : x.TotalPrice);
                var totalNet = totalGross - dailyCosts;
                var totalPos = payments.Sum(x => x.TotalPOS);

                dailySummary.TotalPos = totalPos;
                dailySummary.TotalCashNet = totalCashNet;
                dailySummary.TotalGross = totalGross;
                dailySummary.TotalNet = totalNet;
                dailySummary.TotalCash = totalCash;
            }

            DbService.UpSert(dailySummary);

            return dailySummary;
        }

        public IEnumerable<DailySummary> GetDailySummaries()
        {
            var res = DbService.Search<DailySummary>(filters:null);
            return (res as IEnumerable<DailySummary>);
        }

        public IEnumerable<DailySummary> GetDailySummaries(DateTime from, DateTime to)
        {
            var res = DbService.Search<DailySummary>(new List<FilterSetting>
            {
                new FilterSetting{ Comparisation = ECompareType.GreaterThanOrEqual, Key = "SummaryDate", Value = to },
                new FilterSetting{ Comparisation = ECompareType.LessThanOrEqual, Key = "SummaryDate", Value = from }
            });
            return (res as IEnumerable<DailySummary>);
        }

        public IEnumerable<Category> GetCategories()
        {
            var res = DbService.Search<Category>(filters: null);
            return (res as IEnumerable<Category>);
        }

        public bool UpSertCategory(CategoryDto data)
        {
            return DbService.UpSert(Mappers.Map(data));
        }

        public bool DeleteCategory(int categoryId)
        {
            return DbService.Delete(new Category { CategoryId = categoryId });
        }
    }
}