using HRManagement.DataAccess.Entities;

namespace HRManagement.DataAccess.Repositories
{
    public interface IDBRepository
    {
        Task AddNewCustomerAsync(Customer newCustomer);
    }
}
