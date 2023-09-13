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

            customer.Id = customerToUpdate.Id;
            customer.Name = customerToUpdate.Name;
            customer.Email = customerToUpdate.Email;
            customer.Address = customerToUpdate.Address;
            customer.PhoneNumber = customerToUpdate.PhoneNumber;
            customer.Country = customerToUpdate.Country;
            customer.VAT = customerToUpdate.VAT;
            customer.BillingType = customerToUpdate.BillingType;
            customer.Details = customerToUpdate.Details;
            customer.IsActive = customerToUpdate.IsActive;
            customer.DateCreated = customerToUpdate.DateCreated;
            customer.Documents = customer.Documents;
        
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();

        }

        
    }
}
