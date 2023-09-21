using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Exceptions;
using HRManagement.DataAccess.Models;
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
            PaginationItemsDto paginationItems)
        {
            var mappedPaginationItems = _mapper.Map<PaginationItems>(paginationItems);
            var allCustomers = await _customerInfoRepository.GetAllCustomersAsync(mappedPaginationItems);
            var mappedAllCustomers = allCustomers.Select(_mapper.Map<CustomerSummaryDto>);
            return mappedAllCustomers;
        }

        public async Task<bool> CustomerExists(long cityId)
        {
            return await _customerInfoRepository.CustomerExistsAsync(cityId);
        }

        public async Task DeleteCustomers(List<long> customerIds)
        {
            if (customerIds != null && customerIds.Any())
            {
                await _customerInfoRepository.DeleteCustomers(customerIds);
            }
            else
            {
                throw new BadRequestException();
            }
        }
    }
}
