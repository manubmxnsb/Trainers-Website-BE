using HRManagement.Business.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

        [HttpPut("customerEdit")]

        public async Task<ActionResult> EditCustomer(
            CustomerDto customerToUpdate)
        {
            var customer = await _customerService.GetCustomer(id);
            return Ok(customer);
           
            await _dbService.EditCustomer(customerToUpdate);

            return NoContent();


        }
    }
  
}
