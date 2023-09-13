using AutoMapper;
using HRManagement.Business.Interface;
using HRManagement.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;


        public CustomersController(ICustomerService customerService,
            IMapper mapper)
        {
            _customerService = customerService ?? 
                throw new ArgumentNullException(nameof(customerService));
        }

        [HttpGet("/GetAllCustomers")]
        [HttpGet]
        public async Task<IEnumerable<CustomerSummaryDto>> GetAllCustomers(int pageNumber, int pageSize)
        {
            var allCustomers = await _customerService.GetAllCustomers(pageNumber,pageSize) ;
            return allCustomers;
        }

    }
}
