using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Entities;
using HRManagement.DataAccess.Repositories;
using Microsoft.IdentityModel.Tokens;

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

        public async Task DeleteDocuments(long[] documentsId)
        {
            foreach (var doc in documentsId)
            {
                await _documentRepository.DeleteDocumentsAsync(doc);
            }
        }

        public async Task AddDocuments(long customerId, List<DocumentDto> document)
        {
            var mappedDocuments = _mapper.Map<List<Document>>(document);
            if (mappedDocuments.IsNullOrEmpty()) 
            {
                throw new ArgumentException("No documents mapped!");
            } 
            await _documentRepository.AddDocuments(customerId, mappedDocuments);
        }
    }
}
