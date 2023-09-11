using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Repositories;
using HRManagement.DataAccess.Services;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

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

        public async Task EditCustomer(long id, CustomerForEditDto customerToUpdate)
        {

            Customer customer = await _repository.GetCustomerAsync(id, false);

            if (customer == null)
            {
                throw new Exception("customer doesn't exist");
            }

            customer.Name = customerToUpdate.Name;
            customer.Email = customerToUpdate.Email;
            customer.Address = customerToUpdate.Address;
            customer.PhoneNumber = customerToUpdate.PhoneNumber;
            customer.Country = customerToUpdate.Country;
            customer.VAT = customerToUpdate.VAT;
            customer.BillingType = customerToUpdate.BillingType;
            customer.Details = customerToUpdate.Details;
            customer.IsActive = customerToUpdate.IsActive;
            customer.DateCreated = customerToUpdate.DateCreated;

            //var customerEdit = _mapper.Map<Customer>(customerToUpdate);
            _repository.EditCustomer(customer);
                
        }

        public Task<bool> CustomerExistsAsync(long id)
        {
            return _repository.CustomerExistsAsync(id);
        }

        public async Task<bool> SaveChangesAsync()
        {
            var changes = await _repository.SaveChangesAsync();
            return changes;
        }
    }
}
