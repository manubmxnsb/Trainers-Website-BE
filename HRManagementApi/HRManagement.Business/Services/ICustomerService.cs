using HRManagement.Business.Models;

namespace HRManagement.Business.Services
{
    public interface ICustomerService
    {
        Task AddNewCustomer(CustomerDto customer);
    }
}