namespace HRManagement.DataAccess.IRepositories
{
    public interface IDocumentRepository
    {
        Task DeleteDocumentsAsync(long documentId);
    }
}
