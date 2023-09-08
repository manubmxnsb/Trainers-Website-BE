using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Services;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Business.Interface
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly DBRepository _dataRepository;

        public BusinessLayer(DBRepository dataRepository)
        {
            _dataRepository = dataRepository ?? throw new ArgumentNullException(nameof(dataRepository));
        }

        public async Task AddNewCustomer()
        {
            await _dataRepository.AddNewCustomerAsync(new Customer());
        }
    }
}
