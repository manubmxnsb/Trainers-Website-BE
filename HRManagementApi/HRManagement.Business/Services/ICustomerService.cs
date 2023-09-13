
using HRManagement.Business.Models;

namespace HRManagement.Business.Services
{
    public interface ICustomerService
    {
        Task<CustomerDto> GetCustomer(long id, bool includeDocuments = false);
        Task<bool> CustomerExists(long cityId);
    }
}
