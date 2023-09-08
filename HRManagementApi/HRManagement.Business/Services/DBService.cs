using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Repositories;
using HRManagement.DataAccess.Services;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Business.Interface
{
    public class DBService : IDBService
    {
        private readonly IDBRepository _repository;
        private readonly IMapper _mapper;

        public DBService(IDBRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<Customer> EditCustomer(Customer customerToUpdate)
        {
            var customer = await _repository.EditCustomer(customerToUpdate);
            return customer;
        }

        public async Task<CustomerDto> GetCustomer(long id, bool includeDocuments)
        {
            var customer = await _repository.GetCustomerAsync(id, includeDocuments);
            return (_mapper.Map<CustomerDto>(customer));
        }
    }
}
