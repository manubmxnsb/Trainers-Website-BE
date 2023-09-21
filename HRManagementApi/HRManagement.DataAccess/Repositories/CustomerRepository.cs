using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Exceptions;
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

        public async Task EditCustomer(Customer customerToUpdate)
        {
            if (!await _context.Customers.AnyAsync(c => c.Id == customerToUpdate.Id))
            {
                throw new NotFoundException();
            }

            _context.Customers.Update(customerToUpdate);
            await _context.SaveChangesAsync();

        }

        public async Task<bool> CustomerExistsAsync(long customerId)
        {
            return await _context.Customers.AnyAsync(customer => customer.Id == customerId);
        }

        public async Task<Customer?> GetCustomerAsync(long customerId)
        {
            var customer = await _context.Customers.Include(customer => customer.Documents)
                .FirstOrDefaultAsync(customer => customer.Id == customerId);
            return customer == null ? throw new NotFoundException() : customer;
        }

        public async Task DeleteCustomers(List<long> customerIds)
        {
            var customers = await _context.Customers.Where(c => customerIds.Contains(c.Id)).ToListAsync();
            _context.Customers.RemoveRange(customers);
            await _context.SaveChangesAsync();
        }
    }
}
