using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Business.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerInfoRepository _customerInfoRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerInfoRepository dbRepository, IMapper mapper)
        {
            _mapper = mapper;
            _customerInfoRepository = dbRepository;
        }
        public async Task<CustomerDTO> GetCustomer(long id, bool includeDocuments = false)
        {
            var customer = await _customerInfoRepository.GetCustomerAsync(id, includeDocuments);
            if (customer == null)
            {
                throw new NotFoundException();
            }
            return _mapper.Map<CustomerDTO>(customer);
        }
        public async Task<bool> CustomerExists(long cityId)
        {
            return await _customerInfoRepository.CustomerExistsAsync(cityId);
        }
    }
}
