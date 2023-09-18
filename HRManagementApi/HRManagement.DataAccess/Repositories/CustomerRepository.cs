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

        public async Task AddNewCustomerAsync(Customer newCustomer)
        {
            var customersAdded = await _context.Customers.AddAsync(newCustomer);
            await _context.SaveChangesAsync();
        }

        public async Task<Customer?> GetCustomerAsync(long customerId)
        {
            return await _context.Customers
                .Where(customer => customer.Id == customerId).FirstOrDefaultAsync();
        }

    }
}
