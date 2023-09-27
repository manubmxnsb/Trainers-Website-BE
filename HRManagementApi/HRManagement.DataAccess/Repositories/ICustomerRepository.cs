using HRManagement.DataAccess.Entities;

namespace HRManagement.DataAccess.Repositories
{
    public interface ICustomerRepository
    {
        Task EditCustomer(Customer customer);

        Task<Customer?> GetCustomerAsync(long customerId);

        Task DeleteCustomers(List<long> customerIds);

        Task AddNewCustomerAsync(Customer newCustomer);
    }
}