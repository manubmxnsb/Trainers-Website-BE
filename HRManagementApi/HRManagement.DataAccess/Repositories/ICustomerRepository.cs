using HRManagement.DataAccess.Entities;

namespace HRManagement.DataAccess.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer?> GetCustomerAsync(long customerId, bool includeDocuments);
        Task<bool> CustomerExistsAsync(long cityId);
    }
}
