using HRManagement.Business.Models;

namespace HRManagement.Business.Services
{
    public interface IDocumentService
    {
        Task<IEnumerable<DocumentDTO>> GetDocuments(long customerId);
        Task<DocumentDTO> GetDocument(long customerId, long documentId);
    }
}
