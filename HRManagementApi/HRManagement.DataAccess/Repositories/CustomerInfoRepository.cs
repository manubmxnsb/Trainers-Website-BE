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
    public class CustomerInfoRepository : ICustomerInfoRepository
    {
        private readonly HRManagementDBContext _context;

        public CustomerInfoRepository(HRManagementDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<bool> CustomerExistsAsync(long customerId)
        {
            return await _context.Customers.AnyAsync(customer => customer.Id == customerId);
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

        public async Task<IEnumerable<Document>> GetDocumentForCustomerAsync(long customerId)
        {
            return await _context.Documents
                .Where(p => p.CustomerId == customerId).ToListAsync();
        }

        public async Task<Document> GetDocumentForCustomerAsync(long customerId, long documentId)
        {
            return await _context.Documents
                .Where(p => p.CustomerId == customerId && p.Id == documentId)
                .FirstOrDefaultAsync();
        }

        public Task<IEnumerable<Document>> GetDocumentsForCustomerAsync(long customerId)
        {
            throw new NotImplementedException();
        }
    }
}
