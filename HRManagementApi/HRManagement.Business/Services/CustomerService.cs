using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Exceptions;
using HRManagement.DataAccess.Repositories;
using Microsoft.IdentityModel.Tokens;

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

        public async Task<bool> CustomerExists(long cityId)
        {
            return await _customerInfoRepository.CustomerExistsAsync(cityId);
        }

        public async Task DeleteCustomers(List<long> customerIds)
        {
            if (!customerIds.IsNullOrEmpty())
            {
                await _customerInfoRepository.DeleteCustomers(customerIds);
            }
            else
            {
                throw new NotFoundException();
            }
        }
    }
}
