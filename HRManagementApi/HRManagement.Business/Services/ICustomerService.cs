using HRManagement.Business.Models;

namespace HRManagement.Business.Services
{
    public interface ICustomerService
    {
        Task AddNewCustomer(CustomerDto customer);
        Task<CustomerDto> GetCustomer(long id);
        Task<bool> CustomerExists(long cityId);
        Task DeleteCustomers(List<long> customerIds);
    }
}
