using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.Business.Services;
using HRManagementApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly IDocumentService _documentService;
        private readonly IMapper _mapper;

        public DocumentsController(IDocumentService documentService, IMapper mapper)
        {
            _documentService = documentService ?? throw new ArgumentNullException(nameof(documentService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpDelete("/{customerId}/documentsDelete")]
        public async Task<ActionResult> DeleteDocumentsOnEdit(long[] documentsId)
        {
            await _documentService.DeleteDocuments(documentsId);
            return Ok();
        }
        [HttpPost("/{customerId}/documentAdd")]
        public async Task<ActionResult> AddDocumentFromEdit(long customerId, DocumentModel document)
        {
            var mappedDocumentApi = _mapper.Map<DocumentDto>(document);
            if (mappedDocumentApi == null)
            {
                return NotFound();
            }
            await _documentService.AddNewDocumentFromEdit(customerId, mappedDocumentApi);
            return Ok();
        }
    }
}
