using BeautyHall.Api.SDK.Configuration;
using BeautyHall.Api.SDK.Requests;
using System.Net;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using Newtonsoft.Json;
using BeautyHall.Api.SDK.Responses;

namespace BeautyHall.Api.SDK
{
    public class BeautyHallApiSDK : Interfaces.IBeautyHallApiSDK
    {
        private readonly BeautyHallApiSDKConfiguration Cfg;
        private readonly HttpClient Client;
        public BeautyHallApiSDK(BeautyHallApiSDKConfiguration cfg)
        {
            Cfg = cfg;
            if (cfg != null)
            {
                Client = new HttpClient()
                {
                    BaseAddress = new Uri(Cfg.BaseUrl),
                    Timeout = TimeSpan.FromMilliseconds(Cfg.Timeout)
                };
                Client.DefaultRequestHeaders.Add("Accept", "*/*");
            }
        }
        private string GetEnumDescription(Enum enumType)
        {
            FieldInfo fi = enumType.GetType().GetField(enumType.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes[0].Description;
        }
        private string PrepareUrl(SdkEndpoint endpoint, params object?[] args)
        {
            var ret = Cfg.BaseUrl;
            if (!ret.EndsWith("/"))
                ret += "/";
            ret += string.Format(GetEnumDescription(endpoint), args);
            return ret;
        }
        private async Task<HttpResponseMessage> SendAsync(HttpMethod method, Uri uri, StringContent stringContent)
        {
            int retry = 0;
            HttpResponseMessage response = null;
            while (retry < Cfg.MaxRetry)
            {
                try
                {
                    retry++;
                    if (method == HttpMethod.Post)
                    {
                        response = await Client.PostAsync(uri, stringContent);
                    }
                    else if (method == HttpMethod.Put)
                    {
                        response = await Client.PutAsync(uri, stringContent);
                    }
                    else if (method == HttpMethod.Patch)
                    {
                        response = await Client.PatchAsync(uri, stringContent);
                    }
                    else if (method == HttpMethod.Delete)
                    {
                        var request = new HttpRequestMessage
                        {
                            Method = HttpMethod.Delete,
                            RequestUri = uri,
                            Content = stringContent
                        };
                        response = await Client.SendAsync(request);
                    }
                    else if (method == HttpMethod.Get)
                    {
                        response = await Client.GetAsync(uri);
                    }
                    if (response.IsSuccessStatusCode)
                    {
                        retry = Cfg.MaxRetry;
                    }
                    else if (response.StatusCode == HttpStatusCode.TooManyRequests)
                    {
                        Thread.Sleep(Cfg.WaitTime * retry);
                    }
                    else
                    {
                        Thread.Sleep(Cfg.WaitTime);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error during communication with BeautyHall Api", ex);
                }
            }
            return response;
        }
        private async Task<TResponse?> GetFromApi<TRequest, TResponse>(Uri uri, HttpMethod method, TRequest request = default)
        {
            try
            {
                var json = JsonConvert.SerializeObject(request);
                var stringContent = method == HttpMethod.Get ? null : new StringContent(json, Encoding.UTF8, "application/json");
                var response = await SendAsync(method, uri, stringContent);
                if (response == null || response.Content == null || !response.IsSuccessStatusCode)
                    return default;

                if (typeof(TResponse) == typeof(bool))
                    return (TResponse)(object)response.IsSuccessStatusCode;

                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TResponse>(content);
            }
            catch(Exception) { return default; }
        }

        public async Task<Login?> GetLogin(LoginDto login)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_AUTH));
            return await GetFromApi<LoginDto,Login>(uri, HttpMethod.Post, login);
        }

