using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.Business.Services;
using HRManagementApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementApi.Controllers
{
    [Route("api/[controller]")]
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

        //[Route("{id}")]
        [HttpPost]
        public async Task<ActionResult> AddNew(CustomerModel customer)
        {
            var mappedCustomerApi = _mapper.Map<CustomerDto>(customer);
            await _customerService.AddNewCustomer(mappedCustomerApi);
            return Ok();
        }
    }
}
