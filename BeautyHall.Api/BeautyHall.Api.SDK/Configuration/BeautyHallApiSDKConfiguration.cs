using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyHall.Api.SDK.Configuration
{
    public class BeautyHallApiSDKConfiguration
    {
        public string? BaseUrl { get; set; }
        public long Timeout { get; set; } = 5000;
        public int MaxRetry { get; set; } = 5;
        public int WaitTime { get; set; } = 100;
    }

    public enum SdkEndpoint
    {
        [Description("BeautyHall/Login")]
        ENDPOINT_AUTH,
        [Description("BeautyHall/Login/Add")]
        ENDPOINT_ADD_LOGIN,
        [Description("BeautyHall/Registry/Subjects")]
        ENDPOINT_GET_SUBJECTS,
        [Description("BeautyHall/Registry/Subjects")]
        ENDPOINT_UPDATE_SUBJECTS,
        [Description("BeautyHall/Registry/Subject/{0}")]
        ENDPOINT_DELETE_SUBJECT,
        [Description("BeautyHall/Registry/Employees")]
        ENDPOINT_GET_EMPLOYEES,
        [Description("BeautyHall/Registry/Employees")]
        ENDPOINT_UPDATE_EMPLOYEES,
        [Description("BeautyHall/Registry/Employee/{0}")]
        ENDPOINT_DELETE_EMPLOYEES,
        [Description("BeautyHall/Services")]
        ENDPOINT_GET_SERVICES,
        [Description("BeautyHall/Services")]
        ENDPOINT_UPDATE_SERVICES,
        [Description("BeautyHall/Service/{0}")]
        ENDPOINT_DELETE_SERVICES,
        [Description("BeautyHall/Order")]
        ENDPOINT_UPDATE_ORDER,
        [Description("BeautyHall/Order/{0}")]
        ENDPOINT_DELETE_ORDER,
        [Description("BeautyHall/Orders")]
        ENDPOINT_GET_ORDERS,
        [Description("BeautyHall/Orders/Customer/{0}")]
        ENDPOINT_GET_CUSTOMER_ORDER,
        [Description("BeautyHall/Orders/{0}/{1}")]
        ENDPOINT_GET_ORDERS_DATES,
        [Description("BeautyHall/Order/{0}")]
        ENDPOINT_GET_ORDER_ID,
        [Description("BeautyHall/Orders/Services")]
        ENDPOINT_DELETE_ORDER_SEVICES,
        [Description("BeautyHall/Orders/Products")]
        ENDPOINT_DELETE_ORDER_PRODUCTS,
        [Description("BeautyHall/Appointments")]
        ENDPOINT_GET_APPOINTMENTS,
        [Description("BeautyHall/Appointments/Customer/{0}")]
        ENDPOINT_GET_CUSTOMER_APPOINTMENTS,
        [Description("BeautyHall/Appointment")]
        ENDPOINT_UPDATE_APPOINTMENT,
        [Description("BeautyHall/Appointment/")]
        ENDPOINT_DELETE_APPOINTMENT,
        [Description("BeautyHall/Discount")]
        ENDPOINT_UPDATE_DISCOUNT,
        [Description("BeautyHall/Discount/{0}/{1}")]
        ENDPOINT_DELETE_DISCOUNT,
        [Description("BeautyHall/Products")]
        ENDPOINT_GET_ALL_PRODUCTS,
        [Description("BeautyHall/Products/Supplier/{0}")]
        ENDPOINT_GET_SUPPLIER_PRODUCTS,
        [Description("BeautyHall/Product")]
        ENDPOINT_UPDATE_PRODUCT,
        [Description("BeautyHall/Product/{0}")]
        ENDPOINT_DELETE_PRODUCT,
        [Description("BeautyHall/Stock")]
        ENDPOINT_UPDATE_STOCK,
        [Description("BeautyHall/Payment")]
        ENDPOINT_UPDATE_PAYMENT,
        [Description("BeautyHall/Payment/{0}")]
        ENDPOINT_DELETE_PAYMENT,
        [Description("BeautyHall/DailySummaries")]
        ENDPOINT_GET_DAILYSUMMARIES,
        [Description("BeautyHall/DailySummaries/{0}/{1}")]
        ENDPOINT_GET_FILTERED_DAILYSUMMARIES,
        [Description("BeautyHall/DailySummary/Calculate/{0}/{1}")]
        ENDPOINT_CALCULATE_DAILYSUMMARY,
        [Description("BeautyHall/Categories")]
        ENDPOINT_GET_CATEGORIES,
        [Description("BeautyHall/Category")]
        ENDPOINT_UPDATE_CATEGORY,
        [Description("BeautyHall/Category/{0}")]
        ENDPOINT_DELETE_CATEGORY
    }
}
