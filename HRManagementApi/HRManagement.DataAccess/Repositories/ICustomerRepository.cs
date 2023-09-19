using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Models;

namespace HRManagement.DataAccess.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer?> GetCustomerAsync(long customerId);

        Task<bool> CustomerExistsAsync(long cityId);

        Task<IEnumerable<Customer>> GetAllCustomersAsync(
            PaginationItems paginationItems);
    }
}
