using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
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
        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await _context.Customers.ToListAsync();
            //mapare intre business si data access, sa fie global createMap
        }
    }
}
