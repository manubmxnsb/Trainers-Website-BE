using HRManagement.Business.Models;

namespace HRManagement.Business.Services
{
    public interface ICustomerService
    {
        public Task EditCustomer(CustomerDto customerToUpdate);

        Task<CustomerDto> GetCustomer(long id);

        Task<bool> CustomerExists(long cityId);
    }
}
