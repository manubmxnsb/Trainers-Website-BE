using HRManagement.DataAccess.Entities;

namespace HRManagement.DataAccess.Repositories
{
    public interface IDocumentRepository
    {
        Task<IEnumerable<Document>> GetDocumentsForCustomerAsync(long customerId);
        Task<Document>? GetDocumentForCustomerAsync(long customerId, long documentId);
    }
}
