using AutoMapper;
using HRManagement.Business.Interface;
using HRManagement.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IDBService _businessLayer;
        private readonly IMapper _mapper;


        public CustomerController(IDBService businessLayer,
            IMapper mapper)
        {
            _businessLayer = businessLayer ?? 
                throw new ArgumentNullException(nameof(businessLayer));
            _mapper = mapper ?? 
                throw new ArgumentNullException(nameof(_mapper));
        }

        [HttpGet("/GetAllCustomers")]
        [HttpGet]
        public async Task<IEnumerable<CustomerDto>> GetAllCustomers()
        {
            var allCustomers = await _businessLayer.GetAllCustomers() ;
            var mappedAllCustomers = allCustomers.Select(_mapper.Map<CustomerDto>);
            return mappedAllCustomers;
        }

    }
}
