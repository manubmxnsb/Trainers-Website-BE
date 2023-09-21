using HRManagement.DataAccess.Entities;

namespace HRManagement.DataAccess.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer?> GetCustomerAsync(long customerId);
        Task DeleteCustomers(List<long> customerIds);
        Task AddNewCustomerAsync(Customer newCustomer);
    }
}