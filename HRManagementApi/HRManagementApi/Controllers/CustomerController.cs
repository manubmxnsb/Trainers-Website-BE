using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.Business.Services;
using HRManagementApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IBusinessLayer _customerService;
        private readonly IMapper _mapper;

        public CustomerController(IBusinessLayer customerService, IMapper mapper)
        {
            _customerService = customerService ?? throw new ArgumentException(nameof(customerService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        //[Route("{id}")]
        [HttpPost]
        public async Task<ActionResult> AddNew(CustomerDtoApi customer)
        {
            var mappedCustomerApi = _mapper.Map<CustomerDto>(customer);
            await _customerService.AddNewCustomer(mappedCustomerApi);
            return Ok();
        }
    }
}
