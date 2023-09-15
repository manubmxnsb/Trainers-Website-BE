using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.DataAccess.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly HRManagementDBContext _context;

        public CustomerRepository(HRManagementDBContext context)
        {
            _context = context ?? 
                throw new ArgumentNullException(nameof(context));
        }

        public async Task<bool> CustomerExistsAsync(long customerId)
        {
            return await _context.Customers.AnyAsync(customer => customer.Id == customerId);
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync(int pageNumber, int pageSize)
        {
            var allCustomers = await _context.Customers.Skip(pageSize * (pageNumber - 1))
                .Take(pageSize)
                .ToListAsync();
            return allCustomers;
        }
        public async Task<Customer?> GetCustomerAsync(long customerId)
        {
            return await _context.Customers
                .Where(customer => customer.Id == customerId).FirstOrDefaultAsync();
        }



    }
}
