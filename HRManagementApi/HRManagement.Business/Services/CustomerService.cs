using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.Business.Exceptions;
using HRManagement.DataAccess.Entities;
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
            if (customer == null)
            {
                throw new NotFoundException();
            }
            return _mapper.Map<CustomerDto>(customer);
        }
        public async Task<bool> CustomerExists(long cityId)
        {
            return await _customerInfoRepository.CustomerExistsAsync(cityId);
        }

        public async Task EditCustomer(CustomerDto customerToUpdate)
        {
            var customerEdit = _mapper.Map<Customer>(customerToUpdate);
            await _customerInfoRepository.EditCustomer(customerEdit);
        }
    }
}
