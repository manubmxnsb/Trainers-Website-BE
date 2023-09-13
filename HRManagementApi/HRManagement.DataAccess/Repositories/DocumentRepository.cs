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

        public async Task AddNewDocumentFromEditAsync(long customerId, Document newDocument)
        {
            if (newDocument != null)
            {
                var customer = await _context.Customers.Where(c => c.Id == customerId).FirstAsync();
                if (customer != null)
                {
                    newDocument.CustomerId = customerId;
                    var documentToBeAdded = await _context.Documents.AddAsync(newDocument);
                    await _context.SaveChangesAsync();

                }
                else
                {
                    throw new InvalidOperationException("No customer was found");
                }
            }
            else
            {
                throw new InvalidOperationException("No document was found");
            }
        }
    }
}
