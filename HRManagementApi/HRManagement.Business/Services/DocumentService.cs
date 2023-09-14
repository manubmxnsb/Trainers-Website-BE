using AutoMapper;
using HRManagement.DataAccess.Exceptions;
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
       
       
    }
}
