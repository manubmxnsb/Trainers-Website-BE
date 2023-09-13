using HRManagement.DataAccess.Entities;

namespace HRManagement.DataAccess.Services
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomersAsync(
            int pageNumber, int pageSize);
    }
}
