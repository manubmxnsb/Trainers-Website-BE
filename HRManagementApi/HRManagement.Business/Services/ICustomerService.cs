using HRManagement.Business.Models;
using HRManagement.DataAccess.Models;

namespace HRManagement.Business.Services
{
    public interface ICustomerService
    {
        Task<CustomerDto> GetCustomer(long id);

        Task<bool> CustomerExists(long cityId);

        Task<IEnumerable<CustomerSummaryDto>> GetAllCustomers(PaginationItems paginationItems);
    }
}
