using HRManagement.Business.Services;
using HRManagementApi.Middleware;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRManagementApi.Controllers
{
    
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCustomer(long id, bool includeDocuments = false)
        {
            var customer = await _customerService.GetCustomer(id, includeDocuments);
            return Ok(customer);
        }
    }
}
