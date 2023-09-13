﻿using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.Business.Exceptions;
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

        public async Task DeleteCustomers(List<long> customerIds)
        {
            if (customerIds != null && customerIds.Count > 0)
            {
                await _customerRepository.Delete(customerIds);
            }
            else
            {
                throw new InvalidOperationException("No customers were found!");
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

)

        }
    }
}