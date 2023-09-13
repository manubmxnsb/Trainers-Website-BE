using HRManagement.Business.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        // DELETE api/<CustomerController>/5
        [HttpDelete]
        public async Task< ActionResult > Delete([FromBody] List<long> customerIds)
        {
            await _customerService.DeleteCustomers(customerIds);
            return  Ok();
        }
    }
}