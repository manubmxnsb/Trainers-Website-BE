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

        public void DeleteCustomer(long customerId)
        {

            _dataRepository.Delete(customerId);
        }

    }
}
