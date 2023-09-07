using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Repositories;
using HRManagement.DataAccess.Services;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.Business.Interface
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IDBRepository _dataService;

        public BusinessLayer(IDBRepository dataService)
        {
            _dataService = dataService ?? throw new ArgumentNullException(nameof(dataService));
        }

        public  void DeleteCustomer(long customerId)
        {

            _dataService.Delete(customerId);
        }

    }
}
