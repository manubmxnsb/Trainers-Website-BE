using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Repositories;

namespace HRManagement.Business.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task AddNewCustomer(CustomerDto customer)
        {     
            var mappedCustomerBusiness = _mapper.Map<Customer>(customer);
            await _customerRepository.AddNewCustomerAsync(mappedCustomerBusiness);
        }
    }
}
