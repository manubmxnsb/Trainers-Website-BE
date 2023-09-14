using HRManagement.DataAccess.DbContexts;
using HRManagement.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRManagement.DataAccess.Repositories
{
    public class DocumentRepository :IDocumentRepository
    {
        private readonly HRManagementDBContext _context;

        public DocumentRepository(HRManagementDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
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

        public async Task AddDocuments(long customerId, List<Document> newDocuments)
        {
            var customer = await _context.Customers.Where(c => c.Id == customerId).FirstOrDefaultAsync();
            if (customer != null)
            {
                foreach (var document in newDocuments)
                {
                    document.CustomerId = customerId;
                }
                await _context.Documents.AddRangeAsync(newDocuments);
                await _context.SaveChangesAsync();

            }
            else
            {
                throw new InvalidOperationException("No customer was found");
            }
        }
    }
}
