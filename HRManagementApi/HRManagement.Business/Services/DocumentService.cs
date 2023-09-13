using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Repositories;

namespace HRManagement.Business.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IDocumentRepository _documentRepository;
        private readonly IMapper _mapper;

        public DocumentService(IDocumentRepository documentRepository, IMapper mapper)
        {
            _documentRepository = documentRepository ?? throw new ArgumentNullException(nameof(documentRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<IEnumerable<DocumentDto>> GetDocuments(long customerId)
        {
            if (!await _customerService.CustomerExists(customerId))
            {
                throw new NotFoundException();
            }
            var documentsForCustomer = await _documentRepository.GetDocumentsForCustomerAsync(customerId);
            return _mapper.Map<IEnumerable<DocumentDto>>(documentsForCustomer);
        }
        public async Task<DocumentDto> GetDocument(long customerId, long documentId)
        {
            var document = await _documentRepository.GetDocumentForCustomerAsync(customerId, documentId);
            if ((!await _customerService.CustomerExists(customerId)) || (document == null))
            {
                throw new NotFoundException();
            }
            return _mapper.Map<DocumentDto>(document);
        }
    }
}
