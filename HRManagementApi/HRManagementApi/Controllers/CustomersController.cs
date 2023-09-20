using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementApi.Controllers
{
    [Route("api/Customer")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomersController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService ?? throw new ArgumentException(nameof(customerService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("Get/{id}")]
        public async Task<ActionResult> GetCustomer(long id)
        {
            var customer = await _customerService.GetCustomer(id);
            return Ok(customer);
        }

        [HttpPost("Add/")]
        public async Task<ActionResult> AddNew(CustomerDto customer)
        {
            var mappedCustomerApi = _mapper.Map<CustomerDto>(customer);
            await _customerService.AddNewCustomer(mappedCustomerApi);
            return Ok();
        }
    }
}
