using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRManagementApi.Controllers
{
    
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerInfoRepository _customerInfoRepository;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerInfoRepository customerInfoRepository, IMapper mapper)
        {
            _customerInfoRepository = customerInfoRepository ?? throw new ArgumentNullException(nameof(customerInfoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(int id, bool includeDocuments = false)
        {
            var customer = await _customerInfoRepository.GetCustomerAsync(id, includeDocuments);
            if(customer == null)
            {
                return NotFound();
            }
            if(includeDocuments)
            {
                return Ok(_mapper.Map<CustomerDTO>(customer));
            }
            return (Ok(_mapper.Map<CustomerWithoutDocumentsDTO>(customer)));
        }
    }
}
