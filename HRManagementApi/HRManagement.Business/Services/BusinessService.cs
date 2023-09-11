using HRManagement.Business.Models;
using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Repositories;
using HRManagement.DataAccess.Services;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Business.Services
{
    public class BusinessService : IBusinessService
    {
        private readonly IDBRepository _dataRepository;

        public BusinessService(IDBRepository dataService)
        {
            _dataRepository = dataService ?? throw new ArgumentNullException(nameof(dataService));
        }

        public async Task DeleteCustomer(CustomersForDeletionDto customerIdsDto)
        {
           await _dataRepository.Delete(customerIdsDto.Ids);
        }

    }
}
