using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Exceptions;
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
            return allCustomers.Any() ? allCustomers : throw new NotFoundException();   
        }

        public async Task<Customer?> GetCustomerAsync(long customerId)
        {
            var customer = await _context.Customers.Include(customer => customer.Documents)
                .FirstOrDefaultAsync(customer => customer.Id == customerId);
            return customer == null ? throw new NotFoundException() : customer;
        }
    }
}
