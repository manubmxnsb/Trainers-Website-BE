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
        public async Task<IEnumerable<CustomerDto>> GetAllCustomers(int pageNumber, int pageSize)
        {
            var allCustomers = await _businessLayer.GetAllCustomers(pageNumber,pageSize) ;
            var mappedAllCustomers = allCustomers.Select(_mapper.Map<CustomerDto>);
            return mappedAllCustomers;
        }

    }
}
