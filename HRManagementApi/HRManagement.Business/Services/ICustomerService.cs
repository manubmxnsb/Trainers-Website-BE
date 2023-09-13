using HRManagement.Business.Models;

namespace HRManagement.Business.Interface
{
    public interface ICustomerService
    {
       Task<IEnumerable<CustomerSummaryDto>> GetAllCustomers(int pageNumber, int pageSize);
    }
}
