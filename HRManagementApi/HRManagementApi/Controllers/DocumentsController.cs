using HRManagement.Business.IServices;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private readonly IDocumentService _documentService;

        public DocumentsController(IDocumentService documentService)
        {
            _documentService = documentService ?? throw new ArgumentNullException(nameof(documentService));
        }

        [HttpDelete("/{customerId}/documentsDelete")]
        public async Task<ActionResult> DeleteDocumentsOnEdit(long[] documentsId)
        {
            await _documentService.DeleteDocuments(documentsId);
            return Ok();
        }
    }
}
