using HRManagement.DataAccess.Entities;

namespace HRManagement.DataAccess.Repositories
{
    public interface ICustomerRepository
    {
        Task AddNewCustomerAsync(Customer newCustomer);
        Task<Customer?> GetCustomerAsync(long customerId);
    }
}
