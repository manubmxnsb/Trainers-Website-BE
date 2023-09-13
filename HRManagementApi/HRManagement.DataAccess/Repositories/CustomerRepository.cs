using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.DataAccess.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly HRManagementDBContext _context;

        public CustomerRepository(HRManagementDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<bool> CustomerExistsAsync(long customerId)
        {
        return await _context.Customers.AnyAsync(customer => customer.Id == customerId);
        }

        public async Task<Customer?> GetCustomerAsync(long customerId)
        {
            return await _context.Customers
                .Where(customer => customer.Id == customerId).FirstOrDefaultAsync();
        }
        public async Task<Customer?> GetCustomerAsync(long customerId)
        {
            return await _context.Customers
                .Where(customer => customer.Id == customerId).FirstOrDefaultAsync();
        }
        public async Task Delete(List<long> customerIds)
        {
            var customers = await _context.Customers.Where(c => customerIds.Contains(c.Id)).ToListAsync();
            if (customers.Any())
            {
                _context.Customers.RemoveRange(customers);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("No customers present in the list!");
            }


        }
}
}
