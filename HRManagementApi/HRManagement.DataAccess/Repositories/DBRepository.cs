using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.DataAccess.Repositories
{
    public class DBRepository : IDBRepository
    {
        private readonly HRManagementDBContext _context;

        public DBRepository(HRManagementDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Customer?> GetCustomerAsync(long customerId, bool includeDocuments)
        {
            if (includeDocuments)
            {
                return await _context.Customers.Include(customer => customer.Documents)
                    .Where(customer => customer.Id == customerId).FirstOrDefaultAsync();
            }
            return await _context.Customers
                .Where(customer => customer.Id == customerId).FirstOrDefaultAsync();
        }


        public async Task<bool> CustomerExistsAsync(long customerId)
        {
            return await _context.Customers.AnyAsync(c => c.Id == customerId);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
        
    }
}
