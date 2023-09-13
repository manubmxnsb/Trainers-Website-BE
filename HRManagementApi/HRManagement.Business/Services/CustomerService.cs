using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Services;

namespace HRManagement.Business.Interface
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public CustomerService(ICustomerRepository customerRepository,
             IMapper mapper)
        {
            _customerRepository = customerRepository ?? 
                throw new ArgumentNullException(nameof(customerRepository));
            _mapper = mapper ?? 
                throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<CustomerSummaryDto>> GetAllCustomers(
            int pageNumber, int pageSize)
        {
            var allCustomers = await _customerRepository.GetAllCustomersAsync(pageNumber, pageSize);
            var mappedAllCustomers = allCustomers.Select(_mapper.Map<CustomerSummaryDto>);
            return mappedAllCustomers;
        }
    }
}
