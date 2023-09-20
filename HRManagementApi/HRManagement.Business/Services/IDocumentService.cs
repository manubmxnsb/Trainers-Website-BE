using HRManagement.Business.Models;

namespace HRManagement.Business.Services
{
    public interface IDocumentService
    {
        Task DeleteDocument(long documentId);
    }
}
