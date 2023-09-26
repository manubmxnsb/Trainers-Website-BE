using HRManagement.Business.Models;

namespace HRManagement.Business.Services
{
    public interface ICustomerService
    {
        Task<CustomerDto> GetCustomer(long id);

        Task DeleteCustomers(List<long> customerIds);

        Task AddNewCustomer(CustomerDto customer);
    }
}
