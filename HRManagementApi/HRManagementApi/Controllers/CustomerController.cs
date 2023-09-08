using HRManagement.Business.Interface;
using HRManagementApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IBusinessLayer _customerService;

        public CustomerController(IBusinessLayer customerService)
        {
            _customerService = customerService ?? throw new ArgumentException(nameof(customerService));
        }

        //[Route("{id}")]
        [HttpPost]
        public async Task<ActionResult> AddNew(CustomerDtoService customer)
        {

            await _customerService.AddNewCustomer();
            //await _customerService.SaveChangesAsync();
            return Ok();
        }
    }
}
