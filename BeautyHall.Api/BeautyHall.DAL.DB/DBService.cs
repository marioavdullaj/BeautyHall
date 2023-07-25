using BeautyHall.Models.Common.Interfaces;
using BeautyHall.Models.Db.Models;
using BeautyHall.Models.Db;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections;

namespace BeautyHall.DAL.DB
{
    public class DBService : IDBService
    {
        private readonly IConfiguration Configuration;
        private readonly BeautyHallContext Context;
        public DBService(IConfiguration config)
        {
            Configuration = config;
            Context = new BeautyHallContext(Configuration);
        }

        /// <summary>
        /// Execute the context reset
        /// </summary>
        private void DiscardChanges()
        {
            Context.ChangeTracker.Entries()
                .Where(e => e.Entity != null).ToList()
                .ForEach(e => e.State = EntityState.Detached);
        }

        public bool UpSert<TObject>(TObject value, string companyId = "")
        {
            bool ret = false;
            try
            {
                if (value.GetType() == typeof(Subject)) ret = UpSertSubject(value as Subject);
                if (value.GetType() == typeof(Appointment)) ret = UpSertAppointment(value as Appointment);
                if (value.GetType() == typeof(DailySummary)) ret = UpSertDailySummary(value as DailySummary);
                if (value.GetType() == typeof(Discount)) ret = UpSertDiscount(value as Discount);
                if (value.GetType() == typeof(Employee)) ret = UpSertEmployee(value as Employee);
                if (value.GetType() == typeof(Login)) ret = UpSertLogin(value as Login);
                if (value.GetType() == typeof(Order)) ret = UpSertOrder(value as Order);
                if (value.GetType() == typeof(OrderService)) ret = UpSertOrderService(value as OrderService);
                if (value.GetType() == typeof(PaymentSummary)) ret = UpSertPaymentSummary(value as PaymentSummary);
                if (value.GetType() == typeof(Service)) ret = UpSertService(value as Service);
                if (value.GetType() == typeof(Stock)) ret = UpSertSubject(value as Subject);
                if (value.GetType() == typeof(Product)) ret = UpSertProduct(value as Product);
                if (value.GetType() == typeof(Category)) ret = UpSertCategory(value as Category);
            }
            catch (Exception ex)
            {
                DiscardChanges();
                throw new Exception("Errors on upsert, see InnerException", ex);
            }

            return ret;
        }
        public bool Delete<TObject>(TObject value)
        {
            bool ret = false;
            try
            {
                if (value?.GetType() == typeof(Subject)) ret = DeleteSubject(value as Subject);
                if (value?.GetType() == typeof(Appointment)) ret = DeleteAppointment(value as Appointment);
                if (value?.GetType() == typeof(DailySummary)) ret = DeleteDailySummary(value as DailySummary);
                if (value?.GetType() == typeof(Discount)) ret = DeleteDiscount(value as Discount);
                if (value?.GetType() == typeof(Employee)) ret = DeleteEmployee(value as Employee);
                if (value?.GetType() == typeof(Login)) ret = DeleteLogin(value as Login);
                if (value?.GetType() == typeof(Order)) ret = DeleteOrder(value as Order);
                if (value?.GetType() == typeof(OrderService)) ret = DeleteOrderService(value as OrderService);
                if (value?.GetType() == typeof(PaymentSummary)) ret = DeletePaymentSummary(value as PaymentSummary);
                if (value?.GetType() == typeof(Product)) ret = DeleteProduct(value as Product);
                if (value?.GetType() == typeof(Service)) ret = DeleteService(value as Service);
                if (value?.GetType() == typeof(Stock)) ret = DeleteStock(value as Stock);
                if (value?.GetType() == typeof(Category)) ret = DeleteCategory(value as Category);
            }
            catch (Exception ex)
            {
                DiscardChanges();
                throw new Exception("Errors on delete, see InnerException", ex);
            }

            return ret;

        }
        public IEnumerable<object> Search<TObject>(List<FilterSetting> filters)
        {
            IEnumerable<object> ret = null;
            List<SqlParameter> parameters;
            string clause = CalculateWhereClause(filters, out parameters);
            if (typeof(TObject) == typeof(Subject)) ret = SearchSubject(clause, parameters);
            if (typeof(TObject) == typeof(Appointment)) ret = SearchAppointment(clause, parameters);
            if (typeof(TObject) == typeof(Employee)) ret = SearchEmployee(clause, parameters);
            if (typeof(TObject) == typeof(Order)) ret = SearchOrder(clause, parameters);
            if (typeof(TObject) == typeof(Service)) ret = SearchService(clause, parameters);
            if (typeof(TObject) == typeof(Product)) ret = SearchProduct(clause, parameters);
            if (typeof(TObject) == typeof(Stock)) ret = SearchStock(clause, parameters);
            if (typeof(TObject) == typeof(PaymentSummary)) ret = SearchPaymentSummary(clause, parameters);
            if (typeof(TObject) == typeof(OrderService)) ret = SearchOrderService(clause, parameters);
            if (typeof(TObject) == typeof(Discount)) ret = SearchDiscount(clause, parameters);
            if (typeof(TObject) == typeof(Login)) ret = SearchLogin(clause, parameters);
            if (typeof(TObject) == typeof(DailySummary)) ret = SearchDailySummary(clause, parameters);
            if (typeof(TObject) == typeof(Category)) ret = SearchCategories(clause, parameters);

            return ret;
        }

