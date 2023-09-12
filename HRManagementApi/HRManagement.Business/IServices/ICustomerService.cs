using HRManagement.Business.Models;

namespace HRManagement.Business.IServices
{
    public interface ICustomerService
    {
        Task AddNewCustomer(CustomerDto customer);
    }
}