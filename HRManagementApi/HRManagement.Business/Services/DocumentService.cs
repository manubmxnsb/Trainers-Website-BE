using HRManagement.Business.IServices;
using HRManagement.DataAccess.IRepositories;

namespace HRManagement.Business.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IDocumentRepository _documentRepository;

        public DocumentService(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository ?? throw new ArgumentNullException(nameof(documentRepository));
        }

        public async Task DeleteDocuments(long[] documentsId)
        {
            foreach (var doc in documentsId)
            {
                await _documentRepository.DeleteDocumentsAsync(doc);
            }
        }
    }
}
