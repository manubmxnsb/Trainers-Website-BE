using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;
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

        public async Task AddNewCustomer(CustomerDto customer)
        {
            var mappedCustomerBusiness = _mapper.Map<Customer>(customer);
            await _customerInfoRepository.AddNewCustomerAsync(mappedCustomerBusiness);
        }

        public async Task EditCustomer(CustomerDto customerToUpdate)
        {
            var customerEdit = _mapper.Map<Customer>(customerToUpdate);
            await _customerInfoRepository.EditCustomer(customerEdit);
        }
    }
}
