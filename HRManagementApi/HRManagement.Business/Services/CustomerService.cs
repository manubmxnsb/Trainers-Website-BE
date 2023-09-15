using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Exceptions;
using HRManagement.DataAccess.Repositories;

namespace HRManagement.Business.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerInfoRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository dbRepository, IMapper mapper)
        {
            _mapper = mapper;
            _customerInfoRepository = dbRepository;
        }

        public async Task<CustomerDto> GetCustomer(long id)
        {
            var customer = await _customerInfoRepository.GetCustomerAsync(id);
            return _mapper.Map<CustomerDto>(customer);
        }

        public async Task<IEnumerable<CustomerSummaryDto>> GetAllCustomers(
            int pageNumber, int pageSize)
        {
            var allCustomers = await _customerInfoRepository.GetAllCustomersAsync(pageNumber, pageSize);
            var mappedAllCustomers = allCustomers.Select(_mapper.Map<CustomerSummaryDto>);
            return mappedAllCustomers;
        }

        public async Task<bool> CustomerExists(long cityId)
        {
            return await _customerInfoRepository.CustomerExistsAsync(cityId);
        }

    }
}