        public async Task<bool> AddLogin(LoginDto login)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_ADD_LOGIN));
            return await GetFromApi<LoginDto, bool>(uri, HttpMethod.Put, login);
        }
        public async Task<IEnumerable<Subject>?> GetSubjects()
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_GET_SUBJECTS));
            return await GetFromApi<object, IEnumerable<Subject>?>(uri, HttpMethod.Get);
        }

        public async Task<bool> UpsertSubjects(IEnumerable<SubjectDto> subjects)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_UPDATE_SUBJECTS));
            return await GetFromApi<IEnumerable<SubjectDto>, bool>(uri, HttpMethod.Post, subjects);
        }

        public async Task<bool> DeleteSubject(int subjectId)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_DELETE_SUBJECT, subjectId));
            return await GetFromApi<object, bool>(uri, HttpMethod.Delete);
        }

        public async Task<IEnumerable<Employee>?> GetEmployees()
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_GET_EMPLOYEES));
            return await GetFromApi<object, IEnumerable<Employee>>(uri, HttpMethod.Get);
        }

        public async Task<bool> UpsertEmployees(IEnumerable<EmployeeDto> employees)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_UPDATE_EMPLOYEES));
            return await GetFromApi<IEnumerable<EmployeeDto>, bool>(uri, HttpMethod.Post, employees);
        }

        public async Task<bool> DeleteEmployee(int employeeId)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_DELETE_EMPLOYEES, employeeId));
            return await GetFromApi<object, bool>(uri, HttpMethod.Delete);
        }

        public async Task<IEnumerable<Service>?> GetServices()
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_GET_SERVICES));
            return await GetFromApi<object, IEnumerable<Service>>(uri, HttpMethod.Get);
        }

        public async Task<bool> UpsertServices(IEnumerable<ServiceDto> services)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_UPDATE_SERVICES));
            return await GetFromApi<IEnumerable<ServiceDto>, bool>(uri, HttpMethod.Post, services);
        }

        public async Task<bool> DeleteService(int serviceId)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_DELETE_SERVICES, serviceId));
            return await GetFromApi<object, bool>(uri, HttpMethod.Delete);
        }

        public async Task<Order?> UpsertOrder(OrderDto order)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_UPDATE_ORDER));
            return await GetFromApi<OrderDto, Order>(uri, HttpMethod.Post, order);
        }

        public async Task<bool> DeleteOrder(int orderId)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_DELETE_ORDER, orderId));
            return await GetFromApi<object, bool>(uri, HttpMethod.Delete);
        }

        public async Task<IEnumerable<Order>?> GetOrders()
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_GET_ORDERS));
            return await GetFromApi<object, IEnumerable<Order>>(uri, HttpMethod.Get);
        }

        public async Task<IEnumerable<Order>?> GetCustomerOrders(int customerId)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_GET_CUSTOMER_ORDER, customerId));
            return await GetFromApi<object, IEnumerable<Order>>(uri, HttpMethod.Get);
        }
        public async Task<IEnumerable<Order>?> GetOrders(DateTime from, DateTime to)
        {
            var fromDate = from.ToString("yyyy-MM-dd");
            var toDate = to.ToString("yyyy-MM-dd");
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_GET_ORDERS_DATES, fromDate, toDate));
            return await GetFromApi<object, IEnumerable<Order>>(uri, HttpMethod.Get);
        }
        public async Task<Order?> GetOrder(int orderId)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_GET_ORDER_ID, orderId));
            return await GetFromApi<object, Order?>(uri, HttpMethod.Get);
        }

        public async Task<bool> DeleteOrderServices(IEnumerable<OrderServiceDto> orderServices)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_DELETE_ORDER_SEVICES));
            return await GetFromApi<IEnumerable<OrderServiceDto>, bool>(uri, HttpMethod.Delete, orderServices);
        }

        public async Task<IEnumerable<Appointment>?> GetAppointments()
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_GET_APPOINTMENTS));
            return await GetFromApi<object, IEnumerable<Appointment>>(uri, HttpMethod.Get);
        }

        public async Task<IEnumerable<Appointment>?> GetCustomerAppointments(int customerId)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_GET_CUSTOMER_APPOINTMENTS, customerId));
            return await GetFromApi<object, IEnumerable<Appointment>>(uri, HttpMethod.Get);
        }

        public async Task<bool> UpsertAppointment(AppointmentDto appointment)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_UPDATE_APPOINTMENT));
            return await GetFromApi<AppointmentDto, bool>(uri, HttpMethod.Post, appointment);
        }

        public async Task<bool> DeleteAppointment(int appointmentId)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_DELETE_APPOINTMENT, appointmentId));
            return await GetFromApi<object, bool>(uri, HttpMethod.Delete);
        }

        public async Task<bool> UpsertDiscount(DiscountDto discount)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_UPDATE_DISCOUNT));
            return await GetFromApi<DiscountDto, bool>(uri, HttpMethod.Post, discount);
        }

        public async Task<bool> DeleteDiscount(int serviceId, int customerId)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_DELETE_DISCOUNT, serviceId, customerId));
            return await GetFromApi<object, bool>(uri, HttpMethod.Delete);
        }

        public async Task<IEnumerable<Product>?> GetAllProducts()
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_GET_ALL_PRODUCTS));
            return await GetFromApi<object, IEnumerable<Product>>(uri, HttpMethod.Get);
        }

        public async Task<IEnumerable<Product>?> GetSupplierProducts(int supplierId)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_GET_SUPPLIER_PRODUCTS, supplierId));
            return await GetFromApi<object, IEnumerable<Product>>(uri, HttpMethod.Get);
        }

        public async Task<bool> UpsertProduct(ProductDto product)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_UPDATE_PRODUCT));
            return await GetFromApi<ProductDto, bool>(uri, HttpMethod.Post, product);
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_DELETE_PRODUCT, productId));
            return await GetFromApi<object, bool>(uri, HttpMethod.Delete);
        }

        public async Task<bool> UpsertStock(StockDto stock)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_UPDATE_STOCK));
            return await GetFromApi<StockDto, bool>(uri, HttpMethod.Post, stock);
        }

        public async Task<bool> UpsertPayment(PaymentSummaryDto paymentSummary)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_UPDATE_PAYMENT));
            return await GetFromApi<PaymentSummaryDto, bool>(uri, HttpMethod.Post, paymentSummary);
        }

        public async Task<bool> DeletePayment(int paymentId)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_DELETE_PAYMENT, paymentId));
            return await GetFromApi<object, bool>(uri, HttpMethod.Delete);
        }

        public async Task<IEnumerable<DailySummary>?> GetDailySummaries()
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_GET_DAILYSUMMARIES));
            return await GetFromApi<object, IEnumerable<DailySummary>>(uri, HttpMethod.Get);
        }

        public async Task<IEnumerable<DailySummary>?> GetDailySummaries(DateTime from, DateTime to)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_GET_FILTERED_DAILYSUMMARIES, from, to));
            return await GetFromApi<object, IEnumerable<DailySummary>>(uri, HttpMethod.Get);
        }

        public async Task<DailySummary?> CalculateDailySummary(DateTime date, decimal dailyCosts)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_CALCULATE_DAILYSUMMARY, date, dailyCosts));
            return await GetFromApi<object, DailySummary>(uri, HttpMethod.Get);
        }

        public async Task<IEnumerable<Category>?> GetCategories()
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_GET_CATEGORIES));
            return await GetFromApi<object, IEnumerable<Category>>(uri, HttpMethod.Get);
        }

        public async Task<bool> UpsertCategory(CategoryDto category)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_UPDATE_CATEGORY));
            return await GetFromApi<CategoryDto, bool>(uri, HttpMethod.Post, category);
        }

        public async Task<bool> DeleteCategory(int categoryId)
        {
            var uri = new Uri(PrepareUrl(SdkEndpoint.ENDPOINT_DELETE_CATEGORY, categoryId));
            return await GetFromApi<object, bool>(uri, HttpMethod.Delete);
        }
    }
}
