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
            {
                throw new Exception("customer doesn't exist");
            }

            Customer customer = await _context.Customers
                 .Where(customer => customer.Id == customerToUpdate.Id).FirstOrDefaultAsync();
        
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();

        }

        
    }
}
