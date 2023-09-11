using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;

namespace HRManagement.Business.Interface
{
    public interface IDBService
    {

        public Task EditCustomer(long id, CustomerForEditDto customerToUpdate);

        public Task<bool> CustomerExistsAsync(long id);

        public Task<bool> SaveChangesAsync();

        //Task<CustomerDto> GetCustomer(long id, bool includeDocuments);

    }
}
