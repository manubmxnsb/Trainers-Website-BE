using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.Business.Services;
using HRManagementApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

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
        public async Task<ActionResult> AddDocumentFromEdit(long customerId, List<DocumentModel> document)
        {
            var mappedDocuments = _mapper.Map<List<DocumentDto>>(document);
            if (mappedDocuments.IsNullOrEmpty())
            {
                return NotFound();
            }
            await _documentService.AddDocuments(customerId, mappedDocuments);
            return Ok();
        }
    }
}
