using HRManagement.Business.Models;

namespace HRManagement.Business.Services
{
    public interface ICustomerService
    {
        Task<CustomerDto> GetCustomer(long id);

        Task<bool> CustomerExists(long cityId);

        Task<IEnumerable<CustomerSummaryDto>> GetAllCustomers(PaginationItemsDto paginationItems);

        Task DeleteCustomers(List<long> customerIds);
    }
}
