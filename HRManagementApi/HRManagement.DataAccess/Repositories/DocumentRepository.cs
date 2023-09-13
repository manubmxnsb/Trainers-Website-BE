using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.DataAccess.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly HRManagementDBContext _context;

        public DocumentRepository(HRManagementDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<Document>> GetDocumentsForCustomerAsync(long customerId)
        {
            return await _context.Documents
                .Where(p => p.CustomerId == customerId).ToListAsync();
        }

        public async Task<Document>? GetDocumentForCustomerAsync(long customerId, long documentId)
        {
            return await _context.Documents
                .Where(p => p.CustomerId == customerId && p.Id == documentId)
                .FirstOrDefaultAsync();
        }
    }
}
