using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Exceptions;
using HRManagement.DataAccess.Models;
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

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync(PaginationItems paginationItems)
        {
            var allCustomers = await _context.Customers.OrderBy(c => c.Name)
                .Skip(paginationItems.PageSize * (paginationItems.PageNumber - 1))
                .Take(paginationItems.PageSize)
                .ToListAsync();

            if (paginationItems.CustomerStatus != null)
            {
                allCustomers = allCustomers.Where(c => c.IsActive == paginationItems.CustomerStatus).ToList();
            }

            if (paginationItems.Search != null)
            {
                allCustomers = allCustomers.Where(c => c.Name.Contains(paginationItems.Search)).ToList();
            }

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
