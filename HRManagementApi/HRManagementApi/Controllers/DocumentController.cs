using AutoMapper;
using HRManagement.Business.Models;
using HRManagement.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementApi.Controllers
{
    [Route("api/customers/{customerId}/documents")]
    [ApiController]
    public class DocumentController : Controller
    {
        private readonly ICustomerInfoRepository _customerInfoRepository;
        private readonly IMapper _mapper;

        public DocumentController(ICustomerInfoRepository customerInfoRepository, IMapper mapper)
        {
            _customerInfoRepository = customerInfoRepository ?? throw new ArgumentNullException(nameof(customerInfoRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DocumentDTO>>> GetDocuments(long customerId)
        {
            if (!await _customerInfoRepository.CustomerExistsAsync(customerId))
            {
                return NotFound();
            }
            var documentsForCustomer = await _customerInfoRepository.GetDocumentsForCustomerAsync(customerId);
            return Ok(_mapper.Map<IEnumerable<DocumentDTO>>(documentsForCustomer));
        }
        [HttpGet("{documentId}", Name = "GetDocument")]
        public async Task<ActionResult<DocumentDTO>> GetDocument(long customerId, long documentId)
        {
            if (!await _customerInfoRepository.CustomerExistsAsync(customerId))
            {
                return NotFound();
            }
            var document = await _customerInfoRepository.GetDocumentForCustomerAsync(customerId, documentId);
            if (document == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<DocumentDTO>(document));
        }
    }
}
