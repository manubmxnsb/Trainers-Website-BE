using HRManagement.DataAccess.Repositories;

namespace HRManagement.Business.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IDocumentRepository _documentRepository;

        public DocumentService(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository ?? throw new ArgumentNullException(nameof(documentRepository));
        }

        public async Task DeleteDocuments(long documentsId)
        {
            await _documentRepository.DeleteDocumentsAsync(documentsId);
        }
    }
}
