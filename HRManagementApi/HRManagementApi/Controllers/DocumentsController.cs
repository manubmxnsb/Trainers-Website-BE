
using HRManagement.Business.Models;
using HRManagement.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementApi.Controllers
{
    [Route("api/Documents")]
    [ApiController]
    public class DocumentsController : Controller
    {
        private readonly IDocumentService _documentService;

        public DocumentsController(IDocumentService documentService)
        {
            _documentService = documentService ?? throw new ArgumentNullException(nameof(documentService));
        }

        [HttpDelete("Delete/{documentId}")]
        public async Task<ActionResult> DeleteDocumentOnEdit(long documentId)
        {
            await _documentService.DeleteDocument(documentId);
            return Ok();
        }
    }
}