        #region Private Methods
        private string CalculateWhereClause(List<FilterSetting> filters, out List<SqlParameter> parameters)
        {
            string ret = string.Empty;
            parameters = null;
            if ((filters == null) || (filters.Count == 0))
                return ret;
            parameters = new List<SqlParameter>();
            ret = " WHERE ";
            foreach (var filter in filters)
            {
                if (ret != " WHERE ")
                    ret += " AND ";

                if(filter.Comparisation == ECompareType.SameDay)
                {
                    var parameterName = $"@{filter.Key}";
                    ret += $"( MONTH([{filter.Key}]) = MONTH({parameterName})" +
                        $" AND DAY([{filter.Key}]) = DAY({parameterName})" +
                        $" AND YEAR([{filter.Key}]) = YEAR({parameterName}) ) ";

                    parameters.Add(new SqlParameter() { ParameterName = parameterName, Value = filter.Value });
                }
                else
                {
                    ret += $"[{filter.Key}]";
                    switch (filter.Comparisation)
                    {
                        case ECompareType.Equal: ret += " = "; break;
                        case ECompareType.NotEqual: ret += " <> "; break;
                        case ECompareType.GreaterThanOrEqual: ret += " >= "; break;
                        case ECompareType.GreaterThan: ret += " > "; break;
                        case ECompareType.LessThanOrEqual: ret += " <= "; break;
                        case ECompareType.LessThan: ret += " < "; break;
                        case ECompareType.In: ret += ret += " IN "; break;
                        case ECompareType.NotIn: ret += ret += " NOT IN "; break;
                        case ECompareType.Contains:
                            if (filter.Value.GetType() == typeof(string))
                                ret += " LIKE ";
                            else
                                ret += " IN ";
                            break;
                        case ECompareType.NotContains:
                            if (filter.Value.GetType() == typeof(string))
                                ret += " NOT LIKE ";
                            else
                                ret += " NOT IN ";
                            break;
                    }

                    var parameterName = $"@{filter.Key}";
                    var count = parameters.Where(x => x.ParameterName == parameterName).Count();
                    if(count > 0)
                    {
                        parameterName = $"{parameterName}_{count}";
                    }
                    if (filter.Comparisation == ECompareType.Contains || filter.Comparisation == ECompareType.NotContains)
                    {

                        if (filter.Value.GetType() == typeof(string))
                        {
                            ret += parameterName;
                            parameters.Add(new SqlParameter() { ParameterName = parameterName, SqlDbType = System.Data.SqlDbType.NVarChar, Value = $"%{filter.Value}%" });
                        }
                        else
                        {
                            if (filter.Value.GetType().IsArray ||
                                filter.Value.GetType().IsSZArray ||
                                filter.Value.GetType().IsVariableBoundArray ||
                                filter.Value is IEnumerable)
                            {
                                ret += "(";
                                int index = 0;
                                foreach (var value in (filter.Value as IEnumerable<object>))
                                {
                                    parameters.Add(new SqlParameter() { ParameterName = $"{parameterName}_{index}", Value = $"{value}" });
                                    index++;
                                }
                                ret += string.Join(", ", parameters.Select(p => p.ParameterName));
                                ret += ")";
                            }
                            else
                            {
                                ret += $"({parameterName})";
                                parameters.Add(new SqlParameter() { ParameterName = parameterName, Value = filter.Value });
                            }

                        }
                    }
                    else
                    {
                        ret += parameterName;
                        parameters.Add(new SqlParameter() { ParameterName = parameterName, Value = filter.Value });
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Upserts a subject
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool UpSertSubject(Subject input)
        {
            if (Context.Subjects.Any(item => item.SubjectId == input.SubjectId))
            {
                var item = Context.Subjects.First(item => item.SubjectId == input.SubjectId);
                item.SubjectType = input.SubjectType;
                item.PhoneNumber = input.PhoneNumber;
                item.Email = input.Email;
                item.SubjectName = input.SubjectName;
                item.SubjectLastName = input.SubjectLastName;
                item.RegistrationDate = input.RegistrationDate;
                Context.Subjects.Update(item);
            }

            else
                Context.Subjects.Add(input);

            return Context.SaveChanges() > 0;
        }
        /// <summary>
        /// Delete a subject on the db
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool DeleteSubject(Subject input)
        {
            bool ret = false;

            if (Context.Subjects.Any(item => item.SubjectId == input.SubjectId))
            {
                Context.Subjects.Remove(input);
                ret = Context.SaveChanges() > 0;
            }

            return ret;
        }

        private bool DeleteAppointment(Appointment input)
        {
            bool ret = false;

            if (Context.Appointments.Any(item => item.AppointmentId == input.AppointmentId))
            {
                Context.Appointments.Remove(input);
                ret = Context.SaveChanges() > 0;
            }

            return ret;
        }

        private bool DeleteDailySummary(DailySummary input)
        {
            bool ret = false;

            if (Context.DailySummaries.Any(item => item.SummaryDate == input.SummaryDate))
            {
                Context.DailySummaries.Remove(input);
                ret = Context.SaveChanges() > 0;
            }

            return ret;
        }

        private bool DeleteDiscount(Discount input)
        {
            bool ret = false;

            if (Context.Discounts.Any(item => item.ServiceId == input.ServiceId && item.CustomerId == input.CustomerId))
            {
                Context.Discounts.Remove(input);
                ret = Context.SaveChanges() > 0;
            }

            return ret;
        }

        private bool DeleteEmployee(Employee input)
        {
            bool ret = false;

            if (Context.Employees.Any(item => item.EmployeeId == input.EmployeeId))
            {
                Context.Employees.Remove(input);
                ret = Context.SaveChanges() > 0;
            }

            return ret;
        }

        private bool DeleteLogin(Login input)
        {
            bool ret = false;

            if (Context.Logins.Any(item => item.Id == input.Id))
            {
                Context.Logins.Remove(input);
                ret = Context.SaveChanges() > 0;
            }

            return ret;
        }

        private bool DeleteOrder(Order input)
        {
            bool ret = false;
            if (Context.Orders.Any(item => item.OrderId == input.OrderId))
            {
                Context.Orders.Remove(input);
                ret = Context.SaveChanges() > 0;
            }

            return ret;
        }

        private bool DeleteOrderService(OrderService input)
        {
            bool ret = false;

            if (Context.OrderServices.Any(item => item.OrderId == input.OrderId && item.ServiceId == input.ServiceId))
            {
                Context.OrderServices.Remove(input);
                ret = Context.SaveChanges() > 0;
            }

            return ret;
        }

        private bool DeletePaymentSummary(PaymentSummary input)
        {
            bool ret = false;

            var payment = Context.PaymentSummaries.Where(item => item.PaymentId == input.PaymentId).FirstOrDefault();
            if (payment != null)
            {
                Context.PaymentSummaries.Remove(payment);
                ret = Context.SaveChanges() > 0;
            }

            return ret;
        }

        private bool DeleteProduct(Product input)
        {
            bool ret = false;

            if (Context.Products.Any(item => item.ProductId == input.ProductId))
            {
                Context.Products.Remove(input);
                ret = Context.SaveChanges() > 0;
            }

            return ret;
        }

        private bool DeleteService(Service input)
        {
            bool ret = false;

            if (Context.Services.Any(item => item.ServiceId == input.ServiceId))
            {
                Context.Services.Remove(input);
                ret = Context.SaveChanges() > 0;
            }

            return ret;
        }

        private bool DeleteStock(Stock input)
        {
            bool ret = false;

            if (Context.Stocks.Any(item => item.ProductId == input.ProductId))
            {
                Context.Stocks.Remove(input);
                ret = Context.SaveChanges() > 0;
            }

            return ret;
        }

        private bool DeleteCategory(Category input)
        {
            bool ret = false;

            if (Context.Categories.Any(item => item.CategoryId == input.CategoryId))
            {
                Context.Categories.Remove(input);
                ret = Context.SaveChanges() > 0;
            }

            return ret;
        }
        /// <summary>
        /// Research the subjects over the db
        /// </summary>
        /// <param name="clause"></param>
        /// <returns></returns>
        private IEnumerable<Subject> SearchSubject(string clause, List<SqlParameter> parameters)
        {
            IEnumerable<Subject> ret;

            if (string.IsNullOrWhiteSpace(clause))
                ret = Context.Subjects
                    .Include(x => x.Discounts);
            else
                ret = Context.Subjects.FromSqlRaw($"SELECT * FROM Subjects {clause}", parameters.ToArray())
                    .Include(x => x.Discounts);

            return ret;
        }

        private bool UpSertLogin(Login input)
        {
            if (Context.Logins.Any(item => item.Id == input.Id))
            {
                var item = Context.Logins.First(item => item.Id == input.Id);
                item.Password = input.Password;
                item.Username = input.Username;
                item.Name = input.Name;
                Context.Logins.Update(item);
            }

            else
                Context.Logins.Add(input);

            return Context.SaveChanges() > 0;
        }

        private IEnumerable<Login> SearchLogin(string clause, List<SqlParameter> parameters)
        {
            IEnumerable<Login> ret = new List<Login>();

            if(!string.IsNullOrWhiteSpace(clause))
                ret = Context.Logins.FromSqlRaw($"SELECT * FROM Login {clause}", parameters.ToArray());

            return ret;
        }

        private IEnumerable<Appointment> SearchAppointment(string clause, List<SqlParameter> parameters)
        {
            IEnumerable<Appointment> ret;

            if (string.IsNullOrWhiteSpace(clause))
                ret = Context.Appointments
                    .Include(x => x.Customer)
                    .Include(x => x.Order);
            else
                ret = Context.Appointments.FromSqlRaw($"SELECT * FROM Appointment {clause}", parameters.ToArray())
                    .Include(x => x.Customer)
                    .Include(x => x.Order);

            return ret;
        }
        private IEnumerable<DailySummary> SearchDailySummary(string clause, List<SqlParameter> parameters)
        {
            IEnumerable<DailySummary> ret;

            if (string.IsNullOrWhiteSpace(clause))
                ret = Context.DailySummaries;
            else
                ret = Context.DailySummaries.FromSqlRaw($"SELECT * FROM [Daily_Summary] {clause}", parameters.ToArray());

            return ret;
        }
        private IEnumerable<Discount> SearchDiscount(string clause, List<SqlParameter> parameters)
        {
            IEnumerable<Discount> ret;

            if (string.IsNullOrWhiteSpace(clause))
                ret = Context.Discounts
                    .Include(x => x.Service)
                    .Include(x => x.Customer);
            else
                ret = Context.Discounts.FromSqlRaw($"SELECT * FROM Discount {clause}", parameters.ToArray())
                    .Include(x => x.Service)
                    .Include(x => x.Customer);

            return ret;
        }
        private IEnumerable<Employee> SearchEmployee(string clause, List<SqlParameter> parameters)
        {
            IEnumerable<Employee> ret;

            if (string.IsNullOrWhiteSpace(clause))
                ret = Context.Employees
                    .Include(x => x.Services);
            else
                ret = Context.Employees.FromSqlRaw($"SELECT * FROM Employee {clause}", parameters.ToArray())
                    .Include(x => x.Services);

            return ret;
        }
        private IEnumerable<Order> SearchOrder(string clause, List<SqlParameter> parameters)
        {
            IEnumerable<Order> ret;

            if (string.IsNullOrWhiteSpace(clause))
                ret = Context.Orders
                    .Include(x => x.OrderServices)
                    .ThenInclude(x => x.Service)
                    .Include(x => x.Customer)
                    .Include(x => x.PaymentSummaries)
                    .Select(c => new Order { 
                        OrderId = c.OrderId,
                        CustomerId = c.CustomerId,
                        OrderDate = c.OrderDate,
                        Notes = c.Notes,
                        OrderServices = c.OrderServices.Select(os => new OrderService
                        {
                            OrderId=os.OrderId,
                            ServiceId=os.ServiceId,
                            ServicePrice=os.ServicePrice,
                            EmployeeId=os.EmployeeId,
                            Employee = os.Employee == null ? null : new Employee
                            {
                                EmployeeId = os.Employee.EmployeeId,
                                EmployeeName = os.Employee.EmployeeName,
                                EmployeeLastName = os.Employee.EmployeeLastName,
                                EmployeePhone = os.Employee.EmployeePhone,
                                EmployeeRole = os.Employee.EmployeeRole
                            },
                            Service = new Service
                            {
                                ServiceId = os.Service.ServiceId,
                                ServiceCode = os.Service.ServiceCode,
                                ServiceDescription = os.Service.ServiceDescription,
                                ServiceNotes = os.Service.ServiceNotes,
                                ServiceMinimumPrice = os.Service.ServiceMinimumPrice,
                                ServiceMaximumPrice = os.Service.ServiceMaximumPrice,
                                CategoryId = os.Service.CategoryId,
                                Category = os.Service.Category
                            }
                        }).ToList(),
                        Customer = c.Customer == null ? null : new Subject
                        {
                            SubjectId = c.Customer.SubjectId,
                            SubjectName = c.Customer.SubjectName,
                            SubjectLastName = c.Customer.SubjectLastName,
                            PhoneNumber = c.Customer.PhoneNumber,
                            SubjectType = c.Customer.SubjectType,
                            Email = c.Customer.Email,
                            RegistrationDate = c.Customer.RegistrationDate
                        },
                        PaymentSummaries = c.PaymentSummaries
                    });
            else
                ret = Context.Orders.FromSqlRaw($"SELECT * FROM [Order] {clause}", parameters.ToArray())
                    .Include(x => x.OrderServices)
                    .ThenInclude(x => x.Service)
                    .Include(x => x.Customer)
                    .Include(x => x.PaymentSummaries)
                    .Select(c => new Order
                    {
                        OrderId = c.OrderId,
                        CustomerId = c.CustomerId,
                        OrderDate = c.OrderDate,
                        Notes = c.Notes,
                        OrderServices = c.OrderServices.Select(os => new OrderService
                        {
                            OrderId = os.OrderId,
                            ServiceId = os.ServiceId,
                            ServicePrice = os.ServicePrice,
                            EmployeeId = os.EmployeeId,
                            Employee = os.Employee == null ? null : new Employee
                            {
                                EmployeeId = os.Employee.EmployeeId,
                                EmployeeName = os.Employee.EmployeeName,
                                EmployeeLastName = os.Employee.EmployeeLastName,
                                EmployeePhone = os.Employee.EmployeePhone,
                                EmployeeRole = os.Employee.EmployeeRole
                            },
                            Service = new Service
                            {
                                ServiceId = os.Service.ServiceId,
                                ServiceCode = os.Service.ServiceCode,
                                ServiceDescription = os.Service.ServiceDescription,
                                ServiceNotes = os.Service.ServiceNotes,
                                ServiceMinimumPrice = os.Service.ServiceMinimumPrice,
                                ServiceMaximumPrice = os.Service.ServiceMaximumPrice,
                                CategoryId = os.Service.CategoryId,
                                Category = os.Service.Category
                            }
                        }).ToList(),
                        Customer = c.Customer == null ? null : new Subject
                        {
                            SubjectId = c.Customer.SubjectId,
                            SubjectName = c.Customer.SubjectName,
                            SubjectLastName = c.Customer.SubjectLastName,
                            PhoneNumber = c.Customer.PhoneNumber,
                            SubjectType = c.Customer.SubjectType,
                            Email = c.Customer.Email,
                            RegistrationDate = c.Customer.RegistrationDate
                        },
                        PaymentSummaries = c.PaymentSummaries
                    });

            return ret;
        }
        private IEnumerable<OrderService> SearchOrderService(string clause, List<SqlParameter> parameters)
        {
            IEnumerable<OrderService> ret;

            if (string.IsNullOrWhiteSpace(clause))
                ret = Context.OrderServices;
            else
                ret = Context.OrderServices.FromSqlRaw($"SELECT * FROM Order_Service {clause}", parameters.ToArray());

            return ret;
        }
        private IEnumerable<PaymentSummary> SearchPaymentSummary(string clause, List<SqlParameter> parameters)
        {
            IEnumerable<PaymentSummary> ret;

            if (string.IsNullOrWhiteSpace(clause))
                ret = Context.PaymentSummaries;
            else
                ret = Context.PaymentSummaries.FromSqlRaw($"SELECT * FROM [Payment_Summary] {clause}", parameters.ToArray());

            return ret;
        }
        private IEnumerable<Product> SearchProduct(string clause, List<SqlParameter> parameters)
        {
            IEnumerable<Product> ret;

            if (string.IsNullOrWhiteSpace(clause))
                ret = Context.Products
                    .Include(x => x.Supplier)
                    .Include(x => x.Stock);
            else
                ret = Context.Products.FromSqlRaw($"SELECT * FROM Product {clause}", parameters.ToArray())
                    .Include(x => x.Supplier)
                    .Include(x => x.Stock);

            return ret;
        }

        private IEnumerable<Category> SearchCategories(string clause, List<SqlParameter> parameters)
        {
            IEnumerable<Category> ret;

            if (string.IsNullOrWhiteSpace(clause))
                ret = Context.Categories
                    .Include(x => x.Services).ThenInclude(x => x.Employees);
            else
                ret = Context.Categories.FromSqlRaw($"SELECT * FROM Category {clause}", parameters.ToArray())
                    .Include(x => x.Services).ThenInclude(x => x.Employees); ;

            return ret;
        }
        private IEnumerable<Service> SearchService(string clause, List<SqlParameter> parameters)
        {
            IEnumerable<Service> ret;

            if (string.IsNullOrWhiteSpace(clause))
                ret = Context.Services.AsNoTracking().Include(x => x.Employees).Include(x => x.Category);
            else
                ret = Context.Services.FromSqlRaw($"SELECT * FROM Service {clause}", parameters.ToArray()).AsNoTracking().Include(x => x.Employees).Include(x => x.Category);

            return ret;
        }
        private IEnumerable<Stock> SearchStock(string clause, List<SqlParameter> parameters)
        {
            IEnumerable<Stock> ret;

            if (string.IsNullOrWhiteSpace(clause))
                ret = Context.Stocks;
            else
                ret = Context.Stocks.FromSqlRaw($"SELECT * FROM Stock {clause}", parameters.ToArray());

            return ret;
        }


        private bool UpSertAppointment(Appointment input)
        {
            if (Context.Appointments.Any(item => item.AppointmentId == input.AppointmentId))
            {
                var item = Context.Appointments.First(item => item.AppointmentId == input.AppointmentId);
                item.AppointmentStatus = input.AppointmentStatus;
                item.CustomerId = input.CustomerId;
                item.AppointmentDate = input.AppointmentDate;
                item.OrderId = input.OrderId;
                Context.Appointments.Update(item);
            }

            else
                Context.Appointments.Add(input);

            return Context.SaveChanges() > 0;
        }

        private bool UpSertDailySummary(DailySummary input)
        {
            if (Context.DailySummaries.Any(item => item.SummaryDate == input.SummaryDate))
            {
                var item = Context.DailySummaries.First(item => item.SummaryDate == input.SummaryDate);
                item.TotalGross = input.TotalGross;
                item.TotalCashNet = input.TotalCashNet;
                item.TotalNet = input.TotalNet;
                item.TotalCash = input.TotalCash;
                item.TotalPos = input.TotalPos;
                item.DailyCosts = input.DailyCosts;
                Context.DailySummaries.Update(item);
            }

            else
                Context.DailySummaries.Add(input);

            return Context.SaveChanges() > 0;
        }

        private bool UpSertDiscount(Discount input)
        {
            if (Context.Discounts.Any(item => item.ServiceId == input.ServiceId && item.CustomerId == input.CustomerId))
            {
                var item = Context.Discounts.First(item => item.ServiceId == input.ServiceId && item.CustomerId == input.CustomerId);
                item.DiscountPercentage = input.DiscountPercentage;
                item.DiscountTimestamp = input.DiscountTimestamp;
                Context.Discounts.Update(item);
            }

            else
                Context.Discounts.Add(input);

            return Context.SaveChanges() > 0;
        }

        private bool UpSertEmployee(Employee input)
        {
            if (Context.Employees.Any(item => item.EmployeeId == input.EmployeeId))
            {
                var item = Context.Employees.First(item => item.EmployeeId == input.EmployeeId);
                item.EmployeeName = input.EmployeeName;
                item.EmployeeLastName = input.EmployeeLastName;
                item.EmployeeRole = input.EmployeeRole;
                item.EmployeePhone = input.EmployeePhone;
                item.IsActive = input.IsActive;
                item.EmployeeRegistrationDate = input.EmployeeRegistrationDate;
                item.EmployeeEmail = input.EmployeeEmail;
                item.EmployeeCode = input.EmployeeCode;
                Context.Employees.Update(item);
            }

            else
                Context.Employees.Add(input);

            return Context.SaveChanges() > 0;
        }

        private bool UpSertOrder(Order input)
        {
            if (Context.Orders.Any(item => item.OrderId == input.OrderId))
            {
                var item = Context.Orders.First(item => item.OrderId == input.OrderId);
                item.OrderDate = input.OrderDate;
                if (input.CustomerId.HasValue)
                {
                    if (input.CustomerId == 0) 
                        item.CustomerId = null;
                    else
                        item.CustomerId = input.CustomerId;
                }
                if(input.Notes != null)
                    item.Notes = input.Notes;
                Context.Orders.Update(item);
            }

            else
                Context.Orders.Add(input);

            return Context.SaveChanges() > 0;
        }

        private bool UpSertOrderService(OrderService input)
        {
            if (Context.OrderServices.Any(item => item.OrderId == input.OrderId && item.ServiceId == input.ServiceId))
            {
                var item = Context.OrderServices.First(item => item.OrderId == input.OrderId && item.ServiceId == input.ServiceId);
                item.ServicePrice = input.ServicePrice;
                item.EmployeeId = input.EmployeeId;
                Context.OrderServices.Update(item);
            }

            else
                Context.OrderServices.Add(input);

            return Context.SaveChanges() > 0;
        }

        private bool UpSertPaymentSummary(PaymentSummary input)
        {
            if (Context.PaymentSummaries.Any(item => item.PaymentId == input.PaymentId))
            {
                var item = Context.PaymentSummaries.First(item => item.PaymentId == input.PaymentId);
                item.TotalPOS = input.TotalPOS;
                item.TotalPrice = input.TotalPrice;
                item.TotalPOS = input.TotalPOS;
                item.PaymentDate = input.PaymentDate;
                Context.PaymentSummaries.Update(item);
            }

            else
                Context.PaymentSummaries.Add(input);

            return Context.SaveChanges() > 0;
        }

        private bool UpSertProduct(Product input)
        {
            if (Context.Products.Any(item => item.ProductId == input.ProductId))
            {
                var item = Context.Products.First(item => item.ProductId == input.ProductId);
                item.ProductCode = input.ProductCode;
                item.ProductDescription = input.ProductDescription;
                item.SupplierId = input.SupplierId;
                Context.Products.Update(item);
            }

            else
                Context.Products.Add(input);

            return Context.SaveChanges() > 0;
        }

        private bool UpSertService(Service input)
        {
            if (Context.Services.Any(item => item.ServiceId == input.ServiceId))
            {
                var item = Context.Services.First(item => item.ServiceId == input.ServiceId);
                item.ServiceCode = input.ServiceCode;
                item.ServiceDescription = input.ServiceDescription;
                item.ServiceNotes = input.ServiceNotes;
                item.ServiceMinimumPrice = input.ServiceMinimumPrice;
                item.ServiceMaximumPrice = input.ServiceMaximumPrice;
                item.CategoryId = input.CategoryId;
                Context.Services.Update(item);
            }

            else
                Context.Services.Add(input);

            return Context.SaveChanges() > 0;
        }


        private bool UpSertCategory(Category input)
        {
            if (Context.Categories.Any(item => item.CategoryId == input.CategoryId))
            {
                var item = Context.Categories.First(item => item.CategoryId == input.CategoryId);
                item.CategoryName = input.CategoryName;
                item.CategoryDescription = input.CategoryDescription;
                Context.Categories.Update(item);
            }

            else
                Context.Categories.Add(input);

            return Context.SaveChanges() > 0;
        }

        private bool UpSertStock(Stock input)
        {
            if (Context.Stocks.Any(item => item.ProductId == input.ProductId))
            {
                var item = Context.Stocks.First(item => item.ProductId == input.ProductId);
                item.Quantity = input.Quantity;
                Context.Stocks.Update(item);
            }

            else
                Context.Stocks.Add(input);

            return Context.SaveChanges() > 0;
        }
        #endregion
    }
}
