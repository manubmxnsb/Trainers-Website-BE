using HRManagement.Business.Models;

namespace HRManagement.Business.Services
{
    public interface IDocumentService
    {
        Task DeleteDocuments(long[] documentsId);
        Task AddNewDocumentFromEdit(long customerId, DocumentDto document);
    }
}
