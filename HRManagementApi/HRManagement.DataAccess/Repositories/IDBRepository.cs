using HRManagement.DataAccess.Entities;

namespace HRManagement.DataAccess.Services
{
    public interface IDBRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomersAsync();
    }
}
