using HRManagement.Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IBusinessLayer _documentService;

        public DocumentController(IBusinessLayer documentService)
        {
            _documentService = documentService ?? throw new ArgumentNullException(nameof(documentService));
        }

        [HttpDelete("/{customerId}/documentsDelete")]
        public async Task<ActionResult> DeleteDocumentsOnEdit(long customerId, long[] documentsId)
        {
            await _documentService.DeleteDocuments(customerId, documentsId);
            return Ok();
        }
    }
}
