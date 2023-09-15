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

        [HttpPut("customerEdit")]
        public async Task<ActionResult> EditCustomer(
            CustomerDto customerToUpdate)
        {
            if(!await _customerService.CustomerExists(customerToUpdate.Id))
            {
                throw new Exception("customer doesn't exist");
            }
            await _customerService.EditCustomer(customerToUpdate);
            return NoContent();
        }
    }
}
