using AutoMapper;
using HRManagement.Business.Exceptions;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Repositories;

namespace HRManagement.Business.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IDocumentRepository _documentRepository;
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;

        public DocumentService(IDocumentRepository documentRepository, IMapper mapper, ICustomerService customerService)
        {
            _documentRepository = documentRepository ?? throw new ArgumentNullException(nameof(documentRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }
    }
}
