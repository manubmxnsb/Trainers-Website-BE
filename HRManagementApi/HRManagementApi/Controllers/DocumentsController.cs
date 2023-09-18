
using HRManagement.Business.Models;
using HRManagement.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementApi.Controllers
{
    [Route("api/customers/{customerId}/documents")]
    [ApiController]
    public class DocumentsController : Controller
    {
        private readonly IDocumentService _documentService;

        public DocumentsController(IDocumentService documentService)
        {
            _documentService = documentService ?? throw new ArgumentNullException(nameof(documentService));
        }

        [HttpDelete("/{customerId}/documentsDelete")]
        public async Task<ActionResult> DeleteDocumentsOnEdit(long documentsId)
        {
            await _documentService.DeleteDocuments(documentsId);
            return Ok();
        }
    }
}
