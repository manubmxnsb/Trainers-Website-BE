using HRManagement.DataAccess.Entities;

namespace HRManagement.DataAccess.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer?> GetCustomerAsync(long customerId);

        Task<bool> CustomerExistsAsync(long cityId);

        Task<IEnumerable<Customer>> GetAllCustomersAsync(
            int pageNumber, int pageSize);
    }
}
