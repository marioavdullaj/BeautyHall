using BeautyHall.Commons.Api.Attributes;
using BeautyHall.Models.Common.Interfaces;
using BeautyHall.Models.Dto.Requests;
using Microsoft.AspNetCore.Mvc;

namespace BeautyHall.Api.DB.Controllers
{
    [Authorization]
    [ApiController]
    [Route("[controller]")]
    public class BeautyHallController : ControllerBase
    {
        private readonly IBolDbService BolService;
        public BeautyHallController(IBolDbService bolService) => BolService = bolService;

        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] LoginDto data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var res = BolService.Login(data.Username, data.Password);
            if(res != null)
                return Ok(res);
            else
                return Unauthorized();
        }

        [HttpPut]
        [Route("Login/Add")]
        public IActionResult AddLogin([FromBody] LoginDto data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (BolService.UpSertLogin(data))
                return Ok();
            return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
        }

        #region Registries
        [HttpGet]
        [Route("Registry/Subjects")]
        public IActionResult GetSubjects()
        {
            var res = BolService.GetSubjects();
            if (res != null && res.Any())
                return Ok(res);
            return NoContent();
        }
        [HttpPost]
        [Route("Registry/Subjects")]
        public IActionResult UpSertSubjects([FromBody] IEnumerable<SubjectDto> data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var ret = BolService.UpSertSubjects(data);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }
        [HttpDelete]
        [Route("Registry/Subject/{subjectId}")]
        public IActionResult DeleteSubject(int subjectId)
        {
            var ret = BolService.DeleteSubject(subjectId);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }

        [HttpGet]
        [Route("Registry/Employees")]
        public IActionResult GetEmployees()
        {
            var res = BolService.GetEmployees();
            if (res != null && res.Any())
                return Ok(res);
            return NoContent();
        }
        [HttpPost]
        [Route("Registry/Employees")]
        public IActionResult UpSertEmployees([FromBody] IEnumerable<EmployeeDto> data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var ret = BolService.UpSertEmployees(data);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }
        [HttpDelete]
        [Route("Registry/Employee/{employeeId}")]
        public IActionResult DeleteEmployee(int employeeId)
        {
            var ret = BolService.DeleteEmployee(employeeId);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }

        [HttpGet]
        [Route("Services")]
        public IActionResult GetServices()
        {
            var res = BolService.GetServices();
            if (res != null && res.Any())
                return Ok(res);
            return NoContent();
        }
        [HttpPost]
        [Route("Services")]
        public IActionResult UpSertServices([FromBody] IEnumerable<ServiceDto> data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var ret = BolService.UpSertServices(data);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }
        [HttpDelete]
        [Route("Service/{serviceId}")]
        public IActionResult DeleteService(int serviceId)
        {
            var ret = BolService.DeleteEmployee(serviceId);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }

        [HttpDelete]
        [Route("Order/{orderId}")]
        public IActionResult DeleteOrder(int orderId)
        {
            var ret = BolService.DeleteOrder(orderId);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }


        [HttpPost]
        [Route("Order")]
        public IActionResult UpSertOrder([FromBody] OrderDto data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var ret = BolService.UpSertOrder(data);
            if (ret == null)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok(ret);
        }
        [HttpGet]
        [Route("Orders")]
        public IActionResult GetOrders()
        {
            var res = BolService.GetOrders();
            if (res != null && res.Any())
                return Ok(res);
            return NoContent();
        }

        [HttpGet]
        [Route("Orders/Customer/{customerId}")]
        public IActionResult GetOrders(int customerId)
        {
            var res = BolService.GetOrders(customerId);
            if (res != null && res.Any())
                return Ok(res);
            return NoContent();
        }

        [HttpDelete]
        [Route("Orders/Services")]
        public IActionResult DeleteOrderServices([FromBody] IEnumerable<OrderServiceDto> data)
        {
            if(BolService.DeleteOrderServices(data))
                return Ok();
            return NoContent();
        }

        // Appointments
        [HttpGet]
        [Route("Appointments")]
        public IActionResult GetAppointments()
        {
            var res = BolService.GetAppointments();
            if (res != null && res.Any())
                return Ok(res);
            return NoContent();
        }
        // Appointments
        [HttpGet]
        [Route("Appointments/Customer/{customerId}")]
        public IActionResult GetAppointmentsCustomer(int customerId)
        {
            var res = BolService.GetAppointmentsCustomer(customerId);
            if (res != null && res.Any())
                return Ok(res);
            return NoContent();
        }
        [HttpPost]
        [Route("Appointment")]
        public IActionResult UpSertAppointment([FromBody] AppointmentDto data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var ret = BolService.UpSertAppointment(data);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }
        [HttpDelete]
        [Route("Appointment/{appointmentId}")]
        public IActionResult DeleteAppointment(int appointmentId)
        {
            var ret = BolService.DeleteAppointment(appointmentId);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }
        [HttpPost]
        [Route("Discount")]
        public IActionResult UpSertDiscount([FromBody] DiscountDto data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var ret = BolService.UpSertDiscount(data);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }
        [HttpDelete]
        [Route("Discount/{serviceId}/{customerId}")]
        public IActionResult DeleteDiscount(int serviceId, int customerId)
        {
            var ret = BolService.DeleteDiscount(serviceId, customerId);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }


        [HttpGet]
        [Route("Products")]
        public IActionResult GetAllProducts()
        {
            var res = BolService.GetAllProducts();
            if (res != null && res.Any())
                return Ok(res);
            return NoContent();
        }
        [HttpGet]
        [Route("Products/Supplier/{supplierId}")]
        public IActionResult GetSupplierProducts(int supplierId)
        {
            var res = BolService.GetSupplierProducts(supplierId);
            if (res != null && res.Any())
                return Ok(res);
            return NoContent();
        }
        [HttpPost]
        [Route("Product")]
        public IActionResult UpSertProduct([FromBody] ProductDto data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var ret = BolService.UpSertProduct(data);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }
        [HttpDelete]
        [Route("Product/{productId}")]
        public IActionResult DeleteProduct(int productId)
        {
            var ret = BolService.DeleteProduct(productId);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }

        [HttpPost]
        [Route("Stock")]
        public IActionResult UpSertStock([FromBody] StockDto data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var ret = BolService.UpSertStock(data);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }

        [HttpPost]
        [Route("Payment")]
        public IActionResult Payment([FromBody] PaymentSummaryDto data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var ret = BolService.UpSertPaymentSummary(data);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }
        [HttpDelete]
        [Route("Payment/{paymentId}")]
        public IActionResult DeletePayment(int paymentId)
        {
            var ret = BolService.DeletePaymentSummary(paymentId);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }

        [HttpGet]
        [Route("DailySummaries")]
        public IActionResult GetDailySummaries()
        {
            var res = BolService.GetDailySummaries();
            if (res != null && res.Any())
                return Ok(res);
            return NoContent();
        }
        [HttpGet]
        [Route("DailySummaries/{from}/{to}")]
        public IActionResult DailySummaries(DateTime from, DateTime to)
        {
            var res = BolService.GetDailySummaries(from, to);
            if (res != null && res.Any())
                return Ok(res);
            return NoContent();
        }
        [HttpGet]
        [Route("DailySummary/Calculate/{date}/{dailyCosts}")]
        public IActionResult CalculateDailySummary(DateTime date, decimal dailyCosts)
        {
            var res = BolService.CalculateDailySummary(date, dailyCosts);
            if (res != null)
                return Ok(res);
            return NoContent();
        }

        [HttpGet]
        [Route("Categories")]
        public IActionResult GetCategories()
        {
            var res = BolService.GetCategories();
            if (res != null && res.Any())
                return Ok(res);
            return NoContent();
        }
        [HttpPost]
        [Route("Category")]
        public IActionResult UpSertCategory([FromBody] CategoryDto data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var ret = BolService.UpSertCategory(data);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }
        [HttpDelete]
        [Route("Category/{categoryId}")]
        public IActionResult DeleteCategory(int categoryId)
        {
            var ret = BolService.DeleteCategory(categoryId);
            if (!ret)
                return new ContentResult() { StatusCode = StatusCodes.Status304NotModified };
            return Ok();
        }
        #endregion
    }
}
