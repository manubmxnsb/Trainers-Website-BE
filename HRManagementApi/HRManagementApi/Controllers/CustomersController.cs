using AutoMapper;
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
        private readonly IMapper _mapper;

        public CustomersController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService ?? throw new ArgumentException(nameof(customerService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCustomer(long id)
        {
            var customer = await _customerService.GetCustomer(id);
            return Ok(customer);
        }

        //[Route("{id}")]
        [HttpPost]
        public async Task<ActionResult> AddNew(CustomerDto customer)
        {
            var mappedCustomerApi = _mapper.Map<CustomerDto>(customer);
            await _customerService.AddNewCustomer(mappedCustomerApi);
            return Ok();
        }
    }
}
