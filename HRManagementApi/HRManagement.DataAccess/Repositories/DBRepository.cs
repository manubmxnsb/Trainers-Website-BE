using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;

namespace HRManagement.DataAccess.Services
{
    public class DBRepository : IDBRepository
    {
        private readonly HRManagementDBContext _context;

        public DBRepository(HRManagementDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddNewCustomerAsync(Customer newCustomer)
        {
            await _context.Customers.AddAsync(newCustomer);
        }
    }
}
