using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;

namespace HRManagement.Business.Interface
{
    public interface IDBService
    {

        public Task<Customer> EditCustomer(Customer customerToUpdate);

        Task<CustomerDto> GetCustomer(long id, bool includeDocuments);

    }
}
