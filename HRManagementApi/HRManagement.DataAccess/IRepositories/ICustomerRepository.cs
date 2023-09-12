using HRManagement.DataAccess.Entities;

namespace HRManagement.DataAccess.IRepositories
{
    public interface ICustomerRepository
    {
        Task AddNewCustomerAsync(Customer newCustomer);
    }
}