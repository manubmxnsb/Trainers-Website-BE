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

     
        public async Task EditCustomer(Customer customerToUpdate)
        {
            if (!await _context.Customers.AnyAsync(c => c.Id == customerToUpdate.Id))
        public async Task<bool> CustomerExistsAsync(long customerId)
        {
            return await _context.Customers.AnyAsync(customer => customer.Id == customerId);
                throw new Exception("customer doesn't exist");
        }

            Customer customer = await _context.Customers
                 .Where(customer => customer.Id == customerToUpdate.Id).FirstOrDefaultAsync();
        
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();

        public async Task<Customer?> GetCustomerAsync(long customerId)
        {
            return await _context.Customers
                .Where(customer => customer.Id == customerId).FirstOrDefaultAsync();
        }



    }
}
