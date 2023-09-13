using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Repositories;

namespace HRManagement.Business.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly ICustomerInfoRepository _customerInfoRepository;
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;

        public DocumentService(ICustomerInfoRepository customerInfoRepository, IMapper mapper, ICustomerService customerService)
        {
            _customerInfoRepository = customerInfoRepository ?? throw new ArgumentNullException(nameof(customerInfoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }
        public async Task<IEnumerable<DocumentDTO>> GetDocuments(long customerId)
        {
            if (!await _customerService.CustomerExists(customerId))
            {
                throw new NotFoundException();
            }
            var documentsForCustomer = await _customerInfoRepository.GetDocumentsForCustomerAsync(customerId);
            return _mapper.Map<IEnumerable<DocumentDTO>>(documentsForCustomer);
        }
        public async Task<DocumentDTO> GetDocument(long customerId, long documentId)
        {
            var document = await _customerInfoRepository.GetDocumentForCustomerAsync(customerId, documentId);
            if ((!await _customerService.CustomerExists(customerId)) || (document == null))
            {
                throw new NotFoundException();
            }
            return _mapper.Map<DocumentDTO>(document);
        }
    }
}
