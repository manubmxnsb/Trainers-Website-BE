using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.DataAccess.Repositories
{
    public class DBRepository : IDBRepository
    {
        private readonly HRManagementDBContext _context;

        public DBRepository(HRManagementDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddNewCustomerAsync(Customer newCustomer)
        {
            var customersAdded = await _context.Customers.AddAsync(newCustomer);
            await _context.SaveChangesAsync();
        }

        public async Task<Document>? GetDocumentForCustomerAsync(long customerId, long documentId)
        {
            return await _context.Documents
                .Where(p => p.CustomerId == customerId && p.Id == documentId)
                .FirstOrDefaultAsync();
        }

        public async Task DeleteDocumentsAsync(long documentId) 
        {
            var documentToBeDeleted = await _context.Documents.Where(c => c.Id == documentId).FirstOrDefaultAsync();
            if (documentToBeDeleted != null)
            {
                _context.Documents.Remove(documentToBeDeleted);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException($"No Customer with customer Id: {documentId} was found!");
            }
        }
    }
}
