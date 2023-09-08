using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Repositories;

namespace HRManagement.DataAccess.Services
{
    public interface IDBRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomersAsync(
            int pageNumber, int pageSize);
    }
}
