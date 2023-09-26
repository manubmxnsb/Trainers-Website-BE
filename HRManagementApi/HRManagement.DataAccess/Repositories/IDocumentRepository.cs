using HRManagement.DataAccess.Entities;

namespace HRManagement.DataAccess.Repositories
{
    public interface IDocumentRepository
    {
        Task DeleteDocumentAsync(long documentId);
    }
}