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

        public async Task AddNewCustomerAsync(Customer newCustomer)
        {
            var customersAdded = await _context.Customers.AddAsync(newCustomer);
            await _context.SaveChangesAsync();
        }

        public async Task<Customer?> GetCustomerAsync(long customerId)
        {
            var customer = await _context.Customers.Include(customer => customer.Documents)
                .FirstOrDefaultAsync(customer => customer.Id == customerId);
            return customer == null ? throw new NotFoundException() : customer;
        }
    }
}
