using HRManagement.Business.Models;

namespace HRManagement.Business.Services
{
    public interface IDocumentService
    {
        Task DeleteDocuments(long[] documentsId);
        Task AddDocuments(long customerId, List<DocumentDto> documents);
    }
}
