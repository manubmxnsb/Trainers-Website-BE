using HRManagement.Business.Models;

namespace HRManagement.Business.Services
{
    public interface IDocumentService
    {
        Task<IEnumerable<DocumentDto>> GetDocuments(long customerId);
        Task<DocumentDto> GetDocument(long customerId, long documentId);
    }
}
