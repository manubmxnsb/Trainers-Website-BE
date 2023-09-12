namespace HRManagement.Business.IServices
{
    public interface IDocumentService
    {
        Task DeleteDocuments(long[] documentsId);
    }
}
