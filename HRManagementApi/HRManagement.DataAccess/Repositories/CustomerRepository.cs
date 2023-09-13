using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.DataAccess.Services
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly HRManagementDBContext _context;

        public CustomerRepository(HRManagementDBContext context)
        {
            _context = context ?? 
                throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<Customer>> GetAllCustomersAsync(int pageNumber, int pageSize)
        {
            
            var allCustomers = _context.Customers;
            var allCostomersToReturn = await allCustomers.Skip(pageSize*(pageNumber-1))
                .Take(pageSize)
                .ToListAsync();
            return allCostomersToReturn;
        }
    }
}
