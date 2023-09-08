using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.DataAccess.Services
{
    public class DBRepository: IDBRepository
    {
        private readonly HRManagementDBContext _context;

        public DBRepository(HRManagementDBContext context)
        {
            _context = context ?? 
                throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<Customer>> GetAllCustomersAsync(int pageNumber, int pageSize)
        {
            
            var allCustomers = _context.Customers;
            var totalItemCount = await allCustomers.CountAsync();
            var customerTablePagination = new CustomerTablePagination(
                totalItemCount, pageSize, pageNumber);
            var allCostomersToReturn = await allCustomers.Skip(pageSize*(pageNumber-1))
                .Take(pageSize)
                .ToListAsync();
            return allCostomersToReturn;
        }
    }
}
