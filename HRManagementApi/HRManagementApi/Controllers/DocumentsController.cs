using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.Business.Services;
using HRManagement.DataAccess.Repositories;
using HRManagementApi.Middleware;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementApi.Controllers
{
    [Route("api/customers/{customerId}/documents")]
    [ApiController]
    public class DocumentsController : Controller
    {
        private readonly IDocumentService _documentService;
        private readonly ICustomerService _customerService;

        public DocumentsController(IDocumentService documentService, ICustomerService customerService)
        {
            _documentService = documentService ?? throw new ArgumentNullException(nameof(documentService));
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocumentDTO>>> GetDocuments(long customerId)
        {

            var documentsForCustomer = await _documentService.GetDocuments(customerId);
            return Ok(documentsForCustomer);
        }
        [HttpGet("{documentId}", Name = "GetDocument")]
        public async Task<ActionResult<DocumentDTO>> GetDocument(long customerId, long documentId)
        {
            var document = await _documentService.GetDocument(customerId, documentId);
            return Ok(document);
        }
    }
}
