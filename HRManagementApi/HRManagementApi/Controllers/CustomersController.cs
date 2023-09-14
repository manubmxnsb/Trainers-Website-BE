using HRManagement.Business.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRManagementApi.Controllers
{
    /// <response code="200">Success</response>
    /// <response code="404">Not Found</response>
    /// <response code="400">Bad Request</response>
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
    }
}
