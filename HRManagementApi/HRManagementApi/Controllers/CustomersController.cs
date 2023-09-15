using HRManagement.Business.Models;
using HRManagement.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCustomer(long id)
        {
            var customer = await _customerService.GetCustomer(id);
            return Ok(customer);
        }

        [HttpGet("/all-customers")]
        public async Task<IEnumerable<CustomerSummaryDto>> GetAllCustomers(int pageNumber, int pageSize)
        {
            var allCustomers = await _customerService.GetAllCustomers(pageNumber, pageSize);
            return allCustomers;
        }
    }
}
